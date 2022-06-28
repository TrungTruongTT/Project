namespace SaleManagement._1.Presentation_Layer
{
    partial class frmMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đângXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLTVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLHDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHoten = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.QLSPToolStripMenuItem,
            this.QLTVToolStripMenuItem,
            this.QLHDToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(993, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đângXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đângXuấtToolStripMenuItem
            // 
            this.đângXuấtToolStripMenuItem.Name = "đângXuấtToolStripMenuItem";
            this.đângXuấtToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.đângXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // QLSPToolStripMenuItem
            // 
            this.QLSPToolStripMenuItem.Name = "QLSPToolStripMenuItem";
            this.QLSPToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.QLSPToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.QLSPToolStripMenuItem.Click += new System.EventHandler(this.QLSPToolStripMenuItem_Click);
            // 
            // QLTVToolStripMenuItem
            // 
            this.QLTVToolStripMenuItem.Name = "QLTVToolStripMenuItem";
            this.QLTVToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.QLTVToolStripMenuItem.Text = "Quản lý thành viên";
            this.QLTVToolStripMenuItem.Click += new System.EventHandler(this.QLTVToolStripMenuItem_Click);
            // 
            // QLHDToolStripMenuItem
            // 
            this.QLHDToolStripMenuItem.Name = "QLHDToolStripMenuItem";
            this.QLHDToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.QLHDToolStripMenuItem.Text = "Quản lý hóa đơn";
            this.QLHDToolStripMenuItem.Click += new System.EventHandler(this.QLHDToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHoten});
            this.statusStrip.Location = new System.Drawing.Point(0, 469);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(993, 26);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelHoten
            // 
            this.toolStripStatusLabelHoten.Name = "toolStripStatusLabelHoten";
            this.toolStripStatusLabelHoten.Size = new System.Drawing.Size(46, 20);
            this.toolStripStatusLabelHoten.Text = "Email";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(993, 495);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHoten;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đângXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLTVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLHDToolStripMenuItem;
    }
}