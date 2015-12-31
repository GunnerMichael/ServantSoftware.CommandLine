using ServantSoftware.CommandLine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServantSoftware.CommandLine
{
    public abstract class CommandBase : ICommand
    {
        private string _command;

        private string _workingDirectory;

        private IList<string> _options = new List<string>();

        public CommandBase(string command)
        {
            this.Command = command;
        }

        public CommandBase(string command, string workingDirectory)
        {
            this._workingDirectory = workingDirectory;
            this.Command = command;
        }

        public string Command
        {
            get
            {
                return this._command;
            }

            set
            {
                this._command = value;
            }
        }

        public string CurrentDirectory
        {
            get
            {
                return this._workingDirectory;
            }
        }

        public IList<string> Options
        {
            get
            {
                return this._options;
            }
        }

        public virtual void Execute()
        {            
        }
    }
}
