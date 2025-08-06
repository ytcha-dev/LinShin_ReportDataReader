namespace LinShinForm
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
            label2 = new Label();
            label1 = new Label();
            FileName_TextBox = new RichTextBox();
            FileUploader_Button = new Button();
            button1 = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            MaterialRecord = new CheckBox();
            SurgeryRecord = new CheckBox();
            SurgeryRecord2 = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            FilePath_Label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(35, 144);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 7;
            label2.Text = "檔案路徑：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(35, 44);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 6;
            label1.Text = "檔案名稱：";
            // 
            // FileName_TextBox
            // 
            FileName_TextBox.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FileName_TextBox.Location = new Point(214, 41);
            FileName_TextBox.Name = "FileName_TextBox";
            FileName_TextBox.Size = new Size(512, 49);
            FileName_TextBox.TabIndex = 5;
            FileName_TextBox.Text = "";
            // 
            // FileUploader_Button
            // 
            FileUploader_Button.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FileUploader_Button.Location = new Point(777, 41);
            FileUploader_Button.Name = "FileUploader_Button";
            FileUploader_Button.Size = new Size(160, 49);
            FileUploader_Button.TabIndex = 4;
            FileUploader_Button.Text = "上傳";
            FileUploader_Button.UseVisualStyleBackColor = true;
            FileUploader_Button.Click += FileUploader_Button_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(939, 288);
            button1.Name = "button1";
            button1.Size = new Size(230, 35);
            button1.TabIndex = 15;
            button1.Text = "確認完成  點擊儲存";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(32, 302);
            label4.Name = "label4";
            label4.Size = new Size(580, 24);
            label4.TabIndex = 14;
            label4.Text = "預覽結果，多往下拉是否正確，若有跑版，先確認勾選格式是否正確";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 329);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1137, 314);
            dataGridView1.TabIndex = 18;
            // 
            // MaterialRecord
            // 
            MaterialRecord.AutoSize = true;
            MaterialRecord.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            MaterialRecord.Location = new Point(35, 210);
            MaterialRecord.Name = "MaterialRecord";
            MaterialRecord.Size = new Size(162, 28);
            MaterialRecord.TabIndex = 19;
            MaterialRecord.Tag = "formtype";
            MaterialRecord.Text = "手術室資材報表";
            MaterialRecord.UseVisualStyleBackColor = true;
            MaterialRecord.CheckedChanged += ckb_CheckedChanged;
            // 
            // SurgeryRecord
            // 
            SurgeryRecord.AutoSize = true;
            SurgeryRecord.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            SurgeryRecord.Location = new Point(248, 210);
            SurgeryRecord.Name = "SurgeryRecord";
            SurgeryRecord.Size = new Size(166, 28);
            SurgeryRecord.TabIndex = 20;
            SurgeryRecord.Tag = "formtype";
            SurgeryRecord.Text = "手術通知排程(1)";
            SurgeryRecord.UseVisualStyleBackColor = true;
            SurgeryRecord.CheckedChanged += ckb_CheckedChanged;
            // 
            // SurgeryRecord2
            // 
            SurgeryRecord2.AutoSize = true;
            SurgeryRecord2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            SurgeryRecord2.Location = new Point(477, 210);
            SurgeryRecord2.Name = "SurgeryRecord2";
            SurgeryRecord2.Size = new Size(166, 28);
            SurgeryRecord2.TabIndex = 21;
            SurgeryRecord2.Tag = "formtype";
            SurgeryRecord2.Text = "手術通知排程(2)";
            SurgeryRecord2.UseVisualStyleBackColor = true;
            SurgeryRecord2.CheckedChanged += ckb_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // FilePath_Label
            // 
            FilePath_Label.AutoSize = true;
            FilePath_Label.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FilePath_Label.Location = new Point(214, 149);
            FilePath_Label.Name = "FilePath_Label";
            FilePath_Label.Size = new Size(81, 24);
            FilePath_Label.TabIndex = 22;
            FilePath_Label.Text = "FilePath";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 674);
            Controls.Add(FilePath_Label);
            Controls.Add(SurgeryRecord2);
            Controls.Add(SurgeryRecord);
            Controls.Add(MaterialRecord);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FileName_TextBox);
            Controls.Add(FileUploader_Button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private RichTextBox FileName_TextBox;
        private Button FileUploader_Button;
        private Button button1;
        private Label label4;
        private DataGridView dataGridView1;
        private CheckBox MaterialRecord;
        private CheckBox SurgeryRecord;
        private CheckBox SurgeryRecord2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Label FilePath_Label;
    }
}
