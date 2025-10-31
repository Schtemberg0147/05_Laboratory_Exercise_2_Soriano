namespace _05_Laboratory_Exercise_2_Soriano
{
    partial class FrmStudentRecord
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
            lblViewRecord = new Label();
            lvShowText = new ListView();
            btnRegister = new Button();
            btnFind = new Button();
            btnUpload = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // lblViewRecord
            // 
            lblViewRecord.AutoSize = true;
            lblViewRecord.Font = new Font("Bahnschrift", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewRecord.ForeColor = Color.FromArgb(253, 207, 250);
            lblViewRecord.Location = new Point(18, 19);
            lblViewRecord.Name = "lblViewRecord";
            lblViewRecord.Size = new Size(165, 33);
            lblViewRecord.TabIndex = 0;
            lblViewRecord.Text = "View Record";
            // 
            // lvShowText
            // 
            lvShowText.Alignment = ListViewAlignment.Default;
            lvShowText.BackColor = Color.FromArgb(215, 143, 238);
            lvShowText.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvShowText.LabelWrap = false;
            lvShowText.Location = new Point(25, 69);
            lvShowText.Name = "lvShowText";
            lvShowText.RightToLeft = RightToLeft.No;
            lvShowText.Size = new Size(578, 348);
            lvShowText.TabIndex = 1;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.UseWaitCursor = true;
            lvShowText.View = View.List;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(78, 86, 192);
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Bahnschrift", 14.25F);
            btnRegister.ForeColor = Color.FromArgb(253, 207, 250);
            btnRegister.Location = new Point(642, 69);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 35);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(78, 86, 192);
            btnFind.FlatStyle = FlatStyle.Popup;
            btnFind.Font = new Font("Bahnschrift", 14.25F);
            btnFind.ForeColor = Color.FromArgb(253, 207, 250);
            btnFind.Location = new Point(642, 133);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(120, 35);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(78, 86, 192);
            btnUpload.FlatStyle = FlatStyle.Popup;
            btnUpload.Font = new Font("Bahnschrift", 14.25F);
            btnUpload.ForeColor = Color.FromArgb(253, 207, 250);
            btnUpload.Location = new Point(642, 197);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(120, 35);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpload);
            Controls.Add(btnFind);
            Controls.Add(btnRegister);
            Controls.Add(lvShowText);
            Controls.Add(lblViewRecord);
            Location = new Point(170, 300);
            Name = "FrmStudentRecord";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmStudentRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblViewRecord;
        private ListView lvShowText;
        private Button btnRegister;
        private Button btnFind;
        private Button btnUpload;
        private OpenFileDialog openFileDialog1;
    }
}