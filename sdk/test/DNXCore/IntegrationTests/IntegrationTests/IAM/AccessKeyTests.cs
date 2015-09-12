using System;
using System.Text;
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
        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestCreateAccessKey()
        {
            using (var session = new IAMTestSession("TestCreateAccessKey", Client))
            {
                string username = session.CreateTestUser();
                string keyId = null;
                try
                {
                    CreateAccessKeyResponse response =
                        Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username }).Result;
                    keyId = response.AccessKey.AccessKeyId;
                    Assert.True(response.AccessKey.CreateDate.Date.CompareTo(DateTime.Now.Date) == 0);
                }
                finally
                {
                    if (keyId != null)
                        Client.DeleteAccessKeyAsync(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = keyId }).Wait();                    
                }
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestCreateAccessKeyNonExistentUserException()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;
            AssertExtensions.ExpectExceptionAsync<NoSuchEntityException>(Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username })).Wait();
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestListAccessKeys()
        {
            using (var session = new IAMTestSession("TestListAccessKeys", Client))
            {
                string username = session.CreateTestUser();
                string[] keyIds = new string[2];

                for (int i = 0; i < 2; i++)
                {
                    CreateAccessKeyResponse response =
                        Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username }).Result;

                    keyIds[i] = response.AccessKey.AccessKeyId;
                }

                ListAccessKeysResponse listRes =
                    Client.ListAccessKeysAsync(new ListAccessKeysRequest() { UserName = username }).Result;

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

        // There is a limit of 2 access keys per user
        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(LimitExceededException))]
        public void TestLimitExceedException()
        {
            using (var session = new IAMTestSession("TestLimitExceedException", Client))
            {
                string username = session.CreateTestUser();

                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username }).Wait();
                    }
                }
                catch (AggregateException ae)
                {
                    Assert.NotNull(ae);
                    Assert.NotNull(ae.InnerExceptions);
                    Assert.Equal(1, ae.InnerExceptions.Count);
                    Assert.NotNull(ae.InnerExceptions[0] as LimitExceededException);
                }
            }
        }

        [Fact]
        [Trait(CategoryAttribute, "IAM")]
        public void TestDeleteAccessKey()
        {
            using (var session = new IAMTestSession("TestDeleteAccessKey", Client))
            {
                string username = session.CreateTestUser();
                string[] keyIds = new string[2];

                for (int i = 0; i < 2; i++)
                {
                    CreateAccessKeyResponse response =
                        Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username }).Result;

                    keyIds[i] = response.AccessKey.AccessKeyId;
                }

                ListAccessKeysResponse lakRes =
                    Client.ListAccessKeysAsync(new ListAccessKeysRequest() { UserName = username }).Result;

                Assert.Equal(2, lakRes.AccessKeyMetadata.Count());

                Client.DeleteAccessKeyAsync(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = keyIds[0] }).Wait();

                lakRes = Client.ListAccessKeysAsync(new ListAccessKeysRequest() { UserName = username }).Result;

                Assert.Equal(1, lakRes.AccessKeyMetadata.Count());
                Assert.Equal(keyIds[1], lakRes.AccessKeyMetadata[0].AccessKeyId);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestDeleteNonExistentAccessKeyException()
        {
            using (var session = new IAMTestSession("TestDeleteNonExistentAccessKeyException", Client))
            {
                string username = session.CreateTestUser();
                try
                {
                    CreateAccessKeyResponse response =
                        Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username }).Result;

                    string keyId = response.AccessKey.AccessKeyId;

                    Client.DeleteAccessKeyAsync(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = keyId }).Wait();
                    Client.DeleteAccessKeyAsync(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = keyId }).Wait();
                }
                catch (AggregateException ae)
                {
                    AssertExtensions.VerifyException<NoSuchEntityException>(ae);
                }
            }
        }
    }
}
