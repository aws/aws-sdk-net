using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.MediaStoreData.Model;
using System.Reflection;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Amazon;
using Amazon.MediaStoreData.Model.Internal.MarshallTransformations;

namespace AWSSDK_DotNet35.UnitTests
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
            Assert.AreEqual(internalRequest.ResourcePath, "/" + request.Path);
        }
    }
}
