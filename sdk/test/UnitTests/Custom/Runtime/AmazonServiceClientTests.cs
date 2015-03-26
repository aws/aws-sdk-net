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
using Amazon.ElasticTranscoder;
using Amazon.ElasticTranscoder.Model;
using Amazon;
using Amazon.Runtime.Internal;

namespace AWSSDK.UnitTests
{    
    [TestClass]
    public class AmazonServiceClientTests
    {
        static AmazonElasticTranscoderClient _client = null;

        [ClassInitialize]
        public static void BuildRuntimePipeline(TestContext t)
        {
            _client = new MockElasticTranscoderClient(new BasicAWSCredentials("access_key", "secret_key"),
                new AmazonElasticTranscoderConfig
                {
                    ServiceURL = @"http://EtsListPresets"
                });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestSuccessfulCall()
        {
            var presets = _client.ListPresets();
        }

#if BCL45
        [TestMethod]
        [TestCategory("UnitTest")]
        public async Task TestSuccessfulCallAsync()
        {
            var presets = await _client.ListPresetsAsync(new ListPresetsRequest());
        }
#elif !BCL45 && BCL
        [TestMethod][TestCategory("UnitTest")]
        public void TestSuccessfulCallAsync()
        {
            var asyncResult = _client.BeginListPresets(new ListPresetsRequest(),null,null);
            asyncResult.AsyncWaitHandle.WaitOne();
            var presets = _client.EndListPresets(asyncResult);
        }
#endif
    }

    public class MockElasticTranscoderClient : AmazonElasticTranscoderClient
    {
        private AWSSDK.UnitTests.HttpHandlerTests.MockHttpRequestFactory _requestFactory = null;

        public Action GetResponseAction
        {
            set { _requestFactory.GetResponseAction = value; }
        }


        public MockElasticTranscoderClient(AWSCredentials credentials, AmazonElasticTranscoderConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        public void Reset()
        {
            this.GetResponseAction = null;
        }

        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            _requestFactory = new AWSSDK.UnitTests.HttpHandlerTests.MockHttpRequestFactory();
            var httpHandler = new HttpHandler<Stream>(_requestFactory, this);

            pipeline.ReplaceHandler<HttpHandler<Stream>>(httpHandler);
        }
    }
}
