using System;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;
using Amazon.Runtime;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CloudFormation : TestBase<AmazonCloudFormationClient>
    {
        public const string TEMPLATE_URL = @"https://aws-vs-toolkit.s3.amazonaws.com/CloudFormationTemplates/SingleInstance.template";
        public const string TEMPLATE_TEXT = @"{
	""AWSTemplateFormatVersion"" : ""2010-09-09"",

	""Description"" : ""This is a sample template"",

	""Parameters"" : {
		""TopicName"" : {
		    ""Type"" : ""String"",
            ""Default"" : ""TheTopic"",
            ""Description"" : ""A topic.""
		},
        ""QueueName"" : {
            ""Type"" : ""String"",
            ""Default"" : ""TheQueue"",
            ""Description"" : ""A queue.""
        }
	},

	""Resources"" : {

		""TheQueue"" : {
		    ""Type"" : ""AWS::SQS::Queue"",
		    ""Properties"" : {
				""QueueName"" : { ""Ref"" : ""QueueName"" }
		    }
		},

        ""TheTopic"" : {
            ""Type"" : ""AWS::SNS::Topic"",
            ""Properties"" : {
				""TopicName"" : { ""Ref"" : ""TopicName"" },
                ""Subscription"" : [
					{""Protocol"" : ""sqs"", ""Endpoint"" : {""Fn::GetAtt"" : [ ""TheQueue"", ""Arn""]}}
                ]
            }
        }
	},

	""Outputs"" : {
		""TopicARN"" : {
		    ""Value"" : { ""Ref"" : ""TheTopic"" }
		},
        ""QueueURL"" : {
            ""Value"" : { ""Ref"" : ""TheQueue"" }
        }
	}
}
";

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }
        
        [TestMethod]
        [TestCategory("CloudFormation")]
        public void TestValidateTemplateURL()
        {
            ValidateTemplateResponse response = Client.ValidateTemplate(new ValidateTemplateRequest() { TemplateURL = TEMPLATE_URL });
            Assert.IsNotNull(response.ResponseMetadata.RequestId);
            Assert.IsTrue(response.Parameters.Count > 0);

            foreach (TemplateParameter tp in response.Parameters)
            {
                Assert.IsNotNull(tp.ParameterKey);
            }
        }

        [TestMethod]
        [TestCategory("CloudFormation")]
        public void TestGetTemplateSummary()
        {
            GetTemplateSummaryResponse response = Client.GetTemplateSummary(new GetTemplateSummaryRequest
            {
                TemplateURL = TEMPLATE_URL
            });
            VerifyTemplateSummary(response);

            response = Client.GetTemplateSummary(new GetTemplateSummaryRequest
            {
                TemplateBody = TEMPLATE_TEXT
            });
            VerifyTemplateSummary(response);
        }

        private static void VerifyTemplateSummary(GetTemplateSummaryResponse response)
        {
            Assert.IsNotNull(response.ResponseMetadata.RequestId);
            Assert.IsNotNull(response.Capabilities);
            Assert.AreEqual(0, response.Capabilities.Count);
            Assert.IsNull(response.CapabilitiesReason);
            Assert.IsNotNull(response.Description);
            Assert.IsNotNull(response.Parameters);
            foreach (ParameterDeclaration pd in response.Parameters)
            {
                Assert.IsNotNull(pd.ParameterKey);
                Assert.IsNotNull(pd.ParameterType);
                Assert.IsNotNull(pd.Description);
            }
            Assert.IsNotNull(response.Version);
        }

        [TestMethod]
        [TestCategory("CloudFormation")]
        public void EstimateCostTest()
        {
            EstimateTemplateCostResponse response = Client.EstimateTemplateCost(new EstimateTemplateCostRequest() { TemplateBody = TEMPLATE_TEXT });
            Assert.IsNotNull(response.Url);
        }

        [TestMethod]
        [TestCategory("CloudFormation")]
        public void TestValidateTemplateBody()
        {
            ValidateTemplateResponse response = Client.ValidateTemplate(new ValidateTemplateRequest() { TemplateURL = TEMPLATE_URL });
            Assert.IsNotNull(response.ResponseMetadata.RequestId);
        }

        [TestMethod]
        [TestCategory("CloudFormation")]
        public void TestInvalidTemplate()
        {
            try
            {
                ValidateTemplateResponse response = Client.ValidateTemplate(new ValidateTemplateRequest() { TemplateBody = @"{""Foo"" : ""Bar""}" });
                Assert.Fail("Should have thrown an exception");
            }
            catch (AmazonCloudFormationException acfx)
            {
                Assert.AreEqual<string>("ValidationError", acfx.ErrorCode);
                Assert.AreEqual<ErrorType>(ErrorType.Sender, acfx.ErrorType);
            }
            catch (Exception)
            {
                Assert.Fail("Should have thrown an AmazonCloudFormation Exception");
            }
        }

        [TestMethod]
        [TestCategory("CloudFormation")]
        public void TestCreateStack()
        {
            string stackName = "test-stack-" + DateTime.Now.Ticks;
            try
            {
                CreateStackRequest createRequest = new CreateStackRequest
                {
                    StackName = stackName,
                    TemplateBody = TEMPLATE_TEXT
                };

                createRequest.Parameters.Add(new Parameter
                    {
                        ParameterKey = "TopicName",
                        ParameterValue = "MyTopic" + DateTime.Now.Ticks
                    });
                createRequest.Parameters.Add(new Parameter
                {
                    ParameterKey = "QueueName",
                    ParameterValue = "MyQueue" + DateTime.Now.Ticks
                });

                Client.CreateStack(createRequest);

                WaitTillStackNotInProcess(stackName);

                var stack = Client.DescribeStacks(new DescribeStacksRequest
                {
                    StackName = stackName
                }).Stacks[0];

                Assert.AreEqual(StackStatus.CREATE_COMPLETE , stack.StackStatus);

                var resources = Client.DescribeStackResources(new DescribeStackResourcesRequest
                    {
                        StackName = stackName
                    }).StackResources;

                Assert.AreEqual(2, resources.Count);

                GetTemplateSummaryResponse templateSummaryResponse = Client.GetTemplateSummary(new GetTemplateSummaryRequest
                {
                    StackName = stackName
                });
                VerifyTemplateSummary(templateSummaryResponse);
            }
            finally
            {
                WaitTillStackNotInProcess(stackName);
                Client.DeleteStack(new DeleteStackRequest() { StackName = stackName });
            }
        }

        static void WaitTillStackNotInProcess(string stackname)
        {
            DescribeStacksResponse response = null;
            do
            {
                Thread.Sleep(2000);
                response = Client.DescribeStacks(new DescribeStacksRequest
                {
                    StackName = stackname
                });
            } while (response.Stacks[0].StackStatus.Value.EndsWith("IN_PROGRESS"));
        }
    }
}
