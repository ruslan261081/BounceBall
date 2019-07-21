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

namespace BounceBallProject
{
    public partial class BounceBall : Form
    {
        public BounceBall()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        int dx = 1;
        int dy = 1;
       
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Jumpbtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

            Task.Run(() =>
            {
                while(true)
                {
                    Action a = () => { pictureBox1.Location = new Point(pictureBox1.Location.X + dx, pictureBox1.Location.Y + dy); };
                    pictureBox1.BeginInvoke(a);
                    if (pictureBox1.Location.X + dx <= 0)
                        dx = 1;
                    if (pictureBox1.Location.Y + dy <= 0 + Jumpbtn.Height)
                        dy = 1;
                    if (pictureBox1.Location.X + dx >= ClientSize.Width - pictureBox1.Width)
                        dx = -1;
                    if (pictureBox1.Location.Y + dy >= ClientSize.Height - pictureBox1.Height)
                        dy = -1;
                    Thread.Sleep(10);
                }

            });
        }

        private void AddBallbtrn_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            
           
            Task.Run(() =>
            {
                while (true)
                {
                    Action b = () => { pictureBox2.Location = new Point(pictureBox2.Location.X + dx, pictureBox2.Location.Y + dy); };
                    pictureBox2.BeginInvoke(b);
                    if (pictureBox2.Location.X  + dx <= 0)
                        dx = 1;
                    if (pictureBox2.Location.Y + dy <= 0 + AddBallbtrn.Height )
                        dy = 1;
                    if (pictureBox2.Location.X + dx >= ClientSize.Width - pictureBox2.Width)
                        dx = -1;
                    if (pictureBox2.Location.Y + dy >= ClientSize.Height - pictureBox2.Height)
                        dy = -1;
                    Thread.Sleep(20);
                }

            });
           
        }

        private void RemoveBallbtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void BounceBall_Load(object sender, EventArgs e)
        {

        }
    }
}
