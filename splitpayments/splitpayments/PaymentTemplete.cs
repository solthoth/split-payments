﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace splitpayments
{
    public class PaymentTemplete
    {
        public string Id { get; set; }

        public List<Payee> Splits { get; set; }

    }
}
