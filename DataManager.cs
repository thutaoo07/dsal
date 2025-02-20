using System;
using System.Collections.Generic;
using System.Diagnostics;
//namespace for file io
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

//namespace the the Application class
using System.Windows.Forms;

namespace ExperimentTreeViewV2.Classes
{
    [Serializable]
    internal class DataManager
        //******************************** IMPORTANT *********************************************
        //About DataManager
        //You should manage all the employee data, role data and project data by applying code
        //in this DataManager instead of having seperate RoleManager, EmployeeManager and ProjectManager class
        //****************************************************************************************
    {
        RoleTreeNode _roleTreeStructure;
        private string _filePath; // Saved data file path
        public DataManager()
        {
            _filePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Data.dat";
            _roleTreeStructure = new RoleTreeNode(new Role("ROOT"));
        }
        public RoleTreeNode GenerateFakeTreeStructure()
        {
            _roleTreeStructure = new RoleTreeNode(new Role("ROOT"));
            Role role1 = new Role("CEO");
            RoleTreeNode node1 = new RoleTreeNode(role1);
            _roleTreeStructure.AddChildRoleTreeNode(node1);
            Role role2 = new Role("ADVISORY BOARD");
            RoleTreeNode node2 = new RoleTreeNode(role2);
            node1.AddChildRoleTreeNode(node2);
            Role role3 = new Role("STAFF DIRECTOR");
            RoleTreeNode node3 = new RoleTreeNode(role3);
            node1.AddChildRoleTreeNode(node3);

            Role role4 = new Role("VOLUNTEER DIRECTOR");
            RoleTreeNode node4 = new RoleTreeNode(role4);
            node1.AddChildRoleTreeNode(node4);
            Role role5 = new Role("FINANCE DIRECTOR");
            RoleTreeNode node5 = new RoleTreeNode(role5);
            node3.AddChildRoleTreeNode(node5);
            Role role5_1 = new Role("FINANCE SPECIALIST");
            RoleTreeNode node5_1 = new RoleTreeNode(role5_1);
            node5.AddChildRoleTreeNode(node5_1);
            Role role6 = new Role("COMMUNICATIONS DIRECTOR");
            RoleTreeNode node6 = new RoleTreeNode(role6);
            node3.AddChildRoleTreeNode(node6);
            Role role6_1 = new Role("COMMUNICATIONS SPECIALIST");
            RoleTreeNode node6_1 = new RoleTreeNode(role6_1);
            node6.AddChildRoleTreeNode(node6_1);
            Role role7 = new Role("FUND RAISING DIRECTOR");
            RoleTreeNode node7 = new RoleTreeNode(role7);
            node3.AddChildRoleTreeNode(node7);
            Role role7_1 = new Role("FUND RAISING SPECIALIST");
            RoleTreeNode node7_1 = new RoleTreeNode(role7_1);
            node7.AddChildRoleTreeNode(node7_1);
            Role role8 = new Role("PROGRAM DIRECTOR");
            RoleTreeNode node8 = new RoleTreeNode(role8);
            node3.AddChildRoleTreeNode(node8);
            Role role8_1 = new Role("PROGRAM SPECIALIST");
            RoleTreeNode node8_1 = new RoleTreeNode(role8_1);
            node8.AddChildRoleTreeNode(node8_1);
            Role role9 = new Role("OPERATIONS DIRECTOR");
            RoleTreeNode node9 = new RoleTreeNode(role9);
            node3.AddChildRoleTreeNode(node9);
            Role role9_1 = new Role("OPERATIONS SPECIALIST");
            RoleTreeNode node9_1 = new RoleTreeNode(role9_1);
            node9.AddChildRoleTreeNode(node9_1);
            return _roleTreeStructure;
        }//end of GenerateFakeTreeStructure

        public RoleTreeNode RoleTreeStructure
        {
            get { return _roleTreeStructure; }
            set { _roleTreeStructure = value; }
        }


        public RoleTreeNode InitializeRoleTreeStructure()
        {
            Role role0 = new Role() { Name = "ROOT" };
            Role role1 = new Role() { Name = "Clusterhead" };
            Role role2 = new Role() { Name = "Manager" };
            Role role3 = new Role() { Name = "Project Manager" };
            Role role4 = new Role() { Name = "Project Leader", IsProjectLeader = true };
            Role role5 = new Role() { Name = "Backend Developer" };
            Role role6 = new Role() { Name = "Frontend Developer" };
            Role role7 = new Role() { Name = "Database Engineer" };
            Role role8 = new Role() { Name = "System Analyst" };
            Role role9 = new Role() { Name = "Finance Department Head" };
            Role role10 = new Role() { Name = "Accounts Manager" };
            Role role11 = new Role() { Name = "Business Development Manager" };
            Role role12 = new Role() { Name = "Strategic Planning Officer", IsProjectLeader = true };
            Role role13 = new Role() { Name = "Survey Officer" };
            Role role14 = new Role() { Name = "Data Analyst" };

            // Build the tree structure
            RoleTreeNode root = new RoleTreeNode(role0);
            RoleTreeNode node1 = new RoleTreeNode(role1, root);
            RoleTreeNode node2 = new RoleTreeNode(role2, node1);
            RoleTreeNode node3 = new RoleTreeNode(role3, node2);
            RoleTreeNode node4 = new RoleTreeNode(role4, node3);
            new RoleTreeNode(role5, node4);
            new RoleTreeNode(role6, node4);
            new RoleTreeNode(role7, node4);
            new RoleTreeNode(role8, node4);
            RoleTreeNode node9 = new RoleTreeNode(role9, root);
            RoleTreeNode node10 = new RoleTreeNode(role10, node9);
            new RoleTreeNode(role11, node10);
            RoleTreeNode node12 = new RoleTreeNode(role12, node10);
            new RoleTreeNode(role13, node12);
            new RoleTreeNode(role14, node12);

            return root;
        }

        public void SaveRoleData()
        {
            //this.RoleTreeStructure.SaveToFileBinary(_filePath);
        }//end of SaveRoleData

        public RoleTreeNode LoadRoleData()
        {
            //this.RoleTreeStructure = this.RoleTreeStructure.ReadFromFileBinary(_filePath);
            this.RoleTreeStructure.RebuildTreeNodes();
            return this.RoleTreeStructure;

        } //end of LoadRoleData method

    }//end of class RoleManager
}//end of namespace
