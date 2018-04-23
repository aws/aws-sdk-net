using System;
using Amazon.RDS;
using Amazon.RDS.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.RDS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using AWSSDK_DotNet.CommonTest.Utils;
using Amazon;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Auth;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// This test doesn't test the correctness of the PreSignedUrl.
    /// It only tests that PreSignedUrlRequestHandler fills in the PresignedUrlProperty
    /// when it should, and passes requests through untouched when it should.
    /// Correctness will be tested when each individual use case is added.
    /// i.e. When we real request classes are made to implement IPreSignedUrlRequest.
    /// </summary>
    [TestClass]
    public class PreSignedUrlRequestHandlerTest
    {
        private static readonly string OriginalPreSignedUrlValue = Guid.NewGuid().ToString();
        private static readonly string OriginalOtherValue = Guid.NewGuid().ToString();

        [TestMethod]
        [TestCategory("RDS")]
        public void HandleNonPreSignedUrlRequest()
        {
            var request = new NonPreSignedUrlRequest()
            {
                OtherProperty = OriginalOtherValue
            };
            RunPreInvoke(request);
            Assert.AreEqual(OriginalOtherValue, request.OtherProperty);
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void HandlePreSignedUrlRequestNoSourceRegion()
        {
            var request = new PreSignedUrlRequest();
            RunPreInvoke(request);
            Assert.IsNull(request.PreSignedUrl);
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void HandlePreSignedUrlRequestPresignedUrlHasValue()
        {
            var request = new PreSignedUrlRequest()
            {
                OtherProperty = OriginalOtherValue,
                PreSignedUrl = OriginalPreSignedUrlValue,
                SourceRegion = RegionEndpoint.USWest1.SystemName
            };

            RunPreInvoke(request);

            Assert.AreEqual(OriginalOtherValue, request.OtherProperty);
            Assert.AreEqual(OriginalPreSignedUrlValue, request.PreSignedUrl);
            Assert.AreEqual(RegionEndpoint.USWest1.SystemName, request.SourceRegion);
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void HandlePreSignedUrlRequest()
        {
            var request = new PreSignedUrlRequest()
            {
                OtherProperty = OriginalOtherValue,
                SourceRegion = RegionEndpoint.USWest1.SystemName
            };

            RunPreInvoke(request);

            Assert.AreEqual(OriginalOtherValue, request.OtherProperty);
            Assert.IsTrue(request.PreSignedUrl.Contains("Key=Property%20with%20spaces"));
            Assert.IsTrue(request.PreSignedUrl.Contains("SpecialCharacter=%26%26"));
            Assert.AreEqual(RegionEndpoint.USWest1.SystemName, request.SourceRegion);            
            Assert.IsNotNull(request.PreSignedUrl);
        }

        private void RunPreInvoke(AmazonWebServiceRequest request)
        {
            var credentials = new BasicAWSCredentials("access_key", "secret_key");
            var handler = new PreSignedUrlRequestHandler(credentials);
            var requestContext = new RequestContext(false, new NullSigner());
            var responseContext = new ResponseContext();
            var executionContext = new ExecutionContext(requestContext, responseContext);
            var marshaller = new PreSignedUrlRequestMarshaller();
            var clientConfig = new AmazonRDSConfig();

            clientConfig.RegionEndpoint = RegionEndpoint.EUWest1;
            requestContext.OriginalRequest = request;
            requestContext.Marshaller = marshaller;
            requestContext.ClientConfig = clientConfig;

            // There's extra baggage involved in testing via PreSignedUrlRequestHandler.Invoke.
            // So just call PreInvoke since that's where all the relevant logic is anyway.
            ReflectionHelpers.Invoke(handler, "PreInvoke", executionContext);
        }

        /// <summary>
        /// For a real request, the generator would generate this partial class.
        /// </summary>
        private partial class PreSignedUrlRequest : AmazonWebServiceRequest
        {
            public string PreSignedUrl { get; set; }
            public string OtherProperty { get; set; }
        }

        /// <summary>
        /// This is how we make the handler populate PreSignedUrl, by implementing IPreSignedUrlRequest.
        /// We add this partial class manually.
        /// </summary>
        private partial class PreSignedUrlRequest : AmazonWebServiceRequest, IPreSignedUrlRequest
        {
            public string SourceRegion { get; set; }
            
        }

        /// <summary>
        /// This would be generated.
        /// </summary>
        private class PreSignedUrlRequestMarshaller : IMarshaller<IRequest, PreSignedUrlRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
        {
            public IRequest Marshall(AmazonWebServiceRequest input)
            {
                return this.Marshall((PreSignedUrlRequest)input);
            }

            public IRequest Marshall(PreSignedUrlRequest publicRequest)
            {
                IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
                request.Parameters.Add("Action", "PreSignedUrl");
                request.Parameters.Add("Version", "2014-10-31");
                request.Parameters.Add("PreSignedUrl", publicRequest.PreSignedUrl);
                request.Parameters.Add("OtherProperty", publicRequest.OtherProperty);
                request.Parameters.Add("Key", "Property with spaces");
                request.Parameters.Add("SpecialCharacter", "&&");

                return request;
            }
        }

        private class NonPreSignedUrlRequest : AmazonWebServiceRequest
        {
            public string OtherProperty { get; set; }
        }

    }
}
