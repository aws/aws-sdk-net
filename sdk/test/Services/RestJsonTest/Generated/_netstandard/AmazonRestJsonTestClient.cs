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

/*
 * Do not modify this file. This file is generated from the rest-json-test-2016-04-12.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.RestJsonTest.Model;
using Amazon.RestJsonTest.Model.Internal.MarshallTransformations;
using Amazon.RestJsonTest.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.RestJsonTest
{
    /// <summary>
    /// <para>Implementation for accessing RestJsonTest</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonRestJsonTestClient : AmazonServiceClient, IAmazonRestJsonTest
    {
        private static IServiceMetadata serviceMetadata = new AmazonRestJsonTestMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRestJsonTestClient()
            : base(new AmazonRestJsonTestConfig()) { }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRestJsonTestClient(RegionEndpoint region)
            : base(new AmazonRestJsonTestConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRestJsonTestClient Configuration Object</param>
        public AmazonRestJsonTestClient(AmazonRestJsonTestConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRestJsonTestClient(AWSCredentials credentials)
            : this(credentials, new AmazonRestJsonTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestJsonTestClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRestJsonTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Credentials and an
        /// AmazonRestJsonTestClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRestJsonTestClient Configuration Object</param>
        public AmazonRestJsonTestClient(AWSCredentials credentials, AmazonRestJsonTestConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestJsonTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestJsonTestConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestJsonTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRestJsonTestClient Configuration Object</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRestJsonTestConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestJsonTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestJsonTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestJsonTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRestJsonTestClient Configuration Object</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRestJsonTestConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRestJsonTestAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  MemberRefOp

        internal virtual MemberRefOpResponse MemberRefOp(MemberRefOpRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MemberRefOpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MemberRefOpResponseUnmarshaller.Instance;

            return Invoke<MemberRefOpResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MemberRefOp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MemberRefOp service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/MemberRefOp">REST API Reference for MemberRefOp Operation</seealso>
        public virtual Task<MemberRefOpResponse> MemberRefOpAsync(MemberRefOpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MemberRefOpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MemberRefOpResponseUnmarshaller.Instance;

            return InvokeAsync<MemberRefOpResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  NoPayload

        internal virtual NoPayloadResponse NoPayload(NoPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoPayloadResponseUnmarshaller.Instance;

            return Invoke<NoPayloadResponse>(request, options);
        }



        /// <summary>
        /// Request without a body
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/NoPayload">REST API Reference for NoPayload Operation</seealso>
        public virtual Task<NoPayloadResponse> NoPayloadAsync(NoPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<NoPayloadResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  NoPayloadPost

        internal virtual NoPayloadPostResponse NoPayloadPost(NoPayloadPostRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoPayloadPostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoPayloadPostResponseUnmarshaller.Instance;

            return Invoke<NoPayloadPostResponse>(request, options);
        }



        /// <summary>
        /// A POST request without a body, for verifying that we don't set a Content-Type even
        /// though a POST could have a body
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoPayloadPost service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoPayloadPost service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/NoPayloadPost">REST API Reference for NoPayloadPost Operation</seealso>
        public virtual Task<NoPayloadPostResponse> NoPayloadPostAsync(NoPayloadPostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoPayloadPostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoPayloadPostResponseUnmarshaller.Instance;

            return InvokeAsync<NoPayloadPostResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  QueryBooleanList

        internal virtual QueryBooleanListResponse QueryBooleanList(QueryBooleanListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryBooleanListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryBooleanListResponseUnmarshaller.Instance;

            return Invoke<QueryBooleanListResponse>(request, options);
        }



        /// <summary>
        /// Handles query string lists of boolean
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryBooleanList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryBooleanList service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryBooleanList">REST API Reference for QueryBooleanList Operation</seealso>
        public virtual Task<QueryBooleanListResponse> QueryBooleanListAsync(QueryBooleanListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryBooleanListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryBooleanListResponseUnmarshaller.Instance;

            return InvokeAsync<QueryBooleanListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  QueryIntegerList

        internal virtual QueryIntegerListResponse QueryIntegerList(QueryIntegerListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIntegerListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIntegerListResponseUnmarshaller.Instance;

            return Invoke<QueryIntegerListResponse>(request, options);
        }



        /// <summary>
        /// Handles query string lists of integer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIntegerList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryIntegerList service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryIntegerList">REST API Reference for QueryIntegerList Operation</seealso>
        public virtual Task<QueryIntegerListResponse> QueryIntegerListAsync(QueryIntegerListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIntegerListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIntegerListResponseUnmarshaller.Instance;

            return InvokeAsync<QueryIntegerListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  QueryIntegerListMap

        internal virtual QueryIntegerListMapResponse QueryIntegerListMap(QueryIntegerListMapRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIntegerListMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIntegerListMapResponseUnmarshaller.Instance;

            return Invoke<QueryIntegerListMapResponse>(request, options);
        }



        /// <summary>
        /// Handles query string maps of lists of integers
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIntegerListMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryIntegerListMap service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryIntegerListMap">REST API Reference for QueryIntegerListMap Operation</seealso>
        public virtual Task<QueryIntegerListMapResponse> QueryIntegerListMapAsync(QueryIntegerListMapRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIntegerListMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIntegerListMapResponseUnmarshaller.Instance;

            return InvokeAsync<QueryIntegerListMapResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  QueryStringEscaping

        internal virtual QueryStringEscapingResponse QueryStringEscaping(QueryStringEscapingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryStringEscapingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryStringEscapingResponseUnmarshaller.Instance;

            return Invoke<QueryStringEscapingResponse>(request, options);
        }



        /// <summary>
        /// Handles query string escaping
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryStringEscaping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryStringEscaping service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringEscaping">REST API Reference for QueryStringEscaping Operation</seealso>
        public virtual Task<QueryStringEscapingResponse> QueryStringEscapingAsync(QueryStringEscapingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryStringEscapingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryStringEscapingResponseUnmarshaller.Instance;

            return InvokeAsync<QueryStringEscapingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  QueryStringList

        internal virtual QueryStringListResponse QueryStringList(QueryStringListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryStringListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryStringListResponseUnmarshaller.Instance;

            return Invoke<QueryStringListResponse>(request, options);
        }



        /// <summary>
        /// Handles query string lists of string
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryStringList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryStringList service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringList">REST API Reference for QueryStringList Operation</seealso>
        public virtual Task<QueryStringListResponse> QueryStringListAsync(QueryStringListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryStringListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryStringListResponseUnmarshaller.Instance;

            return InvokeAsync<QueryStringListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  QueryStringListMap

        internal virtual QueryStringListMapResponse QueryStringListMap(QueryStringListMapRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryStringListMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryStringListMapResponseUnmarshaller.Instance;

            return Invoke<QueryStringListMapResponse>(request, options);
        }



        /// <summary>
        /// Handles query string maps of lists of string
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryStringListMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryStringListMap service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringListMap">REST API Reference for QueryStringListMap Operation</seealso>
        public virtual Task<QueryStringListMapResponse> QueryStringListMapAsync(QueryStringListMapRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryStringListMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryStringListMapResponseUnmarshaller.Instance;

            return InvokeAsync<QueryStringListMapResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  QueryTimestampList

        internal virtual QueryTimestampListResponse QueryTimestampList(QueryTimestampListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryTimestampListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryTimestampListResponseUnmarshaller.Instance;

            return Invoke<QueryTimestampListResponse>(request, options);
        }



        /// <summary>
        /// Handles query string lists of timestamp
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryTimestampList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryTimestampList service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryTimestampList">REST API Reference for QueryTimestampList Operation</seealso>
        public virtual Task<QueryTimestampListResponse> QueryTimestampListAsync(QueryTimestampListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryTimestampListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryTimestampListResponseUnmarshaller.Instance;

            return InvokeAsync<QueryTimestampListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StaticOp

        internal virtual StaticOpResponse StaticOp(StaticOpRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StaticOpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StaticOpResponseUnmarshaller.Instance;

            return Invoke<StaticOpResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StaticOp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StaticOp service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/StaticOp">REST API Reference for StaticOp Operation</seealso>
        public virtual Task<StaticOpResponse> StaticOpAsync(StaticOpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StaticOpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StaticOpResponseUnmarshaller.Instance;

            return InvokeAsync<StaticOpResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TestBlobPayload

        internal virtual TestBlobPayloadResponse TestBlobPayload(TestBlobPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestBlobPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBlobPayloadResponseUnmarshaller.Instance;

            return Invoke<TestBlobPayloadResponse>(request, options);
        }



        /// <summary>
        /// Post a test blob payload request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestBlobPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestBlobPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBlobPayload">REST API Reference for TestBlobPayload Operation</seealso>
        public virtual Task<TestBlobPayloadResponse> TestBlobPayloadAsync(TestBlobPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestBlobPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBlobPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<TestBlobPayloadResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TestBody

        internal virtual TestBodyResponse TestBody(TestBodyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestBodyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBodyResponseUnmarshaller.Instance;

            return Invoke<TestBodyResponse>(request, options);
        }



        /// <summary>
        /// Post a test body request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestBody service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestBody service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBody">REST API Reference for TestBody Operation</seealso>
        public virtual Task<TestBodyResponse> TestBodyAsync(TestBodyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestBodyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBodyResponseUnmarshaller.Instance;

            return InvokeAsync<TestBodyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TestPayload

        internal virtual TestPayloadResponse TestPayload(TestPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPayloadResponseUnmarshaller.Instance;

            return Invoke<TestPayloadResponse>(request, options);
        }



        /// <summary>
        /// Post a test payload request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestPayload">REST API Reference for TestPayload Operation</seealso>
        public virtual Task<TestPayloadResponse> TestPayloadAsync(TestPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<TestPayloadResponse>(request, options, cancellationToken);
        }
        #endregion
        
    }
}