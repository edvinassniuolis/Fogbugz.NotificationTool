namespace ExecutePY
{
    partial class StartupView
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.psswTxtField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.emailTxtField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.usernameTxtField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.exitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(102)))), ((int)(((byte)(142)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 20);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(102)))), ((int)(((byte)(142)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 21);
            this.panel2.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(102)))), ((int)(((byte)(142)))));
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(102)))), ((int)(((byte)(142)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.BorderRadius = 0;
            this.loginButton.ButtonText = "LOGIN";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButton.Iconimage = null;
            this.loginButton.Iconimage_right = null;
            this.loginButton.Iconimage_right_Selected = null;
            this.loginButton.Iconimage_Selected = null;
            this.loginButton.IconMarginLeft = 0;
            this.loginButton.IconMarginRight = 0;
            this.loginButton.IconRightVisible = true;
            this.loginButton.IconRightZoom = 0D;
            this.loginButton.IconVisible = true;
            this.loginButton.IconZoom = 90D;
            this.loginButton.IsTab = false;
            this.loginButton.Location = new System.Drawing.Point(147, 184);
            this.loginButton.Name = "loginButton";
            this.loginButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(102)))), ((int)(((byte)(142)))));
            this.loginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(102)))), ((int)(((byte)(142)))));
            this.loginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButton.selected = false;
            this.loginButton.Size = new System.Drawing.Size(165, 30);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "LOGIN";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Textcolor = System.Drawing.Color.White;
            this.loginButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // psswTxtField
            // 
            this.psswTxtField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.psswTxtField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.psswTxtField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.psswTxtField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.psswTxtField.HintForeColor = System.Drawing.Color.DimGray;
            this.psswTxtField.HintText = "Password";
            this.psswTxtField.isPassword = true;
            this.psswTxtField.LineFocusedColor = System.Drawing.Color.Blue;
            this.psswTxtField.LineIdleColor = System.Drawing.Color.Gray;
            this.psswTxtField.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.psswTxtField.LineThickness = 3;
            this.psswTxtField.Location = new System.Drawing.Point(147, 145);
            this.psswTxtField.Margin = new System.Windows.Forms.Padding(4);
            this.psswTxtField.Name = "psswTxtField";
            this.psswTxtField.Size = new System.Drawing.Size(254, 32);
            this.psswTxtField.TabIndex = 3;
            this.psswTxtField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emailTxtField
            // 
            this.emailTxtField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.emailTxtField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxtField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.emailTxtField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTxtField.HintForeColor = System.Drawing.Color.DimGray;
            this.emailTxtField.HintText = "E-mail";
            this.emailTxtField.isPassword = false;
            this.emailTxtField.LineFocusedColor = System.Drawing.Color.Blue;
            this.emailTxtField.LineIdleColor = System.Drawing.Color.Gray;
            this.emailTxtField.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.emailTxtField.LineThickness = 3;
            this.emailTxtField.Location = new System.Drawing.Point(147, 108);
            this.emailTxtField.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxtField.Name = "emailTxtField";
            this.emailTxtField.Size = new System.Drawing.Size(254, 32);
            this.emailTxtField.TabIndex = 6;
            this.emailTxtField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // usernameTxtField
            // 
            this.usernameTxtField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.usernameTxtField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxtField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.usernameTxtField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameTxtField.HintForeColor = System.Drawing.Color.DimGray;
            this.usernameTxtField.HintText = "Name Surname";
            this.usernameTxtField.isPassword = false;
            this.usernameTxtField.LineFocusedColor = System.Drawing.Color.Blue;
            this.usernameTxtField.LineIdleColor = System.Drawing.Color.Gray;
            this.usernameTxtField.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.usernameTxtField.LineThickness = 3;
            this.usernameTxtField.Location = new System.Drawing.Point(147, 70);
            this.usernameTxtField.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTxtField.Name = "usernameTxtField";
            this.usernameTxtField.Size = new System.Drawing.Size(254, 32);
            this.usernameTxtField.TabIndex = 7;
            this.usernameTxtField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // exitButton
            // 
            this.exitButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(89)))), ((int)(((byte)(58)))));
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(89)))), ((int)(((byte)(58)))));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.BorderRadius = 0;
            this.exitButton.ButtonText = "EXIT";
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.DisabledColor = System.Drawing.Color.Gray;
            this.exitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.exitButton.Iconimage = null;
            this.exitButton.Iconimage_right = null;
            this.exitButton.Iconimage_right_Selected = null;
            this.exitButton.Iconimage_Selected = null;
            this.exitButton.IconMarginLeft = 0;
            this.exitButton.IconMarginRight = 0;
            this.exitButton.IconRightVisible = true;
            this.exitButton.IconRightZoom = 0D;
            this.exitButton.IconVisible = true;
            this.exitButton.IconZoom = 90D;
            this.exitButton.IsTab = false;
            this.exitButton.Location = new System.Drawing.Point(318, 184);
            this.exitButton.Name = "exitButton";
            this.exitButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(89)))), ((int)(((byte)(58)))));
            this.exitButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(89)))), ((int)(((byte)(58)))));
            this.exitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.exitButton.selected = false;
            this.exitButton.Size = new System.Drawing.Size(83, 30);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "EXIT";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Textcolor = System.Drawing.Color.White;
            this.exitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExecutePY.Properties.Resources.Logomakr_213tKS;
            this.pictureBox1.Location = new System.Drawing.Point(114, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(550, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usernameTxtField);
            this.Controls.Add(this.emailTxtField);
            this.Controls.Add(this.psswTxtField);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartupForm";
            this.Load += new System.EventHandler(this.StartupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton loginButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox psswTxtField;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailTxtField;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usernameTxtField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton exitButton;
    }
}