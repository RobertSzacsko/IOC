using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOC
{
    public partial class SecondPage : Form
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlasticPage pl= new PlasticPage();
            pl.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            START st = new START();
            st.ShowDialog();
        }

    }
    }

   

