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
    public partial class ReducereDespartire : Form
    {
        public ReducereDespartire()
        {
            InitializeComponent();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\reducereSilabe.wav";
            player.Play();

            checkMark.Visible = false;
            crossMark.Visible = false;
            crossMark1.Visible = false;
        }

        private void two_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\wrong.wav";
            player.Play();

            crossMark.Visible = true;
            crossMark1.Visible = false;
        }

        private void six_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\wrong.wav";
            player.Play();

            crossMark1.Visible = true;
            crossMark.Visible = false;
        }

        private async void four_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\correct.wav";
            player.Play();

            checkMark.Visible = true;
            crossMark.Visible = false;
            crossMark1.Visible = false;
            two.Enabled = false;
            six.Enabled = false;

            await Task.Delay(1000);

            this.Hide();
            RefolosireDespartire pp = new RefolosireDespartire();
            pp.ShowDialog();
        }

        private void two_MouseHover(object sender, EventArgs e)
        {
            var width = two.Size.Width;
            var height = two.Size.Height;
            var x = two.Location.X;
            var y = two.Location.Y;

            two.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }

        private void two_MouseLeave(object sender, EventArgs e)
        {
            var width = two.Size.Width;
            var height = two.Size.Height;
            var x = two.Location.X;
            var y = two.Location.Y;

            two.SetBounds(x + 5, y + 5, width - 10, height - 10);
        }

        private void four_MouseHover(object sender, EventArgs e)
        {
            var width = four.Size.Width;
            var height = four.Size.Height;
            var x = four.Location.X;
            var y = four.Location.Y;

            four.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }

        private void four_MouseLeave(object sender, EventArgs e)
        {
            var width = four.Size.Width;
            var height = four.Size.Height;
            var x = four.Location.X;
            var y = four.Location.Y;

            four.SetBounds(x + 5, y + 5, width - 10, height - 10);
        }

        private void six_MouseHover(object sender, EventArgs e)
        {
            var width = six.Size.Width;
            var height = six.Size.Height;
            var x = six.Location.X;
            var y = six.Location.Y;

            six.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }

        private void six_MouseLeave(object sender, EventArgs e)
        {
            var width = six.Size.Width;
            var height = six.Size.Height;
            var x = six.Location.X;
            var y = six.Location.Y;

            six.SetBounds(x + 5, y + 5, width - 10, height - 10);
        }
    }
}
