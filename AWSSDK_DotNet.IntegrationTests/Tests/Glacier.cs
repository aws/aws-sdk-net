using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.Glacier;
using Amazon.Glacier.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using AWSSDK_DotNet.IntegrationTests.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class Glacier : TestBase<AmazonGlacierClient>
    {
        private const long CONTENT_LENGTH = 1024 * 1024 * 5;

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("Glacier")]
        public void ListCalls()
        {
            var testingVaultName = "dotnet-sdk-test" + DateTime.Now.Ticks.ToString();
            Client.CreateVault(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            });
            Assert.IsNotNull(Client.ListJobs(new ListJobsRequest { VaultName = testingVaultName }));
            Assert.IsNotNull(Client.ListMultipartUploads(new ListMultipartUploadsRequest { VaultName = testingVaultName }));
            Assert.IsNotNull(Client.ListVaults(new ListVaultsRequest()));

            Client.DeleteVault(new DeleteVaultRequest { VaultName = testingVaultName });
        }

        // Commented out because the would leave data in glacier that would cost money
        //[TestMethod]
        //[TestCategory("Glacier")]
        public void TestSimpleUpload()
        {
            var testingVaultName = "dotnet-sdk-test" + DateTime.Now.Ticks.ToString();
            Client.CreateVault(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            });
            const string accountID = "-";
            string archiveID = null;

            try
            {
                var memoryStream = new MemoryStream(Encoding.ASCII.GetBytes("data to archive"));
                var uploadArchiveRequest = new UploadArchiveRequest
                {
                    VaultName = testingVaultName,
                    Body = memoryStream,
                    Checksum = TreeHashGenerator.CalculateTreeHash(memoryStream),
                    AccountId = accountID,
                    ArchiveDescription = "my first archive"
                };

                var response = Client.UploadArchive(uploadArchiveRequest);
                archiveID = response.ArchiveId;
            }
            finally
            {
                Client.DeleteArchive(new DeleteArchiveRequest { AccountId = accountID, VaultName = testingVaultName, ArchiveId = archiveID });
            }
        }

        // Commented out because the would leave data in glacier that would cost money
        //[TestMethod]
        //[TestCategory("Glacier")]
        public void TestMultiPartUpload()
        {
            var testingVaultName = "dotnet-sdk-test" + DateTime.Now.Ticks.ToString();
            Client.CreateVault(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            });

            InitiateMultipartUploadRequest initRequest = new InitiateMultipartUploadRequest()
            {
                VaultName = testingVaultName,
                ArchiveDescription = "dotnet mp upload",
                PartSize = 1048576
            };
            InitiateMultipartUploadResponse initResponse = Client.InitiateMultipartUpload(initRequest);
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
                Client.UploadMultipartPart(partRequest);
                currentPosition += partStream.Length;
            }

            CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest()
            {
                VaultName = testingVaultName,
                UploadId = uploadId,
                ArchiveSize = totalStream.Length.ToString(),
                Checksum = TreeHashGenerator.CalculateTreeHash(md5s)
            };
            CompleteMultipartUploadResponse compResponse = Client.CompleteMultipartUpload(compRequest);
            Assert.IsNotNull(compResponse.Location);
            Assert.IsNotNull(compResponse.Checksum);
            string archiveId = compResponse.ArchiveId;

            DeleteArchiveRequest delArchiveRequest = new DeleteArchiveRequest()
            {
                VaultName = testingVaultName,
                ArchiveId = archiveId
            };
            DeleteArchiveResponse delArchiveResponse = Client.DeleteArchive(delArchiveRequest);
        }
    }
}
