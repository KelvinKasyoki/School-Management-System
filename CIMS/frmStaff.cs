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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboDepartmentID.Text = "";
            txtDesignation.Text = "";
            txtLoginName.Text = "";
            txtPassword.Text = "";
            txtPfNo.Text = "";
            txtPhoneNo.Text = "";
            txtStaffI.Text = "";
            txtStaffName.Text = "";
            chkStatus.CheckState = CheckState.Checked;
            cboPreviledges.Text = "";
            cboStaffID.Text = "";
            txtStaffI.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStaffI.Visible == true && txtStaffI.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStaffI.Focus();
            }
            else if (cboStaffID.Visible == true && cboStaffID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboStaffID.Focus();
            }
            else if (txtStaffName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStaffName.Focus();
            }
            else if (txtPhoneNo.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhoneNo.Focus();
            }
            else if (txtDesignation.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDesignation.Focus();
            }
            else if (txtPfNo.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPfNo.Focus();
            }
            else if (cboPreviledges.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPreviledges.Focus();
            }
            else if (txtLoginName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoginName.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
            }
            else if (cboDepartmentID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboDepartmentID.Focus();
            }

            else
            {
                //Sql code goes here
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cboStaffID.Visible = true;
            txtStaffI.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cboStaffID.Visible = true;
            txtStaffI.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboStaffID.Visible = false;
            txtStaffI.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            cboStaffID.Visible = false;
            txtStaffI.Visible = true;
            this.Width = this.MdiParent.Width;
            this.Height = this.MdiParent.Height;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}
