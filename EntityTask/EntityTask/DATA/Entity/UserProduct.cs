namespace EntityTask.DATA.Entity
{
    public class UserProduct
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
    }
}
