namespace ThereforeAddUsers.Models
{
    public class UserRecord
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string GroupList { get; set; } = string.Empty;

        public List<string> Groups
        {
            get
            {
                return GroupList.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            }
        }
    }
}
