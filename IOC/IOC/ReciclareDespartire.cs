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
    public partial class ReciclareDespartire : Form
    {
        public ReciclareDespartire()
        {
            InitializeComponent();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\reciclareSilabe.wav";
            player.Play();

            checkMark.Visible = false;
            crossMark.Visible = false;
            crossMark1.Visible = false;
        }

        private async void four_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\correct.wav";
            player.Play();

            checkMark.Visible = true;
            crossMark.Visible = false;
            crossMark1.Visible = false;
            three.Enabled = false;
            five.Enabled = false;

            await Task.Delay(1000);

            this.Hide();
            PaperPage pp = new PaperPage();
            pp.ShowDialog();
        }

        private void three_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\wrong.wav";
            player.Play();

            crossMark.Visible = true;
            crossMark1.Visible = false;
        }

        private void five_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\wrong.wav";
            player.Play();

            crossMark1.Visible = true;
            crossMark.Visible = false;
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

        private void five_MouseHover(object sender, EventArgs e)
        {
            var width = five.Size.Width;
            var height = five.Size.Height;
            var x = five.Location.X;
            var y = five.Location.Y;

            five.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }

        private void five_MouseLeave(object sender, EventArgs e)
        {
            var width = five.Size.Width;
            var height = five.Size.Height;
            var x = five.Location.X;
            var y = five.Location.Y;

            five.SetBounds(x + 5, y + 5, width - 10, height - 10);
        }
    }
}
