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
    public partial class frmProgramCourse : Form
    {
        public frmProgramCourse()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProgCourseID.Visible == true && txtProgCourseID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProgCourseID.Focus();
            }
            else if (cboProgramCourseID.Visible == true && cboProgramCourseID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboProgramCourseID.Focus();
            }
            else if (cboProgramID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboProgramID.Focus();
            }
            else if (cboCourseID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCourseID.Focus();
            }
            else if (cboYoS.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboYoS.Focus();
            }
            else if (cboSemester.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSemester.Focus();
            }

            else
            {
                //Sql code goes here
            }
        }

        private void frmProgramCourse_Load(object sender, EventArgs e)
        {
            cboProgramCourseID.Visible = false;
            txtProgCourseID.Visible = true;
            this.Width = this.MdiParent.Width;
            this.Height = this.MdiParent.Height;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboProgramCourseID.Visible = false;
            txtProgCourseID.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboProgramCourseID.Visible = true;
            txtProgCourseID.Visible = false;
        }

        private void bnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            txtProgCourseID.Text = "";
            cboCourseID.Text = "";
            cboProgramID.Text = "";
            cboYoS.Text = "";
            cboSemester.Text = "";
            txtProgCourseID.Focus();

        }
    }
}
