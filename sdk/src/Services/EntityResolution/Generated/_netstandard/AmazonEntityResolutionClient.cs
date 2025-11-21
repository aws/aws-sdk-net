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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.EntityResolution.Model;
using Amazon.EntityResolution.Model.Internal.MarshallTransformations;
using Amazon.EntityResolution.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.EntityResolution
{
    /// <summary>
    /// <para>Implementation for accessing EntityResolution</para>
    ///
    /// Welcome to the <i>Entity Resolution API Reference</i>.
    /// 
    ///  
    /// <para>
    /// Entity Resolution is an Amazon Web Services service that provides pre-configured entity
    /// resolution capabilities that enable developers and analysts at advertising and marketing
    /// companies to build an accurate and complete view of their consumers.
    /// </para>
    ///  
    /// <para>
    ///  With Entity Resolution, you can match source records containing consumer identifiers,
    /// such as name, email address, and phone number. This is true even when these records
    /// have incomplete or conflicting identifiers. For example, Entity Resolution can effectively
    /// match a source record from a customer relationship management (CRM) system with a
    /// source record from a marketing system containing campaign information.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Entity Resolution concepts, procedures, and best practices, see
    /// the <a href="https://docs.aws.amazon.com/entityresolution/latest/userguide/what-is-service.html">Entity
    /// Resolution User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonEntityResolutionClient : AmazonServiceClient, IAmazonEntityResolution
    {
        private static IServiceMetadata serviceMetadata = new AmazonEntityResolutionMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with the credentials loaded from the application's
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
        public AmazonEntityResolutionClient()
            : base(new AmazonEntityResolutionConfig()) { }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with the credentials loaded from the application's
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
        public AmazonEntityResolutionClient(RegionEndpoint region)
            : base(new AmazonEntityResolutionConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEntityResolutionClient Configuration Object</param>
        public AmazonEntityResolutionClient(AmazonEntityResolutionConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEntityResolutionClient(AWSCredentials credentials)
            : this(credentials, new AmazonEntityResolutionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEntityResolutionClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEntityResolutionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Credentials and an
        /// AmazonEntityResolutionClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEntityResolutionClient Configuration Object</param>
        public AmazonEntityResolutionClient(AWSCredentials credentials, AmazonEntityResolutionConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEntityResolutionClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEntityResolutionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEntityResolutionClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEntityResolutionConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEntityResolutionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEntityResolutionClient Configuration Object</param>
        public AmazonEntityResolutionClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEntityResolutionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEntityResolutionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEntityResolutionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEntityResolutionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEntityResolutionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEntityResolutionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEntityResolutionClient Configuration Object</param>
        public AmazonEntityResolutionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEntityResolutionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IEntityResolutionPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IEntityResolutionPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new EntityResolutionPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEntityResolutionEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEntityResolutionAuthSchemeHandler());
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


        #region  AddPolicyStatement

        internal virtual AddPolicyStatementResponse AddPolicyStatement(AddPolicyStatementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddPolicyStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPolicyStatementResponseUnmarshaller.Instance;

            return Invoke<AddPolicyStatementResponse>(request, options);
        }



        /// <summary>
        /// Adds a policy statement object. To retrieve a list of existing policy statements,
        /// use the <c>GetPolicy</c> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPolicyStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddPolicyStatement service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/AddPolicyStatement">REST API Reference for AddPolicyStatement Operation</seealso>
        public virtual Task<AddPolicyStatementResponse> AddPolicyStatementAsync(AddPolicyStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddPolicyStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPolicyStatementResponseUnmarshaller.Instance;

            return InvokeAsync<AddPolicyStatementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteUniqueId

        internal virtual BatchDeleteUniqueIdResponse BatchDeleteUniqueId(BatchDeleteUniqueIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteUniqueIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteUniqueIdResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteUniqueIdResponse>(request, options);
        }



        /// <summary>
        /// Deletes multiple unique IDs in a matching workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteUniqueId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteUniqueId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/BatchDeleteUniqueId">REST API Reference for BatchDeleteUniqueId Operation</seealso>
        public virtual Task<BatchDeleteUniqueIdResponse> BatchDeleteUniqueIdAsync(BatchDeleteUniqueIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteUniqueIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteUniqueIdResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteUniqueIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIdMappingWorkflow

        internal virtual CreateIdMappingWorkflowResponse CreateIdMappingWorkflow(CreateIdMappingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdMappingWorkflowResponseUnmarshaller.Instance;

            return Invoke<CreateIdMappingWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Creates an <c>IdMappingWorkflow</c> object which stores the configuration of the data
        /// processing job to be run. Each <c>IdMappingWorkflow</c> must have a unique workflow
        /// name. To modify an existing workflow, use the UpdateIdMappingWorkflow API.
        /// 
        ///  <important> 
        /// <para>
        /// Incremental processing is not supported for ID mapping workflows. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdMappingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdMappingWorkflow">REST API Reference for CreateIdMappingWorkflow Operation</seealso>
        public virtual Task<CreateIdMappingWorkflowResponse> CreateIdMappingWorkflowAsync(CreateIdMappingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdMappingWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIdMappingWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIdNamespace

        internal virtual CreateIdNamespaceResponse CreateIdNamespace(CreateIdNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreateIdNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Creates an ID namespace object which will help customers provide metadata explaining
        /// their dataset and how to use it. Each ID namespace must have a unique name. To modify
        /// an existing ID namespace, use the UpdateIdNamespace API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdNamespace">REST API Reference for CreateIdNamespace Operation</seealso>
        public virtual Task<CreateIdNamespaceResponse> CreateIdNamespaceAsync(CreateIdNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIdNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMatchingWorkflow

        internal virtual CreateMatchingWorkflowResponse CreateMatchingWorkflow(CreateMatchingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchingWorkflowResponseUnmarshaller.Instance;

            return Invoke<CreateMatchingWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Creates a matching workflow that defines the configuration for a data processing job.
        /// The workflow name must be unique. To modify an existing workflow, use <c>UpdateMatchingWorkflow</c>.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// For workflows where <c>resolutionType</c> is <c>ML_MATCHING</c> or <c>PROVIDER</c>,
        /// incremental processing is not supported. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateMatchingWorkflow">REST API Reference for CreateMatchingWorkflow Operation</seealso>
        public virtual Task<CreateMatchingWorkflowResponse> CreateMatchingWorkflowAsync(CreateMatchingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchingWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMatchingWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSchemaMapping

        internal virtual CreateSchemaMappingResponse CreateSchemaMapping(CreateSchemaMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaMappingResponseUnmarshaller.Instance;

            return Invoke<CreateSchemaMappingResponse>(request, options);
        }



        /// <summary>
        /// Creates a schema mapping, which defines the schema of the input customer records table.
        /// The <c>SchemaMapping</c> also provides Entity Resolution with some metadata about
        /// the table, such as the attribute types of the columns and which columns to match on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchemaMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateSchemaMapping">REST API Reference for CreateSchemaMapping Operation</seealso>
        public virtual Task<CreateSchemaMappingResponse> CreateSchemaMappingAsync(CreateSchemaMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaMappingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSchemaMappingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIdMappingWorkflow

        internal virtual DeleteIdMappingWorkflowResponse DeleteIdMappingWorkflow(DeleteIdMappingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdMappingWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteIdMappingWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Deletes the <c>IdMappingWorkflow</c> with a given name. This operation will succeed
        /// even if a workflow with the given name does not exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdMappingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdMappingWorkflow">REST API Reference for DeleteIdMappingWorkflow Operation</seealso>
        public virtual Task<DeleteIdMappingWorkflowResponse> DeleteIdMappingWorkflowAsync(DeleteIdMappingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdMappingWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdMappingWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIdNamespace

        internal virtual DeleteIdNamespaceResponse DeleteIdNamespace(DeleteIdNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteIdNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes the <c>IdNamespace</c> with a given name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdNamespace">REST API Reference for DeleteIdNamespace Operation</seealso>
        public virtual Task<DeleteIdNamespaceResponse> DeleteIdNamespaceAsync(DeleteIdNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMatchingWorkflow

        internal virtual DeleteMatchingWorkflowResponse DeleteMatchingWorkflow(DeleteMatchingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchingWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteMatchingWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Deletes the <c>MatchingWorkflow</c> with a given name. This operation will succeed
        /// even if a workflow with the given name does not exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteMatchingWorkflow">REST API Reference for DeleteMatchingWorkflow Operation</seealso>
        public virtual Task<DeleteMatchingWorkflowResponse> DeleteMatchingWorkflowAsync(DeleteMatchingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchingWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMatchingWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePolicyStatement

        internal virtual DeletePolicyStatementResponse DeletePolicyStatement(DeletePolicyStatementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePolicyStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyStatementResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyStatementResponse>(request, options);
        }



        /// <summary>
        /// Deletes the policy statement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicyStatement service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeletePolicyStatement">REST API Reference for DeletePolicyStatement Operation</seealso>
        public virtual Task<DeletePolicyStatementResponse> DeletePolicyStatementAsync(DeletePolicyStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePolicyStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyStatementResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyStatementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSchemaMapping

        internal virtual DeleteSchemaMappingResponse DeleteSchemaMapping(DeleteSchemaMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaMappingResponse>(request, options);
        }



        /// <summary>
        /// Deletes the <c>SchemaMapping</c> with a given name. This operation will succeed even
        /// if a schema with the given name does not exist. This operation will fail if there
        /// is a <c>MatchingWorkflow</c> object that references the <c>SchemaMapping</c> in the
        /// workflow's <c>InputSourceConfig</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteSchemaMapping">REST API Reference for DeleteSchemaMapping Operation</seealso>
        public virtual Task<DeleteSchemaMappingResponse> DeleteSchemaMappingAsync(DeleteSchemaMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaMappingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSchemaMappingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GenerateMatchId

        internal virtual GenerateMatchIdResponse GenerateMatchId(GenerateMatchIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateMatchIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateMatchIdResponseUnmarshaller.Instance;

            return Invoke<GenerateMatchIdResponse>(request, options);
        }



        /// <summary>
        /// Generates or retrieves Match IDs for records using a rule-based matching workflow.
        /// When you call this operation, it processes your records against the workflow's matching
        /// rules to identify potential matches. For existing records, it retrieves their Match
        /// IDs and associated rules. For records without matches, it generates new Match IDs.
        /// The operation saves results to Amazon S3. 
        /// 
        ///  
        /// <para>
        /// The processing type (<c>processingType</c>) you choose affects both the accuracy and
        /// response time of the operation. Additional charges apply for each API call, whether
        /// made through the Entity Resolution console or directly via the API. The rule-based
        /// matching workflow must exist and be active before calling this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateMatchId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateMatchId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GenerateMatchId">REST API Reference for GenerateMatchId Operation</seealso>
        public virtual Task<GenerateMatchIdResponse> GenerateMatchIdAsync(GenerateMatchIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateMatchIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateMatchIdResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateMatchIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIdMappingJob

        internal virtual GetIdMappingJobResponse GetIdMappingJob(GetIdMappingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdMappingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdMappingJobResponseUnmarshaller.Instance;

            return Invoke<GetIdMappingJobResponse>(request, options);
        }



        /// <summary>
        /// Returns the status, metrics, and errors (if there are any) that are associated with
        /// a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdMappingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingJob">REST API Reference for GetIdMappingJob Operation</seealso>
        public virtual Task<GetIdMappingJobResponse> GetIdMappingJobAsync(GetIdMappingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdMappingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdMappingJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdMappingJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIdMappingWorkflow

        internal virtual GetIdMappingWorkflowResponse GetIdMappingWorkflow(GetIdMappingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdMappingWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetIdMappingWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Returns the <c>IdMappingWorkflow</c> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingWorkflow">REST API Reference for GetIdMappingWorkflow Operation</seealso>
        public virtual Task<GetIdMappingWorkflowResponse> GetIdMappingWorkflowAsync(GetIdMappingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdMappingWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdMappingWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIdNamespace

        internal virtual GetIdNamespaceResponse GetIdNamespace(GetIdNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdNamespaceResponseUnmarshaller.Instance;

            return Invoke<GetIdNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Returns the <c>IdNamespace</c> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdNamespace">REST API Reference for GetIdNamespace Operation</seealso>
        public virtual Task<GetIdNamespaceResponse> GetIdNamespaceAsync(GetIdNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMatchId

        internal virtual GetMatchIdResponse GetMatchId(GetMatchIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMatchIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchIdResponseUnmarshaller.Instance;

            return Invoke<GetMatchIdResponse>(request, options);
        }



        /// <summary>
        /// Returns the corresponding Match ID of a customer record if the record has been processed
        /// in a rule-based matching workflow.
        /// 
        ///  
        /// <para>
        /// You can call this API as a dry run of an incremental load on the rule-based matching
        /// workflow.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMatchId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchId">REST API Reference for GetMatchId Operation</seealso>
        public virtual Task<GetMatchIdResponse> GetMatchIdAsync(GetMatchIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMatchIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchIdResponseUnmarshaller.Instance;

            return InvokeAsync<GetMatchIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMatchingJob

        internal virtual GetMatchingJobResponse GetMatchingJob(GetMatchingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMatchingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchingJobResponseUnmarshaller.Instance;

            return Invoke<GetMatchingJobResponse>(request, options);
        }



        /// <summary>
        /// Returns the status, metrics, and errors (if there are any) that are associated with
        /// a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMatchingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingJob">REST API Reference for GetMatchingJob Operation</seealso>
        public virtual Task<GetMatchingJobResponse> GetMatchingJobAsync(GetMatchingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMatchingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchingJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetMatchingJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMatchingWorkflow

        internal virtual GetMatchingWorkflowResponse GetMatchingWorkflow(GetMatchingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchingWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetMatchingWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Returns the <c>MatchingWorkflow</c> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingWorkflow">REST API Reference for GetMatchingWorkflow Operation</seealso>
        public virtual Task<GetMatchingWorkflowResponse> GetMatchingWorkflowAsync(GetMatchingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchingWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<GetMatchingWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPolicy

        internal virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns the resource-based policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetProviderService

        internal virtual GetProviderServiceResponse GetProviderService(GetProviderServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProviderServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProviderServiceResponseUnmarshaller.Instance;

            return Invoke<GetProviderServiceResponse>(request, options);
        }



        /// <summary>
        /// Returns the <c>ProviderService</c> of a given name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProviderService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProviderService service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetProviderService">REST API Reference for GetProviderService Operation</seealso>
        public virtual Task<GetProviderServiceResponse> GetProviderServiceAsync(GetProviderServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProviderServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProviderServiceResponseUnmarshaller.Instance;

            return InvokeAsync<GetProviderServiceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSchemaMapping

        internal virtual GetSchemaMappingResponse GetSchemaMapping(GetSchemaMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaMappingResponseUnmarshaller.Instance;

            return Invoke<GetSchemaMappingResponse>(request, options);
        }



        /// <summary>
        /// Returns the SchemaMapping of a given name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetSchemaMapping">REST API Reference for GetSchemaMapping Operation</seealso>
        public virtual Task<GetSchemaMappingResponse> GetSchemaMappingAsync(GetSchemaMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaMappingResponseUnmarshaller.Instance;

            return InvokeAsync<GetSchemaMappingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIdMappingJobs

        internal virtual ListIdMappingJobsResponse ListIdMappingJobs(ListIdMappingJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdMappingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdMappingJobsResponseUnmarshaller.Instance;

            return Invoke<ListIdMappingJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists all ID mapping jobs for a given workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdMappingJobs service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingJobs">REST API Reference for ListIdMappingJobs Operation</seealso>
        public virtual Task<ListIdMappingJobsResponse> ListIdMappingJobsAsync(ListIdMappingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdMappingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdMappingJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdMappingJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIdMappingWorkflows

        internal virtual ListIdMappingWorkflowsResponse ListIdMappingWorkflows(ListIdMappingWorkflowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdMappingWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdMappingWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListIdMappingWorkflowsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the <c>IdMappingWorkflows</c> that have been created for an
        /// Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdMappingWorkflows service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingWorkflows">REST API Reference for ListIdMappingWorkflows Operation</seealso>
        public virtual Task<ListIdMappingWorkflowsResponse> ListIdMappingWorkflowsAsync(ListIdMappingWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdMappingWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdMappingWorkflowsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdMappingWorkflowsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIdNamespaces

        internal virtual ListIdNamespacesResponse ListIdNamespaces(ListIdNamespacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListIdNamespacesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all ID namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdNamespaces service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdNamespaces">REST API Reference for ListIdNamespaces Operation</seealso>
        public virtual Task<ListIdNamespacesResponse> ListIdNamespacesAsync(ListIdNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdNamespacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdNamespacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMatchingJobs

        internal virtual ListMatchingJobsResponse ListMatchingJobs(ListMatchingJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMatchingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMatchingJobsResponseUnmarshaller.Instance;

            return Invoke<ListMatchingJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists all jobs for a given workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMatchingJobs service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingJobs">REST API Reference for ListMatchingJobs Operation</seealso>
        public virtual Task<ListMatchingJobsResponse> ListMatchingJobsAsync(ListMatchingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMatchingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMatchingJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMatchingJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMatchingWorkflows

        internal virtual ListMatchingWorkflowsResponse ListMatchingWorkflows(ListMatchingWorkflowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMatchingWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMatchingWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListMatchingWorkflowsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the <c>MatchingWorkflows</c> that have been created for an Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMatchingWorkflows service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingWorkflows">REST API Reference for ListMatchingWorkflows Operation</seealso>
        public virtual Task<ListMatchingWorkflowsResponse> ListMatchingWorkflowsAsync(ListMatchingWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMatchingWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMatchingWorkflowsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMatchingWorkflowsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProviderServices

        internal virtual ListProviderServicesResponse ListProviderServices(ListProviderServicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProviderServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProviderServicesResponseUnmarshaller.Instance;

            return Invoke<ListProviderServicesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the <c>ProviderServices</c> that are available in this Amazon
        /// Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProviderServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProviderServices service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListProviderServices">REST API Reference for ListProviderServices Operation</seealso>
        public virtual Task<ListProviderServicesResponse> ListProviderServicesAsync(ListProviderServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProviderServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProviderServicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProviderServicesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSchemaMappings

        internal virtual ListSchemaMappingsResponse ListSchemaMappings(ListSchemaMappingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemaMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaMappingsResponseUnmarshaller.Instance;

            return Invoke<ListSchemaMappingsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the <c>SchemaMappings</c> that have been created for an Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemaMappings service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListSchemaMappings">REST API Reference for ListSchemaMappings Operation</seealso>
        public virtual Task<ListSchemaMappingsResponse> ListSchemaMappingsAsync(ListSchemaMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemaMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaMappingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSchemaMappingsResponse>(request, options, cancellationToken);
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
        /// Displays the tags associated with an Entity Resolution resource. In Entity Resolution,
        /// <c>SchemaMapping</c>, and <c>MatchingWorkflow</c> can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutPolicy

        internal virtual PutPolicyResponse PutPolicy(PutPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPolicyResponseUnmarshaller.Instance;

            return Invoke<PutPolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates the resource-based policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPolicy service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        public virtual Task<PutPolicyResponse> PutPolicyAsync(PutPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartIdMappingJob

        internal virtual StartIdMappingJobResponse StartIdMappingJob(StartIdMappingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartIdMappingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIdMappingJobResponseUnmarshaller.Instance;

            return Invoke<StartIdMappingJobResponse>(request, options);
        }



        /// <summary>
        /// Starts the <c>IdMappingJob</c> of a workflow. The workflow must have previously been
        /// created using the <c>CreateIdMappingWorkflow</c> endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIdMappingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartIdMappingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartIdMappingJob">REST API Reference for StartIdMappingJob Operation</seealso>
        public virtual Task<StartIdMappingJobResponse> StartIdMappingJobAsync(StartIdMappingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartIdMappingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIdMappingJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartIdMappingJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartMatchingJob

        internal virtual StartMatchingJobResponse StartMatchingJob(StartMatchingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMatchingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchingJobResponseUnmarshaller.Instance;

            return Invoke<StartMatchingJobResponse>(request, options);
        }



        /// <summary>
        /// Starts the <c>MatchingJob</c> of a workflow. The workflow must have previously been
        /// created using the <c>CreateMatchingWorkflow</c> endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMatchingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMatchingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartMatchingJob">REST API Reference for StartMatchingJob Operation</seealso>
        public virtual Task<StartMatchingJobResponse> StartMatchingJobAsync(StartMatchingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMatchingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchingJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartMatchingJobResponse>(request, options, cancellationToken);
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
        /// Assigns one or more tags (key-value pairs) to the specified Entity Resolution resource.
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values. In Entity Resolution, <c>SchemaMapping</c> and <c>MatchingWorkflow</c>
        /// can be tagged. Tags don't have any semantic meaning to Amazon Web Services and are
        /// interpreted strictly as strings of characters. You can use the <c>TagResource</c>
        /// action with a resource that already has tags. If you specify a new tag key, this tag
        /// is appended to the list of tags associated with the resource. If you specify a tag
        /// key that is already associated with the resource, the new tag value that you specify
        /// replaces the previous value for that tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from the specified Entity Resolution resource. In Entity
        /// Resolution, <c>SchemaMapping</c>, and <c>MatchingWorkflow</c> can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateIdMappingWorkflow

        internal virtual UpdateIdMappingWorkflowResponse UpdateIdMappingWorkflow(UpdateIdMappingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdMappingWorkflowResponseUnmarshaller.Instance;

            return Invoke<UpdateIdMappingWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing <c>IdMappingWorkflow</c>. This method is identical to CreateIdMappingWorkflow,
        /// except it uses an HTTP <c>PUT</c> request instead of a <c>POST</c> request, and the
        /// <c>IdMappingWorkflow</c> must already exist for the method to succeed.
        /// 
        ///  <important> 
        /// <para>
        /// Incremental processing is not supported for ID mapping workflows. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdMappingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdMappingWorkflow">REST API Reference for UpdateIdMappingWorkflow Operation</seealso>
        public virtual Task<UpdateIdMappingWorkflowResponse> UpdateIdMappingWorkflowAsync(UpdateIdMappingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdMappingWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIdMappingWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateIdNamespace

        internal virtual UpdateIdNamespaceResponse UpdateIdNamespace(UpdateIdNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdNamespaceResponseUnmarshaller.Instance;

            return Invoke<UpdateIdNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing ID namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdNamespace">REST API Reference for UpdateIdNamespace Operation</seealso>
        public virtual Task<UpdateIdNamespaceResponse> UpdateIdNamespaceAsync(UpdateIdNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIdNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateMatchingWorkflow

        internal virtual UpdateMatchingWorkflowResponse UpdateMatchingWorkflow(UpdateMatchingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMatchingWorkflowResponseUnmarshaller.Instance;

            return Invoke<UpdateMatchingWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing matching workflow. The workflow must already exist for this operation
        /// to succeed.
        /// 
        ///  <important> 
        /// <para>
        /// For workflows where <c>resolutionType</c> is <c>ML_MATCHING</c> or <c>PROVIDER</c>,
        /// incremental processing is not supported. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateMatchingWorkflow">REST API Reference for UpdateMatchingWorkflow Operation</seealso>
        public virtual Task<UpdateMatchingWorkflowResponse> UpdateMatchingWorkflowAsync(UpdateMatchingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMatchingWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMatchingWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSchemaMapping

        internal virtual UpdateSchemaMappingResponse UpdateSchemaMapping(UpdateSchemaMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateSchemaMappingResponse>(request, options);
        }



        /// <summary>
        /// Updates a schema mapping.
        /// 
        ///  <note> 
        /// <para>
        /// A schema is immutable if it is being used by a workflow. Therefore, you can't update
        /// a schema mapping if it's associated with a workflow. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchemaMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateSchemaMapping">REST API Reference for UpdateSchemaMapping Operation</seealso>
        public virtual Task<UpdateSchemaMappingResponse> UpdateSchemaMappingAsync(UpdateSchemaMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaMappingResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSchemaMappingResponse>(request, options, cancellationToken);
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