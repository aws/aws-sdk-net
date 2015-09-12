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
    /// Summary description for PasswordPolicyTests
    /// </summary>
    
    public class PasswordPolicyTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        //[Fact]
        //[Trait(CategoryAttribute,"IAM")]
        public void CRUDPasswordPolicy()
        {
            var request = new UpdateAccountPasswordPolicyRequest
            {
                RequireNumbers = true,
                RequireSymbols = true,
                MinimumPasswordLength = 8,
                RequireLowercaseCharacters = true,
                RequireUppercaseCharacters = true,

                AllowUsersToChangePassword = true,
                PasswordReusePrevention = 1,
                MaxPasswordAge = 90,
                HardExpiry = true
            };
            Client.UpdateAccountPasswordPolicyAsync(request).Wait();

            try
            {
                var policy = Client.GetAccountPasswordPolicyAsync().Result.PasswordPolicy;
                Assert.Equal(request.RequireNumbers, policy.RequireNumbers);
                Assert.Equal(request.RequireSymbols, policy.RequireSymbols);
                Assert.Equal(request.MinimumPasswordLength, policy.MinimumPasswordLength);
                Assert.Equal(request.RequireLowercaseCharacters, policy.RequireLowercaseCharacters);
                Assert.Equal(request.RequireUppercaseCharacters, policy.RequireUppercaseCharacters);
                Assert.Equal(request.AllowUsersToChangePassword, policy.AllowUsersToChangePassword);
                Assert.Equal(request.PasswordReusePrevention, policy.PasswordReusePrevention);
                Assert.Equal(request.MaxPasswordAge, policy.MaxPasswordAge);
                Assert.Equal(request.HardExpiry, policy.HardExpiry);
                //Assert.True(policy.ExpirePasswords);

                Client.UpdateAccountPasswordPolicyAsync().Wait();

                policy = Client.GetAccountPasswordPolicyAsync().Result.PasswordPolicy;
                Assert.False(policy.RequireNumbers);
                Assert.False(policy.RequireSymbols);
            }
            finally
            {
                Client.DeleteAccountPasswordPolicyAsync().Wait();
            }
        }
    }
}
