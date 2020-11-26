using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;

namespace OutlookAddIn_OneClickSave
{
    [ComVisible(true)]
    public class Ribbon : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        public Ribbon()
        {
        }

        #region IRibbonExtensibility のメンバー

        public string GetCustomUI(string ribbonID)
        {
            string ribbonXML = String.Empty;

            //メール一覧画面のみ、アドインを表示する。
            if (ribbonID == "Microsoft.Outlook.Explorer")
            {
                return GetResourceText("OutlookAddIn_OneClickSave.Ribbon.xml");
            }

            return ribbonXML;
        }

        #endregion

        #region リボンのコールバック
        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }

        public void OnSaveButton(Office.IRibbonControl control)
        {
            //保存ボタン押下時の処理

            //設定読み込み
            Properties.Settings.Default.Reload();

            //保存先フォルダが存在する場合のみ処理
            if (Directory.Exists(Properties.Settings.Default.SaveDir) == true) {
                //選択しているメールの取得
                var explorer = Globals.ThisAddIn.Application.ActiveExplorer();
                foreach (var item in explorer.Selection)
                {
                    //選択数分処理
                    if (item is Outlook.MailItem)
                    {
                        //保存対象のMailItemを取得
                        var selectMailItem = item as Outlook.MailItem;

                        if (Properties.Settings.Default.IsSeparateAttachments == true)
                        {
                            //添付ファイルを分離する設定の場合

                            //添付ファイルを保存
                            foreach (var attachment in selectMailItem.Attachments.Cast<Outlook.Attachment>())
                            {
                                //添付ファイルの保存先パスを作成
                                string attachmentSavePath = Path.Combine(Properties.Settings.Default.SaveDir, attachment.FileName);

                                //添付ファイルを保存
                                attachment.SaveAsFile(attachmentSavePath);
                            }

                            //件名からファイル名を作成
                            string filename = selectMailItem.Subject + ".txt";
                            filename = string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));

                            //メールの保存先パスを作成
                            string mailSavePath = Path.Combine(Properties.Settings.Default.SaveDir, filename);

                            //MailItemをTXT形式で保存
                            selectMailItem.SaveAs(mailSavePath, Outlook.OlSaveAsType.olTXT);
                        }
                        else
                        {
                            //添付ファイルを分離しない設定の場合

                            //件名からファイル名を作成
                            string filename = selectMailItem.Subject + ".msg";
                            filename = string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));

                            //メールの保存先パスを作成
                            string mailSavePath = Path.Combine(Properties.Settings.Default.SaveDir, filename);

                            //MailItemをそのまま保存
                            selectMailItem.SaveAs(mailSavePath);
                        }
                    }
                }
                MessageBox.Show("選択されたメールを保存しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // 保存先フォルダが存在しない場合はエラーを表示
                MessageBox.Show("保存先フォルダが存在しません。設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OnSettingButton(Office.IRibbonControl control)
        {
            //設定ボタン押下時の処理
            
            //設定が終わらないと保存操作をさせないように、モーダルで表示する。
            SettingForm form = new SettingForm();
            form.ShowDialog();
        }

        #endregion

        #region ヘルパー

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion
    }
}
