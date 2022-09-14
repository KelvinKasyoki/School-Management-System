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
    public partial class frmProgramme : Form
    {
        public frmProgramme()
        {
            InitializeComponent();
        }

        private void frmProgramme_Load(object sender, EventArgs e)
        {
            cboDepartmentID.Visible =false;
            txtProgrammeID.Visible = true;
            this.Width = this.MdiParent.Width;
            this.Height = this.MdiParent.Height;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cboDepartmentID.Visible = true;
            txtProgrammeID.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboDepartmentID.Visible = true;
            txtProgrammeID.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProgrammeID.Text = "";
            txtProgrammeID.Text = "";
            cboDepartmentID.Text = "";
            txtProgrammeName.Text = "";
            cboDuration.Text = "";
            cboProgrammeID.Text = "";
            txtProgrammeID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProgrammeID.Visible == true && txtProgrammeID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProgrammeID.Focus();
            }
            else if (cboProgrammeID.Visible == true && cboProgrammeID.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboProgrammeID.Focus();
            }
            else if (txtProgrammeName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProgrammeName.Focus();
            }
            else if (cboDuration.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "CIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboDuration.Focus();
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

        private void bnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
