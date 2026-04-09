using Amazon.Runtime;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class ChecksumMultipartTests : ChecksumTestBase
    {
        public ChecksumMultipartTests(ChecksumMrapFixture mrapFixture) : base(mrapFixture)
        {
        }

        [Theory]
        [MemberData(nameof(GetAlgorithmsToTest))]
        public async Task TestSignedCopyObjectUsingMultipartUpload(CoreChecksumAlgorithm algorithm)
        {
            await CopyObjectUsingMultipartTestHelper(algorithm, _bucketName);
        }

        [Theory]
        [MemberData(nameof(GetAlgorithmsToTest))]
        public async Task TestV4SignedMultipartUpload(CoreChecksumAlgorithm algorithm)
        {
            await MultipartTestHelper(algorithm, _bucketName, false);
        }

        [Theory]
        [MemberData(nameof(GetAlgorithmsToTest))]
        public async Task TestV4UnsignedMultipartUpload(CoreChecksumAlgorithm algorithm)
        {
            await MultipartTestHelper(algorithm, _bucketName, true);
        }

        [Theory]
        [MemberData(nameof(GetAlgorithmsToTest))]
        public async Task TestV4aSignedMultipartUpload(CoreChecksumAlgorithm algorithm)
        {
            await MultipartTestHelper(algorithm, _mrapArn, false);
        }

        [Theory]
        [MemberData(nameof(GetAlgorithmsToTest))]
        public async Task TestV4aUnsignedMultipartUpload(CoreChecksumAlgorithm algorithm)
        {
            await MultipartTestHelper(algorithm, _mrapArn, true);
        }
    }
}
