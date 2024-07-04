using BookExchangeApi.Model;

namespace BookExchangeApi.Interfaces
{
    public interface IAccount
    {
        ICollection<Account> GetAccounts();
    }
}
