# AWSSDK.Extensions.Logging.ILoggerAdaptor

This package allows the logging from the AWS SDK for .NET to be written to Microsoft.Extensions.Logging.

# Example

The code below shows how to enable the SDK logging by calling the `ConfigureAWSSDKLogging` extension method on the configured `ILoggerFactory` of the application.

```csharp
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Services.GetRequiredService<ILoggerFactory>()
    .ConfigureAWSSDKLogging();
```