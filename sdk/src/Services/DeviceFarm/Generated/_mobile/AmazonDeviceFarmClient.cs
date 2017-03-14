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

#if CORECLR
    
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateDevicePool">REST API Reference for CreateDevicePool Operation</seealso>
        public Task<CreateDevicePoolResponse> CreateDevicePoolAsync(CreateDevicePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDevicePoolRequestMarshaller();
            var unmarshaller = CreateDevicePoolResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDevicePoolRequest,CreateDevicePoolResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkProfile

        internal CreateNetworkProfileResponse CreateNetworkProfile(CreateNetworkProfileRequest request)
        {
            var marshaller = new CreateNetworkProfileRequestMarshaller();
            var unmarshaller = CreateNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkProfileRequest,CreateNetworkProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateNetworkProfile">REST API Reference for CreateNetworkProfile Operation</seealso>
        public Task<CreateNetworkProfileResponse> CreateNetworkProfileAsync(CreateNetworkProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateNetworkProfileRequestMarshaller();
            var unmarshaller = CreateNetworkProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkProfileRequest,CreateNetworkProfileResponse>(request, marshaller, 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateProject">REST API Reference for CreateProject Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateProjectRequestMarshaller();
            var unmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectRequest,CreateProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRemoteAccessSession

        internal CreateRemoteAccessSessionResponse CreateRemoteAccessSession(CreateRemoteAccessSessionRequest request)
        {
            var marshaller = new CreateRemoteAccessSessionRequestMarshaller();
            var unmarshaller = CreateRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<CreateRemoteAccessSessionRequest,CreateRemoteAccessSessionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRemoteAccessSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateRemoteAccessSession">REST API Reference for CreateRemoteAccessSession Operation</seealso>
        public Task<CreateRemoteAccessSessionResponse> CreateRemoteAccessSessionAsync(CreateRemoteAccessSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRemoteAccessSessionRequestMarshaller();
            var unmarshaller = CreateRemoteAccessSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRemoteAccessSessionRequest,CreateRemoteAccessSessionResponse>(request, marshaller, 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateUpload">REST API Reference for CreateUpload Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteDevicePool">REST API Reference for DeleteDevicePool Operation</seealso>
        public Task<DeleteDevicePoolResponse> DeleteDevicePoolAsync(DeleteDevicePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDevicePoolRequestMarshaller();
            var unmarshaller = DeleteDevicePoolResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDevicePoolRequest,DeleteDevicePoolResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkProfile

        internal DeleteNetworkProfileResponse DeleteNetworkProfile(DeleteNetworkProfileRequest request)
        {
            var marshaller = new DeleteNetworkProfileRequestMarshaller();
            var unmarshaller = DeleteNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkProfileRequest,DeleteNetworkProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteNetworkProfile">REST API Reference for DeleteNetworkProfile Operation</seealso>
        public Task<DeleteNetworkProfileResponse> DeleteNetworkProfileAsync(DeleteNetworkProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNetworkProfileRequestMarshaller();
            var unmarshaller = DeleteNetworkProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkProfileRequest,DeleteNetworkProfileResponse>(request, marshaller, 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteProjectRequestMarshaller();
            var unmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectRequest,DeleteProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRemoteAccessSession

        internal DeleteRemoteAccessSessionResponse DeleteRemoteAccessSession(DeleteRemoteAccessSessionRequest request)
        {
            var marshaller = new DeleteRemoteAccessSessionRequestMarshaller();
            var unmarshaller = DeleteRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<DeleteRemoteAccessSessionRequest,DeleteRemoteAccessSessionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRemoteAccessSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteRemoteAccessSession">REST API Reference for DeleteRemoteAccessSession Operation</seealso>
        public Task<DeleteRemoteAccessSessionResponse> DeleteRemoteAccessSessionAsync(DeleteRemoteAccessSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRemoteAccessSessionRequestMarshaller();
            var unmarshaller = DeleteRemoteAccessSessionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRemoteAccessSessionRequest,DeleteRemoteAccessSessionResponse>(request, marshaller, 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteRun">REST API Reference for DeleteRun Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteUpload">REST API Reference for DeleteUpload Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevice">REST API Reference for GetDevice Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevice">REST API Reference for GetDevice Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePool">REST API Reference for GetDevicePool Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePool">REST API Reference for GetDevicePool Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePoolCompatibility">REST API Reference for GetDevicePoolCompatibility Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetJob">REST API Reference for GetJob Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetJob">REST API Reference for GetJob Operation</seealso>
        public Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetJobRequestMarshaller();
            var unmarshaller = GetJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobRequest,GetJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetNetworkProfile

        internal GetNetworkProfileResponse GetNetworkProfile(GetNetworkProfileRequest request)
        {
            var marshaller = new GetNetworkProfileRequestMarshaller();
            var unmarshaller = GetNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<GetNetworkProfileRequest,GetNetworkProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetNetworkProfile">REST API Reference for GetNetworkProfile Operation</seealso>
        public Task<GetNetworkProfileResponse> GetNetworkProfileAsync(GetNetworkProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetNetworkProfileRequestMarshaller();
            var unmarshaller = GetNetworkProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetNetworkProfileRequest,GetNetworkProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetOfferingStatus

        internal GetOfferingStatusResponse GetOfferingStatus(GetOfferingStatusRequest request)
        {
            var marshaller = new GetOfferingStatusRequestMarshaller();
            var unmarshaller = GetOfferingStatusResponseUnmarshaller.Instance;

            return Invoke<GetOfferingStatusRequest,GetOfferingStatusResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetOfferingStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOfferingStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetOfferingStatus">REST API Reference for GetOfferingStatus Operation</seealso>
        public Task<GetOfferingStatusResponse> GetOfferingStatusAsync(GetOfferingStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetOfferingStatusRequestMarshaller();
            var unmarshaller = GetOfferingStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetOfferingStatusRequest,GetOfferingStatusResponse>(request, marshaller, 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetProject">REST API Reference for GetProject Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetProject">REST API Reference for GetProject Operation</seealso>
        public Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetProjectRequestMarshaller();
            var unmarshaller = GetProjectResponseUnmarshaller.Instance;

            return InvokeAsync<GetProjectRequest,GetProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRemoteAccessSession

        internal GetRemoteAccessSessionResponse GetRemoteAccessSession(GetRemoteAccessSessionRequest request)
        {
            var marshaller = new GetRemoteAccessSessionRequestMarshaller();
            var unmarshaller = GetRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<GetRemoteAccessSessionRequest,GetRemoteAccessSessionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRemoteAccessSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRemoteAccessSession">REST API Reference for GetRemoteAccessSession Operation</seealso>
        public Task<GetRemoteAccessSessionResponse> GetRemoteAccessSessionAsync(GetRemoteAccessSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetRemoteAccessSessionRequestMarshaller();
            var unmarshaller = GetRemoteAccessSessionResponseUnmarshaller.Instance;

            return InvokeAsync<GetRemoteAccessSessionRequest,GetRemoteAccessSessionResponse>(request, marshaller, 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRun">REST API Reference for GetRun Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRun">REST API Reference for GetRun Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetSuite">REST API Reference for GetSuite Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetSuite">REST API Reference for GetSuite Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetTest">REST API Reference for GetTest Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetTest">REST API Reference for GetTest Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetUpload">REST API Reference for GetUpload Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetUpload">REST API Reference for GetUpload Operation</seealso>
        public Task<GetUploadResponse> GetUploadAsync(GetUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetUploadRequestMarshaller();
            var unmarshaller = GetUploadResponseUnmarshaller.Instance;

            return InvokeAsync<GetUploadRequest,GetUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InstallToRemoteAccessSession

        internal InstallToRemoteAccessSessionResponse InstallToRemoteAccessSession(InstallToRemoteAccessSessionRequest request)
        {
            var marshaller = new InstallToRemoteAccessSessionRequestMarshaller();
            var unmarshaller = InstallToRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<InstallToRemoteAccessSessionRequest,InstallToRemoteAccessSessionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the InstallToRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InstallToRemoteAccessSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/InstallToRemoteAccessSession">REST API Reference for InstallToRemoteAccessSession Operation</seealso>
        public Task<InstallToRemoteAccessSessionResponse> InstallToRemoteAccessSessionAsync(InstallToRemoteAccessSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new InstallToRemoteAccessSessionRequestMarshaller();
            var unmarshaller = InstallToRemoteAccessSessionResponseUnmarshaller.Instance;

            return InvokeAsync<InstallToRemoteAccessSessionRequest,InstallToRemoteAccessSessionResponse>(request, marshaller, 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDevicePools">REST API Reference for ListDevicePools Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDevices">REST API Reference for ListDevices Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListJobsRequestMarshaller();
            var unmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsRequest,ListJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListNetworkProfiles

        internal ListNetworkProfilesResponse ListNetworkProfiles(ListNetworkProfilesRequest request)
        {
            var marshaller = new ListNetworkProfilesRequestMarshaller();
            var unmarshaller = ListNetworkProfilesResponseUnmarshaller.Instance;

            return Invoke<ListNetworkProfilesRequest,ListNetworkProfilesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListNetworkProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListNetworkProfiles">REST API Reference for ListNetworkProfiles Operation</seealso>
        public Task<ListNetworkProfilesResponse> ListNetworkProfilesAsync(ListNetworkProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListNetworkProfilesRequestMarshaller();
            var unmarshaller = ListNetworkProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListNetworkProfilesRequest,ListNetworkProfilesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListOfferings

        internal ListOfferingsResponse ListOfferings(ListOfferingsRequest request)
        {
            var marshaller = new ListOfferingsRequestMarshaller();
            var unmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingsRequest,ListOfferingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public Task<ListOfferingsResponse> ListOfferingsAsync(ListOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListOfferingsRequestMarshaller();
            var unmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOfferingsRequest,ListOfferingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListOfferingTransactions

        internal ListOfferingTransactionsResponse ListOfferingTransactions(ListOfferingTransactionsRequest request)
        {
            var marshaller = new ListOfferingTransactionsRequestMarshaller();
            var unmarshaller = ListOfferingTransactionsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingTransactionsRequest,ListOfferingTransactionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListOfferingTransactions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOfferingTransactions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferingTransactions">REST API Reference for ListOfferingTransactions Operation</seealso>
        public Task<ListOfferingTransactionsResponse> ListOfferingTransactionsAsync(ListOfferingTransactionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListOfferingTransactionsRequestMarshaller();
            var unmarshaller = ListOfferingTransactionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOfferingTransactionsRequest,ListOfferingTransactionsResponse>(request, marshaller, 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListProjectsRequestMarshaller();
            var unmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectsRequest,ListProjectsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRemoteAccessSessions

        internal ListRemoteAccessSessionsResponse ListRemoteAccessSessions(ListRemoteAccessSessionsRequest request)
        {
            var marshaller = new ListRemoteAccessSessionsRequestMarshaller();
            var unmarshaller = ListRemoteAccessSessionsResponseUnmarshaller.Instance;

            return Invoke<ListRemoteAccessSessionsRequest,ListRemoteAccessSessionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListRemoteAccessSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRemoteAccessSessions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListRemoteAccessSessions">REST API Reference for ListRemoteAccessSessions Operation</seealso>
        public Task<ListRemoteAccessSessionsResponse> ListRemoteAccessSessionsAsync(ListRemoteAccessSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListRemoteAccessSessionsRequestMarshaller();
            var unmarshaller = ListRemoteAccessSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRemoteAccessSessionsRequest,ListRemoteAccessSessionsResponse>(request, marshaller, 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListRuns">REST API Reference for ListRuns Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListSamples">REST API Reference for ListSamples Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListSuites">REST API Reference for ListSuites Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTests">REST API Reference for ListTests Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListUniqueProblems">REST API Reference for ListUniqueProblems Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListUploads">REST API Reference for ListUploads Operation</seealso>
        public Task<ListUploadsResponse> ListUploadsAsync(ListUploadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListUploadsRequestMarshaller();
            var unmarshaller = ListUploadsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUploadsRequest,ListUploadsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PurchaseOffering

        internal PurchaseOfferingResponse PurchaseOffering(PurchaseOfferingRequest request)
        {
            var marshaller = new PurchaseOfferingRequestMarshaller();
            var unmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseOfferingRequest,PurchaseOfferingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public Task<PurchaseOfferingResponse> PurchaseOfferingAsync(PurchaseOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseOfferingRequestMarshaller();
            var unmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseOfferingRequest,PurchaseOfferingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RenewOffering

        internal RenewOfferingResponse RenewOffering(RenewOfferingRequest request)
        {
            var marshaller = new RenewOfferingRequestMarshaller();
            var unmarshaller = RenewOfferingResponseUnmarshaller.Instance;

            return Invoke<RenewOfferingRequest,RenewOfferingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RenewOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenewOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/RenewOffering">REST API Reference for RenewOffering Operation</seealso>
        public Task<RenewOfferingResponse> RenewOfferingAsync(RenewOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RenewOfferingRequestMarshaller();
            var unmarshaller = RenewOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<RenewOfferingRequest,RenewOfferingResponse>(request, marshaller, 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ScheduleRun">REST API Reference for ScheduleRun Operation</seealso>
        public Task<ScheduleRunResponse> ScheduleRunAsync(ScheduleRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ScheduleRunRequestMarshaller();
            var unmarshaller = ScheduleRunResponseUnmarshaller.Instance;

            return InvokeAsync<ScheduleRunRequest,ScheduleRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopRemoteAccessSession

        internal StopRemoteAccessSessionResponse StopRemoteAccessSession(StopRemoteAccessSessionRequest request)
        {
            var marshaller = new StopRemoteAccessSessionRequestMarshaller();
            var unmarshaller = StopRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<StopRemoteAccessSessionRequest,StopRemoteAccessSessionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopRemoteAccessSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopRemoteAccessSession">REST API Reference for StopRemoteAccessSession Operation</seealso>
        public Task<StopRemoteAccessSessionResponse> StopRemoteAccessSessionAsync(StopRemoteAccessSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopRemoteAccessSessionRequestMarshaller();
            var unmarshaller = StopRemoteAccessSessionResponseUnmarshaller.Instance;

            return InvokeAsync<StopRemoteAccessSessionRequest,StopRemoteAccessSessionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopRun

        internal StopRunResponse StopRun(StopRunRequest request)
        {
            var marshaller = new StopRunRequestMarshaller();
            var unmarshaller = StopRunResponseUnmarshaller.Instance;

            return Invoke<StopRunRequest,StopRunResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopRun">REST API Reference for StopRun Operation</seealso>
        public Task<StopRunResponse> StopRunAsync(StopRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopRunRequestMarshaller();
            var unmarshaller = StopRunResponseUnmarshaller.Instance;

            return InvokeAsync<StopRunRequest,StopRunResponse>(request, marshaller, 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateDevicePool">REST API Reference for UpdateDevicePool Operation</seealso>
        public Task<UpdateDevicePoolResponse> UpdateDevicePoolAsync(UpdateDevicePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDevicePoolRequestMarshaller();
            var unmarshaller = UpdateDevicePoolResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDevicePoolRequest,UpdateDevicePoolResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateNetworkProfile

        internal UpdateNetworkProfileResponse UpdateNetworkProfile(UpdateNetworkProfileRequest request)
        {
            var marshaller = new UpdateNetworkProfileRequestMarshaller();
            var unmarshaller = UpdateNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkProfileRequest,UpdateNetworkProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateNetworkProfile">REST API Reference for UpdateNetworkProfile Operation</seealso>
        public Task<UpdateNetworkProfileResponse> UpdateNetworkProfileAsync(UpdateNetworkProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateNetworkProfileRequestMarshaller();
            var unmarshaller = UpdateNetworkProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNetworkProfileRequest,UpdateNetworkProfileResponse>(request, marshaller, 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
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