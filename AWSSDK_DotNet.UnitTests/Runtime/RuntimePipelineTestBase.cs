using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet35.UnitTests;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Util;
using System.Threading;
using System.Net;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace AWSSDK.UnitTests
{
    public abstract class RuntimePipelineTestBase
    {
        protected virtual IExecutionContext CreateTestContext()
        {
            var putObjectRequest = new PutObjectRequest
            {
                Key = "TestKey",
                BucketName = "TestBucket",
                ContentBody = "Test Content"
            };
            var requestContext = new RequestContext(true)
            {
                OriginalRequest = putObjectRequest,
                Request = new PutObjectRequestMarshaller().Marshall(putObjectRequest),
                Unmarshaller = PutObjectResponseUnmarshaller.Instance,
                ClientConfig = new AmazonS3Config()
            };
            requestContext.Request.Endpoint = new Uri("https://s3.amazonaws.com");

            var putObjectResponse = MockWebResponse.CreateFromResource("PutObjectResponse.txt")
                as HttpWebResponse;
            return new Amazon.Runtime.Internal.ExecutionContext(requestContext,
                new ResponseContext
                {
                    HttpResponse = new HttpWebRequestResponseData(putObjectResponse)
                });
        }

        protected IAsyncExecutionContext CreateAsyncTestContext()
        {
            var putObjectRequest = new PutObjectRequest
            {
                Key = "Test",
                BucketName = "Test",
                ContentBody = "Test Content"
            };
            var requestContext = new AsyncRequestContext(true)
            {
                OriginalRequest = putObjectRequest,
                Request = new PutObjectRequestMarshaller().Marshall(putObjectRequest),
                Unmarshaller = PutObjectResponseUnmarshaller.Instance,
                ClientConfig = new AmazonS3Config()
            };
            requestContext.Request.Endpoint = new Uri("https://s3.amazonaws.com");

            var putObjectResponse = MockWebResponse.CreateFromResource("PutObjectResponse.txt")
                as HttpWebResponse;
            return new Amazon.Runtime.Internal.AsyncExecutionContext(
                requestContext,
                new AsyncResponseContext
                {
                    HttpResponse = new HttpWebRequestResponseData(putObjectResponse)
                }
            );
        }
    }

    public abstract class RuntimePipelineTestBase<T> : RuntimePipelineTestBase where T : IPipelineHandler
    {
        public static MockActionHandler Tester { get; private set; }

        public static T Handler { get; set; }

        public static RuntimePipeline RuntimePipeline { get; private set; }

        static RuntimePipelineTestBase()
        {
            Tester = new MockActionHandler();
            RuntimePipeline = new RuntimePipeline(Tester);
        }

        //        [TestMethod][TestCategory("UnitTest")]
        //        [TestCategory("Runtime")]
        //        public virtual void TestSuccessfulRequest()
        //        {
        //            Tester.Reset();
        //            var request = CreateTestContext();
        //            RuntimePipeline.InvokeSync(request);

        //            Assert.AreEqual(1, Tester.CallCount);
        //        }

        //#if BCL45

        //        [TestMethod][TestCategory("UnitTest")]
        //        [TestCategory("Runtime")]
        //        [TestCategory(@"Runtime\Async45")]
        //        public virtual async Task TestSuccessfulRequestAsync()
        //        {
        //            Tester.Reset();
        //            var request = CreateTestContext();
        //            await RuntimePipeline.InvokeAsync<AmazonWebServiceResponse>(request);

        //            Assert.AreEqual(1, Tester.CallCount);
        //        }

        //#elif !BCL45 && BCL

        //        [TestMethod][TestCategory("UnitTest")]
        //        [TestCategory("Runtime")]
        //        [TestCategory(@"Runtime\Async35")]
        //        public virtual void TestSuccessfulRequestAsync()
        //        {
        //            Tester.Reset();
        //            var request = CreateAsyncTestContext();
        //            var asyncResult = RuntimePipeline.InvokeAsync(request);
        //            asyncResult.AsyncWaitHandle.WaitOne();

        //            Assert.AreEqual(1, Tester.CallCount);
        //        }
        //#endif               
    }

    public class MockSigner : AbstractAWSSigner
    {
        public int SignCount { get; private set; }

        public override void Sign(IRequest request, ClientConfig clientConfig, RequestMetrics metrics,
            string awsAccessKeyId, string awsSecretAccessKey)
        {
            this.SignCount++;
        }

        public override ClientProtocol Protocol
        {
            get { return ClientProtocol.RestProtocol; }
        }

        public void Reset()
        {
            this.SignCount = 0;
        }
    }

    public class MockActionHandler : PipelineHandler
    {
        public int CallCount { get; private set; }

        public Action<int> Action { get; set; }

        public Action<int, IExecutionContext> Action2 { get; set; }

        public Action<int> Validate { get; set; }

        public void Reset()
        {
            this.Action = null;
            this.Validate = null;
            this.CallCount = 0;
        }

        public override void InvokeSync(IExecutionContext executionContext)
        {
            this.CallCount++;
            if (this.Action != null)
                Action(this.CallCount);

            if (this.Action2 != null)
                Action2(this.CallCount, executionContext);

            if (this.Validate != null)
                Validate(this.CallCount);
        }

#if BCL45
        public override async Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            await Task.Delay(100);

            this.CallCount++;
            if (this.Action != null)
                Action(this.CallCount);

            if (this.Action2 != null)
                Action2(this.CallCount, executionContext);

            if (this.Validate != null)
                Validate(this.CallCount);

            return new T();
        }
#elif !BCL45 && BCL

        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            if (executionContext.ResponseContext.AsyncResult == null)
            {
                var asyncResult = new RuntimeAsyncResult(null, null);
                executionContext.ResponseContext.AsyncResult = asyncResult;
            }

            ThreadPool.QueueUserWorkItem((state) =>
            {
                this.AsyncCallback(executionContext);
            });

            return executionContext.ResponseContext.AsyncResult;
        }

        protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
        {
            this.CallCount++;

            try
            {
                if (this.Action != null)
                    Action(this.CallCount);

                if (this.Action2 != null)
                    Action2(this.CallCount, 
                        Amazon.Runtime.Internal.ExecutionContext.CreateFromAsyncContext(executionContext));

                if (this.Validate != null)
                    Validate(this.CallCount);
            }
            catch (Exception exception)
            {
                executionContext.ResponseContext.AsyncResult.Exception = exception;
            }
            base.InvokeAsyncCallback(executionContext);
        }

#endif

    }

    public class MockHandler : PipelineHandler
    {
        public override void InvokeSync(IExecutionContext executionContext)
        {
        }

#if BCL45
        //public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        //{
        //    return Task.FromResult(new AmazonWebServiceResponse());
        //}
        public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            return Task.FromResult<T>(new T());
        }
#elif !BCL45 && BCL

        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            if (executionContext.ResponseContext.AsyncResult == null)
            {
                var asyncResult = new RuntimeAsyncResult(null, null);
                executionContext.ResponseContext.AsyncResult = asyncResult;
            }

            ThreadPool.QueueUserWorkItem((state) =>
            {
                this.AsyncCallback(executionContext);
            });

            return executionContext.ResponseContext.AsyncResult;
        }
#endif
    }
}
