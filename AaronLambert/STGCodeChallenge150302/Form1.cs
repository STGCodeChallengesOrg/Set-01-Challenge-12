using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STGCodeChallenge150302
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    int c = 25 + ((x * 4) + (y * 40));
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(c, c, c)), new Rectangle(x * 20, y * 20, 20, 20));
                }
            }
        }
    }
}
