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
 * Do not modify this file. This file is generated from the non-query-compatible-rpcv2-protocol-2025-06-20.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.NonQueryCompatibleRpcV2Protocol.Model;
using Amazon.NonQueryCompatibleRpcV2Protocol.Model.Internal.MarshallTransformations;
using Amazon.NonQueryCompatibleRpcV2Protocol.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.NonQueryCompatibleRpcV2Protocol
{
    /// <summary>
    /// <para>Implementation for accessing NonQueryCompatibleRpcV2Protocol</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonNonQueryCompatibleRpcV2ProtocolClient : AmazonServiceClient, IAmazonNonQueryCompatibleRpcV2Protocol
    {
        private static IServiceMetadata serviceMetadata = new AmazonNonQueryCompatibleRpcV2ProtocolMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonNonQueryCompatibleRpcV2ProtocolClient with the credentials loaded from the application's
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
        public AmazonNonQueryCompatibleRpcV2ProtocolClient()
            : base(new AmazonNonQueryCompatibleRpcV2ProtocolConfig()) { }

        /// <summary>
        /// Constructs AmazonNonQueryCompatibleRpcV2ProtocolClient with the credentials loaded from the application's
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
        public AmazonNonQueryCompatibleRpcV2ProtocolClient(RegionEndpoint region)
            : base(new AmazonNonQueryCompatibleRpcV2ProtocolConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNonQueryCompatibleRpcV2ProtocolClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNonQueryCompatibleRpcV2ProtocolClient Configuration Object</param>
        public AmazonNonQueryCompatibleRpcV2ProtocolClient(AmazonNonQueryCompatibleRpcV2ProtocolConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonNonQueryCompatibleRpcV2ProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNonQueryCompatibleRpcV2ProtocolClient(AWSCredentials credentials)
            : this(credentials, new AmazonNonQueryCompatibleRpcV2ProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNonQueryCompatibleRpcV2ProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNonQueryCompatibleRpcV2ProtocolClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNonQueryCompatibleRpcV2ProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNonQueryCompatibleRpcV2ProtocolClient with AWS Credentials and an
        /// AmazonNonQueryCompatibleRpcV2ProtocolClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNonQueryCompatibleRpcV2ProtocolClient Configuration Object</param>
        public AmazonNonQueryCompatibleRpcV2ProtocolClient(AWSCredentials credentials, AmazonNonQueryCompatibleRpcV2ProtocolConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNonQueryCompatibleRpcV2ProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNonQueryCompatibleRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNonQueryCompatibleRpcV2ProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNonQueryCompatibleRpcV2ProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNonQueryCompatibleRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNonQueryCompatibleRpcV2ProtocolConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNonQueryCompatibleRpcV2ProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNonQueryCompatibleRpcV2ProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNonQueryCompatibleRpcV2ProtocolClient Configuration Object</param>
        public AmazonNonQueryCompatibleRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNonQueryCompatibleRpcV2ProtocolConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNonQueryCompatibleRpcV2ProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNonQueryCompatibleRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNonQueryCompatibleRpcV2ProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNonQueryCompatibleRpcV2ProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNonQueryCompatibleRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNonQueryCompatibleRpcV2ProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNonQueryCompatibleRpcV2ProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNonQueryCompatibleRpcV2ProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNonQueryCompatibleRpcV2ProtocolClient Configuration Object</param>
        public AmazonNonQueryCompatibleRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNonQueryCompatibleRpcV2ProtocolConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNonQueryCompatibleRpcV2ProtocolAuthSchemeHandler());
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


        #region  NonQueryCompatibleOperation

        internal virtual NonQueryCompatibleOperationResponse NonQueryCompatibleOperation(NonQueryCompatibleOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NonQueryCompatibleOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NonQueryCompatibleOperationResponseUnmarshaller.Instance;

            return Invoke<NonQueryCompatibleOperationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NonQueryCompatibleOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NonQueryCompatibleOperation service method, as returned by NonQueryCompatibleRpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/non-query-compatible-rpcv2-protocol-2025-06-20/NonQueryCompatibleOperation">REST API Reference for NonQueryCompatibleOperation Operation</seealso>
        public virtual Task<NonQueryCompatibleOperationResponse> NonQueryCompatibleOperationAsync(NonQueryCompatibleOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NonQueryCompatibleOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NonQueryCompatibleOperationResponseUnmarshaller.Instance;

            return InvokeAsync<NonQueryCompatibleOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
    }
}