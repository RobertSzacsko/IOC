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
    public partial class Plastic_despartire : Form
    {
        public Plastic_despartire()
        {
            InitializeComponent();
        }

        private void Plastic_despartire_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ButonDespartireSilabePlastic_Click(object sender, EventArgs e)
        {
          System.Media.SoundPlayer SunetButonCorect = new System.Media.SoundPlayer(@"C:\Users\Razvan\Music\SunetCorect.wav");
            SunetButonCorect.Play();
        }

        private void ButonDespartireSilabePlastic1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer SunetButonIncorect = new System.Media.SoundPlayer(@"C:\Users\Razvan\Music\SunetEroare2.wav");
            SunetButonIncorect.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer SunetButonIncorect = new System.Media.SoundPlayer(@"C:\Users\Razvan\Music\SunetEroare2.wav");
            SunetButonIncorect.Play();
        }

        private void ButonInapoiPlasticDespartire_Click(object sender, EventArgs e)
        {

        }
    }
}
