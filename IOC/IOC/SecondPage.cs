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
            player2.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\secondPageRecycleSymbol.wav";
            player2.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void paperButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Paper_page pp = new Paper_page();
            pp.ShowDialog();
        }


        private async void SecondPage_Load(object sender, EventArgs e)
        {
            labelReducere.Visible = false;
            labelRefolosire.Visible = false;
            labelReciclare.Visible = false;
            await Task.Delay(20000);
            labelReducere.Visible = true;
            await Task.Delay(500);
            labelRefolosire.Visible = true;
            await Task.Delay(500);
            labelReciclare.Visible = true;
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Paper_page pp = new Paper_page();
            pp.ShowDialog();
        }
    }
    }

   

