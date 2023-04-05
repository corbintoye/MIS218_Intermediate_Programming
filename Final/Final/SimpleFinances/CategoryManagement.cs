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
    public partial class CategoryManagement : Form
    {
        private DBManager dbmanager = new DBManager();
        private List<Categories> categories = null;

        public CategoryManagement()
        {
            InitializeComponent();
        }

        private void LoadCategoriesList()
        {
            lstCategories.Items.Clear();
            categories = dbmanager.GetCategories();
            foreach (Categories category in categories)
            {
                lstCategories.Items.Add(category.CatName);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            LoadCategoriesList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Categories category = new Categories();

            category.CatName = txtCategoryName.Text;

            DBManager manager = new DBManager();
            bool result = manager.CreateCategory(category);

            if (result)
            {
                MessageBox.Show("Successfully added new category");

                categories = dbmanager.GetCategories();
                LoadCategoriesList();
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstCategories.SelectedIndex;

            if (selectedIndex == -1)
            {
                txtCategoryID.Clear();
                txtCategoryName.Clear();
                

                return;
            }

            Categories category = categories[selectedIndex];
            category.CategoryID = int.Parse(txtCategoryID.Text);
            category.CatName = txtCategoryName.Text;
            

            DBManager manager = new DBManager();
            bool result = manager.UpdateCategory(category);

            if (result)
            {
                MessageBox.Show("Successfully updated category");

                categories = dbmanager.GetCategories();
                LoadCategoriesList();
            }
        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCategory = lstCategories.SelectedIndex;

            if (selectedCategory == -1)
            {
                txtCategoryID.Clear();
                txtCategoryName.Clear();


                return;
            }

            Categories category = categories[selectedCategory];

            txtCategoryID.Text = category.CategoryID.ToString();
            txtCategoryName.Text = category.CatName;

        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int selectedCategory = lstCategories.SelectedIndex;

            if (selectedCategory == -1)
            {
                txtCategoryID.Clear();
                txtCategoryName.Clear();


                return;
            }

            Categories category = categories[selectedCategory];
            category.CategoryID = int.Parse(txtCategoryID.Text);

            DBManager manager = new DBManager();
            bool result = manager.DeleteCategory(category);

            if (result)
            {
                MessageBox.Show("Successfully deleted category");
                categories = dbmanager.GetCategories();
                LoadCategoriesList();
                txtCategoryName.Clear();
                txtCategoryID.Clear();
                
            }
        }
    }
}
