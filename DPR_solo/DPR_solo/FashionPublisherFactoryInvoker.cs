using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPR_solo
{
    class FashionPublisherFactoryInvoker : IAbstractFactory
    {
        public string Name { get ; set ; }
        public FashionPublisherFactoryInvoker(string name) 
        {
            this.Name = name;
        }

        public IMagazine CreateMagazine()
        {
           return new FashionMagazine();
        }

        public INewspaper CreateNewspaper()
        {
            return new FashionNewspaper();
        }

        public void ChangeDistributionStatus(ICommand command)
        {
            command.Execute(this);
        }
    }
}
