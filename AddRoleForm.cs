using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExperimentTreeViewV2.Classes;
namespace ExperimentTreeViewV2
{
    public partial class AddRoleForm : Form
    {
        private Role _oneRole;
        public delegate void AddItemDelegate(string uuid, string roleName);
        public AddItemDelegate AddItemCallback;

        public AddRoleForm()
        {
            InitializeComponent();
            this._oneRole = new Role();
            _oneRole.UUID = General.GenerateUUID();
        }

        private void AddRoleForm_Load(object sender, EventArgs e)
        {
            this.textboxUUID.Text = _oneRole.UUID;

        }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            string name = textboxRoleName.Text.Trim();
            string uuid = textboxUUID.Text.Trim();
            if (name != "")
            {
                AddItemCallback(uuid, name);
                this.DialogResult = DialogResult.OK;

            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
