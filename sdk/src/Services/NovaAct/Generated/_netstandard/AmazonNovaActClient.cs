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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.NovaAct.Model;
using Amazon.NovaAct.Model.Internal.MarshallTransformations;
using Amazon.NovaAct.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.NovaAct
{
    /// <summary>
    /// <para>Implementation for accessing NovaAct</para>
    ///
    /// The Nova Act service provides a REST API for managing AI-powered workflow automation.
    /// It enables users to create workflow definitions, execute workflow runs, manage sessions,
    /// and orchestrate acts (individual AI tasks) with tool integrations.
    /// </summary>
    public partial class AmazonNovaActClient : AmazonServiceClient, IAmazonNovaAct
    {
        private static IServiceMetadata serviceMetadata = new AmazonNovaActMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonNovaActClient with the credentials loaded from the application's
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
        public AmazonNovaActClient()
            : base(new AmazonNovaActConfig()) { }

        /// <summary>
        /// Constructs AmazonNovaActClient with the credentials loaded from the application's
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
        public AmazonNovaActClient(RegionEndpoint region)
            : base(new AmazonNovaActConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNovaActClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNovaActClient Configuration Object</param>
        public AmazonNovaActClient(AmazonNovaActConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNovaActClient(AWSCredentials credentials)
            : this(credentials, new AmazonNovaActConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNovaActClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNovaActConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Credentials and an
        /// AmazonNovaActClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNovaActClient Configuration Object</param>
        public AmazonNovaActClient(AWSCredentials credentials, AmazonNovaActConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNovaActClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNovaActConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNovaActClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNovaActConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNovaActClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNovaActClient Configuration Object</param>
        public AmazonNovaActClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNovaActConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNovaActClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNovaActConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNovaActClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNovaActConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNovaActClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNovaActClient Configuration Object</param>
        public AmazonNovaActClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNovaActConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private INovaActPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public INovaActPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new NovaActPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNovaActEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNovaActAuthSchemeHandler());
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


        #region  CreateAct

        internal virtual CreateActResponse CreateAct(CreateActRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateActRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActResponseUnmarshaller.Instance;

            return Invoke<CreateActResponse>(request, options);
        }



        /// <summary>
        /// Creates a new AI task (act) within a session that can interact with tools and perform
        /// specific actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAct service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateAct">REST API Reference for CreateAct Operation</seealso>
        public virtual Task<CreateActResponse> CreateActAsync(CreateActRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateActRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActResponseUnmarshaller.Instance;

            return InvokeAsync<CreateActResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSession

        internal virtual CreateSessionResponse CreateSession(CreateSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionResponseUnmarshaller.Instance;

            return Invoke<CreateSessionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new session context within a workflow run to manage conversation state and
        /// acts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSession service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateSession">REST API Reference for CreateSession Operation</seealso>
        public virtual Task<CreateSessionResponse> CreateSessionAsync(CreateSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWorkflowDefinition

        internal virtual CreateWorkflowDefinitionResponse CreateWorkflowDefinition(CreateWorkflowDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new workflow definition template that can be used to execute multiple workflow
        /// runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkflowDefinition service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowDefinition">REST API Reference for CreateWorkflowDefinition Operation</seealso>
        public virtual Task<CreateWorkflowDefinitionResponse> CreateWorkflowDefinitionAsync(CreateWorkflowDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkflowDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWorkflowRun

        internal virtual CreateWorkflowRunResponse CreateWorkflowRun(CreateWorkflowRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowRunResponse>(request, options);
        }



        /// <summary>
        /// Creates a new execution instance of a workflow definition with specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowRun">REST API Reference for CreateWorkflowRun Operation</seealso>
        public virtual Task<CreateWorkflowRunResponse> CreateWorkflowRunAsync(CreateWorkflowRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowRunResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkflowRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWorkflowDefinition

        internal virtual DeleteWorkflowDefinitionResponse DeleteWorkflowDefinition(DeleteWorkflowDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a workflow definition and all associated resources. This operation cannot
        /// be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkflowDefinition service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowDefinition">REST API Reference for DeleteWorkflowDefinition Operation</seealso>
        public virtual Task<DeleteWorkflowDefinitionResponse> DeleteWorkflowDefinitionAsync(DeleteWorkflowDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkflowDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWorkflowRun

        internal virtual DeleteWorkflowRunResponse DeleteWorkflowRun(DeleteWorkflowRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowRunResponse>(request, options);
        }



        /// <summary>
        /// Terminates and cleans up a workflow run, stopping all associated acts and sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowRun">REST API Reference for DeleteWorkflowRun Operation</seealso>
        public virtual Task<DeleteWorkflowRunResponse> DeleteWorkflowRunAsync(DeleteWorkflowRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowRunResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkflowRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkflowDefinition

        internal virtual GetWorkflowDefinitionResponse GetWorkflowDefinition(GetWorkflowDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details and configuration of a specific workflow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflowDefinition service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowDefinition">REST API Reference for GetWorkflowDefinition Operation</seealso>
        public virtual Task<GetWorkflowDefinitionResponse> GetWorkflowDefinitionAsync(GetWorkflowDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkflowRun

        internal virtual GetWorkflowRunResponse GetWorkflowRun(GetWorkflowRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowRunResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current state, configuration, and execution details of a workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        public virtual Task<GetWorkflowRunResponse> GetWorkflowRunAsync(GetWorkflowRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  InvokeActStep

        internal virtual InvokeActStepResponse InvokeActStep(InvokeActStepRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeActStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeActStepResponseUnmarshaller.Instance;

            return Invoke<InvokeActStepResponse>(request, options);
        }



        /// <summary>
        /// Executes the next step of an act, processing tool call results and returning new tool
        /// calls if needed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeActStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeActStep service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/InvokeActStep">REST API Reference for InvokeActStep Operation</seealso>
        public virtual Task<InvokeActStepResponse> InvokeActStepAsync(InvokeActStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeActStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeActStepResponseUnmarshaller.Instance;

            return InvokeAsync<InvokeActStepResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListActs

        internal virtual ListActsResponse ListActs(ListActsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActsResponseUnmarshaller.Instance;

            return Invoke<ListActsResponse>(request, options);
        }



        /// <summary>
        /// Lists all acts within a specific session with their current status and execution details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActs service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListActs">REST API Reference for ListActs Operation</seealso>
        public virtual Task<ListActsResponse> ListActsAsync(ListActsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActsResponseUnmarshaller.Instance;

            return InvokeAsync<ListActsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListModels

        internal virtual ListModelsResponse ListModels(ListModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return Invoke<ListModelsResponse>(request, options);
        }



        /// <summary>
        /// Lists all available AI models that can be used for workflow execution, including their
        /// status and compatibility information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModels service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSessions

        internal virtual ListSessionsResponse ListSessions(ListSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return Invoke<ListSessionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all sessions within a specific workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual Task<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSessionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkflowDefinitions

        internal virtual ListWorkflowDefinitionsResponse ListWorkflowDefinitions(ListWorkflowDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all workflow definitions in your account with optional filtering and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflowDefinitions service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowDefinitions">REST API Reference for ListWorkflowDefinitions Operation</seealso>
        public virtual Task<ListWorkflowDefinitionsResponse> ListWorkflowDefinitionsAsync(ListWorkflowDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkflowRuns

        internal virtual ListWorkflowRunsResponse ListWorkflowRuns(ListWorkflowRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowRunsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowRunsResponse>(request, options);
        }



        /// <summary>
        /// Lists all workflow runs for a specific workflow definition with optional filtering
        /// and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflowRuns service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowRuns">REST API Reference for ListWorkflowRuns Operation</seealso>
        public virtual Task<ListWorkflowRunsResponse> ListWorkflowRunsAsync(ListWorkflowRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowRunsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAct

        internal virtual UpdateActResponse UpdateAct(UpdateActRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateActRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateActResponseUnmarshaller.Instance;

            return Invoke<UpdateActResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing act's configuration, status, or error information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAct service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateAct">REST API Reference for UpdateAct Operation</seealso>
        public virtual Task<UpdateActResponse> UpdateActAsync(UpdateActRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateActRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateActResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateActResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWorkflowRun

        internal virtual UpdateWorkflowRunResponse UpdateWorkflowRun(UpdateWorkflowRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkflowRunResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration or state of an active workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateWorkflowRun">REST API Reference for UpdateWorkflowRun Operation</seealso>
        public virtual Task<UpdateWorkflowRunResponse> UpdateWorkflowRunAsync(UpdateWorkflowRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowRunResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkflowRunResponse>(request, options, cancellationToken);
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