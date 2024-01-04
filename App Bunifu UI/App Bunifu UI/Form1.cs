using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_Bunifu_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bunifu.Framework.UI.Drag dr = new Bunifu.Framework.UI.Drag();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            dr.Grab(this);
        }

        private void header_MouseUp(object sender, MouseEventArgs e)
        {
            dr.Release();
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            dr.MoveObject();
        }

        private void lbltab1_Click(object sender, EventArgs e)
        {
            line.Width = lbltab1.Width;
            line.Left = lbltab1.Left;

            tab12.Visible = false;
            tab12.BringToFront();
            animator1.ShowSync(tab12);
        }

        private void lbltab2_Click(object sender, EventArgs e)
        {
            line.Width = lbltab2.Width;
            line.Left = lbltab2.Left;

            tab22.Visible = false;
            tab22.BringToFront();
            tab22.hideCOntrols();

            animator1.ShowSync(tab22);
            tab22.AnnimateTM();
        }

        private void lbltab3_Click(object sender, EventArgs e)
        {
            line.Width = lbltab3.Width;
            line.Left = lbltab3.Left;

            tab31.Visible = false;
            tab31.BringToFront();
            animator1.ShowSync(tab31);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tab22.AnnimateTM();
        }

        private void tab21_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
