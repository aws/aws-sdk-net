using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class ChecksumRetryTests : ChecksumTestBase
    {
        public ChecksumRetryTests(ChecksumMrapFixture mrapFixture) : base(mrapFixture)
        {
        }

#if NETFRAMEWORK
        // All of these DataRow tests test a case where the first request fails with an internal server error, the input stream
        // file is then changed before retry, and the cached checksum is used on the second request. Because the cached checksum
        // is used on a different file S3 will checksum the new file and then try to match it against the cached checksum being
        // sent. This will fail with a checksum not matched as is intended. A checksum cannot be recalculated on retries for
        // security and performance reasons.
        [Theory]
        // Tests a SigV4 PutObject with the checksum placed in the header
        [InlineData(SignatureVersion.SigV4, false, null, "6kElVYhtR8Qjeqid5cZ690lQN2UWHZHBTzzf/3GVcZU=", "The provided 'x-amz-content-sha256' header does not match what was computed.")]
        // Tests a SigV4 PutObject with the checksum placed in the trailer
        [InlineData(SignatureVersion.SigV4, true, false, "6kElVYhtR8Qjeqid5cZ690lQN2UWHZHBTzzf/3GVcZU=", "The SHA256 you specified did not match the calculated checksum.")]
        // Tests a SigV4 PutObject with an unsigned payload and the checksum in the trailer
        [InlineData(SignatureVersion.SigV4, true, true, "6kElVYhtR8Qjeqid5cZ690lQN2UWHZHBTzzf/3GVcZU=", "The SHA256 you specified did not match the calculated checksum.")]
        // Tests a SigV4a PutObject with the checksum placed in the header
        [InlineData(SignatureVersion.SigV4a, false, null, "6kElVYhtR8Qjeqid5cZ690lQN2UWHZHBTzzf/3GVcZU=", "The provided 'x-amz-content-sha256' header does not match what was computed.")]
        // Tests a SigV4a PutObject with the checksum placed in the trailer
        [InlineData(SignatureVersion.SigV4a, true, false, "6kElVYhtR8Qjeqid5cZ690lQN2UWHZHBTzzf/3GVcZU=", "The SHA256 you specified did not match the calculated checksum.")]
        // Tests a SigV4a PutObject with an unsigned payload and the checksum in the trailer
        [InlineData(SignatureVersion.SigV4a, true, true, "6kElVYhtR8Qjeqid5cZ690lQN2UWHZHBTzzf/3GVcZU=", "The SHA256 you specified did not match the calculated checksum.")]
        public void TestReuseChecksum_FileChanged(SignatureVersion signatureVersion, bool useChunkEncoding, bool? disablePayloadSigning, string checksumValue, string exceptionMessage)
        {
            var s3Config = new AmazonS3Config
            {
                RetryMode = RequestRetryMode.Standard,
                MaxErrorRetry = 2
            };

            var key = UtilityMethods.GenerateName(nameof(ChecksumRetryTests));
            using (var s3Client = new MockInspectS3Client(s3Config))
            {
                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = signatureVersion == SignatureVersion.SigV4 ? _bucketName : _mrapArn,
                    Key = key,                    
                    InputStream = s3Client.TestFileManagerHandler.FileStream,
                    ChecksumAlgorithm = ChecksumAlgorithm.SHA256,
                    DisablePayloadSigning = disablePayloadSigning,
                    UseChunkEncoding = useChunkEncoding
                };

                AssertExtensions.ExpectException(() => s3Client.PutObject(putObjectRequest), typeof(AmazonS3Exception), exceptionMessage);
                Assert.True(s3Client.ChecksumValueEachRequest.Count == 2);                
                Assert.True(s3Client.ChecksumValueEachRequest[0] == checksumValue);
                Assert.Equal(s3Client.ChecksumValueEachRequest[0], s3Client.ChecksumValueEachRequest[1]);
            }
        }
#endif
    }

#if NETFRAMEWORK

    public class MockInspectFileStream : FileStream
    {
        public MockInspectFileStream(string path, FileMode mode, FileAccess access, FileShare share) : base(path, mode, access, share)
        {
        }

        public bool AllowClose { get; set; } = false;

        public override void Close() {
            if (AllowClose)
            {
                base.Close();
            }        
        }
    }

    public class TestFileManagerHandler : PipelineHandler, IDisposable
    {
        public string TemporaryFilePath { get; set; }
        public MockInspectFileStream FileStream { get; set; }
        private bool disposedValue;
        private int _attemptCounter;
        private string[] _attemptFileData = new string[]
        {
            "Test content for attempt 0",
            "Test content for attempt 1"
        };

        private void GenerateFile()
        {
            if(_attemptCounter > 1)
            {
                return;
            }

            string fileData = _attemptFileData[_attemptCounter];
            FileStream.Position = 0;
            FileStream.Write(fileData.Select(c => (byte)c).ToArray(), 0, fileData.Length);
            FileStream.Flush();
            FileStream.Position = 0;            
            _attemptCounter++;
        }

        public TestFileManagerHandler()
        {
            var TemporaryFilePath = Path.GetTempFileName();
            FileStream = new MockInspectFileStream(TemporaryFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            GenerateFile();
        }

        public async override System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            try
            {
                T result = await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
                return result;
            }
            finally
            {
                GenerateFile();
            }

        }

        public override void InvokeSync(IExecutionContext executionContext)
        {
            try
            {
                base.InvokeSync(executionContext);
            }
            finally
            {
                GenerateFile();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                FileStream.AllowClose = true;
                FileStream.Close();
                if (File.Exists(TemporaryFilePath))
                {
                    File.Delete(TemporaryFilePath);
                }
                
                disposedValue = true;
            }
        }

        ~TestFileManagerHandler()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    public class MockInspectS3Client : AmazonS3Client
    {
        public TestFileManagerHandler TestFileManagerHandler { get; set; }
                
        public MockInspectHttpRequestFactory RequestFactory;
        public List<string> ChecksumValueEachRequest { get; set; } = new List<string>();

        public MockInspectS3Client(AmazonS3Config clientConfig) : base(clientConfig)
        {
        }

        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            RequestFactory = new MockInspectHttpRequestFactory(ChecksumValueEachRequest);
            var httpHandler = new HttpHandler<Stream>(RequestFactory, this);
            pipeline.ReplaceHandler<HttpHandler<Stream>>(httpHandler);

            TestFileManagerHandler = new TestFileManagerHandler();
            pipeline.AddHandlerAfter<RetryHandler>(TestFileManagerHandler);
            base.CustomizeRuntimePipeline(pipeline);
        }
    }

    public class MockInspectHttpRequestFactory : IHttpRequestFactory<Stream>
    {
        public MockInspectHttpRequest Request { get; private set; }
        private List<string> _checksumValueEachRequest;
        private int _attemptCount;

        public MockInspectHttpRequestFactory(List<string> ChecksumValueEachRequest)
        {
            _checksumValueEachRequest = ChecksumValueEachRequest;
        }

        public IHttpRequest<Stream> CreateHttpRequest(Uri requestUri)
        {
            Request = new MockInspectHttpRequest(requestUri, _checksumValueEachRequest, _attemptCount);
            _attemptCount++;
            return Request;
        }

        public void Dispose()
        {
        }
    }

    public class MockInspectHttpRequest : IHttpRequest<Stream>
    {
        HttpRequest _httpRequest;
        private const string CachedChecksumKey = "ConsumedCachedChecksum";
        private List<string> _checksumValueEachRequest;
        private const string ChecksumHeaderPrefix = "x-amz-checksum-";
        private int _attemptCount;
        private IRequestContext _requestContext;

        public string Method { get => ((IHttpRequest<Stream>)_httpRequest).Method; set => ((IHttpRequest<Stream>)_httpRequest).Method = value; }

        public Uri RequestUri => ((IHttpRequest<Stream>)_httpRequest).RequestUri;

        public MockInspectHttpRequest(Uri requestUri, List<string> checksumValueEachRequest, int attemptCount)
        {
            _httpRequest = new HttpRequest(requestUri);
            _checksumValueEachRequest = checksumValueEachRequest;
            _attemptCount = attemptCount;
        }

        private string FindHeaderChecksum(IDictionary<string, string> headers)
        {
            var checksum = string.Empty;
            foreach (var entry in headers)
            {
                if (entry.Key.StartsWith(ChecksumHeaderPrefix, StringComparison.OrdinalIgnoreCase))
                {
                    checksum = entry.Value;
                }
            }
            return checksum;
        }
        
        public IWebResponseData GetResponse()
        {
            var checksum = _requestContext.ContextAttributes.ContainsKey(CachedChecksumKey) ? (string)_requestContext.ContextAttributes[CachedChecksumKey] : null;
            if (!string.IsNullOrEmpty(checksum))
            {
                _checksumValueEachRequest.Add(checksum);
            }
            if (_attemptCount == 0)
            {
                _attemptCount++;
                throw new AmazonServiceException("We encountered an internal error. Please try again.", null, HttpStatusCode.InternalServerError);
            }
            _attemptCount++;
            return ((IHttpRequest<Stream>)_httpRequest).GetResponse();
        }

        public void ConfigureRequest(IRequestContext requestContext)
        {
            _requestContext = requestContext;
            ((IHttpRequest<Stream>)_httpRequest).ConfigureRequest(requestContext);
        }

        public void SetRequestHeaders(IDictionary<string, string> headers)
        {
            var checksum = FindHeaderChecksum(headers);
            if (!string.IsNullOrEmpty(checksum))
            {
                _checksumValueEachRequest.Add(FindHeaderChecksum(headers));
            }

            ((IHttpRequest<Stream>)_httpRequest).SetRequestHeaders(headers);
        }

        public Stream GetRequestContent()
        {
            return ((IHttpRequest<Stream>)_httpRequest).GetRequestContent();
        }

        public void WriteToRequestBody(Stream requestContent, Stream contentStream, IDictionary<string, string> contentHeaders, IRequestContext requestContext)
        {
            Assert.NotNull(requestContent);
            Assert.NotNull(contentStream);
            Assert.NotNull(contentHeaders);
            ((IHttpRequest<Stream>)_httpRequest).WriteToRequestBody(requestContent, contentStream, contentHeaders, requestContext);
        }

        public void WriteToRequestBody(Stream requestContent, byte[] content, IDictionary<string, string> contentHeaders)
        {
            Assert.NotNull(requestContent);
            Assert.NotNull(content);
            Assert.NotNull(contentHeaders);
            ((IHttpRequest<Stream>)_httpRequest).WriteToRequestBody(requestContent, content, contentHeaders);
        }

        public Stream SetupProgressListeners(Stream originalStream, long progressUpdateInterval, object sender, EventHandler<StreamTransferProgressArgs> callback)
        {
            return ((IHttpRequest<Stream>)_httpRequest).SetupProgressListeners(originalStream, progressUpdateInterval, sender, callback);
        }

        public void Abort()
        {
            ((IHttpRequest<Stream>)_httpRequest).Abort();
        }

        public Task<Stream> GetRequestContentAsync()
        {
            return ((IHttpRequest<Stream>)_httpRequest).GetRequestContentAsync();
        }

        public Task<Stream> GetRequestContentAsync(CancellationToken cancellationToken)
        {
            return ((IHttpRequest<Stream>)_httpRequest).GetRequestContentAsync(cancellationToken);
        }

        public Task<IWebResponseData> GetResponseAsync(CancellationToken cancellationToken)
        {
            return ((IHttpRequest<Stream>)_httpRequest).GetResponseAsync(cancellationToken);
        }

        public Task WriteToRequestBodyAsync(Stream requestContent, Stream contentStream, IDictionary<string, string> contentHeaders, IRequestContext requestContext)
        {
            return ((IHttpRequest<Stream>)_httpRequest).WriteToRequestBodyAsync(requestContent, contentStream, contentHeaders, requestContext);
        }

        public Task WriteToRequestBodyAsync(Stream requestContent, byte[] requestData, IDictionary<string, string> headers, CancellationToken cancellationToken)
        {
            return ((IHttpRequest<Stream>)_httpRequest).WriteToRequestBodyAsync(requestContent, requestData, headers, cancellationToken);
        }

        public Version HttpProtocolVersion { get; set; }

        public IHttpRequestStreamHandle SetupHttpRequestStreamPublisher(IDictionary<string, string> contentHeaders, IHttpRequestStreamPublisher requestStreamPublisher)
        {
            return ((IHttpRequest<Stream>)_httpRequest).SetupHttpRequestStreamPublisher(contentHeaders, requestStreamPublisher);
        }

        public void Dispose()
        {
            ((IDisposable)_httpRequest).Dispose();
        }
    }
#endif
}
