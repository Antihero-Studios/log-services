using System;
using System.Collections.Generic;

namespace LogServices.Interfaces
{
    public interface ILogService
    {
        void Info(string message);
        void Warn(string message);
        void Error(string message);
        void Exception(Exception exception);

        void AddHandler(ILogHandler handler);
        void RemoveHandler(ILogHandler handler);

        IEnumerable<ILogHandler> GetHandlers();
    }
}
