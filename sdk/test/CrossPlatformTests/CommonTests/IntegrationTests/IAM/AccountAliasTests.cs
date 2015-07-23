using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using CommonTests.Framework;

using Amazon.Runtime;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;



namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    /// <summary>
    /// Summary description for AccountAliasTests
    /// </summary>
    [TestFixture]
    public class AccountAliasTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [Test]
        [Category("IAM")]
        public void ListAccessKeys()
        {
            ListAccessKeysResponse response = Client.ListAccessKeysAsync().Result;
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


        [Test]
        [Category("IAM")]
        public void CreateAccountAlias()
        {
            string alias = "dotnetalias" + DateTime.Now.Ticks;
            CreateAccountAliasRequest createRequest = new CreateAccountAliasRequest()
            {
                AccountAlias = alias
            };

            CreateAccountAliasResponse createResponse = Client.CreateAccountAliasAsync(createRequest).Result;
            Assert.IsNotNull(createResponse.ResponseMetadata.RequestId);
            try
            {
                ListAccountAliasesResponse listResponse = Client.ListAccountAliasesAsync(new ListAccountAliasesRequest()).Result;
                Assert.IsNotNull(listResponse.ResponseMetadata.RequestId);
                Assert.AreEqual(alias, listResponse.AccountAliases[0]);
            }
            finally
            {
                DeleteAccountAliasResponse deleteResponse = Client.DeleteAccountAliasAsync(new DeleteAccountAliasRequest()
                {
                    AccountAlias = alias
                }).Result;
                Assert.IsNotNull(deleteResponse.ResponseMetadata.RequestId);
            }
        }

    }
}
