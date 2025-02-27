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
using Amazon;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Amazon.DNXCore.IntegrationTests
{
    public class ArchiveTransferManagerTests : TestBase<AmazonGlacierClient>
    {
        static string testingVaultName = UtilityMethods.SDK_TEST_PREFIX + "-archive-manager-glacier-test";
        
        [Trait(CategoryAttribute, "Glacier")]
        [Fact]
        public async Task ListGlacierCalls()
        {
            string vaultName = UtilityMethods.GenerateName("glacier-test");
            Client.CreateVaultAsync(new CreateVaultRequest
            {
                VaultName = vaultName
            }).Wait();
            try
            {
                Assert.NotNull(await Client.ListJobsAsync(new ListJobsRequest { VaultName = vaultName }));
                Assert.NotNull(await Client.ListMultipartUploadsAsync(new Glacier.Model.ListMultipartUploadsRequest { VaultName = vaultName }));
                Assert.NotNull(await Client.ListVaultsAsync(new ListVaultsRequest()));
            }
            finally
            {
                await Client.DeleteVaultAsync(new DeleteVaultRequest { VaultName = vaultName });
            }
        }

        
        [Fact]
        public async Task TestSimpleUpload()
        {
            await Client.CreateVaultAsync(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            });
            const string accountID = "-";
            string archiveID = null;
            
            var memoryStream = new MemoryStream(Encoding.ASCII.GetBytes("data to archive"));
            var uploadArchiveRequest = new UploadArchiveRequest
            {
                VaultName = testingVaultName,
                Body = memoryStream,
                Checksum = TreeHashGenerator.CalculateTreeHash(memoryStream),
                AccountId = accountID,
                ArchiveDescription = "my first archive"
            };

            var response = await Client.UploadArchiveAsync(uploadArchiveRequest);
            archiveID = response.ArchiveId;

            await Client.DeleteArchiveAsync(new DeleteArchiveRequest { AccountId = accountID, VaultName = testingVaultName, ArchiveId = archiveID });
        }
    }
}