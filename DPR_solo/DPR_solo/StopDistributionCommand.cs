using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPR_solo
{
    class StopDistributionCommand : ICommand
    {
        public ConcreteDistributorReceiver Receiver { get; set; }
        public StopDistributionCommand(ConcreteDistributorReceiver receiver) 
        {
            this.Receiver = receiver;
        }

        public void Execute(IAbstractFactory invoker)
        {
            Receiver.TerminateContract(invoker);
        }
    }
}
