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
    public partial class RefolosireDespartire : Form
    {
        public RefolosireDespartire()
        {
            InitializeComponent();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\refolosireSilabe.wav";
            player.Play();

            crossMark.Visible = false;
            checkMark.Visible = false;
            crossMark1.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\wrong.wav";
            player.Play();

            crossMark.Visible = true;
            crossMark1.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\wrong.wav";
            player.Play();

            crossMark1.Visible = true;
            crossMark.Visible = false;
        }

        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\correct.wav";
            player.Play();

            checkMark.Visible = true;
            crossMark.Visible = false;
            crossMark1.Visible = false;
            pictureBox3.Enabled = false;
            pictureBox6.Enabled = false;

            await Task.Delay(1000);

            this.Hide();
            ReciclareDespartire pp = new ReciclareDespartire();
            pp.ShowDialog();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            var width = pictureBox3.Size.Width;
            var height = pictureBox3.Size.Height;
            var x = pictureBox3.Location.X;
            var y = pictureBox3.Location.Y;

            pictureBox3.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            var width = pictureBox3.Size.Width;
            var height = pictureBox3.Size.Height;
            var x = pictureBox3.Location.X;
            var y = pictureBox3.Location.Y;

            pictureBox3.SetBounds(x + 5, y + 5, width - 10, height - 10);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            var width = pictureBox6.Size.Width;
            var height = pictureBox6.Size.Height;
            var x = pictureBox6.Location.X;
            var y = pictureBox6.Location.Y;

            pictureBox6.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            var width = pictureBox6.Size.Width;
            var height = pictureBox6.Size.Height;
            var x = pictureBox6.Location.X;
            var y = pictureBox6.Location.Y;

            pictureBox6.SetBounds(x + 5, y + 5, width - 10, height - 10);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            var width = pictureBox2.Size.Width;
            var height = pictureBox2.Size.Height;
            var x = pictureBox2.Location.X;
            var y = pictureBox2.Location.Y;

            pictureBox2.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            var width = pictureBox2.Size.Width;
            var height = pictureBox2.Size.Height;
            var x = pictureBox2.Location.X;
            var y = pictureBox2.Location.Y;

            pictureBox2.SetBounds(x + 5, y + 5, width - 10, height - 10);
        }
    }
}
