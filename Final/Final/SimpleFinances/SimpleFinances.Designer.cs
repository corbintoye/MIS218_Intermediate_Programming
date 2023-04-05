
namespace SimpleFinances
{
    partial class SimpleFinances
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
            this.groupBoxAccounts = new System.Windows.Forms.GroupBox();
            this.btnManagePayees = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnManageCategories = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.groupBoxTransactions = new System.Windows.Forms.GroupBox();
            this.btnRefreshAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSelectedAccountName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lstViewTransactions = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Payee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Notes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.btnEditTransaction = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboPayee = new System.Windows.Forms.ComboBox();
            this.txtTransactionAccount = new System.Windows.Forms.TextBox();
            this.txtTransactionAmount = new System.Windows.Forms.TextBox();
            this.dateTimeTransaction = new System.Windows.Forms.DateTimePicker();
            this.txtTransactionID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxAccounts.SuspendLayout();
            this.groupBoxTransactions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAccounts
            // 
            this.groupBoxAccounts.Controls.Add(this.btnManagePayees);
            this.groupBoxAccounts.Controls.Add(this.btnRefresh);
            this.groupBoxAccounts.Controls.Add(this.btnManageCategories);
            this.groupBoxAccounts.Controls.Add(this.btnUpdateAccount);
            this.groupBoxAccounts.Controls.Add(this.txtAccountBalance);
            this.groupBoxAccounts.Controls.Add(this.txtAccountName);
            this.groupBoxAccounts.Controls.Add(this.txtAccountID);
            this.groupBoxAccounts.Controls.Add(this.label3);
            this.groupBoxAccounts.Controls.Add(this.label2);
            this.groupBoxAccounts.Controls.Add(this.label1);
            this.groupBoxAccounts.Controls.Add(this.btnDeleteAccount);
            this.groupBoxAccounts.Controls.Add(this.btnAddAccount);
            this.groupBoxAccounts.Controls.Add(this.lstAccounts);
            this.groupBoxAccounts.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAccounts.Name = "groupBoxAccounts";
            this.groupBoxAccounts.Size = new System.Drawing.Size(440, 348);
            this.groupBoxAccounts.TabIndex = 0;
            this.groupBoxAccounts.TabStop = false;
            this.groupBoxAccounts.Text = "Account Management";
            // 
            // btnManagePayees
            // 
            this.btnManagePayees.Location = new System.Drawing.Point(301, 282);
            this.btnManagePayees.Name = "btnManagePayees";
            this.btnManagePayees.Size = new System.Drawing.Size(120, 26);
            this.btnManagePayees.TabIndex = 7;
            this.btnManagePayees.Text = "Manage Payees";
            this.btnManagePayees.UseVisualStyleBackColor = true;
            this.btnManagePayees.Click += new System.EventHandler(this.btnManagePayees_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(324, 105);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 26);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Cancel Selection";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnManageCategories
            // 
            this.btnManageCategories.Location = new System.Drawing.Point(301, 314);
            this.btnManageCategories.Name = "btnManageCategories";
            this.btnManageCategories.Size = new System.Drawing.Size(120, 26);
            this.btnManageCategories.TabIndex = 6;
            this.btnManageCategories.Text = "Manage Categories";
            this.btnManageCategories.UseVisualStyleBackColor = true;
            this.btnManageCategories.Click += new System.EventHandler(this.btnManageCategories_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(6, 282);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(170, 26);
            this.btnUpdateAccount.TabIndex = 9;
            this.btnUpdateAccount.Text = "Update Account Name";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Location = new System.Drawing.Point(237, 70);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.ReadOnly = true;
            this.txtAccountBalance.Size = new System.Drawing.Size(184, 20);
            this.txtAccountBalance.TabIndex = 8;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(237, 43);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(184, 20);
            this.txtAccountName.TabIndex = 7;
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(237, 16);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.ReadOnly = true;
            this.txtAccountID.Size = new System.Drawing.Size(96, 20);
            this.txtAccountID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Balance:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(6, 314);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(170, 26);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "Delete Selected Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(6, 250);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(170, 26);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Add New Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // lstAccounts
            // 
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.Location = new System.Drawing.Point(6, 19);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(170, 225);
            this.lstAccounts.TabIndex = 0;
            this.lstAccounts.SelectedIndexChanged += new System.EventHandler(this.lstAccounts_SelectedIndexChanged);
            // 
            // groupBoxTransactions
            // 
            this.groupBoxTransactions.Controls.Add(this.btnRefreshAll);
            this.groupBoxTransactions.Controls.Add(this.btnExit);
            this.groupBoxTransactions.Controls.Add(this.txtSelectedAccountName);
            this.groupBoxTransactions.Controls.Add(this.label4);
            this.groupBoxTransactions.Controls.Add(this.btnExport);
            this.groupBoxTransactions.Controls.Add(this.btnImport);
            this.groupBoxTransactions.Controls.Add(this.lstViewTransactions);
            this.groupBoxTransactions.Location = new System.Drawing.Point(458, 12);
            this.groupBoxTransactions.Name = "groupBoxTransactions";
            this.groupBoxTransactions.Size = new System.Drawing.Size(652, 630);
            this.groupBoxTransactions.TabIndex = 1;
            this.groupBoxTransactions.TabStop = false;
            this.groupBoxTransactions.Text = "Transactions";
            // 
            // btnRefreshAll
            // 
            this.btnRefreshAll.Location = new System.Drawing.Point(305, 598);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.Size = new System.Drawing.Size(75, 26);
            this.btnRefreshAll.TabIndex = 6;
            this.btnRefreshAll.Text = "Refresh All";
            this.btnRefreshAll.UseVisualStyleBackColor = true;
            this.btnRefreshAll.Click += new System.EventHandler(this.btnRefreshAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(571, 598);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSelectedAccountName
            // 
            this.txtSelectedAccountName.Location = new System.Drawing.Point(108, 16);
            this.txtSelectedAccountName.Name = "txtSelectedAccountName";
            this.txtSelectedAccountName.ReadOnly = true;
            this.txtSelectedAccountName.Size = new System.Drawing.Size(191, 20);
            this.txtSelectedAccountName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selected Account:";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(151, 598);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(148, 26);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export Transaction Data";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(6, 598);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(139, 26);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import Transaction Data";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lstViewTransactions
            // 
            this.lstViewTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Date,
            this.Amount,
            this.Payee,
            this.Category,
            this.Notes});
            this.lstViewTransactions.FullRowSelect = true;
            this.lstViewTransactions.GridLines = true;
            this.lstViewTransactions.HideSelection = false;
            this.lstViewTransactions.Location = new System.Drawing.Point(6, 43);
            this.lstViewTransactions.Name = "lstViewTransactions";
            this.lstViewTransactions.Size = new System.Drawing.Size(640, 501);
            this.lstViewTransactions.TabIndex = 0;
            this.lstViewTransactions.UseCompatibleStateImageBehavior = false;
            this.lstViewTransactions.View = System.Windows.Forms.View.Details;
            this.lstViewTransactions.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 90;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 80;
            // 
            // Payee
            // 
            this.Payee.Text = "Payee";
            this.Payee.Width = 120;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 95;
            // 
            // Notes
            // 
            this.Notes.Text = "Notes";
            this.Notes.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteTransaction);
            this.groupBox1.Controls.Add(this.btnEditTransaction);
            this.groupBox1.Controls.Add(this.btnAddTransaction);
            this.groupBox1.Controls.Add(this.btnClearSelection);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboCategory);
            this.groupBox1.Controls.Add(this.cboPayee);
            this.groupBox1.Controls.Add(this.txtTransactionAccount);
            this.groupBox1.Controls.Add(this.txtTransactionAmount);
            this.groupBox1.Controls.Add(this.dateTimeTransaction);
            this.groupBox1.Controls.Add(this.txtTransactionID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 276);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Management";
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Location = new System.Drawing.Point(301, 91);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(120, 26);
            this.btnDeleteTransaction.TabIndex = 17;
            this.btnDeleteTransaction.Text = "Delete Transaction";
            this.btnDeleteTransaction.UseVisualStyleBackColor = true;
            this.btnDeleteTransaction.Click += new System.EventHandler(this.btnDeleteTransaction_Click);
            // 
            // btnEditTransaction
            // 
            this.btnEditTransaction.Location = new System.Drawing.Point(301, 57);
            this.btnEditTransaction.Name = "btnEditTransaction";
            this.btnEditTransaction.Size = new System.Drawing.Size(120, 26);
            this.btnEditTransaction.TabIndex = 16;
            this.btnEditTransaction.Text = "Edit Transaction";
            this.btnEditTransaction.UseVisualStyleBackColor = true;
            this.btnEditTransaction.Click += new System.EventHandler(this.btnEditTransaction_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(301, 25);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(120, 26);
            this.btnAddTransaction.TabIndex = 15;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Location = new System.Drawing.Point(324, 151);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(97, 26);
            this.btnClearSelection.TabIndex = 14;
            this.btnClearSelection.Text = "Cancel Selection";
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(16, 193);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(405, 69);
            this.txtNotes.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Notes:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(65, 101);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 21);
            this.cboCategory.TabIndex = 11;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // cboPayee
            // 
            this.cboPayee.FormattingEnabled = true;
            this.cboPayee.Location = new System.Drawing.Point(65, 76);
            this.cboPayee.Name = "cboPayee";
            this.cboPayee.Size = new System.Drawing.Size(121, 21);
            this.cboPayee.TabIndex = 10;
            this.cboPayee.SelectedIndexChanged += new System.EventHandler(this.cboPayee_SelectedIndexChanged);
            // 
            // txtTransactionAccount
            // 
            this.txtTransactionAccount.Location = new System.Drawing.Point(65, 128);
            this.txtTransactionAccount.Name = "txtTransactionAccount";
            this.txtTransactionAccount.ReadOnly = true;
            this.txtTransactionAccount.Size = new System.Drawing.Size(121, 20);
            this.txtTransactionAccount.TabIndex = 9;
            // 
            // txtTransactionAmount
            // 
            this.txtTransactionAmount.Location = new System.Drawing.Point(65, 51);
            this.txtTransactionAmount.Name = "txtTransactionAmount";
            this.txtTransactionAmount.Size = new System.Drawing.Size(121, 20);
            this.txtTransactionAmount.TabIndex = 8;
            // 
            // dateTimeTransaction
            // 
            this.dateTimeTransaction.Location = new System.Drawing.Point(65, 154);
            this.dateTimeTransaction.Name = "dateTimeTransaction";
            this.dateTimeTransaction.Size = new System.Drawing.Size(184, 20);
            this.dateTimeTransaction.TabIndex = 7;
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.Location = new System.Drawing.Point(65, 25);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.ReadOnly = true;
            this.txtTransactionID.Size = new System.Drawing.Size(121, 20);
            this.txtTransactionID.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Account:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Category:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Payee:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Amount:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SimpleFinances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 654);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTransactions);
            this.Controls.Add(this.groupBoxAccounts);
            this.Name = "SimpleFinances";
            this.Text = "Simple Finances";
            this.Load += new System.EventHandler(this.SimpleFinances_Load);
            this.groupBoxAccounts.ResumeLayout(false);
            this.groupBoxAccounts.PerformLayout();
            this.groupBoxTransactions.ResumeLayout(false);
            this.groupBoxTransactions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAccounts;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.TextBox txtAccountBalance;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.ListBox lstAccounts;
        private System.Windows.Forms.GroupBox groupBoxTransactions;
        private System.Windows.Forms.ListView lstViewTransactions;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Payee;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Notes;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSelectedAccountName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteTransaction;
        private System.Windows.Forms.Button btnEditTransaction;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboPayee;
        private System.Windows.Forms.TextBox txtTransactionAccount;
        private System.Windows.Forms.TextBox txtTransactionAmount;
        private System.Windows.Forms.DateTimePicker dateTimeTransaction;
        private System.Windows.Forms.TextBox txtTransactionID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnManagePayees;
        private System.Windows.Forms.Button btnManageCategories;
        private System.Windows.Forms.Button btnRefreshAll;
    }
}

