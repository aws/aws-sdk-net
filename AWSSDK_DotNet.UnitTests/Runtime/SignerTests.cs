using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet35.UnitTests;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Util;
using System.Threading;
using System.Net;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal;

namespace AWSSDK.UnitTests
{
    [TestClass()]
    public class SignerTests : RuntimePipelineTestBase
    {
        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSignerWithAnonymousCredentials()
        {            
            var pipeline = new RuntimePipeline(new MockHandler());
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new AnonymousAWSCredentials()));

            var context = CreateTestContext();
            var signer = new MockSigner();
            ((RequestContext)context.RequestContext).Signer = signer;
            pipeline.InvokeSync(context);

            Assert.IsTrue(context.RequestContext.IsSigned);
            Assert.AreEqual(0, signer.SignCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSignerWithBasicCredentials()
        {
            var pipeline = new RuntimePipeline(new MockHandler());            
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new BasicAWSCredentials("accessKey", "secretKey")));

            var context = CreateTestContext();
            var signer = new MockSigner();
            ((RequestContext)context.RequestContext).Signer = signer;
            pipeline.InvokeSync(context);

            Assert.IsTrue(context.RequestContext.IsSigned);
            Assert.AreEqual(1, signer.SignCount);
        }

#if BCL45
        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task TestSignerWithBasicCredentialsAsync()
        {
            var pipeline = new RuntimePipeline(new MockHandler());            
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new BasicAWSCredentials("accessKey", "secretKey")));

            var context = CreateTestContext();
            var signer = new MockSigner();
            ((RequestContext)context.RequestContext).Signer = signer;
            await pipeline.InvokeAsync<AmazonWebServiceResponse>(context);

            Assert.IsTrue(context.RequestContext.IsSigned);
            Assert.AreEqual(1, signer.SignCount);
        }
#elif !BCL45 && BCL
        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async35")]
        public void TestSignerWithBasicCredentialsAsync()
        {
            var pipeline = new RuntimePipeline(new MockHandler());
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new BasicAWSCredentials("accessKey", "secretKey")));

            var context = CreateAsyncTestContext();
            var signer = new MockSigner();
            ((RequestContext)context.RequestContext).Signer = signer;
            var asyncResult = pipeline.InvokeAsync(context);
            asyncResult.AsyncWaitHandle.WaitOne();

            Assert.IsTrue(context.RequestContext.IsSigned);
            Assert.AreEqual(1, signer.SignCount);
        }
#endif
    }
}
