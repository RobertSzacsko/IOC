using System;
using System.Windows.Forms;
using System.Media;
using System.Threading.Tasks;

namespace IOC
{
    public partial class START : Form
    {
        
        public START()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\primaPagina.wav";
            player.Play();

            startButton.Visible = false;

            wait();
        }

        private async void wait()
        {
            await Task.Delay(9000);
            startButton.Visible = true;

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecondPage sp = new SecondPage();
            sp.ShowDialog();
        }

        private void START_FormClosed(object sender, FormClosedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\FirstPageRob.wav";
            player.Stop();
        }
    }
}
