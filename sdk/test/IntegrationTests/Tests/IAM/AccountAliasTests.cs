using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.Runtime;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;



namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    /// <summary>
    /// Summary description for AccountAliasTests
    /// </summary>
    [TestClass]
    public class AccountAliasTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        public AccountAliasTests()
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

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void ListAccessKeys()
        {
            ListAccessKeysResponse response = Client.ListAccessKeys();
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.AccessKeyMetadata);
            Assert.AreNotEqual(0, response.AccessKeyMetadata.Count);
            foreach (var akm in response.AccessKeyMetadata)
            {
                Assert.IsNotNull(akm);
                Assert.IsNotNull(akm.AccessKeyId);
                Assert.IsNotNull(akm.Status);
            }
        }


        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void CreateAccountAlias()
        {
            string alias = "dotnetalias" + DateTime.Now.Ticks;
            CreateAccountAliasRequest createRequest = new CreateAccountAliasRequest()
            {
                AccountAlias = alias
            };

            CreateAccountAliasResponse createResponse = Client.CreateAccountAlias(createRequest);
            Assert.IsNotNull(createResponse.ResponseMetadata.RequestId);
            try
            {
                ListAccountAliasesResponse listResponse = Client.ListAccountAliases(new ListAccountAliasesRequest());
                Assert.IsNotNull(listResponse.ResponseMetadata.RequestId);
                Assert.AreEqual(alias, listResponse.AccountAliases[0]);
            }
            finally
            {
                DeleteAccountAliasResponse deleteResponse = Client.DeleteAccountAlias(new DeleteAccountAliasRequest()
                {
                    AccountAlias = alias
                });
                Assert.IsNotNull(deleteResponse.ResponseMetadata.RequestId);
            }
        }

    }
}
