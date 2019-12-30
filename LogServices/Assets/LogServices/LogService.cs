using LogServices.Interfaces;
using System;
using System.Collections.Generic;

namespace LogServices
{
    public class LogService : ILogService
    {
        private List<ILogHandler> _logHandlers = new List<ILogHandler>();

        public void AddHandler(ILogHandler handler)
        {
            _logHandlers.Add(handler);
        }

        public void RemoveHandler(ILogHandler handler)
        {
            _logHandlers.Remove(handler);
        }

        public void Info(string message)
        {
            foreach(var handler in _logHandlers)
            {
                handler?.Info(message);
            }
        }

        public void Warn(string message)
        {
            foreach(var handler in _logHandlers)
            {
                handler?.Warn(message);
            }
        }

        public void Error(string message)
        {
            foreach (var handler in _logHandlers)
            {
                handler?.Error(message);
            }
        }

        public void Exception(Exception exception)
        {
            foreach (var handler in _logHandlers)
            {
                handler?.Exception(exception);
            }
        }

        public IEnumerable<ILogHandler> GetHandlers()
        {
            return _logHandlers;
        }
    }
}
