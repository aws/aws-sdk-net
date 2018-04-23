using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    /// <summary>
    /// Summary description for AccessKeyTests
    /// </summary>
    [TestClass]
    public class AccessKeyTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        public AccessKeyTests()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestInitialize]
        public void TestSetup()
        {
            IAMUtil.DeleteUsersAndGroupsInTestNameSpace(Client);
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestCreateAccessKey()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string keyId = null;
            try
            {
                CreateAccessKeyResponse response =
                    Client.CreateAccessKey(new CreateAccessKeyRequest() { UserName = username });
                keyId = response.AccessKey.AccessKeyId;
                Assert.IsTrue(response.AccessKey.CreateDate.Date.CompareTo(DateTime.Now.Date) == 0);
            }
            finally
            {
                if (keyId != null)
                    Client.DeleteAccessKey(new DeleteAccessKeyRequest() { UserName = username,AccessKeyId = keyId });

                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(NoSuchEntityException))]
        public void TestCreateAccessKeyNonExistentUserException()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;

            Client.CreateAccessKey(new CreateAccessKeyRequest() { UserName = username });
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestListAccessKeys()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string[] keyIds = new string[2];
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    CreateAccessKeyResponse response =
                        Client.CreateAccessKey(new CreateAccessKeyRequest() { UserName = username });

                    keyIds[i] = response.AccessKey.AccessKeyId;
                }

                ListAccessKeysResponse listRes =
                    Client.ListAccessKeys(new ListAccessKeysRequest() { UserName = username });

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
        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(LimitExceededException))]
        public void TestLimitExceedException()
        {
            string username = IAMUtil.CreateTestUser(Client);

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Client.CreateAccessKey(new CreateAccessKeyRequest() { UserName = username });
                }
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestDeleteAccessKey()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string[] keyIds = new string[2];
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    CreateAccessKeyResponse response =
                        Client.CreateAccessKey(new CreateAccessKeyRequest() { UserName = username });

                    keyIds[i] = response.AccessKey.AccessKeyId;
                }

                ListAccessKeysResponse lakRes =
                    Client.ListAccessKeys(new ListAccessKeysRequest() { UserName = username });

                Assert.AreEqual(2, lakRes.AccessKeyMetadata.Count());

                Client.DeleteAccessKey(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = keyIds[0] });

                lakRes = Client.ListAccessKeys(new ListAccessKeysRequest() { UserName = username });

                Assert.AreEqual(1, lakRes.AccessKeyMetadata.Count());
                Assert.AreEqual(keyIds[1], lakRes.AccessKeyMetadata[0].AccessKeyId);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(NoSuchEntityException))]
        public void TestDeleteNonExistentAccessKeyException()
        {
            string username = IAMUtil.CreateTestUser(Client);
            try
            {
                CreateAccessKeyResponse response =
                    Client.CreateAccessKey(new CreateAccessKeyRequest() { UserName = username });

                string keyId = response.AccessKey.AccessKeyId;

                Client.DeleteAccessKey(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = keyId });
                Client.DeleteAccessKey(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = keyId });
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }
    }
}
