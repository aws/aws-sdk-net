using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.IO;
using Amazon.Runtime.Internal.Util;
using Amazon;

namespace AWSSDK.UnitTests.Runtime
{
    [TestClass]
    public class CachingWrapperStreamTests
    {
        private Stream _baseStream;

        [TestInitialize]
        public void Init()
        {
            _baseStream = new MemoryStream(Enumerable.Repeat((byte) 0x20, 10).ToArray());
            AWSConfigs.LoggingConfig.LogResponsesSizeLimit = 5;
        }

        [TestMethod]
        [TestCategory("Runtime")]
        public void ReadBytes_NoLimit()
        {
            var cachingWrapperStream = new CachingWrapperStream(_baseStream);

            var binaryReader = new BinaryReader(cachingWrapperStream);
            binaryReader.ReadBytes((int)_baseStream.Length);

            Assert.AreEqual(10, cachingWrapperStream.AllReadBytes.Count);
            Assert.AreEqual(5, cachingWrapperStream.LoggableReadBytes.Count);
        }

        [TestMethod]
        [TestCategory("Runtime")]
        public void ReadBytes_SmallerLimit()
        {
            var cachingWrapperStream = new CachingWrapperStream(_baseStream, 2);

            var binaryReader = new BinaryReader(cachingWrapperStream);
            binaryReader.ReadBytes((int)_baseStream.Length);

            Assert.AreEqual(2, cachingWrapperStream.AllReadBytes.Count);
            Assert.AreEqual(2, cachingWrapperStream.LoggableReadBytes.Count);
        }

        [TestMethod]
        [TestCategory("Runtime")]
        public void ReadBytes_BiggerLimit()
        {
            var cachingWrapperStream = new CachingWrapperStream(_baseStream, 15);

            var binaryReader = new BinaryReader(cachingWrapperStream);
            binaryReader.ReadBytes((int)_baseStream.Length);

            Assert.AreEqual(10, cachingWrapperStream.AllReadBytes.Count);
            Assert.AreEqual(10, cachingWrapperStream.LoggableReadBytes.Count);
        }
    }
}
