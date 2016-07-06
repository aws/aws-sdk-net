using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using System.Threading;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    [TestClass]
    public class PolicyTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        public static string 
            TEST_ALLOW_POLICY = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
            TEST_VERSIONED_POLICY =  @"{""Version"": ""2012-10-17"",""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
            TEST_DENY_POLICY  = @"{""Statement"":[{""Effect"":""Deny"",""Action"":""*"",""Resource"":""*""}]}";


        
        public PolicyTests()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestInitialize]
        public void TestSetup()
        {
            IAMUtil.DeleteUsersAndGroupsInTestNameSpace(Client);
        }


        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestPrincipalPolicies()
        {
            string groupname = "sdk-testgroup-" + DateTime.Now.Ticks;
            string policyName = "strong-password";
            string policy = @"{
  ""Version"": ""2012-10-17"",
  ""Statement"": [{
    ""Effect"": ""Allow"",
    ""Action"": ""dynamodb:*"",
    ""Resource"": ""arn:aws:dynamodb:us-east-1:123456789012:table/${aws:username}""
  }]
}";
            try
            {
                // create group
                var groupArn = Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH }).Group.Arn;

                // attach policy
                Client.PutGroupPolicy(
                    new PutGroupPolicyRequest()
                    {
                        GroupName = groupname,
                        PolicyName = policyName,
                        PolicyDocument = policy
                    });

                // test group policy
                GetGroupPolicyResponse groupInfo =
                    Client.GetGroupPolicy(new GetGroupPolicyRequest() { GroupName = groupname, PolicyName = policyName });
                Assert.AreEqual(groupname, groupInfo.GroupName);
                Assert.AreEqual(policyName, groupInfo.PolicyName);
                Assert.AreEqual(policy, HttpUtility.UrlDecode(groupInfo.PolicyDocument));

                // get context keys
                var contextKeyNames = Client.GetContextKeysForPrincipalPolicy(new GetContextKeysForPrincipalPolicyRequest
                {
                    PolicySourceArn = groupArn
                }).ContextKeyNames;
                Assert.IsNotNull(contextKeyNames);
                Assert.AreEqual(1, contextKeyNames.Count);
                Assert.IsTrue(contextKeyNames.Contains("aws:username"));

                
                // simulate policy
                var response = Client.SimulatePrincipalPolicy(new SimulatePrincipalPolicyRequest
                {
                    PolicySourceArn = groupArn,
                    ActionNames = new List<string>
                    {
                        "dynamodb:PutItem"
                    },
                    ResourceArns = new List<string>
                    {
                        "arn:aws:dynamodb:us-east-1:123456789012:table/bob"
                    },
                    ContextEntries = new List<ContextEntry>
                    {
                        new ContextEntry
                        {
                            ContextKeyName = "aws:username",
                            ContextKeyType = ContextKeyTypeEnum.String,
                            ContextKeyValues = new List<string>
                            {
                                "bob"
                            }
                        }
                    }
                });
                var results = response.EvaluationResults;
                Assert.IsNotNull(results);
                Assert.AreEqual(1, results.Count);
                var result = results.First();
                Assert.AreEqual(PolicyEvaluationDecisionType.Allowed, result.EvalDecision);

                response = Client.SimulatePrincipalPolicy(new SimulatePrincipalPolicyRequest
                {
                    PolicySourceArn = groupArn,
                    ActionNames = new List<string>
                    {
                        "dynamodb:PutItem"
                    },
                    ResourceArns = new List<string>
                    {
                        "arn:aws:dynamodb:us-east-1:123456789012:table/bob"
                    },
                    ContextEntries = new List<ContextEntry>
                    {
                        new ContextEntry
                        {
                            ContextKeyName = "aws:username",
                            ContextKeyType = ContextKeyTypeEnum.String,
                            ContextKeyValues = new List<string>
                            {
                                "alice"
                            }
                        }
                    }
                });
                results = response.EvaluationResults;
                Assert.IsNotNull(results);
                Assert.AreEqual(1, results.Count);
                result = results.First();
                Assert.AreEqual(PolicyEvaluationDecisionType.ImplicitDeny, result.EvalDecision);
            }
            finally
            {
                Client.DeleteGroupPolicy(new DeleteGroupPolicyRequest() { GroupName = groupname, PolicyName = policyName });
                Client.DeleteGroup(new DeleteGroupRequest { GroupName = groupname });
            }
        }


        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestCustomPolicies()
        {
            var s3SamplePolicy = @"{
  ""Version"": ""2012-10-17"",
  ""Statement"": [
    {
      ""Effect"": ""Allow"",
      ""Action"": [
        ""s3:ListAllMyBuckets"",
        ""s3:GetBucketLocation""
      ],
      ""Resource"": ""arn:aws:s3:::*""
    },
    {
      ""Effect"": ""Allow"",
      ""Action"": ""s3:ListBucket"",
      ""Resource"": ""arn:aws:s3:::test-bucket123"",
      ""Condition"": {""StringLike"": {""s3:prefix"": [
        """",
        ""home/"",
        ""home/${aws:username}/""
      ]}}
    },
    {
      ""Effect"": ""Allow"",
      ""Action"": ""s3:*"",
      ""Resource"": [
        ""arn:aws:s3:::test-bucket123/home/${aws:username}"",
        ""arn:aws:s3:::test-bucket123/home/${aws:username}/*""
      ]
    }
  ]
}";
            var contextKeys = Client.GetContextKeysForCustomPolicy(new GetContextKeysForCustomPolicyRequest
            {
                PolicyInputList = new List<string>
                {
                    s3SamplePolicy
                }
            }).ContextKeyNames;
            Assert.IsNotNull(contextKeys);
            Assert.AreNotEqual(0, contextKeys.Count);
            Assert.IsTrue(contextKeys.Contains("s3:prefix"));
            Assert.IsTrue(contextKeys.Contains("aws:username"));

            var response = Client.SimulateCustomPolicy(new SimulateCustomPolicyRequest
            {
                ActionNames = new List<string>
                {
                    "s3:ListBucket"
                },
                PolicyInputList = new List<string> 
                {
                    s3SamplePolicy
                },
                ResourceArns = new List<string>
                {
                    "arn:aws:s3:::test-bucket123"
                },
                ContextEntries = new List<ContextEntry>
                {
                    new ContextEntry
                    {
                        ContextKeyName = "s3:prefix",
                        ContextKeyType = ContextKeyTypeEnum.String,
                        ContextKeyValues = new List<string>
                        {
                            "home/bob/"
                        }
                    },
                    new ContextEntry
                    {
                        ContextKeyName = "aws:username",
                        ContextKeyType = ContextKeyTypeEnum.String,
                        ContextKeyValues = new List<string>
                        {
                            "bob"
                        }
                    }
                }
            });
            var results = response.EvaluationResults;
            Assert.AreEqual(1, results.Count);
            var result = results.First();
            Assert.IsNotNull(result);
            Assert.AreEqual(PolicyEvaluationDecisionType.Allowed, result.EvalDecision);

            response = Client.SimulateCustomPolicy(new SimulateCustomPolicyRequest
            {
                ActionNames = new List<string>
                {
                    "s3:ListBucket"
                },
                PolicyInputList = new List<string> 
                {
                    s3SamplePolicy
                },
                ResourceArns = new List<string>
                {
                    "arn:aws:s3:::test-bucket123"
                },
                ContextEntries = new List<ContextEntry>
                {
                    new ContextEntry
                    {
                        ContextKeyName = "s3:prefix",
                        ContextKeyType = ContextKeyTypeEnum.String,
                        ContextKeyValues = new List<string>
                        {
                            "home/alice/"
                        }
                    },
                    new ContextEntry
                    {
                        ContextKeyName = "aws:username",
                        ContextKeyType = ContextKeyTypeEnum.String,
                        ContextKeyValues = new List<string>
                        {
                            "bob"
                        }
                    }
                }
            });
            results = response.EvaluationResults;
            Assert.AreEqual(1, results.Count);
            result = results.First();
            Assert.IsNotNull(result);
            Assert.AreEqual(PolicyEvaluationDecisionType.ImplicitDeny, result.EvalDecision);
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestPutGetUserPolicy()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string policyName = "test-policy-" + DateTime.Now.Ticks;

            try
            {
                Client.PutUserPolicy(
                    new PutUserPolicyRequest()
                    {
                        UserName = username,
                        PolicyName = policyName,
                        PolicyDocument = TEST_ALLOW_POLICY
                    });

                GetUserPolicyResponse response =
                    Client.GetUserPolicy(new GetUserPolicyRequest() { UserName = username, PolicyName = policyName });

                Assert.AreEqual(username, response.UserName);
                Assert.AreEqual(policyName, response.PolicyName);
                Assert.AreEqual(TEST_ALLOW_POLICY, HttpUtility.UrlDecode(response.PolicyDocument));
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestPutGetGroupPolicy()
        {
            string groupname = "sdk-testgroup-" + DateTime.Now.Ticks;
            string policyName = "strong-password";

            try
            {
                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH });

                Client.PutGroupPolicy(
                    new PutGroupPolicyRequest()
                    {
                        GroupName = groupname,
                        PolicyName = policyName,
                        PolicyDocument = TEST_ALLOW_POLICY
                    });

                GetGroupPolicyResponse response =
                    Client.GetGroupPolicy(new GetGroupPolicyRequest() { GroupName = groupname, PolicyName = policyName });

                Assert.AreEqual(groupname,  response.GroupName);
                Assert.AreEqual(policyName, response.PolicyName);
                Assert.AreEqual(TEST_ALLOW_POLICY, HttpUtility.UrlDecode(response.PolicyDocument));
            }
            finally
            {
                Client.DeleteGroupPolicy(new DeleteGroupPolicyRequest() { GroupName = groupname, PolicyName = policyName });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(NoSuchEntityException))]
        public void TestGetNonExistantPolicy()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string policyName = "test-policy-" + DateTime.Now.Ticks;

            try
            {
                GetUserPolicyResponse response =
                    Client.GetUserPolicy(new GetUserPolicyRequest() { UserName = username, PolicyName = policyName });
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
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
                    Client.PutUserPolicy(new PutUserPolicyRequest()
                    {
                        UserName = username,
                        PolicyName = policyNames[i],
                        PolicyDocument = TEST_ALLOW_POLICY
                    });
                }

                ListUserPoliciesResponse response =
                    Client.ListUserPolicies(new ListUserPoliciesRequest() { UserName = username });

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

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestListGroupPolicies()
        {
            string grpname = "sdk-testgroup-" + DateTime.Now.Ticks;
            string[] policyNames = new string[3];
            int nPolicies = 3;

            try
            {
                Client.CreateGroup(new CreateGroupRequest() { GroupName = grpname, Path = IAMUtil.TEST_PATH });

                for (int i = 0; i < nPolicies; i++)
                {
                    policyNames[i] = "test-policy-" + DateTime.Now.Ticks + i;
                    Client.PutGroupPolicy(new PutGroupPolicyRequest()
                    {
                        GroupName = grpname,
                        PolicyName = policyNames[i],
                        PolicyDocument = TEST_ALLOW_POLICY
                    });
                }

                ListGroupPoliciesResponse response =
                    Client.ListGroupPolicies(new ListGroupPoliciesRequest() { GroupName = grpname });

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
                    Client.DeleteGroupPolicy(new DeleteGroupPolicyRequest() { GroupName = grpname, PolicyName = policyNames[i] });
                }

                Client.DeleteGroup(new DeleteGroupRequest() {GroupName = grpname });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
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
                    Client.PutUserPolicy(new PutUserPolicyRequest()
                    {
                        UserName = username,
                        PolicyName = policyNames[i],
                        PolicyDocument = TEST_ALLOW_POLICY
                    });
                }

                ListUserPoliciesResponse response =
                    Client.ListUserPolicies(new ListUserPoliciesRequest() { UserName = username, MaxItems = 2 });

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

                response = Client.ListUserPolicies(new ListUserPoliciesRequest() { UserName = username, Marker = marker });

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

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestListGroupPoliciesPaging()
        {
            string grpname = "sdk-testgroup-" + DateTime.Now.Ticks;
            int nPolicies = 3;
            string[] policyNames = new string[nPolicies];

            try
            {
                Client.CreateGroup(new CreateGroupRequest() {GroupName = grpname, Path = IAMUtil.TEST_PATH });

                for (int i = 0; i < nPolicies; i++)
                {
                    policyNames[i] = "test-policy-" + DateTime.Now.Ticks + i;
                    Client.PutGroupPolicy(new PutGroupPolicyRequest()
                    {
                        GroupName = grpname,
                        PolicyName = policyNames[i],
                        PolicyDocument = TEST_ALLOW_POLICY
                    });
                }

                ListGroupPoliciesResponse response =
                    Client.ListGroupPolicies(new ListGroupPoliciesRequest() { GroupName = grpname, MaxItems = 2 });

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

                response = Client.ListGroupPolicies(new ListGroupPoliciesRequest() { GroupName = grpname, Marker = marker });

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
                    Client.DeleteGroupPolicy(new DeleteGroupPolicyRequest() { GroupName = grpname, PolicyName = policyNames[i] });
                }

                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = grpname });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestDeleteUserPolicy()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string pName = "sdk-policy-" + DateTime.Now.Ticks;

            try
            {
                Client.PutUserPolicy(new PutUserPolicyRequest()
                {
                    UserName = username,
                    PolicyName = pName,
                    PolicyDocument = TEST_ALLOW_POLICY
                });

                ListUserPoliciesResponse response =
                    Client.ListUserPolicies(new ListUserPoliciesRequest() { UserName = username });

                Assert.AreEqual(1, response.PolicyNames.Count());

                Client.DeleteUserPolicy(new DeleteUserPolicyRequest() { UserName = username, PolicyName = pName });

                response = Client.ListUserPolicies(new ListUserPoliciesRequest() { UserName = username });

                Assert.AreEqual(0, response.PolicyNames.Count());
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestDeleteGroupPolicy()
        {
            string groupname = "sdk-testgroup-" + DateTime.Now.Ticks;
            string pName = "test-policy-" + DateTime.Now.Ticks;

            try
            {
                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH });

                Client.PutGroupPolicy(new PutGroupPolicyRequest()
                {
                    GroupName = groupname,
                    PolicyName = pName,
                    PolicyDocument = TEST_ALLOW_POLICY
                });

                ListGroupPoliciesResponse response =
                    Client.ListGroupPolicies(new ListGroupPoliciesRequest() { GroupName = groupname });

                Assert.AreEqual(1, response.PolicyNames.Count());

                Client.DeleteGroupPolicy(new DeleteGroupPolicyRequest() { GroupName = groupname, PolicyName = pName });

                response = Client.ListGroupPolicies(new ListGroupPoliciesRequest() { GroupName = groupname });

                Assert.AreEqual(0, response.PolicyNames.Count());
            }
            finally
            {
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(NoSuchEntityException))]
        public void TestDeleteNonExistentGroupPolicyException()
        {
            string groupname = "sdk-testgroup-" + DateTime.Now.Ticks;

            try
            {
                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH });
                Client.DeleteGroupPolicy(new DeleteGroupPolicyRequest() { GroupName = groupname, PolicyName = "test-policy-" + DateTime.Now.Ticks });
            }
            finally
            {
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(NoSuchEntityException))]
        public void TestGetNonExistentGroupPolicyException()
        {
            string groupname = "sdk-testgroup-" + DateTime.Now.Ticks;

            try
            {
                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH });
                Client.GetGroupPolicy(new GetGroupPolicyRequest() { GroupName = groupname, PolicyName = "test-policy-" + DateTime.Now.Ticks });
            }
            finally
            {
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(NoSuchEntityException))]
        public void TestDeleteNonExistentUserPolicyException()
        {
            string username = IAMUtil.CreateTestUser(Client);

            try
            {
                Client.DeleteUserPolicy(new DeleteUserPolicyRequest() { UserName = username, PolicyName = "test-policy-" + DateTime.Now.Ticks });
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(NoSuchEntityException))]
        public void TestGetNonExistentUserPolicyException()
        {
            string username = IAMUtil.CreateTestUser(Client);

            try
            {
                Client.GetUserPolicy(new GetUserPolicyRequest() { UserName = username, PolicyName = "test-policy-" + DateTime.Now.Ticks });
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(MalformedPolicyDocumentException))]
        public void TestPutUserPolicyMalformedPolicyDocumentException()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string policyName = "test-policy-" + DateTime.Now.Ticks;

            try
            {
                Client.PutUserPolicy(new PutUserPolicyRequest()
                {
                    UserName = username,
                    PolicyName = policyName,
                    PolicyDocument = "["
                });
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestCreateManagedPolicy()
        {
            string policyName = "test-policy-" + DateTime.Now.Ticks;
            string arn = null;

            Client.CreatePolicy(new CreatePolicyRequest { PolicyName = policyName, PolicyDocument = TEST_VERSIONED_POLICY });
            try
            {
                arn = UtilityMethods.WaitUntilSuccess(() => FindPolicy(policyName));
            }
            finally
            {
                if (arn != null)
                    Client.DeletePolicy(new DeletePolicyRequest { PolicyArn = arn });
            }
        }

        private static string FindPolicy(string policyName)
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

        private static IEnumerable<ManagedPolicy> ListAllPolicies()
        {
            var request = new ListPoliciesRequest();
            ListPoliciesResponse response;
            do
            {
                response = Client.ListPolicies(request);
                foreach (var p in response.Policies)
                    yield return p;

                request.Marker = response.Marker;
            } while (response.IsTruncated);
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestAttachManagedPolicy()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string policyName = "sdk-policy-" + DateTime.Now.Ticks;

            var policyArn = Client.CreatePolicy(new CreatePolicyRequest { PolicyName = policyName, PolicyDocument = TEST_VERSIONED_POLICY }).Policy.Arn;

            try
            {
                Client.AttachUserPolicy(new AttachUserPolicyRequest { UserName = username, PolicyArn = policyArn });
                Client.DetachUserPolicy(new DetachUserPolicyRequest { UserName = username, PolicyArn = policyArn });
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }
    }
}
