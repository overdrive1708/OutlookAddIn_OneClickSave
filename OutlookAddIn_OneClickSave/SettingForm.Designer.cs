
namespace OutlookAddIn_OneClickSave
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSaveDIr = new System.Windows.Forms.Label();
            this.textBoxSaveDir = new System.Windows.Forms.TextBox();
            this.checkBoxIsSeparateAttachments = new System.Windows.Forms.CheckBox();
            this.buttonSaveSetting = new System.Windows.Forms.Button();
            this.buttonSelectSaveDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSaveDIr
            // 
            this.labelSaveDIr.AutoSize = true;
            this.labelSaveDIr.Location = new System.Drawing.Point(13, 15);
            this.labelSaveDIr.Name = "labelSaveDIr";
            this.labelSaveDIr.Size = new System.Drawing.Size(76, 12);
            this.labelSaveDIr.TabIndex = 1;
            this.labelSaveDIr.Text = "保存先フォルダ";
            // 
            // textBoxSaveDir
            // 
            this.textBoxSaveDir.Location = new System.Drawing.Point(95, 12);
            this.textBoxSaveDir.Name = "textBoxSaveDir";
            this.textBoxSaveDir.Size = new System.Drawing.Size(344, 19);
            this.textBoxSaveDir.TabIndex = 2;
            this.textBoxSaveDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxSaveDir_DragDrop);
            this.textBoxSaveDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxSaveDir_DragEnter);
            // 
            // checkBoxIsSeparateAttachments
            // 
            this.checkBoxIsSeparateAttachments.AutoSize = true;
            this.checkBoxIsSeparateAttachments.Location = new System.Drawing.Point(15, 37);
            this.checkBoxIsSeparateAttachments.Name = "checkBoxIsSeparateAttachments";
            this.checkBoxIsSeparateAttachments.Size = new System.Drawing.Size(157, 16);
            this.checkBoxIsSeparateAttachments.TabIndex = 3;
            this.checkBoxIsSeparateAttachments.Text = "添付ファイルを分離して保存";
            this.checkBoxIsSeparateAttachments.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSetting
            // 
            this.buttonSaveSetting.Location = new System.Drawing.Point(13, 60);
            this.buttonSaveSetting.Name = "buttonSaveSetting";
            this.buttonSaveSetting.Size = new System.Drawing.Size(517, 29);
            this.buttonSaveSetting.TabIndex = 4;
            this.buttonSaveSetting.Text = "設定保存";
            this.buttonSaveSetting.UseVisualStyleBackColor = true;
            this.buttonSaveSetting.Click += new System.EventHandler(this.buttonSaveSetting_Click);
            // 
            // buttonSelectSaveDir
            // 
            this.buttonSelectSaveDir.Location = new System.Drawing.Point(445, 10);
            this.buttonSelectSaveDir.Name = "buttonSelectSaveDir";
            this.buttonSelectSaveDir.Size = new System.Drawing.Size(85, 23);
            this.buttonSelectSaveDir.TabIndex = 5;
            this.buttonSelectSaveDir.Text = "選択";
            this.buttonSelectSaveDir.UseVisualStyleBackColor = true;
            this.buttonSelectSaveDir.Click += new System.EventHandler(this.buttonSelectSaveDir_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 101);
            this.Controls.Add(this.buttonSelectSaveDir);
            this.Controls.Add(this.buttonSaveSetting);
            this.Controls.Add(this.checkBoxIsSeparateAttachments);
            this.Controls.Add(this.textBoxSaveDir);
            this.Controls.Add(this.labelSaveDIr);
            this.Name = "SettingForm";
            this.Text = "設定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSaveDIr;
        private System.Windows.Forms.TextBox textBoxSaveDir;
        private System.Windows.Forms.CheckBox checkBoxIsSeparateAttachments;
        private System.Windows.Forms.Button buttonSaveSetting;
        private System.Windows.Forms.Button buttonSelectSaveDir;
    }
}