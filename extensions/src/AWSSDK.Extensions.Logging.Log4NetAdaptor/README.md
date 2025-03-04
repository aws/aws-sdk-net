# AWSSDK.Extensions.Logging.Log4NetAdaptor

This package allows the logging from the AWS SDK for .NET to be written to log4net.

# Example

The code below shows how to enable the SDK logging by calling the `Log4NetAWSExtensions.ConfigureAWSSDKLogging` from the namespace `AWSSDK.Extensions.Logging.Log4NetAdaptor`.

```csharp
using Amazon.Extensions.Logging.Log4NetAdaptor;
using log4net;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]

Log4NetAWSExtensions.ConfigureAWSSDKLogging();
```