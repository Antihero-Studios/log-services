using System;
using LogServices.Interfaces;

namespace LogServices.Handlers
{
    public class DefaultUnityLogHandler : ILogHandler
    {
        public void Error(string message)
        {
            UnityEngine.Debug.LogError(message);
        }

        public void Exception(Exception exception)
        {
            UnityEngine.Debug.LogException(exception);
        }

        public void Info(string message)
        {
            UnityEngine.Debug.Log(message);
        }

        public void Warn(string message)
        {
            UnityEngine.Debug.LogWarning(message);
        }
    }
}
