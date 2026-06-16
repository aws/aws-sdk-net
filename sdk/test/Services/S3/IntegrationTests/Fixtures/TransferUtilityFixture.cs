using Amazon.S3.Transfer;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures
{
    /// <summary>
    /// Assembly-level fixture that creates one S3 bucket and a unique temp directory
    /// shared by all TransferUtility test classes.
    /// <para>
    /// The temp directory is unique per fixture instance (GUID-based) so that parallel
    /// test runs on the same machine do not collide.
    /// </para>
    /// </summary>
    public class TransferUtilityFixture : S3BucketFixture
    {
        /// <summary>
        /// A unique temp directory for this fixture instance.
        /// Each test class that needs its own sub-directory should create one under this path.
        /// </summary>
        public string BasePath { get; private set; }
        public TransferUtility Transfer { get; private set; }

        public override async ValueTask InitializeAsync()
        {
            await base.InitializeAsync();
            Transfer = new TransferUtility(Client);

            // Unique per fixture instance — prevents collisions when tests run in parallel.
            BasePath = Path.Combine(Path.GetTempPath(), "transferutility", Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(BasePath);
        }

        public override async ValueTask DisposeAsync()
        {
            Transfer?.Dispose();

            if (BasePath != null && Directory.Exists(BasePath))
            {
                Directory.Delete(BasePath, recursive: true);
            }

            await base.DisposeAsync();
        }
    }
}
