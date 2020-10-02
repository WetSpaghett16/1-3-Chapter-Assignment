using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_3_Chapter_Assignment
{
    public partial class frmChapterAssignment : Form
    {
       

        public frmChapterAssignment()
        {

            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblName2.Visible = true;
            lblHeight2.Visible = true;
            lblAge2.Visible = true;
            
        }

        private void txtName1_TextChanged(object sender, EventArgs e)
        {
            string name = txtName1.Text;
            lblName2.Text = "Hello " + name;
        }

        private void txtHeight_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            int Age;
            Age = Convert.ToInt32(txtAge.Text);
            int expectency = 82 - Age;
            lblAge2.Text = "You are " + expectency + " years below  life expentancy";
        }
    }
}