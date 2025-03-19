namespace MidtermExaminationApp
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
            label3 = new Label();
            label4 = new Label();
            iphonelstbox = new ListBox();
            iphonechcklstbox = new CheckedListBox();
            loancombobox = new ComboBox();
            Computebtn = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            downPaymentLabel = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(317, 21);
            label1.TabIndex = 0;
            label1.Text = "SIMPLE IPHONE LOAN CALCULATOR APP\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(337, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 1;
            label2.Text = "Adds-on";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 98);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 2;
            label3.Text = "iPhone Model";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(577, 98);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 3;
            label4.Text = "Loan Term";
            // 
            // iphonelstbox
            // 
            iphonelstbox.FormattingEnabled = true;
            iphonelstbox.ItemHeight = 21;
            iphonelstbox.Location = new Point(36, 122);
            iphonelstbox.Margin = new Padding(2, 3, 2, 3);
            iphonelstbox.Name = "iphonelstbox";
            iphonelstbox.Size = new Size(223, 130);
            iphonelstbox.TabIndex = 4;
            iphonelstbox.SelectedIndexChanged += iphonelstbox_SelectedIndexChanged;
            // 
            // iphonechcklstbox
            // 
            iphonechcklstbox.FormattingEnabled = true;
            iphonechcklstbox.Location = new Point(331, 122);
            iphonechcklstbox.Margin = new Padding(2, 3, 2, 3);
            iphonechcklstbox.Name = "iphonechcklstbox";
            iphonechcklstbox.Size = new Size(200, 124);
            iphonechcklstbox.TabIndex = 5;
            iphonechcklstbox.SelectedIndexChanged += iphonechcklstbox_SelectedIndexChanged;
            // 
            // loancombobox
            // 
            loancombobox.FormattingEnabled = true;
            loancombobox.Location = new Point(577, 122);
            loancombobox.Margin = new Padding(2, 3, 2, 3);
            loancombobox.Name = "loancombobox";
            loancombobox.Size = new Size(100, 29);
            loancombobox.TabIndex = 6;
            // 
            // Computebtn
            // 
            Computebtn.BackColor = Color.Lime;
            Computebtn.ForeColor = Color.Maroon;
            Computebtn.Location = new Point(577, 170);
            Computebtn.Margin = new Padding(2, 3, 2, 3);
            Computebtn.Name = "Computebtn";
            Computebtn.Size = new Size(100, 31);
            Computebtn.TabIndex = 7;
            Computebtn.Text = "Compute";
            Computebtn.UseVisualStyleBackColor = false;
            Computebtn.Click += Computebtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 294);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 8;
            label5.Text = "Loan Details :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 337);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 9;
            label6.Text = "Model";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 374);
            label7.Name = "label7";
            label7.Size = new Size(121, 21);
            label7.TabIndex = 10;
            label7.Text = "Priciple Amount";
            // 
            // downPaymentLabel
            // 
            downPaymentLabel.AutoSize = true;
            downPaymentLabel.Location = new Point(52, 416);
            downPaymentLabel.Name = "downPaymentLabel";
            downPaymentLabel.Size = new Size(115, 21);
            downPaymentLabel.TabIndex = 11;
            downPaymentLabel.Text = "Down Payment";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 460);
            label9.Name = "label9";
            label9.Size = new Size(82, 21);
            label9.TabIndex = 12;
            label9.Text = "Loan Term";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(407, 337);
            label10.Name = "label10";
            label10.Size = new Size(93, 21);
            label10.TabIndex = 13;
            label10.Text = "Interest rate";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(407, 374);
            label11.Name = "label11";
            label11.Size = new Size(151, 21);
            label11.TabIndex = 14;
            label11.Text = "interest rate amount\r\n";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(407, 416);
            label12.Name = "label12";
            label12.Size = new Size(193, 21);
            label12.TabIndex = 15;
            label12.Text = " total monthly amotization";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(407, 460);
            label13.Name = "label13";
            label13.Size = new Size(99, 21);
            label13.TabIndex = 16;
            label13.Text = "total amount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(722, 514);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(downPaymentLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Computebtn);
            Controls.Add(loancombobox);
            Controls.Add(iphonechcklstbox);
            Controls.Add(iphonelstbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox iphonelstbox;
        private CheckedListBox iphonechcklstbox;
        private ComboBox loancombobox;
        private Button Computebtn;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label downPaymentLabel;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}
