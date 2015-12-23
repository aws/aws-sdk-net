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
using Amazon.Util;

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

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestDetermineRegionFromURL()
        {
            Assert.AreEqual("eu-west-1", AWSSDKUtils.DetermineRegion("https://autoscaling.eu-west-1.amazonaws.com/"));
            Assert.AreEqual("eu-west-1", AWSSDKUtils.DetermineRegion("https://cognito-identity.eu-west-1.amazonaws.com/"));
            Assert.AreEqual("us-east-1", AWSSDKUtils.DetermineRegion("https://route53.amazonaws.com/"));
            Assert.AreEqual("us-east-1", AWSSDKUtils.DetermineRegion("https://s3.amazonaws.com/"));
            Assert.AreEqual("us-east-1", AWSSDKUtils.DetermineRegion("https://s3-external-1.amazonaws.com/"));
            Assert.AreEqual("eu-central-1", AWSSDKUtils.DetermineRegion("https://s3-eu-central-1.amazonaws.com/"));
            Assert.AreEqual("eu-central-1", AWSSDKUtils.DetermineRegion("https://s3.eu-central-1.amazonaws.com/"));
            Assert.AreEqual("us-west-2", AWSSDKUtils.DetermineRegion("https://streams.dynamodb.us-west-2.amazonaws.com/"));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestCanonicalizeResourcePath()
        {
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePath(null, null));
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePath(null, string.Empty));
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://ec2.us-west-1.amazonaws.com"), null));
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://ec2.us-west-1.amazonaws.com"), string.Empty));
            Assert.AreEqual("/custompath", AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://customhost/custompath"), null));
            Assert.AreEqual("/custompath", AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://customhost/custompath"), string.Empty));

            Assert.AreEqual(
                "/vx_folder/1.0%5Cdatafiles%5Cfile.json",
                AWSSDKUtils.CanonicalizeResourcePath(null, @"/vx_folder/1.0\datafiles\file.json"));

            Assert.AreEqual(
                "/vx_folder/1.0%5Cdatafiles%5Cfile.json",
                AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://s3-eu-west-1.amazonaws.com/"), @"/vx_folder/1.0\datafiles\file.json"));

            Assert.AreEqual(
                "/custompath/vx_folder/1.0%5Cdatafiles%5Cfile.json",
                AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://customhost/custompath"), @"/vx_folder/1.0\datafiles\file.json"));
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
