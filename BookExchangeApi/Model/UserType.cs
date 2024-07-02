namespace BookExchangeApi.Model
{
    public class UserType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
