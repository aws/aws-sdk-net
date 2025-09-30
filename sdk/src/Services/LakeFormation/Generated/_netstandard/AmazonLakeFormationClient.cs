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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.LakeFormation.Model;
using Amazon.LakeFormation.Model.Internal.MarshallTransformations;
using Amazon.LakeFormation.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.LakeFormation
{
    /// <summary>
    /// <para>Implementation for accessing LakeFormation</para>
    ///
    /// Lake Formation 
    /// <para>
    /// Defines the public endpoint for the Lake Formation service.
    /// </para>
    /// </summary>
    public partial class AmazonLakeFormationClient : AmazonServiceClient, IAmazonLakeFormation
    {
        private static IServiceMetadata serviceMetadata = new AmazonLakeFormationMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonLakeFormationClient with the credentials loaded from the application's
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
        public AmazonLakeFormationClient()
            : base(new AmazonLakeFormationConfig()) { }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with the credentials loaded from the application's
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
        public AmazonLakeFormationClient(RegionEndpoint region)
            : base(new AmazonLakeFormationConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLakeFormationClient Configuration Object</param>
        public AmazonLakeFormationClient(AmazonLakeFormationConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLakeFormationClient(AWSCredentials credentials)
            : this(credentials, new AmazonLakeFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLakeFormationClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLakeFormationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Credentials and an
        /// AmazonLakeFormationClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLakeFormationClient Configuration Object</param>
        public AmazonLakeFormationClient(AWSCredentials credentials, AmazonLakeFormationConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLakeFormationClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLakeFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLakeFormationClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLakeFormationConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLakeFormationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLakeFormationClient Configuration Object</param>
        public AmazonLakeFormationClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLakeFormationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLakeFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLakeFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLakeFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLakeFormationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLakeFormationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLakeFormationClient Configuration Object</param>
        public AmazonLakeFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLakeFormationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ILakeFormationPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILakeFormationPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new LakeFormationPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLakeFormationEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLakeFormationAuthSchemeHandler());
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


        #region  AddLFTagsToResource

        internal virtual AddLFTagsToResourceResponse AddLFTagsToResource(AddLFTagsToResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddLFTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddLFTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddLFTagsToResourceResponse>(request, options);
        }



        /// <summary>
        /// Attaches one or more LF-tags to an existing resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddLFTagsToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddLFTagsToResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/AddLFTagsToResource">REST API Reference for AddLFTagsToResource Operation</seealso>
        public virtual Task<AddLFTagsToResourceResponse> AddLFTagsToResourceAsync(AddLFTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddLFTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddLFTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddLFTagsToResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssumeDecoratedRoleWithSAML

        internal virtual AssumeDecoratedRoleWithSAMLResponse AssumeDecoratedRoleWithSAML(AssumeDecoratedRoleWithSAMLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeDecoratedRoleWithSAMLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeDecoratedRoleWithSAMLResponseUnmarshaller.Instance;

            return Invoke<AssumeDecoratedRoleWithSAMLResponse>(request, options);
        }



        /// <summary>
        /// Allows a caller to assume an IAM role decorated as the SAML user specified in the
        /// SAML assertion included in the request. This decoration allows Lake Formation to enforce
        /// access policies against the SAML users and groups. This API operation requires SAML
        /// federation setup in the caller’s account as it can only be called with valid SAML
        /// assertions. Lake Formation does not scope down the permission of the assumed role.
        /// All permissions attached to the role via the SAML federation setup will be included
        /// in the role session. 
        /// 
        ///  
        /// <para>
        ///  This decorated role is expected to access data in Amazon S3 by getting temporary
        /// access from Lake Formation which is authorized via the virtual API <c>GetDataAccess</c>.
        /// Therefore, all SAML roles that can be assumed via <c>AssumeDecoratedRoleWithSAML</c>
        /// must at a minimum include <c>lakeformation:GetDataAccess</c> in their role policies.
        /// A typical IAM policy attached to such a role would look as follows: 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeDecoratedRoleWithSAML service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssumeDecoratedRoleWithSAML service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/AssumeDecoratedRoleWithSAML">REST API Reference for AssumeDecoratedRoleWithSAML Operation</seealso>
        public virtual Task<AssumeDecoratedRoleWithSAMLResponse> AssumeDecoratedRoleWithSAMLAsync(AssumeDecoratedRoleWithSAMLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeDecoratedRoleWithSAMLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeDecoratedRoleWithSAMLResponseUnmarshaller.Instance;

            return InvokeAsync<AssumeDecoratedRoleWithSAMLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGrantPermissions

        internal virtual BatchGrantPermissionsResponse BatchGrantPermissions(BatchGrantPermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGrantPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGrantPermissionsResponseUnmarshaller.Instance;

            return Invoke<BatchGrantPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Batch operation to grant permissions to the principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGrantPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGrantPermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchGrantPermissions">REST API Reference for BatchGrantPermissions Operation</seealso>
        public virtual Task<BatchGrantPermissionsResponse> BatchGrantPermissionsAsync(BatchGrantPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGrantPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGrantPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGrantPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchRevokePermissions

        internal virtual BatchRevokePermissionsResponse BatchRevokePermissions(BatchRevokePermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchRevokePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchRevokePermissionsResponseUnmarshaller.Instance;

            return Invoke<BatchRevokePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Batch operation to revoke permissions from the principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchRevokePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchRevokePermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchRevokePermissions">REST API Reference for BatchRevokePermissions Operation</seealso>
        public virtual Task<BatchRevokePermissionsResponse> BatchRevokePermissionsAsync(BatchRevokePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchRevokePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchRevokePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchRevokePermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelTransaction

        internal virtual CancelTransactionResponse CancelTransaction(CancelTransactionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTransactionResponseUnmarshaller.Instance;

            return Invoke<CancelTransactionResponse>(request, options);
        }



        /// <summary>
        /// Attempts to cancel the specified transaction. Returns an exception if the transaction
        /// was previously committed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTransaction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelTransaction service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommitInProgressException">
        /// Contains details about an error related to a transaction commit that was in progress.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommittedException">
        /// Contains details about an error where the specified transaction has already been committed
        /// and cannot be used for <c>UpdateTableObjects</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CancelTransaction">REST API Reference for CancelTransaction Operation</seealso>
        public virtual Task<CancelTransactionResponse> CancelTransactionAsync(CancelTransactionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTransactionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelTransactionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CommitTransaction

        internal virtual CommitTransactionResponse CommitTransaction(CommitTransactionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CommitTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CommitTransactionResponseUnmarshaller.Instance;

            return Invoke<CommitTransactionResponse>(request, options);
        }



        /// <summary>
        /// Attempts to commit the specified transaction. Returns an exception if the transaction
        /// was previously aborted. This API action is idempotent if called multiple times for
        /// the same transaction.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CommitTransaction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CommitTransaction service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCanceledException">
        /// Contains details about an error related to a transaction that was cancelled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CommitTransaction">REST API Reference for CommitTransaction Operation</seealso>
        public virtual Task<CommitTransactionResponse> CommitTransactionAsync(CommitTransactionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CommitTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CommitTransactionResponseUnmarshaller.Instance;

            return InvokeAsync<CommitTransactionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDataCellsFilter

        internal virtual CreateDataCellsFilterResponse CreateDataCellsFilter(CreateDataCellsFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataCellsFilterResponseUnmarshaller.Instance;

            return Invoke<CreateDataCellsFilterResponse>(request, options);
        }



        /// <summary>
        /// Creates a data cell filter to allow one to grant access to certain columns on certain
        /// rows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataCellsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataCellsFilter service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateDataCellsFilter">REST API Reference for CreateDataCellsFilter Operation</seealso>
        public virtual Task<CreateDataCellsFilterResponse> CreateDataCellsFilterAsync(CreateDataCellsFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataCellsFilterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataCellsFilterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateLakeFormationIdentityCenterConfiguration

        internal virtual CreateLakeFormationIdentityCenterConfigurationResponse CreateLakeFormationIdentityCenterConfiguration(CreateLakeFormationIdentityCenterConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateLakeFormationIdentityCenterConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates an IAM Identity Center connection with Lake Formation to allow IAM Identity
        /// Center users and groups to access Data Catalog resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLakeFormationIdentityCenterConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLakeFormationIdentityCenterConfiguration service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLakeFormationIdentityCenterConfiguration">REST API Reference for CreateLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual Task<CreateLakeFormationIdentityCenterConfigurationResponse> CreateLakeFormationIdentityCenterConfigurationAsync(CreateLakeFormationIdentityCenterConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLakeFormationIdentityCenterConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateLakeFormationOptIn

        internal virtual CreateLakeFormationOptInResponse CreateLakeFormationOptIn(CreateLakeFormationOptInRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLakeFormationOptInRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLakeFormationOptInResponseUnmarshaller.Instance;

            return Invoke<CreateLakeFormationOptInResponse>(request, options);
        }



        /// <summary>
        /// Enforce Lake Formation permissions for the given databases, tables, and principals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLakeFormationOptIn service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLakeFormationOptIn service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLakeFormationOptIn">REST API Reference for CreateLakeFormationOptIn Operation</seealso>
        public virtual Task<CreateLakeFormationOptInResponse> CreateLakeFormationOptInAsync(CreateLakeFormationOptInRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLakeFormationOptInRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLakeFormationOptInResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLakeFormationOptInResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateLFTag

        internal virtual CreateLFTagResponse CreateLFTag(CreateLFTagRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLFTagResponseUnmarshaller.Instance;

            return Invoke<CreateLFTagResponse>(request, options);
        }



        /// <summary>
        /// Creates an LF-tag with the specified name and values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLFTag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLFTag">REST API Reference for CreateLFTag Operation</seealso>
        public virtual Task<CreateLFTagResponse> CreateLFTagAsync(CreateLFTagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLFTagResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLFTagResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateLFTagExpression

        internal virtual CreateLFTagExpressionResponse CreateLFTagExpression(CreateLFTagExpressionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLFTagExpressionResponseUnmarshaller.Instance;

            return Invoke<CreateLFTagExpressionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new LF-Tag expression with the provided name, description, catalog ID, and
        /// expression body. This call fails if a LF-Tag expression with the same name already
        /// exists in the caller’s account or if the underlying LF-Tags don't exist. To call this
        /// API operation, caller needs the following Lake Formation permissions:
        /// 
        ///  
        /// <para>
        ///  <c>CREATE_LF_TAG_EXPRESSION</c> on the root catalog resource.
        /// </para>
        ///  
        /// <para>
        ///  <c>GRANT_WITH_LF_TAG_EXPRESSION</c> on all underlying LF-Tag key:value pairs included
        /// in the expression. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLFTagExpression service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLFTagExpression service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLFTagExpression">REST API Reference for CreateLFTagExpression Operation</seealso>
        public virtual Task<CreateLFTagExpressionResponse> CreateLFTagExpressionAsync(CreateLFTagExpressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLFTagExpressionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLFTagExpressionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDataCellsFilter

        internal virtual DeleteDataCellsFilterResponse DeleteDataCellsFilter(DeleteDataCellsFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataCellsFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteDataCellsFilterResponse>(request, options);
        }



        /// <summary>
        /// Deletes a data cell filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataCellsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataCellsFilter service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteDataCellsFilter">REST API Reference for DeleteDataCellsFilter Operation</seealso>
        public virtual Task<DeleteDataCellsFilterResponse> DeleteDataCellsFilterAsync(DeleteDataCellsFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataCellsFilterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataCellsFilterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteLakeFormationIdentityCenterConfiguration

        internal virtual DeleteLakeFormationIdentityCenterConfigurationResponse DeleteLakeFormationIdentityCenterConfiguration(DeleteLakeFormationIdentityCenterConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLakeFormationIdentityCenterConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an IAM Identity Center connection with Lake Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLakeFormationIdentityCenterConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLakeFormationIdentityCenterConfiguration service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLakeFormationIdentityCenterConfiguration">REST API Reference for DeleteLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual Task<DeleteLakeFormationIdentityCenterConfigurationResponse> DeleteLakeFormationIdentityCenterConfigurationAsync(DeleteLakeFormationIdentityCenterConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLakeFormationIdentityCenterConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteLakeFormationOptIn

        internal virtual DeleteLakeFormationOptInResponse DeleteLakeFormationOptIn(DeleteLakeFormationOptInRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLakeFormationOptInRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLakeFormationOptInResponseUnmarshaller.Instance;

            return Invoke<DeleteLakeFormationOptInResponse>(request, options);
        }



        /// <summary>
        /// Remove the Lake Formation permissions enforcement of the given databases, tables,
        /// and principals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLakeFormationOptIn service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLakeFormationOptIn service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLakeFormationOptIn">REST API Reference for DeleteLakeFormationOptIn Operation</seealso>
        public virtual Task<DeleteLakeFormationOptInResponse> DeleteLakeFormationOptInAsync(DeleteLakeFormationOptInRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLakeFormationOptInRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLakeFormationOptInResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLakeFormationOptInResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteLFTag

        internal virtual DeleteLFTagResponse DeleteLFTag(DeleteLFTagRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLFTagResponseUnmarshaller.Instance;

            return Invoke<DeleteLFTagResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified LF-tag given a key name. If the input parameter tag key was
        /// not found, then the operation will throw an exception. When you delete an LF-tag,
        /// the <c>LFTagPolicy</c> attached to the LF-tag becomes invalid. If the deleted LF-tag
        /// was still assigned to any resource, the tag policy attach to the deleted LF-tag will
        /// no longer be applied to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLFTag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLFTag">REST API Reference for DeleteLFTag Operation</seealso>
        public virtual Task<DeleteLFTagResponse> DeleteLFTagAsync(DeleteLFTagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLFTagResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLFTagResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteLFTagExpression

        internal virtual DeleteLFTagExpressionResponse DeleteLFTagExpression(DeleteLFTagExpressionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLFTagExpressionResponseUnmarshaller.Instance;

            return Invoke<DeleteLFTagExpressionResponse>(request, options);
        }



        /// <summary>
        /// Deletes the LF-Tag expression. The caller must be a data lake admin or have <c>DROP</c>
        /// permissions on the LF-Tag expression. Deleting a LF-Tag expression will also delete
        /// all <c>LFTagPolicy</c> permissions referencing the LF-Tag expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLFTagExpression service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLFTagExpression service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLFTagExpression">REST API Reference for DeleteLFTagExpression Operation</seealso>
        public virtual Task<DeleteLFTagExpressionResponse> DeleteLFTagExpressionAsync(DeleteLFTagExpressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLFTagExpressionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLFTagExpressionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteObjectsOnCancel

        internal virtual DeleteObjectsOnCancelResponse DeleteObjectsOnCancel(DeleteObjectsOnCancelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteObjectsOnCancelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectsOnCancelResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectsOnCancelResponse>(request, options);
        }



        /// <summary>
        /// For a specific governed table, provides a list of Amazon S3 objects that will be written
        /// during the current transaction and that can be automatically deleted if the transaction
        /// is canceled. Without this call, no Amazon S3 objects are automatically deleted when
        /// a transaction cancels. 
        /// 
        ///  
        /// <para>
        ///  The Glue ETL library function <c>write_dynamic_frame.from_catalog()</c> includes
        /// an option to automatically call <c>DeleteObjectsOnCancel</c> before writes. For more
        /// information, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/transactions-data-operations.html#rolling-back-writes">Rolling
        /// Back Amazon S3 Writes</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjectsOnCancel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObjectsOnCancel service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ResourceNotReadyException">
        /// Contains details about an error related to a resource which is not ready for a transaction.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCanceledException">
        /// Contains details about an error related to a transaction that was cancelled.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommittedException">
        /// Contains details about an error where the specified transaction has already been committed
        /// and cannot be used for <c>UpdateTableObjects</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteObjectsOnCancel">REST API Reference for DeleteObjectsOnCancel Operation</seealso>
        public virtual Task<DeleteObjectsOnCancelResponse> DeleteObjectsOnCancelAsync(DeleteObjectsOnCancelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteObjectsOnCancelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectsOnCancelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectsOnCancelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeregisterResource

        internal virtual DeregisterResourceResponse DeregisterResource(DeregisterResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterResourceResponseUnmarshaller.Instance;

            return Invoke<DeregisterResourceResponse>(request, options);
        }



        /// <summary>
        /// Deregisters the resource as managed by the Data Catalog.
        /// 
        ///  
        /// <para>
        /// When you deregister a path, Lake Formation removes the path from the inline policy
        /// attached to your service-linked role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeregisterResource">REST API Reference for DeregisterResource Operation</seealso>
        public virtual Task<DeregisterResourceResponse> DeregisterResourceAsync(DeregisterResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeLakeFormationIdentityCenterConfiguration

        internal virtual DescribeLakeFormationIdentityCenterConfigurationResponse DescribeLakeFormationIdentityCenterConfiguration(DescribeLakeFormationIdentityCenterConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeLakeFormationIdentityCenterConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the instance ARN and application ARN for the connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLakeFormationIdentityCenterConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLakeFormationIdentityCenterConfiguration service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeLakeFormationIdentityCenterConfiguration">REST API Reference for DescribeLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual Task<DescribeLakeFormationIdentityCenterConfigurationResponse> DescribeLakeFormationIdentityCenterConfigurationAsync(DescribeLakeFormationIdentityCenterConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLakeFormationIdentityCenterConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeResource

        internal virtual DescribeResourceResponse DescribeResource(DescribeResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current data access role for the given resource registered in Lake Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        public virtual Task<DescribeResourceResponse> DescribeResourceAsync(DescribeResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTransaction

        internal virtual DescribeTransactionResponse DescribeTransaction(DescribeTransactionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransactionResponseUnmarshaller.Instance;

            return Invoke<DescribeTransactionResponse>(request, options);
        }



        /// <summary>
        /// Returns the details of a single transaction.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransaction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransaction service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeTransaction">REST API Reference for DescribeTransaction Operation</seealso>
        public virtual Task<DescribeTransactionResponse> DescribeTransactionAsync(DescribeTransactionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransactionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTransactionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExtendTransaction

        internal virtual ExtendTransactionResponse ExtendTransaction(ExtendTransactionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExtendTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExtendTransactionResponseUnmarshaller.Instance;

            return Invoke<ExtendTransactionResponse>(request, options);
        }



        /// <summary>
        /// Indicates to the service that the specified transaction is still active and should
        /// not be treated as idle and aborted.
        /// 
        ///  
        /// <para>
        /// Write transactions that remain idle for a long period are automatically aborted unless
        /// explicitly extended.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExtendTransaction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExtendTransaction service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCanceledException">
        /// Contains details about an error related to a transaction that was cancelled.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommitInProgressException">
        /// Contains details about an error related to a transaction commit that was in progress.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommittedException">
        /// Contains details about an error where the specified transaction has already been committed
        /// and cannot be used for <c>UpdateTableObjects</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ExtendTransaction">REST API Reference for ExtendTransaction Operation</seealso>
        public virtual Task<ExtendTransactionResponse> ExtendTransactionAsync(ExtendTransactionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExtendTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExtendTransactionResponseUnmarshaller.Instance;

            return InvokeAsync<ExtendTransactionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDataCellsFilter

        internal virtual GetDataCellsFilterResponse GetDataCellsFilter(GetDataCellsFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataCellsFilterResponseUnmarshaller.Instance;

            return Invoke<GetDataCellsFilterResponse>(request, options);
        }



        /// <summary>
        /// Returns a data cells filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataCellsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataCellsFilter service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataCellsFilter">REST API Reference for GetDataCellsFilter Operation</seealso>
        public virtual Task<GetDataCellsFilterResponse> GetDataCellsFilterAsync(GetDataCellsFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataCellsFilterResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataCellsFilterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDataLakePrincipal

        internal virtual GetDataLakePrincipalResponse GetDataLakePrincipal(GetDataLakePrincipalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataLakePrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakePrincipalResponseUnmarshaller.Instance;

            return Invoke<GetDataLakePrincipalResponse>(request, options);
        }



        /// <summary>
        /// Returns the identity of the invoking principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakePrincipal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataLakePrincipal service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataLakePrincipal">REST API Reference for GetDataLakePrincipal Operation</seealso>
        public virtual Task<GetDataLakePrincipalResponse> GetDataLakePrincipalAsync(GetDataLakePrincipalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataLakePrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakePrincipalResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataLakePrincipalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDataLakeSettings

        internal virtual GetDataLakeSettingsResponse GetDataLakeSettings(GetDataLakeSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataLakeSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeSettingsResponseUnmarshaller.Instance;

            return Invoke<GetDataLakeSettingsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the list of the data lake administrators of a Lake Formation-managed data
        /// lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataLakeSettings service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataLakeSettings">REST API Reference for GetDataLakeSettings Operation</seealso>
        public virtual Task<GetDataLakeSettingsResponse> GetDataLakeSettingsAsync(GetDataLakeSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataLakeSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataLakeSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEffectivePermissionsForPath

        internal virtual GetEffectivePermissionsForPathResponse GetEffectivePermissionsForPath(GetEffectivePermissionsForPathRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEffectivePermissionsForPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEffectivePermissionsForPathResponseUnmarshaller.Instance;

            return Invoke<GetEffectivePermissionsForPathResponse>(request, options);
        }



        /// <summary>
        /// Returns the Lake Formation permissions for a specified table or database resource
        /// located at a path in Amazon S3. <c>GetEffectivePermissionsForPath</c> will not return
        /// databases and tables if the catalog is encrypted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEffectivePermissionsForPath service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEffectivePermissionsForPath service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetEffectivePermissionsForPath">REST API Reference for GetEffectivePermissionsForPath Operation</seealso>
        public virtual Task<GetEffectivePermissionsForPathResponse> GetEffectivePermissionsForPathAsync(GetEffectivePermissionsForPathRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEffectivePermissionsForPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEffectivePermissionsForPathResponseUnmarshaller.Instance;

            return InvokeAsync<GetEffectivePermissionsForPathResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLFTag

        internal virtual GetLFTagResponse GetLFTag(GetLFTagRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLFTagResponseUnmarshaller.Instance;

            return Invoke<GetLFTagResponse>(request, options);
        }



        /// <summary>
        /// Returns an LF-tag definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLFTag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetLFTag">REST API Reference for GetLFTag Operation</seealso>
        public virtual Task<GetLFTagResponse> GetLFTagAsync(GetLFTagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLFTagResponseUnmarshaller.Instance;

            return InvokeAsync<GetLFTagResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLFTagExpression

        internal virtual GetLFTagExpressionResponse GetLFTagExpression(GetLFTagExpressionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLFTagExpressionResponseUnmarshaller.Instance;

            return Invoke<GetLFTagExpressionResponse>(request, options);
        }



        /// <summary>
        /// Returns the details about the LF-Tag expression. The caller must be a data lake admin
        /// or must have <c>DESCRIBE</c> permission on the LF-Tag expression resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLFTagExpression service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLFTagExpression service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetLFTagExpression">REST API Reference for GetLFTagExpression Operation</seealso>
        public virtual Task<GetLFTagExpressionResponse> GetLFTagExpressionAsync(GetLFTagExpressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLFTagExpressionResponseUnmarshaller.Instance;

            return InvokeAsync<GetLFTagExpressionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetQueryState

        internal virtual GetQueryStateResponse GetQueryState(GetQueryStateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStateResponseUnmarshaller.Instance;

            return Invoke<GetQueryStateResponse>(request, options);
        }



        /// <summary>
        /// Returns the state of a query previously submitted. Clients are expected to poll <c>GetQueryState</c>
        /// to monitor the current state of the planning before retrieving the work units. A query
        /// state is only visible to the principal that made the initial call to <c>StartQueryPlanning</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryState service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetQueryState">REST API Reference for GetQueryState Operation</seealso>
        public virtual Task<GetQueryStateResponse> GetQueryStateAsync(GetQueryStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStateResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryStateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetQueryStatistics

        internal virtual GetQueryStatisticsResponse GetQueryStatistics(GetQueryStatisticsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetQueryStatisticsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves statistics on the planning and execution of a query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryStatistics service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ExpiredException">
        /// Contains details about an error where the query request expired.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.StatisticsNotReadyYetException">
        /// Contains details about an error related to statistics not being ready.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ThrottledException">
        /// Contains details about an error where the query request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetQueryStatistics">REST API Reference for GetQueryStatistics Operation</seealso>
        public virtual Task<GetQueryStatisticsResponse> GetQueryStatisticsAsync(GetQueryStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatisticsResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryStatisticsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourceLFTags

        internal virtual GetResourceLFTagsResponse GetResourceLFTags(GetResourceLFTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceLFTagsResponseUnmarshaller.Instance;

            return Invoke<GetResourceLFTagsResponse>(request, options);
        }



        /// <summary>
        /// Returns the LF-tags applied to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceLFTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetResourceLFTags">REST API Reference for GetResourceLFTags Operation</seealso>
        public virtual Task<GetResourceLFTagsResponse> GetResourceLFTagsAsync(GetResourceLFTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceLFTagsResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceLFTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTableObjects

        internal virtual GetTableObjectsResponse GetTableObjects(GetTableObjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableObjectsResponseUnmarshaller.Instance;

            return Invoke<GetTableObjectsResponse>(request, options);
        }



        /// <summary>
        /// Returns the set of Amazon S3 objects that make up the specified governed table. A
        /// transaction ID or timestamp can be specified for time-travel queries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableObjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableObjects service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ResourceNotReadyException">
        /// Contains details about an error related to a resource which is not ready for a transaction.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCanceledException">
        /// Contains details about an error related to a transaction that was cancelled.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommittedException">
        /// Contains details about an error where the specified transaction has already been committed
        /// and cannot be used for <c>UpdateTableObjects</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTableObjects">REST API Reference for GetTableObjects Operation</seealso>
        public virtual Task<GetTableObjectsResponse> GetTableObjectsAsync(GetTableObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableObjectsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTemporaryGluePartitionCredentials

        internal virtual GetTemporaryGluePartitionCredentialsResponse GetTemporaryGluePartitionCredentials(GetTemporaryGluePartitionCredentialsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemporaryGluePartitionCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemporaryGluePartitionCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetTemporaryGluePartitionCredentialsResponse>(request, options);
        }



        /// <summary>
        /// This API is identical to <c>GetTemporaryTableCredentials</c> except that this is used
        /// when the target Data Catalog resource is of type Partition. Lake Formation restricts
        /// the permission of the vended credentials with the same scope down policy which restricts
        /// access to a single Amazon S3 prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemporaryGluePartitionCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemporaryGluePartitionCredentials service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.PermissionTypeMismatchException">
        /// The engine does not support filtering data based on the enforced permissions. For
        /// example, if you call the <c>GetTemporaryGlueTableCredentials</c> operation with <c>SupportedPermissionType</c>
        /// equal to <c>ColumnPermission</c>, but cell-level permissions exist on the table, this
        /// exception is thrown.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTemporaryGluePartitionCredentials">REST API Reference for GetTemporaryGluePartitionCredentials Operation</seealso>
        public virtual Task<GetTemporaryGluePartitionCredentialsResponse> GetTemporaryGluePartitionCredentialsAsync(GetTemporaryGluePartitionCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemporaryGluePartitionCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemporaryGluePartitionCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemporaryGluePartitionCredentialsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTemporaryGlueTableCredentials

        internal virtual GetTemporaryGlueTableCredentialsResponse GetTemporaryGlueTableCredentials(GetTemporaryGlueTableCredentialsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemporaryGlueTableCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemporaryGlueTableCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetTemporaryGlueTableCredentialsResponse>(request, options);
        }



        /// <summary>
        /// Allows a caller in a secure environment to assume a role with permission to access
        /// Amazon S3. In order to vend such credentials, Lake Formation assumes the role associated
        /// with a registered location, for example an Amazon S3 bucket, with a scope down policy
        /// which restricts the access to a single prefix.
        /// 
        ///  
        /// <para>
        /// To call this API, the role that the service assumes must have <c>lakeformation:GetDataAccess</c>
        /// permission on the resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemporaryGlueTableCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemporaryGlueTableCredentials service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.PermissionTypeMismatchException">
        /// The engine does not support filtering data based on the enforced permissions. For
        /// example, if you call the <c>GetTemporaryGlueTableCredentials</c> operation with <c>SupportedPermissionType</c>
        /// equal to <c>ColumnPermission</c>, but cell-level permissions exist on the table, this
        /// exception is thrown.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTemporaryGlueTableCredentials">REST API Reference for GetTemporaryGlueTableCredentials Operation</seealso>
        public virtual Task<GetTemporaryGlueTableCredentialsResponse> GetTemporaryGlueTableCredentialsAsync(GetTemporaryGlueTableCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemporaryGlueTableCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemporaryGlueTableCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemporaryGlueTableCredentialsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkUnitResults

        internal virtual GetWorkUnitResultsResponse GetWorkUnitResults(GetWorkUnitResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkUnitResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkUnitResultsResponseUnmarshaller.Instance;

            return Invoke<GetWorkUnitResultsResponse>(request, options);
        }



        /// <summary>
        /// Returns the work units resulting from the query. Work units can be executed in any
        /// order and in parallel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkUnitResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkUnitResults service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ExpiredException">
        /// Contains details about an error where the query request expired.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ThrottledException">
        /// Contains details about an error where the query request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetWorkUnitResults">REST API Reference for GetWorkUnitResults Operation</seealso>
        public virtual Task<GetWorkUnitResultsResponse> GetWorkUnitResultsAsync(GetWorkUnitResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkUnitResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkUnitResultsResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkUnitResultsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkUnits

        internal virtual GetWorkUnitsResponse GetWorkUnits(GetWorkUnitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkUnitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkUnitsResponseUnmarshaller.Instance;

            return Invoke<GetWorkUnitsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the work units generated by the <c>StartQueryPlanning</c> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkUnits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkUnits service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ExpiredException">
        /// Contains details about an error where the query request expired.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.WorkUnitsNotReadyYetException">
        /// Contains details about an error related to work units not being ready.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetWorkUnits">REST API Reference for GetWorkUnits Operation</seealso>
        public virtual Task<GetWorkUnitsResponse> GetWorkUnitsAsync(GetWorkUnitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkUnitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkUnitsResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkUnitsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GrantPermissions

        internal virtual GrantPermissionsResponse GrantPermissions(GrantPermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GrantPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GrantPermissionsResponseUnmarshaller.Instance;

            return Invoke<GrantPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Grants permissions to the principal to access metadata in the Data Catalog and data
        /// organized in underlying data storage such as Amazon S3.
        /// 
        ///  
        /// <para>
        /// For information about permissions, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/security-data-access.html">Security
        /// and Access Control to Metadata and Data</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GrantPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GrantPermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GrantPermissions">REST API Reference for GrantPermissions Operation</seealso>
        public virtual Task<GrantPermissionsResponse> GrantPermissionsAsync(GrantPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GrantPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GrantPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<GrantPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDataCellsFilter

        internal virtual ListDataCellsFilterResponse ListDataCellsFilter(ListDataCellsFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataCellsFilterResponseUnmarshaller.Instance;

            return Invoke<ListDataCellsFilterResponse>(request, options);
        }



        /// <summary>
        /// Lists all the data cell filters on a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataCellsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataCellsFilter service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListDataCellsFilter">REST API Reference for ListDataCellsFilter Operation</seealso>
        public virtual Task<ListDataCellsFilterResponse> ListDataCellsFilterAsync(ListDataCellsFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataCellsFilterResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataCellsFilterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLakeFormationOptIns

        internal virtual ListLakeFormationOptInsResponse ListLakeFormationOptIns(ListLakeFormationOptInsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLakeFormationOptInsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLakeFormationOptInsResponseUnmarshaller.Instance;

            return Invoke<ListLakeFormationOptInsResponse>(request, options);
        }



        /// <summary>
        /// Retrieve the current list of resources and principals that are opt in to enforce Lake
        /// Formation permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLakeFormationOptIns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLakeFormationOptIns service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLakeFormationOptIns">REST API Reference for ListLakeFormationOptIns Operation</seealso>
        public virtual Task<ListLakeFormationOptInsResponse> ListLakeFormationOptInsAsync(ListLakeFormationOptInsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLakeFormationOptInsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLakeFormationOptInsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLakeFormationOptInsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLFTagExpressions

        internal virtual ListLFTagExpressionsResponse ListLFTagExpressions(ListLFTagExpressionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLFTagExpressionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLFTagExpressionsResponseUnmarshaller.Instance;

            return Invoke<ListLFTagExpressionsResponse>(request, options);
        }



        /// <summary>
        /// Returns the LF-Tag expressions in caller’s account filtered based on caller's permissions.
        /// Data Lake and read only admins implicitly can see all tag expressions in their account,
        /// else caller needs DESCRIBE permissions on tag expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLFTagExpressions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLFTagExpressions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLFTagExpressions">REST API Reference for ListLFTagExpressions Operation</seealso>
        public virtual Task<ListLFTagExpressionsResponse> ListLFTagExpressionsAsync(ListLFTagExpressionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLFTagExpressionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLFTagExpressionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLFTagExpressionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLFTags

        internal virtual ListLFTagsResponse ListLFTags(ListLFTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLFTagsResponseUnmarshaller.Instance;

            return Invoke<ListLFTagsResponse>(request, options);
        }



        /// <summary>
        /// Lists LF-tags that the requester has permission to view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLFTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLFTags">REST API Reference for ListLFTags Operation</seealso>
        public virtual Task<ListLFTagsResponse> ListLFTagsAsync(ListLFTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLFTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLFTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPermissions

        internal virtual ListPermissionsResponse ListPermissions(ListPermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionsResponseUnmarshaller.Instance;

            return Invoke<ListPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the principal permissions on the resource, filtered by the permissions
        /// of the caller. For example, if you are granted an ALTER permission, you are able to
        /// see only the principal permissions for ALTER.
        /// 
        ///  
        /// <para>
        /// This operation returns only those permissions that have been explicitly granted.
        /// </para>
        ///  
        /// <para>
        /// For information about permissions, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/security-data-access.html">Security
        /// and Access Control to Metadata and Data</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        public virtual Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResources

        internal virtual ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return Invoke<ListResourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists the resources registered to be managed by the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTableStorageOptimizers

        internal virtual ListTableStorageOptimizersResponse ListTableStorageOptimizers(ListTableStorageOptimizersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTableStorageOptimizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableStorageOptimizersResponseUnmarshaller.Instance;

            return Invoke<ListTableStorageOptimizersResponse>(request, options);
        }



        /// <summary>
        /// Returns the configuration of all storage optimizers associated with a specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableStorageOptimizers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTableStorageOptimizers service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListTableStorageOptimizers">REST API Reference for ListTableStorageOptimizers Operation</seealso>
        public virtual Task<ListTableStorageOptimizersResponse> ListTableStorageOptimizersAsync(ListTableStorageOptimizersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTableStorageOptimizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableStorageOptimizersResponseUnmarshaller.Instance;

            return InvokeAsync<ListTableStorageOptimizersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTransactions

        internal virtual ListTransactionsResponse ListTransactions(ListTransactionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTransactionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTransactionsResponseUnmarshaller.Instance;

            return Invoke<ListTransactionsResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata about transactions and their status. To prevent the response from
        /// growing indefinitely, only uncommitted transactions and those available for time-travel
        /// queries are returned.
        /// 
        ///  
        /// <para>
        /// This operation can help you identify uncommitted transactions or to get information
        /// about transactions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransactions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTransactions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListTransactions">REST API Reference for ListTransactions Operation</seealso>
        public virtual Task<ListTransactionsResponse> ListTransactionsAsync(ListTransactionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTransactionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTransactionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTransactionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutDataLakeSettings

        internal virtual PutDataLakeSettingsResponse PutDataLakeSettings(PutDataLakeSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDataLakeSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDataLakeSettingsResponseUnmarshaller.Instance;

            return Invoke<PutDataLakeSettingsResponse>(request, options);
        }



        /// <summary>
        /// Sets the list of data lake administrators who have admin privileges on all resources
        /// managed by Lake Formation. For more information on admin privileges, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/lake-formation-permissions.html">Granting
        /// Lake Formation Permissions</a>.
        /// 
        ///  
        /// <para>
        /// This API replaces the current list of data lake admins with the new list being passed.
        /// To add an admin, fetch the current list and add the new admin to that list and pass
        /// that list in this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDataLakeSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDataLakeSettings service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/PutDataLakeSettings">REST API Reference for PutDataLakeSettings Operation</seealso>
        public virtual Task<PutDataLakeSettingsResponse> PutDataLakeSettingsAsync(PutDataLakeSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDataLakeSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDataLakeSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<PutDataLakeSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RegisterResource

        internal virtual RegisterResourceResponse RegisterResource(RegisterResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterResourceResponseUnmarshaller.Instance;

            return Invoke<RegisterResourceResponse>(request, options);
        }



        /// <summary>
        /// Registers the resource as managed by the Data Catalog.
        /// 
        ///  
        /// <para>
        /// To add or update data, Lake Formation needs read/write access to the chosen data location.
        /// Choose a role that you know has permission to do this, or choose the AWSServiceRoleForLakeFormationDataAccess
        /// service-linked role. When you register the first Amazon S3 path, the service-linked
        /// role and a new inline policy are created on your behalf. Lake Formation adds the first
        /// path to the inline policy and attaches it to the service-linked role. When you register
        /// subsequent paths, Lake Formation adds the path to the existing policy.
        /// </para>
        ///  
        /// <para>
        /// The following request registers a new location and gives Lake Formation permission
        /// to use the service-linked role to access that location.
        /// </para>
        ///  
        /// <para>
        ///  <c>ResourceArn = arn:aws:s3:::my-bucket/ UseServiceLinkedRole = true</c> 
        /// </para>
        ///  
        /// <para>
        /// If <c>UseServiceLinkedRole</c> is not set to true, you must provide or set the <c>RoleArn</c>:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:iam::12345:role/my-data-access-role</c> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RegisterResource">REST API Reference for RegisterResource Operation</seealso>
        public virtual Task<RegisterResourceResponse> RegisterResourceAsync(RegisterResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveLFTagsFromResource

        internal virtual RemoveLFTagsFromResourceResponse RemoveLFTagsFromResource(RemoveLFTagsFromResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveLFTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveLFTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveLFTagsFromResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes an LF-tag from the resource. Only database, table, or tableWithColumns resource
        /// are allowed. To tag columns, use the column inclusion list in <c>tableWithColumns</c>
        /// to specify column input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveLFTagsFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveLFTagsFromResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RemoveLFTagsFromResource">REST API Reference for RemoveLFTagsFromResource Operation</seealso>
        public virtual Task<RemoveLFTagsFromResourceResponse> RemoveLFTagsFromResourceAsync(RemoveLFTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveLFTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveLFTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveLFTagsFromResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RevokePermissions

        internal virtual RevokePermissionsResponse RevokePermissions(RevokePermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokePermissionsResponseUnmarshaller.Instance;

            return Invoke<RevokePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Revokes permissions to the principal to access metadata in the Data Catalog and data
        /// organized in underlying data storage such as Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokePermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RevokePermissions">REST API Reference for RevokePermissions Operation</seealso>
        public virtual Task<RevokePermissionsResponse> RevokePermissionsAsync(RevokePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<RevokePermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchDatabasesByLFTags

        internal virtual SearchDatabasesByLFTagsResponse SearchDatabasesByLFTags(SearchDatabasesByLFTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchDatabasesByLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDatabasesByLFTagsResponseUnmarshaller.Instance;

            return Invoke<SearchDatabasesByLFTagsResponse>(request, options);
        }



        /// <summary>
        /// This operation allows a search on <c>DATABASE</c> resources by <c>TagCondition</c>.
        /// This operation is used by admins who want to grant user permissions on certain <c>TagConditions</c>.
        /// Before making a grant, the admin can use <c>SearchDatabasesByTags</c> to find all
        /// resources where the given <c>TagConditions</c> are valid to verify whether the returned
        /// resources can be shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDatabasesByLFTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchDatabasesByLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/SearchDatabasesByLFTags">REST API Reference for SearchDatabasesByLFTags Operation</seealso>
        public virtual Task<SearchDatabasesByLFTagsResponse> SearchDatabasesByLFTagsAsync(SearchDatabasesByLFTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchDatabasesByLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDatabasesByLFTagsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchDatabasesByLFTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchTablesByLFTags

        internal virtual SearchTablesByLFTagsResponse SearchTablesByLFTags(SearchTablesByLFTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchTablesByLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTablesByLFTagsResponseUnmarshaller.Instance;

            return Invoke<SearchTablesByLFTagsResponse>(request, options);
        }



        /// <summary>
        /// This operation allows a search on <c>TABLE</c> resources by <c>LFTag</c>s. This will
        /// be used by admins who want to grant user permissions on certain LF-tags. Before making
        /// a grant, the admin can use <c>SearchTablesByLFTags</c> to find all resources where
        /// the given <c>LFTag</c>s are valid to verify whether the returned resources can be
        /// shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTablesByLFTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchTablesByLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/SearchTablesByLFTags">REST API Reference for SearchTablesByLFTags Operation</seealso>
        public virtual Task<SearchTablesByLFTagsResponse> SearchTablesByLFTagsAsync(SearchTablesByLFTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchTablesByLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTablesByLFTagsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchTablesByLFTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartQueryPlanning

        internal virtual StartQueryPlanningResponse StartQueryPlanning(StartQueryPlanningRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryPlanningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryPlanningResponseUnmarshaller.Instance;

            return Invoke<StartQueryPlanningResponse>(request, options);
        }



        /// <summary>
        /// Submits a request to process a query statement.
        /// 
        ///  
        /// <para>
        /// This operation generates work units that can be retrieved with the <c>GetWorkUnits</c>
        /// operation as soon as the query state is WORKUNITS_AVAILABLE or FINISHED.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQueryPlanning service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartQueryPlanning service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ThrottledException">
        /// Contains details about an error where the query request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/StartQueryPlanning">REST API Reference for StartQueryPlanning Operation</seealso>
        public virtual Task<StartQueryPlanningResponse> StartQueryPlanningAsync(StartQueryPlanningRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryPlanningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryPlanningResponseUnmarshaller.Instance;

            return InvokeAsync<StartQueryPlanningResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartTransaction

        internal virtual StartTransactionResponse StartTransaction(StartTransactionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTransactionResponseUnmarshaller.Instance;

            return Invoke<StartTransactionResponse>(request, options);
        }



        /// <summary>
        /// Starts a new transaction and returns its transaction ID. Transaction IDs are opaque
        /// objects that you can use to identify a transaction.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTransaction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTransaction service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/StartTransaction">REST API Reference for StartTransaction Operation</seealso>
        public virtual Task<StartTransactionResponse> StartTransactionAsync(StartTransactionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTransactionResponseUnmarshaller.Instance;

            return InvokeAsync<StartTransactionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDataCellsFilter

        internal virtual UpdateDataCellsFilterResponse UpdateDataCellsFilter(UpdateDataCellsFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataCellsFilterResponseUnmarshaller.Instance;

            return Invoke<UpdateDataCellsFilterResponse>(request, options);
        }



        /// <summary>
        /// Updates a data cell filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataCellsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataCellsFilter service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateDataCellsFilter">REST API Reference for UpdateDataCellsFilter Operation</seealso>
        public virtual Task<UpdateDataCellsFilterResponse> UpdateDataCellsFilterAsync(UpdateDataCellsFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataCellsFilterResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataCellsFilterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateLakeFormationIdentityCenterConfiguration

        internal virtual UpdateLakeFormationIdentityCenterConfigurationResponse UpdateLakeFormationIdentityCenterConfiguration(UpdateLakeFormationIdentityCenterConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateLakeFormationIdentityCenterConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the IAM Identity Center connection parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLakeFormationIdentityCenterConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLakeFormationIdentityCenterConfiguration service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLakeFormationIdentityCenterConfiguration">REST API Reference for UpdateLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual Task<UpdateLakeFormationIdentityCenterConfigurationResponse> UpdateLakeFormationIdentityCenterConfigurationAsync(UpdateLakeFormationIdentityCenterConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLakeFormationIdentityCenterConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateLFTag

        internal virtual UpdateLFTagResponse UpdateLFTag(UpdateLFTagRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLFTagResponseUnmarshaller.Instance;

            return Invoke<UpdateLFTagResponse>(request, options);
        }



        /// <summary>
        /// Updates the list of possible values for the specified LF-tag key. If the LF-tag does
        /// not exist, the operation throws an EntityNotFoundException. The values in the delete
        /// key values will be deleted from list of possible values. If any value in the delete
        /// key values is attached to a resource, then API errors out with a 400 Exception - "Update
        /// not allowed". Untag the attribute before deleting the LF-tag key's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLFTag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLFTag">REST API Reference for UpdateLFTag Operation</seealso>
        public virtual Task<UpdateLFTagResponse> UpdateLFTagAsync(UpdateLFTagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLFTagResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLFTagResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateLFTagExpression

        internal virtual UpdateLFTagExpressionResponse UpdateLFTagExpression(UpdateLFTagExpressionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLFTagExpressionResponseUnmarshaller.Instance;

            return Invoke<UpdateLFTagExpressionResponse>(request, options);
        }



        /// <summary>
        /// Updates the name of the LF-Tag expression to the new description and expression body
        /// provided. Updating a LF-Tag expression immediately changes the permission boundaries
        /// of all existing <c>LFTagPolicy</c> permission grants that reference the given LF-Tag
        /// expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLFTagExpression service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLFTagExpression service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLFTagExpression">REST API Reference for UpdateLFTagExpression Operation</seealso>
        public virtual Task<UpdateLFTagExpressionResponse> UpdateLFTagExpressionAsync(UpdateLFTagExpressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLFTagExpressionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLFTagExpressionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateResource

        internal virtual UpdateResourceResponse UpdateResource(UpdateResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceResponse>(request, options);
        }



        /// <summary>
        /// Updates the data access role used for vending access to the given (registered) resource
        /// in Lake Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        public virtual Task<UpdateResourceResponse> UpdateResourceAsync(UpdateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTableObjects

        internal virtual UpdateTableObjectsResponse UpdateTableObjects(UpdateTableObjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTableObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableObjectsResponseUnmarshaller.Instance;

            return Invoke<UpdateTableObjectsResponse>(request, options);
        }



        /// <summary>
        /// Updates the manifest of Amazon S3 objects that make up the specified governed table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableObjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTableObjects service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ResourceNotReadyException">
        /// Contains details about an error related to a resource which is not ready for a transaction.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCanceledException">
        /// Contains details about an error related to a transaction that was cancelled.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommitInProgressException">
        /// Contains details about an error related to a transaction commit that was in progress.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommittedException">
        /// Contains details about an error where the specified transaction has already been committed
        /// and cannot be used for <c>UpdateTableObjects</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateTableObjects">REST API Reference for UpdateTableObjects Operation</seealso>
        public virtual Task<UpdateTableObjectsResponse> UpdateTableObjectsAsync(UpdateTableObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTableObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTableObjectsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTableStorageOptimizer

        internal virtual UpdateTableStorageOptimizerResponse UpdateTableStorageOptimizer(UpdateTableStorageOptimizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTableStorageOptimizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableStorageOptimizerResponseUnmarshaller.Instance;

            return Invoke<UpdateTableStorageOptimizerResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of the storage optimizers for a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableStorageOptimizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTableStorageOptimizer service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateTableStorageOptimizer">REST API Reference for UpdateTableStorageOptimizer Operation</seealso>
        public virtual Task<UpdateTableStorageOptimizerResponse> UpdateTableStorageOptimizerAsync(UpdateTableStorageOptimizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTableStorageOptimizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableStorageOptimizerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTableStorageOptimizerResponse>(request, options, cancellationToken);
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