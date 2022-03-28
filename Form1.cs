using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RinRorm
{
    public partial class Form1 : Form
    {
        public MessageFather messageFather;

        public int startTop;

        public int qwqNum = 0;
        public Form1()
        {
            InitializeComponent();
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.ResourceManager.GetStream("Rick"));
            soundPlayer.Play();

            richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            this.richTextBox1.SelectionLength = 0;
            this.richTextBox1.ScrollToCaret();

            startTop = (Screen.AllScreens[0].WorkingArea.Height - this.Height) / 2;//保持纵向在屏幕中间
            Top = startTop;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState == CheckState.Checked)
            {
                checkBox1.Text = "yes";
            }
            else
            {
                checkBox1.Text = "no";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You wouldn't get this from any other guy", "", MessageBoxButtons.OK);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            this.richTextBox1.SelectionLength = 0;
            this.richTextBox1.ScrollToCaret();
        }

        private void btDesert_Click(object sender, EventArgs e)
        {
            btU.Visible = true;
            btDesert.Visible = false;
        }

        private void btU_Click(object sender, EventArgs e)
        {
            btU.Visible = false;
            btDesert.Visible = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            switch(trackBar1.Value)
            {
                case 0: label9.Text = "Never";
                    break;
                case 1:
                    label9.Text = "gonna";
                    break;
                case 2:
                    label9.Text = "make";
                    break;
                case 3:
                    label9.Text = "you";
                    break;
                case 4:
                    label9.Text = "cry";
                    break;
            }
        }
        private void toolTipCakeController(object sender, EventArgs e)
        {
            toolTipCake.ShowAlways = true;
            toolTipCake.SetToolTip(this.pictureBox1, "蛋糕是个谎言");
        }
        private void toolTipLCDController(object sender, EventArgs e)
        {
            toolTipCake.ShowAlways = true;
            toolTipCake.SetToolTip(this.pictureBox2, "Richard Paul Astley");
        }
        private void toolTipWSLController(object sender, EventArgs e)
        {
            toolTipCake.ShowAlways = true;
            toolTipCake.SetToolTip(this.pictureBox3, "汪苏泷");
        }

        private void pictureBox2_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        }

        public void ButtonChangeText(object sender, EventArgs e)
        {
            button2.Text = "Open it!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timerTop.Enabled = true;
            timerDown.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timerDown.Enabled = true;
            timerTop.Enabled = false;
        }

        private void timerTop_Tick(object sender, EventArgs e)
        {
            startTop-=5;
            this.Top = startTop;

            if(startTop <= 5)
            {
                startTop = 5;
                timerTop.Enabled = false;
            }
        }

        private void timerDown_Tick(object sender, EventArgs e)
        {
            startTop+=7;
            this.Top = startTop;

            if (startTop >= Screen.AllScreens[0].WorkingArea.Height - this.Height + 5)
            {
                startTop = Screen.AllScreens[0].WorkingArea.Height - this.Height + 5;
                timerDown.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.RightToLeft == RightToLeft.No)
            {
                this.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            messageFather = new MessageFather();
            timerQwQ.Enabled = true;
        }

        private void timerQwQ_Tick(object sender, EventArgs e)
        {
            qwqNum++;
            if(qwqNum >= 30)
            {
                timerQwQ.Enabled = false;
                messageFather.Close();
            }
            else
            {
                MessageBox.Show(messageFather, "QwQ");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            timerQwQ.Enabled = false;
            messageFather.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bilibili.com/video/BV1GJ411x7HZ");
            Application.Exit();
        }
    }
}
