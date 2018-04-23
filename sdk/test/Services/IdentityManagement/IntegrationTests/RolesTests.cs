using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    [TestClass]
    public class RolesTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        private static IAmazonIdentityManagementService client = Client;

        public static string roleName = "TestRole";
        public static string policyName = "TestPolicy";
        public static string profileName = "TestProfile";
        public static string path = "/";
        public static string
            TEST_ALLOW_POLICY = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
            TEST_DENY_POLICY = @"{""Statement"":[{""Effect"":""Deny"",""Action"":""*"",""Resource"":""*""}]}",
            TEST_ASSUME_ALLOW_POLICY = "{\"Statement\":[{\"Principal\":{\"Service\":[\"ec2.amazonaws.com\"]},\"Effect\":\"Allow\",\"Action\":[\"sts:AssumeRole\"]}]}",
            TEST_ASSUME_DENY_POLICY = "{\"Statement\":[{\"Principal\":{\"Service\":[\"ec2.amazonaws.com\"]},\"Effect\":\"Deny\",\"Action\":[\"sts:AssumeRole\"]}]}";

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestInitialize]
        public void TestSetup()
        {
            //IAMUtil.DeleteUsersAndGroupsInTestNameSpace();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            var roles = GetRoles();
            if (roles.Any(r => string.Equals(r.RoleName, roleName)))
            {
                var rolePolicies = client.ListRolePolicies(new ListRolePoliciesRequest
                {
                    RoleName = roleName
                }).PolicyNames;

                foreach (var rolePolicy in rolePolicies)
                {
                    client.DeleteRolePolicy(new DeleteRolePolicyRequest
                    {
                        RoleName = roleName,
                        PolicyName = rolePolicy
                    });
                }

                client.DeleteRole(new DeleteRoleRequest
                {
                    RoleName = roleName
                });
            }

            var profiles = client.ListInstanceProfiles().InstanceProfiles;
            if (profiles.Any(p => string.Equals(p.InstanceProfileName, profileName)))
            {
                client.DeleteInstanceProfile(new DeleteInstanceProfileRequest
                {
                    InstanceProfileName = profileName
                });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void Roles()
        {
            var roles = GetRoles();
            Assert.IsNotNull(roles);
            int originalCount = roles.Count;

            var newRole = client.CreateRole(new CreateRoleRequest
            {
                RoleName = roleName,
                Path = path,
                AssumeRolePolicyDocument = TEST_ASSUME_ALLOW_POLICY
            }).Role;
            Assert.IsNotNull(newRole);

            roles = GetRoles();
            Assert.IsNotNull(roles);
            Assert.AreEqual(originalCount + 1, roles.Count);

            AssertExtensions.ExpectException(() => client.GetRole(new GetRoleRequest { RoleName = "bar" }));

            var role = client.GetRole(new GetRoleRequest
            {
                RoleName = roleName
            });
            Assert.IsNotNull(role);

            var rolePolicies = client.ListRolePolicies(new ListRolePoliciesRequest
            {
                RoleName = roleName
            }).PolicyNames;
            Assert.AreEqual(0, rolePolicies.Count);

            AssertExtensions.ExpectException(() => client.DeleteRole(new DeleteRoleRequest { RoleName = "bar" }));

            roles = GetRoles();
            Assert.IsNotNull(roles);
            Assert.AreEqual(originalCount + 1, roles.Count);

            client.DeleteRole(new DeleteRoleRequest
            {
                RoleName = roleName
            });

            roles = GetRoles();
            Assert.IsNotNull(roles);
            Assert.AreEqual(originalCount, roles.Count);

            AssertExtensions.ExpectException(() => client.GetRole(new GetRoleRequest { RoleName = roleName }));
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void RolePolicies()
        {
            client.CreateRole(new CreateRoleRequest
            {
                RoleName = roleName,
                Path = path,
                AssumeRolePolicyDocument = TEST_ASSUME_ALLOW_POLICY
            });

            var rolePolicies = client.ListRolePolicies(new ListRolePoliciesRequest
            {
                RoleName = roleName
            }).PolicyNames;
            Assert.AreEqual(0, rolePolicies.Count);

            AssertExtensions.ExpectException(() => client.GetRolePolicy(new GetRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            }));

            AssertExtensions.ExpectException(() => client.DeleteRolePolicy(new DeleteRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            }));

            client.PutRolePolicy(new PutRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName,
                PolicyDocument = TEST_DENY_POLICY
            });

            var roles = GetRoles();
            Assert.IsNotNull(roles);

            var policyResult = client.GetRolePolicy(new GetRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            });

            Assert.IsNotNull(policyResult);
            Assert.AreEqual(roleName, policyResult.RoleName);
            Assert.AreEqual(policyName, policyResult.PolicyName);
            Assert.AreEqual(TEST_DENY_POLICY, Uri.UnescapeDataString(policyResult.PolicyDocument));

            rolePolicies = client.ListRolePolicies(new ListRolePoliciesRequest
            {
                RoleName = roleName
            }).PolicyNames;
            Assert.AreEqual(1, rolePolicies.Count);

            var role = client.GetRole(new GetRoleRequest
            {
                RoleName = roleName
            }).Role;
            Assert.IsNotNull(role);

            client.DeleteRolePolicy(new DeleteRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            });

            AssertExtensions.ExpectException(() => client.GetRolePolicy(new GetRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            }));

            AssertExtensions.ExpectException(() => client.DeleteRolePolicy(new DeleteRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            }));

            rolePolicies = client.ListRolePolicies(new ListRolePoliciesRequest
            {
                RoleName = roleName
            }).PolicyNames;
            Assert.AreEqual(0, rolePolicies.Count);
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void IdentityProfiles()
        {
            var profiles = client.ListInstanceProfiles().InstanceProfiles;
            int originalCount = profiles.Count;

            AssertExtensions.ExpectException(() => client.GetInstanceProfile(new GetInstanceProfileRequest
            {
                InstanceProfileName = profileName
            }));

            var newProfile = client.CreateInstanceProfile(new CreateInstanceProfileRequest
            {
                InstanceProfileName = profileName,
                Path = path
            }).InstanceProfile;
            Assert.IsNotNull(newProfile);

            profiles = client.ListInstanceProfiles().InstanceProfiles;
            Assert.AreEqual(originalCount + 1, profiles.Count);

            var profile = client.GetInstanceProfile(new GetInstanceProfileRequest
            {
                InstanceProfileName = profileName
            }).InstanceProfile;
            Assert.IsNotNull(profile);

            AssertExtensions.ExpectException(() => client.ListInstanceProfilesForRole(new ListInstanceProfilesForRoleRequest
            {
                RoleName = roleName
            }));

            // add role to profile
            var newRole = client.CreateRole(new CreateRoleRequest
            {
                RoleName = roleName,
                Path = path,
                AssumeRolePolicyDocument = TEST_ASSUME_ALLOW_POLICY
            }).Role;
            Assert.IsNotNull(newRole);

            client.AddRoleToInstanceProfile(new AddRoleToInstanceProfileRequest
            {
                InstanceProfileName = profileName,
                RoleName = roleName
            });
            var roleProfiles = client.ListInstanceProfilesForRole(new ListInstanceProfilesForRoleRequest
            {
                RoleName = roleName
            }).InstanceProfiles;
            Assert.AreEqual(1, roleProfiles.Count);

            client.RemoveRoleFromInstanceProfile(new RemoveRoleFromInstanceProfileRequest
            {
                InstanceProfileName = profileName,
                RoleName = roleName
            });
            roleProfiles = client.ListInstanceProfilesForRole(new ListInstanceProfilesForRoleRequest
            {
                RoleName = roleName
            }).InstanceProfiles;
            Assert.AreEqual(0, roleProfiles.Count);

            client.DeleteInstanceProfile(new DeleteInstanceProfileRequest
            {
                InstanceProfileName = profileName
            });

            AssertExtensions.ExpectException(() => client.DeleteInstanceProfile(new DeleteInstanceProfileRequest
            {
                InstanceProfileName = profileName
            }));

            profiles = client.ListInstanceProfiles().InstanceProfiles;
            Assert.AreEqual(originalCount, profiles.Count);
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void AssumeRolePolicyDocument()
        {
            client.CreateRole(new CreateRoleRequest
            {
                RoleName = roleName,
                Path = path,
                AssumeRolePolicyDocument = TEST_ASSUME_ALLOW_POLICY
            });

            var role = client.GetRole(new GetRoleRequest
            {
                RoleName = roleName
            }).Role;
            Assert.IsNotNull(role);
            Assert.IsNotNull(role.AssumeRolePolicyDocument);

            client.UpdateAssumeRolePolicy(new UpdateAssumeRolePolicyRequest
            {
                RoleName = roleName,
                PolicyDocument = TEST_ASSUME_DENY_POLICY
            });

            role = client.GetRole(new GetRoleRequest
            {
                RoleName = roleName
            }).Role;
            Assert.IsNotNull(role);
            Assert.IsNotNull(role.AssumeRolePolicyDocument);
        }

        private List<Role> GetRoles()
        {
            var roles = new List<Role>();
            string nextMarker = null;
            do
            {
                var response = client.ListRoles(new ListRolesRequest
                {
                    Marker = nextMarker
                });
                nextMarker = response.Marker;
                roles.AddRange(response.Roles);
            } while (!string.IsNullOrEmpty(nextMarker));

            return roles;
        }
    }
}
