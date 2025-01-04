namespace MyMemeoryGame
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
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnNext = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.TxtBxUserName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.BtnExit = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnSingIn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.TxtBxPassWord = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.AnimateWindow = true;
            this.siticoneBorderlessForm1.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm.AnimateWindowType.AW_HOR_NEGATIVE;
            this.siticoneBorderlessForm1.BorderRadius = 5;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockForm = false;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.DragStartTransparencyValue = 1D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(100)))), ((int)(((byte)(123)))));
            this.label2.Location = new System.Drawing.Point(-2, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(988, 68);
            this.label2.TabIndex = 3;
            this.label2.Text = "Memeory Game";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Algerian", 14F);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(199, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(587, 68);
            this.label3.TabIndex = 4;
            this.label3.Text = "ENTER YOUR NAME PLEASE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnNext
            // 
            this.BtnNext.Animated = true;
            this.BtnNext.AutoRoundedCorners = true;
            this.BtnNext.BorderRadius = 17;
            this.BtnNext.CheckedState.BorderColor = System.Drawing.Color.White;
            this.BtnNext.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnNext.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(100)))), ((int)(((byte)(123)))));
            this.BtnNext.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(100)))), ((int)(((byte)(123)))));
            this.BtnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnNext.ForeColor = System.Drawing.Color.White;
            this.BtnNext.HoverState.BorderColor = System.Drawing.Color.White;
            this.BtnNext.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.BtnNext.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnNext.HoverState.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.BtnNext.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnNext.Location = new System.Drawing.Point(831, 563);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.PressedColor = System.Drawing.Color.DodgerBlue;
            this.BtnNext.PressedDepth = 50;
            this.BtnNext.Size = new System.Drawing.Size(102, 36);
            this.BtnNext.TabIndex = 3;
            this.BtnNext.Text = "Next";
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // TxtBxUserName
            // 
            this.TxtBxUserName.Animated = true;
            this.TxtBxUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBxUserName.DefaultText = "";
            this.TxtBxUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBxUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBxUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxUserName.FocusedState.BorderColor = System.Drawing.Color.IndianRed;
            this.TxtBxUserName.FocusedState.PlaceholderForeColor = System.Drawing.Color.IndianRed;
            this.TxtBxUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(98)))));
            this.TxtBxUserName.HoverState.BorderColor = System.Drawing.Color.IndianRed;
            this.TxtBxUserName.HoverState.PlaceholderForeColor = System.Drawing.Color.IndianRed;
            this.TxtBxUserName.Location = new System.Drawing.Point(312, 336);
            this.TxtBxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBxUserName.MaxLength = 37;
            this.TxtBxUserName.Name = "TxtBxUserName";
            this.TxtBxUserName.PasswordChar = '\0';
            this.TxtBxUserName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtBxUserName.PlaceholderText = "Name";
            this.TxtBxUserName.SelectedText = "";
            this.TxtBxUserName.Size = new System.Drawing.Size(360, 46);
            this.TxtBxUserName.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.TxtBxUserName.TabIndex = 0;
            this.TxtBxUserName.TabStop = false;
            this.TxtBxUserName.TextChanged += new System.EventHandler(this.TxtBxUserName_TextChanged);
            this.TxtBxUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBxUserName_KeyDown);
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
            this.BtnExit.Location = new System.Drawing.Point(57, 563);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedColor = System.Drawing.Color.DodgerBlue;
            this.BtnExit.PressedDepth = 50;
            this.BtnExit.Size = new System.Drawing.Size(102, 36);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exite";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BtnSingIn
            // 
            this.BtnSingIn.Animated = true;
            this.BtnSingIn.BorderRadius = 10;
            this.BtnSingIn.CheckedState.BorderColor = System.Drawing.Color.White;
            this.BtnSingIn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnSingIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSingIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSingIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSingIn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSingIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSingIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.BtnSingIn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.BtnSingIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSingIn.ForeColor = System.Drawing.Color.White;
            this.BtnSingIn.HoverState.BorderColor = System.Drawing.Color.White;
            this.BtnSingIn.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.BtnSingIn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(100)))), ((int)(((byte)(123)))));
            this.BtnSingIn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(100)))), ((int)(((byte)(123)))));
            this.BtnSingIn.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnSingIn.Location = new System.Drawing.Point(23, 31);
            this.BtnSingIn.Name = "BtnSingIn";
            this.BtnSingIn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.BtnSingIn.PressedDepth = 50;
            this.BtnSingIn.Size = new System.Drawing.Size(102, 36);
            this.BtnSingIn.TabIndex = 1;
            this.BtnSingIn.Text = "Sing In";
            this.BtnSingIn.Click += new System.EventHandler(this.BtnSingIn_Click);
            // 
            // TxtBxPassWord
            // 
            this.TxtBxPassWord.Animated = true;
            this.TxtBxPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBxPassWord.DefaultText = "";
            this.TxtBxPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBxPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBxPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxPassWord.FocusedState.BorderColor = System.Drawing.Color.IndianRed;
            this.TxtBxPassWord.FocusedState.PlaceholderForeColor = System.Drawing.Color.IndianRed;
            this.TxtBxPassWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBxPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(98)))));
            this.TxtBxPassWord.HoverState.BorderColor = System.Drawing.Color.Red;
            this.TxtBxPassWord.HoverState.PlaceholderForeColor = System.Drawing.Color.IndianRed;
            this.TxtBxPassWord.IconRight = global::MyMemeoryGame.Properties.Resources.hide_Password1;
            this.TxtBxPassWord.IconRightOffset = new System.Drawing.Point(4, 0);
            this.TxtBxPassWord.Location = new System.Drawing.Point(312, 424);
            this.TxtBxPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBxPassWord.MaxLength = 32;
            this.TxtBxPassWord.Name = "TxtBxPassWord";
            this.TxtBxPassWord.PasswordChar = '\0';
            this.TxtBxPassWord.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtBxPassWord.PlaceholderText = "PassWord";
            this.TxtBxPassWord.SelectedText = "";
            this.TxtBxPassWord.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.TxtBxPassWord.Size = new System.Drawing.Size(360, 46);
            this.TxtBxPassWord.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.TxtBxPassWord.TabIndex = 2;
            this.TxtBxPassWord.TabStop = false;
            this.TxtBxPassWord.IconRightClick += new System.EventHandler(this.TxtBxPassWord_IconRightClick);
            this.TxtBxPassWord.TextChanged += new System.EventHandler(this.TxtBxPassWord_TextChanged);
            this.TxtBxPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBxPassWord_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 666);
            this.Controls.Add(this.BtnSingIn);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtBxPassWord);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBxUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton BtnNext;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TxtBxUserName;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TxtBxPassWord;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton BtnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton BtnSingIn;
    }
}

