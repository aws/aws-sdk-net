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
    /// Summary description for PasswordPolicyTests
    /// </summary>
    [TestClass]
    public class PasswordPolicyTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
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
            Client.UpdateAccountPasswordPolicy(request);

            try
            {
                var policy = Client.GetAccountPasswordPolicy().PasswordPolicy;
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

                Client.UpdateAccountPasswordPolicy();

                policy = Client.GetAccountPasswordPolicy().PasswordPolicy;
                Assert.IsFalse(policy.RequireNumbers);
                Assert.IsFalse(policy.RequireSymbols);
            }
            finally
            {
                Client.DeleteAccountPasswordPolicy();
            }
        }
    }
}
