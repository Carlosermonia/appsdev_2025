namespace SimpleFormsAppWithListBox
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
            lstbox = new ListBox();
            txtbox = new TextBox();
            addbtn = new Button();
            removebtn = new Button();
            clrbtn = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(380, 60);
            label1.TabIndex = 0;
            label1.Text = "LIST OF PROGRAMMING LANGUAGE\r\n\r\n";
            // 
            // lstbox
            // 
            lstbox.FormattingEnabled = true;
            lstbox.ItemHeight = 15;
            lstbox.Location = new Point(24, 53);
            lstbox.Name = "lstbox";
            lstbox.Size = new Size(125, 364);
            lstbox.TabIndex = 1;
            // 
            // txtbox
            // 
            txtbox.Location = new Point(174, 87);
            txtbox.Name = "txtbox";
            txtbox.Size = new Size(158, 23);
            txtbox.TabIndex = 2;
            // 
            // addbtn
            // 
            addbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addbtn.Location = new Point(182, 143);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(75, 23);
            addbtn.TabIndex = 3;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // removebtn
            // 
            removebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removebtn.Location = new Point(182, 181);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(75, 23);
            removebtn.TabIndex = 4;
            removebtn.Text = "Remove";
            removebtn.UseVisualStyleBackColor = true;
            removebtn.Click += removebtn_Click_1;
            // 
            // clrbtn
            // 
            clrbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clrbtn.Location = new Point(182, 223);
            clrbtn.Name = "clrbtn";
            clrbtn.Size = new Size(75, 23);
            clrbtn.TabIndex = 5;
            clrbtn.Text = "Clear";
            clrbtn.UseVisualStyleBackColor = true;
            clrbtn.Click += clrbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(166, 69);
            label2.Name = "label2";
            label2.Size = new Size(166, 15);
            label2.TabIndex = 6;
            label2.Text = "Enter Programming language:\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(382, 450);
            Controls.Add(label2);
            Controls.Add(clrbtn);
            Controls.Add(removebtn);
            Controls.Add(addbtn);
            Controls.Add(txtbox);
            Controls.Add(lstbox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstbox;
        private TextBox txtbox;
        private Button addbtn;
        private Button removebtn;
        private Button clrbtn;
        private Label label2;
    }
}
