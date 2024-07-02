namespace BookExchangeApi.Model
{
    public class GroupType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}
