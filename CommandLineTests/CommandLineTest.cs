using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServantSoftware.CommandLine;
using ServantSoftware.CommandLine.Interfaces;
using System.Collections.Generic;

namespace CommandLineTests
{
    [TestClass]
    public class CommandLineTest
    {
        [TestMethod]
        public void TestOneArg()
        {
            string[] args = new string[] { "-add" , @"c:\test.txt" };

            ICommand command = new TestAddCommand("add");


            CommandParser p = new CommandParser(new List<ICommand>() { command });

            var activeCommands = p.Parse(args);

            Assert.IsNotNull(activeCommands[0]);

            Assert.AreEqual("add", activeCommands[0].Command);
            Assert.AreEqual(args[1], activeCommands[0].Options[0]);

        }

        [TestMethod]
        public void TestTwoArgs()
        {
            string[] args = new string[] { "-add", @"c:\test.txt", "myname.txt" };

            ICommand command = new TestAddCommand("add");


            CommandParser p = new CommandParser(new List<ICommand>() { command });

            var activeCommands = p.Parse(args);

            Assert.IsNotNull(activeCommands[0]);

            Assert.AreEqual("add", activeCommands[0].Command);
            Assert.AreEqual(args[1], activeCommands[0].Options[0]);
            Assert.AreEqual(args[2], activeCommands[0].Options[1]);
        }

        [TestMethod]
        public void TestTwoCommands()
        {
            string[] args = new string[] { "-add", @"c:\test.txt", "myname.txt", "-move", "zzzz" };

            ICommand command = new TestAddCommand("add");
            ICommand command2 = new TestAddCommand("move");



            CommandParser p = new CommandParser(new List<ICommand>() { command, command2 });

            var activeCommands = p.Parse(args);

            Assert.IsNotNull(activeCommands[1]);

            Assert.AreEqual("add", activeCommands[0].Command);
            Assert.AreEqual(args[1], activeCommands[0].Options[0]);
            Assert.AreEqual(args[2], activeCommands[0].Options[1]);

            Assert.AreEqual("move", activeCommands[1].Command);
            Assert.AreEqual(args[4], activeCommands[1].Options[0]);

        }


    }
}
