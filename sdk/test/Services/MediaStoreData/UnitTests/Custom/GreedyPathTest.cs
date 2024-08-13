using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.MediaStoreData.Model;
using System.Reflection;
using AWSSDK_DotNet.UnitTests.TestTools;
using Amazon;
using Amazon.MediaStoreData.Model.Internal.MarshallTransformations;
using Amazon.Util;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class GreedyPathTest
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("MediaStoreData")]
        public void GreedyPathStartingWithSlashTest()
        {
            var request = InstantiateClassGenerator.Execute<GetObjectRequest>();
            request.Path = "/TestPath/foo/bar";
            var marshaller = new GetObjectRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            internalRequest.ResourcePath = AWSSDKUtils.ResolveResourcePathV2(internalRequest.ResourcePath, internalRequest.PathResources);
            Assert.AreEqual(internalRequest.ResourcePath, request.Path);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("MediaStoreData")]
        public void GreedyPathStartingWithoutSlashTest()
        {
            var request = InstantiateClassGenerator.Execute<GetObjectRequest>();
            request.Path = "TestPath/foo/bar";
            var marshaller = new GetObjectRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            internalRequest.ResourcePath = AWSSDKUtils.ResolveResourcePathV2(internalRequest.ResourcePath, internalRequest.PathResources);
            Assert.AreEqual(internalRequest.ResourcePath, "/" + request.Path);
        }
    }
}
