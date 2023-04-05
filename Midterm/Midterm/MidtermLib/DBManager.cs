using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermLib
{
    public class DBManager
    {
        //Gets connection string
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Midterm"].ConnectionString;
        }

        public List<StudentClass> GetStudents()
        {
            //STUDENTS: Retrieves all students from DB
            List<StudentClass> students = null;

            string sql = "SELECT StudentId, LastName, FirstName, Email FROM Students ORDER BY LastName;";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                students = new List<StudentClass>();

                while (reader.Read())
                {
                    StudentClass student = new StudentClass();

                    student.StudentID = (int)reader["StudentId"];
                    student.LastName = (string)reader["LastName"];
                    student.FirstName = (string)reader["FirstName"];
                    student.Email = (string)reader["Email"];

                    students.Add(student);
                }

            }

            return students;

        }

        //STUDENTS: Updates student entry in DB
        public bool UpdateStudent(StudentClass student)
        {
            bool result = false;

            string sql = "UPDATE Students SET Email = @Email, FirstName = @FirstName, LastName = @LastName WHERE StudentId = @StudentId";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@StudentId", student.StudentID);
                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
            }

            return result;
        }

        //STUDENTS: Adds new student to DB
        public bool CreateStudent(StudentClass student)
        {
            bool result = false;

            string sql = "INSERT INTO Students (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
                return result;
            }
        }

        //STUDENTS Deletes student from DB
        public bool DeleteStudent(StudentClass student)
        {
            bool result = false;

            string sql = "DELETE FROM Students WHERE StudentId = @StudentId";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@StudentId", student.StudentID);
                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
                return result;
            }
        }

        //ASSIGNMENTS: Retrieves all assignments from DB
        public List<AssignmentClass> GetAssignments()
        {
            List<AssignmentClass> assignments = null;

            string sql = "SELECT AssignmentId, Name, TotalPoints FROM Assignments ORDER BY Name";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                assignments = new List<AssignmentClass>();

                while (reader.Read())
                {
                    AssignmentClass assignment = new AssignmentClass();

                    assignment.AssignmentId = (int)reader["AssignmentId"];
                    assignment.Name = (string)reader["Name"];
                    assignment.TotalPoints = (int)reader["TotalPoints"];

                    assignments.Add(assignment);
                }

            }

            return assignments;
        }

        //ASSIGNMENTS: Updates an assignment entry in the DB
        public bool UpdateAssignment(AssignmentClass assignment)
        {
            bool result = false;

            string sql = "UPDATE Assignments SET Name = @Name, TotalPoints = @TotalPoints WHERE AssignmentId = @AssignmentId";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@Name", assignment.Name);
                cmd.Parameters.AddWithValue("@TotalPoints", assignment.TotalPoints);
                cmd.Parameters.AddWithValue("@AssignmentId", assignment.AssignmentId);

                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
            }

            return result;
        }

        //ASSIGNMENTS: Adds a new assignment to DB
        public bool CreateAssignment(AssignmentClass assignment)
        {
            bool result = false;

            string sql = "INSERT INTO Assignments (Name, TotalPoints) VALUES (@Name, @TotalPoints)";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@Name", assignment.Name);
                cmd.Parameters.AddWithValue("@TotalPoints", assignment.TotalPoints);

                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
                return result;
            }
        }

        //ASSIGNENTS: Deletes assignment from DB
        public bool DeleteAssignment(AssignmentClass assignment)
        {
            bool result = false;

            string sql = "DELETE FROM Assignments WHERE AssignmentId = @AssignmentId";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@AssignmentId", assignment.AssignmentId);
                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
                return result;
            }
        }

        //GRADES: Retrieves a grade entry in the CompletedAssignments table
        public CompAssignmentClass GetGrade(int studentId, int assignmentId)
        {
            CompAssignmentClass grade = null;

            string sql = "SELECT EarnedPoints FROM CompletedAssignments WHERE StudentId = @StudentId AND AssignmentId = @AssignmentId";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@AssignmentId", assignmentId);

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    grade = new CompAssignmentClass();
                    grade.StudentId = studentId;
                    grade.AssignmentId = assignmentId;
                    grade.EarnedPoints = (int)reader["EarnedPoints"];
                }
            }

            return grade;
        }

        //GRADES: Adds a grade entry in the CompletedAssignments table
        public bool CreateGrade(CompAssignmentClass grade)
        {
            bool result = false;

            string sql = "INSERT INTO CompletedAssignments (StudentId, AssignmentId, EarnedPoints) VALUES (@StudentId, @AssignmentId, @EarnedPoints)";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@StudentId", grade.StudentId);
                cmd.Parameters.AddWithValue("@AssignmentId", grade.AssignmentId);
                cmd.Parameters.AddWithValue("@EarnedPoints", grade.EarnedPoints);

                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
                return result;
            }
        }

        //GRADES: Updates a grade entry in the CompletedAssignments table
        public bool UpdateGrade(CompAssignmentClass grade)
        {
            bool result = false;

            string sql = "UPDATE CompletedAssignments SET EarnedPoints = @EarnedPoints WHERE StudentId = @StudentId AND AssignmentId = @AssignmentId";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@EarnedPoints", grade.EarnedPoints);
                cmd.Parameters.AddWithValue("@StudentId", grade.StudentId);
                cmd.Parameters.AddWithValue("@AssignmentId", grade.AssignmentId);
                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
                return result;
            }
        }

        //GRADES: Deletes a grade entry from the CompletedAssignments table
        public bool DeleteGrade(CompAssignmentClass grade)
        {
            bool result = false;

            string sql = "DELETE FROM CompletedAssignments WHERE AssignmentId = @AssignmentId AND StudentId = @StudentId";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@AssignmentId", grade.AssignmentId);
                cmd.Parameters.AddWithValue("@StudentId", grade.StudentId);
                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
                return result;
            }
        }

        //REPORT CARD: Retrieves info for report card
        public List<ReportCardClass> GetReportCard()
        {
            List<ReportCardClass> report = null;

            string sql = @"SELECT
                            Students.StudentId,
                            FirstName,
                            LastName,
                            Email,
                            SUM(CompletedAssignments.EarnedPoints) AS EarnedPoints,
                            SUM(Assignments.TotalPoints) AS TotalPoints,
                            CAST(((SUM(CAST(EarnedPoints AS DECIMAL)) / SUM(CAST(TotalPoints AS DECIMAL))) * 100) AS DECIMAL(5, 2)) AS Grade
                            FROM Students
                            FULL OUTER JOIN CompletedAssignments ON Students.StudentId = CompletedAssignments.StudentId
                            FULL OUTER JOIN Assignments ON CompletedAssignments.AssignmentId = Assignments.AssignmentId
                            GROUP BY Students.FirstName, Students.LastName, Students.StudentId, Students.Email";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                report = new List<ReportCardClass>();

                while (reader.Read())
                {
                    ReportCardClass reports = new ReportCardClass();

                    reports.StudentID = (int)reader["StudentId"];
                    reports.LastName = (string)reader["LastName"];
                    reports.FirstName = (string)reader["FirstName"];
                    reports.Email = (string)reader["Email"];
                    reports.EarnedPoints = (int)reader["EarnedPoints"];
                    reports.TotalPoints = (int)reader["TotalPoints"];
                    reports.Grade = (decimal)reader["Grade"];

                    report.Add(reports);
                }

            }

            return report;
        }

    }
}
