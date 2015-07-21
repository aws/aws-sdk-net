using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.Glacier;
using Amazon.Glacier.Model;
using System.IO;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class Glacier : TestBase<AmazonGlacierClient>
    {
        private const long CONTENT_LENGTH = 1024 * 1024 * 5;

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [Test]
        [Category("Glacier")]
        public void ListCalls()
        {
            var testingVaultName = "dotnet-sdk-test" + DateTime.Now.Ticks.ToString();
            Client.CreateVaultAsync(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            }).Wait();
            Assert.IsNotNull(Client.ListJobsAsync(new ListJobsRequest { VaultName = testingVaultName }).Result);
            Assert.IsNotNull(Client.ListMultipartUploadsAsync(new ListMultipartUploadsRequest { VaultName = testingVaultName }).Result);
            Assert.IsNotNull(Client.ListVaultsAsync(new ListVaultsRequest()).Result);

            Client.DeleteVaultAsync(new DeleteVaultRequest { VaultName = testingVaultName }).Wait();
        }

        // Commented out because the would leave data in glacier that would cost money
        //[Test]
        //[Category("Glacier")]
        public void TestSimpleUpload()
        {
            var testingVaultName = "dotnet-sdk-test" + DateTime.Now.Ticks.ToString();
            Client.CreateVaultAsync(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            }).Wait();
            const string accountID = "-";
            string archiveID = null;

            try
            {
                var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes("data to archive"));
                var uploadArchiveRequest = new UploadArchiveRequest
                {
                    VaultName = testingVaultName,
                    Body = memoryStream,
                    Checksum = TreeHashGenerator.CalculateTreeHash(memoryStream),
                    AccountId = accountID,
                    ArchiveDescription = "my first archive"
                };

                var response = Client.UploadArchiveAsync(uploadArchiveRequest).Result;
                archiveID = response.ArchiveId;
            }
            finally
            {
                Client.DeleteArchiveAsync(new DeleteArchiveRequest { AccountId = accountID, VaultName = testingVaultName, ArchiveId = archiveID }).Wait();
            }
        }

        // Commented out because the would leave data in glacier that would cost money
        //[Test]
        //[Category("Glacier")]
        public void TestMultiPartUpload()
        {
            var testingVaultName = "dotnet-sdk-test" + DateTime.Now.Ticks.ToString();
            Client.CreateVaultAsync(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            }).Wait();

            InitiateMultipartUploadRequest initRequest = new InitiateMultipartUploadRequest()
            {
                VaultName = testingVaultName,
                ArchiveDescription = "dotnet mp upload",
                PartSize = 1048576
            };
            InitiateMultipartUploadResponse initResponse = Client.InitiateMultipartUploadAsync(initRequest).Result;
            string uploadId = initResponse.UploadId;


            MemoryStream totalStream = new MemoryStream();
            for (int i = 0; i < 1048576 + 1048576 / 2; i++)
            {
                totalStream.WriteByte((byte)(i % byte.MaxValue));
            }
            totalStream.Position = 0;

            List<string> md5s = new List<string>();
            long currentPosition = 0;
            long partSize = 1048576;
            while (totalStream.Position < totalStream.Length)
            {
                Stream partStream = GlacierUtils.CreatePartStream(totalStream, partSize);
                string checkSum = TreeHashGenerator.CalculateTreeHash(partStream);
                md5s.Add(checkSum);

                UploadMultipartPartRequest partRequest = new UploadMultipartPartRequest()
                {
                    VaultName = testingVaultName,
                    UploadId = uploadId,
                    Body = partStream,
                    Checksum = checkSum
                };
                partRequest.SetRange(currentPosition, currentPosition + partStream.Length - 1);
                Client.UploadMultipartPartAsync(partRequest).Wait();
                currentPosition += partStream.Length;
            }

            CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest()
            {
                VaultName = testingVaultName,
                UploadId = uploadId,
                ArchiveSize = totalStream.Length.ToString(),
                Checksum = TreeHashGenerator.CalculateTreeHash(md5s)
            };
            CompleteMultipartUploadResponse compResponse = Client.CompleteMultipartUploadAsync(compRequest).Result;
            Assert.IsNotNull(compResponse.Location);
            Assert.IsNotNull(compResponse.Checksum);
            string archiveId = compResponse.ArchiveId;

            DeleteArchiveRequest delArchiveRequest = new DeleteArchiveRequest()
            {
                VaultName = testingVaultName,
                ArchiveId = archiveId
            };
            DeleteArchiveResponse delArchiveResponse = Client.DeleteArchiveAsync(delArchiveRequest).Result;
        }
    }
}
