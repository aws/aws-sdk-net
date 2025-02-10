using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Amazon.S3;

using Amazon.DNXCore.IntegrationTests;
using Amazon.S3.Model;
using System.Net;
using System.Threading;
using System.IO;

namespace Amazon.DNXCore.IntegrationTests.S3
{
    public class MetadataTests : TestBase<AmazonS3Client>
    {
        private Random random = new Random();
        private string bucketName;
        private string filePath = string.Empty;
        private static readonly Dictionary<string, string> metadata = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "date", DateTime.UtcNow.ToFileTime().ToString() },
            { "test", "true" }
        };
        private static readonly Dictionary<string, string> unicodeMetadata = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "test", "test" },
            { "test2", "£" },
            { "test3", "no non ascii characters %" },
            { "test4", "1 non ascii character £ %" }
        };

        public MetadataTests()
        {
            filePath = Path.Combine(Path.GetTempPath(), "PutObjectMetadataFile.txt");
            File.WriteAllText(filePath, "This is some sample text.!!");
            bucketName = UtilityMethods.CreateBucketAsync(Client, "PutObjectTest").Result;
        }

        protected override void Dispose(bool disposing)
        {
            UtilityMethods.DeleteBucketWithObjectsAsync(Client, bucketName).Wait();

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            base.Dispose(disposing);
        }

        [Theory]
        [Trait(CategoryAttribute, "S3")]
        [InlineData(true)]
        [InlineData(false)]
        public async Task SimplePutObjectTestWithMetadata(bool escapeMetadata)
        {
            AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata = escapeMetadata;
            var key = "contentBodyPut" + random.Next();
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = key
            };
            SetMetadata(request.Metadata);
            PutObjectResponse response = await Client.PutObjectAsync(request);
            await ValidateObjectMetadata(key);
            AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata = false;
        }

        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public async Task PutObjectTestWithUnicodeMetadata()
        {
            AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata = true;
            var key = "contentBodyPut" + random.Next();
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = key
            };
            SetMetadata(request.Metadata, true);
            PutObjectResponse response = await Client.PutObjectAsync(request);
            await ValidateObjectMetadata(key, true);
            AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata = false;
        }

        private void SetMetadata(MetadataCollection mc, bool unicode = false)
        {
            foreach (var kvp in unicode ? unicodeMetadata : metadata)
                mc[kvp.Key] = kvp.Value;
        }

        private async Task ValidateObjectMetadata(string key, bool unicode = false)
        {
            using (var response = await Client.GetObjectAsync(bucketName, key))
            {
                ValidateMetadata(response, unicode);
            }
        }

        private static void ValidateMetadata(GetObjectResponse response, bool unicode = false)
        {
            foreach (var kvp in unicode ? unicodeMetadata : metadata)
            {
                var name = kvp.Key;
                var expectedValue = kvp.Value;
                var actualValue = response.Metadata[name];
                Assert.Equal(expectedValue, actualValue);
            }
        }
    }
}
