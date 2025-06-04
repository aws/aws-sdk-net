using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.SQS.Model.Internal.MarshallTransformations;
using Amazon.Util;
using AWSSDK_DotNet.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for the AwsQueryCompatibleTrait for services that want to migrate to AWSJSON away from the query protocol
    /// If the service sets the AwsQueryCompatible trait then they will send an addiaional Http header x-amzn-query-error
    /// containing a semicolon delimited pair, Code and Type. For example: **x-amzn-query-error: AWS.SimpleQueueService.NonExistentQueue;Sender**
    /// If AwsQueryCompatibleTrait is set then the SDK will also send an additional header x-amzn-query-mode: 'true' to the service.
    /// </summary>
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

            var context = CreateTestContext(null, GetQueueUrlResponseUnmarshaller.Instance, null);
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

            var context = CreateTestContext(null, GetQueueUrlResponseUnmarshaller.Instance, null);
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

            var context = CreateTestContext(null, GetQueueUrlResponseUnmarshaller.Instance, null);
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

        [TestMethod]
        public void ValidateSdkSendsXAmzQueryModeWhenServiceHasAwsQueryCompatibleTrait()
        {
            // even though TC4 is for a request, since we only care about the headers we cast it to a HttpWebResponse to make use
            // of the helper method
            var expectedRequest = (HttpWebResponse)MockWebResponse.CreateFromResource("QueryCompatibleTC4.txt");
            var getQueueUrlRequest = new GetQueueUrlRequest
            {
                QueueName = "test-queue"
            };

            var actualRequest = GetQueueUrlRequestMarshaller.Instance.Marshall(getQueueUrlRequest);
            Assert.IsNotNull(actualRequest.Headers[HeaderKeys.XAmzQueryMode]);
            Assert.AreEqual<string>(actualRequest.Headers[HeaderKeys.XAmzQueryMode], expectedRequest.Headers[HeaderKeys.XAmzQueryMode]);      
        }

        protected override IExecutionContext CreateTestContext(AbstractAWSSigner signer, ResponseUnmarshaller responseUnmarshaller, ClientConfig config)
        {
            if (config == null)
            {
                config = new AmazonSQSConfig
                {
                    RegionEndpoint = Amazon.RegionEndpoint.USEast1
                };
            }

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
