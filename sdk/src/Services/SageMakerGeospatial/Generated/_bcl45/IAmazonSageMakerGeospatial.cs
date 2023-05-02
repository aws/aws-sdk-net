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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SageMakerGeospatial.Model;

namespace Amazon.SageMakerGeospatial
{
    /// <summary>
    /// Interface for accessing SageMakerGeospatial
    ///
    /// Provides APIs for creating and managing SageMaker geospatial resources.
    /// </summary>
    public partial interface IAmazonSageMakerGeospatial : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISageMakerGeospatialPaginatorFactory Paginators { get; }

        
        #region  DeleteEarthObservationJob


        /// <summary>
        /// Use this operation to delete an Earth Observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEarthObservationJob service method.</param>
        /// 
        /// <returns>The response from the DeleteEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteEarthObservationJob">REST API Reference for DeleteEarthObservationJob Operation</seealso>
        DeleteEarthObservationJobResponse DeleteEarthObservationJob(DeleteEarthObservationJobRequest request);



        /// <summary>
        /// Use this operation to delete an Earth Observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEarthObservationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteEarthObservationJob">REST API Reference for DeleteEarthObservationJob Operation</seealso>
        Task<DeleteEarthObservationJobResponse> DeleteEarthObservationJobAsync(DeleteEarthObservationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVectorEnrichmentJob


        /// <summary>
        /// Use this operation to delete a Vector Enrichment job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectorEnrichmentJob service method.</param>
        /// 
        /// <returns>The response from the DeleteVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteVectorEnrichmentJob">REST API Reference for DeleteVectorEnrichmentJob Operation</seealso>
        DeleteVectorEnrichmentJobResponse DeleteVectorEnrichmentJob(DeleteVectorEnrichmentJobRequest request);



        /// <summary>
        /// Use this operation to delete a Vector Enrichment job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectorEnrichmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteVectorEnrichmentJob">REST API Reference for DeleteVectorEnrichmentJob Operation</seealso>
        Task<DeleteVectorEnrichmentJobResponse> DeleteVectorEnrichmentJobAsync(DeleteVectorEnrichmentJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExportEarthObservationJob


        /// <summary>
        /// Use this operation to export results of an Earth Observation job and optionally source
        /// images used as input to the EOJ to an Amazon S3 location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportEarthObservationJob service method.</param>
        /// 
        /// <returns>The response from the ExportEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportEarthObservationJob">REST API Reference for ExportEarthObservationJob Operation</seealso>
        ExportEarthObservationJobResponse ExportEarthObservationJob(ExportEarthObservationJobRequest request);



        /// <summary>
        /// Use this operation to export results of an Earth Observation job and optionally source
        /// images used as input to the EOJ to an Amazon S3 location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportEarthObservationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportEarthObservationJob">REST API Reference for ExportEarthObservationJob Operation</seealso>
        Task<ExportEarthObservationJobResponse> ExportEarthObservationJobAsync(ExportEarthObservationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExportVectorEnrichmentJob


        /// <summary>
        /// Use this operation to copy results of a Vector Enrichment job to an Amazon S3 location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportVectorEnrichmentJob service method.</param>
        /// 
        /// <returns>The response from the ExportVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportVectorEnrichmentJob">REST API Reference for ExportVectorEnrichmentJob Operation</seealso>
        ExportVectorEnrichmentJobResponse ExportVectorEnrichmentJob(ExportVectorEnrichmentJobRequest request);



        /// <summary>
        /// Use this operation to copy results of a Vector Enrichment job to an Amazon S3 location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportVectorEnrichmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportVectorEnrichmentJob">REST API Reference for ExportVectorEnrichmentJob Operation</seealso>
        Task<ExportVectorEnrichmentJobResponse> ExportVectorEnrichmentJobAsync(ExportVectorEnrichmentJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEarthObservationJob


        /// <summary>
        /// Get the details for a previously initiated Earth Observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEarthObservationJob service method.</param>
        /// 
        /// <returns>The response from the GetEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetEarthObservationJob">REST API Reference for GetEarthObservationJob Operation</seealso>
        GetEarthObservationJobResponse GetEarthObservationJob(GetEarthObservationJobRequest request);



        /// <summary>
        /// Get the details for a previously initiated Earth Observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEarthObservationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetEarthObservationJob">REST API Reference for GetEarthObservationJob Operation</seealso>
        Task<GetEarthObservationJobResponse> GetEarthObservationJobAsync(GetEarthObservationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRasterDataCollection


        /// <summary>
        /// Use this operation to get details of a specific raster data collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRasterDataCollection service method.</param>
        /// 
        /// <returns>The response from the GetRasterDataCollection service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetRasterDataCollection">REST API Reference for GetRasterDataCollection Operation</seealso>
        GetRasterDataCollectionResponse GetRasterDataCollection(GetRasterDataCollectionRequest request);



        /// <summary>
        /// Use this operation to get details of a specific raster data collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRasterDataCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRasterDataCollection service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetRasterDataCollection">REST API Reference for GetRasterDataCollection Operation</seealso>
        Task<GetRasterDataCollectionResponse> GetRasterDataCollectionAsync(GetRasterDataCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTile


        /// <summary>
        /// Gets a web mercator tile for the given Earth Observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTile service method.</param>
        /// 
        /// <returns>The response from the GetTile service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetTile">REST API Reference for GetTile Operation</seealso>
        GetTileResponse GetTile(GetTileRequest request);



        /// <summary>
        /// Gets a web mercator tile for the given Earth Observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTile service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetTile">REST API Reference for GetTile Operation</seealso>
        Task<GetTileResponse> GetTileAsync(GetTileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetVectorEnrichmentJob


        /// <summary>
        /// Retrieves details of a Vector Enrichment Job for a given job Amazon Resource Name
        /// (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVectorEnrichmentJob service method.</param>
        /// 
        /// <returns>The response from the GetVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetVectorEnrichmentJob">REST API Reference for GetVectorEnrichmentJob Operation</seealso>
        GetVectorEnrichmentJobResponse GetVectorEnrichmentJob(GetVectorEnrichmentJobRequest request);



        /// <summary>
        /// Retrieves details of a Vector Enrichment Job for a given job Amazon Resource Name
        /// (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVectorEnrichmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetVectorEnrichmentJob">REST API Reference for GetVectorEnrichmentJob Operation</seealso>
        Task<GetVectorEnrichmentJobResponse> GetVectorEnrichmentJobAsync(GetVectorEnrichmentJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEarthObservationJobs


        /// <summary>
        /// Use this operation to get a list of the Earth Observation jobs associated with the
        /// calling Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEarthObservationJobs service method.</param>
        /// 
        /// <returns>The response from the ListEarthObservationJobs service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListEarthObservationJobs">REST API Reference for ListEarthObservationJobs Operation</seealso>
        ListEarthObservationJobsResponse ListEarthObservationJobs(ListEarthObservationJobsRequest request);



        /// <summary>
        /// Use this operation to get a list of the Earth Observation jobs associated with the
        /// calling Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEarthObservationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEarthObservationJobs service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListEarthObservationJobs">REST API Reference for ListEarthObservationJobs Operation</seealso>
        Task<ListEarthObservationJobsResponse> ListEarthObservationJobsAsync(ListEarthObservationJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRasterDataCollections


        /// <summary>
        /// Use this operation to get raster data collections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRasterDataCollections service method.</param>
        /// 
        /// <returns>The response from the ListRasterDataCollections service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListRasterDataCollections">REST API Reference for ListRasterDataCollections Operation</seealso>
        ListRasterDataCollectionsResponse ListRasterDataCollections(ListRasterDataCollectionsRequest request);



        /// <summary>
        /// Use this operation to get raster data collections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRasterDataCollections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRasterDataCollections service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListRasterDataCollections">REST API Reference for ListRasterDataCollections Operation</seealso>
        Task<ListRasterDataCollectionsResponse> ListRasterDataCollectionsAsync(ListRasterDataCollectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags attached to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags attached to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVectorEnrichmentJobs


        /// <summary>
        /// Retrieves a list of vector enrichment jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVectorEnrichmentJobs service method.</param>
        /// 
        /// <returns>The response from the ListVectorEnrichmentJobs service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListVectorEnrichmentJobs">REST API Reference for ListVectorEnrichmentJobs Operation</seealso>
        ListVectorEnrichmentJobsResponse ListVectorEnrichmentJobs(ListVectorEnrichmentJobsRequest request);



        /// <summary>
        /// Retrieves a list of vector enrichment jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVectorEnrichmentJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVectorEnrichmentJobs service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListVectorEnrichmentJobs">REST API Reference for ListVectorEnrichmentJobs Operation</seealso>
        Task<ListVectorEnrichmentJobsResponse> ListVectorEnrichmentJobsAsync(ListVectorEnrichmentJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchRasterDataCollection


        /// <summary>
        /// Allows you run image query on a specific raster data collection to get a list of the
        /// satellite imagery matching the selected filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRasterDataCollection service method.</param>
        /// 
        /// <returns>The response from the SearchRasterDataCollection service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/SearchRasterDataCollection">REST API Reference for SearchRasterDataCollection Operation</seealso>
        SearchRasterDataCollectionResponse SearchRasterDataCollection(SearchRasterDataCollectionRequest request);



        /// <summary>
        /// Allows you run image query on a specific raster data collection to get a list of the
        /// satellite imagery matching the selected filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRasterDataCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchRasterDataCollection service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/SearchRasterDataCollection">REST API Reference for SearchRasterDataCollection Operation</seealso>
        Task<SearchRasterDataCollectionResponse> SearchRasterDataCollectionAsync(SearchRasterDataCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartEarthObservationJob


        /// <summary>
        /// Use this operation to create an Earth observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEarthObservationJob service method.</param>
        /// 
        /// <returns>The response from the StartEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartEarthObservationJob">REST API Reference for StartEarthObservationJob Operation</seealso>
        StartEarthObservationJobResponse StartEarthObservationJob(StartEarthObservationJobRequest request);



        /// <summary>
        /// Use this operation to create an Earth observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEarthObservationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartEarthObservationJob">REST API Reference for StartEarthObservationJob Operation</seealso>
        Task<StartEarthObservationJobResponse> StartEarthObservationJobAsync(StartEarthObservationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartVectorEnrichmentJob


        /// <summary>
        /// Creates a Vector Enrichment job for the supplied job type. Currently, there are two
        /// supported job types: reverse geocoding and map matching.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVectorEnrichmentJob service method.</param>
        /// 
        /// <returns>The response from the StartVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartVectorEnrichmentJob">REST API Reference for StartVectorEnrichmentJob Operation</seealso>
        StartVectorEnrichmentJobResponse StartVectorEnrichmentJob(StartVectorEnrichmentJobRequest request);



        /// <summary>
        /// Creates a Vector Enrichment job for the supplied job type. Currently, there are two
        /// supported job types: reverse geocoding and map matching.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVectorEnrichmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartVectorEnrichmentJob">REST API Reference for StartVectorEnrichmentJob Operation</seealso>
        Task<StartVectorEnrichmentJobResponse> StartVectorEnrichmentJobAsync(StartVectorEnrichmentJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopEarthObservationJob


        /// <summary>
        /// Use this operation to stop an existing earth observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEarthObservationJob service method.</param>
        /// 
        /// <returns>The response from the StopEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopEarthObservationJob">REST API Reference for StopEarthObservationJob Operation</seealso>
        StopEarthObservationJobResponse StopEarthObservationJob(StopEarthObservationJobRequest request);



        /// <summary>
        /// Use this operation to stop an existing earth observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEarthObservationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopEarthObservationJob">REST API Reference for StopEarthObservationJob Operation</seealso>
        Task<StopEarthObservationJobResponse> StopEarthObservationJobAsync(StopEarthObservationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopVectorEnrichmentJob


        /// <summary>
        /// Stops the Vector Enrichment job for a given job ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopVectorEnrichmentJob service method.</param>
        /// 
        /// <returns>The response from the StopVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopVectorEnrichmentJob">REST API Reference for StopVectorEnrichmentJob Operation</seealso>
        StopVectorEnrichmentJobResponse StopVectorEnrichmentJob(StopVectorEnrichmentJobRequest request);



        /// <summary>
        /// Stops the Vector Enrichment job for a given job ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopVectorEnrichmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopVectorEnrichmentJob">REST API Reference for StopVectorEnrichmentJob Operation</seealso>
        Task<StopVectorEnrichmentJobResponse> StopVectorEnrichmentJobAsync(StopVectorEnrichmentJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// The resource you want to tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// The resource you want to tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// The resource you want to untag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// The resource you want to untag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}