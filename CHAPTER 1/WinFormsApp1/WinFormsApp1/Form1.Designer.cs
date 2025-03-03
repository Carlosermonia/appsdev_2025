namespace WinFormsApp1
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
            firstname = new TextBox();
            label1 = new Label();
            lastname = new TextBox();
            label2 = new Label();
            Submit = new Button();
            SuspendLayout();
            // 
            // firstname
            // 
            firstname.Location = new Point(75, 74);
            firstname.Name = "firstname";
            firstname.Size = new Size(100, 23);
            firstname.TabIndex = 0;
            firstname.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 56);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // lastname
            // 
            lastname.Location = new Point(75, 144);
            lastname.Name = "lastname";
            lastname.Size = new Size(100, 23);
            lastname.TabIndex = 2;
            lastname.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 115);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // Submit
            // 
            Submit.Location = new Point(75, 190);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 23);
            Submit.TabIndex = 4;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 450);
            Controls.Add(Submit);
            Controls.Add(label2);
            Controls.Add(lastname);
            Controls.Add(label1);
            Controls.Add(firstname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstname;
        private Label label1;
        private TextBox lastname;
        private Label label2;
        private Button Submit;
    }
}
