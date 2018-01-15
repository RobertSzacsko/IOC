using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace IOC
{
    public partial class Plastic_Despartire : Form
    {
        public Plastic_Despartire()
        {
            InitializeComponent();
            check.Visible = false;
            crossMark.Visible = false;
            crossMark1.Visible = false;

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\plasticSilabe.wav";
            player.Play();

        }

        private async void ButonDespartireSilabePlastic_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\correct.wav";
            player.Play();

            check.Visible = true;
            crossMark.Visible = false;
            crossMark1.Visible = false;
            ButonDespartireSilabePlastic1.Enabled = false;
            ButonDespartireSilabePlastic2.Enabled = false;

            await Task.Delay(1000);

            this.Hide();
            SticlaPage pp = new SticlaPage();
            pp.ShowDialog();

        }

        private void ButonDespartireSilabePlastic1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\wrong.wav";
            player.Play();

            crossMark.Visible = true;
            crossMark1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\wrong.wav";
            player.Play();

            crossMark1.Visible = true;
            crossMark.Visible = false;
        }

        private void ButonDespartireSilabePlastic_MouseHover(object sender, EventArgs e)
        {
            var width = ButonDespartireSilabePlastic.Size.Width;
            var height = ButonDespartireSilabePlastic.Size.Height;
            var x = ButonDespartireSilabePlastic.Location.X;
            var y = ButonDespartireSilabePlastic.Location.Y;

            ButonDespartireSilabePlastic.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }

        private void ButonDespartireSilabePlastic_MouseLeave(object sender, EventArgs e)
        {
            var width = ButonDespartireSilabePlastic.Size.Width;
            var height = ButonDespartireSilabePlastic.Size.Height;
            var x = ButonDespartireSilabePlastic.Location.X;
            var y = ButonDespartireSilabePlastic.Location.Y;

            ButonDespartireSilabePlastic.SetBounds(x + 5, y + 5, width - 10, height - 10);
        }

        private void ButonDespartireSilabePlastic1_MouseHover(object sender, EventArgs e)
        {
            var width = ButonDespartireSilabePlastic1.Size.Width;
            var height = ButonDespartireSilabePlastic1.Size.Height;
            var x = ButonDespartireSilabePlastic1.Location.X;
            var y = ButonDespartireSilabePlastic1.Location.Y;

            ButonDespartireSilabePlastic1.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }

        private void ButonDespartireSilabePlastic1_MouseLeave(object sender, EventArgs e)
        {
            var width = ButonDespartireSilabePlastic1.Size.Width;
            var height = ButonDespartireSilabePlastic1.Size.Height;
            var x = ButonDespartireSilabePlastic1.Location.X;
            var y = ButonDespartireSilabePlastic1.Location.Y;

            ButonDespartireSilabePlastic1.SetBounds(x + 5, y + 5, width - 10, height - 10);
        }

        private void ButonDespartireSilabePlastic2_MouseLeave(object sender, EventArgs e)
        {
            var width = ButonDespartireSilabePlastic2.Size.Width;
            var height = ButonDespartireSilabePlastic2.Size.Height;
            var x = ButonDespartireSilabePlastic2.Location.X;
            var y = ButonDespartireSilabePlastic2.Location.Y;

            ButonDespartireSilabePlastic2.SetBounds(x + 5, y + 5, width - 10, height - 10);
        }

        private void ButonDespartireSilabePlastic2_MouseHover(object sender, EventArgs e)
        {
            var width = ButonDespartireSilabePlastic2.Size.Width;
            var height = ButonDespartireSilabePlastic2.Size.Height;
            var x = ButonDespartireSilabePlastic2.Location.X;
            var y = ButonDespartireSilabePlastic2.Location.Y;

            ButonDespartireSilabePlastic2.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }
    }
}
