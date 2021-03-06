﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_2_BdAvancees
{
    public class Customer
    {
        public double AccountBalance { get; set; }

        public String AddressLine1 { get; set; }

        public String AddressLine2 { get; set; }

        public String City { get; set; }

        public String Country { get; set; }

        public String EMail { get; set; }

        public long Id { get; set; }

        public String Name { get; set; }

        public String PostCode { get; set; }

        public String Remark { get; set; }

        // integration de l'optimistic 
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
