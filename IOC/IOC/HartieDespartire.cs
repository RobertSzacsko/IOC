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

namespace IOC.Resources
{
    public partial class Hartie_Despartire : Form
    { 
        public Hartie_Despartire()
        {
            InitializeComponent();

            checkMark.Visible = false;
            cross_mark1.Visible = false;
            cross_mark2.Visible = false;

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\hartieSilabe.wav";
            player.Play();
        }

        private void button_hartie_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\wrong.wav";
            player.Play();
            cross_mark1.Visible = true;
            cross_mark2.Visible = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\correct.wav";
            player.Play();
            checkMark.Visible = true;
            cross_mark1.Visible = false;
            cross_mark2.Visible = false;
            button_hartie.Enabled = false;
            button2.Enabled = false;

            await Task.Delay(1000);

            this.Hide();
            PlasticPage pp = new PlasticPage();
            pp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\wrong.wav";
            player.Play();
            cross_mark1.Visible = false;
            cross_mark2.Visible = true;
            
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlasticPage pp = new PlasticPage();
            pp.ShowDialog();
        }

        private void button_hartie_MouseHover(object sender, EventArgs e)
        {
            var width = button_hartie.Size.Width;
            var height = button_hartie.Size.Height;
            var x = button_hartie.Location.X;
            var y = button_hartie.Location.Y;

            button_hartie.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }

        private void button_hartie_MouseLeave(object sender, EventArgs e)
        {
            var width = button_hartie.Size.Width;
            var height = button_hartie.Size.Height;
            var x = button_hartie.Location.X;
            var y = button_hartie.Location.Y;

            button_hartie.SetBounds(x + 5, y + 5, width - 10, height - 10);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            var width = button1.Size.Width;
            var height = button1.Size.Height;
            var x = button1.Location.X;
            var y = button1.Location.Y;

            button1.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            var width = button1.Size.Width;
            var height = button1.Size.Height;
            var x = button1.Location.X;
            var y = button1.Location.Y;

            button1.SetBounds(x + 5, y + 5, width - 10, height - 10);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            var width = button2.Size.Width;
            var height = button2.Size.Height;
            var x = button2.Location.X;
            var y = button2.Location.Y;

            button2.SetBounds(x - 5, y - 5, width + 10, height + 10);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            var width = button2.Size.Width;
            var height = button2.Size.Height;
            var x = button2.Location.X;
            var y = button2.Location.Y;

            button2.SetBounds(x + 5, y + 5, width - 10, height - 10);
        }

    }
}
