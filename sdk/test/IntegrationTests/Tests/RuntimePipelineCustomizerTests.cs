using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime.Internal;
using Amazon.Runtime;
#if BCL45
using Amazon.S3;
#endif
using Amazon;
using Amazon.Runtime.Internal.Util;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
#if BCL45
    [TestClass]
    public class RuntimePipelineCustomizerTests
    {
        [TestMethod]
        public void RegisterPipelineHandler()
        {

            RuntimePipelineCustomizerRegistry.Instance.Register(new SpecialPipelineCustomizer());

            var s3Client = new AmazonS3Client(RegionEndpoint.USEast1);

            var currentCount = SpecialPipelineHandler.CallCount;
            s3Client.ListBuckets();

            Assert.IsTrue(SpecialPipelineHandler.CallCount > currentCount);


            RuntimePipelineCustomizerRegistry.Instance.Deregister(new SpecialPipelineCustomizer());
            currentCount = SpecialPipelineHandler.CallCount;

            s3Client = new AmazonS3Client(RegionEndpoint.USEast1);

            s3Client.ListBuckets();
            Assert.AreEqual(currentCount, SpecialPipelineHandler.CallCount);
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
#endif
}
