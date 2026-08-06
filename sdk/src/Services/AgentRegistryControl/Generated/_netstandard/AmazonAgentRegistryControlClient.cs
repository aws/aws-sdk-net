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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AgentRegistryControl.Model;
using Amazon.AgentRegistryControl.Model.Internal.MarshallTransformations;
using Amazon.AgentRegistryControl.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.AgentRegistryControl
{
    /// <summary>
    /// <para>Implementation for accessing AgentRegistryControl</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// AWS Agent Registry is a managed catalog for publishing and discovering resources such
    /// as MCP servers, agents, and agent skills. Agent Registry Control is its control-plane
    /// API: use it to create and manage registries and the records they contain, configure
    /// discovery and authorization, govern record approval and curation workflows, and manage
    /// automatic detection of resources. Data-plane search and MCP invocation operations
    /// are provided by the companion Agent Registry API.
    /// </summary>
    public partial class AmazonAgentRegistryControlClient : AmazonServiceClient, IAmazonAgentRegistryControl
    {
        private static IServiceMetadata serviceMetadata = new AmazonAgentRegistryControlMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAgentRegistryControlClient with the credentials loaded from the application's
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
        public AmazonAgentRegistryControlClient()
            : base(new AmazonAgentRegistryControlConfig()) { }

        /// <summary>
        /// Constructs AmazonAgentRegistryControlClient with the credentials loaded from the application's
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
        public AmazonAgentRegistryControlClient(RegionEndpoint region)
            : base(new AmazonAgentRegistryControlConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAgentRegistryControlClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAgentRegistryControlClient Configuration Object</param>
        public AmazonAgentRegistryControlClient(AmazonAgentRegistryControlConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonAgentRegistryControlClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAgentRegistryControlClient(AWSCredentials credentials)
            : this(credentials, new AmazonAgentRegistryControlConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryControlClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAgentRegistryControlClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAgentRegistryControlConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryControlClient with AWS Credentials and an
        /// AmazonAgentRegistryControlClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAgentRegistryControlClient Configuration Object</param>
        public AmazonAgentRegistryControlClient(AWSCredentials credentials, AmazonAgentRegistryControlConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryControlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAgentRegistryControlClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAgentRegistryControlConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryControlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAgentRegistryControlClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAgentRegistryControlConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryControlClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAgentRegistryControlClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAgentRegistryControlClient Configuration Object</param>
        public AmazonAgentRegistryControlClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAgentRegistryControlConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryControlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAgentRegistryControlClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAgentRegistryControlConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryControlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAgentRegistryControlClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAgentRegistryControlConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAgentRegistryControlClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAgentRegistryControlClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAgentRegistryControlClient Configuration Object</param>
        public AmazonAgentRegistryControlClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAgentRegistryControlConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IAgentRegistryControlPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAgentRegistryControlPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AgentRegistryControlPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAgentRegistryControlEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAgentRegistryControlAuthSchemeHandler());
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


        #region  CreateRegistry

        internal virtual CreateRegistryResponse CreateRegistry(CreateRegistryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistryResponseUnmarshaller.Instance;

            return Invoke<CreateRegistryResponse>(request, options);
        }



        /// <summary>
        /// Creates a new registry, a catalog that organizes registry records and defines their
        /// discovery authorization and record approval behavior. Creation is asynchronous: the
        /// registry begins in the CREATING status and becomes usable once it reaches READY.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistry service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        public virtual Task<CreateRegistryResponse> CreateRegistryAsync(CreateRegistryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRegistryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRegistryRecord

        internal virtual CreateRegistryRecordResponse CreateRegistryRecord(CreateRegistryRecordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistryRecordResponseUnmarshaller.Instance;

            return Invoke<CreateRegistryRecordResponse>(request, options);
        }



        /// <summary>
        /// Creates a registry record within a registry. A registry record describes a discoverable
        /// resource, such as an MCP server, an agent, an agent skill, or a custom resource. Creation
        /// is asynchronous: the record is returned with the CREATING status while it is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistryRecord service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/CreateRegistryRecord">REST API Reference for CreateRegistryRecord Operation</seealso>
        public virtual Task<CreateRegistryRecordResponse> CreateRegistryRecordAsync(CreateRegistryRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistryRecordResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRegistryRecordResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRegistry

        internal virtual DeleteRegistryResponse DeleteRegistry(DeleteRegistryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistryResponseUnmarshaller.Instance;

            return Invoke<DeleteRegistryResponse>(request, options);
        }



        /// <summary>
        /// Deletes a registry. Deletion is asynchronous: the registry transitions to the DELETING
        /// status and is removed along with its registry records.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegistry service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        public virtual Task<DeleteRegistryResponse> DeleteRegistryAsync(DeleteRegistryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRegistryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRegistryRecord

        internal virtual DeleteRegistryRecordResponse DeleteRegistryRecord(DeleteRegistryRecordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegistryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistryRecordResponseUnmarshaller.Instance;

            return Invoke<DeleteRegistryRecordResponse>(request, options);
        }



        /// <summary>
        /// Deletes a registry record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegistryRecord service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/DeleteRegistryRecord">REST API Reference for DeleteRegistryRecord Operation</seealso>
        public virtual Task<DeleteRegistryRecordResponse> DeleteRegistryRecordAsync(DeleteRegistryRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegistryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistryRecordResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRegistryRecordResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRegistry

        internal virtual GetRegistryResponse GetRegistry(GetRegistryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistryResponseUnmarshaller.Instance;

            return Invoke<GetRegistryResponse>(request, options);
        }



        /// <summary>
        /// Gets a registry by identifier (ARN or ID)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegistry service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/GetRegistry">REST API Reference for GetRegistry Operation</seealso>
        public virtual Task<GetRegistryResponse> GetRegistryAsync(GetRegistryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistryResponseUnmarshaller.Instance;

            return InvokeAsync<GetRegistryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRegistryRecord

        internal virtual GetRegistryRecordResponse GetRegistryRecord(GetRegistryRecordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRegistryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistryRecordResponseUnmarshaller.Instance;

            return Invoke<GetRegistryRecordResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of a registry record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegistryRecord service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/GetRegistryRecord">REST API Reference for GetRegistryRecord Operation</seealso>
        public virtual Task<GetRegistryRecordResponse> GetRegistryRecordAsync(GetRegistryRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRegistryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistryRecordResponseUnmarshaller.Instance;

            return InvokeAsync<GetRegistryRecordResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRegistries

        internal virtual ListRegistriesResponse ListRegistries(ListRegistriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegistriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistriesResponseUnmarshaller.Instance;

            return Invoke<ListRegistriesResponse>(request, options);
        }



        /// <summary>
        /// Lists the registries in the caller's account and Region, with optional filtering by
        /// status and discovery authorizer type
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegistries service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        public virtual Task<ListRegistriesResponse> ListRegistriesAsync(ListRegistriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegistriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRegistriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRegistryRecords

        internal virtual ListRegistryRecordsResponse ListRegistryRecords(ListRegistryRecordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegistryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistryRecordsResponseUnmarshaller.Instance;

            return Invoke<ListRegistryRecordsResponse>(request, options);
        }



        /// <summary>
        /// Lists the registry records within a registry, with optional filtering by name, status,
        /// and record type
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegistryRecords service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ListRegistryRecords">REST API Reference for ListRegistryRecords Operation</seealso>
        public virtual Task<ListRegistryRecordsResponse> ListRegistryRecordsAsync(ListRegistryRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegistryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistryRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRegistryRecordsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// List the tags on a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SubmitRegistryRecordForApproval

        internal virtual SubmitRegistryRecordForApprovalResponse SubmitRegistryRecordForApproval(SubmitRegistryRecordForApprovalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubmitRegistryRecordForApprovalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitRegistryRecordForApprovalResponseUnmarshaller.Instance;

            return Invoke<SubmitRegistryRecordForApprovalResponse>(request, options);
        }



        /// <summary>
        /// Submits a DRAFT registry record for approval, moving it into the registry's approval
        /// workflow. Depending on the registry's approval configuration, the record is either
        /// auto-approved or set to PENDING_APPROVAL for a curator to approve or reject.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitRegistryRecordForApproval service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitRegistryRecordForApproval service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/SubmitRegistryRecordForApproval">REST API Reference for SubmitRegistryRecordForApproval Operation</seealso>
        public virtual Task<SubmitRegistryRecordForApprovalResponse> SubmitRegistryRecordForApprovalAsync(SubmitRegistryRecordForApprovalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubmitRegistryRecordForApprovalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitRegistryRecordForApprovalResponseUnmarshaller.Instance;

            return InvokeAsync<SubmitRegistryRecordForApprovalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Tag a resource with key-value pairs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Remove tags from a resource by key
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRegistry

        internal virtual UpdateRegistryResponse UpdateRegistry(UpdateRegistryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistryResponseUnmarshaller.Instance;

            return Invoke<UpdateRegistryResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing registry. This operation uses PATCH semantics: specify only the
        /// fields you want to change, and omit the rest to leave them unchanged. Updates are
        /// applied asynchronously and the registry transitions to the UPDATING status while they
        /// are processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegistry service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        public virtual Task<UpdateRegistryResponse> UpdateRegistryAsync(UpdateRegistryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistryResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRegistryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRegistryRecord

        internal virtual UpdateRegistryRecordResponse UpdateRegistryRecord(UpdateRegistryRecordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegistryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistryRecordResponseUnmarshaller.Instance;

            return Invoke<UpdateRegistryRecordResponse>(request, options);
        }



        /// <summary>
        /// Updates a registry record. The update is asynchronous: the record is returned with
        /// the UPDATING status while it is processed. Fields that use update wrappers follow
        /// PATCH semantics: omit the field to leave it unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegistryRecord service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/UpdateRegistryRecord">REST API Reference for UpdateRegistryRecord Operation</seealso>
        public virtual Task<UpdateRegistryRecordResponse> UpdateRegistryRecordAsync(UpdateRegistryRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegistryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistryRecordResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRegistryRecordResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRegistryRecordStatus

        internal virtual UpdateRegistryRecordStatusResponse UpdateRegistryRecordStatus(UpdateRegistryRecordStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegistryRecordStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistryRecordStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateRegistryRecordStatusResponse>(request, options);
        }



        /// <summary>
        /// Updates the status of a registry record as part of the registry's curation workflow,
        /// for example to approve or reject a record that is pending approval, or to deprecate
        /// an approved record so that it is no longer discoverable
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistryRecordStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegistryRecordStatus service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/UpdateRegistryRecordStatus">REST API Reference for UpdateRegistryRecordStatus Operation</seealso>
        public virtual Task<UpdateRegistryRecordStatusResponse> UpdateRegistryRecordStatusAsync(UpdateRegistryRecordStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegistryRecordStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistryRecordStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRegistryRecordStatusResponse>(request, options, cancellationToken);
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