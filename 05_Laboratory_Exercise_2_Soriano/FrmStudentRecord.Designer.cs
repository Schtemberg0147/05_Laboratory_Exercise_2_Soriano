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
            listView1 = new ListView();
            btnRegister = new Button();
            btnFind = new Button();
            btnUpload = new Button();
            SuspendLayout();
            // 
            // lblViewRecord
            // 
            lblViewRecord.AutoSize = true;
            lblViewRecord.Font = new Font("Bahnschrift", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewRecord.Location = new Point(18, 19);
            lblViewRecord.Name = "lblViewRecord";
            lblViewRecord.Size = new Size(165, 33);
            lblViewRecord.TabIndex = 0;
            lblViewRecord.Text = "View Record";
            // 
            // listView1
            // 
            listView1.Location = new Point(25, 69);
            listView1.Name = "listView1";
            listView1.Size = new Size(578, 348);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnRegister
            // 
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Bahnschrift", 14.25F);
            btnRegister.Location = new Point(642, 69);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 35);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Bahnschrift", 14.25F);
            btnFind.Location = new Point(642, 133);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(120, 35);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Bahnschrift", 14.25F);
            btnUpload.Location = new Point(642, 197);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(120, 35);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpload);
            Controls.Add(btnFind);
            Controls.Add(btnRegister);
            Controls.Add(listView1);
            Controls.Add(lblViewRecord);
            Name = "FrmStudentRecord";
            Text = "FrmStudentRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblViewRecord;
        private ListView listView1;
        private Button btnRegister;
        private Button btnFind;
        private Button btnUpload;
    }
}