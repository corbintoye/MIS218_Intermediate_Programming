using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLib
{
    public class NewTransaction
    {
        public int TransactionID { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int CategoryID { get; set; }
        public int PayeeID { get; set; }
        public string Note { get; set; }
        public int AccountID { get; set; }
    }
}
