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

namespace SimpleFinances
{
    public partial class PayeeManagement : Form
    {
        private DBManager dbmanager = new DBManager();
        private List<Categories> categories = null;
        private List<Payees> payees = null;
        private int selectedCategoryID = 0;
        

        public PayeeManagement()
        {
            InitializeComponent();
        }




        private void cboDefaultCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCategory = cboDefaultCategory.SelectedIndex;

            
            Categories category = categories[selectedCategory];

            selectedCategoryID = category.CategoryID;
            

            
        }

        private void PayeeManagement_Load(object sender, EventArgs e)
        {
            cboDefaultCategory.Items.Clear();
            categories = dbmanager.GetCategories();
            foreach (Categories category in categories)
            {
                cboDefaultCategory.Items.Add(category.CatName);
            }

            LoadPayeesList();
        }

        private void LoadPayeesList()
        {
            lstPayees.Items.Clear();
            payees = dbmanager.GetPayees();
            foreach (Payees payee in payees)
            {
                lstPayees.Items.Add(payee.PayeeName);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstPayees_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedPayee = lstPayees.SelectedIndex;

            if (selectedPayee == -1)
            {
                txtPayeeID.Clear();
                txtPayeeName.Clear();
                cboDefaultCategory.Text = "";


                return;
            }

            Payees payee = payees[selectedPayee];

            txtPayeeID.Text = payee.PayeeID.ToString();
            txtPayeeName.Text = payee.PayeeName;
             
            
        }

        private void btnAddPayee_Click(object sender, EventArgs e)
        {
            Payees payee = new Payees();
            payee.PayeeName = txtPayeeName.Text;
            payee.CategoryID = selectedCategoryID;

            DBManager manager = new DBManager();
            bool result = manager.CreatePayee(payee);

            if (result)
            {
                MessageBox.Show("Successfully added new payee");

                payees = manager.GetPayees();
                LoadPayeesList();
            }
        }

        private void btnEditPayee_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstPayees.SelectedIndex;
            

            if (selectedIndex == -1)
            {
                txtPayeeID.Clear();
                txtPayeeName.Clear();
                cboDefaultCategory.Text = "";

                return;
            }

            int selectedCategory = cboDefaultCategory.SelectedIndex;
            Categories category = categories[selectedCategory];
            selectedCategoryID = category.CategoryID;

            Payees payee = payees[selectedIndex];
            payee.PayeeID = int.Parse(txtPayeeID.Text);
            payee.CategoryID = selectedCategoryID;
            payee.PayeeName = txtPayeeName.Text;

            DBManager manager = new DBManager();
            bool result = manager.UpdatePayee(payee);

            if (result)
            {
                MessageBox.Show("Successfully updated payee");

                payees = manager.GetPayees();
                LoadPayeesList();
            }
        }

        private void btnDeletePayee_Click(object sender, EventArgs e)
        {
            int selectedPayee = lstPayees.SelectedIndex;

            if (selectedPayee == -1)
            {
                txtPayeeID.Clear();
                txtPayeeName.Clear();
                cboDefaultCategory.Text = "";

                return;
            }

            Payees payee = payees[selectedPayee];
            payee.PayeeID = int.Parse(txtPayeeID.Text);

            DBManager manager = new DBManager();
            bool result = manager.DeletePayee(payee);

            if (result)
            {
                MessageBox.Show("Successfully deleted payee");
                payees = dbmanager.GetPayees();
                LoadPayeesList();
                txtPayeeName.Clear();
                txtPayeeID.Clear();
            }
        }

        
    }
}
