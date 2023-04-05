using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalLib;
using System.IO;

namespace SimpleFinances
{
    public partial class SimpleFinances : Form
    {
        private DBManager dbmanager = new DBManager();
        private IOManager iomanager = new IOManager();
        private List<Accounts> accounts = null;
        private List<Transactions> transactions = null;
        private List<Categories> categories = null;
        private List<Payees> payees = null;
        private string selacc = null;
        private int selaccint = 0;
        private int selectedCategoryID = 0;
        private string selectedCategoryName = "";
        private int selectedPayeeID = 0;
        private string selectedPayeeName = "";

        public SimpleFinances()
        {
            InitializeComponent();
        }

        //Loads transaction details into transaction management when transaction is selected from listview
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViewTransactions.SelectedItems.Count > 0)
            {
                LoadTransactionManagement();
            }
            
            
            
        }

        //Launch
        private void SimpleFinances_Load(object sender, EventArgs e)
        {
            LoadAccountsList();
            LoadCategoriesCombo();
            LoadPayeesCombo();
        }

        //Loads account names into selection list
        private void LoadAccountsList()
        {
            lstAccounts.Items.Clear();
            accounts = dbmanager.GetAccounts();
            foreach (Accounts account in accounts)
            {
                lstAccounts.Items.Add(account.AcctName);
            }
        }

        //Loads category names into transaction management combo box
        private void LoadCategoriesCombo()
        {
            cboCategory.Items.Clear();
            categories = dbmanager.GetCategories();
            foreach (Categories category in categories)
            {
                cboCategory.Items.Add(category.CatName);
            }
        }

        //Loads payee names into transaction management combo box
        private void LoadPayeesCombo()
        {
            cboPayee.Items.Clear();
            payees = dbmanager.GetPayees();
            foreach (Payees payee in payees)
            {
                cboPayee.Items.Add(payee.PayeeName);
            }
        }


        //Loads transactions into transaction list
        private void LoadTransactionsList()
        {
            transactions = dbmanager.GetTransactions(selacc);
        }

        //Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Manages selection of accounts
        private void lstAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedAccount = lstAccounts.SelectedIndex;

            if (selectedAccount == -1)
            {
                txtAccountID.Clear();
                txtAccountName.Clear();
                txtAccountBalance.Clear();

                return;
            }

            Accounts account = accounts[selectedAccount];

            txtAccountID.Text = account.AccountID.ToString();
            txtAccountName.Text = account.AcctName;
            txtAccountBalance.Text = account.AcctBalance.ToString();
            txtSelectedAccountName.Text = account.AcctName;
            txtTransactionAccount.Text = account.AccountID.ToString();

            //Passes account id to class variable
            selacc = account.AccountID.ToString();
            selaccint = account.AccountID;

            LoadTransactionsList();
            LoadTransactionListView();
        }

        //Loads transactions into listview
        //Used Microsoft docs to figure out the listview: https://learn.microsoft.com/en-us/windows/apps/design/controls/listview-and-gridview
        private void LoadTransactionListView()
        {
            lstViewTransactions.Items.Clear();
            Transactions trans = new Transactions();
            

            foreach (Transactions transaction in transactions)
            {
                ListViewItem item = new ListViewItem(transaction.TransactionID.ToString());
                
                item.SubItems.Add(transaction.Date.ToString());
                item.SubItems.Add(transaction.Amount.ToString());
                item.SubItems.Add(transaction.PayeeName.ToString());
                item.SubItems.Add(transaction.CatName.ToString());
                item.SubItems.Add(transaction.Note.ToString());
                lstViewTransactions.Items.Add(item);
            }
        }

        //Clears text boxes and reloads accounts list
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtAccountID.Clear();
            txtAccountName.Clear();
            txtAccountBalance.Clear();
            txtSelectedAccountName.Clear();
            lstViewTransactions.Items.Clear();
            LoadAccountsList();
        }

        //Adds new account to DB
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text == "")
            {
                MessageBox.Show("Please enter a name for the new account");
                return;
            }
            
                                  
            Accounts account = new Accounts();

            account.AcctName = txtAccountName.Text;

            DBManager manager = new DBManager();
            bool result = manager.CreateAccount(account);

            if (result)
            {
                MessageBox.Show("Successfully added new account");

                accounts = dbmanager.GetAccounts();
                LoadAccountsList();
            }
        }

        //Update account name
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstAccounts.SelectedIndex;

            if (selectedIndex == -1)
            {
                txtAccountName.Clear();
                txtAccountID.Clear();
                txtAccountBalance.Clear();

                return;
            }

            Accounts account = accounts[selectedIndex];
            account.AccountID = int.Parse(txtAccountID.Text);
            account.AcctName = txtAccountName.Text;
            account.AcctBalance = decimal.Parse(txtAccountBalance.Text);

            DBManager manager = new DBManager();
            bool result = manager.UpdateAccount(account);

            if (result)
            {
                MessageBox.Show("Successfully updated account");

                accounts = dbmanager.GetAccounts();
                LoadAccountsList();
            }

        }

        //Deletes account
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstAccounts.SelectedIndex;

            if (selectedIndex == -1)
            {
                txtAccountName.Clear();
                txtAccountID.Clear();
                txtAccountBalance.Clear();

                return;
            }

            Accounts account = accounts[selectedIndex];
            account.AccountID = int.Parse(txtAccountID.Text);

            DBManager manager = new DBManager();
            bool result = manager.DeleteAccount(account);

            if (result)
            {
                MessageBox.Show("Successfully deleted account");
                accounts = dbmanager.GetAccounts();
                LoadAccountsList();
                txtAccountName.Clear();
                txtAccountID.Clear();
                txtAccountBalance.Clear();
            }
        }

        //Loads selected transaction from listview into transaction management fields
        //Used MS docs and this video as a guide: https://www.youtube.com/watch?v=OAvMTu-LFgs
        private void LoadTransactionManagement()
        {
            ListViewItem selectedItem = lstViewTransactions.SelectedItems[0];

            string subID = selectedItem.SubItems[0].Text;
            string subDate = selectedItem.SubItems[1].Text;
            string subAmount = selectedItem.SubItems[2].Text;
            string subPayee = selectedItem.SubItems[3].Text;
            string subCatName = selectedItem.SubItems[4].Text;
            string subNote = selectedItem.SubItems[5].Text;

            txtTransactionID.Text = subID;
            txtTransactionAmount.Text = subAmount;
            cboCategory.Text = subCatName;
            cboPayee.Text = subPayee;
            txtNotes.Text = subNote;
            dateTimeTransaction.Value = DateTime.Parse(subDate);

            //txtTransactionAccount.Text = lstAccounts.SelectedIndex.ToString(); ;


        }

        //Clears transaction management fields
        private void ClearTransactionFields()
        {
            txtTransactionAccount.Clear();
            txtTransactionAmount.Clear();
            txtTransactionID.Clear();
            cboCategory.Text = "Select Category";
            cboPayee.Text = "Select Payee";
            dateTimeTransaction.Value = DateTime.Now;
            txtNotes.Clear();

        }

        //Cancel transaction selection button
        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            ClearTransactionFields();
        }

        //Opens payee management form
        private void btnManagePayees_Click(object sender, EventArgs e)
        {
            PayeeManagement payeemanagement = new PayeeManagement();
            payeemanagement.Show();
        }

        //Opens category management form
        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            CategoryManagement categorymanagement = new CategoryManagement();
            categorymanagement.Show();
        }

        //Transaction management add button
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {

            if (txtTransactionAccount.Text == "")
            {
                MessageBox.Show("Please select an account for the transaction to be applied to");
                return;
            }

            if (txtTransactionAmount.Text == "")
            {
                MessageBox.Show("Please enter the amount of the transaction");
                return;
            }

            if (cboCategory.Text == "Select Category" || cboCategory.Text == "")
            {
                MessageBox.Show("Please select a category");
                return;
            }

            if (cboPayee.Text == "Select Payee" || cboPayee.Text == "")
            {
                MessageBox.Show("Please select a payee");
                return;
            }

            NewTransaction newtransaction = new NewTransaction();


            newtransaction.Date = dateTimeTransaction.Value;
            newtransaction.Amount = decimal.Parse(txtTransactionAmount.Text);
            newtransaction.CategoryID = selectedCategoryID;
            newtransaction.PayeeID = selectedPayeeID;
            newtransaction.AccountID = selaccint;
            newtransaction.Note = txtNotes.Text;

            DBManager dbmanager = new DBManager();
            bool result = dbmanager.CreateTransaction(newtransaction);


            if (result)
            {
                MessageBox.Show("Successfully added transaction");
                
                LoadAccountsList();
                LoadTransactionsList();
                LoadTransactionListView();
                txtAccountBalance.Clear();
            }
            
        }
        //Transaction management payee combobox selection
        private void cboPayee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedPayee = cboPayee.SelectedIndex;
            Payees payee = payees[selectedPayee];
            selectedPayeeID = payee.PayeeID;
            selectedPayeeName = payee.PayeeName;
        }

        //Transaction management category combobox selection
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCategory = cboCategory.SelectedIndex;
            Categories category = categories[selectedCategory];
            selectedCategoryID = category.CategoryID;
            selectedCategoryName = category.CatName;
        }

        //Transaction management delete button
        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {           
            int selectedTransactionID = int.Parse(txtTransactionID.Text);
           
            DBManager manager = new DBManager();
            bool result = manager.DeleteTransaction(selectedTransactionID);

            if (result)
            {
                MessageBox.Show("Successfully deleted transaction");
                LoadAccountsList();
                txtAccountBalance.Clear();
                LoadTransactionsList();
                LoadTransactionListView();
                ClearTransactionFields();

            }
        }

        private void btnRefreshAll_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void RefreshAll()
        {
            LoadAccountsList();
            LoadCategoriesCombo();
            LoadPayeesCombo();
            ClearTransactionFields();
            lstViewTransactions.Items.Clear();
            txtAccountID.Clear();
            txtAccountName.Clear();
            txtAccountBalance.Clear();
            txtSelectedAccountName.Clear();
        }



        private void btnEditTransaction_Click(object sender, EventArgs e)
        {


            NewTransaction transaction = new NewTransaction();

            transaction.Date = dateTimeTransaction.Value;
            transaction.Amount = decimal.Parse(txtTransactionAmount.Text);
            transaction.CategoryID = selectedCategoryID;
            transaction.PayeeID = selectedPayeeID;
            transaction.Note = txtNotes.Text;
            transaction.TransactionID = int.Parse(txtTransactionID.Text);

            DBManager manager = new DBManager();
            bool result = manager.UpdateTransaction(transaction);

            if (result)
            {
                MessageBox.Show("Successfully updated transaction.");


                RefreshAll();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "Tab-separated values (*.tsv)|*.tsv|All files (*.*)|*.*";

            DialogResult result = saveDlg.ShowDialog();



            if (result == DialogResult.OK)
            {
                iomanager.ExportTransactions(transactions, saveDlg.FileName);

                MessageBox.Show("Transactions exported successfully");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Tab-separated values (*.tsv)|*.tsv|All files (*.*)|*.*";

            DialogResult result = openDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                RefreshAll();
                transactions = iomanager.ImportTransactions(openDlg.FileName);
                LoadTransactionListView();
                txtSelectedAccountName.Text = "Imported Data";
            }
        }
    }

}
/* TO DO
 * 
 * Nice to haves:
 * Delete confirmation
 */