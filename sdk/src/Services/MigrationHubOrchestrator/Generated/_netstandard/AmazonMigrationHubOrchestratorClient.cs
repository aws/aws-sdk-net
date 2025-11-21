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
 * Do not modify this file. This file is generated from the migrationhuborchestrator-2021-08-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MigrationHubOrchestrator.Model;
using Amazon.MigrationHubOrchestrator.Model.Internal.MarshallTransformations;
using Amazon.MigrationHubOrchestrator.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.MigrationHubOrchestrator
{
    /// <summary>
    /// <para>Implementation for accessing MigrationHubOrchestrator</para>
    ///
    /// This API reference provides descriptions, syntax, and other details about each of
    /// the actions and data types for AWS Migration Hub Orchestrator. The topic for each
    /// action shows the API request parameters and responses. Alternatively, you can use
    /// one of the AWS SDKs to access an API that is tailored to the programming language
    /// or platform that you're using.
    /// </summary>
    public partial class AmazonMigrationHubOrchestratorClient : AmazonServiceClient, IAmazonMigrationHubOrchestrator
    {
        private static IServiceMetadata serviceMetadata = new AmazonMigrationHubOrchestratorMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMigrationHubOrchestratorClient with the credentials loaded from the application's
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
        public AmazonMigrationHubOrchestratorClient()
            : base(new AmazonMigrationHubOrchestratorConfig()) { }

        /// <summary>
        /// Constructs AmazonMigrationHubOrchestratorClient with the credentials loaded from the application's
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
        public AmazonMigrationHubOrchestratorClient(RegionEndpoint region)
            : base(new AmazonMigrationHubOrchestratorConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMigrationHubOrchestratorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMigrationHubOrchestratorClient Configuration Object</param>
        public AmazonMigrationHubOrchestratorClient(AmazonMigrationHubOrchestratorConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonMigrationHubOrchestratorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMigrationHubOrchestratorClient(AWSCredentials credentials)
            : this(credentials, new AmazonMigrationHubOrchestratorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubOrchestratorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubOrchestratorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMigrationHubOrchestratorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubOrchestratorClient with AWS Credentials and an
        /// AmazonMigrationHubOrchestratorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMigrationHubOrchestratorClient Configuration Object</param>
        public AmazonMigrationHubOrchestratorClient(AWSCredentials credentials, AmazonMigrationHubOrchestratorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubOrchestratorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMigrationHubOrchestratorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMigrationHubOrchestratorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubOrchestratorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubOrchestratorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMigrationHubOrchestratorConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubOrchestratorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMigrationHubOrchestratorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMigrationHubOrchestratorClient Configuration Object</param>
        public AmazonMigrationHubOrchestratorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMigrationHubOrchestratorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubOrchestratorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMigrationHubOrchestratorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMigrationHubOrchestratorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubOrchestratorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubOrchestratorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMigrationHubOrchestratorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubOrchestratorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMigrationHubOrchestratorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMigrationHubOrchestratorClient Configuration Object</param>
        public AmazonMigrationHubOrchestratorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMigrationHubOrchestratorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMigrationHubOrchestratorPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMigrationHubOrchestratorPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MigrationHubOrchestratorPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMigrationHubOrchestratorEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMigrationHubOrchestratorAuthSchemeHandler());
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


        #region  CreateTemplate

        internal virtual CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a migration workflow template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ConflictException">
        /// This exception is thrown when an attempt to update or delete a resource would cause
        /// an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWorkflow

        internal virtual CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Create a workflow to orchestrate your migrations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        public virtual Task<CreateWorkflowResponse> CreateWorkflowAsync(CreateWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWorkflowStep

        internal virtual CreateWorkflowStepResponse CreateWorkflowStep(CreateWorkflowStepRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowStepResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowStepResponse>(request, options);
        }



        /// <summary>
        /// Create a step in the migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflowStep">REST API Reference for CreateWorkflowStep Operation</seealso>
        public virtual Task<CreateWorkflowStepResponse> CreateWorkflowStepAsync(CreateWorkflowStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowStepResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkflowStepResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWorkflowStepGroup

        internal virtual CreateWorkflowStepGroupResponse CreateWorkflowStepGroup(CreateWorkflowStepGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowStepGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowStepGroupResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowStepGroupResponse>(request, options);
        }



        /// <summary>
        /// Create a step group in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowStepGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkflowStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflowStepGroup">REST API Reference for CreateWorkflowStepGroup Operation</seealso>
        public virtual Task<CreateWorkflowStepGroupResponse> CreateWorkflowStepGroupAsync(CreateWorkflowStepGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowStepGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowStepGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkflowStepGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTemplate

        internal virtual DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes a migration workflow template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWorkflow

        internal virtual DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Delete a migration workflow. You must pause a running workflow in Migration Hub Orchestrator
        /// console to delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        public virtual Task<DeleteWorkflowResponse> DeleteWorkflowAsync(DeleteWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWorkflowStep

        internal virtual DeleteWorkflowStepResponse DeleteWorkflowStep(DeleteWorkflowStepRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowStepResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowStepResponse>(request, options);
        }



        /// <summary>
        /// Delete a step in a migration workflow. Pause the workflow to delete a running step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflowStep">REST API Reference for DeleteWorkflowStep Operation</seealso>
        public virtual Task<DeleteWorkflowStepResponse> DeleteWorkflowStepAsync(DeleteWorkflowStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowStepResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkflowStepResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWorkflowStepGroup

        internal virtual DeleteWorkflowStepGroupResponse DeleteWorkflowStepGroup(DeleteWorkflowStepGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowStepGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowStepGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowStepGroupResponse>(request, options);
        }



        /// <summary>
        /// Delete a step group in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowStepGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkflowStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflowStepGroup">REST API Reference for DeleteWorkflowStepGroup Operation</seealso>
        public virtual Task<DeleteWorkflowStepGroupResponse> DeleteWorkflowStepGroupAsync(DeleteWorkflowStepGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowStepGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowStepGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkflowStepGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTemplate

        internal virtual GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetTemplateResponse>(request, options);
        }



        /// <summary>
        /// Get the template you want to use for creating a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTemplateStep

        internal virtual GetTemplateStepResponse GetTemplateStep(GetTemplateStepRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateStepResponseUnmarshaller.Instance;

            return Invoke<GetTemplateStepResponse>(request, options);
        }



        /// <summary>
        /// Get a specific step in a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplateStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplateStep">REST API Reference for GetTemplateStep Operation</seealso>
        public virtual Task<GetTemplateStepResponse> GetTemplateStepAsync(GetTemplateStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateStepResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateStepResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTemplateStepGroup

        internal virtual GetTemplateStepGroupResponse GetTemplateStepGroup(GetTemplateStepGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateStepGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateStepGroupResponseUnmarshaller.Instance;

            return Invoke<GetTemplateStepGroupResponse>(request, options);
        }



        /// <summary>
        /// Get a step group in a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateStepGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplateStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplateStepGroup">REST API Reference for GetTemplateStepGroup Operation</seealso>
        public virtual Task<GetTemplateStepGroupResponse> GetTemplateStepGroupAsync(GetTemplateStepGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateStepGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateStepGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateStepGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkflow

        internal virtual GetWorkflowResponse GetWorkflow(GetWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Get migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        public virtual Task<GetWorkflowResponse> GetWorkflowAsync(GetWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkflowStep

        internal virtual GetWorkflowStepResponse GetWorkflowStep(GetWorkflowStepRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowStepResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowStepResponse>(request, options);
        }



        /// <summary>
        /// Get a step in the migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflowStep">REST API Reference for GetWorkflowStep Operation</seealso>
        public virtual Task<GetWorkflowStepResponse> GetWorkflowStepAsync(GetWorkflowStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowStepResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowStepResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkflowStepGroup

        internal virtual GetWorkflowStepGroupResponse GetWorkflowStepGroup(GetWorkflowStepGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowStepGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowStepGroupResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowStepGroupResponse>(request, options);
        }



        /// <summary>
        /// Get the step group of a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowStepGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflowStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflowStepGroup">REST API Reference for GetWorkflowStepGroup Operation</seealso>
        public virtual Task<GetWorkflowStepGroupResponse> GetWorkflowStepGroupAsync(GetWorkflowStepGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowStepGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowStepGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowStepGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPlugins

        internal virtual ListPluginsResponse ListPlugins(ListPluginsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPluginsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPluginsResponseUnmarshaller.Instance;

            return Invoke<ListPluginsResponse>(request, options);
        }



        /// <summary>
        /// List AWS Migration Hub Orchestrator plugins.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlugins service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlugins service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListPlugins">REST API Reference for ListPlugins Operation</seealso>
        public virtual Task<ListPluginsResponse> ListPluginsAsync(ListPluginsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPluginsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPluginsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPluginsResponse>(request, options, cancellationToken);
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
        /// List the tags added to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTemplates

        internal virtual ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListTemplatesResponse>(request, options);
        }



        /// <summary>
        /// List the templates available in Migration Hub Orchestrator to create a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTemplateStepGroups

        internal virtual ListTemplateStepGroupsResponse ListTemplateStepGroups(ListTemplateStepGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplateStepGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateStepGroupsResponseUnmarshaller.Instance;

            return Invoke<ListTemplateStepGroupsResponse>(request, options);
        }



        /// <summary>
        /// List the step groups in a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateStepGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplateStepGroups service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplateStepGroups">REST API Reference for ListTemplateStepGroups Operation</seealso>
        public virtual Task<ListTemplateStepGroupsResponse> ListTemplateStepGroupsAsync(ListTemplateStepGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplateStepGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateStepGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTemplateStepGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTemplateSteps

        internal virtual ListTemplateStepsResponse ListTemplateSteps(ListTemplateStepsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplateStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateStepsResponseUnmarshaller.Instance;

            return Invoke<ListTemplateStepsResponse>(request, options);
        }



        /// <summary>
        /// List the steps in a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplateSteps service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplateSteps">REST API Reference for ListTemplateSteps Operation</seealso>
        public virtual Task<ListTemplateStepsResponse> ListTemplateStepsAsync(ListTemplateStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplateStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateStepsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTemplateStepsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkflows

        internal virtual ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowsResponse>(request, options);
        }



        /// <summary>
        /// List the migration workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual Task<ListWorkflowsResponse> ListWorkflowsAsync(ListWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkflowStepGroups

        internal virtual ListWorkflowStepGroupsResponse ListWorkflowStepGroups(ListWorkflowStepGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowStepGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowStepGroupsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowStepGroupsResponse>(request, options);
        }



        /// <summary>
        /// List the step groups in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowStepGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflowStepGroups service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflowStepGroups">REST API Reference for ListWorkflowStepGroups Operation</seealso>
        public virtual Task<ListWorkflowStepGroupsResponse> ListWorkflowStepGroupsAsync(ListWorkflowStepGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowStepGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowStepGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowStepGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkflowSteps

        internal virtual ListWorkflowStepsResponse ListWorkflowSteps(ListWorkflowStepsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowStepsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowStepsResponse>(request, options);
        }



        /// <summary>
        /// List the steps in a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflowSteps service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflowSteps">REST API Reference for ListWorkflowSteps Operation</seealso>
        public virtual Task<ListWorkflowStepsResponse> ListWorkflowStepsAsync(ListWorkflowStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowStepsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowStepsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RetryWorkflowStep

        internal virtual RetryWorkflowStepResponse RetryWorkflowStep(RetryWorkflowStepRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetryWorkflowStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryWorkflowStepResponseUnmarshaller.Instance;

            return Invoke<RetryWorkflowStepResponse>(request, options);
        }



        /// <summary>
        /// Retry a failed step in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryWorkflowStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetryWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/RetryWorkflowStep">REST API Reference for RetryWorkflowStep Operation</seealso>
        public virtual Task<RetryWorkflowStepResponse> RetryWorkflowStepAsync(RetryWorkflowStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetryWorkflowStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryWorkflowStepResponseUnmarshaller.Instance;

            return InvokeAsync<RetryWorkflowStepResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartWorkflow

        internal virtual StartWorkflowResponse StartWorkflow(StartWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkflowResponseUnmarshaller.Instance;

            return Invoke<StartWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Start a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/StartWorkflow">REST API Reference for StartWorkflow Operation</seealso>
        public virtual Task<StartWorkflowResponse> StartWorkflowAsync(StartWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<StartWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopWorkflow

        internal virtual StopWorkflowResponse StopWorkflow(StopWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopWorkflowResponseUnmarshaller.Instance;

            return Invoke<StopWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Stop an ongoing migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/StopWorkflow">REST API Reference for StopWorkflow Operation</seealso>
        public virtual Task<StopWorkflowResponse> StopWorkflowAsync(StopWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<StopWorkflowResponse>(request, options, cancellationToken);
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
        /// Tag a resource by specifying its Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Deletes the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTemplate

        internal virtual UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates a migration workflow template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWorkflow

        internal virtual UpdateWorkflowResponse UpdateWorkflow(UpdateWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Update a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        public virtual Task<UpdateWorkflowResponse> UpdateWorkflowAsync(UpdateWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWorkflowStep

        internal virtual UpdateWorkflowStepResponse UpdateWorkflowStep(UpdateWorkflowStepRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowStepResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkflowStepResponse>(request, options);
        }



        /// <summary>
        /// Update a step in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflowStep">REST API Reference for UpdateWorkflowStep Operation</seealso>
        public virtual Task<UpdateWorkflowStepResponse> UpdateWorkflowStepAsync(UpdateWorkflowStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowStepResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkflowStepResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWorkflowStepGroup

        internal virtual UpdateWorkflowStepGroupResponse UpdateWorkflowStepGroup(UpdateWorkflowStepGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowStepGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowStepGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkflowStepGroupResponse>(request, options);
        }



        /// <summary>
        /// Update the step group in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowStepGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkflowStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflowStepGroup">REST API Reference for UpdateWorkflowStepGroup Operation</seealso>
        public virtual Task<UpdateWorkflowStepGroupResponse> UpdateWorkflowStepGroupAsync(UpdateWorkflowStepGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowStepGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowStepGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkflowStepGroupResponse>(request, options, cancellationToken);
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