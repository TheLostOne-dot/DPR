using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPR_solo
{
    abstract class Distributor
    {
        public string State { get; set; }
        public string Name { get; set; }
        public Distributor(string Name) { }
        protected virtual void Notify() { }
        public virtual void Attach(IObserver o) { }
        public virtual void Detach(IObserver o) { }
        public virtual IObserver GetSubscriber(string postcode) 
        {
            return null;
        }
        public abstract string GetState();
    }
}
