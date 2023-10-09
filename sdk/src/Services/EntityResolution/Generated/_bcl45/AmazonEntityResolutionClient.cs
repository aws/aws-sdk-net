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

namespace Amazon.EntityResolution
{
    /// <summary>
    /// Implementation for accessing EntityResolution
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEntityResolutionConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEntityResolutionConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

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

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEntityResolutionEndpointResolver());
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


        #region  CreateMatchingWorkflow


        /// <summary>
        /// Creates a <code>MatchingWorkflow</code> object which stores the configuration of the
        /// data processing job to be run. It is important to note that there should not be a
        /// pre-existing <code>MatchingWorkflow</code> with the same name. To modify an existing
        /// workflow, utilize the <code>UpdateMatchingWorkflow</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the CreateMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc. <code>HTTP Status Code: 400</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// <code>HTTP Status Code: 402</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateMatchingWorkflow">REST API Reference for CreateMatchingWorkflow Operation</seealso>
        public virtual CreateMatchingWorkflowResponse CreateMatchingWorkflow(CreateMatchingWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchingWorkflowResponseUnmarshaller.Instance;

            return Invoke<CreateMatchingWorkflowResponse>(request, options);
        }


        /// <summary>
        /// Creates a <code>MatchingWorkflow</code> object which stores the configuration of the
        /// data processing job to be run. It is important to note that there should not be a
        /// pre-existing <code>MatchingWorkflow</code> with the same name. To modify an existing
        /// workflow, utilize the <code>UpdateMatchingWorkflow</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc. <code>HTTP Status Code: 400</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// <code>HTTP Status Code: 402</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateMatchingWorkflow">REST API Reference for CreateMatchingWorkflow Operation</seealso>
        public virtual Task<CreateMatchingWorkflowResponse> CreateMatchingWorkflowAsync(CreateMatchingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchingWorkflowResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMatchingWorkflowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSchemaMapping


        /// <summary>
        /// Creates a schema mapping, which defines the schema of the input customer records table.
        /// The <code>SchemaMapping</code> also provides Entity Resolution with some metadata
        /// about the table, such as the attribute types of the columns and which columns to match
        /// on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchemaMapping service method.</param>
        /// 
        /// <returns>The response from the CreateSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc. <code>HTTP Status Code: 400</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// <code>HTTP Status Code: 402</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateSchemaMapping">REST API Reference for CreateSchemaMapping Operation</seealso>
        public virtual CreateSchemaMappingResponse CreateSchemaMapping(CreateSchemaMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaMappingResponseUnmarshaller.Instance;

            return Invoke<CreateSchemaMappingResponse>(request, options);
        }


        /// <summary>
        /// Creates a schema mapping, which defines the schema of the input customer records table.
        /// The <code>SchemaMapping</code> also provides Entity Resolution with some metadata
        /// about the table, such as the attribute types of the columns and which columns to match
        /// on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchemaMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc. <code>HTTP Status Code: 400</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// <code>HTTP Status Code: 402</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateSchemaMapping">REST API Reference for CreateSchemaMapping Operation</seealso>
        public virtual Task<CreateSchemaMappingResponse> CreateSchemaMappingAsync(CreateSchemaMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaMappingResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSchemaMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMatchingWorkflow


        /// <summary>
        /// Deletes the <code>MatchingWorkflow</code> with a given name. This operation will succeed
        /// even if a workflow with the given name does not exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteMatchingWorkflow">REST API Reference for DeleteMatchingWorkflow Operation</seealso>
        public virtual DeleteMatchingWorkflowResponse DeleteMatchingWorkflow(DeleteMatchingWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchingWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteMatchingWorkflowResponse>(request, options);
        }


        /// <summary>
        /// Deletes the <code>MatchingWorkflow</code> with a given name. This operation will succeed
        /// even if a workflow with the given name does not exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteMatchingWorkflow">REST API Reference for DeleteMatchingWorkflow Operation</seealso>
        public virtual Task<DeleteMatchingWorkflowResponse> DeleteMatchingWorkflowAsync(DeleteMatchingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchingWorkflowResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMatchingWorkflowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSchemaMapping


        /// <summary>
        /// Deletes the <code>SchemaMapping</code> with a given name. This operation will succeed
        /// even if a schema with the given name does not exist. This operation will fail if there
        /// is a <code>DataIntegrationWorkflow</code> object that references the <code>SchemaMapping</code>
        /// in the workflow's <code>InputSourceConfig</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc. <code>HTTP Status Code: 400</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteSchemaMapping">REST API Reference for DeleteSchemaMapping Operation</seealso>
        public virtual DeleteSchemaMappingResponse DeleteSchemaMapping(DeleteSchemaMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaMappingResponse>(request, options);
        }


        /// <summary>
        /// Deletes the <code>SchemaMapping</code> with a given name. This operation will succeed
        /// even if a schema with the given name does not exist. This operation will fail if there
        /// is a <code>DataIntegrationWorkflow</code> object that references the <code>SchemaMapping</code>
        /// in the workflow's <code>InputSourceConfig</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc. <code>HTTP Status Code: 400</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteSchemaMapping">REST API Reference for DeleteSchemaMapping Operation</seealso>
        public virtual Task<DeleteSchemaMappingResponse> DeleteSchemaMappingAsync(DeleteSchemaMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaMappingResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSchemaMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMatchId


        /// <summary>
        /// Returns the corresponding Match ID of a customer record if the record has been processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchId service method.</param>
        /// 
        /// <returns>The response from the GetMatchId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchId">REST API Reference for GetMatchId Operation</seealso>
        public virtual GetMatchIdResponse GetMatchId(GetMatchIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMatchIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchIdResponseUnmarshaller.Instance;

            return Invoke<GetMatchIdResponse>(request, options);
        }


        /// <summary>
        /// Returns the corresponding Match ID of a customer record if the record has been processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMatchId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchId">REST API Reference for GetMatchId Operation</seealso>
        public virtual Task<GetMatchIdResponse> GetMatchIdAsync(GetMatchIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMatchIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchIdResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMatchIdResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMatchingJob


        /// <summary>
        /// Gets the status, metrics, and errors (if there are any) that are associated with a
        /// job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingJob service method.</param>
        /// 
        /// <returns>The response from the GetMatchingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingJob">REST API Reference for GetMatchingJob Operation</seealso>
        public virtual GetMatchingJobResponse GetMatchingJob(GetMatchingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMatchingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchingJobResponseUnmarshaller.Instance;

            return Invoke<GetMatchingJobResponse>(request, options);
        }


        /// <summary>
        /// Gets the status, metrics, and errors (if there are any) that are associated with a
        /// job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMatchingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingJob">REST API Reference for GetMatchingJob Operation</seealso>
        public virtual Task<GetMatchingJobResponse> GetMatchingJobAsync(GetMatchingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMatchingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchingJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMatchingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMatchingWorkflow


        /// <summary>
        /// Returns the <code>MatchingWorkflow</code> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the GetMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingWorkflow">REST API Reference for GetMatchingWorkflow Operation</seealso>
        public virtual GetMatchingWorkflowResponse GetMatchingWorkflow(GetMatchingWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchingWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetMatchingWorkflowResponse>(request, options);
        }


        /// <summary>
        /// Returns the <code>MatchingWorkflow</code> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingWorkflow">REST API Reference for GetMatchingWorkflow Operation</seealso>
        public virtual Task<GetMatchingWorkflowResponse> GetMatchingWorkflowAsync(GetMatchingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchingWorkflowResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMatchingWorkflowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSchemaMapping


        /// <summary>
        /// Returns the SchemaMapping of a given name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaMapping service method.</param>
        /// 
        /// <returns>The response from the GetSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetSchemaMapping">REST API Reference for GetSchemaMapping Operation</seealso>
        public virtual GetSchemaMappingResponse GetSchemaMapping(GetSchemaMappingRequest request)
        {
            var options = new InvokeOptions();
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
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetSchemaMapping">REST API Reference for GetSchemaMapping Operation</seealso>
        public virtual Task<GetSchemaMappingResponse> GetSchemaMappingAsync(GetSchemaMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaMappingResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSchemaMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMatchingJobs


        /// <summary>
        /// Lists all jobs for a given workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingJobs service method.</param>
        /// 
        /// <returns>The response from the ListMatchingJobs service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingJobs">REST API Reference for ListMatchingJobs Operation</seealso>
        public virtual ListMatchingJobsResponse ListMatchingJobs(ListMatchingJobsRequest request)
        {
            var options = new InvokeOptions();
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
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingJobs">REST API Reference for ListMatchingJobs Operation</seealso>
        public virtual Task<ListMatchingJobsResponse> ListMatchingJobsAsync(ListMatchingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMatchingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMatchingJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMatchingJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMatchingWorkflows


        /// <summary>
        /// Returns a list of all the <code>MatchingWorkflows</code> that have been created for
        /// an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListMatchingWorkflows service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingWorkflows">REST API Reference for ListMatchingWorkflows Operation</seealso>
        public virtual ListMatchingWorkflowsResponse ListMatchingWorkflows(ListMatchingWorkflowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMatchingWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMatchingWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListMatchingWorkflowsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all the <code>MatchingWorkflows</code> that have been created for
        /// an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMatchingWorkflows service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingWorkflows">REST API Reference for ListMatchingWorkflows Operation</seealso>
        public virtual Task<ListMatchingWorkflowsResponse> ListMatchingWorkflowsAsync(ListMatchingWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMatchingWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMatchingWorkflowsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMatchingWorkflowsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSchemaMappings


        /// <summary>
        /// Returns a list of all the <code>SchemaMappings</code> that have been created for an
        /// Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaMappings service method.</param>
        /// 
        /// <returns>The response from the ListSchemaMappings service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListSchemaMappings">REST API Reference for ListSchemaMappings Operation</seealso>
        public virtual ListSchemaMappingsResponse ListSchemaMappings(ListSchemaMappingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemaMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaMappingsResponseUnmarshaller.Instance;

            return Invoke<ListSchemaMappingsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all the <code>SchemaMappings</code> that have been created for an
        /// Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemaMappings service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListSchemaMappings">REST API Reference for ListSchemaMappings Operation</seealso>
        public virtual Task<ListSchemaMappingsResponse> ListSchemaMappingsAsync(ListSchemaMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemaMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaMappingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSchemaMappingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Displays the tags associated with an Entity Resolution resource. In Entity Resolution,
        /// <code>SchemaMapping</code>, and <code>MatchingWorkflow</code> can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Displays the tags associated with an Entity Resolution resource. In Entity Resolution,
        /// <code>SchemaMapping</code>, and <code>MatchingWorkflow</code> can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMatchingJob


        /// <summary>
        /// Starts the <code>MatchingJob</code> of a workflow. The workflow must have previously
        /// been created using the <code>CreateMatchingWorkflow</code> endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMatchingJob service method.</param>
        /// 
        /// <returns>The response from the StartMatchingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc. <code>HTTP Status Code: 400</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// <code>HTTP Status Code: 402</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartMatchingJob">REST API Reference for StartMatchingJob Operation</seealso>
        public virtual StartMatchingJobResponse StartMatchingJob(StartMatchingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMatchingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchingJobResponseUnmarshaller.Instance;

            return Invoke<StartMatchingJobResponse>(request, options);
        }


        /// <summary>
        /// Starts the <code>MatchingJob</code> of a workflow. The workflow must have previously
        /// been created using the <code>CreateMatchingWorkflow</code> endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMatchingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMatchingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc. <code>HTTP Status Code: 400</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// <code>HTTP Status Code: 402</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartMatchingJob">REST API Reference for StartMatchingJob Operation</seealso>
        public virtual Task<StartMatchingJobResponse> StartMatchingJobAsync(StartMatchingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMatchingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchingJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartMatchingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified Entity Resolution resource.
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values. In Entity Resolution, <code>SchemaMapping</code> and <code>MatchingWorkflow</code>
        /// can be tagged. Tags don't have any semantic meaning to Amazon Web Services and are
        /// interpreted strictly as strings of characters. You can use the <code>TagResource</code>
        /// action with a resource that already has tags. If you specify a new tag key, this tag
        /// is appended to the list of tags associated with the resource. If you specify a tag
        /// key that is already associated with the resource, the new tag value that you specify
        /// replaces the previous value for that tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified Entity Resolution resource.
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values. In Entity Resolution, <code>SchemaMapping</code> and <code>MatchingWorkflow</code>
        /// can be tagged. Tags don't have any semantic meaning to Amazon Web Services and are
        /// interpreted strictly as strings of characters. You can use the <code>TagResource</code>
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
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified Entity Resolution resource. In Entity
        /// Resolution, <code>SchemaMapping</code>, and <code>MatchingWorkflow</code> can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes one or more tags from the specified Entity Resolution resource. In Entity
        /// Resolution, <code>SchemaMapping</code>, and <code>MatchingWorkflow</code> can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMatchingWorkflow


        /// <summary>
        /// Updates an existing <code>MatchingWorkflow</code>. This method is identical to <code>CreateMatchingWorkflow</code>,
        /// except it uses an HTTP <code>PUT</code> request instead of a <code>POST</code> request,
        /// and the <code>MatchingWorkflow</code> must already exist for the method to succeed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the UpdateMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateMatchingWorkflow">REST API Reference for UpdateMatchingWorkflow Operation</seealso>
        public virtual UpdateMatchingWorkflowResponse UpdateMatchingWorkflow(UpdateMatchingWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMatchingWorkflowResponseUnmarshaller.Instance;

            return Invoke<UpdateMatchingWorkflowResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing <code>MatchingWorkflow</code>. This method is identical to <code>CreateMatchingWorkflow</code>,
        /// except it uses an HTTP <code>PUT</code> request instead of a <code>POST</code> request,
        /// and the <code>MatchingWorkflow</code> must already exist for the method to succeed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateMatchingWorkflow">REST API Reference for UpdateMatchingWorkflow Operation</seealso>
        public virtual Task<UpdateMatchingWorkflowResponse> UpdateMatchingWorkflowAsync(UpdateMatchingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMatchingWorkflowResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateMatchingWorkflowResponse>(request, options, cancellationToken);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonEntityResolutionEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}