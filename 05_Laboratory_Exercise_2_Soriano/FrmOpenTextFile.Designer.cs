namespace _05_Laboratory_Exercise_2_Soriano
{
    partial class FrmOpenTextFile
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
            lvShowText = new ListView();
            btnOpen = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.Alignment = ListViewAlignment.Default;
            lvShowText.AllowColumnReorder = true;
            lvShowText.BackColor = Color.FromArgb(215, 143, 238);
            lvShowText.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvShowText.ForeColor = SystemColors.MenuText;
            lvShowText.LabelWrap = false;
            lvShowText.Location = new Point(43, 72);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(711, 262);
            lvShowText.TabIndex = 0;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = View.List;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.FromArgb(78, 86, 192);
            btnOpen.FlatStyle = FlatStyle.Popup;
            btnOpen.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.ForeColor = Color.FromArgb(253, 207, 250);
            btnOpen.Location = new Point(312, 367);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(178, 37);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open File";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(253, 207, 250);
            label1.Location = new Point(43, 22);
            label1.Name = "label1";
            label1.Size = new Size(110, 29);
            label1.TabIndex = 2;
            label1.Text = "View File";
            // 
            // FrmOpenTextFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnOpen);
            Controls.Add(lvShowText);
            Location = new Point(1000, 300);
            Name = "FrmOpenTextFile";
            StartPosition = FormStartPosition.Manual;
            Text = "Open File";
            Load += FrmOpenTextFile_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvShowText;
        private Button btnOpen;
        private OpenFileDialog openFileDialog1;
        private Label label1;
    }
}
