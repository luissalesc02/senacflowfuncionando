using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace senacflowfuncionando
{
    public partial class mapasenac : Form
    {
        public mapasenac()
        {
            InitializeComponent();
            pictureBox1.MouseWheel += pictureBox1_MouseWheel;
            pictureBox1.Focus();
            pictureBox2.MouseWheel += pictureBox2_MouseWheel;
            pictureBox2.Focus();
            pictureBox3.MouseWheel += pictureBox3_MouseWheel;
            pictureBox3.Focus();
            pictureBox4.MouseWheel += pictureBox4_MouseWheel;
            pictureBox4.Focus();
        }
        private void pictureBox4_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) // Scroll para cima → Zoom in
            {
                pictureBox4.Width = (int)(pictureBox4.Width * 1.1);
                pictureBox4.Height = (int)(pictureBox4.Height * 1.1);
            }
            else // Scroll para baixo → Zoom out
            {
                pictureBox4.Width = (int)(pictureBox4.Width * 0.9);
                pictureBox4.Height = (int)(pictureBox4.Height * 0.9);
            }
        }
        private void pictureBox3_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) // Scroll para cima → Zoom in
            {
                pictureBox3.Width = (int)(pictureBox3.Width * 1.1);
                pictureBox3.Height = (int)(pictureBox3.Height * 1.1);
            }
            else // Scroll para baixo → Zoom out
            {
                pictureBox3.Width = (int)(pictureBox3.Width * 0.9);
                pictureBox3.Height = (int)(pictureBox3.Height * 0.9);
            }
        }
        private void pictureBox2_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) // Scroll para cima → Zoom in
            {
                pictureBox2.Width = (int)(pictureBox2.Width * 1.1);
                pictureBox2.Height = (int)(pictureBox2.Height * 1.1);
            }
            else // Scroll para baixo → Zoom out
            {
                pictureBox2.Width = (int)(pictureBox2.Width * 0.9);
                pictureBox2.Height = (int)(pictureBox2.Height * 0.9);
            }
        }
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) // Scroll para cima → Zoom in
            {
                pictureBox1.Width = (int)(pictureBox1.Width * 1.1);
                pictureBox1.Height = (int)(pictureBox1.Height * 1.1);
            }
            else // Scroll para baixo → Zoom out
            {
                pictureBox1.Width = (int)(pictureBox1.Width * 0.9);
                pictureBox1.Height = (int)(pictureBox1.Height * 0.9);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void mapasenac_Load(object sender, EventArgs e)
        {

        }
    }
}
