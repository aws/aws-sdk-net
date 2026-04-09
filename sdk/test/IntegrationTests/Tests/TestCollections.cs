using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /// <summary>
    /// Collection definition that disables parallelization. Test classes decorated with
    /// [Collection("Serial")] will not run concurrently with any other test collection.
    /// Use this for tests that mutate global static state (e.g. AWSConfigs fields).
    /// </summary>
    [CollectionDefinition("Serial", DisableParallelization = true)]
    public class SerialCollectionDefinition { }
}
