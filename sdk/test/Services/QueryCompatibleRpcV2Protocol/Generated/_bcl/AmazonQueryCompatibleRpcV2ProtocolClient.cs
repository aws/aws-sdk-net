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
 * Do not modify this file. This file is generated from the query-compatible-rpcv2-protocol-2025-06-20.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.QueryCompatibleRpcV2Protocol.Model;
using Amazon.QueryCompatibleRpcV2Protocol.Model.Internal.MarshallTransformations;
using Amazon.QueryCompatibleRpcV2Protocol.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.QueryCompatibleRpcV2Protocol
{
    /// <summary>
    /// <para>Implementation for accessing QueryCompatibleRpcV2Protocol</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonQueryCompatibleRpcV2ProtocolClient : AmazonServiceClient, IAmazonQueryCompatibleRpcV2Protocol
    {
        private static IServiceMetadata serviceMetadata = new AmazonQueryCompatibleRpcV2ProtocolMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonQueryCompatibleRpcV2ProtocolClient with the credentials loaded from the application's
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
        public AmazonQueryCompatibleRpcV2ProtocolClient()
            : base(new AmazonQueryCompatibleRpcV2ProtocolConfig()) { }

        /// <summary>
        /// Constructs AmazonQueryCompatibleRpcV2ProtocolClient with the credentials loaded from the application's
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
        public AmazonQueryCompatibleRpcV2ProtocolClient(RegionEndpoint region)
            : base(new AmazonQueryCompatibleRpcV2ProtocolConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQueryCompatibleRpcV2ProtocolClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQueryCompatibleRpcV2ProtocolClient Configuration Object</param>
        public AmazonQueryCompatibleRpcV2ProtocolClient(AmazonQueryCompatibleRpcV2ProtocolConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonQueryCompatibleRpcV2ProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQueryCompatibleRpcV2ProtocolClient(AWSCredentials credentials)
            : this(credentials, new AmazonQueryCompatibleRpcV2ProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleRpcV2ProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryCompatibleRpcV2ProtocolClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQueryCompatibleRpcV2ProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleRpcV2ProtocolClient with AWS Credentials and an
        /// AmazonQueryCompatibleRpcV2ProtocolClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQueryCompatibleRpcV2ProtocolClient Configuration Object</param>
        public AmazonQueryCompatibleRpcV2ProtocolClient(AWSCredentials credentials, AmazonQueryCompatibleRpcV2ProtocolConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleRpcV2ProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQueryCompatibleRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQueryCompatibleRpcV2ProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleRpcV2ProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryCompatibleRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQueryCompatibleRpcV2ProtocolConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleRpcV2ProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQueryCompatibleRpcV2ProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQueryCompatibleRpcV2ProtocolClient Configuration Object</param>
        public AmazonQueryCompatibleRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonQueryCompatibleRpcV2ProtocolConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleRpcV2ProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQueryCompatibleRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQueryCompatibleRpcV2ProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleRpcV2ProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryCompatibleRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQueryCompatibleRpcV2ProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleRpcV2ProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQueryCompatibleRpcV2ProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQueryCompatibleRpcV2ProtocolClient Configuration Object</param>
        public AmazonQueryCompatibleRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQueryCompatibleRpcV2ProtocolConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQueryCompatibleRpcV2ProtocolAuthSchemeHandler());
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


        #region  QueryCompatibleOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryCompatibleOperation service method.</param>
        /// 
        /// <returns>The response from the QueryCompatibleOperation service method, as returned by QueryCompatibleRpcV2Protocol.</returns>
        /// <exception cref="Amazon.QueryCompatibleRpcV2Protocol.Model.CustomCodeErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.QueryCompatibleRpcV2Protocol.Model.NoCustomCodeErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-compatible-rpcv2-protocol-2025-06-20/QueryCompatibleOperation">REST API Reference for QueryCompatibleOperation Operation</seealso>
        public virtual QueryCompatibleOperationResponse QueryCompatibleOperation(QueryCompatibleOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryCompatibleOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryCompatibleOperationResponseUnmarshaller.Instance;

            return Invoke<QueryCompatibleOperationResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryCompatibleOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryCompatibleOperation service method, as returned by QueryCompatibleRpcV2Protocol.</returns>
        /// <exception cref="Amazon.QueryCompatibleRpcV2Protocol.Model.CustomCodeErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.QueryCompatibleRpcV2Protocol.Model.NoCustomCodeErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-compatible-rpcv2-protocol-2025-06-20/QueryCompatibleOperation">REST API Reference for QueryCompatibleOperation Operation</seealso>
        public virtual Task<QueryCompatibleOperationResponse> QueryCompatibleOperationAsync(QueryCompatibleOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryCompatibleOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryCompatibleOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<QueryCompatibleOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}