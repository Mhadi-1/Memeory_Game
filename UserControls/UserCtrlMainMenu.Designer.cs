namespace MyMemeoryGame.UserControls
{
    partial class UserCtrlMainMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.siticoneShadowPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowPanel();
            this.PcBxSoundMoode = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmSoundOn = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmSoundOf = new System.Windows.Forms.ToolStripMenuItem();
            this.siticoneGradientButton3 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton2 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btnFrocty = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnExit = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBxSoundMoode)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneShadowPanel1
            // 
            this.siticoneShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel1.Controls.Add(this.PcBxSoundMoode);
            this.siticoneShadowPanel1.Controls.Add(this.menuStrip1);
            this.siticoneShadowPanel1.Controls.Add(this.siticoneGradientButton3);
            this.siticoneShadowPanel1.Controls.Add(this.siticoneGradientButton2);
            this.siticoneShadowPanel1.Controls.Add(this.btnFrocty);
            this.siticoneShadowPanel1.Controls.Add(this.pictureBox3);
            this.siticoneShadowPanel1.Controls.Add(this.pictureBox2);
            this.siticoneShadowPanel1.Controls.Add(this.BtnExit);
            this.siticoneShadowPanel1.Controls.Add(this.pictureBox1);
            this.siticoneShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.siticoneShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneShadowPanel1.Name = "siticoneShadowPanel1";
            this.siticoneShadowPanel1.ShadowColor = System.Drawing.Color.White;
            this.siticoneShadowPanel1.ShadowDepth = 40;
            this.siticoneShadowPanel1.ShadowShift = 30;
            this.siticoneShadowPanel1.Size = new System.Drawing.Size(987, 666);
            this.siticoneShadowPanel1.TabIndex = 0;
            // 
            // PcBxSoundMoode
            // 
            this.PcBxSoundMoode.Image = global::MyMemeoryGame.Properties.Resources.icons8_no_audio_50;
            this.PcBxSoundMoode.ImageRotate = 0F;
            this.PcBxSoundMoode.Location = new System.Drawing.Point(935, 12);
            this.PcBxSoundMoode.Name = "PcBxSoundMoode";
            this.PcBxSoundMoode.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.PcBxSoundMoode.Size = new System.Drawing.Size(40, 28);
            this.PcBxSoundMoode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcBxSoundMoode.TabIndex = 19;
            this.PcBxSoundMoode.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsMenuItems});
            this.menuStrip1.Location = new System.Drawing.Point(22, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(228, 32);
            this.menuStrip1.TabIndex = 18;
            // 
            // SettingsMenuItems
            // 
            this.SettingsMenuItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingsMenuItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItmSoundOn,
            this.ItmSoundOf});
            this.SettingsMenuItems.Image = global::MyMemeoryGame.Properties.Resources.icons8_setting;
            this.SettingsMenuItems.Name = "SettingsMenuItems";
            this.SettingsMenuItems.Size = new System.Drawing.Size(40, 28);
            this.SettingsMenuItems.Click += new System.EventHandler(this.SettingsMenuItems_Click);
            // 
            // ItmSoundOn
            // 
            this.ItmSoundOn.AutoToolTip = true;
            this.ItmSoundOn.Image = global::MyMemeoryGame.Properties.Resources.icons8_voice_50;
            this.ItmSoundOn.Name = "ItmSoundOn";
            this.ItmSoundOn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ItmSoundOn.Size = new System.Drawing.Size(270, 34);
            this.ItmSoundOn.Text = "On";
            this.ItmSoundOn.ToolTipText = "Sound On";
            this.ItmSoundOn.Click += new System.EventHandler(this.SoundOnMenuItem_Click);
            // 
            // ItmSoundOf
            // 
            this.ItmSoundOf.Checked = true;
            this.ItmSoundOf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ItmSoundOf.Image = global::MyMemeoryGame.Properties.Resources.icons8_no_audio_50;
            this.ItmSoundOf.Name = "ItmSoundOf";
            this.ItmSoundOf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ItmSoundOf.Size = new System.Drawing.Size(270, 34);
            this.ItmSoundOf.Text = "Of";
            this.ItmSoundOf.ToolTipText = "Sound Off";
            this.ItmSoundOf.Click += new System.EventHandler(this.ItmSoundOf_Click);
            // 
            // siticoneGradientButton3
            // 
            this.siticoneGradientButton3.Animated = true;
            this.siticoneGradientButton3.AutoRoundedCorners = true;
            this.siticoneGradientButton3.BorderRadius = 19;
            this.siticoneGradientButton3.CheckedState.BorderColor = System.Drawing.Color.White;
            this.siticoneGradientButton3.CheckedState.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneGradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(100)))), ((int)(((byte)(123)))));
            this.siticoneGradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(100)))), ((int)(((byte)(123)))));
            this.siticoneGradientButton3.Font = new System.Drawing.Font("Algerian", 14F);
            this.siticoneGradientButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton3.HoverState.BorderColor = System.Drawing.Color.White;
            this.siticoneGradientButton3.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton3.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.siticoneGradientButton3.HoverState.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.siticoneGradientButton3.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton3.Location = new System.Drawing.Point(23, 437);
            this.siticoneGradientButton3.Name = "siticoneGradientButton3";
            this.siticoneGradientButton3.PressedColor = System.Drawing.Color.DodgerBlue;
            this.siticoneGradientButton3.PressedDepth = 50;
            this.siticoneGradientButton3.Size = new System.Drawing.Size(298, 41);
            this.siticoneGradientButton3.TabIndex = 16;
            this.siticoneGradientButton3.Text = "Animales";
            this.siticoneGradientButton3.Click += new System.EventHandler(this.siticoneGradientButton3_Click);
            this.siticoneGradientButton3.MouseLeave += new System.EventHandler(this.BtnSelected_MouseLeave);
            this.siticoneGradientButton3.MouseHover += new System.EventHandler(this.BtnSelected_MouseHover);
            // 
            // siticoneGradientButton2
            // 
            this.siticoneGradientButton2.Animated = true;
            this.siticoneGradientButton2.AutoRoundedCorners = true;
            this.siticoneGradientButton2.BorderRadius = 19;
            this.siticoneGradientButton2.CheckedState.BorderColor = System.Drawing.Color.White;
            this.siticoneGradientButton2.CheckedState.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneGradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(100)))), ((int)(((byte)(123)))));
            this.siticoneGradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(100)))), ((int)(((byte)(123)))));
            this.siticoneGradientButton2.Font = new System.Drawing.Font("Algerian", 14F);
            this.siticoneGradientButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton2.HoverState.BorderColor = System.Drawing.Color.White;
            this.siticoneGradientButton2.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton2.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.siticoneGradientButton2.HoverState.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.siticoneGradientButton2.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton2.Location = new System.Drawing.Point(339, 437);
            this.siticoneGradientButton2.Name = "siticoneGradientButton2";
            this.siticoneGradientButton2.PressedColor = System.Drawing.Color.DodgerBlue;
            this.siticoneGradientButton2.PressedDepth = 50;
            this.siticoneGradientButton2.Size = new System.Drawing.Size(298, 41);
            this.siticoneGradientButton2.TabIndex = 15;
            this.siticoneGradientButton2.Text = "Clothes";
            this.siticoneGradientButton2.MouseLeave += new System.EventHandler(this.BtnSelected_MouseLeave);
            this.siticoneGradientButton2.MouseHover += new System.EventHandler(this.BtnSelected_MouseHover);
            // 
            // btnFrocty
            // 
            this.btnFrocty.Animated = true;
            this.btnFrocty.AutoRoundedCorners = true;
            this.btnFrocty.BorderRadius = 19;
            this.btnFrocty.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnFrocty.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnFrocty.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFrocty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFrocty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFrocty.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFrocty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFrocty.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(100)))), ((int)(((byte)(123)))));
            this.btnFrocty.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(100)))), ((int)(((byte)(123)))));
            this.btnFrocty.Font = new System.Drawing.Font("Algerian", 14F);
            this.btnFrocty.ForeColor = System.Drawing.Color.White;
            this.btnFrocty.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnFrocty.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnFrocty.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnFrocty.HoverState.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnFrocty.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnFrocty.Location = new System.Drawing.Point(654, 437);
            this.btnFrocty.Name = "btnFrocty";
            this.btnFrocty.PressedColor = System.Drawing.Color.DodgerBlue;
            this.btnFrocty.PressedDepth = 50;
            this.btnFrocty.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.btnFrocty.Size = new System.Drawing.Size(298, 41);
            this.btnFrocty.TabIndex = 14;
            this.btnFrocty.Text = "Forcty";
            this.btnFrocty.MouseLeave += new System.EventHandler(this.BtnSelected_MouseLeave);
            this.btnFrocty.MouseHover += new System.EventHandler(this.BtnSelected_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MyMemeoryGame.Properties.Resources.f238bb6d_824d_4a11_9a9e_923f45f1b3e0;
            this.pictureBox3.Location = new System.Drawing.Point(654, 111);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(297, 320);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MyMemeoryGame.Properties.Resources._8494573;
            this.pictureBox2.Location = new System.Drawing.Point(339, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 320);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.Animated = true;
            this.BtnExit.AutoRoundedCorners = true;
            this.BtnExit.BorderRadius = 17;
            this.BtnExit.CheckedState.BorderColor = System.Drawing.Color.White;
            this.BtnExit.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnExit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(100)))), ((int)(((byte)(123)))));
            this.BtnExit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(100)))), ((int)(((byte)(123)))));
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.HoverState.BorderColor = System.Drawing.Color.White;
            this.BtnExit.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.BtnExit.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnExit.HoverState.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.BtnExit.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(22, 578);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedColor = System.Drawing.Color.DodgerBlue;
            this.BtnExit.PressedDepth = 50;
            this.BtnExit.Size = new System.Drawing.Size(102, 36);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Back";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MyMemeoryGame.Properties.Resources._466e0072_556f_4b2a_9110_c5e95a31f033;
            this.pictureBox1.Location = new System.Drawing.Point(23, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserCtrlMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.siticoneShadowPanel1);
            this.Name = "UserCtrlMainMenu";
            this.Size = new System.Drawing.Size(987, 666);
            this.siticoneShadowPanel1.ResumeLayout(false);
            this.siticoneShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBxSoundMoode)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton BtnExit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnFrocty;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItems;
        private System.Windows.Forms.ToolStripMenuItem ItmSoundOn;
        private System.Windows.Forms.ToolStripMenuItem ItmSoundOf;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox PcBxSoundMoode;
    }
}
