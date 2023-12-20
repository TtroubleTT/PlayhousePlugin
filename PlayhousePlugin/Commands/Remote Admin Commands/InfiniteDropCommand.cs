using System;
using CommandSystem;
using Exiled.API.Features;
using RemoteAdmin;

namespace PlayhousePlugin.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class InfiniteDropCommand : ICommand
    {
        public string Command { get; } = "infinitedrop";
        public string[] Aliases { get; } = {"idrop"};
        public string Description { get; } = "Gives you the item you just dropped or threw";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            var p = Player.Get(((PlayerCommandSender)sender).ReferenceHub);
            var DamageHandler = PlayhousePlugin.PlayhousePluginRef.DamageHandler;

            if (DamageHandler.PlayersWithInfiniteDrop.Contains(p))
            {
                DamageHandler.PlayersWithInfiniteDrop.Remove(p);
                response = "Removed from list";
                return true;
            }
            else
            {
                DamageHandler.PlayersWithInfiniteDrop.Add(p);
                response = "Added to list";
                return true;
            }
        }
    }
}