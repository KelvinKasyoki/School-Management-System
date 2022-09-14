using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIMS
{
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }

        private void bnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCourseID.Visible == true && txtCourseID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCourseID.Focus();
            }
            else if (cboCourseID.Visible == true && cboCourseID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCourseID.Focus();
            }
            else if (cboUnits.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboUnits.Focus();
            }

            else
            {
                //Sql code goes here
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtCourseID.Visible = false;
            cboCourseID.Visible = true;
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            txtCourseID.Visible = true;
            cboCourseID.Visible = false;
            this.Width = this.MdiParent.Width;
            this.Height = this.MdiParent.Height;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtCourseID.Visible = false;
            cboCourseID.Visible = true;
        }
    }
}
