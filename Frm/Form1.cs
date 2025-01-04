
using MyMemeoryGame.GeneralCls;
using MyMemeoryGame.Properties;
using MyMemeoryGame.UserControls;
using Siticone.Desktop.UI.WinForms;
using System.Windows.Forms;

namespace MyMemeoryGame
{
    public partial class Form1 : Form
    {

       
        enum CurrentUserCtrl { SingInControl = 1 , MainMenuCotrol = 2 };
        CurrentUserCtrl CurrentCntrl = 0; 
        void SetErrorProvider(Control control , string Message)
        {
            errorProvider1.SetError(control, Message); 
        }
        void ShowCtrlPorgressAndAccessUserCtrlByName(CurrentUserCtrl CtrlName)
        {
            if( CurrentCntrl != (CurrentUserCtrl)CtrlName)
            {
                ClsGeneral.AccessUserCtrlByCtrlName((ClsGeneral.enCtrlsName)CtrlName); 
                this.Controls.Add(ClsGeneral.headCtrl);
                ClsGeneral.headCtrl.BringToFront();
                CurrentCntrl = (CurrentUserCtrl)CtrlName;
                return;
            }
            ClsGeneral.headCtrl.Visible = true; 
            return; 
          
        }
        
        public Form1()
        {
          
            InitializeComponent();
        }

        private void TxtBxUserName_TextChanged(object sender, System.EventArgs e)
        {
            if (ClsGeneral.IsTxtBxEmpty(TxtBxUserName))
            {
                SetErrorProvider(TxtBxUserName, "User Name Should Not Be Empty!!");
                return;
            }
            SetErrorProvider(TxtBxUserName, "");
        }
        private void TxtBxPassWord_TextChanged(object sender, System.EventArgs e)
        {
           if (ClsGeneral.IsTxtBxEmpty(TxtBxPassWord))
           {
                SetErrorProvider(TxtBxPassWord, "PassWord Should Not Be Empty!!");
                return; 
           }
            SetErrorProvider(TxtBxPassWord, "");
            ClsGeneral.ShowTextChangedOfTxtBx(TxtBxPassWord); 
            return;
        }
        private void TxtBxPassWord_IconRightClick(object sender, System.EventArgs e)
        {
            ClsGeneral.ShowOrHideTextOfTxtBxByIconeClick(TxtBxPassWord);
        }
        private void BtnSingIn_Click(object sender, System.EventArgs e)
        {
            SetErrorProvider(TxtBxPassWord, "");
            SetErrorProvider(TxtBxUserName, "");
            ShowCtrlPorgressAndAccessUserCtrlByName(CurrentUserCtrl.SingInControl);

        }
        private void BtnNext_Click(object sender, System.EventArgs e)
        {
           if(ClsGeneral.IsTxtBxEmpty(TxtBxUserName))
           {
                SetErrorProvider(TxtBxUserName, "User Name Should Not Be Empty!!");
                return; 
           }
           if(ClsGeneral.IsTxtBxEmpty(TxtBxPassWord))
           {
                SetErrorProvider(TxtBxPassWord, "PassWord Should Not Be Empty!!");
                return;
           }
            ShowCtrlPorgressAndAccessUserCtrlByName(CurrentUserCtrl.MainMenuCotrol);



        }
        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void TxtBxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (ClsGeneral.IsTxtBxEmpty(TxtBxUserName))
                return; 
            else

            if (e.KeyData == Keys.Enter)
            {
                TxtBxPassWord.Focus();
            }
        }
        private void TxtBxPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (ClsGeneral.IsTxtBxEmpty(TxtBxPassWord))
                return;
            else

            if (e.KeyData == Keys.Enter)
            {
                BtnNext.Focus();
              

            }
        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }
    }
}
