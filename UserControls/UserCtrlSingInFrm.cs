using MyMemeoryGame.GeneralCls;
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
    public partial class UserCtrlFrmSingIn : UserControl
    {
        void SetErrorProvider(Control control, string Message)
        {
            errorProvider1.SetError(control, Message);
        }

        public UserCtrlFrmSingIn()
        {
            InitializeComponent();
           
        }

        private void TxtBxPassword_TextChanged(object sender, EventArgs e)
        {
            if (ClsGeneral.IsTxtBxEmpty((SiticoneTextBox)sender))
            {

                SetErrorProvider(((SiticoneTextBox)sender), "PassWord Should Not Be Empty!!");
                return;
            }
            SetErrorProvider(((SiticoneTextBox)sender), ""); ;
            ClsGeneral.ShowTextChangedOfTxtBx(((SiticoneTextBox)sender));
            return;
        }
        private void TxtBxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (ClsGeneral.IsTxtBxEmpty((SiticoneTextBox)sender))
            {
                 e.Cancel = true; 
                 SetErrorProvider(((SiticoneTextBox)sender), "PassWord Should Not Be Empty!!");

                ((SiticoneTextBox)sender).Focus();

                 return;
            }
            e.Cancel = false;
            SetErrorProvider(((SiticoneTextBox)sender), "");
        }
        private void TxtBxPassword_IconRightClick(object sender, EventArgs e)
        {
            ClsGeneral.ShowOrHideTextOfTxtBxByIconeClick((SiticoneTextBox)sender);
        }
        private void TxtBxUserFristName_KeyDown(object sender, KeyEventArgs e)
        {
            if (ClsGeneral.IsTxtBxEmpty(TxtBxUserFristName))
                return;
            else

            if (e.KeyData == Keys.Enter)
            {
                TxtBxUserLastName.Focus();
            }
            
        }
        private void TxtBxUserLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (ClsGeneral.IsTxtBxEmpty(TxtBxUserLastName))
                return;
            else

            if (e.KeyData == Keys.Enter)
            {
                TxtBxCurrentPassword.Focus();
                return;
            }
        }
        private void TxtBxCurrentPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (ClsGeneral.IsTxtBxEmpty(TxtBxCurrentPassword))
            {
                SetErrorProvider(((SiticoneTextBox)sender), "PassWord Should Not Be Empty!!");
                return;
            }
           
            if (e.KeyData == Keys.Enter)
            {
                TxtBxPasswordConfirt.Focus();
            }
        }
        private void UserCtrlSingInFrm_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            ClsGeneral.headCtrl.Visible = false;
        }
    }
}
