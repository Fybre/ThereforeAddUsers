namespace ThereforeAddUsers.Models
{
    public class UpdateUserGroupAssignmentRequest
    {
        public UpdateUserGroupUser User { get; set; }
        public List<Assignment> Assignments { get; set; }
    }
    public class Assignment
    {
        public ThereforeGroup ThereforeGroup { get; set; }
        public bool Remove { get; set; }
    }
    public class ThereforeGroup
    {
        public long? Id { get; set; }
        public string? Name { get; set; }
    }
    public class UpdateUserGroupUser
    {
        public long? Id { get; set; }
        public string? Name { get; set; }
        public string? DomainName { get; set; }
    }
}
