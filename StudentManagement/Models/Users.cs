namespace StudentManagement.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserLogin { get; set; } = string.Empty;

        public string UserPassword { get; set; } = string.Empty;
    }
}
