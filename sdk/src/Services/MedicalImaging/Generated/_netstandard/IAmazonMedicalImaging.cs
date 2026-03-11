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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MedicalImaging.Model;

#pragma warning disable CS1570
namespace Amazon.MedicalImaging
{
    /// <summary>
    /// <para>Interface for accessing MedicalImaging</para>
    ///
    /// This is the <i>AWS HealthImaging API Reference</i>. For an introduction to the service,
    /// see <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/what-is.html">What
    /// is AWS HealthImaging?</a> in the <i>AWS HealthImaging Developer Guide</i>.
    /// </summary>
    public partial interface IAmazonMedicalImaging : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMedicalImagingPaginatorFactory Paginators { get; }
#endif
                
        #region  CopyImageSet



        /// <summary>
        /// Copy an image set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyImageSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyImageSet service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ServiceQuotaExceededException">
        /// The request caused a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/CopyImageSet">REST API Reference for CopyImageSet Operation</seealso>
        Task<CopyImageSetResponse> CopyImageSetAsync(CopyImageSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDatastore



        /// <summary>
        /// Create a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatastore service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ServiceQuotaExceededException">
        /// The request caused a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/CreateDatastore">REST API Reference for CreateDatastore Operation</seealso>
        Task<CreateDatastoreResponse> CreateDatastoreAsync(CreateDatastoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDatastore



        /// <summary>
        /// Delete a data store.
        /// 
        ///  <note> 
        /// <para>
        /// Before a data store can be deleted, you must first delete all image sets within it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatastore service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/DeleteDatastore">REST API Reference for DeleteDatastore Operation</seealso>
        Task<DeleteDatastoreResponse> DeleteDatastoreAsync(DeleteDatastoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteImageSet



        /// <summary>
        /// Delete an image set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteImageSet service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/DeleteImageSet">REST API Reference for DeleteImageSet Operation</seealso>
        Task<DeleteImageSetResponse> DeleteImageSetAsync(DeleteImageSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDatastore



        /// <summary>
        /// Get data store properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatastore service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetDatastore">REST API Reference for GetDatastore Operation</seealso>
        Task<GetDatastoreResponse> GetDatastoreAsync(GetDatastoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDICOMImportJob



        /// <summary>
        /// Get the import job properties to learn more about the job or job progress.
        /// 
        ///  <note> 
        /// <para>
        /// The <c>jobStatus</c> refers to the execution of the import job. Therefore, an import
        /// job can return a <c>jobStatus</c> as <c>COMPLETED</c> even if validation issues are
        /// discovered during the import process. If a <c>jobStatus</c> returns as <c>COMPLETED</c>,
        /// we still recommend you review the output manifests written to S3, as they provide
        /// details on the success or failure of individual P10 object imports.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDICOMImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDICOMImportJob service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetDICOMImportJob">REST API Reference for GetDICOMImportJob Operation</seealso>
        Task<GetDICOMImportJobResponse> GetDICOMImportJobAsync(GetDICOMImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetImageFrame



        /// <summary>
        /// Get an image frame (pixel data) for an image set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageFrame service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImageFrame service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetImageFrame">REST API Reference for GetImageFrame Operation</seealso>
        Task<GetImageFrameResponse> GetImageFrameAsync(GetImageFrameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetImageSet



        /// <summary>
        /// Get image set properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImageSet service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetImageSet">REST API Reference for GetImageSet Operation</seealso>
        Task<GetImageSetResponse> GetImageSetAsync(GetImageSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetImageSetMetadata



        /// <summary>
        /// Get metadata attributes for an image set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageSetMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImageSetMetadata service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetImageSetMetadata">REST API Reference for GetImageSetMetadata Operation</seealso>
        Task<GetImageSetMetadataResponse> GetImageSetMetadataAsync(GetImageSetMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDatastores



        /// <summary>
        /// List data stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatastores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatastores service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListDatastores">REST API Reference for ListDatastores Operation</seealso>
        Task<ListDatastoresResponse> ListDatastoresAsync(ListDatastoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDICOMImportJobs



        /// <summary>
        /// List import jobs created for a specific data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDICOMImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDICOMImportJobs service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListDICOMImportJobs">REST API Reference for ListDICOMImportJobs Operation</seealso>
        Task<ListDICOMImportJobsResponse> ListDICOMImportJobsAsync(ListDICOMImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListImageSetVersions



        /// <summary>
        /// List image set versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageSetVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImageSetVersions service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListImageSetVersions">REST API Reference for ListImageSetVersions Operation</seealso>
        Task<ListImageSetVersionsResponse> ListImageSetVersionsAsync(ListImageSetVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all tags associated with a medical imaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchImageSets



        /// <summary>
        /// Search image sets based on defined input attributes.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>SearchImageSets</c> accepts a single search query parameter and returns a paginated
        /// response of all image sets that have the matching criteria. All date range queries
        /// must be input as <c>(lowerBound, upperBound)</c>.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>SearchImageSets</c> uses the <c>updatedAt</c> field for sorting in
        /// descending order from newest to oldest.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchImageSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchImageSets service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/SearchImageSets">REST API Reference for SearchImageSets Operation</seealso>
        Task<SearchImageSetsResponse> SearchImageSetsAsync(SearchImageSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDICOMImportJob



        /// <summary>
        /// Start importing bulk data into an <c>ACTIVE</c> data store. The import job imports
        /// DICOM P10 files found in the S3 prefix specified by the <c>inputS3Uri</c> parameter.
        /// The import job stores processing results in the file specified by the <c>outputS3Uri</c>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDICOMImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDICOMImportJob service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ServiceQuotaExceededException">
        /// The request caused a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/StartDICOMImportJob">REST API Reference for StartDICOMImportJob Operation</seealso>
        Task<StartDICOMImportJobResponse> StartDICOMImportJobAsync(StartDICOMImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds a user-specifed key and value tag to a medical imaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a medical imaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateImageSetMetadata



        /// <summary>
        /// Update image set metadata attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImageSetMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateImageSetMetadata service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ServiceQuotaExceededException">
        /// The request caused a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/UpdateImageSetMetadata">REST API Reference for UpdateImageSetMetadata Operation</seealso>
        Task<UpdateImageSetMetadataResponse> UpdateImageSetMetadataAsync(UpdateImageSetMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonMedicalImagingConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonMedicalImagingConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonMedicalImagingConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonMedicalImagingConfig to create AmazonMedicalImagingClient");
            }

            return awsCredentials == null ? 
                    new AmazonMedicalImagingClient(serviceClientConfig) :
                    new AmazonMedicalImagingClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}