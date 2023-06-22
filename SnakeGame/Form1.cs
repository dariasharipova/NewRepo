using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private easyLevel easy;
        private normalLevel normal;
        private hardLevel hard;
        public Form1()
        {
            InitializeComponent();
        }

        private void среднийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            normal = new normalLevel();
            normal.Show();
        }

        private void сложныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hard = new hardLevel();
            hard.Show();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void легкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            easy = new easyLevel();
            easy.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

    }
}
