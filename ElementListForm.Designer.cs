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
            this.listElement = new System.Windows.Forms.ListBox();
            this.tbxH = new System.Windows.Forms.TextBox();
            this.cbxHDirection = new System.Windows.Forms.ComboBox();
            this.tbxV = new System.Windows.Forms.TextBox();
            this.cbxVDirection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "对齐";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listElement
            // 
            this.listElement.FormattingEnabled = true;
            this.listElement.ItemHeight = 15;
            this.listElement.Location = new System.Drawing.Point(12, 12);
            this.listElement.Name = "listElement";
            this.listElement.Size = new System.Drawing.Size(250, 289);
            this.listElement.TabIndex = 1;
            // 
            // tbxH
            // 
            this.tbxH.Location = new System.Drawing.Point(162, 320);
            this.tbxH.Name = "tbxH";
            this.tbxH.Size = new System.Drawing.Size(100, 25);
            this.tbxH.TabIndex = 2;
            // 
            // cbxHDirection
            // 
            this.cbxHDirection.FormattingEnabled = true;
            this.cbxHDirection.Items.AddRange(new object[] {
            "左侧",
            "右侧"});
            this.cbxHDirection.Location = new System.Drawing.Point(19, 322);
            this.cbxHDirection.Name = "cbxHDirection";
            this.cbxHDirection.Size = new System.Drawing.Size(121, 23);
            this.cbxHDirection.TabIndex = 3;
            this.cbxHDirection.Text = "左侧";
            // 
            // tbxV
            // 
            this.tbxV.Location = new System.Drawing.Point(162, 366);
            this.tbxV.Name = "tbxV";
            this.tbxV.Size = new System.Drawing.Size(100, 25);
            this.tbxV.TabIndex = 2;
            // 
            // cbxVDirection
            // 
            this.cbxVDirection.FormattingEnabled = true;
            this.cbxVDirection.Items.AddRange(new object[] {
            "上侧",
            "下侧"});
            this.cbxVDirection.Location = new System.Drawing.Point(19, 368);
            this.cbxVDirection.Name = "cbxVDirection";
            this.cbxVDirection.Size = new System.Drawing.Size(121, 23);
            this.cbxVDirection.TabIndex = 3;
            this.cbxVDirection.Text = "上侧";
            // 
            // ElementListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 446);
            this.Controls.Add(this.cbxVDirection);
            this.Controls.Add(this.cbxHDirection);
            this.Controls.Add(this.tbxV);
            this.Controls.Add(this.tbxH);
            this.Controls.Add(this.listElement);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ElementListForm";
            this.Text = "设置对齐参数";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listElement;
        private System.Windows.Forms.TextBox tbxH;
        private System.Windows.Forms.ComboBox cbxHDirection;
        private System.Windows.Forms.TextBox tbxV;
        private System.Windows.Forms.ComboBox cbxVDirection;
    }
}