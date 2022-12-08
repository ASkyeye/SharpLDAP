using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SharpLDAP.Enum
{
    public class GroupMembers
    {

        public static void ListMembers(string[] args)
        {
            using (PrincipalContext ctx = new PrincipalContext(ContextType.Domain))
            {

                string groupname = args[2];
                // find a user
                using (var group = GroupPrincipal.FindByIdentity(ctx, args[2]))
                {
                    if (group == null)
                    {
                        Console.WriteLine("Group does not exist");
                    }
                    else
                    {
                        var users = group.GetMembers(true);
                        foreach (UserPrincipal user in users)
                        {
                            
                            Console.WriteLine(user.SamAccountName);
                        }
                    }
                }
            }
        }
    }
}