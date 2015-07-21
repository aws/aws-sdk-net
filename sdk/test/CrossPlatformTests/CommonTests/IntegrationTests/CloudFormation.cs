using System;
using System.Linq;
using System.Threading;

using Amazon;
using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using CommonTests.Framework;
using NUnit.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
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

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }
        
        [Test]
        [Category("CloudFormation")]
        public void TestValidateTemplateURL()
        {
            ValidateTemplateResponse response = Client.ValidateTemplateAsync(new ValidateTemplateRequest() { TemplateURL = TEMPLATE_URL }).Result;
            Assert.IsNotNull(response.ResponseMetadata.RequestId);
            Assert.IsTrue(response.Parameters.Count > 0);

            foreach (TemplateParameter tp in response.Parameters)
            {
                Assert.IsNotNull(tp.ParameterKey);
            }
        }

        [Test]
        [Category("CloudFormation")]
        public void TestGetTemplateSummary()
        {
            GetTemplateSummaryResponse response = Client.GetTemplateSummaryAsync(new GetTemplateSummaryRequest
            {
                TemplateURL = TEMPLATE_URL
            }).Result;
            VerifyTemplateSummary(response);

            response = Client.GetTemplateSummaryAsync(new GetTemplateSummaryRequest
            {
                TemplateBody = TEMPLATE_TEXT
            }).Result;
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

        [Test]
        [Category("CloudFormation")]
        public void EstimateCostTest()
        {
            EstimateTemplateCostResponse response = Client.EstimateTemplateCostAsync(new EstimateTemplateCostRequest() { TemplateBody = TEMPLATE_TEXT }).Result;
            Assert.IsNotNull(response.Url);
        }

        [Test]
        [Category("CloudFormation")]
        public void TestValidateTemplateBody()
        {
            ValidateTemplateResponse response = Client.ValidateTemplateAsync(new ValidateTemplateRequest() { TemplateURL = TEMPLATE_URL }).Result;
            Assert.IsNotNull(response.ResponseMetadata.RequestId);
        }

        [Test]
        [Category("CloudFormation")]
        public void TestInvalidTemplate()
        {
            var exception = AssertExtensions.ExpectExceptionAsync<AmazonCloudFormationException>(Client.ValidateTemplateAsync(new ValidateTemplateRequest() { TemplateBody = @"{""Foo"" : ""Bar""}" })).Result;
            Assert.AreEqual("ValidationError", exception.ErrorCode);
            Assert.AreEqual(ErrorType.Sender, exception.ErrorType);
        }

        [Test]
        [Category("CloudFormation")]
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

                Client.CreateStackAsync(createRequest).Wait();

                WaitTillStackNotInProcess(stackName);

                var stack = Client.DescribeStacksAsync(new DescribeStacksRequest
                {
                    StackName = stackName
                }).Result.Stacks[0];

                Assert.AreEqual(StackStatus.CREATE_COMPLETE , stack.StackStatus);

                var resources = Client.DescribeStackResourcesAsync(new DescribeStackResourcesRequest
                    {
                        StackName = stackName
                    }).Result.StackResources;

                Assert.AreEqual(2, resources.Count);

                GetTemplateSummaryResponse templateSummaryResponse = Client.GetTemplateSummaryAsync(new GetTemplateSummaryRequest
                {
                    StackName = stackName
                }).Result;
                VerifyTemplateSummary(templateSummaryResponse);
            }
            finally
            {
                WaitTillStackNotInProcess(stackName);
                Client.DeleteStackAsync(new DeleteStackRequest() { StackName = stackName }).Wait();
            }
        }

        void WaitTillStackNotInProcess(string stackname)
        {
            DescribeStacksResponse response = null;
            do
            {
                UtilityMethods.Sleep(TimeSpan.FromSeconds(2));
                response = Client.DescribeStacksAsync(new DescribeStacksRequest
                {
                    StackName = stackname
                }).Result;
            } while (response.Stacks[0].StackStatus.Value.EndsWith("IN_PROGRESS"));
        }
    }
}
