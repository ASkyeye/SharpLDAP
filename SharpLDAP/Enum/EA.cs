using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SharpLDAP.Enum
{
    public class EA
    {
        public static void Users1(string[] args)
        {

            var context = new PrincipalContext(ContextType.Domain, args[0]);
            using (var searcher = new PrincipalSearcher())
            {
                var groupName = "Enterprise Admins";
                var sp = new GroupPrincipal(context, groupName);
                searcher.QueryFilter = sp;
                var group = searcher.FindOne() as GroupPrincipal;

                if (group == null)
                    Console.WriteLine("Invalid Group Name: {0}", groupName);

                foreach (var f in group.GetMembers())
                {
                    var principal = f as UserPrincipal;

                    if (principal == null || string.IsNullOrEmpty(principal.Name))
                        continue;

                    Console.WriteLine("{0}", principal.Name);
                }
            }
        }
    }
}

