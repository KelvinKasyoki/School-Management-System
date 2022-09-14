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
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            this.Width = this.MdiParent.Width;
            this.Height = this.MdiParent.Height;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void cboSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cboLoadingID.Visible = false;
            txtLoadingID.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cboLoadingID.Visible = false;
            txtLoadingID.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            txtAcademicYear.Text = "";
            txtLoadingID.Text = "";
            txtLoadingType.Text = "";
            txtStaffID.Text = "";
            txtVenue.Text = "";
            cboLoadingID.Text = "";
            cboCourseID.Text = "";
            cboProgrammeID.Text = "";
            cboSemester.Text = "";
            cboStaffID.Text = "";
            txtTime.Text = "";
            txtLoadingID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLoadingID.Visible == true && txtLoadingID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboLoadingID.Focus();
            }
            else if (cboLoadingID.Visible == true && cboLoadingID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboLoadingID.Focus();
            }
            else if (cboProgrammeID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboProgrammeID.Focus();
            }
            else if (cboCourseID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCourseID.Focus();
            }
            else if ( cboStaffID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboStaffID.Focus();
            }
            else if (txtAcademicYear.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAcademicYear.Focus();
            }
            else if (cboSemester.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSemester.Focus();
            }
            else if (txtTime.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               txtTime.Focus();
            }
            else if (txtVenue.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtVenue.Focus();
            }
            else if (txtLoadingType.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoadingType.Focus();
            }

            else
            {
                //Sql code goes here
            }
        }
    }
}
