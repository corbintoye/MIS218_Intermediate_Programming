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
    public partial class ManageStudent : Form
    {
        private List<StudentClass> students = null;
        private DBManager manager = new DBManager();
        
        public ManageStudent()
        {
            InitializeComponent();

            students = manager.GetStudents();
            UpdateListBox();
        }

        //Updates list
        private void UpdateListBox()
        {
            lstStudents.Items.Clear();
            foreach (StudentClass student in students)
            {
                lstStudents.Items.Add(student.LastName + ", " + student.FirstName);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Update button handler
        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstStudents.SelectedIndex;

            if (selectedIndex == -1)
            {
                txtStudentID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();

                return;
            }

            StudentClass student = students[selectedIndex];
            student.Email = txtEmail.Text;
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;

            DBManager dbmanager = new DBManager();
            bool result = dbmanager.UpdateStudent(student);


            if (result)
            {
                MessageBox.Show("Successfully updated student");

                students = manager.GetStudents();
                UpdateListBox();
            }
        }

        //Add button handler
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentClass student = new StudentClass();

            student.Email = txtEmail.Text;
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;

            DBManager dbmanager = new DBManager();
            bool result = dbmanager.CreateStudent(student);


            if (result)
            {
                MessageBox.Show("Successfully added student");

                students = manager.GetStudents();
                UpdateListBox();
            }
        }

        //Delete button handler
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstStudents.SelectedIndex;

            if (selectedIndex == -1)
            {
                txtStudentID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();

                return;
            }

            StudentClass student = students[selectedIndex];
            student.StudentID = int.Parse(txtStudentID.Text);

            DBManager dbmanager = new DBManager();
            bool result = dbmanager.DeleteStudent(student);


            if (result)
            {
                MessageBox.Show("Successfully deleted student");

                students = manager.GetStudents();
                UpdateListBox();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtStudentID.Clear();
                txtEmail.Clear();
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
            students = manager.GetStudents();
            UpdateListBox();
        }

        //Selection handler
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstStudents.SelectedIndex;

            if (selectedIndex == -1)
            {
                txtFirstName.Clear();
                txtLastName.Clear();
                txtStudentID.Clear();
                txtEmail.Clear();

                return;
            }

            StudentClass student = students[selectedIndex];

            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtEmail.Text = student.Email;
            txtStudentID.Text = student.StudentID.ToString();
        }
    }
}
