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
    public partial class SecondPage : Form
    {
        public SecondPage()
        {
            InitializeComponent();

            SoundPlayer player2 = new SoundPlayer();
            player2.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\aDouaPagina.wav";
            player2.Play();
            next_button.Visible = false;
            wait();
        }

        private async void wait()

        {
            await Task.Delay(37000);
            next_button.Visible = true;

        }

        private async void SecondPage_Load(object sender, EventArgs e)
        {
            labelReducere.Visible = false;
            labelRefolosire.Visible = false;
            labelReciclare.Visible = false;
            await Task.Delay(21000);
            labelReducere.Visible = true;
            await Task.Delay(500);
            labelRefolosire.Visible = true;
            await Task.Delay(500);
            labelReciclare.Visible = true;
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReducereDespartire pp = new ReducereDespartire();
            pp.ShowDialog();
        }
    }
    }

   

