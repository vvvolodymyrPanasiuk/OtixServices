﻿using Money.Domain.Entities.AccountAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.Domain.Repositories
{
    public interface IAccountRepository<T> where T : BaseAccount
    {
        //IEnumerable<T> GetAllAccounts<T>();
        T GetAccountById(int accountId);
        IEnumerable<T> GetAccountsByUserId(string userId);
        void CreateAccount(T account);
        void UpdateAccount(T account);
        void RemoveAccount(T account);
    }
}
