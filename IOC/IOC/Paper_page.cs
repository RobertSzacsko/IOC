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
    public partial class Paper_page : Form
    {
        public Paper_page()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Paper_page_back_button_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            SecondPage st = new SecondPage();
            st.ShowDialog();
        }
    }
}
