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
using System.Net;

using Amazon.DeviceFarm.Model;
using Amazon.DeviceFarm.Model.Internal.MarshallTransformations;
using Amazon.DeviceFarm.Internal;
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
        private static IServiceMetadata serviceMetadata = new AmazonDeviceFarmMetadata();
        
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

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
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

        internal virtual CreateDevicePoolResponse CreateDevicePool(CreateDevicePoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDevicePoolResponseUnmarshaller.Instance;

            return Invoke<CreateDevicePoolResponse>(request, options);
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
        public virtual Task<CreateDevicePoolResponse> CreateDevicePoolAsync(CreateDevicePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDevicePoolResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDevicePoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInstanceProfile

        internal virtual CreateInstanceProfileResponse CreateInstanceProfile(CreateInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceProfileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        public virtual Task<CreateInstanceProfileResponse> CreateInstanceProfileAsync(CreateInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkProfile

        internal virtual CreateNetworkProfileResponse CreateNetworkProfile(CreateNetworkProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkProfileResponse>(request, options);
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
        public virtual Task<CreateNetworkProfileResponse> CreateNetworkProfileAsync(CreateNetworkProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProject

        internal virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
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
        public virtual Task<CreateProjectResponse> CreateProjectAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRemoteAccessSession

        internal virtual CreateRemoteAccessSessionResponse CreateRemoteAccessSession(CreateRemoteAccessSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<CreateRemoteAccessSessionResponse>(request, options);
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
        public virtual Task<CreateRemoteAccessSessionResponse> CreateRemoteAccessSessionAsync(CreateRemoteAccessSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRemoteAccessSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRemoteAccessSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUpload

        internal virtual CreateUploadResponse CreateUpload(CreateUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUploadResponseUnmarshaller.Instance;

            return Invoke<CreateUploadResponse>(request, options);
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
        public virtual Task<CreateUploadResponse> CreateUploadAsync(CreateUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUploadResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVPCEConfiguration

        internal virtual CreateVPCEConfigurationResponse CreateVPCEConfiguration(CreateVPCEConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVPCEConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateVPCEConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVPCEConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVPCEConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateVPCEConfiguration">REST API Reference for CreateVPCEConfiguration Operation</seealso>
        public virtual Task<CreateVPCEConfigurationResponse> CreateVPCEConfigurationAsync(CreateVPCEConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVPCEConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVPCEConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDevicePool

        internal virtual DeleteDevicePoolResponse DeleteDevicePool(DeleteDevicePoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDevicePoolResponseUnmarshaller.Instance;

            return Invoke<DeleteDevicePoolResponse>(request, options);
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
        public virtual Task<DeleteDevicePoolResponse> DeleteDevicePoolAsync(DeleteDevicePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDevicePoolResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDevicePoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInstanceProfile

        internal virtual DeleteInstanceProfileResponse DeleteInstanceProfile(DeleteInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceProfileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        public virtual Task<DeleteInstanceProfileResponse> DeleteInstanceProfileAsync(DeleteInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInstanceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkProfile

        internal virtual DeleteNetworkProfileResponse DeleteNetworkProfile(DeleteNetworkProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkProfileResponse>(request, options);
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
        public virtual Task<DeleteNetworkProfileResponse> DeleteNetworkProfileAsync(DeleteNetworkProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProject

        internal virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
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
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRemoteAccessSession

        internal virtual DeleteRemoteAccessSessionResponse DeleteRemoteAccessSession(DeleteRemoteAccessSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<DeleteRemoteAccessSessionResponse>(request, options);
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
        public virtual Task<DeleteRemoteAccessSessionResponse> DeleteRemoteAccessSessionAsync(DeleteRemoteAccessSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRemoteAccessSessionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRemoteAccessSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRun

        internal virtual DeleteRunResponse DeleteRun(DeleteRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return Invoke<DeleteRunResponse>(request, options);
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
        public virtual Task<DeleteRunResponse> DeleteRunAsync(DeleteRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUpload

        internal virtual DeleteUploadResponse DeleteUpload(DeleteUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUploadResponseUnmarshaller.Instance;

            return Invoke<DeleteUploadResponse>(request, options);
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
        public virtual Task<DeleteUploadResponse> DeleteUploadAsync(DeleteUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUploadResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVPCEConfiguration

        internal virtual DeleteVPCEConfigurationResponse DeleteVPCEConfiguration(DeleteVPCEConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVPCEConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteVPCEConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVPCEConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVPCEConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteVPCEConfiguration">REST API Reference for DeleteVPCEConfiguration Operation</seealso>
        public virtual Task<DeleteVPCEConfigurationResponse> DeleteVPCEConfigurationAsync(DeleteVPCEConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVPCEConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVPCEConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccountSettings

        internal virtual GetAccountSettingsResponse GetAccountSettings()
        {
            return GetAccountSettings(new GetAccountSettingsRequest());
        }
        internal virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAccountSettingsResponse>(request, options);
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
        public virtual Task<GetAccountSettingsResponse> GetAccountSettingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public virtual Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDevice

        internal virtual GetDeviceResponse GetDevice(GetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return Invoke<GetDeviceResponse>(request, options);
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
        public virtual Task<GetDeviceResponse> GetDeviceAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public virtual Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeviceInstance

        internal virtual GetDeviceInstanceResponse GetDeviceInstance(GetDeviceInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceInstanceResponseUnmarshaller.Instance;

            return Invoke<GetDeviceInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDeviceInstance">REST API Reference for GetDeviceInstance Operation</seealso>
        public virtual Task<GetDeviceInstanceResponse> GetDeviceInstanceAsync(GetDeviceInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDevicePool

        internal virtual GetDevicePoolResponse GetDevicePool(GetDevicePoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicePoolResponseUnmarshaller.Instance;

            return Invoke<GetDevicePoolResponse>(request, options);
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
        public virtual Task<GetDevicePoolResponse> GetDevicePoolAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public virtual Task<GetDevicePoolResponse> GetDevicePoolAsync(GetDevicePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicePoolResponseUnmarshaller.Instance;

            return InvokeAsync<GetDevicePoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDevicePoolCompatibility

        internal virtual GetDevicePoolCompatibilityResponse GetDevicePoolCompatibility(GetDevicePoolCompatibilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicePoolCompatibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicePoolCompatibilityResponseUnmarshaller.Instance;

            return Invoke<GetDevicePoolCompatibilityResponse>(request, options);
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
        public virtual Task<GetDevicePoolCompatibilityResponse> GetDevicePoolCompatibilityAsync(GetDevicePoolCompatibilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicePoolCompatibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicePoolCompatibilityResponseUnmarshaller.Instance;

            return InvokeAsync<GetDevicePoolCompatibilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstanceProfile

        internal virtual GetInstanceProfileResponse GetInstanceProfile(GetInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<GetInstanceProfileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetInstanceProfile">REST API Reference for GetInstanceProfile Operation</seealso>
        public virtual Task<GetInstanceProfileResponse> GetInstanceProfileAsync(GetInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstanceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJob

        internal virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobResponse>(request, options);
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
        public virtual Task<GetJobResponse> GetJobAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public virtual Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNetworkProfile

        internal virtual GetNetworkProfileResponse GetNetworkProfile(GetNetworkProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<GetNetworkProfileResponse>(request, options);
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
        public virtual Task<GetNetworkProfileResponse> GetNetworkProfileAsync(GetNetworkProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetNetworkProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOfferingStatus

        internal virtual GetOfferingStatusResponse GetOfferingStatus(GetOfferingStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOfferingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOfferingStatusResponseUnmarshaller.Instance;

            return Invoke<GetOfferingStatusResponse>(request, options);
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
        public virtual Task<GetOfferingStatusResponse> GetOfferingStatusAsync(GetOfferingStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOfferingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOfferingStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetOfferingStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetProject

        internal virtual GetProjectResponse GetProject(GetProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;

            return Invoke<GetProjectResponse>(request, options);
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
        public virtual Task<GetProjectResponse> GetProjectAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public virtual Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;

            return InvokeAsync<GetProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRemoteAccessSession

        internal virtual GetRemoteAccessSessionResponse GetRemoteAccessSession(GetRemoteAccessSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<GetRemoteAccessSessionResponse>(request, options);
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
        public virtual Task<GetRemoteAccessSessionResponse> GetRemoteAccessSessionAsync(GetRemoteAccessSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRemoteAccessSessionResponseUnmarshaller.Instance;

            return InvokeAsync<GetRemoteAccessSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRun

        internal virtual GetRunResponse GetRun(GetRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunResponseUnmarshaller.Instance;

            return Invoke<GetRunResponse>(request, options);
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
        public virtual Task<GetRunResponse> GetRunAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public virtual Task<GetRunResponse> GetRunAsync(GetRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunResponseUnmarshaller.Instance;

            return InvokeAsync<GetRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSuite

        internal virtual GetSuiteResponse GetSuite(GetSuiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSuiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteResponseUnmarshaller.Instance;

            return Invoke<GetSuiteResponse>(request, options);
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
        public virtual Task<GetSuiteResponse> GetSuiteAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public virtual Task<GetSuiteResponse> GetSuiteAsync(GetSuiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSuiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteResponseUnmarshaller.Instance;

            return InvokeAsync<GetSuiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTest

        internal virtual GetTestResponse GetTest(GetTestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestResponseUnmarshaller.Instance;

            return Invoke<GetTestResponse>(request, options);
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
        public virtual Task<GetTestResponse> GetTestAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public virtual Task<GetTestResponse> GetTestAsync(GetTestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestResponseUnmarshaller.Instance;

            return InvokeAsync<GetTestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUpload

        internal virtual GetUploadResponse GetUpload(GetUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUploadResponseUnmarshaller.Instance;

            return Invoke<GetUploadResponse>(request, options);
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
        public virtual Task<GetUploadResponse> GetUploadAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public virtual Task<GetUploadResponse> GetUploadAsync(GetUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUploadResponseUnmarshaller.Instance;

            return InvokeAsync<GetUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVPCEConfiguration

        internal virtual GetVPCEConfigurationResponse GetVPCEConfiguration(GetVPCEConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVPCEConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetVPCEConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetVPCEConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVPCEConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetVPCEConfiguration">REST API Reference for GetVPCEConfiguration Operation</seealso>
        public virtual Task<GetVPCEConfigurationResponse> GetVPCEConfigurationAsync(GetVPCEConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVPCEConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetVPCEConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InstallToRemoteAccessSession

        internal virtual InstallToRemoteAccessSessionResponse InstallToRemoteAccessSession(InstallToRemoteAccessSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InstallToRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InstallToRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<InstallToRemoteAccessSessionResponse>(request, options);
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
        public virtual Task<InstallToRemoteAccessSessionResponse> InstallToRemoteAccessSessionAsync(InstallToRemoteAccessSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InstallToRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InstallToRemoteAccessSessionResponseUnmarshaller.Instance;

            return InvokeAsync<InstallToRemoteAccessSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListArtifacts

        internal virtual ListArtifactsResponse ListArtifacts(ListArtifactsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListArtifactsResponse>(request, options);
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
        public virtual Task<ListArtifactsResponse> ListArtifactsAsync(ListArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArtifactsResponseUnmarshaller.Instance;

            return InvokeAsync<ListArtifactsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDeviceInstances

        internal virtual ListDeviceInstancesResponse ListDeviceInstances(ListDeviceInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeviceInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceInstancesResponseUnmarshaller.Instance;

            return Invoke<ListDeviceInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDeviceInstances">REST API Reference for ListDeviceInstances Operation</seealso>
        public virtual Task<ListDeviceInstancesResponse> ListDeviceInstancesAsync(ListDeviceInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeviceInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeviceInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDevicePools

        internal virtual ListDevicePoolsResponse ListDevicePools(ListDevicePoolsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicePoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicePoolsResponseUnmarshaller.Instance;

            return Invoke<ListDevicePoolsResponse>(request, options);
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
        public virtual Task<ListDevicePoolsResponse> ListDevicePoolsAsync(ListDevicePoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicePoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicePoolsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevicePoolsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDevices

        internal virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesResponse>(request, options);
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
        public virtual Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInstanceProfiles

        internal virtual ListInstanceProfilesResponse ListInstanceProfiles(ListInstanceProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListInstanceProfilesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        public virtual Task<ListInstanceProfilesResponse> ListInstanceProfilesAsync(ListInstanceProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstanceProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobs

        internal virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
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
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNetworkProfiles

        internal virtual ListNetworkProfilesResponse ListNetworkProfiles(ListNetworkProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworkProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkProfilesResponseUnmarshaller.Instance;

            return Invoke<ListNetworkProfilesResponse>(request, options);
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
        public virtual Task<ListNetworkProfilesResponse> ListNetworkProfilesAsync(ListNetworkProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworkProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListNetworkProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOfferingPromotions

        internal virtual ListOfferingPromotionsResponse ListOfferingPromotions(ListOfferingPromotionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOfferingPromotionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingPromotionsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingPromotionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListOfferingPromotions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOfferingPromotions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferingPromotions">REST API Reference for ListOfferingPromotions Operation</seealso>
        public virtual Task<ListOfferingPromotionsResponse> ListOfferingPromotionsAsync(ListOfferingPromotionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOfferingPromotionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingPromotionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOfferingPromotionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOfferings

        internal virtual ListOfferingsResponse ListOfferings(ListOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingsResponse>(request, options);
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
        public virtual Task<ListOfferingsResponse> ListOfferingsAsync(ListOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOfferingTransactions

        internal virtual ListOfferingTransactionsResponse ListOfferingTransactions(ListOfferingTransactionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOfferingTransactionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingTransactionsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingTransactionsResponse>(request, options);
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
        public virtual Task<ListOfferingTransactionsResponse> ListOfferingTransactionsAsync(ListOfferingTransactionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOfferingTransactionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingTransactionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOfferingTransactionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProjects

        internal virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsResponse>(request, options);
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
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRemoteAccessSessions

        internal virtual ListRemoteAccessSessionsResponse ListRemoteAccessSessions(ListRemoteAccessSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRemoteAccessSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRemoteAccessSessionsResponseUnmarshaller.Instance;

            return Invoke<ListRemoteAccessSessionsResponse>(request, options);
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
        public virtual Task<ListRemoteAccessSessionsResponse> ListRemoteAccessSessionsAsync(ListRemoteAccessSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRemoteAccessSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRemoteAccessSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRemoteAccessSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRuns

        internal virtual ListRunsResponse ListRuns(ListRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunsResponseUnmarshaller.Instance;

            return Invoke<ListRunsResponse>(request, options);
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
        public virtual Task<ListRunsResponse> ListRunsAsync(ListRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRunsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSamples

        internal virtual ListSamplesResponse ListSamples(ListSamplesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSamplesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSamplesResponseUnmarshaller.Instance;

            return Invoke<ListSamplesResponse>(request, options);
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
        public virtual Task<ListSamplesResponse> ListSamplesAsync(ListSamplesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSamplesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSamplesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSamplesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSuites

        internal virtual ListSuitesResponse ListSuites(ListSuitesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSuitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuitesResponseUnmarshaller.Instance;

            return Invoke<ListSuitesResponse>(request, options);
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
        public virtual Task<ListSuitesResponse> ListSuitesAsync(ListSuitesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSuitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuitesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSuitesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTests

        internal virtual ListTestsResponse ListTests(ListTestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestsResponseUnmarshaller.Instance;

            return Invoke<ListTestsResponse>(request, options);
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
        public virtual Task<ListTestsResponse> ListTestsAsync(ListTestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUniqueProblems

        internal virtual ListUniqueProblemsResponse ListUniqueProblems(ListUniqueProblemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUniqueProblemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUniqueProblemsResponseUnmarshaller.Instance;

            return Invoke<ListUniqueProblemsResponse>(request, options);
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
        public virtual Task<ListUniqueProblemsResponse> ListUniqueProblemsAsync(ListUniqueProblemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUniqueProblemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUniqueProblemsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUniqueProblemsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUploads

        internal virtual ListUploadsResponse ListUploads(ListUploadsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUploadsResponseUnmarshaller.Instance;

            return Invoke<ListUploadsResponse>(request, options);
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
        public virtual Task<ListUploadsResponse> ListUploadsAsync(ListUploadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUploadsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUploadsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVPCEConfigurations

        internal virtual ListVPCEConfigurationsResponse ListVPCEConfigurations(ListVPCEConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVPCEConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVPCEConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListVPCEConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListVPCEConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVPCEConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListVPCEConfigurations">REST API Reference for ListVPCEConfigurations Operation</seealso>
        public virtual Task<ListVPCEConfigurationsResponse> ListVPCEConfigurationsAsync(ListVPCEConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVPCEConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVPCEConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVPCEConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseOffering

        internal virtual PurchaseOfferingResponse PurchaseOffering(PurchaseOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseOfferingResponse>(request, options);
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
        public virtual Task<PurchaseOfferingResponse> PurchaseOfferingAsync(PurchaseOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseOfferingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RenewOffering

        internal virtual RenewOfferingResponse RenewOffering(RenewOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RenewOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenewOfferingResponseUnmarshaller.Instance;

            return Invoke<RenewOfferingResponse>(request, options);
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
        public virtual Task<RenewOfferingResponse> RenewOfferingAsync(RenewOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RenewOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenewOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<RenewOfferingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ScheduleRun

        internal virtual ScheduleRunResponse ScheduleRun(ScheduleRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ScheduleRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScheduleRunResponseUnmarshaller.Instance;

            return Invoke<ScheduleRunResponse>(request, options);
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
        public virtual Task<ScheduleRunResponse> ScheduleRunAsync(ScheduleRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ScheduleRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScheduleRunResponseUnmarshaller.Instance;

            return InvokeAsync<ScheduleRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopJob

        internal virtual StopJobResponse StopJob(StopJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopJobResponseUnmarshaller.Instance;

            return Invoke<StopJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopJob">REST API Reference for StopJob Operation</seealso>
        public virtual Task<StopJobResponse> StopJobAsync(StopJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopRemoteAccessSession

        internal virtual StopRemoteAccessSessionResponse StopRemoteAccessSession(StopRemoteAccessSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<StopRemoteAccessSessionResponse>(request, options);
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
        public virtual Task<StopRemoteAccessSessionResponse> StopRemoteAccessSessionAsync(StopRemoteAccessSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRemoteAccessSessionResponseUnmarshaller.Instance;

            return InvokeAsync<StopRemoteAccessSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopRun

        internal virtual StopRunResponse StopRun(StopRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRunResponseUnmarshaller.Instance;

            return Invoke<StopRunResponse>(request, options);
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
        public virtual Task<StopRunResponse> StopRunAsync(StopRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRunResponseUnmarshaller.Instance;

            return InvokeAsync<StopRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDeviceInstance

        internal virtual UpdateDeviceInstanceResponse UpdateDeviceInstance(UpdateDeviceInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateDeviceInstance">REST API Reference for UpdateDeviceInstance Operation</seealso>
        public virtual Task<UpdateDeviceInstanceResponse> UpdateDeviceInstanceAsync(UpdateDeviceInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeviceInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDevicePool

        internal virtual UpdateDevicePoolResponse UpdateDevicePool(UpdateDevicePoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevicePoolResponseUnmarshaller.Instance;

            return Invoke<UpdateDevicePoolResponse>(request, options);
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
        public virtual Task<UpdateDevicePoolResponse> UpdateDevicePoolAsync(UpdateDevicePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevicePoolResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDevicePoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateInstanceProfile

        internal virtual UpdateInstanceProfileResponse UpdateInstanceProfile(UpdateInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceProfileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateInstanceProfile">REST API Reference for UpdateInstanceProfile Operation</seealso>
        public virtual Task<UpdateInstanceProfileResponse> UpdateInstanceProfileAsync(UpdateInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInstanceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNetworkProfile

        internal virtual UpdateNetworkProfileResponse UpdateNetworkProfile(UpdateNetworkProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkProfileResponse>(request, options);
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
        public virtual Task<UpdateNetworkProfileResponse> UpdateNetworkProfileAsync(UpdateNetworkProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNetworkProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProject

        internal virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectResponse>(request, options);
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
        public virtual Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUpload

        internal virtual UpdateUploadResponse UpdateUpload(UpdateUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUploadResponseUnmarshaller.Instance;

            return Invoke<UpdateUploadResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateUpload">REST API Reference for UpdateUpload Operation</seealso>
        public virtual Task<UpdateUploadResponse> UpdateUploadAsync(UpdateUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUploadResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVPCEConfiguration

        internal virtual UpdateVPCEConfigurationResponse UpdateVPCEConfiguration(UpdateVPCEConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVPCEConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateVPCEConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVPCEConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVPCEConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateVPCEConfiguration">REST API Reference for UpdateVPCEConfiguration Operation</seealso>
        public virtual Task<UpdateVPCEConfigurationResponse> UpdateVPCEConfigurationAsync(UpdateVPCEConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVPCEConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVPCEConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}