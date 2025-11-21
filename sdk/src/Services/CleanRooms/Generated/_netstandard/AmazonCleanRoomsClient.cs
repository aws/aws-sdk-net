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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CleanRooms.Model;
using Amazon.CleanRooms.Model.Internal.MarshallTransformations;
using Amazon.CleanRooms.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CleanRooms
{
    /// <summary>
    /// <para>Implementation for accessing CleanRooms</para>
    ///
    /// Welcome to the <i>Clean Rooms API Reference</i>.
    /// 
    ///  
    /// <para>
    /// Clean Rooms is an Amazon Web Services service that helps multiple parties to join
    /// their data together in a secure collaboration workspace. In the collaboration, members
    /// who can run queries and jobs and receive results can get insights into the collective
    /// datasets without either party getting access to the other party's raw data.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Clean Rooms concepts, procedures, and best practices, see the
    /// <a href="https://docs.aws.amazon.com/clean-rooms/latest/userguide/what-is.html">Clean
    /// Rooms User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// To learn more about SQL commands, functions, and conditions supported in Clean Rooms,
    /// see the <a href="https://docs.aws.amazon.com/clean-rooms/latest/sql-reference/sql-reference.html">Clean
    /// Rooms SQL Reference</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCleanRoomsClient : AmazonServiceClient, IAmazonCleanRooms
    {
        private static IServiceMetadata serviceMetadata = new AmazonCleanRoomsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with the credentials loaded from the application's
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
        public AmazonCleanRoomsClient()
            : base(new AmazonCleanRoomsConfig()) { }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with the credentials loaded from the application's
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
        public AmazonCleanRoomsClient(RegionEndpoint region)
            : base(new AmazonCleanRoomsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCleanRoomsClient Configuration Object</param>
        public AmazonCleanRoomsClient(AmazonCleanRoomsConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCleanRoomsClient(AWSCredentials credentials)
            : this(credentials, new AmazonCleanRoomsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCleanRoomsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCleanRoomsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Credentials and an
        /// AmazonCleanRoomsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCleanRoomsClient Configuration Object</param>
        public AmazonCleanRoomsClient(AWSCredentials credentials, AmazonCleanRoomsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCleanRoomsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCleanRoomsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCleanRoomsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCleanRoomsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCleanRoomsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCleanRoomsClient Configuration Object</param>
        public AmazonCleanRoomsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCleanRoomsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCleanRoomsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCleanRoomsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCleanRoomsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCleanRoomsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCleanRoomsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCleanRoomsClient Configuration Object</param>
        public AmazonCleanRoomsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCleanRoomsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ICleanRoomsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICleanRoomsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CleanRoomsPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCleanRoomsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCleanRoomsAuthSchemeHandler());
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


        #region  BatchGetCollaborationAnalysisTemplate

        internal virtual BatchGetCollaborationAnalysisTemplateResponse BatchGetCollaborationAnalysisTemplate(BatchGetCollaborationAnalysisTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetCollaborationAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCollaborationAnalysisTemplateResponseUnmarshaller.Instance;

            return Invoke<BatchGetCollaborationAnalysisTemplateResponse>(request, options);
        }



        /// <summary>
        /// Retrieves multiple analysis templates within a collaboration by their Amazon Resource
        /// Names (ARNs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCollaborationAnalysisTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCollaborationAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetCollaborationAnalysisTemplate">REST API Reference for BatchGetCollaborationAnalysisTemplate Operation</seealso>
        public virtual Task<BatchGetCollaborationAnalysisTemplateResponse> BatchGetCollaborationAnalysisTemplateAsync(BatchGetCollaborationAnalysisTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetCollaborationAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCollaborationAnalysisTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetCollaborationAnalysisTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetSchema

        internal virtual BatchGetSchemaResponse BatchGetSchema(BatchGetSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSchemaResponseUnmarshaller.Instance;

            return Invoke<BatchGetSchemaResponse>(request, options);
        }



        /// <summary>
        /// Retrieves multiple schemas by their identifiers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetSchema service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetSchema">REST API Reference for BatchGetSchema Operation</seealso>
        public virtual Task<BatchGetSchemaResponse> BatchGetSchemaAsync(BatchGetSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetSchemaAnalysisRule

        internal virtual BatchGetSchemaAnalysisRuleResponse BatchGetSchemaAnalysisRule(BatchGetSchemaAnalysisRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetSchemaAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSchemaAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<BatchGetSchemaAnalysisRuleResponse>(request, options);
        }



        /// <summary>
        /// Retrieves multiple analysis rule schemas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSchemaAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetSchemaAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetSchemaAnalysisRule">REST API Reference for BatchGetSchemaAnalysisRule Operation</seealso>
        public virtual Task<BatchGetSchemaAnalysisRuleResponse> BatchGetSchemaAnalysisRuleAsync(BatchGetSchemaAnalysisRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetSchemaAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSchemaAnalysisRuleResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetSchemaAnalysisRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAnalysisTemplate

        internal virtual CreateAnalysisTemplateResponse CreateAnalysisTemplate(CreateAnalysisTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnalysisTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateAnalysisTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a new analysis template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnalysisTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateAnalysisTemplate">REST API Reference for CreateAnalysisTemplate Operation</seealso>
        public virtual Task<CreateAnalysisTemplateResponse> CreateAnalysisTemplateAsync(CreateAnalysisTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnalysisTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAnalysisTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCollaboration

        internal virtual CreateCollaborationResponse CreateCollaboration(CreateCollaborationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollaborationResponseUnmarshaller.Instance;

            return Invoke<CreateCollaborationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollaboration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateCollaboration">REST API Reference for CreateCollaboration Operation</seealso>
        public virtual Task<CreateCollaborationResponse> CreateCollaborationAsync(CreateCollaborationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollaborationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCollaborationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCollaborationChangeRequest

        internal virtual CreateCollaborationChangeRequestResponse CreateCollaborationChangeRequest(CreateCollaborationChangeRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCollaborationChangeRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollaborationChangeRequestResponseUnmarshaller.Instance;

            return Invoke<CreateCollaborationChangeRequestResponse>(request, options);
        }



        /// <summary>
        /// Creates a new change request to modify an existing collaboration. This enables post-creation
        /// modifications to collaborations through a structured API-driven approach.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollaborationChangeRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCollaborationChangeRequest service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateCollaborationChangeRequest">REST API Reference for CreateCollaborationChangeRequest Operation</seealso>
        public virtual Task<CreateCollaborationChangeRequestResponse> CreateCollaborationChangeRequestAsync(CreateCollaborationChangeRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCollaborationChangeRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollaborationChangeRequestResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCollaborationChangeRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConfiguredAudienceModelAssociation

        internal virtual CreateConfiguredAudienceModelAssociationResponse CreateConfiguredAudienceModelAssociation(CreateConfiguredAudienceModelAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateConfiguredAudienceModelAssociationResponse>(request, options);
        }



        /// <summary>
        /// Provides the details necessary to create a configured audience model association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredAudienceModelAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfiguredAudienceModelAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredAudienceModelAssociation">REST API Reference for CreateConfiguredAudienceModelAssociation Operation</seealso>
        public virtual Task<CreateConfiguredAudienceModelAssociationResponse> CreateConfiguredAudienceModelAssociationAsync(CreateConfiguredAudienceModelAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfiguredAudienceModelAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConfiguredTable

        internal virtual CreateConfiguredTableResponse CreateConfiguredTable(CreateConfiguredTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableResponseUnmarshaller.Instance;

            return Invoke<CreateConfiguredTableResponse>(request, options);
        }



        /// <summary>
        /// Creates a new configured table resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTable">REST API Reference for CreateConfiguredTable Operation</seealso>
        public virtual Task<CreateConfiguredTableResponse> CreateConfiguredTableAsync(CreateConfiguredTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfiguredTableResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConfiguredTableAnalysisRule

        internal virtual CreateConfiguredTableAnalysisRuleResponse CreateConfiguredTableAnalysisRule(CreateConfiguredTableAnalysisRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<CreateConfiguredTableAnalysisRuleResponse>(request, options);
        }



        /// <summary>
        /// Creates a new analysis rule for a configured table. Currently, only one analysis rule
        /// can be created for a given configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAnalysisRule">REST API Reference for CreateConfiguredTableAnalysisRule Operation</seealso>
        public virtual Task<CreateConfiguredTableAnalysisRuleResponse> CreateConfiguredTableAnalysisRuleAsync(CreateConfiguredTableAnalysisRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfiguredTableAnalysisRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConfiguredTableAssociation

        internal virtual CreateConfiguredTableAssociationResponse CreateConfiguredTableAssociation(CreateConfiguredTableAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateConfiguredTableAssociationResponse>(request, options);
        }



        /// <summary>
        /// Creates a configured table association. A configured table association links a configured
        /// table with a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAssociation">REST API Reference for CreateConfiguredTableAssociation Operation</seealso>
        public virtual Task<CreateConfiguredTableAssociationResponse> CreateConfiguredTableAssociationAsync(CreateConfiguredTableAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfiguredTableAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConfiguredTableAssociationAnalysisRule

        internal virtual CreateConfiguredTableAssociationAnalysisRuleResponse CreateConfiguredTableAssociationAnalysisRule(CreateConfiguredTableAssociationAnalysisRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<CreateConfiguredTableAssociationAnalysisRuleResponse>(request, options);
        }



        /// <summary>
        /// Creates a new analysis rule for an associated configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAssociationAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfiguredTableAssociationAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAssociationAnalysisRule">REST API Reference for CreateConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual Task<CreateConfiguredTableAssociationAnalysisRuleResponse> CreateConfiguredTableAssociationAnalysisRuleAsync(CreateConfiguredTableAssociationAnalysisRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfiguredTableAssociationAnalysisRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIdMappingTable

        internal virtual CreateIdMappingTableResponse CreateIdMappingTable(CreateIdMappingTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdMappingTableResponseUnmarshaller.Instance;

            return Invoke<CreateIdMappingTableResponse>(request, options);
        }



        /// <summary>
        /// Creates an ID mapping table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdMappingTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIdMappingTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateIdMappingTable">REST API Reference for CreateIdMappingTable Operation</seealso>
        public virtual Task<CreateIdMappingTableResponse> CreateIdMappingTableAsync(CreateIdMappingTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdMappingTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIdMappingTableResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIdNamespaceAssociation

        internal virtual CreateIdNamespaceAssociationResponse CreateIdNamespaceAssociation(CreateIdNamespaceAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdNamespaceAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateIdNamespaceAssociationResponse>(request, options);
        }



        /// <summary>
        /// Creates an ID namespace association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdNamespaceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIdNamespaceAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateIdNamespaceAssociation">REST API Reference for CreateIdNamespaceAssociation Operation</seealso>
        public virtual Task<CreateIdNamespaceAssociationResponse> CreateIdNamespaceAssociationAsync(CreateIdNamespaceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdNamespaceAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIdNamespaceAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMembership

        internal virtual CreateMembershipResponse CreateMembership(CreateMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateMembershipResponse>(request, options);
        }



        /// <summary>
        /// Creates a membership for a specific collaboration identifier and joins the collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        public virtual Task<CreateMembershipResponse> CreateMembershipAsync(CreateMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePrivacyBudgetTemplate

        internal virtual CreatePrivacyBudgetTemplateResponse CreatePrivacyBudgetTemplate(CreatePrivacyBudgetTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return Invoke<CreatePrivacyBudgetTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a privacy budget template for a specified collaboration. Each collaboration
        /// can have only one privacy budget template. If you need to change the privacy budget
        /// template, use the <a>UpdatePrivacyBudgetTemplate</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivacyBudgetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePrivacyBudgetTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreatePrivacyBudgetTemplate">REST API Reference for CreatePrivacyBudgetTemplate Operation</seealso>
        public virtual Task<CreatePrivacyBudgetTemplateResponse> CreatePrivacyBudgetTemplateAsync(CreatePrivacyBudgetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePrivacyBudgetTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAnalysisTemplate

        internal virtual DeleteAnalysisTemplateResponse DeleteAnalysisTemplate(DeleteAnalysisTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnalysisTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteAnalysisTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes an analysis template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysisTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteAnalysisTemplate">REST API Reference for DeleteAnalysisTemplate Operation</seealso>
        public virtual Task<DeleteAnalysisTemplateResponse> DeleteAnalysisTemplateAsync(DeleteAnalysisTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnalysisTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAnalysisTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCollaboration

        internal virtual DeleteCollaborationResponse DeleteCollaboration(DeleteCollaborationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollaborationResponseUnmarshaller.Instance;

            return Invoke<DeleteCollaborationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a collaboration. It can only be called by the collaboration owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollaboration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteCollaboration">REST API Reference for DeleteCollaboration Operation</seealso>
        public virtual Task<DeleteCollaborationResponse> DeleteCollaborationAsync(DeleteCollaborationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollaborationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCollaborationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConfiguredAudienceModelAssociation

        internal virtual DeleteConfiguredAudienceModelAssociationResponse DeleteConfiguredAudienceModelAssociation(DeleteConfiguredAudienceModelAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredAudienceModelAssociationResponse>(request, options);
        }



        /// <summary>
        /// Provides the information necessary to delete a configured audience model association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredAudienceModelAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfiguredAudienceModelAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredAudienceModelAssociation">REST API Reference for DeleteConfiguredAudienceModelAssociation Operation</seealso>
        public virtual Task<DeleteConfiguredAudienceModelAssociationResponse> DeleteConfiguredAudienceModelAssociationAsync(DeleteConfiguredAudienceModelAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfiguredAudienceModelAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConfiguredTable

        internal virtual DeleteConfiguredTableResponse DeleteConfiguredTable(DeleteConfiguredTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredTableResponse>(request, options);
        }



        /// <summary>
        /// Deletes a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTable">REST API Reference for DeleteConfiguredTable Operation</seealso>
        public virtual Task<DeleteConfiguredTableResponse> DeleteConfiguredTableAsync(DeleteConfiguredTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfiguredTableResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConfiguredTableAnalysisRule

        internal virtual DeleteConfiguredTableAnalysisRuleResponse DeleteConfiguredTableAnalysisRule(DeleteConfiguredTableAnalysisRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredTableAnalysisRuleResponse>(request, options);
        }



        /// <summary>
        /// Deletes a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAnalysisRule">REST API Reference for DeleteConfiguredTableAnalysisRule Operation</seealso>
        public virtual Task<DeleteConfiguredTableAnalysisRuleResponse> DeleteConfiguredTableAnalysisRuleAsync(DeleteConfiguredTableAnalysisRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfiguredTableAnalysisRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConfiguredTableAssociation

        internal virtual DeleteConfiguredTableAssociationResponse DeleteConfiguredTableAssociation(DeleteConfiguredTableAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredTableAssociationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAssociation">REST API Reference for DeleteConfiguredTableAssociation Operation</seealso>
        public virtual Task<DeleteConfiguredTableAssociationResponse> DeleteConfiguredTableAssociationAsync(DeleteConfiguredTableAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfiguredTableAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConfiguredTableAssociationAnalysisRule

        internal virtual DeleteConfiguredTableAssociationAnalysisRuleResponse DeleteConfiguredTableAssociationAnalysisRule(DeleteConfiguredTableAssociationAnalysisRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredTableAssociationAnalysisRuleResponse>(request, options);
        }



        /// <summary>
        /// Deletes an analysis rule for a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAssociationAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfiguredTableAssociationAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAssociationAnalysisRule">REST API Reference for DeleteConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual Task<DeleteConfiguredTableAssociationAnalysisRuleResponse> DeleteConfiguredTableAssociationAnalysisRuleAsync(DeleteConfiguredTableAssociationAnalysisRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfiguredTableAssociationAnalysisRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIdMappingTable

        internal virtual DeleteIdMappingTableResponse DeleteIdMappingTable(DeleteIdMappingTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdMappingTableResponseUnmarshaller.Instance;

            return Invoke<DeleteIdMappingTableResponse>(request, options);
        }



        /// <summary>
        /// Deletes an ID mapping table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdMappingTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdMappingTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteIdMappingTable">REST API Reference for DeleteIdMappingTable Operation</seealso>
        public virtual Task<DeleteIdMappingTableResponse> DeleteIdMappingTableAsync(DeleteIdMappingTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdMappingTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdMappingTableResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIdNamespaceAssociation

        internal virtual DeleteIdNamespaceAssociationResponse DeleteIdNamespaceAssociation(DeleteIdNamespaceAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdNamespaceAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteIdNamespaceAssociationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an ID namespace association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdNamespaceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdNamespaceAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteIdNamespaceAssociation">REST API Reference for DeleteIdNamespaceAssociation Operation</seealso>
        public virtual Task<DeleteIdNamespaceAssociationResponse> DeleteIdNamespaceAssociationAsync(DeleteIdNamespaceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdNamespaceAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdNamespaceAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMember

        internal virtual DeleteMemberResponse DeleteMember(DeleteMemberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMemberResponseUnmarshaller.Instance;

            return Invoke<DeleteMemberResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified member from a collaboration. The removed member is placed in
        /// the Removed status and can't interact with the collaboration. The removed member's
        /// data is inaccessible to active members of the collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMember service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        public virtual Task<DeleteMemberResponse> DeleteMemberAsync(DeleteMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMemberResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMemberResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMembership

        internal virtual DeleteMembershipResponse DeleteMembership(DeleteMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteMembershipResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specified membership. All resources under a membership must be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMembership">REST API Reference for DeleteMembership Operation</seealso>
        public virtual Task<DeleteMembershipResponse> DeleteMembershipAsync(DeleteMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePrivacyBudgetTemplate

        internal virtual DeletePrivacyBudgetTemplateResponse DeletePrivacyBudgetTemplate(DeletePrivacyBudgetTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return Invoke<DeletePrivacyBudgetTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes a privacy budget template for a specified collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrivacyBudgetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePrivacyBudgetTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeletePrivacyBudgetTemplate">REST API Reference for DeletePrivacyBudgetTemplate Operation</seealso>
        public virtual Task<DeletePrivacyBudgetTemplateResponse> DeletePrivacyBudgetTemplateAsync(DeletePrivacyBudgetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePrivacyBudgetTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAnalysisTemplate

        internal virtual GetAnalysisTemplateResponse GetAnalysisTemplate(GetAnalysisTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnalysisTemplateResponseUnmarshaller.Instance;

            return Invoke<GetAnalysisTemplateResponse>(request, options);
        }



        /// <summary>
        /// Retrieves an analysis template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnalysisTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetAnalysisTemplate">REST API Reference for GetAnalysisTemplate Operation</seealso>
        public virtual Task<GetAnalysisTemplateResponse> GetAnalysisTemplateAsync(GetAnalysisTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnalysisTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetAnalysisTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCollaboration

        internal virtual GetCollaborationResponse GetCollaboration(GetCollaborationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationResponseUnmarshaller.Instance;

            return Invoke<GetCollaborationResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata about a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaboration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaboration">REST API Reference for GetCollaboration Operation</seealso>
        public virtual Task<GetCollaborationResponse> GetCollaborationAsync(GetCollaborationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationResponseUnmarshaller.Instance;

            return InvokeAsync<GetCollaborationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCollaborationAnalysisTemplate

        internal virtual GetCollaborationAnalysisTemplateResponse GetCollaborationAnalysisTemplate(GetCollaborationAnalysisTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationAnalysisTemplateResponseUnmarshaller.Instance;

            return Invoke<GetCollaborationAnalysisTemplateResponse>(request, options);
        }



        /// <summary>
        /// Retrieves an analysis template within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationAnalysisTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCollaborationAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationAnalysisTemplate">REST API Reference for GetCollaborationAnalysisTemplate Operation</seealso>
        public virtual Task<GetCollaborationAnalysisTemplateResponse> GetCollaborationAnalysisTemplateAsync(GetCollaborationAnalysisTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationAnalysisTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetCollaborationAnalysisTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCollaborationChangeRequest

        internal virtual GetCollaborationChangeRequestResponse GetCollaborationChangeRequest(GetCollaborationChangeRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationChangeRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationChangeRequestResponseUnmarshaller.Instance;

            return Invoke<GetCollaborationChangeRequestResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about a specific collaboration change request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationChangeRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCollaborationChangeRequest service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationChangeRequest">REST API Reference for GetCollaborationChangeRequest Operation</seealso>
        public virtual Task<GetCollaborationChangeRequestResponse> GetCollaborationChangeRequestAsync(GetCollaborationChangeRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationChangeRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationChangeRequestResponseUnmarshaller.Instance;

            return InvokeAsync<GetCollaborationChangeRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCollaborationConfiguredAudienceModelAssociation

        internal virtual GetCollaborationConfiguredAudienceModelAssociationResponse GetCollaborationConfiguredAudienceModelAssociation(GetCollaborationConfiguredAudienceModelAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return Invoke<GetCollaborationConfiguredAudienceModelAssociationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a configured audience model association within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationConfiguredAudienceModelAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCollaborationConfiguredAudienceModelAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationConfiguredAudienceModelAssociation">REST API Reference for GetCollaborationConfiguredAudienceModelAssociation Operation</seealso>
        public virtual Task<GetCollaborationConfiguredAudienceModelAssociationResponse> GetCollaborationConfiguredAudienceModelAssociationAsync(GetCollaborationConfiguredAudienceModelAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetCollaborationConfiguredAudienceModelAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCollaborationIdNamespaceAssociation

        internal virtual GetCollaborationIdNamespaceAssociationResponse GetCollaborationIdNamespaceAssociation(GetCollaborationIdNamespaceAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationIdNamespaceAssociationResponseUnmarshaller.Instance;

            return Invoke<GetCollaborationIdNamespaceAssociationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves an ID namespace association from a specific collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationIdNamespaceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCollaborationIdNamespaceAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationIdNamespaceAssociation">REST API Reference for GetCollaborationIdNamespaceAssociation Operation</seealso>
        public virtual Task<GetCollaborationIdNamespaceAssociationResponse> GetCollaborationIdNamespaceAssociationAsync(GetCollaborationIdNamespaceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationIdNamespaceAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetCollaborationIdNamespaceAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCollaborationPrivacyBudgetTemplate

        internal virtual GetCollaborationPrivacyBudgetTemplateResponse GetCollaborationPrivacyBudgetTemplate(GetCollaborationPrivacyBudgetTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationPrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationPrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetCollaborationPrivacyBudgetTemplateResponse>(request, options);
        }



        /// <summary>
        /// Returns details about a specified privacy budget template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationPrivacyBudgetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCollaborationPrivacyBudgetTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationPrivacyBudgetTemplate">REST API Reference for GetCollaborationPrivacyBudgetTemplate Operation</seealso>
        public virtual Task<GetCollaborationPrivacyBudgetTemplateResponse> GetCollaborationPrivacyBudgetTemplateAsync(GetCollaborationPrivacyBudgetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationPrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationPrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetCollaborationPrivacyBudgetTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConfiguredAudienceModelAssociation

        internal virtual GetConfiguredAudienceModelAssociationResponse GetConfiguredAudienceModelAssociation(GetConfiguredAudienceModelAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredAudienceModelAssociationResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a configured audience model association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredAudienceModelAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguredAudienceModelAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredAudienceModelAssociation">REST API Reference for GetConfiguredAudienceModelAssociation Operation</seealso>
        public virtual Task<GetConfiguredAudienceModelAssociationResponse> GetConfiguredAudienceModelAssociationAsync(GetConfiguredAudienceModelAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfiguredAudienceModelAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConfiguredTable

        internal virtual GetConfiguredTableResponse GetConfiguredTable(GetConfiguredTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredTableResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTable">REST API Reference for GetConfiguredTable Operation</seealso>
        public virtual Task<GetConfiguredTableResponse> GetConfiguredTableAsync(GetConfiguredTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfiguredTableResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConfiguredTableAnalysisRule

        internal virtual GetConfiguredTableAnalysisRuleResponse GetConfiguredTableAnalysisRule(GetConfiguredTableAnalysisRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredTableAnalysisRuleResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAnalysisRule">REST API Reference for GetConfiguredTableAnalysisRule Operation</seealso>
        public virtual Task<GetConfiguredTableAnalysisRuleResponse> GetConfiguredTableAnalysisRuleAsync(GetConfiguredTableAnalysisRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfiguredTableAnalysisRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConfiguredTableAssociation

        internal virtual GetConfiguredTableAssociationResponse GetConfiguredTableAssociation(GetConfiguredTableAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableAssociationResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredTableAssociationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAssociation">REST API Reference for GetConfiguredTableAssociation Operation</seealso>
        public virtual Task<GetConfiguredTableAssociationResponse> GetConfiguredTableAssociationAsync(GetConfiguredTableAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfiguredTableAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConfiguredTableAssociationAnalysisRule

        internal virtual GetConfiguredTableAssociationAnalysisRuleResponse GetConfiguredTableAssociationAnalysisRule(GetConfiguredTableAssociationAnalysisRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredTableAssociationAnalysisRuleResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the analysis rule for a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAssociationAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguredTableAssociationAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAssociationAnalysisRule">REST API Reference for GetConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual Task<GetConfiguredTableAssociationAnalysisRuleResponse> GetConfiguredTableAssociationAnalysisRuleAsync(GetConfiguredTableAssociationAnalysisRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfiguredTableAssociationAnalysisRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIdMappingTable

        internal virtual GetIdMappingTableResponse GetIdMappingTable(GetIdMappingTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdMappingTableResponseUnmarshaller.Instance;

            return Invoke<GetIdMappingTableResponse>(request, options);
        }



        /// <summary>
        /// Retrieves an ID mapping table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdMappingTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetIdMappingTable">REST API Reference for GetIdMappingTable Operation</seealso>
        public virtual Task<GetIdMappingTableResponse> GetIdMappingTableAsync(GetIdMappingTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdMappingTableResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdMappingTableResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIdNamespaceAssociation

        internal virtual GetIdNamespaceAssociationResponse GetIdNamespaceAssociation(GetIdNamespaceAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdNamespaceAssociationResponseUnmarshaller.Instance;

            return Invoke<GetIdNamespaceAssociationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves an ID namespace association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdNamespaceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdNamespaceAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetIdNamespaceAssociation">REST API Reference for GetIdNamespaceAssociation Operation</seealso>
        public virtual Task<GetIdNamespaceAssociationResponse> GetIdNamespaceAssociationAsync(GetIdNamespaceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdNamespaceAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdNamespaceAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMembership

        internal virtual GetMembershipResponse GetMembership(GetMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembershipResponseUnmarshaller.Instance;

            return Invoke<GetMembershipResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a specified membership for an identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetMembership">REST API Reference for GetMembership Operation</seealso>
        public virtual Task<GetMembershipResponse> GetMembershipAsync(GetMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<GetMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPrivacyBudgetTemplate

        internal virtual GetPrivacyBudgetTemplateResponse GetPrivacyBudgetTemplate(GetPrivacyBudgetTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetPrivacyBudgetTemplateResponse>(request, options);
        }



        /// <summary>
        /// Returns details for a specified privacy budget template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrivacyBudgetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPrivacyBudgetTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetPrivacyBudgetTemplate">REST API Reference for GetPrivacyBudgetTemplate Operation</seealso>
        public virtual Task<GetPrivacyBudgetTemplateResponse> GetPrivacyBudgetTemplateAsync(GetPrivacyBudgetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetPrivacyBudgetTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetProtectedJob

        internal virtual GetProtectedJobResponse GetProtectedJob(GetProtectedJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProtectedJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtectedJobResponseUnmarshaller.Instance;

            return Invoke<GetProtectedJobResponse>(request, options);
        }



        /// <summary>
        /// Returns job processing metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtectedJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProtectedJob service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetProtectedJob">REST API Reference for GetProtectedJob Operation</seealso>
        public virtual Task<GetProtectedJobResponse> GetProtectedJobAsync(GetProtectedJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProtectedJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtectedJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetProtectedJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetProtectedQuery

        internal virtual GetProtectedQueryResponse GetProtectedQuery(GetProtectedQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProtectedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtectedQueryResponseUnmarshaller.Instance;

            return Invoke<GetProtectedQueryResponse>(request, options);
        }



        /// <summary>
        /// Returns query processing metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtectedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetProtectedQuery">REST API Reference for GetProtectedQuery Operation</seealso>
        public virtual Task<GetProtectedQueryResponse> GetProtectedQueryAsync(GetProtectedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProtectedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtectedQueryResponseUnmarshaller.Instance;

            return InvokeAsync<GetProtectedQueryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSchema

        internal virtual GetSchemaResponse GetSchema(GetSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaResponseUnmarshaller.Instance;

            return Invoke<GetSchemaResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the schema for a relation within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchema service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchema">REST API Reference for GetSchema Operation</seealso>
        public virtual Task<GetSchemaResponse> GetSchemaAsync(GetSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<GetSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSchemaAnalysisRule

        internal virtual GetSchemaAnalysisRuleResponse GetSchemaAnalysisRule(GetSchemaAnalysisRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<GetSchemaAnalysisRuleResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a schema analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchemaAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchemaAnalysisRule">REST API Reference for GetSchemaAnalysisRule Operation</seealso>
        public virtual Task<GetSchemaAnalysisRuleResponse> GetSchemaAnalysisRuleAsync(GetSchemaAnalysisRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaAnalysisRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetSchemaAnalysisRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAnalysisTemplates

        internal virtual ListAnalysisTemplatesResponse ListAnalysisTemplates(ListAnalysisTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnalysisTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalysisTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListAnalysisTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists analysis templates that the caller owns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalysisTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnalysisTemplates service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListAnalysisTemplates">REST API Reference for ListAnalysisTemplates Operation</seealso>
        public virtual Task<ListAnalysisTemplatesResponse> ListAnalysisTemplatesAsync(ListAnalysisTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnalysisTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalysisTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAnalysisTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCollaborationAnalysisTemplates

        internal virtual ListCollaborationAnalysisTemplatesResponse ListCollaborationAnalysisTemplates(ListCollaborationAnalysisTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationAnalysisTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationAnalysisTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationAnalysisTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists analysis templates within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationAnalysisTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCollaborationAnalysisTemplates service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationAnalysisTemplates">REST API Reference for ListCollaborationAnalysisTemplates Operation</seealso>
        public virtual Task<ListCollaborationAnalysisTemplatesResponse> ListCollaborationAnalysisTemplatesAsync(ListCollaborationAnalysisTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationAnalysisTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationAnalysisTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCollaborationAnalysisTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCollaborationChangeRequests

        internal virtual ListCollaborationChangeRequestsResponse ListCollaborationChangeRequests(ListCollaborationChangeRequestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationChangeRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationChangeRequestsResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationChangeRequestsResponse>(request, options);
        }



        /// <summary>
        /// Lists all change requests for a collaboration with pagination support. Returns change
        /// requests sorted by creation time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationChangeRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCollaborationChangeRequests service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationChangeRequests">REST API Reference for ListCollaborationChangeRequests Operation</seealso>
        public virtual Task<ListCollaborationChangeRequestsResponse> ListCollaborationChangeRequestsAsync(ListCollaborationChangeRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationChangeRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationChangeRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCollaborationChangeRequestsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCollaborationConfiguredAudienceModelAssociations

        internal virtual ListCollaborationConfiguredAudienceModelAssociationsResponse ListCollaborationConfiguredAudienceModelAssociations(ListCollaborationConfiguredAudienceModelAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationConfiguredAudienceModelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationConfiguredAudienceModelAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationConfiguredAudienceModelAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists configured audience model associations within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationConfiguredAudienceModelAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCollaborationConfiguredAudienceModelAssociations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationConfiguredAudienceModelAssociations">REST API Reference for ListCollaborationConfiguredAudienceModelAssociations Operation</seealso>
        public virtual Task<ListCollaborationConfiguredAudienceModelAssociationsResponse> ListCollaborationConfiguredAudienceModelAssociationsAsync(ListCollaborationConfiguredAudienceModelAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationConfiguredAudienceModelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationConfiguredAudienceModelAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCollaborationConfiguredAudienceModelAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCollaborationIdNamespaceAssociations

        internal virtual ListCollaborationIdNamespaceAssociationsResponse ListCollaborationIdNamespaceAssociations(ListCollaborationIdNamespaceAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationIdNamespaceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationIdNamespaceAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationIdNamespaceAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the ID namespace associations in a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationIdNamespaceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCollaborationIdNamespaceAssociations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationIdNamespaceAssociations">REST API Reference for ListCollaborationIdNamespaceAssociations Operation</seealso>
        public virtual Task<ListCollaborationIdNamespaceAssociationsResponse> ListCollaborationIdNamespaceAssociationsAsync(ListCollaborationIdNamespaceAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationIdNamespaceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationIdNamespaceAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCollaborationIdNamespaceAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCollaborationPrivacyBudgets

        internal virtual ListCollaborationPrivacyBudgetsResponse ListCollaborationPrivacyBudgets(ListCollaborationPrivacyBudgetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationPrivacyBudgetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationPrivacyBudgetsResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationPrivacyBudgetsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array that summarizes each privacy budget in a specified collaboration.
        /// The summary includes the collaboration ARN, creation time, creating account, and privacy
        /// budget details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationPrivacyBudgets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCollaborationPrivacyBudgets service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationPrivacyBudgets">REST API Reference for ListCollaborationPrivacyBudgets Operation</seealso>
        public virtual Task<ListCollaborationPrivacyBudgetsResponse> ListCollaborationPrivacyBudgetsAsync(ListCollaborationPrivacyBudgetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationPrivacyBudgetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationPrivacyBudgetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCollaborationPrivacyBudgetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCollaborationPrivacyBudgetTemplates

        internal virtual ListCollaborationPrivacyBudgetTemplatesResponse ListCollaborationPrivacyBudgetTemplates(ListCollaborationPrivacyBudgetTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationPrivacyBudgetTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationPrivacyBudgetTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationPrivacyBudgetTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Returns an array that summarizes each privacy budget template in a specified collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationPrivacyBudgetTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCollaborationPrivacyBudgetTemplates service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationPrivacyBudgetTemplates">REST API Reference for ListCollaborationPrivacyBudgetTemplates Operation</seealso>
        public virtual Task<ListCollaborationPrivacyBudgetTemplatesResponse> ListCollaborationPrivacyBudgetTemplatesAsync(ListCollaborationPrivacyBudgetTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationPrivacyBudgetTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationPrivacyBudgetTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCollaborationPrivacyBudgetTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCollaborations

        internal virtual ListCollaborationsResponse ListCollaborations(ListCollaborationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationsResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationsResponse>(request, options);
        }



        /// <summary>
        /// Lists collaborations the caller owns, is active in, or has been invited to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCollaborations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborations">REST API Reference for ListCollaborations Operation</seealso>
        public virtual Task<ListCollaborationsResponse> ListCollaborationsAsync(ListCollaborationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCollaborationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConfiguredAudienceModelAssociations

        internal virtual ListConfiguredAudienceModelAssociationsResponse ListConfiguredAudienceModelAssociations(ListConfiguredAudienceModelAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfiguredAudienceModelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredAudienceModelAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListConfiguredAudienceModelAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists information about requested configured audience model associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredAudienceModelAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfiguredAudienceModelAssociations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredAudienceModelAssociations">REST API Reference for ListConfiguredAudienceModelAssociations Operation</seealso>
        public virtual Task<ListConfiguredAudienceModelAssociationsResponse> ListConfiguredAudienceModelAssociationsAsync(ListConfiguredAudienceModelAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfiguredAudienceModelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredAudienceModelAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfiguredAudienceModelAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConfiguredTableAssociations

        internal virtual ListConfiguredTableAssociationsResponse ListConfiguredTableAssociations(ListConfiguredTableAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfiguredTableAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredTableAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListConfiguredTableAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists configured table associations for a membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredTableAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfiguredTableAssociations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTableAssociations">REST API Reference for ListConfiguredTableAssociations Operation</seealso>
        public virtual Task<ListConfiguredTableAssociationsResponse> ListConfiguredTableAssociationsAsync(ListConfiguredTableAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfiguredTableAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredTableAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfiguredTableAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConfiguredTables

        internal virtual ListConfiguredTablesResponse ListConfiguredTables(ListConfiguredTablesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfiguredTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredTablesResponseUnmarshaller.Instance;

            return Invoke<ListConfiguredTablesResponse>(request, options);
        }



        /// <summary>
        /// Lists configured tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfiguredTables service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTables">REST API Reference for ListConfiguredTables Operation</seealso>
        public virtual Task<ListConfiguredTablesResponse> ListConfiguredTablesAsync(ListConfiguredTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfiguredTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredTablesResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfiguredTablesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIdMappingTables

        internal virtual ListIdMappingTablesResponse ListIdMappingTables(ListIdMappingTablesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdMappingTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdMappingTablesResponseUnmarshaller.Instance;

            return Invoke<ListIdMappingTablesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of ID mapping tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdMappingTables service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListIdMappingTables">REST API Reference for ListIdMappingTables Operation</seealso>
        public virtual Task<ListIdMappingTablesResponse> ListIdMappingTablesAsync(ListIdMappingTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdMappingTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdMappingTablesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdMappingTablesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIdNamespaceAssociations

        internal virtual ListIdNamespaceAssociationsResponse ListIdNamespaceAssociations(ListIdNamespaceAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdNamespaceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdNamespaceAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListIdNamespaceAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of ID namespace associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdNamespaceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdNamespaceAssociations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListIdNamespaceAssociations">REST API Reference for ListIdNamespaceAssociations Operation</seealso>
        public virtual Task<ListIdNamespaceAssociationsResponse> ListIdNamespaceAssociationsAsync(ListIdNamespaceAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdNamespaceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdNamespaceAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdNamespaceAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMembers

        internal virtual ListMembersResponse ListMembers(ListMembersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return Invoke<ListMembersResponse>(request, options);
        }



        /// <summary>
        /// Lists all members within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return InvokeAsync<ListMembersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMemberships

        internal virtual ListMembershipsResponse ListMemberships(ListMembershipsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListMembershipsResponse>(request, options);
        }



        /// <summary>
        /// Lists all memberships resources within the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMemberships service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        public virtual Task<ListMembershipsResponse> ListMembershipsAsync(ListMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembershipsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMembershipsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPrivacyBudgets

        internal virtual ListPrivacyBudgetsResponse ListPrivacyBudgets(ListPrivacyBudgetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPrivacyBudgetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivacyBudgetsResponseUnmarshaller.Instance;

            return Invoke<ListPrivacyBudgetsResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed information about the privacy budgets in a specified membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrivacyBudgets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrivacyBudgets service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListPrivacyBudgets">REST API Reference for ListPrivacyBudgets Operation</seealso>
        public virtual Task<ListPrivacyBudgetsResponse> ListPrivacyBudgetsAsync(ListPrivacyBudgetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPrivacyBudgetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivacyBudgetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPrivacyBudgetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPrivacyBudgetTemplates

        internal virtual ListPrivacyBudgetTemplatesResponse ListPrivacyBudgetTemplates(ListPrivacyBudgetTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPrivacyBudgetTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivacyBudgetTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListPrivacyBudgetTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed information about the privacy budget templates in a specified membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrivacyBudgetTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrivacyBudgetTemplates service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListPrivacyBudgetTemplates">REST API Reference for ListPrivacyBudgetTemplates Operation</seealso>
        public virtual Task<ListPrivacyBudgetTemplatesResponse> ListPrivacyBudgetTemplatesAsync(ListPrivacyBudgetTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPrivacyBudgetTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivacyBudgetTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPrivacyBudgetTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProtectedJobs

        internal virtual ListProtectedJobsResponse ListProtectedJobs(ListProtectedJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProtectedJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedJobsResponseUnmarshaller.Instance;

            return Invoke<ListProtectedJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists protected jobs, sorted by most recent job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProtectedJobs service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListProtectedJobs">REST API Reference for ListProtectedJobs Operation</seealso>
        public virtual Task<ListProtectedJobsResponse> ListProtectedJobsAsync(ListProtectedJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProtectedJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProtectedJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProtectedQueries

        internal virtual ListProtectedQueriesResponse ListProtectedQueries(ListProtectedQueriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProtectedQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedQueriesResponseUnmarshaller.Instance;

            return Invoke<ListProtectedQueriesResponse>(request, options);
        }



        /// <summary>
        /// Lists protected queries, sorted by the most recent query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProtectedQueries service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListProtectedQueries">REST API Reference for ListProtectedQueries Operation</seealso>
        public virtual Task<ListProtectedQueriesResponse> ListProtectedQueriesAsync(ListProtectedQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProtectedQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedQueriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProtectedQueriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSchemas

        internal virtual ListSchemasResponse ListSchemas(ListSchemasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return Invoke<ListSchemasResponse>(request, options);
        }



        /// <summary>
        /// Lists the schemas for relations within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual Task<ListSchemasResponse> ListSchemasAsync(ListSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return InvokeAsync<ListSchemasResponse>(request, options, cancellationToken);
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
        /// Lists all of the tags that have been added to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PopulateIdMappingTable

        internal virtual PopulateIdMappingTableResponse PopulateIdMappingTable(PopulateIdMappingTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PopulateIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PopulateIdMappingTableResponseUnmarshaller.Instance;

            return Invoke<PopulateIdMappingTableResponse>(request, options);
        }



        /// <summary>
        /// Defines the information that's necessary to populate an ID mapping table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PopulateIdMappingTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PopulateIdMappingTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/PopulateIdMappingTable">REST API Reference for PopulateIdMappingTable Operation</seealso>
        public virtual Task<PopulateIdMappingTableResponse> PopulateIdMappingTableAsync(PopulateIdMappingTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PopulateIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PopulateIdMappingTableResponseUnmarshaller.Instance;

            return InvokeAsync<PopulateIdMappingTableResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PreviewPrivacyImpact

        internal virtual PreviewPrivacyImpactResponse PreviewPrivacyImpact(PreviewPrivacyImpactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PreviewPrivacyImpactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PreviewPrivacyImpactResponseUnmarshaller.Instance;

            return Invoke<PreviewPrivacyImpactResponse>(request, options);
        }



        /// <summary>
        /// An estimate of the number of aggregation functions that the member who can query can
        /// run given epsilon and noise parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PreviewPrivacyImpact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PreviewPrivacyImpact service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/PreviewPrivacyImpact">REST API Reference for PreviewPrivacyImpact Operation</seealso>
        public virtual Task<PreviewPrivacyImpactResponse> PreviewPrivacyImpactAsync(PreviewPrivacyImpactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PreviewPrivacyImpactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PreviewPrivacyImpactResponseUnmarshaller.Instance;

            return InvokeAsync<PreviewPrivacyImpactResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartProtectedJob

        internal virtual StartProtectedJobResponse StartProtectedJob(StartProtectedJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartProtectedJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProtectedJobResponseUnmarshaller.Instance;

            return Invoke<StartProtectedJobResponse>(request, options);
        }



        /// <summary>
        /// Creates a protected job that is started by Clean Rooms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProtectedJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartProtectedJob service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/StartProtectedJob">REST API Reference for StartProtectedJob Operation</seealso>
        public virtual Task<StartProtectedJobResponse> StartProtectedJobAsync(StartProtectedJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartProtectedJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProtectedJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartProtectedJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartProtectedQuery

        internal virtual StartProtectedQueryResponse StartProtectedQuery(StartProtectedQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartProtectedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProtectedQueryResponseUnmarshaller.Instance;

            return Invoke<StartProtectedQueryResponse>(request, options);
        }



        /// <summary>
        /// Creates a protected query that is started by Clean Rooms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProtectedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/StartProtectedQuery">REST API Reference for StartProtectedQuery Operation</seealso>
        public virtual Task<StartProtectedQueryResponse> StartProtectedQueryAsync(StartProtectedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartProtectedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProtectedQueryResponseUnmarshaller.Instance;

            return InvokeAsync<StartProtectedQueryResponse>(request, options, cancellationToken);
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
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes a tag or list of tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAnalysisTemplate

        internal virtual UpdateAnalysisTemplateResponse UpdateAnalysisTemplate(UpdateAnalysisTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnalysisTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateAnalysisTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates the analysis template metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalysisTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateAnalysisTemplate">REST API Reference for UpdateAnalysisTemplate Operation</seealso>
        public virtual Task<UpdateAnalysisTemplateResponse> UpdateAnalysisTemplateAsync(UpdateAnalysisTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnalysisTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAnalysisTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCollaboration

        internal virtual UpdateCollaborationResponse UpdateCollaboration(UpdateCollaborationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCollaborationResponseUnmarshaller.Instance;

            return Invoke<UpdateCollaborationResponse>(request, options);
        }



        /// <summary>
        /// Updates collaboration metadata and can only be called by the collaboration owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollaboration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateCollaboration">REST API Reference for UpdateCollaboration Operation</seealso>
        public virtual Task<UpdateCollaborationResponse> UpdateCollaborationAsync(UpdateCollaborationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCollaborationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCollaborationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConfiguredAudienceModelAssociation

        internal virtual UpdateConfiguredAudienceModelAssociationResponse UpdateConfiguredAudienceModelAssociation(UpdateConfiguredAudienceModelAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfiguredAudienceModelAssociationResponse>(request, options);
        }



        /// <summary>
        /// Provides the details necessary to update a configured audience model association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredAudienceModelAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfiguredAudienceModelAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredAudienceModelAssociation">REST API Reference for UpdateConfiguredAudienceModelAssociation Operation</seealso>
        public virtual Task<UpdateConfiguredAudienceModelAssociationResponse> UpdateConfiguredAudienceModelAssociationAsync(UpdateConfiguredAudienceModelAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfiguredAudienceModelAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConfiguredTable

        internal virtual UpdateConfiguredTableResponse UpdateConfiguredTable(UpdateConfiguredTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableResponseUnmarshaller.Instance;

            return Invoke<UpdateConfiguredTableResponse>(request, options);
        }



        /// <summary>
        /// Updates a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTable">REST API Reference for UpdateConfiguredTable Operation</seealso>
        public virtual Task<UpdateConfiguredTableResponse> UpdateConfiguredTableAsync(UpdateConfiguredTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfiguredTableResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConfiguredTableAnalysisRule

        internal virtual UpdateConfiguredTableAnalysisRuleResponse UpdateConfiguredTableAnalysisRule(UpdateConfiguredTableAnalysisRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateConfiguredTableAnalysisRuleResponse>(request, options);
        }



        /// <summary>
        /// Updates a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAnalysisRule">REST API Reference for UpdateConfiguredTableAnalysisRule Operation</seealso>
        public virtual Task<UpdateConfiguredTableAnalysisRuleResponse> UpdateConfiguredTableAnalysisRuleAsync(UpdateConfiguredTableAnalysisRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfiguredTableAnalysisRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConfiguredTableAssociation

        internal virtual UpdateConfiguredTableAssociationResponse UpdateConfiguredTableAssociation(UpdateConfiguredTableAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfiguredTableAssociationResponse>(request, options);
        }



        /// <summary>
        /// Updates a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAssociation">REST API Reference for UpdateConfiguredTableAssociation Operation</seealso>
        public virtual Task<UpdateConfiguredTableAssociationResponse> UpdateConfiguredTableAssociationAsync(UpdateConfiguredTableAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfiguredTableAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConfiguredTableAssociationAnalysisRule

        internal virtual UpdateConfiguredTableAssociationAnalysisRuleResponse UpdateConfiguredTableAssociationAnalysisRule(UpdateConfiguredTableAssociationAnalysisRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateConfiguredTableAssociationAnalysisRuleResponse>(request, options);
        }



        /// <summary>
        /// Updates the analysis rule for a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAssociationAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfiguredTableAssociationAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAssociationAnalysisRule">REST API Reference for UpdateConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual Task<UpdateConfiguredTableAssociationAnalysisRuleResponse> UpdateConfiguredTableAssociationAnalysisRuleAsync(UpdateConfiguredTableAssociationAnalysisRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfiguredTableAssociationAnalysisRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateIdMappingTable

        internal virtual UpdateIdMappingTableResponse UpdateIdMappingTable(UpdateIdMappingTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdMappingTableResponseUnmarshaller.Instance;

            return Invoke<UpdateIdMappingTableResponse>(request, options);
        }



        /// <summary>
        /// Provides the details that are necessary to update an ID mapping table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdMappingTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIdMappingTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateIdMappingTable">REST API Reference for UpdateIdMappingTable Operation</seealso>
        public virtual Task<UpdateIdMappingTableResponse> UpdateIdMappingTableAsync(UpdateIdMappingTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdMappingTableResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIdMappingTableResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateIdNamespaceAssociation

        internal virtual UpdateIdNamespaceAssociationResponse UpdateIdNamespaceAssociation(UpdateIdNamespaceAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdNamespaceAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateIdNamespaceAssociationResponse>(request, options);
        }



        /// <summary>
        /// Provides the details that are necessary to update an ID namespace association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdNamespaceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIdNamespaceAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateIdNamespaceAssociation">REST API Reference for UpdateIdNamespaceAssociation Operation</seealso>
        public virtual Task<UpdateIdNamespaceAssociationResponse> UpdateIdNamespaceAssociationAsync(UpdateIdNamespaceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdNamespaceAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIdNamespaceAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateMembership

        internal virtual UpdateMembershipResponse UpdateMembership(UpdateMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMembershipResponseUnmarshaller.Instance;

            return Invoke<UpdateMembershipResponse>(request, options);
        }



        /// <summary>
        /// Updates a membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        public virtual Task<UpdateMembershipResponse> UpdateMembershipAsync(UpdateMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePrivacyBudgetTemplate

        internal virtual UpdatePrivacyBudgetTemplateResponse UpdatePrivacyBudgetTemplate(UpdatePrivacyBudgetTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdatePrivacyBudgetTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates the privacy budget template for the specified collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrivacyBudgetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePrivacyBudgetTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdatePrivacyBudgetTemplate">REST API Reference for UpdatePrivacyBudgetTemplate Operation</seealso>
        public virtual Task<UpdatePrivacyBudgetTemplateResponse> UpdatePrivacyBudgetTemplateAsync(UpdatePrivacyBudgetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePrivacyBudgetTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateProtectedJob

        internal virtual UpdateProtectedJobResponse UpdateProtectedJob(UpdateProtectedJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProtectedJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProtectedJobResponseUnmarshaller.Instance;

            return Invoke<UpdateProtectedJobResponse>(request, options);
        }



        /// <summary>
        /// Updates the processing of a currently running job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectedJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProtectedJob service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateProtectedJob">REST API Reference for UpdateProtectedJob Operation</seealso>
        public virtual Task<UpdateProtectedJobResponse> UpdateProtectedJobAsync(UpdateProtectedJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProtectedJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProtectedJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProtectedJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateProtectedQuery

        internal virtual UpdateProtectedQueryResponse UpdateProtectedQuery(UpdateProtectedQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProtectedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProtectedQueryResponseUnmarshaller.Instance;

            return Invoke<UpdateProtectedQueryResponse>(request, options);
        }



        /// <summary>
        /// Updates the processing of a currently running query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateProtectedQuery">REST API Reference for UpdateProtectedQuery Operation</seealso>
        public virtual Task<UpdateProtectedQueryResponse> UpdateProtectedQueryAsync(UpdateProtectedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProtectedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProtectedQueryResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProtectedQueryResponse>(request, options, cancellationToken);
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