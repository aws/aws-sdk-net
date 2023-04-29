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
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IOmicsPaginatorFactory Paginators { get; }

        
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
        /// Deletes one or more read sets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteReadSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchDeleteReadSetResponse> BatchDeleteReadSetAsync(BatchDeleteReadSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Cancels an annotation import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelAnnotationImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CancelAnnotationImportJobResponse> CancelAnnotationImportJobAsync(CancelAnnotationImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Cancels a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CancelRunResponse> CancelRunAsync(CancelRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Cancels a variant import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelVariantImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CancelVariantImportJobResponse> CancelVariantImportJobAsync(CancelVariantImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnnotationStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAnnotationStoreResponse> CreateAnnotationStoreAsync(CreateAnnotationStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a reference store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReferenceStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateReferenceStoreResponse> CreateReferenceStoreAsync(CreateReferenceStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a run group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRunGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateRunGroupResponse> CreateRunGroupAsync(CreateRunGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a sequence store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSequenceStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateSequenceStoreResponse> CreateSequenceStoreAsync(CreateSequenceStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVariantStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateVariantStoreResponse> CreateVariantStoreAsync(CreateVariantStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateWorkflowResponse> CreateWorkflowAsync(CreateWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnnotationStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAnnotationStoreResponse> DeleteAnnotationStoreAsync(DeleteAnnotationStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a genome reference.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteReferenceResponse> DeleteReferenceAsync(DeleteReferenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a genome reference store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReferenceStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteReferenceStoreResponse> DeleteReferenceStoreAsync(DeleteReferenceStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteRunResponse> DeleteRunAsync(DeleteRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a workflow run group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRunGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteRunGroupResponse> DeleteRunGroupAsync(DeleteRunGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a sequence store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSequenceStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteSequenceStoreResponse> DeleteSequenceStoreAsync(DeleteSequenceStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVariantStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteVariantStoreResponse> DeleteVariantStoreAsync(DeleteVariantStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteWorkflowResponse> DeleteWorkflowAsync(DeleteWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about an annotation import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnnotationImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAnnotationImportJobResponse> GetAnnotationImportJobAsync(GetAnnotationImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnnotationStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAnnotationStoreResponse> GetAnnotationStoreAsync(GetAnnotationStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a file from a read set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetReadSetResponse> GetReadSetAsync(GetReadSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a read set activation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetActivationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetReadSetActivationJobResponse> GetReadSetActivationJobAsync(GetReadSetActivationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a read set export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetReadSetExportJobResponse> GetReadSetExportJobAsync(GetReadSetExportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a read set import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetReadSetImportJobResponse> GetReadSetImportJobAsync(GetReadSetImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets details about a read set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetReadSetMetadataResponse> GetReadSetMetadataAsync(GetReadSetMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a reference file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetReferenceResponse> GetReferenceAsync(GetReferenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a reference import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetReferenceImportJobResponse> GetReferenceImportJobAsync(GetReferenceImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a genome reference's metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetReferenceMetadataResponse> GetReferenceMetadataAsync(GetReferenceMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a reference store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetReferenceStoreResponse> GetReferenceStoreAsync(GetReferenceStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetRunResponse> GetRunAsync(GetRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a workflow run group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRunGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetRunGroupResponse> GetRunGroupAsync(GetRunGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a workflow run task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRunTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetRunTaskResponse> GetRunTaskAsync(GetRunTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a sequence store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSequenceStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSequenceStoreResponse> GetSequenceStoreAsync(GetSequenceStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a variant import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVariantImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetVariantImportJobResponse> GetVariantImportJobAsync(GetVariantImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVariantStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetVariantStoreResponse> GetVariantStoreAsync(GetVariantStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetWorkflowResponse> GetWorkflowAsync(GetWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of annotation import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnnotationImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAnnotationImportJobsResponse> ListAnnotationImportJobsAsync(ListAnnotationImportJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of annotation stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnnotationStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAnnotationStoresResponse> ListAnnotationStoresAsync(ListAnnotationStoresRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of read set activation jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetActivationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListReadSetActivationJobsResponse> ListReadSetActivationJobsAsync(ListReadSetActivationJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of read set export jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListReadSetExportJobsResponse> ListReadSetExportJobsAsync(ListReadSetExportJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of read set import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListReadSetImportJobsResponse> ListReadSetImportJobsAsync(ListReadSetImportJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of read sets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListReadSetsResponse> ListReadSetsAsync(ListReadSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of reference import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReferenceImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListReferenceImportJobsResponse> ListReferenceImportJobsAsync(ListReferenceImportJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of references.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListReferencesResponse> ListReferencesAsync(ListReferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of reference stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReferenceStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListReferenceStoresResponse> ListReferenceStoresAsync(ListReferenceStoresRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of run groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRunGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListRunGroupsResponse> ListRunGroupsAsync(ListRunGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListRunsResponse> ListRunsAsync(ListRunsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of tasks for a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRunTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListRunTasksResponse> ListRunTasksAsync(ListRunTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of sequence stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSequenceStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSequenceStoresResponse> ListSequenceStoresAsync(ListSequenceStoresRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of variant import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVariantImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListVariantImportJobsResponse> ListVariantImportJobsAsync(ListVariantImportJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of variant stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVariantStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListVariantStoresResponse> ListVariantStoresAsync(ListVariantStoresRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListWorkflowsResponse> ListWorkflowsAsync(ListWorkflowsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts an annotation import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAnnotationImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartAnnotationImportJobResponse> StartAnnotationImportJobAsync(StartAnnotationImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartReadSetActivationJob


        /// <summary>
        /// Activates an archived read set. To reduce storage charges, Amazon Omics archives unused
        /// read sets after 30 days.
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
        /// Activates an archived read set. To reduce storage charges, Amazon Omics archives unused
        /// read sets after 30 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetActivationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartReadSetActivationJobResponse> StartReadSetActivationJobAsync(StartReadSetActivationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartReadSetExportJob


        /// <summary>
        /// Exports a read set to Amazon S3.
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
        /// Exports a read set to Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartReadSetExportJobResponse> StartReadSetExportJobAsync(StartReadSetExportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts a read set import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartReadSetImportJobResponse> StartReadSetImportJobAsync(StartReadSetImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts a reference import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReferenceImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartReferenceImportJobResponse> StartReferenceImportJobAsync(StartReferenceImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartRunResponse> StartRunAsync(StartRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts a variant import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVariantImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartVariantImportJobResponse> StartVariantImportJobAsync(StartVariantImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnnotationStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAnnotationStoreResponse> UpdateAnnotationStoreAsync(UpdateAnnotationStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a run group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRunGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateRunGroupResponse> UpdateRunGroupAsync(UpdateRunGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVariantStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateVariantStoreResponse> UpdateVariantStoreAsync(UpdateVariantStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateWorkflowResponse> UpdateWorkflowAsync(UpdateWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}