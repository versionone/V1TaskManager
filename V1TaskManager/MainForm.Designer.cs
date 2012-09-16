namespace V1TaskManager
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuMyStuff = new System.Windows.Forms.ToolStripMenuItem();
			this.menuMyStuffRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.iconList = new System.Windows.Forms.ImageList(this.components);
			this.menuOtherStuff = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOtherStuffRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.trayMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// trayIcon
			// 
			this.trayIcon.ContextMenuStrip = this.trayMenu;
			this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
			this.trayIcon.Text = "VersionOne";
			this.trayIcon.Visible = true;
			// 
			// trayMenu
			// 
			this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOtherStuff,
            this.menuMyStuff,
            this.toolStripSeparator1,
            this.menuConfig,
            this.toolStripSeparator3,
            this.menuExit});
			this.trayMenu.Name = "trayMenu";
			this.trayMenu.Size = new System.Drawing.Size(153, 126);
			// 
			// menuMyStuff
			// 
			this.menuMyStuff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMyStuffRefresh,
            this.toolStripSeparator2});
			this.menuMyStuff.Name = "menuMyStuff";
			this.menuMyStuff.Size = new System.Drawing.Size(152, 22);
			this.menuMyStuff.Text = "My Stuff";
			// 
			// menuMyStuffRefresh
			// 
			this.menuMyStuffRefresh.Image = ((System.Drawing.Image)(resources.GetObject("menuMyStuffRefresh.Image")));
			this.menuMyStuffRefresh.Name = "menuMyStuffRefresh";
			this.menuMyStuffRefresh.Size = new System.Drawing.Size(152, 22);
			this.menuMyStuffRefresh.Text = "Refresh";
			this.menuMyStuffRefresh.Click += new System.EventHandler(this.menuMyStuffRefresh_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// menuConfig
			// 
			this.menuConfig.Image = ((System.Drawing.Image)(resources.GetObject("menuConfig.Image")));
			this.menuConfig.Name = "menuConfig";
			this.menuConfig.Size = new System.Drawing.Size(152, 22);
			this.menuConfig.Text = "Configuration";
			this.menuConfig.Click += new System.EventHandler(this.menuConfig_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
			// 
			// menuExit
			// 
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new System.Drawing.Size(152, 22);
			this.menuExit.Text = "Exit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// iconList
			// 
			this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
			this.iconList.TransparentColor = System.Drawing.Color.Transparent;
			this.iconList.Images.SetKeyName(0, "ChangeSet");
			this.iconList.Images.SetKeyName(1, "Defect");
			this.iconList.Images.SetKeyName(2, "DefectTemplate");
			this.iconList.Images.SetKeyName(3, "Epic");
			this.iconList.Images.SetKeyName(4, "Goal");
			this.iconList.Images.SetKeyName(5, "Issue");
			this.iconList.Images.SetKeyName(6, "Iteration");
			this.iconList.Images.SetKeyName(7, "Member");
			this.iconList.Images.SetKeyName(8, "Note");
			this.iconList.Images.SetKeyName(9, "Project");
			this.iconList.Images.SetKeyName(10, "Request");
			this.iconList.Images.SetKeyName(11, "Retrospective");
			this.iconList.Images.SetKeyName(12, "Story");
			this.iconList.Images.SetKeyName(13, "StoryTemplate");
			this.iconList.Images.SetKeyName(14, "Task");
			this.iconList.Images.SetKeyName(15, "Team");
			this.iconList.Images.SetKeyName(16, "Test");
			this.iconList.Images.SetKeyName(17, "Theme");
			// 
			// menuOtherStuff
			// 
			this.menuOtherStuff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOtherStuffRefresh,
            this.toolStripSeparator4});
			this.menuOtherStuff.Name = "menuOtherStuff";
			this.menuOtherStuff.Size = new System.Drawing.Size(152, 22);
			this.menuOtherStuff.Text = "Other Stuff";
			// 
			// menuOtherStuffRefresh
			// 
			this.menuOtherStuffRefresh.Image = ((System.Drawing.Image)(resources.GetObject("menuOtherStuffRefresh.Image")));
			this.menuOtherStuffRefresh.Name = "menuOtherStuffRefresh";
			this.menuOtherStuffRefresh.Size = new System.Drawing.Size(152, 22);
			this.menuOtherStuffRefresh.Text = "Refresh";
			this.menuOtherStuffRefresh.Click += new System.EventHandler(this.menuOtherStuffRefresh_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 272);
			this.Name = "MainForm";
			this.ShowInTaskbar = false;
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.trayMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon trayIcon;
		private System.Windows.Forms.ContextMenuStrip trayMenu;
		private System.Windows.Forms.ToolStripMenuItem menuConfig;
		private System.Windows.Forms.ToolStripMenuItem menuExit;
		private System.Windows.Forms.ToolStripMenuItem menuMyStuff;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuMyStuffRefresh;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ImageList iconList;
		private System.Windows.Forms.ToolStripMenuItem menuOtherStuff;
		private System.Windows.Forms.ToolStripMenuItem menuOtherStuffRefresh;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
	}
}

