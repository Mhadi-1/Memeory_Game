using MyMemeoryGame.GeneralCls;
using MyMemeoryGame.Properties;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMemeoryGame.UserControls
{
    public partial class UserCtrlMainMenu : UserControl
    {

        string CurrentSelectedText = "";
        void ShowGameCountDownFrm()
        {
            ClsGeneral.GameCountDownCntrl = new UserControlGameCountDown();
            ClsGeneral.headCtrl.Controls.Add(ClsGeneral.GameCountDownCntrl);
            ClsGeneral.GameCountDownCntrl.Visible = true;
            ClsGeneral.GameCountDownCntrl.BringToFront();

        }

        public UserCtrlMainMenu()
        {
            InitializeComponent();
        }

        private void BtnSelected_MouseHover(object sender, EventArgs e)
        {
            CurrentSelectedText = ((SiticoneGradientButton)sender).Text.ToString();
            ((SiticoneGradientButton)sender).Text = "Start";
        }
        private void BtnSelected_MouseLeave(object sender, EventArgs e)
        {
            if (((SiticoneGradientButton)sender).Text == "Start")
            {
                ((SiticoneGradientButton)sender).Text = CurrentSelectedText.ToString();
                return;
            }
        }
        private void SoundOnMenuItem_Click(object sender, EventArgs e)
        {
            ItmSoundOn.Checked = true;
            ItmSoundOf.Checked = !ItmSoundOn.Checked;
            PcBxSoundMoode.Image = ItmSoundOn.Image;
            ClsGeneral.GameSound(true);
        }
        private void ItmSoundOf_Click(object sender, EventArgs e)
        {
            ItmSoundOf.Checked = true;
            ItmSoundOn.Checked = !ItmSoundOf.Checked;
            PcBxSoundMoode.Image = ItmSoundOf.Image;
            ClsGeneral.GameSound(false);
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            ClsGeneral.headCtrl.Visible = false;

        }
        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        { 
            
            ShowGameCountDownFrm();
        }

        private void SettingsMenuItems_Click(object sender, EventArgs e)
        {

        }
    }
}
