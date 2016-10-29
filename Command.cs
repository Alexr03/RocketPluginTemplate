using Rocket.API;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System.Collections.Generic;
using System.IO;

namespace LYHMEManager
{
    class CommandCheckAnti : IRocketCommand
    {
        public string Help
        {
            get { return ""; }
        }

        public string Name
        {
            get { return "name"; }
        }

        public string Syntax
        {
            get { return "syntax"; }
        }

        public List<string> Aliases
        {
            get { return new List<string>(); }
        }

        public AllowedCaller AllowedCaller
        {
            get { return AllowedCaller.Both; }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>() { "perm.ission" };
            }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            //Execute Command
        }
    }
}
