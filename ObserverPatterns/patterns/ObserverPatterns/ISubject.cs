﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatterns.patterns.interfaces {
    public interface ISubject {

        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message);
    }
}
