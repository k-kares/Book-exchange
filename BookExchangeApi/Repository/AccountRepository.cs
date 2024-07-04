using BookExchangeApi.Data;
using BookExchangeApi.Interfaces;
using BookExchangeApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace BookExchangeApi.Repository
{
    public class AccountRepository : IAccount
    {
        private readonly DataContext context;

        public AccountRepository(DataContext context)
        {
            this.context = context;
        }
        public ICollection<Account> GetAccounts()
        {
            
            return context.Account.OrderBy(a => a.IDAccount).ToList();
        }
    }
}
