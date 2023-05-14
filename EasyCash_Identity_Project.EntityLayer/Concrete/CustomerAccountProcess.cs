﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash_Identity_Project.EntityLayer.Concrete
{
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessID { get; set; }  // Müşteri Hesabı ID
        public string ProcessType { get; set; } // Islem türü
        public decimal AMount { get; set; } // Miktar
        public DateTime ProcessDate { get; set; } // Islem Tarihi 
           
        //Id-IslemTürü-(Gelen Giden)-Miktar-Tarih-Gonderici - Alici 
    }
}
