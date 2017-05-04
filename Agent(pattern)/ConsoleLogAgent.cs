using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agent_pattern_
{
    class ConsoleLogAgent : AgentDecorator
    {
        public ConsoleLogAgent(AbstractAgent agent) : base(agent.fileName, agent)
        { }

        public override void ReadMessage()
        {
            agent.ReadMessage();
        }

        public override void ShowMessage()
        {
            agent.ShowMessage();
            LogMessage();
        }
    }
}
