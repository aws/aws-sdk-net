using System;
using System.Linq;
using System.Threading;

using Amazon;
using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.DNXCore.IntegrationTests;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests
{
    
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
        
        [Fact]
        [Trait(CategoryAttribute,"CloudFormation")]
        public void TestValidateTemplateURL()
        {
            ValidateTemplateResponse response = Client.ValidateTemplateAsync(new ValidateTemplateRequest() { TemplateURL = TEMPLATE_URL }).Result;
            Assert.NotNull(response.ResponseMetadata.RequestId);
            Assert.True(response.Parameters.Count > 0);

            foreach (TemplateParameter tp in response.Parameters)
            {
                Assert.NotNull(tp.ParameterKey);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"CloudFormation")]
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
            Assert.NotNull(response.ResponseMetadata.RequestId);
            Assert.NotNull(response.Capabilities);
            Assert.Equal(0, response.Capabilities.Count);
            Assert.Null(response.CapabilitiesReason);
            Assert.NotNull(response.Description);
            Assert.NotNull(response.Parameters);
            foreach (ParameterDeclaration pd in response.Parameters)
            {
                Assert.NotNull(pd.ParameterKey);
                Assert.NotNull(pd.ParameterType);
                Assert.NotNull(pd.Description);
            }
            Assert.NotNull(response.Version);
        }

        [Fact]
        [Trait(CategoryAttribute,"CloudFormation")]
        public void EstimateCostTest()
        {
            EstimateTemplateCostResponse response = Client.EstimateTemplateCostAsync(new EstimateTemplateCostRequest() { TemplateBody = TEMPLATE_TEXT }).Result;
            Assert.NotNull(response.Url);
        }

        [Fact]
        [Trait(CategoryAttribute,"CloudFormation")]
        public void TestValidateTemplateBody()
        {
            ValidateTemplateResponse response = Client.ValidateTemplateAsync(new ValidateTemplateRequest() { TemplateURL = TEMPLATE_URL }).Result;
            Assert.NotNull(response.ResponseMetadata.RequestId);
        }

        [Fact]
        [Trait(CategoryAttribute,"CloudFormation")]
        public void TestInvalidTemplate()
        {
            var exception = AssertExtensions.ExpectExceptionAsync<AmazonCloudFormationException>(Client.ValidateTemplateAsync(new ValidateTemplateRequest() { TemplateBody = @"{""Foo"" : ""Bar""}" })).Result;
            Assert.Equal("ValidationError", exception.ErrorCode);
            Assert.Equal(ErrorType.Sender, exception.ErrorType);
        }

        [Fact]
        [Trait(CategoryAttribute,"CloudFormation")]
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

                Assert.Equal(StackStatus.CREATE_COMPLETE , stack.StackStatus);

                var resources = Client.DescribeStackResourcesAsync(new DescribeStackResourcesRequest
                    {
                        StackName = stackName
                    }).Result.StackResources;

                Assert.Equal(2, resources.Count);

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
