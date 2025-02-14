namespace ThereforeAddUsers.Models
{
    public enum UserTypeEnum { SingleUser = 1, UserGroup = 2, SystemUser = 3 };
    public class CreateUserRequest
    {
        public string? Password { get; set; }
        public User? User { get; set; }
    }
}
