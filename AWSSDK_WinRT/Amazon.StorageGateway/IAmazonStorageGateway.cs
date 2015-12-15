/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.StorageGateway.Model;

namespace Amazon.StorageGateway
{
    /// <summary>
    /// Interface for accessing StorageGateway
    ///
    /// AWS Storage Gateway Service 
    /// <para>
    /// AWS Storage Gateway is the service that connects an on-premises software appliance
    /// with cloud-based storage to provide seamless and secure integration between an organization's
    /// on-premises IT environment and AWS's storage infrastructure. The service enables you
    /// to securely upload data to the AWS cloud for cost effective backup and rapid disaster
    /// recovery.
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started using the <i>AWS Storage Gateway Service API
    /// Reference</i>:
    /// </para>
    ///  <ul> <li> <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayHTTPRequestsHeaders.html">AWS
    /// Storage Gateway Required Request Headers</a>: Describes the required headers that
    /// you must send with every POST request to AWS Storage Gateway.</li> <li> <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewaySigningRequests.html">Signing
    /// Requests</a>: AWS Storage Gateway requires that you authenticate every request you
    /// send; this topic describes how sign such a request.</li> <li> <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/APIErrorResponses.html">Error
    /// Responses</a>: Provides reference information about AWS Storage Gateway errors.</li>
    /// <li> <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPIOperations.html">Operations
    /// in AWS Storage Gateway</a>: Contains detailed descriptions of all AWS Storage Gateway
    /// operations, their request parameters, response elements, possible errors, and examples
    /// of requests and responses.</li> <li> <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">AWS
    /// Storage Gateway Regions and Endpoints</a>: Provides a list of each of the regions
    /// and endpoints available for use with AWS Storage Gateway. </li> </ul>
    /// </summary>
    public partial interface IAmazonStorageGateway : IDisposable
    {
                
        #region  ActivateGateway

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ActivateGatewayResponse> ActivateGatewayAsync(ActivateGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddCache

        /// <summary>
        /// Initiates the asynchronous execution of the AddCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddCacheResponse> AddCacheAsync(AddCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddTagsToResource

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddUploadBuffer

        /// <summary>
        /// Initiates the asynchronous execution of the AddUploadBuffer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUploadBuffer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddUploadBufferResponse> AddUploadBufferAsync(AddUploadBufferRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddWorkingStorage

        /// <summary>
        /// Initiates the asynchronous execution of the AddWorkingStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddWorkingStorage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddWorkingStorageResponse> AddWorkingStorageAsync(AddWorkingStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelArchival

        /// <summary>
        /// Initiates the asynchronous execution of the CancelArchival operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelArchival operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CancelArchivalResponse> CancelArchivalAsync(CancelArchivalRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelRetrieval

        /// <summary>
        /// Initiates the asynchronous execution of the CancelRetrieval operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelRetrieval operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CancelRetrievalResponse> CancelRetrievalAsync(CancelRetrievalRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCachediSCSIVolume

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCachediSCSIVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateCachediSCSIVolumeResponse> CreateCachediSCSIVolumeAsync(CreateCachediSCSIVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSnapshot

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSnapshotFromVolumeRecoveryPoint

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotFromVolumeRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotFromVolumeRecoveryPoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateSnapshotFromVolumeRecoveryPointResponse> CreateSnapshotFromVolumeRecoveryPointAsync(CreateSnapshotFromVolumeRecoveryPointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStorediSCSIVolume

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorediSCSIVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateStorediSCSIVolumeResponse> CreateStorediSCSIVolumeAsync(CreateStorediSCSIVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTapes

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTapes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTapes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateTapesResponse> CreateTapesAsync(CreateTapesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBandwidthRateLimit

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBandwidthRateLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteBandwidthRateLimitResponse> DeleteBandwidthRateLimitAsync(DeleteBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteChapCredentials

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChapCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteChapCredentialsResponse> DeleteChapCredentialsAsync(DeleteChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGateway

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSnapshotSchedule

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteSnapshotScheduleResponse> DeleteSnapshotScheduleAsync(DeleteSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTape

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTape operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTape operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteTapeResponse> DeleteTapeAsync(DeleteTapeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTapeArchive

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTapeArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapeArchive operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteTapeArchiveResponse> DeleteTapeArchiveAsync(DeleteTapeArchiveRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVolume

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBandwidthRateLimit

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBandwidthRateLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeBandwidthRateLimitResponse> DescribeBandwidthRateLimitAsync(DescribeBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCache

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCacheResponse> DescribeCacheAsync(DescribeCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCachediSCSIVolumes

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCachediSCSIVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCachediSCSIVolumesResponse> DescribeCachediSCSIVolumesAsync(DescribeCachediSCSIVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeChapCredentials

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChapCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeChapCredentialsResponse> DescribeChapCredentialsAsync(DescribeChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeGatewayInformation

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGatewayInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeGatewayInformationResponse> DescribeGatewayInformationAsync(DescribeGatewayInformationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMaintenanceStartTime

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMaintenanceStartTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeMaintenanceStartTimeResponse> DescribeMaintenanceStartTimeAsync(DescribeMaintenanceStartTimeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSnapshotSchedule

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSnapshotScheduleResponse> DescribeSnapshotScheduleAsync(DescribeSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStorediSCSIVolumes

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStorediSCSIVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeStorediSCSIVolumesResponse> DescribeStorediSCSIVolumesAsync(DescribeStorediSCSIVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTapeArchives

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTapeArchives operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeArchives operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTapeArchivesResponse> DescribeTapeArchivesAsync(DescribeTapeArchivesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTapeRecoveryPoints

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTapeRecoveryPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeRecoveryPoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTapeRecoveryPointsResponse> DescribeTapeRecoveryPointsAsync(DescribeTapeRecoveryPointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTapes

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTapes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTapesResponse> DescribeTapesAsync(DescribeTapesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUploadBuffer

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUploadBuffer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeUploadBufferResponse> DescribeUploadBufferAsync(DescribeUploadBufferRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVTLDevices

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVTLDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVTLDevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeVTLDevicesResponse> DescribeVTLDevicesAsync(DescribeVTLDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkingStorage

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkingStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkingStorage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeWorkingStorageResponse> DescribeWorkingStorageAsync(DescribeWorkingStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableGateway

        /// <summary>
        /// Initiates the asynchronous execution of the DisableGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableGatewayResponse> DisableGatewayAsync(DisableGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGateways

        /// <summary>
        /// Initiates the asynchronous execution of the ListGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLocalDisks

        /// <summary>
        /// Initiates the asynchronous execution of the ListLocalDisks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListLocalDisksResponse> ListLocalDisksAsync(ListLocalDisksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVolumeInitiators

        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumeInitiators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeInitiators operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListVolumeInitiatorsResponse> ListVolumeInitiatorsAsync(ListVolumeInitiatorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVolumeRecoveryPoints

        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumeRecoveryPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeRecoveryPoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListVolumeRecoveryPointsResponse> ListVolumeRecoveryPointsAsync(ListVolumeRecoveryPointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVolumes

        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListVolumesResponse> ListVolumesAsync(ListVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveTagsFromResource

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetCache

        /// <summary>
        /// Initiates the asynchronous execution of the ResetCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResetCacheResponse> ResetCacheAsync(ResetCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RetrieveTapeArchive

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveTapeArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeArchive operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RetrieveTapeArchiveResponse> RetrieveTapeArchiveAsync(RetrieveTapeArchiveRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RetrieveTapeRecoveryPoint

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveTapeRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeRecoveryPoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RetrieveTapeRecoveryPointResponse> RetrieveTapeRecoveryPointAsync(RetrieveTapeRecoveryPointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ShutdownGateway

        /// <summary>
        /// Initiates the asynchronous execution of the ShutdownGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ShutdownGatewayResponse> ShutdownGatewayAsync(ShutdownGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartGateway

        /// <summary>
        /// Initiates the asynchronous execution of the StartGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartGatewayResponse> StartGatewayAsync(StartGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBandwidthRateLimit

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBandwidthRateLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateBandwidthRateLimitResponse> UpdateBandwidthRateLimitAsync(UpdateBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateChapCredentials

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChapCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateChapCredentialsResponse> UpdateChapCredentialsAsync(UpdateChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGatewayInformation

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateGatewayInformationResponse> UpdateGatewayInformationAsync(UpdateGatewayInformationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGatewaySoftwareNow

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewaySoftwareNow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateGatewaySoftwareNowResponse> UpdateGatewaySoftwareNowAsync(UpdateGatewaySoftwareNowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMaintenanceStartTime

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMaintenanceStartTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateMaintenanceStartTimeResponse> UpdateMaintenanceStartTimeAsync(UpdateMaintenanceStartTimeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSnapshotSchedule

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateSnapshotScheduleResponse> UpdateSnapshotScheduleAsync(UpdateSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVTLDeviceType

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVTLDeviceType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVTLDeviceType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateVTLDeviceTypeResponse> UpdateVTLDeviceTypeAsync(UpdateVTLDeviceTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}