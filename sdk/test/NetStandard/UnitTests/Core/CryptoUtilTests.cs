using System;
using System.IO;
using System.Text;
using Amazon.Runtime;
using Amazon.Util;
using Xunit;

namespace UnitTests.NetStandard.Core
{
    public class CryptoUtilTests
    {
        [Fact]
        [Trait("Category", "Core")]
        public void HMACSignFromString()
        {
            var actual = CryptoUtilFactory.CryptoInstance.HMACSign("HELLOWORLD", "HELLOKEY", SigningAlgorithm.HmacSHA256);

            Assert.Equal("LH+6qR+N6WU91evFKfjq/6NqiVES5BD6z6EHYsDwOUE=", actual);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void ComputeMD5Hash_ByteArray_ReturnsCorrectHash()
        {
            var data = Encoding.UTF8.GetBytes("hello");
            var hash = CryptoUtilFactory.CryptoInstance.ComputeMD5Hash(data);
            var hex = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.Equal("5d41402abc4b2a76b9719d911017c592", hex);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void ComputeMD5Hash_Stream_ReturnsCorrectHash()
        {
            var data = Encoding.UTF8.GetBytes("hello");
            using var stream = new MemoryStream(data);
            var hash = CryptoUtilFactory.CryptoInstance.ComputeMD5Hash(stream);
            var hex = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.Equal("5d41402abc4b2a76b9719d911017c592", hex);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void ComputeMD5Hash_EmptyInput_ReturnsCorrectHash()
        {
            var hash = CryptoUtilFactory.CryptoInstance.ComputeMD5Hash(Array.Empty<byte>());
            var hex = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.Equal("d41d8cd98f00b204e9800998ecf8427e", hex);
        }
    }
}
