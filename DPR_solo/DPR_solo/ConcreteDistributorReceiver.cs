using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPR_solo
{
    class ConcreteDistributorReceiver: Distributor
    {
        readonly List<IObserver> subscribers;
        readonly List<IAbstractFactory> publishers;
        public string PublisherState { get; private set; }

        public ConcreteDistributorReceiver(string Name)
            : base(Name) 
        {
            base.Name = Name;
            subscribers = new List<IObserver>();
            publishers = new List<IAbstractFactory>();
        }
        public override void Attach(IObserver o)
        {
            bool exists = false;
            foreach (var s in subscribers)
            {
                if (s.Address == o.Address)
                    exists = true;
            }
            if (!exists)
            {
                subscribers.Add(o);
            }
            else
                throw new Exception();
        }
        public override void Detach(IObserver o)
        {
            IObserver temp = null;
            foreach (var s in subscribers)
            {
                if (s.Address == o.Address)
                    temp = o;
            }
            if(temp!=null)
                subscribers.Remove(temp);
            else
                throw new Exception();
        }
        protected override void Notify()
        {
            foreach (var o in subscribers)
            {
                o.Update();
            }
        }
        public override string GetState() 
        {
            return PublisherState;
        }
        public override IObserver GetSubscriber(string postcode) 
        {
            IObserver temp=null;
            foreach (var o in subscribers)
            {
                if (o.Address == postcode)
                    temp = o;
                break;
            }
            return temp;
        }

        public void TerminateContract(IAbstractFactory publisher) 
        {
            PublisherState = publisher.Name + ". Is no longer available";
            publishers.Remove(publisher);
        }

        public void StartContract(IAbstractFactory publisher) 
        {
            PublisherState = publisher.Name + ". Is now being distributed";
            publishers.Add(publisher);
        }
    }
}
