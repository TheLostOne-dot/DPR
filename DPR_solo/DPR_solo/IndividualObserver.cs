using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPR_solo
{
    class IndividualObserver : IObserver
    {
        Distributor distributor;
        public IndividualObserver(Distributor d,string firstName, string lastName,string address) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            distributor = d;
            d.Attach(this);
        }

        public string FirstName { get; set; }
        public string LastName { get ; set; }
        public string Address { get ; set ; }

        public void Update()
        {
           distributor.GetState();
        }
    }
}
