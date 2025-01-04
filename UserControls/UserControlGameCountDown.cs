using DevExpress.Utils.VisualEffects;
using MyMemeoryGame.GeneralCls;
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
    public partial class UserControlGameCountDown : UserControl
    {
       
        byte GameCountDount = 3; 

        void StartCountDown(byte CountDown)
        {
            BtnCountDown.Text = CountDown.ToString();
            switch (CountDown)
            {
                case 2:
                    BtnCountDown.FillColor = Color.Green;
                    BtnCountDown.Refresh(); 
                break;
                case 1:
                    BtnCountDown.FillColor = Color.Red;
                    BtnCountDown.Refresh();
                break;
            }
        }
        void StartTimer(bool Start = false)
        {
            if(Start)
            {
               timer1.Enabled = Start;
               return;
            }
            timer1.Enabled = Start;
            this.Visible = false;
        }
        void ShoGameScreen()
        {
            ClsGeneral.gameForm = new GameForm();
            ClsGeneral.gameForm.Show();
            this.Hide();
        }
        public UserControlGameCountDown()
        {
            InitializeComponent();
        }

        private void UserControlGameCountDown_Load(object sender, EventArgs e)
        {
            StartTimer(true);


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartCountDown((GameCountDount));
            if(GameCountDount == 0 )
            {
               
                StartTimer(false);
                ShoGameScreen();
                return; 
            }
            GameCountDount--;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            StartTimer(false);


        }

    }
}
