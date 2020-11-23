using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookAddIn_OneClickSave
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();

            //保存先フォルダテキストボックスへのDrag&Dropを許可
            textBoxSaveDir.AllowDrop = true;

            //設定読み込み
            Properties.Settings.Default.Reload();
            textBoxSaveDir.Text = Properties.Settings.Default.SaveDir;
            checkBoxIsSeparateAttachments.Checked = Properties.Settings.Default.IsSeparateAttachments;
        }

        private void buttonSaveSetting_Click(object sender, EventArgs e)
        {
            //設定保存ボタン押下時の処理
            //設定書き込み
            Properties.Settings.Default.SaveDir = textBoxSaveDir.Text;
            Properties.Settings.Default.IsSeparateAttachments = checkBoxIsSeparateAttachments.Checked;
            Properties.Settings.Default.Save();
            
            //設定画面を閉じる
            this.Close();
        }

        private void buttonSelectSaveDir_Click(object sender, EventArgs e)
        {
            //選択ボタン押下時の処理
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                //初期選択フォルダー
                dialog.SelectedPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                //ダイアログに表示する説明文
                dialog.Description = "メールの保存先を指定してください。";

                //新しくフォルダを作成することを許可する
                dialog.ShowNewFolderButton = true;

                //ダイアログを表示する。
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //選択されたフォルダを取得する
                    textBoxSaveDir.Text = dialog.SelectedPath;
                }
                else
                {
                    //キャンセルの場合は何もしない
                }
            }
        }

        private void textBoxSaveDir_DragEnter(object sender, DragEventArgs e)
        {
            //保存先フォルダテキストボックスにドラッグしたときの処理
            if(e.Data.GetDataPresent(DataFormats.FileDrop, true) == true)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBoxSaveDir_DragDrop(object sender, DragEventArgs e)
        {
            //保存先フォルダテキストボックスにドロップしたときの処理
            if (e.Data.GetData(DataFormats.FileDrop) is string[] dropitems)
            {
                if(System.IO.Directory.Exists(dropitems[0]) == true)
                {
                    //フォルダが存在すればテキストボックスに格納
                    textBoxSaveDir.Text = dropitems[0];
                }
            }
        }
    }
}
