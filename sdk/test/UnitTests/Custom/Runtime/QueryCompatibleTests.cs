using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.SQS.Model.Internal.MarshallTransformations;
using AWSSDK_DotNet.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
namespace AWSSDK.UnitTests
{
    [TestClass]
    public class QueryCompatibleTests : RuntimePipelineTestBase<ErrorHandler>
    {
        [ClassInitialize]
        public static void Initialize(TestContext t)
        {
            var logger =
                 Amazon.Runtime.Internal.Util.Logger.GetLogger(new object().GetType());
            Handler = new ErrorHandler(logger);
            RuntimePipeline.AddHandler(Handler);
        }

        [TestMethod]
        public void ValidateSdkCanParseCodeField()
        {
            Tester.Reset();
            Tester.Action = (int callcount) =>
            {
                var errorResponse = (HttpWebResponse)MockWebResponse.CreateFromResource("QueryCompatibleTC1.txt");
                throw new HttpErrorResponseException(new HttpWebRequestResponseData(errorResponse));
            };
            var config = new AmazonSQSConfig();
            config.RegionEndpoint = Amazon.RegionEndpoint.USEast1;

            var context = CreateTestContext(null, GetQueueUrlResponseUnmarshaller.Instance, config);
            var exception = Utils.AssertExceptionExpected(() =>
            {
                RuntimePipeline.InvokeSync(context);
            }, typeof(AmazonSQSException));
            Assert.IsNotNull(((AmazonSQSException)exception).ErrorCode);
            Assert.AreEqual("AWS.SimpleQueueService.NonExistentQueue", ((AmazonSQSException)exception).ErrorCode);
        }

        [TestMethod]
        public void ValidateSdkCanHandleMissingCodeField()
        {
            Tester.Reset();
            Tester.Action = (int callcount) =>
            {
                var errorResponse = (HttpWebResponse)MockWebResponse.CreateFromResource("QueryCompatibleTC2.txt");
                throw new HttpErrorResponseException(new HttpWebRequestResponseData(errorResponse));
            };
            var config = new AmazonSQSConfig();
            config.RegionEndpoint = Amazon.RegionEndpoint.USEast1;

            var context = CreateTestContext(null, GetQueueUrlResponseUnmarshaller.Instance, config);
            var exception = Utils.AssertExceptionExpected(() =>
            {
                RuntimePipeline.InvokeSync(context);
            }, typeof(AmazonSQSException));
            Assert.IsNotNull(((AmazonSQSException)exception).ErrorCode);
            Assert.AreEqual("QueueDoesNotExist", ((AmazonSQSException)exception).ErrorCode);
        }

        [TestMethod]
        public void ValidateSdkCanParseTypeField()
        {
            Tester.Reset();
            Tester.Action = (int callcount) =>
            {
                var errorResponse = (HttpWebResponse)MockWebResponse.CreateFromResource("QueryCompatibleTC3.txt");
                throw new HttpErrorResponseException(new HttpWebRequestResponseData(errorResponse));
            };
            var config = new AmazonSQSConfig();
            config.RegionEndpoint = Amazon.RegionEndpoint.USEast1;

            var context = CreateTestContext(null, GetQueueUrlResponseUnmarshaller.Instance, config);
            var exception = Utils.AssertExceptionExpected(() =>
            {
                RuntimePipeline.InvokeSync(context);
            }, typeof(AmazonSQSException));
            Assert.IsNotNull(((AmazonSQSException)exception).ErrorCode);
            Assert.AreEqual(ErrorType.Sender, ((AmazonSQSException)exception)
                .ErrorType);
            Assert.AreEqual<string>("Sender", ((AmazonSQSException)exception)
                .ErrorType.ToString());
        }

        protected override IExecutionContext CreateTestContext(AbstractAWSSigner signer, ResponseUnmarshaller responseUnmarshaller, ClientConfig config)
        {
            var getQueueUrlRequest = new GetQueueUrlRequest
            {
                QueueName = "test-queue"
            };
            var requestContext = new RequestContext(true, new NullSigner())
            {
                OriginalRequest = getQueueUrlRequest,
                Request = new GetQueueUrlRequestMarshaller().Marshall(getQueueUrlRequest),
                Unmarshaller = responseUnmarshaller,
                ClientConfig = config
            };
            return new Amazon.Runtime.Internal.ExecutionContext(requestContext,
                new ResponseContext
                {

                });
        }

    }
}
