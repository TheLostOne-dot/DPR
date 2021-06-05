using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPR_solo
{
    class SportPublisherFactoryInvoker : IAbstractFactory
    {
        public string Name { get ; set ; }
        public SportPublisherFactoryInvoker(string name) 
        {
            this.Name = name;
        }

        public IMagazine CreateMagazine()
        {
            return new SportMagazine();
        }

        public INewspaper CreateNewspaper()
        {
            return new SportNewspaper();
        }

        public void ChangeDistributionStatus(ICommand command)
        {
            command.Execute(this);
        }
    }
}
