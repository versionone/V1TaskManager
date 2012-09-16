namespace V1TaskManager
{
	partial class ConfigForm
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
            this.lblAppPath = new System.Windows.Forms.Label();
            this.txtAppPath = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblIntegratedUsername = new System.Windows.Forms.Label();
            this.cbIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblAppPath
            // 
            this.lblAppPath.AutoSize = true;
            this.lblAppPath.Location = new System.Drawing.Point(12, 9);
            this.lblAppPath.Name = "lblAppPath";
            this.lblAppPath.Size = new System.Drawing.Size(87, 13);
            this.lblAppPath.TabIndex = 0;
            this.lblAppPath.Text = "Application Path:";
            // 
            // txtAppPath
            // 
            this.txtAppPath.Location = new System.Drawing.Point(105, 6);
            this.txtAppPath.Name = "txtAppPath";
            this.txtAppPath.Size = new System.Drawing.Size(246, 20);
            this.txtAppPath.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(105, 74);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(246, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 77);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(105, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(246, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 103);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(276, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(195, 126);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblIntegratedUsername
            // 
            this.lblIntegratedUsername.AutoSize = true;
            this.lblIntegratedUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegratedUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIntegratedUsername.Location = new System.Drawing.Point(122, 52);
            this.lblIntegratedUsername.Name = "lblIntegratedUsername";
            this.lblIntegratedUsername.Size = new System.Drawing.Size(108, 13);
            this.lblIntegratedUsername.TabIndex = 18;
            this.lblIntegratedUsername.Text = "\'user@domain\' format";
            this.lblIntegratedUsername.Visible = false;
            // 
            // cbIntegratedSecurity
            // 
            this.cbIntegratedSecurity.AutoSize = true;
            this.cbIntegratedSecurity.Location = new System.Drawing.Point(105, 32);
            this.cbIntegratedSecurity.Name = "cbIntegratedSecurity";
            this.cbIntegratedSecurity.Size = new System.Drawing.Size(184, 17);
            this.cbIntegratedSecurity.TabIndex = 17;
            this.cbIntegratedSecurity.Text = "Use Windows Integrated Security";
            this.cbIntegratedSecurity.UseVisualStyleBackColor = true;
            this.cbIntegratedSecurity.CheckedChanged += new System.EventHandler(this.cbIntegratedSecurity_CheckedChanged);
            // 
            // ConfigForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(363, 158);
            this.Controls.Add(this.lblIntegratedUsername);
            this.Controls.Add(this.cbIntegratedSecurity);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtAppPath);
            this.Controls.Add(this.lblAppPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblAppPath;
		private System.Windows.Forms.TextBox txtAppPath;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblIntegratedUsername;
        private System.Windows.Forms.CheckBox cbIntegratedSecurity;
	}
}