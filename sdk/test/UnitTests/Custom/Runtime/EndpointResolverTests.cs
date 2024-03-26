using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.SecurityToken.Model.Internal.MarshallTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class EndpointResolverTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSuccessfulCall()
        {
            var endpointResolver = new EndpointResolver();            
            var executionContext = CreateExecutionContext(SetupConfig());
            Uri endpoint = endpointResolver.DetermineEndpoint(executionContext.RequestContext);

            Assert.AreEqual(@"https://testprefix.test123-s3.us-east-1.amazonaws.com/", endpoint.ToString());
        }

        [DataTestMethod]
        [DataRow(StsRegionalEndpointsValue.Regional, "us-east-1", @"https://sts.us-east-1.amazonaws.com/")]
        [DataRow(StsRegionalEndpointsValue.Regional, "us-west-2", @"https://sts.us-west-2.amazonaws.com/")]
        [DataRow(StsRegionalEndpointsValue.Regional, "cn-north-1", @"https://sts.cn-north-1.amazonaws.com.cn/")]
        [DataRow(StsRegionalEndpointsValue.Regional, "ap-east-1", @"https://sts.ap-east-1.amazonaws.com/")]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestDetermineEndpointStsFlag(StsRegionalEndpointsValue stsRegionalFlag, string region, string expected)
        {
            var endpointResolver = new EndpointResolver();
            var executionContext = CreateExecutionContextSTS(SetupSTSConfig(RegionEndpoint.GetBySystemName(region), stsRegionalFlag));
            Uri endpoint = endpointResolver.DetermineEndpoint(executionContext.RequestContext);
            Assert.AreEqual(expected, endpoint.ToString());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestDisableHostPrefixInjection()
        {   
            var config = SetupConfig();
            config.DisableHostPrefixInjection = true;

            var endpointResolver = new EndpointResolver();
            var executionContext = CreateExecutionContext(config);
            Uri endpoint = endpointResolver.DetermineEndpoint(executionContext.RequestContext);

            Assert.AreEqual(@"https://s3.us-east-1.amazonaws.com/", endpoint.ToString());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestNoHostPrefix()
        {
            var config = SetupConfig();
            config.DisableHostPrefixInjection = true;

            var endpointResolver = new EndpointResolver();
            var executionContext = CreateExecutionContext(config);
            executionContext.RequestContext.Request.HostPrefix = string.Empty;
            Uri endpoint = endpointResolver.DetermineEndpoint(executionContext.RequestContext);

            Assert.AreEqual(@"https://s3.us-east-1.amazonaws.com/", endpoint.ToString());
        }

        private ExecutionContext CreateExecutionContext(IClientConfig config)
        {
            var listBucketsRequest = new ListBucketsRequest();       
            var executionContext = new ExecutionContext(
                new RequestContext(true, new NullSigner())
                {
                    ClientConfig = config,                    
                    Request = new ListBucketsRequestMarshaller().Marshall(listBucketsRequest)                    
                },
                new ResponseContext()
            );

            executionContext.RequestContext.Request.HostPrefix = "TestPrefix.Test123-";
            return executionContext;
        }

        private ExecutionContext CreateExecutionContextSTS(IClientConfig config)
        {
            var stsRequest = new AssumeRoleRequest();
            var executionContext = new ExecutionContext(
                new RequestContext(true, new NullSigner())
                {
                    ClientConfig = config,
                    Request = new AssumeRoleRequestMarshaller().Marshall(stsRequest)
                },
                new ResponseContext()
            );
            return executionContext;
        }

        private static AmazonS3Config SetupConfig()
        {        
            var config = new AmazonS3Config();
            config.RegionEndpoint = RegionEndpoint.USEast1;
            return config;
        }

        private static AmazonSecurityTokenServiceConfig SetupSTSConfig(RegionEndpoint endpoint, StsRegionalEndpointsValue stsRegionalEndpoints)
        {
            var config = new AmazonSecurityTokenServiceConfig();
            config.RegionEndpoint = endpoint;
            config.StsRegionalEndpoints = stsRegionalEndpoints;
            return config;
        }
    }
}
