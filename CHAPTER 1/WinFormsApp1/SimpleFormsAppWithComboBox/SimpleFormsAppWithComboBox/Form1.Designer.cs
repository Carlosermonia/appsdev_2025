namespace SimpleFormsAppWithComboBox
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
            cuisinecombobox = new ComboBox();
            selectbtn = new Button();
            foodlstchckbox = new CheckedListBox();
            addbtn = new Button();
            foodlstbox = new ListBox();
            removebtn = new Button();
            clrbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(172, 26);
            label1.Name = "label1";
            label1.Size = new Size(430, 38);
            label1.TabIndex = 0;
            label1.Text = "Simple Favorite Food Picker App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(314, 99);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 1;
            label2.Text = "Food list ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(59, 99);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 2;
            label3.Text = "Cuisine";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(573, 99);
            label4.Name = "label4";
            label4.Size = new Size(229, 28);
            label4.TabIndex = 3;
            label4.Text = "  My Favorite Food list ";
            // 
            // cuisinecombobox
            // 
            cuisinecombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            cuisinecombobox.FormattingEnabled = true;
            cuisinecombobox.Location = new Point(36, 144);
            cuisinecombobox.Name = "cuisinecombobox";
            cuisinecombobox.Size = new Size(151, 28);
            cuisinecombobox.TabIndex = 4;
            cuisinecombobox.SelectedIndexChanged += cuisinecombobox_SelectedIndexChanged;
            // 
            // selectbtn
            // 
            selectbtn.BackColor = Color.Lime;
            selectbtn.Location = new Point(59, 221);
            selectbtn.Name = "selectbtn";
            selectbtn.Size = new Size(94, 29);
            selectbtn.TabIndex = 5;
            selectbtn.Text = "Select\r\n";
            selectbtn.UseVisualStyleBackColor = false;
            selectbtn.Click += selectbtn_Click;
            // 
            // foodlstchckbox
            // 
            foodlstchckbox.FormattingEnabled = true;
            foodlstchckbox.Location = new Point(284, 144);
            foodlstchckbox.Name = "foodlstchckbox";
            foodlstchckbox.Size = new Size(180, 202);
            foodlstchckbox.TabIndex = 6;
            foodlstchckbox.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.Lime;
            addbtn.ForeColor = Color.White;
            addbtn.Location = new Point(319, 382);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(94, 29);
            addbtn.TabIndex = 7;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // foodlstbox
            // 
            foodlstbox.FormattingEnabled = true;
            foodlstbox.Location = new Point(588, 144);
            foodlstbox.Name = "foodlstbox";
            foodlstbox.Size = new Size(190, 204);
            foodlstbox.TabIndex = 8;
            // 
            // removebtn
            // 
            removebtn.BackColor = Color.Red;
            removebtn.ForeColor = Color.White;
            removebtn.Location = new Point(638, 382);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(94, 29);
            removebtn.TabIndex = 9;
            removebtn.Text = "Remove";
            removebtn.TextImageRelation = TextImageRelation.ImageAboveText;
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // clrbtn
            // 
            clrbtn.BackColor = Color.Red;
            clrbtn.ForeColor = SystemColors.ButtonHighlight;
            clrbtn.Location = new Point(638, 430);
            clrbtn.Name = "clrbtn";
            clrbtn.Size = new Size(94, 29);
            clrbtn.TabIndex = 10;
            clrbtn.Text = "Clear All";
            clrbtn.UseVisualStyleBackColor = false;
            clrbtn.Click += clrbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(959, 552);
            Controls.Add(clrbtn);
            Controls.Add(removebtn);
            Controls.Add(foodlstbox);
            Controls.Add(addbtn);
            Controls.Add(foodlstchckbox);
            Controls.Add(selectbtn);
            Controls.Add(cuisinecombobox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Transparent;
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
        private Button selectbtn;
        private CheckedListBox foodlstchckbox;
        private Button addbtn;
        private ListBox foodlstbox;
        private Button removebtn;
        private Button clrbtn;
        public ComboBox cuisinecombobox;
    }
}
