namespace MyMemeoryGame.UserControls
{
    partial class UserControlGameCountDown
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
            this.components = new System.ComponentModel.Container();
            this.BtnCountDown = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnExit = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.SuspendLayout();
            // 
            // BtnCountDown
            // 
            this.BtnCountDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCountDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCountDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCountDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCountDown.Font = new System.Drawing.Font("Segoe UI", 29F);
            this.BtnCountDown.ForeColor = System.Drawing.Color.White;
            this.BtnCountDown.Location = new System.Drawing.Point(395, 182);
            this.BtnCountDown.Name = "BtnCountDown";
            this.BtnCountDown.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.BtnCountDown.Size = new System.Drawing.Size(221, 213);
            this.BtnCountDown.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "Back";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // UserControlGameCountDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCountDown);
            this.Name = "UserControlGameCountDown";
            this.Size = new System.Drawing.Size(987, 666);
            this.Load += new System.EventHandler(this.UserControlGameCountDown_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton BtnCountDown;
        private System.Windows.Forms.Timer timer1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton BtnExit;
    }
}
