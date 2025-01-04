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
    public partial class UserCtrlFrmProgress : UserControl
    {
       
        

        public enum enCtrlsName { SingInCtrl = 1 , MainMenuCtrl = 2};
        public enCtrlsName AccessCtrlNo;
        byte LoadingProgressCoustTime = 5;


        void ShowUserCtrlFrmSingIn()
        {
            UserCtrlFrmSingIn CtrlSingIn = new UserCtrlFrmSingIn();
            CtrlSingIn.Visible = true;
            this.Controls.Add(CtrlSingIn);
            CtrlSingIn.BringToFront();

        }
        void ShowUserCtrlFrmMainMenu()
        {
            UserCtrlMainMenu MainMenuCtrl = new UserCtrlMainMenu();
            MainMenuCtrl.Visible = true;
            this.Controls.Add(MainMenuCtrl);
            MainMenuCtrl.BringToFront(); 
        }
        void AccessUserCtrl()
        {
           

            switch (AccessCtrlNo)
            {
                case enCtrlsName.SingInCtrl:
                    ShowUserCtrlFrmSingIn();
                    break;
                case enCtrlsName.MainMenuCtrl:
                    ShowUserCtrlFrmMainMenu();
                    break;  
            }
        }

        public UserCtrlFrmProgress()
        {
            InitializeComponent();

        }

        private void UserCtrlProgress_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            ProgressIndicator.Refresh();
            if (LoadingProgressCoustTime == 0)
            {
                timer1.Enabled = false;
                AccessUserCtrl();

                return;
            };
            LoadingProgressCoustTime--;
        }



    }

}
