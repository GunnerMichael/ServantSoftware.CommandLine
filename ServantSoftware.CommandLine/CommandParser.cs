using ServantSoftware.CommandLine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServantSoftware.CommandLine
{
    public class CommandParser
    {
        private IList<ICommand> _registeredCommands;

        public CommandParser(IList<ICommand> registeredCommands)
        {
            this._registeredCommands = registeredCommands;
        }

        public IList<ICommand> Parse(string[] args)
        {
            List<ICommand> commands = new List<ICommand>();

            IList<string> options = new List<string>();

            ICommand currentCommand = null;

            foreach (var item in args)
            {

                if (item.StartsWith("-"))
                {
                    currentCommand = FindCommand(item.Substring(1));
                    commands.Add(currentCommand);
                }
                else
                {
                    if (currentCommand != null)
                    {
                        currentCommand.Options.Add(item);
                    }
                }
              

            }

            return commands;
        }

        private ICommand FindCommand(string commandName)
        {
            foreach(var command in _registeredCommands)
            {
                if (command.Command == commandName)
                {
                    return command;
                }
            }

            return null;
        }
    }
}
