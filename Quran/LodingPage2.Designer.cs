namespace Quran
{
	partial class LodingPage2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LodingPage2));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Location = new System.Drawing.Point(1, 612);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(468, 18);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.SandyBrown;
			this.panel2.Location = new System.Drawing.Point(1, 612);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(48, 18);
			this.panel2.TabIndex = 0;
			// 
			// timer2
			// 
			this.timer2.Enabled = true;
			this.timer2.Interval = 15;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// LodingPage2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(467, 630);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(483, 630);
			this.Name = "LodingPage2";
			this.Text = "LodingPage2";
			this.Load += new System.EventHandler(this.LodingPage2_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Timer timer2;
	}
}