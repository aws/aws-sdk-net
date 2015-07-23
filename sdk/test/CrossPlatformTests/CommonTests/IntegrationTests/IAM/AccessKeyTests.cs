using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using CommonTests.Framework;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    /// <summary>
    /// Summary description for AccessKeyTests
    /// </summary>
    [TestFixture]
    public class AccessKeyTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [SetUp]
        public void TestSetup()
        {
            IAMUtil.DeleteUsersAndGroupsInTestNameSpace(Client);
        }

        [Test]
        [Category("IAM")]
        public void TestCreateAccessKey()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string keyId = null;
            try
            {
                CreateAccessKeyResponse response =
                    Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username }).Result;
                keyId = response.AccessKey.AccessKeyId;
                Assert.IsTrue(response.AccessKey.CreateDate.Date.CompareTo(DateTime.Now.Date) == 0);
            }
            finally
            {
                if (keyId != null)
                    Client.DeleteAccessKeyAsync(new DeleteAccessKeyRequest() { UserName = username,AccessKeyId = keyId }).Wait();

                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [Test]
        [Category("IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestCreateAccessKeyNonExistentUserException()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;

            AssertExtensions.ExpectExceptionAsync<NoSuchEntityException>(Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username })).Wait();
        }

        [Test]
        [Category("IAM")]
        public void TestListAccessKeys()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string[] keyIds = new string[2];
            try
            {
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
                Assert.AreEqual(3, matches);

            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        // There is a limit of 2 access keys per user
        [Test]
        [Category("IAM")]
        //[ExpectedException(typeof(LimitExceededException))]
        public void TestLimitExceedException()
        {
            string username = IAMUtil.CreateTestUser(Client);

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username }).Wait();
                }
            }
            catch(AggregateException ae)
            {
                Assert.IsNotNull(ae);
                Assert.IsNotNull(ae.InnerExceptions);
                Assert.AreEqual(1, ae.InnerExceptions.Count);
                Assert.IsNotNull(ae.InnerExceptions[0] as LimitExceededException);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [Test]
        [Category("IAM")]
        public void TestDeleteAccessKey()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string[] keyIds = new string[2];
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    CreateAccessKeyResponse response =
                        Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username }).Result;

                    keyIds[i] = response.AccessKey.AccessKeyId;
                }

                ListAccessKeysResponse lakRes =
                    Client.ListAccessKeysAsync(new ListAccessKeysRequest() { UserName = username }).Result;

                Assert.AreEqual(2, lakRes.AccessKeyMetadata.Count());

                Client.DeleteAccessKeyAsync(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = keyIds[0] }).Wait();

                lakRes = Client.ListAccessKeysAsync(new ListAccessKeysRequest() { UserName = username }).Result;

                Assert.AreEqual(1, lakRes.AccessKeyMetadata.Count());
                Assert.AreEqual(keyIds[1], lakRes.AccessKeyMetadata[0].AccessKeyId);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [Test]
        [Category("IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestDeleteNonExistentAccessKeyException()
        {
            string username = IAMUtil.CreateTestUser(Client);
            try
            {
                CreateAccessKeyResponse response =
                    Client.CreateAccessKeyAsync(new CreateAccessKeyRequest() { UserName = username }).Result;

                string keyId = response.AccessKey.AccessKeyId;

                Client.DeleteAccessKeyAsync(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = keyId }).Wait();
                Client.DeleteAccessKeyAsync(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = keyId }).Wait();
            }
            catch(AggregateException ae)
            {
                AssertExtensions.VerifyException<NoSuchEntityException>(ae);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }
    }
}
