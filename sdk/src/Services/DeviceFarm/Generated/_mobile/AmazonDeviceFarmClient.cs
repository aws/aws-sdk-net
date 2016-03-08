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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.DeviceFarm.Model;
using Amazon.DeviceFarm.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DeviceFarm
{
    /// <summary>
    /// Implementation for accessing DeviceFarm
    ///
    /// AWS Device Farm is a service that enables mobile app developers to test Android, iOS,
    /// and Fire OS apps on physical phones, tablets, and other devices in the cloud.
    /// </summary>
    public partial class AmazonDeviceFarmClient : AmazonServiceClient, IAmazonDeviceFarm
    {
        
        #region Constructors

#if DNX
    
        /// <summary>
        /// Constructs AmazonDeviceFarmClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonDeviceFarmClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDeviceFarmConfig()) { }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonDeviceFarmClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDeviceFarmConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonDeviceFarmClient Configuration Object</param>
        public AmazonDeviceFarmClient(AmazonDeviceFarmConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDeviceFarmClient(AWSCredentials credentials)
            : this(credentials, new AmazonDeviceFarmConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDeviceFarmClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDeviceFarmConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Credentials and an
        /// AmazonDeviceFarmClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDeviceFarmClient Configuration Object</param>
        public AmazonDeviceFarmClient(AWSCredentials credentials, AmazonDeviceFarmConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDeviceFarmClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDeviceFarmConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDeviceFarmClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDeviceFarmConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDeviceFarmClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDeviceFarmClient Configuration Object</param>
        public AmazonDeviceFarmClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDeviceFarmConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDeviceFarmClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDeviceFarmConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDeviceFarmClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDeviceFarmConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDeviceFarmClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDeviceFarmClient Configuration Object</param>
        public AmazonDeviceFarmClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDeviceFarmConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CreateDevicePool

        internal CreateDevicePoolResponse CreateDevicePool(CreateDevicePoolRequest request)
        {
            var marshaller = new CreateDevicePoolRequestMarshaller();
            var unmarshaller = CreateDevicePoolResponseUnmarshaller.Instance;

            return Invoke<CreateDevicePoolRequest,CreateDevicePoolResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDevicePool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDevicePoolResponse> CreateDevicePoolAsync(CreateDevicePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDevicePoolRequestMarshaller();
            var unmarshaller = CreateDevicePoolResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDevicePoolRequest,CreateDevicePoolResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateProject

        internal CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var marshaller = new CreateProjectRequestMarshaller();
            var unmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectRequest,CreateProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="name">The project's name.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        public Task<CreateProjectResponse> CreateProjectAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateProjectRequest();
            request.Name = name;
            return CreateProjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateProjectRequestMarshaller();
            var unmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectRequest,CreateProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateUpload

        internal CreateUploadResponse CreateUpload(CreateUploadRequest request)
        {
            var marshaller = new CreateUploadRequestMarshaller();
            var unmarshaller = CreateUploadResponseUnmarshaller.Instance;

            return Invoke<CreateUploadRequest,CreateUploadResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateUploadResponse> CreateUploadAsync(CreateUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateUploadRequestMarshaller();
            var unmarshaller = CreateUploadResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUploadRequest,CreateUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDevicePool

        internal DeleteDevicePoolResponse DeleteDevicePool(DeleteDevicePoolRequest request)
        {
            var marshaller = new DeleteDevicePoolRequestMarshaller();
            var unmarshaller = DeleteDevicePoolResponseUnmarshaller.Instance;

            return Invoke<DeleteDevicePoolRequest,DeleteDevicePoolResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevicePool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDevicePoolResponse> DeleteDevicePoolAsync(DeleteDevicePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDevicePoolRequestMarshaller();
            var unmarshaller = DeleteDevicePoolResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDevicePoolRequest,DeleteDevicePoolResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteProject

        internal DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var marshaller = new DeleteProjectRequestMarshaller();
            var unmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectRequest,DeleteProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteProjectRequestMarshaller();
            var unmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectRequest,DeleteProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRun

        internal DeleteRunResponse DeleteRun(DeleteRunRequest request)
        {
            var marshaller = new DeleteRunRequestMarshaller();
            var unmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return Invoke<DeleteRunRequest,DeleteRunResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteRunResponse> DeleteRunAsync(DeleteRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRunRequestMarshaller();
            var unmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRunRequest,DeleteRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUpload

        internal DeleteUploadResponse DeleteUpload(DeleteUploadRequest request)
        {
            var marshaller = new DeleteUploadRequestMarshaller();
            var unmarshaller = DeleteUploadResponseUnmarshaller.Instance;

            return Invoke<DeleteUploadRequest,DeleteUploadResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteUploadResponse> DeleteUploadAsync(DeleteUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteUploadRequestMarshaller();
            var unmarshaller = DeleteUploadResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUploadRequest,DeleteUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAccountSettings

        internal GetAccountSettingsResponse GetAccountSettings()
        {
            return GetAccountSettings(new GetAccountSettingsRequest());
        }
        internal GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
        {
            var marshaller = new GetAccountSettingsRequestMarshaller();
            var unmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAccountSettingsRequest,GetAccountSettingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the number of unmetered iOS and/or unmetered Android devices that have been
        /// purchased by the account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        public Task<GetAccountSettingsResponse> GetAccountSettingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetAccountSettingsAsync(new GetAccountSettingsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetAccountSettingsRequestMarshaller();
            var unmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountSettingsRequest,GetAccountSettingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDevice

        internal GetDeviceResponse GetDevice(GetDeviceRequest request)
        {
            var marshaller = new GetDeviceRequestMarshaller();
            var unmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return Invoke<GetDeviceRequest,GetDeviceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets information about a unique device type.
        /// </summary>
        /// <param name="arn">The device type's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        public Task<GetDeviceResponse> GetDeviceAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetDeviceRequest();
            request.Arn = arn;
            return GetDeviceAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDeviceRequestMarshaller();
            var unmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceRequest,GetDeviceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDevicePool

        internal GetDevicePoolResponse GetDevicePool(GetDevicePoolRequest request)
        {
            var marshaller = new GetDevicePoolRequestMarshaller();
            var unmarshaller = GetDevicePoolResponseUnmarshaller.Instance;

            return Invoke<GetDevicePoolRequest,GetDevicePoolResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets information about a device pool.
        /// </summary>
        /// <param name="arn">The device pool's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevicePool service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        public Task<GetDevicePoolResponse> GetDevicePoolAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetDevicePoolRequest();
            request.Arn = arn;
            return GetDevicePoolAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetDevicePoolResponse> GetDevicePoolAsync(GetDevicePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDevicePoolRequestMarshaller();
            var unmarshaller = GetDevicePoolResponseUnmarshaller.Instance;

            return InvokeAsync<GetDevicePoolRequest,GetDevicePoolResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDevicePoolCompatibility

        internal GetDevicePoolCompatibilityResponse GetDevicePoolCompatibility(GetDevicePoolCompatibilityRequest request)
        {
            var marshaller = new GetDevicePoolCompatibilityRequestMarshaller();
            var unmarshaller = GetDevicePoolCompatibilityResponseUnmarshaller.Instance;

            return Invoke<GetDevicePoolCompatibilityRequest,GetDevicePoolCompatibilityResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicePoolCompatibility operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePoolCompatibility operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetDevicePoolCompatibilityResponse> GetDevicePoolCompatibilityAsync(GetDevicePoolCompatibilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDevicePoolCompatibilityRequestMarshaller();
            var unmarshaller = GetDevicePoolCompatibilityResponseUnmarshaller.Instance;

            return InvokeAsync<GetDevicePoolCompatibilityRequest,GetDevicePoolCompatibilityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJob

        internal GetJobResponse GetJob(GetJobRequest request)
        {
            var marshaller = new GetJobRequestMarshaller();
            var unmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobRequest,GetJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets information about a job.
        /// </summary>
        /// <param name="arn">The job's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        public Task<GetJobResponse> GetJobAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetJobRequest();
            request.Arn = arn;
            return GetJobAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetJobRequestMarshaller();
            var unmarshaller = GetJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobRequest,GetJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetProject

        internal GetProjectResponse GetProject(GetProjectRequest request)
        {
            var marshaller = new GetProjectRequestMarshaller();
            var unmarshaller = GetProjectResponseUnmarshaller.Instance;

            return Invoke<GetProjectRequest,GetProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets information about a project.
        /// </summary>
        /// <param name="arn">The project's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        public Task<GetProjectResponse> GetProjectAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetProjectRequest();
            request.Arn = arn;
            return GetProjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetProjectRequestMarshaller();
            var unmarshaller = GetProjectResponseUnmarshaller.Instance;

            return InvokeAsync<GetProjectRequest,GetProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRun

        internal GetRunResponse GetRun(GetRunRequest request)
        {
            var marshaller = new GetRunRequestMarshaller();
            var unmarshaller = GetRunResponseUnmarshaller.Instance;

            return Invoke<GetRunRequest,GetRunResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets information about a run.
        /// </summary>
        /// <param name="arn">The run's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRun service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        public Task<GetRunResponse> GetRunAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetRunRequest();
            request.Arn = arn;
            return GetRunAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetRunResponse> GetRunAsync(GetRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetRunRequestMarshaller();
            var unmarshaller = GetRunResponseUnmarshaller.Instance;

            return InvokeAsync<GetRunRequest,GetRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSuite

        internal GetSuiteResponse GetSuite(GetSuiteRequest request)
        {
            var marshaller = new GetSuiteRequestMarshaller();
            var unmarshaller = GetSuiteResponseUnmarshaller.Instance;

            return Invoke<GetSuiteRequest,GetSuiteResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets information about a suite.
        /// </summary>
        /// <param name="arn">The suite's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSuite service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        public Task<GetSuiteResponse> GetSuiteAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetSuiteRequest();
            request.Arn = arn;
            return GetSuiteAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSuite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSuite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetSuiteResponse> GetSuiteAsync(GetSuiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSuiteRequestMarshaller();
            var unmarshaller = GetSuiteResponseUnmarshaller.Instance;

            return InvokeAsync<GetSuiteRequest,GetSuiteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTest

        internal GetTestResponse GetTest(GetTestRequest request)
        {
            var marshaller = new GetTestRequestMarshaller();
            var unmarshaller = GetTestResponseUnmarshaller.Instance;

            return Invoke<GetTestRequest,GetTestResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets information about a test.
        /// </summary>
        /// <param name="arn">The test's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTest service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        public Task<GetTestResponse> GetTestAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetTestRequest();
            request.Arn = arn;
            return GetTestAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetTestResponse> GetTestAsync(GetTestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTestRequestMarshaller();
            var unmarshaller = GetTestResponseUnmarshaller.Instance;

            return InvokeAsync<GetTestRequest,GetTestResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetUpload

        internal GetUploadResponse GetUpload(GetUploadRequest request)
        {
            var marshaller = new GetUploadRequestMarshaller();
            var unmarshaller = GetUploadResponseUnmarshaller.Instance;

            return Invoke<GetUploadRequest,GetUploadResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets information about an upload.
        /// </summary>
        /// <param name="arn">The upload's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUpload service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        public Task<GetUploadResponse> GetUploadAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetUploadRequest();
            request.Arn = arn;
            return GetUploadAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetUploadResponse> GetUploadAsync(GetUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetUploadRequestMarshaller();
            var unmarshaller = GetUploadResponseUnmarshaller.Instance;

            return InvokeAsync<GetUploadRequest,GetUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListArtifacts

        internal ListArtifactsResponse ListArtifacts(ListArtifactsRequest request)
        {
            var marshaller = new ListArtifactsRequestMarshaller();
            var unmarshaller = ListArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListArtifactsRequest,ListArtifactsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListArtifactsResponse> ListArtifactsAsync(ListArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListArtifactsRequestMarshaller();
            var unmarshaller = ListArtifactsResponseUnmarshaller.Instance;

            return InvokeAsync<ListArtifactsRequest,ListArtifactsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDevicePools

        internal ListDevicePoolsResponse ListDevicePools(ListDevicePoolsRequest request)
        {
            var marshaller = new ListDevicePoolsRequestMarshaller();
            var unmarshaller = ListDevicePoolsResponseUnmarshaller.Instance;

            return Invoke<ListDevicePoolsRequest,ListDevicePoolsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDevicePools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevicePools operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListDevicePoolsResponse> ListDevicePoolsAsync(ListDevicePoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDevicePoolsRequestMarshaller();
            var unmarshaller = ListDevicePoolsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevicePoolsRequest,ListDevicePoolsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDevices

        internal ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var marshaller = new ListDevicesRequestMarshaller();
            var unmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesRequest,ListDevicesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDevicesRequestMarshaller();
            var unmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevicesRequest,ListDevicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListJobs

        internal ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var marshaller = new ListJobsRequestMarshaller();
            var unmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsRequest,ListJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListJobsRequestMarshaller();
            var unmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsRequest,ListJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListProjects

        internal ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var marshaller = new ListProjectsRequestMarshaller();
            var unmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsRequest,ListProjectsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListProjectsRequestMarshaller();
            var unmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectsRequest,ListProjectsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRuns

        internal ListRunsResponse ListRuns(ListRunsRequest request)
        {
            var marshaller = new ListRunsRequestMarshaller();
            var unmarshaller = ListRunsResponseUnmarshaller.Instance;

            return Invoke<ListRunsRequest,ListRunsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListRunsResponse> ListRunsAsync(ListRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListRunsRequestMarshaller();
            var unmarshaller = ListRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRunsRequest,ListRunsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSamples

        internal ListSamplesResponse ListSamples(ListSamplesRequest request)
        {
            var marshaller = new ListSamplesRequestMarshaller();
            var unmarshaller = ListSamplesResponseUnmarshaller.Instance;

            return Invoke<ListSamplesRequest,ListSamplesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSamples operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSamples operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListSamplesResponse> ListSamplesAsync(ListSamplesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListSamplesRequestMarshaller();
            var unmarshaller = ListSamplesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSamplesRequest,ListSamplesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSuites

        internal ListSuitesResponse ListSuites(ListSuitesRequest request)
        {
            var marshaller = new ListSuitesRequestMarshaller();
            var unmarshaller = ListSuitesResponseUnmarshaller.Instance;

            return Invoke<ListSuitesRequest,ListSuitesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSuites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSuites operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListSuitesResponse> ListSuitesAsync(ListSuitesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListSuitesRequestMarshaller();
            var unmarshaller = ListSuitesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSuitesRequest,ListSuitesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTests

        internal ListTestsResponse ListTests(ListTestsRequest request)
        {
            var marshaller = new ListTestsRequestMarshaller();
            var unmarshaller = ListTestsResponseUnmarshaller.Instance;

            return Invoke<ListTestsRequest,ListTestsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTestsResponse> ListTestsAsync(ListTestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTestsRequestMarshaller();
            var unmarshaller = ListTestsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTestsRequest,ListTestsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListUniqueProblems

        internal ListUniqueProblemsResponse ListUniqueProblems(ListUniqueProblemsRequest request)
        {
            var marshaller = new ListUniqueProblemsRequestMarshaller();
            var unmarshaller = ListUniqueProblemsResponseUnmarshaller.Instance;

            return Invoke<ListUniqueProblemsRequest,ListUniqueProblemsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListUniqueProblems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUniqueProblems operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListUniqueProblemsResponse> ListUniqueProblemsAsync(ListUniqueProblemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListUniqueProblemsRequestMarshaller();
            var unmarshaller = ListUniqueProblemsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUniqueProblemsRequest,ListUniqueProblemsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListUploads

        internal ListUploadsResponse ListUploads(ListUploadsRequest request)
        {
            var marshaller = new ListUploadsRequestMarshaller();
            var unmarshaller = ListUploadsResponseUnmarshaller.Instance;

            return Invoke<ListUploadsRequest,ListUploadsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListUploads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUploads operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListUploadsResponse> ListUploadsAsync(ListUploadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListUploadsRequestMarshaller();
            var unmarshaller = ListUploadsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUploadsRequest,ListUploadsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ScheduleRun

        internal ScheduleRunResponse ScheduleRun(ScheduleRunRequest request)
        {
            var marshaller = new ScheduleRunRequestMarshaller();
            var unmarshaller = ScheduleRunResponseUnmarshaller.Instance;

            return Invoke<ScheduleRunRequest,ScheduleRunResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ScheduleRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ScheduleRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ScheduleRunResponse> ScheduleRunAsync(ScheduleRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ScheduleRunRequestMarshaller();
            var unmarshaller = ScheduleRunResponseUnmarshaller.Instance;

            return InvokeAsync<ScheduleRunRequest,ScheduleRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDevicePool

        internal UpdateDevicePoolResponse UpdateDevicePool(UpdateDevicePoolRequest request)
        {
            var marshaller = new UpdateDevicePoolRequestMarshaller();
            var unmarshaller = UpdateDevicePoolResponseUnmarshaller.Instance;

            return Invoke<UpdateDevicePoolRequest,UpdateDevicePoolResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevicePool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateDevicePoolResponse> UpdateDevicePoolAsync(UpdateDevicePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDevicePoolRequestMarshaller();
            var unmarshaller = UpdateDevicePoolResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDevicePoolRequest,UpdateDevicePoolResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateProject

        internal UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var marshaller = new UpdateProjectRequestMarshaller();
            var unmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectRequest,UpdateProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateProjectRequestMarshaller();
            var unmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProjectRequest,UpdateProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}