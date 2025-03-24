using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.BankTransaction
{
    [Table("TransactionCardLog", Schema = "Transaction")]
    public class TransactionCardLog
    {
        public TransactionCardLog()
        {
            TransactionCardLogGUID = Guid.NewGuid();
        }
        [Key]
        public int TransactionCardLogID { get; set; }
        public Guid TransactionCardLogGUID { get; set; }
        public int OrdersID { get; set; }
        public int CustomersID { get; set; }
        public int TransactionID { get; set; }

        public string PaymentID { get; set; }
        public string InvoiceId { get; set; }
        public string CustomerReference { get; set; }


        public string Status { get; set; }
        public int TransactionStatus { get; set; } // Enum TransactionEnum
        public int LastStatusUpdateFrom { get; set; } // Enum LastStatusUpdateFrom



        public DateTime DateAdded { get; set; }
        public string Message { get; set; }

        public virtual TransactionCard TransactionCard { get; set; }
    }
}
