using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Amazon;
using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.DNXCore.IntegrationTests;
using Xunit;
using System.Collections.Generic;

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
        public async Task TestValidateTemplateURL()
        {
            ValidateTemplateResponse response = await Client.ValidateTemplateAsync(new ValidateTemplateRequest() { TemplateURL = TEMPLATE_URL });
            Assert.NotNull(response.ResponseMetadata.RequestId);
            Assert.True(response.Parameters.Count > 0);

            foreach (TemplateParameter tp in response.Parameters)
            {
                Assert.NotNull(tp.ParameterKey);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"CloudFormation")]
        public async Task TestGetTemplateSummary()
        {
            GetTemplateSummaryResponse response = await Client.GetTemplateSummaryAsync(new GetTemplateSummaryRequest
            {
                TemplateURL = TEMPLATE_URL
            });
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

            if (AWSConfigs.InitializeCollections)
            {
                Assert.NotNull(response.Capabilities);
                Assert.Empty(response.Capabilities);
            }
            else
            {
                Assert.Null(response.Capabilities);
            }

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
        public async Task TestCreateStack()
        {
            string stackName = "test-stack-" + DateTime.UtcNow.Ticks;
            try
            {
                CreateStackRequest createRequest = new CreateStackRequest
                {
                    StackName = stackName,
                    TemplateBody = TEMPLATE_TEXT,
                    Parameters = new List<Parameter>
                    {
                        new Parameter
                        {
                            ParameterKey = "TopicName",
                            ParameterValue = "MyTopic" + DateTime.UtcNow.Ticks
                        },
                        new Parameter
                        {
                            ParameterKey = "QueueName",
                            ParameterValue = "MyQueue" + DateTime.UtcNow.Ticks
                        }
                    }
                };

                await Client.CreateStackAsync(createRequest);

                await WaitTillStackNotInProcess(stackName);

                var stack = (await Client.DescribeStacksAsync(new DescribeStacksRequest
                {
                    StackName = stackName
                })).Stacks[0];

                Assert.Equal(StackStatus.CREATE_COMPLETE , stack.StackStatus);

                var resources = (await Client.DescribeStackResourcesAsync(new DescribeStackResourcesRequest
                    {
                        StackName = stackName
                    })).StackResources;

                Assert.Equal(2, resources.Count);

                GetTemplateSummaryResponse templateSummaryResponse = await Client.GetTemplateSummaryAsync(new GetTemplateSummaryRequest
                {
                    StackName = stackName
                });
                VerifyTemplateSummary(templateSummaryResponse);
            }
            finally
            {
                await WaitTillStackNotInProcess(stackName);
                await Client.DeleteStackAsync(new DeleteStackRequest() { StackName = stackName });
            }
        }

        async Task WaitTillStackNotInProcess(string stackname)
        {
            DescribeStacksResponse response = null;
            do
            {
                UtilityMethods.Sleep(TimeSpan.FromSeconds(2));
                response = await Client.DescribeStacksAsync(new DescribeStacksRequest
                {
                    StackName = stackname
                });
            } while (response.Stacks[0].StackStatus.Value.EndsWith("IN_PROGRESS"));
        }
    }
}
