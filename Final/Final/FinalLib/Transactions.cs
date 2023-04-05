using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLib
{
    public class Transactions
    {
        public int TransactionID { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string CatName { get; set; }
        public string PayeeName { get; set; }
        public string AcctName { get; set; }
        public string Note { get; set; }
        public int AccountID { get; set; }
    }
}
