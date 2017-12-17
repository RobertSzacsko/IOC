using System;
using System.Windows.Forms;
using System.Media;

namespace IOC
{
    public partial class START : Form
    {
        public START()
        {
            InitializeComponent();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "recs\\FirstPageRob.wav";
            player.Play();
          
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecondPage sp = new SecondPage();
            sp.ShowDialog();
        }
    }
}
