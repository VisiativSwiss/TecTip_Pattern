using System.Collections.Generic;

namespace TecTip_Pattern
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    public interface IObserver
    {
        void Update();
    }

    // Concrete Subject
    public class SolidWorksApplication : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        // Methods to trigger Notify() when certain events occur in SolidWorks
    }

    // Concrete Observer
    public class AddInComponent : IObserver
    {
        public void Update()
        {
            // Respond to the notification
        }
    }

}
