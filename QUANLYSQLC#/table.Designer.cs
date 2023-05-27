namespace QUANLYSQLC_
{
    partial class table
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.admimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.cbfood = new System.Windows.Forms.ComboBox();
            this.btaddfood = new System.Windows.Forms.Button();
            this.nmfood = new System.Windows.Forms.NumericUpDown();
            this.flbtable = new System.Windows.Forms.FlowLayoutPanel();
            this.bntcheckout = new System.Windows.Forms.Button();
            this.btngiamgia = new System.Windows.Forms.Button();
            this.nmgiamgia = new System.Windows.Forms.NumericUpDown();
            this.btnchuyen = new System.Windows.Forms.Button();
            this.cbchuyen = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmfood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmgiamgia)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admimToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // admimToolStripMenuItem
            // 
            this.admimToolStripMenuItem.Name = "admimToolStripMenuItem";
            this.admimToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.admimToolStripMenuItem.Text = "admim";
            this.admimToolStripMenuItem.Click += new System.EventHandler(this.admimToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "thông tin tài khoản";
            // 
            // thôngTinCáToolStripMenuItem
            // 
            this.thôngTinCáToolStripMenuItem.Name = "thôngTinCáToolStripMenuItem";
            this.thôngTinCáToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinCáToolStripMenuItem.Text = "thông tin cá ";
            this.thôngTinCáToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(427, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 283);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbchuyen);
            this.panel3.Controls.Add(this.btnchuyen);
            this.panel3.Controls.Add(this.nmgiamgia);
            this.panel3.Controls.Add(this.btngiamgia);
            this.panel3.Controls.Add(this.bntcheckout);
            this.panel3.Location = new System.Drawing.Point(427, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 59);
            this.panel3.TabIndex = 3;
            // 
            // lsvBill
            // 
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(6, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(355, 277);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmfood);
            this.panel4.Controls.Add(this.btaddfood);
            this.panel4.Controls.Add(this.cbfood);
            this.panel4.Controls.Add(this.cbcategory);
            this.panel4.Location = new System.Drawing.Point(427, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 57);
            this.panel4.TabIndex = 4;
            // 
            // cbcategory
            // 
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Location = new System.Drawing.Point(3, 3);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(189, 21);
            this.cbcategory.TabIndex = 0;
            // 
            // cbfood
            // 
            this.cbfood.FormattingEnabled = true;
            this.cbfood.Location = new System.Drawing.Point(3, 30);
            this.cbfood.Name = "cbfood";
            this.cbfood.Size = new System.Drawing.Size(189, 21);
            this.cbfood.TabIndex = 1;
            // 
            // btaddfood
            // 
            this.btaddfood.Location = new System.Drawing.Point(199, 0);
            this.btaddfood.Name = "btaddfood";
            this.btaddfood.Size = new System.Drawing.Size(78, 51);
            this.btaddfood.TabIndex = 2;
            this.btaddfood.Text = "thêm món";
            this.btaddfood.UseVisualStyleBackColor = true;
            // 
            // nmfood
            // 
            this.nmfood.Location = new System.Drawing.Point(284, 3);
            this.nmfood.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmfood.Name = "nmfood";
            this.nmfood.Size = new System.Drawing.Size(71, 20);
            this.nmfood.TabIndex = 3;
            this.nmfood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flbtable
            // 
            this.flbtable.Location = new System.Drawing.Point(13, 27);
            this.flbtable.Name = "flbtable";
            this.flbtable.Size = new System.Drawing.Size(408, 411);
            this.flbtable.TabIndex = 5;
            // 
            // bntcheckout
            // 
            this.bntcheckout.Location = new System.Drawing.Point(280, 3);
            this.bntcheckout.Name = "bntcheckout";
            this.bntcheckout.Size = new System.Drawing.Size(78, 51);
            this.bntcheckout.TabIndex = 3;
            this.bntcheckout.Text = "thanh toán";
            this.bntcheckout.UseVisualStyleBackColor = true;
            this.bntcheckout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngiamgia
            // 
            this.btngiamgia.Location = new System.Drawing.Point(143, 3);
            this.btngiamgia.Name = "btngiamgia";
            this.btngiamgia.Size = new System.Drawing.Size(78, 27);
            this.btngiamgia.TabIndex = 4;
            this.btngiamgia.Text = "giảm giá";
            this.btngiamgia.UseVisualStyleBackColor = true;
            // 
            // nmgiamgia
            // 
            this.nmgiamgia.Location = new System.Drawing.Point(143, 34);
            this.nmgiamgia.Name = "nmgiamgia";
            this.nmgiamgia.Size = new System.Drawing.Size(78, 20);
            this.nmgiamgia.TabIndex = 5;
            this.nmgiamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnchuyen
            // 
            this.btnchuyen.Location = new System.Drawing.Point(3, 3);
            this.btnchuyen.Name = "btnchuyen";
            this.btnchuyen.Size = new System.Drawing.Size(78, 27);
            this.btnchuyen.TabIndex = 6;
            this.btnchuyen.Text = " chuyển bàn";
            this.btnchuyen.UseVisualStyleBackColor = true;
            // 
            // cbchuyen
            // 
            this.cbchuyen.FormattingEnabled = true;
            this.cbchuyen.Location = new System.Drawing.Point(3, 34);
            this.cbchuyen.Name = "cbchuyen";
            this.cbchuyen.Size = new System.Drawing.Size(78, 21);
            this.cbchuyen.TabIndex = 7;
            // 
            // table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flbtable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "phần mềm quản lý";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmfood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmgiamgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem admimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btaddfood;
        private System.Windows.Forms.ComboBox cbfood;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.NumericUpDown nmfood;
        private System.Windows.Forms.FlowLayoutPanel flbtable;
        private System.Windows.Forms.Button bntcheckout;
        private System.Windows.Forms.Button btngiamgia;
        private System.Windows.Forms.ComboBox cbchuyen;
        private System.Windows.Forms.Button btnchuyen;
        private System.Windows.Forms.NumericUpDown nmgiamgia;
    }
}