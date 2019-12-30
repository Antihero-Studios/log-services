# Log Services

## Concepts

### ILogService
`ILogService` is the main touch-point for the projects. It provides several methods to log such as: `Info`,`Warn`,`Error`,`Exception`.

### ILogHandler
By itself `ILogService` doesn't do anything. You must add `ILogHandler`s as necessary. This allows each project to specify how and when, exactly logs are produced. For example, you may want to write Info and Warnings to the log, but send any Exceptions to a web-service for collection.

``` csharp
public class OnlyExceptionsLogHandler : ILogHandler
{
    public void Exception(Exception exception)
    {
        UnityEngine.Debug.LogException(exception);
    }

    public void Error(string message) {}
    public void Info(string message) {}
    public void Warn(string message) {}
}

// Add to service...
_logService.AddHandler(new OnlyExceptionsLogHandler());
```