using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaMemoryTest;

public class Function
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input">The event for the Lambda function handler to process.</param>
    /// <param name="context">The ILambdaContext that provides methods for logging and describing the Lambda environment.</param>
    /// <returns></returns>
    public string FunctionHandler(string input, ILambdaContext context)
    {
        context.Logger.LogInformation("DOTNET_GCHeapHardLimit Value: " + Environment.GetEnvironmentVariable("DOTNET_GCHeapHardLimit"));
        context.Logger.LogInformation("Total Available Memory: " + GC.GetGCMemoryInfo().TotalAvailableMemoryBytes.ToString("N0"));
        return input.ToUpper();
    }
}
