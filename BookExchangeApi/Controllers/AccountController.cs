using BookExchangeApi.Interfaces;
using BookExchangeApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BookExchangeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController
    {
        private readonly IAccount accountRepository;

        public AccountController(IAccount accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Account>))]
        public IActionResult GetAccounts()
        {
            var account = accountRepository.GetAccounts();
            
            return new OkObjectResult(account);
        }
    }
}
