using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.QueryCompatible;
using Amazon.QueryCompatible.Model;
using Amazon.QueryCompatible.Model.Internal.MarshallTransformations;


using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;
using Amazon.Util;

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
        public void ModeledExcceptionUnmarshalTest()
        {
            var response = GetJsonErrorResponse(
                "{\"__type\":\"com.amazonaws.awsquerycompatible#QueueDeletedRecently\",\"message\":\"some-message\"}", "AWS.SimpleQueueService.QueueDeletedRecently");
            Console.WriteLine(response.ErrorCode);
            
        }

        private QueueDeletedRecentlyException GetJsonErrorResponse(string body, string amznQueryErrorHeaderValue)
        {
            body = body ?? string.Empty;
            var webResponse = new WebResponseData
            {
                StatusCode = HttpStatusCode.BadRequest,
                Headers = {}
            };

            if (amznQueryErrorHeaderValue != null)
                webResponse.Headers.Add("x-amzn-query-error", amznQueryErrorHeaderValue);
            Console.WriteLine(webResponse.Headers);
            var context = new JsonUnmarshallerContext(AWSSDK_DotNet35.UnitTests.Utils.CreateStreamFromString(body), true, webResponse, true);
            Console.WriteLine(context.ResponseData.GetHeaderNames());
            return QueueDeletedRecentlyExceptionUnmarshaller.Instance.Unmarshall(context);
        }
    }
}