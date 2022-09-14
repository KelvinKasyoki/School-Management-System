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
    public partial class frmSplash : Form
    {
        int counter;
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (counter <= 100)
            {
                lblDisplay.Text = "Loading..." + counter + "%";
                progressBar1.Value = counter;
            }
            else
            {
                MDIParent1 mdi = new MDIParent1();
                mdi.Visible = true;
                this.Hide();
                timer1.Enabled = false;
            }
            counter += 20;
            
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            counter = 0;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}
