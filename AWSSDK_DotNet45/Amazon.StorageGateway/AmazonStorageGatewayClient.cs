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
        /// Constructs AmazonStorageGatewayClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonStorageGatewayClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonStorageGatewayConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonStorageGatewayClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonStorageGatewayConfig(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonStorageGateway Configuration Object</param>
        public AmazonStorageGatewayClient(AmazonStorageGatewayConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
		public ActivateGatewayResponse ActivateGateway(ActivateGatewayRequest request)
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
        /// Initiates the asynchronous execution of the ActivateGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ActivateGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ActivateGatewayResponse> ActivateGatewayAsync(ActivateGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ActivateGatewayRequestMarshaller();
            var unmarshaller = ActivateGatewayResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ActivateGatewayRequest, ActivateGatewayResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCache service method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the AddCache service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		public AddCacheResponse AddCache(AddCacheRequest request)
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
        /// Initiates the asynchronous execution of the AddCache operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<AddCacheResponse> AddCacheAsync(AddCacheRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddCacheRequestMarshaller();
            var unmarshaller = AddCacheResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AddCacheRequest, AddCacheResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public AddUploadBufferResponse AddUploadBuffer(AddUploadBufferRequest request)
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
        /// Initiates the asynchronous execution of the AddUploadBuffer operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddUploadBuffer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUploadBuffer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<AddUploadBufferResponse> AddUploadBufferAsync(AddUploadBufferRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddUploadBufferRequestMarshaller();
            var unmarshaller = AddUploadBufferResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AddUploadBufferRequest, AddUploadBufferResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public AddWorkingStorageResponse AddWorkingStorage(AddWorkingStorageRequest request)
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
        /// Initiates the asynchronous execution of the AddWorkingStorage operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddWorkingStorage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddWorkingStorage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<AddWorkingStorageResponse> AddWorkingStorageAsync(AddWorkingStorageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddWorkingStorageRequestMarshaller();
            var unmarshaller = AddWorkingStorageResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AddWorkingStorageRequest, AddWorkingStorageResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public CreateCachediSCSIVolumeResponse CreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest request)
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
        /// Initiates the asynchronous execution of the CreateCachediSCSIVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateCachediSCSIVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateCachediSCSIVolumeResponse> CreateCachediSCSIVolumeAsync(CreateCachediSCSIVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCachediSCSIVolumeRequestMarshaller();
            var unmarshaller = CreateCachediSCSIVolumeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateCachediSCSIVolumeRequest, CreateCachediSCSIVolumeResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
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
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateSnapshotRequest, CreateSnapshotResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public CreateSnapshotFromVolumeRecoveryPointResponse CreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest request)
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
        /// Initiates the asynchronous execution of the CreateSnapshotFromVolumeRecoveryPoint operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateSnapshotFromVolumeRecoveryPoint"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotFromVolumeRecoveryPoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateSnapshotFromVolumeRecoveryPointResponse> CreateSnapshotFromVolumeRecoveryPointAsync(CreateSnapshotFromVolumeRecoveryPointRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSnapshotFromVolumeRecoveryPointRequestMarshaller();
            var unmarshaller = CreateSnapshotFromVolumeRecoveryPointResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateSnapshotFromVolumeRecoveryPointRequest, CreateSnapshotFromVolumeRecoveryPointResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public CreateStorediSCSIVolumeResponse CreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest request)
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
        /// Initiates the asynchronous execution of the CreateStorediSCSIVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateStorediSCSIVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateStorediSCSIVolumeResponse> CreateStorediSCSIVolumeAsync(CreateStorediSCSIVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStorediSCSIVolumeRequestMarshaller();
            var unmarshaller = CreateStorediSCSIVolumeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateStorediSCSIVolumeRequest, CreateStorediSCSIVolumeResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DeleteBandwidthRateLimitResponse DeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest request)
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
        /// Initiates the asynchronous execution of the DeleteBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteBandwidthRateLimitResponse> DeleteBandwidthRateLimitAsync(DeleteBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBandwidthRateLimitRequestMarshaller();
            var unmarshaller = DeleteBandwidthRateLimitResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteBandwidthRateLimitRequest, DeleteBandwidthRateLimitResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DeleteChapCredentialsResponse DeleteChapCredentials(DeleteChapCredentialsRequest request)
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
        /// Initiates the asynchronous execution of the DeleteChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteChapCredentialsResponse> DeleteChapCredentialsAsync(DeleteChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteChapCredentialsRequestMarshaller();
            var unmarshaller = DeleteChapCredentialsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteChapCredentialsRequest, DeleteChapCredentialsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request)
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
        /// Initiates the asynchronous execution of the DeleteGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteGatewayRequestMarshaller();
            var unmarshaller = DeleteGatewayResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteGatewayRequest, DeleteGatewayResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request)
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
        /// Initiates the asynchronous execution of the DeleteSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteSnapshotScheduleResponse> DeleteSnapshotScheduleAsync(DeleteSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSnapshotScheduleRequestMarshaller();
            var unmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteSnapshotScheduleRequest, DeleteSnapshotScheduleResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
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
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVolumeRequestMarshaller();
            var unmarshaller = DeleteVolumeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteVolumeRequest, DeleteVolumeResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DescribeBandwidthRateLimitResponse DescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest request)
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
        /// Initiates the asynchronous execution of the DescribeBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeBandwidthRateLimitResponse> DescribeBandwidthRateLimitAsync(DescribeBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeBandwidthRateLimitRequestMarshaller();
            var unmarshaller = DescribeBandwidthRateLimitResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeBandwidthRateLimitRequest, DescribeBandwidthRateLimitResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DescribeCacheResponse DescribeCache(DescribeCacheRequest request)
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
        /// Initiates the asynchronous execution of the DescribeCache operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeCacheResponse> DescribeCacheAsync(DescribeCacheRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheRequestMarshaller();
            var unmarshaller = DescribeCacheResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCacheRequest, DescribeCacheResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DescribeCachediSCSIVolumesResponse DescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest request)
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
        /// Initiates the asynchronous execution of the DescribeCachediSCSIVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeCachediSCSIVolumes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeCachediSCSIVolumesResponse> DescribeCachediSCSIVolumesAsync(DescribeCachediSCSIVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCachediSCSIVolumesRequestMarshaller();
            var unmarshaller = DescribeCachediSCSIVolumesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCachediSCSIVolumesRequest, DescribeCachediSCSIVolumesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DescribeChapCredentialsResponse DescribeChapCredentials(DescribeChapCredentialsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeChapCredentialsResponse> DescribeChapCredentialsAsync(DescribeChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeChapCredentialsRequestMarshaller();
            var unmarshaller = DescribeChapCredentialsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeChapCredentialsRequest, DescribeChapCredentialsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DescribeGatewayInformationResponse DescribeGatewayInformation(DescribeGatewayInformationRequest request)
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
        /// Initiates the asynchronous execution of the DescribeGatewayInformation operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeGatewayInformation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeGatewayInformationResponse> DescribeGatewayInformationAsync(DescribeGatewayInformationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeGatewayInformationRequestMarshaller();
            var unmarshaller = DescribeGatewayInformationResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeGatewayInformationRequest, DescribeGatewayInformationResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DescribeMaintenanceStartTimeResponse DescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest request)
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
        /// Initiates the asynchronous execution of the DescribeMaintenanceStartTime operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeMaintenanceStartTime"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeMaintenanceStartTimeResponse> DescribeMaintenanceStartTimeAsync(DescribeMaintenanceStartTimeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMaintenanceStartTimeRequestMarshaller();
            var unmarshaller = DescribeMaintenanceStartTimeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeMaintenanceStartTimeRequest, DescribeMaintenanceStartTimeResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DescribeSnapshotScheduleResponse DescribeSnapshotSchedule(DescribeSnapshotScheduleRequest request)
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
        /// Initiates the asynchronous execution of the DescribeSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeSnapshotScheduleResponse> DescribeSnapshotScheduleAsync(DescribeSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSnapshotScheduleRequestMarshaller();
            var unmarshaller = DescribeSnapshotScheduleResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeSnapshotScheduleRequest, DescribeSnapshotScheduleResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DescribeStorediSCSIVolumesResponse DescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest request)
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
        /// Initiates the asynchronous execution of the DescribeStorediSCSIVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeStorediSCSIVolumes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeStorediSCSIVolumesResponse> DescribeStorediSCSIVolumesAsync(DescribeStorediSCSIVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStorediSCSIVolumesRequestMarshaller();
            var unmarshaller = DescribeStorediSCSIVolumesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeStorediSCSIVolumesRequest, DescribeStorediSCSIVolumesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DescribeUploadBufferResponse DescribeUploadBuffer(DescribeUploadBufferRequest request)
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
        /// Initiates the asynchronous execution of the DescribeUploadBuffer operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeUploadBuffer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeUploadBufferResponse> DescribeUploadBufferAsync(DescribeUploadBufferRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeUploadBufferRequestMarshaller();
            var unmarshaller = DescribeUploadBufferResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeUploadBufferRequest, DescribeUploadBufferResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public DescribeWorkingStorageResponse DescribeWorkingStorage(DescribeWorkingStorageRequest request)
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
        /// Initiates the asynchronous execution of the DescribeWorkingStorage operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeWorkingStorage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkingStorage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeWorkingStorageResponse> DescribeWorkingStorageAsync(DescribeWorkingStorageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeWorkingStorageRequestMarshaller();
            var unmarshaller = DescribeWorkingStorageResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeWorkingStorageRequest, DescribeWorkingStorageResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public ListGatewaysResponse ListGateways(ListGatewaysRequest request)
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
        /// Initiates the asynchronous execution of the ListGateways operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListGateways"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListGatewaysRequestMarshaller();
            var unmarshaller = ListGatewaysResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListGatewaysRequest, ListGatewaysResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListGateways service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		public ListGatewaysResponse ListGateways()
        {
            return this.ListGateways(new ListGatewaysRequest());
        }
 
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
		public ListLocalDisksResponse ListLocalDisks(ListLocalDisksRequest request)
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
        /// Initiates the asynchronous execution of the ListLocalDisks operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListLocalDisks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListLocalDisksResponse> ListLocalDisksAsync(ListLocalDisksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListLocalDisksRequestMarshaller();
            var unmarshaller = ListLocalDisksResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListLocalDisksRequest, ListLocalDisksResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public ListVolumeRecoveryPointsResponse ListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest request)
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
        /// Initiates the asynchronous execution of the ListVolumeRecoveryPoints operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListVolumeRecoveryPoints"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeRecoveryPoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListVolumeRecoveryPointsResponse> ListVolumeRecoveryPointsAsync(ListVolumeRecoveryPointsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListVolumeRecoveryPointsRequestMarshaller();
            var unmarshaller = ListVolumeRecoveryPointsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListVolumeRecoveryPointsRequest, ListVolumeRecoveryPointsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public ListVolumesResponse ListVolumes(ListVolumesRequest request)
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
        /// Initiates the asynchronous execution of the ListVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListVolumes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListVolumesResponse> ListVolumesAsync(ListVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListVolumesRequestMarshaller();
            var unmarshaller = ListVolumesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListVolumesRequest, ListVolumesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public ShutdownGatewayResponse ShutdownGateway(ShutdownGatewayRequest request)
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
        /// Initiates the asynchronous execution of the ShutdownGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ShutdownGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ShutdownGatewayResponse> ShutdownGatewayAsync(ShutdownGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ShutdownGatewayRequestMarshaller();
            var unmarshaller = ShutdownGatewayResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ShutdownGatewayRequest, ShutdownGatewayResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public StartGatewayResponse StartGateway(StartGatewayRequest request)
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
        /// Initiates the asynchronous execution of the StartGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.StartGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<StartGatewayResponse> StartGatewayAsync(StartGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartGatewayRequestMarshaller();
            var unmarshaller = StartGatewayResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, StartGatewayRequest, StartGatewayResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public UpdateBandwidthRateLimitResponse UpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest request)
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
        /// Initiates the asynchronous execution of the UpdateBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<UpdateBandwidthRateLimitResponse> UpdateBandwidthRateLimitAsync(UpdateBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateBandwidthRateLimitRequestMarshaller();
            var unmarshaller = UpdateBandwidthRateLimitResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateBandwidthRateLimitRequest, UpdateBandwidthRateLimitResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public UpdateChapCredentialsResponse UpdateChapCredentials(UpdateChapCredentialsRequest request)
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
        /// Initiates the asynchronous execution of the UpdateChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<UpdateChapCredentialsResponse> UpdateChapCredentialsAsync(UpdateChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateChapCredentialsRequestMarshaller();
            var unmarshaller = UpdateChapCredentialsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateChapCredentialsRequest, UpdateChapCredentialsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public UpdateGatewayInformationResponse UpdateGatewayInformation(UpdateGatewayInformationRequest request)
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
        /// Initiates the asynchronous execution of the UpdateGatewayInformation operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateGatewayInformation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<UpdateGatewayInformationResponse> UpdateGatewayInformationAsync(UpdateGatewayInformationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateGatewayInformationRequestMarshaller();
            var unmarshaller = UpdateGatewayInformationResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateGatewayInformationRequest, UpdateGatewayInformationResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public UpdateGatewaySoftwareNowResponse UpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request)
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
        /// Initiates the asynchronous execution of the UpdateGatewaySoftwareNow operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateGatewaySoftwareNow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<UpdateGatewaySoftwareNowResponse> UpdateGatewaySoftwareNowAsync(UpdateGatewaySoftwareNowRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateGatewaySoftwareNowRequestMarshaller();
            var unmarshaller = UpdateGatewaySoftwareNowResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateGatewaySoftwareNowRequest, UpdateGatewaySoftwareNowResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public UpdateMaintenanceStartTimeResponse UpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest request)
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
        /// Initiates the asynchronous execution of the UpdateMaintenanceStartTime operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateMaintenanceStartTime"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<UpdateMaintenanceStartTimeResponse> UpdateMaintenanceStartTimeAsync(UpdateMaintenanceStartTimeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateMaintenanceStartTimeRequestMarshaller();
            var unmarshaller = UpdateMaintenanceStartTimeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateMaintenanceStartTimeRequest, UpdateMaintenanceStartTimeResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
		public UpdateSnapshotScheduleResponse UpdateSnapshotSchedule(UpdateSnapshotScheduleRequest request)
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
        /// Initiates the asynchronous execution of the UpdateSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<UpdateSnapshotScheduleResponse> UpdateSnapshotScheduleAsync(UpdateSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateSnapshotScheduleRequestMarshaller();
            var unmarshaller = UpdateSnapshotScheduleResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateSnapshotScheduleRequest, UpdateSnapshotScheduleResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
