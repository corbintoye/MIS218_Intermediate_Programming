using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidtermLib;

namespace SimpleGradebook
{
    public partial class ManageAssignment : Form
    {
        private List<AssignmentClass> assignments = null;
        private DBManager manager = new DBManager();

        public ManageAssignment()
        {
            InitializeComponent();

            assignments = manager.GetAssignments();
            UpdateListBox();
        }

        //Updates list
        private void UpdateListBox()
        {
            lstAssignments.Items.Clear();
            foreach (AssignmentClass assignment in assignments)
            {
                lstAssignments.Items.Add(assignment.Name);
            }
        }

        //Edit button handler
        private void btnEditAssignment_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstAssignments.SelectedIndex;

            if (selectedIndex == -1)
            {
                txtAssignmentID.Clear();
                txtAssignmentName.Clear();
                txtAssignmentTotalPoints.Clear();

                return;
            }

            AssignmentClass assignment = assignments[selectedIndex];
            assignment.AssignmentId = int.Parse(txtAssignmentID.Text);
            assignment.Name = txtAssignmentName.Text;
            assignment.TotalPoints = int.Parse(txtAssignmentTotalPoints.Text);

            DBManager dbmanager = new DBManager();
            bool result = dbmanager.UpdateAssignment(assignment);


            if (result)
            {
                MessageBox.Show("Successfully updated assignment");

                assignments = manager.GetAssignments();
                UpdateListBox();
            }
        }

        //Add button handler
        private void btnAddNewAssignment_Click(object sender, EventArgs e)
        {
            AssignmentClass assignment = new AssignmentClass();

            assignment.Name = txtAssignmentName.Text;
            assignment.TotalPoints = int.Parse(txtAssignmentTotalPoints.Text);
            

            DBManager dbmanager = new DBManager();
            bool result = dbmanager.CreateAssignment(assignment);


            if (result)
            {
                MessageBox.Show("Successfully added assignment");

                assignments = manager.GetAssignments();
                UpdateListBox();
            }
        }

        //Delete button handler
        private void btnDeleteAssignment_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstAssignments.SelectedIndex;

            if (selectedIndex == -1)
            {
                txtAssignmentID.Clear();
                txtAssignmentName.Clear();
                txtAssignmentTotalPoints.Clear();

                return;
            }

            AssignmentClass assignment = assignments[selectedIndex];
            assignment.AssignmentId = int.Parse(txtAssignmentID.Text);

            DBManager dbmanager = new DBManager();
            bool result = dbmanager.DeleteAssignment(assignment);


            if (result)
            {
                MessageBox.Show("Successfully deleted assignment");

                assignments = manager.GetAssignments();
                UpdateListBox();
                txtAssignmentID.Clear();
                txtAssignmentName.Clear();
                txtAssignmentTotalPoints.Clear();
            }
        }

        //Exit button handler
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Refresh button handler
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            assignments = manager.GetAssignments();
            UpdateListBox();
        }

        //Selection handler
        private void lstAssignments_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstAssignments.SelectedIndex;

            if (selectedIndex == -1)
            {
                txtAssignmentID.Clear();
                txtAssignmentName.Clear();
                txtAssignmentTotalPoints.Clear();

                return;
            }

            AssignmentClass assignment = assignments[selectedIndex];

            txtAssignmentName.Text = assignment.Name;
            txtAssignmentTotalPoints.Text = assignment.TotalPoints.ToString();
            txtAssignmentID.Text = assignment.AssignmentId.ToString();
        }
    }
}
