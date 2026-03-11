using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Xunit;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.DNXCore.IntegrationTests
{
    /// <summary>
    /// Test class for testing various AWS protocols.
    /// </summary>
    
    public class ProtocolTests
    {
        [Fact]
        public async Task TestRestXml()
        {
            // TODO: Validate this test is still necessary after the S3 codegen migration is complete.
            using (var client = UtilityMethods.CreateClient<AmazonS3Client>())
            {
                var bucketName = await UtilityMethods.CreateBucketAsync(client, "TestRestXml_Async");
                try
                {
                    var buckets = (await client.ListBucketsAsync(new ListBucketsRequest())).Buckets;
                    Assert.NotNull(buckets);
                    Assert.NotEmpty(buckets);
                    Assert.Equal(1, buckets
                        .Count(b =>
                            string.Equals(bucketName, b.BucketName, StringComparison.OrdinalIgnoreCase)));

                    var fakeBucketName = ("really-fake-bucket-that-shout-not-exist" + DateTime.UtcNow.ToFileTime()).ToLower();
                    var as3e = await AssertExtensions.ExpectExceptionAsync<AmazonS3Exception>(client.DeleteBucketAsync(new DeleteBucketRequest
                    {
                        BucketName = fakeBucketName
                    }));

                    Assert.NotNull(as3e);
                    Assert.NotNull(as3e.Message);
                    Assert.Equal(ErrorType.Sender, as3e.ErrorType);
                }
                finally
                {
                    await UtilityMethods.DeleteBucketWithObjectsAsync(client, bucketName);
                }
            }
        }
    }
}
