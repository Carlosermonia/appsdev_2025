namespace SimpleFormsAppWithCheckedListBox
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
            chcklistbox = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            lstbox = new ListBox();
            add = new Button();
            clrbtn = new Button();
            removebtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // chcklistbox
            // 
            chcklistbox.BackColor = SystemColors.Menu;
            chcklistbox.FormattingEnabled = true;
            chcklistbox.Location = new Point(29, 165);
            chcklistbox.Name = "chcklistbox";
            chcklistbox.Size = new Size(239, 268);
            chcklistbox.TabIndex = 0;
            chcklistbox.SelectedIndexChanged += chcklistbox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 121);
            label1.Name = "label1";
            label1.Size = new Size(199, 28);
            label1.TabIndex = 1;
            label1.Text = "MOVIE/ SERIES LIST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(401, 121);
            label2.Name = "label2";
            label2.Size = new Size(253, 28);
            label2.TabIndex = 2;
            label2.Text = "MOVIE/ SERIES SELECTED";
            // 
            // lstbox
            // 
            lstbox.BackColor = SystemColors.Menu;
            lstbox.FormattingEnabled = true;
            lstbox.Location = new Point(401, 169);
            lstbox.Name = "lstbox";
            lstbox.Size = new Size(251, 264);
            lstbox.TabIndex = 3;
            // 
            // add
            // 
            add.BackColor = SystemColors.ScrollBar;
            add.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add.ForeColor = Color.Black;
            add.Location = new Point(87, 456);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 4;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // clrbtn
            // 
            clrbtn.BackColor = SystemColors.ScrollBar;
            clrbtn.ForeColor = Color.Black;
            clrbtn.Location = new Point(692, 276);
            clrbtn.Name = "clrbtn";
            clrbtn.Size = new Size(94, 29);
            clrbtn.TabIndex = 5;
            clrbtn.Text = "Clear";
            clrbtn.UseVisualStyleBackColor = false;
            clrbtn.Click += clrbtn_Click;
            // 
            // removebtn
            // 
            removebtn.BackColor = SystemColors.ScrollBar;
            removebtn.ForeColor = Color.Black;
            removebtn.Location = new Point(692, 206);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(94, 29);
            removebtn.TabIndex = 6;
            removebtn.Text = "Remove";
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 36);
            label3.Name = "label3";
            label3.Size = new Size(558, 46);
            label3.TabIndex = 7;
            label3.Text = "Simple Favorite Movie Picker App";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(885, 561);
            Controls.Add(label3);
            Controls.Add(removebtn);
            Controls.Add(clrbtn);
            Controls.Add(add);
            Controls.Add(lstbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chcklistbox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox chcklistbox;
        private Label label1;
        private Label label2;
        private ListBox lstbox;
        private Button add;
        private Button clrbtn;
        private Button removebtn;
        private Label label3;
    }
}
