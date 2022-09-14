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
    public partial class frmFaculty : Form
    {
        public frmFaculty()
        {
            InitializeComponent();
        }

        private void bnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            cboFacultyID.Visible = false;
            txtFacultyID.Visible = true;
            this.Width = this.MdiParent.Width;
            this.Height = this.MdiParent.Height;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboFacultyID.Visible = true;
            txtFacultyID.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboFacultyID.Visible = false;
            txtFacultyID.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clean();
        }
        private void clean()
        {
            txtFacultyID.Text = "";
            txtFacultyName.Text = "";
            txtDescription.Text = "";
            cboFacultyID.Text = "";
            txtFacultyID.Focus();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFacultyID.Visible ==true && txtFacultyID.Text =="")
            {
                MessageBox.Show("Ensure all fields are filled!","CIMS Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtFacultyID.Focus();
            }
            else if(cboFacultyID.Visible ==true && cboFacultyID.Text =="")
            {
                MessageBox.Show("Ensure all fields are filled!","CIMS Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                cboFacultyID.Focus();
            }
            else if(txtFacultyName.Text =="")
            {
                MessageBox.Show("Ensure all fields are filled!");
                txtFacultyName.Focus();
            }
            else if (txtDescription.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!");
                txtDescription.Focus();
            }
            else
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
