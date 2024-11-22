using ObserverPatterns.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatterns {
     class Program {
        static void Main(string[] args) {

            // Cria um subject
            NewsPublisher publisher = new NewsPublisher();

            // Cria alguns observers
            Subscriber subscriber1 = new Subscriber("Thiago");
            Subscriber subscriber2 = new Subscriber("Maria");

            // Adiciona os observers ao subject
            publisher.Attach(subscriber1);
            publisher.Attach(subscriber2);

            // Publica uma notícia
            publisher.PublishNews("C# 12 foi lançado com novos recursos incríveis!");

            // Remove um observer
            publisher.Detach(subscriber2);

            // Publica outra notícia
            publisher.PublishNews("Nova atualização de segurança disponível para o .NET Framework.");

            Console.ReadLine();
        }
    }
}
