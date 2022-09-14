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
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDepartmentID.Visible == true && txtDepartmentID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDepartmentID.Focus();
            }
            else if (cboDepartmentID.Visible == true && cboDepartmentID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboFacultyID.Focus();
            }
            else if (cboFacultyID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboFacultyID.Focus();
            }
            else if (txtDepartmentName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDepartmentName.Focus();
            }
            
            else
            {
                //Sql code goes here
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            txtDepartmentID.Text = "";
            txtDepartmentName.Text = "";
            cboFacultyID.Text = "";
            txtDepartmentID.Focus();

        }
        private void bnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboDepartmentID.Visible = true;
            txtDepartmentID.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cboDepartmentID.Visible = true;
            txtDepartmentID.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboDepartmentID.Visible = false;
            txtDepartmentID.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            cboDepartmentID.Visible = false;
            txtDepartmentID.Visible = true;
            this.Width = this.MdiParent.Width;
            this.Height = this.MdiParent.Height;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}
