using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

using Amazon.Glacier;
using Amazon.Glacier.Model;
using Amazon.Glacier.Transfer;
using Amazon.Runtime;
using Xunit;
using ThirdParty.Json.LitJson;
using Amazon;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Amazon.DNXCore.IntegrationTests
{
    public class ArchiveTransferManagerTests : TestBase<AmazonGlacierClient>
    {

        static string testingVaultName = "sdk-dot-archive-manager-glacier-test";

        static DownloadOptions defaultDownloadOptions = new DownloadOptions() { PollingInterval = 0.1 };

        [Trait(CategoryAttribute, "Glacier")]
        [Fact]

        public async Task Createvault()
        {
            await Client.CreateVaultAsync(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            }).ConfigureAwait(false);

            Assert.NotNull(await Client.ListJobsAsync(new ListJobsRequest { VaultName = testingVaultName }).ConfigureAwait(false));
            Assert.NotNull(await Client.ListMultipartUploadsAsync(new Glacier.Model.ListMultipartUploadsRequest { VaultName = testingVaultName }).ConfigureAwait(false));
            Assert.NotNull(await Client.ListVaultsAsync(new ListVaultsRequest()).ConfigureAwait(false));

            Client.DeleteVaultAsync(new DeleteVaultRequest { VaultName = testingVaultName }).Wait();
        }

        [Fact]

        public async Task TestSimpleUpload()
        {
            await Client.CreateVaultAsync(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            }).ConfigureAwait(false);
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

                var response = await Client.UploadArchiveAsync(uploadArchiveRequest).ConfigureAwait(false);
                archiveID = response.ArchiveId;
            }
            finally
            {
                Client.DeleteArchiveAsync(new DeleteArchiveRequest { AccountId = accountID, VaultName = testingVaultName, ArchiveId = archiveID }).Wait();
            }
        }
    }
}