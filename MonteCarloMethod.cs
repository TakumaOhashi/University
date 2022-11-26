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
        Graphics g;
        Random rnd = new Random();
        int i, n, cnt;
        double p;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            double x, y;
             x = rnd.NextDouble();
             y = rnd.NextDouble();
            if (x * x + y * y < 1)
            {
                g.FillRectangle(Brushes.Blue, (int)(x * 200.0), (int)(y * 200.0), 1, 1);
                cnt++;
            }
            else
            {
                g.FillRectangle(Brushes.Green, (int)(x * 200.0), (int)(y * 200.0), 1, 1);
            }
            n++;
            label1.Text = Math.Round(x, 2).ToString();
            label5.Text = Math.Round(y, 2).ToString();
            label4.Text = n.ToString();

            p = 4.0 * cnt / n;
            label6.Text = Math.Round(p, 3).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button2.Visible = false;
            button1.Visible = true;
        }

        public Form1()
        {

            InitializeComponent();
            g = CreateGraphics();
            g.ResetTransform();
            g.TranslateTransform(0, ClientRectangle.Height);

            g.ScaleTransform(1, -1);
            g.Clear(BackColor);

            cnt = 0;
            n = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            timer1.Enabled = true;
            button1.Visible = false;
            button2.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
