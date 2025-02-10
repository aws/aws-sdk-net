using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    /// <summary>
    /// Summary description for AccessKeyTests
    /// </summary>
    
    public class AccessKeyTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        [Fact(Skip = "Excluding tests that need IAM Write/Permissions management.")]
        [Trait(CategoryAttribute,"IAM")]
        public async Task TestCreateAccessKey()
        {
            using (var session = new IAMTestSession("TestCreateAccessKey", Client))
            {
                string username = session.CreateTestUser();
                string keyId = null;
                try
                {
                    CreateAccessKeyResponse response =
                        await Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username });
                    keyId = response.AccessKey.AccessKeyId;
                    Assert.True(response.AccessKey.CreateDate.Value.Date.CompareTo(DateTime.UtcNow.Date) == 0);
                }
                finally
                {
                    if (keyId != null)
                        await Client.DeleteAccessKeyAsync(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = keyId });                    
                }
            }
        }

        [Fact(Skip = "Excluding tests that need IAM Write/Permissions management.")]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public async Task TestCreateAccessKeyNonExistentUserException()
        {
            string username = "sdk-testuser-" + DateTime.UtcNow.Ticks;
            await AssertExtensions.ExpectExceptionAsync<NoSuchEntityException>(Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username }));
        }

        [Fact(Skip="Excluding tests that need IAM Write/Permissions management.")]
        [Trait(CategoryAttribute,"IAM")]
        public async Task TestListAccessKeys()
        {
            using (var session = new IAMTestSession("TestListAccessKeys", Client))
            {
                string username = session.CreateTestUser();
                string[] keyIds = new string[2];

                for (int i = 0; i < 2; i++)
                {
                    CreateAccessKeyResponse response =
                        await Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username });

                    keyIds[i] = response.AccessKey.AccessKeyId;
                }

                ListAccessKeysResponse listRes =
                    await Client.ListAccessKeysAsync(new ListAccessKeysRequest() { UserName = username });

                int matches = 0;
                foreach (AccessKeyMetadata akm in listRes.AccessKeyMetadata)
                {
                    if (akm.AccessKeyId.Equals(keyIds[0]))
                        matches |= 1;
                    if (akm.AccessKeyId.Equals(keyIds[1]))
                        matches |= 2;
                }
                Assert.Equal(3, matches);

            }
        }


        [Fact(Skip = "Excluding tests that need IAM Write/Permissions management.")]
        [Trait(CategoryAttribute, "IAM")]
        public async Task TestDeleteAccessKey()
        {
            using (var session = new IAMTestSession("TestDeleteAccessKey", Client))
            {
                string username = session.CreateTestUser();
                string[] keyIds = new string[2];

                for (int i = 0; i < 2; i++)
                {
                    CreateAccessKeyResponse response =
                        await Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username });

                    keyIds[i] = response.AccessKey.AccessKeyId;
                }

                ListAccessKeysResponse lakRes =
                    await Client.ListAccessKeysAsync(new ListAccessKeysRequest() { UserName = username });

                Assert.Equal(2, lakRes.AccessKeyMetadata.Count());

                await Client.DeleteAccessKeyAsync(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = keyIds[0] });

                lakRes = await Client.ListAccessKeysAsync(new ListAccessKeysRequest() { UserName = username });

                Assert.Single(lakRes.AccessKeyMetadata);
                Assert.Equal(keyIds[1], lakRes.AccessKeyMetadata[0].AccessKeyId);
            }
        }

        [Fact(Skip = "Excluding tests that need IAM Write/Permissions management.")]
        [Trait(CategoryAttribute,"IAM")]
        public async Task TestDeleteNonExistentAccessKeyException()
        {
            using (var session = new IAMTestSession("TestDeleteNonExistentAccessKeyException", Client))
            {
                string username = session.CreateTestUser();

                CreateAccessKeyResponse response = await Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username });

                string keyId = response.AccessKey.AccessKeyId;
                await Client.DeleteAccessKeyAsync(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = keyId });

                await Assert.ThrowsAsync<NoSuchEntityException>(() => Client.DeleteAccessKeyAsync(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = keyId }));
            }
        }
    }
}
