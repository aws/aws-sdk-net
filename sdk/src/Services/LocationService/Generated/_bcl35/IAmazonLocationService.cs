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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LocationService.Model;

namespace Amazon.LocationService
{
    /// <summary>
    /// Interface for accessing LocationService
    ///
    /// Suite of geospatial services including Maps, Places, Tracking, and Geofencing
    /// </summary>
    public partial interface IAmazonLocationService : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILocationServicePaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateTrackerConsumer


        /// <summary>
        /// Creates an association between a geofence collection and a tracker resource. This
        /// allows the tracker resource to communicate location data to the linked geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrackerConsumer service method.</param>
        /// 
        /// <returns>The response from the AssociateTrackerConsumer service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/AssociateTrackerConsumer">REST API Reference for AssociateTrackerConsumer Operation</seealso>
        AssociateTrackerConsumerResponse AssociateTrackerConsumer(AssociateTrackerConsumerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTrackerConsumer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrackerConsumer operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateTrackerConsumer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/AssociateTrackerConsumer">REST API Reference for AssociateTrackerConsumer Operation</seealso>
        IAsyncResult BeginAssociateTrackerConsumer(AssociateTrackerConsumerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateTrackerConsumer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateTrackerConsumer.</param>
        /// 
        /// <returns>Returns a  AssociateTrackerConsumerResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/AssociateTrackerConsumer">REST API Reference for AssociateTrackerConsumer Operation</seealso>
        AssociateTrackerConsumerResponse EndAssociateTrackerConsumer(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDeleteGeofence


        /// <summary>
        /// Deletes a batch of geofences from a geofence collection.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You can't undo this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteGeofence service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchDeleteGeofence">REST API Reference for BatchDeleteGeofence Operation</seealso>
        BatchDeleteGeofenceResponse BatchDeleteGeofence(BatchDeleteGeofenceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteGeofence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteGeofence operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteGeofence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchDeleteGeofence">REST API Reference for BatchDeleteGeofence Operation</seealso>
        IAsyncResult BeginBatchDeleteGeofence(BatchDeleteGeofenceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteGeofence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteGeofence.</param>
        /// 
        /// <returns>Returns a  BatchDeleteGeofenceResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchDeleteGeofence">REST API Reference for BatchDeleteGeofence Operation</seealso>
        BatchDeleteGeofenceResponse EndBatchDeleteGeofence(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchEvaluateGeofences


        /// <summary>
        /// Used in geofence monitoring. Evaluates device positions against the position of geofences
        /// in a given geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchEvaluateGeofences service method.</param>
        /// 
        /// <returns>The response from the BatchEvaluateGeofences service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchEvaluateGeofences">REST API Reference for BatchEvaluateGeofences Operation</seealso>
        BatchEvaluateGeofencesResponse BatchEvaluateGeofences(BatchEvaluateGeofencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchEvaluateGeofences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchEvaluateGeofences operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchEvaluateGeofences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchEvaluateGeofences">REST API Reference for BatchEvaluateGeofences Operation</seealso>
        IAsyncResult BeginBatchEvaluateGeofences(BatchEvaluateGeofencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchEvaluateGeofences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchEvaluateGeofences.</param>
        /// 
        /// <returns>Returns a  BatchEvaluateGeofencesResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchEvaluateGeofences">REST API Reference for BatchEvaluateGeofences Operation</seealso>
        BatchEvaluateGeofencesResponse EndBatchEvaluateGeofences(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetDevicePosition


        /// <summary>
        /// A batch request to retrieve device positions.
        /// 
        ///  <note> 
        /// <para>
        /// The response will return the device positions from the last 24 hours.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDevicePosition service method.</param>
        /// 
        /// <returns>The response from the BatchGetDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchGetDevicePosition">REST API Reference for BatchGetDevicePosition Operation</seealso>
        BatchGetDevicePositionResponse BatchGetDevicePosition(BatchGetDevicePositionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetDevicePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDevicePosition operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetDevicePosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchGetDevicePosition">REST API Reference for BatchGetDevicePosition Operation</seealso>
        IAsyncResult BeginBatchGetDevicePosition(BatchGetDevicePositionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetDevicePosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetDevicePosition.</param>
        /// 
        /// <returns>Returns a  BatchGetDevicePositionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchGetDevicePosition">REST API Reference for BatchGetDevicePosition Operation</seealso>
        BatchGetDevicePositionResponse EndBatchGetDevicePosition(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchPutGeofence


        /// <summary>
        /// A batch request for storing geofences into a given geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutGeofence service method.</param>
        /// 
        /// <returns>The response from the BatchPutGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchPutGeofence">REST API Reference for BatchPutGeofence Operation</seealso>
        BatchPutGeofenceResponse BatchPutGeofence(BatchPutGeofenceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutGeofence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutGeofence operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutGeofence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchPutGeofence">REST API Reference for BatchPutGeofence Operation</seealso>
        IAsyncResult BeginBatchPutGeofence(BatchPutGeofenceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutGeofence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutGeofence.</param>
        /// 
        /// <returns>Returns a  BatchPutGeofenceResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchPutGeofence">REST API Reference for BatchPutGeofence Operation</seealso>
        BatchPutGeofenceResponse EndBatchPutGeofence(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchUpdateDevicePosition


        /// <summary>
        /// Uploads a position update for one or more devices to a tracker resource. The data
        /// is used for API queries requesting the device position and position history.
        /// 
        ///  <note> 
        /// <para>
        /// Limitation — Location data is sampled at a fixed rate of 1 position per 30 second
        /// interval, and retained for 1 year before it is deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDevicePosition service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchUpdateDevicePosition">REST API Reference for BatchUpdateDevicePosition Operation</seealso>
        BatchUpdateDevicePositionResponse BatchUpdateDevicePosition(BatchUpdateDevicePositionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateDevicePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDevicePosition operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateDevicePosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchUpdateDevicePosition">REST API Reference for BatchUpdateDevicePosition Operation</seealso>
        IAsyncResult BeginBatchUpdateDevicePosition(BatchUpdateDevicePositionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateDevicePosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateDevicePosition.</param>
        /// 
        /// <returns>Returns a  BatchUpdateDevicePositionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchUpdateDevicePosition">REST API Reference for BatchUpdateDevicePosition Operation</seealso>
        BatchUpdateDevicePositionResponse EndBatchUpdateDevicePosition(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGeofenceCollection


        /// <summary>
        /// Creates a geofence collection, which manages and stores geofences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGeofenceCollection service method.</param>
        /// 
        /// <returns>The response from the CreateGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateGeofenceCollection">REST API Reference for CreateGeofenceCollection Operation</seealso>
        CreateGeofenceCollectionResponse CreateGeofenceCollection(CreateGeofenceCollectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGeofenceCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGeofenceCollection operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGeofenceCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateGeofenceCollection">REST API Reference for CreateGeofenceCollection Operation</seealso>
        IAsyncResult BeginCreateGeofenceCollection(CreateGeofenceCollectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGeofenceCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGeofenceCollection.</param>
        /// 
        /// <returns>Returns a  CreateGeofenceCollectionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateGeofenceCollection">REST API Reference for CreateGeofenceCollection Operation</seealso>
        CreateGeofenceCollectionResponse EndCreateGeofenceCollection(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMap


        /// <summary>
        /// Creates a map resource in your AWS account, which provides map tiles of different
        /// styles sourced from global location data providers.
        /// 
        ///  <note> 
        /// <para>
        /// By using Maps, you agree that AWS may transmit your API queries to your selected third
        /// party provider for processing, which may be outside the AWS region you are currently
        /// using. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
        /// Service Terms</a> for Amazon Location Service. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMap service method.</param>
        /// 
        /// <returns>The response from the CreateMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateMap">REST API Reference for CreateMap Operation</seealso>
        CreateMapResponse CreateMap(CreateMapRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMap operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateMap">REST API Reference for CreateMap Operation</seealso>
        IAsyncResult BeginCreateMap(CreateMapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMap.</param>
        /// 
        /// <returns>Returns a  CreateMapResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateMap">REST API Reference for CreateMap Operation</seealso>
        CreateMapResponse EndCreateMap(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePlaceIndex


        /// <summary>
        /// Creates a Place index resource in your AWS account, which supports Places functions
        /// with geospatial data sourced from your chosen data provider.
        /// 
        ///  <note> 
        /// <para>
        /// By using Places, you agree that AWS may transmit your API queries to your selected
        /// third party provider for processing, which may be outside the AWS region you are currently
        /// using. 
        /// </para>
        ///  
        /// <para>
        /// Because of licensing limitations, you may not use HERE to store results for locations
        /// in Japan. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
        /// Service Terms</a> for Amazon Location Service.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlaceIndex service method.</param>
        /// 
        /// <returns>The response from the CreatePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreatePlaceIndex">REST API Reference for CreatePlaceIndex Operation</seealso>
        CreatePlaceIndexResponse CreatePlaceIndex(CreatePlaceIndexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlaceIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlaceIndex operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlaceIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreatePlaceIndex">REST API Reference for CreatePlaceIndex Operation</seealso>
        IAsyncResult BeginCreatePlaceIndex(CreatePlaceIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlaceIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlaceIndex.</param>
        /// 
        /// <returns>Returns a  CreatePlaceIndexResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreatePlaceIndex">REST API Reference for CreatePlaceIndex Operation</seealso>
        CreatePlaceIndexResponse EndCreatePlaceIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTracker


        /// <summary>
        /// Creates a tracker resource in your AWS account, which lets you retrieve current and
        /// historical location of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTracker service method.</param>
        /// 
        /// <returns>The response from the CreateTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateTracker">REST API Reference for CreateTracker Operation</seealso>
        CreateTrackerResponse CreateTracker(CreateTrackerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTracker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTracker operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTracker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateTracker">REST API Reference for CreateTracker Operation</seealso>
        IAsyncResult BeginCreateTracker(CreateTrackerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTracker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTracker.</param>
        /// 
        /// <returns>Returns a  CreateTrackerResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateTracker">REST API Reference for CreateTracker Operation</seealso>
        CreateTrackerResponse EndCreateTracker(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGeofenceCollection


        /// <summary>
        /// Deletes a geofence collection from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You can't undo this action. If the geofence
        /// collection is the target of a tracker resource, the devices will no longer be monitored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeofenceCollection service method.</param>
        /// 
        /// <returns>The response from the DeleteGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteGeofenceCollection">REST API Reference for DeleteGeofenceCollection Operation</seealso>
        DeleteGeofenceCollectionResponse DeleteGeofenceCollection(DeleteGeofenceCollectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGeofenceCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeofenceCollection operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGeofenceCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteGeofenceCollection">REST API Reference for DeleteGeofenceCollection Operation</seealso>
        IAsyncResult BeginDeleteGeofenceCollection(DeleteGeofenceCollectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGeofenceCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGeofenceCollection.</param>
        /// 
        /// <returns>Returns a  DeleteGeofenceCollectionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteGeofenceCollection">REST API Reference for DeleteGeofenceCollection Operation</seealso>
        DeleteGeofenceCollectionResponse EndDeleteGeofenceCollection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMap


        /// <summary>
        /// Deletes a map resource from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You cannot undo this action. If the
        /// map is being used in an application, the map may not render.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMap service method.</param>
        /// 
        /// <returns>The response from the DeleteMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteMap">REST API Reference for DeleteMap Operation</seealso>
        DeleteMapResponse DeleteMap(DeleteMapRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMap operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteMap">REST API Reference for DeleteMap Operation</seealso>
        IAsyncResult BeginDeleteMap(DeleteMapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMap.</param>
        /// 
        /// <returns>Returns a  DeleteMapResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteMap">REST API Reference for DeleteMap Operation</seealso>
        DeleteMapResponse EndDeleteMap(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePlaceIndex


        /// <summary>
        /// Deletes a Place index resource from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You cannot undo this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaceIndex service method.</param>
        /// 
        /// <returns>The response from the DeletePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeletePlaceIndex">REST API Reference for DeletePlaceIndex Operation</seealso>
        DeletePlaceIndexResponse DeletePlaceIndex(DeletePlaceIndexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlaceIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaceIndex operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlaceIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeletePlaceIndex">REST API Reference for DeletePlaceIndex Operation</seealso>
        IAsyncResult BeginDeletePlaceIndex(DeletePlaceIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlaceIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlaceIndex.</param>
        /// 
        /// <returns>Returns a  DeletePlaceIndexResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeletePlaceIndex">REST API Reference for DeletePlaceIndex Operation</seealso>
        DeletePlaceIndexResponse EndDeletePlaceIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTracker


        /// <summary>
        /// Deletes a tracker resource from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You can't undo this action. If the tracker
        /// resource is in use, you may encounter an error. Make sure that the target resource
        /// is not a dependency for your applications.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTracker service method.</param>
        /// 
        /// <returns>The response from the DeleteTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteTracker">REST API Reference for DeleteTracker Operation</seealso>
        DeleteTrackerResponse DeleteTracker(DeleteTrackerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTracker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTracker operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTracker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteTracker">REST API Reference for DeleteTracker Operation</seealso>
        IAsyncResult BeginDeleteTracker(DeleteTrackerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTracker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTracker.</param>
        /// 
        /// <returns>Returns a  DeleteTrackerResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteTracker">REST API Reference for DeleteTracker Operation</seealso>
        DeleteTrackerResponse EndDeleteTracker(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGeofenceCollection


        /// <summary>
        /// Retrieves the geofence collection details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGeofenceCollection service method.</param>
        /// 
        /// <returns>The response from the DescribeGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeGeofenceCollection">REST API Reference for DescribeGeofenceCollection Operation</seealso>
        DescribeGeofenceCollectionResponse DescribeGeofenceCollection(DescribeGeofenceCollectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGeofenceCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGeofenceCollection operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGeofenceCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeGeofenceCollection">REST API Reference for DescribeGeofenceCollection Operation</seealso>
        IAsyncResult BeginDescribeGeofenceCollection(DescribeGeofenceCollectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGeofenceCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGeofenceCollection.</param>
        /// 
        /// <returns>Returns a  DescribeGeofenceCollectionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeGeofenceCollection">REST API Reference for DescribeGeofenceCollection Operation</seealso>
        DescribeGeofenceCollectionResponse EndDescribeGeofenceCollection(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMap


        /// <summary>
        /// Retrieves the map resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMap service method.</param>
        /// 
        /// <returns>The response from the DescribeMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeMap">REST API Reference for DescribeMap Operation</seealso>
        DescribeMapResponse DescribeMap(DescribeMapRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMap operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeMap">REST API Reference for DescribeMap Operation</seealso>
        IAsyncResult BeginDescribeMap(DescribeMapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMap.</param>
        /// 
        /// <returns>Returns a  DescribeMapResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeMap">REST API Reference for DescribeMap Operation</seealso>
        DescribeMapResponse EndDescribeMap(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePlaceIndex


        /// <summary>
        /// Retrieves the Place index resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlaceIndex service method.</param>
        /// 
        /// <returns>The response from the DescribePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribePlaceIndex">REST API Reference for DescribePlaceIndex Operation</seealso>
        DescribePlaceIndexResponse DescribePlaceIndex(DescribePlaceIndexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlaceIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlaceIndex operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePlaceIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribePlaceIndex">REST API Reference for DescribePlaceIndex Operation</seealso>
        IAsyncResult BeginDescribePlaceIndex(DescribePlaceIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePlaceIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePlaceIndex.</param>
        /// 
        /// <returns>Returns a  DescribePlaceIndexResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribePlaceIndex">REST API Reference for DescribePlaceIndex Operation</seealso>
        DescribePlaceIndexResponse EndDescribePlaceIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTracker


        /// <summary>
        /// Retrieves the tracker resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTracker service method.</param>
        /// 
        /// <returns>The response from the DescribeTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeTracker">REST API Reference for DescribeTracker Operation</seealso>
        DescribeTrackerResponse DescribeTracker(DescribeTrackerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTracker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTracker operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTracker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeTracker">REST API Reference for DescribeTracker Operation</seealso>
        IAsyncResult BeginDescribeTracker(DescribeTrackerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTracker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTracker.</param>
        /// 
        /// <returns>Returns a  DescribeTrackerResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeTracker">REST API Reference for DescribeTracker Operation</seealso>
        DescribeTrackerResponse EndDescribeTracker(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateTrackerConsumer


        /// <summary>
        /// Removes the association bewteen a tracker resource and a geofence collection.
        /// 
        ///  <note> 
        /// <para>
        /// Once you unlink a tracker resource from a geofence collection, the tracker positions
        /// will no longer be automatically evaluated against geofences.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrackerConsumer service method.</param>
        /// 
        /// <returns>The response from the DisassociateTrackerConsumer service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DisassociateTrackerConsumer">REST API Reference for DisassociateTrackerConsumer Operation</seealso>
        DisassociateTrackerConsumerResponse DisassociateTrackerConsumer(DisassociateTrackerConsumerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTrackerConsumer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrackerConsumer operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateTrackerConsumer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DisassociateTrackerConsumer">REST API Reference for DisassociateTrackerConsumer Operation</seealso>
        IAsyncResult BeginDisassociateTrackerConsumer(DisassociateTrackerConsumerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateTrackerConsumer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateTrackerConsumer.</param>
        /// 
        /// <returns>Returns a  DisassociateTrackerConsumerResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DisassociateTrackerConsumer">REST API Reference for DisassociateTrackerConsumer Operation</seealso>
        DisassociateTrackerConsumerResponse EndDisassociateTrackerConsumer(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDevicePosition


        /// <summary>
        /// Retrieves the latest device position.
        /// 
        ///  <note> 
        /// <para>
        /// Limitation — Device positions are deleted after one year.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePosition service method.</param>
        /// 
        /// <returns>The response from the GetDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePosition">REST API Reference for GetDevicePosition Operation</seealso>
        GetDevicePositionResponse GetDevicePosition(GetDevicePositionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePosition operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevicePosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePosition">REST API Reference for GetDevicePosition Operation</seealso>
        IAsyncResult BeginGetDevicePosition(GetDevicePositionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevicePosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevicePosition.</param>
        /// 
        /// <returns>Returns a  GetDevicePositionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePosition">REST API Reference for GetDevicePosition Operation</seealso>
        GetDevicePositionResponse EndGetDevicePosition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDevicePositionHistory


        /// <summary>
        /// Retrieves the device position history from a tracker resource within a specified range
        /// of time.
        /// 
        ///  <note> 
        /// <para>
        /// Limitation — Device positions are deleted after one year.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePositionHistory service method.</param>
        /// 
        /// <returns>The response from the GetDevicePositionHistory service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePositionHistory">REST API Reference for GetDevicePositionHistory Operation</seealso>
        GetDevicePositionHistoryResponse GetDevicePositionHistory(GetDevicePositionHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicePositionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePositionHistory operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevicePositionHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePositionHistory">REST API Reference for GetDevicePositionHistory Operation</seealso>
        IAsyncResult BeginGetDevicePositionHistory(GetDevicePositionHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevicePositionHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevicePositionHistory.</param>
        /// 
        /// <returns>Returns a  GetDevicePositionHistoryResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePositionHistory">REST API Reference for GetDevicePositionHistory Operation</seealso>
        GetDevicePositionHistoryResponse EndGetDevicePositionHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGeofence


        /// <summary>
        /// Retrieves the geofence details from a geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeofence service method.</param>
        /// 
        /// <returns>The response from the GetGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetGeofence">REST API Reference for GetGeofence Operation</seealso>
        GetGeofenceResponse GetGeofence(GetGeofenceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGeofence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeofence operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGeofence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetGeofence">REST API Reference for GetGeofence Operation</seealso>
        IAsyncResult BeginGetGeofence(GetGeofenceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGeofence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGeofence.</param>
        /// 
        /// <returns>Returns a  GetGeofenceResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetGeofence">REST API Reference for GetGeofence Operation</seealso>
        GetGeofenceResponse EndGetGeofence(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMapGlyphs


        /// <summary>
        /// Retrieves glyphs used to display labels on a map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapGlyphs service method.</param>
        /// 
        /// <returns>The response from the GetMapGlyphs service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapGlyphs">REST API Reference for GetMapGlyphs Operation</seealso>
        GetMapGlyphsResponse GetMapGlyphs(GetMapGlyphsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMapGlyphs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMapGlyphs operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMapGlyphs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapGlyphs">REST API Reference for GetMapGlyphs Operation</seealso>
        IAsyncResult BeginGetMapGlyphs(GetMapGlyphsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMapGlyphs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMapGlyphs.</param>
        /// 
        /// <returns>Returns a  GetMapGlyphsResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapGlyphs">REST API Reference for GetMapGlyphs Operation</seealso>
        GetMapGlyphsResponse EndGetMapGlyphs(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMapSprites


        /// <summary>
        /// Retrieves the sprite sheet corresponding to a map resource. The sprite sheet is a
        /// PNG image paired with a JSON document describing the offsets of individual icons that
        /// will be displayed on a rendered map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapSprites service method.</param>
        /// 
        /// <returns>The response from the GetMapSprites service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapSprites">REST API Reference for GetMapSprites Operation</seealso>
        GetMapSpritesResponse GetMapSprites(GetMapSpritesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMapSprites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMapSprites operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMapSprites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapSprites">REST API Reference for GetMapSprites Operation</seealso>
        IAsyncResult BeginGetMapSprites(GetMapSpritesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMapSprites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMapSprites.</param>
        /// 
        /// <returns>Returns a  GetMapSpritesResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapSprites">REST API Reference for GetMapSprites Operation</seealso>
        GetMapSpritesResponse EndGetMapSprites(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMapStyleDescriptor


        /// <summary>
        /// Retrieves the map style descriptor from a map resource. 
        /// 
        ///  
        /// <para>
        /// The style descriptor contains speciﬁcations on how features render on a map. For example,
        /// what data to display, what order to display the data in, and the style for the data.
        /// Style descriptors follow the Mapbox Style Specification.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapStyleDescriptor service method.</param>
        /// 
        /// <returns>The response from the GetMapStyleDescriptor service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapStyleDescriptor">REST API Reference for GetMapStyleDescriptor Operation</seealso>
        GetMapStyleDescriptorResponse GetMapStyleDescriptor(GetMapStyleDescriptorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMapStyleDescriptor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMapStyleDescriptor operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMapStyleDescriptor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapStyleDescriptor">REST API Reference for GetMapStyleDescriptor Operation</seealso>
        IAsyncResult BeginGetMapStyleDescriptor(GetMapStyleDescriptorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMapStyleDescriptor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMapStyleDescriptor.</param>
        /// 
        /// <returns>Returns a  GetMapStyleDescriptorResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapStyleDescriptor">REST API Reference for GetMapStyleDescriptor Operation</seealso>
        GetMapStyleDescriptorResponse EndGetMapStyleDescriptor(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMapTile


        /// <summary>
        /// Retrieves a vector data tile from the map resource. Map tiles are used by clients
        /// to render a map. They are addressed using a grid arrangement with an X coordinate,
        /// Y coordinate, and Z (zoom) level. 
        /// 
        ///  
        /// <para>
        /// The origin (0, 0) is the top left of the map. Increasing the zoom level by 1 doubles
        /// both the X and Y dimensions, so a tile containing data for the entire world at (0/0/0)
        /// will be split into 4 tiles at zoom 1 (1/0/0, 1/0/1, 1/1/0, 1/1/1).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapTile service method.</param>
        /// 
        /// <returns>The response from the GetMapTile service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapTile">REST API Reference for GetMapTile Operation</seealso>
        GetMapTileResponse GetMapTile(GetMapTileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMapTile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMapTile operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMapTile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapTile">REST API Reference for GetMapTile Operation</seealso>
        IAsyncResult BeginGetMapTile(GetMapTileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMapTile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMapTile.</param>
        /// 
        /// <returns>Returns a  GetMapTileResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapTile">REST API Reference for GetMapTile Operation</seealso>
        GetMapTileResponse EndGetMapTile(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGeofenceCollections


        /// <summary>
        /// Lists geofence collections in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeofenceCollections service method.</param>
        /// 
        /// <returns>The response from the ListGeofenceCollections service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofenceCollections">REST API Reference for ListGeofenceCollections Operation</seealso>
        ListGeofenceCollectionsResponse ListGeofenceCollections(ListGeofenceCollectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGeofenceCollections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeofenceCollections operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGeofenceCollections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofenceCollections">REST API Reference for ListGeofenceCollections Operation</seealso>
        IAsyncResult BeginListGeofenceCollections(ListGeofenceCollectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGeofenceCollections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGeofenceCollections.</param>
        /// 
        /// <returns>Returns a  ListGeofenceCollectionsResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofenceCollections">REST API Reference for ListGeofenceCollections Operation</seealso>
        ListGeofenceCollectionsResponse EndListGeofenceCollections(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGeofences


        /// <summary>
        /// Lists geofences stored in a given geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeofences service method.</param>
        /// 
        /// <returns>The response from the ListGeofences service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofences">REST API Reference for ListGeofences Operation</seealso>
        ListGeofencesResponse ListGeofences(ListGeofencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGeofences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeofences operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGeofences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofences">REST API Reference for ListGeofences Operation</seealso>
        IAsyncResult BeginListGeofences(ListGeofencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGeofences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGeofences.</param>
        /// 
        /// <returns>Returns a  ListGeofencesResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofences">REST API Reference for ListGeofences Operation</seealso>
        ListGeofencesResponse EndListGeofences(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMaps


        /// <summary>
        /// Lists map resources in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMaps service method.</param>
        /// 
        /// <returns>The response from the ListMaps service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListMaps">REST API Reference for ListMaps Operation</seealso>
        ListMapsResponse ListMaps(ListMapsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMaps operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListMaps">REST API Reference for ListMaps Operation</seealso>
        IAsyncResult BeginListMaps(ListMapsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMaps.</param>
        /// 
        /// <returns>Returns a  ListMapsResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListMaps">REST API Reference for ListMaps Operation</seealso>
        ListMapsResponse EndListMaps(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPlaceIndexes


        /// <summary>
        /// Lists Place index resources in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaceIndexes service method.</param>
        /// 
        /// <returns>The response from the ListPlaceIndexes service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListPlaceIndexes">REST API Reference for ListPlaceIndexes Operation</seealso>
        ListPlaceIndexesResponse ListPlaceIndexes(ListPlaceIndexesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlaceIndexes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlaceIndexes operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlaceIndexes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListPlaceIndexes">REST API Reference for ListPlaceIndexes Operation</seealso>
        IAsyncResult BeginListPlaceIndexes(ListPlaceIndexesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlaceIndexes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlaceIndexes.</param>
        /// 
        /// <returns>Returns a  ListPlaceIndexesResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListPlaceIndexes">REST API Reference for ListPlaceIndexes Operation</seealso>
        ListPlaceIndexesResponse EndListPlaceIndexes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrackerConsumers


        /// <summary>
        /// Lists geofence collections currently associated to the given tracker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrackerConsumers service method.</param>
        /// 
        /// <returns>The response from the ListTrackerConsumers service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackerConsumers">REST API Reference for ListTrackerConsumers Operation</seealso>
        ListTrackerConsumersResponse ListTrackerConsumers(ListTrackerConsumersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrackerConsumers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrackerConsumers operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrackerConsumers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackerConsumers">REST API Reference for ListTrackerConsumers Operation</seealso>
        IAsyncResult BeginListTrackerConsumers(ListTrackerConsumersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrackerConsumers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrackerConsumers.</param>
        /// 
        /// <returns>Returns a  ListTrackerConsumersResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackerConsumers">REST API Reference for ListTrackerConsumers Operation</seealso>
        ListTrackerConsumersResponse EndListTrackerConsumers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrackers


        /// <summary>
        /// Lists tracker resources in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrackers service method.</param>
        /// 
        /// <returns>The response from the ListTrackers service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackers">REST API Reference for ListTrackers Operation</seealso>
        ListTrackersResponse ListTrackers(ListTrackersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrackers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrackers operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrackers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackers">REST API Reference for ListTrackers Operation</seealso>
        IAsyncResult BeginListTrackers(ListTrackersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrackers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrackers.</param>
        /// 
        /// <returns>Returns a  ListTrackersResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackers">REST API Reference for ListTrackers Operation</seealso>
        ListTrackersResponse EndListTrackers(IAsyncResult asyncResult);

        #endregion
        
        #region  PutGeofence


        /// <summary>
        /// Stores a geofence to a given geofence collection, or updates the geometry of an existing
        /// geofence if a geofence ID is included in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGeofence service method.</param>
        /// 
        /// <returns>The response from the PutGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/PutGeofence">REST API Reference for PutGeofence Operation</seealso>
        PutGeofenceResponse PutGeofence(PutGeofenceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutGeofence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGeofence operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutGeofence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/PutGeofence">REST API Reference for PutGeofence Operation</seealso>
        IAsyncResult BeginPutGeofence(PutGeofenceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutGeofence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGeofence.</param>
        /// 
        /// <returns>Returns a  PutGeofenceResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/PutGeofence">REST API Reference for PutGeofence Operation</seealso>
        PutGeofenceResponse EndPutGeofence(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchPlaceIndexForPosition


        /// <summary>
        /// Reverse geocodes a given coordinate and returns a legible address. Allows you to search
        /// for Places or points of interest near a given position.
        /// 
        ///  <note> 
        /// <para>
        /// By using Places, you agree that AWS may transmit your API queries to your selected
        /// third party provider for processing, which may be outside the AWS region you are currently
        /// using. 
        /// </para>
        ///  
        /// <para>
        /// Because of licensing limitations, you may not use HERE to store results for locations
        /// in Japan. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
        /// Service Terms</a> for Amazon Location Service.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForPosition service method.</param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForPosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForPosition">REST API Reference for SearchPlaceIndexForPosition Operation</seealso>
        SearchPlaceIndexForPositionResponse SearchPlaceIndexForPosition(SearchPlaceIndexForPositionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchPlaceIndexForPosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForPosition operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchPlaceIndexForPosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForPosition">REST API Reference for SearchPlaceIndexForPosition Operation</seealso>
        IAsyncResult BeginSearchPlaceIndexForPosition(SearchPlaceIndexForPositionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchPlaceIndexForPosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchPlaceIndexForPosition.</param>
        /// 
        /// <returns>Returns a  SearchPlaceIndexForPositionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForPosition">REST API Reference for SearchPlaceIndexForPosition Operation</seealso>
        SearchPlaceIndexForPositionResponse EndSearchPlaceIndexForPosition(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchPlaceIndexForText


        /// <summary>
        /// Geocodes free-form text, such as an address, name, city, or region to allow you to
        /// search for Places or points of interest. 
        /// 
        ///  
        /// <para>
        /// Includes the option to apply additional parameters to narrow your list of results.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can search for places near a given position using <code>BiasPosition</code>, or
        /// filter results within a bounding box using <code>FilterBBox</code>. Providing both
        /// parameters simultaneously returns an error.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// By using Places, you agree that AWS may transmit your API queries to your selected
        /// third party provider for processing, which may be outside the AWS region you are currently
        /// using. 
        /// </para>
        ///  
        /// <para>
        /// Also, when using HERE as your data provider, you may not (a) use HERE Places for Asset
        /// Management, or (b) select the <code>Storage</code> option for the <code>IntendedUse</code>
        /// parameter when requesting Places in Japan. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
        /// Service Terms</a> for Amazon Location Service.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForText service method.</param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForText service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForText">REST API Reference for SearchPlaceIndexForText Operation</seealso>
        SearchPlaceIndexForTextResponse SearchPlaceIndexForText(SearchPlaceIndexForTextRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchPlaceIndexForText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForText operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchPlaceIndexForText
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForText">REST API Reference for SearchPlaceIndexForText Operation</seealso>
        IAsyncResult BeginSearchPlaceIndexForText(SearchPlaceIndexForTextRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchPlaceIndexForText operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchPlaceIndexForText.</param>
        /// 
        /// <returns>Returns a  SearchPlaceIndexForTextResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForText">REST API Reference for SearchPlaceIndexForText Operation</seealso>
        SearchPlaceIndexForTextResponse EndSearchPlaceIndexForText(IAsyncResult asyncResult);

        #endregion
        
    }
}