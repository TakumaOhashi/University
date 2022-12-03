using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int x, y,i,k;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 300);
            x = 15;
            y = 15;
            i = x;
            k = y;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureBox1.Left + pictureBox1.Width >= 385 || pictureBox1.Left <= 0)
            {
                x = -x;
            }
            if (pictureBox1.Top + pictureBox1.Height >= 260 || pictureBox1.Top <= 0)
            {
                y = -y;
            }

            if (pictureBox1.Top < label1.Top + label1.Height && pictureBox1.Top + pictureBox1.Height > label1.Top)
            {

                if (pictureBox1.Left + pictureBox1.Width - i < label1.Left)
                {
                    if (pictureBox1.Left + pictureBox1.Width >= label1.Left)
                    {
                        x = -x;

                    }
                }
                else if (pictureBox1.Left + i > label1.Left + label1.Width)
                {
                    if (pictureBox1.Left <= label1.Left + label1.Width)
                    {
                        x = -x;
                    }
                }
            }
            if (pictureBox1.Left < label1.Left + label1.Width && pictureBox1.Left + pictureBox1.Height > label1.Left )
            {

                if (pictureBox1.Top + pictureBox1.Height - k < label1.Top)
                {
                    if (pictureBox1.Top + pictureBox1.Height >= label1.Top)
                    {
                        y = -y;

                    }
                }
                else if (pictureBox1.Top + k > label1.Top + label1.Height)
                {
                    if (pictureBox1.Top <= label1.Top + label1.Height)
                    {
                        y = -y;
                    }
                    

                }
            }
            pictureBox1.Left = pictureBox1.Left + x;
            pictureBox1.Top = pictureBox1.Top + y;
        }
    }
}
