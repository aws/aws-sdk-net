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
using Amazon.StorageGateway.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.StorageGateway
{
    /// <summary>
    /// Implementation for accessing AmazonStorageGateway.
    /// 
    /// 
    /// </summary>
	public partial class AmazonStorageGatewayClient : AmazonWebServiceClient, Amazon.StorageGateway.IAmazonStorageGateway
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonStorageGatewayClient(AWSCredentials credentials)
            : this(credentials, new AmazonStorageGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonStorageGatewayClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonStorageGatewayConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Credentials and an
        /// AmazonStorageGatewayClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonStorageGatewayClient Configuration Object</param>
        public AmazonStorageGatewayClient(AWSCredentials credentials, AmazonStorageGatewayConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonStorageGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonStorageGatewayConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonStorageGatewayClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonStorageGatewayClient Configuration Object</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonStorageGatewayConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonStorageGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonStorageGatewayConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonStorageGatewayClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonStorageGatewayClient Configuration Object</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonStorageGatewayConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
		internal ActivateGatewayResponse ActivateGateway(ActivateGatewayRequest request)
        {
            var task = ActivateGatewayAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="activateGatewayRequest">Container for the necessary parameters to execute the ActivateGateway service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ActivateGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ActivateGatewayResponse> ActivateGatewayAsync(ActivateGatewayRequest activateGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ActivateGatewayRequestMarshaller();
            var unmarshaller = ActivateGatewayResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ActivateGatewayRequest, ActivateGatewayResponse>(activateGatewayRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal AddCacheResponse AddCache(AddCacheRequest request)
        {
            var task = AddCacheAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="addCacheRequest">Container for the necessary parameters to execute the AddCache service method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the AddCache service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<AddCacheResponse> AddCacheAsync(AddCacheRequest addCacheRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddCacheRequestMarshaller();
            var unmarshaller = AddCacheResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AddCacheRequest, AddCacheResponse>(addCacheRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal AddUploadBufferResponse AddUploadBuffer(AddUploadBufferRequest request)
        {
            var task = AddUploadBufferAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="addUploadBufferRequest">Container for the necessary parameters to execute the AddUploadBuffer service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the AddUploadBuffer service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<AddUploadBufferResponse> AddUploadBufferAsync(AddUploadBufferRequest addUploadBufferRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddUploadBufferRequestMarshaller();
            var unmarshaller = AddUploadBufferResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AddUploadBufferRequest, AddUploadBufferResponse>(addUploadBufferRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal AddWorkingStorageResponse AddWorkingStorage(AddWorkingStorageRequest request)
        {
            var task = AddWorkingStorageAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="addWorkingStorageRequest">Container for the necessary parameters to execute the AddWorkingStorage service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the AddWorkingStorage service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<AddWorkingStorageResponse> AddWorkingStorageAsync(AddWorkingStorageRequest addWorkingStorageRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddWorkingStorageRequestMarshaller();
            var unmarshaller = AddWorkingStorageResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AddWorkingStorageRequest, AddWorkingStorageResponse>(addWorkingStorageRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal CreateCachediSCSIVolumeResponse CreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest request)
        {
            var task = CreateCachediSCSIVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="createCachediSCSIVolumeRequest">Container for the necessary parameters to execute the CreateCachediSCSIVolume service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateCachediSCSIVolume service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateCachediSCSIVolumeResponse> CreateCachediSCSIVolumeAsync(CreateCachediSCSIVolumeRequest createCachediSCSIVolumeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCachediSCSIVolumeRequestMarshaller();
            var unmarshaller = CreateCachediSCSIVolumeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateCachediSCSIVolumeRequest, CreateCachediSCSIVolumeResponse>(createCachediSCSIVolumeRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var task = CreateSnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="createSnapshotRequest">Container for the necessary parameters to execute the CreateSnapshot service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest createSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateSnapshotRequest, CreateSnapshotResponse>(createSnapshotRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal CreateSnapshotFromVolumeRecoveryPointResponse CreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest request)
        {
            var task = CreateSnapshotFromVolumeRecoveryPointAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="createSnapshotFromVolumeRecoveryPointRequest">Container for the necessary parameters to execute the
        /// CreateSnapshotFromVolumeRecoveryPoint service method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateSnapshotFromVolumeRecoveryPoint service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateSnapshotFromVolumeRecoveryPointResponse> CreateSnapshotFromVolumeRecoveryPointAsync(CreateSnapshotFromVolumeRecoveryPointRequest createSnapshotFromVolumeRecoveryPointRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSnapshotFromVolumeRecoveryPointRequestMarshaller();
            var unmarshaller = CreateSnapshotFromVolumeRecoveryPointResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateSnapshotFromVolumeRecoveryPointRequest, CreateSnapshotFromVolumeRecoveryPointResponse>(createSnapshotFromVolumeRecoveryPointRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal CreateStorediSCSIVolumeResponse CreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest request)
        {
            var task = CreateStorediSCSIVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="createStorediSCSIVolumeRequest">Container for the necessary parameters to execute the CreateStorediSCSIVolume service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateStorediSCSIVolume service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateStorediSCSIVolumeResponse> CreateStorediSCSIVolumeAsync(CreateStorediSCSIVolumeRequest createStorediSCSIVolumeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStorediSCSIVolumeRequestMarshaller();
            var unmarshaller = CreateStorediSCSIVolumeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateStorediSCSIVolumeRequest, CreateStorediSCSIVolumeResponse>(createStorediSCSIVolumeRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DeleteBandwidthRateLimitResponse DeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest request)
        {
            var task = DeleteBandwidthRateLimitAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteBandwidthRateLimitRequest">Container for the necessary parameters to execute the DeleteBandwidthRateLimit service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteBandwidthRateLimit service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteBandwidthRateLimitResponse> DeleteBandwidthRateLimitAsync(DeleteBandwidthRateLimitRequest deleteBandwidthRateLimitRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBandwidthRateLimitRequestMarshaller();
            var unmarshaller = DeleteBandwidthRateLimitResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteBandwidthRateLimitRequest, DeleteBandwidthRateLimitResponse>(deleteBandwidthRateLimitRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DeleteChapCredentialsResponse DeleteChapCredentials(DeleteChapCredentialsRequest request)
        {
            var task = DeleteChapCredentialsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteChapCredentialsRequest">Container for the necessary parameters to execute the DeleteChapCredentials service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteChapCredentials service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteChapCredentialsResponse> DeleteChapCredentialsAsync(DeleteChapCredentialsRequest deleteChapCredentialsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteChapCredentialsRequestMarshaller();
            var unmarshaller = DeleteChapCredentialsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteChapCredentialsRequest, DeleteChapCredentialsResponse>(deleteChapCredentialsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request)
        {
            var task = DeleteGatewayAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteGatewayRequest">Container for the necessary parameters to execute the DeleteGateway service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest deleteGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteGatewayRequestMarshaller();
            var unmarshaller = DeleteGatewayResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteGatewayRequest, DeleteGatewayResponse>(deleteGatewayRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request)
        {
            var task = DeleteSnapshotScheduleAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteSnapshotScheduleRequest">Container for the necessary parameters to execute the DeleteSnapshotSchedule service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteSnapshotSchedule service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteSnapshotScheduleResponse> DeleteSnapshotScheduleAsync(DeleteSnapshotScheduleRequest deleteSnapshotScheduleRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSnapshotScheduleRequestMarshaller();
            var unmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteSnapshotScheduleRequest, DeleteSnapshotScheduleResponse>(deleteSnapshotScheduleRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            var task = DeleteVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteVolumeRequest">Container for the necessary parameters to execute the DeleteVolume service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest deleteVolumeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVolumeRequestMarshaller();
            var unmarshaller = DeleteVolumeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteVolumeRequest, DeleteVolumeResponse>(deleteVolumeRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DescribeBandwidthRateLimitResponse DescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest request)
        {
            var task = DescribeBandwidthRateLimitAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeBandwidthRateLimitRequest">Container for the necessary parameters to execute the DescribeBandwidthRateLimit service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeBandwidthRateLimit service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeBandwidthRateLimitResponse> DescribeBandwidthRateLimitAsync(DescribeBandwidthRateLimitRequest describeBandwidthRateLimitRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeBandwidthRateLimitRequestMarshaller();
            var unmarshaller = DescribeBandwidthRateLimitResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeBandwidthRateLimitRequest, DescribeBandwidthRateLimitResponse>(describeBandwidthRateLimitRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DescribeCacheResponse DescribeCache(DescribeCacheRequest request)
        {
            var task = DescribeCacheAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeCacheRequest">Container for the necessary parameters to execute the DescribeCache service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeCache service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeCacheResponse> DescribeCacheAsync(DescribeCacheRequest describeCacheRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheRequestMarshaller();
            var unmarshaller = DescribeCacheResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCacheRequest, DescribeCacheResponse>(describeCacheRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DescribeCachediSCSIVolumesResponse DescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest request)
        {
            var task = DescribeCachediSCSIVolumesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeCachediSCSIVolumesRequest">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeCachediSCSIVolumes service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeCachediSCSIVolumesResponse> DescribeCachediSCSIVolumesAsync(DescribeCachediSCSIVolumesRequest describeCachediSCSIVolumesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCachediSCSIVolumesRequestMarshaller();
            var unmarshaller = DescribeCachediSCSIVolumesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCachediSCSIVolumesRequest, DescribeCachediSCSIVolumesResponse>(describeCachediSCSIVolumesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DescribeChapCredentialsResponse DescribeChapCredentials(DescribeChapCredentialsRequest request)
        {
            var task = DescribeChapCredentialsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeChapCredentialsRequest">Container for the necessary parameters to execute the DescribeChapCredentials service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeChapCredentials service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeChapCredentialsResponse> DescribeChapCredentialsAsync(DescribeChapCredentialsRequest describeChapCredentialsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeChapCredentialsRequestMarshaller();
            var unmarshaller = DescribeChapCredentialsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeChapCredentialsRequest, DescribeChapCredentialsResponse>(describeChapCredentialsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DescribeGatewayInformationResponse DescribeGatewayInformation(DescribeGatewayInformationRequest request)
        {
            var task = DescribeGatewayInformationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeGatewayInformationRequest">Container for the necessary parameters to execute the DescribeGatewayInformation service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeGatewayInformation service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeGatewayInformationResponse> DescribeGatewayInformationAsync(DescribeGatewayInformationRequest describeGatewayInformationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeGatewayInformationRequestMarshaller();
            var unmarshaller = DescribeGatewayInformationResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeGatewayInformationRequest, DescribeGatewayInformationResponse>(describeGatewayInformationRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DescribeMaintenanceStartTimeResponse DescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest request)
        {
            var task = DescribeMaintenanceStartTimeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeMaintenanceStartTimeRequest">Container for the necessary parameters to execute the DescribeMaintenanceStartTime service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceStartTime service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeMaintenanceStartTimeResponse> DescribeMaintenanceStartTimeAsync(DescribeMaintenanceStartTimeRequest describeMaintenanceStartTimeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMaintenanceStartTimeRequestMarshaller();
            var unmarshaller = DescribeMaintenanceStartTimeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeMaintenanceStartTimeRequest, DescribeMaintenanceStartTimeResponse>(describeMaintenanceStartTimeRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DescribeSnapshotScheduleResponse DescribeSnapshotSchedule(DescribeSnapshotScheduleRequest request)
        {
            var task = DescribeSnapshotScheduleAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeSnapshotScheduleRequest">Container for the necessary parameters to execute the DescribeSnapshotSchedule service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotSchedule service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeSnapshotScheduleResponse> DescribeSnapshotScheduleAsync(DescribeSnapshotScheduleRequest describeSnapshotScheduleRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSnapshotScheduleRequestMarshaller();
            var unmarshaller = DescribeSnapshotScheduleResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeSnapshotScheduleRequest, DescribeSnapshotScheduleResponse>(describeSnapshotScheduleRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DescribeStorediSCSIVolumesResponse DescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest request)
        {
            var task = DescribeStorediSCSIVolumesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeStorediSCSIVolumesRequest">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeStorediSCSIVolumes service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeStorediSCSIVolumesResponse> DescribeStorediSCSIVolumesAsync(DescribeStorediSCSIVolumesRequest describeStorediSCSIVolumesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStorediSCSIVolumesRequestMarshaller();
            var unmarshaller = DescribeStorediSCSIVolumesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeStorediSCSIVolumesRequest, DescribeStorediSCSIVolumesResponse>(describeStorediSCSIVolumesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DescribeUploadBufferResponse DescribeUploadBuffer(DescribeUploadBufferRequest request)
        {
            var task = DescribeUploadBufferAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeUploadBufferRequest">Container for the necessary parameters to execute the DescribeUploadBuffer service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeUploadBuffer service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeUploadBufferResponse> DescribeUploadBufferAsync(DescribeUploadBufferRequest describeUploadBufferRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeUploadBufferRequestMarshaller();
            var unmarshaller = DescribeUploadBufferResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeUploadBufferRequest, DescribeUploadBufferResponse>(describeUploadBufferRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DescribeWorkingStorageResponse DescribeWorkingStorage(DescribeWorkingStorageRequest request)
        {
            var task = DescribeWorkingStorageAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeWorkingStorageRequest">Container for the necessary parameters to execute the DescribeWorkingStorage service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeWorkingStorage service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeWorkingStorageResponse> DescribeWorkingStorageAsync(DescribeWorkingStorageRequest describeWorkingStorageRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeWorkingStorageRequestMarshaller();
            var unmarshaller = DescribeWorkingStorageResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeWorkingStorageRequest, DescribeWorkingStorageResponse>(describeWorkingStorageRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal ListGatewaysResponse ListGateways(ListGatewaysRequest request)
        {
            var task = ListGatewaysAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="listGatewaysRequest">Container for the necessary parameters to execute the ListGateways service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest listGatewaysRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListGatewaysRequestMarshaller();
            var unmarshaller = ListGatewaysResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListGatewaysRequest, ListGatewaysResponse>(listGatewaysRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal ListLocalDisksResponse ListLocalDisks(ListLocalDisksRequest request)
        {
            var task = ListLocalDisksAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="listLocalDisksRequest">Container for the necessary parameters to execute the ListLocalDisks service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListLocalDisks service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ListLocalDisksResponse> ListLocalDisksAsync(ListLocalDisksRequest listLocalDisksRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListLocalDisksRequestMarshaller();
            var unmarshaller = ListLocalDisksResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListLocalDisksRequest, ListLocalDisksResponse>(listLocalDisksRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal ListVolumeRecoveryPointsResponse ListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest request)
        {
            var task = ListVolumeRecoveryPointsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="listVolumeRecoveryPointsRequest">Container for the necessary parameters to execute the ListVolumeRecoveryPoints service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListVolumeRecoveryPoints service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ListVolumeRecoveryPointsResponse> ListVolumeRecoveryPointsAsync(ListVolumeRecoveryPointsRequest listVolumeRecoveryPointsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListVolumeRecoveryPointsRequestMarshaller();
            var unmarshaller = ListVolumeRecoveryPointsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListVolumeRecoveryPointsRequest, ListVolumeRecoveryPointsResponse>(listVolumeRecoveryPointsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal ListVolumesResponse ListVolumes(ListVolumesRequest request)
        {
            var task = ListVolumesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="listVolumesRequest">Container for the necessary parameters to execute the ListVolumes service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListVolumes service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ListVolumesResponse> ListVolumesAsync(ListVolumesRequest listVolumesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListVolumesRequestMarshaller();
            var unmarshaller = ListVolumesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListVolumesRequest, ListVolumesResponse>(listVolumesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal ShutdownGatewayResponse ShutdownGateway(ShutdownGatewayRequest request)
        {
            var task = ShutdownGatewayAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="shutdownGatewayRequest">Container for the necessary parameters to execute the ShutdownGateway service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ShutdownGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ShutdownGatewayResponse> ShutdownGatewayAsync(ShutdownGatewayRequest shutdownGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ShutdownGatewayRequestMarshaller();
            var unmarshaller = ShutdownGatewayResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ShutdownGatewayRequest, ShutdownGatewayResponse>(shutdownGatewayRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal StartGatewayResponse StartGateway(StartGatewayRequest request)
        {
            var task = StartGatewayAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="startGatewayRequest">Container for the necessary parameters to execute the StartGateway service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the StartGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<StartGatewayResponse> StartGatewayAsync(StartGatewayRequest startGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartGatewayRequestMarshaller();
            var unmarshaller = StartGatewayResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, StartGatewayRequest, StartGatewayResponse>(startGatewayRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal UpdateBandwidthRateLimitResponse UpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest request)
        {
            var task = UpdateBandwidthRateLimitAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateBandwidthRateLimitRequest">Container for the necessary parameters to execute the UpdateBandwidthRateLimit service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateBandwidthRateLimit service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateBandwidthRateLimitResponse> UpdateBandwidthRateLimitAsync(UpdateBandwidthRateLimitRequest updateBandwidthRateLimitRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateBandwidthRateLimitRequestMarshaller();
            var unmarshaller = UpdateBandwidthRateLimitResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateBandwidthRateLimitRequest, UpdateBandwidthRateLimitResponse>(updateBandwidthRateLimitRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal UpdateChapCredentialsResponse UpdateChapCredentials(UpdateChapCredentialsRequest request)
        {
            var task = UpdateChapCredentialsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateChapCredentialsRequest">Container for the necessary parameters to execute the UpdateChapCredentials service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateChapCredentials service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateChapCredentialsResponse> UpdateChapCredentialsAsync(UpdateChapCredentialsRequest updateChapCredentialsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateChapCredentialsRequestMarshaller();
            var unmarshaller = UpdateChapCredentialsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateChapCredentialsRequest, UpdateChapCredentialsResponse>(updateChapCredentialsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal UpdateGatewayInformationResponse UpdateGatewayInformation(UpdateGatewayInformationRequest request)
        {
            var task = UpdateGatewayInformationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateGatewayInformationRequest">Container for the necessary parameters to execute the UpdateGatewayInformation service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateGatewayInformation service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateGatewayInformationResponse> UpdateGatewayInformationAsync(UpdateGatewayInformationRequest updateGatewayInformationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateGatewayInformationRequestMarshaller();
            var unmarshaller = UpdateGatewayInformationResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateGatewayInformationRequest, UpdateGatewayInformationResponse>(updateGatewayInformationRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal UpdateGatewaySoftwareNowResponse UpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request)
        {
            var task = UpdateGatewaySoftwareNowAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateGatewaySoftwareNowRequest">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateGatewaySoftwareNow service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateGatewaySoftwareNowResponse> UpdateGatewaySoftwareNowAsync(UpdateGatewaySoftwareNowRequest updateGatewaySoftwareNowRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateGatewaySoftwareNowRequestMarshaller();
            var unmarshaller = UpdateGatewaySoftwareNowResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateGatewaySoftwareNowRequest, UpdateGatewaySoftwareNowResponse>(updateGatewaySoftwareNowRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal UpdateMaintenanceStartTimeResponse UpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest request)
        {
            var task = UpdateMaintenanceStartTimeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateMaintenanceStartTimeRequest">Container for the necessary parameters to execute the UpdateMaintenanceStartTime service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateMaintenanceStartTime service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateMaintenanceStartTimeResponse> UpdateMaintenanceStartTimeAsync(UpdateMaintenanceStartTimeRequest updateMaintenanceStartTimeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateMaintenanceStartTimeRequestMarshaller();
            var unmarshaller = UpdateMaintenanceStartTimeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateMaintenanceStartTimeRequest, UpdateMaintenanceStartTimeResponse>(updateMaintenanceStartTimeRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal UpdateSnapshotScheduleResponse UpdateSnapshotSchedule(UpdateSnapshotScheduleRequest request)
        {
            var task = UpdateSnapshotScheduleAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateSnapshotScheduleRequest">Container for the necessary parameters to execute the UpdateSnapshotSchedule service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateSnapshotSchedule service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateSnapshotScheduleResponse> UpdateSnapshotScheduleAsync(UpdateSnapshotScheduleRequest updateSnapshotScheduleRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateSnapshotScheduleRequestMarshaller();
            var unmarshaller = UpdateSnapshotScheduleResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateSnapshotScheduleRequest, UpdateSnapshotScheduleResponse>(updateSnapshotScheduleRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
