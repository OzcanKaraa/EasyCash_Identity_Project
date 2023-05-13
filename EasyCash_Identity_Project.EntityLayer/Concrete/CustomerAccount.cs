using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash_Identity_Project.EntityLayer.Concrete
{
		public Class CustomerAccount
	{
		 public int CustomerAccountID { get; set; }

		 public string  CustomerAccountNumber { get; set; }

		 public string CustomerAccountCurrency { get; set; } /*Müşteri Para türü*/

		public string CustomerAccountBalance { get; set; } /*Müşteri oplam Bakiye*/
}
}
