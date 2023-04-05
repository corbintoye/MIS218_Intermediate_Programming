
namespace SimpleGradebook
{
    partial class SGHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnManageAssignments = new System.Windows.Forms.Button();
            this.btnManageGrades = new System.Windows.Forms.Button();
            this.btnReportCard = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Gradebook";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Location = new System.Drawing.Point(17, 50);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(188, 37);
            this.btnManageStudents.TabIndex = 1;
            this.btnManageStudents.Text = "Manage Students";
            this.btnManageStudents.UseVisualStyleBackColor = true;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // btnManageAssignments
            // 
            this.btnManageAssignments.Location = new System.Drawing.Point(17, 93);
            this.btnManageAssignments.Name = "btnManageAssignments";
            this.btnManageAssignments.Size = new System.Drawing.Size(188, 37);
            this.btnManageAssignments.TabIndex = 2;
            this.btnManageAssignments.Text = "Manage Assignments";
            this.btnManageAssignments.UseVisualStyleBackColor = true;
            this.btnManageAssignments.Click += new System.EventHandler(this.btnManageAssignments_Click);
            // 
            // btnManageGrades
            // 
            this.btnManageGrades.Location = new System.Drawing.Point(17, 136);
            this.btnManageGrades.Name = "btnManageGrades";
            this.btnManageGrades.Size = new System.Drawing.Size(188, 37);
            this.btnManageGrades.TabIndex = 3;
            this.btnManageGrades.Text = "Manage Grades";
            this.btnManageGrades.UseVisualStyleBackColor = true;
            this.btnManageGrades.Click += new System.EventHandler(this.btnManageGrades_Click);
            // 
            // btnReportCard
            // 
            this.btnReportCard.Location = new System.Drawing.Point(17, 209);
            this.btnReportCard.Name = "btnReportCard";
            this.btnReportCard.Size = new System.Drawing.Size(188, 37);
            this.btnReportCard.TabIndex = 4;
            this.btnReportCard.Text = "Generate Report Card";
            this.btnReportCard.UseVisualStyleBackColor = true;
            this.btnReportCard.Click += new System.EventHandler(this.btnReportCard_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(17, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SGHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 311);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReportCard);
            this.Controls.Add(this.btnManageGrades);
            this.Controls.Add(this.btnManageAssignments);
            this.Controls.Add(this.btnManageStudents);
            this.Controls.Add(this.label1);
            this.Name = "SGHome";
            this.Text = "Simple Gradebook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnManageAssignments;
        private System.Windows.Forms.Button btnManageGrades;
        private System.Windows.Forms.Button btnReportCard;
        private System.Windows.Forms.Button btnExit;
    }
}

