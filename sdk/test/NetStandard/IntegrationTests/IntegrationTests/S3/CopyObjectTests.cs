using Amazon.ConfigService.Model;
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

        private const string testKey = "testKey.txt";
        private const string testKeyWithSlash = "/sourceTestKey.txt";

        public CopyObjectTests()
        {
            bucketName = UtilityMethods.CreateBucketAsync(Client, "CopyObjectTest").Result;

            Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                ContentBody = testContent,
                Key = testKey
            }).Wait();

            Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                ContentBody = testContent,
                Key = testKeyWithSlash
            }).Wait();
        }

        protected override void Dispose(bool disposing)
        {
            UtilityMethods.DeleteBucketWithObjectsAsync(Client, bucketName).Wait();
            base.Dispose(disposing);
        }

        [Theory]
        [InlineData(testKey, "/destinationTestKey1.txt", "/destinationTestKey1.txt")]
        [InlineData(testKeyWithSlash, "/destinationTestKey2.txt", "/destinationTestKey2.txt")]
        [InlineData(testKeyWithSlash, "/", "/")]
        [Trait(CategoryAttribute, "S3")]
        public async Task CopyObjectTestWithLeadingSlash(string sourceKey, string destinationKey, string expectedKey)
        {
            var copyResponse = await Client.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = bucketName,
                SourceKey = sourceKey,

                DestinationBucket = bucketName,
                DestinationKey = destinationKey,
            });
            Assert.Equal(HttpStatusCode.OK, copyResponse.HttpStatusCode);

            using (var getResponse = await Client.GetObjectAsync(bucketName, expectedKey))
            using (var reader = new StreamReader(getResponse.ResponseStream))
            {
                var actualContent = reader.ReadToEnd();
                Assert.Equal(testContent, actualContent);
            }
        }
    }
}
