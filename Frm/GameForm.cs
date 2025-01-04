using Bunifu.Framework.UI;
using Bunifu.UI.WinForms.BunifuButton;
using DevExpress.Internal;
using DevExpress.Utils;
using DevExpress.XtraEditors.ColorPick.Picker;
using MyMemeoryGame.GeneralCls;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMemeoryGame
{
    public partial class GameForm : Form
    {
       
        short Counter = 5;
        Random loc = new Random();
        List<Point> point = new List<Point>();
        SiticoneImageButton Tempbtn1 = null;
        SiticoneImageButton Tempbtn2 = null;
        


        void showImage(SiticoneImageButton btn)
        {
            switch(Convert.ToByte( btn.Tag))
            {
                case 1:
                    btn.Image = Properties.Resources.img1;
                   break;
                case 2:
                    btn.Image = Properties.Resources.img2;
                    break;
                case 3:
                    btn.Image = Properties.Resources.img3;
                    break;
                case 4:
                    btn.Image = Properties.Resources.img4;
                    break;
                case 5:
                    btn.Image = Properties.Resources.img5;
                    break;
                case 6:
                    btn.Image = Properties.Resources.img6;
                    break;
                case 7:
                    btn.Image = Properties.Resources.img7;
                    break;
                case 8:
                    btn.Image = Properties.Resources.img8;
                    break;
            }
        }
        void LoeadGameBtnImages()
        {
            foreach (SiticoneImageButton bunifubtn in panel1.Controls)
            {
                bunifubtn.Enabled = false;
                point.Add(bunifubtn.Location);
            }
            foreach (SiticoneImageButton bunifubtn in panel1.Controls)
            {
                int index = loc.Next(point.Count);
                Point p = point[index];
                bunifubtn.Location = p;
                point.Remove(p);
            }
            btn1.Image = Properties.Resources.img1;
            btn2.Image = Properties.Resources.img1;
            btn3.Image = Properties.Resources.img2;
            btn4.Image = Properties.Resources.img2;
            btn5.Image = Properties.Resources.img3;
            btn6.Image = Properties.Resources.img3;
            btn7.Image = Properties.Resources.img4;
            btn8.Image = Properties.Resources.img4;
            btn9.Image = Properties.Resources.img5;
            btn10.Image = Properties.Resources.img5;
            btn11.Image = Properties.Resources.img6;
            btn12.Image = Properties.Resources.img6;
            btn13.Image = Properties.Resources.img7;
            btn14.Image = Properties.Resources.img7;
            btn15.Image = Properties.Resources.img8;
            btn16.Image = Properties.Resources.img8;
        }  
        void ShowImageCoverOnebtn(bool showImases = false)
        {
           
            foreach (SiticoneImageButton bunifubtn in panel1.Controls)
            { 
                bunifubtn.Enabled = true;
                bunifubtn.Image = Properties.Resources.cover;
            }
            

        }
        void GameTimerStart(bool start = false)
        {
            GameTimer.Enabled = start;  
        }
        bool AreSameImages()
        {
            if (Tempbtn1 != null && Tempbtn2 != null)
            {
                if (Tempbtn1.Tag == Tempbtn2.Tag)
                {
                    Tempbtn1 = null;
                    Tempbtn2 = null;
                    return true; 
                }
            }

            return  false; 
        }
        void IsChicked(SiticoneImageButton Button)
        {
             showImage(Button);

            if (Tempbtn1 == null)
            {
                Button.Checked = true;
                Tempbtn1 = Button;
                return; 
            }

            else if (Tempbtn2 == null)
            {
                Button.Checked = true;
                Tempbtn2 = Button;
            }

            if(!AreSameImages())
            {
                timerCountToCoverBtn.Start();
            }
           
            return;

        }

        public GameForm()
        {
            InitializeComponent();
            
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            LoeadGameBtnImages();
            GameTimerStart(true);

        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            lblCounter.Text = Counter.ToString();
            if(Counter == 0 )
            {
               ShowImageCoverOnebtn();
               GameTimerStart(false);

            }
            else
            Counter--;
        }
        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            ClsGeneral.GameCountDownCntrl.Visible = false;
            this.Hide();
        }
        private void ItmSoundOn_Click(object sender, EventArgs e)
        {
                ItmSoundOn.Checked = true;
                ItmSoundOf.Checked = !ItmSoundOn.Checked;
                ClsGeneral.GameSound(true);
            
        }
        private void ItmSoundOf_Click(object sender, EventArgs e)
        {
            ItmSoundOf.Checked = true;
            ItmSoundOn.Checked = !ItmSoundOf.Checked;
            ClsGeneral.GameSound(false);
        }
        private void btn_Click(object sender, EventArgs e)
        {
               IsChicked((SiticoneImageButton)sender); 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCountToCoverBtn.Stop();
            Tempbtn1.Image = Properties.Resources.cover;
            Tempbtn2.Image = Properties.Resources.cover;
            Tempbtn1 = null;
            Tempbtn2 = null;
        }


    }
}
