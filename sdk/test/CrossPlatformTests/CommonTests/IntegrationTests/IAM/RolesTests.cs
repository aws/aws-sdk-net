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
    [TestFixture]
    public class RolesTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        public static string roleName = "TestRole";
        public static string policyName = "TestPolicy";
        public static string profileName = "TestProfile";
        public static string path = "/";
        public static string
            TEST_ALLOW_POLICY = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
            TEST_DENY_POLICY = @"{""Statement"":[{""Effect"":""Deny"",""Action"":""*"",""Resource"":""*""}]}",
            TEST_ASSUME_ALLOW_POLICY = "{\"Statement\":[{\"Principal\":{\"Service\":[\"ec2.amazonaws.com\"]},\"Effect\":\"Allow\",\"Action\":[\"sts:AssumeRole\"]}]}",
            TEST_ASSUME_DENY_POLICY = "{\"Statement\":[{\"Principal\":{\"Service\":[\"ec2.amazonaws.com\"]},\"Effect\":\"Deny\",\"Action\":[\"sts:AssumeRole\"]}]}";

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [SetUp]
        public void TestSetup()
        {
            //IAMUtil.DeleteUsersAndGroupsInTestNameSpace();
        }

        [TearDown]
        public void TestCleanup()
        {
            var roles = GetRoles();
            if (roles.Any(r => string.Equals(r.RoleName, roleName)))
            {
                var rolePolicies = Client.ListRolePoliciesAsync(new ListRolePoliciesRequest
                {
                    RoleName = roleName
                }).Result.PolicyNames;

                foreach (var rolePolicy in rolePolicies)
                {
                    Client.DeleteRolePolicyAsync(new DeleteRolePolicyRequest
                    {
                        RoleName = roleName,
                        PolicyName = rolePolicy
                    }).Wait();
                }

                Client.DeleteRoleAsync(new DeleteRoleRequest
                {
                    RoleName = roleName
                }).Wait();
            }

            var profiles = Client.ListInstanceProfilesAsync().Result.InstanceProfiles;
            if (profiles.Any(p => string.Equals(p.InstanceProfileName, profileName)))
            {
                Client.DeleteInstanceProfileAsync(new DeleteInstanceProfileRequest
                {
                    InstanceProfileName = profileName
                }).Wait();
            }
        }

        [Test]
        [Category("IAM")]
        public void Roles()
        {
            var roles = GetRoles();
            Assert.IsNotNull(roles);
            int originalCount = roles.Count;

            var newRole = Client.CreateRoleAsync(new CreateRoleRequest
            {
                RoleName = roleName,
                Path = path,
                AssumeRolePolicyDocument = TEST_ASSUME_ALLOW_POLICY
            }).Result.Role;
            Assert.IsNotNull(newRole);

            roles = GetRoles();
            Assert.IsNotNull(roles);
            Assert.AreEqual(originalCount + 1, roles.Count);

            AssertExtensions.ExpectExceptionAsync(Client.GetRoleAsync(new GetRoleRequest { RoleName = "bar" })).Wait();

            var role = Client.GetRoleAsync(new GetRoleRequest
            {
                RoleName = roleName
            }).Result;
            Assert.IsNotNull(role);

            var rolePolicies = Client.ListRolePoliciesAsync(new ListRolePoliciesRequest
            {
                RoleName = roleName
            }).Result.PolicyNames;
            Assert.AreEqual(0, rolePolicies.Count);

            AssertExtensions.ExpectExceptionAsync(Client.DeleteRoleAsync(new DeleteRoleRequest { RoleName = "bar" })).Wait();

            roles = GetRoles();
            Assert.IsNotNull(roles);
            Assert.AreEqual(originalCount + 1, roles.Count);

            Client.DeleteRoleAsync(new DeleteRoleRequest
            {
                RoleName = roleName
            }).Wait();

            roles = GetRoles();
            Assert.IsNotNull(roles);
            Assert.AreEqual(originalCount, roles.Count);

            AssertExtensions.ExpectExceptionAsync(Client.GetRoleAsync(new GetRoleRequest { RoleName = roleName })).Wait();
        }

        [Test]
        [Category("IAM")]
        public void RolePolicies()
        {
            Client.CreateRoleAsync(new CreateRoleRequest
            {
                RoleName = roleName,
                Path = path,
                AssumeRolePolicyDocument = TEST_ASSUME_ALLOW_POLICY
            }).Wait();

            var rolePolicies = Client.ListRolePoliciesAsync(new ListRolePoliciesRequest
            {
                RoleName = roleName
            }).Result.PolicyNames;
            Assert.AreEqual(0, rolePolicies.Count);

            AssertExtensions.ExpectExceptionAsync(Client.GetRolePolicyAsync(new GetRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            })).Wait();

            AssertExtensions.ExpectExceptionAsync(Client.DeleteRolePolicyAsync(new DeleteRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            })).Wait();

            Client.PutRolePolicyAsync(new PutRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName,
                PolicyDocument = TEST_DENY_POLICY
            }).Wait();

            var roles = GetRoles();
            Assert.IsNotNull(roles);

            var policyResult = Client.GetRolePolicyAsync(new GetRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            }).Result;

            Assert.IsNotNull(policyResult);
            Assert.AreEqual(roleName, policyResult.RoleName);
            Assert.AreEqual(policyName, policyResult.PolicyName);
            Assert.AreEqual(TEST_DENY_POLICY, Uri.UnescapeDataString(policyResult.PolicyDocument));

            rolePolicies = Client.ListRolePoliciesAsync(new ListRolePoliciesRequest
            {
                RoleName = roleName
            }).Result.PolicyNames;
            Assert.AreEqual(1, rolePolicies.Count);

            var role = Client.GetRoleAsync(new GetRoleRequest
            {
                RoleName = roleName
            }).Result.Role;
            Assert.IsNotNull(role);

            Client.DeleteRolePolicyAsync(new DeleteRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            }).Wait();

            AssertExtensions.ExpectExceptionAsync(Client.GetRolePolicyAsync(new GetRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            })).Wait();

            AssertExtensions.ExpectExceptionAsync(Client.DeleteRolePolicyAsync(new DeleteRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            })).Wait();

            rolePolicies = Client.ListRolePoliciesAsync(new ListRolePoliciesRequest
            {
                RoleName = roleName
            }).Result.PolicyNames;
            Assert.AreEqual(0, rolePolicies.Count);
        }

        [Test]
        [Category("IAM")]
        public void IdentityProfiles()
        {
            var profiles = Client.ListInstanceProfilesAsync().Result.InstanceProfiles;
            int originalCount = profiles.Count;

            AssertExtensions.ExpectExceptionAsync(Client.GetInstanceProfileAsync(new GetInstanceProfileRequest
            {
                InstanceProfileName = profileName
            })).Wait();

            var newProfile = Client.CreateInstanceProfileAsync(new CreateInstanceProfileRequest
            {
                InstanceProfileName = profileName,
                Path = path
            }).Result.InstanceProfile;
            Assert.IsNotNull(newProfile);

            profiles = Client.ListInstanceProfilesAsync().Result.InstanceProfiles;
            Assert.AreEqual(originalCount + 1, profiles.Count);

            var profile = Client.GetInstanceProfileAsync(new GetInstanceProfileRequest
            {
                InstanceProfileName = profileName
            }).Result.InstanceProfile;
            Assert.IsNotNull(profile);

            AssertExtensions.ExpectExceptionAsync(Client.ListInstanceProfilesForRoleAsync(new ListInstanceProfilesForRoleRequest
            {
                RoleName = roleName
            })).Wait();

            // add role to profile
            var newRole = Client.CreateRoleAsync(new CreateRoleRequest
            {
                RoleName = roleName,
                Path = path,
                AssumeRolePolicyDocument = TEST_ASSUME_ALLOW_POLICY
            }).Result.Role;
            Assert.IsNotNull(newRole);

            Client.AddRoleToInstanceProfileAsync(new AddRoleToInstanceProfileRequest
            {
                InstanceProfileName = profileName,
                RoleName = roleName
            }).Wait();
            var roleProfiles = Client.ListInstanceProfilesForRoleAsync(new ListInstanceProfilesForRoleRequest
            {
                RoleName = roleName
            }).Result.InstanceProfiles;
            Assert.AreEqual(1, roleProfiles.Count);

            Client.RemoveRoleFromInstanceProfileAsync(new RemoveRoleFromInstanceProfileRequest
            {
                InstanceProfileName = profileName,
                RoleName = roleName
            }).Wait();
            roleProfiles = Client.ListInstanceProfilesForRoleAsync(new ListInstanceProfilesForRoleRequest
            {
                RoleName = roleName
            }).Result.InstanceProfiles;
            Assert.AreEqual(0, roleProfiles.Count);

            Client.DeleteInstanceProfileAsync(new DeleteInstanceProfileRequest
            {
                InstanceProfileName = profileName
            }).Wait();

            AssertExtensions.ExpectExceptionAsync(Client.DeleteInstanceProfileAsync(new DeleteInstanceProfileRequest
            {
                InstanceProfileName = profileName
            })).Wait();

            profiles = Client.ListInstanceProfilesAsync().Result.InstanceProfiles;
            Assert.AreEqual(originalCount, profiles.Count);
        }

        [Test]
        [Category("IAM")]
        public void AssumeRolePolicyDocument()
        {
            Client.CreateRoleAsync(new CreateRoleRequest
            {
                RoleName = roleName,
                Path = path,
                AssumeRolePolicyDocument = TEST_ASSUME_ALLOW_POLICY
            }).Wait();

            var role = Client.GetRoleAsync(new GetRoleRequest
            {
                RoleName = roleName
            }).Result.Role;
            Assert.IsNotNull(role);
            Assert.IsNotNull(role.AssumeRolePolicyDocument);

            Client.UpdateAssumeRolePolicyAsync(new UpdateAssumeRolePolicyRequest
            {
                RoleName = roleName,
                PolicyDocument = TEST_ASSUME_DENY_POLICY
            }).Wait();

            role = Client.GetRoleAsync(new GetRoleRequest
            {
                RoleName = roleName
            }).Result.Role;
            Assert.IsNotNull(role);
            Assert.IsNotNull(role.AssumeRolePolicyDocument);
        }

        private List<Role> GetRoles()
        {
            var roles = new List<Role>();
            string nextMarker = null;
            do
            {
                var response = Client.ListRolesAsync(new ListRolesRequest
                {
                    Marker = nextMarker
                }).Result;
                nextMarker = response.Marker;
                roles.AddRange(response.Roles);
            } while (!string.IsNullOrEmpty(nextMarker));

            return roles;
        }
    }
}
