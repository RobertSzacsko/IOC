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
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\plastic_despartire.wav";
            player.Play();

        }

        private void Plastic_despartire_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlasticPage pp = new PlasticPage();
            pp.ShowDialog();
        }

        private void ButonDespartireSilabePlastic_Enter(object sender, EventArgs e)
        {
            
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
    }
}
