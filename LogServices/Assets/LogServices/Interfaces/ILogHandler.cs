using System;

namespace LogServices.Interfaces
{
    public interface ILogHandler
    {
        void Info(string message);
        void Warn(string message);
        void Error(string message);
        void Exception(Exception exception);
    }
}
