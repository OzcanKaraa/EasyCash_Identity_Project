using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash_Identity_Project.EntityLayer.Concrete
{
    public Class AccountProcess
    {

            public int CustomerAccountProcessID { get; set; }
             public string ProcessType { get; set; } // Islem türü
             public decimal AMount { get; set; } // Miktar
            public DateTime ProcessDate { get; set; } //Islem Tarihi 
            //Gonderici ve Alici 


}
}
