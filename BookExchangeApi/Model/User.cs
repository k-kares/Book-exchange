namespace BookExchangeApi.Model
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string Email{ get; set; }
        public string Contact { get; set; }
        public UserType UserType { get; set; }
        public Account Account { get; set; }
        public ICollection<BookReview> BookReviews { get; set; } = new List<BookReview>();
        public ICollection<FavouriteBooks> FavouriteBooks { get; set; } = new List<FavouriteBooks>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>();
    }
}
