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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        

        private void facultyMenu_Click(object sender, EventArgs e)
        {
            frmFaculty fac = new frmFaculty();
            fac.MdiParent = this;
            fac.Visible = true;
        }

        private void programMenu_Click(object sender, EventArgs e)
        {
            frmProgramme prog = new frmProgramme();
            prog.MdiParent = this;
            prog.Visible = true;
        }

        private void departmentMenu_Click(object sender, EventArgs e)
        {
            frmDepartment dep = new frmDepartment();
            dep.MdiParent = this;
            dep.Visible = true;
        }

        private void courseDetailsSubMenu_Click(object sender, EventArgs e)
        {
            frmCourse cos = new frmCourse();
            cos.MdiParent = this;
            cos.Visible = true;
        }

        private void programCoursesSubMenu_Click(object sender, EventArgs e)
        {
            frmProgramCourse progcos = new frmProgramCourse();
            progcos.MdiParent = this;
            progcos.Visible = true;
        }

        private void loadingSubMenu_Click(object sender, EventArgs e)
        {
            frmLoading lod = new frmLoading();
            lod.MdiParent = this;
            lod.Visible = true;
        }

        private void staffMenu_Click(object sender, EventArgs e)
        {
            frmStaff staf = new frmStaff();
            staf.MdiParent = this;
            staf.Visible = true;
        }

        private void studentMenu_Click(object sender, EventArgs e)
        {
            frmStudent stud = new frmStudent();
            stud.MdiParent = this;
            stud.Visible = true;
        }

        private void logoutMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
