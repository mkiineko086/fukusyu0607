﻿using System;
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
        int vx = -10;
        int vy = -10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text=MousePosition.X+","+MousePosition.Y;
            Point p=PointToClient(MousePosition);

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
                timer1.Enabled = false;
                label1.Visible = false;
                label2.Text = "＼(＾o＾)／";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
