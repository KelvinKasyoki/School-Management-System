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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Visible == true && txtRegNo.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRegNo.Focus();
            }
            else if (cboRegNo.Visible == true && cboRegNo.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboRegNo.Focus();
            }
            else if (txtStudentName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStudentName.Focus();
            }
            else if (cboYear.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboYear.Focus();
            }
            else if (cboProgramme.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboProgramme.Focus();
                            }
            else if (txtPhoneNo.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhoneNo.Focus();
            }
            else if (cboSemester.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSemester.Focus();

            }
            else
            {
                //sql codes to interact with the Database
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtRegNo.Visible=true;
            cboRegNo.Visible = false;
            this.Width = this.MdiParent.Width;
            this.Height = this.MdiParent.Height;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtRegNo.Visible = false;
            cboRegNo.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtRegNo.Visible = false;
            cboRegNo.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            txtPhoneNo.Text = "";
            txtRegNo.Text = "";
            chkStatus.CheckState =CheckState.Checked;
            txtStudentName.Text = "";
            cboProgramme.Text = "";
            cboRegNo.Text = "";
            cboSemester.Text = "";
            cboYear.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
