
namespace SimpleGradebook
{
    partial class ManageAssignment
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
            this.lstAssignments = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAssignmentTotalPoints = new System.Windows.Forms.TextBox();
            this.txtAssignmentName = new System.Windows.Forms.TextBox();
            this.txtAssignmentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditAssignment = new System.Windows.Forms.Button();
            this.btnAddNewAssignment = new System.Windows.Forms.Button();
            this.btnDeleteAssignment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAssignments
            // 
            this.lstAssignments.FormattingEnabled = true;
            this.lstAssignments.Location = new System.Drawing.Point(12, 12);
            this.lstAssignments.Name = "lstAssignments";
            this.lstAssignments.Size = new System.Drawing.Size(243, 381);
            this.lstAssignments.TabIndex = 0;
            this.lstAssignments.SelectedIndexChanged += new System.EventHandler(this.lstAssignments_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAssignmentTotalPoints);
            this.groupBox1.Controls.Add(this.txtAssignmentName);
            this.groupBox1.Controls.Add(this.txtAssignmentID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(261, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Assignment";
            // 
            // txtAssignmentTotalPoints
            // 
            this.txtAssignmentTotalPoints.Location = new System.Drawing.Point(105, 89);
            this.txtAssignmentTotalPoints.Name = "txtAssignmentTotalPoints";
            this.txtAssignmentTotalPoints.Size = new System.Drawing.Size(131, 20);
            this.txtAssignmentTotalPoints.TabIndex = 5;
            // 
            // txtAssignmentName
            // 
            this.txtAssignmentName.Location = new System.Drawing.Point(105, 58);
            this.txtAssignmentName.Name = "txtAssignmentName";
            this.txtAssignmentName.Size = new System.Drawing.Size(131, 20);
            this.txtAssignmentName.TabIndex = 4;
            // 
            // txtAssignmentID
            // 
            this.txtAssignmentID.Location = new System.Drawing.Point(105, 28);
            this.txtAssignmentID.Name = "txtAssignmentID";
            this.txtAssignmentID.ReadOnly = true;
            this.txtAssignmentID.Size = new System.Drawing.Size(131, 20);
            this.txtAssignmentID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assignment ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnEditAssignment
            // 
            this.btnEditAssignment.Location = new System.Drawing.Point(261, 163);
            this.btnEditAssignment.Name = "btnEditAssignment";
            this.btnEditAssignment.Size = new System.Drawing.Size(132, 35);
            this.btnEditAssignment.TabIndex = 2;
            this.btnEditAssignment.Text = "Edit Assignment";
            this.btnEditAssignment.UseVisualStyleBackColor = true;
            this.btnEditAssignment.Click += new System.EventHandler(this.btnEditAssignment_Click);
            // 
            // btnAddNewAssignment
            // 
            this.btnAddNewAssignment.Location = new System.Drawing.Point(261, 230);
            this.btnAddNewAssignment.Name = "btnAddNewAssignment";
            this.btnAddNewAssignment.Size = new System.Drawing.Size(132, 35);
            this.btnAddNewAssignment.TabIndex = 3;
            this.btnAddNewAssignment.Text = "Add New Assignment";
            this.btnAddNewAssignment.UseVisualStyleBackColor = true;
            this.btnAddNewAssignment.Click += new System.EventHandler(this.btnAddNewAssignment_Click);
            // 
            // btnDeleteAssignment
            // 
            this.btnDeleteAssignment.Location = new System.Drawing.Point(261, 271);
            this.btnDeleteAssignment.Name = "btnDeleteAssignment";
            this.btnDeleteAssignment.Size = new System.Drawing.Size(132, 35);
            this.btnDeleteAssignment.TabIndex = 4;
            this.btnDeleteAssignment.Text = "Delete Assignment";
            this.btnDeleteAssignment.UseVisualStyleBackColor = true;
            this.btnDeleteAssignment.Click += new System.EventHandler(this.btnDeleteAssignment_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(261, 397);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 397);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(132, 35);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteAssignment);
            this.Controls.Add(this.btnAddNewAssignment);
            this.Controls.Add(this.btnEditAssignment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstAssignments);
            this.Name = "ManageAssignment";
            this.Text = "Manage Assignments";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAssignments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAssignmentTotalPoints;
        private System.Windows.Forms.TextBox txtAssignmentName;
        private System.Windows.Forms.TextBox txtAssignmentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditAssignment;
        private System.Windows.Forms.Button btnAddNewAssignment;
        private System.Windows.Forms.Button btnDeleteAssignment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
    }
}