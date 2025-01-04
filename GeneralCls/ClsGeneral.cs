using MyMemeoryGame.Properties;
using MyMemeoryGame.UserControls;
using Siticone.Desktop.UI.WinForms;
using System.Media; 


namespace MyMemeoryGame.GeneralCls
{
    public class ClsGeneral
    {
        public static UserControlGameCountDown GameCountDownCntrl ;
        public static GameForm gameForm ;
        public static HeadUserCtrls headCtrl;
        public enum enCtrlsName { SingInCtrl = 1  , MainMenuCtrl = 2};
        private static SoundPlayer Sound = new SoundPlayer(@"C:\Users\chmik\Desktop\Memeory Game\MememorygameSound.wav");
     //----------------------------------------------------------
        public static bool GameSound(bool PlaySound = false)
        {
            if (PlaySound)
            {
                Sound.Play();
                return PlaySound;
            }
            Sound.Stop();
            return PlaySound; 
        }
        public static void ShowTextChangedOfTxtBx(SiticoneTextBox textBox)
        {
            if (textBox.IconRight.Tag == "ShowPassword")
            {
                return;
            }
            textBox.IconRight = Resources.hide_Password;
            textBox.IconRight.Tag = "HidePassword";
            textBox.UseSystemPasswordChar = true;
        }
        public static void ShowOrHideTextOfTxtBxByIconeClick(SiticoneTextBox textBox)
        {
            if (textBox.UseSystemPasswordChar)
            {
                textBox.UseSystemPasswordChar = false;
                textBox.IconRight = Resources.show_password;
                textBox.IconRight.Tag = "ShowPassword";
                return;
            }
            else
            {
                textBox.UseSystemPasswordChar = true;
                textBox.IconRight = Resources.hide_Password;
                textBox.IconRight.Tag = "HidePassword";
            }
        }
        public static bool IsTxtBxEmpty(SiticoneTextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return true;
            }
            return false;
        }
        public static void AccessUserCtrlByCtrlName(enCtrlsName CntrlNumber)
        {
           
            headCtrl = new HeadUserCtrls();
            UserCtrlFrmProgress CtrlProgressing = new UserCtrlFrmProgress();
            CtrlProgressing.AccessCtrlNo = (UserCtrlFrmProgress.enCtrlsName)CntrlNumber;
            headCtrl.Controls.Add(CtrlProgressing);
            headCtrl.Visible = true;
            headCtrl.BringToFront();
           
        }
     
    }
}
