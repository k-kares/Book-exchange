namespace BookExchangeApi.Model
{
    public class Account
    {
        public int IDAccount { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
