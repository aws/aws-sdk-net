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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LakeFormation.Model;

#pragma warning disable CS1570
namespace Amazon.LakeFormation
{
    /// <summary>
    /// <para>Interface for accessing LakeFormation</para>
    ///
    /// Lake Formation 
    /// <para>
    /// Defines the public endpoint for the Lake Formation service.
    /// </para>
    /// </summary>
    public partial interface IAmazonLakeFormation : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILakeFormationPaginatorFactory Paginators { get; }

        
        #region  AddLFTagsToResource


        /// <summary>
        /// Attaches one or more LF-tags to an existing resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddLFTagsToResource service method.</param>
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
        AddLFTagsToResourceResponse AddLFTagsToResource(AddLFTagsToResourceRequest request);



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
        Task<AddLFTagsToResourceResponse> AddLFTagsToResourceAsync(AddLFTagsToResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssumeDecoratedRoleWithSAML


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
        AssumeDecoratedRoleWithSAMLResponse AssumeDecoratedRoleWithSAML(AssumeDecoratedRoleWithSAMLRequest request);



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
        Task<AssumeDecoratedRoleWithSAMLResponse> AssumeDecoratedRoleWithSAMLAsync(AssumeDecoratedRoleWithSAMLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGrantPermissions


        /// <summary>
        /// Batch operation to grant permissions to the principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGrantPermissions service method.</param>
        /// 
        /// <returns>The response from the BatchGrantPermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchGrantPermissions">REST API Reference for BatchGrantPermissions Operation</seealso>
        BatchGrantPermissionsResponse BatchGrantPermissions(BatchGrantPermissionsRequest request);



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
        Task<BatchGrantPermissionsResponse> BatchGrantPermissionsAsync(BatchGrantPermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchRevokePermissions


        /// <summary>
        /// Batch operation to revoke permissions from the principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchRevokePermissions service method.</param>
        /// 
        /// <returns>The response from the BatchRevokePermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchRevokePermissions">REST API Reference for BatchRevokePermissions Operation</seealso>
        BatchRevokePermissionsResponse BatchRevokePermissions(BatchRevokePermissionsRequest request);



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
        Task<BatchRevokePermissionsResponse> BatchRevokePermissionsAsync(BatchRevokePermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelTransaction


        /// <summary>
        /// Attempts to cancel the specified transaction. Returns an exception if the transaction
        /// was previously committed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTransaction service method.</param>
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
        CancelTransactionResponse CancelTransaction(CancelTransactionRequest request);



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
        Task<CancelTransactionResponse> CancelTransactionAsync(CancelTransactionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CommitTransaction


        /// <summary>
        /// Attempts to commit the specified transaction. Returns an exception if the transaction
        /// was previously aborted. This API action is idempotent if called multiple times for
        /// the same transaction.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CommitTransaction service method.</param>
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
        CommitTransactionResponse CommitTransaction(CommitTransactionRequest request);



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
        Task<CommitTransactionResponse> CommitTransactionAsync(CommitTransactionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDataCellsFilter


        /// <summary>
        /// Creates a data cell filter to allow one to grant access to certain columns on certain
        /// rows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataCellsFilter service method.</param>
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
        CreateDataCellsFilterResponse CreateDataCellsFilter(CreateDataCellsFilterRequest request);



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
        Task<CreateDataCellsFilterResponse> CreateDataCellsFilterAsync(CreateDataCellsFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLakeFormationIdentityCenterConfiguration


        /// <summary>
        /// Creates an IAM Identity Center connection with Lake Formation to allow IAM Identity
        /// Center users and groups to access Data Catalog resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLakeFormationIdentityCenterConfiguration service method.</param>
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
        CreateLakeFormationIdentityCenterConfigurationResponse CreateLakeFormationIdentityCenterConfiguration(CreateLakeFormationIdentityCenterConfigurationRequest request);



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
        Task<CreateLakeFormationIdentityCenterConfigurationResponse> CreateLakeFormationIdentityCenterConfigurationAsync(CreateLakeFormationIdentityCenterConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLakeFormationOptIn


        /// <summary>
        /// Enforce Lake Formation permissions for the given databases, tables, and principals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLakeFormationOptIn service method.</param>
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
        CreateLakeFormationOptInResponse CreateLakeFormationOptIn(CreateLakeFormationOptInRequest request);



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
        Task<CreateLakeFormationOptInResponse> CreateLakeFormationOptInAsync(CreateLakeFormationOptInRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLFTag


        /// <summary>
        /// Creates an LF-tag with the specified name and values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLFTag service method.</param>
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
        CreateLFTagResponse CreateLFTag(CreateLFTagRequest request);



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
        Task<CreateLFTagResponse> CreateLFTagAsync(CreateLFTagRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLFTagExpression


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
        CreateLFTagExpressionResponse CreateLFTagExpression(CreateLFTagExpressionRequest request);



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
        Task<CreateLFTagExpressionResponse> CreateLFTagExpressionAsync(CreateLFTagExpressionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDataCellsFilter


        /// <summary>
        /// Deletes a data cell filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataCellsFilter service method.</param>
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
        DeleteDataCellsFilterResponse DeleteDataCellsFilter(DeleteDataCellsFilterRequest request);



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
        Task<DeleteDataCellsFilterResponse> DeleteDataCellsFilterAsync(DeleteDataCellsFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLakeFormationIdentityCenterConfiguration


        /// <summary>
        /// Deletes an IAM Identity Center connection with Lake Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLakeFormationIdentityCenterConfiguration service method.</param>
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
        DeleteLakeFormationIdentityCenterConfigurationResponse DeleteLakeFormationIdentityCenterConfiguration(DeleteLakeFormationIdentityCenterConfigurationRequest request);



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
        Task<DeleteLakeFormationIdentityCenterConfigurationResponse> DeleteLakeFormationIdentityCenterConfigurationAsync(DeleteLakeFormationIdentityCenterConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLakeFormationOptIn


        /// <summary>
        /// Remove the Lake Formation permissions enforcement of the given databases, tables,
        /// and principals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLakeFormationOptIn service method.</param>
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
        DeleteLakeFormationOptInResponse DeleteLakeFormationOptIn(DeleteLakeFormationOptInRequest request);



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
        Task<DeleteLakeFormationOptInResponse> DeleteLakeFormationOptInAsync(DeleteLakeFormationOptInRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLFTag


        /// <summary>
        /// Deletes the specified LF-tag given a key name. If the input parameter tag key was
        /// not found, then the operation will throw an exception. When you delete an LF-tag,
        /// the <c>LFTagPolicy</c> attached to the LF-tag becomes invalid. If the deleted LF-tag
        /// was still assigned to any resource, the tag policy attach to the deleted LF-tag will
        /// no longer be applied to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLFTag service method.</param>
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
        DeleteLFTagResponse DeleteLFTag(DeleteLFTagRequest request);



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
        Task<DeleteLFTagResponse> DeleteLFTagAsync(DeleteLFTagRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLFTagExpression


        /// <summary>
        /// Deletes the LF-Tag expression. The caller must be a data lake admin or have <c>DROP</c>
        /// permissions on the LF-Tag expression. Deleting a LF-Tag expression will also delete
        /// all <c>LFTagPolicy</c> permissions referencing the LF-Tag expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLFTagExpression service method.</param>
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
        DeleteLFTagExpressionResponse DeleteLFTagExpression(DeleteLFTagExpressionRequest request);



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
        Task<DeleteLFTagExpressionResponse> DeleteLFTagExpressionAsync(DeleteLFTagExpressionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteObjectsOnCancel


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
        DeleteObjectsOnCancelResponse DeleteObjectsOnCancel(DeleteObjectsOnCancelRequest request);



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
        Task<DeleteObjectsOnCancelResponse> DeleteObjectsOnCancelAsync(DeleteObjectsOnCancelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterResource


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
        DeregisterResourceResponse DeregisterResource(DeregisterResourceRequest request);



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
        Task<DeregisterResourceResponse> DeregisterResourceAsync(DeregisterResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLakeFormationIdentityCenterConfiguration


        /// <summary>
        /// Retrieves the instance ARN and application ARN for the connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLakeFormationIdentityCenterConfiguration service method.</param>
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
        DescribeLakeFormationIdentityCenterConfigurationResponse DescribeLakeFormationIdentityCenterConfiguration(DescribeLakeFormationIdentityCenterConfigurationRequest request);



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
        Task<DescribeLakeFormationIdentityCenterConfigurationResponse> DescribeLakeFormationIdentityCenterConfigurationAsync(DescribeLakeFormationIdentityCenterConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeResource


        /// <summary>
        /// Retrieves the current data access role for the given resource registered in Lake Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource service method.</param>
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
        DescribeResourceResponse DescribeResource(DescribeResourceRequest request);



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
        Task<DescribeResourceResponse> DescribeResourceAsync(DescribeResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTransaction


        /// <summary>
        /// Returns the details of a single transaction.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransaction service method.</param>
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
        DescribeTransactionResponse DescribeTransaction(DescribeTransactionRequest request);



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
        Task<DescribeTransactionResponse> DescribeTransactionAsync(DescribeTransactionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExtendTransaction


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
        ExtendTransactionResponse ExtendTransaction(ExtendTransactionRequest request);



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
        Task<ExtendTransactionResponse> ExtendTransactionAsync(ExtendTransactionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDataCellsFilter


        /// <summary>
        /// Returns a data cells filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataCellsFilter service method.</param>
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
        GetDataCellsFilterResponse GetDataCellsFilter(GetDataCellsFilterRequest request);



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
        Task<GetDataCellsFilterResponse> GetDataCellsFilterAsync(GetDataCellsFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDataLakePrincipal


        /// <summary>
        /// Returns the identity of the invoking principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakePrincipal service method.</param>
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
        GetDataLakePrincipalResponse GetDataLakePrincipal(GetDataLakePrincipalRequest request);



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
        Task<GetDataLakePrincipalResponse> GetDataLakePrincipalAsync(GetDataLakePrincipalRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDataLakeSettings


        /// <summary>
        /// Retrieves the list of the data lake administrators of a Lake Formation-managed data
        /// lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeSettings service method.</param>
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
        GetDataLakeSettingsResponse GetDataLakeSettings(GetDataLakeSettingsRequest request);



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
        Task<GetDataLakeSettingsResponse> GetDataLakeSettingsAsync(GetDataLakeSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEffectivePermissionsForPath


        /// <summary>
        /// Returns the Lake Formation permissions for a specified table or database resource
        /// located at a path in Amazon S3. <c>GetEffectivePermissionsForPath</c> will not return
        /// databases and tables if the catalog is encrypted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEffectivePermissionsForPath service method.</param>
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
        GetEffectivePermissionsForPathResponse GetEffectivePermissionsForPath(GetEffectivePermissionsForPathRequest request);



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
        Task<GetEffectivePermissionsForPathResponse> GetEffectivePermissionsForPathAsync(GetEffectivePermissionsForPathRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLFTag


        /// <summary>
        /// Returns an LF-tag definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLFTag service method.</param>
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
        GetLFTagResponse GetLFTag(GetLFTagRequest request);



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
        Task<GetLFTagResponse> GetLFTagAsync(GetLFTagRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLFTagExpression


        /// <summary>
        /// Returns the details about the LF-Tag expression. The caller must be a data lake admin
        /// or must have <c>DESCRIBE</c> permission on the LF-Tag expression resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLFTagExpression service method.</param>
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
        GetLFTagExpressionResponse GetLFTagExpression(GetLFTagExpressionRequest request);



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
        Task<GetLFTagExpressionResponse> GetLFTagExpressionAsync(GetLFTagExpressionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetQueryState


        /// <summary>
        /// Returns the state of a query previously submitted. Clients are expected to poll <c>GetQueryState</c>
        /// to monitor the current state of the planning before retrieving the work units. A query
        /// state is only visible to the principal that made the initial call to <c>StartQueryPlanning</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryState service method.</param>
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
        GetQueryStateResponse GetQueryState(GetQueryStateRequest request);



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
        Task<GetQueryStateResponse> GetQueryStateAsync(GetQueryStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetQueryStatistics


        /// <summary>
        /// Retrieves statistics on the planning and execution of a query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatistics service method.</param>
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
        GetQueryStatisticsResponse GetQueryStatistics(GetQueryStatisticsRequest request);



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
        Task<GetQueryStatisticsResponse> GetQueryStatisticsAsync(GetQueryStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResourceLFTags


        /// <summary>
        /// Returns the LF-tags applied to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceLFTags service method.</param>
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
        GetResourceLFTagsResponse GetResourceLFTags(GetResourceLFTagsRequest request);



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
        Task<GetResourceLFTagsResponse> GetResourceLFTagsAsync(GetResourceLFTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTableObjects


        /// <summary>
        /// Returns the set of Amazon S3 objects that make up the specified governed table. A
        /// transaction ID or timestamp can be specified for time-travel queries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableObjects service method.</param>
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
        GetTableObjectsResponse GetTableObjects(GetTableObjectsRequest request);



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
        Task<GetTableObjectsResponse> GetTableObjectsAsync(GetTableObjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTemporaryGluePartitionCredentials


        /// <summary>
        /// This API is identical to <c>GetTemporaryTableCredentials</c> except that this is used
        /// when the target Data Catalog resource is of type Partition. Lake Formation restricts
        /// the permission of the vended credentials with the same scope down policy which restricts
        /// access to a single Amazon S3 prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemporaryGluePartitionCredentials service method.</param>
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
        GetTemporaryGluePartitionCredentialsResponse GetTemporaryGluePartitionCredentials(GetTemporaryGluePartitionCredentialsRequest request);



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
        Task<GetTemporaryGluePartitionCredentialsResponse> GetTemporaryGluePartitionCredentialsAsync(GetTemporaryGluePartitionCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTemporaryGlueTableCredentials


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
        GetTemporaryGlueTableCredentialsResponse GetTemporaryGlueTableCredentials(GetTemporaryGlueTableCredentialsRequest request);



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
        Task<GetTemporaryGlueTableCredentialsResponse> GetTemporaryGlueTableCredentialsAsync(GetTemporaryGlueTableCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWorkUnitResults


        /// <summary>
        /// Returns the work units resulting from the query. Work units can be executed in any
        /// order and in parallel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkUnitResults service method.</param>
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
        GetWorkUnitResultsResponse GetWorkUnitResults(GetWorkUnitResultsRequest request);



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
        Task<GetWorkUnitResultsResponse> GetWorkUnitResultsAsync(GetWorkUnitResultsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWorkUnits


        /// <summary>
        /// Retrieves the work units generated by the <c>StartQueryPlanning</c> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkUnits service method.</param>
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
        GetWorkUnitsResponse GetWorkUnits(GetWorkUnitsRequest request);



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
        Task<GetWorkUnitsResponse> GetWorkUnitsAsync(GetWorkUnitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GrantPermissions


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
        GrantPermissionsResponse GrantPermissions(GrantPermissionsRequest request);



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
        Task<GrantPermissionsResponse> GrantPermissionsAsync(GrantPermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDataCellsFilter


        /// <summary>
        /// Lists all the data cell filters on a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataCellsFilter service method.</param>
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
        ListDataCellsFilterResponse ListDataCellsFilter(ListDataCellsFilterRequest request);



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
        Task<ListDataCellsFilterResponse> ListDataCellsFilterAsync(ListDataCellsFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLakeFormationOptIns


        /// <summary>
        /// Retrieve the current list of resources and principals that are opt in to enforce Lake
        /// Formation permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLakeFormationOptIns service method.</param>
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
        ListLakeFormationOptInsResponse ListLakeFormationOptIns(ListLakeFormationOptInsRequest request);



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
        Task<ListLakeFormationOptInsResponse> ListLakeFormationOptInsAsync(ListLakeFormationOptInsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLFTagExpressions


        /// <summary>
        /// Returns the LF-Tag expressions in caller’s account filtered based on caller's permissions.
        /// Data Lake and read only admins implicitly can see all tag expressions in their account,
        /// else caller needs DESCRIBE permissions on tag expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLFTagExpressions service method.</param>
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
        ListLFTagExpressionsResponse ListLFTagExpressions(ListLFTagExpressionsRequest request);



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
        Task<ListLFTagExpressionsResponse> ListLFTagExpressionsAsync(ListLFTagExpressionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLFTags


        /// <summary>
        /// Lists LF-tags that the requester has permission to view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLFTags service method.</param>
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
        ListLFTagsResponse ListLFTags(ListLFTagsRequest request);



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
        Task<ListLFTagsResponse> ListLFTagsAsync(ListLFTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPermissions


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
        ListPermissionsResponse ListPermissions(ListPermissionsRequest request);



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
        Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResources


        /// <summary>
        /// Lists the resources registered to be managed by the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
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
        ListResourcesResponse ListResources(ListResourcesRequest request);



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
        Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTableStorageOptimizers


        /// <summary>
        /// Returns the configuration of all storage optimizers associated with a specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableStorageOptimizers service method.</param>
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
        ListTableStorageOptimizersResponse ListTableStorageOptimizers(ListTableStorageOptimizersRequest request);



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
        Task<ListTableStorageOptimizersResponse> ListTableStorageOptimizersAsync(ListTableStorageOptimizersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTransactions


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
        ListTransactionsResponse ListTransactions(ListTransactionsRequest request);



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
        Task<ListTransactionsResponse> ListTransactionsAsync(ListTransactionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutDataLakeSettings


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
        /// 
        /// <returns>The response from the PutDataLakeSettings service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/PutDataLakeSettings">REST API Reference for PutDataLakeSettings Operation</seealso>
        PutDataLakeSettingsResponse PutDataLakeSettings(PutDataLakeSettingsRequest request);



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
        Task<PutDataLakeSettingsResponse> PutDataLakeSettingsAsync(PutDataLakeSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterResource


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
        RegisterResourceResponse RegisterResource(RegisterResourceRequest request);



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
        Task<RegisterResourceResponse> RegisterResourceAsync(RegisterResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveLFTagsFromResource


        /// <summary>
        /// Removes an LF-tag from the resource. Only database, table, or tableWithColumns resource
        /// are allowed. To tag columns, use the column inclusion list in <c>tableWithColumns</c>
        /// to specify column input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveLFTagsFromResource service method.</param>
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
        RemoveLFTagsFromResourceResponse RemoveLFTagsFromResource(RemoveLFTagsFromResourceRequest request);



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
        Task<RemoveLFTagsFromResourceResponse> RemoveLFTagsFromResourceAsync(RemoveLFTagsFromResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RevokePermissions


        /// <summary>
        /// Revokes permissions to the principal to access metadata in the Data Catalog and data
        /// organized in underlying data storage such as Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokePermissions service method.</param>
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
        RevokePermissionsResponse RevokePermissions(RevokePermissionsRequest request);



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
        Task<RevokePermissionsResponse> RevokePermissionsAsync(RevokePermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchDatabasesByLFTags


        /// <summary>
        /// This operation allows a search on <c>DATABASE</c> resources by <c>TagCondition</c>.
        /// This operation is used by admins who want to grant user permissions on certain <c>TagConditions</c>.
        /// Before making a grant, the admin can use <c>SearchDatabasesByTags</c> to find all
        /// resources where the given <c>TagConditions</c> are valid to verify whether the returned
        /// resources can be shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDatabasesByLFTags service method.</param>
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
        SearchDatabasesByLFTagsResponse SearchDatabasesByLFTags(SearchDatabasesByLFTagsRequest request);



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
        Task<SearchDatabasesByLFTagsResponse> SearchDatabasesByLFTagsAsync(SearchDatabasesByLFTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchTablesByLFTags


        /// <summary>
        /// This operation allows a search on <c>TABLE</c> resources by <c>LFTag</c>s. This will
        /// be used by admins who want to grant user permissions on certain LF-tags. Before making
        /// a grant, the admin can use <c>SearchTablesByLFTags</c> to find all resources where
        /// the given <c>LFTag</c>s are valid to verify whether the returned resources can be
        /// shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTablesByLFTags service method.</param>
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
        SearchTablesByLFTagsResponse SearchTablesByLFTags(SearchTablesByLFTagsRequest request);



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
        Task<SearchTablesByLFTagsResponse> SearchTablesByLFTagsAsync(SearchTablesByLFTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartQueryPlanning


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
        StartQueryPlanningResponse StartQueryPlanning(StartQueryPlanningRequest request);



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
        Task<StartQueryPlanningResponse> StartQueryPlanningAsync(StartQueryPlanningRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartTransaction


        /// <summary>
        /// Starts a new transaction and returns its transaction ID. Transaction IDs are opaque
        /// objects that you can use to identify a transaction.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTransaction service method.</param>
        /// 
        /// <returns>The response from the StartTransaction service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/StartTransaction">REST API Reference for StartTransaction Operation</seealso>
        StartTransactionResponse StartTransaction(StartTransactionRequest request);



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
        Task<StartTransactionResponse> StartTransactionAsync(StartTransactionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDataCellsFilter


        /// <summary>
        /// Updates a data cell filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataCellsFilter service method.</param>
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
        UpdateDataCellsFilterResponse UpdateDataCellsFilter(UpdateDataCellsFilterRequest request);



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
        Task<UpdateDataCellsFilterResponse> UpdateDataCellsFilterAsync(UpdateDataCellsFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLakeFormationIdentityCenterConfiguration


        /// <summary>
        /// Updates the IAM Identity Center connection parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLakeFormationIdentityCenterConfiguration service method.</param>
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
        UpdateLakeFormationIdentityCenterConfigurationResponse UpdateLakeFormationIdentityCenterConfiguration(UpdateLakeFormationIdentityCenterConfigurationRequest request);



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
        Task<UpdateLakeFormationIdentityCenterConfigurationResponse> UpdateLakeFormationIdentityCenterConfigurationAsync(UpdateLakeFormationIdentityCenterConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLFTag


        /// <summary>
        /// Updates the list of possible values for the specified LF-tag key. If the LF-tag does
        /// not exist, the operation throws an EntityNotFoundException. The values in the delete
        /// key values will be deleted from list of possible values. If any value in the delete
        /// key values is attached to a resource, then API errors out with a 400 Exception - "Update
        /// not allowed". Untag the attribute before deleting the LF-tag key's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLFTag service method.</param>
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
        UpdateLFTagResponse UpdateLFTag(UpdateLFTagRequest request);



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
        Task<UpdateLFTagResponse> UpdateLFTagAsync(UpdateLFTagRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLFTagExpression


        /// <summary>
        /// Updates the name of the LF-Tag expression to the new description and expression body
        /// provided. Updating a LF-Tag expression immediately changes the permission boundaries
        /// of all existing <c>LFTagPolicy</c> permission grants that reference the given LF-Tag
        /// expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLFTagExpression service method.</param>
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
        UpdateLFTagExpressionResponse UpdateLFTagExpression(UpdateLFTagExpressionRequest request);



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
        Task<UpdateLFTagExpressionResponse> UpdateLFTagExpressionAsync(UpdateLFTagExpressionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateResource


        /// <summary>
        /// Updates the data access role used for vending access to the given (registered) resource
        /// in Lake Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
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
        UpdateResourceResponse UpdateResource(UpdateResourceRequest request);



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
        Task<UpdateResourceResponse> UpdateResourceAsync(UpdateResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTableObjects


        /// <summary>
        /// Updates the manifest of Amazon S3 objects that make up the specified governed table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableObjects service method.</param>
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
        UpdateTableObjectsResponse UpdateTableObjects(UpdateTableObjectsRequest request);



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
        Task<UpdateTableObjectsResponse> UpdateTableObjectsAsync(UpdateTableObjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTableStorageOptimizer


        /// <summary>
        /// Updates the configuration of the storage optimizers for a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableStorageOptimizer service method.</param>
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
        UpdateTableStorageOptimizerResponse UpdateTableStorageOptimizer(UpdateTableStorageOptimizerRequest request);



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
        Task<UpdateTableStorageOptimizerResponse> UpdateTableStorageOptimizerAsync(UpdateTableStorageOptimizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}