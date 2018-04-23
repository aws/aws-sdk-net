using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.CloudWatchEvents;
using Amazon.CloudWatchEvents.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CloudWatchEvents : TestBase<AmazonCloudWatchEventsClient>
    {
        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("CloudWatchEvents")]
        public void TestCloudWatchEvents()
        {
            var rules = Client.ListRules().Rules;

            Assert.IsTrue(rules != null);

            string ruleName = UtilityMethods.GenerateName("CloudWatchEventRule");

            var exception = AssertExtensions.ExpectException<ResourceNotFoundException>(() =>
                Client.DescribeRule(new DescribeRuleRequest { Name = ruleName }));
                        
            try
            {
                var createRuleResponse = Client.PutRule(new PutRuleRequest
                {
                    Name = ruleName,
                    State = RuleState.ENABLED,
                    ScheduleExpression = "rate(5 minutes)"
                    
                });

                Assert.IsFalse(string.IsNullOrEmpty(createRuleResponse.RuleArn));
            }
            finally
            {
                Client.DeleteRule(new DeleteRuleRequest
                {
                    Name = ruleName
                });
            }
        }
    }
}