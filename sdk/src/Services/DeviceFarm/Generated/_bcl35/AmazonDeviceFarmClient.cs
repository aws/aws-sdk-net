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

        /// <summary>
        /// Creates a device pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDevicePool service method.</param>
        /// 
        /// <returns>The response from the CreateDevicePool service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateDevicePool">REST API Reference for CreateDevicePool Operation</seealso>
        public CreateDevicePoolResponse CreateDevicePool(CreateDevicePoolRequest request)
        {
            var marshaller = new CreateDevicePoolRequestMarshaller();
            var unmarshaller = CreateDevicePoolResponseUnmarshaller.Instance;

            return Invoke<CreateDevicePoolRequest,CreateDevicePoolResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDevicePool operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDevicePool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateDevicePool">REST API Reference for CreateDevicePool Operation</seealso>
        public IAsyncResult BeginCreateDevicePool(CreateDevicePoolRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDevicePoolRequestMarshaller();
            var unmarshaller = CreateDevicePoolResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDevicePoolRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDevicePool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDevicePool.</param>
        /// 
        /// <returns>Returns a  CreateDevicePoolResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateDevicePool">REST API Reference for CreateDevicePool Operation</seealso>
        public  CreateDevicePoolResponse EndCreateDevicePool(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDevicePoolResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNetworkProfile

        /// <summary>
        /// Creates a network profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkProfile service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkProfile service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateNetworkProfile">REST API Reference for CreateNetworkProfile Operation</seealso>
        public CreateNetworkProfileResponse CreateNetworkProfile(CreateNetworkProfileRequest request)
        {
            var marshaller = new CreateNetworkProfileRequestMarshaller();
            var unmarshaller = CreateNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkProfileRequest,CreateNetworkProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkProfile operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateNetworkProfile">REST API Reference for CreateNetworkProfile Operation</seealso>
        public IAsyncResult BeginCreateNetworkProfile(CreateNetworkProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateNetworkProfileRequestMarshaller();
            var unmarshaller = CreateNetworkProfileResponseUnmarshaller.Instance;

            return BeginInvoke<CreateNetworkProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkProfile.</param>
        /// 
        /// <returns>Returns a  CreateNetworkProfileResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateNetworkProfile">REST API Reference for CreateNetworkProfile Operation</seealso>
        public  CreateNetworkProfileResponse EndCreateNetworkProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNetworkProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProject

        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="name">The project's name.</param>
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
        public CreateProjectResponse CreateProject(string name)
        {
            var request = new CreateProjectRequest();
            request.Name = name;
            return CreateProject(request);
        }


        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
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
        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var marshaller = new CreateProjectRequestMarshaller();
            var unmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectRequest,CreateProjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateProjectRequestMarshaller();
            var unmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return BeginInvoke<CreateProjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public  CreateProjectResponse EndCreateProject(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRemoteAccessSession

        /// <summary>
        /// Specifies and starts a remote access session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRemoteAccessSession service method.</param>
        /// 
        /// <returns>The response from the CreateRemoteAccessSession service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateRemoteAccessSession">REST API Reference for CreateRemoteAccessSession Operation</seealso>
        public CreateRemoteAccessSessionResponse CreateRemoteAccessSession(CreateRemoteAccessSessionRequest request)
        {
            var marshaller = new CreateRemoteAccessSessionRequestMarshaller();
            var unmarshaller = CreateRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<CreateRemoteAccessSessionRequest,CreateRemoteAccessSessionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRemoteAccessSession operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRemoteAccessSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateRemoteAccessSession">REST API Reference for CreateRemoteAccessSession Operation</seealso>
        public IAsyncResult BeginCreateRemoteAccessSession(CreateRemoteAccessSessionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateRemoteAccessSessionRequestMarshaller();
            var unmarshaller = CreateRemoteAccessSessionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateRemoteAccessSessionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRemoteAccessSession.</param>
        /// 
        /// <returns>Returns a  CreateRemoteAccessSessionResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateRemoteAccessSession">REST API Reference for CreateRemoteAccessSession Operation</seealso>
        public  CreateRemoteAccessSessionResponse EndCreateRemoteAccessSession(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRemoteAccessSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUpload

        /// <summary>
        /// Uploads an app or test scripts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUpload service method.</param>
        /// 
        /// <returns>The response from the CreateUpload service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateUpload">REST API Reference for CreateUpload Operation</seealso>
        public CreateUploadResponse CreateUpload(CreateUploadRequest request)
        {
            var marshaller = new CreateUploadRequestMarshaller();
            var unmarshaller = CreateUploadResponseUnmarshaller.Instance;

            return Invoke<CreateUploadRequest,CreateUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUpload operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateUpload">REST API Reference for CreateUpload Operation</seealso>
        public IAsyncResult BeginCreateUpload(CreateUploadRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateUploadRequestMarshaller();
            var unmarshaller = CreateUploadResponseUnmarshaller.Instance;

            return BeginInvoke<CreateUploadRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUpload.</param>
        /// 
        /// <returns>Returns a  CreateUploadResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateUpload">REST API Reference for CreateUpload Operation</seealso>
        public  CreateUploadResponse EndCreateUpload(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUploadResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDevicePool

        /// <summary>
        /// Deletes a device pool given the pool ARN. Does not allow deletion of curated pools
        /// owned by the system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevicePool service method.</param>
        /// 
        /// <returns>The response from the DeleteDevicePool service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteDevicePool">REST API Reference for DeleteDevicePool Operation</seealso>
        public DeleteDevicePoolResponse DeleteDevicePool(DeleteDevicePoolRequest request)
        {
            var marshaller = new DeleteDevicePoolRequestMarshaller();
            var unmarshaller = DeleteDevicePoolResponseUnmarshaller.Instance;

            return Invoke<DeleteDevicePoolRequest,DeleteDevicePoolResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevicePool operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDevicePool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteDevicePool">REST API Reference for DeleteDevicePool Operation</seealso>
        public IAsyncResult BeginDeleteDevicePool(DeleteDevicePoolRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDevicePoolRequestMarshaller();
            var unmarshaller = DeleteDevicePoolResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDevicePoolRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDevicePool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDevicePool.</param>
        /// 
        /// <returns>Returns a  DeleteDevicePoolResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteDevicePool">REST API Reference for DeleteDevicePool Operation</seealso>
        public  DeleteDevicePoolResponse EndDeleteDevicePool(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDevicePoolResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNetworkProfile

        /// <summary>
        /// Deletes a network profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkProfile service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteNetworkProfile">REST API Reference for DeleteNetworkProfile Operation</seealso>
        public DeleteNetworkProfileResponse DeleteNetworkProfile(DeleteNetworkProfileRequest request)
        {
            var marshaller = new DeleteNetworkProfileRequestMarshaller();
            var unmarshaller = DeleteNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkProfileRequest,DeleteNetworkProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkProfile operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteNetworkProfile">REST API Reference for DeleteNetworkProfile Operation</seealso>
        public IAsyncResult BeginDeleteNetworkProfile(DeleteNetworkProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteNetworkProfileRequestMarshaller();
            var unmarshaller = DeleteNetworkProfileResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteNetworkProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkProfile.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkProfileResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteNetworkProfile">REST API Reference for DeleteNetworkProfile Operation</seealso>
        public  DeleteNetworkProfileResponse EndDeleteNetworkProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNetworkProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProject

        /// <summary>
        /// Deletes an AWS Device Farm project, given the project ARN.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> Deleting this resource does not stop an in-progress run.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var marshaller = new DeleteProjectRequestMarshaller();
            var unmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectRequest,DeleteProjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteProjectRequestMarshaller();
            var unmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteProjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProject.</param>
        /// 
        /// <returns>Returns a  DeleteProjectResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public  DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRemoteAccessSession

        /// <summary>
        /// Deletes a completed remote access session and its results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRemoteAccessSession service method.</param>
        /// 
        /// <returns>The response from the DeleteRemoteAccessSession service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteRemoteAccessSession">REST API Reference for DeleteRemoteAccessSession Operation</seealso>
        public DeleteRemoteAccessSessionResponse DeleteRemoteAccessSession(DeleteRemoteAccessSessionRequest request)
        {
            var marshaller = new DeleteRemoteAccessSessionRequestMarshaller();
            var unmarshaller = DeleteRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<DeleteRemoteAccessSessionRequest,DeleteRemoteAccessSessionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRemoteAccessSession operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRemoteAccessSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteRemoteAccessSession">REST API Reference for DeleteRemoteAccessSession Operation</seealso>
        public IAsyncResult BeginDeleteRemoteAccessSession(DeleteRemoteAccessSessionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteRemoteAccessSessionRequestMarshaller();
            var unmarshaller = DeleteRemoteAccessSessionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRemoteAccessSessionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRemoteAccessSession.</param>
        /// 
        /// <returns>Returns a  DeleteRemoteAccessSessionResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteRemoteAccessSession">REST API Reference for DeleteRemoteAccessSession Operation</seealso>
        public  DeleteRemoteAccessSessionResponse EndDeleteRemoteAccessSession(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRemoteAccessSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRun

        /// <summary>
        /// Deletes the run, given the run ARN.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> Deleting this resource does not stop an in-progress run.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun service method.</param>
        /// 
        /// <returns>The response from the DeleteRun service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteRun">REST API Reference for DeleteRun Operation</seealso>
        public DeleteRunResponse DeleteRun(DeleteRunRequest request)
        {
            var marshaller = new DeleteRunRequestMarshaller();
            var unmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return Invoke<DeleteRunRequest,DeleteRunResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteRun">REST API Reference for DeleteRun Operation</seealso>
        public IAsyncResult BeginDeleteRun(DeleteRunRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteRunRequestMarshaller();
            var unmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRunRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRun.</param>
        /// 
        /// <returns>Returns a  DeleteRunResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteRun">REST API Reference for DeleteRun Operation</seealso>
        public  DeleteRunResponse EndDeleteRun(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRunResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUpload

        /// <summary>
        /// Deletes an upload given the upload ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUpload service method.</param>
        /// 
        /// <returns>The response from the DeleteUpload service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteUpload">REST API Reference for DeleteUpload Operation</seealso>
        public DeleteUploadResponse DeleteUpload(DeleteUploadRequest request)
        {
            var marshaller = new DeleteUploadRequestMarshaller();
            var unmarshaller = DeleteUploadResponseUnmarshaller.Instance;

            return Invoke<DeleteUploadRequest,DeleteUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUpload operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteUpload">REST API Reference for DeleteUpload Operation</seealso>
        public IAsyncResult BeginDeleteUpload(DeleteUploadRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteUploadRequestMarshaller();
            var unmarshaller = DeleteUploadResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteUploadRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUpload.</param>
        /// 
        /// <returns>Returns a  DeleteUploadResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteUpload">REST API Reference for DeleteUpload Operation</seealso>
        public  DeleteUploadResponse EndDeleteUpload(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUploadResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccountSettings

        /// <summary>
        /// Returns the number of unmetered iOS and/or unmetered Android devices that have been
        /// purchased by the account.
        /// </summary>
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
        public GetAccountSettingsResponse GetAccountSettings()
        {
            return GetAccountSettings(new GetAccountSettingsRequest());
        }

        /// <summary>
        /// Returns the number of unmetered iOS and/or unmetered Android devices that have been
        /// purchased by the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
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
        public GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
        {
            var marshaller = new GetAccountSettingsRequestMarshaller();
            var unmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAccountSettingsRequest,GetAccountSettingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public IAsyncResult BeginGetAccountSettings(GetAccountSettingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetAccountSettingsRequestMarshaller();
            var unmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return BeginInvoke<GetAccountSettingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSettings.</param>
        /// 
        /// <returns>Returns a  GetAccountSettingsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public  GetAccountSettingsResponse EndGetAccountSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDevice

        /// <summary>
        /// Gets information about a unique device type.
        /// </summary>
        /// <param name="arn">The device type's ARN.</param>
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
        public GetDeviceResponse GetDevice(string arn)
        {
            var request = new GetDeviceRequest();
            request.Arn = arn;
            return GetDevice(request);
        }


        /// <summary>
        /// Gets information about a unique device type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
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
        public GetDeviceResponse GetDevice(GetDeviceRequest request)
        {
            var marshaller = new GetDeviceRequestMarshaller();
            var unmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return Invoke<GetDeviceRequest,GetDeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevice operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public IAsyncResult BeginGetDevice(GetDeviceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDeviceRequestMarshaller();
            var unmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return BeginInvoke<GetDeviceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevice.</param>
        /// 
        /// <returns>Returns a  GetDeviceResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public  GetDeviceResponse EndGetDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDevicePool

        /// <summary>
        /// Gets information about a device pool.
        /// </summary>
        /// <param name="arn">The device pool's ARN.</param>
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
        public GetDevicePoolResponse GetDevicePool(string arn)
        {
            var request = new GetDevicePoolRequest();
            request.Arn = arn;
            return GetDevicePool(request);
        }


        /// <summary>
        /// Gets information about a device pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePool service method.</param>
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
        public GetDevicePoolResponse GetDevicePool(GetDevicePoolRequest request)
        {
            var marshaller = new GetDevicePoolRequestMarshaller();
            var unmarshaller = GetDevicePoolResponseUnmarshaller.Instance;

            return Invoke<GetDevicePoolRequest,GetDevicePoolResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePool operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevicePool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePool">REST API Reference for GetDevicePool Operation</seealso>
        public IAsyncResult BeginGetDevicePool(GetDevicePoolRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDevicePoolRequestMarshaller();
            var unmarshaller = GetDevicePoolResponseUnmarshaller.Instance;

            return BeginInvoke<GetDevicePoolRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevicePool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevicePool.</param>
        /// 
        /// <returns>Returns a  GetDevicePoolResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePool">REST API Reference for GetDevicePool Operation</seealso>
        public  GetDevicePoolResponse EndGetDevicePool(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDevicePoolResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDevicePoolCompatibility

        /// <summary>
        /// Gets information about compatibility with a device pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePoolCompatibility service method.</param>
        /// 
        /// <returns>The response from the GetDevicePoolCompatibility service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePoolCompatibility">REST API Reference for GetDevicePoolCompatibility Operation</seealso>
        public GetDevicePoolCompatibilityResponse GetDevicePoolCompatibility(GetDevicePoolCompatibilityRequest request)
        {
            var marshaller = new GetDevicePoolCompatibilityRequestMarshaller();
            var unmarshaller = GetDevicePoolCompatibilityResponseUnmarshaller.Instance;

            return Invoke<GetDevicePoolCompatibilityRequest,GetDevicePoolCompatibilityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicePoolCompatibility operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePoolCompatibility operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevicePoolCompatibility
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePoolCompatibility">REST API Reference for GetDevicePoolCompatibility Operation</seealso>
        public IAsyncResult BeginGetDevicePoolCompatibility(GetDevicePoolCompatibilityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDevicePoolCompatibilityRequestMarshaller();
            var unmarshaller = GetDevicePoolCompatibilityResponseUnmarshaller.Instance;

            return BeginInvoke<GetDevicePoolCompatibilityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevicePoolCompatibility operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevicePoolCompatibility.</param>
        /// 
        /// <returns>Returns a  GetDevicePoolCompatibilityResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePoolCompatibility">REST API Reference for GetDevicePoolCompatibility Operation</seealso>
        public  GetDevicePoolCompatibilityResponse EndGetDevicePoolCompatibility(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDevicePoolCompatibilityResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJob

        /// <summary>
        /// Gets information about a job.
        /// </summary>
        /// <param name="arn">The job's ARN.</param>
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
        public GetJobResponse GetJob(string arn)
        {
            var request = new GetJobRequest();
            request.Arn = arn;
            return GetJob(request);
        }


        /// <summary>
        /// Gets information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
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
        public GetJobResponse GetJob(GetJobRequest request)
        {
            var marshaller = new GetJobRequestMarshaller();
            var unmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobRequest,GetJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetJob">REST API Reference for GetJob Operation</seealso>
        public IAsyncResult BeginGetJob(GetJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetJobRequestMarshaller();
            var unmarshaller = GetJobResponseUnmarshaller.Instance;

            return BeginInvoke<GetJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJob.</param>
        /// 
        /// <returns>Returns a  GetJobResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetJob">REST API Reference for GetJob Operation</seealso>
        public  GetJobResponse EndGetJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNetworkProfile

        /// <summary>
        /// Returns information about a network profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkProfile service method.</param>
        /// 
        /// <returns>The response from the GetNetworkProfile service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetNetworkProfile">REST API Reference for GetNetworkProfile Operation</seealso>
        public GetNetworkProfileResponse GetNetworkProfile(GetNetworkProfileRequest request)
        {
            var marshaller = new GetNetworkProfileRequestMarshaller();
            var unmarshaller = GetNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<GetNetworkProfileRequest,GetNetworkProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkProfile operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetNetworkProfile">REST API Reference for GetNetworkProfile Operation</seealso>
        public IAsyncResult BeginGetNetworkProfile(GetNetworkProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetNetworkProfileRequestMarshaller();
            var unmarshaller = GetNetworkProfileResponseUnmarshaller.Instance;

            return BeginInvoke<GetNetworkProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkProfile.</param>
        /// 
        /// <returns>Returns a  GetNetworkProfileResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetNetworkProfile">REST API Reference for GetNetworkProfile Operation</seealso>
        public  GetNetworkProfileResponse EndGetNetworkProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNetworkProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOfferingStatus

        /// <summary>
        /// Gets the current status and future status of all offerings purchased by an AWS account.
        /// The response indicates how many offerings are currently available and the offerings
        /// that will be available in the next period. The API returns a <code>NotEligible</code>
        /// error if the user is not permitted to invoke the operation. Please contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you believe that you should be able to invoke this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOfferingStatus service method.</param>
        /// 
        /// <returns>The response from the GetOfferingStatus service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotEligibleException">
        /// Exception gets thrown when a user is not eligible to perform the specified transaction.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetOfferingStatus">REST API Reference for GetOfferingStatus Operation</seealso>
        public GetOfferingStatusResponse GetOfferingStatus(GetOfferingStatusRequest request)
        {
            var marshaller = new GetOfferingStatusRequestMarshaller();
            var unmarshaller = GetOfferingStatusResponseUnmarshaller.Instance;

            return Invoke<GetOfferingStatusRequest,GetOfferingStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOfferingStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOfferingStatus operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOfferingStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetOfferingStatus">REST API Reference for GetOfferingStatus Operation</seealso>
        public IAsyncResult BeginGetOfferingStatus(GetOfferingStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetOfferingStatusRequestMarshaller();
            var unmarshaller = GetOfferingStatusResponseUnmarshaller.Instance;

            return BeginInvoke<GetOfferingStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOfferingStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOfferingStatus.</param>
        /// 
        /// <returns>Returns a  GetOfferingStatusResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetOfferingStatus">REST API Reference for GetOfferingStatus Operation</seealso>
        public  GetOfferingStatusResponse EndGetOfferingStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOfferingStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProject

        /// <summary>
        /// Gets information about a project.
        /// </summary>
        /// <param name="arn">The project's ARN.</param>
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
        public GetProjectResponse GetProject(string arn)
        {
            var request = new GetProjectRequest();
            request.Arn = arn;
            return GetProject(request);
        }


        /// <summary>
        /// Gets information about a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProject service method.</param>
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
        public GetProjectResponse GetProject(GetProjectRequest request)
        {
            var marshaller = new GetProjectRequestMarshaller();
            var unmarshaller = GetProjectResponseUnmarshaller.Instance;

            return Invoke<GetProjectRequest,GetProjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProject operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetProject">REST API Reference for GetProject Operation</seealso>
        public IAsyncResult BeginGetProject(GetProjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetProjectRequestMarshaller();
            var unmarshaller = GetProjectResponseUnmarshaller.Instance;

            return BeginInvoke<GetProjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProject.</param>
        /// 
        /// <returns>Returns a  GetProjectResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetProject">REST API Reference for GetProject Operation</seealso>
        public  GetProjectResponse EndGetProject(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRemoteAccessSession

        /// <summary>
        /// Returns a link to a currently running remote access session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRemoteAccessSession service method.</param>
        /// 
        /// <returns>The response from the GetRemoteAccessSession service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRemoteAccessSession">REST API Reference for GetRemoteAccessSession Operation</seealso>
        public GetRemoteAccessSessionResponse GetRemoteAccessSession(GetRemoteAccessSessionRequest request)
        {
            var marshaller = new GetRemoteAccessSessionRequestMarshaller();
            var unmarshaller = GetRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<GetRemoteAccessSessionRequest,GetRemoteAccessSessionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRemoteAccessSession operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRemoteAccessSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRemoteAccessSession">REST API Reference for GetRemoteAccessSession Operation</seealso>
        public IAsyncResult BeginGetRemoteAccessSession(GetRemoteAccessSessionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetRemoteAccessSessionRequestMarshaller();
            var unmarshaller = GetRemoteAccessSessionResponseUnmarshaller.Instance;

            return BeginInvoke<GetRemoteAccessSessionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRemoteAccessSession.</param>
        /// 
        /// <returns>Returns a  GetRemoteAccessSessionResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRemoteAccessSession">REST API Reference for GetRemoteAccessSession Operation</seealso>
        public  GetRemoteAccessSessionResponse EndGetRemoteAccessSession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRemoteAccessSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRun

        /// <summary>
        /// Gets information about a run.
        /// </summary>
        /// <param name="arn">The run's ARN.</param>
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
        public GetRunResponse GetRun(string arn)
        {
            var request = new GetRunRequest();
            request.Arn = arn;
            return GetRun(request);
        }


        /// <summary>
        /// Gets information about a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRun service method.</param>
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
        public GetRunResponse GetRun(GetRunRequest request)
        {
            var marshaller = new GetRunRequestMarshaller();
            var unmarshaller = GetRunResponseUnmarshaller.Instance;

            return Invoke<GetRunRequest,GetRunResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRun operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRun">REST API Reference for GetRun Operation</seealso>
        public IAsyncResult BeginGetRun(GetRunRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetRunRequestMarshaller();
            var unmarshaller = GetRunResponseUnmarshaller.Instance;

            return BeginInvoke<GetRunRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRun.</param>
        /// 
        /// <returns>Returns a  GetRunResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRun">REST API Reference for GetRun Operation</seealso>
        public  GetRunResponse EndGetRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRunResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSuite

        /// <summary>
        /// Gets information about a suite.
        /// </summary>
        /// <param name="arn">The suite's ARN.</param>
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
        public GetSuiteResponse GetSuite(string arn)
        {
            var request = new GetSuiteRequest();
            request.Arn = arn;
            return GetSuite(request);
        }


        /// <summary>
        /// Gets information about a suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuite service method.</param>
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
        public GetSuiteResponse GetSuite(GetSuiteRequest request)
        {
            var marshaller = new GetSuiteRequestMarshaller();
            var unmarshaller = GetSuiteResponseUnmarshaller.Instance;

            return Invoke<GetSuiteRequest,GetSuiteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSuite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSuite operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSuite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetSuite">REST API Reference for GetSuite Operation</seealso>
        public IAsyncResult BeginGetSuite(GetSuiteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetSuiteRequestMarshaller();
            var unmarshaller = GetSuiteResponseUnmarshaller.Instance;

            return BeginInvoke<GetSuiteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSuite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSuite.</param>
        /// 
        /// <returns>Returns a  GetSuiteResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetSuite">REST API Reference for GetSuite Operation</seealso>
        public  GetSuiteResponse EndGetSuite(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSuiteResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTest

        /// <summary>
        /// Gets information about a test.
        /// </summary>
        /// <param name="arn">The test's ARN.</param>
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
        public GetTestResponse GetTest(string arn)
        {
            var request = new GetTestRequest();
            request.Arn = arn;
            return GetTest(request);
        }


        /// <summary>
        /// Gets information about a test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTest service method.</param>
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
        public GetTestResponse GetTest(GetTestRequest request)
        {
            var marshaller = new GetTestRequestMarshaller();
            var unmarshaller = GetTestResponseUnmarshaller.Instance;

            return Invoke<GetTestRequest,GetTestResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTest operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetTest">REST API Reference for GetTest Operation</seealso>
        public IAsyncResult BeginGetTest(GetTestRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetTestRequestMarshaller();
            var unmarshaller = GetTestResponseUnmarshaller.Instance;

            return BeginInvoke<GetTestRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTest.</param>
        /// 
        /// <returns>Returns a  GetTestResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetTest">REST API Reference for GetTest Operation</seealso>
        public  GetTestResponse EndGetTest(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTestResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUpload

        /// <summary>
        /// Gets information about an upload.
        /// </summary>
        /// <param name="arn">The upload's ARN.</param>
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
        public GetUploadResponse GetUpload(string arn)
        {
            var request = new GetUploadRequest();
            request.Arn = arn;
            return GetUpload(request);
        }


        /// <summary>
        /// Gets information about an upload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpload service method.</param>
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
        public GetUploadResponse GetUpload(GetUploadRequest request)
        {
            var marshaller = new GetUploadRequestMarshaller();
            var unmarshaller = GetUploadResponseUnmarshaller.Instance;

            return Invoke<GetUploadRequest,GetUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpload operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetUpload">REST API Reference for GetUpload Operation</seealso>
        public IAsyncResult BeginGetUpload(GetUploadRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetUploadRequestMarshaller();
            var unmarshaller = GetUploadResponseUnmarshaller.Instance;

            return BeginInvoke<GetUploadRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUpload.</param>
        /// 
        /// <returns>Returns a  GetUploadResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetUpload">REST API Reference for GetUpload Operation</seealso>
        public  GetUploadResponse EndGetUpload(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUploadResponse>(asyncResult);
        }

        #endregion
        
        #region  InstallToRemoteAccessSession

        /// <summary>
        /// Installs an application to the device in a remote access session. For Android applications,
        /// the file must be in .apk format. For iOS applications, the file must be in .ipa format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InstallToRemoteAccessSession service method.</param>
        /// 
        /// <returns>The response from the InstallToRemoteAccessSession service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/InstallToRemoteAccessSession">REST API Reference for InstallToRemoteAccessSession Operation</seealso>
        public InstallToRemoteAccessSessionResponse InstallToRemoteAccessSession(InstallToRemoteAccessSessionRequest request)
        {
            var marshaller = new InstallToRemoteAccessSessionRequestMarshaller();
            var unmarshaller = InstallToRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<InstallToRemoteAccessSessionRequest,InstallToRemoteAccessSessionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InstallToRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InstallToRemoteAccessSession operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInstallToRemoteAccessSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/InstallToRemoteAccessSession">REST API Reference for InstallToRemoteAccessSession Operation</seealso>
        public IAsyncResult BeginInstallToRemoteAccessSession(InstallToRemoteAccessSessionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new InstallToRemoteAccessSessionRequestMarshaller();
            var unmarshaller = InstallToRemoteAccessSessionResponseUnmarshaller.Instance;

            return BeginInvoke<InstallToRemoteAccessSessionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InstallToRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInstallToRemoteAccessSession.</param>
        /// 
        /// <returns>Returns a  InstallToRemoteAccessSessionResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/InstallToRemoteAccessSession">REST API Reference for InstallToRemoteAccessSession Operation</seealso>
        public  InstallToRemoteAccessSessionResponse EndInstallToRemoteAccessSession(IAsyncResult asyncResult)
        {
            return EndInvoke<InstallToRemoteAccessSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListArtifacts

        /// <summary>
        /// Gets information about artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListArtifacts service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        public ListArtifactsResponse ListArtifacts(ListArtifactsRequest request)
        {
            var marshaller = new ListArtifactsRequestMarshaller();
            var unmarshaller = ListArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListArtifactsRequest,ListArtifactsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListArtifacts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        public IAsyncResult BeginListArtifacts(ListArtifactsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListArtifactsRequestMarshaller();
            var unmarshaller = ListArtifactsResponseUnmarshaller.Instance;

            return BeginInvoke<ListArtifactsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListArtifacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListArtifacts.</param>
        /// 
        /// <returns>Returns a  ListArtifactsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        public  ListArtifactsResponse EndListArtifacts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListArtifactsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDevicePools

        /// <summary>
        /// Gets information about device pools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicePools service method.</param>
        /// 
        /// <returns>The response from the ListDevicePools service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDevicePools">REST API Reference for ListDevicePools Operation</seealso>
        public ListDevicePoolsResponse ListDevicePools(ListDevicePoolsRequest request)
        {
            var marshaller = new ListDevicePoolsRequestMarshaller();
            var unmarshaller = ListDevicePoolsResponseUnmarshaller.Instance;

            return Invoke<ListDevicePoolsRequest,ListDevicePoolsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevicePools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevicePools operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevicePools
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDevicePools">REST API Reference for ListDevicePools Operation</seealso>
        public IAsyncResult BeginListDevicePools(ListDevicePoolsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDevicePoolsRequestMarshaller();
            var unmarshaller = ListDevicePoolsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDevicePoolsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevicePools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevicePools.</param>
        /// 
        /// <returns>Returns a  ListDevicePoolsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDevicePools">REST API Reference for ListDevicePools Operation</seealso>
        public  ListDevicePoolsResponse EndListDevicePools(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevicePoolsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDevices

        /// <summary>
        /// Gets information about unique device types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var marshaller = new ListDevicesRequestMarshaller();
            var unmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesRequest,ListDevicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public IAsyncResult BeginListDevices(ListDevicesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDevicesRequestMarshaller();
            var unmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return BeginInvoke<ListDevicesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevices.</param>
        /// 
        /// <returns>Returns a  ListDevicesResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public  ListDevicesResponse EndListDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJobs

        /// <summary>
        /// Gets information about jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var marshaller = new ListJobsRequestMarshaller();
            var unmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsRequest,ListJobsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListJobsRequestMarshaller();
            var unmarshaller = ListJobsResponseUnmarshaller.Instance;

            return BeginInvoke<ListJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public  ListJobsResponse EndListJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNetworkProfiles

        /// <summary>
        /// Returns the list of available network profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkProfiles service method.</param>
        /// 
        /// <returns>The response from the ListNetworkProfiles service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListNetworkProfiles">REST API Reference for ListNetworkProfiles Operation</seealso>
        public ListNetworkProfilesResponse ListNetworkProfiles(ListNetworkProfilesRequest request)
        {
            var marshaller = new ListNetworkProfilesRequestMarshaller();
            var unmarshaller = ListNetworkProfilesResponseUnmarshaller.Instance;

            return Invoke<ListNetworkProfilesRequest,ListNetworkProfilesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNetworkProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkProfiles operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNetworkProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListNetworkProfiles">REST API Reference for ListNetworkProfiles Operation</seealso>
        public IAsyncResult BeginListNetworkProfiles(ListNetworkProfilesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListNetworkProfilesRequestMarshaller();
            var unmarshaller = ListNetworkProfilesResponseUnmarshaller.Instance;

            return BeginInvoke<ListNetworkProfilesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNetworkProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNetworkProfiles.</param>
        /// 
        /// <returns>Returns a  ListNetworkProfilesResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListNetworkProfiles">REST API Reference for ListNetworkProfiles Operation</seealso>
        public  ListNetworkProfilesResponse EndListNetworkProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNetworkProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOfferingPromotions

        /// <summary>
        /// Returns a list of offering promotions. Each offering promotion record contains the
        /// ID and description of the promotion. The API returns a <code>NotEligible</code> error
        /// if the caller is not permitted to invoke the operation. Contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you believe that you should be able to invoke this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfferingPromotions service method.</param>
        /// 
        /// <returns>The response from the ListOfferingPromotions service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotEligibleException">
        /// Exception gets thrown when a user is not eligible to perform the specified transaction.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferingPromotions">REST API Reference for ListOfferingPromotions Operation</seealso>
        public ListOfferingPromotionsResponse ListOfferingPromotions(ListOfferingPromotionsRequest request)
        {
            var marshaller = new ListOfferingPromotionsRequestMarshaller();
            var unmarshaller = ListOfferingPromotionsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingPromotionsRequest,ListOfferingPromotionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOfferingPromotions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOfferingPromotions operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOfferingPromotions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferingPromotions">REST API Reference for ListOfferingPromotions Operation</seealso>
        public IAsyncResult BeginListOfferingPromotions(ListOfferingPromotionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListOfferingPromotionsRequestMarshaller();
            var unmarshaller = ListOfferingPromotionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListOfferingPromotionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOfferingPromotions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOfferingPromotions.</param>
        /// 
        /// <returns>Returns a  ListOfferingPromotionsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferingPromotions">REST API Reference for ListOfferingPromotions Operation</seealso>
        public  ListOfferingPromotionsResponse EndListOfferingPromotions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOfferingPromotionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOfferings

        /// <summary>
        /// Returns a list of products or offerings that the user can manage through the API.
        /// Each offering record indicates the recurring price per unit and the frequency for
        /// that offering. The API returns a <code>NotEligible</code> error if the user is not
        /// permitted to invoke the operation. Please contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you believe that you should be able to invoke this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings service method.</param>
        /// 
        /// <returns>The response from the ListOfferings service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotEligibleException">
        /// Exception gets thrown when a user is not eligible to perform the specified transaction.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public ListOfferingsResponse ListOfferings(ListOfferingsRequest request)
        {
            var marshaller = new ListOfferingsRequestMarshaller();
            var unmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingsRequest,ListOfferingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public IAsyncResult BeginListOfferings(ListOfferingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListOfferingsRequestMarshaller();
            var unmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return BeginInvoke<ListOfferingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOfferings.</param>
        /// 
        /// <returns>Returns a  ListOfferingsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public  ListOfferingsResponse EndListOfferings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOfferingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOfferingTransactions

        /// <summary>
        /// Returns a list of all historical purchases, renewals, and system renewal transactions
        /// for an AWS account. The list is paginated and ordered by a descending timestamp (most
        /// recent transactions are first). The API returns a <code>NotEligible</code> error if
        /// the user is not permitted to invoke the operation. Please contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you believe that you should be able to invoke this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfferingTransactions service method.</param>
        /// 
        /// <returns>The response from the ListOfferingTransactions service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotEligibleException">
        /// Exception gets thrown when a user is not eligible to perform the specified transaction.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferingTransactions">REST API Reference for ListOfferingTransactions Operation</seealso>
        public ListOfferingTransactionsResponse ListOfferingTransactions(ListOfferingTransactionsRequest request)
        {
            var marshaller = new ListOfferingTransactionsRequestMarshaller();
            var unmarshaller = ListOfferingTransactionsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingTransactionsRequest,ListOfferingTransactionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOfferingTransactions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOfferingTransactions operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOfferingTransactions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferingTransactions">REST API Reference for ListOfferingTransactions Operation</seealso>
        public IAsyncResult BeginListOfferingTransactions(ListOfferingTransactionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListOfferingTransactionsRequestMarshaller();
            var unmarshaller = ListOfferingTransactionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListOfferingTransactionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOfferingTransactions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOfferingTransactions.</param>
        /// 
        /// <returns>Returns a  ListOfferingTransactionsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferingTransactions">REST API Reference for ListOfferingTransactions Operation</seealso>
        public  ListOfferingTransactionsResponse EndListOfferingTransactions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOfferingTransactionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProjects

        /// <summary>
        /// Gets information about projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var marshaller = new ListProjectsRequestMarshaller();
            var unmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsRequest,ListProjectsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListProjectsRequestMarshaller();
            var unmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return BeginInvoke<ListProjectsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjects.</param>
        /// 
        /// <returns>Returns a  ListProjectsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public  ListProjectsResponse EndListProjects(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRemoteAccessSessions

        /// <summary>
        /// Returns a list of all currently running remote access sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRemoteAccessSessions service method.</param>
        /// 
        /// <returns>The response from the ListRemoteAccessSessions service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListRemoteAccessSessions">REST API Reference for ListRemoteAccessSessions Operation</seealso>
        public ListRemoteAccessSessionsResponse ListRemoteAccessSessions(ListRemoteAccessSessionsRequest request)
        {
            var marshaller = new ListRemoteAccessSessionsRequestMarshaller();
            var unmarshaller = ListRemoteAccessSessionsResponseUnmarshaller.Instance;

            return Invoke<ListRemoteAccessSessionsRequest,ListRemoteAccessSessionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRemoteAccessSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRemoteAccessSessions operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRemoteAccessSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListRemoteAccessSessions">REST API Reference for ListRemoteAccessSessions Operation</seealso>
        public IAsyncResult BeginListRemoteAccessSessions(ListRemoteAccessSessionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListRemoteAccessSessionsRequestMarshaller();
            var unmarshaller = ListRemoteAccessSessionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListRemoteAccessSessionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRemoteAccessSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRemoteAccessSessions.</param>
        /// 
        /// <returns>Returns a  ListRemoteAccessSessionsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListRemoteAccessSessions">REST API Reference for ListRemoteAccessSessions Operation</seealso>
        public  ListRemoteAccessSessionsResponse EndListRemoteAccessSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRemoteAccessSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRuns

        /// <summary>
        /// Gets information about runs, given an AWS Device Farm project ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuns service method.</param>
        /// 
        /// <returns>The response from the ListRuns service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListRuns">REST API Reference for ListRuns Operation</seealso>
        public ListRunsResponse ListRuns(ListRunsRequest request)
        {
            var marshaller = new ListRunsRequestMarshaller();
            var unmarshaller = ListRunsResponseUnmarshaller.Instance;

            return Invoke<ListRunsRequest,ListRunsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuns operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListRuns">REST API Reference for ListRuns Operation</seealso>
        public IAsyncResult BeginListRuns(ListRunsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListRunsRequestMarshaller();
            var unmarshaller = ListRunsResponseUnmarshaller.Instance;

            return BeginInvoke<ListRunsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuns.</param>
        /// 
        /// <returns>Returns a  ListRunsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListRuns">REST API Reference for ListRuns Operation</seealso>
        public  ListRunsResponse EndListRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSamples

        /// <summary>
        /// Gets information about samples, given an AWS Device Farm project ARN
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSamples service method.</param>
        /// 
        /// <returns>The response from the ListSamples service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListSamples">REST API Reference for ListSamples Operation</seealso>
        public ListSamplesResponse ListSamples(ListSamplesRequest request)
        {
            var marshaller = new ListSamplesRequestMarshaller();
            var unmarshaller = ListSamplesResponseUnmarshaller.Instance;

            return Invoke<ListSamplesRequest,ListSamplesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSamples operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSamples operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSamples
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListSamples">REST API Reference for ListSamples Operation</seealso>
        public IAsyncResult BeginListSamples(ListSamplesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListSamplesRequestMarshaller();
            var unmarshaller = ListSamplesResponseUnmarshaller.Instance;

            return BeginInvoke<ListSamplesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSamples operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSamples.</param>
        /// 
        /// <returns>Returns a  ListSamplesResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListSamples">REST API Reference for ListSamples Operation</seealso>
        public  ListSamplesResponse EndListSamples(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSamplesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSuites

        /// <summary>
        /// Gets information about suites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuites service method.</param>
        /// 
        /// <returns>The response from the ListSuites service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListSuites">REST API Reference for ListSuites Operation</seealso>
        public ListSuitesResponse ListSuites(ListSuitesRequest request)
        {
            var marshaller = new ListSuitesRequestMarshaller();
            var unmarshaller = ListSuitesResponseUnmarshaller.Instance;

            return Invoke<ListSuitesRequest,ListSuitesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSuites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSuites operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSuites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListSuites">REST API Reference for ListSuites Operation</seealso>
        public IAsyncResult BeginListSuites(ListSuitesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListSuitesRequestMarshaller();
            var unmarshaller = ListSuitesResponseUnmarshaller.Instance;

            return BeginInvoke<ListSuitesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSuites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSuites.</param>
        /// 
        /// <returns>Returns a  ListSuitesResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListSuites">REST API Reference for ListSuites Operation</seealso>
        public  ListSuitesResponse EndListSuites(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSuitesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTests

        /// <summary>
        /// Gets information about tests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTests service method.</param>
        /// 
        /// <returns>The response from the ListTests service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTests">REST API Reference for ListTests Operation</seealso>
        public ListTestsResponse ListTests(ListTestsRequest request)
        {
            var marshaller = new ListTestsRequestMarshaller();
            var unmarshaller = ListTestsResponseUnmarshaller.Instance;

            return Invoke<ListTestsRequest,ListTestsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTests operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTests">REST API Reference for ListTests Operation</seealso>
        public IAsyncResult BeginListTests(ListTestsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTestsRequestMarshaller();
            var unmarshaller = ListTestsResponseUnmarshaller.Instance;

            return BeginInvoke<ListTestsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTests.</param>
        /// 
        /// <returns>Returns a  ListTestsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTests">REST API Reference for ListTests Operation</seealso>
        public  ListTestsResponse EndListTests(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTestsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUniqueProblems

        /// <summary>
        /// Gets information about unique problems.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUniqueProblems service method.</param>
        /// 
        /// <returns>The response from the ListUniqueProblems service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListUniqueProblems">REST API Reference for ListUniqueProblems Operation</seealso>
        public ListUniqueProblemsResponse ListUniqueProblems(ListUniqueProblemsRequest request)
        {
            var marshaller = new ListUniqueProblemsRequestMarshaller();
            var unmarshaller = ListUniqueProblemsResponseUnmarshaller.Instance;

            return Invoke<ListUniqueProblemsRequest,ListUniqueProblemsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUniqueProblems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUniqueProblems operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUniqueProblems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListUniqueProblems">REST API Reference for ListUniqueProblems Operation</seealso>
        public IAsyncResult BeginListUniqueProblems(ListUniqueProblemsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListUniqueProblemsRequestMarshaller();
            var unmarshaller = ListUniqueProblemsResponseUnmarshaller.Instance;

            return BeginInvoke<ListUniqueProblemsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUniqueProblems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUniqueProblems.</param>
        /// 
        /// <returns>Returns a  ListUniqueProblemsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListUniqueProblems">REST API Reference for ListUniqueProblems Operation</seealso>
        public  ListUniqueProblemsResponse EndListUniqueProblems(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUniqueProblemsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUploads

        /// <summary>
        /// Gets information about uploads, given an AWS Device Farm project ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUploads service method.</param>
        /// 
        /// <returns>The response from the ListUploads service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListUploads">REST API Reference for ListUploads Operation</seealso>
        public ListUploadsResponse ListUploads(ListUploadsRequest request)
        {
            var marshaller = new ListUploadsRequestMarshaller();
            var unmarshaller = ListUploadsResponseUnmarshaller.Instance;

            return Invoke<ListUploadsRequest,ListUploadsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUploads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUploads operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUploads
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListUploads">REST API Reference for ListUploads Operation</seealso>
        public IAsyncResult BeginListUploads(ListUploadsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListUploadsRequestMarshaller();
            var unmarshaller = ListUploadsResponseUnmarshaller.Instance;

            return BeginInvoke<ListUploadsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUploads operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUploads.</param>
        /// 
        /// <returns>Returns a  ListUploadsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListUploads">REST API Reference for ListUploads Operation</seealso>
        public  ListUploadsResponse EndListUploads(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUploadsResponse>(asyncResult);
        }

        #endregion
        
        #region  PurchaseOffering

        /// <summary>
        /// Immediately purchases offerings for an AWS account. Offerings renew with the latest
        /// total purchased quantity for an offering, unless the renewal was overridden. The API
        /// returns a <code>NotEligible</code> error if the user is not permitted to invoke the
        /// operation. Please contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you believe that you should be able to invoke this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseOffering service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotEligibleException">
        /// Exception gets thrown when a user is not eligible to perform the specified transaction.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public PurchaseOfferingResponse PurchaseOffering(PurchaseOfferingRequest request)
        {
            var marshaller = new PurchaseOfferingRequestMarshaller();
            var unmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseOfferingRequest,PurchaseOfferingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public IAsyncResult BeginPurchaseOffering(PurchaseOfferingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PurchaseOfferingRequestMarshaller();
            var unmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return BeginInvoke<PurchaseOfferingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseOfferingResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public  PurchaseOfferingResponse EndPurchaseOffering(IAsyncResult asyncResult)
        {
            return EndInvoke<PurchaseOfferingResponse>(asyncResult);
        }

        #endregion
        
        #region  RenewOffering

        /// <summary>
        /// Explicitly sets the quantity of devices to renew for an offering, starting from the
        /// <code>effectiveDate</code> of the next period. The API returns a <code>NotEligible</code>
        /// error if the user is not permitted to invoke the operation. Please contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you believe that you should be able to invoke this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenewOffering service method.</param>
        /// 
        /// <returns>The response from the RenewOffering service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotEligibleException">
        /// Exception gets thrown when a user is not eligible to perform the specified transaction.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/RenewOffering">REST API Reference for RenewOffering Operation</seealso>
        public RenewOfferingResponse RenewOffering(RenewOfferingRequest request)
        {
            var marshaller = new RenewOfferingRequestMarshaller();
            var unmarshaller = RenewOfferingResponseUnmarshaller.Instance;

            return Invoke<RenewOfferingRequest,RenewOfferingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RenewOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenewOffering operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRenewOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/RenewOffering">REST API Reference for RenewOffering Operation</seealso>
        public IAsyncResult BeginRenewOffering(RenewOfferingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RenewOfferingRequestMarshaller();
            var unmarshaller = RenewOfferingResponseUnmarshaller.Instance;

            return BeginInvoke<RenewOfferingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RenewOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRenewOffering.</param>
        /// 
        /// <returns>Returns a  RenewOfferingResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/RenewOffering">REST API Reference for RenewOffering Operation</seealso>
        public  RenewOfferingResponse EndRenewOffering(IAsyncResult asyncResult)
        {
            return EndInvoke<RenewOfferingResponse>(asyncResult);
        }

        #endregion
        
        #region  ScheduleRun

        /// <summary>
        /// Schedules a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScheduleRun service method.</param>
        /// 
        /// <returns>The response from the ScheduleRun service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.IdempotencyException">
        /// An entity with the same name already exists.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ScheduleRun">REST API Reference for ScheduleRun Operation</seealso>
        public ScheduleRunResponse ScheduleRun(ScheduleRunRequest request)
        {
            var marshaller = new ScheduleRunRequestMarshaller();
            var unmarshaller = ScheduleRunResponseUnmarshaller.Instance;

            return Invoke<ScheduleRunRequest,ScheduleRunResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ScheduleRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ScheduleRun operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndScheduleRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ScheduleRun">REST API Reference for ScheduleRun Operation</seealso>
        public IAsyncResult BeginScheduleRun(ScheduleRunRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ScheduleRunRequestMarshaller();
            var unmarshaller = ScheduleRunResponseUnmarshaller.Instance;

            return BeginInvoke<ScheduleRunRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ScheduleRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginScheduleRun.</param>
        /// 
        /// <returns>Returns a  ScheduleRunResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ScheduleRun">REST API Reference for ScheduleRun Operation</seealso>
        public  ScheduleRunResponse EndScheduleRun(IAsyncResult asyncResult)
        {
            return EndInvoke<ScheduleRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StopRemoteAccessSession

        /// <summary>
        /// Ends a specified remote access session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRemoteAccessSession service method.</param>
        /// 
        /// <returns>The response from the StopRemoteAccessSession service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopRemoteAccessSession">REST API Reference for StopRemoteAccessSession Operation</seealso>
        public StopRemoteAccessSessionResponse StopRemoteAccessSession(StopRemoteAccessSessionRequest request)
        {
            var marshaller = new StopRemoteAccessSessionRequestMarshaller();
            var unmarshaller = StopRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<StopRemoteAccessSessionRequest,StopRemoteAccessSessionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopRemoteAccessSession operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopRemoteAccessSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopRemoteAccessSession">REST API Reference for StopRemoteAccessSession Operation</seealso>
        public IAsyncResult BeginStopRemoteAccessSession(StopRemoteAccessSessionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StopRemoteAccessSessionRequestMarshaller();
            var unmarshaller = StopRemoteAccessSessionResponseUnmarshaller.Instance;

            return BeginInvoke<StopRemoteAccessSessionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopRemoteAccessSession.</param>
        /// 
        /// <returns>Returns a  StopRemoteAccessSessionResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopRemoteAccessSession">REST API Reference for StopRemoteAccessSession Operation</seealso>
        public  StopRemoteAccessSessionResponse EndStopRemoteAccessSession(IAsyncResult asyncResult)
        {
            return EndInvoke<StopRemoteAccessSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopRun

        /// <summary>
        /// Initiates a stop request for the current test run. AWS Device Farm will immediately
        /// stop the run on devices where tests have not started executing, and you will not be
        /// billed for these devices. On devices where tests have started executing, Setup Suite
        /// and Teardown Suite tests will run to completion before stopping execution on those
        /// devices. You will be billed for Setup, Teardown, and any tests that were in progress
        /// or already completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRun service method.</param>
        /// 
        /// <returns>The response from the StopRun service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopRun">REST API Reference for StopRun Operation</seealso>
        public StopRunResponse StopRun(StopRunRequest request)
        {
            var marshaller = new StopRunRequestMarshaller();
            var unmarshaller = StopRunResponseUnmarshaller.Instance;

            return Invoke<StopRunRequest,StopRunResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopRun operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopRun">REST API Reference for StopRun Operation</seealso>
        public IAsyncResult BeginStopRun(StopRunRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StopRunRequestMarshaller();
            var unmarshaller = StopRunResponseUnmarshaller.Instance;

            return BeginInvoke<StopRunRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopRun.</param>
        /// 
        /// <returns>Returns a  StopRunResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopRun">REST API Reference for StopRun Operation</seealso>
        public  StopRunResponse EndStopRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StopRunResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDevicePool

        /// <summary>
        /// Modifies the name, description, and rules in a device pool given the attributes and
        /// the pool ARN. Rule updates are all-or-nothing, meaning they can only be updated as
        /// a whole (or not at all).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevicePool service method.</param>
        /// 
        /// <returns>The response from the UpdateDevicePool service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateDevicePool">REST API Reference for UpdateDevicePool Operation</seealso>
        public UpdateDevicePoolResponse UpdateDevicePool(UpdateDevicePoolRequest request)
        {
            var marshaller = new UpdateDevicePoolRequestMarshaller();
            var unmarshaller = UpdateDevicePoolResponseUnmarshaller.Instance;

            return Invoke<UpdateDevicePoolRequest,UpdateDevicePoolResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevicePool operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDevicePool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateDevicePool">REST API Reference for UpdateDevicePool Operation</seealso>
        public IAsyncResult BeginUpdateDevicePool(UpdateDevicePoolRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateDevicePoolRequestMarshaller();
            var unmarshaller = UpdateDevicePoolResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDevicePoolRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDevicePool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDevicePool.</param>
        /// 
        /// <returns>Returns a  UpdateDevicePoolResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateDevicePool">REST API Reference for UpdateDevicePool Operation</seealso>
        public  UpdateDevicePoolResponse EndUpdateDevicePool(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDevicePoolResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNetworkProfile

        /// <summary>
        /// Updates the network profile with specific settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkProfile service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateNetworkProfile">REST API Reference for UpdateNetworkProfile Operation</seealso>
        public UpdateNetworkProfileResponse UpdateNetworkProfile(UpdateNetworkProfileRequest request)
        {
            var marshaller = new UpdateNetworkProfileRequestMarshaller();
            var unmarshaller = UpdateNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkProfileRequest,UpdateNetworkProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkProfile operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNetworkProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateNetworkProfile">REST API Reference for UpdateNetworkProfile Operation</seealso>
        public IAsyncResult BeginUpdateNetworkProfile(UpdateNetworkProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateNetworkProfileRequestMarshaller();
            var unmarshaller = UpdateNetworkProfileResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateNetworkProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNetworkProfile.</param>
        /// 
        /// <returns>Returns a  UpdateNetworkProfileResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateNetworkProfile">REST API Reference for UpdateNetworkProfile Operation</seealso>
        public  UpdateNetworkProfileResponse EndUpdateNetworkProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNetworkProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProject

        /// <summary>
        /// Modifies the specified project name, given the project ARN and a new name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by DeviceFarm.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var marshaller = new UpdateProjectRequestMarshaller();
            var unmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectRequest,UpdateProjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public IAsyncResult BeginUpdateProject(UpdateProjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateProjectRequestMarshaller();
            var unmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateProjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProject.</param>
        /// 
        /// <returns>Returns a  UpdateProjectResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public  UpdateProjectResponse EndUpdateProject(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProjectResponse>(asyncResult);
        }

        #endregion
        
    }
}