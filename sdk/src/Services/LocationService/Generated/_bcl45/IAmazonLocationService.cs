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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LocationService.Model;

namespace Amazon.LocationService
{
    /// <summary>
    /// Interface for accessing LocationService
    ///
    /// "Suite of geospatial services including Maps, Places, Routes, Tracking, and Geofencing"
    /// </summary>
    public partial interface IAmazonLocationService : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILocationServicePaginatorFactory Paginators { get; }

        
        #region  AssociateTrackerConsumer


        /// <summary>
        /// Creates an association between a geofence collection and a tracker resource. This
        /// allows the tracker resource to communicate location data to the linked geofence collection.
        /// 
        /// 
        ///  
        /// <para>
        /// You can associate up to five geofence collections to each tracker resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently not supported — Cross-account configurations, such as creating associations
        /// between a tracker resource in one account and a geofence collection in another account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrackerConsumer service method.</param>
        /// 
        /// <returns>The response from the AssociateTrackerConsumer service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/AssociateTrackerConsumer">REST API Reference for AssociateTrackerConsumer Operation</seealso>
        AssociateTrackerConsumerResponse AssociateTrackerConsumer(AssociateTrackerConsumerRequest request);



        /// <summary>
        /// Creates an association between a geofence collection and a tracker resource. This
        /// allows the tracker resource to communicate location data to the linked geofence collection.
        /// 
        /// 
        ///  
        /// <para>
        /// You can associate up to five geofence collections to each tracker resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently not supported — Cross-account configurations, such as creating associations
        /// between a tracker resource in one account and a geofence collection in another account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrackerConsumer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateTrackerConsumer service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/AssociateTrackerConsumer">REST API Reference for AssociateTrackerConsumer Operation</seealso>
        Task<AssociateTrackerConsumerResponse> AssociateTrackerConsumerAsync(AssociateTrackerConsumerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeleteDevicePositionHistory


        /// <summary>
        /// Deletes the position history of one or more devices from a tracker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDevicePositionHistory service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteDevicePositionHistory service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchDeleteDevicePositionHistory">REST API Reference for BatchDeleteDevicePositionHistory Operation</seealso>
        BatchDeleteDevicePositionHistoryResponse BatchDeleteDevicePositionHistory(BatchDeleteDevicePositionHistoryRequest request);



        /// <summary>
        /// Deletes the position history of one or more devices from a tracker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDevicePositionHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteDevicePositionHistory service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchDeleteDevicePositionHistory">REST API Reference for BatchDeleteDevicePositionHistory Operation</seealso>
        Task<BatchDeleteDevicePositionHistoryResponse> BatchDeleteDevicePositionHistoryAsync(BatchDeleteDevicePositionHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeleteGeofence


        /// <summary>
        /// Deletes a batch of geofences from a geofence collection.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteGeofence service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchDeleteGeofence">REST API Reference for BatchDeleteGeofence Operation</seealso>
        BatchDeleteGeofenceResponse BatchDeleteGeofence(BatchDeleteGeofenceRequest request);



        /// <summary>
        /// Deletes a batch of geofences from a geofence collection.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteGeofence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchDeleteGeofence">REST API Reference for BatchDeleteGeofence Operation</seealso>
        Task<BatchDeleteGeofenceResponse> BatchDeleteGeofenceAsync(BatchDeleteGeofenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchEvaluateGeofences


        /// <summary>
        /// Evaluates device positions against the geofence geometries from a given geofence collection.
        /// 
        ///  
        /// <para>
        /// This operation always returns an empty response because geofences are asynchronously
        /// evaluated. The evaluation determines if the device has entered or exited a geofenced
        /// area, and then publishes one of the following events to Amazon EventBridge:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENTER</code> if Amazon Location determines that the tracked device has entered
        /// a geofenced area.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EXIT</code> if Amazon Location determines that the tracked device has exited
        /// a geofenced area.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The last geofence that a device was observed within is tracked for 30 days after the
        /// most recent device position update.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Geofence evaluation uses the given device position. It does not account for the optional
        /// <code>Accuracy</code> of a <code>DevicePositionUpdate</code>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// The <code>DeviceID</code> is used as a string to represent the device. You do not
        /// need to have a <code>Tracker</code> associated with the <code>DeviceID</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchEvaluateGeofences service method.</param>
        /// 
        /// <returns>The response from the BatchEvaluateGeofences service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchEvaluateGeofences">REST API Reference for BatchEvaluateGeofences Operation</seealso>
        BatchEvaluateGeofencesResponse BatchEvaluateGeofences(BatchEvaluateGeofencesRequest request);



        /// <summary>
        /// Evaluates device positions against the geofence geometries from a given geofence collection.
        /// 
        ///  
        /// <para>
        /// This operation always returns an empty response because geofences are asynchronously
        /// evaluated. The evaluation determines if the device has entered or exited a geofenced
        /// area, and then publishes one of the following events to Amazon EventBridge:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENTER</code> if Amazon Location determines that the tracked device has entered
        /// a geofenced area.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EXIT</code> if Amazon Location determines that the tracked device has exited
        /// a geofenced area.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The last geofence that a device was observed within is tracked for 30 days after the
        /// most recent device position update.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Geofence evaluation uses the given device position. It does not account for the optional
        /// <code>Accuracy</code> of a <code>DevicePositionUpdate</code>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// The <code>DeviceID</code> is used as a string to represent the device. You do not
        /// need to have a <code>Tracker</code> associated with the <code>DeviceID</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchEvaluateGeofences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchEvaluateGeofences service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchEvaluateGeofences">REST API Reference for BatchEvaluateGeofences Operation</seealso>
        Task<BatchEvaluateGeofencesResponse> BatchEvaluateGeofencesAsync(BatchEvaluateGeofencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetDevicePosition


        /// <summary>
        /// Lists the latest device positions for requested devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDevicePosition service method.</param>
        /// 
        /// <returns>The response from the BatchGetDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchGetDevicePosition">REST API Reference for BatchGetDevicePosition Operation</seealso>
        BatchGetDevicePositionResponse BatchGetDevicePosition(BatchGetDevicePositionRequest request);



        /// <summary>
        /// Lists the latest device positions for requested devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDevicePosition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchGetDevicePosition">REST API Reference for BatchGetDevicePosition Operation</seealso>
        Task<BatchGetDevicePositionResponse> BatchGetDevicePositionAsync(BatchGetDevicePositionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchPutGeofence


        /// <summary>
        /// A batch request for storing geofence geometries into a given geofence collection,
        /// or updates the geometry of an existing geofence if a geofence ID is included in the
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutGeofence service method.</param>
        /// 
        /// <returns>The response from the BatchPutGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchPutGeofence">REST API Reference for BatchPutGeofence Operation</seealso>
        BatchPutGeofenceResponse BatchPutGeofence(BatchPutGeofenceRequest request);



        /// <summary>
        /// A batch request for storing geofence geometries into a given geofence collection,
        /// or updates the geometry of an existing geofence if a geofence ID is included in the
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutGeofence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchPutGeofence">REST API Reference for BatchPutGeofence Operation</seealso>
        Task<BatchPutGeofenceResponse> BatchPutGeofenceAsync(BatchPutGeofenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchUpdateDevicePosition


        /// <summary>
        /// Uploads position update data for one or more devices to a tracker resource. Amazon
        /// Location uses the data when it reports the last known device position and position
        /// history. Amazon Location retains location data for 30 days.
        /// 
        ///  <note> 
        /// <para>
        /// Position updates are handled based on the <code>PositionFiltering</code> property
        /// of the tracker. When <code>PositionFiltering</code> is set to <code>TimeBased</code>,
        /// updates are evaluated against linked geofence collections, and location data is stored
        /// at a maximum of one position per 30 second interval. If your update frequency is more
        /// often than every 30 seconds, only one update per 30 seconds is stored for each unique
        /// device ID.
        /// </para>
        ///  
        /// <para>
        /// When <code>PositionFiltering</code> is set to <code>DistanceBased</code> filtering,
        /// location data is stored and evaluated against linked geofence collections only if
        /// the device has moved more than 30 m (98.4 ft).
        /// </para>
        ///  
        /// <para>
        /// When <code>PositionFiltering</code> is set to <code>AccuracyBased</code> filtering,
        /// location data is stored and evaluated against linked geofence collections only if
        /// the device has moved more than the measured accuracy. For example, if two consecutive
        /// updates from a device have a horizontal accuracy of 5 m and 10 m, the second update
        /// is neither stored or evaluated if the device has moved less than 15 m. If <code>PositionFiltering</code>
        /// is set to <code>AccuracyBased</code> filtering, Amazon Location uses the default value
        /// <code>{ "Horizontal": 0}</code> when accuracy is not provided on a <code>DevicePositionUpdate</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDevicePosition service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchUpdateDevicePosition">REST API Reference for BatchUpdateDevicePosition Operation</seealso>
        BatchUpdateDevicePositionResponse BatchUpdateDevicePosition(BatchUpdateDevicePositionRequest request);



        /// <summary>
        /// Uploads position update data for one or more devices to a tracker resource. Amazon
        /// Location uses the data when it reports the last known device position and position
        /// history. Amazon Location retains location data for 30 days.
        /// 
        ///  <note> 
        /// <para>
        /// Position updates are handled based on the <code>PositionFiltering</code> property
        /// of the tracker. When <code>PositionFiltering</code> is set to <code>TimeBased</code>,
        /// updates are evaluated against linked geofence collections, and location data is stored
        /// at a maximum of one position per 30 second interval. If your update frequency is more
        /// often than every 30 seconds, only one update per 30 seconds is stored for each unique
        /// device ID.
        /// </para>
        ///  
        /// <para>
        /// When <code>PositionFiltering</code> is set to <code>DistanceBased</code> filtering,
        /// location data is stored and evaluated against linked geofence collections only if
        /// the device has moved more than 30 m (98.4 ft).
        /// </para>
        ///  
        /// <para>
        /// When <code>PositionFiltering</code> is set to <code>AccuracyBased</code> filtering,
        /// location data is stored and evaluated against linked geofence collections only if
        /// the device has moved more than the measured accuracy. For example, if two consecutive
        /// updates from a device have a horizontal accuracy of 5 m and 10 m, the second update
        /// is neither stored or evaluated if the device has moved less than 15 m. If <code>PositionFiltering</code>
        /// is set to <code>AccuracyBased</code> filtering, Amazon Location uses the default value
        /// <code>{ "Horizontal": 0}</code> when accuracy is not provided on a <code>DevicePositionUpdate</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDevicePosition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchUpdateDevicePosition">REST API Reference for BatchUpdateDevicePosition Operation</seealso>
        Task<BatchUpdateDevicePositionResponse> BatchUpdateDevicePositionAsync(BatchUpdateDevicePositionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CalculateRoute


        /// <summary>
        /// <a href="https://docs.aws.amazon.com/location/latest/developerguide/calculate-route.html">Calculates
        /// a route</a> given the following required parameters: <code>DeparturePosition</code>
        /// and <code>DestinationPosition</code>. Requires that you first <a href="https://docs.aws.amazon.com/location-routes/latest/APIReference/API_CreateRouteCalculator.html">create
        /// a route calculator resource</a>.
        /// 
        ///  
        /// <para>
        /// By default, a request that doesn't specify a departure time uses the best time of
        /// day to travel with the best traffic conditions when calculating the route.
        /// </para>
        ///  
        /// <para>
        /// Additional options include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/departure-time.html">Specifying
        /// a departure time</a> using either <code>DepartureTime</code> or <code>DepartNow</code>.
        /// This calculates a route based on predictive traffic data at the given time. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't specify both <code>DepartureTime</code> and <code>DepartNow</code> in a
        /// single request. Specifying both parameters returns a validation error.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/travel-mode.html">Specifying
        /// a travel mode</a> using TravelMode sets the transportation mode used to calculate
        /// the routes. This also lets you specify additional route preferences in <code>CarModeOptions</code>
        /// if traveling by <code>Car</code>, or <code>TruckModeOptions</code> if traveling by
        /// <code>Truck</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <code>walking</code> for the travel mode and your data provider is
        /// Esri, the start and destination must be within 40km.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CalculateRoute service method.</param>
        /// 
        /// <returns>The response from the CalculateRoute service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CalculateRoute">REST API Reference for CalculateRoute Operation</seealso>
        CalculateRouteResponse CalculateRoute(CalculateRouteRequest request);



        /// <summary>
        /// <a href="https://docs.aws.amazon.com/location/latest/developerguide/calculate-route.html">Calculates
        /// a route</a> given the following required parameters: <code>DeparturePosition</code>
        /// and <code>DestinationPosition</code>. Requires that you first <a href="https://docs.aws.amazon.com/location-routes/latest/APIReference/API_CreateRouteCalculator.html">create
        /// a route calculator resource</a>.
        /// 
        ///  
        /// <para>
        /// By default, a request that doesn't specify a departure time uses the best time of
        /// day to travel with the best traffic conditions when calculating the route.
        /// </para>
        ///  
        /// <para>
        /// Additional options include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/departure-time.html">Specifying
        /// a departure time</a> using either <code>DepartureTime</code> or <code>DepartNow</code>.
        /// This calculates a route based on predictive traffic data at the given time. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't specify both <code>DepartureTime</code> and <code>DepartNow</code> in a
        /// single request. Specifying both parameters returns a validation error.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/travel-mode.html">Specifying
        /// a travel mode</a> using TravelMode sets the transportation mode used to calculate
        /// the routes. This also lets you specify additional route preferences in <code>CarModeOptions</code>
        /// if traveling by <code>Car</code>, or <code>TruckModeOptions</code> if traveling by
        /// <code>Truck</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <code>walking</code> for the travel mode and your data provider is
        /// Esri, the start and destination must be within 40km.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CalculateRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CalculateRoute service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CalculateRoute">REST API Reference for CalculateRoute Operation</seealso>
        Task<CalculateRouteResponse> CalculateRouteAsync(CalculateRouteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CalculateRouteMatrix


        /// <summary>
        /// <a href="https://docs.aws.amazon.com/location/latest/developerguide/calculate-route-matrix.html">
        /// Calculates a route matrix</a> given the following required parameters: <code>DeparturePositions</code>
        /// and <code>DestinationPositions</code>. <code>CalculateRouteMatrix</code> calculates
        /// routes and returns the travel time and travel distance from each departure position
        /// to each destination position in the request. For example, given departure positions
        /// A and B, and destination positions X and Y, <code>CalculateRouteMatrix</code> will
        /// return time and distance for routes from A to X, A to Y, B to X, and B to Y (in that
        /// order). The number of results returned (and routes calculated) will be the number
        /// of <code>DeparturePositions</code> times the number of <code>DestinationPositions</code>.
        /// 
        ///  <note> 
        /// <para>
        /// Your account is charged for each route calculated, not the number of requests.
        /// </para>
        ///  </note> 
        /// <para>
        /// Requires that you first <a href="https://docs.aws.amazon.com/location-routes/latest/APIReference/API_CreateRouteCalculator.html">create
        /// a route calculator resource</a>.
        /// </para>
        ///  
        /// <para>
        /// By default, a request that doesn't specify a departure time uses the best time of
        /// day to travel with the best traffic conditions when calculating routes.
        /// </para>
        ///  
        /// <para>
        /// Additional options include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/departure-time.html">
        /// Specifying a departure time</a> using either <code>DepartureTime</code> or <code>DepartNow</code>.
        /// This calculates routes based on predictive traffic data at the given time. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't specify both <code>DepartureTime</code> and <code>DepartNow</code> in a
        /// single request. Specifying both parameters returns a validation error.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/travel-mode.html">Specifying
        /// a travel mode</a> using TravelMode sets the transportation mode used to calculate
        /// the routes. This also lets you specify additional route preferences in <code>CarModeOptions</code>
        /// if traveling by <code>Car</code>, or <code>TruckModeOptions</code> if traveling by
        /// <code>Truck</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CalculateRouteMatrix service method.</param>
        /// 
        /// <returns>The response from the CalculateRouteMatrix service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CalculateRouteMatrix">REST API Reference for CalculateRouteMatrix Operation</seealso>
        CalculateRouteMatrixResponse CalculateRouteMatrix(CalculateRouteMatrixRequest request);



        /// <summary>
        /// <a href="https://docs.aws.amazon.com/location/latest/developerguide/calculate-route-matrix.html">
        /// Calculates a route matrix</a> given the following required parameters: <code>DeparturePositions</code>
        /// and <code>DestinationPositions</code>. <code>CalculateRouteMatrix</code> calculates
        /// routes and returns the travel time and travel distance from each departure position
        /// to each destination position in the request. For example, given departure positions
        /// A and B, and destination positions X and Y, <code>CalculateRouteMatrix</code> will
        /// return time and distance for routes from A to X, A to Y, B to X, and B to Y (in that
        /// order). The number of results returned (and routes calculated) will be the number
        /// of <code>DeparturePositions</code> times the number of <code>DestinationPositions</code>.
        /// 
        ///  <note> 
        /// <para>
        /// Your account is charged for each route calculated, not the number of requests.
        /// </para>
        ///  </note> 
        /// <para>
        /// Requires that you first <a href="https://docs.aws.amazon.com/location-routes/latest/APIReference/API_CreateRouteCalculator.html">create
        /// a route calculator resource</a>.
        /// </para>
        ///  
        /// <para>
        /// By default, a request that doesn't specify a departure time uses the best time of
        /// day to travel with the best traffic conditions when calculating routes.
        /// </para>
        ///  
        /// <para>
        /// Additional options include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/departure-time.html">
        /// Specifying a departure time</a> using either <code>DepartureTime</code> or <code>DepartNow</code>.
        /// This calculates routes based on predictive traffic data at the given time. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't specify both <code>DepartureTime</code> and <code>DepartNow</code> in a
        /// single request. Specifying both parameters returns a validation error.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/travel-mode.html">Specifying
        /// a travel mode</a> using TravelMode sets the transportation mode used to calculate
        /// the routes. This also lets you specify additional route preferences in <code>CarModeOptions</code>
        /// if traveling by <code>Car</code>, or <code>TruckModeOptions</code> if traveling by
        /// <code>Truck</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CalculateRouteMatrix service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CalculateRouteMatrix service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CalculateRouteMatrix">REST API Reference for CalculateRouteMatrix Operation</seealso>
        Task<CalculateRouteMatrixResponse> CalculateRouteMatrixAsync(CalculateRouteMatrixRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGeofenceCollection


        /// <summary>
        /// Creates a geofence collection, which manages and stores geofences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGeofenceCollection service method.</param>
        /// 
        /// <returns>The response from the CreateGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateGeofenceCollection">REST API Reference for CreateGeofenceCollection Operation</seealso>
        CreateGeofenceCollectionResponse CreateGeofenceCollection(CreateGeofenceCollectionRequest request);



        /// <summary>
        /// Creates a geofence collection, which manages and stores geofences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGeofenceCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateGeofenceCollection">REST API Reference for CreateGeofenceCollection Operation</seealso>
        Task<CreateGeofenceCollectionResponse> CreateGeofenceCollectionAsync(CreateGeofenceCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateKey


        /// <summary>
        /// Creates an API key resource in your Amazon Web Services account, which lets you grant
        /// <code>geo:GetMap*</code> actions for Amazon Location Map resources to the API key
        /// bearer.
        /// 
        ///  <important> 
        /// <para>
        /// The API keys feature is in preview. We may add, change, or remove features before
        /// announcing general availability. For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/using-apikeys.html">Using
        /// API keys</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKey service method.</param>
        /// 
        /// <returns>The response from the CreateKey service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateKey">REST API Reference for CreateKey Operation</seealso>
        CreateKeyResponse CreateKey(CreateKeyRequest request);



        /// <summary>
        /// Creates an API key resource in your Amazon Web Services account, which lets you grant
        /// <code>geo:GetMap*</code> actions for Amazon Location Map resources to the API key
        /// bearer.
        /// 
        ///  <important> 
        /// <para>
        /// The API keys feature is in preview. We may add, change, or remove features before
        /// announcing general availability. For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/using-apikeys.html">Using
        /// API keys</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKey service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateKey">REST API Reference for CreateKey Operation</seealso>
        Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMap


        /// <summary>
        /// Creates a map resource in your Amazon Web Services account, which provides map tiles
        /// of different styles sourced from global location data providers.
        /// 
        ///  <note> 
        /// <para>
        /// If your application is tracking or routing assets you use in your business, such as
        /// delivery vehicles or employees, you must not use Esri as your geolocation provider.
        /// See section 82 of the <a href="http://aws.amazon.com/service-terms">Amazon Web Services
        /// service terms</a> for more details.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMap service method.</param>
        /// 
        /// <returns>The response from the CreateMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateMap">REST API Reference for CreateMap Operation</seealso>
        CreateMapResponse CreateMap(CreateMapRequest request);



        /// <summary>
        /// Creates a map resource in your Amazon Web Services account, which provides map tiles
        /// of different styles sourced from global location data providers.
        /// 
        ///  <note> 
        /// <para>
        /// If your application is tracking or routing assets you use in your business, such as
        /// delivery vehicles or employees, you must not use Esri as your geolocation provider.
        /// See section 82 of the <a href="http://aws.amazon.com/service-terms">Amazon Web Services
        /// service terms</a> for more details.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateMap">REST API Reference for CreateMap Operation</seealso>
        Task<CreateMapResponse> CreateMapAsync(CreateMapRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePlaceIndex


        /// <summary>
        /// Creates a place index resource in your Amazon Web Services account. Use a place index
        /// resource to geocode addresses and other text queries by using the <code>SearchPlaceIndexForText</code>
        /// operation, and reverse geocode coordinates by using the <code>SearchPlaceIndexForPosition</code>
        /// operation, and enable autosuggestions by using the <code>SearchPlaceIndexForSuggestions</code>
        /// operation.
        /// 
        ///  <note> 
        /// <para>
        /// If your application is tracking or routing assets you use in your business, such as
        /// delivery vehicles or employees, you must not use Esri as your geolocation provider.
        /// See section 82 of the <a href="http://aws.amazon.com/service-terms">Amazon Web Services
        /// service terms</a> for more details.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlaceIndex service method.</param>
        /// 
        /// <returns>The response from the CreatePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreatePlaceIndex">REST API Reference for CreatePlaceIndex Operation</seealso>
        CreatePlaceIndexResponse CreatePlaceIndex(CreatePlaceIndexRequest request);



        /// <summary>
        /// Creates a place index resource in your Amazon Web Services account. Use a place index
        /// resource to geocode addresses and other text queries by using the <code>SearchPlaceIndexForText</code>
        /// operation, and reverse geocode coordinates by using the <code>SearchPlaceIndexForPosition</code>
        /// operation, and enable autosuggestions by using the <code>SearchPlaceIndexForSuggestions</code>
        /// operation.
        /// 
        ///  <note> 
        /// <para>
        /// If your application is tracking or routing assets you use in your business, such as
        /// delivery vehicles or employees, you must not use Esri as your geolocation provider.
        /// See section 82 of the <a href="http://aws.amazon.com/service-terms">Amazon Web Services
        /// service terms</a> for more details.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlaceIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreatePlaceIndex">REST API Reference for CreatePlaceIndex Operation</seealso>
        Task<CreatePlaceIndexResponse> CreatePlaceIndexAsync(CreatePlaceIndexRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRouteCalculator


        /// <summary>
        /// Creates a route calculator resource in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// You can send requests to a route calculator resource to estimate travel time, distance,
        /// and get directions. A route calculator sources traffic and road network data from
        /// your chosen data provider.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your application is tracking or routing assets you use in your business, such as
        /// delivery vehicles or employees, you must not use Esri as your geolocation provider.
        /// See section 82 of the <a href="http://aws.amazon.com/service-terms">Amazon Web Services
        /// service terms</a> for more details.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteCalculator service method.</param>
        /// 
        /// <returns>The response from the CreateRouteCalculator service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateRouteCalculator">REST API Reference for CreateRouteCalculator Operation</seealso>
        CreateRouteCalculatorResponse CreateRouteCalculator(CreateRouteCalculatorRequest request);



        /// <summary>
        /// Creates a route calculator resource in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// You can send requests to a route calculator resource to estimate travel time, distance,
        /// and get directions. A route calculator sources traffic and road network data from
        /// your chosen data provider.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your application is tracking or routing assets you use in your business, such as
        /// delivery vehicles or employees, you must not use Esri as your geolocation provider.
        /// See section 82 of the <a href="http://aws.amazon.com/service-terms">Amazon Web Services
        /// service terms</a> for more details.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteCalculator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRouteCalculator service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateRouteCalculator">REST API Reference for CreateRouteCalculator Operation</seealso>
        Task<CreateRouteCalculatorResponse> CreateRouteCalculatorAsync(CreateRouteCalculatorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTracker


        /// <summary>
        /// Creates a tracker resource in your Amazon Web Services account, which lets you retrieve
        /// current and historical location of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTracker service method.</param>
        /// 
        /// <returns>The response from the CreateTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateTracker">REST API Reference for CreateTracker Operation</seealso>
        CreateTrackerResponse CreateTracker(CreateTrackerRequest request);



        /// <summary>
        /// Creates a tracker resource in your Amazon Web Services account, which lets you retrieve
        /// current and historical location of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTracker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateTracker">REST API Reference for CreateTracker Operation</seealso>
        Task<CreateTrackerResponse> CreateTrackerAsync(CreateTrackerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGeofenceCollection


        /// <summary>
        /// Deletes a geofence collection from your Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently. If the geofence collection is the
        /// target of a tracker resource, the devices will no longer be monitored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeofenceCollection service method.</param>
        /// 
        /// <returns>The response from the DeleteGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteGeofenceCollection">REST API Reference for DeleteGeofenceCollection Operation</seealso>
        DeleteGeofenceCollectionResponse DeleteGeofenceCollection(DeleteGeofenceCollectionRequest request);



        /// <summary>
        /// Deletes a geofence collection from your Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently. If the geofence collection is the
        /// target of a tracker resource, the devices will no longer be monitored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeofenceCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteGeofenceCollection">REST API Reference for DeleteGeofenceCollection Operation</seealso>
        Task<DeleteGeofenceCollectionResponse> DeleteGeofenceCollectionAsync(DeleteGeofenceCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteKey


        /// <summary>
        /// Deletes the specified API key. The API key must have been deactivated more than 90
        /// days previously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKey service method.</param>
        /// 
        /// <returns>The response from the DeleteKey service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteKey">REST API Reference for DeleteKey Operation</seealso>
        DeleteKeyResponse DeleteKey(DeleteKeyRequest request);



        /// <summary>
        /// Deletes the specified API key. The API key must have been deactivated more than 90
        /// days previously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKey service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteKey">REST API Reference for DeleteKey Operation</seealso>
        Task<DeleteKeyResponse> DeleteKeyAsync(DeleteKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMap


        /// <summary>
        /// Deletes a map resource from your Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently. If the map is being used in an application,
        /// the map may not render.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMap service method.</param>
        /// 
        /// <returns>The response from the DeleteMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteMap">REST API Reference for DeleteMap Operation</seealso>
        DeleteMapResponse DeleteMap(DeleteMapRequest request);



        /// <summary>
        /// Deletes a map resource from your Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently. If the map is being used in an application,
        /// the map may not render.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteMap">REST API Reference for DeleteMap Operation</seealso>
        Task<DeleteMapResponse> DeleteMapAsync(DeleteMapRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePlaceIndex


        /// <summary>
        /// Deletes a place index resource from your Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaceIndex service method.</param>
        /// 
        /// <returns>The response from the DeletePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeletePlaceIndex">REST API Reference for DeletePlaceIndex Operation</seealso>
        DeletePlaceIndexResponse DeletePlaceIndex(DeletePlaceIndexRequest request);



        /// <summary>
        /// Deletes a place index resource from your Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaceIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeletePlaceIndex">REST API Reference for DeletePlaceIndex Operation</seealso>
        Task<DeletePlaceIndexResponse> DeletePlaceIndexAsync(DeletePlaceIndexRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRouteCalculator


        /// <summary>
        /// Deletes a route calculator resource from your Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteCalculator service method.</param>
        /// 
        /// <returns>The response from the DeleteRouteCalculator service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteRouteCalculator">REST API Reference for DeleteRouteCalculator Operation</seealso>
        DeleteRouteCalculatorResponse DeleteRouteCalculator(DeleteRouteCalculatorRequest request);



        /// <summary>
        /// Deletes a route calculator resource from your Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteCalculator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRouteCalculator service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteRouteCalculator">REST API Reference for DeleteRouteCalculator Operation</seealso>
        Task<DeleteRouteCalculatorResponse> DeleteRouteCalculatorAsync(DeleteRouteCalculatorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTracker


        /// <summary>
        /// Deletes a tracker resource from your Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently. If the tracker resource is in use,
        /// you may encounter an error. Make sure that the target resource isn't a dependency
        /// for your applications.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTracker service method.</param>
        /// 
        /// <returns>The response from the DeleteTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteTracker">REST API Reference for DeleteTracker Operation</seealso>
        DeleteTrackerResponse DeleteTracker(DeleteTrackerRequest request);



        /// <summary>
        /// Deletes a tracker resource from your Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently. If the tracker resource is in use,
        /// you may encounter an error. Make sure that the target resource isn't a dependency
        /// for your applications.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTracker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteTracker">REST API Reference for DeleteTracker Operation</seealso>
        Task<DeleteTrackerResponse> DeleteTrackerAsync(DeleteTrackerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeGeofenceCollection


        /// <summary>
        /// Retrieves the geofence collection details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGeofenceCollection service method.</param>
        /// 
        /// <returns>The response from the DescribeGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeGeofenceCollection">REST API Reference for DescribeGeofenceCollection Operation</seealso>
        DescribeGeofenceCollectionResponse DescribeGeofenceCollection(DescribeGeofenceCollectionRequest request);



        /// <summary>
        /// Retrieves the geofence collection details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGeofenceCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeGeofenceCollection">REST API Reference for DescribeGeofenceCollection Operation</seealso>
        Task<DescribeGeofenceCollectionResponse> DescribeGeofenceCollectionAsync(DescribeGeofenceCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeKey


        /// <summary>
        /// Retrieves the API key resource details.
        /// 
        ///  <important> 
        /// <para>
        /// The API keys feature is in preview. We may add, change, or remove features before
        /// announcing general availability. For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/using-apikeys.html">Using
        /// API keys</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey service method.</param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        DescribeKeyResponse DescribeKey(DescribeKeyRequest request);



        /// <summary>
        /// Retrieves the API key resource details.
        /// 
        ///  <important> 
        /// <para>
        /// The API keys feature is in preview. We may add, change, or remove features before
        /// announcing general availability. For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/using-apikeys.html">Using
        /// API keys</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        Task<DescribeKeyResponse> DescribeKeyAsync(DescribeKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMap


        /// <summary>
        /// Retrieves the map resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMap service method.</param>
        /// 
        /// <returns>The response from the DescribeMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeMap">REST API Reference for DescribeMap Operation</seealso>
        DescribeMapResponse DescribeMap(DescribeMapRequest request);



        /// <summary>
        /// Retrieves the map resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeMap">REST API Reference for DescribeMap Operation</seealso>
        Task<DescribeMapResponse> DescribeMapAsync(DescribeMapRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePlaceIndex


        /// <summary>
        /// Retrieves the place index resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlaceIndex service method.</param>
        /// 
        /// <returns>The response from the DescribePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribePlaceIndex">REST API Reference for DescribePlaceIndex Operation</seealso>
        DescribePlaceIndexResponse DescribePlaceIndex(DescribePlaceIndexRequest request);



        /// <summary>
        /// Retrieves the place index resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlaceIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribePlaceIndex">REST API Reference for DescribePlaceIndex Operation</seealso>
        Task<DescribePlaceIndexResponse> DescribePlaceIndexAsync(DescribePlaceIndexRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRouteCalculator


        /// <summary>
        /// Retrieves the route calculator resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteCalculator service method.</param>
        /// 
        /// <returns>The response from the DescribeRouteCalculator service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeRouteCalculator">REST API Reference for DescribeRouteCalculator Operation</seealso>
        DescribeRouteCalculatorResponse DescribeRouteCalculator(DescribeRouteCalculatorRequest request);



        /// <summary>
        /// Retrieves the route calculator resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteCalculator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRouteCalculator service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeRouteCalculator">REST API Reference for DescribeRouteCalculator Operation</seealso>
        Task<DescribeRouteCalculatorResponse> DescribeRouteCalculatorAsync(DescribeRouteCalculatorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTracker


        /// <summary>
        /// Retrieves the tracker resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTracker service method.</param>
        /// 
        /// <returns>The response from the DescribeTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeTracker">REST API Reference for DescribeTracker Operation</seealso>
        DescribeTrackerResponse DescribeTracker(DescribeTrackerRequest request);



        /// <summary>
        /// Retrieves the tracker resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTracker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeTracker">REST API Reference for DescribeTracker Operation</seealso>
        Task<DescribeTrackerResponse> DescribeTrackerAsync(DescribeTrackerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateTrackerConsumer


        /// <summary>
        /// Removes the association between a tracker resource and a geofence collection.
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
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DisassociateTrackerConsumer">REST API Reference for DisassociateTrackerConsumer Operation</seealso>
        DisassociateTrackerConsumerResponse DisassociateTrackerConsumer(DisassociateTrackerConsumerRequest request);



        /// <summary>
        /// Removes the association between a tracker resource and a geofence collection.
        /// 
        ///  <note> 
        /// <para>
        /// Once you unlink a tracker resource from a geofence collection, the tracker positions
        /// will no longer be automatically evaluated against geofences.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrackerConsumer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTrackerConsumer service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DisassociateTrackerConsumer">REST API Reference for DisassociateTrackerConsumer Operation</seealso>
        Task<DisassociateTrackerConsumerResponse> DisassociateTrackerConsumerAsync(DisassociateTrackerConsumerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDevicePosition


        /// <summary>
        /// Retrieves a device's most recent position according to its sample time.
        /// 
        ///  <note> 
        /// <para>
        /// Device positions are deleted after 30 days.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePosition service method.</param>
        /// 
        /// <returns>The response from the GetDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePosition">REST API Reference for GetDevicePosition Operation</seealso>
        GetDevicePositionResponse GetDevicePosition(GetDevicePositionRequest request);



        /// <summary>
        /// Retrieves a device's most recent position according to its sample time.
        /// 
        ///  <note> 
        /// <para>
        /// Device positions are deleted after 30 days.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePosition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePosition">REST API Reference for GetDevicePosition Operation</seealso>
        Task<GetDevicePositionResponse> GetDevicePositionAsync(GetDevicePositionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDevicePositionHistory


        /// <summary>
        /// Retrieves the device position history from a tracker resource within a specified range
        /// of time.
        /// 
        ///  <note> 
        /// <para>
        /// Device positions are deleted after 30 days.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePositionHistory service method.</param>
        /// 
        /// <returns>The response from the GetDevicePositionHistory service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePositionHistory">REST API Reference for GetDevicePositionHistory Operation</seealso>
        GetDevicePositionHistoryResponse GetDevicePositionHistory(GetDevicePositionHistoryRequest request);



        /// <summary>
        /// Retrieves the device position history from a tracker resource within a specified range
        /// of time.
        /// 
        ///  <note> 
        /// <para>
        /// Device positions are deleted after 30 days.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePositionHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevicePositionHistory service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePositionHistory">REST API Reference for GetDevicePositionHistory Operation</seealso>
        Task<GetDevicePositionHistoryResponse> GetDevicePositionHistoryAsync(GetDevicePositionHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGeofence


        /// <summary>
        /// Retrieves the geofence details from a geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeofence service method.</param>
        /// 
        /// <returns>The response from the GetGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetGeofence">REST API Reference for GetGeofence Operation</seealso>
        GetGeofenceResponse GetGeofence(GetGeofenceRequest request);



        /// <summary>
        /// Retrieves the geofence details from a geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeofence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetGeofence">REST API Reference for GetGeofence Operation</seealso>
        Task<GetGeofenceResponse> GetGeofenceAsync(GetGeofenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMapGlyphs


        /// <summary>
        /// Retrieves glyphs used to display labels on a map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapGlyphs service method.</param>
        /// 
        /// <returns>The response from the GetMapGlyphs service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapGlyphs">REST API Reference for GetMapGlyphs Operation</seealso>
        GetMapGlyphsResponse GetMapGlyphs(GetMapGlyphsRequest request);



        /// <summary>
        /// Retrieves glyphs used to display labels on a map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapGlyphs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMapGlyphs service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapGlyphs">REST API Reference for GetMapGlyphs Operation</seealso>
        Task<GetMapGlyphsResponse> GetMapGlyphsAsync(GetMapGlyphsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapSprites">REST API Reference for GetMapSprites Operation</seealso>
        GetMapSpritesResponse GetMapSprites(GetMapSpritesRequest request);



        /// <summary>
        /// Retrieves the sprite sheet corresponding to a map resource. The sprite sheet is a
        /// PNG image paired with a JSON document describing the offsets of individual icons that
        /// will be displayed on a rendered map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapSprites service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMapSprites service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapSprites">REST API Reference for GetMapSprites Operation</seealso>
        Task<GetMapSpritesResponse> GetMapSpritesAsync(GetMapSpritesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapStyleDescriptor">REST API Reference for GetMapStyleDescriptor Operation</seealso>
        GetMapStyleDescriptorResponse GetMapStyleDescriptor(GetMapStyleDescriptorRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMapStyleDescriptor service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapStyleDescriptor">REST API Reference for GetMapStyleDescriptor Operation</seealso>
        Task<GetMapStyleDescriptorResponse> GetMapStyleDescriptorAsync(GetMapStyleDescriptorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMapTile


        /// <summary>
        /// Retrieves a vector data tile from the map resource. Map tiles are used by clients
        /// to render a map. they're addressed using a grid arrangement with an X coordinate,
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
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapTile">REST API Reference for GetMapTile Operation</seealso>
        GetMapTileResponse GetMapTile(GetMapTileRequest request);



        /// <summary>
        /// Retrieves a vector data tile from the map resource. Map tiles are used by clients
        /// to render a map. they're addressed using a grid arrangement with an X coordinate,
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMapTile service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapTile">REST API Reference for GetMapTile Operation</seealso>
        Task<GetMapTileResponse> GetMapTileAsync(GetMapTileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPlace


        /// <summary>
        /// Finds a place by its unique ID. A <code>PlaceId</code> is returned by other search
        /// operations.
        /// 
        ///  <note> 
        /// <para>
        /// A PlaceId is valid only if all of the following are the same in the original search
        /// request and the call to <code>GetPlace</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Customer Amazon Web Services account
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Region
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data provider specified in the place index resource
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlace service method.</param>
        /// 
        /// <returns>The response from the GetPlace service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetPlace">REST API Reference for GetPlace Operation</seealso>
        GetPlaceResponse GetPlace(GetPlaceRequest request);



        /// <summary>
        /// Finds a place by its unique ID. A <code>PlaceId</code> is returned by other search
        /// operations.
        /// 
        ///  <note> 
        /// <para>
        /// A PlaceId is valid only if all of the following are the same in the original search
        /// request and the call to <code>GetPlace</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Customer Amazon Web Services account
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Region
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data provider specified in the place index resource
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlace service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetPlace">REST API Reference for GetPlace Operation</seealso>
        Task<GetPlaceResponse> GetPlaceAsync(GetPlaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDevicePositions


        /// <summary>
        /// A batch request to retrieve all device positions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicePositions service method.</param>
        /// 
        /// <returns>The response from the ListDevicePositions service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListDevicePositions">REST API Reference for ListDevicePositions Operation</seealso>
        ListDevicePositionsResponse ListDevicePositions(ListDevicePositionsRequest request);



        /// <summary>
        /// A batch request to retrieve all device positions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicePositions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevicePositions service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListDevicePositions">REST API Reference for ListDevicePositions Operation</seealso>
        Task<ListDevicePositionsResponse> ListDevicePositionsAsync(ListDevicePositionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGeofenceCollections


        /// <summary>
        /// Lists geofence collections in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeofenceCollections service method.</param>
        /// 
        /// <returns>The response from the ListGeofenceCollections service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofenceCollections">REST API Reference for ListGeofenceCollections Operation</seealso>
        ListGeofenceCollectionsResponse ListGeofenceCollections(ListGeofenceCollectionsRequest request);



        /// <summary>
        /// Lists geofence collections in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeofenceCollections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGeofenceCollections service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofenceCollections">REST API Reference for ListGeofenceCollections Operation</seealso>
        Task<ListGeofenceCollectionsResponse> ListGeofenceCollectionsAsync(ListGeofenceCollectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGeofences


        /// <summary>
        /// Lists geofences stored in a given geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeofences service method.</param>
        /// 
        /// <returns>The response from the ListGeofences service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofences">REST API Reference for ListGeofences Operation</seealso>
        ListGeofencesResponse ListGeofences(ListGeofencesRequest request);



        /// <summary>
        /// Lists geofences stored in a given geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeofences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGeofences service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofences">REST API Reference for ListGeofences Operation</seealso>
        Task<ListGeofencesResponse> ListGeofencesAsync(ListGeofencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListKeys


        /// <summary>
        /// Lists API key resources in your Amazon Web Services account.
        /// 
        ///  <important> 
        /// <para>
        /// The API keys feature is in preview. We may add, change, or remove features before
        /// announcing general availability. For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/using-apikeys.html">Using
        /// API keys</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// 
        /// <returns>The response from the ListKeys service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListKeys">REST API Reference for ListKeys Operation</seealso>
        ListKeysResponse ListKeys(ListKeysRequest request);



        /// <summary>
        /// Lists API key resources in your Amazon Web Services account.
        /// 
        ///  <important> 
        /// <para>
        /// The API keys feature is in preview. We may add, change, or remove features before
        /// announcing general availability. For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/using-apikeys.html">Using
        /// API keys</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeys service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListKeys">REST API Reference for ListKeys Operation</seealso>
        Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMaps


        /// <summary>
        /// Lists map resources in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMaps service method.</param>
        /// 
        /// <returns>The response from the ListMaps service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListMaps">REST API Reference for ListMaps Operation</seealso>
        ListMapsResponse ListMaps(ListMapsRequest request);



        /// <summary>
        /// Lists map resources in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMaps service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListMaps">REST API Reference for ListMaps Operation</seealso>
        Task<ListMapsResponse> ListMapsAsync(ListMapsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPlaceIndexes


        /// <summary>
        /// Lists place index resources in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaceIndexes service method.</param>
        /// 
        /// <returns>The response from the ListPlaceIndexes service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListPlaceIndexes">REST API Reference for ListPlaceIndexes Operation</seealso>
        ListPlaceIndexesResponse ListPlaceIndexes(ListPlaceIndexesRequest request);



        /// <summary>
        /// Lists place index resources in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaceIndexes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlaceIndexes service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListPlaceIndexes">REST API Reference for ListPlaceIndexes Operation</seealso>
        Task<ListPlaceIndexesResponse> ListPlaceIndexesAsync(ListPlaceIndexesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRouteCalculators


        /// <summary>
        /// Lists route calculator resources in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRouteCalculators service method.</param>
        /// 
        /// <returns>The response from the ListRouteCalculators service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListRouteCalculators">REST API Reference for ListRouteCalculators Operation</seealso>
        ListRouteCalculatorsResponse ListRouteCalculators(ListRouteCalculatorsRequest request);



        /// <summary>
        /// Lists route calculator resources in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRouteCalculators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRouteCalculators service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListRouteCalculators">REST API Reference for ListRouteCalculators Operation</seealso>
        Task<ListRouteCalculatorsResponse> ListRouteCalculatorsAsync(ListRouteCalculatorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of tags that are applied to the specified Amazon Location resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Returns a list of tags that are applied to the specified Amazon Location resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTrackerConsumers


        /// <summary>
        /// Lists geofence collections currently associated to the given tracker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrackerConsumers service method.</param>
        /// 
        /// <returns>The response from the ListTrackerConsumers service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackerConsumers">REST API Reference for ListTrackerConsumers Operation</seealso>
        ListTrackerConsumersResponse ListTrackerConsumers(ListTrackerConsumersRequest request);



        /// <summary>
        /// Lists geofence collections currently associated to the given tracker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrackerConsumers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrackerConsumers service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackerConsumers">REST API Reference for ListTrackerConsumers Operation</seealso>
        Task<ListTrackerConsumersResponse> ListTrackerConsumersAsync(ListTrackerConsumersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTrackers


        /// <summary>
        /// Lists tracker resources in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrackers service method.</param>
        /// 
        /// <returns>The response from the ListTrackers service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackers">REST API Reference for ListTrackers Operation</seealso>
        ListTrackersResponse ListTrackers(ListTrackersRequest request);



        /// <summary>
        /// Lists tracker resources in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrackers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrackers service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackers">REST API Reference for ListTrackers Operation</seealso>
        Task<ListTrackersResponse> ListTrackersAsync(ListTrackersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutGeofence


        /// <summary>
        /// Stores a geofence geometry in a given geofence collection, or updates the geometry
        /// of an existing geofence if a geofence ID is included in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGeofence service method.</param>
        /// 
        /// <returns>The response from the PutGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/PutGeofence">REST API Reference for PutGeofence Operation</seealso>
        PutGeofenceResponse PutGeofence(PutGeofenceRequest request);



        /// <summary>
        /// Stores a geofence geometry in a given geofence collection, or updates the geometry
        /// of an existing geofence if a geofence ID is included in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGeofence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/PutGeofence">REST API Reference for PutGeofence Operation</seealso>
        Task<PutGeofenceResponse> PutGeofenceAsync(PutGeofenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchPlaceIndexForPosition


        /// <summary>
        /// Reverse geocodes a given coordinate and returns a legible address. Allows you to search
        /// for Places or points of interest near a given position.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForPosition service method.</param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForPosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForPosition">REST API Reference for SearchPlaceIndexForPosition Operation</seealso>
        SearchPlaceIndexForPositionResponse SearchPlaceIndexForPosition(SearchPlaceIndexForPositionRequest request);



        /// <summary>
        /// Reverse geocodes a given coordinate and returns a legible address. Allows you to search
        /// for Places or points of interest near a given position.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForPosition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForPosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForPosition">REST API Reference for SearchPlaceIndexForPosition Operation</seealso>
        Task<SearchPlaceIndexForPositionResponse> SearchPlaceIndexForPositionAsync(SearchPlaceIndexForPositionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchPlaceIndexForSuggestions


        /// <summary>
        /// Generates suggestions for addresses and points of interest based on partial or misspelled
        /// free-form text. This operation is also known as autocomplete, autosuggest, or fuzzy
        /// matching.
        /// 
        ///  
        /// <para>
        /// Optional parameters let you narrow your search results by bounding box or country,
        /// or bias your search toward a specific position on the globe.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can search for suggested place names near a specified position by using <code>BiasPosition</code>,
        /// or filter results within a bounding box by using <code>FilterBBox</code>. These parameters
        /// are mutually exclusive; using both <code>BiasPosition</code> and <code>FilterBBox</code>
        /// in the same command returns an error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForSuggestions service method.</param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForSuggestions service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForSuggestions">REST API Reference for SearchPlaceIndexForSuggestions Operation</seealso>
        SearchPlaceIndexForSuggestionsResponse SearchPlaceIndexForSuggestions(SearchPlaceIndexForSuggestionsRequest request);



        /// <summary>
        /// Generates suggestions for addresses and points of interest based on partial or misspelled
        /// free-form text. This operation is also known as autocomplete, autosuggest, or fuzzy
        /// matching.
        /// 
        ///  
        /// <para>
        /// Optional parameters let you narrow your search results by bounding box or country,
        /// or bias your search toward a specific position on the globe.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can search for suggested place names near a specified position by using <code>BiasPosition</code>,
        /// or filter results within a bounding box by using <code>FilterBBox</code>. These parameters
        /// are mutually exclusive; using both <code>BiasPosition</code> and <code>FilterBBox</code>
        /// in the same command returns an error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForSuggestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForSuggestions service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForSuggestions">REST API Reference for SearchPlaceIndexForSuggestions Operation</seealso>
        Task<SearchPlaceIndexForSuggestionsResponse> SearchPlaceIndexForSuggestionsAsync(SearchPlaceIndexForSuggestionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchPlaceIndexForText


        /// <summary>
        /// Geocodes free-form text, such as an address, name, city, or region to allow you to
        /// search for Places or points of interest. 
        /// 
        ///  
        /// <para>
        /// Optional parameters let you narrow your search results by bounding box or country,
        /// or bias your search toward a specific position on the globe.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can search for places near a given position using <code>BiasPosition</code>, or
        /// filter results within a bounding box using <code>FilterBBox</code>. Providing both
        /// parameters simultaneously returns an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Search results are returned in order of highest to lowest relevance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForText service method.</param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForText service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForText">REST API Reference for SearchPlaceIndexForText Operation</seealso>
        SearchPlaceIndexForTextResponse SearchPlaceIndexForText(SearchPlaceIndexForTextRequest request);



        /// <summary>
        /// Geocodes free-form text, such as an address, name, city, or region to allow you to
        /// search for Places or points of interest. 
        /// 
        ///  
        /// <para>
        /// Optional parameters let you narrow your search results by bounding box or country,
        /// or bias your search toward a specific position on the globe.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can search for places near a given position using <code>BiasPosition</code>, or
        /// filter results within a bounding box using <code>FilterBBox</code>. Providing both
        /// parameters simultaneously returns an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Search results are returned in order of highest to lowest relevance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForText service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForText service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForText">REST API Reference for SearchPlaceIndexForText Operation</seealso>
        Task<SearchPlaceIndexForTextResponse> SearchPlaceIndexForTextAsync(SearchPlaceIndexForTextRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified Amazon Location Service
        /// resource.
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> operation with an Amazon Location Service
        /// resource that already has tags. If you specify a new tag key for the resource, this
        /// tag is appended to the tags already associated with the resource. If you specify a
        /// tag key that's already associated with the resource, the new tag value that you specify
        /// replaces the previous value for that tag. 
        /// </para>
        ///  
        /// <para>
        /// You can associate up to 50 tags with a resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified Amazon Location Service
        /// resource.
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> operation with an Amazon Location Service
        /// resource that already has tags. If you specify a new tag key for the resource, this
        /// tag is appended to the tags already associated with the resource. If you specify a
        /// tag key that's already associated with the resource, the new tag value that you specify
        /// replaces the previous value for that tag. 
        /// </para>
        ///  
        /// <para>
        /// You can associate up to 50 tags with a resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified Amazon Location resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes one or more tags from the specified Amazon Location resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGeofenceCollection


        /// <summary>
        /// Updates the specified properties of a given geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGeofenceCollection service method.</param>
        /// 
        /// <returns>The response from the UpdateGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateGeofenceCollection">REST API Reference for UpdateGeofenceCollection Operation</seealso>
        UpdateGeofenceCollectionResponse UpdateGeofenceCollection(UpdateGeofenceCollectionRequest request);



        /// <summary>
        /// Updates the specified properties of a given geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGeofenceCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateGeofenceCollection">REST API Reference for UpdateGeofenceCollection Operation</seealso>
        Task<UpdateGeofenceCollectionResponse> UpdateGeofenceCollectionAsync(UpdateGeofenceCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateKey


        /// <summary>
        /// Updates the specified properties of a given API key resource.
        /// 
        ///  <important> 
        /// <para>
        /// The API keys feature is in preview. We may add, change, or remove features before
        /// announcing general availability. For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/using-apikeys.html">Using
        /// API keys</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKey service method.</param>
        /// 
        /// <returns>The response from the UpdateKey service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateKey">REST API Reference for UpdateKey Operation</seealso>
        UpdateKeyResponse UpdateKey(UpdateKeyRequest request);



        /// <summary>
        /// Updates the specified properties of a given API key resource.
        /// 
        ///  <important> 
        /// <para>
        /// The API keys feature is in preview. We may add, change, or remove features before
        /// announcing general availability. For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/using-apikeys.html">Using
        /// API keys</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKey service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateKey">REST API Reference for UpdateKey Operation</seealso>
        Task<UpdateKeyResponse> UpdateKeyAsync(UpdateKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMap


        /// <summary>
        /// Updates the specified properties of a given map resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMap service method.</param>
        /// 
        /// <returns>The response from the UpdateMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateMap">REST API Reference for UpdateMap Operation</seealso>
        UpdateMapResponse UpdateMap(UpdateMapRequest request);



        /// <summary>
        /// Updates the specified properties of a given map resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateMap">REST API Reference for UpdateMap Operation</seealso>
        Task<UpdateMapResponse> UpdateMapAsync(UpdateMapRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePlaceIndex


        /// <summary>
        /// Updates the specified properties of a given place index resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlaceIndex service method.</param>
        /// 
        /// <returns>The response from the UpdatePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdatePlaceIndex">REST API Reference for UpdatePlaceIndex Operation</seealso>
        UpdatePlaceIndexResponse UpdatePlaceIndex(UpdatePlaceIndexRequest request);



        /// <summary>
        /// Updates the specified properties of a given place index resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlaceIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdatePlaceIndex">REST API Reference for UpdatePlaceIndex Operation</seealso>
        Task<UpdatePlaceIndexResponse> UpdatePlaceIndexAsync(UpdatePlaceIndexRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRouteCalculator


        /// <summary>
        /// Updates the specified properties for a given route calculator resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouteCalculator service method.</param>
        /// 
        /// <returns>The response from the UpdateRouteCalculator service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateRouteCalculator">REST API Reference for UpdateRouteCalculator Operation</seealso>
        UpdateRouteCalculatorResponse UpdateRouteCalculator(UpdateRouteCalculatorRequest request);



        /// <summary>
        /// Updates the specified properties for a given route calculator resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouteCalculator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRouteCalculator service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateRouteCalculator">REST API Reference for UpdateRouteCalculator Operation</seealso>
        Task<UpdateRouteCalculatorResponse> UpdateRouteCalculatorAsync(UpdateRouteCalculatorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTracker


        /// <summary>
        /// Updates the specified properties of a given tracker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTracker service method.</param>
        /// 
        /// <returns>The response from the UpdateTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateTracker">REST API Reference for UpdateTracker Operation</seealso>
        UpdateTrackerResponse UpdateTracker(UpdateTrackerRequest request);



        /// <summary>
        /// Updates the specified properties of a given tracker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTracker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateTracker">REST API Reference for UpdateTracker Operation</seealso>
        Task<UpdateTrackerResponse> UpdateTrackerAsync(UpdateTrackerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}