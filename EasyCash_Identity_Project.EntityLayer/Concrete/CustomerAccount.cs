using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash_Identity_Project.EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; } // Müşteri Hesabı ID

        public string CustomerAccountNumber { get; set; } // Müşteri Hesap Numarası

        public string CustomerAccountCurrency { get; set; } // Müşteri Para türü

        public string CustomerAccountBalance { get; set; } // Müşteri Toplam Bakiye

        public string CustomerAccountBankBranch { get; set; } // Banka Subesi
    }
}
