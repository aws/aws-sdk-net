using Amazon.S3;
using Amazon.S3.Model;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests.S3
{
    public class CopyObjectTests : TestBase<AmazonS3Client>
    {
        private readonly string bucketName;
        private readonly string testContent = "This is some sample text.!!";

        public CopyObjectTests()
        {
            bucketName = UtilityMethods.CreateBucketAsync(Client, "CopyObjectTest").Result;
        }

        protected override void Dispose(bool disposing)
        {
            UtilityMethods.DeleteBucketWithObjectsAsync(Client, bucketName).Wait();
            base.Dispose(disposing);
        }

        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public async Task CopyObjectTestWithLeadingSlash()
        {
            var sourceKey = "/source-key.txt";
            var destinationKey = "/destination-key.txt";

            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                ContentBody = testContent,
                Key = sourceKey
            });

            var copyResponse = await Client.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = bucketName,
                SourceKey = sourceKey,

                DestinationBucket = bucketName,
                DestinationKey = destinationKey
            });
            Assert.Equal(HttpStatusCode.OK, copyResponse.HttpStatusCode);

            using (var getResponse = await Client.GetObjectAsync(bucketName, destinationKey))
            using (var reader = new StreamReader(getResponse.ResponseStream))
            {
                var actualContent = reader.ReadToEnd();
                Assert.Equal(testContent, actualContent);
            }
        }
    }
}
