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
            timeLable.Text = timeLeft + " seconds";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (timeLeft > 0)
            {
                
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLable.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLable.Text = "GATA";
                timeLable.BackColor = Color.Red;
                //SoundPlayer player = new SoundPlayer();
                //player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\FirstPageRob.wav";
                //player.Play();

            }
        }

    }
}
