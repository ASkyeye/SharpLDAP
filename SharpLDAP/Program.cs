using SharpLDAP.Enum;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLDAP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                Information.Banner();
            }
                if (args[0] == "help" || args[0] == "Help")
                {
                    Help.Help1();
                }
                if (args[1] == "Users")
                    {
                        Enum.Users.Users1(args);
                    }
               
                if (args[1] == "Ou")
                {
                    Enum.Ou.Users1(args);
                }

                if (args[1] == "DA")
                {
                    Enum.DA.Users1(args);
                }

                if (args[1] == "EA")
                {
                    Enum.EA.Users1(args);
                }
          
                if (args[1] == "Computers")
                {
                Enum.Computers.Computers1(args);
                }

                if (args[1] == "GroupMembers")
                {
                  Enum.GroupMembers.ListMembers(args);
                }

                if (args[1] == "DC")
                {
                    Enum.DC.DC1(args);
                }

                if (args[1] == "SERVICE")
                {
                Enum.SPN.SPN1(args);
                }

                if (args[1] == "CUSTOM")
                {
                   Enum.Custom.Custom1(args);
                }



        }

    }
    }
