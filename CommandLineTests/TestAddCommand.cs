using ServantSoftware.CommandLine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineTests
{
    class TestAddCommand : ICommand
    {
        public TestAddCommand(string command)
        {
            this.Command = command;
        }

        private IList<string> options = new List<string>();

        public string Command { get; set; }

        public string CurrentDirectory
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IList<string> Options
        {
            get
            {
                return this.options;
            }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
