﻿using System;
using System.Threading.Tasks;

namespace SignalR.Client.Hubs {
    public interface IHubProxy {
        object this[string name] { get; set; }

        IObservable<object[]> Subscribe(string eventName);
        Task Invoke(string action, params object[] args);
        Task<T> Invoke<T>(string action, params object[] args);
    }
}
