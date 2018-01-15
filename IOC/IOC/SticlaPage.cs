using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOC
{
    public partial class SticlaPage : Form
    {
        public SticlaPage()
        {
            InitializeComponent();

            SoundPlayer player2 = new SoundPlayer();
            player2.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\sticla.wav";
            player2.Play();

            pictureBox1.Visible = false;
            wait();
        }

        private async void wait()

        {
            await Task.Delay(24000);
            pictureBox1.Visible = true;

        }

        private async void SticlaPage_Load(object sender, EventArgs e)
        {
            sticlaTomberon.Visible = false;
            greenBottle.Visible = false;
            waterBottle.Visible = false;
            mirror.Visible = false;
            glass.Visible = false;
            left.Visible = false;
            bottle.Visible = false;
            up.Visible = false;
            down.Visible = false;
            right.Visible = false;

            await Task.Delay(1000);
            sticlaTomberon.Visible = true;
            await Task.Delay(500);
            greenBottle.Visible = true;
            await Task.Delay(500);
            waterBottle.Visible = true;
            await Task.Delay(500);
            down.Visible = true;
            await Task.Delay(500);
            mirror.Visible = true;
            await Task.Delay(500);
            left.Visible = true;
            await Task.Delay(500);
            glass.Visible = true;
            await Task.Delay(500);
            up.Visible = true;
            await Task.Delay(500);
            bottle.Visible = true;
            await Task.Delay(500);
            right.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SticlaDespartire pp = new SticlaDespartire();
            pp.ShowDialog();
        }
    }
}
