namespace BookExchangeApi.Model
{
    public class Group
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MaximumUsers { get; set; }
        public int GroupTypeId { get; set; }
        public GroupType GroupType { get; set; }
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>();

    }
}
