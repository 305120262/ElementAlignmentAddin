namespace ElementAlignmentAddin
{
    partial class ElementListForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbxH = new System.Windows.Forms.TextBox();
            this.cbxHDirection = new System.Windows.Forms.ComboBox();
            this.tbxV = new System.Windows.Forms.TextBox();
            this.cbxVDirection = new System.Windows.Forms.ComboBox();
            this.listElement = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "对齐Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxH
            // 
            this.tbxH.Location = new System.Drawing.Point(150, 89);
            this.tbxH.Name = "tbxH";
            this.tbxH.Size = new System.Drawing.Size(100, 25);
            this.tbxH.TabIndex = 2;
            // 
            // cbxHDirection
            // 
            this.cbxHDirection.FormattingEnabled = true;
            this.cbxHDirection.Items.AddRange(new object[] {
            "左侧Left",
            "右侧Right"});
            this.cbxHDirection.Location = new System.Drawing.Point(7, 91);
            this.cbxHDirection.Name = "cbxHDirection";
            this.cbxHDirection.Size = new System.Drawing.Size(121, 23);
            this.cbxHDirection.TabIndex = 3;
            this.cbxHDirection.Text = "左侧Left";
            // 
            // tbxV
            // 
            this.tbxV.Location = new System.Drawing.Point(150, 135);
            this.tbxV.Name = "tbxV";
            this.tbxV.Size = new System.Drawing.Size(100, 25);
            this.tbxV.TabIndex = 2;
            // 
            // cbxVDirection
            // 
            this.cbxVDirection.FormattingEnabled = true;
            this.cbxVDirection.Items.AddRange(new object[] {
            "上侧Top",
            "下侧Bottom"});
            this.cbxVDirection.Location = new System.Drawing.Point(7, 137);
            this.cbxVDirection.Name = "cbxVDirection";
            this.cbxVDirection.Size = new System.Drawing.Size(121, 23);
            this.cbxVDirection.TabIndex = 3;
            this.cbxVDirection.Text = "上侧Top";
            // 
            // listElement
            // 
            this.listElement.FormattingEnabled = true;
            this.listElement.Location = new System.Drawing.Point(77, 46);
            this.listElement.Name = "listElement";
            this.listElement.Size = new System.Drawing.Size(152, 23);
            this.listElement.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "元素";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 19);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "对齐元素";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(117, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 19);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "对齐页边框";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ElementListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 221);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listElement);
            this.Controls.Add(this.cbxVDirection);
            this.Controls.Add(this.cbxHDirection);
            this.Controls.Add(this.tbxV);
            this.Controls.Add(this.tbxH);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ElementListForm";
            this.Text = "设置对齐参数Align Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxH;
        private System.Windows.Forms.ComboBox cbxHDirection;
        private System.Windows.Forms.TextBox tbxV;
        private System.Windows.Forms.ComboBox cbxVDirection;
        private System.Windows.Forms.ComboBox listElement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}