namespace ThereforeAddUsers.Models
{
    public class User
    {
        public string? Description { get; set; }
        public string? DisplayName { get; set; }
        public string? DomainName { get; set; }
        public string? InFolder { get; set; }
        public string? SMTP { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public UserTypeEnum? UserType { get; set; }
        public bool Disabled { get; set; }
        public string? GUID { get; set; }
        public bool OneTimePwd { get; set; }
    }
}
