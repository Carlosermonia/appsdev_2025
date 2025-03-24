namespace SimpleFavoriteCartoonFormApp
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
            charcombobox = new ComboBox();
            viewbtn = new Button();
            clrbtn = new Button();
            label1 = new Label();
            imgpicturebox = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgpicturebox).BeginInit();
            SuspendLayout();
            // 
            // charcombobox
            // 
            charcombobox.FormattingEnabled = true;
            charcombobox.Location = new Point(48, 170);
            charcombobox.Name = "charcombobox";
            charcombobox.Size = new Size(162, 28);
            charcombobox.TabIndex = 0;
            // 
            // viewbtn
            // 
            viewbtn.BackColor = Color.Red;
            viewbtn.ForeColor = SystemColors.ActiveCaptionText;
            viewbtn.Location = new Point(66, 234);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(94, 29);
            viewbtn.TabIndex = 1;
            viewbtn.Text = "View";
            viewbtn.UseVisualStyleBackColor = false;
            viewbtn.Click += viewbtn_Click;
            // 
            // clrbtn
            // 
            clrbtn.BackColor = Color.Red;
            clrbtn.Location = new Point(66, 302);
            clrbtn.Name = "clrbtn";
            clrbtn.Size = new Size(94, 29);
            clrbtn.TabIndex = 2;
            clrbtn.Text = "Clear";
            clrbtn.UseVisualStyleBackColor = false;
            clrbtn.Click += clrbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 121);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 3;
            label1.Text = "Select an item";
            // 
            // imgpicturebox
            // 
            imgpicturebox.Location = new Point(438, 145);
            imgpicturebox.Name = "imgpicturebox";
            imgpicturebox.Size = new Size(246, 265);
            imgpicturebox.TabIndex = 4;
            imgpicturebox.TabStop = false;
            imgpicturebox.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(438, 104);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 5;
            label2.Text = "Image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(167, 42);
            label3.Name = "label3";
            label3.Size = new Size(396, 28);
            label3.TabIndex = 6;
            label3.Text = "Simple favorite cartoon character picker\r\n";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.spongebobbg;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(imgpicturebox);
            Controls.Add(label1);
            Controls.Add(clrbtn);
            Controls.Add(viewbtn);
            Controls.Add(charcombobox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)imgpicturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox charcombobox;
        private Button viewbtn;
        private Button clrbtn;
        private Label label1;
        private PictureBox imgpicturebox;
        private Label label2;
        private Label label3;
    }
}
