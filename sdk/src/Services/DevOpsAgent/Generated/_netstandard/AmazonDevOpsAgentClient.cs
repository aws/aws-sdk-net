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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DevOpsAgent.Model;
using Amazon.DevOpsAgent.Model.Internal.MarshallTransformations;
using Amazon.DevOpsAgent.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.DevOpsAgent
{
    /// <summary>
    /// <para>Implementation for accessing DevOpsAgent</para>
    ///
    /// AWS DevOps Agent is a frontier agent that resolves and proactively prevents incidents,
    /// continuously improving reliability and performance. AWS DevOps Agent investigates
    /// incidents and identifies operational improvements as an experienced DevOps engineer.
    /// 
    ///  
    /// <para>
    /// The agent works by:
    /// </para>
    ///  <ul> <li>Learning your resources and their relationships.</li> <li>Working with your
    /// observability tools, runbooks, code repositories, and CI/CD pipelines.</li> <li>Correlating
    /// telemetry, code, and deployment data to understand relationships between your application
    /// resources.</li> <li>Supporting applications in multicloud and hybrid environments.</li>
    /// </ul>
    /// </summary>
    public partial class AmazonDevOpsAgentClient : AmazonServiceClient, IAmazonDevOpsAgent
    {
        private static IServiceMetadata serviceMetadata = new AmazonDevOpsAgentMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonDevOpsAgentClient with the credentials loaded from the application's
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
        public AmazonDevOpsAgentClient()
            : base(new AmazonDevOpsAgentConfig()) { }

        /// <summary>
        /// Constructs AmazonDevOpsAgentClient with the credentials loaded from the application's
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
        public AmazonDevOpsAgentClient(RegionEndpoint region)
            : base(new AmazonDevOpsAgentConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDevOpsAgentClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDevOpsAgentClient Configuration Object</param>
        public AmazonDevOpsAgentClient(AmazonDevOpsAgentConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonDevOpsAgentClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDevOpsAgentClient(AWSCredentials credentials)
            : this(credentials, new AmazonDevOpsAgentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsAgentClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDevOpsAgentClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDevOpsAgentConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsAgentClient with AWS Credentials and an
        /// AmazonDevOpsAgentClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDevOpsAgentClient Configuration Object</param>
        public AmazonDevOpsAgentClient(AWSCredentials credentials, AmazonDevOpsAgentConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDevOpsAgentClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDevOpsAgentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDevOpsAgentClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDevOpsAgentConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsAgentClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDevOpsAgentClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDevOpsAgentClient Configuration Object</param>
        public AmazonDevOpsAgentClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDevOpsAgentConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDevOpsAgentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDevOpsAgentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDevOpsAgentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDevOpsAgentConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsAgentClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDevOpsAgentClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDevOpsAgentClient Configuration Object</param>
        public AmazonDevOpsAgentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDevOpsAgentConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IDevOpsAgentPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDevOpsAgentPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DevOpsAgentPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDevOpsAgentEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDevOpsAgentAuthSchemeHandler());
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


        #region  AllowVendedLogDeliveryForResource

        internal virtual AllowVendedLogDeliveryForResourceResponse AllowVendedLogDeliveryForResource(AllowVendedLogDeliveryForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AllowVendedLogDeliveryForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllowVendedLogDeliveryForResourceResponseUnmarshaller.Instance;

            return Invoke<AllowVendedLogDeliveryForResourceResponse>(request, options);
        }



        /// <summary>
        /// Authorize Ingestion Hub subscription operation. Looks to see if the derived accountId
        /// from FAS has an AgentSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllowVendedLogDeliveryForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllowVendedLogDeliveryForResource service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/AllowVendedLogDeliveryForResource">REST API Reference for AllowVendedLogDeliveryForResource Operation</seealso>
        public virtual Task<AllowVendedLogDeliveryForResourceResponse> AllowVendedLogDeliveryForResourceAsync(AllowVendedLogDeliveryForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AllowVendedLogDeliveryForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllowVendedLogDeliveryForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AllowVendedLogDeliveryForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateService

        internal virtual AssociateServiceResponse AssociateService(AssociateServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceResponseUnmarshaller.Instance;

            return Invoke<AssociateServiceResponse>(request, options);
        }



        /// <summary>
        /// Adds a specific service association to an AgentSpace. It overwrites the existing association
        /// of the same service. Returns 201 Created on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/AssociateService">REST API Reference for AssociateService Operation</seealso>
        public virtual Task<AssociateServiceResponse> AssociateServiceAsync(AssociateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateServiceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAgentSpace

        internal virtual CreateAgentSpaceResponse CreateAgentSpace(CreateAgentSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentSpaceResponseUnmarshaller.Instance;

            return Invoke<CreateAgentSpaceResponse>(request, options);
        }



        /// <summary>
        /// Creates a new AgentSpace with the specified name and description. Duplicate space
        /// names are allowed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgentSpace service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/CreateAgentSpace">REST API Reference for CreateAgentSpace Operation</seealso>
        public virtual Task<CreateAgentSpaceResponse> CreateAgentSpaceAsync(CreateAgentSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAgentSpaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateBacklogTask

        internal virtual CreateBacklogTaskResponse CreateBacklogTask(CreateBacklogTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBacklogTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBacklogTaskResponseUnmarshaller.Instance;

            return Invoke<CreateBacklogTaskResponse>(request, options);
        }



        /// <summary>
        /// Creates a new backlog task in the specified agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBacklogTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBacklogTask service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/CreateBacklogTask">REST API Reference for CreateBacklogTask Operation</seealso>
        public virtual Task<CreateBacklogTaskResponse> CreateBacklogTaskAsync(CreateBacklogTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBacklogTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBacklogTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBacklogTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateChat

        internal virtual CreateChatResponse CreateChat(CreateChatRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChatResponseUnmarshaller.Instance;

            return Invoke<CreateChatResponse>(request, options);
        }



        /// <summary>
        /// Creates a new chat execution in the specified agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChat service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/CreateChat">REST API Reference for CreateChat Operation</seealso>
        public virtual Task<CreateChatResponse> CreateChatAsync(CreateChatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChatResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChatResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePrivateConnection

        internal virtual CreatePrivateConnectionResponse CreatePrivateConnection(CreatePrivateConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePrivateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivateConnectionResponseUnmarshaller.Instance;

            return Invoke<CreatePrivateConnectionResponse>(request, options);
        }



        /// <summary>
        /// Creates a Private Connection to a target resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePrivateConnection service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/CreatePrivateConnection">REST API Reference for CreatePrivateConnection Operation</seealso>
        public virtual Task<CreatePrivateConnectionResponse> CreatePrivateConnectionAsync(CreatePrivateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePrivateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePrivateConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAgentSpace

        internal virtual DeleteAgentSpaceResponse DeleteAgentSpace(DeleteAgentSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentSpaceResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentSpaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes an AgentSpace. This operation is idempotent and returns a 204 No Content response
        /// on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgentSpace service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DeleteAgentSpace">REST API Reference for DeleteAgentSpace Operation</seealso>
        public virtual Task<DeleteAgentSpaceResponse> DeleteAgentSpaceAsync(DeleteAgentSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAgentSpaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePrivateConnection

        internal virtual DeletePrivateConnectionResponse DeletePrivateConnection(DeletePrivateConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePrivateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrivateConnectionResponseUnmarshaller.Instance;

            return Invoke<DeletePrivateConnectionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Private Connection. The deletion is asynchronous and returns DELETE_IN_PROGRESS
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrivateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePrivateConnection service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DeletePrivateConnection">REST API Reference for DeletePrivateConnection Operation</seealso>
        public virtual Task<DeletePrivateConnectionResponse> DeletePrivateConnectionAsync(DeletePrivateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePrivateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrivateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePrivateConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeregisterService

        internal virtual DeregisterServiceResponse DeregisterService(DeregisterServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterServiceResponseUnmarshaller.Instance;

            return Invoke<DeregisterServiceResponse>(request, options);
        }



        /// <summary>
        /// Deregister a service
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DeregisterService">REST API Reference for DeregisterService Operation</seealso>
        public virtual Task<DeregisterServiceResponse> DeregisterServiceAsync(DeregisterServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterServiceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterServiceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribePrivateConnection

        internal virtual DescribePrivateConnectionResponse DescribePrivateConnection(DescribePrivateConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePrivateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrivateConnectionResponseUnmarshaller.Instance;

            return Invoke<DescribePrivateConnectionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details of an existing Private Connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrivateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePrivateConnection service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DescribePrivateConnection">REST API Reference for DescribePrivateConnection Operation</seealso>
        public virtual Task<DescribePrivateConnectionResponse> DescribePrivateConnectionAsync(DescribePrivateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePrivateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrivateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePrivateConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSupportLevel

        internal virtual DescribeSupportLevelResponse DescribeSupportLevel(DescribeSupportLevelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSupportLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSupportLevelResponseUnmarshaller.Instance;

            return Invoke<DescribeSupportLevelResponse>(request, options);
        }



        /// <summary>
        /// Describe the support level of a CloudSmith customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSupportLevel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSupportLevel service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DescribeSupportLevel">REST API Reference for DescribeSupportLevel Operation</seealso>
        public virtual Task<DescribeSupportLevelResponse> DescribeSupportLevelAsync(DescribeSupportLevelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSupportLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSupportLevelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSupportLevelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableOperatorApp

        internal virtual DisableOperatorAppResponse DisableOperatorApp(DisableOperatorAppRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableOperatorAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableOperatorAppResponseUnmarshaller.Instance;

            return Invoke<DisableOperatorAppResponse>(request, options);
        }



        /// <summary>
        /// Disable the Operator App for the specified AgentSpace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOperatorApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableOperatorApp service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.IdentityCenterServiceException">
        /// Calls to the customer Identity Center have failed
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DisableOperatorApp">REST API Reference for DisableOperatorApp Operation</seealso>
        public virtual Task<DisableOperatorAppResponse> DisableOperatorAppAsync(DisableOperatorAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableOperatorAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableOperatorAppResponseUnmarshaller.Instance;

            return InvokeAsync<DisableOperatorAppResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateService

        internal virtual DisassociateServiceResponse DisassociateService(DisassociateServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceResponseUnmarshaller.Instance;

            return Invoke<DisassociateServiceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specific service association from an AgentSpace. This operation is idempotent
        /// and returns a 204 No Content response on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DisassociateService">REST API Reference for DisassociateService Operation</seealso>
        public virtual Task<DisassociateServiceResponse> DisassociateServiceAsync(DisassociateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateServiceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableOperatorApp

        internal virtual EnableOperatorAppResponse EnableOperatorApp(EnableOperatorAppRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableOperatorAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableOperatorAppResponseUnmarshaller.Instance;

            return Invoke<EnableOperatorAppResponse>(request, options);
        }



        /// <summary>
        /// Enable the Operator App to access the given AgentSpace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOperatorApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableOperatorApp service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.IdentityCenterServiceException">
        /// Calls to the customer Identity Center have failed
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/EnableOperatorApp">REST API Reference for EnableOperatorApp Operation</seealso>
        public virtual Task<EnableOperatorAppResponse> EnableOperatorAppAsync(EnableOperatorAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableOperatorAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableOperatorAppResponseUnmarshaller.Instance;

            return InvokeAsync<EnableOperatorAppResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EndChatForCase

        internal virtual EndChatForCaseResponse EndChatForCase(EndChatForCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndChatForCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndChatForCaseResponseUnmarshaller.Instance;

            return Invoke<EndChatForCaseResponse>(request, options);
        }



        /// <summary>
        /// End a chat session for a support case in the specified agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndChatForCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EndChatForCase service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/EndChatForCase">REST API Reference for EndChatForCase Operation</seealso>
        public virtual Task<EndChatForCaseResponse> EndChatForCaseAsync(EndChatForCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndChatForCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndChatForCaseResponseUnmarshaller.Instance;

            return InvokeAsync<EndChatForCaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAccountUsage

        internal virtual GetAccountUsageResponse GetAccountUsage(GetAccountUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountUsageResponseUnmarshaller.Instance;

            return Invoke<GetAccountUsageResponse>(request, options);
        }



        /// <summary>
        /// Retrieves monthly account usage metrics and limits for the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountUsage service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetAccountUsage">REST API Reference for GetAccountUsage Operation</seealso>
        public virtual Task<GetAccountUsageResponse> GetAccountUsageAsync(GetAccountUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountUsageResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountUsageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAgentSpace

        internal virtual GetAgentSpaceResponse GetAgentSpace(GetAgentSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentSpaceResponseUnmarshaller.Instance;

            return Invoke<GetAgentSpaceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about a specific AgentSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentSpace service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetAgentSpace">REST API Reference for GetAgentSpace Operation</seealso>
        public virtual Task<GetAgentSpaceResponse> GetAgentSpaceAsync(GetAgentSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<GetAgentSpaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAssociation

        internal virtual GetAssociationResponse GetAssociation(GetAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssociationResponseUnmarshaller.Instance;

            return Invoke<GetAssociationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves given associations configured for a specific AgentSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssociation service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetAssociation">REST API Reference for GetAssociation Operation</seealso>
        public virtual Task<GetAssociationResponse> GetAssociationAsync(GetAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetBacklogTask

        internal virtual GetBacklogTaskResponse GetBacklogTask(GetBacklogTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBacklogTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBacklogTaskResponseUnmarshaller.Instance;

            return Invoke<GetBacklogTaskResponse>(request, options);
        }



        /// <summary>
        /// Gets a backlog task for the specified agent space and task id
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBacklogTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBacklogTask service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetBacklogTask">REST API Reference for GetBacklogTask Operation</seealso>
        public virtual Task<GetBacklogTaskResponse> GetBacklogTaskAsync(GetBacklogTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBacklogTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBacklogTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetBacklogTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetOperatorApp

        internal virtual GetOperatorAppResponse GetOperatorApp(GetOperatorAppRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOperatorAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperatorAppResponseUnmarshaller.Instance;

            return Invoke<GetOperatorAppResponse>(request, options);
        }



        /// <summary>
        /// Get the full auth configuration of operator including any enabled auth flow
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperatorApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOperatorApp service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetOperatorApp">REST API Reference for GetOperatorApp Operation</seealso>
        public virtual Task<GetOperatorAppResponse> GetOperatorAppAsync(GetOperatorAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOperatorAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperatorAppResponseUnmarshaller.Instance;

            return InvokeAsync<GetOperatorAppResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRecommendation

        internal virtual GetRecommendationResponse GetRecommendation(GetRecommendationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a specific recommendation by its ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecommendation service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        public virtual Task<GetRecommendationResponse> GetRecommendationAsync(GetRecommendationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationResponseUnmarshaller.Instance;

            return InvokeAsync<GetRecommendationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetService

        internal virtual GetServiceResponse GetService(GetServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceResponseUnmarshaller.Instance;

            return Invoke<GetServiceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves given service by it's unique identifier
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetService">REST API Reference for GetService Operation</seealso>
        public virtual Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  InitiateChatForCase

        internal virtual InitiateChatForCaseResponse InitiateChatForCase(InitiateChatForCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitiateChatForCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateChatForCaseResponseUnmarshaller.Instance;

            return Invoke<InitiateChatForCaseResponse>(request, options);
        }



        /// <summary>
        /// Initiate a chat for support case in the specified agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateChatForCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitiateChatForCase service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/InitiateChatForCase">REST API Reference for InitiateChatForCase Operation</seealso>
        public virtual Task<InitiateChatForCaseResponse> InitiateChatForCaseAsync(InitiateChatForCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitiateChatForCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateChatForCaseResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateChatForCaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAgentSpaces

        internal virtual ListAgentSpacesResponse ListAgentSpaces(ListAgentSpacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentSpacesResponseUnmarshaller.Instance;

            return Invoke<ListAgentSpacesResponse>(request, options);
        }



        /// <summary>
        /// Lists all AgentSpaces with optional pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentSpaces service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListAgentSpaces">REST API Reference for ListAgentSpaces Operation</seealso>
        public virtual Task<ListAgentSpacesResponse> ListAgentSpacesAsync(ListAgentSpacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentSpacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgentSpacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssociations

        internal virtual ListAssociationsResponse ListAssociations(ListAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListAssociationsResponse>(request, options);
        }



        /// <summary>
        /// List all associations for given AgentSpace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        public virtual Task<ListAssociationsResponse> ListAssociationsAsync(ListAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBacklogTasks

        internal virtual ListBacklogTasksResponse ListBacklogTasks(ListBacklogTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBacklogTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBacklogTasksResponseUnmarshaller.Instance;

            return Invoke<ListBacklogTasksResponse>(request, options);
        }



        /// <summary>
        /// Lists backlog tasks in the specified agent space with optional filtering and sorting
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBacklogTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBacklogTasks service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListBacklogTasks">REST API Reference for ListBacklogTasks Operation</seealso>
        public virtual Task<ListBacklogTasksResponse> ListBacklogTasksAsync(ListBacklogTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBacklogTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBacklogTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListBacklogTasksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListChats

        internal virtual ListChatsResponse ListChats(ListChatsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChatsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChatsResponseUnmarshaller.Instance;

            return Invoke<ListChatsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of the user's recent chat executions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChats service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChats service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListChats">REST API Reference for ListChats Operation</seealso>
        public virtual Task<ListChatsResponse> ListChatsAsync(ListChatsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChatsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChatsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChatsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListExecutions

        internal virtual ListExecutionsResponse ListExecutions(ListExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListExecutionsResponse>(request, options);
        }



        /// <summary>
        /// List executions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        public virtual Task<ListExecutionsResponse> ListExecutionsAsync(ListExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExecutionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGoals

        internal virtual ListGoalsResponse ListGoals(ListGoalsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGoalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGoalsResponseUnmarshaller.Instance;

            return Invoke<ListGoalsResponse>(request, options);
        }



        /// <summary>
        /// Lists goals in the specified agent space with optional filtering
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGoals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGoals service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListGoals">REST API Reference for ListGoals Operation</seealso>
        public virtual Task<ListGoalsResponse> ListGoalsAsync(ListGoalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGoalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGoalsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGoalsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListJournalRecords

        internal virtual ListJournalRecordsResponse ListJournalRecords(ListJournalRecordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJournalRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJournalRecordsResponseUnmarshaller.Instance;

            return Invoke<ListJournalRecordsResponse>(request, options);
        }



        /// <summary>
        /// List journal records for a specific execution
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJournalRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJournalRecords service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListJournalRecords">REST API Reference for ListJournalRecords Operation</seealso>
        public virtual Task<ListJournalRecordsResponse> ListJournalRecordsAsync(ListJournalRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJournalRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJournalRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJournalRecordsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPendingMessages

        internal virtual ListPendingMessagesResponse ListPendingMessages(ListPendingMessagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPendingMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPendingMessagesResponseUnmarshaller.Instance;

            return Invoke<ListPendingMessagesResponse>(request, options);
        }



        /// <summary>
        /// List pending messages for a specific execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPendingMessages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPendingMessages service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListPendingMessages">REST API Reference for ListPendingMessages Operation</seealso>
        public virtual Task<ListPendingMessagesResponse> ListPendingMessagesAsync(ListPendingMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPendingMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPendingMessagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPendingMessagesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPrivateConnections

        internal virtual ListPrivateConnectionsResponse ListPrivateConnections(ListPrivateConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPrivateConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivateConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListPrivateConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all Private Connections in the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrivateConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrivateConnections service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListPrivateConnections">REST API Reference for ListPrivateConnections Operation</seealso>
        public virtual Task<ListPrivateConnectionsResponse> ListPrivateConnectionsAsync(ListPrivateConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPrivateConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivateConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPrivateConnectionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRecommendations

        internal virtual ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Lists recommendations for the specified agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual Task<ListRecommendationsResponse> ListRecommendationsAsync(ListRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListServices

        internal virtual ListServicesResponse ListServices(ListServicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return Invoke<ListServicesResponse>(request, options);
        }



        /// <summary>
        /// List a list of registered service on the account level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListServicesResponse>(request, options, cancellationToken);
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
        /// Lists tags for the specified AWS DevOps Agent resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWebhooks

        internal virtual ListWebhooksResponse ListWebhooks(ListWebhooksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWebhooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebhooksResponseUnmarshaller.Instance;

            return Invoke<ListWebhooksResponse>(request, options);
        }



        /// <summary>
        /// List all webhooks for given Association
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebhooks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebhooks service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListWebhooks">REST API Reference for ListWebhooks Operation</seealso>
        public virtual Task<ListWebhooksResponse> ListWebhooksAsync(ListWebhooksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWebhooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebhooksResponseUnmarshaller.Instance;

            return InvokeAsync<ListWebhooksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RegisterService

        internal virtual RegisterServiceResponse RegisterService(RegisterServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterServiceResponseUnmarshaller.Instance;

            return Invoke<RegisterServiceResponse>(request, options);
        }



        /// <summary>
        /// This operation registers the specified service
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/RegisterService">REST API Reference for RegisterService Operation</seealso>
        public virtual Task<RegisterServiceResponse> RegisterServiceAsync(RegisterServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterServiceResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterServiceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SendMessage

        internal virtual SendMessageResponse SendMessage(SendMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageResponseUnmarshaller.Instance;

            return Invoke<SendMessageResponse>(request, options);
        }



        /// <summary>
        /// Sends a chat message and streams the response for the specified agent space execution
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/SendMessage">REST API Reference for SendMessage Operation</seealso>
        public virtual Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageResponseUnmarshaller.Instance;

            return InvokeAsync<SendMessageResponse>(request, options, cancellationToken);
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
        /// Adds or overwrites tags for the specified AWS DevOps Agent resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from the specified AWS DevOps Agent resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAgentSpace

        internal virtual UpdateAgentSpaceResponse UpdateAgentSpace(UpdateAgentSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentSpaceResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentSpaceResponse>(request, options);
        }



        /// <summary>
        /// Updates the information of an existing AgentSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentSpace service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateAgentSpace">REST API Reference for UpdateAgentSpace Operation</seealso>
        public virtual Task<UpdateAgentSpaceResponse> UpdateAgentSpaceAsync(UpdateAgentSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAgentSpaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAssociation

        internal virtual UpdateAssociationResponse UpdateAssociation(UpdateAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateAssociationResponse>(request, options);
        }



        /// <summary>
        /// Partially updates the configuration of an existing service association for an AgentSpace.
        /// Present fields are fully replaced; absent fields are left unchanged. Returns 200 OK
        /// on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssociation service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateAssociation">REST API Reference for UpdateAssociation Operation</seealso>
        public virtual Task<UpdateAssociationResponse> UpdateAssociationAsync(UpdateAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBacklogTask

        internal virtual UpdateBacklogTaskResponse UpdateBacklogTask(UpdateBacklogTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBacklogTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBacklogTaskResponseUnmarshaller.Instance;

            return Invoke<UpdateBacklogTaskResponse>(request, options);
        }



        /// <summary>
        /// Update an existing backlog task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBacklogTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBacklogTask service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateBacklogTask">REST API Reference for UpdateBacklogTask Operation</seealso>
        public virtual Task<UpdateBacklogTaskResponse> UpdateBacklogTaskAsync(UpdateBacklogTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBacklogTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBacklogTaskResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBacklogTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGoal

        internal virtual UpdateGoalResponse UpdateGoal(UpdateGoalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGoalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGoalResponseUnmarshaller.Instance;

            return Invoke<UpdateGoalResponse>(request, options);
        }



        /// <summary>
        /// Update an existing goal
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGoal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGoal service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateGoal">REST API Reference for UpdateGoal Operation</seealso>
        public virtual Task<UpdateGoalResponse> UpdateGoalAsync(UpdateGoalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGoalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGoalResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGoalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateOperatorAppIdpConfig

        internal virtual UpdateOperatorAppIdpConfigResponse UpdateOperatorAppIdpConfig(UpdateOperatorAppIdpConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOperatorAppIdpConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOperatorAppIdpConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateOperatorAppIdpConfigResponse>(request, options);
        }



        /// <summary>
        /// Update the external Identity Provider configuration for the Operator App
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOperatorAppIdpConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOperatorAppIdpConfig service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateOperatorAppIdpConfig">REST API Reference for UpdateOperatorAppIdpConfig Operation</seealso>
        public virtual Task<UpdateOperatorAppIdpConfigResponse> UpdateOperatorAppIdpConfigAsync(UpdateOperatorAppIdpConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOperatorAppIdpConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOperatorAppIdpConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOperatorAppIdpConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePrivateConnectionCertificate

        internal virtual UpdatePrivateConnectionCertificateResponse UpdatePrivateConnectionCertificate(UpdatePrivateConnectionCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePrivateConnectionCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrivateConnectionCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdatePrivateConnectionCertificateResponse>(request, options);
        }



        /// <summary>
        /// Updates the certificate associated with a Private Connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrivateConnectionCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePrivateConnectionCertificate service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdatePrivateConnectionCertificate">REST API Reference for UpdatePrivateConnectionCertificate Operation</seealso>
        public virtual Task<UpdatePrivateConnectionCertificateResponse> UpdatePrivateConnectionCertificateAsync(UpdatePrivateConnectionCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePrivateConnectionCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrivateConnectionCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePrivateConnectionCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRecommendation

        internal virtual UpdateRecommendationResponse UpdateRecommendation(UpdateRecommendationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecommendationResponseUnmarshaller.Instance;

            return Invoke<UpdateRecommendationResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing recommendation with new content, status, or metadata
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRecommendation service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateRecommendation">REST API Reference for UpdateRecommendation Operation</seealso>
        public virtual Task<UpdateRecommendationResponse> UpdateRecommendationAsync(UpdateRecommendationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecommendationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRecommendationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ValidateAwsAssociations

        internal virtual ValidateAwsAssociationsResponse ValidateAwsAssociations(ValidateAwsAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateAwsAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateAwsAssociationsResponseUnmarshaller.Instance;

            return Invoke<ValidateAwsAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Validates an aws association and set status and returns a 204 No Content response
        /// on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateAwsAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateAwsAssociations service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ValidateAwsAssociations">REST API Reference for ValidateAwsAssociations Operation</seealso>
        public virtual Task<ValidateAwsAssociationsResponse> ValidateAwsAssociationsAsync(ValidateAwsAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateAwsAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateAwsAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateAwsAssociationsResponse>(request, options, cancellationToken);
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