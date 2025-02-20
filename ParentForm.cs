using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperimentTreeViewV2
{
    public partial class ParentForm : Form
    {
        public Form2 roleForm;
        public Form3 empForm;

        public ParentForm()
        {
            InitializeComponent();
            this.roleFormToolStripMenuItem.Click += new EventHandler(roleFormToolStripMenuItemClicked);
            this.employeeFormToolStripMenuItem.Click += new EventHandler(employeeFormToolStripMenuItemClicked);
        }

        private void roleFormToolStripMenuItemClicked(object sender, EventArgs e)
        {
            if (roleForm != null)
            {
                roleForm.Show();
            }

            if (roleForm == null) 
            {
                roleForm = new Form2();
                roleForm.MdiParent = this;
                roleForm.Show();
            }

        }

        private void employeeFormToolStripMenuItemClicked(object sender, EventArgs e)
        {
            if (empForm != null)
            {
                empForm.Show();
            }

            if (empForm == null)
            {
                empForm = new Form3();
                empForm.MdiParent = this;
                empForm.Show();
            }

        }

    }
}
