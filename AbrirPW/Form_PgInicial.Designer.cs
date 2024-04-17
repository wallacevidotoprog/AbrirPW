namespace AbrirPW
{
	partial class Form_PgInicial
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
			this.process1 = new System.Diagnostics.Process();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(200, 132);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// process1
			// 
			this.process1.StartInfo.Domain = "";
			this.process1.StartInfo.LoadUserProfile = false;
			this.process1.StartInfo.Password = null;
			this.process1.StartInfo.StandardErrorEncoding = null;
			this.process1.StartInfo.StandardOutputEncoding = null;
			this.process1.StartInfo.UserName = "";
			this.process1.SynchronizingObject = this;
			// 
			// Form_PgInicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::AbrirPW.Properties.Resources.接受任务;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(610, 512);
			this.Controls.Add(this.button1);
			this.DoubleBuffered = true;
			this.Name = "Form_PgInicial";
			this.Text = "Form_PgInicial";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Diagnostics.Process process1;
	}
}