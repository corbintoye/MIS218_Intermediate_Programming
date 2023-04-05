
namespace SimpleFinances
{
    partial class PayeeManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDefaultCategory = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeletePayee = new System.Windows.Forms.Button();
            this.btnEditPayee = new System.Windows.Forms.Button();
            this.btnAddPayee = new System.Windows.Forms.Button();
            this.txtPayeeName = new System.Windows.Forms.TextBox();
            this.txtPayeeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPayees = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDefaultCategory);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnDeletePayee);
            this.groupBox1.Controls.Add(this.btnEditPayee);
            this.groupBox1.Controls.Add(this.btnAddPayee);
            this.groupBox1.Controls.Add(this.txtPayeeName);
            this.groupBox1.Controls.Add(this.txtPayeeID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstPayees);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payees";
            // 
            // cboDefaultCategory
            // 
            this.cboDefaultCategory.FormattingEnabled = true;
            this.cboDefaultCategory.Location = new System.Drawing.Point(266, 76);
            this.cboDefaultCategory.Name = "cboDefaultCategory";
            this.cboDefaultCategory.Size = new System.Drawing.Size(172, 21);
            this.cboDefaultCategory.TabIndex = 11;
            this.cboDefaultCategory.SelectedIndexChanged += new System.EventHandler(this.cboDefaultCategory_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(363, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeletePayee
            // 
            this.btnDeletePayee.Location = new System.Drawing.Point(320, 172);
            this.btnDeletePayee.Name = "btnDeletePayee";
            this.btnDeletePayee.Size = new System.Drawing.Size(95, 23);
            this.btnDeletePayee.TabIndex = 9;
            this.btnDeletePayee.Text = "Delete Payee";
            this.btnDeletePayee.UseVisualStyleBackColor = true;
            this.btnDeletePayee.Click += new System.EventHandler(this.btnDeletePayee_Click);
            // 
            // btnEditPayee
            // 
            this.btnEditPayee.Location = new System.Drawing.Point(320, 143);
            this.btnEditPayee.Name = "btnEditPayee";
            this.btnEditPayee.Size = new System.Drawing.Size(95, 23);
            this.btnEditPayee.TabIndex = 8;
            this.btnEditPayee.Text = "Edit Payee";
            this.btnEditPayee.UseVisualStyleBackColor = true;
            this.btnEditPayee.Click += new System.EventHandler(this.btnEditPayee_Click);
            // 
            // btnAddPayee
            // 
            this.btnAddPayee.Location = new System.Drawing.Point(320, 114);
            this.btnAddPayee.Name = "btnAddPayee";
            this.btnAddPayee.Size = new System.Drawing.Size(95, 23);
            this.btnAddPayee.TabIndex = 7;
            this.btnAddPayee.Text = "Add Payee";
            this.btnAddPayee.UseVisualStyleBackColor = true;
            this.btnAddPayee.Click += new System.EventHandler(this.btnAddPayee_Click);
            // 
            // txtPayeeName
            // 
            this.txtPayeeName.Location = new System.Drawing.Point(266, 50);
            this.txtPayeeName.Name = "txtPayeeName";
            this.txtPayeeName.Size = new System.Drawing.Size(172, 20);
            this.txtPayeeName.TabIndex = 5;
            // 
            // txtPayeeID
            // 
            this.txtPayeeID.Location = new System.Drawing.Point(266, 25);
            this.txtPayeeID.Name = "txtPayeeID";
            this.txtPayeeID.ReadOnly = true;
            this.txtPayeeID.Size = new System.Drawing.Size(172, 20);
            this.txtPayeeID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Default Category:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lstPayees
            // 
            this.lstPayees.FormattingEnabled = true;
            this.lstPayees.Location = new System.Drawing.Point(6, 19);
            this.lstPayees.Name = "lstPayees";
            this.lstPayees.Size = new System.Drawing.Size(159, 277);
            this.lstPayees.TabIndex = 0;
            this.lstPayees.SelectedIndexChanged += new System.EventHandler(this.lstPayees_SelectedIndexChanged);
            // 
            // PayeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 330);
            this.Controls.Add(this.groupBox1);
            this.Name = "PayeeManagement";
            this.Text = "Manage Payees";
            this.Load += new System.EventHandler(this.PayeeManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPayees;
        private System.Windows.Forms.TextBox txtPayeeName;
        private System.Windows.Forms.TextBox txtPayeeID;
        private System.Windows.Forms.Button btnDeletePayee;
        private System.Windows.Forms.Button btnEditPayee;
        private System.Windows.Forms.Button btnAddPayee;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboDefaultCategory;
    }
}