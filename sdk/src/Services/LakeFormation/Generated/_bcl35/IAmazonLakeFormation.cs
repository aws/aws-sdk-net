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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LakeFormation.Model;

namespace Amazon.LakeFormation
{
    /// <summary>
    /// Interface for accessing LakeFormation
    ///
    /// Lake Formation 
    /// <para>
    /// Defines the public endpoint for the Lake Formation service.
    /// </para>
    /// </summary>
    public partial interface IAmazonLakeFormation : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILakeFormationPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the AddLFTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddLFTagsToResource operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddLFTagsToResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/AddLFTagsToResource">REST API Reference for AddLFTagsToResource Operation</seealso>
        IAsyncResult BeginAddLFTagsToResource(AddLFTagsToResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddLFTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddLFTagsToResource.</param>
        /// 
        /// <returns>Returns a  AddLFTagsToResourceResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/AddLFTagsToResource">REST API Reference for AddLFTagsToResource Operation</seealso>
        AddLFTagsToResourceResponse EndAddLFTagsToResource(IAsyncResult asyncResult);

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
        /// access from Lake Formation which is authorized via the virtual API <code>GetDataAccess</code>.
        /// Therefore, all SAML roles that can be assumed via <code>AssumeDecoratedRoleWithSAML</code>
        /// must at a minimum include <code>lakeformation:GetDataAccess</code> in their role policies.
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
        /// Initiates the asynchronous execution of the AssumeDecoratedRoleWithSAML operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeDecoratedRoleWithSAML operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeDecoratedRoleWithSAML
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/AssumeDecoratedRoleWithSAML">REST API Reference for AssumeDecoratedRoleWithSAML Operation</seealso>
        IAsyncResult BeginAssumeDecoratedRoleWithSAML(AssumeDecoratedRoleWithSAMLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeDecoratedRoleWithSAML operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeDecoratedRoleWithSAML.</param>
        /// 
        /// <returns>Returns a  AssumeDecoratedRoleWithSAMLResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/AssumeDecoratedRoleWithSAML">REST API Reference for AssumeDecoratedRoleWithSAML Operation</seealso>
        AssumeDecoratedRoleWithSAMLResponse EndAssumeDecoratedRoleWithSAML(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the BatchGrantPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGrantPermissions operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGrantPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchGrantPermissions">REST API Reference for BatchGrantPermissions Operation</seealso>
        IAsyncResult BeginBatchGrantPermissions(BatchGrantPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGrantPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGrantPermissions.</param>
        /// 
        /// <returns>Returns a  BatchGrantPermissionsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchGrantPermissions">REST API Reference for BatchGrantPermissions Operation</seealso>
        BatchGrantPermissionsResponse EndBatchGrantPermissions(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the BatchRevokePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchRevokePermissions operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchRevokePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchRevokePermissions">REST API Reference for BatchRevokePermissions Operation</seealso>
        IAsyncResult BeginBatchRevokePermissions(BatchRevokePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchRevokePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchRevokePermissions.</param>
        /// 
        /// <returns>Returns a  BatchRevokePermissionsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchRevokePermissions">REST API Reference for BatchRevokePermissions Operation</seealso>
        BatchRevokePermissionsResponse EndBatchRevokePermissions(IAsyncResult asyncResult);

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
        /// and cannot be used for <code>UpdateTableObjects</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CancelTransaction">REST API Reference for CancelTransaction Operation</seealso>
        CancelTransactionResponse CancelTransaction(CancelTransactionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelTransaction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelTransaction operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelTransaction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CancelTransaction">REST API Reference for CancelTransaction Operation</seealso>
        IAsyncResult BeginCancelTransaction(CancelTransactionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelTransaction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelTransaction.</param>
        /// 
        /// <returns>Returns a  CancelTransactionResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CancelTransaction">REST API Reference for CancelTransaction Operation</seealso>
        CancelTransactionResponse EndCancelTransaction(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CommitTransaction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CommitTransaction operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCommitTransaction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CommitTransaction">REST API Reference for CommitTransaction Operation</seealso>
        IAsyncResult BeginCommitTransaction(CommitTransactionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CommitTransaction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCommitTransaction.</param>
        /// 
        /// <returns>Returns a  CommitTransactionResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CommitTransaction">REST API Reference for CommitTransaction Operation</seealso>
        CommitTransactionResponse EndCommitTransaction(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataCellsFilter operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataCellsFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateDataCellsFilter">REST API Reference for CreateDataCellsFilter Operation</seealso>
        IAsyncResult BeginCreateDataCellsFilter(CreateDataCellsFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataCellsFilter.</param>
        /// 
        /// <returns>Returns a  CreateDataCellsFilterResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateDataCellsFilter">REST API Reference for CreateDataCellsFilter Operation</seealso>
        CreateDataCellsFilterResponse EndCreateDataCellsFilter(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateLFTag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLFTag operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLFTag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLFTag">REST API Reference for CreateLFTag Operation</seealso>
        IAsyncResult BeginCreateLFTag(CreateLFTagRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLFTag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLFTag.</param>
        /// 
        /// <returns>Returns a  CreateLFTagResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLFTag">REST API Reference for CreateLFTag Operation</seealso>
        CreateLFTagResponse EndCreateLFTag(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataCellsFilter operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataCellsFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteDataCellsFilter">REST API Reference for DeleteDataCellsFilter Operation</seealso>
        IAsyncResult BeginDeleteDataCellsFilter(DeleteDataCellsFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataCellsFilter.</param>
        /// 
        /// <returns>Returns a  DeleteDataCellsFilterResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteDataCellsFilter">REST API Reference for DeleteDataCellsFilter Operation</seealso>
        DeleteDataCellsFilterResponse EndDeleteDataCellsFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLFTag


        /// <summary>
        /// Deletes the specified LF-tag given a key name. If the input parameter tag key was
        /// not found, then the operation will throw an exception. When you delete an LF-tag,
        /// the <code>LFTagPolicy</code> attached to the LF-tag becomes invalid. If the deleted
        /// LF-tag was still assigned to any resource, the tag policy attach to the deleted LF-tag
        /// will no longer be applied to the resource.
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
        /// Initiates the asynchronous execution of the DeleteLFTag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLFTag operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLFTag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLFTag">REST API Reference for DeleteLFTag Operation</seealso>
        IAsyncResult BeginDeleteLFTag(DeleteLFTagRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLFTag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLFTag.</param>
        /// 
        /// <returns>Returns a  DeleteLFTagResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLFTag">REST API Reference for DeleteLFTag Operation</seealso>
        DeleteLFTagResponse EndDeleteLFTag(IAsyncResult asyncResult);

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
        ///  The Glue ETL library function <code>write_dynamic_frame.from_catalog()</code> includes
        /// an option to automatically call <code>DeleteObjectsOnCancel</code> before writes.
        /// For more information, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/transactions-data-operations.html#rolling-back-writes">Rolling
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
        /// and cannot be used for <code>UpdateTableObjects</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteObjectsOnCancel">REST API Reference for DeleteObjectsOnCancel Operation</seealso>
        DeleteObjectsOnCancelResponse DeleteObjectsOnCancel(DeleteObjectsOnCancelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjectsOnCancel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjectsOnCancel operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteObjectsOnCancel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteObjectsOnCancel">REST API Reference for DeleteObjectsOnCancel Operation</seealso>
        IAsyncResult BeginDeleteObjectsOnCancel(DeleteObjectsOnCancelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteObjectsOnCancel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObjectsOnCancel.</param>
        /// 
        /// <returns>Returns a  DeleteObjectsOnCancelResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteObjectsOnCancel">REST API Reference for DeleteObjectsOnCancel Operation</seealso>
        DeleteObjectsOnCancelResponse EndDeleteObjectsOnCancel(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeregisterResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterResource operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeregisterResource">REST API Reference for DeregisterResource Operation</seealso>
        IAsyncResult BeginDeregisterResource(DeregisterResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterResource.</param>
        /// 
        /// <returns>Returns a  DeregisterResourceResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeregisterResource">REST API Reference for DeregisterResource Operation</seealso>
        DeregisterResourceResponse EndDeregisterResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        IAsyncResult BeginDescribeResource(DescribeResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResource.</param>
        /// 
        /// <returns>Returns a  DescribeResourceResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        DescribeResourceResponse EndDescribeResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeTransaction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransaction operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTransaction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeTransaction">REST API Reference for DescribeTransaction Operation</seealso>
        IAsyncResult BeginDescribeTransaction(DescribeTransactionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTransaction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTransaction.</param>
        /// 
        /// <returns>Returns a  DescribeTransactionResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeTransaction">REST API Reference for DescribeTransaction Operation</seealso>
        DescribeTransactionResponse EndDescribeTransaction(IAsyncResult asyncResult);

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
        /// and cannot be used for <code>UpdateTableObjects</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ExtendTransaction">REST API Reference for ExtendTransaction Operation</seealso>
        ExtendTransactionResponse ExtendTransaction(ExtendTransactionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExtendTransaction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExtendTransaction operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExtendTransaction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ExtendTransaction">REST API Reference for ExtendTransaction Operation</seealso>
        IAsyncResult BeginExtendTransaction(ExtendTransactionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExtendTransaction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExtendTransaction.</param>
        /// 
        /// <returns>Returns a  ExtendTransactionResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ExtendTransaction">REST API Reference for ExtendTransaction Operation</seealso>
        ExtendTransactionResponse EndExtendTransaction(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataCellsFilter operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataCellsFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataCellsFilter">REST API Reference for GetDataCellsFilter Operation</seealso>
        IAsyncResult BeginGetDataCellsFilter(GetDataCellsFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataCellsFilter.</param>
        /// 
        /// <returns>Returns a  GetDataCellsFilterResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataCellsFilter">REST API Reference for GetDataCellsFilter Operation</seealso>
        GetDataCellsFilterResponse EndGetDataCellsFilter(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetDataLakeSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeSettings operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataLakeSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataLakeSettings">REST API Reference for GetDataLakeSettings Operation</seealso>
        IAsyncResult BeginGetDataLakeSettings(GetDataLakeSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataLakeSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataLakeSettings.</param>
        /// 
        /// <returns>Returns a  GetDataLakeSettingsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataLakeSettings">REST API Reference for GetDataLakeSettings Operation</seealso>
        GetDataLakeSettingsResponse EndGetDataLakeSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEffectivePermissionsForPath


        /// <summary>
        /// Returns the Lake Formation permissions for a specified table or database resource
        /// located at a path in Amazon S3. <code>GetEffectivePermissionsForPath</code> will not
        /// return databases and tables if the catalog is encrypted.
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
        /// Initiates the asynchronous execution of the GetEffectivePermissionsForPath operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEffectivePermissionsForPath operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEffectivePermissionsForPath
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetEffectivePermissionsForPath">REST API Reference for GetEffectivePermissionsForPath Operation</seealso>
        IAsyncResult BeginGetEffectivePermissionsForPath(GetEffectivePermissionsForPathRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEffectivePermissionsForPath operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEffectivePermissionsForPath.</param>
        /// 
        /// <returns>Returns a  GetEffectivePermissionsForPathResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetEffectivePermissionsForPath">REST API Reference for GetEffectivePermissionsForPath Operation</seealso>
        GetEffectivePermissionsForPathResponse EndGetEffectivePermissionsForPath(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetLFTag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLFTag operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLFTag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetLFTag">REST API Reference for GetLFTag Operation</seealso>
        IAsyncResult BeginGetLFTag(GetLFTagRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLFTag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLFTag.</param>
        /// 
        /// <returns>Returns a  GetLFTagResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetLFTag">REST API Reference for GetLFTag Operation</seealso>
        GetLFTagResponse EndGetLFTag(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQueryState


        /// <summary>
        /// Returns the state of a query previously submitted. Clients are expected to poll <code>GetQueryState</code>
        /// to monitor the current state of the planning before retrieving the work units. A query
        /// state is only visible to the principal that made the initial call to <code>StartQueryPlanning</code>.
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
        /// Initiates the asynchronous execution of the GetQueryState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryState operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueryState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetQueryState">REST API Reference for GetQueryState Operation</seealso>
        IAsyncResult BeginGetQueryState(GetQueryStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueryState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueryState.</param>
        /// 
        /// <returns>Returns a  GetQueryStateResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetQueryState">REST API Reference for GetQueryState Operation</seealso>
        GetQueryStateResponse EndGetQueryState(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetQueryStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatistics operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueryStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetQueryStatistics">REST API Reference for GetQueryStatistics Operation</seealso>
        IAsyncResult BeginGetQueryStatistics(GetQueryStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueryStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueryStatistics.</param>
        /// 
        /// <returns>Returns a  GetQueryStatisticsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetQueryStatistics">REST API Reference for GetQueryStatistics Operation</seealso>
        GetQueryStatisticsResponse EndGetQueryStatistics(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetResourceLFTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceLFTags operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceLFTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetResourceLFTags">REST API Reference for GetResourceLFTags Operation</seealso>
        IAsyncResult BeginGetResourceLFTags(GetResourceLFTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceLFTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceLFTags.</param>
        /// 
        /// <returns>Returns a  GetResourceLFTagsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetResourceLFTags">REST API Reference for GetResourceLFTags Operation</seealso>
        GetResourceLFTagsResponse EndGetResourceLFTags(IAsyncResult asyncResult);

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
        /// and cannot be used for <code>UpdateTableObjects</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTableObjects">REST API Reference for GetTableObjects Operation</seealso>
        GetTableObjectsResponse GetTableObjects(GetTableObjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableObjects operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableObjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTableObjects">REST API Reference for GetTableObjects Operation</seealso>
        IAsyncResult BeginGetTableObjects(GetTableObjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableObjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableObjects.</param>
        /// 
        /// <returns>Returns a  GetTableObjectsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTableObjects">REST API Reference for GetTableObjects Operation</seealso>
        GetTableObjectsResponse EndGetTableObjects(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTemporaryGluePartitionCredentials


        /// <summary>
        /// This API is identical to <code>GetTemporaryTableCredentials</code> except that this
        /// is used when the target Data Catalog resource is of type Partition. Lake Formation
        /// restricts the permission of the vended credentials with the same scope down policy
        /// which restricts access to a single Amazon S3 prefix.
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
        /// example, if you call the <code>GetTemporaryGlueTableCredentials</code> operation with
        /// <code>SupportedPermissionType</code> equal to <code>ColumnPermission</code>, but cell-level
        /// permissions exist on the table, this exception is thrown.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTemporaryGluePartitionCredentials">REST API Reference for GetTemporaryGluePartitionCredentials Operation</seealso>
        GetTemporaryGluePartitionCredentialsResponse GetTemporaryGluePartitionCredentials(GetTemporaryGluePartitionCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemporaryGluePartitionCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemporaryGluePartitionCredentials operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemporaryGluePartitionCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTemporaryGluePartitionCredentials">REST API Reference for GetTemporaryGluePartitionCredentials Operation</seealso>
        IAsyncResult BeginGetTemporaryGluePartitionCredentials(GetTemporaryGluePartitionCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemporaryGluePartitionCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemporaryGluePartitionCredentials.</param>
        /// 
        /// <returns>Returns a  GetTemporaryGluePartitionCredentialsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTemporaryGluePartitionCredentials">REST API Reference for GetTemporaryGluePartitionCredentials Operation</seealso>
        GetTemporaryGluePartitionCredentialsResponse EndGetTemporaryGluePartitionCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTemporaryGlueTableCredentials


        /// <summary>
        /// Allows a caller in a secure environment to assume a role with permission to access
        /// Amazon S3. In order to vend such credentials, Lake Formation assumes the role associated
        /// with a registered location, for example an Amazon S3 bucket, with a scope down policy
        /// which restricts the access to a single prefix.
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
        /// example, if you call the <code>GetTemporaryGlueTableCredentials</code> operation with
        /// <code>SupportedPermissionType</code> equal to <code>ColumnPermission</code>, but cell-level
        /// permissions exist on the table, this exception is thrown.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTemporaryGlueTableCredentials">REST API Reference for GetTemporaryGlueTableCredentials Operation</seealso>
        GetTemporaryGlueTableCredentialsResponse GetTemporaryGlueTableCredentials(GetTemporaryGlueTableCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemporaryGlueTableCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemporaryGlueTableCredentials operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemporaryGlueTableCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTemporaryGlueTableCredentials">REST API Reference for GetTemporaryGlueTableCredentials Operation</seealso>
        IAsyncResult BeginGetTemporaryGlueTableCredentials(GetTemporaryGlueTableCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemporaryGlueTableCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemporaryGlueTableCredentials.</param>
        /// 
        /// <returns>Returns a  GetTemporaryGlueTableCredentialsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTemporaryGlueTableCredentials">REST API Reference for GetTemporaryGlueTableCredentials Operation</seealso>
        GetTemporaryGlueTableCredentialsResponse EndGetTemporaryGlueTableCredentials(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetWorkUnitResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkUnitResults operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkUnitResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetWorkUnitResults">REST API Reference for GetWorkUnitResults Operation</seealso>
        IAsyncResult BeginGetWorkUnitResults(GetWorkUnitResultsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkUnitResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkUnitResults.</param>
        /// 
        /// <returns>Returns a  GetWorkUnitResultsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetWorkUnitResults">REST API Reference for GetWorkUnitResults Operation</seealso>
        GetWorkUnitResultsResponse EndGetWorkUnitResults(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkUnits


        /// <summary>
        /// Retrieves the work units generated by the <code>StartQueryPlanning</code> operation.
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
        /// Initiates the asynchronous execution of the GetWorkUnits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkUnits operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkUnits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetWorkUnits">REST API Reference for GetWorkUnits Operation</seealso>
        IAsyncResult BeginGetWorkUnits(GetWorkUnitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkUnits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkUnits.</param>
        /// 
        /// <returns>Returns a  GetWorkUnitsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetWorkUnits">REST API Reference for GetWorkUnits Operation</seealso>
        GetWorkUnitsResponse EndGetWorkUnits(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GrantPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GrantPermissions operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGrantPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GrantPermissions">REST API Reference for GrantPermissions Operation</seealso>
        IAsyncResult BeginGrantPermissions(GrantPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GrantPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGrantPermissions.</param>
        /// 
        /// <returns>Returns a  GrantPermissionsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GrantPermissions">REST API Reference for GrantPermissions Operation</seealso>
        GrantPermissionsResponse EndGrantPermissions(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataCellsFilter operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataCellsFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListDataCellsFilter">REST API Reference for ListDataCellsFilter Operation</seealso>
        IAsyncResult BeginListDataCellsFilter(ListDataCellsFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataCellsFilter.</param>
        /// 
        /// <returns>Returns a  ListDataCellsFilterResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListDataCellsFilter">REST API Reference for ListDataCellsFilter Operation</seealso>
        ListDataCellsFilterResponse EndListDataCellsFilter(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListLFTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLFTags operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLFTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLFTags">REST API Reference for ListLFTags Operation</seealso>
        IAsyncResult BeginListLFTags(ListLFTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLFTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLFTags.</param>
        /// 
        /// <returns>Returns a  ListLFTagsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLFTags">REST API Reference for ListLFTags Operation</seealso>
        ListLFTagsResponse EndListLFTags(IAsyncResult asyncResult);

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
        /// For information about permissions, see <a href="https://docs-aws.amazon.com/lake-formation/latest/dg/security-data-access.html">Security
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
        /// Initiates the asynchronous execution of the ListPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        IAsyncResult BeginListPermissions(ListPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissions.</param>
        /// 
        /// <returns>Returns a  ListPermissionsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        ListPermissionsResponse EndListPermissions(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResources operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListResources">REST API Reference for ListResources Operation</seealso>
        IAsyncResult BeginListResources(ListResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResources.</param>
        /// 
        /// <returns>Returns a  ListResourcesResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListResources">REST API Reference for ListResources Operation</seealso>
        ListResourcesResponse EndListResources(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTableStorageOptimizers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTableStorageOptimizers operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTableStorageOptimizers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListTableStorageOptimizers">REST API Reference for ListTableStorageOptimizers Operation</seealso>
        IAsyncResult BeginListTableStorageOptimizers(ListTableStorageOptimizersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTableStorageOptimizers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTableStorageOptimizers.</param>
        /// 
        /// <returns>Returns a  ListTableStorageOptimizersResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListTableStorageOptimizers">REST API Reference for ListTableStorageOptimizers Operation</seealso>
        ListTableStorageOptimizersResponse EndListTableStorageOptimizers(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTransactions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTransactions operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTransactions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListTransactions">REST API Reference for ListTransactions Operation</seealso>
        IAsyncResult BeginListTransactions(ListTransactionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTransactions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTransactions.</param>
        /// 
        /// <returns>Returns a  ListTransactionsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListTransactions">REST API Reference for ListTransactions Operation</seealso>
        ListTransactionsResponse EndListTransactions(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the PutDataLakeSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDataLakeSettings operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDataLakeSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/PutDataLakeSettings">REST API Reference for PutDataLakeSettings Operation</seealso>
        IAsyncResult BeginPutDataLakeSettings(PutDataLakeSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutDataLakeSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDataLakeSettings.</param>
        /// 
        /// <returns>Returns a  PutDataLakeSettingsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/PutDataLakeSettings">REST API Reference for PutDataLakeSettings Operation</seealso>
        PutDataLakeSettingsResponse EndPutDataLakeSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterResource


        /// <summary>
        /// Registers the resource as managed by the Data Catalog.
        /// 
        ///  
        /// <para>
        /// To add or update data, Lake Formation needs read/write access to the chosen Amazon
        /// S3 path. Choose a role that you know has permission to do this, or choose the AWSServiceRoleForLakeFormationDataAccess
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
        ///  <code>ResourceArn = arn:aws:s3:::my-bucket UseServiceLinkedRole = true</code> 
        /// </para>
        ///  
        /// <para>
        /// If <code>UseServiceLinkedRole</code> is not set to true, you must provide or set the
        /// <code>RoleArn</code>:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:iam::12345:role/my-data-access-role</code> 
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
        /// Initiates the asynchronous execution of the RegisterResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterResource operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RegisterResource">REST API Reference for RegisterResource Operation</seealso>
        IAsyncResult BeginRegisterResource(RegisterResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterResource.</param>
        /// 
        /// <returns>Returns a  RegisterResourceResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RegisterResource">REST API Reference for RegisterResource Operation</seealso>
        RegisterResourceResponse EndRegisterResource(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveLFTagsFromResource


        /// <summary>
        /// Removes an LF-tag from the resource. Only database, table, or tableWithColumns resource
        /// are allowed. To tag columns, use the column inclusion list in <code>tableWithColumns</code>
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
        /// Initiates the asynchronous execution of the RemoveLFTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveLFTagsFromResource operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveLFTagsFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RemoveLFTagsFromResource">REST API Reference for RemoveLFTagsFromResource Operation</seealso>
        IAsyncResult BeginRemoveLFTagsFromResource(RemoveLFTagsFromResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveLFTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveLFTagsFromResource.</param>
        /// 
        /// <returns>Returns a  RemoveLFTagsFromResourceResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RemoveLFTagsFromResource">REST API Reference for RemoveLFTagsFromResource Operation</seealso>
        RemoveLFTagsFromResourceResponse EndRemoveLFTagsFromResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the RevokePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokePermissions operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RevokePermissions">REST API Reference for RevokePermissions Operation</seealso>
        IAsyncResult BeginRevokePermissions(RevokePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokePermissions.</param>
        /// 
        /// <returns>Returns a  RevokePermissionsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RevokePermissions">REST API Reference for RevokePermissions Operation</seealso>
        RevokePermissionsResponse EndRevokePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchDatabasesByLFTags


        /// <summary>
        /// This operation allows a search on <code>DATABASE</code> resources by <code>TagCondition</code>.
        /// This operation is used by admins who want to grant user permissions on certain <code>TagConditions</code>.
        /// Before making a grant, the admin can use <code>SearchDatabasesByTags</code> to find
        /// all resources where the given <code>TagConditions</code> are valid to verify whether
        /// the returned resources can be shared.
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
        /// Initiates the asynchronous execution of the SearchDatabasesByLFTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchDatabasesByLFTags operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchDatabasesByLFTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/SearchDatabasesByLFTags">REST API Reference for SearchDatabasesByLFTags Operation</seealso>
        IAsyncResult BeginSearchDatabasesByLFTags(SearchDatabasesByLFTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchDatabasesByLFTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchDatabasesByLFTags.</param>
        /// 
        /// <returns>Returns a  SearchDatabasesByLFTagsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/SearchDatabasesByLFTags">REST API Reference for SearchDatabasesByLFTags Operation</seealso>
        SearchDatabasesByLFTagsResponse EndSearchDatabasesByLFTags(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchTablesByLFTags


        /// <summary>
        /// This operation allows a search on <code>TABLE</code> resources by <code>LFTag</code>s.
        /// This will be used by admins who want to grant user permissions on certain LF-tags.
        /// Before making a grant, the admin can use <code>SearchTablesByLFTags</code> to find
        /// all resources where the given <code>LFTag</code>s are valid to verify whether the
        /// returned resources can be shared.
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
        /// Initiates the asynchronous execution of the SearchTablesByLFTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchTablesByLFTags operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchTablesByLFTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/SearchTablesByLFTags">REST API Reference for SearchTablesByLFTags Operation</seealso>
        IAsyncResult BeginSearchTablesByLFTags(SearchTablesByLFTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchTablesByLFTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchTablesByLFTags.</param>
        /// 
        /// <returns>Returns a  SearchTablesByLFTagsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/SearchTablesByLFTags">REST API Reference for SearchTablesByLFTags Operation</seealso>
        SearchTablesByLFTagsResponse EndSearchTablesByLFTags(IAsyncResult asyncResult);

        #endregion
        
        #region  StartQueryPlanning


        /// <summary>
        /// Submits a request to process a query statement.
        /// 
        ///  
        /// <para>
        /// This operation generates work units that can be retrieved with the <code>GetWorkUnits</code>
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
        /// Initiates the asynchronous execution of the StartQueryPlanning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartQueryPlanning operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartQueryPlanning
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/StartQueryPlanning">REST API Reference for StartQueryPlanning Operation</seealso>
        IAsyncResult BeginStartQueryPlanning(StartQueryPlanningRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartQueryPlanning operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartQueryPlanning.</param>
        /// 
        /// <returns>Returns a  StartQueryPlanningResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/StartQueryPlanning">REST API Reference for StartQueryPlanning Operation</seealso>
        StartQueryPlanningResponse EndStartQueryPlanning(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StartTransaction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTransaction operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTransaction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/StartTransaction">REST API Reference for StartTransaction Operation</seealso>
        IAsyncResult BeginStartTransaction(StartTransactionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartTransaction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTransaction.</param>
        /// 
        /// <returns>Returns a  StartTransactionResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/StartTransaction">REST API Reference for StartTransaction Operation</seealso>
        StartTransactionResponse EndStartTransaction(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataCellsFilter operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataCellsFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateDataCellsFilter">REST API Reference for UpdateDataCellsFilter Operation</seealso>
        IAsyncResult BeginUpdateDataCellsFilter(UpdateDataCellsFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataCellsFilter.</param>
        /// 
        /// <returns>Returns a  UpdateDataCellsFilterResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateDataCellsFilter">REST API Reference for UpdateDataCellsFilter Operation</seealso>
        UpdateDataCellsFilterResponse EndUpdateDataCellsFilter(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateLFTag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLFTag operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLFTag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLFTag">REST API Reference for UpdateLFTag Operation</seealso>
        IAsyncResult BeginUpdateLFTag(UpdateLFTagRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLFTag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLFTag.</param>
        /// 
        /// <returns>Returns a  UpdateLFTagResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLFTag">REST API Reference for UpdateLFTag Operation</seealso>
        UpdateLFTagResponse EndUpdateLFTag(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        IAsyncResult BeginUpdateResource(UpdateResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResource.</param>
        /// 
        /// <returns>Returns a  UpdateResourceResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        UpdateResourceResponse EndUpdateResource(IAsyncResult asyncResult);

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
        /// and cannot be used for <code>UpdateTableObjects</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateTableObjects">REST API Reference for UpdateTableObjects Operation</seealso>
        UpdateTableObjectsResponse UpdateTableObjects(UpdateTableObjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTableObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableObjects operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTableObjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateTableObjects">REST API Reference for UpdateTableObjects Operation</seealso>
        IAsyncResult BeginUpdateTableObjects(UpdateTableObjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTableObjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTableObjects.</param>
        /// 
        /// <returns>Returns a  UpdateTableObjectsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateTableObjects">REST API Reference for UpdateTableObjects Operation</seealso>
        UpdateTableObjectsResponse EndUpdateTableObjects(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateTableStorageOptimizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableStorageOptimizer operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTableStorageOptimizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateTableStorageOptimizer">REST API Reference for UpdateTableStorageOptimizer Operation</seealso>
        IAsyncResult BeginUpdateTableStorageOptimizer(UpdateTableStorageOptimizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTableStorageOptimizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTableStorageOptimizer.</param>
        /// 
        /// <returns>Returns a  UpdateTableStorageOptimizerResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateTableStorageOptimizer">REST API Reference for UpdateTableStorageOptimizer Operation</seealso>
        UpdateTableStorageOptimizerResponse EndUpdateTableStorageOptimizer(IAsyncResult asyncResult);

        #endregion
        
    }
}