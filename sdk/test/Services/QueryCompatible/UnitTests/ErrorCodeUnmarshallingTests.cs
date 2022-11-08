using System;
using System.Linq;
using System.Net;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Amazon.QueryCompatible.Model.Internal.MarshallTransformations;
using ServiceClientGenerator;
using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class QueryCompatibleUnmarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("aws-query-compatible");

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("QueryCompatible")]
        public void ModeledExceptionUnmarshalTest_When_HeaderIsPresent()
        {
            var response = GetJsonErrorResponse("AWS.SimpleQueueService.QueueDeletedRecently;Sender");
            Assert.AreEqual("AWS.SimpleQueueService.QueueDeletedRecently", response.ErrorCode);
            Assert.AreEqual(ErrorType.Sender, response.ErrorType);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("QueryCompatible")]
        public void ModeledExceptionUnmarshalTest_IgnoresErrorType_When_TypeUnparsable()
        {
            var response = GetJsonErrorResponse("AWS.SimpleQueueService.QueueDeletedRecently;Some");
            Assert.AreEqual("AWS.SimpleQueueService.QueueDeletedRecently", response.ErrorCode);
            Assert.AreEqual(ErrorType.Unknown, response.ErrorType);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("QueryCompatible")]
        public void ModeledExceptionUnmarshalTest_When_HeaderIsNotPresent()
        {
            var response = GetJsonErrorResponse(null);
            Assert.AreEqual("QueueDeletedRecently", response.ErrorCode);
            Assert.AreEqual(ErrorType.Unknown, response.ErrorType);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("QueryCompatible")]
        public void ModeledExceptionUnmarshalTest_When_HeaderIsIncomplete()
        {
            var response = GetJsonErrorResponse("AWS.SimpleQueueService.QueueDeletedRecently");
            Assert.AreEqual("QueueDeletedRecently", response.ErrorCode);
            Assert.AreEqual(ErrorType.Unknown, response.ErrorType);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("QueryCompatible")]
        public void ModeledExceptionUnmarshalTest_When_HeaderIsEmpty()
        {
            var response = GetJsonErrorResponse("");
            Assert.AreEqual("QueueDeletedRecently", response.ErrorCode);
            Assert.AreEqual(ErrorType.Unknown, response.ErrorType);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("QueryCompatible")]
        public void UnmodeledExceptionUnmarshalTest_WhenHeaderIsPresent()
        {
            var body = "{\"__type\":\"com.amazonaws.awsquerycompatible#AccessDeniedException\"}";
            var response = UnmarshalException(body, "AccessDeniedException", "AccessDenied;Sender");
            Assert.AreEqual("AccessDenied", response.ErrorCode);
            Assert.AreEqual(ErrorType.Sender, response.ErrorType);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("QueryCompatible")]
        public void UnmodeledExceptionUnmarshalTest_IgnoresErrorType_When_TypeUnparsable()
        {
            var body = "{\"__type\":\"com.amazonaws.awsquerycompatible#AccessDeniedException\"}";
            var response = UnmarshalException(body, "AccessDeniedException", "AccessDenied;Some");
            Assert.AreEqual("AccessDenied", response.ErrorCode);
            Assert.AreEqual(ErrorType.Unknown, response.ErrorType);
        }

        private AmazonServiceException UnmarshalException(string body, string exceptionName, string amznQueryErrorHeaderValue)
        {
            var webResponse = CreateResponse(body, exceptionName, amznQueryErrorHeaderValue);
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(body), true, webResponse, true);
            var response = CreateQueueResponseUnmarshaller.Instance.UnmarshallException(context, null, HttpStatusCode.BadRequest);
            return response;
        }

        private WebResponseData CreateResponse(string body, string exceptionName, string amznQueryErrorHeaderValue)
        {
            var webResponse = new WebResponseData
            {
                StatusCode = HttpStatusCode.ServiceUnavailable,
                Headers =
                {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType", exceptionName},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(body).Length.ToString()}
                }
            };
            if (amznQueryErrorHeaderValue != null)
                webResponse.Headers.Add("x-amzn-query-error", amznQueryErrorHeaderValue);
            return webResponse;
        }

        private AmazonServiceException GetJsonErrorResponse(string amznQueryErrorHeaderValue)
        {
            var operation = service_model.FindOperation("CreateQueue");
            var exception = operation.Exceptions.First(e => e.Name.Equals("QueueDeletedRecentlyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var response = UnmarshalException(jsonResponse, exception.ErrorCode, amznQueryErrorHeaderValue);
            return response;
        }
    }
}