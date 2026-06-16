using Amazon;
using Amazon.S3Control;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures
{
    /// <summary>
    /// Assembly-level fixture that provides a long-lived S3 Multi-Region Access Point (MRAP)
    /// and a standard S3 bucket for checksum and MRAP integration tests.
    /// <para>
    /// The MRAP is created once and reused across test runs (it is expensive to create).
    /// The standard bucket is deleted after each test run.
    /// </para>
    /// </summary>
    public class ChecksumMrapFixture : S3BucketFixture
    {
        public string MrapArn { get; private set; }

        public override async ValueTask InitializeAsync()
        {
            await base.InitializeAsync();
            MrapArn = await S3TestUtils.GetOrCreateTestMRAP(new AmazonS3ControlClient(RegionEndpoint.USWest2), Client);
        }

        public override async ValueTask DisposeAsync()
        {
            if (MrapArn != null)
            {
                // Delete objects in the MRAP bucket but leave the MRAP itself for future runs.
                await S3TestUtils.DeleteObjects(Client, MrapArn);
            }
            await base.DisposeAsync();
        }
    }
}
