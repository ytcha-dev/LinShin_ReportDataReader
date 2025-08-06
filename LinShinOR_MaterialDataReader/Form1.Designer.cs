namespace LinShinOR_MaterialDataReader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FileUploader_Button = new Button();
            openFileDialog1 = new OpenFileDialog();
            FileName_TextBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            FilePath_Label = new Label();
            Anchor_TextBox = new RichTextBox();
            label4 = new Label();
            button1 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            AnchorUp = new Button();
            AnchorDown = new Button();
            label3 = new Label();
            DataRowCount_Box = new RichTextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // FileUploader_Button
            // 
            FileUploader_Button.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FileUploader_Button.Location = new Point(559, 29);
            FileUploader_Button.Name = "FileUploader_Button";
            FileUploader_Button.Size = new Size(160, 49);
            FileUploader_Button.TabIndex = 0;
            FileUploader_Button.Text = "上傳";
            FileUploader_Button.UseVisualStyleBackColor = true;
            FileUploader_Button.Click += Click_UploadFile;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += OpenFileDialog1_FileOk;
            // 
            // FileName_TextBox
            // 
            FileName_TextBox.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FileName_TextBox.Location = new Point(195, 29);
            FileName_TextBox.Name = "FileName_TextBox";
            FileName_TextBox.Size = new Size(344, 49);
            FileName_TextBox.TabIndex = 1;
            FileName_TextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(45, 32);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 2;
            label1.Text = "檔案名稱：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(45, 110);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 3;
            label2.Text = "檔案路徑：";
            // 
            // FilePath_Label
            // 
            FilePath_Label.AutoSize = true;
            FilePath_Label.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FilePath_Label.Location = new Point(195, 116);
            FilePath_Label.Name = "FilePath_Label";
            FilePath_Label.Size = new Size(0, 24);
            FilePath_Label.TabIndex = 4;
            // 
            // Anchor_TextBox
            // 
            Anchor_TextBox.Location = new Point(45, 217);
            Anchor_TextBox.Name = "Anchor_TextBox";
            Anchor_TextBox.Size = new Size(674, 166);
            Anchor_TextBox.TabIndex = 5;
            Anchor_TextBox.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(45, 190);
            label4.Name = "label4";
            label4.Size = new Size(295, 24);
            label4.TabIndex = 6;
            label4.Text = "對齊頂端（資料置頂，移除空行）";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(489, 389);
            button1.Name = "button1";
            button1.Size = new Size(230, 49);
            button1.TabIndex = 7;
            button1.Text = "確認完成  點擊儲存";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Click_CkeckDoneAndSave;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "\"xlsx\"";
            saveFileDialog1.FileOk += SaveFileDialog1_FileOk;
            // 
            // AnchorUp
            // 
            AnchorUp.Location = new Point(489, 184);
            AnchorUp.Name = "AnchorUp";
            AnchorUp.Size = new Size(109, 27);
            AnchorUp.TabIndex = 8;
            AnchorUp.Text = "↑";
            AnchorUp.UseVisualStyleBackColor = true;
            AnchorUp.Click += Click_AnchorUp;
            // 
            // AnchorDown
            // 
            AnchorDown.Location = new Point(604, 184);
            AnchorDown.Name = "AnchorDown";
            AnchorDown.Size = new Size(115, 27);
            AnchorDown.TabIndex = 9;
            AnchorDown.Text = "↓";
            AnchorDown.UseVisualStyleBackColor = true;
            AnchorDown.Click += Ckick_AnchorDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(45, 392);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 10;
            label3.Text = "單頁資料筆數設定：";
            // 
            // DataRowCount_Box
            // 
            DataRowCount_Box.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            DataRowCount_Box.Location = new Point(195, 389);
            DataRowCount_Box.Margin = new Padding(0);
            DataRowCount_Box.Name = "DataRowCount_Box";
            DataRowCount_Box.Size = new Size(29, 31);
            DataRowCount_Box.TabIndex = 11;
            DataRowCount_Box.Text = "2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(227, 392);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 12;
            label5.Text = "筆資料/頁";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 461);
            Controls.Add(label5);
            Controls.Add(DataRowCount_Box);
            Controls.Add(label3);
            Controls.Add(AnchorDown);
            Controls.Add(AnchorUp);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(Anchor_TextBox);
            Controls.Add(FilePath_Label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FileName_TextBox);
            Controls.Add(FileUploader_Button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FileUploader_Button;
        private OpenFileDialog openFileDialog1;
        private RichTextBox FileName_TextBox;
        private Label label1;
        private Label label2;
        private Label FilePath_Label;
        private RichTextBox Anchor_TextBox;
        private Label label4;
        private Button button1;
        private SaveFileDialog saveFileDialog1;
        private Button AnchorUp;
        private Button AnchorDown;
        private Label label3;
        private RichTextBox DataRowCount_Box;
        private Label label5;
    }
}
