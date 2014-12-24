using System;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.CloudFormation.Resources;
using Amazon.CloudFormation.Model;
using Amazon.CloudFormation;
using Amazon.Runtime;


namespace AWSSDK_DotNet.IntegrationTests.Tests.ResourceAPI
{
    [TestClass]
    public class CloudFormationTests
    {
        static Amazon.CloudFormation.Resources.CloudFormation cloudFormation;

        [ClassInitialize()]
        public static void Initialize(TestContext a)
        {
            cloudFormation = new Amazon.CloudFormation.Resources.CloudFormation();
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            cloudFormation.Dispose();           
        }

        [TestMethod]
        [TestCategory("CloudFormation")]
        public void TestCreateStack()
        {
            string stackName = "test-stack-" + DateTime.Now.Ticks;
            IStack stack = null;
            try
            {
                CreateStackRequest createRequest = new CreateStackRequest
                {
                    StackName = stackName,
                    TemplateBody = IntegrationTests.Tests.CloudFormation.TEMPLATE_TEXT
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

                stack = cloudFormation.CreateStack(createRequest);

                IntegrationTests.Tests.CloudFormation.WaitTillStackNotInProcess(stackName);                

                Assert.AreEqual(StackStatus.CREATE_COMPLETE, stack.StackStatus);
            }
            finally
            {
                IntegrationTests.Tests.CloudFormation.WaitTillStackNotInProcess(stackName);
                stack.Delete(new DeleteStackRequest());
            }
        }
    }
}
