using ServantSoftware.CommandLine;
using ServantSoftware.CommandLine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineTests
{
    class TestAddCommand : CommandBase
    {
        public TestAddCommand(string command) : base(command)
        {
            this.Command = command;
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
