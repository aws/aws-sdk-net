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
 * Do not modify this file. This file is generated from the agent-registry-2025-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AgentRegistry.Model;
using Amazon.AgentRegistry.Model.Internal.MarshallTransformations;
using Amazon.AgentRegistry.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.AgentRegistry
{
    /// <summary>
    /// <para>Implementation for accessing AgentRegistry</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Agent Registry lets callers discover, list, and retrieve approved records published
    /// to a registry.
    /// </summary>
    public partial class AmazonAgentRegistryClient : AmazonServiceClient, IAmazonAgentRegistry
    {
        private static IServiceMetadata serviceMetadata = new AmazonAgentRegistryMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAgentRegistryClient with the credentials loaded from the application's
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
        public AmazonAgentRegistryClient()
            : base(new AmazonAgentRegistryConfig()) { }

        /// <summary>
        /// Constructs AmazonAgentRegistryClient with the credentials loaded from the application's
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
        public AmazonAgentRegistryClient(RegionEndpoint region)
            : base(new AmazonAgentRegistryConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAgentRegistryClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAgentRegistryClient Configuration Object</param>
        public AmazonAgentRegistryClient(AmazonAgentRegistryConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonAgentRegistryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAgentRegistryClient(AWSCredentials credentials)
            : this(credentials, new AmazonAgentRegistryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAgentRegistryClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAgentRegistryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryClient with AWS Credentials and an
        /// AmazonAgentRegistryClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAgentRegistryClient Configuration Object</param>
        public AmazonAgentRegistryClient(AWSCredentials credentials, AmazonAgentRegistryConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAgentRegistryClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAgentRegistryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAgentRegistryClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAgentRegistryConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAgentRegistryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAgentRegistryClient Configuration Object</param>
        public AmazonAgentRegistryClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAgentRegistryConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAgentRegistryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAgentRegistryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAgentRegistryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAgentRegistryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAgentRegistryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAgentRegistryClient Configuration Object</param>
        public AmazonAgentRegistryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAgentRegistryConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IAgentRegistryPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAgentRegistryPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AgentRegistryPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAgentRegistryEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAgentRegistryAuthSchemeHandler());
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


        #region  BatchGetDiscoverableRegistryRecord

        internal virtual BatchGetDiscoverableRegistryRecordResponse BatchGetDiscoverableRegistryRecord(BatchGetDiscoverableRegistryRecordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetDiscoverableRegistryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDiscoverableRegistryRecordResponseUnmarshaller.Instance;

            return Invoke<BatchGetDiscoverableRegistryRecordResponse>(request, options);
        }



        /// <summary>
        /// Retrieves multiple discoverable registry records by ID from a single registry. Records
        /// that cannot be retrieved are reported individually in the <c>errors</c> list rather
        /// than failing the entire request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDiscoverableRegistryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetDiscoverableRegistryRecord service method, as returned by AgentRegistry.</returns>
        /// <exception cref="Amazon.AgentRegistry.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.UnauthorizedException">
        /// The request could not be authenticated.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-2025-12-01/BatchGetDiscoverableRegistryRecord">REST API Reference for BatchGetDiscoverableRegistryRecord Operation</seealso>
        public virtual Task<BatchGetDiscoverableRegistryRecordResponse> BatchGetDiscoverableRegistryRecordAsync(BatchGetDiscoverableRegistryRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetDiscoverableRegistryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDiscoverableRegistryRecordResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetDiscoverableRegistryRecordResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDiscoverableRegistryRecords

        internal virtual ListDiscoverableRegistryRecordsResponse ListDiscoverableRegistryRecords(ListDiscoverableRegistryRecordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoverableRegistryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoverableRegistryRecordsResponseUnmarshaller.Instance;

            return Invoke<ListDiscoverableRegistryRecordsResponse>(request, options);
        }



        /// <summary>
        /// Lists the discoverable registry records in a registry. You can optionally filter
        /// and paginate the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoverableRegistryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDiscoverableRegistryRecords service method, as returned by AgentRegistry.</returns>
        /// <exception cref="Amazon.AgentRegistry.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.UnauthorizedException">
        /// The request could not be authenticated.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-2025-12-01/ListDiscoverableRegistryRecords">REST API Reference for ListDiscoverableRegistryRecords Operation</seealso>
        public virtual Task<ListDiscoverableRegistryRecordsResponse> ListDiscoverableRegistryRecordsAsync(ListDiscoverableRegistryRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoverableRegistryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoverableRegistryRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDiscoverableRegistryRecordsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchDiscoverableRegistryRecords

        internal virtual SearchDiscoverableRegistryRecordsResponse SearchDiscoverableRegistryRecords(SearchDiscoverableRegistryRecordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchDiscoverableRegistryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDiscoverableRegistryRecordsResponseUnmarshaller.Instance;

            return Invoke<SearchDiscoverableRegistryRecordsResponse>(request, options);
        }



        /// <summary>
        /// Searches the discoverable registry records in a registry using a natural language
        /// query. Returns metadata for the matching records ordered by relevance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDiscoverableRegistryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchDiscoverableRegistryRecords service method, as returned by AgentRegistry.</returns>
        /// <exception cref="Amazon.AgentRegistry.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.UnauthorizedException">
        /// The request could not be authenticated.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-2025-12-01/SearchDiscoverableRegistryRecords">REST API Reference for SearchDiscoverableRegistryRecords Operation</seealso>
        public virtual Task<SearchDiscoverableRegistryRecordsResponse> SearchDiscoverableRegistryRecordsAsync(SearchDiscoverableRegistryRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchDiscoverableRegistryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDiscoverableRegistryRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchDiscoverableRegistryRecordsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}