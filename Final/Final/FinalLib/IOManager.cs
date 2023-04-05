using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalLib
{
    public class IOManager
    {
        public bool ExportTransactions(List<Transactions> transactions, string fileName)
        {
            bool result = true;

            try
            {
                using (StreamWriter file = File.CreateText(fileName))
                {
                    file.WriteLine("CustomerID\tName\tAddress\tCity\tState\tZipCode");
                    foreach (Transactions transaction in transactions)
                    {
                        file.Write(transaction.TransactionID + "\t");
                        file.Write(transaction.Date + "\t");
                        file.Write(transaction.Amount + "\t");
                        file.Write(transaction.CatName + "\t");
                        file.Write(transaction.PayeeName + "\t");
                        file.Write(transaction.AccountID + "\t");
                        file.Write(transaction.Note);
                        file.WriteLine();
                    }

                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public List<Transactions> ImportTransactions(string fileName)
        {
            List<Transactions> transactions = new List<Transactions>();
            using (StreamReader reader = File.OpenText(fileName))
            {
                transactions = new List<Transactions>();

                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] columns = line.Split('\t');

                    Transactions transaction = new Transactions();
                    transaction.TransactionID = int.Parse(columns[0]);
                    transaction.Date = DateTime.Parse(columns[1]);
                    transaction.Amount = decimal.Parse(columns[2]);
                    transaction.CatName = columns[3];
                    transaction.PayeeName = columns[4];
                    transaction.AccountID = int.Parse(columns[5]);
                    transaction.Note = columns[6];

                    transactions.Add(transaction);
                }
            }

            return transactions;

        }
    }
}
