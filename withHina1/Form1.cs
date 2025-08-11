using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace withHina1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.BackColor = Color.Black;
            this.TransparencyKey = this.BackColor;
            
            this.TopMost = true;
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // タスクバーを除いた領域
            var screenArea = Screen.PrimaryScreen.WorkingArea;

            // 左下
            this.Location = new Point(
                0,
                screenArea.Height - this.Height
            );
        }

        Point lastPoint;

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(5);
           pictureBox1.AllowDrop = true;

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
//                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.ido;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.emote;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.main;
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
