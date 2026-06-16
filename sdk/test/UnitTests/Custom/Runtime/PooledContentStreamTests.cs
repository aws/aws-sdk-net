using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Compression;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class PooledContentStreamTests
    {
#if !NETFRAMEWORK
        [TestMethod]
        public void PooledContentStream_ExposesWrittenContent()
        {
            var payload = Encoding.UTF8.GetBytes("{\"key\":\"value\"}");
            using var stream = CreatePooledStreamWithData(payload);

            CollectionAssert.AreEqual(payload, stream.Content.ToArray());
            Assert.AreEqual(payload.Length, stream.Length);
        }

        [TestMethod]
        public void PooledContentStream_SupportsReadAndSeek()
        {
            var payload = Encoding.UTF8.GetBytes("hello world");
            using var stream = CreatePooledStreamWithData(payload);

            // Read first 5 bytes
            var buffer = new byte[5];
            int read = stream.Read(buffer, 0, 5);
            Assert.AreEqual(5, read);
            CollectionAssert.AreEqual(Encoding.UTF8.GetBytes("hello"), buffer);

            // Seek back to beginning
            stream.Seek(0, SeekOrigin.Begin);
            Assert.AreEqual(0, stream.Position);

            // Read full content
            var fullBuffer = new byte[payload.Length];
            read = stream.Read(fullBuffer, 0, fullBuffer.Length);
            Assert.AreEqual(payload.Length, read);
            CollectionAssert.AreEqual(payload, fullBuffer);
        }

        [TestMethod]
        public void PooledContentStream_Dispose_IsIdempotent()
        {
            var stream = CreatePooledStreamWithData(Encoding.UTF8.GetBytes("test"));

            stream.Dispose();
            stream.Dispose();

            Assert.AreEqual(0, stream.Length);
        }

        [TestMethod]
        public void DefaultRequest_Dispose_DisposesContentStream()
        {
            var request = CreateRequest();
            request.ContentStream = CreatePooledStreamWithData(Encoding.UTF8.GetBytes("test"));

            request.Dispose();

            Assert.IsNull(request.ContentStream);
        }

        [TestMethod]
        public void ComputeContentStreamHash_MatchesByteArrayHash()
        {
            var payload = Encoding.UTF8.GetBytes("{\"MessageBody\":\"hello world\"}");

            var request = CreateRequest();
            request.Endpoint = new Uri("https://sqs.us-east-1.amazonaws.com");
            request.ContentStream = CreatePooledStreamWithData(payload);

            var hashFromStream = request.ComputeContentStreamHash();

            byte[] expectedHashBytes = CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(payload);
            var expectedHash = AWSSDKUtils.ToHex(expectedHashBytes, true);

            Assert.AreEqual(expectedHash, hashFromStream);
        }

        [TestMethod]
        public void ComputeContentStreamHash_IsCached()
        {
            var payload = Encoding.UTF8.GetBytes("test payload");
            var request = CreateRequest();
            request.ContentStream = CreatePooledStreamWithData(payload);

            var hash1 = request.ComputeContentStreamHash();
            var hash2 = request.ComputeContentStreamHash();

            Assert.AreSame(hash1, hash2);
        }

        /// <summary>
        /// Verifies that compression reads from the pooled buffer correctly and the
        /// decompressed output matches the original payload.
        /// </summary>
        [TestMethod]
        public void CompressionHandler_CompressesPooledContentStream()
        {
            // Create a payload large enough to trigger compression (> default 10KB threshold)
            var payload = Encoding.UTF8.GetBytes(new string('X', 11000));
            var request = CreateRequest();
            request.ContentStream = CreatePooledStreamWithData(payload);
            request.CompressionAlgorithm = CompressionEncodingAlgorithm.gzip;

            var handler = new CompressionHandler();
            handler.InnerHandler = new NoOpHandler();

            var config = new MockClientConfig();
            config.RequestMinCompressionSizeBytes = 1024;

            var executionContext = new ExecutionContext(
                new RequestContext(true, new NullSigner())
                {
                    ClientConfig = config,
                    OriginalRequest = new TestRequest(),
                    Request = request,
                    Options = new InvokeOptions(),
                },
                new ResponseContext()
            );

            handler.InvokeSync(executionContext);

            // PooledContentStream should be disposed and cleared
            Assert.IsNull(request.ContentStream);
            // Content should be set to compressed bytes
            Assert.IsNotNull(request.Content);

            // Decompress and verify it matches the original
            using var compressedStream = new MemoryStream(request.Content);
            using var gzipStream = new GZipStream(compressedStream, CompressionMode.Decompress);
            using var decompressedStream = new MemoryStream();
            gzipStream.CopyTo(decompressedStream);

            CollectionAssert.AreEqual(payload, decompressedStream.ToArray());
        }

        private static PooledContentStream CreatePooledStreamWithData(byte[] data)
        {
            var stream = new PooledContentStream();
            var span = stream.BufferWriter.GetSpan(data.Length);
            data.CopyTo(span);
            stream.BufferWriter.Advance(data.Length);
            return stream;
        }

        private static DefaultRequest CreateRequest()
        {
            return new DefaultRequest(new TestRequest(), "TestService");
        }

        private class TestRequest : AmazonWebServiceRequest
        {
        }

        private class NoOpHandler : PipelineHandler
        {
            public override void InvokeSync(IExecutionContext executionContext) { }
            public override System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
                => System.Threading.Tasks.Task.FromResult(default(T));
        }
#endif

    }
}
