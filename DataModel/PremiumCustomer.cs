﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.DataModel
{
    public sealed class PremiumCustomer : Customer
    {
        public PremiumCustomer() { }
        public PremiumCustomer(int id, string name) : base(id, name) { }
    }
}
