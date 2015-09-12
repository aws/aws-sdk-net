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
    
    public class RolesTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        public static string RoleNamePrefix = "TestRole";
        public static string policyName = "TestPolicy";
        public static string profileName = "TestProfile";
        public static string path = "/";
        public static string
            TEST_ALLOW_POLICY = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
            TEST_DENY_POLICY = @"{""Statement"":[{""Effect"":""Deny"",""Action"":""*"",""Resource"":""*""}]}",
            TEST_ASSUME_ALLOW_POLICY = "{\"Statement\":[{\"Principal\":{\"Service\":[\"ec2.amazonaws.com\"]},\"Effect\":\"Allow\",\"Action\":[\"sts:AssumeRole\"]}]}",
            TEST_ASSUME_DENY_POLICY = "{\"Statement\":[{\"Principal\":{\"Service\":[\"ec2.amazonaws.com\"]},\"Effect\":\"Deny\",\"Action\":[\"sts:AssumeRole\"]}]}";

        void TestCleanup(string roleName)
        {
            var roles = GetRoles();
            if(roles.Exists(r => r.RoleName.Equals(roleName)))
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

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void Roles()
        {
            var roles = GetRoles();
            Assert.NotNull(roles);
            var roleName = UtilityMethods.GenerateName(RoleNamePrefix);
            
            var newRole = Client.CreateRoleAsync(new CreateRoleRequest
            {
                RoleName = roleName,
                Path = path,
                AssumeRolePolicyDocument = TEST_ASSUME_ALLOW_POLICY
            }).Result.Role;
            Assert.NotNull(newRole);

            roles = GetRoles();
            Assert.NotNull(roles);
            
            AssertExtensions.ExpectExceptionAsync(Client.GetRoleAsync(new GetRoleRequest { RoleName = "bar" })).Wait();

            var role = Client.GetRoleAsync(new GetRoleRequest
            {
                RoleName = roleName
            }).Result;
            Assert.NotNull(role);

            var rolePolicies = Client.ListRolePoliciesAsync(new ListRolePoliciesRequest
            {
                RoleName = roleName
            }).Result.PolicyNames;
            Assert.Equal(0, rolePolicies.Count);

            AssertExtensions.ExpectExceptionAsync(Client.DeleteRoleAsync(new DeleteRoleRequest { RoleName = "bar" })).Wait();

            roles = GetRoles();
            Assert.NotNull(roles);
            Assert.True(roles.Exists(r => r.RoleName.Equals(roleName)));

            Client.DeleteRoleAsync(new DeleteRoleRequest
            {
                RoleName = roleName
            }).Wait();

            roles = GetRoles();
            Assert.NotNull(roles);
            Assert.True(!roles.Exists(r => r.RoleName.Equals(roleName)));

            AssertExtensions.ExpectExceptionAsync(Client.GetRoleAsync(new GetRoleRequest { RoleName = roleName })).Wait();
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void RolePolicies()
        {
            var roleName = UtilityMethods.GenerateName(RoleNamePrefix);
            try
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
                Assert.Equal(0, rolePolicies.Count);

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
                Assert.NotNull(roles);

                var policyResult = Client.GetRolePolicyAsync(new GetRolePolicyRequest
                {
                    RoleName = roleName,
                    PolicyName = policyName
                }).Result;

                Assert.NotNull(policyResult);
                Assert.Equal(roleName, policyResult.RoleName);
                Assert.Equal(policyName, policyResult.PolicyName);
                Assert.Equal(TEST_DENY_POLICY, Uri.UnescapeDataString(policyResult.PolicyDocument));

                rolePolicies = Client.ListRolePoliciesAsync(new ListRolePoliciesRequest
                {
                    RoleName = roleName
                }).Result.PolicyNames;
                Assert.Equal(1, rolePolicies.Count);

                var role = Client.GetRoleAsync(new GetRoleRequest
                {
                    RoleName = roleName
                }).Result.Role;
                Assert.NotNull(role);

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
                Assert.Equal(0, rolePolicies.Count);

            }
            finally
            {
                TestCleanup(roleName);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void IdentityProfiles()
        {
            var roleName = UtilityMethods.GenerateName(RoleNamePrefix);
            try
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
                Assert.NotNull(newProfile);

                profiles = Client.ListInstanceProfilesAsync().Result.InstanceProfiles;
                Assert.Equal(originalCount + 1, profiles.Count);

                var profile = Client.GetInstanceProfileAsync(new GetInstanceProfileRequest
                {
                    InstanceProfileName = profileName
                }).Result.InstanceProfile;
                Assert.NotNull(profile);

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
                Assert.NotNull(newRole);

                Client.AddRoleToInstanceProfileAsync(new AddRoleToInstanceProfileRequest
                {
                    InstanceProfileName = profileName,
                    RoleName = roleName
                }).Wait();
                var roleProfiles = Client.ListInstanceProfilesForRoleAsync(new ListInstanceProfilesForRoleRequest
                {
                    RoleName = roleName
                }).Result.InstanceProfiles;
                Assert.Equal(1, roleProfiles.Count);

                Client.RemoveRoleFromInstanceProfileAsync(new RemoveRoleFromInstanceProfileRequest
                {
                    InstanceProfileName = profileName,
                    RoleName = roleName
                }).Wait();
                roleProfiles = Client.ListInstanceProfilesForRoleAsync(new ListInstanceProfilesForRoleRequest
                {
                    RoleName = roleName
                }).Result.InstanceProfiles;
                Assert.Equal(0, roleProfiles.Count);

                Client.DeleteInstanceProfileAsync(new DeleteInstanceProfileRequest
                {
                    InstanceProfileName = profileName
                }).Wait();

                AssertExtensions.ExpectExceptionAsync(Client.DeleteInstanceProfileAsync(new DeleteInstanceProfileRequest
                {
                    InstanceProfileName = profileName
                })).Wait();

                profiles = Client.ListInstanceProfilesAsync().Result.InstanceProfiles;
                Assert.Equal(originalCount, profiles.Count);
            }
            finally
            {
                TestCleanup(roleName);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void AssumeRolePolicyDocument()
        { 
            var roleName = UtilityMethods.GenerateName(RoleNamePrefix);
            try
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
                Assert.NotNull(role);
                Assert.NotNull(role.AssumeRolePolicyDocument);

                Client.UpdateAssumeRolePolicyAsync(new UpdateAssumeRolePolicyRequest
                {
                    RoleName = roleName,
                    PolicyDocument = TEST_ASSUME_DENY_POLICY
                }).Wait();

                role = Client.GetRoleAsync(new GetRoleRequest
                {
                    RoleName = roleName
                }).Result.Role;
                Assert.NotNull(role);
                Assert.NotNull(role.AssumeRolePolicyDocument);
            }
            finally
            {
                TestCleanup(roleName);
            }
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
