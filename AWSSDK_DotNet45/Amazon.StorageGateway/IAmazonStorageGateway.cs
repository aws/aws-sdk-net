/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.StorageGateway.Model;

namespace Amazon.StorageGateway
{
    /// <summary>
    /// Interface for accessing AmazonStorageGateway.
    /// 
    /// 
    /// </summary>
	public partial interface IAmazonStorageGateway : IDisposable
    {
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ActivateGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		ActivateGatewayResponse ActivateGateway(ActivateGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ActivateGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ActivateGatewayResponse> ActivateGatewayAsync(ActivateGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCache service method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the AddCache service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		AddCacheResponse AddCache(AddCacheRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddCache operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AddCacheResponse> AddCacheAsync(AddCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUploadBuffer service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the AddUploadBuffer service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		AddUploadBufferResponse AddUploadBuffer(AddUploadBufferRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddUploadBuffer operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddUploadBuffer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUploadBuffer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AddUploadBufferResponse> AddUploadBufferAsync(AddUploadBufferRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddWorkingStorage service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the AddWorkingStorage service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		AddWorkingStorageResponse AddWorkingStorage(AddWorkingStorageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddWorkingStorage operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddWorkingStorage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddWorkingStorage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AddWorkingStorageResponse> AddWorkingStorageAsync(AddWorkingStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateCachediSCSIVolume service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		CreateCachediSCSIVolumeResponse CreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCachediSCSIVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateCachediSCSIVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateCachediSCSIVolumeResponse> CreateCachediSCSIVolumeAsync(CreateCachediSCSIVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// CreateSnapshotFromVolumeRecoveryPoint service method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateSnapshotFromVolumeRecoveryPoint service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		CreateSnapshotFromVolumeRecoveryPointResponse CreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotFromVolumeRecoveryPoint operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateSnapshotFromVolumeRecoveryPoint"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotFromVolumeRecoveryPoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateSnapshotFromVolumeRecoveryPointResponse> CreateSnapshotFromVolumeRecoveryPointAsync(CreateSnapshotFromVolumeRecoveryPointRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateStorediSCSIVolume service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		CreateStorediSCSIVolumeResponse CreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorediSCSIVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateStorediSCSIVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateStorediSCSIVolumeResponse> CreateStorediSCSIVolumeAsync(CreateStorediSCSIVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteBandwidthRateLimit service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DeleteBandwidthRateLimitResponse DeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteBandwidthRateLimitResponse> DeleteBandwidthRateLimitAsync(DeleteBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteChapCredentials service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DeleteChapCredentialsResponse DeleteChapCredentials(DeleteChapCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteChapCredentialsResponse> DeleteChapCredentialsAsync(DeleteChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteSnapshotSchedule service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteSnapshotScheduleResponse> DeleteSnapshotScheduleAsync(DeleteSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeBandwidthRateLimit service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeBandwidthRateLimitResponse DescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeBandwidthRateLimitResponse> DescribeBandwidthRateLimitAsync(DescribeBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeCache service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeCacheResponse DescribeCache(DescribeCacheRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCache operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeCacheResponse> DescribeCacheAsync(DescribeCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeCachediSCSIVolumes service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeCachediSCSIVolumesResponse DescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCachediSCSIVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeCachediSCSIVolumes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeCachediSCSIVolumesResponse> DescribeCachediSCSIVolumesAsync(DescribeCachediSCSIVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeChapCredentials service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeChapCredentialsResponse DescribeChapCredentials(DescribeChapCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeChapCredentialsResponse> DescribeChapCredentialsAsync(DescribeChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeGatewayInformation service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeGatewayInformationResponse DescribeGatewayInformation(DescribeGatewayInformationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGatewayInformation operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeGatewayInformation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeGatewayInformationResponse> DescribeGatewayInformationAsync(DescribeGatewayInformationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceStartTime service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeMaintenanceStartTimeResponse DescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMaintenanceStartTime operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeMaintenanceStartTime"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeMaintenanceStartTimeResponse> DescribeMaintenanceStartTimeAsync(DescribeMaintenanceStartTimeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotSchedule service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeSnapshotScheduleResponse DescribeSnapshotSchedule(DescribeSnapshotScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeSnapshotScheduleResponse> DescribeSnapshotScheduleAsync(DescribeSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeStorediSCSIVolumes service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeStorediSCSIVolumesResponse DescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStorediSCSIVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeStorediSCSIVolumes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeStorediSCSIVolumesResponse> DescribeStorediSCSIVolumesAsync(DescribeStorediSCSIVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeUploadBuffer service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeUploadBufferResponse DescribeUploadBuffer(DescribeUploadBufferRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUploadBuffer operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeUploadBuffer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeUploadBufferResponse> DescribeUploadBufferAsync(DescribeUploadBufferRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkingStorage service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeWorkingStorage service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeWorkingStorageResponse DescribeWorkingStorage(DescribeWorkingStorageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkingStorage operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeWorkingStorage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkingStorage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeWorkingStorageResponse> DescribeWorkingStorageAsync(DescribeWorkingStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		ListGatewaysResponse ListGateways(ListGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGateways operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListGateways"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListGateways service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		ListGatewaysResponse ListGateways();
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListLocalDisks service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		ListLocalDisksResponse ListLocalDisks(ListLocalDisksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLocalDisks operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListLocalDisks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListLocalDisksResponse> ListLocalDisksAsync(ListLocalDisksRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeRecoveryPoints service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListVolumeRecoveryPoints service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		ListVolumeRecoveryPointsResponse ListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumeRecoveryPoints operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListVolumeRecoveryPoints"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeRecoveryPoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListVolumeRecoveryPointsResponse> ListVolumeRecoveryPointsAsync(ListVolumeRecoveryPointsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListVolumes service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		ListVolumesResponse ListVolumes(ListVolumesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListVolumes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListVolumesResponse> ListVolumesAsync(ListVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ShutdownGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		ShutdownGatewayResponse ShutdownGateway(ShutdownGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ShutdownGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ShutdownGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ShutdownGatewayResponse> ShutdownGatewayAsync(ShutdownGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGateway service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the StartGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		StartGatewayResponse StartGateway(StartGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.StartGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<StartGatewayResponse> StartGatewayAsync(StartGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimit service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateBandwidthRateLimit service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		UpdateBandwidthRateLimitResponse UpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateBandwidthRateLimitResponse> UpdateBandwidthRateLimitAsync(UpdateBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateChapCredentials service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		UpdateChapCredentialsResponse UpdateChapCredentials(UpdateChapCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateChapCredentialsResponse> UpdateChapCredentialsAsync(UpdateChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateGatewayInformation service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		UpdateGatewayInformationResponse UpdateGatewayInformation(UpdateGatewayInformationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayInformation operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateGatewayInformation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateGatewayInformationResponse> UpdateGatewayInformationAsync(UpdateGatewayInformationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateGatewaySoftwareNow service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		UpdateGatewaySoftwareNowResponse UpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewaySoftwareNow operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateGatewaySoftwareNow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateGatewaySoftwareNowResponse> UpdateGatewaySoftwareNowAsync(UpdateGatewaySoftwareNowRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateMaintenanceStartTime service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		UpdateMaintenanceStartTimeResponse UpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMaintenanceStartTime operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateMaintenanceStartTime"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateMaintenanceStartTimeResponse> UpdateMaintenanceStartTimeAsync(UpdateMaintenanceStartTimeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotSchedule service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateSnapshotSchedule service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		UpdateSnapshotScheduleResponse UpdateSnapshotSchedule(UpdateSnapshotScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateSnapshotScheduleResponse> UpdateSnapshotScheduleAsync(UpdateSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
