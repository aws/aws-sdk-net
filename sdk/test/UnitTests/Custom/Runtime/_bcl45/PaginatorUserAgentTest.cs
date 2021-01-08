using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon;
using System.Reflection;

namespace AWSSDK.UnitTests.Runtime
{
    [TestClass]
    public class PaginatorUserAgentTest
    {
        [TestMethod]
        [TestCategory("Runtime")]
        public void TestUserAgentAdditionForPaginators()
        {
            var request = new ListObjectsV2Request
            {
                BucketName = "test"
            };
            PaginatorUtils.SetUserAgentAdditionOnRequest(request);
            var internalRequest = RunMockRequest(request, ListObjectsV2RequestMarshaller.Instance);
            var propertyInfo = typeof(AmazonWebServiceRequest).GetProperty("UserAgentAddition",
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            Assert.AreEqual(" Paginator", propertyInfo.GetValue(request, null));
            Assert.IsTrue(internalRequest.Headers[HeaderKeys.UserAgentHeader].EndsWith(" Paginator"));
        }

        private IRequest RunMockRequest(AmazonWebServiceRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller)
        {
            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1
            };

            return RunMockRequest(request, marshaller, config);
        }

        private IRequest RunMockRequest(AmazonWebServiceRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, AmazonS3Config config)
        {
            var pipeline = new RuntimePipeline(new List<IPipelineHandler>
            {
                new NoopPipelineHandler(),
                new Marshaller()
            });

            var requestContext = new RequestContext(config.LogMetrics, new AWS4Signer())
            {
                ClientConfig = config,
                Marshaller = marshaller,
                OriginalRequest = request,
                Unmarshaller = null,
                IsAsync = false
            };
            var executionContext = new ExecutionContext(
                requestContext,
                new ResponseContext()
            );

            pipeline.InvokeSync(executionContext);

            return requestContext.Request;
        }

        public class NoopPipelineHandler : IPipelineHandler
        {
            public ILogger Logger { get; set; }
            public IPipelineHandler InnerHandler { get; set; }
            public IPipelineHandler OuterHandler { get; set; }

            public void AsyncCallback(IAsyncExecutionContext executionContext)
            {
            }

            public IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
            {
                return null;
            }


            public virtual System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
                where T : AmazonWebServiceResponse, new()
            {
                return null;
            }

            public void InvokeSync(IExecutionContext executionContext)
            {
            }
        }
    }
}
