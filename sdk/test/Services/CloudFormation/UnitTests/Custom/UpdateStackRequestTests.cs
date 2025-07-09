using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AWSSDK.UnitTests.CloudFormation
{
    /// <summary>
    /// Validates issue reported in https://github.com/aws/aws-sdk-net/issues/3824 does not reoccur.
    /// </summary>
    [TestClass]
    public class UpdateStackRequestTests
    {
        [TestMethod]
        public void Test_HandlesNotificationARNs()
        {
            var client = new MockCloudFormationClient();

            // Invoke the operation without specifying notification ARNs
            client.UpdateStack(new UpdateStackRequest
            {
                StackName = "test-stack",
                TemplateBody = "template-body",
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
            });

            // Invoke the operation with an empty list of notification ARNs
            client.UpdateStack(new UpdateStackRequest
            {
                StackName = "test-stack",
                TemplateBody = "template-body",
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
                },
                NotificationARNs = new List<string>()
            });
        }

        private class MockCloudFormationClient : AmazonCloudFormationClient
        {
            protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
            {
                base.CustomizeRuntimePipeline(pipeline);

                // Remove handlers that expect an actual HTTP response.
                pipeline.RemoveHandler<Unmarshaller>();
                pipeline.RemoveHandler<MetricsHandler>();

                // Replace actual HTTP handler with a mock validating the request parameters.
                pipeline.ReplaceHandler<HttpHandler<Stream>>(new MockHttpHandler());
            }
        }

        private class MockHttpHandler : PipelineHandler
        {
            public override void InvokeSync(IExecutionContext executionContext)
            {
                var request = executionContext.RequestContext.Request;
                var updateStackRequest = request.OriginalRequest as UpdateStackRequest;
                if (updateStackRequest == null)
                {
                    Assert.Fail("Request is not of type UpdateStackRequest");
                }

                var notificationARNs = updateStackRequest.NotificationARNs;
                if (notificationARNs == null)
                {
                    Assert.IsFalse(request.Parameters.ContainsKey("NotificationARNs"));
                }
                else if (!notificationARNs.Any() && notificationARNs is not AutoConstructedList<string>)
                {
                    Assert.AreEqual(string.Empty, request.Parameters["NotificationARNs"]);
                }
            }
        }
    }
}
