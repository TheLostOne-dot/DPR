using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPR_solo
{
    class OrganizationObserver : IObserver
    {
        Distributor distributor;
        public OrganizationObserver(Distributor d,string organizationName,string address)
        {
            this.Address = address;
            this.OrganizationName = organizationName;
            distributor = d;
            d.Attach(this);
        }

        public string OrganizationName { get; set; }
        public string Address { get; set; }
        public void Update()
        {
            distributor.GetState();
        }
    }
}
