namespace Photography.Data.Models
{
    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
