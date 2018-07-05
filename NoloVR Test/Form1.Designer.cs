namespace NoloVR_Test
{
	partial class Form1
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
			this.buttonConnect = new System.Windows.Forms.Button();
			this.timerUpdate = new System.Windows.Forms.Timer(this.components);
			this.labelStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(23, 12);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(75, 23);
			this.buttonConnect.TabIndex = 0;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// timerUpdate
			// 
			this.timerUpdate.Enabled = true;
			this.timerUpdate.Interval = 50;
			this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Location = new System.Drawing.Point(20, 81);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(46, 13);
			this.labelStatus.TabIndex = 1;
			this.labelStatus.Text = "Status...";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 445);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.buttonConnect);
			this.Name = "Form1";
			this.Text = "NOLO VR Test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Timer timerUpdate;
		private System.Windows.Forms.Label labelStatus;
	}
}

