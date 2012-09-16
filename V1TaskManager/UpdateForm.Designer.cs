namespace V1TaskManager
{
	partial class UpdateForm
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
			this.todoPanel = new System.Windows.Forms.Panel();
			this.txtToDo = new System.Windows.Forms.TextBox();
			this.lblToDo = new System.Windows.Forms.Label();
			this.effortPanel = new System.Windows.Forms.Panel();
			this.txtEffort = new System.Windows.Forms.TextBox();
			this.lblEffort = new System.Windows.Forms.Label();
			this.statusPanel = new System.Windows.Forms.Panel();
			this.comboStatus = new System.Windows.Forms.ComboBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.todoPanel.SuspendLayout();
			this.effortPanel.SuspendLayout();
			this.statusPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// todoPanel
			// 
			this.todoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.todoPanel.Controls.Add(this.txtToDo);
			this.todoPanel.Controls.Add(this.lblToDo);
			this.todoPanel.Location = new System.Drawing.Point(7, 43);
			this.todoPanel.Name = "todoPanel";
			this.todoPanel.Size = new System.Drawing.Size(243, 28);
			this.todoPanel.TabIndex = 3;
			// 
			// txtToDo
			// 
			this.txtToDo.Location = new System.Drawing.Point(90, 3);
			this.txtToDo.Name = "txtToDo";
			this.txtToDo.Size = new System.Drawing.Size(135, 20);
			this.txtToDo.TabIndex = 1;
			// 
			// lblToDo
			// 
			this.lblToDo.AutoSize = true;
			this.lblToDo.Location = new System.Drawing.Point(44, 6);
			this.lblToDo.Name = "lblToDo";
			this.lblToDo.Size = new System.Drawing.Size(40, 13);
			this.lblToDo.TabIndex = 0;
			this.lblToDo.Text = "To Do:";
			// 
			// effortPanel
			// 
			this.effortPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.effortPanel.AutoSize = true;
			this.effortPanel.Controls.Add(this.txtEffort);
			this.effortPanel.Controls.Add(this.lblEffort);
			this.effortPanel.Location = new System.Drawing.Point(7, 77);
			this.effortPanel.Name = "effortPanel";
			this.effortPanel.Size = new System.Drawing.Size(243, 28);
			this.effortPanel.TabIndex = 2;
			// 
			// txtEffort
			// 
			this.txtEffort.Location = new System.Drawing.Point(90, 3);
			this.txtEffort.Name = "txtEffort";
			this.txtEffort.Size = new System.Drawing.Size(135, 20);
			this.txtEffort.TabIndex = 1;
			// 
			// lblEffort
			// 
			this.lblEffort.AutoSize = true;
			this.lblEffort.Location = new System.Drawing.Point(49, 6);
			this.lblEffort.Name = "lblEffort";
			this.lblEffort.Size = new System.Drawing.Size(35, 13);
			this.lblEffort.TabIndex = 0;
			this.lblEffort.Text = "Effort:";
			// 
			// statusPanel
			// 
			this.statusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.statusPanel.Controls.Add(this.comboStatus);
			this.statusPanel.Controls.Add(this.lblStatus);
			this.statusPanel.Location = new System.Drawing.Point(7, 7);
			this.statusPanel.Name = "statusPanel";
			this.statusPanel.Size = new System.Drawing.Size(243, 30);
			this.statusPanel.TabIndex = 4;
			// 
			// comboStatus
			// 
			this.comboStatus.FormattingEnabled = true;
			this.comboStatus.ItemHeight = 13;
			this.comboStatus.Location = new System.Drawing.Point(90, 3);
			this.comboStatus.Name = "comboStatus";
			this.comboStatus.Size = new System.Drawing.Size(135, 21);
			this.comboStatus.TabIndex = 3;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(47, 6);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(37, 13);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Status";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(173, 111);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(77, 23);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(90, 111);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(77, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnClose.Location = new System.Drawing.Point(7, 111);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(77, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "OK && Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// UpdateForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(262, 144);
			this.ControlBox = false;
			this.Controls.Add(this.statusPanel);
			this.Controls.Add(this.todoPanel);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.effortPanel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "UpdateForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Update";
			this.todoPanel.ResumeLayout(false);
			this.todoPanel.PerformLayout();
			this.effortPanel.ResumeLayout(false);
			this.effortPanel.PerformLayout();
			this.statusPanel.ResumeLayout(false);
			this.statusPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Panel effortPanel;
		private System.Windows.Forms.TextBox txtEffort;
		private System.Windows.Forms.Label lblEffort;
		private System.Windows.Forms.Panel todoPanel;
		private System.Windows.Forms.TextBox txtToDo;
		private System.Windows.Forms.Label lblToDo;
		private System.Windows.Forms.Panel statusPanel;
		private System.Windows.Forms.ComboBox comboStatus;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button btnClose;
	}
}