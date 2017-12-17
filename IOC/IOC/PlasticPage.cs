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
    public partial class PlasticPage : Form
    {
        public PlasticPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecondPage sc = new SecondPage();
            sc.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
