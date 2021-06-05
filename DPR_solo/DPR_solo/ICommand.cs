using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPR_solo
{
    interface ICommand
    {
        void Execute(IAbstractFactory invoker);
    }
}
