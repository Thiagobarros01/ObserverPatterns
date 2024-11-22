using System;
using System.Collections.Generic;
using System.Linq;
using ObserverPatterns.patterns;
using ObserverPatterns.patterns.interfaces;

namespace ObserverPatterns.entities {
     class NewsPublisher : ISubject {

        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer) {
            observers.Add(observer);
        }

        public void Detach(IObserver observer) {
            observers.Remove(observer);
        }

        public void Notify(string message) {
            foreach (IObserver observer in observers) {
                observer.Update(message);
            }
        }

        public void PublishNews(string news) {
            Console.WriteLine("Publicando notícia: " + news);
            Notify(news);
        }
    }
}
