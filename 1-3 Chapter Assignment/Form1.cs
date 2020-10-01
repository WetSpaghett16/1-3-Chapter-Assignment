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
            string name = txtName.Text;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblFinale.Visible = true;
            lblFinale.Text = "Thank you for your cooperation" + name;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

