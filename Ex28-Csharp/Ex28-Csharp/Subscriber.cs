using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_Csharp
{
    public abstract class Subscriber
    {
        private List<Observer> observers;

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
            //foreach (Observer item in observers)
            //{
            //    if (observer == item)
            //    {
            //        observers.Remove(item);
            //    }
            //}
        }

        public void Notify()
        {
            foreach(Observer item in observers)
            {
                item.Update();
            }
        }
    }
}
