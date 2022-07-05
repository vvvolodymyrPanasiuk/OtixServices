﻿using Money.Domain.Entities.AccountAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.Domain.Entities.TransactionAggregate
{
    /// <summary>
    /// Транзакція для накопичуального рахунку
    /// </summary>
    public class SavingAccountTransaction : BaseTransaction
    {
        public int SavingAccountId { get; set; }

        //public SavingAccount SavingAccount { get; set; }
    }
}
