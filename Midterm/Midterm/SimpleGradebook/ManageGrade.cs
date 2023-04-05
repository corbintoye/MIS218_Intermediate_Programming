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
    public partial class ManageGrade : Form
    {
        private List<StudentClass> students = null;
        private List<AssignmentClass> assignments = null;
        private int grade = 0;
        private DBManager manager = new DBManager();

        public ManageGrade()
        {
            InitializeComponent();

            assignments = manager.GetAssignments();
            UpdateListBoxA();
            students = manager.GetStudents();
            UpdateListBoxB();
        }

        //Updates assignments list
        private void UpdateListBoxA()
        {
            lstAssignments.Items.Clear();
            foreach (AssignmentClass assignment in assignments)
            {
                lstAssignments.Items.Add(assignment.Name);
            }
        }

        //Updates students list
        private void UpdateListBoxB()
        {
            lstStudents.Items.Clear();
            foreach (StudentClass student in students)
            {
                lstStudents.Items.Add(student.LastName + ", " + student.FirstName);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Save button handler
        private void btnSave_Click(object sender, EventArgs e)
        {
            CompAssignmentClass grade = new CompAssignmentClass();

            grade.StudentId = int.Parse(txtStudentID.Text);
            grade.AssignmentId = int.Parse(txtAssignmentID.Text);
            grade.EarnedPoints = int.Parse(txtEarnedPoints.Text);

            DBManager dbmanager = new DBManager();
            bool result = dbmanager.CreateGrade(grade);


            if (result)
            {
                MessageBox.Show("Successfully saved grade");

                assignments = manager.GetAssignments();
                UpdateListBoxA();
                students = manager.GetStudents();
                UpdateListBoxB();
            }
        }

        //Delete button handler
        private void btnDelete_Click(object sender, EventArgs e)
        {
            CompAssignmentClass grade = new CompAssignmentClass();

            grade.StudentId = int.Parse(txtStudentID.Text);
            grade.AssignmentId = int.Parse(txtAssignmentID.Text);
            grade.EarnedPoints = int.Parse(txtEarnedPoints.Text);

            DBManager dbmanager = new DBManager();
            bool result = dbmanager.DeleteGrade(grade);


            if (result)
            {
                MessageBox.Show("Successfully deleted grade");

                assignments = manager.GetAssignments();
                UpdateListBoxA();
                students = manager.GetStudents();
                UpdateListBoxB();

                txtEarnedPoints.Clear();
            }
        }

        //Exit button handler
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Student selection handler
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstStudents.SelectedIndex;

            if (selectedIndex == -1)
            {
                txtStudent.Clear();
                txtStudentID.Clear();
                txtEarnedPoints.Clear();
                

                return;
            }

            StudentClass student = students[selectedIndex];

            txtStudent.Text = student.FirstName + " " + student.LastName;
            txtStudentID.Text = student.StudentID.ToString();

            
        }

        //Assignment selection handler
        private void lstAssignments_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstAssignments.SelectedIndex;

            if (selectedIndex == -1)
            {
                txtAssignmentID.Clear();
                txtAssignment.Clear();
                txtTotalPoints.Clear();
                txtEarnedPoints.Clear();

                return;
            }

            AssignmentClass assignment = assignments[selectedIndex];

            txtAssignment.Text = assignment.Name;
            txtTotalPoints.Text = assignment.TotalPoints.ToString();
            txtAssignmentID.Text = assignment.AssignmentId.ToString();
            
        }

        //Refresh button handler
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            assignments = manager.GetAssignments();
            UpdateListBoxA();
            students = manager.GetStudents();
            UpdateListBoxB();

            
        }

        //Update earned points box
        private void UpdateGradeBox()
        {
            CompAssignmentClass grade = manager.GetGrade(int.Parse(txtStudentID.Text), int.Parse(txtAssignmentID.Text));
            if (grade != null)
            {
                txtEarnedPoints.Text = grade.EarnedPoints.ToString();
            }
            else
            {
                txtEarnedPoints.Clear();
                MessageBox.Show("Student does not have a grade entry for the selected assignment.", "Empty Grade", MessageBoxButtons.OK);
                
            }
             
        }

        //Check grade button handler
        private void btnCheckGrade_Click(object sender, EventArgs e)
        {
            UpdateGradeBox();
        }

        //Update grade button handler
        private void btnUpdateGrade_Click(object sender, EventArgs e)
        {
            CompAssignmentClass grade = new CompAssignmentClass();

            grade.StudentId = int.Parse(txtStudentID.Text);
            grade.AssignmentId = int.Parse(txtAssignmentID.Text);
            grade.EarnedPoints = int.Parse(txtEarnedPoints.Text);

            DBManager dbmanager = new DBManager();
            bool result = dbmanager.UpdateGrade(grade);


            if (result)
            {
                MessageBox.Show("Successfully updated grade");

                assignments = manager.GetAssignments();
                UpdateListBoxA();
                students = manager.GetStudents();
                UpdateListBoxB();


            }
        }
    }
}
