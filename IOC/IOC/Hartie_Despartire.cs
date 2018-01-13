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

        // This integer variable keeps track of the 
        // remaining time.
        int timeLeft=5;
        public Hartie_Despartire()
        {
            InitializeComponent();
            //timeLable.Text = timeLeft.ToString();
            checkMark.Visible = false;
            cross_mark1.Visible = false;
            cross_mark2.Visible = false;

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\hartie_despartire.wav";
            player.Play();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Paper_page pp = new Paper_page();
            pp.ShowDialog();
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

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (timeLeft > 0)
            {
                
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLable.Text = timeLeft.ToString();
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\timpTerminat.wav";
                player.Play();
                timeLable.Text = "GATA";
                timeLable.BackColor = Color.Red;
                

            }
        }*/

    }
}
