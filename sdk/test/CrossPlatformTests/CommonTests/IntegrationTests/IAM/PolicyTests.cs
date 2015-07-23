using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using CommonTests.Framework;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using System.Threading;
using System.Net;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    [TestFixture]
    public class PolicyTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        public static string 
            TEST_ALLOW_POLICY = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
            TEST_VERSIONED_POLICY =  @"{""Version"": ""2012-10-17"",""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
            TEST_DENY_POLICY  = @"{""Statement"":[{""Effect"":""Deny"",""Action"":""*"",""Resource"":""*""}]}";

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [SetUp]
        public void TestSetup()
        {
            IAMUtil.DeleteUsersAndGroupsInTestNameSpace(Client);
        }

        [Test]
        [Category("IAM")]
        public void TestPutGetUserPolicy()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string policyName = "test-policy-" + DateTime.Now.Ticks;

            try
            {
                Client.PutUserPolicyAsync(
                    new PutUserPolicyRequest()
                    {
                        UserName = username,
                        PolicyName = policyName,
                        PolicyDocument = TEST_ALLOW_POLICY
                    }).Wait();

                GetUserPolicyResponse response =
                    Client.GetUserPolicyAsync(new GetUserPolicyRequest() { UserName = username, PolicyName = policyName }).Result;

                Assert.AreEqual(username, response.UserName);
                Assert.AreEqual(policyName, response.PolicyName);
                Assert.AreEqual(TEST_ALLOW_POLICY, WebUtility.UrlDecode(response.PolicyDocument));
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [Test]
        [Category("IAM")]
        public void TestPutGetGroupPolicy()
        {
            string groupname = "sdk-testgroup-" + DateTime.Now.Ticks;
            string policyName = "strong-password";

            try
            {
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH }).Wait();

                Client.PutGroupPolicyAsync(
                    new PutGroupPolicyRequest()
                    {
                        GroupName = groupname,
                        PolicyName = policyName,
                        PolicyDocument = TEST_ALLOW_POLICY
                    }).Wait();

                GetGroupPolicyResponse response =
                    Client.GetGroupPolicyAsync(new GetGroupPolicyRequest() { GroupName = groupname, PolicyName = policyName }).Result;

                Assert.AreEqual(groupname,  response.GroupName);
                Assert.AreEqual(policyName, response.PolicyName);
                Assert.AreEqual(TEST_ALLOW_POLICY, WebUtility.UrlDecode(response.PolicyDocument));
            }
            finally
            {
                Client.DeleteGroupPolicyAsync(new DeleteGroupPolicyRequest() { GroupName = groupname, PolicyName = policyName }).Wait();
            }
        }

        [Test]
        [Category("IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestGetNonExistantPolicy()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string policyName = "test-policy-" + DateTime.Now.Ticks;

            try
            {
                GetUserPolicyResponse response =
                    Client.GetUserPolicyAsync(new GetUserPolicyRequest() { UserName = username, PolicyName = policyName }).Result;
            }
            catch (AggregateException ae)
            {
                AssertExtensions.VerifyException<NoSuchEntityException>(ae);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client);
            }
        }

        [Test]
        [Category("IAM")]
        public void TestListUserPolicies()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string[] policyNames = new string[3];
            int nPolicies = 3;

            try
            {
                for (int i = 0; i < nPolicies; i++)
                {
                    policyNames[i] = "test-policy-" + DateTime.Now.Ticks + i;
                    Client.PutUserPolicyAsync(new PutUserPolicyRequest()
                    {
                        UserName = username,
                        PolicyName = policyNames[i],
                        PolicyDocument = TEST_ALLOW_POLICY
                    }).Wait();
                }

                ListUserPoliciesResponse response =
                    Client.ListUserPoliciesAsync(new ListUserPoliciesRequest() { UserName = username }).Result;

                Assert.AreEqual(nPolicies, response.PolicyNames.Count());

                int matches = 0;
                foreach (string name in response.PolicyNames)
                {
                    for (int i = 0; i < nPolicies; i++)
                    {
                        if (name.Equals(policyNames[i]))
                            matches |= (1 << i);
                    }
                }
                Assert.AreEqual((1 << nPolicies) - 1, matches);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [Test]
        [Category("IAM")]
        public void TestListGroupPolicies()
        {
            string grpname = "sdk-testgroup-" + DateTime.Now.Ticks;
            string[] policyNames = new string[3];
            int nPolicies = 3;

            try
            {
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = grpname, Path = IAMUtil.TEST_PATH }).Wait();

                for (int i = 0; i < nPolicies; i++)
                {
                    policyNames[i] = "test-policy-" + DateTime.Now.Ticks + i;
                    Client.PutGroupPolicyAsync(new PutGroupPolicyRequest()
                    {
                        GroupName = grpname,
                        PolicyName = policyNames[i],
                        PolicyDocument = TEST_ALLOW_POLICY
                    }).Wait();
                }

                ListGroupPoliciesResponse response =
                    Client.ListGroupPoliciesAsync(new ListGroupPoliciesRequest() { GroupName = grpname }).Result;

                Assert.AreEqual(nPolicies, response.PolicyNames.Count());

                int matches = 0;
                foreach (string name in response.PolicyNames)
                {
                    for (int i = 0; i < nPolicies; i++)
                    {
                        if (name.Equals(policyNames[i]))
                            matches |= (1 << i);
                    }
                }
                Assert.AreEqual((1 << nPolicies) - 1, matches);
            }
            finally
            {
                for (int i = 0; i < nPolicies; i++)
                {
                    Client.DeleteGroupPolicyAsync(new DeleteGroupPolicyRequest() { GroupName = grpname, PolicyName = policyNames[i] }).Wait();
                }

                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = grpname }).Wait();
            }
        }

        [Test]
        [Category("IAM")]
        public void TestListUserPoliciesPaging()
        {
            string username = IAMUtil.CreateTestUser(Client);
            int nPolicies = 4;
            string[] policyNames = new string[nPolicies];

            try
            {
                for (int i = 0; i < nPolicies; i++)
                {
                    policyNames[i] = "test-policy-" + DateTime.Now.Ticks + i;
                    Client.PutUserPolicyAsync(new PutUserPolicyRequest()
                    {
                        UserName = username,
                        PolicyName = policyNames[i],
                        PolicyDocument = TEST_ALLOW_POLICY
                    }).Wait();
                }

                ListUserPoliciesResponse response =
                    Client.ListUserPoliciesAsync(new ListUserPoliciesRequest() { UserName = username, MaxItems = 2 }).Result;

                Assert.AreEqual(2, response.PolicyNames.Count());
                Assert.AreEqual(true, response.IsTruncated);
                string marker = response.Marker;

                int matches = 0;
                foreach (string name in response.PolicyNames)
                {
                    for (int i = 0; i < nPolicies; i++)
                    {
                        if (name.Equals(policyNames[i]))
                            matches |= (1 << i);
                    }
                }

                response = Client.ListUserPoliciesAsync(new ListUserPoliciesRequest() { UserName = username, Marker = marker }).Result;

                Assert.AreEqual(nPolicies - 2, response.PolicyNames.Count());
                Assert.AreEqual(false, response.IsTruncated);

                foreach (string name in response.PolicyNames)
                {
                    for (int i = 0; i < nPolicies; i++)
                    {
                        if (name.Equals(policyNames[i]))
                            matches |= (1 << i);
                    }
                }

                Assert.AreEqual((1 << nPolicies) - 1, matches);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [Test]
        [Category("IAM")]
        public void TestListGroupPoliciesPaging()
        {
            string grpname = "sdk-testgroup-" + DateTime.Now.Ticks;
            int nPolicies = 3;
            string[] policyNames = new string[nPolicies];

            try
            {
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = grpname, Path = IAMUtil.TEST_PATH }).Wait();

                for (int i = 0; i < nPolicies; i++)
                {
                    policyNames[i] = "test-policy-" + DateTime.Now.Ticks + i;
                    Client.PutGroupPolicyAsync(new PutGroupPolicyRequest()
                    {
                        GroupName = grpname,
                        PolicyName = policyNames[i],
                        PolicyDocument = TEST_ALLOW_POLICY
                    }).Wait();
                }

                ListGroupPoliciesResponse response =
                    Client.ListGroupPoliciesAsync(new ListGroupPoliciesRequest() { GroupName = grpname, MaxItems = 2 }).Result;

                Assert.AreEqual(2, response.PolicyNames.Count());
                Assert.AreEqual(true, response.IsTruncated);
                string marker = response.Marker;

                int matches = 0;
                foreach (string name in response.PolicyNames)
                {
                    for (int i = 0; i < nPolicies; i++)
                    {
                        if (name.Equals(policyNames[i]))
                            matches |= (1 << i);
                    }
                }

                response = Client.ListGroupPoliciesAsync(new ListGroupPoliciesRequest() { GroupName = grpname, Marker = marker }).Result;

                Assert.AreEqual(nPolicies - 2, response.PolicyNames.Count());
                Assert.AreEqual(false, response.IsTruncated);

                foreach (string name in response.PolicyNames)
                {
                    for (int i = 0; i < nPolicies; i++)
                    {
                        if (name.Equals(policyNames[i]))
                            matches |= (1 << i);
                    }
                }

                Assert.AreEqual((1 << nPolicies) - 1, matches);
            }
            finally
            {
                for (int i = 0; i < nPolicies; i++)
                {
                    Client.DeleteGroupPolicyAsync(new DeleteGroupPolicyRequest() { GroupName = grpname, PolicyName = policyNames[i] }).Wait();
                }

                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = grpname }).Wait();
            }
        }

        [Test]
        [Category("IAM")]
        public void TestDeleteUserPolicy()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string pName = "sdk-policy-" + DateTime.Now.Ticks;

            try
            {
                Client.PutUserPolicyAsync(new PutUserPolicyRequest()
                {
                    UserName = username,
                    PolicyName = pName,
                    PolicyDocument = TEST_ALLOW_POLICY
                }).Wait();

                ListUserPoliciesResponse response =
                    Client.ListUserPoliciesAsync(new ListUserPoliciesRequest() { UserName = username }).Result;

                Assert.AreEqual(1, response.PolicyNames.Count());

                Client.DeleteUserPolicyAsync(new DeleteUserPolicyRequest() { UserName = username, PolicyName = pName }).Wait();

                response = Client.ListUserPoliciesAsync(new ListUserPoliciesRequest() { UserName = username }).Result;

                Assert.AreEqual(0, response.PolicyNames.Count());
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [Test]
        [Category("IAM")]
        public void TestDeleteGroupPolicy()
        {
            string groupname = "sdk-testgroup-" + DateTime.Now.Ticks;
            string pName = "test-policy-" + DateTime.Now.Ticks;

            try
            {
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH }).Wait();

                Client.PutGroupPolicyAsync(new PutGroupPolicyRequest()
                {
                    GroupName = groupname,
                    PolicyName = pName,
                    PolicyDocument = TEST_ALLOW_POLICY
                }).Wait();

                ListGroupPoliciesResponse response =
                    Client.ListGroupPoliciesAsync(new ListGroupPoliciesRequest() { GroupName = groupname }).Result;

                Assert.AreEqual(1, response.PolicyNames.Count());

                Client.DeleteGroupPolicyAsync(new DeleteGroupPolicyRequest() { GroupName = groupname, PolicyName = pName }).Wait();

                response = Client.ListGroupPoliciesAsync(new ListGroupPoliciesRequest() { GroupName = groupname }).Result;

                Assert.AreEqual(0, response.PolicyNames.Count());
            }
            finally
            {
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname }).Wait();
            }
        }

        [Test]
        [Category("IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestDeleteNonExistentGroupPolicyException()
        {
            string groupname = "sdk-testgroup-" + DateTime.Now.Ticks;

            try
            {
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH }).Wait();
                Client.DeleteGroupPolicyAsync(new DeleteGroupPolicyRequest() { GroupName = groupname, PolicyName = "test-policy" + DateTime.Now.Ticks }).Wait();
            }
            catch (AggregateException ae)
            {
                AssertExtensions.VerifyException<NoSuchEntityException>(ae);
            }
            finally
            {
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname }).Wait();
            }
        }

        [Test]
        [Category("IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestGetNonExistentGroupPolicyException()
        {
            string groupname = "sdk-testgroup-" + DateTime.Now.Ticks;

            try
            {
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH }).Wait();
                Client.GetGroupPolicyAsync(new GetGroupPolicyRequest() { GroupName = groupname, PolicyName = "test-policy-" + DateTime.Now.Ticks }).Wait();
            }
            catch (AggregateException ae)
            {
                AssertExtensions.VerifyException<NoSuchEntityException>(ae);
            }
            finally
            {
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname }).Wait();
            }
        }

        [Test]
        [Category("IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestDeleteNonExistentUserPolicyException()
        {
            string username = IAMUtil.CreateTestUser(Client);

            try
            {
                Client.DeleteUserPolicyAsync(new DeleteUserPolicyRequest() { UserName = username, PolicyName = "test-policy-" + DateTime.Now.Ticks }).Wait();
            }
            catch (AggregateException ae)
            {
                AssertExtensions.VerifyException<NoSuchEntityException>(ae);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [Test]
        [Category("IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestGetNonExistentUserPolicyException()
        {
            string username = IAMUtil.CreateTestUser(Client);

            try
            {
                Client.GetUserPolicyAsync(new GetUserPolicyRequest() { UserName = username, PolicyName = "test-policy-" + DateTime.Now.Ticks }).Wait();
            }
            catch (AggregateException ae)
            {
                AssertExtensions.VerifyException<NoSuchEntityException>(ae);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [Test]
        [Category("IAM")]
        //[ExpectedException(typeof(MalformedPolicyDocumentException))]
        public void TestPutUserPolicyMalformedPolicyDocumentException()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string policyName = "test-policy-" + DateTime.Now.Ticks;

            try
            {
                Client.PutUserPolicyAsync(new PutUserPolicyRequest()
                {
                    UserName = username,
                    PolicyName = policyName,
                    PolicyDocument = "["
                }).Wait();
            }
            catch (AggregateException ae)
            {
                AssertExtensions.VerifyException<MalformedPolicyDocumentException>(ae);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [Test]
        [Category("IAM")]
        public void TestCreateManagedPolicy()
        {
            string policyName = "test-policy-" + DateTime.Now.Ticks;
            string arn = null;

            Client.CreatePolicyAsync(new CreatePolicyRequest { PolicyName = policyName, PolicyDocument = TEST_VERSIONED_POLICY }).Wait();
            try
            {
                arn = UtilityMethods.WaitUntilSuccess(() => FindPolicy(policyName));
            }
            finally
            {
                if (arn != null)
                    Client.DeletePolicyAsync(new DeletePolicyRequest { PolicyArn = arn }).Wait();
            }
        }

        private string FindPolicy(string policyName)
        {
            string arn = null;
            var policies = ListAllPolicies().ToList();
            var found = false;
            foreach (var policy in policies)
            {
                if (policy.PolicyName.Equals(policyName))
                {
                    found = true;
                    arn = policy.Arn;
                }
            }

            Assert.IsTrue(found);
            Assert.IsNotNull(arn);
            return arn;
        }

        private IEnumerable<ManagedPolicy> ListAllPolicies()
        {
            var request = new ListPoliciesRequest();
            ListPoliciesResponse response;
            do
            {
                response = Client.ListPoliciesAsync(request).Result;
                foreach (var p in response.Policies)
                    yield return p;

                request.Marker = response.Marker;
            } while (response.IsTruncated);
        }

        [Test]
        [Category("IAM")]
        public void TestAttachManagedPolicy()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string policyName = "sdk-policy-" + DateTime.Now.Ticks;

            var policyArn = Client.CreatePolicyAsync(new CreatePolicyRequest { PolicyName = policyName, PolicyDocument = TEST_VERSIONED_POLICY }).Result.Policy.Arn;

            try
            {
                Client.AttachUserPolicyAsync(new AttachUserPolicyRequest { UserName = username, PolicyArn = policyArn }).Wait();
                Client.DetachUserPolicyAsync(new DetachUserPolicyRequest { UserName = username, PolicyArn = policyArn }).Wait();
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }
    }
}
