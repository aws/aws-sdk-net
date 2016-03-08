using System;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using AWSSDK.Tests.Framework;
using NUnit.Framework;
using System.Threading;
using Amazon.Runtime;
using System.Collections.Generic;

namespace AWSSDK.IntegrationTests.IdentityManagement
{
    [TestFixture(TestOf = typeof(RolesTests))]
    [Category("Integration")]

    class RolesTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        public static string roleName = "UnityTestRole";
        public static string policyName = "UnityTestPolicy";
        public static string profileName = "UnityTestProfile";
        public static string path = "/";
        public static string
            TEST_ALLOW_POLICY = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
            TEST_DENY_POLICY = @"{""Statement"":[{""Effect"":""Deny"",""Action"":""*"",""Resource"":""*""}]}",
            TEST_ASSUME_ALLOW_POLICY = "{\"Statement\":[{\"Principal\":{\"Service\":[\"ec2.amazonaws.com\"]},\"Effect\":\"Allow\",\"Action\":[\"sts:AssumeRole\"]}]}",
            TEST_ASSUME_DENY_POLICY = "{\"Statement\":[{\"Principal\":{\"Service\":[\"ec2.amazonaws.com\"]},\"Effect\":\"Deny\",\"Action\":[\"sts:AssumeRole\"]}]}";


        [TearDown]
        [OneTimeSetUp]
        public void CleanupRoles()
        {
            var roles = GetRoles();
            bool roleExists = false;
            foreach (var role in roles)
            {
                if (string.Equals(role.RoleName, roleName))
                {
                    roleExists = true;
                    break;
                }
            }

            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            if (roleExists)
            {
                List<string> rolePolicies = null;
                Client.ListRolePoliciesAsync(new ListRolePoliciesRequest
                {
                    RoleName = roleName
                }, (response) =>
                {
                    responseException = response.Exception;
                    if (responseException == null)
                    {
                        rolePolicies = response.Response.PolicyNames;
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);

                foreach (var rolePolicy in rolePolicies)
                {
                    Client.DeleteRolePolicyAsync(new DeleteRolePolicyRequest
                    {
                        RoleName = roleName,
                        PolicyName = rolePolicy
                    }, (response) =>
                    {
                        responseException = response.Exception;
                        ars.Set();
                    }, new AsyncOptions { ExecuteCallbackOnMainThread = false });

                    ars.WaitOne();
                    Assert.IsNull(responseException);
                }

                Client.DeleteRoleAsync(new DeleteRoleRequest
                {
                    RoleName = roleName
                }, (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);
            }

            List<InstanceProfile> profiles = null;
            Client.ListInstanceProfilesAsync((response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    profiles = response.Response.InstanceProfiles;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            bool profileExists = false;

            foreach (var profile in profiles)
            {
                if (profile.InstanceProfileName == profileName)
                {
                    profileExists = true;
                    break;
                }
            }

            if (profileExists)
            {
                Client.DeleteInstanceProfileAsync(new DeleteInstanceProfileRequest
                {
                    InstanceProfileName = profileName
                }, (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);
            }
        }

        [Test]
        [Category("WWW")]
        public void Roles()
        {
            var roles = GetRoles();
            Assert.IsNotNull(roles);
            int originalCount = roles.Count;

            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            Role newRole = null;
            Client.CreateRoleAsync(new CreateRoleRequest
            {
                RoleName = roleName,
                Path = path,
                AssumeRolePolicyDocument = TEST_ASSUME_ALLOW_POLICY
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    newRole = response.Response.Role;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            Assert.IsNotNull(newRole);

            roles = GetRoles();
            Assert.IsNotNull(roles);
            Assert.AreEqual(originalCount + 1, roles.Count);

            Client.GetRoleAsync(new GetRoleRequest
            {
                RoleName = "IDontExist"
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNotNull(responseException);
            Utils.AssertTrue(responseException is NoSuchEntityException);


            Role gotRole = null;

            Client.GetRoleAsync(new GetRoleRequest
             {
                 RoleName = roleName
             }, (response) =>
             {
                 responseException = response.Exception;
                 if (responseException == null)
                 {
                     gotRole = response.Response.Role;
                 }
                 ars.Set();
             }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(gotRole);

            List<string> rolePolicies = null;
            Client.ListRolePoliciesAsync(new ListRolePoliciesRequest
             {
                 RoleName = roleName
             }, (response) =>
             {
                 responseException = response.Exception;
                 if (responseException == null)
                 {
                     rolePolicies = response.Response.PolicyNames;
                 }
                 ars.Set();
             }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual(0, rolePolicies.Count);

            Client.DeleteRoleAsync(new DeleteRoleRequest
            {
                RoleName = "IDontExist"
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNotNull(responseException);
            Utils.AssertTrue(responseException is NoSuchEntityException);

            roles = GetRoles();
            Assert.IsNotNull(roles);
            Assert.AreEqual(originalCount + 1, roles.Count);

            Client.DeleteRoleAsync(new DeleteRoleRequest
            {
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            roles = GetRoles();
            Assert.IsNotNull(roles);
            Assert.AreEqual(originalCount, roles.Count);

            Client.GetRoleAsync(new GetRoleRequest
            {
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNotNull(responseException);
            Utils.AssertTrue(responseException is NoSuchEntityException);
        }

        [Test]
        [Category("WWW")]
        public void RolePolicies()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            Client.CreateRoleAsync(new CreateRoleRequest
            {
                RoleName = roleName,
                Path = path,
                AssumeRolePolicyDocument = TEST_ASSUME_ALLOW_POLICY
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            List<string> rolePolicies = null;
            Client.ListRolePoliciesAsync(new ListRolePoliciesRequest
            {
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    rolePolicies = response.Response.PolicyNames;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual(0, rolePolicies.Count);

            Client.GetRolePolicyAsync(new GetRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNotNull(responseException);
            Utils.AssertTrue(responseException is NoSuchEntityException);

            Client.DeleteRolePolicyAsync(new DeleteRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNotNull(responseException);
            Utils.AssertTrue(responseException is NoSuchEntityException);

            Client.PutRolePolicyAsync(new PutRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName,
                PolicyDocument = TEST_DENY_POLICY
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            var roles = GetRoles();
            Assert.IsNotNull(roles);

            string gotRoleName = null;
            string gotPolicyName = null;
            string gotPolicyDocument = null;
            Client.GetRolePolicyAsync(new GetRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    gotRoleName = response.Response.RoleName;
                    gotPolicyName = response.Response.PolicyName;
                    gotPolicyDocument = response.Response.PolicyDocument;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            Assert.AreEqual(roleName, gotRoleName);
            Assert.AreEqual(policyName, gotPolicyName);
            Assert.AreEqual(TEST_DENY_POLICY, Uri.UnescapeDataString(gotPolicyDocument));

            Client.ListRolePoliciesAsync(new ListRolePoliciesRequest
            {
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    rolePolicies = response.Response.PolicyNames;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual(1, rolePolicies.Count);

            Role gotRole = null;
            Client.GetRoleAsync(new GetRoleRequest
            {
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    gotRole = response.Response.Role;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(gotRole);

            Client.DeleteRolePolicyAsync(new DeleteRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();

            Client.GetRolePolicyAsync(new GetRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNotNull(responseException);
            Utils.AssertTrue(responseException is NoSuchEntityException);

            Client.DeleteRolePolicyAsync(new DeleteRolePolicyRequest
            {
                RoleName = roleName,
                PolicyName = policyName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNotNull(responseException);
            Utils.AssertTrue(responseException is NoSuchEntityException);

            Client.ListRolePoliciesAsync(new ListRolePoliciesRequest
            {
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    rolePolicies = response.Response.PolicyNames;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual(0, rolePolicies.Count);
        }

        [Test]
        [Category("WWW")]
        public void IdentityProfiles()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            List<InstanceProfile> profiles = null;
            Client.ListInstanceProfilesAsync((response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    profiles = response.Response.InstanceProfiles;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            int originalCount = profiles.Count;

            Client.GetInstanceProfileAsync(new GetInstanceProfileRequest
            {
                InstanceProfileName = profileName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNotNull(responseException);
            Utils.AssertTrue(responseException is NoSuchEntityException);

            InstanceProfile newProfile = null;
            Client.CreateInstanceProfileAsync(new CreateInstanceProfileRequest
            {
                InstanceProfileName = profileName,
                Path = path
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    newProfile = response.Response.InstanceProfile;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(newProfile);

            Client.ListInstanceProfilesAsync((response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    profiles = response.Response.InstanceProfiles;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual(originalCount + 1, profiles.Count);

            InstanceProfile profile = null;
            Client.GetInstanceProfileAsync(new GetInstanceProfileRequest
            {
                InstanceProfileName = profileName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    profile = response.Response.InstanceProfile;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(profile);

            Client.ListInstanceProfilesForRoleAsync(new ListInstanceProfilesForRoleRequest
            {
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNotNull(responseException);
            Utils.AssertTrue(responseException is NoSuchEntityException);

            // add role to profile
            Role newRole = null;
            Client.CreateRoleAsync(new CreateRoleRequest
            {
                RoleName = roleName,
                Path = path,
                AssumeRolePolicyDocument = TEST_ASSUME_ALLOW_POLICY
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    newRole = response.Response.Role;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(newRole);

            Client.AddRoleToInstanceProfileAsync(new AddRoleToInstanceProfileRequest
            {
                InstanceProfileName = profileName,
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            List<InstanceProfile> roleProfiles = null;
            Client.ListInstanceProfilesForRoleAsync(new ListInstanceProfilesForRoleRequest
            {
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    roleProfiles = response.Response.InstanceProfiles;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual(1, roleProfiles.Count);

            Client.RemoveRoleFromInstanceProfileAsync(new RemoveRoleFromInstanceProfileRequest
            {
                InstanceProfileName = profileName,
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            Client.ListInstanceProfilesForRoleAsync(new ListInstanceProfilesForRoleRequest
            {
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    roleProfiles = response.Response.InstanceProfiles;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual(0, roleProfiles.Count);

            Client.DeleteInstanceProfileAsync(new DeleteInstanceProfileRequest
            {
                InstanceProfileName = profileName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            Client.DeleteInstanceProfileAsync(new DeleteInstanceProfileRequest
            {
                InstanceProfileName = profileName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNotNull(responseException);
            Utils.AssertTrue(responseException is NoSuchEntityException);

            Client.ListInstanceProfilesAsync((response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    profiles = response.Response.InstanceProfiles;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual(originalCount, profiles.Count);
        }

        [Test]
        [Category("IAM")]
        [Category("WWW")]
        public void AssumeRolePolicyDocument()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            Client.CreateRoleAsync(new CreateRoleRequest
            {
                RoleName = roleName,
                Path = path,
                AssumeRolePolicyDocument = TEST_ASSUME_ALLOW_POLICY
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            Role gotRole = null;
            Client.GetRoleAsync(new GetRoleRequest
            {
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    gotRole = response.Response.Role;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(gotRole);
            Assert.IsNotNull(gotRole.AssumeRolePolicyDocument);

            Client.UpdateAssumeRolePolicyAsync(new UpdateAssumeRolePolicyRequest
            {
                RoleName = roleName,
                PolicyDocument = TEST_ASSUME_DENY_POLICY
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            Client.GetRoleAsync(new GetRoleRequest
            {
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    gotRole = response.Response.Role;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(gotRole);
            Assert.IsNotNull(gotRole.AssumeRolePolicyDocument);

        }

        private List<Role> GetRoles()
        {
            var roles = new List<Role>();
            string nextMarker = null;
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            do
            {
                Client.ListRolesAsync(new ListRolesRequest
                {
                    Marker = nextMarker
                }, (response) =>
                {
                    responseException = response.Exception;
                    if (responseException == null)
                    {
                        nextMarker = response.Response.Marker;
                        roles.AddRange(response.Response.Roles);
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);
            } while (!string.IsNullOrEmpty(nextMarker));

            return roles;
        }
    }
}
