namespace SimpleFormsAppWithMessageBoxes
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
            label1 = new Label();
            label2 = new Label();
            firstname = new TextBox();
            middlename = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lastname = new TextBox();
            label5 = new Label();
            suffix = new TextBox();
            submit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(78, 29);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 0;
            label1.Text = "SIMPLE FORM APPLICATION";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 67);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            label2.Click += label2_Click;
            // 
            // firstname
            // 
            firstname.Location = new Point(22, 85);
            firstname.Name = "firstname";
            firstname.Size = new Size(183, 23);
            firstname.TabIndex = 2;
            // 
            // middlename
            // 
            middlename.Location = new Point(22, 154);
            middlename.Name = "middlename";
            middlename.Size = new Size(183, 23);
            middlename.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 136);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 4;
            label3.Text = "Middle Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 207);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 5;
            label4.Text = "Last Name";
            // 
            // lastname
            // 
            lastname.Location = new Point(22, 225);
            lastname.Name = "lastname";
            lastname.Size = new Size(183, 23);
            lastname.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 269);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 7;
            label5.Text = "Suffix";
            // 
            // suffix
            // 
            suffix.Location = new Point(22, 287);
            suffix.Name = "suffix";
            suffix.Size = new Size(183, 23);
            suffix.TabIndex = 8;
            // 
            // submit
            // 
            submit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submit.Location = new Point(22, 346);
            submit.Name = "submit";
            submit.Size = new Size(164, 23);
            submit.TabIndex = 9;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 450);
            Controls.Add(submit);
            Controls.Add(suffix);
            Controls.Add(label5);
            Controls.Add(lastname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(middlename);
            Controls.Add(firstname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox firstname;
        private TextBox middlename;
        private Label label3;
        private Label label4;
        private TextBox lastname;
        private Label label5;
        private TextBox suffix;
        private Button submit;
    }
}
