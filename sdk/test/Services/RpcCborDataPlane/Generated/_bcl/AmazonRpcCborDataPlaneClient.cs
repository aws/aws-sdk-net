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
 * Do not modify this file. This file is generated from the rpccbordataplane-1999-12-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.RpcCborDataPlane.Model;
using Amazon.RpcCborDataPlane.Model.Internal.MarshallTransformations;
using Amazon.RpcCborDataPlane.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.RpcCborDataPlane
{
    /// <summary>
    /// <para>Implementation for accessing RpcCborDataPlane</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// 
    /// </summary>
    public partial class AmazonRpcCborDataPlaneClient : AmazonServiceClient, IAmazonRpcCborDataPlane
    {
        private static IServiceMetadata serviceMetadata = new AmazonRpcCborDataPlaneMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonRpcCborDataPlaneClient with the credentials loaded from the application's
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
        public AmazonRpcCborDataPlaneClient()
            : base(new AmazonRpcCborDataPlaneConfig()) { }

        /// <summary>
        /// Constructs AmazonRpcCborDataPlaneClient with the credentials loaded from the application's
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
        public AmazonRpcCborDataPlaneClient(RegionEndpoint region)
            : base(new AmazonRpcCborDataPlaneConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRpcCborDataPlaneClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRpcCborDataPlaneClient Configuration Object</param>
        public AmazonRpcCborDataPlaneClient(AmazonRpcCborDataPlaneConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonRpcCborDataPlaneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRpcCborDataPlaneClient(AWSCredentials credentials)
            : this(credentials, new AmazonRpcCborDataPlaneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRpcCborDataPlaneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRpcCborDataPlaneClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRpcCborDataPlaneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRpcCborDataPlaneClient with AWS Credentials and an
        /// AmazonRpcCborDataPlaneClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRpcCborDataPlaneClient Configuration Object</param>
        public AmazonRpcCborDataPlaneClient(AWSCredentials credentials, AmazonRpcCborDataPlaneConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRpcCborDataPlaneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRpcCborDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRpcCborDataPlaneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRpcCborDataPlaneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRpcCborDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRpcCborDataPlaneConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRpcCborDataPlaneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRpcCborDataPlaneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRpcCborDataPlaneClient Configuration Object</param>
        public AmazonRpcCborDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRpcCborDataPlaneConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRpcCborDataPlaneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRpcCborDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRpcCborDataPlaneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRpcCborDataPlaneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRpcCborDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRpcCborDataPlaneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRpcCborDataPlaneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRpcCborDataPlaneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRpcCborDataPlaneClient Configuration Object</param>
        public AmazonRpcCborDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRpcCborDataPlaneConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRpcCborDataPlaneAuthSchemeHandler());
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


        #region  GetItem


        /// <summary>
        /// <pre><c>From Amazon DynamoDB. Deserialization of recursive structures. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetItem service method.</param>
        /// 
        /// <returns>The response from the GetItem service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/GetItem">REST API Reference for GetItem Operation</seealso>
        public virtual GetItemResponse GetItem(GetItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetItemResponseUnmarshaller.Instance;

            return Invoke<GetItemResponse>(request, options);
        }


        /// <summary>
        /// <pre><c>From Amazon DynamoDB. Deserialization of recursive structures. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetItem service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/GetItem">REST API Reference for GetItem Operation</seealso>
        public virtual Task<GetItemResponse> GetItemAsync(GetItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetItemResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetItemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMetricData


        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData service method.</param>
        /// 
        /// <returns>The response from the GetMetricData service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        public virtual GetMetricDataResponse GetMetricData(GetMetricDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetMetricDataResponse>(request, options);
        }


        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMetricData service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        public virtual Task<GetMetricDataResponse> GetMetricDataAsync(GetMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricDataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMetricDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Healthcheck


        /// <summary>
        /// <pre><c>A response that only says &quot;OK&quot;, if it can. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Healthcheck service method.</param>
        /// 
        /// <returns>The response from the Healthcheck service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/Healthcheck">REST API Reference for Healthcheck Operation</seealso>
        public virtual HealthcheckResponse Healthcheck(HealthcheckRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HealthcheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HealthcheckResponseUnmarshaller.Instance;

            return Invoke<HealthcheckResponse>(request, options);
        }


        /// <summary>
        /// <pre><c>A response that only says &quot;OK&quot;, if it can. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Healthcheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Healthcheck service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/Healthcheck">REST API Reference for Healthcheck Operation</seealso>
        public virtual Task<HealthcheckResponse> HealthcheckAsync(HealthcheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HealthcheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HealthcheckResponseUnmarshaller.Instance;
            
            return InvokeAsync<HealthcheckResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutItem


        /// <summary>
        /// <pre><c>From Amazon DynamoDB. Serialization of recursive structures. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutItem service method.</param>
        /// 
        /// <returns>The response from the PutItem service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/PutItem">REST API Reference for PutItem Operation</seealso>
        public virtual PutItemResponse PutItem(PutItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutItemResponseUnmarshaller.Instance;

            return Invoke<PutItemResponse>(request, options);
        }


        /// <summary>
        /// <pre><c>From Amazon DynamoDB. Serialization of recursive structures. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutItem service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/PutItem">REST API Reference for PutItem Operation</seealso>
        public virtual Task<PutItemResponse> PutItemAsync(PutItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutItemResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutItemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutMetricData


        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData service method.</param>
        /// 
        /// <returns>The response from the PutMetricData service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/PutMetricData">REST API Reference for PutMetricData Operation</seealso>
        public virtual PutMetricDataResponse PutMetricData(PutMetricDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricDataResponseUnmarshaller.Instance;

            return Invoke<PutMetricDataResponse>(request, options);
        }


        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMetricData service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/PutMetricData">REST API Reference for PutMetricData Operation</seealso>
        public virtual Task<PutMetricDataResponse> PutMetricDataAsync(PutMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricDataResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutMetricDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}