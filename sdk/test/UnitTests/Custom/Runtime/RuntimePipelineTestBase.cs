/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Identity;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using System;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    public abstract class RuntimePipelineTestBase
    {
        protected virtual IExecutionContext CreateTestContext()
        {
            return CreateTestContext(null);
        }

        protected virtual IExecutionContext CreateTestContext(AbstractAWSSigner signer)
        {
            return CreateTestContext(signer, null);
        }

        protected virtual IExecutionContext CreateTestContext(AbstractAWSSigner signer, ResponseUnmarshaller responseUnmarshaller)
        {
            return CreateTestContext(signer, responseUnmarshaller, null);
        }
        
        protected virtual IExecutionContext CreateTestContext(AbstractAWSSigner signer, ResponseUnmarshaller responseUnmarshaller, ClientConfig config)
        {
            var putObjectRequest = new PutObjectRequest
            {
                Key = "TestKey",
                BucketName = "TestBucket",
                ContentBody = "Test Content"
            };

            if (responseUnmarshaller == null)
                responseUnmarshaller = PutObjectResponseUnmarshaller.Instance;

            var requestContext = new RequestContext(true, signer == null ? new NullSigner() : signer)
            {
                OriginalRequest = putObjectRequest,
                Request = new PutObjectRequestMarshaller().Marshall(putObjectRequest),
                Unmarshaller = responseUnmarshaller,
                ClientConfig = config ?? new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USEast1
                }
            };

            // Create and set the internal ServiceMetadata via reflection
            var serviceMetaData = Assembly.GetAssembly(requestContext.GetType()).CreateInstance("Amazon.Runtime.Internal.ServiceMetadata");
            requestContext.GetType().GetProperty("ServiceMetaData").SetValue(requestContext, serviceMetaData);

            requestContext.Request.Endpoint = new Uri("https://s3.amazonaws.com");

            var putObjectResponse = MockWebResponse.CreateFromResource("PutObjectResponse.txt")
                as HttpWebResponse;
            return new Amazon.Runtime.Internal.ExecutionContext(requestContext,
                new ResponseContext
                {
                    HttpResponse = new HttpWebRequestResponseData(putObjectResponse)
                });
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
    }

    public class MockSigner : AbstractAWSSigner
    {
        public int SignCount { get; private set; }

        public override void Sign(IRequest request, 
            IClientConfig clientConfig, 
            RequestMetrics metrics,
            BaseIdentity credentials)
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

#if BCL
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
#endif

    }

    public class MockHandler : PipelineHandler
    {
        public override void InvokeSync(IExecutionContext executionContext)
        {
        }

#if BCL
        public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            return Task.FromResult<T>(new T());
        }
#endif
    }
}
