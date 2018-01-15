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
    public partial class SticlaDespartire : Form
    {
        public SticlaDespartire()
        {
            InitializeComponent();

            SoundPlayer player2 = new SoundPlayer();
            player2.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\sticlaSilabe.wav";
            player2.Play();

            crossMark.Visible = false;
            checkMark.Visible = false;
            crossMark1.Visible = false;
        }

        private void one_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\wrong.wav";
            player.Play();

            crossMark.Visible = true;
            crossMark1.Visible = false;
        }

        private void three_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\wrong.wav";
            player.Play();

            crossMark1.Visible = true;
            crossMark.Visible = false;
        }

        private async void two_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\correct.wav";
            player.Play();

            checkMark.Visible = true;
            crossMark.Visible = false;
            crossMark1.Visible = false;
            three.Enabled = false;
            one.Enabled = false;
      

            await Task.Delay(1000);

            this.Hide();
            GamePage pp = new GamePage();
            pp.ShowDialog();
        }

        private void one_MouseHover(object sender, EventArgs e)
        {
            var width = one.Size.Width;
            var height = one.Size.Height;
            var x = one.Location.X;
            var y = one.Location.Y;

            one.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }

        private void one_MouseLeave(object sender, EventArgs e)
        {
            var width = one.Size.Width;
            var height = one.Size.Height;
            var x = one.Location.X;
            var y = one.Location.Y;

            one.SetBounds(x + 5, y + 5, width - 10, height - 10);
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

        private void three_MouseHover(object sender, EventArgs e)
        {
            var width = three.Size.Width;
            var height = three.Size.Height;
            var x = three.Location.X;
            var y = three.Location.Y;

            three.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }

        private void three_MouseLeave(object sender, EventArgs e)
        {
            var width = three.Size.Width;
            var height = three.Size.Height;
            var x = three.Location.X;
            var y = three.Location.Y;

            three.SetBounds(x + 5, y + 5, width - 10, height - 10);
        }
    }
}
