using System;
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo 
    {
        public MockCommanderRepo()
        {
        }

        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id=0, HowTo="HT0", Line="L0", Platform="P0" },
                new Command {Id=1, HowTo="HT1", Line="L1", Platform="P1" },
                new Command {Id=2, HowTo="HT2", Line="L2", Platform="P2" }
            };
            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command {Id=0, HowTo="HT0", Line="L0", Platform="P0" };
        }
    }
}
