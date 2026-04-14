using Amazon.S3.Util;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures
{
    /// <summary>
    /// Class-level fixture that creates an isolated S3 bucket for a single test class.
    /// Used by bucket-configuration test classes (versioning, lifecycle, policy, etc.)
    /// that modify bucket-level settings and therefore cannot share a bucket.
    /// <para>
    /// Usage: <c>public class MyTests(S3BucketFixture bucket) : IClassFixture&lt;S3BucketFixture&gt;</c>
    /// </para>
    /// </summary>
    public class S3BucketFixture : S3ClientFixture
    {
        public string BucketName { get; protected set; }

        public override async ValueTask InitializeAsync()
        {
            await base.InitializeAsync();
            BucketName = await CreateBucketAsync();
        }

        protected virtual Task<string> CreateBucketAsync()
            => S3TestUtils.CreateBucketWithWaitAsync(Client);

        public override async ValueTask DisposeAsync()
        {
            if (Client != null && BucketName != null)
            {
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, BucketName);
            }
            await base.DisposeAsync();
        }
    }
}
