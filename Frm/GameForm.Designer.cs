namespace MyMemeoryGame
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmSoundOn = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmSoundOf = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn8 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn7 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn12 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn11 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn10 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn9 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn4 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn3 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn6 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn5 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn14 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn13 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn2 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn1 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn16 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btn15 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnExit = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblCounter = new System.Windows.Forms.Label();
            this.timerCountToCoverBtn = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(48, 32);
            this.menuStrip1.TabIndex = 20;
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
            // 
            // ItmSoundOn
            // 
            this.ItmSoundOn.AutoToolTip = true;
            this.ItmSoundOn.Image = global::MyMemeoryGame.Properties.Resources.icons8_voice_50;
            this.ItmSoundOn.Name = "ItmSoundOn";
            this.ItmSoundOn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ItmSoundOn.Size = new System.Drawing.Size(138, 34);
            this.ItmSoundOn.Text = "On";
            this.ItmSoundOn.ToolTipText = "Sound On";
            this.ItmSoundOn.Click += new System.EventHandler(this.ItmSoundOn_Click);
            // 
            // ItmSoundOf
            // 
            this.ItmSoundOf.Checked = true;
            this.ItmSoundOf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ItmSoundOf.Image = global::MyMemeoryGame.Properties.Resources.icons8_no_audio_50;
            this.ItmSoundOf.Name = "ItmSoundOf";
            this.ItmSoundOf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ItmSoundOf.Size = new System.Drawing.Size(138, 34);
            this.ItmSoundOf.Text = "Of";
            this.ItmSoundOf.ToolTipText = "Sound Off";
            this.ItmSoundOf.Click += new System.EventHandler(this.ItmSoundOf_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn12);
            this.panel1.Controls.Add(this.btn11);
            this.panel1.Controls.Add(this.btn10);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn14);
            this.panel1.Controls.Add(this.btn13);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn16);
            this.panel1.Controls.Add(this.btn15);
            this.panel1.Location = new System.Drawing.Point(186, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 625);
            this.panel1.TabIndex = 36;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn8.Enabled = false;
            this.btn8.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn8.Image = ((System.Drawing.Image)(resources.GetObject("btn8.Image")));
            this.btn8.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn8.ImageRotate = 0F;
            this.btn8.ImageSize = new System.Drawing.Size(90, 90);
            this.btn8.Location = new System.Drawing.Point(471, 160);
            this.btn8.Name = "btn8";
            this.btn8.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn8.Size = new System.Drawing.Size(148, 150);
            this.btn8.TabIndex = 15;
            this.btn8.Tag = "4";
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn7.Enabled = false;
            this.btn7.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn7.Image = ((System.Drawing.Image)(resources.GetObject("btn7.Image")));
            this.btn7.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn7.ImageRotate = 0F;
            this.btn7.ImageSize = new System.Drawing.Size(90, 90);
            this.btn7.Location = new System.Drawing.Point(317, 160);
            this.btn7.Name = "btn7";
            this.btn7.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn7.Size = new System.Drawing.Size(148, 150);
            this.btn7.TabIndex = 14;
            this.btn7.Tag = "4";
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.White;
            this.btn12.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn12.Enabled = false;
            this.btn12.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn12.Image = ((System.Drawing.Image)(resources.GetObject("btn12.Image")));
            this.btn12.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn12.ImageRotate = 0F;
            this.btn12.ImageSize = new System.Drawing.Size(90, 90);
            this.btn12.Location = new System.Drawing.Point(471, 316);
            this.btn12.Name = "btn12";
            this.btn12.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn12.Size = new System.Drawing.Size(148, 150);
            this.btn12.TabIndex = 13;
            this.btn12.Tag = "6";
            this.btn12.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.White;
            this.btn11.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn11.Enabled = false;
            this.btn11.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn11.Image = ((System.Drawing.Image)(resources.GetObject("btn11.Image")));
            this.btn11.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn11.ImageRotate = 0F;
            this.btn11.ImageSize = new System.Drawing.Size(90, 90);
            this.btn11.Location = new System.Drawing.Point(317, 316);
            this.btn11.Name = "btn11";
            this.btn11.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn11.Size = new System.Drawing.Size(148, 150);
            this.btn11.TabIndex = 12;
            this.btn11.Tag = "6";
            this.btn11.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.White;
            this.btn10.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn10.Enabled = false;
            this.btn10.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn10.Image = ((System.Drawing.Image)(resources.GetObject("btn10.Image")));
            this.btn10.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn10.ImageRotate = 0F;
            this.btn10.ImageSize = new System.Drawing.Size(90, 90);
            this.btn10.Location = new System.Drawing.Point(163, 316);
            this.btn10.Name = "btn10";
            this.btn10.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn10.Size = new System.Drawing.Size(148, 150);
            this.btn10.TabIndex = 11;
            this.btn10.Tag = "5";
            this.btn10.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn9.Enabled = false;
            this.btn9.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn9.Image = ((System.Drawing.Image)(resources.GetObject("btn9.Image")));
            this.btn9.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn9.ImageRotate = 0F;
            this.btn9.ImageSize = new System.Drawing.Size(90, 90);
            this.btn9.Location = new System.Drawing.Point(9, 316);
            this.btn9.Name = "btn9";
            this.btn9.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn9.Size = new System.Drawing.Size(148, 150);
            this.btn9.TabIndex = 10;
            this.btn9.Tag = "5";
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn4.Enabled = false;
            this.btn4.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn4.Image = global::MyMemeoryGame.Properties.Resources.cover;
            this.btn4.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn4.ImageRotate = 0F;
            this.btn4.ImageSize = new System.Drawing.Size(90, 90);
            this.btn4.Location = new System.Drawing.Point(471, 4);
            this.btn4.Name = "btn4";
            this.btn4.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn4.Size = new System.Drawing.Size(148, 150);
            this.btn4.TabIndex = 9;
            this.btn4.Tag = "2";
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn3.Enabled = false;
            this.btn3.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn3.ImageRotate = 0F;
            this.btn3.ImageSize = new System.Drawing.Size(90, 90);
            this.btn3.Location = new System.Drawing.Point(317, 4);
            this.btn3.Name = "btn3";
            this.btn3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn3.Size = new System.Drawing.Size(148, 150);
            this.btn3.TabIndex = 8;
            this.btn3.Tag = "2";
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn6.Enabled = false;
            this.btn6.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn6.Image = ((System.Drawing.Image)(resources.GetObject("btn6.Image")));
            this.btn6.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn6.ImageRotate = 0F;
            this.btn6.ImageSize = new System.Drawing.Size(90, 90);
            this.btn6.Location = new System.Drawing.Point(163, 160);
            this.btn6.Name = "btn6";
            this.btn6.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn6.Size = new System.Drawing.Size(148, 150);
            this.btn6.TabIndex = 7;
            this.btn6.Tag = "3";
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn5.Enabled = false;
            this.btn5.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn5.ImageRotate = 0F;
            this.btn5.ImageSize = new System.Drawing.Size(90, 90);
            this.btn5.Location = new System.Drawing.Point(9, 160);
            this.btn5.Name = "btn5";
            this.btn5.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn5.Size = new System.Drawing.Size(148, 150);
            this.btn5.TabIndex = 6;
            this.btn5.Tag = "3";
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn14
            // 
            this.btn14.BackColor = System.Drawing.Color.White;
            this.btn14.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn14.Enabled = false;
            this.btn14.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn14.Image = ((System.Drawing.Image)(resources.GetObject("btn14.Image")));
            this.btn14.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn14.ImageRotate = 0F;
            this.btn14.ImageSize = new System.Drawing.Size(90, 90);
            this.btn14.Location = new System.Drawing.Point(163, 472);
            this.btn14.Name = "btn14";
            this.btn14.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn14.Size = new System.Drawing.Size(148, 150);
            this.btn14.TabIndex = 5;
            this.btn14.Tag = "7";
            this.btn14.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.White;
            this.btn13.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn13.Enabled = false;
            this.btn13.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn13.Image = ((System.Drawing.Image)(resources.GetObject("btn13.Image")));
            this.btn13.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn13.ImageRotate = 0F;
            this.btn13.ImageSize = new System.Drawing.Size(90, 90);
            this.btn13.Location = new System.Drawing.Point(9, 472);
            this.btn13.Name = "btn13";
            this.btn13.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn13.Size = new System.Drawing.Size(148, 150);
            this.btn13.TabIndex = 4;
            this.btn13.Tag = "7";
            this.btn13.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn2.Enabled = false;
            this.btn2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn2.ImageRotate = 0F;
            this.btn2.ImageSize = new System.Drawing.Size(90, 90);
            this.btn2.Location = new System.Drawing.Point(163, 4);
            this.btn2.Name = "btn2";
            this.btn2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn2.Size = new System.Drawing.Size(148, 150);
            this.btn2.TabIndex = 3;
            this.btn2.Tag = "1";
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn1.Enabled = false;
            this.btn1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn1.ImageRotate = 0F;
            this.btn1.ImageSize = new System.Drawing.Size(90, 90);
            this.btn1.Location = new System.Drawing.Point(9, 4);
            this.btn1.Name = "btn1";
            this.btn1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn1.Size = new System.Drawing.Size(148, 150);
            this.btn1.TabIndex = 2;
            this.btn1.Tag = "1";
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn16
            // 
            this.btn16.BackColor = System.Drawing.Color.White;
            this.btn16.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn16.Enabled = false;
            this.btn16.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn16.Image = ((System.Drawing.Image)(resources.GetObject("btn16.Image")));
            this.btn16.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn16.ImageRotate = 0F;
            this.btn16.ImageSize = new System.Drawing.Size(90, 90);
            this.btn16.Location = new System.Drawing.Point(471, 472);
            this.btn16.Name = "btn16";
            this.btn16.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn16.Size = new System.Drawing.Size(148, 150);
            this.btn16.TabIndex = 1;
            this.btn16.Tag = "8";
            this.btn16.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.Color.White;
            this.btn15.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn15.Enabled = false;
            this.btn15.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn15.Image = ((System.Drawing.Image)(resources.GetObject("btn15.Image")));
            this.btn15.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn15.ImageRotate = 0F;
            this.btn15.ImageSize = new System.Drawing.Size(90, 90);
            this.btn15.Location = new System.Drawing.Point(317, 472);
            this.btn15.Name = "btn15";
            this.btn15.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn15.Size = new System.Drawing.Size(148, 150);
            this.btn15.TabIndex = 0;
            this.btn15.Tag = "8";
            this.btn15.Click += new System.EventHandler(this.btn_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
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
            this.BtnExit.TabIndex = 37;
            this.BtnExit.Text = "Back";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "img1.jpg");
            this.imageList1.Images.SetKeyName(1, "img2.jpg");
            this.imageList1.Images.SetKeyName(2, "img3.jpg");
            this.imageList1.Images.SetKeyName(3, "img4.jpg");
            this.imageList1.Images.SetKeyName(4, "img5.jpg");
            this.imageList1.Images.SetKeyName(5, "img6.jpg");
            this.imageList1.Images.SetKeyName(6, "img7.jpg");
            this.imageList1.Images.SetKeyName(7, "img8.jpg");
            this.imageList1.Images.SetKeyName(8, "img9.jpg");
            this.imageList1.Images.SetKeyName(9, "img10.jpg");
            this.imageList1.Images.SetKeyName(10, "img11.png");
            this.imageList1.Images.SetKeyName(11, "img12.png");
            // 
            // lblCounter
            // 
            this.lblCounter.BackColor = System.Drawing.Color.Maroon;
            this.lblCounter.Font = new System.Drawing.Font("Ravie", 20F);
            this.lblCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblCounter.Location = new System.Drawing.Point(856, 13);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(83, 54);
            this.lblCounter.TabIndex = 38;
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCountToCoverBtn
            // 
            this.timerCountToCoverBtn.Interval = 500;
            this.timerCountToCoverBtn.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 678);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItems;
        private System.Windows.Forms.ToolStripMenuItem ItmSoundOn;
        private System.Windows.Forms.ToolStripMenuItem ItmSoundOf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer GameTimer;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton BtnExit;
        private System.Windows.Forms.ImageList imageList1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn6;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn5;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn14;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn13;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn2;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn16;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn15;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn8;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn7;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn12;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn11;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn10;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn9;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn4;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btn3;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Timer timerCountToCoverBtn;
    }
}