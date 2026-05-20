using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class PooledContentWriterTests
    {
#if !NETFRAMEWORK
        [TestMethod]
        public void ContentGetter_ReturnsLazyCopy_WhenPooledContentWriterIsSet()
        {
            var request = CreateRequest();
            var payload = Encoding.UTF8.GetBytes("{\"key\":\"value\"}");
            request.PooledContentWriter = CreateWriterWithData(payload);

            byte[] content = request.Content;

            Assert.IsNotNull(content);
            CollectionAssert.AreEqual(payload, content);
        }

        [TestMethod]
        public void ContentSetter_DisposesPooledContentWriter()
        {
            var request = CreateRequest();
            request.PooledContentWriter = CreateWriterWithData(Encoding.UTF8.GetBytes("test"));

            request.Content = Encoding.UTF8.GetBytes("replacement");

            Assert.IsNull(request.PooledContentWriter);
        }

        [TestMethod]
        public void Dispose_ReturnsBufferToPool()
        {
            var request = CreateRequest();
            request.PooledContentWriter = CreateWriterWithData(Encoding.UTF8.GetBytes("test"));

            request.Dispose();

            Assert.IsNull(request.PooledContentWriter);
        }

        [TestMethod]
        public void Dispose_IsIdempotent()
        {
            var request = CreateRequest();
            request.PooledContentWriter = CreateWriterWithData(Encoding.UTF8.GetBytes("test"));

            request.Dispose();
            request.Dispose();

            Assert.IsNull(request.PooledContentWriter);
        }

        [TestMethod]
        public void SetRequestBodyHash_ProducesSameHash_ForPooledAndDirectContent()
        {
            var payload = Encoding.UTF8.GetBytes("{\"MessageBody\":\"hello world\"}");

            var pooledRequest = CreateRequest();
            pooledRequest.Endpoint = new Uri("https://sqs.us-east-1.amazonaws.com");
            pooledRequest.PooledContentWriter = CreateWriterWithData(payload);

            var directRequest = CreateRequest();
            directRequest.Endpoint = new Uri("https://sqs.us-east-1.amazonaws.com");
            directRequest.Content = payload;

            var hashFromPooled = AWS4Signer.SetRequestBodyHash(pooledRequest, true, "STREAMING-AWS4-HMAC-SHA256-PAYLOAD", 0);
            var hashFromDirect = AWS4Signer.SetRequestBodyHash(directRequest, true, "STREAMING-AWS4-HMAC-SHA256-PAYLOAD", 0);

            Assert.AreEqual(hashFromDirect, hashFromPooled);
        }

        [TestMethod]
        public void HasRequestData_ReturnsTrue_WhenOnlyPooledContentWriterIsSet()
        {
            var request = CreateRequest();
            request.PooledContentWriter = CreateWriterWithData(Encoding.UTF8.GetBytes("test"));

            Assert.IsTrue(((IRequest)request).HasRequestData());
        }

        /// <summary>
        /// Verifies that the full pipeline (Marshaller → EndpointResolver → CompressionHandler →
        /// ChecksumHandler → Signer → HttpHandler) does not trigger the Content getter's lazy copy.
        /// If this test fails, a pipeline handler is accidentally reading request.Content
        /// which defeats the zero-copy optimization.
        /// </summary>
        [TestMethod]
        public void Pipeline_DoesNotTriggerLazyCopy_WhenPooledContentWriterIsSet()
        {
            bool pooledContentWriterWasAlive = false;

            var putItemRequest = new PutItemRequest
            {
                TableName = "TestTable",
                Item = new Dictionary<string, AttributeValue>
                {
                    ["PK"] = new AttributeValue { S = "test-key" },
                    ["Data"] = new AttributeValue { S = new string('X', 1024) }
                }
            };

            var config = new AmazonDynamoDBConfig { DefaultAWSCredentials = new BasicAWSCredentials("accessKey", "secretKey") };
            var factory = new HttpHandlerTests.MockHttpRequestFactory
            {
                ResponseCreator = _ => new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("{}", Encoding.UTF8, "application/x-amz-json-1.0")
                }
            };
            var httpHandler = new HttpHandler<Stream>(factory, new object());

            // The inspector sits just inside the Marshaller — it runs after the entire inner
            // pipeline (HttpHandler, Signer, etc.) completes but before Marshaller.finally
            // calls Dispose(). This proves no handler in the full pipeline triggered 
            // PooledContentWriter lazy copy to DefaultRequest.Content.
            var inspectorHandler = new PooledContentInspectorHandler(ctx =>
            {
                pooledContentWriterWasAlive = ctx.RequestContext.Request.PooledContentWriter != null;
            });

            var pipeline = new RuntimePipeline(new List<IPipelineHandler>
            {
                httpHandler,
                new Unmarshaller(true),
                new ErrorHandler(Amazon.Runtime.Internal.Util.Logger.EmptyLogger),
                new Signer(),
                new EndpointDiscoveryHandler(),
                new ChecksumHandler(),
                new RetryHandler(new StandardRetryPolicy(config)),
                new CompressionHandler(),
                new EndpointResolver(),
                inspectorHandler,
                new Marshaller(),
            });

            var executionContext = new ExecutionContext(
                new RequestContext(true, new NullSigner())
                {
                    ClientConfig = config,
                    Marshaller = PutItemRequestMarshaller.Instance,
                    OriginalRequest = putItemRequest,
                    Unmarshaller = PutItemResponseUnmarshaller.Instance,
                    Options = new Amazon.Runtime.Internal.InvokeOptions(),
                },
                new ResponseContext()
            );

            pipeline.InvokeSync(executionContext);

            Assert.IsTrue(pooledContentWriterWasAlive,
                "PooledContentWriter was disposed before reaching the HTTP handler. " +
                "A pipeline stage is accidentally reading request.Content, defeating the zero-copy optimization.");
        }

        private static ArrayPoolBufferWriter<byte> CreateWriterWithData(byte[] data)
        {
            var writer = new ArrayPoolBufferWriter<byte>();
            var span = writer.GetSpan(data.Length);
            data.CopyTo(span);
            writer.Advance(data.Length);
            return writer;
        }

        /// <summary>
        /// Runs the assertion after the entire inner pipeline completes (on the return path),
        /// just before Marshaller's finally block disposes the request.
        /// </summary>
        private class PooledContentInspectorHandler : PipelineHandler
        {
            private readonly Action<IExecutionContext> _inspect;

            public PooledContentInspectorHandler(Action<IExecutionContext> inspect)
            {
                _inspect = inspect;
            }

            public override void InvokeSync(IExecutionContext executionContext)
            {
                base.InvokeSync(executionContext);
                _inspect(executionContext);
            }

            public override System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
            {
                var result = base.InvokeAsync<T>(executionContext);
                _inspect(executionContext);
                return result;
            }
        }
#endif

        [TestMethod]
        public void HasRequestData_ReturnsFalse_WhenNothingIsSet()
        {
            var request = CreateRequest();

            Assert.IsFalse(((IRequest)request).HasRequestData());
        }

        private static DefaultRequest CreateRequest()
        {
            return new DefaultRequest(new TestRequest(), "TestService");
        }

        private class TestRequest : AmazonWebServiceRequest
        {
        }
    }
}
