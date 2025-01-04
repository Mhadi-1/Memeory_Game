namespace MyMemeoryGame.UserControls
{
    partial class UserCtrlFrmProgress
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
            this.ProgressIndicator = new Siticone.Desktop.UI.WinForms.SiticoneProgressIndicator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.realTimeSource1 = new DevExpress.Data.RealTimeSource();
            this.SuspendLayout();
            // 
            // ProgressIndicator
            // 
            this.ProgressIndicator.AutoStart = true;
            this.ProgressIndicator.Location = new System.Drawing.Point(441, 144);
            this.ProgressIndicator.Name = "ProgressIndicator";
            this.ProgressIndicator.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(100)))), ((int)(((byte)(123)))));
            this.ProgressIndicator.Size = new System.Drawing.Size(104, 99);
            this.ProgressIndicator.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(397, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Progress loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(446, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Waite";
            // 
            // timerCountToCoverBtn
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // realTimeSource1
            // 
            this.realTimeSource1.DisplayableProperties = null;
            // 
            // UserCtrlFrmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressIndicator);
            this.Name = "UserCtrlFrmProgress";
            this.Size = new System.Drawing.Size(987, 666);
            this.Load += new System.EventHandler(this.UserCtrlProgress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneProgressIndicator ProgressIndicator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.Data.RealTimeSource realTimeSource1;
    }
}
