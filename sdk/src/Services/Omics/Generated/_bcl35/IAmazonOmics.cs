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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Omics.Model;

namespace Amazon.Omics
{
    /// <summary>
    /// Interface for accessing Omics
    ///
    /// This is the <i>Amazon Omics API Reference</i>. For an introduction to the service,
    /// see <a href="https://docs.aws.amazon.com/omics/latest/dev/">What is Amazon Omics?</a>
    /// in the <i>Amazon Omics Developer Guide</i>.
    /// </summary>
    public partial interface IAmazonOmics : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IOmicsPaginatorFactory Paginators { get; }
#endif


        
        #region  BatchDeleteReadSet


        /// <summary>
        /// Deletes one or more read sets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteReadSet service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteReadSet service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/BatchDeleteReadSet">REST API Reference for BatchDeleteReadSet Operation</seealso>
        BatchDeleteReadSetResponse BatchDeleteReadSet(BatchDeleteReadSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteReadSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteReadSet operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteReadSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/BatchDeleteReadSet">REST API Reference for BatchDeleteReadSet Operation</seealso>
        IAsyncResult BeginBatchDeleteReadSet(BatchDeleteReadSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteReadSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteReadSet.</param>
        /// 
        /// <returns>Returns a  BatchDeleteReadSetResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/BatchDeleteReadSet">REST API Reference for BatchDeleteReadSet Operation</seealso>
        BatchDeleteReadSetResponse EndBatchDeleteReadSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelAnnotationImportJob


        /// <summary>
        /// Cancels an annotation import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelAnnotationImportJob service method.</param>
        /// 
        /// <returns>The response from the CancelAnnotationImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelAnnotationImportJob">REST API Reference for CancelAnnotationImportJob Operation</seealso>
        CancelAnnotationImportJobResponse CancelAnnotationImportJob(CancelAnnotationImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelAnnotationImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelAnnotationImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelAnnotationImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelAnnotationImportJob">REST API Reference for CancelAnnotationImportJob Operation</seealso>
        IAsyncResult BeginCancelAnnotationImportJob(CancelAnnotationImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelAnnotationImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelAnnotationImportJob.</param>
        /// 
        /// <returns>Returns a  CancelAnnotationImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelAnnotationImportJob">REST API Reference for CancelAnnotationImportJob Operation</seealso>
        CancelAnnotationImportJobResponse EndCancelAnnotationImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelRun


        /// <summary>
        /// Cancels a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelRun service method.</param>
        /// 
        /// <returns>The response from the CancelRun service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelRun">REST API Reference for CancelRun Operation</seealso>
        CancelRunResponse CancelRun(CancelRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelRun operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelRun">REST API Reference for CancelRun Operation</seealso>
        IAsyncResult BeginCancelRun(CancelRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelRun.</param>
        /// 
        /// <returns>Returns a  CancelRunResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelRun">REST API Reference for CancelRun Operation</seealso>
        CancelRunResponse EndCancelRun(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelVariantImportJob


        /// <summary>
        /// Cancels a variant import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelVariantImportJob service method.</param>
        /// 
        /// <returns>The response from the CancelVariantImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelVariantImportJob">REST API Reference for CancelVariantImportJob Operation</seealso>
        CancelVariantImportJobResponse CancelVariantImportJob(CancelVariantImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelVariantImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelVariantImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelVariantImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelVariantImportJob">REST API Reference for CancelVariantImportJob Operation</seealso>
        IAsyncResult BeginCancelVariantImportJob(CancelVariantImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelVariantImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelVariantImportJob.</param>
        /// 
        /// <returns>Returns a  CancelVariantImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelVariantImportJob">REST API Reference for CancelVariantImportJob Operation</seealso>
        CancelVariantImportJobResponse EndCancelVariantImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAnnotationStore


        /// <summary>
        /// Creates an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnnotationStore service method.</param>
        /// 
        /// <returns>The response from the CreateAnnotationStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateAnnotationStore">REST API Reference for CreateAnnotationStore Operation</seealso>
        CreateAnnotationStoreResponse CreateAnnotationStore(CreateAnnotationStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAnnotationStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAnnotationStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateAnnotationStore">REST API Reference for CreateAnnotationStore Operation</seealso>
        IAsyncResult BeginCreateAnnotationStore(CreateAnnotationStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAnnotationStore.</param>
        /// 
        /// <returns>Returns a  CreateAnnotationStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateAnnotationStore">REST API Reference for CreateAnnotationStore Operation</seealso>
        CreateAnnotationStoreResponse EndCreateAnnotationStore(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateReferenceStore


        /// <summary>
        /// Creates a reference store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReferenceStore service method.</param>
        /// 
        /// <returns>The response from the CreateReferenceStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateReferenceStore">REST API Reference for CreateReferenceStore Operation</seealso>
        CreateReferenceStoreResponse CreateReferenceStore(CreateReferenceStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReferenceStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReferenceStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReferenceStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateReferenceStore">REST API Reference for CreateReferenceStore Operation</seealso>
        IAsyncResult BeginCreateReferenceStore(CreateReferenceStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReferenceStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReferenceStore.</param>
        /// 
        /// <returns>Returns a  CreateReferenceStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateReferenceStore">REST API Reference for CreateReferenceStore Operation</seealso>
        CreateReferenceStoreResponse EndCreateReferenceStore(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRunGroup


        /// <summary>
        /// Creates a run group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRunGroup service method.</param>
        /// 
        /// <returns>The response from the CreateRunGroup service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateRunGroup">REST API Reference for CreateRunGroup Operation</seealso>
        CreateRunGroupResponse CreateRunGroup(CreateRunGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRunGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRunGroup operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRunGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateRunGroup">REST API Reference for CreateRunGroup Operation</seealso>
        IAsyncResult BeginCreateRunGroup(CreateRunGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRunGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRunGroup.</param>
        /// 
        /// <returns>Returns a  CreateRunGroupResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateRunGroup">REST API Reference for CreateRunGroup Operation</seealso>
        CreateRunGroupResponse EndCreateRunGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSequenceStore


        /// <summary>
        /// Creates a sequence store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSequenceStore service method.</param>
        /// 
        /// <returns>The response from the CreateSequenceStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateSequenceStore">REST API Reference for CreateSequenceStore Operation</seealso>
        CreateSequenceStoreResponse CreateSequenceStore(CreateSequenceStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSequenceStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSequenceStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSequenceStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateSequenceStore">REST API Reference for CreateSequenceStore Operation</seealso>
        IAsyncResult BeginCreateSequenceStore(CreateSequenceStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSequenceStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSequenceStore.</param>
        /// 
        /// <returns>Returns a  CreateSequenceStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateSequenceStore">REST API Reference for CreateSequenceStore Operation</seealso>
        CreateSequenceStoreResponse EndCreateSequenceStore(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVariantStore


        /// <summary>
        /// Creates a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVariantStore service method.</param>
        /// 
        /// <returns>The response from the CreateVariantStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateVariantStore">REST API Reference for CreateVariantStore Operation</seealso>
        CreateVariantStoreResponse CreateVariantStore(CreateVariantStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVariantStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVariantStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVariantStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateVariantStore">REST API Reference for CreateVariantStore Operation</seealso>
        IAsyncResult BeginCreateVariantStore(CreateVariantStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVariantStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVariantStore.</param>
        /// 
        /// <returns>Returns a  CreateVariantStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateVariantStore">REST API Reference for CreateVariantStore Operation</seealso>
        CreateVariantStoreResponse EndCreateVariantStore(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkflow


        /// <summary>
        /// Creates a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// 
        /// <returns>The response from the CreateWorkflow service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        IAsyncResult BeginCreateWorkflow(CreateWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkflow.</param>
        /// 
        /// <returns>Returns a  CreateWorkflowResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        CreateWorkflowResponse EndCreateWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAnnotationStore


        /// <summary>
        /// Deletes an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnnotationStore service method.</param>
        /// 
        /// <returns>The response from the DeleteAnnotationStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteAnnotationStore">REST API Reference for DeleteAnnotationStore Operation</seealso>
        DeleteAnnotationStoreResponse DeleteAnnotationStore(DeleteAnnotationStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnnotationStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAnnotationStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteAnnotationStore">REST API Reference for DeleteAnnotationStore Operation</seealso>
        IAsyncResult BeginDeleteAnnotationStore(DeleteAnnotationStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnnotationStore.</param>
        /// 
        /// <returns>Returns a  DeleteAnnotationStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteAnnotationStore">REST API Reference for DeleteAnnotationStore Operation</seealso>
        DeleteAnnotationStoreResponse EndDeleteAnnotationStore(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteReference


        /// <summary>
        /// Deletes a genome reference.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReference service method.</param>
        /// 
        /// <returns>The response from the DeleteReference service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteReference">REST API Reference for DeleteReference Operation</seealso>
        DeleteReferenceResponse DeleteReference(DeleteReferenceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReference operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReference
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteReference">REST API Reference for DeleteReference Operation</seealso>
        IAsyncResult BeginDeleteReference(DeleteReferenceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReference operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReference.</param>
        /// 
        /// <returns>Returns a  DeleteReferenceResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteReference">REST API Reference for DeleteReference Operation</seealso>
        DeleteReferenceResponse EndDeleteReference(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteReferenceStore


        /// <summary>
        /// Deletes a genome reference store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReferenceStore service method.</param>
        /// 
        /// <returns>The response from the DeleteReferenceStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteReferenceStore">REST API Reference for DeleteReferenceStore Operation</seealso>
        DeleteReferenceStoreResponse DeleteReferenceStore(DeleteReferenceStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReferenceStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReferenceStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReferenceStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteReferenceStore">REST API Reference for DeleteReferenceStore Operation</seealso>
        IAsyncResult BeginDeleteReferenceStore(DeleteReferenceStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReferenceStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReferenceStore.</param>
        /// 
        /// <returns>Returns a  DeleteReferenceStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteReferenceStore">REST API Reference for DeleteReferenceStore Operation</seealso>
        DeleteReferenceStoreResponse EndDeleteReferenceStore(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRun


        /// <summary>
        /// Deletes a workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun service method.</param>
        /// 
        /// <returns>The response from the DeleteRun service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteRun">REST API Reference for DeleteRun Operation</seealso>
        DeleteRunResponse DeleteRun(DeleteRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteRun">REST API Reference for DeleteRun Operation</seealso>
        IAsyncResult BeginDeleteRun(DeleteRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRun.</param>
        /// 
        /// <returns>Returns a  DeleteRunResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteRun">REST API Reference for DeleteRun Operation</seealso>
        DeleteRunResponse EndDeleteRun(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRunGroup


        /// <summary>
        /// Deletes a workflow run group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRunGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteRunGroup service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteRunGroup">REST API Reference for DeleteRunGroup Operation</seealso>
        DeleteRunGroupResponse DeleteRunGroup(DeleteRunGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRunGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRunGroup operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRunGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteRunGroup">REST API Reference for DeleteRunGroup Operation</seealso>
        IAsyncResult BeginDeleteRunGroup(DeleteRunGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRunGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRunGroup.</param>
        /// 
        /// <returns>Returns a  DeleteRunGroupResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteRunGroup">REST API Reference for DeleteRunGroup Operation</seealso>
        DeleteRunGroupResponse EndDeleteRunGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSequenceStore


        /// <summary>
        /// Deletes a sequence store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSequenceStore service method.</param>
        /// 
        /// <returns>The response from the DeleteSequenceStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteSequenceStore">REST API Reference for DeleteSequenceStore Operation</seealso>
        DeleteSequenceStoreResponse DeleteSequenceStore(DeleteSequenceStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSequenceStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSequenceStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSequenceStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteSequenceStore">REST API Reference for DeleteSequenceStore Operation</seealso>
        IAsyncResult BeginDeleteSequenceStore(DeleteSequenceStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSequenceStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSequenceStore.</param>
        /// 
        /// <returns>Returns a  DeleteSequenceStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteSequenceStore">REST API Reference for DeleteSequenceStore Operation</seealso>
        DeleteSequenceStoreResponse EndDeleteSequenceStore(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVariantStore


        /// <summary>
        /// Deletes a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVariantStore service method.</param>
        /// 
        /// <returns>The response from the DeleteVariantStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteVariantStore">REST API Reference for DeleteVariantStore Operation</seealso>
        DeleteVariantStoreResponse DeleteVariantStore(DeleteVariantStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVariantStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVariantStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVariantStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteVariantStore">REST API Reference for DeleteVariantStore Operation</seealso>
        IAsyncResult BeginDeleteVariantStore(DeleteVariantStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVariantStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVariantStore.</param>
        /// 
        /// <returns>Returns a  DeleteVariantStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteVariantStore">REST API Reference for DeleteVariantStore Operation</seealso>
        DeleteVariantStoreResponse EndDeleteVariantStore(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkflow


        /// <summary>
        /// Deletes a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkflow service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        IAsyncResult BeginDeleteWorkflow(DeleteWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkflow.</param>
        /// 
        /// <returns>Returns a  DeleteWorkflowResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        DeleteWorkflowResponse EndDeleteWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAnnotationImportJob


        /// <summary>
        /// Gets information about an annotation import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnnotationImportJob service method.</param>
        /// 
        /// <returns>The response from the GetAnnotationImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetAnnotationImportJob">REST API Reference for GetAnnotationImportJob Operation</seealso>
        GetAnnotationImportJobResponse GetAnnotationImportJob(GetAnnotationImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAnnotationImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnnotationImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnnotationImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetAnnotationImportJob">REST API Reference for GetAnnotationImportJob Operation</seealso>
        IAsyncResult BeginGetAnnotationImportJob(GetAnnotationImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnnotationImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnnotationImportJob.</param>
        /// 
        /// <returns>Returns a  GetAnnotationImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetAnnotationImportJob">REST API Reference for GetAnnotationImportJob Operation</seealso>
        GetAnnotationImportJobResponse EndGetAnnotationImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAnnotationStore


        /// <summary>
        /// Gets information about an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnnotationStore service method.</param>
        /// 
        /// <returns>The response from the GetAnnotationStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetAnnotationStore">REST API Reference for GetAnnotationStore Operation</seealso>
        GetAnnotationStoreResponse GetAnnotationStore(GetAnnotationStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnnotationStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnnotationStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetAnnotationStore">REST API Reference for GetAnnotationStore Operation</seealso>
        IAsyncResult BeginGetAnnotationStore(GetAnnotationStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnnotationStore.</param>
        /// 
        /// <returns>Returns a  GetAnnotationStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetAnnotationStore">REST API Reference for GetAnnotationStore Operation</seealso>
        GetAnnotationStoreResponse EndGetAnnotationStore(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReadSet


        /// <summary>
        /// Gets a file from a read set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSet service method.</param>
        /// 
        /// <returns>The response from the GetReadSet service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RangeNotSatisfiableException">
        /// The ranges specified in the request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSet">REST API Reference for GetReadSet Operation</seealso>
        GetReadSetResponse GetReadSet(GetReadSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadSet operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSet">REST API Reference for GetReadSet Operation</seealso>
        IAsyncResult BeginGetReadSet(GetReadSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadSet.</param>
        /// 
        /// <returns>Returns a  GetReadSetResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSet">REST API Reference for GetReadSet Operation</seealso>
        GetReadSetResponse EndGetReadSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReadSetActivationJob


        /// <summary>
        /// Gets information about a read set activation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetActivationJob service method.</param>
        /// 
        /// <returns>The response from the GetReadSetActivationJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetActivationJob">REST API Reference for GetReadSetActivationJob Operation</seealso>
        GetReadSetActivationJobResponse GetReadSetActivationJob(GetReadSetActivationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadSetActivationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetActivationJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadSetActivationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetActivationJob">REST API Reference for GetReadSetActivationJob Operation</seealso>
        IAsyncResult BeginGetReadSetActivationJob(GetReadSetActivationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadSetActivationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadSetActivationJob.</param>
        /// 
        /// <returns>Returns a  GetReadSetActivationJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetActivationJob">REST API Reference for GetReadSetActivationJob Operation</seealso>
        GetReadSetActivationJobResponse EndGetReadSetActivationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReadSetExportJob


        /// <summary>
        /// Gets information about a read set export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetExportJob service method.</param>
        /// 
        /// <returns>The response from the GetReadSetExportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetExportJob">REST API Reference for GetReadSetExportJob Operation</seealso>
        GetReadSetExportJobResponse GetReadSetExportJob(GetReadSetExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadSetExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetExportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadSetExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetExportJob">REST API Reference for GetReadSetExportJob Operation</seealso>
        IAsyncResult BeginGetReadSetExportJob(GetReadSetExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadSetExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadSetExportJob.</param>
        /// 
        /// <returns>Returns a  GetReadSetExportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetExportJob">REST API Reference for GetReadSetExportJob Operation</seealso>
        GetReadSetExportJobResponse EndGetReadSetExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReadSetImportJob


        /// <summary>
        /// Gets information about a read set import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetImportJob service method.</param>
        /// 
        /// <returns>The response from the GetReadSetImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetImportJob">REST API Reference for GetReadSetImportJob Operation</seealso>
        GetReadSetImportJobResponse GetReadSetImportJob(GetReadSetImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadSetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadSetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetImportJob">REST API Reference for GetReadSetImportJob Operation</seealso>
        IAsyncResult BeginGetReadSetImportJob(GetReadSetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadSetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadSetImportJob.</param>
        /// 
        /// <returns>Returns a  GetReadSetImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetImportJob">REST API Reference for GetReadSetImportJob Operation</seealso>
        GetReadSetImportJobResponse EndGetReadSetImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReadSetMetadata


        /// <summary>
        /// Gets details about a read set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetMetadata service method.</param>
        /// 
        /// <returns>The response from the GetReadSetMetadata service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetMetadata">REST API Reference for GetReadSetMetadata Operation</seealso>
        GetReadSetMetadataResponse GetReadSetMetadata(GetReadSetMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadSetMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetMetadata operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadSetMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetMetadata">REST API Reference for GetReadSetMetadata Operation</seealso>
        IAsyncResult BeginGetReadSetMetadata(GetReadSetMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadSetMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadSetMetadata.</param>
        /// 
        /// <returns>Returns a  GetReadSetMetadataResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetMetadata">REST API Reference for GetReadSetMetadata Operation</seealso>
        GetReadSetMetadataResponse EndGetReadSetMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReference


        /// <summary>
        /// Gets a reference file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReference service method.</param>
        /// 
        /// <returns>The response from the GetReference service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RangeNotSatisfiableException">
        /// The ranges specified in the request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReference">REST API Reference for GetReference Operation</seealso>
        GetReferenceResponse GetReference(GetReferenceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReference operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReference
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReference">REST API Reference for GetReference Operation</seealso>
        IAsyncResult BeginGetReference(GetReferenceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReference operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReference.</param>
        /// 
        /// <returns>Returns a  GetReferenceResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReference">REST API Reference for GetReference Operation</seealso>
        GetReferenceResponse EndGetReference(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReferenceImportJob


        /// <summary>
        /// Gets information about a reference import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceImportJob service method.</param>
        /// 
        /// <returns>The response from the GetReferenceImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceImportJob">REST API Reference for GetReferenceImportJob Operation</seealso>
        GetReferenceImportJobResponse GetReferenceImportJob(GetReferenceImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReferenceImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReferenceImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceImportJob">REST API Reference for GetReferenceImportJob Operation</seealso>
        IAsyncResult BeginGetReferenceImportJob(GetReferenceImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReferenceImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReferenceImportJob.</param>
        /// 
        /// <returns>Returns a  GetReferenceImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceImportJob">REST API Reference for GetReferenceImportJob Operation</seealso>
        GetReferenceImportJobResponse EndGetReferenceImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReferenceMetadata


        /// <summary>
        /// Gets information about a genome reference's metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceMetadata service method.</param>
        /// 
        /// <returns>The response from the GetReferenceMetadata service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceMetadata">REST API Reference for GetReferenceMetadata Operation</seealso>
        GetReferenceMetadataResponse GetReferenceMetadata(GetReferenceMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReferenceMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceMetadata operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReferenceMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceMetadata">REST API Reference for GetReferenceMetadata Operation</seealso>
        IAsyncResult BeginGetReferenceMetadata(GetReferenceMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReferenceMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReferenceMetadata.</param>
        /// 
        /// <returns>Returns a  GetReferenceMetadataResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceMetadata">REST API Reference for GetReferenceMetadata Operation</seealso>
        GetReferenceMetadataResponse EndGetReferenceMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReferenceStore


        /// <summary>
        /// Gets information about a reference store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceStore service method.</param>
        /// 
        /// <returns>The response from the GetReferenceStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceStore">REST API Reference for GetReferenceStore Operation</seealso>
        GetReferenceStoreResponse GetReferenceStore(GetReferenceStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReferenceStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReferenceStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceStore">REST API Reference for GetReferenceStore Operation</seealso>
        IAsyncResult BeginGetReferenceStore(GetReferenceStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReferenceStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReferenceStore.</param>
        /// 
        /// <returns>Returns a  GetReferenceStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceStore">REST API Reference for GetReferenceStore Operation</seealso>
        GetReferenceStoreResponse EndGetReferenceStore(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRun


        /// <summary>
        /// Gets information about a workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRun service method.</param>
        /// 
        /// <returns>The response from the GetRun service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRun">REST API Reference for GetRun Operation</seealso>
        GetRunResponse GetRun(GetRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRun operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRun">REST API Reference for GetRun Operation</seealso>
        IAsyncResult BeginGetRun(GetRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRun.</param>
        /// 
        /// <returns>Returns a  GetRunResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRun">REST API Reference for GetRun Operation</seealso>
        GetRunResponse EndGetRun(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRunGroup


        /// <summary>
        /// Gets information about a workflow run group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRunGroup service method.</param>
        /// 
        /// <returns>The response from the GetRunGroup service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRunGroup">REST API Reference for GetRunGroup Operation</seealso>
        GetRunGroupResponse GetRunGroup(GetRunGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRunGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRunGroup operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRunGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRunGroup">REST API Reference for GetRunGroup Operation</seealso>
        IAsyncResult BeginGetRunGroup(GetRunGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRunGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRunGroup.</param>
        /// 
        /// <returns>Returns a  GetRunGroupResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRunGroup">REST API Reference for GetRunGroup Operation</seealso>
        GetRunGroupResponse EndGetRunGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRunTask


        /// <summary>
        /// Gets information about a workflow run task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRunTask service method.</param>
        /// 
        /// <returns>The response from the GetRunTask service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRunTask">REST API Reference for GetRunTask Operation</seealso>
        GetRunTaskResponse GetRunTask(GetRunTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRunTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRunTask operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRunTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRunTask">REST API Reference for GetRunTask Operation</seealso>
        IAsyncResult BeginGetRunTask(GetRunTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRunTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRunTask.</param>
        /// 
        /// <returns>Returns a  GetRunTaskResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRunTask">REST API Reference for GetRunTask Operation</seealso>
        GetRunTaskResponse EndGetRunTask(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSequenceStore


        /// <summary>
        /// Gets information about a sequence store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSequenceStore service method.</param>
        /// 
        /// <returns>The response from the GetSequenceStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetSequenceStore">REST API Reference for GetSequenceStore Operation</seealso>
        GetSequenceStoreResponse GetSequenceStore(GetSequenceStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSequenceStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSequenceStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSequenceStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetSequenceStore">REST API Reference for GetSequenceStore Operation</seealso>
        IAsyncResult BeginGetSequenceStore(GetSequenceStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSequenceStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSequenceStore.</param>
        /// 
        /// <returns>Returns a  GetSequenceStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetSequenceStore">REST API Reference for GetSequenceStore Operation</seealso>
        GetSequenceStoreResponse EndGetSequenceStore(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVariantImportJob


        /// <summary>
        /// Gets information about a variant import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVariantImportJob service method.</param>
        /// 
        /// <returns>The response from the GetVariantImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetVariantImportJob">REST API Reference for GetVariantImportJob Operation</seealso>
        GetVariantImportJobResponse GetVariantImportJob(GetVariantImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVariantImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVariantImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVariantImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetVariantImportJob">REST API Reference for GetVariantImportJob Operation</seealso>
        IAsyncResult BeginGetVariantImportJob(GetVariantImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVariantImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVariantImportJob.</param>
        /// 
        /// <returns>Returns a  GetVariantImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetVariantImportJob">REST API Reference for GetVariantImportJob Operation</seealso>
        GetVariantImportJobResponse EndGetVariantImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVariantStore


        /// <summary>
        /// Gets information about a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVariantStore service method.</param>
        /// 
        /// <returns>The response from the GetVariantStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetVariantStore">REST API Reference for GetVariantStore Operation</seealso>
        GetVariantStoreResponse GetVariantStore(GetVariantStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVariantStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVariantStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVariantStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetVariantStore">REST API Reference for GetVariantStore Operation</seealso>
        IAsyncResult BeginGetVariantStore(GetVariantStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVariantStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVariantStore.</param>
        /// 
        /// <returns>Returns a  GetVariantStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetVariantStore">REST API Reference for GetVariantStore Operation</seealso>
        GetVariantStoreResponse EndGetVariantStore(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkflow


        /// <summary>
        /// Gets information about a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// 
        /// <returns>The response from the GetWorkflow service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        GetWorkflowResponse GetWorkflow(GetWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        IAsyncResult BeginGetWorkflow(GetWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflow.</param>
        /// 
        /// <returns>Returns a  GetWorkflowResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        GetWorkflowResponse EndGetWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAnnotationImportJobs


        /// <summary>
        /// Retrieves a list of annotation import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnnotationImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListAnnotationImportJobs service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListAnnotationImportJobs">REST API Reference for ListAnnotationImportJobs Operation</seealso>
        ListAnnotationImportJobsResponse ListAnnotationImportJobs(ListAnnotationImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnnotationImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnnotationImportJobs operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnnotationImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListAnnotationImportJobs">REST API Reference for ListAnnotationImportJobs Operation</seealso>
        IAsyncResult BeginListAnnotationImportJobs(ListAnnotationImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnnotationImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnnotationImportJobs.</param>
        /// 
        /// <returns>Returns a  ListAnnotationImportJobsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListAnnotationImportJobs">REST API Reference for ListAnnotationImportJobs Operation</seealso>
        ListAnnotationImportJobsResponse EndListAnnotationImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAnnotationStores


        /// <summary>
        /// Retrieves a list of annotation stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnnotationStores service method.</param>
        /// 
        /// <returns>The response from the ListAnnotationStores service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListAnnotationStores">REST API Reference for ListAnnotationStores Operation</seealso>
        ListAnnotationStoresResponse ListAnnotationStores(ListAnnotationStoresRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnnotationStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnnotationStores operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnnotationStores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListAnnotationStores">REST API Reference for ListAnnotationStores Operation</seealso>
        IAsyncResult BeginListAnnotationStores(ListAnnotationStoresRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnnotationStores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnnotationStores.</param>
        /// 
        /// <returns>Returns a  ListAnnotationStoresResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListAnnotationStores">REST API Reference for ListAnnotationStores Operation</seealso>
        ListAnnotationStoresResponse EndListAnnotationStores(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReadSetActivationJobs


        /// <summary>
        /// Retrieves a list of read set activation jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetActivationJobs service method.</param>
        /// 
        /// <returns>The response from the ListReadSetActivationJobs service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetActivationJobs">REST API Reference for ListReadSetActivationJobs Operation</seealso>
        ListReadSetActivationJobsResponse ListReadSetActivationJobs(ListReadSetActivationJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReadSetActivationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetActivationJobs operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReadSetActivationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetActivationJobs">REST API Reference for ListReadSetActivationJobs Operation</seealso>
        IAsyncResult BeginListReadSetActivationJobs(ListReadSetActivationJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReadSetActivationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReadSetActivationJobs.</param>
        /// 
        /// <returns>Returns a  ListReadSetActivationJobsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetActivationJobs">REST API Reference for ListReadSetActivationJobs Operation</seealso>
        ListReadSetActivationJobsResponse EndListReadSetActivationJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReadSetExportJobs


        /// <summary>
        /// Retrieves a list of read set export jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListReadSetExportJobs service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetExportJobs">REST API Reference for ListReadSetExportJobs Operation</seealso>
        ListReadSetExportJobsResponse ListReadSetExportJobs(ListReadSetExportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReadSetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetExportJobs operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReadSetExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetExportJobs">REST API Reference for ListReadSetExportJobs Operation</seealso>
        IAsyncResult BeginListReadSetExportJobs(ListReadSetExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReadSetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReadSetExportJobs.</param>
        /// 
        /// <returns>Returns a  ListReadSetExportJobsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetExportJobs">REST API Reference for ListReadSetExportJobs Operation</seealso>
        ListReadSetExportJobsResponse EndListReadSetExportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReadSetImportJobs


        /// <summary>
        /// Retrieves a list of read set import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListReadSetImportJobs service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetImportJobs">REST API Reference for ListReadSetImportJobs Operation</seealso>
        ListReadSetImportJobsResponse ListReadSetImportJobs(ListReadSetImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReadSetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetImportJobs operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReadSetImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetImportJobs">REST API Reference for ListReadSetImportJobs Operation</seealso>
        IAsyncResult BeginListReadSetImportJobs(ListReadSetImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReadSetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReadSetImportJobs.</param>
        /// 
        /// <returns>Returns a  ListReadSetImportJobsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetImportJobs">REST API Reference for ListReadSetImportJobs Operation</seealso>
        ListReadSetImportJobsResponse EndListReadSetImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReadSets


        /// <summary>
        /// Retrieves a list of read sets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSets service method.</param>
        /// 
        /// <returns>The response from the ListReadSets service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSets">REST API Reference for ListReadSets Operation</seealso>
        ListReadSetsResponse ListReadSets(ListReadSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReadSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReadSets operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReadSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSets">REST API Reference for ListReadSets Operation</seealso>
        IAsyncResult BeginListReadSets(ListReadSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReadSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReadSets.</param>
        /// 
        /// <returns>Returns a  ListReadSetsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSets">REST API Reference for ListReadSets Operation</seealso>
        ListReadSetsResponse EndListReadSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReferenceImportJobs


        /// <summary>
        /// Retrieves a list of reference import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReferenceImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListReferenceImportJobs service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferenceImportJobs">REST API Reference for ListReferenceImportJobs Operation</seealso>
        ListReferenceImportJobsResponse ListReferenceImportJobs(ListReferenceImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReferenceImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReferenceImportJobs operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReferenceImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferenceImportJobs">REST API Reference for ListReferenceImportJobs Operation</seealso>
        IAsyncResult BeginListReferenceImportJobs(ListReferenceImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReferenceImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReferenceImportJobs.</param>
        /// 
        /// <returns>Returns a  ListReferenceImportJobsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferenceImportJobs">REST API Reference for ListReferenceImportJobs Operation</seealso>
        ListReferenceImportJobsResponse EndListReferenceImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReferences


        /// <summary>
        /// Retrieves a list of references.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReferences service method.</param>
        /// 
        /// <returns>The response from the ListReferences service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferences">REST API Reference for ListReferences Operation</seealso>
        ListReferencesResponse ListReferences(ListReferencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReferences operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferences">REST API Reference for ListReferences Operation</seealso>
        IAsyncResult BeginListReferences(ListReferencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReferences.</param>
        /// 
        /// <returns>Returns a  ListReferencesResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferences">REST API Reference for ListReferences Operation</seealso>
        ListReferencesResponse EndListReferences(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReferenceStores


        /// <summary>
        /// Retrieves a list of reference stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReferenceStores service method.</param>
        /// 
        /// <returns>The response from the ListReferenceStores service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferenceStores">REST API Reference for ListReferenceStores Operation</seealso>
        ListReferenceStoresResponse ListReferenceStores(ListReferenceStoresRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReferenceStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReferenceStores operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReferenceStores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferenceStores">REST API Reference for ListReferenceStores Operation</seealso>
        IAsyncResult BeginListReferenceStores(ListReferenceStoresRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReferenceStores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReferenceStores.</param>
        /// 
        /// <returns>Returns a  ListReferenceStoresResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferenceStores">REST API Reference for ListReferenceStores Operation</seealso>
        ListReferenceStoresResponse EndListReferenceStores(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRunGroups


        /// <summary>
        /// Retrieves a list of run groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRunGroups service method.</param>
        /// 
        /// <returns>The response from the ListRunGroups service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRunGroups">REST API Reference for ListRunGroups Operation</seealso>
        ListRunGroupsResponse ListRunGroups(ListRunGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRunGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRunGroups operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRunGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRunGroups">REST API Reference for ListRunGroups Operation</seealso>
        IAsyncResult BeginListRunGroups(ListRunGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRunGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRunGroups.</param>
        /// 
        /// <returns>Returns a  ListRunGroupsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRunGroups">REST API Reference for ListRunGroups Operation</seealso>
        ListRunGroupsResponse EndListRunGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRuns


        /// <summary>
        /// Retrieves a list of runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuns service method.</param>
        /// 
        /// <returns>The response from the ListRuns service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRuns">REST API Reference for ListRuns Operation</seealso>
        ListRunsResponse ListRuns(ListRunsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuns operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRuns">REST API Reference for ListRuns Operation</seealso>
        IAsyncResult BeginListRuns(ListRunsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuns.</param>
        /// 
        /// <returns>Returns a  ListRunsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRuns">REST API Reference for ListRuns Operation</seealso>
        ListRunsResponse EndListRuns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRunTasks


        /// <summary>
        /// Retrieves a list of tasks for a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRunTasks service method.</param>
        /// 
        /// <returns>The response from the ListRunTasks service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRunTasks">REST API Reference for ListRunTasks Operation</seealso>
        ListRunTasksResponse ListRunTasks(ListRunTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRunTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRunTasks operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRunTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRunTasks">REST API Reference for ListRunTasks Operation</seealso>
        IAsyncResult BeginListRunTasks(ListRunTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRunTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRunTasks.</param>
        /// 
        /// <returns>Returns a  ListRunTasksResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRunTasks">REST API Reference for ListRunTasks Operation</seealso>
        ListRunTasksResponse EndListRunTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSequenceStores


        /// <summary>
        /// Retrieves a list of sequence stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSequenceStores service method.</param>
        /// 
        /// <returns>The response from the ListSequenceStores service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListSequenceStores">REST API Reference for ListSequenceStores Operation</seealso>
        ListSequenceStoresResponse ListSequenceStores(ListSequenceStoresRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSequenceStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSequenceStores operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSequenceStores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListSequenceStores">REST API Reference for ListSequenceStores Operation</seealso>
        IAsyncResult BeginListSequenceStores(ListSequenceStoresRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSequenceStores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSequenceStores.</param>
        /// 
        /// <returns>Returns a  ListSequenceStoresResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListSequenceStores">REST API Reference for ListSequenceStores Operation</seealso>
        ListSequenceStoresResponse EndListSequenceStores(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVariantImportJobs


        /// <summary>
        /// Retrieves a list of variant import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVariantImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListVariantImportJobs service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListVariantImportJobs">REST API Reference for ListVariantImportJobs Operation</seealso>
        ListVariantImportJobsResponse ListVariantImportJobs(ListVariantImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVariantImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVariantImportJobs operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVariantImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListVariantImportJobs">REST API Reference for ListVariantImportJobs Operation</seealso>
        IAsyncResult BeginListVariantImportJobs(ListVariantImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVariantImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVariantImportJobs.</param>
        /// 
        /// <returns>Returns a  ListVariantImportJobsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListVariantImportJobs">REST API Reference for ListVariantImportJobs Operation</seealso>
        ListVariantImportJobsResponse EndListVariantImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVariantStores


        /// <summary>
        /// Retrieves a list of variant stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVariantStores service method.</param>
        /// 
        /// <returns>The response from the ListVariantStores service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListVariantStores">REST API Reference for ListVariantStores Operation</seealso>
        ListVariantStoresResponse ListVariantStores(ListVariantStoresRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVariantStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVariantStores operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVariantStores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListVariantStores">REST API Reference for ListVariantStores Operation</seealso>
        IAsyncResult BeginListVariantStores(ListVariantStoresRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVariantStores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVariantStores.</param>
        /// 
        /// <returns>Returns a  ListVariantStoresResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListVariantStores">REST API Reference for ListVariantStores Operation</seealso>
        ListVariantStoresResponse EndListVariantStores(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkflows


        /// <summary>
        /// Retrieves a list of workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        IAsyncResult BeginListWorkflows(ListWorkflowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflows.</param>
        /// 
        /// <returns>Returns a  ListWorkflowsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        ListWorkflowsResponse EndListWorkflows(IAsyncResult asyncResult);

        #endregion
        
        #region  StartAnnotationImportJob


        /// <summary>
        /// Starts an annotation import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAnnotationImportJob service method.</param>
        /// 
        /// <returns>The response from the StartAnnotationImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartAnnotationImportJob">REST API Reference for StartAnnotationImportJob Operation</seealso>
        StartAnnotationImportJobResponse StartAnnotationImportJob(StartAnnotationImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartAnnotationImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAnnotationImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAnnotationImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartAnnotationImportJob">REST API Reference for StartAnnotationImportJob Operation</seealso>
        IAsyncResult BeginStartAnnotationImportJob(StartAnnotationImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartAnnotationImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAnnotationImportJob.</param>
        /// 
        /// <returns>Returns a  StartAnnotationImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartAnnotationImportJob">REST API Reference for StartAnnotationImportJob Operation</seealso>
        StartAnnotationImportJobResponse EndStartAnnotationImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartReadSetActivationJob


        /// <summary>
        /// Starts a read set activation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetActivationJob service method.</param>
        /// 
        /// <returns>The response from the StartReadSetActivationJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetActivationJob">REST API Reference for StartReadSetActivationJob Operation</seealso>
        StartReadSetActivationJobResponse StartReadSetActivationJob(StartReadSetActivationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartReadSetActivationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetActivationJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReadSetActivationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetActivationJob">REST API Reference for StartReadSetActivationJob Operation</seealso>
        IAsyncResult BeginStartReadSetActivationJob(StartReadSetActivationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartReadSetActivationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReadSetActivationJob.</param>
        /// 
        /// <returns>Returns a  StartReadSetActivationJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetActivationJob">REST API Reference for StartReadSetActivationJob Operation</seealso>
        StartReadSetActivationJobResponse EndStartReadSetActivationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartReadSetExportJob


        /// <summary>
        /// Starts a read set export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetExportJob service method.</param>
        /// 
        /// <returns>The response from the StartReadSetExportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetExportJob">REST API Reference for StartReadSetExportJob Operation</seealso>
        StartReadSetExportJobResponse StartReadSetExportJob(StartReadSetExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartReadSetExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetExportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReadSetExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetExportJob">REST API Reference for StartReadSetExportJob Operation</seealso>
        IAsyncResult BeginStartReadSetExportJob(StartReadSetExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartReadSetExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReadSetExportJob.</param>
        /// 
        /// <returns>Returns a  StartReadSetExportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetExportJob">REST API Reference for StartReadSetExportJob Operation</seealso>
        StartReadSetExportJobResponse EndStartReadSetExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartReadSetImportJob


        /// <summary>
        /// Starts a read set import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetImportJob service method.</param>
        /// 
        /// <returns>The response from the StartReadSetImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetImportJob">REST API Reference for StartReadSetImportJob Operation</seealso>
        StartReadSetImportJobResponse StartReadSetImportJob(StartReadSetImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartReadSetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReadSetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetImportJob">REST API Reference for StartReadSetImportJob Operation</seealso>
        IAsyncResult BeginStartReadSetImportJob(StartReadSetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartReadSetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReadSetImportJob.</param>
        /// 
        /// <returns>Returns a  StartReadSetImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetImportJob">REST API Reference for StartReadSetImportJob Operation</seealso>
        StartReadSetImportJobResponse EndStartReadSetImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartReferenceImportJob


        /// <summary>
        /// Starts a reference import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReferenceImportJob service method.</param>
        /// 
        /// <returns>The response from the StartReferenceImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReferenceImportJob">REST API Reference for StartReferenceImportJob Operation</seealso>
        StartReferenceImportJobResponse StartReferenceImportJob(StartReferenceImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartReferenceImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReferenceImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReferenceImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReferenceImportJob">REST API Reference for StartReferenceImportJob Operation</seealso>
        IAsyncResult BeginStartReferenceImportJob(StartReferenceImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartReferenceImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReferenceImportJob.</param>
        /// 
        /// <returns>Returns a  StartReferenceImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReferenceImportJob">REST API Reference for StartReferenceImportJob Operation</seealso>
        StartReferenceImportJobResponse EndStartReferenceImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartRun


        /// <summary>
        /// Starts a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRun service method.</param>
        /// 
        /// <returns>The response from the StartRun service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartRun">REST API Reference for StartRun Operation</seealso>
        StartRunResponse StartRun(StartRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRun operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartRun">REST API Reference for StartRun Operation</seealso>
        IAsyncResult BeginStartRun(StartRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRun.</param>
        /// 
        /// <returns>Returns a  StartRunResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartRun">REST API Reference for StartRun Operation</seealso>
        StartRunResponse EndStartRun(IAsyncResult asyncResult);

        #endregion
        
        #region  StartVariantImportJob


        /// <summary>
        /// Starts a variant import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVariantImportJob service method.</param>
        /// 
        /// <returns>The response from the StartVariantImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartVariantImportJob">REST API Reference for StartVariantImportJob Operation</seealso>
        StartVariantImportJobResponse StartVariantImportJob(StartVariantImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartVariantImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartVariantImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartVariantImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartVariantImportJob">REST API Reference for StartVariantImportJob Operation</seealso>
        IAsyncResult BeginStartVariantImportJob(StartVariantImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartVariantImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartVariantImportJob.</param>
        /// 
        /// <returns>Returns a  StartVariantImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartVariantImportJob">REST API Reference for StartVariantImportJob Operation</seealso>
        StartVariantImportJobResponse EndStartVariantImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAnnotationStore


        /// <summary>
        /// Updates an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnnotationStore service method.</param>
        /// 
        /// <returns>The response from the UpdateAnnotationStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateAnnotationStore">REST API Reference for UpdateAnnotationStore Operation</seealso>
        UpdateAnnotationStoreResponse UpdateAnnotationStore(UpdateAnnotationStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnnotationStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAnnotationStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateAnnotationStore">REST API Reference for UpdateAnnotationStore Operation</seealso>
        IAsyncResult BeginUpdateAnnotationStore(UpdateAnnotationStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAnnotationStore.</param>
        /// 
        /// <returns>Returns a  UpdateAnnotationStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateAnnotationStore">REST API Reference for UpdateAnnotationStore Operation</seealso>
        UpdateAnnotationStoreResponse EndUpdateAnnotationStore(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRunGroup


        /// <summary>
        /// Updates a run group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRunGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateRunGroup service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateRunGroup">REST API Reference for UpdateRunGroup Operation</seealso>
        UpdateRunGroupResponse UpdateRunGroup(UpdateRunGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRunGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRunGroup operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRunGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateRunGroup">REST API Reference for UpdateRunGroup Operation</seealso>
        IAsyncResult BeginUpdateRunGroup(UpdateRunGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRunGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRunGroup.</param>
        /// 
        /// <returns>Returns a  UpdateRunGroupResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateRunGroup">REST API Reference for UpdateRunGroup Operation</seealso>
        UpdateRunGroupResponse EndUpdateRunGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVariantStore


        /// <summary>
        /// Updates a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVariantStore service method.</param>
        /// 
        /// <returns>The response from the UpdateVariantStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateVariantStore">REST API Reference for UpdateVariantStore Operation</seealso>
        UpdateVariantStoreResponse UpdateVariantStore(UpdateVariantStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVariantStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVariantStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVariantStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateVariantStore">REST API Reference for UpdateVariantStore Operation</seealso>
        IAsyncResult BeginUpdateVariantStore(UpdateVariantStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVariantStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVariantStore.</param>
        /// 
        /// <returns>Returns a  UpdateVariantStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateVariantStore">REST API Reference for UpdateVariantStore Operation</seealso>
        UpdateVariantStoreResponse EndUpdateVariantStore(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkflow


        /// <summary>
        /// Updates a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkflow service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        UpdateWorkflowResponse UpdateWorkflow(UpdateWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        IAsyncResult BeginUpdateWorkflow(UpdateWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkflow.</param>
        /// 
        /// <returns>Returns a  UpdateWorkflowResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        UpdateWorkflowResponse EndUpdateWorkflow(IAsyncResult asyncResult);

        #endregion
        
    }
}