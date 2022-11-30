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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISageMakerGeospatialPaginatorFactory Paginators { get; }
#endif


        
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
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
        /// Initiates the asynchronous execution of the DeleteEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEarthObservationJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEarthObservationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteEarthObservationJob">REST API Reference for DeleteEarthObservationJob Operation</seealso>
        IAsyncResult BeginDeleteEarthObservationJob(DeleteEarthObservationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEarthObservationJob.</param>
        /// 
        /// <returns>Returns a  DeleteEarthObservationJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteEarthObservationJob">REST API Reference for DeleteEarthObservationJob Operation</seealso>
        DeleteEarthObservationJobResponse EndDeleteEarthObservationJob(IAsyncResult asyncResult);

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
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
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
        /// Initiates the asynchronous execution of the DeleteVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectorEnrichmentJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVectorEnrichmentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteVectorEnrichmentJob">REST API Reference for DeleteVectorEnrichmentJob Operation</seealso>
        IAsyncResult BeginDeleteVectorEnrichmentJob(DeleteVectorEnrichmentJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVectorEnrichmentJob.</param>
        /// 
        /// <returns>Returns a  DeleteVectorEnrichmentJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteVectorEnrichmentJob">REST API Reference for DeleteVectorEnrichmentJob Operation</seealso>
        DeleteVectorEnrichmentJobResponse EndDeleteVectorEnrichmentJob(IAsyncResult asyncResult);

        #endregion
        
        #region  ExportEarthObservationJob


        /// <summary>
        /// Use this operation to export results of an Earth Observation job and optionally source
        /// images used as input to the EOJ to an S3 location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportEarthObservationJob service method.</param>
        /// 
        /// <returns>The response from the ExportEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
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
        /// Initiates the asynchronous execution of the ExportEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportEarthObservationJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportEarthObservationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportEarthObservationJob">REST API Reference for ExportEarthObservationJob Operation</seealso>
        IAsyncResult BeginExportEarthObservationJob(ExportEarthObservationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExportEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportEarthObservationJob.</param>
        /// 
        /// <returns>Returns a  ExportEarthObservationJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportEarthObservationJob">REST API Reference for ExportEarthObservationJob Operation</seealso>
        ExportEarthObservationJobResponse EndExportEarthObservationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  ExportVectorEnrichmentJob


        /// <summary>
        /// Use this operation to copy results of a Vector Enrichment job to an S3 location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportVectorEnrichmentJob service method.</param>
        /// 
        /// <returns>The response from the ExportVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
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
        /// Initiates the asynchronous execution of the ExportVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportVectorEnrichmentJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportVectorEnrichmentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportVectorEnrichmentJob">REST API Reference for ExportVectorEnrichmentJob Operation</seealso>
        IAsyncResult BeginExportVectorEnrichmentJob(ExportVectorEnrichmentJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExportVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportVectorEnrichmentJob.</param>
        /// 
        /// <returns>Returns a  ExportVectorEnrichmentJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportVectorEnrichmentJob">REST API Reference for ExportVectorEnrichmentJob Operation</seealso>
        ExportVectorEnrichmentJobResponse EndExportVectorEnrichmentJob(IAsyncResult asyncResult);

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
        /// 
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
        /// Initiates the asynchronous execution of the GetEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEarthObservationJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEarthObservationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetEarthObservationJob">REST API Reference for GetEarthObservationJob Operation</seealso>
        IAsyncResult BeginGetEarthObservationJob(GetEarthObservationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEarthObservationJob.</param>
        /// 
        /// <returns>Returns a  GetEarthObservationJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetEarthObservationJob">REST API Reference for GetEarthObservationJob Operation</seealso>
        GetEarthObservationJobResponse EndGetEarthObservationJob(IAsyncResult asyncResult);

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
        /// 
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
        /// Initiates the asynchronous execution of the GetRasterDataCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRasterDataCollection operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRasterDataCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetRasterDataCollection">REST API Reference for GetRasterDataCollection Operation</seealso>
        IAsyncResult BeginGetRasterDataCollection(GetRasterDataCollectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRasterDataCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRasterDataCollection.</param>
        /// 
        /// <returns>Returns a  GetRasterDataCollectionResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetRasterDataCollection">REST API Reference for GetRasterDataCollection Operation</seealso>
        GetRasterDataCollectionResponse EndGetRasterDataCollection(IAsyncResult asyncResult);

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
        /// 
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
        /// Initiates the asynchronous execution of the GetTile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTile operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetTile">REST API Reference for GetTile Operation</seealso>
        IAsyncResult BeginGetTile(GetTileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTile.</param>
        /// 
        /// <returns>Returns a  GetTileResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetTile">REST API Reference for GetTile Operation</seealso>
        GetTileResponse EndGetTile(IAsyncResult asyncResult);

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
        /// 
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
        /// Initiates the asynchronous execution of the GetVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVectorEnrichmentJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVectorEnrichmentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetVectorEnrichmentJob">REST API Reference for GetVectorEnrichmentJob Operation</seealso>
        IAsyncResult BeginGetVectorEnrichmentJob(GetVectorEnrichmentJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVectorEnrichmentJob.</param>
        /// 
        /// <returns>Returns a  GetVectorEnrichmentJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetVectorEnrichmentJob">REST API Reference for GetVectorEnrichmentJob Operation</seealso>
        GetVectorEnrichmentJobResponse EndGetVectorEnrichmentJob(IAsyncResult asyncResult);

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
        /// 
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
        /// Initiates the asynchronous execution of the ListEarthObservationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEarthObservationJobs operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEarthObservationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListEarthObservationJobs">REST API Reference for ListEarthObservationJobs Operation</seealso>
        IAsyncResult BeginListEarthObservationJobs(ListEarthObservationJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEarthObservationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEarthObservationJobs.</param>
        /// 
        /// <returns>Returns a  ListEarthObservationJobsResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListEarthObservationJobs">REST API Reference for ListEarthObservationJobs Operation</seealso>
        ListEarthObservationJobsResponse EndListEarthObservationJobs(IAsyncResult asyncResult);

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
        /// 
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
        /// Initiates the asynchronous execution of the ListRasterDataCollections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRasterDataCollections operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRasterDataCollections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListRasterDataCollections">REST API Reference for ListRasterDataCollections Operation</seealso>
        IAsyncResult BeginListRasterDataCollections(ListRasterDataCollectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRasterDataCollections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRasterDataCollections.</param>
        /// 
        /// <returns>Returns a  ListRasterDataCollectionsResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListRasterDataCollections">REST API Reference for ListRasterDataCollections Operation</seealso>
        ListRasterDataCollectionsResponse EndListRasterDataCollections(IAsyncResult asyncResult);

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
        /// 
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// 
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
        /// Initiates the asynchronous execution of the ListVectorEnrichmentJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVectorEnrichmentJobs operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVectorEnrichmentJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListVectorEnrichmentJobs">REST API Reference for ListVectorEnrichmentJobs Operation</seealso>
        IAsyncResult BeginListVectorEnrichmentJobs(ListVectorEnrichmentJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVectorEnrichmentJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVectorEnrichmentJobs.</param>
        /// 
        /// <returns>Returns a  ListVectorEnrichmentJobsResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListVectorEnrichmentJobs">REST API Reference for ListVectorEnrichmentJobs Operation</seealso>
        ListVectorEnrichmentJobsResponse EndListVectorEnrichmentJobs(IAsyncResult asyncResult);

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
        /// 
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
        /// Initiates the asynchronous execution of the SearchRasterDataCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchRasterDataCollection operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchRasterDataCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/SearchRasterDataCollection">REST API Reference for SearchRasterDataCollection Operation</seealso>
        IAsyncResult BeginSearchRasterDataCollection(SearchRasterDataCollectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchRasterDataCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchRasterDataCollection.</param>
        /// 
        /// <returns>Returns a  SearchRasterDataCollectionResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/SearchRasterDataCollection">REST API Reference for SearchRasterDataCollection Operation</seealso>
        SearchRasterDataCollectionResponse EndSearchRasterDataCollection(IAsyncResult asyncResult);

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
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
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
        /// Initiates the asynchronous execution of the StartEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartEarthObservationJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartEarthObservationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartEarthObservationJob">REST API Reference for StartEarthObservationJob Operation</seealso>
        IAsyncResult BeginStartEarthObservationJob(StartEarthObservationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartEarthObservationJob.</param>
        /// 
        /// <returns>Returns a  StartEarthObservationJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartEarthObservationJob">REST API Reference for StartEarthObservationJob Operation</seealso>
        StartEarthObservationJobResponse EndStartEarthObservationJob(IAsyncResult asyncResult);

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
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
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
        /// Initiates the asynchronous execution of the StartVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartVectorEnrichmentJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartVectorEnrichmentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartVectorEnrichmentJob">REST API Reference for StartVectorEnrichmentJob Operation</seealso>
        IAsyncResult BeginStartVectorEnrichmentJob(StartVectorEnrichmentJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartVectorEnrichmentJob.</param>
        /// 
        /// <returns>Returns a  StartVectorEnrichmentJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartVectorEnrichmentJob">REST API Reference for StartVectorEnrichmentJob Operation</seealso>
        StartVectorEnrichmentJobResponse EndStartVectorEnrichmentJob(IAsyncResult asyncResult);

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
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
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
        /// Initiates the asynchronous execution of the StopEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopEarthObservationJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopEarthObservationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopEarthObservationJob">REST API Reference for StopEarthObservationJob Operation</seealso>
        IAsyncResult BeginStopEarthObservationJob(StopEarthObservationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopEarthObservationJob.</param>
        /// 
        /// <returns>Returns a  StopEarthObservationJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopEarthObservationJob">REST API Reference for StopEarthObservationJob Operation</seealso>
        StopEarthObservationJobResponse EndStopEarthObservationJob(IAsyncResult asyncResult);

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
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
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
        /// Initiates the asynchronous execution of the StopVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopVectorEnrichmentJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopVectorEnrichmentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopVectorEnrichmentJob">REST API Reference for StopVectorEnrichmentJob Operation</seealso>
        IAsyncResult BeginStopVectorEnrichmentJob(StopVectorEnrichmentJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopVectorEnrichmentJob.</param>
        /// 
        /// <returns>Returns a  StopVectorEnrichmentJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopVectorEnrichmentJob">REST API Reference for StopVectorEnrichmentJob Operation</seealso>
        StopVectorEnrichmentJobResponse EndStopVectorEnrichmentJob(IAsyncResult asyncResult);

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
        /// 
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// 
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
    }
}