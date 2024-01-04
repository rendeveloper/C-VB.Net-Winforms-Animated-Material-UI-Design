using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_Bunifu_UI
{
    public partial class tab2 : UserControl
    {
        public tab2()
        {
            InitializeComponent();
        }

        public void AnnimateTM()
        {
            hideCOntrols();
            annimate.Start();
        }

        private void annimate_Tick(object sender, EventArgs e)
        {
            annimate.Stop();

            showcontrols();
        }

        void showcontrols()
        {


            foreach (Control item in this.Controls)
            {
                animator1.ShowSync(item);
                Application.DoEvents();
            }
        }

        public        void hideCOntrols()
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = false;
                Application.DoEvents();
            }
        }

        private void tab2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
