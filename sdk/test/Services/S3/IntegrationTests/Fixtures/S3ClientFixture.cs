using Amazon.S3;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures
{
    /// <summary>
    /// xUnit fixture that owns a single <see cref="AmazonS3Client"/> for the lifetime
    /// of the test class that uses it.
    /// </summary>
    public class S3ClientFixture : IAsyncLifetime
    {
        public AmazonS3Client Client { get; protected set; }

        public virtual ValueTask InitializeAsync()
        {
            Client = new AmazonS3Client();
            RetryUtilities.ConfigureClient(Client);
            return default;
        }

        public virtual ValueTask DisposeAsync()
        {
            Client?.Dispose();
            return default;
        }
    }
}
