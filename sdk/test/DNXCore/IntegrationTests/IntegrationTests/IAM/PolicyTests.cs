using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using System.Threading;
using System.Net;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    
    public class PolicyTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        public static string 
            TEST_ALLOW_POLICY = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
            TEST_VERSIONED_POLICY =  @"{""Version"": ""2012-10-17"",""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
            TEST_DENY_POLICY  = @"{""Statement"":[{""Effect"":""Deny"",""Action"":""*"",""Resource"":""*""}]}";

        [Fact]
        [Trait(CategoryAttribute, "IAM")]
        public void TestPutGetUserPolicy()
        {
            using (var session = new IAMTestSession("TestPutGetUserPolicy", Client))
            {
                string username = session.CreateTestUser();
                string policyName = "test-policy-" + DateTime.Now.Ticks;

                Client.PutUserPolicyAsync(
                    new PutUserPolicyRequest()
                    {
                        UserName = username,
                        PolicyName = policyName,
                        PolicyDocument = TEST_ALLOW_POLICY
                    }).Wait();

                GetUserPolicyResponse response =
                    Client.GetUserPolicyAsync(new GetUserPolicyRequest() { UserName = username, PolicyName = policyName }).Result;

                Assert.Equal(username, response.UserName);
                Assert.Equal(policyName, response.PolicyName);
                Assert.Equal(TEST_ALLOW_POLICY, WebUtility.UrlDecode(response.PolicyDocument));
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
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

                Assert.Equal(groupname,  response.GroupName);
                Assert.Equal(policyName, response.PolicyName);
                Assert.Equal(TEST_ALLOW_POLICY, WebUtility.UrlDecode(response.PolicyDocument));
            }
            finally
            {
                Client.DeleteGroupPolicyAsync(new DeleteGroupPolicyRequest() { GroupName = groupname, PolicyName = policyName }).Wait();
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestGetNonExistantPolicy()
        {
            using (var session = new IAMTestSession("TestGetNonExistantPolicy", Client))
            {
                string username = session.CreateTestUser();
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
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestListUserPolicies()
        {
            using (var session = new IAMTestSession("TestListUserPolicies", Client))
            {
                string username = session.CreateTestUser();
                string[] policyNames = new string[3];
                int nPolicies = 3;

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

                Assert.Equal(nPolicies, response.PolicyNames.Count());

                int matches = 0;
                foreach (string name in response.PolicyNames)
                {
                    for (int i = 0; i < nPolicies; i++)
                    {
                        if (name.Equals(policyNames[i]))
                            matches |= (1 << i);
                    }
                }
                Assert.Equal((1 << nPolicies) - 1, matches);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
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

                Assert.Equal(nPolicies, response.PolicyNames.Count());

                int matches = 0;
                foreach (string name in response.PolicyNames)
                {
                    for (int i = 0; i < nPolicies; i++)
                    {
                        if (name.Equals(policyNames[i]))
                            matches |= (1 << i);
                    }
                }
                Assert.Equal((1 << nPolicies) - 1, matches);
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

        [Fact]
        [Trait(CategoryAttribute, "IAM")]
        public void TestListUserPoliciesPaging()
        {
            using (var session = new IAMTestSession("TestListUserPoliciesPaging", Client))
            {
                string username = session.CreateTestUser();
                int nPolicies = 4;
                string[] policyNames = new string[nPolicies];

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

                Assert.Equal(2, response.PolicyNames.Count());
                Assert.Equal(true, response.IsTruncated);
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

                Assert.Equal(nPolicies - 2, response.PolicyNames.Count());
                Assert.Equal(false, response.IsTruncated);

                foreach (string name in response.PolicyNames)
                {
                    for (int i = 0; i < nPolicies; i++)
                    {
                        if (name.Equals(policyNames[i]))
                            matches |= (1 << i);
                    }
                }

                Assert.Equal((1 << nPolicies) - 1, matches);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
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

                Assert.Equal(2, response.PolicyNames.Count());
                Assert.Equal(true, response.IsTruncated);
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

                Assert.Equal(nPolicies - 2, response.PolicyNames.Count());
                Assert.Equal(false, response.IsTruncated);

                foreach (string name in response.PolicyNames)
                {
                    for (int i = 0; i < nPolicies; i++)
                    {
                        if (name.Equals(policyNames[i]))
                            matches |= (1 << i);
                    }
                }

                Assert.Equal((1 << nPolicies) - 1, matches);
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

        [Fact]
        [Trait(CategoryAttribute, "IAM")]
        public void TestDeleteUserPolicy()
        {
            using (var session = new IAMTestSession("TestDeleteUserPolicy", Client))
            {
                string username = session.CreateTestUser();
                string pName = "sdk-policy-" + DateTime.Now.Ticks;

                Client.PutUserPolicyAsync(new PutUserPolicyRequest()
                {
                    UserName = username,
                    PolicyName = pName,
                    PolicyDocument = TEST_ALLOW_POLICY
                }).Wait();

                ListUserPoliciesResponse response =
                    Client.ListUserPoliciesAsync(new ListUserPoliciesRequest() { UserName = username }).Result;

                Assert.Equal(1, response.PolicyNames.Count());

                Client.DeleteUserPolicyAsync(new DeleteUserPolicyRequest() { UserName = username, PolicyName = pName }).Wait();

                response = Client.ListUserPoliciesAsync(new ListUserPoliciesRequest() { UserName = username }).Result;

                Assert.Equal(0, response.PolicyNames.Count());
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
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

                Assert.Equal(1, response.PolicyNames.Count());

                Client.DeleteGroupPolicyAsync(new DeleteGroupPolicyRequest() { GroupName = groupname, PolicyName = pName }).Wait();

                response = Client.ListGroupPoliciesAsync(new ListGroupPoliciesRequest() { GroupName = groupname }).Result;

                Assert.Equal(0, response.PolicyNames.Count());
            }
            finally
            {
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname }).Wait();
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
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

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
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

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestDeleteNonExistentUserPolicyException()
        {
            using (var session = new IAMTestSession("TestDeleteNonExistentUserPolicyException", Client))
            {
                string username = session.CreateTestUser();

                try
                {
                    Client.DeleteUserPolicyAsync(new DeleteUserPolicyRequest() { UserName = username, PolicyName = "test-policy-" + DateTime.Now.Ticks }).Wait();
                }
                catch (AggregateException ae)
                {
                    AssertExtensions.VerifyException<NoSuchEntityException>(ae);
                }
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestGetNonExistentUserPolicyException()
        {
            using (var session = new IAMTestSession("TestGetNonExistentUserPolicyException", Client))
            {
                string username = session.CreateTestUser();

                try
                {
                    Client.GetUserPolicyAsync(new GetUserPolicyRequest() { UserName = username, PolicyName = "test-policy-" + DateTime.Now.Ticks }).Wait();
                }
                catch (AggregateException ae)
                {
                    AssertExtensions.VerifyException<NoSuchEntityException>(ae);
                }
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(MalformedPolicyDocumentException))]
        public void TestPutUserPolicyMalformedPolicyDocumentException()
        {
            using (var session = new IAMTestSession("TestPutUserPolicyMalformedPolicyDocumentException", Client))
            {
                string username = session.CreateTestUser();
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
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
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

            Assert.True(found);
            Assert.NotNull(arn);
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

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestAttachManagedPolicy()
        {
            using (var session = new IAMTestSession("TestLimitExceedException", Client))
            {
                string username = session.CreateTestUser();
                string policyName = "sdk-policy-" + DateTime.Now.Ticks;

                var policyArn = Client.CreatePolicyAsync(new CreatePolicyRequest { PolicyName = policyName, PolicyDocument = TEST_VERSIONED_POLICY }).Result.Policy.Arn;

                Client.AttachUserPolicyAsync(new AttachUserPolicyRequest { UserName = username, PolicyArn = policyArn }).Wait();
                Client.DetachUserPolicyAsync(new DetachUserPolicyRequest { UserName = username, PolicyArn = policyArn }).Wait();
            }
        }
    }
}
