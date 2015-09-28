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
    public class TransferUtilityTest : TestBase<AmazonS3Client>
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);
                
        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public void SimpleUpload()
        {
            var testFile = "PutObjectFile.txt";
            var testContent = "This is the content body!";
            var fullPath = UtilityMethods.GenerateName("SimpleUpload");
            File.WriteAllText(fullPath, testContent);

            RunAsSync(async () =>
            {
                var bucketName = await UtilityMethods.CreateBucketAsync(Client, "SimpleUpload");
                try
                {
                    var client = Client;

                    using (var tu = new Amazon.S3.Transfer.TransferUtility(client))
                    {
                        await tu.UploadAsync(fullPath, bucketName);

                        var response = await client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                        {
                            BucketName = bucketName,
                            Key = testFile
                        });
                        Assert.True(response.ETag.Length > 0);

                        var downloadPath = fullPath + ".download";
                        var downloadRequest = new Amazon.S3.Transfer.TransferUtilityDownloadRequest
                        {
                            BucketName = bucketName,
                            Key = testFile,
                            FilePath = downloadPath
                        };

                        var fileExists = File.Exists(downloadPath);
                        Assert.False(fileExists);
                        await tu.DownloadAsync(downloadRequest);
                        TestDownloadedFile(downloadPath, testContent);

                        // empty out file, except for 1 byte
                        File.WriteAllText(fullPath, testContent.Substring(0, 1));
                        await tu.DownloadAsync(downloadRequest);
                        TestDownloadedFile(downloadPath, testContent);
                    }
                }
                finally
                {
                    await UtilityMethods.DeleteBucketWithObjectsAsync(Client, bucketName);
                }
            });
        }

        private void TestDownloadedFile(string downloadPath, string content)
        {
            var fileExists = File.Exists(downloadPath);
            Assert.True(fileExists);
            var fileContent = File.ReadAllText(downloadPath);
            Assert.Equal(content, fileContent);
        }
    }
}
