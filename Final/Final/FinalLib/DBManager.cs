using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;

namespace FinalLib
{
    public class DBManager
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["final"].ConnectionString;
        }

        //ACCOUNTS: Selects account info from DB
        public List<Accounts> GetAccounts()
        {
            List<Accounts> accounts = null;

            string sql = @"SELECT Accounts.AccountID, AcctName, CAST(SUM(Amount) AS DECIMAL(10,2)) AS AcctBalance 
                            FROM Accounts
                            JOIN Transactions ON Accounts.AccountID = Transactions.AccountID
                            GROUP BY Accounts.AccountID, AcctName";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                accounts = new List<Accounts>();
                while (reader.Read())
                {
                    Accounts account = new Accounts();
                    Type type = typeof(Accounts);

                    foreach (PropertyInfo info in type.GetProperties())
                    {
                        info.SetValue(account, reader[info.Name]);
                    }

                    accounts.Add(account);
                }
            }
            return accounts;
        }

        //ACCOUNTS: Adds new account to DB
        public bool CreateAccount(Accounts newaccount)
        {
            bool result = false;

            string sql = @"INSERT INTO Accounts (AcctName) VALUES (@AcctName);
                            INSERT INTO Transactions (Date, Amount, CategoryID, PayeeID, AccountID, Note) VALUES (GETDATE(), 0, 3, 4, (SELECT MAX(AccountID) FROM Accounts), 'Account created')";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@AcctName", newaccount.AcctName);
                

                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 2)
                {
                    result = true;
                }
                return result;
            }
        }

        //ACCOUNTS: Updates account name
        public bool UpdateAccount(Accounts account)
        {
            bool result = false;

            string sql = "UPDATE Accounts SET AcctName = @AcctName WHERE AccountID = @AccountID";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@AcctName", account.AcctName);
                cmd.Parameters.AddWithValue("@AccountID", account.AccountID);
                

                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
            }

            return result;
        }

        //ACCOUNTS: Deletes account from DB
        public bool DeleteAccount(Accounts account)
        {
            bool result = false;

            string sql = @"DELETE FROM Transactions WHERE AccountID = @AccountID;
                            DELETE FROM Accounts WHERE AccountID = @AccountID";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@AccountID", account.AccountID);
                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows > 1)
                {
                    result = true;
                }
                return result;
            }
        }


        //TRANSACTIONS: Selects transaction details from DB

        public List<Transactions> GetTransactions(string AccountID)
        {
            List<Transactions> transactions = null;

            string sql = @"SELECT TransactionID, Date, CAST(Amount AS DECIMAL(10,2)) AS Amount, CatName, PayeeName, AcctName, Note
                            FROM Transactions
                            JOIN Categories ON Transactions.CategoryID = Categories.CategoryID
                            JOIN Payees ON Transactions.PayeeID = Payees.PayeeID
                            JOIN Accounts ON Transactions.AccountID = Accounts.AccountID
                            WHERE Transactions.AccountID = @AccountID";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@AccountID", int.Parse(AccountID));
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                transactions = new List<Transactions>();
                while (reader.Read())
                {
                    Transactions transaction = new Transactions();

                    transaction.TransactionID = (int)reader["TransactionID"];
                    transaction.Date = (DateTime)reader["Date"];
                    transaction.Amount = (decimal)reader["Amount"];
                    transaction.CatName = (string)reader["CatName"];
                    transaction.PayeeName = (string)reader["PayeeName"];
                    transaction.AcctName = (string)reader["AcctName"];
                    transaction.Note = (string)reader["Note"];

                    transactions.Add(transaction);
                }
            }
            return transactions;
        }

        //TRANSACTIONS: Adds new transaction to DB
        public bool CreateTransaction(NewTransaction newtransaction)
        {
            bool result = false;

            string sql = "INSERT INTO Transactions (Date, Amount, CategoryID, PayeeID, AccountID, Note) VALUES (@Date, @Amount, @CategoryID, @PayeeID, @AccountID, @Note)";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@Date", newtransaction.Date);
                cmd.Parameters.AddWithValue("@Amount", newtransaction.Amount);
                cmd.Parameters.AddWithValue("@CategoryID", newtransaction.CategoryID);
                cmd.Parameters.AddWithValue("@PayeeID", newtransaction.PayeeID);
                cmd.Parameters.AddWithValue("@AccountID", newtransaction.AccountID);
                cmd.Parameters.AddWithValue("@Note", newtransaction.Note);

                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
                return result;
            }
        }

        //TRANSACTIONS: Deletes a transaction from db
        public bool DeleteTransaction(int transaction)
        {
            bool result = false;

            string sql = @"DELETE FROM Transactions WHERE TransactionID = @TransactionID";
                            

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@TransactionID", transaction);
                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
                return result;
            }
        }

        //TRANSACTIONS: Updates an existing transaction 
        public bool UpdateTransaction(NewTransaction transaction)
        {
            bool result = false;

            string sql = "UPDATE Transactions SET Date = @Date, Amount = @Amount, CategoryID = @CategoryID, PayeeID = @PayeeID, Note = @Note WHERE TransactionID = @TransactionID ";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@Date", transaction.Date);
                cmd.Parameters.AddWithValue("@Amount", transaction.Amount);
                cmd.Parameters.AddWithValue("@CategoryID", transaction.CategoryID);
                cmd.Parameters.AddWithValue("@PayeeID", transaction.PayeeID);
                cmd.Parameters.AddWithValue("@Note", transaction.Note);
                cmd.Parameters.AddWithValue("@TransactionID", transaction.TransactionID);

                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
            }

            return result;
        }








        //CATEGORIES: Selects all categories from db
        public List<Categories> GetCategories()
        {
            List<Categories> categories = null;

            string sql = "SELECT CategoryID, CatName FROM Categories";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                categories = new List<Categories>();
                while (reader.Read())
                {
                    Categories category = new Categories();
                    Type type = typeof(Categories);

                    foreach (PropertyInfo info in type.GetProperties())
                    {
                        info.SetValue(category, reader[info.Name]);
                    }

                    categories.Add(category);
                }
            }
            return categories;
        }

        //CATEGORIES: Adds new category to db
        public bool CreateCategory(Categories newcategory)
        {
            bool result = false;

            string sql = @"INSERT INTO Categories (CatName) VALUES (@CatName)";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@CatName", newcategory.CatName);


                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
                return result;
            }
        }

        //CATEGORIES: Updates an existing category
        public bool UpdateCategory(Categories category)
        {
            bool result = false;

            string sql = "UPDATE Categories SET CatName = @CatName WHERE CategoryID = @CategoryID";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@CatName", category.CatName);
                cmd.Parameters.AddWithValue("@CategoryID", category.CategoryID);


                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
            }

            return result;
        }

        //CATEGORIES: Deletes a category
        public bool DeleteCategory(Categories category)
        {
            bool result = false;

            string sql = @"DELETE FROM Categories WHERE CategoryID = @CategoryID";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@CategoryID", category.CategoryID);
                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
                return result;
            }
        }

        //PAYEES: Selects all payees from db
        public List<Payees> GetPayees()
        {
            List<Payees> payees = null;

            string sql = "SELECT PayeeID, PayeeName, CategoryID FROM Payees";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                payees = new List<Payees>();
                while (reader.Read())
                {
                    Payees payee = new Payees();
                    Type type = typeof(Payees);

                    foreach (PropertyInfo info in type.GetProperties())
                    {
                        info.SetValue(payee, reader[info.Name]);
                    }

                    payees.Add(payee);
                }
            }
            return payees;
        }

        //PAYEES: Adds a payee
        public bool CreatePayee(Payees newpayee)
        {
            bool result = false;

            string sql = @"INSERT INTO Payees (PayeeName, CategoryID) VALUES (@PayeeName, @CategoryID)";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@PayeeName", newpayee.PayeeName);
                cmd.Parameters.AddWithValue("@CategoryID", newpayee.CategoryID);

                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }

                return result;
            }
        }

        //PAYEES: Updates a payee
        public bool UpdatePayee(Payees payee)
        {
            bool result = false;

            string sql = "UPDATE Payees SET PayeeName = @PayeeName, CategoryID = @CategoryID WHERE PayeeID = @PayeeID";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@PayeeName", payee.PayeeName);
                cmd.Parameters.AddWithValue("@CategoryID", payee.CategoryID);
                cmd.Parameters.AddWithValue("@PayeeID", payee.PayeeID);

                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
            }

            return result;
        }

        //PAYEES: Deletes a payee
        public bool DeletePayee(Payees payee)
        {
            bool result = false;

            string sql = @"DELETE FROM Payees WHERE PayeeID = @PayeeID";

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@PayeeID", payee.PayeeID);
                sqlConnection.Open();

                int numRows = cmd.ExecuteNonQuery();

                if (numRows == 1)
                {
                    result = true;
                }
                return result;
            }
        }

        







    }
}
