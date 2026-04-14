using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures
{
    /// <summary>
    /// Class-level fixture that creates an isolated S3 bucket with public ACLs enabled.
    /// Used by test classes that require ACL or public-policy operations.
    /// <para>
    /// Usage: <c>public class MyTests(S3PublicAclBucketFixture fixture) : IClassFixture&lt;S3PublicAclBucketFixture&gt;</c>
    /// </para>
    /// </summary>
    public class S3PublicAclBucketFixture : S3BucketFixture
    {
        protected override Task<string> CreateBucketAsync()
            => S3TestUtils.CreateBucketWithWaitAsync(Client, setPublicACLs: true);
    }
}
