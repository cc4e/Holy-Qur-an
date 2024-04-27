namespace Quran
{
    partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.usernameLogin_box = new Guna.UI2.WinForms.Guna2TextBox();
			this.passwordLogin_box = new Guna.UI2.WinForms.Guna2TextBox();
			this.login_button = new Guna.UI2.WinForms.Guna2GradientButton();
			this.Register_button = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(709, 641);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// usernameLogin_box
			// 
			this.usernameLogin_box.BackColor = System.Drawing.Color.Transparent;
			this.usernameLogin_box.BorderColor = System.Drawing.Color.Gold;
			this.usernameLogin_box.BorderRadius = 24;
			this.usernameLogin_box.BorderThickness = 3;
			this.usernameLogin_box.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.usernameLogin_box.DefaultText = "";
			this.usernameLogin_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.usernameLogin_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.usernameLogin_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.usernameLogin_box.DisabledState.Parent = this.usernameLogin_box;
			this.usernameLogin_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.usernameLogin_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.usernameLogin_box.FocusedState.Parent = this.usernameLogin_box;
			this.usernameLogin_box.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameLogin_box.ForeColor = System.Drawing.Color.Chocolate;
			this.usernameLogin_box.HoverState.BorderColor = System.Drawing.Color.DarkOrange;
			this.usernameLogin_box.HoverState.Parent = this.usernameLogin_box;
			this.usernameLogin_box.IconLeft = ((System.Drawing.Image)(resources.GetObject("usernameLogin_box.IconLeft")));
			this.usernameLogin_box.IconLeftOffset = new System.Drawing.Point(7, 0);
			this.usernameLogin_box.IconLeftSize = new System.Drawing.Size(30, 30);
			this.usernameLogin_box.Location = new System.Drawing.Point(249, 335);
			this.usernameLogin_box.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.usernameLogin_box.Name = "usernameLogin_box";
			this.usernameLogin_box.PasswordChar = '\0';
			this.usernameLogin_box.PlaceholderForeColor = System.Drawing.Color.Red;
			this.usernameLogin_box.PlaceholderText = "USERNAME";
			this.usernameLogin_box.SelectedText = "";
			this.usernameLogin_box.ShadowDecoration.Parent = this.usernameLogin_box;
			this.usernameLogin_box.Size = new System.Drawing.Size(249, 53);
			this.usernameLogin_box.TabIndex = 2;
			this.usernameLogin_box.TextOffset = new System.Drawing.Point(20, 0);
			// 
			// passwordLogin_box
			// 
			this.passwordLogin_box.BackColor = System.Drawing.Color.Transparent;
			this.passwordLogin_box.BorderColor = System.Drawing.Color.Gold;
			this.passwordLogin_box.BorderRadius = 24;
			this.passwordLogin_box.BorderThickness = 3;
			this.passwordLogin_box.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.passwordLogin_box.DefaultText = "";
			this.passwordLogin_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.passwordLogin_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.passwordLogin_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.passwordLogin_box.DisabledState.Parent = this.passwordLogin_box;
			this.passwordLogin_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.passwordLogin_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.passwordLogin_box.FocusedState.Parent = this.passwordLogin_box;
			this.passwordLogin_box.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordLogin_box.ForeColor = System.Drawing.Color.Chocolate;
			this.passwordLogin_box.HoverState.BorderColor = System.Drawing.Color.DarkOrange;
			this.passwordLogin_box.HoverState.Parent = this.passwordLogin_box;
			this.passwordLogin_box.IconLeft = ((System.Drawing.Image)(resources.GetObject("passwordLogin_box.IconLeft")));
			this.passwordLogin_box.IconLeftOffset = new System.Drawing.Point(9, 2);
			this.passwordLogin_box.IconLeftSize = new System.Drawing.Size(22, 22);
			this.passwordLogin_box.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.passwordLogin_box.Location = new System.Drawing.Point(249, 465);
			this.passwordLogin_box.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.passwordLogin_box.Name = "passwordLogin_box";
			this.passwordLogin_box.PasswordChar = '\0';
			this.passwordLogin_box.PlaceholderForeColor = System.Drawing.Color.Red;
			this.passwordLogin_box.PlaceholderText = "PASSWORD";
			this.passwordLogin_box.SelectedText = "";
			this.passwordLogin_box.ShadowDecoration.Parent = this.passwordLogin_box;
			this.passwordLogin_box.Size = new System.Drawing.Size(249, 53);
			this.passwordLogin_box.TabIndex = 2;
			this.passwordLogin_box.TextOffset = new System.Drawing.Point(20, 0);
			this.passwordLogin_box.UseSystemPasswordChar = true;
			// 
			// login_button
			// 
			this.login_button.BackColor = System.Drawing.Color.Transparent;
			this.login_button.BorderRadius = 24;
			this.login_button.CheckedState.Parent = this.login_button;
			this.login_button.CustomImages.Parent = this.login_button;
			this.login_button.FillColor = System.Drawing.Color.Peru;
			this.login_button.FillColor2 = System.Drawing.Color.Orange;
			this.login_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_button.ForeColor = System.Drawing.Color.Black;
			this.login_button.HoverState.Parent = this.login_button;
			this.login_button.Location = new System.Drawing.Point(288, 582);
			this.login_button.Name = "login_button";
			this.login_button.ShadowDecoration.Parent = this.login_button;
			this.login_button.Size = new System.Drawing.Size(171, 34);
			this.login_button.TabIndex = 3;
			this.login_button.Text = "LOGIN";
			this.login_button.Click += new System.EventHandler(this.login_button_Click);
			// 
			// Register_button
			// 
			this.Register_button.BackColor = System.Drawing.Color.Transparent;
			this.Register_button.BorderRadius = 24;
			this.Register_button.CheckedState.Parent = this.Register_button;
			this.Register_button.CustomImages.Parent = this.Register_button;
			this.Register_button.FillColor = System.Drawing.Color.MistyRose;
			this.Register_button.FillColor2 = System.Drawing.Color.Silver;
			this.Register_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Register_button.ForeColor = System.Drawing.Color.Black;
			this.Register_button.HoverState.Parent = this.Register_button;
			this.Register_button.Location = new System.Drawing.Point(25, 598);
			this.Register_button.Name = "Register_button";
			this.Register_button.ShadowDecoration.Parent = this.Register_button;
			this.Register_button.Size = new System.Drawing.Size(100, 28);
			this.Register_button.TabIndex = 3;
			this.Register_button.Text = "Register";
			this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 574);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(136, 18);
			this.guna2HtmlLabel1.TabIndex = 4;
			this.guna2HtmlLabel1.Text = "I dont have an account";
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.Location = new System.Drawing.Point(249, 86);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new System.Drawing.Size(249, 222);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 5;
			this.guna2PictureBox1.TabStop = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(709, 641);
			this.Controls.Add(this.guna2PictureBox1);
			this.Controls.Add(this.guna2HtmlLabel1);
			this.Controls.Add(this.Register_button);
			this.Controls.Add(this.login_button);
			this.Controls.Add(this.passwordLogin_box);
			this.Controls.Add(this.usernameLogin_box);
			this.Controls.Add(this.pictureBox1);
			this.MaximumSize = new System.Drawing.Size(725, 680);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(700, 660);
			this.Name = "Login";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "LOGIN ";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox usernameLogin_box;
        private Guna.UI2.WinForms.Guna2TextBox passwordLogin_box;
        private Guna.UI2.WinForms.Guna2GradientButton login_button;
        private Guna.UI2.WinForms.Guna2GradientButton Register_button;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

