using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3;
using Amazon.S3.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [Flags]
    public enum S3ConfigFlags { None=0, ArnRegion = 2, Accelerate=4, Dualstack=8, Fips=16, DisableMRAP=32 }

    public class S3ArnTestUtils
    {
        public static AmazonS3Config BuildFromRegionSystemName(string region, S3ConfigFlags flags)
        {
            return new AmazonS3Config
            {
                UseArnRegion = (flags & S3ConfigFlags.ArnRegion) != 0,
                UseAccelerateEndpoint = (flags & S3ConfigFlags.Accelerate) != 0,
                UseDualstackEndpoint = (flags & S3ConfigFlags.Dualstack) != 0,
                UseFIPSEndpoint = (flags & S3ConfigFlags.Fips) != 0,
                DisableMultiregionAccessPoints = (flags & S3ConfigFlags.DisableMRAP) != 0,
                RegionEndpoint = RegionEndpoint.GetBySystemName(region)
            };
        }

        public static IRequest RunMockRequest(AmazonWebServiceRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller)
        {
            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1
            };

            return RunMockRequest(request, marshaller, config);
        }

        public static IRequest RunMockRequest(AmazonWebServiceRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, AmazonS3Config config)
        {
            var pipeline = new RuntimePipeline(new List<IPipelineHandler>
            {
                new NoopPipelineHandler(),
                new Signer(),
                new ChecksumHandler(),
                new CompressionHandler(),
                new AmazonS3PostMarshallHandler(),
                new AmazonS3EndpointResolver(),
                new AmazonS3AuthSchemeHandler(),
                new Marshaller(),
                new AmazonS3PreMarshallHandler(),
            });

            var requestContext = new RequestContext(config.LogMetrics)
            {
                ClientConfig = config,
                Marshaller = marshaller,
                OriginalRequest = request,
                Unmarshaller = null,
                IsAsync = false,
            };
            var executionContext = new ExecutionContext(
                requestContext,
                new ResponseContext()
            );

            pipeline.InvokeSync(executionContext);

            // Since resource path substituation happens in the ComposeUrl method, which exists in the HttpHandler
            // we need to call ComposeUrl here to ensure the resource path is set correctly.
            // For an actual API call, it will always go through the HttpHandler so we need not worry about this.
            requestContext.Request.ResourcePath = AmazonServiceClient.ComposeUrl(requestContext.Request).AbsolutePath;
            return requestContext.Request;
        }
        public class NoopPipelineHandler : IPipelineHandler
        {
            public ILogger Logger { get; set; }
            public IPipelineHandler InnerHandler { get; set; }
            public IPipelineHandler OuterHandler { get; set; }

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
