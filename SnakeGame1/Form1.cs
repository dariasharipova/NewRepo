using static System.Windows.Forms.DataFormats;

namespace SnakeGame1
{
    public partial class Form1 : Form
    {
        private easyLevel easyLevel;
        private normalLevel normalLevel;;
        private hardLevel hardLevel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void âûéòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void ëåãêèéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            easyLevel = new easyLevel();
            easyLevel.Show();

        }

        private void íîğìàëüíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            normalLevel = new normalLevel();
            normalLevel.Show();

        }

        private void ñëîæíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hardLevel = new hardLevel();
            hardLevel.Show();

        }
    }
}