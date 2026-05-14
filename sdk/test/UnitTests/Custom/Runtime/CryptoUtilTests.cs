#if !NETFRAMEWORK
using System;
using System.IO;
using System.Text;
using Amazon.Runtime;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class CryptoUtilTests
    {
        [TestMethod]
        [TestCategory("Core")]
        public void HMACSignFromString()
        {
            var actual = CryptoUtilFactory.CryptoInstance.HMACSign("HELLOWORLD", "HELLOKEY", SigningAlgorithm.HmacSHA256);

            Assert.AreEqual("LH+6qR+N6WU91evFKfjq/6NqiVES5BD6z6EHYsDwOUE=", actual);
        }

        [TestMethod]
        [TestCategory("Core")]
        public void ComputeMD5Hash_ByteArray_ReturnsCorrectHash()
        {
            var data = Encoding.UTF8.GetBytes("hello");
            var hash = CryptoUtilFactory.CryptoInstance.ComputeMD5Hash(data);
            var hex = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.AreEqual("5d41402abc4b2a76b9719d911017c592", hex);
        }

        [TestMethod]
        [TestCategory("Core")]
        public void ComputeMD5Hash_Stream_ReturnsCorrectHash()
        {
            var data = Encoding.UTF8.GetBytes("hello");
            using var stream = new MemoryStream(data);
            var hash = CryptoUtilFactory.CryptoInstance.ComputeMD5Hash(stream);
            var hex = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.AreEqual("5d41402abc4b2a76b9719d911017c592", hex);
        }

        [TestMethod]
        [TestCategory("Core")]
        public void ComputeMD5Hash_EmptyInput_ReturnsCorrectHash()
        {
            var hash = CryptoUtilFactory.CryptoInstance.ComputeMD5Hash(Array.Empty<byte>());
            var hex = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.AreEqual("d41d8cd98f00b204e9800998ecf8427e", hex);
        }
    }
}
#endif
