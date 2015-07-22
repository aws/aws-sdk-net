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
    /// Summary description for PasswordPolicyTests
    /// </summary>
    [TestFixture]
    public class PasswordPolicyTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [Test]
        [Category("IAM")]
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
                Assert.AreEqual(request.RequireNumbers, policy.RequireNumbers);
                Assert.AreEqual(request.RequireSymbols, policy.RequireSymbols);
                Assert.AreEqual(request.MinimumPasswordLength, policy.MinimumPasswordLength);
                Assert.AreEqual(request.RequireLowercaseCharacters, policy.RequireLowercaseCharacters);
                Assert.AreEqual(request.RequireUppercaseCharacters, policy.RequireUppercaseCharacters);
                Assert.AreEqual(request.AllowUsersToChangePassword, policy.AllowUsersToChangePassword);
                Assert.AreEqual(request.PasswordReusePrevention, policy.PasswordReusePrevention);
                Assert.AreEqual(request.MaxPasswordAge, policy.MaxPasswordAge);
                Assert.AreEqual(request.HardExpiry, policy.HardExpiry);
                //Assert.IsTrue(policy.ExpirePasswords);

                Client.UpdateAccountPasswordPolicyAsync().Wait();

                policy = Client.GetAccountPasswordPolicyAsync().Result.PasswordPolicy;
                Assert.IsFalse(policy.RequireNumbers);
                Assert.IsFalse(policy.RequireSymbols);
            }
            finally
            {
                Client.DeleteAccountPasswordPolicyAsync().Wait();
            }
        }
    }
}
