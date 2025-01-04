namespace MyMemeoryGame.UserControls
{
    partial class UserControlAnimalesfrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siticoneShadowPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowPanel();
            this.PcBxSoundMoode = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.SettingsMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmSoundOn = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmSoundOf = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBxSoundMoode)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(51, 36);
            this.menuStrip1.TabIndex = 19;
            // 
            // siticoneShadowPanel1
            // 
            this.siticoneShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneShadowPanel1.FillColor = System.Drawing.Color.White;
            this.siticoneShadowPanel1.Location = new System.Drawing.Point(637, 0);
            this.siticoneShadowPanel1.Name = "siticoneShadowPanel1";
            this.siticoneShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.siticoneShadowPanel1.ShadowShift = 10;
            this.siticoneShadowPanel1.Size = new System.Drawing.Size(284, 666);
            this.siticoneShadowPanel1.TabIndex = 21;
            this.siticoneShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneShadowPanel1_Paint);
            // 
            // PcBxSoundMoode
            // 
            this.PcBxSoundMoode.Image = global::MyMemeoryGame.Properties.Resources.icons8_no_audio_50;
            this.PcBxSoundMoode.ImageRotate = 0F;
            this.PcBxSoundMoode.Location = new System.Drawing.Point(394, 218);
            this.PcBxSoundMoode.Name = "PcBxSoundMoode";
            this.PcBxSoundMoode.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.PcBxSoundMoode.Size = new System.Drawing.Size(40, 28);
            this.PcBxSoundMoode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcBxSoundMoode.TabIndex = 20;
            this.PcBxSoundMoode.TabStop = false;
            // 
            // SettingsMenuItems
            // 
            this.SettingsMenuItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingsMenuItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItmSoundOn,
            this.ItmSoundOf});
            this.SettingsMenuItems.Image = global::MyMemeoryGame.Properties.Resources.icons8_setting;
            this.SettingsMenuItems.Name = "SettingsMenuItems";
            this.SettingsMenuItems.Size = new System.Drawing.Size(40, 32);
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
            // 
            // UserControlAnimalesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PcBxSoundMoode);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.siticoneShadowPanel1);
            this.Name = "UserControlAnimalesfrm";
            this.Size = new System.Drawing.Size(921, 666);
            this.Load += new System.EventHandler(this.UserControlAnimalesfrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBxSoundMoode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItems;
        private System.Windows.Forms.ToolStripMenuItem ItmSoundOn;
        private System.Windows.Forms.ToolStripMenuItem ItmSoundOf;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox PcBxSoundMoode;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel1;
    }
}
