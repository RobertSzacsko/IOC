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

        private async void Paper_page_Load(object sender, EventArgs e)
        {
            paperBin.Visible = false;
            cereal_box.Visible = false;
            down.Visible = false;
            paperEqualsTree.Visible = false;
            newspaper.Visible = false;
            right.Visible = false;
            cryingTree.Visible = false;
            notebook.Visible = false;
            up.Visible = false;
            cuttingTree.Visible = false;
            colored_paper.Visible = false;
            left.Visible = false;
            cuttingTrees.Visible = false;

            await Task.Delay(1000);
            paperBin.Visible = true;
            await Task.Delay(500);
            cereal_box.Visible = true;
            await Task.Delay(500);
            down.Visible = true;
            await Task.Delay(500);
            paperEqualsTree.Visible = true;
            await Task.Delay(500);
            newspaper.Visible = true;
            await Task.Delay(500);
            right.Visible = true;
            await Task.Delay(500);
            cryingTree.Visible = true;
            await Task.Delay(500);
            notebook.Visible = true;
            await Task.Delay(500);
            up.Visible = true;
            await Task.Delay(500);
            cuttingTree.Visible = true;
            await Task.Delay(500);
            colored_paper.Visible = true;
            await Task.Delay(500);
            left.Visible = true;
            await Task.Delay(500);
            cuttingTrees.Visible = true;
            await Task.Delay(500);
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resources.Hartie_Despartire st = new Resources.Hartie_Despartire();
            st.ShowDialog();
        }
    }
}
