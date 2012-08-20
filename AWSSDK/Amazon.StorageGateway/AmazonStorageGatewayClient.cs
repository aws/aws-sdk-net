/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// AWS Storage Gateway Service <para>AWS Storage Gateway is a service that connects an on-premises software appliance with cloud-based storage
    /// to provide seamless and secure integration between an organization's on-premises IT environment and AWS's storage infrastructure. The
    /// service enables you to securely upload data to the AWS cloud for cost effective backup and rapid disaster recovery.</para> <para>Use the
    /// following links to get started using the <i>AWS Storage Gateway Service API Reference</i> :</para>
    /// <ul>
    /// <li> Actions: An alphabetical list of all AWS Storage Gateway actions.</li>
    /// <li> Common Parameters: Parameters that all Query actions can use.</li>
    /// <li> Common Errors: Client and server errors that all actions can return.</li>
    /// <li> Regions and Endpoints: Itemized regions and endpoints for all AWS products.</li>
    /// <li> WSDL Location: http://storagegateway.us-east-1.amazonaws.com/doc/2012-04-15/AWSStorageGatewayService.wsdl</li>
    /// 
    /// </ul>
    /// </summary>
    public class AmazonStorageGatewayClient : AmazonWebServiceClient, AmazonStorageGateway
    {
    
        AbstractAWSSigner signer = new AWS4Signer();

        #region Constructors

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with the credentials defined in the App.config.
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonStorageGatewayConfig(), true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with the credentials defined in the App.config.
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
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonStorageGatewayClient(AWSCredentials credentials)
            : this(credentials, new AmazonStorageGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Credentials and an
        /// AmazonStorageGatewayClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonStorageGatewayClient Configuration Object</param>
        public AmazonStorageGatewayClient(AWSCredentials credentials, AmazonStorageGatewayConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User)
        {
        }
        

        #endregion
   
        #region DescribeBandwidthRateLimit

        /// <summary>
        /// <para>This operation returns the bandwidth rate limits of a gateway. By default, these limits are not set, which means no bandwidth rate
        /// limiting is in effect.</para> <para>This operation only returns a value for a bandwidth rate limit only if the limit is set. If no limits
        /// are set for the gateway, then this operation returns only the gateway ARN in the response body. To specify which gateway to describe, use
        /// the Amazon Resource Name (ARN) of the gateway in your request.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeBandwidthRateLimit"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeBandwidthRateLimit"/>
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
    
        #region ShutdownGateway

        /// <summary>
        /// <para>This operation shuts down a gateway. To specify which gateway to shut down, use the Amazon Resource Name (ARN) of the gateway in the
        /// body of your request.</para> <para>The operation shuts down the gateway service component running in the storage gateway's virtual machine
        /// (VM) and not the VM.</para> <para><b>NOTE:</b>If you want to shut down the VM, it is recommended that you first shut down the gateway
        /// component in the VM to avoid unpredictable conditions.</para> <para>After the gateway is shutdown, you cannot call any other API except
        /// StartGateway, DescribeGatewayInformation, and ListGateways. For more information, see ActivateGateway. Your applications cannot read from or
        /// write to the gateway's storage volumes, and there are no snapshots taken.</para> <para><b>NOTE:</b>When you make a shutdown request, you
        /// will get a 200 OK success response immediately. However, it might take some time for the gateway to shut down. You can call the
        /// DescribeGatewayInformation API to check the status. For more information, see ActivateGateway.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.ShutdownGateway"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.ShutdownGateway"/>
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
    
        #region CreateSnapshot

        /// <summary>
        /// <para>This operation initiates a snapshot of a volume.</para> <para>AWS Storage Gateway provides the ability to back up point-in-time
        /// snapshots of your data to Amazon Simple Storage (S3) for durable off-site recovery, as well as import the data to an Amazon Elastic Block
        /// Store (EBS) volume in Amazon Elastic Compute Cloud (EC2). You can take snapshots of your gateway volume on a scheduled or ad-hoc basis. This
        /// API enables you to take ad-hoc snapshot. For more information, see Working With Snapshots in the AWS Storage Gateway Console.</para>
        /// <para>In the CreateSnapshot request you identify the volume by providing it's Amazon Resource Name (ARN). You must also provide description
        /// for the snapshot. When AWS Storage Gateway takes the snapshot of specified volume, the snapshot and description appears in the Amazon EC2
        /// console. In response, AWS Storage Gateway returns you a snapshot ID. You can use this snapshot ID to check the snapshot progress or later
        /// use it when you want to create a volume from a snapshot.</para> <para><b>NOTE:</b>To list or delete a snapshot, you must use the Amazon EC2
        /// API. For more information, go to DeleteSnapshot and DescribeSnapshots in the Amazon Elastic Compute Cloud API Reference.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.CreateSnapshot"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.CreateSnapshot"/>
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
    
        #region DeleteVolume

        /// <summary>
        /// <para>This operation delete the specified gateway volume that you previously created using the CreateStorediSCSIVolume API. The gateway
        /// local disk that was configured as the storage volume is not deleted. You can reuse the local disk to create another storage volume.</para>
        /// <para>Before you delete a gateway volume, make sure there are no iSCSI connections to the volume you are deleting. You should also make sure
        /// there is no snapshot in progress. You can use the Amazon Elastic Compute Cloud (EC2) API to query snapshots on the volume you are deleting
        /// and check the snapshot status. For more information, go to DescribeSnapshots in the <i>Amazon Elastic Compute Cloud API Reference</i>
        /// .</para> <para>In the request, you must provide the Amazon Resource Name (ARN) of the storage volume you want to delete.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DeleteVolume"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DeleteVolume"/>
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
    
        #region UpdateMaintenanceStartTime

        /// <summary>
        /// <para>This operation updates a gateway's weekly maintenance start time information, including day and time of the week. The maintenance time
        /// is the time in your gateway's time zone.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.UpdateMaintenanceStartTime"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.UpdateMaintenanceStartTime"/>
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
    
        #region DescribeGatewayInformation

        /// <summary>
        /// <para>This operation returns metadata about a gateway such as its name, network interfaces, configured time zone, and the state (whether the
        /// gateway is running or not). To specify which gateway to describe, use the Amazon Resource Name (ARN) of the gateway in your request.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeGatewayInformation"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeGatewayInformation"/>
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
    
        #region CreateStorediSCSIVolume

        /// <summary>
        /// <para>This operation creates a volume on a specified gateway. The size of the volume is inferred from the disk size. You can choose to
        /// preserve existing data on the disk, create volume from an existing snapshot, or create an empty volume. If you choose to create an empty
        /// gateway volume, then any existing data on the disk is erased.</para> <para>In the request you must specify the gateway and the disk
        /// information on which you are creating the volume. In response, AWS Storage Gateway creates the volume and returns volume information such as
        /// the volume ARN, size and the iSCSI target ARN that initiators can use to connect to the volume target.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.CreateStorediSCSIVolume"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.CreateStorediSCSIVolume"/>
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
    
        #region UpdateChapCredentials

        /// <summary>
        /// <para>This operation updates the Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified iSCSI target. By default, a
        /// gateway does not have CHAP enabled; however, for added security, you might use it.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.UpdateChapCredentials"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.UpdateChapCredentials"/>
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
    
        #region StartGateway

        /// <summary>
        /// <para>This operation starts a gateway that you previously shut down (see ShutdownGateway). After the gateway starts, you can then make other
        /// API calls, your applications can read from or write to the gateway's storage volumes and you will be able to take snapshot backups.</para>
        /// <para><b>NOTE:</b>When you make a request, you will get a 200 OK success response immediately. However, it might take some time for the
        /// gateway to be ready. You should call DescribeGatewayInformation and check the status before making any additional API calls. For more
        /// information, see ActivateGateway.</para> <para>To specify which gateway to start, use the Amazon Resource Name (ARN) of the gateway in your
        /// request.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.StartGateway"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.StartGateway"/>
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
    
        #region DeleteBandwidthRateLimit

        /// <summary>
        /// <para>This operation deletes the bandwidth rate limits of a gateway. You can delete either the upload and download bandwidth rate limit, or
        /// you can delete both. If you delete only one of the limits, the other limit remains unchanged. To specify which gateway to work with, use the
        /// Amazon Resource Name (ARN) of the gateway in your request.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DeleteBandwidthRateLimit"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DeleteBandwidthRateLimit"/>
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
    
        #region UpdateSnapshotSchedule

        /// <summary>
        /// <para>This operation updates a snapshot schedule configured for a gateway volume.</para> <para>The default snapshot schedule for volume is
        /// once every 24 hours, starting at the creation time of the volume. You can use this API to change the snaphot schedule configured for the
        /// volume.</para> <para>In the request you must identify the gateway volume whose snapshot schedule you want to update, and the schedule
        /// information, including when you want the snapshot to begin on a day and the frequency (in hours) of snapshots.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.UpdateSnapshotSchedule"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.UpdateSnapshotSchedule"/>
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
    
        #region DescribeMaintenanceStartTime

        /// <summary>
        /// <para>This operation returns your gateway's weekly maintenance start time including the day and time of the week. Note that values are in
        /// terms of the gateway's time zone.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeMaintenanceStartTime"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeMaintenanceStartTime"/>
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
        /// <para>This operation describes the snapshot schedule for the specified gateway volume. The snapshot schedule information includes intervals
        /// at which snapshots are automatically initiated on the volume.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeSnapshotSchedule"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeSnapshotSchedule"/>
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
    
        #region UpdateBandwidthRateLimit

        /// <summary>
        /// <para>This operation updates the bandwidth rate limits of a gateway. You can update both the upload and download bandwidth rate limit or
        /// specify only one of the two. If you don't set a bandwidth rate limit, the existing rate limit remains.</para> <para>By default, a gateway's
        /// bandwidth rate limits are not set. If you don't set any limit, the gateway does not have any limitations on its bandwidth usage and could
        /// potentially use the maximum available bandwidth.</para> <para>To specify which gateway to update, use the Amazon Resource Name (ARN) of the
        /// gateway in your request.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.UpdateBandwidthRateLimit"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.UpdateBandwidthRateLimit"/>
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
    
        #region DeleteChapCredentials

        /// <summary>
        /// <para>This operation deletes Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified iSCSI target and initiator
        /// pair.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DeleteChapCredentials"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DeleteChapCredentials"/>
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
    
        #region DescribeStorediSCSIVolumes

        /// <summary>
        /// <para>This operation returns description of the gateway volumes specified in the request. The list of gateway volumes in the request must be
        /// from one gateway. In the response Amazon Storage Gateway returns volume information sorted by volume ARNs.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeStorediSCSIVolumes"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeStorediSCSIVolumes"/>
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
    
        #region UpdateGatewayInformation

        /// <summary>
        /// <para>This operation updates a gateway's metadata, which includes the gateway's name and time zone. To specify which gateway to update, use
        /// the Amazon Resource Name (ARN) of the gateway in your request.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.UpdateGatewayInformation"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.UpdateGatewayInformation"/>
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
    
        #region DeleteGateway

        /// <summary>
        /// <para>This operation deletes a gateway. To specify which gateway to delete, use the Amazon Resource Name (ARN) of the gateway in your
        /// request. The operation deletes the gateway; however, it does not delete the gateway virtual machine (VM) from your host computer.</para>
        /// <para>After you delete a gateway, you cannot reactivate it. Completed snapshots of the gateway volumes are not deleted upon deleting the
        /// gateway, however, pending snapshots will not complete. After you delete a gateway, your next step is to remove it from your
        /// environment.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DeleteGateway"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DeleteGateway"/>
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
    
        #region ListVolumes

        /// <summary>
        /// <para>This operation lists the iSCSI stored volumes of a gateway. Results are sorted by volume ARN. The response includes only the volume
        /// ARNs. If you want additional volume information, use the DescribeStorediSCSIVolumes API.</para> <para>The operation supports pagination. By
        /// default, the operation returns a maximum of up to 100 volumes. You can optionally specify the <c>Limit</c> field in the body to limit the
        /// number of volumes in the response. If the number of volumes returned in the response is truncated, the response includes a Marker field. You
        /// can use this Marker value in your subsequent request to retrieve the next set of volumes.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.ListVolumes"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.ListVolumes"/>
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
    
        #region ListLocalDisks

        /// <summary>
        /// <para>This operation returns a list of the local disks of a gateway. To specify which gateway to describe you use the Amazon Resource Name
        /// (ARN) of the gateway in the body of the request.</para> <para>The request returns all disks, specifying which are configured as working
        /// storage, stored volume or not configured at all.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.ListLocalDisks"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.ListLocalDisks"/>
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
    
        #region DescribeChapCredentials

        /// <summary>
        /// <para>This operation returns an array of Challenge-Handshake Authentication Protocol (CHAP) credentials information for a specified iSCSI
        /// target, one for each target-initiator pair.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeChapCredentials"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeChapCredentials"/>
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
    
        #region UpdateGatewaySoftwareNow

        /// <summary>
        /// <para>This operation updates the gateway virtual machine (VM) software. The request immediately triggers the software update. Before
        /// initiating this update, make sure there is no traffic to the gateway.</para> <para>Before sending this request, you should make sure all
        /// your applications have finished writing to your gateway's storage volumes in order to avoid data loss. During the update, applications
        /// cannot use the gateway's storage volumes.</para> <para><b>NOTE:</b>When you make this request, you get a 200 OK success response
        /// immediately. However, it might take some time for the update to complete. You can call DescribeGatewayInformation to verify the gateway is
        /// in the STATE_RUNNING state.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.UpdateGatewaySoftwareNow"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.UpdateGatewaySoftwareNow"/>
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
    
        #region ListGateways

        /// <summary>
        /// <para>This operation lists gateways owned by an AWS account in a region specified in the request. The returned list is ordered by gateway
        /// Amazon Resource Name (ARN).</para> <para>By default, the operation returns a maximum of 100 gateways. This operation supports pagination
        /// that allows you to optionally reduce the number of gateways returned in a response.</para> <para>If you have more gateways than are returned
        /// in a response-that is, the response returns only a truncated list of your gateways-the response contains a marker that you can specify in
        /// your next request to fetch the next page of gateways.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.ListGateways"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.ListGateways"/>
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
        /// <para>This operation lists gateways owned by an AWS account in a region specified in the request. The returned list is ordered by gateway
        /// Amazon Resource Name (ARN).</para> <para>By default, the operation returns a maximum of 100 gateways. This operation supports pagination
        /// that allows you to optionally reduce the number of gateways returned in a response.</para> <para>If you have more gateways than are returned
        /// in a response-that is, the response returns only a truncated list of your gateways-the response contains a marker that you can specify in
        /// your next request to fetch the next page of gateways.</para>
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
    
        #region DescribeWorkingStorage

        /// <summary>
        /// <para>This operation returns information about the working storage of a gateway. The response includes disk IDs that are configured as
        /// working storage, and it includes the amount of working storage allocated and used.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeWorkingStorage"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeWorkingStorage"/>
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
    
        #region AddWorkingStorage

        /// <summary>
        /// <para>This operation configures one or more gateway local disks as working storage.</para> <para>In the request, you specify the gateway
        /// Amazon Resource Name (ARN) to which you want to add working storage, and one or more disk IDs that you want to configure as working
        /// storage.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.AddWorkingStorage"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.AddWorkingStorage"/>
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
    
        #region ActivateGateway

        /// <summary>
        /// <para>This operation activates the gateway you previously deployed on your VMware host. For more information, see DownloadAndDeploy. In the
        /// activation process you specify information such as the region you want to use for storing snapshots, the time zone for scheduled snapshots
        /// and the gateway schedule window, an activation key, and a name for your gateway. The activation process also associates your gateway with
        /// your account.</para> <para><b>NOTE:</b>You must power on the gateway VM before you can activate your gateway.</para>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.ActivateGateway"/>
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
        /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.ActivateGateway"/>
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
    
    }
}
    
