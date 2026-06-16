using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    public class RuntimePipelineCustomizerTests
    {
        [Fact]
        public async Task RegisterPipelineHandler()
        {
            RuntimePipelineCustomizerRegistry.Instance.Register(new SpecialPipelineCustomizer());

            var s3Client = new AmazonS3Client(RegionEndpoint.USEast1);
            var currentCount = SpecialPipelineHandler.CallCount;
            await s3Client.ListBucketsAsync();
            Assert.True(SpecialPipelineHandler.CallCount > currentCount);

            RuntimePipelineCustomizerRegistry.Instance.Deregister(new SpecialPipelineCustomizer());
        }

        public class SpecialPipelineCustomizer : IRuntimePipelineCustomizer
        {
            public string UniqueName { get { return "Integ Tests"; } }

            public void Customize(Type type, RuntimePipeline pipeline)
            {
                pipeline.AddHandler(new SpecialPipelineHandler());
            }
        }


        public class SpecialPipelineHandler : PipelineHandler
        {
            public static int CallCount = 0;
            public override void InvokeSync(IExecutionContext executionContext)
            {
                CallCount++;
                base.InvokeSync(executionContext);
            }

            public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
            {
                CallCount++;
                return base.InvokeAsync<T>(executionContext);
            }
        }
    }
}
