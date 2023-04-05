using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGradebook
{
    public partial class SGHome : Form
    {
        public SGHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent();
            manageStudent.Show();
        }

        private void btnManageAssignments_Click(object sender, EventArgs e)
        {
            ManageAssignment manageAssignment = new ManageAssignment();
            manageAssignment.Show();
        }

        private void btnManageGrades_Click(object sender, EventArgs e)
        {
            ManageGrade manageGrade = new ManageGrade();
            manageGrade.Show();
        }

        private void btnReportCard_Click(object sender, EventArgs e)
        {
            ReportCard reportCard = new ReportCard();
            reportCard.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
