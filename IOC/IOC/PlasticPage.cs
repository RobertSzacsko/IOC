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
    public partial class PlasticPage : Form
    {
        public PlasticPage()
        {
            InitializeComponent();

            SoundPlayer player2 = new SoundPlayer();
            player2.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\plastic.wav";
            player2.Play();

            next_button.Visible = false;
            wait();
        }
        private async void wait()

        {
            await Task.Delay(23000);
            next_button.Visible = true;

        }


        private void next_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Plastic_Despartire st = new Plastic_Despartire();
            st.ShowDialog();
        }

        private async void PlasticPage_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            toys.Visible = false;
            Down.Visible = false;
            cupWithStraw.Visible = false;
            pictureBox4.Visible = false;
            straws.Visible = false;
            up.Visible = false;
            juice.Visible = false;
            pictureBox3.Visible = false;
            turtle.Visible = false;
            illEarth.Visible = false;

            await Task.Delay(1000);
            pictureBox1.Visible = true;
            await Task.Delay(500);
            toys.Visible = true;
            await Task.Delay(500);
            Down.Visible = true;
            await Task.Delay(500);
            cupWithStraw.Visible = true;
            await Task.Delay(500);
            pictureBox4.Visible = true;
            await Task.Delay(500);
            straws.Visible = true;
            await Task.Delay(500);
            up.Visible = true;
            await Task.Delay(500);
            juice.Visible = true;
            await Task.Delay(500);
            pictureBox3.Visible = true;
            await Task.Delay(500);
            turtle.Visible = true;
            await Task.Delay(500);
            await Task.Delay(500);
            illEarth.Visible = true;
        }
    }
}
