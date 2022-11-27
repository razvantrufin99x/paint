using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int x;
        public int px;
        public int y;
        public int py;
        public bool ismousedown = false;
        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("DOT");

        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("LINE");
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("SQUARE");
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("TRIANGLE");
        }

        private void rombeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("ROMBE");
        }

        private void paralelogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("PARALELOGRAM");
        }

        private void pathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("PATH");
        }

        private void poligonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("POLIGON");
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("ELLIPSE");
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("CIRCLE");
        }

        private void arcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("ARC");
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("TEXT");
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("IMAGE");
        }

        private void iconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("ICON");
        }

        private void pieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("PIE");
        }

        private void graphicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("GRAPHIC");
        }

        private void histrogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("HISTOGRAM");
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.g.Clear(Color.White);
        }

        private void penToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.SetMode("PEN");
        }

        private void userControl11_MouseDown(object sender, MouseEventArgs e)
        {
            ismousedown = true;
            x = e.X;
            y = e.Y;
            px = x;
            py = y;
        }

        private void userControl11_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismousedown == true)
            {
                if (userControl11.mode == "PEN")
                {
                    x = e.X;
                    y = e.Y;
                    userControl11.g.DrawLine(userControl11.p, x, y, px, py);
                    px = x;
                    py = y;
                    userControl11.Refresh();
                }
            }
        }

        private void userControl11_MouseUp(object sender, MouseEventArgs e)
        {
            ismousedown = false;
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
