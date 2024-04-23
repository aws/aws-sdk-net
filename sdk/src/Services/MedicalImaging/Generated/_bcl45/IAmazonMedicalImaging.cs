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

namespace Amazon.MedicalImaging
{
    /// <summary>
    /// <para>Interface for accessing MedicalImaging</para>
    ///
    /// This is the <i>AWS HealthImaging API Reference</i>. AWS HealthImaging is a HIPAA eligible
    /// service that empowers healthcare providers, life science organizations, and their
    /// software partners to store, analyze, and share medical images in the cloud at petabyte
    /// scale. For an introduction to the service, see the <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/what-is.html">
    /// <i>AWS HealthImaging Developer Guide</i> </a>.
    /// 
    ///  <note> 
    /// <para>
    /// We recommend using one of the AWS Software Development Kits (SDKs) for your programming
    /// language, as they take care of request authentication, serialization, and connection
    /// management. For more information, see <a href="http://aws.amazon.com/developer/tools">Tools
    /// to build on AWS</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// The following sections list AWS HealthImaging API actions categorized according to
    /// functionality. Links are provided to actions within this Reference, along with links
    /// back to corresponding sections in the <i>AWS HealthImaging Developer Guide</i> where
    /// you can view tested code examples.
    /// </para>
    ///  
    /// <para>
    ///  <b>Data store actions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_CreateDatastore.html">CreateDatastore</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/create-data-store.html">Creating
    /// a data store</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_GetDatastore.html">GetDatastore</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/get-data-store.html">Getting
    /// data store properties</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_ListDatastores.html">ListDatastores</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/list-data-stores.html">Listing
    /// data stores</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_DeleteDatastore.html">DeleteDatastore</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/delete-data-store.html">Deleting
    /// a data store</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Import job actions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_StartDICOMImportJob.html">StartDICOMImportJob</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/start-dicom-import-job.html">Starting
    /// an import job</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_GetDICOMImportJob.html">GetDICOMImportJob</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/get-dicom-import-job.html">Getting
    /// import job properties</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_ListDICOMImportJobs.html">ListDICOMImportJobs</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/list-dicom-import-jobs.html">Listing
    /// import jobs</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Image set access actions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_SearchImageSets.html">SearchImageSets</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/search-image-sets.html">Searching
    /// image sets</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_GetImageSet.html">GetImageSet</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/get-image-set-properties.html">Getting
    /// image set properties</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_GetImageSetMetadata.html">GetImageSetMetadata</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/get-image-set-metadata.html">Getting
    /// image set metadata</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_GetImageFrame.html">GetImageFrame</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/get-image-frame.html">Getting
    /// image set pixel data</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Image set modification actions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_ListImageSetVersions.html">ListImageSetVersions</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/list-image-set-versions.html">Listing
    /// image set versions</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_UpdateImageSetMetadata.html">UpdateImageSetMetadata</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/update-image-set-metadata.html">Updating
    /// image set metadata</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_CopyImageSet.html">CopyImageSet</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/copy-image-set.html">Copying
    /// an image set</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_DeleteImageSet.html">DeleteImageSet</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/delete-image-set.html">Deleting
    /// an image set</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tagging actions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_TagResource.html">TagResource</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/tag-resource.html">Tagging
    /// a resource</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_ListTagsForResource.html">ListTagsForResource</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/list-tag-resource.html">Listing
    /// tags for a resource</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/healthimaging/latest/APIReference/API_UntagResource.html">UntagResource</a>
    /// – See <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/untag-resource.html">Untagging
    /// a resource</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonMedicalImaging : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMedicalImagingPaginatorFactory Paginators { get; }

        
        #region  CopyImageSet


        /// <summary>
        /// Copy an image set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyImageSet service method.</param>
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
        CopyImageSetResponse CopyImageSet(CopyImageSetRequest request);



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
        Task<CopyImageSetResponse> CopyImageSetAsync(CopyImageSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDatastore


        /// <summary>
        /// Create a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatastore service method.</param>
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
        CreateDatastoreResponse CreateDatastore(CreateDatastoreRequest request);



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
        Task<CreateDatastoreResponse> CreateDatastoreAsync(CreateDatastoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteDatastoreResponse DeleteDatastore(DeleteDatastoreRequest request);



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
        Task<DeleteDatastoreResponse> DeleteDatastoreAsync(DeleteDatastoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteImageSet


        /// <summary>
        /// Delete an image set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageSet service method.</param>
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
        DeleteImageSetResponse DeleteImageSet(DeleteImageSetRequest request);



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
        Task<DeleteImageSetResponse> DeleteImageSetAsync(DeleteImageSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDatastore


        /// <summary>
        /// Get data store properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatastore service method.</param>
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
        GetDatastoreResponse GetDatastore(GetDatastoreRequest request);



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
        Task<GetDatastoreResponse> GetDatastoreAsync(GetDatastoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetDICOMImportJobResponse GetDICOMImportJob(GetDICOMImportJobRequest request);



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
        Task<GetDICOMImportJobResponse> GetDICOMImportJobAsync(GetDICOMImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetImageFrame


        /// <summary>
        /// Get an image frame (pixel data) for an image set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageFrame service method.</param>
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
        GetImageFrameResponse GetImageFrame(GetImageFrameRequest request);



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
        Task<GetImageFrameResponse> GetImageFrameAsync(GetImageFrameRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetImageSet


        /// <summary>
        /// Get image set properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageSet service method.</param>
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
        GetImageSetResponse GetImageSet(GetImageSetRequest request);



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
        Task<GetImageSetResponse> GetImageSetAsync(GetImageSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetImageSetMetadata


        /// <summary>
        /// Get metadata attributes for an image set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageSetMetadata service method.</param>
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
        GetImageSetMetadataResponse GetImageSetMetadata(GetImageSetMetadataRequest request);



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
        Task<GetImageSetMetadataResponse> GetImageSetMetadataAsync(GetImageSetMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDatastores


        /// <summary>
        /// List data stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatastores service method.</param>
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
        ListDatastoresResponse ListDatastores(ListDatastoresRequest request);



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
        Task<ListDatastoresResponse> ListDatastoresAsync(ListDatastoresRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDICOMImportJobs


        /// <summary>
        /// List import jobs created for a specific data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDICOMImportJobs service method.</param>
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
        ListDICOMImportJobsResponse ListDICOMImportJobs(ListDICOMImportJobsRequest request);



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
        Task<ListDICOMImportJobsResponse> ListDICOMImportJobsAsync(ListDICOMImportJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListImageSetVersions


        /// <summary>
        /// List image set versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageSetVersions service method.</param>
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
        ListImageSetVersionsResponse ListImageSetVersions(ListImageSetVersionsRequest request);



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
        Task<ListImageSetVersionsResponse> ListImageSetVersionsAsync(ListImageSetVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags associated with a medical imaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchImageSets


        /// <summary>
        /// Search image sets based on defined input attributes.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>SearchImageSets</c> accepts a single search query parameter and returns a paginated
        /// response of all image sets that have the matching criteria. All range queries must
        /// be input as <c>(lowerBound, upperBound)</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>SearchImageSets</c> uses the <c>updatedAt</c> field for sorting in decreasing
        /// order from latest to oldest.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchImageSets service method.</param>
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
        SearchImageSetsResponse SearchImageSets(SearchImageSetsRequest request);



        /// <summary>
        /// Search image sets based on defined input attributes.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>SearchImageSets</c> accepts a single search query parameter and returns a paginated
        /// response of all image sets that have the matching criteria. All range queries must
        /// be input as <c>(lowerBound, upperBound)</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>SearchImageSets</c> uses the <c>updatedAt</c> field for sorting in decreasing
        /// order from latest to oldest.
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
        Task<SearchImageSetsResponse> SearchImageSetsAsync(SearchImageSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartDICOMImportJob


        /// <summary>
        /// Start importing bulk data into an <c>ACTIVE</c> data store. The import job imports
        /// DICOM P10 files found in the S3 prefix specified by the <c>inputS3Uri</c> parameter.
        /// The import job stores processing results in the file specified by the <c>outputS3Uri</c>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDICOMImportJob service method.</param>
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
        StartDICOMImportJobResponse StartDICOMImportJob(StartDICOMImportJobRequest request);



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
        Task<StartDICOMImportJobResponse> StartDICOMImportJobAsync(StartDICOMImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds a user-specifed key and value tag to a medical imaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);



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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a medical imaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);



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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateImageSetMetadata


        /// <summary>
        /// Update image set metadata attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImageSetMetadata service method.</param>
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
        UpdateImageSetMetadataResponse UpdateImageSetMetadata(UpdateImageSetMetadataRequest request);



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
        Task<UpdateImageSetMetadataResponse> UpdateImageSetMetadataAsync(UpdateImageSetMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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