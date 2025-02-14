using System.Reflection.Metadata.Ecma335;

namespace ThereforeAddUsers.Models
{

    public enum ExecuteUsersQueryFlagsEnum { 
                                FindUsersInActiveDirector=1, 
                                FindUsersInTherefore =4,
                                FindAllusers =5,
                                FindUsersNotInTherefore = 32,
                                FindGroupsInActiveDirectory = 64,
                                FindGroupsInTherefore = 256,
                                FindAllGroups = 320,
                                FindAllUsersAndGroups = 325,
                                FindGroupsNotInTherefore = 1024,
                                FindSMTPUsersOnly = 4096
    }
    public class ExecuteUsersQueryRequest
    {
        public List<string> DomainNames { get; set; } = new List<string>();
        public ExecuteUsersQueryFlagsEnum Flags { get; set; }
        public string Query { get; set; } = string.Empty;

        public ExecuteUsersQueryRequest()
        {
            DomainNames.Add("<THEREFORE>");
        }
    }
}

