using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using ImageProcess2;

namespace Coins_Activity
{
    public partial class Form1 : Form
    {
        Bitmap? loaded;
        Bitmap? processed;
        public Form1()
        {
            InitializeComponent();
        }

        private void coinsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            pictureBox1.Image = loaded = new Bitmap(openFileDialog1.FileName);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            pictureBox1.Image = loaded = new Bitmap(openFileDialog1.FileName);
        }

        private void countCoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded.Width, loaded.Height);
            BitmapFilter.Binary(loaded, processed, 200);
            Coins.CountCoin(processed, ref label2, ref label4);

            pictureBox2.Image = processed;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
