using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0607
{
    public partial class Form1 : Form
    {
        //疑似乱数
        //ランダムのシード(種)を指定して初期化したら、
        //それを使い続ける。

        private static Random rand = new Random();
        int vx = rand.Next(-10,11);
        int vy = rand.Next(-10,11);

        int x = rand.Next(-10, 11);
        int y = rand.Next(-10, 11);

        int xx = rand.Next(-10, 11);
        int yy = rand.Next(-10, 11);


        int time = 100 * 5;

        public Form1()
        {
            InitializeComponent();
            
            //以下に、label1.Leftとlabel1.Topの座標をランダムで求めよ

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);




            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
            label4.Left += x;
            label4.Top += y;
            label5.Left += xx;
            label5.Top += yy;

            Text=MousePosition.X+","+MousePosition.Y;
            Point p = PointToClient(MousePosition);

            /*if  (   (p.X>=label1.Left)
                &&  (p.X<label1.Right)
                &&  (p.Y>=label1.Top)
                &&  (p.Y<label1.Bottom)
                )
            {
                timer1.Enabled = false;
            }*/

            label2.Left = p.X - label2.Width / 2;
            label2.Top = p.Y - label2.Height / 2;
            

            label1.Left += vx;
            label1.Top += vy;

            if(label1.Left<0)
            {
                vx = Math.Abs(vx);
            }
            if(label1.Top<0)
            {
                vy = -vy;
            }
            if(label1.Left>ClientSize.Width-label1.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Top > ClientSize.Height - label1.Height)
            {
                vy = -vy;
            }
            if ((p.X >= label1.Left) && (p.X <= label1.Right) && (p.Y >= label1.Top) && (p.Y <= label1.Bottom))
            {
                //timer1.Enabled = false;
                label1.Visible = false;
                label1.Enabled = false;
                label2.Text = "( ;∀;)";
            }




            if (label4.Left < 0)
            {
                x = Math.Abs(x);
            }
            if (label4.Top < 0)
            {
                y = -y;
            }
            if (label4.Left > ClientSize.Width - label4.Width)
            {
                x = -Math.Abs(x);
            }
            if (label4.Top > ClientSize.Height - label4.Height)
            {
                y = -y;
            }
            if ((p.X >= label4.Left) && (p.X <= label4.Right) && (p.Y >= label4.Top) && (p.Y <= label4.Bottom))
            {
                //timer1.Enabled = false;
                label4.Visible = false;
                label4.Enabled = false;
                label2.Text = "《《コォォ ＿(ﾟДﾟ)_| ォォオ!!》》";
            }


            if (label5.Left < 0)
            {
                xx = Math.Abs(xx);
            }
            if (label5.Top < 0)
            {
                yy = -yy;
            }
            if (label5.Left > ClientSize.Width - label5.Width)
            {
                xx = -Math.Abs(xx);
            }
            if (label5.Top > ClientSize.Height - label5.Height)
            {
                yy = -yy;
            }
            if ((p.X >= label5.Left) && (p.X <= label5.Right) && (p.Y >= label5.Top) && (p.Y <= label5.Bottom))
            {
                //timer1.Enabled = false;
                label5.Visible = false;
                label5.Enabled = false;
                label2.Text = "(〃ﾟOﾟ)b";
            }
            time--;
            label6.Text = "Time: " + time;
            if ((label1.Enabled == false) && (label4.Enabled == false) && (label5.Enabled == false))
            {
                timer1.Enabled = false;
                label3.Visible = true;
                label2.Text = "＼(＾o＾)／";
                label2.Location = new Point(118, 120);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //if (label3.Visible == true)
                
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
