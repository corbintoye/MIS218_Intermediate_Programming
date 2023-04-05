
namespace SimpleGradebook
{
    partial class ReportCard
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
            this.txtReportCard = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboStudents = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtReportCard
            // 
            this.txtReportCard.Location = new System.Drawing.Point(173, 12);
            this.txtReportCard.Multiline = true;
            this.txtReportCard.Name = "txtReportCard";
            this.txtReportCard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReportCard.Size = new System.Drawing.Size(531, 426);
            this.txtReportCard.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboStudents
            // 
            this.cboStudents.FormattingEnabled = true;
            this.cboStudents.Location = new System.Drawing.Point(12, 12);
            this.cboStudents.Name = "cboStudents";
            this.cboStudents.Size = new System.Drawing.Size(155, 21);
            this.cboStudents.TabIndex = 4;
            this.cboStudents.Text = "Select Student";
            this.cboStudents.SelectedIndexChanged += new System.EventHandler(this.cboStudents_SelectedIndexChanged);
            // 
            // ReportCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.cboStudents);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtReportCard);
            this.Name = "ReportCard";
            this.Text = "Report Card";
            this.Load += new System.EventHandler(this.ReportCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtReportCard;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboStudents;
    }
}