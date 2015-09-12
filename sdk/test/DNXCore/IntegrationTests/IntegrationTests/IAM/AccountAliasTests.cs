using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

using Amazon.Runtime;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;



namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    /// <summary>
    /// Summary description for AccountAliasTests
    /// </summary>
    
    public class AccountAliasTests : TestBase<AmazonIdentityManagementServiceClient>
    {        
        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void ListAccessKeys()
        {
            ListAccessKeysResponse response = Client.ListAccessKeysAsync().Result;
            Assert.NotNull(response);
            Assert.NotNull(response.AccessKeyMetadata);
            Assert.NotEqual(0, response.AccessKeyMetadata.Count);
            foreach (var akm in response.AccessKeyMetadata)
            {
                Assert.NotNull(akm);
                Assert.NotNull(akm.AccessKeyId);
                Assert.NotNull(akm.Status);
            }
        }


        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void CreateAccountAlias()
        {
            string alias = "dotnetalias" + DateTime.Now.Ticks;
            CreateAccountAliasRequest createRequest = new CreateAccountAliasRequest()
            {
                AccountAlias = alias
            };

            CreateAccountAliasResponse createResponse = Client.CreateAccountAliasAsync(createRequest).Result;
            Assert.NotNull(createResponse.ResponseMetadata.RequestId);
            try
            {
                ListAccountAliasesResponse listResponse = Client.ListAccountAliasesAsync(new ListAccountAliasesRequest()).Result;
                Assert.NotNull(listResponse.ResponseMetadata.RequestId);
                Assert.Equal(alias, listResponse.AccountAliases[0]);
            }
            finally
            {
                DeleteAccountAliasResponse deleteResponse = Client.DeleteAccountAliasAsync(new DeleteAccountAliasRequest()
                {
                    AccountAlias = alias
                }).Result;
                Assert.NotNull(deleteResponse.ResponseMetadata.RequestId);
            }
        }

    }
}
