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
    public partial class ReportCard : Form
    {
        
        private List<ReportCardClass> reports = null;
        private DBManager manager = new DBManager();

        public ReportCard()
        {
            InitializeComponent();
        }

        //Exit button handler
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ReportCard_Load(object sender, EventArgs e)
        {
            reports = manager.GetReportCard();
            RefreshComboBox();
        }

        //Builds report card from selected student
        private void cboStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboStudents.SelectedIndex == -1)
            {
                return;
            }

            ReportCardClass report = reports[cboStudents.SelectedIndex];

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Student ID: {report.StudentID}");
            sb.AppendLine($"Name: {report.FirstName} {report.LastName}");
            sb.AppendLine($"Email: {report.Email}");
            sb.AppendLine();
            sb.AppendLine($"{report.EarnedPoints} / {report.TotalPoints} ");
            sb.AppendLine($"{report.Grade}%");

            txtReportCard.Text = sb.ToString();

        }

        //Refreshes combo box student selector
        private void RefreshComboBox()
        {
            cboStudents.Items.Clear();
            foreach (ReportCardClass report in reports)
            {
                cboStudents.Items.Add(report.FirstName + " " + report.LastName);
            }
        }
    }
}
