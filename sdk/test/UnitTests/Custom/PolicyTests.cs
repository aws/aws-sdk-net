using Amazon.Auth.AccessControlPolicy;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using static Amazon.Auth.AccessControlPolicy.ConditionFactory;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    [TestCategory("Runtime")]
    public class PolicyTests
    {
        [TestMethod]
        public void TestIfStatementAlreadyExists()
        {
            var policy = new Policy();

            Statement statement = new Statement(Statement.StatementEffect.Allow);
            statement.Actions.Add("sqs:SendMessage");
            statement.Resources.Add(new Resource("the:queue:arn"));
            statement.Conditions.Add(ConditionFactory.NewSourceArnCondition("source:arn"));
            statement.Principals.Add(new Principal("*"));

            policy.Statements.Add(statement);

            Statement newStatement = new Statement(Statement.StatementEffect.Allow);
            newStatement.Actions.Add("sqs:SendMessage");
            newStatement.Resources.Add(new Resource("the:queue:arn"));
            newStatement.Conditions.Add(ConditionFactory.NewSourceArnCondition("source:arn"));
            newStatement.Principals.Add(new Principal("*"));

            Assert.IsTrue(policy.CheckIfStatementExists(newStatement));

            newStatement.Effect = Statement.StatementEffect.Deny;
            Assert.IsFalse(policy.CheckIfStatementExists(newStatement));

            newStatement.Effect = Statement.StatementEffect.Allow;
            Assert.IsTrue(policy.CheckIfStatementExists(newStatement));

            newStatement.Actions.Add("sqs:AddPermission");
            Assert.IsFalse(policy.CheckIfStatementExists(newStatement));

            newStatement.Actions.Remove("sqs:AddPermission");
            Assert.IsTrue(policy.CheckIfStatementExists(newStatement));

            newStatement.Principals.Add(new Principal("data"));
            Assert.IsFalse(policy.CheckIfStatementExists(newStatement));

            newStatement.Principals.RemoveAt(1);
            Assert.IsTrue(policy.CheckIfStatementExists(newStatement));

            newStatement.Conditions[0].ConditionKey = "new:arn";
            Assert.IsFalse(policy.CheckIfStatementExists(newStatement));
        }

        [TestMethod]
        public void TestAnonymousPrincipal()
        {
            var policy = new Policy 
            {
                Statements =
                {
                    new Statement(Statement.StatementEffect.Deny)
                    {
                         Principals = { Principal.Anonymous }
                    }
                }
            };

            var json = policy.ToJson();
            Console.WriteLine(json);
            Assert.IsTrue(json.Contains("\"Principal\": \"*\""));

            var roundTripPolicy = Policy.FromJson(json);

            Assert.AreEqual(Principal.Anonymous, roundTripPolicy.Statements[0].Principals[0]);
        }
        
        [TestMethod]
        public void CheckIfStatementExists_DoesCaseInsensitiveComparisonOnActions()
        {
            var action = "GetBucketAcl";

            var policy = new Policy()
            {
                Statements =
                {
                    new Statement(Statement.StatementEffect.Allow)
                    {
                        Actions = { new ActionIdentifier(action.ToLower()) }
                    }
                }
            };

            var statementToCheck = new Statement(Statement.StatementEffect.Allow);
            statementToCheck.Actions.Add(new ActionIdentifier(action));

            var result = policy.CheckIfStatementExists(statementToCheck);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LookForArnComparisonTypeChanges()
        {
            var expectedHash = "93F200C066AF797AE2A923313D16DD1737AB26D8041C03F68E2BC9FAB03F464A";
            AssertExtensions.AssertEnumUnchanged(
                typeof(ArnComparisonType),
                expectedHash,
                "The Amazon.Auth.AccessControlPolicy.ConditionFactory.ToString(ArnComparisonType) method implementation may need to be updated.");
        }

        [TestMethod]
        public void LookForDateComparisonTypeChanges()
        {
            var expectedHash = "929F27F8B4A0619A30D90F35429690BE334B14D4881EF47311FDEB5696D27DEF";
            AssertExtensions.AssertEnumUnchanged(
                typeof(DateComparisonType),
                expectedHash,
                "The Amazon.Auth.AccessControlPolicy.ConditionFactory.ToString(DateComparisonType) method implementation may need to be updated.");
        }

        [TestMethod]
        public void LookForIpAddressComparisonTypeChanges()
        {
            var expectedHash = "440711FCA8408753BAEC4D1ECA39F813477A43DCA988924E0260A28359F53B78";
            AssertExtensions.AssertEnumUnchanged(
                typeof(IpAddressComparisonType),
                expectedHash,
                "The Amazon.Auth.AccessControlPolicy.ConditionFactory.ToString(DateComparisonType) method implementation may need to be updated.");
        }

        [TestMethod]
        public void LookForNumericComparisonTypeChanges()
        {
            var expectedHash = "15808022DE81B0A1C62DBB9238EA542B891EDE6840278508C1FBFC4A6ACC829D";
            AssertExtensions.AssertEnumUnchanged(
                typeof(NumericComparisonType),
                expectedHash,
                "The Amazon.Auth.AccessControlPolicy.ConditionFactory.ToString(DateComparisonType) method implementation may need to be updated.");
        }

        [TestMethod]
        public void LookForStringComparisonTypeChanges()
        {
            var expectedHash = "8466438D83763A3ADE2161964A9C3A68E247BC576A40956D5295382C74D8FB22";
            AssertExtensions.AssertEnumUnchanged(
                typeof(StringComparisonType),
                expectedHash,
                "The Amazon.Auth.AccessControlPolicy.ConditionFactory.ToString(DateComparisonType) method implementation may need to be updated.");
        }

        [TestMethod]
        public void HandleObjectsWhenConvertingPrincipals()
        {
            string testPolicy = @"{
              ""Version"": ""2012-10-17"",
              ""Statement"": [
                {
                  ""Effect"": ""Deny"",
                  ""Action"": ""s3:*"",
                  ""Principal"": {
                    ""AWS"": [
                        ""arn:aws:iam::123456789012:root"",
                        ""999999999999""
                    ],
                    ""CanonicalUser"": ""79a59df900b949e55d96a1e698fbacedfd6e09d98eacf8f8d5218e7cd47ef2be""
                  },
                  ""Resource"": [
                    ""arn:aws:s3:::amzn-s3-demo-bucket/*"",
                    ""arn:aws:s3:::amzn-s3-demo-bucket""
                  ],
                  ""Condition"": {
                    ""ArnNotEquals"": {
                      ""aws:PrincipalArn"": ""arn:aws:iam::444455556666:user/user-name""
                    }
                  }
                }
              ]
            }";

            var policy = Policy.FromJson(testPolicy);
            Assert.IsNotNull(policy);
            Assert.AreEqual(1, policy.Statements.Count);

            var statement = policy.Statements.First();
            Assert.AreEqual(statement.Actions.Count, 1);
            Assert.AreEqual(statement.Principals.Count, 3);
            Assert.AreEqual(statement.Conditions.Count, 1);
        }

        [TestMethod]
        public void HandleSingleValueWhenConvertingPrincipals()
        {
            string testPolicy = @"{
              ""Version"": ""2012-10-17"",
              ""Statement"": [
                {
                  ""Effect"": ""Allow"",
                  ""Action"": ""s3:ListBucket"",
                  ""Principal"": {
                    ""AWS"": ""123456789012""
                  }
                }
              ]
            }";

            var policy = Policy.FromJson(testPolicy);
            Assert.IsNotNull(policy);
            Assert.AreEqual(1, policy.Statements.Count);

            var statement = policy.Statements.First();
            Assert.AreEqual(1, statement.Principals.Count);

            var principal = statement.Principals.First();
            Assert.AreEqual(Principal.AWS_PROVIDER, principal.Provider);
            Assert.AreEqual("123456789012", principal.Id);
        }

        [TestMethod]
        public void HandleAnonymousWhenConvertingPrincipals()
        {
            string testPolicy = @"{
              ""Version"": ""2012-10-17"",
              ""Statement"": [
                {
                  ""Effect"": ""Deny"",
                  ""Action"": ""s3:*"",
                  ""Principal"": ""*"",
                  ""Resource"": [
                    ""arn:aws:s3:::amzn-s3-demo-bucket/*"",
                    ""arn:aws:s3:::amzn-s3-demo-bucket""
                  ],
                  ""Condition"": {
                    ""ArnNotEquals"": {
                      ""aws:PrincipalArn"": ""arn:aws:iam::444455556666:user/user-name""
                    }
                  }
                }
              ]
            }";

            var policy = Policy.FromJson(testPolicy);
            Assert.IsNotNull(policy);
            Assert.AreEqual(1, policy.Statements.Count);

            var statement = policy.Statements.First();
            Assert.AreEqual(1, statement.Principals.Count);
            Assert.AreEqual(Principal.Anonymous, statement.Principals.First());
        }

        [TestMethod]
        public void TestPrettyPrintIndentationDisabled()
        {
            string testPolicy = @"{
                ""Version"": ""2012-10-17"",
                ""Statement"": [
                {
                    ""Sid"": ""AllowS3ListBucket"",
                    ""Effect"": ""Allow"",
                    ""Action"": [
                    ""s3:ListBucket""
                    ],
                    ""Resource"": [
                    ""arn:aws:s3:::your-bucket-name""
                    ]
                }
                ]
            }";

            var policy = Policy.FromJson(testPolicy);
            string policyString = policy.ToJson(false);

            Assert.IsFalse(policyString.Contains("\n"));
        }

        [TestMethod]
        public void TestPrettyPrintIndentationEnabled()
        {
            string testPolicy = @"{""Version"": ""2012-10-17"", ""Statement"": [{""Sid"": ""AllowS3ListBucket"", ""Effect"": ""Allow"", ""Action"": [ ""s3:ListBucket"" ], ""Resource"": [ ""arn:aws:s3:::your-bucket-name""]}]}";

            var policy = Policy.FromJson(testPolicy);
            string policyString = policy.ToJson(true);

            Assert.IsTrue(policyString.Contains("\n"));
        }
    }
}
