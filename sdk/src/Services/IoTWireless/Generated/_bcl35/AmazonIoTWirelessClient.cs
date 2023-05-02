/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTWireless.Model;
using Amazon.IoTWireless.Model.Internal.MarshallTransformations;
using Amazon.IoTWireless.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoTWireless
{
    /// <summary>
    /// Implementation for accessing IoTWireless
    ///
    /// AWS IoT Wireless provides bi-directional communication between internet-connected
    /// wireless devices and the AWS Cloud. To onboard both LoRaWAN and Sidewalk devices to
    /// AWS IoT, use the IoT Wireless API. These wireless devices use the Low Power Wide Area
    /// Networking (LPWAN) communication protocol to communicate with AWS IoT.
    /// 
    ///  
    /// <para>
    /// Using the API, you can perform create, read, update, and delete operations for your
    /// wireless devices, gateways, destinations, and profiles. After onboarding your devices,
    /// you can use the API operations to set log levels and monitor your devices with CloudWatch.
    /// </para>
    ///  
    /// <para>
    /// You can also use the API operations to create multicast groups and schedule a multicast
    /// session for sending a downlink message to devices in the group. By using Firmware
    /// Updates Over-The-Air (FUOTA) API operations, you can create a FUOTA task and schedule
    /// a session to update the firmware of individual devices or an entire group of devices
    /// in a multicast group.
    /// </para>
    /// </summary>
    public partial class AmazonIoTWirelessClient : AmazonServiceClient, IAmazonIoTWireless
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTWirelessMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IIoTWirelessPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIoTWirelessPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IoTWirelessPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with the credentials loaded from the application's
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
        public AmazonIoTWirelessClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTWirelessConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with the credentials loaded from the application's
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
        public AmazonIoTWirelessClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTWirelessConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTWirelessClient Configuration Object</param>
        public AmazonIoTWirelessClient(AmazonIoTWirelessConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTWirelessClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTWirelessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTWirelessClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTWirelessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Credentials and an
        /// AmazonIoTWirelessClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTWirelessClient Configuration Object</param>
        public AmazonIoTWirelessClient(AWSCredentials credentials, AmazonIoTWirelessConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTWirelessClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTWirelessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTWirelessClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTWirelessConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTWirelessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTWirelessClient Configuration Object</param>
        public AmazonIoTWirelessClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTWirelessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTWirelessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTWirelessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTWirelessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTWirelessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTWirelessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTWirelessClient Configuration Object</param>
        public AmazonIoTWirelessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTWirelessConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTWirelessEndpointResolver());
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


        #region  AssociateAwsAccountWithPartnerAccount

        /// <summary>
        /// Associates a partner account with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsAccountWithPartnerAccount service method.</param>
        /// 
        /// <returns>The response from the AssociateAwsAccountWithPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateAwsAccountWithPartnerAccount">REST API Reference for AssociateAwsAccountWithPartnerAccount Operation</seealso>
        public virtual AssociateAwsAccountWithPartnerAccountResponse AssociateAwsAccountWithPartnerAccount(AssociateAwsAccountWithPartnerAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAwsAccountWithPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAwsAccountWithPartnerAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateAwsAccountWithPartnerAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAwsAccountWithPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsAccountWithPartnerAccount operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAwsAccountWithPartnerAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateAwsAccountWithPartnerAccount">REST API Reference for AssociateAwsAccountWithPartnerAccount Operation</seealso>
        public virtual IAsyncResult BeginAssociateAwsAccountWithPartnerAccount(AssociateAwsAccountWithPartnerAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAwsAccountWithPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAwsAccountWithPartnerAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAwsAccountWithPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAwsAccountWithPartnerAccount.</param>
        /// 
        /// <returns>Returns a  AssociateAwsAccountWithPartnerAccountResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateAwsAccountWithPartnerAccount">REST API Reference for AssociateAwsAccountWithPartnerAccount Operation</seealso>
        public virtual AssociateAwsAccountWithPartnerAccountResponse EndAssociateAwsAccountWithPartnerAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateAwsAccountWithPartnerAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateMulticastGroupWithFuotaTask

        /// <summary>
        /// Associate a multicast group with a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMulticastGroupWithFuotaTask service method.</param>
        /// 
        /// <returns>The response from the AssociateMulticastGroupWithFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateMulticastGroupWithFuotaTask">REST API Reference for AssociateMulticastGroupWithFuotaTask Operation</seealso>
        public virtual AssociateMulticastGroupWithFuotaTaskResponse AssociateMulticastGroupWithFuotaTask(AssociateMulticastGroupWithFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateMulticastGroupWithFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMulticastGroupWithFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<AssociateMulticastGroupWithFuotaTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMulticastGroupWithFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMulticastGroupWithFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMulticastGroupWithFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateMulticastGroupWithFuotaTask">REST API Reference for AssociateMulticastGroupWithFuotaTask Operation</seealso>
        public virtual IAsyncResult BeginAssociateMulticastGroupWithFuotaTask(AssociateMulticastGroupWithFuotaTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateMulticastGroupWithFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMulticastGroupWithFuotaTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMulticastGroupWithFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMulticastGroupWithFuotaTask.</param>
        /// 
        /// <returns>Returns a  AssociateMulticastGroupWithFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateMulticastGroupWithFuotaTask">REST API Reference for AssociateMulticastGroupWithFuotaTask Operation</seealso>
        public virtual AssociateMulticastGroupWithFuotaTaskResponse EndAssociateMulticastGroupWithFuotaTask(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateMulticastGroupWithFuotaTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateWirelessDeviceWithFuotaTask

        /// <summary>
        /// Associate a wireless device with a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithFuotaTask service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessDeviceWithFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithFuotaTask">REST API Reference for AssociateWirelessDeviceWithFuotaTask Operation</seealso>
        public virtual AssociateWirelessDeviceWithFuotaTaskResponse AssociateWirelessDeviceWithFuotaTask(AssociateWirelessDeviceWithFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessDeviceWithFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessDeviceWithFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<AssociateWirelessDeviceWithFuotaTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWirelessDeviceWithFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWirelessDeviceWithFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithFuotaTask">REST API Reference for AssociateWirelessDeviceWithFuotaTask Operation</seealso>
        public virtual IAsyncResult BeginAssociateWirelessDeviceWithFuotaTask(AssociateWirelessDeviceWithFuotaTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessDeviceWithFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessDeviceWithFuotaTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWirelessDeviceWithFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWirelessDeviceWithFuotaTask.</param>
        /// 
        /// <returns>Returns a  AssociateWirelessDeviceWithFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithFuotaTask">REST API Reference for AssociateWirelessDeviceWithFuotaTask Operation</seealso>
        public virtual AssociateWirelessDeviceWithFuotaTaskResponse EndAssociateWirelessDeviceWithFuotaTask(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateWirelessDeviceWithFuotaTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateWirelessDeviceWithMulticastGroup

        /// <summary>
        /// Associates a wireless device with a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessDeviceWithMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithMulticastGroup">REST API Reference for AssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        public virtual AssociateWirelessDeviceWithMulticastGroupResponse AssociateWirelessDeviceWithMulticastGroup(AssociateWirelessDeviceWithMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessDeviceWithMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessDeviceWithMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<AssociateWirelessDeviceWithMulticastGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWirelessDeviceWithMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWirelessDeviceWithMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithMulticastGroup">REST API Reference for AssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        public virtual IAsyncResult BeginAssociateWirelessDeviceWithMulticastGroup(AssociateWirelessDeviceWithMulticastGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessDeviceWithMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessDeviceWithMulticastGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWirelessDeviceWithMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWirelessDeviceWithMulticastGroup.</param>
        /// 
        /// <returns>Returns a  AssociateWirelessDeviceWithMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithMulticastGroup">REST API Reference for AssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        public virtual AssociateWirelessDeviceWithMulticastGroupResponse EndAssociateWirelessDeviceWithMulticastGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateWirelessDeviceWithMulticastGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateWirelessDeviceWithThing

        /// <summary>
        /// Associates a wireless device with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithThing service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessDeviceWithThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithThing">REST API Reference for AssociateWirelessDeviceWithThing Operation</seealso>
        public virtual AssociateWirelessDeviceWithThingResponse AssociateWirelessDeviceWithThing(AssociateWirelessDeviceWithThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessDeviceWithThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessDeviceWithThingResponseUnmarshaller.Instance;

            return Invoke<AssociateWirelessDeviceWithThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWirelessDeviceWithThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithThing operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWirelessDeviceWithThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithThing">REST API Reference for AssociateWirelessDeviceWithThing Operation</seealso>
        public virtual IAsyncResult BeginAssociateWirelessDeviceWithThing(AssociateWirelessDeviceWithThingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessDeviceWithThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessDeviceWithThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWirelessDeviceWithThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWirelessDeviceWithThing.</param>
        /// 
        /// <returns>Returns a  AssociateWirelessDeviceWithThingResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithThing">REST API Reference for AssociateWirelessDeviceWithThing Operation</seealso>
        public virtual AssociateWirelessDeviceWithThingResponse EndAssociateWirelessDeviceWithThing(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateWirelessDeviceWithThingResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateWirelessGatewayWithCertificate

        /// <summary>
        /// Associates a wireless gateway with a certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithCertificate service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessGatewayWithCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithCertificate">REST API Reference for AssociateWirelessGatewayWithCertificate Operation</seealso>
        public virtual AssociateWirelessGatewayWithCertificateResponse AssociateWirelessGatewayWithCertificate(AssociateWirelessGatewayWithCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessGatewayWithCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessGatewayWithCertificateResponseUnmarshaller.Instance;

            return Invoke<AssociateWirelessGatewayWithCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWirelessGatewayWithCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithCertificate operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWirelessGatewayWithCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithCertificate">REST API Reference for AssociateWirelessGatewayWithCertificate Operation</seealso>
        public virtual IAsyncResult BeginAssociateWirelessGatewayWithCertificate(AssociateWirelessGatewayWithCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessGatewayWithCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessGatewayWithCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWirelessGatewayWithCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWirelessGatewayWithCertificate.</param>
        /// 
        /// <returns>Returns a  AssociateWirelessGatewayWithCertificateResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithCertificate">REST API Reference for AssociateWirelessGatewayWithCertificate Operation</seealso>
        public virtual AssociateWirelessGatewayWithCertificateResponse EndAssociateWirelessGatewayWithCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateWirelessGatewayWithCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateWirelessGatewayWithThing

        /// <summary>
        /// Associates a wireless gateway with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithThing service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessGatewayWithThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithThing">REST API Reference for AssociateWirelessGatewayWithThing Operation</seealso>
        public virtual AssociateWirelessGatewayWithThingResponse AssociateWirelessGatewayWithThing(AssociateWirelessGatewayWithThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessGatewayWithThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessGatewayWithThingResponseUnmarshaller.Instance;

            return Invoke<AssociateWirelessGatewayWithThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWirelessGatewayWithThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithThing operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWirelessGatewayWithThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithThing">REST API Reference for AssociateWirelessGatewayWithThing Operation</seealso>
        public virtual IAsyncResult BeginAssociateWirelessGatewayWithThing(AssociateWirelessGatewayWithThingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessGatewayWithThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessGatewayWithThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWirelessGatewayWithThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWirelessGatewayWithThing.</param>
        /// 
        /// <returns>Returns a  AssociateWirelessGatewayWithThingResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithThing">REST API Reference for AssociateWirelessGatewayWithThing Operation</seealso>
        public virtual AssociateWirelessGatewayWithThingResponse EndAssociateWirelessGatewayWithThing(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateWirelessGatewayWithThingResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelMulticastGroupSession

        /// <summary>
        /// Cancels an existing multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMulticastGroupSession service method.</param>
        /// 
        /// <returns>The response from the CancelMulticastGroupSession service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CancelMulticastGroupSession">REST API Reference for CancelMulticastGroupSession Operation</seealso>
        public virtual CancelMulticastGroupSessionResponse CancelMulticastGroupSession(CancelMulticastGroupSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMulticastGroupSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMulticastGroupSessionResponseUnmarshaller.Instance;

            return Invoke<CancelMulticastGroupSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelMulticastGroupSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelMulticastGroupSession operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelMulticastGroupSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CancelMulticastGroupSession">REST API Reference for CancelMulticastGroupSession Operation</seealso>
        public virtual IAsyncResult BeginCancelMulticastGroupSession(CancelMulticastGroupSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMulticastGroupSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMulticastGroupSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelMulticastGroupSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelMulticastGroupSession.</param>
        /// 
        /// <returns>Returns a  CancelMulticastGroupSessionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CancelMulticastGroupSession">REST API Reference for CancelMulticastGroupSession Operation</seealso>
        public virtual CancelMulticastGroupSessionResponse EndCancelMulticastGroupSession(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelMulticastGroupSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDestination

        /// <summary>
        /// Creates a new destination that maps a device message to an AWS IoT rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination service method.</param>
        /// 
        /// <returns>The response from the CreateDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        public virtual CreateDestinationResponse CreateDestination(CreateDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        public virtual IAsyncResult BeginCreateDestination(CreateDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDestination.</param>
        /// 
        /// <returns>Returns a  CreateDestinationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        public virtual CreateDestinationResponse EndCreateDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDeviceProfile

        /// <summary>
        /// Creates a new device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDeviceProfile">REST API Reference for CreateDeviceProfile Operation</seealso>
        public virtual CreateDeviceProfileResponse CreateDeviceProfile(CreateDeviceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateDeviceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeviceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDeviceProfile">REST API Reference for CreateDeviceProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateDeviceProfile(CreateDeviceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeviceProfile.</param>
        /// 
        /// <returns>Returns a  CreateDeviceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDeviceProfile">REST API Reference for CreateDeviceProfile Operation</seealso>
        public virtual CreateDeviceProfileResponse EndCreateDeviceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeviceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFuotaTask

        /// <summary>
        /// Creates a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFuotaTask service method.</param>
        /// 
        /// <returns>The response from the CreateFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateFuotaTask">REST API Reference for CreateFuotaTask Operation</seealso>
        public virtual CreateFuotaTaskResponse CreateFuotaTask(CreateFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<CreateFuotaTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateFuotaTask">REST API Reference for CreateFuotaTask Operation</seealso>
        public virtual IAsyncResult BeginCreateFuotaTask(CreateFuotaTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFuotaTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFuotaTask.</param>
        /// 
        /// <returns>Returns a  CreateFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateFuotaTask">REST API Reference for CreateFuotaTask Operation</seealso>
        public virtual CreateFuotaTaskResponse EndCreateFuotaTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFuotaTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMulticastGroup

        /// <summary>
        /// Creates a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the CreateMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateMulticastGroup">REST API Reference for CreateMulticastGroup Operation</seealso>
        public virtual CreateMulticastGroupResponse CreateMulticastGroup(CreateMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<CreateMulticastGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateMulticastGroup">REST API Reference for CreateMulticastGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateMulticastGroup(CreateMulticastGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMulticastGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMulticastGroup.</param>
        /// 
        /// <returns>Returns a  CreateMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateMulticastGroup">REST API Reference for CreateMulticastGroup Operation</seealso>
        public virtual CreateMulticastGroupResponse EndCreateMulticastGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMulticastGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNetworkAnalyzerConfiguration

        /// <summary>
        /// Creates a new network analyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAnalyzerConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkAnalyzerConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateNetworkAnalyzerConfiguration">REST API Reference for CreateNetworkAnalyzerConfiguration Operation</seealso>
        public virtual CreateNetworkAnalyzerConfigurationResponse CreateNetworkAnalyzerConfiguration(CreateNetworkAnalyzerConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkAnalyzerConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAnalyzerConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkAnalyzerConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateNetworkAnalyzerConfiguration">REST API Reference for CreateNetworkAnalyzerConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateNetworkAnalyzerConfiguration(CreateNetworkAnalyzerConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkAnalyzerConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateNetworkAnalyzerConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateNetworkAnalyzerConfiguration">REST API Reference for CreateNetworkAnalyzerConfiguration Operation</seealso>
        public virtual CreateNetworkAnalyzerConfigurationResponse EndCreateNetworkAnalyzerConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNetworkAnalyzerConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateServiceProfile

        /// <summary>
        /// Creates a new service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateServiceProfile">REST API Reference for CreateServiceProfile Operation</seealso>
        public virtual CreateServiceProfileResponse CreateServiceProfile(CreateServiceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateServiceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateServiceProfile">REST API Reference for CreateServiceProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateServiceProfile(CreateServiceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServiceProfile.</param>
        /// 
        /// <returns>Returns a  CreateServiceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateServiceProfile">REST API Reference for CreateServiceProfile Operation</seealso>
        public virtual CreateServiceProfileResponse EndCreateServiceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateServiceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWirelessDevice

        /// <summary>
        /// Provisions a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessDevice">REST API Reference for CreateWirelessDevice Operation</seealso>
        public virtual CreateWirelessDeviceResponse CreateWirelessDevice(CreateWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<CreateWirelessDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessDevice">REST API Reference for CreateWirelessDevice Operation</seealso>
        public virtual IAsyncResult BeginCreateWirelessDevice(CreateWirelessDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWirelessDevice.</param>
        /// 
        /// <returns>Returns a  CreateWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessDevice">REST API Reference for CreateWirelessDevice Operation</seealso>
        public virtual CreateWirelessDeviceResponse EndCreateWirelessDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWirelessDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWirelessGateway

        /// <summary>
        /// Provisions a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGateway">REST API Reference for CreateWirelessGateway Operation</seealso>
        public virtual CreateWirelessGatewayResponse CreateWirelessGateway(CreateWirelessGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateWirelessGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGateway operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWirelessGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGateway">REST API Reference for CreateWirelessGateway Operation</seealso>
        public virtual IAsyncResult BeginCreateWirelessGateway(CreateWirelessGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWirelessGateway.</param>
        /// 
        /// <returns>Returns a  CreateWirelessGatewayResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGateway">REST API Reference for CreateWirelessGateway Operation</seealso>
        public virtual CreateWirelessGatewayResponse EndCreateWirelessGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWirelessGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWirelessGatewayTask

        /// <summary>
        /// Creates a task for a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTask service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTask">REST API Reference for CreateWirelessGatewayTask Operation</seealso>
        public virtual CreateWirelessGatewayTaskResponse CreateWirelessGatewayTask(CreateWirelessGatewayTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayTaskResponseUnmarshaller.Instance;

            return Invoke<CreateWirelessGatewayTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWirelessGatewayTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTask">REST API Reference for CreateWirelessGatewayTask Operation</seealso>
        public virtual IAsyncResult BeginCreateWirelessGatewayTask(CreateWirelessGatewayTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWirelessGatewayTask.</param>
        /// 
        /// <returns>Returns a  CreateWirelessGatewayTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTask">REST API Reference for CreateWirelessGatewayTask Operation</seealso>
        public virtual CreateWirelessGatewayTaskResponse EndCreateWirelessGatewayTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWirelessGatewayTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWirelessGatewayTaskDefinition

        /// <summary>
        /// Creates a gateway task definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTaskDefinition">REST API Reference for CreateWirelessGatewayTaskDefinition Operation</seealso>
        public virtual CreateWirelessGatewayTaskDefinitionResponse CreateWirelessGatewayTaskDefinition(CreateWirelessGatewayTaskDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateWirelessGatewayTaskDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTaskDefinition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWirelessGatewayTaskDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTaskDefinition">REST API Reference for CreateWirelessGatewayTaskDefinition Operation</seealso>
        public virtual IAsyncResult BeginCreateWirelessGatewayTaskDefinition(CreateWirelessGatewayTaskDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWirelessGatewayTaskDefinition.</param>
        /// 
        /// <returns>Returns a  CreateWirelessGatewayTaskDefinitionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTaskDefinition">REST API Reference for CreateWirelessGatewayTaskDefinition Operation</seealso>
        public virtual CreateWirelessGatewayTaskDefinitionResponse EndCreateWirelessGatewayTaskDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWirelessGatewayTaskDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDestination

        /// <summary>
        /// Deletes a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual IAsyncResult BeginDeleteDestination(DeleteDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDestination.</param>
        /// 
        /// <returns>Returns a  DeleteDestinationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual DeleteDestinationResponse EndDeleteDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDeviceProfile

        /// <summary>
        /// Deletes a device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDeviceProfile">REST API Reference for DeleteDeviceProfile Operation</seealso>
        public virtual DeleteDeviceProfileResponse DeleteDeviceProfile(DeleteDeviceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteDeviceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeviceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDeviceProfile">REST API Reference for DeleteDeviceProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteDeviceProfile(DeleteDeviceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeviceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteDeviceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDeviceProfile">REST API Reference for DeleteDeviceProfile Operation</seealso>
        public virtual DeleteDeviceProfileResponse EndDeleteDeviceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeviceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFuotaTask

        /// <summary>
        /// Deletes a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFuotaTask service method.</param>
        /// 
        /// <returns>The response from the DeleteFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteFuotaTask">REST API Reference for DeleteFuotaTask Operation</seealso>
        public virtual DeleteFuotaTaskResponse DeleteFuotaTask(DeleteFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteFuotaTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteFuotaTask">REST API Reference for DeleteFuotaTask Operation</seealso>
        public virtual IAsyncResult BeginDeleteFuotaTask(DeleteFuotaTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFuotaTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFuotaTask.</param>
        /// 
        /// <returns>Returns a  DeleteFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteFuotaTask">REST API Reference for DeleteFuotaTask Operation</seealso>
        public virtual DeleteFuotaTaskResponse EndDeleteFuotaTask(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFuotaTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMulticastGroup

        /// <summary>
        /// Deletes a multicast group if it is not in use by a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteMulticastGroup">REST API Reference for DeleteMulticastGroup Operation</seealso>
        public virtual DeleteMulticastGroupResponse DeleteMulticastGroup(DeleteMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteMulticastGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteMulticastGroup">REST API Reference for DeleteMulticastGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteMulticastGroup(DeleteMulticastGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMulticastGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMulticastGroup.</param>
        /// 
        /// <returns>Returns a  DeleteMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteMulticastGroup">REST API Reference for DeleteMulticastGroup Operation</seealso>
        public virtual DeleteMulticastGroupResponse EndDeleteMulticastGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMulticastGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNetworkAnalyzerConfiguration

        /// <summary>
        /// Deletes a network analyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAnalyzerConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkAnalyzerConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteNetworkAnalyzerConfiguration">REST API Reference for DeleteNetworkAnalyzerConfiguration Operation</seealso>
        public virtual DeleteNetworkAnalyzerConfigurationResponse DeleteNetworkAnalyzerConfiguration(DeleteNetworkAnalyzerConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkAnalyzerConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAnalyzerConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkAnalyzerConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteNetworkAnalyzerConfiguration">REST API Reference for DeleteNetworkAnalyzerConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteNetworkAnalyzerConfiguration(DeleteNetworkAnalyzerConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkAnalyzerConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkAnalyzerConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteNetworkAnalyzerConfiguration">REST API Reference for DeleteNetworkAnalyzerConfiguration Operation</seealso>
        public virtual DeleteNetworkAnalyzerConfigurationResponse EndDeleteNetworkAnalyzerConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNetworkAnalyzerConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteQueuedMessages

        /// <summary>
        /// Remove queued messages from the downlink queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueuedMessages service method.</param>
        /// 
        /// <returns>The response from the DeleteQueuedMessages service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteQueuedMessages">REST API Reference for DeleteQueuedMessages Operation</seealso>
        public virtual DeleteQueuedMessagesResponse DeleteQueuedMessages(DeleteQueuedMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQueuedMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueuedMessagesResponseUnmarshaller.Instance;

            return Invoke<DeleteQueuedMessagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueuedMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueuedMessages operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQueuedMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteQueuedMessages">REST API Reference for DeleteQueuedMessages Operation</seealso>
        public virtual IAsyncResult BeginDeleteQueuedMessages(DeleteQueuedMessagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQueuedMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueuedMessagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueuedMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueuedMessages.</param>
        /// 
        /// <returns>Returns a  DeleteQueuedMessagesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteQueuedMessages">REST API Reference for DeleteQueuedMessages Operation</seealso>
        public virtual DeleteQueuedMessagesResponse EndDeleteQueuedMessages(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteQueuedMessagesResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteServiceProfile

        /// <summary>
        /// Deletes a service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteServiceProfile">REST API Reference for DeleteServiceProfile Operation</seealso>
        public virtual DeleteServiceProfileResponse DeleteServiceProfile(DeleteServiceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteServiceProfile">REST API Reference for DeleteServiceProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteServiceProfile(DeleteServiceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteServiceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteServiceProfile">REST API Reference for DeleteServiceProfile Operation</seealso>
        public virtual DeleteServiceProfileResponse EndDeleteServiceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServiceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWirelessDevice

        /// <summary>
        /// Deletes a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDevice">REST API Reference for DeleteWirelessDevice Operation</seealso>
        public virtual DeleteWirelessDeviceResponse DeleteWirelessDevice(DeleteWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteWirelessDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDevice">REST API Reference for DeleteWirelessDevice Operation</seealso>
        public virtual IAsyncResult BeginDeleteWirelessDevice(DeleteWirelessDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWirelessDevice.</param>
        /// 
        /// <returns>Returns a  DeleteWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDevice">REST API Reference for DeleteWirelessDevice Operation</seealso>
        public virtual DeleteWirelessDeviceResponse EndDeleteWirelessDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWirelessDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWirelessDeviceImportTask

        /// <summary>
        /// Delete an import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessDeviceImportTask service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessDeviceImportTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDeviceImportTask">REST API Reference for DeleteWirelessDeviceImportTask Operation</seealso>
        public virtual DeleteWirelessDeviceImportTaskResponse DeleteWirelessDeviceImportTask(DeleteWirelessDeviceImportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessDeviceImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessDeviceImportTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteWirelessDeviceImportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessDeviceImportTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWirelessDeviceImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDeviceImportTask">REST API Reference for DeleteWirelessDeviceImportTask Operation</seealso>
        public virtual IAsyncResult BeginDeleteWirelessDeviceImportTask(DeleteWirelessDeviceImportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessDeviceImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessDeviceImportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWirelessDeviceImportTask.</param>
        /// 
        /// <returns>Returns a  DeleteWirelessDeviceImportTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDeviceImportTask">REST API Reference for DeleteWirelessDeviceImportTask Operation</seealso>
        public virtual DeleteWirelessDeviceImportTaskResponse EndDeleteWirelessDeviceImportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWirelessDeviceImportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWirelessGateway

        /// <summary>
        /// Deletes a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGateway">REST API Reference for DeleteWirelessGateway Operation</seealso>
        public virtual DeleteWirelessGatewayResponse DeleteWirelessGateway(DeleteWirelessGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteWirelessGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGateway operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWirelessGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGateway">REST API Reference for DeleteWirelessGateway Operation</seealso>
        public virtual IAsyncResult BeginDeleteWirelessGateway(DeleteWirelessGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWirelessGateway.</param>
        /// 
        /// <returns>Returns a  DeleteWirelessGatewayResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGateway">REST API Reference for DeleteWirelessGateway Operation</seealso>
        public virtual DeleteWirelessGatewayResponse EndDeleteWirelessGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWirelessGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWirelessGatewayTask

        /// <summary>
        /// Deletes a wireless gateway task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTask service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTask">REST API Reference for DeleteWirelessGatewayTask Operation</seealso>
        public virtual DeleteWirelessGatewayTaskResponse DeleteWirelessGatewayTask(DeleteWirelessGatewayTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteWirelessGatewayTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWirelessGatewayTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTask">REST API Reference for DeleteWirelessGatewayTask Operation</seealso>
        public virtual IAsyncResult BeginDeleteWirelessGatewayTask(DeleteWirelessGatewayTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWirelessGatewayTask.</param>
        /// 
        /// <returns>Returns a  DeleteWirelessGatewayTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTask">REST API Reference for DeleteWirelessGatewayTask Operation</seealso>
        public virtual DeleteWirelessGatewayTaskResponse EndDeleteWirelessGatewayTask(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWirelessGatewayTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWirelessGatewayTaskDefinition

        /// <summary>
        /// Deletes a wireless gateway task definition. Deleting this task definition does not
        /// affect tasks that are currently in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTaskDefinition">REST API Reference for DeleteWirelessGatewayTaskDefinition Operation</seealso>
        public virtual DeleteWirelessGatewayTaskDefinitionResponse DeleteWirelessGatewayTaskDefinition(DeleteWirelessGatewayTaskDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteWirelessGatewayTaskDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTaskDefinition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWirelessGatewayTaskDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTaskDefinition">REST API Reference for DeleteWirelessGatewayTaskDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeleteWirelessGatewayTaskDefinition(DeleteWirelessGatewayTaskDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWirelessGatewayTaskDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteWirelessGatewayTaskDefinitionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTaskDefinition">REST API Reference for DeleteWirelessGatewayTaskDefinition Operation</seealso>
        public virtual DeleteWirelessGatewayTaskDefinitionResponse EndDeleteWirelessGatewayTaskDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWirelessGatewayTaskDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterWirelessDevice

        /// <summary>
        /// Deregister a wireless device from AWS IoT Wireless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the DeregisterWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeregisterWirelessDevice">REST API Reference for DeregisterWirelessDevice Operation</seealso>
        public virtual DeregisterWirelessDeviceResponse DeregisterWirelessDevice(DeregisterWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<DeregisterWirelessDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeregisterWirelessDevice">REST API Reference for DeregisterWirelessDevice Operation</seealso>
        public virtual IAsyncResult BeginDeregisterWirelessDevice(DeregisterWirelessDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterWirelessDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterWirelessDevice.</param>
        /// 
        /// <returns>Returns a  DeregisterWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeregisterWirelessDevice">REST API Reference for DeregisterWirelessDevice Operation</seealso>
        public virtual DeregisterWirelessDeviceResponse EndDeregisterWirelessDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterWirelessDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateAwsAccountFromPartnerAccount

        /// <summary>
        /// Disassociates your AWS account from a partner account. If <code>PartnerAccountId</code>
        /// and <code>PartnerType</code> are <code>null</code>, disassociates your AWS account
        /// from all partner accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsAccountFromPartnerAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateAwsAccountFromPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateAwsAccountFromPartnerAccount">REST API Reference for DisassociateAwsAccountFromPartnerAccount Operation</seealso>
        public virtual DisassociateAwsAccountFromPartnerAccountResponse DisassociateAwsAccountFromPartnerAccount(DisassociateAwsAccountFromPartnerAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAwsAccountFromPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAwsAccountFromPartnerAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateAwsAccountFromPartnerAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAwsAccountFromPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsAccountFromPartnerAccount operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAwsAccountFromPartnerAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateAwsAccountFromPartnerAccount">REST API Reference for DisassociateAwsAccountFromPartnerAccount Operation</seealso>
        public virtual IAsyncResult BeginDisassociateAwsAccountFromPartnerAccount(DisassociateAwsAccountFromPartnerAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAwsAccountFromPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAwsAccountFromPartnerAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAwsAccountFromPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAwsAccountFromPartnerAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateAwsAccountFromPartnerAccountResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateAwsAccountFromPartnerAccount">REST API Reference for DisassociateAwsAccountFromPartnerAccount Operation</seealso>
        public virtual DisassociateAwsAccountFromPartnerAccountResponse EndDisassociateAwsAccountFromPartnerAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateAwsAccountFromPartnerAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateMulticastGroupFromFuotaTask

        /// <summary>
        /// Disassociates a multicast group from a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMulticastGroupFromFuotaTask service method.</param>
        /// 
        /// <returns>The response from the DisassociateMulticastGroupFromFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateMulticastGroupFromFuotaTask">REST API Reference for DisassociateMulticastGroupFromFuotaTask Operation</seealso>
        public virtual DisassociateMulticastGroupFromFuotaTaskResponse DisassociateMulticastGroupFromFuotaTask(DisassociateMulticastGroupFromFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMulticastGroupFromFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMulticastGroupFromFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<DisassociateMulticastGroupFromFuotaTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMulticastGroupFromFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMulticastGroupFromFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMulticastGroupFromFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateMulticastGroupFromFuotaTask">REST API Reference for DisassociateMulticastGroupFromFuotaTask Operation</seealso>
        public virtual IAsyncResult BeginDisassociateMulticastGroupFromFuotaTask(DisassociateMulticastGroupFromFuotaTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMulticastGroupFromFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMulticastGroupFromFuotaTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMulticastGroupFromFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMulticastGroupFromFuotaTask.</param>
        /// 
        /// <returns>Returns a  DisassociateMulticastGroupFromFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateMulticastGroupFromFuotaTask">REST API Reference for DisassociateMulticastGroupFromFuotaTask Operation</seealso>
        public virtual DisassociateMulticastGroupFromFuotaTaskResponse EndDisassociateMulticastGroupFromFuotaTask(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateMulticastGroupFromFuotaTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateWirelessDeviceFromFuotaTask

        /// <summary>
        /// Disassociates a wireless device from a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromFuotaTask service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessDeviceFromFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromFuotaTask">REST API Reference for DisassociateWirelessDeviceFromFuotaTask Operation</seealso>
        public virtual DisassociateWirelessDeviceFromFuotaTaskResponse DisassociateWirelessDeviceFromFuotaTask(DisassociateWirelessDeviceFromFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessDeviceFromFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessDeviceFromFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<DisassociateWirelessDeviceFromFuotaTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWirelessDeviceFromFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWirelessDeviceFromFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromFuotaTask">REST API Reference for DisassociateWirelessDeviceFromFuotaTask Operation</seealso>
        public virtual IAsyncResult BeginDisassociateWirelessDeviceFromFuotaTask(DisassociateWirelessDeviceFromFuotaTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessDeviceFromFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessDeviceFromFuotaTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWirelessDeviceFromFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWirelessDeviceFromFuotaTask.</param>
        /// 
        /// <returns>Returns a  DisassociateWirelessDeviceFromFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromFuotaTask">REST API Reference for DisassociateWirelessDeviceFromFuotaTask Operation</seealso>
        public virtual DisassociateWirelessDeviceFromFuotaTaskResponse EndDisassociateWirelessDeviceFromFuotaTask(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateWirelessDeviceFromFuotaTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateWirelessDeviceFromMulticastGroup

        /// <summary>
        /// Disassociates a wireless device from a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessDeviceFromMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromMulticastGroup">REST API Reference for DisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        public virtual DisassociateWirelessDeviceFromMulticastGroupResponse DisassociateWirelessDeviceFromMulticastGroup(DisassociateWirelessDeviceFromMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessDeviceFromMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessDeviceFromMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociateWirelessDeviceFromMulticastGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWirelessDeviceFromMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWirelessDeviceFromMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromMulticastGroup">REST API Reference for DisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        public virtual IAsyncResult BeginDisassociateWirelessDeviceFromMulticastGroup(DisassociateWirelessDeviceFromMulticastGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessDeviceFromMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessDeviceFromMulticastGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWirelessDeviceFromMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWirelessDeviceFromMulticastGroup.</param>
        /// 
        /// <returns>Returns a  DisassociateWirelessDeviceFromMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromMulticastGroup">REST API Reference for DisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        public virtual DisassociateWirelessDeviceFromMulticastGroupResponse EndDisassociateWirelessDeviceFromMulticastGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateWirelessDeviceFromMulticastGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateWirelessDeviceFromThing

        /// <summary>
        /// Disassociates a wireless device from its currently associated thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromThing service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessDeviceFromThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromThing">REST API Reference for DisassociateWirelessDeviceFromThing Operation</seealso>
        public virtual DisassociateWirelessDeviceFromThingResponse DisassociateWirelessDeviceFromThing(DisassociateWirelessDeviceFromThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessDeviceFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessDeviceFromThingResponseUnmarshaller.Instance;

            return Invoke<DisassociateWirelessDeviceFromThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWirelessDeviceFromThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromThing operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWirelessDeviceFromThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromThing">REST API Reference for DisassociateWirelessDeviceFromThing Operation</seealso>
        public virtual IAsyncResult BeginDisassociateWirelessDeviceFromThing(DisassociateWirelessDeviceFromThingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessDeviceFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessDeviceFromThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWirelessDeviceFromThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWirelessDeviceFromThing.</param>
        /// 
        /// <returns>Returns a  DisassociateWirelessDeviceFromThingResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromThing">REST API Reference for DisassociateWirelessDeviceFromThing Operation</seealso>
        public virtual DisassociateWirelessDeviceFromThingResponse EndDisassociateWirelessDeviceFromThing(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateWirelessDeviceFromThingResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateWirelessGatewayFromCertificate

        /// <summary>
        /// Disassociates a wireless gateway from its currently associated certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromCertificate service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessGatewayFromCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromCertificate">REST API Reference for DisassociateWirelessGatewayFromCertificate Operation</seealso>
        public virtual DisassociateWirelessGatewayFromCertificateResponse DisassociateWirelessGatewayFromCertificate(DisassociateWirelessGatewayFromCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessGatewayFromCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessGatewayFromCertificateResponseUnmarshaller.Instance;

            return Invoke<DisassociateWirelessGatewayFromCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWirelessGatewayFromCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromCertificate operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWirelessGatewayFromCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromCertificate">REST API Reference for DisassociateWirelessGatewayFromCertificate Operation</seealso>
        public virtual IAsyncResult BeginDisassociateWirelessGatewayFromCertificate(DisassociateWirelessGatewayFromCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessGatewayFromCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessGatewayFromCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWirelessGatewayFromCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWirelessGatewayFromCertificate.</param>
        /// 
        /// <returns>Returns a  DisassociateWirelessGatewayFromCertificateResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromCertificate">REST API Reference for DisassociateWirelessGatewayFromCertificate Operation</seealso>
        public virtual DisassociateWirelessGatewayFromCertificateResponse EndDisassociateWirelessGatewayFromCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateWirelessGatewayFromCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateWirelessGatewayFromThing

        /// <summary>
        /// Disassociates a wireless gateway from its currently associated thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromThing service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessGatewayFromThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromThing">REST API Reference for DisassociateWirelessGatewayFromThing Operation</seealso>
        public virtual DisassociateWirelessGatewayFromThingResponse DisassociateWirelessGatewayFromThing(DisassociateWirelessGatewayFromThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessGatewayFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessGatewayFromThingResponseUnmarshaller.Instance;

            return Invoke<DisassociateWirelessGatewayFromThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWirelessGatewayFromThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromThing operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWirelessGatewayFromThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromThing">REST API Reference for DisassociateWirelessGatewayFromThing Operation</seealso>
        public virtual IAsyncResult BeginDisassociateWirelessGatewayFromThing(DisassociateWirelessGatewayFromThingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessGatewayFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessGatewayFromThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWirelessGatewayFromThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWirelessGatewayFromThing.</param>
        /// 
        /// <returns>Returns a  DisassociateWirelessGatewayFromThingResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromThing">REST API Reference for DisassociateWirelessGatewayFromThing Operation</seealso>
        public virtual DisassociateWirelessGatewayFromThingResponse EndDisassociateWirelessGatewayFromThing(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateWirelessGatewayFromThingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDestination

        /// <summary>
        /// Gets information about a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDestination service method.</param>
        /// 
        /// <returns>The response from the GetDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDestination">REST API Reference for GetDestination Operation</seealso>
        public virtual GetDestinationResponse GetDestination(GetDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDestinationResponseUnmarshaller.Instance;

            return Invoke<GetDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDestination operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDestination">REST API Reference for GetDestination Operation</seealso>
        public virtual IAsyncResult BeginGetDestination(GetDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDestination.</param>
        /// 
        /// <returns>Returns a  GetDestinationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDestination">REST API Reference for GetDestination Operation</seealso>
        public virtual GetDestinationResponse EndGetDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeviceProfile

        /// <summary>
        /// Gets information about a device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceProfile service method.</param>
        /// 
        /// <returns>The response from the GetDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDeviceProfile">REST API Reference for GetDeviceProfile Operation</seealso>
        public virtual GetDeviceProfileResponse GetDeviceProfile(GetDeviceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceProfileResponseUnmarshaller.Instance;

            return Invoke<GetDeviceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeviceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDeviceProfile">REST API Reference for GetDeviceProfile Operation</seealso>
        public virtual IAsyncResult BeginGetDeviceProfile(GetDeviceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeviceProfile.</param>
        /// 
        /// <returns>Returns a  GetDeviceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDeviceProfile">REST API Reference for GetDeviceProfile Operation</seealso>
        public virtual GetDeviceProfileResponse EndGetDeviceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeviceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEventConfigurationByResourceTypes

        /// <summary>
        /// Get the event configuration based on resource types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventConfigurationByResourceTypes service method.</param>
        /// 
        /// <returns>The response from the GetEventConfigurationByResourceTypes service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetEventConfigurationByResourceTypes">REST API Reference for GetEventConfigurationByResourceTypes Operation</seealso>
        public virtual GetEventConfigurationByResourceTypesResponse GetEventConfigurationByResourceTypes(GetEventConfigurationByResourceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventConfigurationByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventConfigurationByResourceTypesResponseUnmarshaller.Instance;

            return Invoke<GetEventConfigurationByResourceTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventConfigurationByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventConfigurationByResourceTypes operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventConfigurationByResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetEventConfigurationByResourceTypes">REST API Reference for GetEventConfigurationByResourceTypes Operation</seealso>
        public virtual IAsyncResult BeginGetEventConfigurationByResourceTypes(GetEventConfigurationByResourceTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventConfigurationByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventConfigurationByResourceTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventConfigurationByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventConfigurationByResourceTypes.</param>
        /// 
        /// <returns>Returns a  GetEventConfigurationByResourceTypesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetEventConfigurationByResourceTypes">REST API Reference for GetEventConfigurationByResourceTypes Operation</seealso>
        public virtual GetEventConfigurationByResourceTypesResponse EndGetEventConfigurationByResourceTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventConfigurationByResourceTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFuotaTask

        /// <summary>
        /// Gets information about a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFuotaTask service method.</param>
        /// 
        /// <returns>The response from the GetFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetFuotaTask">REST API Reference for GetFuotaTask Operation</seealso>
        public virtual GetFuotaTaskResponse GetFuotaTask(GetFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<GetFuotaTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetFuotaTask">REST API Reference for GetFuotaTask Operation</seealso>
        public virtual IAsyncResult BeginGetFuotaTask(GetFuotaTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFuotaTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFuotaTask.</param>
        /// 
        /// <returns>Returns a  GetFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetFuotaTask">REST API Reference for GetFuotaTask Operation</seealso>
        public virtual GetFuotaTaskResponse EndGetFuotaTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFuotaTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLogLevelsByResourceTypes

        /// <summary>
        /// Returns current default log levels or log levels by resource types. Based on resource
        /// types, log levels can be for wireless device log options or wireless gateway log options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogLevelsByResourceTypes service method.</param>
        /// 
        /// <returns>The response from the GetLogLevelsByResourceTypes service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetLogLevelsByResourceTypes">REST API Reference for GetLogLevelsByResourceTypes Operation</seealso>
        public virtual GetLogLevelsByResourceTypesResponse GetLogLevelsByResourceTypes(GetLogLevelsByResourceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogLevelsByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogLevelsByResourceTypesResponseUnmarshaller.Instance;

            return Invoke<GetLogLevelsByResourceTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLogLevelsByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLogLevelsByResourceTypes operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLogLevelsByResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetLogLevelsByResourceTypes">REST API Reference for GetLogLevelsByResourceTypes Operation</seealso>
        public virtual IAsyncResult BeginGetLogLevelsByResourceTypes(GetLogLevelsByResourceTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogLevelsByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogLevelsByResourceTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLogLevelsByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLogLevelsByResourceTypes.</param>
        /// 
        /// <returns>Returns a  GetLogLevelsByResourceTypesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetLogLevelsByResourceTypes">REST API Reference for GetLogLevelsByResourceTypes Operation</seealso>
        public virtual GetLogLevelsByResourceTypesResponse EndGetLogLevelsByResourceTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLogLevelsByResourceTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMulticastGroup

        /// <summary>
        /// Gets information about a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the GetMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroup">REST API Reference for GetMulticastGroup Operation</seealso>
        public virtual GetMulticastGroupResponse GetMulticastGroup(GetMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<GetMulticastGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroup">REST API Reference for GetMulticastGroup Operation</seealso>
        public virtual IAsyncResult BeginGetMulticastGroup(GetMulticastGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMulticastGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMulticastGroup.</param>
        /// 
        /// <returns>Returns a  GetMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroup">REST API Reference for GetMulticastGroup Operation</seealso>
        public virtual GetMulticastGroupResponse EndGetMulticastGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMulticastGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMulticastGroupSession

        /// <summary>
        /// Gets information about a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMulticastGroupSession service method.</param>
        /// 
        /// <returns>The response from the GetMulticastGroupSession service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroupSession">REST API Reference for GetMulticastGroupSession Operation</seealso>
        public virtual GetMulticastGroupSessionResponse GetMulticastGroupSession(GetMulticastGroupSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMulticastGroupSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMulticastGroupSessionResponseUnmarshaller.Instance;

            return Invoke<GetMulticastGroupSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMulticastGroupSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMulticastGroupSession operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMulticastGroupSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroupSession">REST API Reference for GetMulticastGroupSession Operation</seealso>
        public virtual IAsyncResult BeginGetMulticastGroupSession(GetMulticastGroupSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMulticastGroupSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMulticastGroupSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMulticastGroupSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMulticastGroupSession.</param>
        /// 
        /// <returns>Returns a  GetMulticastGroupSessionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroupSession">REST API Reference for GetMulticastGroupSession Operation</seealso>
        public virtual GetMulticastGroupSessionResponse EndGetMulticastGroupSession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMulticastGroupSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNetworkAnalyzerConfiguration

        /// <summary>
        /// Get network analyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkAnalyzerConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetNetworkAnalyzerConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetNetworkAnalyzerConfiguration">REST API Reference for GetNetworkAnalyzerConfiguration Operation</seealso>
        public virtual GetNetworkAnalyzerConfigurationResponse GetNetworkAnalyzerConfiguration(GetNetworkAnalyzerConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetNetworkAnalyzerConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkAnalyzerConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkAnalyzerConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetNetworkAnalyzerConfiguration">REST API Reference for GetNetworkAnalyzerConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetNetworkAnalyzerConfiguration(GetNetworkAnalyzerConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkAnalyzerConfiguration.</param>
        /// 
        /// <returns>Returns a  GetNetworkAnalyzerConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetNetworkAnalyzerConfiguration">REST API Reference for GetNetworkAnalyzerConfiguration Operation</seealso>
        public virtual GetNetworkAnalyzerConfigurationResponse EndGetNetworkAnalyzerConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNetworkAnalyzerConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPartnerAccount

        /// <summary>
        /// Gets information about a partner account. If <code>PartnerAccountId</code> and <code>PartnerType</code>
        /// are <code>null</code>, returns all partner accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartnerAccount service method.</param>
        /// 
        /// <returns>The response from the GetPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPartnerAccount">REST API Reference for GetPartnerAccount Operation</seealso>
        public virtual GetPartnerAccountResponse GetPartnerAccount(GetPartnerAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartnerAccountResponseUnmarshaller.Instance;

            return Invoke<GetPartnerAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartnerAccount operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPartnerAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPartnerAccount">REST API Reference for GetPartnerAccount Operation</seealso>
        public virtual IAsyncResult BeginGetPartnerAccount(GetPartnerAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartnerAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPartnerAccount.</param>
        /// 
        /// <returns>Returns a  GetPartnerAccountResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPartnerAccount">REST API Reference for GetPartnerAccount Operation</seealso>
        public virtual GetPartnerAccountResponse EndGetPartnerAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPartnerAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPosition

        /// <summary>
        /// Get the position information for a given resource.
        /// 
        ///  <important> 
        /// <para>
        /// This action is no longer supported. Calls to retrieve the position information should
        /// use the <a href="https://docs.aws.amazon.com/iot-wireless/2020-11-22/apireference/API_GetResourcePosition.html">GetResourcePosition</a>
        /// API operation instead.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPosition service method.</param>
        /// 
        /// <returns>The response from the GetPosition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPosition">REST API Reference for GetPosition Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual GetPositionResponse GetPosition(GetPositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPositionResponseUnmarshaller.Instance;

            return Invoke<GetPositionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPosition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPosition">REST API Reference for GetPosition Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual IAsyncResult BeginGetPosition(GetPositionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPositionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPosition.</param>
        /// 
        /// <returns>Returns a  GetPositionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPosition">REST API Reference for GetPosition Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual GetPositionResponse EndGetPosition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPositionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPositionConfiguration

        /// <summary>
        /// Get position configuration for a given resource.
        /// 
        ///  <important> 
        /// <para>
        /// This action is no longer supported. Calls to retrieve the position configuration should
        /// use the <a href="https://docs.aws.amazon.com/iot-wireless/2020-11-22/apireference/API_GetResourcePosition.html">GetResourcePosition</a>
        /// API operation instead.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPositionConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetPositionConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPositionConfiguration">REST API Reference for GetPositionConfiguration Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual GetPositionConfigurationResponse GetPositionConfiguration(GetPositionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPositionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPositionConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetPositionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPositionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPositionConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPositionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPositionConfiguration">REST API Reference for GetPositionConfiguration Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual IAsyncResult BeginGetPositionConfiguration(GetPositionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPositionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPositionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPositionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPositionConfiguration.</param>
        /// 
        /// <returns>Returns a  GetPositionConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPositionConfiguration">REST API Reference for GetPositionConfiguration Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual GetPositionConfigurationResponse EndGetPositionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPositionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPositionEstimate

        /// <summary>
        /// Get estimated position information as a payload in GeoJSON format. The payload measurement
        /// data is resolved using solvers that are provided by third-party vendors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPositionEstimate service method.</param>
        /// 
        /// <returns>The response from the GetPositionEstimate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPositionEstimate">REST API Reference for GetPositionEstimate Operation</seealso>
        public virtual GetPositionEstimateResponse GetPositionEstimate(GetPositionEstimateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPositionEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPositionEstimateResponseUnmarshaller.Instance;

            return Invoke<GetPositionEstimateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPositionEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPositionEstimate operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPositionEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPositionEstimate">REST API Reference for GetPositionEstimate Operation</seealso>
        public virtual IAsyncResult BeginGetPositionEstimate(GetPositionEstimateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPositionEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPositionEstimateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPositionEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPositionEstimate.</param>
        /// 
        /// <returns>Returns a  GetPositionEstimateResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPositionEstimate">REST API Reference for GetPositionEstimate Operation</seealso>
        public virtual GetPositionEstimateResponse EndGetPositionEstimate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPositionEstimateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceEventConfiguration

        /// <summary>
        /// Get the event configuration for a particular resource identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceEventConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetResourceEventConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceEventConfiguration">REST API Reference for GetResourceEventConfiguration Operation</seealso>
        public virtual GetResourceEventConfigurationResponse GetResourceEventConfiguration(GetResourceEventConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceEventConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetResourceEventConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceEventConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceEventConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceEventConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceEventConfiguration">REST API Reference for GetResourceEventConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetResourceEventConfiguration(GetResourceEventConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceEventConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceEventConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceEventConfiguration.</param>
        /// 
        /// <returns>Returns a  GetResourceEventConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceEventConfiguration">REST API Reference for GetResourceEventConfiguration Operation</seealso>
        public virtual GetResourceEventConfigurationResponse EndGetResourceEventConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceEventConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceLogLevel

        /// <summary>
        /// Fetches the log-level override, if any, for a given resource-ID and resource-type.
        /// It can be used for a wireless device or a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceLogLevel service method.</param>
        /// 
        /// <returns>The response from the GetResourceLogLevel service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceLogLevel">REST API Reference for GetResourceLogLevel Operation</seealso>
        public virtual GetResourceLogLevelResponse GetResourceLogLevel(GetResourceLogLevelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceLogLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceLogLevelResponseUnmarshaller.Instance;

            return Invoke<GetResourceLogLevelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceLogLevel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceLogLevel operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceLogLevel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceLogLevel">REST API Reference for GetResourceLogLevel Operation</seealso>
        public virtual IAsyncResult BeginGetResourceLogLevel(GetResourceLogLevelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceLogLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceLogLevelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceLogLevel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceLogLevel.</param>
        /// 
        /// <returns>Returns a  GetResourceLogLevelResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceLogLevel">REST API Reference for GetResourceLogLevel Operation</seealso>
        public virtual GetResourceLogLevelResponse EndGetResourceLogLevel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceLogLevelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourcePosition

        /// <summary>
        /// Get the position information for a given wireless device or a wireless gateway resource.
        /// The position information uses the <a href="https://gisgeography.com/wgs84-world-geodetic-system/">
        /// World Geodetic System (WGS84)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePosition service method.</param>
        /// 
        /// <returns>The response from the GetResourcePosition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourcePosition">REST API Reference for GetResourcePosition Operation</seealso>
        public virtual GetResourcePositionResponse GetResourcePosition(GetResourcePositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePositionResponseUnmarshaller.Instance;

            return Invoke<GetResourcePositionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePosition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourcePosition">REST API Reference for GetResourcePosition Operation</seealso>
        public virtual IAsyncResult BeginGetResourcePosition(GetResourcePositionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePositionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePosition.</param>
        /// 
        /// <returns>Returns a  GetResourcePositionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourcePosition">REST API Reference for GetResourcePosition Operation</seealso>
        public virtual GetResourcePositionResponse EndGetResourcePosition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcePositionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServiceEndpoint

        /// <summary>
        /// Gets the account-specific endpoint for Configuration and Update Server (CUPS) protocol
        /// or LoRaWAN Network Server (LNS) connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetServiceEndpoint service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceEndpoint">REST API Reference for GetServiceEndpoint Operation</seealso>
        public virtual GetServiceEndpointResponse GetServiceEndpoint(GetServiceEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceEndpointResponseUnmarshaller.Instance;

            return Invoke<GetServiceEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceEndpoint operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceEndpoint">REST API Reference for GetServiceEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetServiceEndpoint(GetServiceEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceEndpoint.</param>
        /// 
        /// <returns>Returns a  GetServiceEndpointResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceEndpoint">REST API Reference for GetServiceEndpoint Operation</seealso>
        public virtual GetServiceEndpointResponse EndGetServiceEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServiceProfile

        /// <summary>
        /// Gets information about a service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceProfile service method.</param>
        /// 
        /// <returns>The response from the GetServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceProfile">REST API Reference for GetServiceProfile Operation</seealso>
        public virtual GetServiceProfileResponse GetServiceProfile(GetServiceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceProfileResponseUnmarshaller.Instance;

            return Invoke<GetServiceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceProfile">REST API Reference for GetServiceProfile Operation</seealso>
        public virtual IAsyncResult BeginGetServiceProfile(GetServiceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceProfile.</param>
        /// 
        /// <returns>Returns a  GetServiceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceProfile">REST API Reference for GetServiceProfile Operation</seealso>
        public virtual GetServiceProfileResponse EndGetServiceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessDevice

        /// <summary>
        /// Gets information about a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the GetWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDevice">REST API Reference for GetWirelessDevice Operation</seealso>
        public virtual GetWirelessDeviceResponse GetWirelessDevice(GetWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<GetWirelessDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDevice">REST API Reference for GetWirelessDevice Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessDevice(GetWirelessDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessDevice.</param>
        /// 
        /// <returns>Returns a  GetWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDevice">REST API Reference for GetWirelessDevice Operation</seealso>
        public virtual GetWirelessDeviceResponse EndGetWirelessDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessDeviceImportTask

        /// <summary>
        /// Get information about an import task and count of device onboarding summary information
        /// for the import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDeviceImportTask service method.</param>
        /// 
        /// <returns>The response from the GetWirelessDeviceImportTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceImportTask">REST API Reference for GetWirelessDeviceImportTask Operation</seealso>
        public virtual GetWirelessDeviceImportTaskResponse GetWirelessDeviceImportTask(GetWirelessDeviceImportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessDeviceImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessDeviceImportTaskResponseUnmarshaller.Instance;

            return Invoke<GetWirelessDeviceImportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDeviceImportTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessDeviceImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceImportTask">REST API Reference for GetWirelessDeviceImportTask Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessDeviceImportTask(GetWirelessDeviceImportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessDeviceImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessDeviceImportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessDeviceImportTask.</param>
        /// 
        /// <returns>Returns a  GetWirelessDeviceImportTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceImportTask">REST API Reference for GetWirelessDeviceImportTask Operation</seealso>
        public virtual GetWirelessDeviceImportTaskResponse EndGetWirelessDeviceImportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessDeviceImportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessDeviceStatistics

        /// <summary>
        /// Gets operating information about a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDeviceStatistics service method.</param>
        /// 
        /// <returns>The response from the GetWirelessDeviceStatistics service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceStatistics">REST API Reference for GetWirelessDeviceStatistics Operation</seealso>
        public virtual GetWirelessDeviceStatisticsResponse GetWirelessDeviceStatistics(GetWirelessDeviceStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessDeviceStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessDeviceStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetWirelessDeviceStatisticsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessDeviceStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDeviceStatistics operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessDeviceStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceStatistics">REST API Reference for GetWirelessDeviceStatistics Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessDeviceStatistics(GetWirelessDeviceStatisticsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessDeviceStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessDeviceStatisticsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessDeviceStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessDeviceStatistics.</param>
        /// 
        /// <returns>Returns a  GetWirelessDeviceStatisticsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceStatistics">REST API Reference for GetWirelessDeviceStatistics Operation</seealso>
        public virtual GetWirelessDeviceStatisticsResponse EndGetWirelessDeviceStatistics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessDeviceStatisticsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessGateway

        /// <summary>
        /// Gets information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGateway">REST API Reference for GetWirelessGateway Operation</seealso>
        public virtual GetWirelessGatewayResponse GetWirelessGateway(GetWirelessGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGateway operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGateway">REST API Reference for GetWirelessGateway Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessGateway(GetWirelessGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGateway.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGateway">REST API Reference for GetWirelessGateway Operation</seealso>
        public virtual GetWirelessGatewayResponse EndGetWirelessGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessGatewayCertificate

        /// <summary>
        /// Gets the ID of the certificate that is currently associated with a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayCertificate service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayCertificate">REST API Reference for GetWirelessGatewayCertificate Operation</seealso>
        public virtual GetWirelessGatewayCertificateResponse GetWirelessGatewayCertificate(GetWirelessGatewayCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayCertificateResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayCertificate operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayCertificate">REST API Reference for GetWirelessGatewayCertificate Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessGatewayCertificate(GetWirelessGatewayCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayCertificate.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayCertificateResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayCertificate">REST API Reference for GetWirelessGatewayCertificate Operation</seealso>
        public virtual GetWirelessGatewayCertificateResponse EndGetWirelessGatewayCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessGatewayCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessGatewayFirmwareInformation

        /// <summary>
        /// Gets the firmware version and other information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayFirmwareInformation service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayFirmwareInformation service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayFirmwareInformation">REST API Reference for GetWirelessGatewayFirmwareInformation Operation</seealso>
        public virtual GetWirelessGatewayFirmwareInformationResponse GetWirelessGatewayFirmwareInformation(GetWirelessGatewayFirmwareInformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayFirmwareInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayFirmwareInformationResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayFirmwareInformationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayFirmwareInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayFirmwareInformation operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayFirmwareInformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayFirmwareInformation">REST API Reference for GetWirelessGatewayFirmwareInformation Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessGatewayFirmwareInformation(GetWirelessGatewayFirmwareInformationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayFirmwareInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayFirmwareInformationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayFirmwareInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayFirmwareInformation.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayFirmwareInformationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayFirmwareInformation">REST API Reference for GetWirelessGatewayFirmwareInformation Operation</seealso>
        public virtual GetWirelessGatewayFirmwareInformationResponse EndGetWirelessGatewayFirmwareInformation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessGatewayFirmwareInformationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessGatewayStatistics

        /// <summary>
        /// Gets operating information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayStatistics service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayStatistics service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayStatistics">REST API Reference for GetWirelessGatewayStatistics Operation</seealso>
        public virtual GetWirelessGatewayStatisticsResponse GetWirelessGatewayStatistics(GetWirelessGatewayStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayStatisticsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayStatistics operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayStatistics">REST API Reference for GetWirelessGatewayStatistics Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessGatewayStatistics(GetWirelessGatewayStatisticsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayStatisticsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayStatistics.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayStatisticsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayStatistics">REST API Reference for GetWirelessGatewayStatistics Operation</seealso>
        public virtual GetWirelessGatewayStatisticsResponse EndGetWirelessGatewayStatistics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessGatewayStatisticsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessGatewayTask

        /// <summary>
        /// Gets information about a wireless gateway task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTask service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTask">REST API Reference for GetWirelessGatewayTask Operation</seealso>
        public virtual GetWirelessGatewayTaskResponse GetWirelessGatewayTask(GetWirelessGatewayTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayTaskResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTask">REST API Reference for GetWirelessGatewayTask Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessGatewayTask(GetWirelessGatewayTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayTask.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTask">REST API Reference for GetWirelessGatewayTask Operation</seealso>
        public virtual GetWirelessGatewayTaskResponse EndGetWirelessGatewayTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessGatewayTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessGatewayTaskDefinition

        /// <summary>
        /// Gets information about a wireless gateway task definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTaskDefinition">REST API Reference for GetWirelessGatewayTaskDefinition Operation</seealso>
        public virtual GetWirelessGatewayTaskDefinitionResponse GetWirelessGatewayTaskDefinition(GetWirelessGatewayTaskDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayTaskDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTaskDefinition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayTaskDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTaskDefinition">REST API Reference for GetWirelessGatewayTaskDefinition Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessGatewayTaskDefinition(GetWirelessGatewayTaskDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayTaskDefinition.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayTaskDefinitionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTaskDefinition">REST API Reference for GetWirelessGatewayTaskDefinition Operation</seealso>
        public virtual GetWirelessGatewayTaskDefinitionResponse EndGetWirelessGatewayTaskDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessGatewayTaskDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDestinations

        /// <summary>
        /// Lists the destinations registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations service method.</param>
        /// 
        /// <returns>The response from the ListDestinations service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        public virtual ListDestinationsResponse ListDestinations(ListDestinationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDestinationsResponseUnmarshaller.Instance;

            return Invoke<ListDestinationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        public virtual IAsyncResult BeginListDestinations(ListDestinationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDestinationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDestinations.</param>
        /// 
        /// <returns>Returns a  ListDestinationsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        public virtual ListDestinationsResponse EndListDestinations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDestinationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDeviceProfiles

        /// <summary>
        /// Lists the device profiles registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListDeviceProfiles service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDeviceProfiles">REST API Reference for ListDeviceProfiles Operation</seealso>
        public virtual ListDeviceProfilesResponse ListDeviceProfiles(ListDeviceProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeviceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListDeviceProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceProfiles operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeviceProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDeviceProfiles">REST API Reference for ListDeviceProfiles Operation</seealso>
        public virtual IAsyncResult BeginListDeviceProfiles(ListDeviceProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeviceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeviceProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeviceProfiles.</param>
        /// 
        /// <returns>Returns a  ListDeviceProfilesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDeviceProfiles">REST API Reference for ListDeviceProfiles Operation</seealso>
        public virtual ListDeviceProfilesResponse EndListDeviceProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeviceProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDevicesForWirelessDeviceImportTask

        /// <summary>
        /// List the Sidewalk devices in an import task and their onboarding status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesForWirelessDeviceImportTask service method.</param>
        /// 
        /// <returns>The response from the ListDevicesForWirelessDeviceImportTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDevicesForWirelessDeviceImportTask">REST API Reference for ListDevicesForWirelessDeviceImportTask Operation</seealso>
        public virtual ListDevicesForWirelessDeviceImportTaskResponse ListDevicesForWirelessDeviceImportTask(ListDevicesForWirelessDeviceImportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesForWirelessDeviceImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesForWirelessDeviceImportTaskResponseUnmarshaller.Instance;

            return Invoke<ListDevicesForWirelessDeviceImportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevicesForWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesForWirelessDeviceImportTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevicesForWirelessDeviceImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDevicesForWirelessDeviceImportTask">REST API Reference for ListDevicesForWirelessDeviceImportTask Operation</seealso>
        public virtual IAsyncResult BeginListDevicesForWirelessDeviceImportTask(ListDevicesForWirelessDeviceImportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesForWirelessDeviceImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesForWirelessDeviceImportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevicesForWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevicesForWirelessDeviceImportTask.</param>
        /// 
        /// <returns>Returns a  ListDevicesForWirelessDeviceImportTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDevicesForWirelessDeviceImportTask">REST API Reference for ListDevicesForWirelessDeviceImportTask Operation</seealso>
        public virtual ListDevicesForWirelessDeviceImportTaskResponse EndListDevicesForWirelessDeviceImportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevicesForWirelessDeviceImportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEventConfigurations

        /// <summary>
        /// List event configurations where at least one event topic has been enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListEventConfigurations service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListEventConfigurations">REST API Reference for ListEventConfigurations Operation</seealso>
        public virtual ListEventConfigurationsResponse ListEventConfigurations(ListEventConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListEventConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventConfigurations operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListEventConfigurations">REST API Reference for ListEventConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListEventConfigurations(ListEventConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventConfigurations.</param>
        /// 
        /// <returns>Returns a  ListEventConfigurationsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListEventConfigurations">REST API Reference for ListEventConfigurations Operation</seealso>
        public virtual ListEventConfigurationsResponse EndListEventConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFuotaTasks

        /// <summary>
        /// Lists the FUOTA tasks registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFuotaTasks service method.</param>
        /// 
        /// <returns>The response from the ListFuotaTasks service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListFuotaTasks">REST API Reference for ListFuotaTasks Operation</seealso>
        public virtual ListFuotaTasksResponse ListFuotaTasks(ListFuotaTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFuotaTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFuotaTasksResponseUnmarshaller.Instance;

            return Invoke<ListFuotaTasksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFuotaTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFuotaTasks operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFuotaTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListFuotaTasks">REST API Reference for ListFuotaTasks Operation</seealso>
        public virtual IAsyncResult BeginListFuotaTasks(ListFuotaTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFuotaTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFuotaTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFuotaTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFuotaTasks.</param>
        /// 
        /// <returns>Returns a  ListFuotaTasksResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListFuotaTasks">REST API Reference for ListFuotaTasks Operation</seealso>
        public virtual ListFuotaTasksResponse EndListFuotaTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFuotaTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMulticastGroups

        /// <summary>
        /// Lists the multicast groups registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMulticastGroups service method.</param>
        /// 
        /// <returns>The response from the ListMulticastGroups service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroups">REST API Reference for ListMulticastGroups Operation</seealso>
        public virtual ListMulticastGroupsResponse ListMulticastGroups(ListMulticastGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMulticastGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMulticastGroupsResponseUnmarshaller.Instance;

            return Invoke<ListMulticastGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMulticastGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMulticastGroups operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMulticastGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroups">REST API Reference for ListMulticastGroups Operation</seealso>
        public virtual IAsyncResult BeginListMulticastGroups(ListMulticastGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMulticastGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMulticastGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMulticastGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMulticastGroups.</param>
        /// 
        /// <returns>Returns a  ListMulticastGroupsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroups">REST API Reference for ListMulticastGroups Operation</seealso>
        public virtual ListMulticastGroupsResponse EndListMulticastGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMulticastGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMulticastGroupsByFuotaTask

        /// <summary>
        /// List all multicast groups associated with a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMulticastGroupsByFuotaTask service method.</param>
        /// 
        /// <returns>The response from the ListMulticastGroupsByFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroupsByFuotaTask">REST API Reference for ListMulticastGroupsByFuotaTask Operation</seealso>
        public virtual ListMulticastGroupsByFuotaTaskResponse ListMulticastGroupsByFuotaTask(ListMulticastGroupsByFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMulticastGroupsByFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMulticastGroupsByFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<ListMulticastGroupsByFuotaTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMulticastGroupsByFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMulticastGroupsByFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMulticastGroupsByFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroupsByFuotaTask">REST API Reference for ListMulticastGroupsByFuotaTask Operation</seealso>
        public virtual IAsyncResult BeginListMulticastGroupsByFuotaTask(ListMulticastGroupsByFuotaTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMulticastGroupsByFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMulticastGroupsByFuotaTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMulticastGroupsByFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMulticastGroupsByFuotaTask.</param>
        /// 
        /// <returns>Returns a  ListMulticastGroupsByFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroupsByFuotaTask">REST API Reference for ListMulticastGroupsByFuotaTask Operation</seealso>
        public virtual ListMulticastGroupsByFuotaTaskResponse EndListMulticastGroupsByFuotaTask(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMulticastGroupsByFuotaTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNetworkAnalyzerConfigurations

        /// <summary>
        /// Lists the network analyzer configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkAnalyzerConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListNetworkAnalyzerConfigurations service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListNetworkAnalyzerConfigurations">REST API Reference for ListNetworkAnalyzerConfigurations Operation</seealso>
        public virtual ListNetworkAnalyzerConfigurationsResponse ListNetworkAnalyzerConfigurations(ListNetworkAnalyzerConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworkAnalyzerConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkAnalyzerConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListNetworkAnalyzerConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNetworkAnalyzerConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkAnalyzerConfigurations operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNetworkAnalyzerConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListNetworkAnalyzerConfigurations">REST API Reference for ListNetworkAnalyzerConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListNetworkAnalyzerConfigurations(ListNetworkAnalyzerConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworkAnalyzerConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkAnalyzerConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNetworkAnalyzerConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNetworkAnalyzerConfigurations.</param>
        /// 
        /// <returns>Returns a  ListNetworkAnalyzerConfigurationsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListNetworkAnalyzerConfigurations">REST API Reference for ListNetworkAnalyzerConfigurations Operation</seealso>
        public virtual ListNetworkAnalyzerConfigurationsResponse EndListNetworkAnalyzerConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNetworkAnalyzerConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPartnerAccounts

        /// <summary>
        /// Lists the partner accounts associated with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerAccounts service method.</param>
        /// 
        /// <returns>The response from the ListPartnerAccounts service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPartnerAccounts">REST API Reference for ListPartnerAccounts Operation</seealso>
        public virtual ListPartnerAccountsResponse ListPartnerAccounts(ListPartnerAccountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartnerAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnerAccountsResponseUnmarshaller.Instance;

            return Invoke<ListPartnerAccountsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPartnerAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerAccounts operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPartnerAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPartnerAccounts">REST API Reference for ListPartnerAccounts Operation</seealso>
        public virtual IAsyncResult BeginListPartnerAccounts(ListPartnerAccountsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartnerAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnerAccountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPartnerAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPartnerAccounts.</param>
        /// 
        /// <returns>Returns a  ListPartnerAccountsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPartnerAccounts">REST API Reference for ListPartnerAccounts Operation</seealso>
        public virtual ListPartnerAccountsResponse EndListPartnerAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPartnerAccountsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPositionConfigurations

        /// <summary>
        /// List position configurations for a given resource, such as positioning solvers.
        /// 
        ///  <important> 
        /// <para>
        /// This action is no longer supported. Calls to retrieve position information should
        /// use the <a href="https://docs.aws.amazon.com/iot-wireless/2020-11-22/apireference/API_GetResourcePosition.html">GetResourcePosition</a>
        /// API operation instead.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPositionConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListPositionConfigurations service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPositionConfigurations">REST API Reference for ListPositionConfigurations Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual ListPositionConfigurationsResponse ListPositionConfigurations(ListPositionConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPositionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPositionConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListPositionConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPositionConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPositionConfigurations operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPositionConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPositionConfigurations">REST API Reference for ListPositionConfigurations Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual IAsyncResult BeginListPositionConfigurations(ListPositionConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPositionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPositionConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPositionConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPositionConfigurations.</param>
        /// 
        /// <returns>Returns a  ListPositionConfigurationsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPositionConfigurations">REST API Reference for ListPositionConfigurations Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual ListPositionConfigurationsResponse EndListPositionConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPositionConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListQueuedMessages

        /// <summary>
        /// List queued messages in the downlink queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueuedMessages service method.</param>
        /// 
        /// <returns>The response from the ListQueuedMessages service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListQueuedMessages">REST API Reference for ListQueuedMessages Operation</seealso>
        public virtual ListQueuedMessagesResponse ListQueuedMessages(ListQueuedMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueuedMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuedMessagesResponseUnmarshaller.Instance;

            return Invoke<ListQueuedMessagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListQueuedMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueuedMessages operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueuedMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListQueuedMessages">REST API Reference for ListQueuedMessages Operation</seealso>
        public virtual IAsyncResult BeginListQueuedMessages(ListQueuedMessagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueuedMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuedMessagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueuedMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueuedMessages.</param>
        /// 
        /// <returns>Returns a  ListQueuedMessagesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListQueuedMessages">REST API Reference for ListQueuedMessages Operation</seealso>
        public virtual ListQueuedMessagesResponse EndListQueuedMessages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQueuedMessagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServiceProfiles

        /// <summary>
        /// Lists the service profiles registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListServiceProfiles service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListServiceProfiles">REST API Reference for ListServiceProfiles Operation</seealso>
        public virtual ListServiceProfilesResponse ListServiceProfiles(ListServiceProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListServiceProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceProfiles operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListServiceProfiles">REST API Reference for ListServiceProfiles Operation</seealso>
        public virtual IAsyncResult BeginListServiceProfiles(ListServiceProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceProfiles.</param>
        /// 
        /// <returns>Returns a  ListServiceProfilesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListServiceProfiles">REST API Reference for ListServiceProfiles Operation</seealso>
        public virtual ListServiceProfilesResponse EndListServiceProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServiceProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWirelessDeviceImportTasks

        /// <summary>
        /// List wireless devices that have been added to an import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessDeviceImportTasks service method.</param>
        /// 
        /// <returns>The response from the ListWirelessDeviceImportTasks service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDeviceImportTasks">REST API Reference for ListWirelessDeviceImportTasks Operation</seealso>
        public virtual ListWirelessDeviceImportTasksResponse ListWirelessDeviceImportTasks(ListWirelessDeviceImportTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessDeviceImportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessDeviceImportTasksResponseUnmarshaller.Instance;

            return Invoke<ListWirelessDeviceImportTasksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWirelessDeviceImportTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessDeviceImportTasks operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWirelessDeviceImportTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDeviceImportTasks">REST API Reference for ListWirelessDeviceImportTasks Operation</seealso>
        public virtual IAsyncResult BeginListWirelessDeviceImportTasks(ListWirelessDeviceImportTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessDeviceImportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessDeviceImportTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWirelessDeviceImportTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWirelessDeviceImportTasks.</param>
        /// 
        /// <returns>Returns a  ListWirelessDeviceImportTasksResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDeviceImportTasks">REST API Reference for ListWirelessDeviceImportTasks Operation</seealso>
        public virtual ListWirelessDeviceImportTasksResponse EndListWirelessDeviceImportTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWirelessDeviceImportTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWirelessDevices

        /// <summary>
        /// Lists the wireless devices registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessDevices service method.</param>
        /// 
        /// <returns>The response from the ListWirelessDevices service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDevices">REST API Reference for ListWirelessDevices Operation</seealso>
        public virtual ListWirelessDevicesResponse ListWirelessDevices(ListWirelessDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessDevicesResponseUnmarshaller.Instance;

            return Invoke<ListWirelessDevicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWirelessDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessDevices operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWirelessDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDevices">REST API Reference for ListWirelessDevices Operation</seealso>
        public virtual IAsyncResult BeginListWirelessDevices(ListWirelessDevicesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessDevicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWirelessDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWirelessDevices.</param>
        /// 
        /// <returns>Returns a  ListWirelessDevicesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDevices">REST API Reference for ListWirelessDevices Operation</seealso>
        public virtual ListWirelessDevicesResponse EndListWirelessDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWirelessDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWirelessGateways

        /// <summary>
        /// Lists the wireless gateways registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGateways service method.</param>
        /// 
        /// <returns>The response from the ListWirelessGateways service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGateways">REST API Reference for ListWirelessGateways Operation</seealso>
        public virtual ListWirelessGatewaysResponse ListWirelessGateways(ListWirelessGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListWirelessGatewaysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWirelessGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGateways operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWirelessGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGateways">REST API Reference for ListWirelessGateways Operation</seealso>
        public virtual IAsyncResult BeginListWirelessGateways(ListWirelessGatewaysRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessGatewaysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWirelessGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWirelessGateways.</param>
        /// 
        /// <returns>Returns a  ListWirelessGatewaysResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGateways">REST API Reference for ListWirelessGateways Operation</seealso>
        public virtual ListWirelessGatewaysResponse EndListWirelessGateways(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWirelessGatewaysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWirelessGatewayTaskDefinitions

        /// <summary>
        /// List the wireless gateway tasks definitions registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGatewayTaskDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListWirelessGatewayTaskDefinitions service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGatewayTaskDefinitions">REST API Reference for ListWirelessGatewayTaskDefinitions Operation</seealso>
        public virtual ListWirelessGatewayTaskDefinitionsResponse ListWirelessGatewayTaskDefinitions(ListWirelessGatewayTaskDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessGatewayTaskDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessGatewayTaskDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListWirelessGatewayTaskDefinitionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWirelessGatewayTaskDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGatewayTaskDefinitions operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWirelessGatewayTaskDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGatewayTaskDefinitions">REST API Reference for ListWirelessGatewayTaskDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListWirelessGatewayTaskDefinitions(ListWirelessGatewayTaskDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessGatewayTaskDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessGatewayTaskDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWirelessGatewayTaskDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWirelessGatewayTaskDefinitions.</param>
        /// 
        /// <returns>Returns a  ListWirelessGatewayTaskDefinitionsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGatewayTaskDefinitions">REST API Reference for ListWirelessGatewayTaskDefinitions Operation</seealso>
        public virtual ListWirelessGatewayTaskDefinitionsResponse EndListWirelessGatewayTaskDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWirelessGatewayTaskDefinitionsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPositionConfiguration

        /// <summary>
        /// Put position configuration for a given resource.
        /// 
        ///  <important> 
        /// <para>
        /// This action is no longer supported. Calls to update the position configuration should
        /// use the <a href="https://docs.aws.amazon.com/iot-wireless/2020-11-22/apireference/API_UpdateResourcePosition.html">UpdateResourcePosition</a>
        /// API operation instead.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPositionConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutPositionConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/PutPositionConfiguration">REST API Reference for PutPositionConfiguration Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual PutPositionConfigurationResponse PutPositionConfiguration(PutPositionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPositionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPositionConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutPositionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutPositionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPositionConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPositionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/PutPositionConfiguration">REST API Reference for PutPositionConfiguration Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual IAsyncResult BeginPutPositionConfiguration(PutPositionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPositionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPositionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPositionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPositionConfiguration.</param>
        /// 
        /// <returns>Returns a  PutPositionConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/PutPositionConfiguration">REST API Reference for PutPositionConfiguration Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual PutPositionConfigurationResponse EndPutPositionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPositionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutResourceLogLevel

        /// <summary>
        /// Sets the log-level override for a resource-ID and resource-type. This option can be
        /// specified for a wireless gateway or a wireless device. A limit of 200 log level override
        /// can be set per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourceLogLevel service method.</param>
        /// 
        /// <returns>The response from the PutResourceLogLevel service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/PutResourceLogLevel">REST API Reference for PutResourceLogLevel Operation</seealso>
        public virtual PutResourceLogLevelResponse PutResourceLogLevel(PutResourceLogLevelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourceLogLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourceLogLevelResponseUnmarshaller.Instance;

            return Invoke<PutResourceLogLevelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourceLogLevel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourceLogLevel operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourceLogLevel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/PutResourceLogLevel">REST API Reference for PutResourceLogLevel Operation</seealso>
        public virtual IAsyncResult BeginPutResourceLogLevel(PutResourceLogLevelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourceLogLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourceLogLevelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourceLogLevel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourceLogLevel.</param>
        /// 
        /// <returns>Returns a  PutResourceLogLevelResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/PutResourceLogLevel">REST API Reference for PutResourceLogLevel Operation</seealso>
        public virtual PutResourceLogLevelResponse EndPutResourceLogLevel(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourceLogLevelResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetAllResourceLogLevels

        /// <summary>
        /// Removes the log-level overrides for all resources; both wireless devices and wireless
        /// gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetAllResourceLogLevels service method.</param>
        /// 
        /// <returns>The response from the ResetAllResourceLogLevels service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetAllResourceLogLevels">REST API Reference for ResetAllResourceLogLevels Operation</seealso>
        public virtual ResetAllResourceLogLevelsResponse ResetAllResourceLogLevels(ResetAllResourceLogLevelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetAllResourceLogLevelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetAllResourceLogLevelsResponseUnmarshaller.Instance;

            return Invoke<ResetAllResourceLogLevelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetAllResourceLogLevels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetAllResourceLogLevels operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetAllResourceLogLevels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetAllResourceLogLevels">REST API Reference for ResetAllResourceLogLevels Operation</seealso>
        public virtual IAsyncResult BeginResetAllResourceLogLevels(ResetAllResourceLogLevelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetAllResourceLogLevelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetAllResourceLogLevelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetAllResourceLogLevels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetAllResourceLogLevels.</param>
        /// 
        /// <returns>Returns a  ResetAllResourceLogLevelsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetAllResourceLogLevels">REST API Reference for ResetAllResourceLogLevels Operation</seealso>
        public virtual ResetAllResourceLogLevelsResponse EndResetAllResourceLogLevels(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetAllResourceLogLevelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetResourceLogLevel

        /// <summary>
        /// Removes the log-level override, if any, for a specific resource-ID and resource-type.
        /// It can be used for a wireless device or a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetResourceLogLevel service method.</param>
        /// 
        /// <returns>The response from the ResetResourceLogLevel service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetResourceLogLevel">REST API Reference for ResetResourceLogLevel Operation</seealso>
        public virtual ResetResourceLogLevelResponse ResetResourceLogLevel(ResetResourceLogLevelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetResourceLogLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetResourceLogLevelResponseUnmarshaller.Instance;

            return Invoke<ResetResourceLogLevelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetResourceLogLevel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetResourceLogLevel operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetResourceLogLevel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetResourceLogLevel">REST API Reference for ResetResourceLogLevel Operation</seealso>
        public virtual IAsyncResult BeginResetResourceLogLevel(ResetResourceLogLevelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetResourceLogLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetResourceLogLevelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetResourceLogLevel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetResourceLogLevel.</param>
        /// 
        /// <returns>Returns a  ResetResourceLogLevelResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetResourceLogLevel">REST API Reference for ResetResourceLogLevel Operation</seealso>
        public virtual ResetResourceLogLevelResponse EndResetResourceLogLevel(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetResourceLogLevelResponse>(asyncResult);
        }

        #endregion
        
        #region  SendDataToMulticastGroup

        /// <summary>
        /// Sends the specified data to a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataToMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the SendDataToMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToMulticastGroup">REST API Reference for SendDataToMulticastGroup Operation</seealso>
        public virtual SendDataToMulticastGroupResponse SendDataToMulticastGroup(SendDataToMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendDataToMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataToMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<SendDataToMulticastGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendDataToMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendDataToMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendDataToMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToMulticastGroup">REST API Reference for SendDataToMulticastGroup Operation</seealso>
        public virtual IAsyncResult BeginSendDataToMulticastGroup(SendDataToMulticastGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendDataToMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataToMulticastGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendDataToMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendDataToMulticastGroup.</param>
        /// 
        /// <returns>Returns a  SendDataToMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToMulticastGroup">REST API Reference for SendDataToMulticastGroup Operation</seealso>
        public virtual SendDataToMulticastGroupResponse EndSendDataToMulticastGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<SendDataToMulticastGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  SendDataToWirelessDevice

        /// <summary>
        /// Sends a decrypted application data frame to a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataToWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the SendDataToWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToWirelessDevice">REST API Reference for SendDataToWirelessDevice Operation</seealso>
        public virtual SendDataToWirelessDeviceResponse SendDataToWirelessDevice(SendDataToWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendDataToWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataToWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<SendDataToWirelessDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendDataToWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendDataToWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendDataToWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToWirelessDevice">REST API Reference for SendDataToWirelessDevice Operation</seealso>
        public virtual IAsyncResult BeginSendDataToWirelessDevice(SendDataToWirelessDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendDataToWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataToWirelessDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendDataToWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendDataToWirelessDevice.</param>
        /// 
        /// <returns>Returns a  SendDataToWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToWirelessDevice">REST API Reference for SendDataToWirelessDevice Operation</seealso>
        public virtual SendDataToWirelessDeviceResponse EndSendDataToWirelessDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<SendDataToWirelessDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartBulkAssociateWirelessDeviceWithMulticastGroup

        /// <summary>
        /// Starts a bulk association of all qualifying wireless devices with a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBulkAssociateWirelessDeviceWithMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the StartBulkAssociateWirelessDeviceWithMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkAssociateWirelessDeviceWithMulticastGroup">REST API Reference for StartBulkAssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        public virtual StartBulkAssociateWirelessDeviceWithMulticastGroupResponse StartBulkAssociateWirelessDeviceWithMulticastGroup(StartBulkAssociateWirelessDeviceWithMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBulkAssociateWirelessDeviceWithMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBulkAssociateWirelessDeviceWithMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<StartBulkAssociateWirelessDeviceWithMulticastGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartBulkAssociateWirelessDeviceWithMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBulkAssociateWirelessDeviceWithMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartBulkAssociateWirelessDeviceWithMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkAssociateWirelessDeviceWithMulticastGroup">REST API Reference for StartBulkAssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        public virtual IAsyncResult BeginStartBulkAssociateWirelessDeviceWithMulticastGroup(StartBulkAssociateWirelessDeviceWithMulticastGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBulkAssociateWirelessDeviceWithMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBulkAssociateWirelessDeviceWithMulticastGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartBulkAssociateWirelessDeviceWithMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartBulkAssociateWirelessDeviceWithMulticastGroup.</param>
        /// 
        /// <returns>Returns a  StartBulkAssociateWirelessDeviceWithMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkAssociateWirelessDeviceWithMulticastGroup">REST API Reference for StartBulkAssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        public virtual StartBulkAssociateWirelessDeviceWithMulticastGroupResponse EndStartBulkAssociateWirelessDeviceWithMulticastGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<StartBulkAssociateWirelessDeviceWithMulticastGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  StartBulkDisassociateWirelessDeviceFromMulticastGroup

        /// <summary>
        /// Starts a bulk disassociatin of all qualifying wireless devices from a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBulkDisassociateWirelessDeviceFromMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the StartBulkDisassociateWirelessDeviceFromMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkDisassociateWirelessDeviceFromMulticastGroup">REST API Reference for StartBulkDisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        public virtual StartBulkDisassociateWirelessDeviceFromMulticastGroupResponse StartBulkDisassociateWirelessDeviceFromMulticastGroup(StartBulkDisassociateWirelessDeviceFromMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBulkDisassociateWirelessDeviceFromMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBulkDisassociateWirelessDeviceFromMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<StartBulkDisassociateWirelessDeviceFromMulticastGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartBulkDisassociateWirelessDeviceFromMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBulkDisassociateWirelessDeviceFromMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartBulkDisassociateWirelessDeviceFromMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkDisassociateWirelessDeviceFromMulticastGroup">REST API Reference for StartBulkDisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        public virtual IAsyncResult BeginStartBulkDisassociateWirelessDeviceFromMulticastGroup(StartBulkDisassociateWirelessDeviceFromMulticastGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBulkDisassociateWirelessDeviceFromMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBulkDisassociateWirelessDeviceFromMulticastGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartBulkDisassociateWirelessDeviceFromMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartBulkDisassociateWirelessDeviceFromMulticastGroup.</param>
        /// 
        /// <returns>Returns a  StartBulkDisassociateWirelessDeviceFromMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkDisassociateWirelessDeviceFromMulticastGroup">REST API Reference for StartBulkDisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        public virtual StartBulkDisassociateWirelessDeviceFromMulticastGroupResponse EndStartBulkDisassociateWirelessDeviceFromMulticastGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<StartBulkDisassociateWirelessDeviceFromMulticastGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  StartFuotaTask

        /// <summary>
        /// Starts a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFuotaTask service method.</param>
        /// 
        /// <returns>The response from the StartFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartFuotaTask">REST API Reference for StartFuotaTask Operation</seealso>
        public virtual StartFuotaTaskResponse StartFuotaTask(StartFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<StartFuotaTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartFuotaTask">REST API Reference for StartFuotaTask Operation</seealso>
        public virtual IAsyncResult BeginStartFuotaTask(StartFuotaTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFuotaTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFuotaTask.</param>
        /// 
        /// <returns>Returns a  StartFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartFuotaTask">REST API Reference for StartFuotaTask Operation</seealso>
        public virtual StartFuotaTaskResponse EndStartFuotaTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartFuotaTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMulticastGroupSession

        /// <summary>
        /// Starts a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMulticastGroupSession service method.</param>
        /// 
        /// <returns>The response from the StartMulticastGroupSession service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartMulticastGroupSession">REST API Reference for StartMulticastGroupSession Operation</seealso>
        public virtual StartMulticastGroupSessionResponse StartMulticastGroupSession(StartMulticastGroupSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMulticastGroupSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMulticastGroupSessionResponseUnmarshaller.Instance;

            return Invoke<StartMulticastGroupSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMulticastGroupSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMulticastGroupSession operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMulticastGroupSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartMulticastGroupSession">REST API Reference for StartMulticastGroupSession Operation</seealso>
        public virtual IAsyncResult BeginStartMulticastGroupSession(StartMulticastGroupSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMulticastGroupSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMulticastGroupSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMulticastGroupSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMulticastGroupSession.</param>
        /// 
        /// <returns>Returns a  StartMulticastGroupSessionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartMulticastGroupSession">REST API Reference for StartMulticastGroupSession Operation</seealso>
        public virtual StartMulticastGroupSessionResponse EndStartMulticastGroupSession(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMulticastGroupSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  StartSingleWirelessDeviceImportTask

        /// <summary>
        /// Start import task for a single wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSingleWirelessDeviceImportTask service method.</param>
        /// 
        /// <returns>The response from the StartSingleWirelessDeviceImportTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartSingleWirelessDeviceImportTask">REST API Reference for StartSingleWirelessDeviceImportTask Operation</seealso>
        public virtual StartSingleWirelessDeviceImportTaskResponse StartSingleWirelessDeviceImportTask(StartSingleWirelessDeviceImportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSingleWirelessDeviceImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSingleWirelessDeviceImportTaskResponseUnmarshaller.Instance;

            return Invoke<StartSingleWirelessDeviceImportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSingleWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSingleWirelessDeviceImportTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSingleWirelessDeviceImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartSingleWirelessDeviceImportTask">REST API Reference for StartSingleWirelessDeviceImportTask Operation</seealso>
        public virtual IAsyncResult BeginStartSingleWirelessDeviceImportTask(StartSingleWirelessDeviceImportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSingleWirelessDeviceImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSingleWirelessDeviceImportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSingleWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSingleWirelessDeviceImportTask.</param>
        /// 
        /// <returns>Returns a  StartSingleWirelessDeviceImportTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartSingleWirelessDeviceImportTask">REST API Reference for StartSingleWirelessDeviceImportTask Operation</seealso>
        public virtual StartSingleWirelessDeviceImportTaskResponse EndStartSingleWirelessDeviceImportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSingleWirelessDeviceImportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  StartWirelessDeviceImportTask

        /// <summary>
        /// Start import task for provisioning Sidewalk devices in bulk using an S3 CSV file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWirelessDeviceImportTask service method.</param>
        /// 
        /// <returns>The response from the StartWirelessDeviceImportTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartWirelessDeviceImportTask">REST API Reference for StartWirelessDeviceImportTask Operation</seealso>
        public virtual StartWirelessDeviceImportTaskResponse StartWirelessDeviceImportTask(StartWirelessDeviceImportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWirelessDeviceImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWirelessDeviceImportTaskResponseUnmarshaller.Instance;

            return Invoke<StartWirelessDeviceImportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWirelessDeviceImportTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartWirelessDeviceImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartWirelessDeviceImportTask">REST API Reference for StartWirelessDeviceImportTask Operation</seealso>
        public virtual IAsyncResult BeginStartWirelessDeviceImportTask(StartWirelessDeviceImportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWirelessDeviceImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWirelessDeviceImportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartWirelessDeviceImportTask.</param>
        /// 
        /// <returns>Returns a  StartWirelessDeviceImportTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartWirelessDeviceImportTask">REST API Reference for StartWirelessDeviceImportTask Operation</seealso>
        public virtual StartWirelessDeviceImportTaskResponse EndStartWirelessDeviceImportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartWirelessDeviceImportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.TooManyTagsException">
        /// The request was denied because the resource can't have any more tags.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TestWirelessDevice

        /// <summary>
        /// Simulates a provisioned device by sending an uplink data payload of <code>Hello</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the TestWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TestWirelessDevice">REST API Reference for TestWirelessDevice Operation</seealso>
        public virtual TestWirelessDeviceResponse TestWirelessDevice(TestWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<TestWirelessDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TestWirelessDevice">REST API Reference for TestWirelessDevice Operation</seealso>
        public virtual IAsyncResult BeginTestWirelessDevice(TestWirelessDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestWirelessDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestWirelessDevice.</param>
        /// 
        /// <returns>Returns a  TestWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TestWirelessDevice">REST API Reference for TestWirelessDevice Operation</seealso>
        public virtual TestWirelessDeviceResponse EndTestWirelessDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<TestWirelessDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDestination

        /// <summary>
        /// Updates properties of a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual UpdateDestinationResponse UpdateDestination(UpdateDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual IAsyncResult BeginUpdateDestination(UpdateDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDestination.</param>
        /// 
        /// <returns>Returns a  UpdateDestinationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual UpdateDestinationResponse EndUpdateDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEventConfigurationByResourceTypes

        /// <summary>
        /// Update the event configuration based on resource types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventConfigurationByResourceTypes service method.</param>
        /// 
        /// <returns>The response from the UpdateEventConfigurationByResourceTypes service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateEventConfigurationByResourceTypes">REST API Reference for UpdateEventConfigurationByResourceTypes Operation</seealso>
        public virtual UpdateEventConfigurationByResourceTypesResponse UpdateEventConfigurationByResourceTypes(UpdateEventConfigurationByResourceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventConfigurationByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventConfigurationByResourceTypesResponseUnmarshaller.Instance;

            return Invoke<UpdateEventConfigurationByResourceTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventConfigurationByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventConfigurationByResourceTypes operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventConfigurationByResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateEventConfigurationByResourceTypes">REST API Reference for UpdateEventConfigurationByResourceTypes Operation</seealso>
        public virtual IAsyncResult BeginUpdateEventConfigurationByResourceTypes(UpdateEventConfigurationByResourceTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventConfigurationByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventConfigurationByResourceTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventConfigurationByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventConfigurationByResourceTypes.</param>
        /// 
        /// <returns>Returns a  UpdateEventConfigurationByResourceTypesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateEventConfigurationByResourceTypes">REST API Reference for UpdateEventConfigurationByResourceTypes Operation</seealso>
        public virtual UpdateEventConfigurationByResourceTypesResponse EndUpdateEventConfigurationByResourceTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEventConfigurationByResourceTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFuotaTask

        /// <summary>
        /// Updates properties of a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFuotaTask service method.</param>
        /// 
        /// <returns>The response from the UpdateFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateFuotaTask">REST API Reference for UpdateFuotaTask Operation</seealso>
        public virtual UpdateFuotaTaskResponse UpdateFuotaTask(UpdateFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<UpdateFuotaTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateFuotaTask">REST API Reference for UpdateFuotaTask Operation</seealso>
        public virtual IAsyncResult BeginUpdateFuotaTask(UpdateFuotaTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFuotaTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFuotaTask.</param>
        /// 
        /// <returns>Returns a  UpdateFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateFuotaTask">REST API Reference for UpdateFuotaTask Operation</seealso>
        public virtual UpdateFuotaTaskResponse EndUpdateFuotaTask(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFuotaTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLogLevelsByResourceTypes

        /// <summary>
        /// Set default log level, or log levels by resource types. This can be for wireless device
        /// log options or wireless gateways log options and is used to control the log messages
        /// that'll be displayed in CloudWatch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogLevelsByResourceTypes service method.</param>
        /// 
        /// <returns>The response from the UpdateLogLevelsByResourceTypes service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateLogLevelsByResourceTypes">REST API Reference for UpdateLogLevelsByResourceTypes Operation</seealso>
        public virtual UpdateLogLevelsByResourceTypesResponse UpdateLogLevelsByResourceTypes(UpdateLogLevelsByResourceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLogLevelsByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLogLevelsByResourceTypesResponseUnmarshaller.Instance;

            return Invoke<UpdateLogLevelsByResourceTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLogLevelsByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogLevelsByResourceTypes operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLogLevelsByResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateLogLevelsByResourceTypes">REST API Reference for UpdateLogLevelsByResourceTypes Operation</seealso>
        public virtual IAsyncResult BeginUpdateLogLevelsByResourceTypes(UpdateLogLevelsByResourceTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLogLevelsByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLogLevelsByResourceTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLogLevelsByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLogLevelsByResourceTypes.</param>
        /// 
        /// <returns>Returns a  UpdateLogLevelsByResourceTypesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateLogLevelsByResourceTypes">REST API Reference for UpdateLogLevelsByResourceTypes Operation</seealso>
        public virtual UpdateLogLevelsByResourceTypesResponse EndUpdateLogLevelsByResourceTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLogLevelsByResourceTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMulticastGroup

        /// <summary>
        /// Updates properties of a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateMulticastGroup">REST API Reference for UpdateMulticastGroup Operation</seealso>
        public virtual UpdateMulticastGroupResponse UpdateMulticastGroup(UpdateMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateMulticastGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateMulticastGroup">REST API Reference for UpdateMulticastGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateMulticastGroup(UpdateMulticastGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMulticastGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMulticastGroup.</param>
        /// 
        /// <returns>Returns a  UpdateMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateMulticastGroup">REST API Reference for UpdateMulticastGroup Operation</seealso>
        public virtual UpdateMulticastGroupResponse EndUpdateMulticastGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMulticastGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNetworkAnalyzerConfiguration

        /// <summary>
        /// Update network analyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkAnalyzerConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkAnalyzerConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateNetworkAnalyzerConfiguration">REST API Reference for UpdateNetworkAnalyzerConfiguration Operation</seealso>
        public virtual UpdateNetworkAnalyzerConfigurationResponse UpdateNetworkAnalyzerConfiguration(UpdateNetworkAnalyzerConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkAnalyzerConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkAnalyzerConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNetworkAnalyzerConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateNetworkAnalyzerConfiguration">REST API Reference for UpdateNetworkAnalyzerConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateNetworkAnalyzerConfiguration(UpdateNetworkAnalyzerConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNetworkAnalyzerConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateNetworkAnalyzerConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateNetworkAnalyzerConfiguration">REST API Reference for UpdateNetworkAnalyzerConfiguration Operation</seealso>
        public virtual UpdateNetworkAnalyzerConfigurationResponse EndUpdateNetworkAnalyzerConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNetworkAnalyzerConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePartnerAccount

        /// <summary>
        /// Updates properties of a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnerAccount service method.</param>
        /// 
        /// <returns>The response from the UpdatePartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePartnerAccount">REST API Reference for UpdatePartnerAccount Operation</seealso>
        public virtual UpdatePartnerAccountResponse UpdatePartnerAccount(UpdatePartnerAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartnerAccountResponseUnmarshaller.Instance;

            return Invoke<UpdatePartnerAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnerAccount operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePartnerAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePartnerAccount">REST API Reference for UpdatePartnerAccount Operation</seealso>
        public virtual IAsyncResult BeginUpdatePartnerAccount(UpdatePartnerAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartnerAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePartnerAccount.</param>
        /// 
        /// <returns>Returns a  UpdatePartnerAccountResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePartnerAccount">REST API Reference for UpdatePartnerAccount Operation</seealso>
        public virtual UpdatePartnerAccountResponse EndUpdatePartnerAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePartnerAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePosition

        /// <summary>
        /// Update the position information of a resource.
        /// 
        ///  <important> 
        /// <para>
        /// This action is no longer supported. Calls to update the position information should
        /// use the <a href="https://docs.aws.amazon.com/iot-wireless/2020-11-22/apireference/API_UpdateResourcePosition.html">UpdateResourcePosition</a>
        /// API operation instead.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePosition service method.</param>
        /// 
        /// <returns>The response from the UpdatePosition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePosition">REST API Reference for UpdatePosition Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual UpdatePositionResponse UpdatePosition(UpdatePositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePositionResponseUnmarshaller.Instance;

            return Invoke<UpdatePositionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePosition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePosition">REST API Reference for UpdatePosition Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual IAsyncResult BeginUpdatePosition(UpdatePositionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePositionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePosition.</param>
        /// 
        /// <returns>Returns a  UpdatePositionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePosition">REST API Reference for UpdatePosition Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        public virtual UpdatePositionResponse EndUpdatePosition(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePositionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateResourceEventConfiguration

        /// <summary>
        /// Update the event configuration for a particular resource identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceEventConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceEventConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateResourceEventConfiguration">REST API Reference for UpdateResourceEventConfiguration Operation</seealso>
        public virtual UpdateResourceEventConfigurationResponse UpdateResourceEventConfiguration(UpdateResourceEventConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceEventConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceEventConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceEventConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceEventConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourceEventConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateResourceEventConfiguration">REST API Reference for UpdateResourceEventConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateResourceEventConfiguration(UpdateResourceEventConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceEventConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourceEventConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourceEventConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateResourceEventConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateResourceEventConfiguration">REST API Reference for UpdateResourceEventConfiguration Operation</seealso>
        public virtual UpdateResourceEventConfigurationResponse EndUpdateResourceEventConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResourceEventConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateResourcePosition

        /// <summary>
        /// Update the position information of a given wireless device or a wireless gateway resource.
        /// The position coordinates are based on the <a href="https://gisgeography.com/wgs84-world-geodetic-system/">
        /// World Geodetic System (WGS84)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourcePosition service method.</param>
        /// 
        /// <returns>The response from the UpdateResourcePosition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateResourcePosition">REST API Reference for UpdateResourcePosition Operation</seealso>
        public virtual UpdateResourcePositionResponse UpdateResourcePosition(UpdateResourcePositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourcePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourcePositionResponseUnmarshaller.Instance;

            return Invoke<UpdateResourcePositionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourcePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourcePosition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourcePosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateResourcePosition">REST API Reference for UpdateResourcePosition Operation</seealso>
        public virtual IAsyncResult BeginUpdateResourcePosition(UpdateResourcePositionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourcePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourcePositionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourcePosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourcePosition.</param>
        /// 
        /// <returns>Returns a  UpdateResourcePositionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateResourcePosition">REST API Reference for UpdateResourcePosition Operation</seealso>
        public virtual UpdateResourcePositionResponse EndUpdateResourcePosition(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResourcePositionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWirelessDevice

        /// <summary>
        /// Updates properties of a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the UpdateWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDevice">REST API Reference for UpdateWirelessDevice Operation</seealso>
        public virtual UpdateWirelessDeviceResponse UpdateWirelessDevice(UpdateWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<UpdateWirelessDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDevice">REST API Reference for UpdateWirelessDevice Operation</seealso>
        public virtual IAsyncResult BeginUpdateWirelessDevice(UpdateWirelessDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWirelessDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWirelessDevice.</param>
        /// 
        /// <returns>Returns a  UpdateWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDevice">REST API Reference for UpdateWirelessDevice Operation</seealso>
        public virtual UpdateWirelessDeviceResponse EndUpdateWirelessDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWirelessDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWirelessDeviceImportTask

        /// <summary>
        /// Update an import task to add more devices to the task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessDeviceImportTask service method.</param>
        /// 
        /// <returns>The response from the UpdateWirelessDeviceImportTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDeviceImportTask">REST API Reference for UpdateWirelessDeviceImportTask Operation</seealso>
        public virtual UpdateWirelessDeviceImportTaskResponse UpdateWirelessDeviceImportTask(UpdateWirelessDeviceImportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWirelessDeviceImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWirelessDeviceImportTaskResponseUnmarshaller.Instance;

            return Invoke<UpdateWirelessDeviceImportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessDeviceImportTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWirelessDeviceImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDeviceImportTask">REST API Reference for UpdateWirelessDeviceImportTask Operation</seealso>
        public virtual IAsyncResult BeginUpdateWirelessDeviceImportTask(UpdateWirelessDeviceImportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWirelessDeviceImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWirelessDeviceImportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWirelessDeviceImportTask.</param>
        /// 
        /// <returns>Returns a  UpdateWirelessDeviceImportTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDeviceImportTask">REST API Reference for UpdateWirelessDeviceImportTask Operation</seealso>
        public virtual UpdateWirelessDeviceImportTaskResponse EndUpdateWirelessDeviceImportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWirelessDeviceImportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWirelessGateway

        /// <summary>
        /// Updates properties of a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the UpdateWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessGateway">REST API Reference for UpdateWirelessGateway Operation</seealso>
        public virtual UpdateWirelessGatewayResponse UpdateWirelessGateway(UpdateWirelessGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWirelessGatewayResponseUnmarshaller.Instance;

            return Invoke<UpdateWirelessGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessGateway operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWirelessGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessGateway">REST API Reference for UpdateWirelessGateway Operation</seealso>
        public virtual IAsyncResult BeginUpdateWirelessGateway(UpdateWirelessGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWirelessGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWirelessGateway.</param>
        /// 
        /// <returns>Returns a  UpdateWirelessGatewayResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessGateway">REST API Reference for UpdateWirelessGateway Operation</seealso>
        public virtual UpdateWirelessGatewayResponse EndUpdateWirelessGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWirelessGatewayResponse>(asyncResult);
        }

        #endregion
        
    }
}