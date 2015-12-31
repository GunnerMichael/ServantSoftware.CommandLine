using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServantSoftware.CommandLine.Interfaces
{
    public interface ICommand
    {
        string Command { get; set; }

        IList<string> Options { get; }

        string CurrentDirectory { get; }

        void Execute();
    }
}
