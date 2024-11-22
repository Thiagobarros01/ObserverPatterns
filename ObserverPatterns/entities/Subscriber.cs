using ObserverPatterns.patterns.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatterns.entities {
     class Subscriber : IObserver {
        private string name;

        public Subscriber(string name) {
            this.name = name;
        }

        public void Update(string message) {
            Console.WriteLine($"[{name}] Recebeu a notícia: {message}");
        }
    }
}
