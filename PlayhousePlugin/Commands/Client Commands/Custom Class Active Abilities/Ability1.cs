﻿using System;
using CommandSystem;
using Exiled.API.Features;
using RemoteAdmin;

namespace PlayhousePlugin.Commands
{
	[CommandHandler(typeof(ClientCommandHandler))]
	public class Ability1 : ICommand
	{
		public string Command { get; } = "ability1";
		public string[] Aliases { get; } = null;
		public string Description { get; } = "Activates Custom Class Ability 1 (Deprecated)";

		public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
		{
			if (!(sender is PlayerCommandSender))
			{
				response = "This command can only be ran by a player!";
				return true;
			}

			var p = Player.Get(((PlayerCommandSender)sender).ReferenceHub);
			var DamageHandler = PlayhousePlugin.PlayhousePluginRef.DamageHandler;

			response = "This command is no longer supported, please type .commands for the latest binds";
			return false;
		}
	}
}

