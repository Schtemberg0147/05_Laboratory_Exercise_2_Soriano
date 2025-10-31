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
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.Alignment = ListViewAlignment.Default;
            lvShowText.AllowColumnReorder = true;
            lvShowText.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvShowText.LabelWrap = false;
            lvShowText.Location = new Point(113, 64);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(572, 262);
            lvShowText.TabIndex = 0;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = View.List;
            // 
            // btnOpen
            // 
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(312, 367);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(178, 37);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open File";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmOpenTextFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpen);
            Controls.Add(lvShowText);
            Name = "FrmOpenTextFile";
            Text = "Form1";
            Load += FrmOpenTextFile_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvShowText;
        private Button btnOpen;
        private OpenFileDialog openFileDialog1;
    }
}
