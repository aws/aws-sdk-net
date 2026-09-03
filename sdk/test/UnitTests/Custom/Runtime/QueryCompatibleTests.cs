using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for <see cref="AwsQueryCompatibleErrorHandler"/>, the Core helper used by services that
    /// opt into the AwsQueryCompatible trait when migrating to AWSJSON away from the query protocol.
    /// Such services return an x-amzn-query-error header containing a semicolon delimited Code and Type
    /// pair (for example: "AWS.SimpleQueueService.NonExistentQueue;Sender"). When present, that header
    /// takes precedence over the code/type parsed from the response body.
    ///
    /// This exercises the shared Core logic directly (no service reference, no wire protocol) so it is
    /// unaffected by any individual service's choice of protocol.
    /// </summary>
    [TestClass]
    public class QueryCompatibleTests
    {
        private static Mock<IWebResponseData> ResponseWithQueryError(string queryErrorHeader)
        {
            var responseData = new Mock<IWebResponseData>();
            responseData.Setup(r => r.IsHeaderPresent(HeaderKeys.XAmzQueryError)).Returns(queryErrorHeader != null);
            responseData.Setup(r => r.GetHeaderValue(HeaderKeys.XAmzQueryError)).Returns(queryErrorHeader);
            return responseData;
        }

        [TestMethod]
        public void QueryErrorHeader_WithCodeAndType_OverridesCodeAndType()
        {
            var errorResponse = new ErrorResponse { Code = "QueueDoesNotExist", Type = ErrorType.Unknown };
            var responseData = ResponseWithQueryError("AWS.SimpleQueueService.NonExistentQueue;Sender");

            AwsQueryCompatibleErrorHandler.ApplyQueryErrorHeader(errorResponse, responseData.Object);

            Assert.AreEqual("AWS.SimpleQueueService.NonExistentQueue", errorResponse.Code);
            Assert.AreEqual(ErrorType.Sender, errorResponse.Type);
        }

        [TestMethod]
        public void QueryErrorHeader_Absent_LeavesErrorResponseUnchanged()
        {
            var errorResponse = new ErrorResponse { Code = "QueueDoesNotExist", Type = ErrorType.Unknown };
            var responseData = ResponseWithQueryError(null);

            AwsQueryCompatibleErrorHandler.ApplyQueryErrorHeader(errorResponse, responseData.Object);

            // Without the header, the code/type parsed from the body are left untouched.
            Assert.AreEqual("QueueDoesNotExist", errorResponse.Code);
            Assert.AreEqual(ErrorType.Unknown, errorResponse.Type);
        }

        [TestMethod]
        public void QueryErrorHeader_Malformed_LeavesErrorResponseUnchanged()
        {
            var errorResponse = new ErrorResponse { Code = "QueueDoesNotExist", Type = ErrorType.Unknown };
            // Missing the semicolon delimiter, so the header is ignored.
            var responseData = ResponseWithQueryError("AWS.SimpleQueueService.NonExistentQueue");

            AwsQueryCompatibleErrorHandler.ApplyQueryErrorHeader(errorResponse, responseData.Object);

            Assert.AreEqual("QueueDoesNotExist", errorResponse.Code);
            Assert.AreEqual(ErrorType.Unknown, errorResponse.Type);
        }
    }
}
