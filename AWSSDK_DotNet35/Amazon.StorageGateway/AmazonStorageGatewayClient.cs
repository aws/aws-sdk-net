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
    public partial class AmazonStorageGatewayClient : AmazonWebServiceClient, IAmazonStorageGateway
    {
    AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonStorageGatewayConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : this(credentials, new AmazonStorageGatewayConfig{RegionEndpoint = region})
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
        /// AmazonStorageGatewayClient Configuration object. 
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonStorageGatewayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonStorageGatewayClient Configuration object. 
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


        #region ActivateGateway

        /// <summary>
        /// </summary>
        /// 
        /// <param name="activateGatewayRequest">Container for the necessary parameters to execute the ActivateGateway service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ActivateGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public ActivateGatewayResponse ActivateGateway(ActivateGatewayRequest activateGatewayRequest)
        {
            IAsyncResult asyncResult = invokeActivateGateway(activateGatewayRequest, null, null, true);
            return EndActivateGateway(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ActivateGateway"/>
        /// </summary>
        /// 
        /// <param name="activateGatewayRequest">Container for the necessary parameters to execute the ActivateGateway operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateGateway
        ///         operation.</returns>
        public IAsyncResult BeginActivateGateway(ActivateGatewayRequest activateGatewayRequest, AsyncCallback callback, object state)
        {
            return invokeActivateGateway(activateGatewayRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ActivateGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ActivateGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateGateway.</param>
        /// 
        /// <returns>Returns a ActivateGatewayResult from AmazonStorageGateway.</returns>
        public ActivateGatewayResponse EndActivateGateway(IAsyncResult asyncResult)
        {
            return endOperation<ActivateGatewayResponse>(asyncResult);
        }
        
        IAsyncResult invokeActivateGateway(ActivateGatewayRequest activateGatewayRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ActivateGatewayRequestMarshaller().Marshall(activateGatewayRequest);
            var unmarshaller = ActivateGatewayResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AddCache

        /// <summary>
        /// </summary>
        /// 
        /// <param name="addCacheRequest">Container for the necessary parameters to execute the AddCache service method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the AddCache service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public AddCacheResponse AddCache(AddCacheRequest addCacheRequest)
        {
            IAsyncResult asyncResult = invokeAddCache(addCacheRequest, null, null, true);
            return EndAddCache(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AddCache operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddCache"/>
        /// </summary>
        /// 
        /// <param name="addCacheRequest">Container for the necessary parameters to execute the AddCache operation on AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddCache
        ///         operation.</returns>
        public IAsyncResult BeginAddCache(AddCacheRequest addCacheRequest, AsyncCallback callback, object state)
        {
            return invokeAddCache(addCacheRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AddCache operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddCache.</param>
        /// 
        /// <returns>Returns a AddCacheResult from AmazonStorageGateway.</returns>
        public AddCacheResponse EndAddCache(IAsyncResult asyncResult)
        {
            return endOperation<AddCacheResponse>(asyncResult);
        }
        
        IAsyncResult invokeAddCache(AddCacheRequest addCacheRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddCacheRequestMarshaller().Marshall(addCacheRequest);
            var unmarshaller = AddCacheResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AddUploadBuffer

        /// <summary>
        /// </summary>
        /// 
        /// <param name="addUploadBufferRequest">Container for the necessary parameters to execute the AddUploadBuffer service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the AddUploadBuffer service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public AddUploadBufferResponse AddUploadBuffer(AddUploadBufferRequest addUploadBufferRequest)
        {
            IAsyncResult asyncResult = invokeAddUploadBuffer(addUploadBufferRequest, null, null, true);
            return EndAddUploadBuffer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AddUploadBuffer operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddUploadBuffer"/>
        /// </summary>
        /// 
        /// <param name="addUploadBufferRequest">Container for the necessary parameters to execute the AddUploadBuffer operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddUploadBuffer
        ///         operation.</returns>
        public IAsyncResult BeginAddUploadBuffer(AddUploadBufferRequest addUploadBufferRequest, AsyncCallback callback, object state)
        {
            return invokeAddUploadBuffer(addUploadBufferRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AddUploadBuffer operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddUploadBuffer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddUploadBuffer.</param>
        /// 
        /// <returns>Returns a AddUploadBufferResult from AmazonStorageGateway.</returns>
        public AddUploadBufferResponse EndAddUploadBuffer(IAsyncResult asyncResult)
        {
            return endOperation<AddUploadBufferResponse>(asyncResult);
        }
        
        IAsyncResult invokeAddUploadBuffer(AddUploadBufferRequest addUploadBufferRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddUploadBufferRequestMarshaller().Marshall(addUploadBufferRequest);
            var unmarshaller = AddUploadBufferResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AddWorkingStorage

        /// <summary>
        /// </summary>
        /// 
        /// <param name="addWorkingStorageRequest">Container for the necessary parameters to execute the AddWorkingStorage service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the AddWorkingStorage service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public AddWorkingStorageResponse AddWorkingStorage(AddWorkingStorageRequest addWorkingStorageRequest)
        {
            IAsyncResult asyncResult = invokeAddWorkingStorage(addWorkingStorageRequest, null, null, true);
            return EndAddWorkingStorage(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AddWorkingStorage operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddWorkingStorage"/>
        /// </summary>
        /// 
        /// <param name="addWorkingStorageRequest">Container for the necessary parameters to execute the AddWorkingStorage operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddWorkingStorage
        ///         operation.</returns>
        public IAsyncResult BeginAddWorkingStorage(AddWorkingStorageRequest addWorkingStorageRequest, AsyncCallback callback, object state)
        {
            return invokeAddWorkingStorage(addWorkingStorageRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AddWorkingStorage operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddWorkingStorage"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddWorkingStorage.</param>
        /// 
        /// <returns>Returns a AddWorkingStorageResult from AmazonStorageGateway.</returns>
        public AddWorkingStorageResponse EndAddWorkingStorage(IAsyncResult asyncResult)
        {
            return endOperation<AddWorkingStorageResponse>(asyncResult);
        }
        
        IAsyncResult invokeAddWorkingStorage(AddWorkingStorageRequest addWorkingStorageRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddWorkingStorageRequestMarshaller().Marshall(addWorkingStorageRequest);
            var unmarshaller = AddWorkingStorageResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateCachediSCSIVolume

        /// <summary>
        /// </summary>
        /// 
        /// <param name="createCachediSCSIVolumeRequest">Container for the necessary parameters to execute the CreateCachediSCSIVolume service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateCachediSCSIVolume service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public CreateCachediSCSIVolumeResponse CreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest createCachediSCSIVolumeRequest)
        {
            IAsyncResult asyncResult = invokeCreateCachediSCSIVolume(createCachediSCSIVolumeRequest, null, null, true);
            return EndCreateCachediSCSIVolume(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCachediSCSIVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateCachediSCSIVolume"/>
        /// </summary>
        /// 
        /// <param name="createCachediSCSIVolumeRequest">Container for the necessary parameters to execute the CreateCachediSCSIVolume operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateCachediSCSIVolume operation.</returns>
        public IAsyncResult BeginCreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest createCachediSCSIVolumeRequest, AsyncCallback callback, object state)
        {
            return invokeCreateCachediSCSIVolume(createCachediSCSIVolumeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCachediSCSIVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateCachediSCSIVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCachediSCSIVolume.</param>
        /// 
        /// <returns>Returns a CreateCachediSCSIVolumeResult from AmazonStorageGateway.</returns>
        public CreateCachediSCSIVolumeResponse EndCreateCachediSCSIVolume(IAsyncResult asyncResult)
        {
            return endOperation<CreateCachediSCSIVolumeResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest createCachediSCSIVolumeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateCachediSCSIVolumeRequestMarshaller().Marshall(createCachediSCSIVolumeRequest);
            var unmarshaller = CreateCachediSCSIVolumeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateSnapshot

        /// <summary>
        /// </summary>
        /// 
        /// <param name="createSnapshotRequest">Container for the necessary parameters to execute the CreateSnapshot service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest createSnapshotRequest)
        {
            IAsyncResult asyncResult = invokeCreateSnapshot(createSnapshotRequest, null, null, true);
            return EndCreateSnapshot(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateSnapshot"/>
        /// </summary>
        /// 
        /// <param name="createSnapshotRequest">Container for the necessary parameters to execute the CreateSnapshot operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest createSnapshotRequest, AsyncCallback callback, object state)
        {
            return invokeCreateSnapshot(createSnapshotRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a CreateSnapshotResult from AmazonStorageGateway.</returns>
        public CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult)
        {
            return endOperation<CreateSnapshotResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateSnapshot(CreateSnapshotRequest createSnapshotRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateSnapshotRequestMarshaller().Marshall(createSnapshotRequest);
            var unmarshaller = CreateSnapshotResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateSnapshotFromVolumeRecoveryPoint

        /// <summary>
        /// </summary>
        /// 
        /// <param name="createSnapshotFromVolumeRecoveryPointRequest">Container for the necessary parameters to execute the
        ///          CreateSnapshotFromVolumeRecoveryPoint service method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateSnapshotFromVolumeRecoveryPoint service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public CreateSnapshotFromVolumeRecoveryPointResponse CreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest createSnapshotFromVolumeRecoveryPointRequest)
        {
            IAsyncResult asyncResult = invokeCreateSnapshotFromVolumeRecoveryPoint(createSnapshotFromVolumeRecoveryPointRequest, null, null, true);
            return EndCreateSnapshotFromVolumeRecoveryPoint(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotFromVolumeRecoveryPoint operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateSnapshotFromVolumeRecoveryPoint"/>
        /// </summary>
        /// 
        /// <param name="createSnapshotFromVolumeRecoveryPointRequest">Container for the necessary parameters to execute the
        ///          CreateSnapshotFromVolumeRecoveryPoint operation on AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateSnapshotFromVolumeRecoveryPoint operation.</returns>
        public IAsyncResult BeginCreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest createSnapshotFromVolumeRecoveryPointRequest, AsyncCallback callback, object state)
        {
            return invokeCreateSnapshotFromVolumeRecoveryPoint(createSnapshotFromVolumeRecoveryPointRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateSnapshotFromVolumeRecoveryPoint operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateSnapshotFromVolumeRecoveryPoint"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshotFromVolumeRecoveryPoint.</param>
        /// 
        /// <returns>Returns a CreateSnapshotFromVolumeRecoveryPointResult from AmazonStorageGateway.</returns>
        public CreateSnapshotFromVolumeRecoveryPointResponse EndCreateSnapshotFromVolumeRecoveryPoint(IAsyncResult asyncResult)
        {
            return endOperation<CreateSnapshotFromVolumeRecoveryPointResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest createSnapshotFromVolumeRecoveryPointRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateSnapshotFromVolumeRecoveryPointRequestMarshaller().Marshall(createSnapshotFromVolumeRecoveryPointRequest);
            var unmarshaller = CreateSnapshotFromVolumeRecoveryPointResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateStorediSCSIVolume

        /// <summary>
        /// </summary>
        /// 
        /// <param name="createStorediSCSIVolumeRequest">Container for the necessary parameters to execute the CreateStorediSCSIVolume service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateStorediSCSIVolume service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public CreateStorediSCSIVolumeResponse CreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest createStorediSCSIVolumeRequest)
        {
            IAsyncResult asyncResult = invokeCreateStorediSCSIVolume(createStorediSCSIVolumeRequest, null, null, true);
            return EndCreateStorediSCSIVolume(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorediSCSIVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateStorediSCSIVolume"/>
        /// </summary>
        /// 
        /// <param name="createStorediSCSIVolumeRequest">Container for the necessary parameters to execute the CreateStorediSCSIVolume operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateStorediSCSIVolume operation.</returns>
        public IAsyncResult BeginCreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest createStorediSCSIVolumeRequest, AsyncCallback callback, object state)
        {
            return invokeCreateStorediSCSIVolume(createStorediSCSIVolumeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateStorediSCSIVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateStorediSCSIVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStorediSCSIVolume.</param>
        /// 
        /// <returns>Returns a CreateStorediSCSIVolumeResult from AmazonStorageGateway.</returns>
        public CreateStorediSCSIVolumeResponse EndCreateStorediSCSIVolume(IAsyncResult asyncResult)
        {
            return endOperation<CreateStorediSCSIVolumeResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest createStorediSCSIVolumeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateStorediSCSIVolumeRequestMarshaller().Marshall(createStorediSCSIVolumeRequest);
            var unmarshaller = CreateStorediSCSIVolumeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteBandwidthRateLimit

        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteBandwidthRateLimitRequest">Container for the necessary parameters to execute the DeleteBandwidthRateLimit service method
        ///          on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteBandwidthRateLimit service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DeleteBandwidthRateLimitResponse DeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest deleteBandwidthRateLimitRequest)
        {
            IAsyncResult asyncResult = invokeDeleteBandwidthRateLimit(deleteBandwidthRateLimitRequest, null, null, true);
            return EndDeleteBandwidthRateLimit(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="deleteBandwidthRateLimitRequest">Container for the necessary parameters to execute the DeleteBandwidthRateLimit operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteBandwidthRateLimit operation.</returns>
        public IAsyncResult BeginDeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest deleteBandwidthRateLimitRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteBandwidthRateLimit(deleteBandwidthRateLimitRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBandwidthRateLimit.</param>
        /// 
        /// <returns>Returns a DeleteBandwidthRateLimitResult from AmazonStorageGateway.</returns>
        public DeleteBandwidthRateLimitResponse EndDeleteBandwidthRateLimit(IAsyncResult asyncResult)
        {
            return endOperation<DeleteBandwidthRateLimitResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest deleteBandwidthRateLimitRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteBandwidthRateLimitRequestMarshaller().Marshall(deleteBandwidthRateLimitRequest);
            var unmarshaller = DeleteBandwidthRateLimitResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteChapCredentials

        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteChapCredentialsRequest">Container for the necessary parameters to execute the DeleteChapCredentials service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteChapCredentials service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DeleteChapCredentialsResponse DeleteChapCredentials(DeleteChapCredentialsRequest deleteChapCredentialsRequest)
        {
            IAsyncResult asyncResult = invokeDeleteChapCredentials(deleteChapCredentialsRequest, null, null, true);
            return EndDeleteChapCredentials(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="deleteChapCredentialsRequest">Container for the necessary parameters to execute the DeleteChapCredentials operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteChapCredentials operation.</returns>
        public IAsyncResult BeginDeleteChapCredentials(DeleteChapCredentialsRequest deleteChapCredentialsRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteChapCredentials(deleteChapCredentialsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChapCredentials.</param>
        /// 
        /// <returns>Returns a DeleteChapCredentialsResult from AmazonStorageGateway.</returns>
        public DeleteChapCredentialsResponse EndDeleteChapCredentials(IAsyncResult asyncResult)
        {
            return endOperation<DeleteChapCredentialsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteChapCredentials(DeleteChapCredentialsRequest deleteChapCredentialsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteChapCredentialsRequestMarshaller().Marshall(deleteChapCredentialsRequest);
            var unmarshaller = DeleteChapCredentialsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteGateway

        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteGatewayRequest">Container for the necessary parameters to execute the DeleteGateway service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest deleteGatewayRequest)
        {
            IAsyncResult asyncResult = invokeDeleteGateway(deleteGatewayRequest, null, null, true);
            return EndDeleteGateway(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteGateway"/>
        /// </summary>
        /// 
        /// <param name="deleteGatewayRequest">Container for the necessary parameters to execute the DeleteGateway operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGateway
        ///         operation.</returns>
        public IAsyncResult BeginDeleteGateway(DeleteGatewayRequest deleteGatewayRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteGateway(deleteGatewayRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGateway.</param>
        /// 
        /// <returns>Returns a DeleteGatewayResult from AmazonStorageGateway.</returns>
        public DeleteGatewayResponse EndDeleteGateway(IAsyncResult asyncResult)
        {
            return endOperation<DeleteGatewayResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteGateway(DeleteGatewayRequest deleteGatewayRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteGatewayRequestMarshaller().Marshall(deleteGatewayRequest);
            var unmarshaller = DeleteGatewayResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteSnapshotSchedule

        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteSnapshotScheduleRequest">Container for the necessary parameters to execute the DeleteSnapshotSchedule service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteSnapshotSchedule service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest deleteSnapshotScheduleRequest)
        {
            IAsyncResult asyncResult = invokeDeleteSnapshotSchedule(deleteSnapshotScheduleRequest, null, null, true);
            return EndDeleteSnapshotSchedule(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="deleteSnapshotScheduleRequest">Container for the necessary parameters to execute the DeleteSnapshotSchedule operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteSnapshotSchedule operation.</returns>
        public IAsyncResult BeginDeleteSnapshotSchedule(DeleteSnapshotScheduleRequest deleteSnapshotScheduleRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteSnapshotSchedule(deleteSnapshotScheduleRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshotSchedule.</param>
        /// 
        /// <returns>Returns a DeleteSnapshotScheduleResult from AmazonStorageGateway.</returns>
        public DeleteSnapshotScheduleResponse EndDeleteSnapshotSchedule(IAsyncResult asyncResult)
        {
            return endOperation<DeleteSnapshotScheduleResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteSnapshotSchedule(DeleteSnapshotScheduleRequest deleteSnapshotScheduleRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteSnapshotScheduleRequestMarshaller().Marshall(deleteSnapshotScheduleRequest);
            var unmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteVolume

        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteVolumeRequest">Container for the necessary parameters to execute the DeleteVolume service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest deleteVolumeRequest)
        {
            IAsyncResult asyncResult = invokeDeleteVolume(deleteVolumeRequest, null, null, true);
            return EndDeleteVolume(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteVolume"/>
        /// </summary>
        /// 
        /// <param name="deleteVolumeRequest">Container for the necessary parameters to execute the DeleteVolume operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVolume
        ///         operation.</returns>
        public IAsyncResult BeginDeleteVolume(DeleteVolumeRequest deleteVolumeRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteVolume(deleteVolumeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVolume.</param>
        /// 
        /// <returns>Returns a DeleteVolumeResult from AmazonStorageGateway.</returns>
        public DeleteVolumeResponse EndDeleteVolume(IAsyncResult asyncResult)
        {
            return endOperation<DeleteVolumeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteVolume(DeleteVolumeRequest deleteVolumeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteVolumeRequestMarshaller().Marshall(deleteVolumeRequest);
            var unmarshaller = DeleteVolumeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeBandwidthRateLimit

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeBandwidthRateLimitRequest">Container for the necessary parameters to execute the DescribeBandwidthRateLimit service
        ///          method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeBandwidthRateLimit service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DescribeBandwidthRateLimitResponse DescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest describeBandwidthRateLimitRequest)
        {
            IAsyncResult asyncResult = invokeDescribeBandwidthRateLimit(describeBandwidthRateLimitRequest, null, null, true);
            return EndDescribeBandwidthRateLimit(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="describeBandwidthRateLimitRequest">Container for the necessary parameters to execute the DescribeBandwidthRateLimit operation
        ///          on AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeBandwidthRateLimit operation.</returns>
        public IAsyncResult BeginDescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest describeBandwidthRateLimitRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeBandwidthRateLimit(describeBandwidthRateLimitRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBandwidthRateLimit.</param>
        /// 
        /// <returns>Returns a DescribeBandwidthRateLimitResult from AmazonStorageGateway.</returns>
        public DescribeBandwidthRateLimitResponse EndDescribeBandwidthRateLimit(IAsyncResult asyncResult)
        {
            return endOperation<DescribeBandwidthRateLimitResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest describeBandwidthRateLimitRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeBandwidthRateLimitRequestMarshaller().Marshall(describeBandwidthRateLimitRequest);
            var unmarshaller = DescribeBandwidthRateLimitResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeCache

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeCacheRequest">Container for the necessary parameters to execute the DescribeCache service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeCache service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DescribeCacheResponse DescribeCache(DescribeCacheRequest describeCacheRequest)
        {
            IAsyncResult asyncResult = invokeDescribeCache(describeCacheRequest, null, null, true);
            return EndDescribeCache(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCache operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeCache"/>
        /// </summary>
        /// 
        /// <param name="describeCacheRequest">Container for the necessary parameters to execute the DescribeCache operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCache
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCache(DescribeCacheRequest describeCacheRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeCache(describeCacheRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCache operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCache.</param>
        /// 
        /// <returns>Returns a DescribeCacheResult from AmazonStorageGateway.</returns>
        public DescribeCacheResponse EndDescribeCache(IAsyncResult asyncResult)
        {
            return endOperation<DescribeCacheResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeCache(DescribeCacheRequest describeCacheRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeCacheRequestMarshaller().Marshall(describeCacheRequest);
            var unmarshaller = DescribeCacheResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeCachediSCSIVolumes

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeCachediSCSIVolumesRequest">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes service
        ///          method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeCachediSCSIVolumes service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DescribeCachediSCSIVolumesResponse DescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest describeCachediSCSIVolumesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeCachediSCSIVolumes(describeCachediSCSIVolumesRequest, null, null, true);
            return EndDescribeCachediSCSIVolumes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCachediSCSIVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeCachediSCSIVolumes"/>
        /// </summary>
        /// 
        /// <param name="describeCachediSCSIVolumesRequest">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes operation
        ///          on AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCachediSCSIVolumes operation.</returns>
        public IAsyncResult BeginDescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest describeCachediSCSIVolumesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeCachediSCSIVolumes(describeCachediSCSIVolumesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCachediSCSIVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeCachediSCSIVolumes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCachediSCSIVolumes.</param>
        /// 
        /// <returns>Returns a DescribeCachediSCSIVolumesResult from AmazonStorageGateway.</returns>
        public DescribeCachediSCSIVolumesResponse EndDescribeCachediSCSIVolumes(IAsyncResult asyncResult)
        {
            return endOperation<DescribeCachediSCSIVolumesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest describeCachediSCSIVolumesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeCachediSCSIVolumesRequestMarshaller().Marshall(describeCachediSCSIVolumesRequest);
            var unmarshaller = DescribeCachediSCSIVolumesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeChapCredentials

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeChapCredentialsRequest">Container for the necessary parameters to execute the DescribeChapCredentials service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeChapCredentials service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DescribeChapCredentialsResponse DescribeChapCredentials(DescribeChapCredentialsRequest describeChapCredentialsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeChapCredentials(describeChapCredentialsRequest, null, null, true);
            return EndDescribeChapCredentials(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="describeChapCredentialsRequest">Container for the necessary parameters to execute the DescribeChapCredentials operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeChapCredentials operation.</returns>
        public IAsyncResult BeginDescribeChapCredentials(DescribeChapCredentialsRequest describeChapCredentialsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeChapCredentials(describeChapCredentialsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChapCredentials.</param>
        /// 
        /// <returns>Returns a DescribeChapCredentialsResult from AmazonStorageGateway.</returns>
        public DescribeChapCredentialsResponse EndDescribeChapCredentials(IAsyncResult asyncResult)
        {
            return endOperation<DescribeChapCredentialsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeChapCredentials(DescribeChapCredentialsRequest describeChapCredentialsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeChapCredentialsRequestMarshaller().Marshall(describeChapCredentialsRequest);
            var unmarshaller = DescribeChapCredentialsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeGatewayInformation

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeGatewayInformationRequest">Container for the necessary parameters to execute the DescribeGatewayInformation service
        ///          method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeGatewayInformation service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DescribeGatewayInformationResponse DescribeGatewayInformation(DescribeGatewayInformationRequest describeGatewayInformationRequest)
        {
            IAsyncResult asyncResult = invokeDescribeGatewayInformation(describeGatewayInformationRequest, null, null, true);
            return EndDescribeGatewayInformation(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGatewayInformation operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeGatewayInformation"/>
        /// </summary>
        /// 
        /// <param name="describeGatewayInformationRequest">Container for the necessary parameters to execute the DescribeGatewayInformation operation
        ///          on AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeGatewayInformation operation.</returns>
        public IAsyncResult BeginDescribeGatewayInformation(DescribeGatewayInformationRequest describeGatewayInformationRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeGatewayInformation(describeGatewayInformationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeGatewayInformation operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeGatewayInformation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGatewayInformation.</param>
        /// 
        /// <returns>Returns a DescribeGatewayInformationResult from AmazonStorageGateway.</returns>
        public DescribeGatewayInformationResponse EndDescribeGatewayInformation(IAsyncResult asyncResult)
        {
            return endOperation<DescribeGatewayInformationResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeGatewayInformation(DescribeGatewayInformationRequest describeGatewayInformationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeGatewayInformationRequestMarshaller().Marshall(describeGatewayInformationRequest);
            var unmarshaller = DescribeGatewayInformationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeMaintenanceStartTime

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeMaintenanceStartTimeRequest">Container for the necessary parameters to execute the DescribeMaintenanceStartTime service
        ///          method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceStartTime service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DescribeMaintenanceStartTimeResponse DescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest describeMaintenanceStartTimeRequest)
        {
            IAsyncResult asyncResult = invokeDescribeMaintenanceStartTime(describeMaintenanceStartTimeRequest, null, null, true);
            return EndDescribeMaintenanceStartTime(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMaintenanceStartTime operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeMaintenanceStartTime"/>
        /// </summary>
        /// 
        /// <param name="describeMaintenanceStartTimeRequest">Container for the necessary parameters to execute the DescribeMaintenanceStartTime
        ///          operation on AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeMaintenanceStartTime operation.</returns>
        public IAsyncResult BeginDescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest describeMaintenanceStartTimeRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeMaintenanceStartTime(describeMaintenanceStartTimeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeMaintenanceStartTime operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeMaintenanceStartTime"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceStartTime.</param>
        /// 
        /// <returns>Returns a DescribeMaintenanceStartTimeResult from AmazonStorageGateway.</returns>
        public DescribeMaintenanceStartTimeResponse EndDescribeMaintenanceStartTime(IAsyncResult asyncResult)
        {
            return endOperation<DescribeMaintenanceStartTimeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest describeMaintenanceStartTimeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeMaintenanceStartTimeRequestMarshaller().Marshall(describeMaintenanceStartTimeRequest);
            var unmarshaller = DescribeMaintenanceStartTimeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeSnapshotSchedule

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeSnapshotScheduleRequest">Container for the necessary parameters to execute the DescribeSnapshotSchedule service method
        ///          on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotSchedule service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DescribeSnapshotScheduleResponse DescribeSnapshotSchedule(DescribeSnapshotScheduleRequest describeSnapshotScheduleRequest)
        {
            IAsyncResult asyncResult = invokeDescribeSnapshotSchedule(describeSnapshotScheduleRequest, null, null, true);
            return EndDescribeSnapshotSchedule(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="describeSnapshotScheduleRequest">Container for the necessary parameters to execute the DescribeSnapshotSchedule operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSnapshotSchedule operation.</returns>
        public IAsyncResult BeginDescribeSnapshotSchedule(DescribeSnapshotScheduleRequest describeSnapshotScheduleRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeSnapshotSchedule(describeSnapshotScheduleRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshotSchedule.</param>
        /// 
        /// <returns>Returns a DescribeSnapshotScheduleResult from AmazonStorageGateway.</returns>
        public DescribeSnapshotScheduleResponse EndDescribeSnapshotSchedule(IAsyncResult asyncResult)
        {
            return endOperation<DescribeSnapshotScheduleResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeSnapshotSchedule(DescribeSnapshotScheduleRequest describeSnapshotScheduleRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeSnapshotScheduleRequestMarshaller().Marshall(describeSnapshotScheduleRequest);
            var unmarshaller = DescribeSnapshotScheduleResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeStorediSCSIVolumes

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeStorediSCSIVolumesRequest">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes service
        ///          method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeStorediSCSIVolumes service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DescribeStorediSCSIVolumesResponse DescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest describeStorediSCSIVolumesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeStorediSCSIVolumes(describeStorediSCSIVolumesRequest, null, null, true);
            return EndDescribeStorediSCSIVolumes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStorediSCSIVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeStorediSCSIVolumes"/>
        /// </summary>
        /// 
        /// <param name="describeStorediSCSIVolumesRequest">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes operation
        ///          on AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeStorediSCSIVolumes operation.</returns>
        public IAsyncResult BeginDescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest describeStorediSCSIVolumesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeStorediSCSIVolumes(describeStorediSCSIVolumesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStorediSCSIVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeStorediSCSIVolumes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStorediSCSIVolumes.</param>
        /// 
        /// <returns>Returns a DescribeStorediSCSIVolumesResult from AmazonStorageGateway.</returns>
        public DescribeStorediSCSIVolumesResponse EndDescribeStorediSCSIVolumes(IAsyncResult asyncResult)
        {
            return endOperation<DescribeStorediSCSIVolumesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest describeStorediSCSIVolumesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeStorediSCSIVolumesRequestMarshaller().Marshall(describeStorediSCSIVolumesRequest);
            var unmarshaller = DescribeStorediSCSIVolumesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeUploadBuffer

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeUploadBufferRequest">Container for the necessary parameters to execute the DescribeUploadBuffer service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeUploadBuffer service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DescribeUploadBufferResponse DescribeUploadBuffer(DescribeUploadBufferRequest describeUploadBufferRequest)
        {
            IAsyncResult asyncResult = invokeDescribeUploadBuffer(describeUploadBufferRequest, null, null, true);
            return EndDescribeUploadBuffer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUploadBuffer operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeUploadBuffer"/>
        /// </summary>
        /// 
        /// <param name="describeUploadBufferRequest">Container for the necessary parameters to execute the DescribeUploadBuffer operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeUploadBuffer operation.</returns>
        public IAsyncResult BeginDescribeUploadBuffer(DescribeUploadBufferRequest describeUploadBufferRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeUploadBuffer(describeUploadBufferRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeUploadBuffer operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeUploadBuffer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUploadBuffer.</param>
        /// 
        /// <returns>Returns a DescribeUploadBufferResult from AmazonStorageGateway.</returns>
        public DescribeUploadBufferResponse EndDescribeUploadBuffer(IAsyncResult asyncResult)
        {
            return endOperation<DescribeUploadBufferResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeUploadBuffer(DescribeUploadBufferRequest describeUploadBufferRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeUploadBufferRequestMarshaller().Marshall(describeUploadBufferRequest);
            var unmarshaller = DescribeUploadBufferResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeWorkingStorage

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeWorkingStorageRequest">Container for the necessary parameters to execute the DescribeWorkingStorage service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeWorkingStorage service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public DescribeWorkingStorageResponse DescribeWorkingStorage(DescribeWorkingStorageRequest describeWorkingStorageRequest)
        {
            IAsyncResult asyncResult = invokeDescribeWorkingStorage(describeWorkingStorageRequest, null, null, true);
            return EndDescribeWorkingStorage(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkingStorage operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeWorkingStorage"/>
        /// </summary>
        /// 
        /// <param name="describeWorkingStorageRequest">Container for the necessary parameters to execute the DescribeWorkingStorage operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeWorkingStorage operation.</returns>
        public IAsyncResult BeginDescribeWorkingStorage(DescribeWorkingStorageRequest describeWorkingStorageRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeWorkingStorage(describeWorkingStorageRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeWorkingStorage operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeWorkingStorage"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkingStorage.</param>
        /// 
        /// <returns>Returns a DescribeWorkingStorageResult from AmazonStorageGateway.</returns>
        public DescribeWorkingStorageResponse EndDescribeWorkingStorage(IAsyncResult asyncResult)
        {
            return endOperation<DescribeWorkingStorageResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeWorkingStorage(DescribeWorkingStorageRequest describeWorkingStorageRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeWorkingStorageRequestMarshaller().Marshall(describeWorkingStorageRequest);
            var unmarshaller = DescribeWorkingStorageResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListGateways

        /// <summary>
        /// </summary>
        /// 
        /// <param name="listGatewaysRequest">Container for the necessary parameters to execute the ListGateways service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public ListGatewaysResponse ListGateways(ListGatewaysRequest listGatewaysRequest)
        {
            IAsyncResult asyncResult = invokeListGateways(listGatewaysRequest, null, null, true);
            return EndListGateways(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListGateways operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListGateways"/>
        /// </summary>
        /// 
        /// <param name="listGatewaysRequest">Container for the necessary parameters to execute the ListGateways operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGateways
        ///         operation.</returns>
        public IAsyncResult BeginListGateways(ListGatewaysRequest listGatewaysRequest, AsyncCallback callback, object state)
        {
            return invokeListGateways(listGatewaysRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListGateways operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListGateways"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGateways.</param>
        /// 
        /// <returns>Returns a ListGatewaysResult from AmazonStorageGateway.</returns>
        public ListGatewaysResponse EndListGateways(IAsyncResult asyncResult)
        {
            return endOperation<ListGatewaysResponse>(asyncResult);
        }
        
        IAsyncResult invokeListGateways(ListGatewaysRequest listGatewaysRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListGatewaysRequestMarshaller().Marshall(listGatewaysRequest);
            var unmarshaller = ListGatewaysResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// </summary>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public ListGatewaysResponse ListGateways()
        {
            return ListGateways(new ListGatewaysRequest());
        }
        

        #endregion
    
        #region ListLocalDisks

        /// <summary>
        /// </summary>
        /// 
        /// <param name="listLocalDisksRequest">Container for the necessary parameters to execute the ListLocalDisks service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListLocalDisks service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public ListLocalDisksResponse ListLocalDisks(ListLocalDisksRequest listLocalDisksRequest)
        {
            IAsyncResult asyncResult = invokeListLocalDisks(listLocalDisksRequest, null, null, true);
            return EndListLocalDisks(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListLocalDisks operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListLocalDisks"/>
        /// </summary>
        /// 
        /// <param name="listLocalDisksRequest">Container for the necessary parameters to execute the ListLocalDisks operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLocalDisks
        ///         operation.</returns>
        public IAsyncResult BeginListLocalDisks(ListLocalDisksRequest listLocalDisksRequest, AsyncCallback callback, object state)
        {
            return invokeListLocalDisks(listLocalDisksRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListLocalDisks operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListLocalDisks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLocalDisks.</param>
        /// 
        /// <returns>Returns a ListLocalDisksResult from AmazonStorageGateway.</returns>
        public ListLocalDisksResponse EndListLocalDisks(IAsyncResult asyncResult)
        {
            return endOperation<ListLocalDisksResponse>(asyncResult);
        }
        
        IAsyncResult invokeListLocalDisks(ListLocalDisksRequest listLocalDisksRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListLocalDisksRequestMarshaller().Marshall(listLocalDisksRequest);
            var unmarshaller = ListLocalDisksResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListVolumeRecoveryPoints

        /// <summary>
        /// </summary>
        /// 
        /// <param name="listVolumeRecoveryPointsRequest">Container for the necessary parameters to execute the ListVolumeRecoveryPoints service method
        ///          on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListVolumeRecoveryPoints service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public ListVolumeRecoveryPointsResponse ListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest listVolumeRecoveryPointsRequest)
        {
            IAsyncResult asyncResult = invokeListVolumeRecoveryPoints(listVolumeRecoveryPointsRequest, null, null, true);
            return EndListVolumeRecoveryPoints(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumeRecoveryPoints operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListVolumeRecoveryPoints"/>
        /// </summary>
        /// 
        /// <param name="listVolumeRecoveryPointsRequest">Container for the necessary parameters to execute the ListVolumeRecoveryPoints operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListVolumeRecoveryPoints operation.</returns>
        public IAsyncResult BeginListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest listVolumeRecoveryPointsRequest, AsyncCallback callback, object state)
        {
            return invokeListVolumeRecoveryPoints(listVolumeRecoveryPointsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListVolumeRecoveryPoints operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListVolumeRecoveryPoints"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVolumeRecoveryPoints.</param>
        /// 
        /// <returns>Returns a ListVolumeRecoveryPointsResult from AmazonStorageGateway.</returns>
        public ListVolumeRecoveryPointsResponse EndListVolumeRecoveryPoints(IAsyncResult asyncResult)
        {
            return endOperation<ListVolumeRecoveryPointsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest listVolumeRecoveryPointsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListVolumeRecoveryPointsRequestMarshaller().Marshall(listVolumeRecoveryPointsRequest);
            var unmarshaller = ListVolumeRecoveryPointsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListVolumes

        /// <summary>
        /// </summary>
        /// 
        /// <param name="listVolumesRequest">Container for the necessary parameters to execute the ListVolumes service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListVolumes service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public ListVolumesResponse ListVolumes(ListVolumesRequest listVolumesRequest)
        {
            IAsyncResult asyncResult = invokeListVolumes(listVolumesRequest, null, null, true);
            return EndListVolumes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListVolumes"/>
        /// </summary>
        /// 
        /// <param name="listVolumesRequest">Container for the necessary parameters to execute the ListVolumes operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVolumes
        ///         operation.</returns>
        public IAsyncResult BeginListVolumes(ListVolumesRequest listVolumesRequest, AsyncCallback callback, object state)
        {
            return invokeListVolumes(listVolumesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListVolumes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVolumes.</param>
        /// 
        /// <returns>Returns a ListVolumesResult from AmazonStorageGateway.</returns>
        public ListVolumesResponse EndListVolumes(IAsyncResult asyncResult)
        {
            return endOperation<ListVolumesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListVolumes(ListVolumesRequest listVolumesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListVolumesRequestMarshaller().Marshall(listVolumesRequest);
            var unmarshaller = ListVolumesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ShutdownGateway

        /// <summary>
        /// </summary>
        /// 
        /// <param name="shutdownGatewayRequest">Container for the necessary parameters to execute the ShutdownGateway service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ShutdownGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public ShutdownGatewayResponse ShutdownGateway(ShutdownGatewayRequest shutdownGatewayRequest)
        {
            IAsyncResult asyncResult = invokeShutdownGateway(shutdownGatewayRequest, null, null, true);
            return EndShutdownGateway(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ShutdownGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ShutdownGateway"/>
        /// </summary>
        /// 
        /// <param name="shutdownGatewayRequest">Container for the necessary parameters to execute the ShutdownGateway operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndShutdownGateway
        ///         operation.</returns>
        public IAsyncResult BeginShutdownGateway(ShutdownGatewayRequest shutdownGatewayRequest, AsyncCallback callback, object state)
        {
            return invokeShutdownGateway(shutdownGatewayRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ShutdownGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ShutdownGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginShutdownGateway.</param>
        /// 
        /// <returns>Returns a ShutdownGatewayResult from AmazonStorageGateway.</returns>
        public ShutdownGatewayResponse EndShutdownGateway(IAsyncResult asyncResult)
        {
            return endOperation<ShutdownGatewayResponse>(asyncResult);
        }
        
        IAsyncResult invokeShutdownGateway(ShutdownGatewayRequest shutdownGatewayRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ShutdownGatewayRequestMarshaller().Marshall(shutdownGatewayRequest);
            var unmarshaller = ShutdownGatewayResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region StartGateway

        /// <summary>
        /// </summary>
        /// 
        /// <param name="startGatewayRequest">Container for the necessary parameters to execute the StartGateway service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the StartGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public StartGatewayResponse StartGateway(StartGatewayRequest startGatewayRequest)
        {
            IAsyncResult asyncResult = invokeStartGateway(startGatewayRequest, null, null, true);
            return EndStartGateway(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the StartGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.StartGateway"/>
        /// </summary>
        /// 
        /// <param name="startGatewayRequest">Container for the necessary parameters to execute the StartGateway operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartGateway
        ///         operation.</returns>
        public IAsyncResult BeginStartGateway(StartGatewayRequest startGatewayRequest, AsyncCallback callback, object state)
        {
            return invokeStartGateway(startGatewayRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the StartGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.StartGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartGateway.</param>
        /// 
        /// <returns>Returns a StartGatewayResult from AmazonStorageGateway.</returns>
        public StartGatewayResponse EndStartGateway(IAsyncResult asyncResult)
        {
            return endOperation<StartGatewayResponse>(asyncResult);
        }
        
        IAsyncResult invokeStartGateway(StartGatewayRequest startGatewayRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new StartGatewayRequestMarshaller().Marshall(startGatewayRequest);
            var unmarshaller = StartGatewayResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateBandwidthRateLimit

        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateBandwidthRateLimitRequest">Container for the necessary parameters to execute the UpdateBandwidthRateLimit service method
        ///          on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateBandwidthRateLimit service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public UpdateBandwidthRateLimitResponse UpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest updateBandwidthRateLimitRequest)
        {
            IAsyncResult asyncResult = invokeUpdateBandwidthRateLimit(updateBandwidthRateLimitRequest, null, null, true);
            return EndUpdateBandwidthRateLimit(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="updateBandwidthRateLimitRequest">Container for the necessary parameters to execute the UpdateBandwidthRateLimit operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateBandwidthRateLimit operation.</returns>
        public IAsyncResult BeginUpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest updateBandwidthRateLimitRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateBandwidthRateLimit(updateBandwidthRateLimitRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBandwidthRateLimit.</param>
        /// 
        /// <returns>Returns a UpdateBandwidthRateLimitResult from AmazonStorageGateway.</returns>
        public UpdateBandwidthRateLimitResponse EndUpdateBandwidthRateLimit(IAsyncResult asyncResult)
        {
            return endOperation<UpdateBandwidthRateLimitResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest updateBandwidthRateLimitRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateBandwidthRateLimitRequestMarshaller().Marshall(updateBandwidthRateLimitRequest);
            var unmarshaller = UpdateBandwidthRateLimitResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateChapCredentials

        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateChapCredentialsRequest">Container for the necessary parameters to execute the UpdateChapCredentials service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateChapCredentials service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public UpdateChapCredentialsResponse UpdateChapCredentials(UpdateChapCredentialsRequest updateChapCredentialsRequest)
        {
            IAsyncResult asyncResult = invokeUpdateChapCredentials(updateChapCredentialsRequest, null, null, true);
            return EndUpdateChapCredentials(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="updateChapCredentialsRequest">Container for the necessary parameters to execute the UpdateChapCredentials operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateChapCredentials operation.</returns>
        public IAsyncResult BeginUpdateChapCredentials(UpdateChapCredentialsRequest updateChapCredentialsRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateChapCredentials(updateChapCredentialsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChapCredentials.</param>
        /// 
        /// <returns>Returns a UpdateChapCredentialsResult from AmazonStorageGateway.</returns>
        public UpdateChapCredentialsResponse EndUpdateChapCredentials(IAsyncResult asyncResult)
        {
            return endOperation<UpdateChapCredentialsResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateChapCredentials(UpdateChapCredentialsRequest updateChapCredentialsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateChapCredentialsRequestMarshaller().Marshall(updateChapCredentialsRequest);
            var unmarshaller = UpdateChapCredentialsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateGatewayInformation

        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateGatewayInformationRequest">Container for the necessary parameters to execute the UpdateGatewayInformation service method
        ///          on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateGatewayInformation service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public UpdateGatewayInformationResponse UpdateGatewayInformation(UpdateGatewayInformationRequest updateGatewayInformationRequest)
        {
            IAsyncResult asyncResult = invokeUpdateGatewayInformation(updateGatewayInformationRequest, null, null, true);
            return EndUpdateGatewayInformation(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayInformation operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateGatewayInformation"/>
        /// </summary>
        /// 
        /// <param name="updateGatewayInformationRequest">Container for the necessary parameters to execute the UpdateGatewayInformation operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateGatewayInformation operation.</returns>
        public IAsyncResult BeginUpdateGatewayInformation(UpdateGatewayInformationRequest updateGatewayInformationRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateGatewayInformation(updateGatewayInformationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateGatewayInformation operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateGatewayInformation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewayInformation.</param>
        /// 
        /// <returns>Returns a UpdateGatewayInformationResult from AmazonStorageGateway.</returns>
        public UpdateGatewayInformationResponse EndUpdateGatewayInformation(IAsyncResult asyncResult)
        {
            return endOperation<UpdateGatewayInformationResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateGatewayInformation(UpdateGatewayInformationRequest updateGatewayInformationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateGatewayInformationRequestMarshaller().Marshall(updateGatewayInformationRequest);
            var unmarshaller = UpdateGatewayInformationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateGatewaySoftwareNow

        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateGatewaySoftwareNowRequest">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow service method
        ///          on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateGatewaySoftwareNow service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public UpdateGatewaySoftwareNowResponse UpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest updateGatewaySoftwareNowRequest)
        {
            IAsyncResult asyncResult = invokeUpdateGatewaySoftwareNow(updateGatewaySoftwareNowRequest, null, null, true);
            return EndUpdateGatewaySoftwareNow(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewaySoftwareNow operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateGatewaySoftwareNow"/>
        /// </summary>
        /// 
        /// <param name="updateGatewaySoftwareNowRequest">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateGatewaySoftwareNow operation.</returns>
        public IAsyncResult BeginUpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest updateGatewaySoftwareNowRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateGatewaySoftwareNow(updateGatewaySoftwareNowRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateGatewaySoftwareNow operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateGatewaySoftwareNow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewaySoftwareNow.</param>
        /// 
        /// <returns>Returns a UpdateGatewaySoftwareNowResult from AmazonStorageGateway.</returns>
        public UpdateGatewaySoftwareNowResponse EndUpdateGatewaySoftwareNow(IAsyncResult asyncResult)
        {
            return endOperation<UpdateGatewaySoftwareNowResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest updateGatewaySoftwareNowRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateGatewaySoftwareNowRequestMarshaller().Marshall(updateGatewaySoftwareNowRequest);
            var unmarshaller = UpdateGatewaySoftwareNowResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateMaintenanceStartTime

        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateMaintenanceStartTimeRequest">Container for the necessary parameters to execute the UpdateMaintenanceStartTime service
        ///          method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateMaintenanceStartTime service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public UpdateMaintenanceStartTimeResponse UpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest updateMaintenanceStartTimeRequest)
        {
            IAsyncResult asyncResult = invokeUpdateMaintenanceStartTime(updateMaintenanceStartTimeRequest, null, null, true);
            return EndUpdateMaintenanceStartTime(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMaintenanceStartTime operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateMaintenanceStartTime"/>
        /// </summary>
        /// 
        /// <param name="updateMaintenanceStartTimeRequest">Container for the necessary parameters to execute the UpdateMaintenanceStartTime operation
        ///          on AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateMaintenanceStartTime operation.</returns>
        public IAsyncResult BeginUpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest updateMaintenanceStartTimeRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateMaintenanceStartTime(updateMaintenanceStartTimeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateMaintenanceStartTime operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateMaintenanceStartTime"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMaintenanceStartTime.</param>
        /// 
        /// <returns>Returns a UpdateMaintenanceStartTimeResult from AmazonStorageGateway.</returns>
        public UpdateMaintenanceStartTimeResponse EndUpdateMaintenanceStartTime(IAsyncResult asyncResult)
        {
            return endOperation<UpdateMaintenanceStartTimeResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest updateMaintenanceStartTimeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateMaintenanceStartTimeRequestMarshaller().Marshall(updateMaintenanceStartTimeRequest);
            var unmarshaller = UpdateMaintenanceStartTimeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateSnapshotSchedule

        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateSnapshotScheduleRequest">Container for the necessary parameters to execute the UpdateSnapshotSchedule service method on
        ///          AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateSnapshotSchedule service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="InvalidGatewayRequestException"/>
        public UpdateSnapshotScheduleResponse UpdateSnapshotSchedule(UpdateSnapshotScheduleRequest updateSnapshotScheduleRequest)
        {
            IAsyncResult asyncResult = invokeUpdateSnapshotSchedule(updateSnapshotScheduleRequest, null, null, true);
            return EndUpdateSnapshotSchedule(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="updateSnapshotScheduleRequest">Container for the necessary parameters to execute the UpdateSnapshotSchedule operation on
        ///          AmazonStorageGateway.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateSnapshotSchedule operation.</returns>
        public IAsyncResult BeginUpdateSnapshotSchedule(UpdateSnapshotScheduleRequest updateSnapshotScheduleRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateSnapshotSchedule(updateSnapshotScheduleRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSnapshotSchedule.</param>
        /// 
        /// <returns>Returns a UpdateSnapshotScheduleResult from AmazonStorageGateway.</returns>
        public UpdateSnapshotScheduleResponse EndUpdateSnapshotSchedule(IAsyncResult asyncResult)
        {
            return endOperation<UpdateSnapshotScheduleResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateSnapshotSchedule(UpdateSnapshotScheduleRequest updateSnapshotScheduleRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateSnapshotScheduleRequestMarshaller().Marshall(updateSnapshotScheduleRequest);
            var unmarshaller = UpdateSnapshotScheduleResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
