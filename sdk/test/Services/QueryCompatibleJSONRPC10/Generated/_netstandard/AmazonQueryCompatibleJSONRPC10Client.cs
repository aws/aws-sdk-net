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
 * Do not modify this file. This file is generated from the query-compatible-json-rpc-10-2020-07-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.QueryCompatibleJSONRPC10.Model;
using Amazon.QueryCompatibleJSONRPC10.Model.Internal.MarshallTransformations;
using Amazon.QueryCompatibleJSONRPC10.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.QueryCompatibleJSONRPC10
{
    /// <summary>
    /// <para>Implementation for accessing QueryCompatibleJSONRPC10</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonQueryCompatibleJSONRPC10Client : AmazonServiceClient, IAmazonQueryCompatibleJSONRPC10
    {
        private static IServiceMetadata serviceMetadata = new AmazonQueryCompatibleJSONRPC10Metadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with the credentials loaded from the application's
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
        public AmazonQueryCompatibleJSONRPC10Client()
            : base(new AmazonQueryCompatibleJSONRPC10Config()) { }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with the credentials loaded from the application's
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
        public AmazonQueryCompatibleJSONRPC10Client(RegionEndpoint region)
            : base(new AmazonQueryCompatibleJSONRPC10Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQueryCompatibleJSONRPC10Client Configuration Object</param>
        public AmazonQueryCompatibleJSONRPC10Client(AmazonQueryCompatibleJSONRPC10Config config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQueryCompatibleJSONRPC10Client(AWSCredentials credentials)
            : this(credentials, new AmazonQueryCompatibleJSONRPC10Config())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryCompatibleJSONRPC10Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQueryCompatibleJSONRPC10Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Credentials and an
        /// AmazonQueryCompatibleJSONRPC10Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQueryCompatibleJSONRPC10Client Configuration Object</param>
        public AmazonQueryCompatibleJSONRPC10Client(AWSCredentials credentials, AmazonQueryCompatibleJSONRPC10Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQueryCompatibleJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQueryCompatibleJSONRPC10Config())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryCompatibleJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQueryCompatibleJSONRPC10Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQueryCompatibleJSONRPC10Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQueryCompatibleJSONRPC10Client Configuration Object</param>
        public AmazonQueryCompatibleJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonQueryCompatibleJSONRPC10Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQueryCompatibleJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQueryCompatibleJSONRPC10Config())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryCompatibleJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQueryCompatibleJSONRPC10Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQueryCompatibleJSONRPC10Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQueryCompatibleJSONRPC10Client Configuration Object</param>
        public AmazonQueryCompatibleJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQueryCompatibleJSONRPC10Config clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQueryCompatibleJSONRPC10AuthSchemeHandler());
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

        internal virtual QueryCompatibleOperationResponse QueryCompatibleOperation(QueryCompatibleOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the QueryCompatibleOperation service method, as returned by QueryCompatibleJSONRPC10.</returns>
        /// <exception cref="Amazon.QueryCompatibleJSONRPC10.Model.CustomCodeErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.QueryCompatibleJSONRPC10.Model.NoCustomCodeErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-compatible-json-rpc-10-2020-07-14/QueryCompatibleOperation">REST API Reference for QueryCompatibleOperation Operation</seealso>
        public virtual Task<QueryCompatibleOperationResponse> QueryCompatibleOperationAsync(QueryCompatibleOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryCompatibleOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryCompatibleOperationResponseUnmarshaller.Instance;

            return InvokeAsync<QueryCompatibleOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
    }
}