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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
#if AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
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

        internal virtual AssociateAwsAccountWithPartnerAccountResponse AssociateAwsAccountWithPartnerAccount(AssociateAwsAccountWithPartnerAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAwsAccountWithPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAwsAccountWithPartnerAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateAwsAccountWithPartnerAccountResponse>(request, options);
        }



        /// <summary>
        /// Associates a partner account with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsAccountWithPartnerAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateAwsAccountWithPartnerAccountResponse> AssociateAwsAccountWithPartnerAccountAsync(AssociateAwsAccountWithPartnerAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAwsAccountWithPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAwsAccountWithPartnerAccountResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAwsAccountWithPartnerAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateMulticastGroupWithFuotaTask

        internal virtual AssociateMulticastGroupWithFuotaTaskResponse AssociateMulticastGroupWithFuotaTask(AssociateMulticastGroupWithFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateMulticastGroupWithFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMulticastGroupWithFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<AssociateMulticastGroupWithFuotaTaskResponse>(request, options);
        }



        /// <summary>
        /// Associate a multicast group with a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMulticastGroupWithFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateMulticastGroupWithFuotaTaskResponse> AssociateMulticastGroupWithFuotaTaskAsync(AssociateMulticastGroupWithFuotaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateMulticastGroupWithFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMulticastGroupWithFuotaTaskResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateMulticastGroupWithFuotaTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateWirelessDeviceWithFuotaTask

        internal virtual AssociateWirelessDeviceWithFuotaTaskResponse AssociateWirelessDeviceWithFuotaTask(AssociateWirelessDeviceWithFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessDeviceWithFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessDeviceWithFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<AssociateWirelessDeviceWithFuotaTaskResponse>(request, options);
        }



        /// <summary>
        /// Associate a wireless device with a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateWirelessDeviceWithFuotaTaskResponse> AssociateWirelessDeviceWithFuotaTaskAsync(AssociateWirelessDeviceWithFuotaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessDeviceWithFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessDeviceWithFuotaTaskResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateWirelessDeviceWithFuotaTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateWirelessDeviceWithMulticastGroup

        internal virtual AssociateWirelessDeviceWithMulticastGroupResponse AssociateWirelessDeviceWithMulticastGroup(AssociateWirelessDeviceWithMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessDeviceWithMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessDeviceWithMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<AssociateWirelessDeviceWithMulticastGroupResponse>(request, options);
        }



        /// <summary>
        /// Associates a wireless device with a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateWirelessDeviceWithMulticastGroupResponse> AssociateWirelessDeviceWithMulticastGroupAsync(AssociateWirelessDeviceWithMulticastGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessDeviceWithMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessDeviceWithMulticastGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateWirelessDeviceWithMulticastGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateWirelessDeviceWithThing

        internal virtual AssociateWirelessDeviceWithThingResponse AssociateWirelessDeviceWithThing(AssociateWirelessDeviceWithThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessDeviceWithThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessDeviceWithThingResponseUnmarshaller.Instance;

            return Invoke<AssociateWirelessDeviceWithThingResponse>(request, options);
        }



        /// <summary>
        /// Associates a wireless device with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateWirelessDeviceWithThingResponse> AssociateWirelessDeviceWithThingAsync(AssociateWirelessDeviceWithThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessDeviceWithThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessDeviceWithThingResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateWirelessDeviceWithThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateWirelessGatewayWithCertificate

        internal virtual AssociateWirelessGatewayWithCertificateResponse AssociateWirelessGatewayWithCertificate(AssociateWirelessGatewayWithCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessGatewayWithCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessGatewayWithCertificateResponseUnmarshaller.Instance;

            return Invoke<AssociateWirelessGatewayWithCertificateResponse>(request, options);
        }



        /// <summary>
        /// Associates a wireless gateway with a certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateWirelessGatewayWithCertificateResponse> AssociateWirelessGatewayWithCertificateAsync(AssociateWirelessGatewayWithCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessGatewayWithCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessGatewayWithCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateWirelessGatewayWithCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateWirelessGatewayWithThing

        internal virtual AssociateWirelessGatewayWithThingResponse AssociateWirelessGatewayWithThing(AssociateWirelessGatewayWithThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessGatewayWithThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessGatewayWithThingResponseUnmarshaller.Instance;

            return Invoke<AssociateWirelessGatewayWithThingResponse>(request, options);
        }



        /// <summary>
        /// Associates a wireless gateway with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateWirelessGatewayWithThingResponse> AssociateWirelessGatewayWithThingAsync(AssociateWirelessGatewayWithThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessGatewayWithThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessGatewayWithThingResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateWirelessGatewayWithThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelMulticastGroupSession

        internal virtual CancelMulticastGroupSessionResponse CancelMulticastGroupSession(CancelMulticastGroupSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMulticastGroupSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMulticastGroupSessionResponseUnmarshaller.Instance;

            return Invoke<CancelMulticastGroupSessionResponse>(request, options);
        }



        /// <summary>
        /// Cancels an existing multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMulticastGroupSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelMulticastGroupSessionResponse> CancelMulticastGroupSessionAsync(CancelMulticastGroupSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMulticastGroupSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMulticastGroupSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelMulticastGroupSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDestination

        internal virtual CreateDestinationResponse CreateDestination(CreateDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateDestinationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new destination that maps a device message to an AWS IoT rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateDestinationResponse> CreateDestinationAsync(CreateDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDeviceProfile

        internal virtual CreateDeviceProfileResponse CreateDeviceProfile(CreateDeviceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateDeviceProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates a new device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateDeviceProfileResponse> CreateDeviceProfileAsync(CreateDeviceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeviceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFuotaTask

        internal virtual CreateFuotaTaskResponse CreateFuotaTask(CreateFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<CreateFuotaTaskResponse>(request, options);
        }



        /// <summary>
        /// Creates a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateFuotaTaskResponse> CreateFuotaTaskAsync(CreateFuotaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFuotaTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFuotaTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMulticastGroup

        internal virtual CreateMulticastGroupResponse CreateMulticastGroup(CreateMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<CreateMulticastGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateMulticastGroupResponse> CreateMulticastGroupAsync(CreateMulticastGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMulticastGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMulticastGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkAnalyzerConfiguration

        internal virtual CreateNetworkAnalyzerConfigurationResponse CreateNetworkAnalyzerConfiguration(CreateNetworkAnalyzerConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkAnalyzerConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new network analyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAnalyzerConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateNetworkAnalyzerConfigurationResponse> CreateNetworkAnalyzerConfigurationAsync(CreateNetworkAnalyzerConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkAnalyzerConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateServiceProfile

        internal virtual CreateServiceProfileResponse CreateServiceProfile(CreateServiceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateServiceProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates a new service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateServiceProfileResponse> CreateServiceProfileAsync(CreateServiceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateServiceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWirelessDevice

        internal virtual CreateWirelessDeviceResponse CreateWirelessDevice(CreateWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<CreateWirelessDeviceResponse>(request, options);
        }



        /// <summary>
        /// Provisions a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateWirelessDeviceResponse> CreateWirelessDeviceAsync(CreateWirelessDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWirelessDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWirelessGateway

        internal virtual CreateWirelessGatewayResponse CreateWirelessGateway(CreateWirelessGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateWirelessGatewayResponse>(request, options);
        }



        /// <summary>
        /// Provisions a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateWirelessGatewayResponse> CreateWirelessGatewayAsync(CreateWirelessGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWirelessGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWirelessGatewayTask

        internal virtual CreateWirelessGatewayTaskResponse CreateWirelessGatewayTask(CreateWirelessGatewayTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayTaskResponseUnmarshaller.Instance;

            return Invoke<CreateWirelessGatewayTaskResponse>(request, options);
        }



        /// <summary>
        /// Creates a task for a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateWirelessGatewayTaskResponse> CreateWirelessGatewayTaskAsync(CreateWirelessGatewayTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWirelessGatewayTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWirelessGatewayTaskDefinition

        internal virtual CreateWirelessGatewayTaskDefinitionResponse CreateWirelessGatewayTaskDefinition(CreateWirelessGatewayTaskDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateWirelessGatewayTaskDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a gateway task definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTaskDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateWirelessGatewayTaskDefinitionResponse> CreateWirelessGatewayTaskDefinitionAsync(CreateWirelessGatewayTaskDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWirelessGatewayTaskDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDestination

        internal virtual DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteDestinationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteDestinationResponse> DeleteDestinationAsync(DeleteDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDeviceProfile

        internal virtual DeleteDeviceProfileResponse DeleteDeviceProfile(DeleteDeviceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteDeviceProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes a device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteDeviceProfileResponse> DeleteDeviceProfileAsync(DeleteDeviceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeviceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFuotaTask

        internal virtual DeleteFuotaTaskResponse DeleteFuotaTask(DeleteFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteFuotaTaskResponse>(request, options);
        }



        /// <summary>
        /// Deletes a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteFuotaTaskResponse> DeleteFuotaTaskAsync(DeleteFuotaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFuotaTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFuotaTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMulticastGroup

        internal virtual DeleteMulticastGroupResponse DeleteMulticastGroup(DeleteMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteMulticastGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a multicast group if it is not in use by a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteMulticastGroupResponse> DeleteMulticastGroupAsync(DeleteMulticastGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMulticastGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMulticastGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkAnalyzerConfiguration

        internal virtual DeleteNetworkAnalyzerConfigurationResponse DeleteNetworkAnalyzerConfiguration(DeleteNetworkAnalyzerConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkAnalyzerConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a network analyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAnalyzerConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteNetworkAnalyzerConfigurationResponse> DeleteNetworkAnalyzerConfigurationAsync(DeleteNetworkAnalyzerConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkAnalyzerConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteQueuedMessages

        internal virtual DeleteQueuedMessagesResponse DeleteQueuedMessages(DeleteQueuedMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQueuedMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueuedMessagesResponseUnmarshaller.Instance;

            return Invoke<DeleteQueuedMessagesResponse>(request, options);
        }



        /// <summary>
        /// Remove queued messages from the downlink queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueuedMessages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteQueuedMessagesResponse> DeleteQueuedMessagesAsync(DeleteQueuedMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQueuedMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueuedMessagesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteQueuedMessagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceProfile

        internal virtual DeleteServiceProfileResponse DeleteServiceProfile(DeleteServiceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes a service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteServiceProfileResponse> DeleteServiceProfileAsync(DeleteServiceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServiceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWirelessDevice

        internal virtual DeleteWirelessDeviceResponse DeleteWirelessDevice(DeleteWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteWirelessDeviceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteWirelessDeviceResponse> DeleteWirelessDeviceAsync(DeleteWirelessDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWirelessDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWirelessGateway

        internal virtual DeleteWirelessGatewayResponse DeleteWirelessGateway(DeleteWirelessGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteWirelessGatewayResponse>(request, options);
        }



        /// <summary>
        /// Deletes a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteWirelessGatewayResponse> DeleteWirelessGatewayAsync(DeleteWirelessGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWirelessGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWirelessGatewayTask

        internal virtual DeleteWirelessGatewayTaskResponse DeleteWirelessGatewayTask(DeleteWirelessGatewayTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteWirelessGatewayTaskResponse>(request, options);
        }



        /// <summary>
        /// Deletes a wireless gateway task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteWirelessGatewayTaskResponse> DeleteWirelessGatewayTaskAsync(DeleteWirelessGatewayTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWirelessGatewayTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWirelessGatewayTaskDefinition

        internal virtual DeleteWirelessGatewayTaskDefinitionResponse DeleteWirelessGatewayTaskDefinition(DeleteWirelessGatewayTaskDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteWirelessGatewayTaskDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a wireless gateway task definition. Deleting this task definition does not
        /// affect tasks that are currently in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTaskDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteWirelessGatewayTaskDefinitionResponse> DeleteWirelessGatewayTaskDefinitionAsync(DeleteWirelessGatewayTaskDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWirelessGatewayTaskDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateAwsAccountFromPartnerAccount

        internal virtual DisassociateAwsAccountFromPartnerAccountResponse DisassociateAwsAccountFromPartnerAccount(DisassociateAwsAccountFromPartnerAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAwsAccountFromPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAwsAccountFromPartnerAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateAwsAccountFromPartnerAccountResponse>(request, options);
        }



        /// <summary>
        /// Disassociates your AWS account from a partner account. If <code>PartnerAccountId</code>
        /// and <code>PartnerType</code> are <code>null</code>, disassociates your AWS account
        /// from all partner accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsAccountFromPartnerAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisassociateAwsAccountFromPartnerAccountResponse> DisassociateAwsAccountFromPartnerAccountAsync(DisassociateAwsAccountFromPartnerAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAwsAccountFromPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAwsAccountFromPartnerAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAwsAccountFromPartnerAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMulticastGroupFromFuotaTask

        internal virtual DisassociateMulticastGroupFromFuotaTaskResponse DisassociateMulticastGroupFromFuotaTask(DisassociateMulticastGroupFromFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMulticastGroupFromFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMulticastGroupFromFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<DisassociateMulticastGroupFromFuotaTaskResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a multicast group from a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMulticastGroupFromFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisassociateMulticastGroupFromFuotaTaskResponse> DisassociateMulticastGroupFromFuotaTaskAsync(DisassociateMulticastGroupFromFuotaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMulticastGroupFromFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMulticastGroupFromFuotaTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateMulticastGroupFromFuotaTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateWirelessDeviceFromFuotaTask

        internal virtual DisassociateWirelessDeviceFromFuotaTaskResponse DisassociateWirelessDeviceFromFuotaTask(DisassociateWirelessDeviceFromFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessDeviceFromFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessDeviceFromFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<DisassociateWirelessDeviceFromFuotaTaskResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a wireless device from a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisassociateWirelessDeviceFromFuotaTaskResponse> DisassociateWirelessDeviceFromFuotaTaskAsync(DisassociateWirelessDeviceFromFuotaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessDeviceFromFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessDeviceFromFuotaTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateWirelessDeviceFromFuotaTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateWirelessDeviceFromMulticastGroup

        internal virtual DisassociateWirelessDeviceFromMulticastGroupResponse DisassociateWirelessDeviceFromMulticastGroup(DisassociateWirelessDeviceFromMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessDeviceFromMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessDeviceFromMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociateWirelessDeviceFromMulticastGroupResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a wireless device from a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisassociateWirelessDeviceFromMulticastGroupResponse> DisassociateWirelessDeviceFromMulticastGroupAsync(DisassociateWirelessDeviceFromMulticastGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessDeviceFromMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessDeviceFromMulticastGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateWirelessDeviceFromMulticastGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateWirelessDeviceFromThing

        internal virtual DisassociateWirelessDeviceFromThingResponse DisassociateWirelessDeviceFromThing(DisassociateWirelessDeviceFromThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessDeviceFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessDeviceFromThingResponseUnmarshaller.Instance;

            return Invoke<DisassociateWirelessDeviceFromThingResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a wireless device from its currently associated thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisassociateWirelessDeviceFromThingResponse> DisassociateWirelessDeviceFromThingAsync(DisassociateWirelessDeviceFromThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessDeviceFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessDeviceFromThingResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateWirelessDeviceFromThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateWirelessGatewayFromCertificate

        internal virtual DisassociateWirelessGatewayFromCertificateResponse DisassociateWirelessGatewayFromCertificate(DisassociateWirelessGatewayFromCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessGatewayFromCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessGatewayFromCertificateResponseUnmarshaller.Instance;

            return Invoke<DisassociateWirelessGatewayFromCertificateResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a wireless gateway from its currently associated certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisassociateWirelessGatewayFromCertificateResponse> DisassociateWirelessGatewayFromCertificateAsync(DisassociateWirelessGatewayFromCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessGatewayFromCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessGatewayFromCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateWirelessGatewayFromCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateWirelessGatewayFromThing

        internal virtual DisassociateWirelessGatewayFromThingResponse DisassociateWirelessGatewayFromThing(DisassociateWirelessGatewayFromThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessGatewayFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessGatewayFromThingResponseUnmarshaller.Instance;

            return Invoke<DisassociateWirelessGatewayFromThingResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a wireless gateway from its currently associated thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisassociateWirelessGatewayFromThingResponse> DisassociateWirelessGatewayFromThingAsync(DisassociateWirelessGatewayFromThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessGatewayFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessGatewayFromThingResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateWirelessGatewayFromThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDestination

        internal virtual GetDestinationResponse GetDestination(GetDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDestinationResponseUnmarshaller.Instance;

            return Invoke<GetDestinationResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetDestinationResponse> GetDestinationAsync(GetDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<GetDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeviceProfile

        internal virtual GetDeviceProfileResponse GetDeviceProfile(GetDeviceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceProfileResponseUnmarshaller.Instance;

            return Invoke<GetDeviceProfileResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetDeviceProfileResponse> GetDeviceProfileAsync(GetDeviceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEventConfigurationByResourceTypes

        internal virtual GetEventConfigurationByResourceTypesResponse GetEventConfigurationByResourceTypes(GetEventConfigurationByResourceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventConfigurationByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventConfigurationByResourceTypesResponseUnmarshaller.Instance;

            return Invoke<GetEventConfigurationByResourceTypesResponse>(request, options);
        }



        /// <summary>
        /// Get the event configuration based on resource types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventConfigurationByResourceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetEventConfigurationByResourceTypesResponse> GetEventConfigurationByResourceTypesAsync(GetEventConfigurationByResourceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventConfigurationByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventConfigurationByResourceTypesResponseUnmarshaller.Instance;

            return InvokeAsync<GetEventConfigurationByResourceTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFuotaTask

        internal virtual GetFuotaTaskResponse GetFuotaTask(GetFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<GetFuotaTaskResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetFuotaTaskResponse> GetFuotaTaskAsync(GetFuotaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFuotaTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetFuotaTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLogLevelsByResourceTypes

        internal virtual GetLogLevelsByResourceTypesResponse GetLogLevelsByResourceTypes(GetLogLevelsByResourceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogLevelsByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogLevelsByResourceTypesResponseUnmarshaller.Instance;

            return Invoke<GetLogLevelsByResourceTypesResponse>(request, options);
        }



        /// <summary>
        /// Returns current default log levels or log levels by resource types. Based on resource
        /// types, log levels can be for wireless device log options or wireless gateway log options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogLevelsByResourceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetLogLevelsByResourceTypesResponse> GetLogLevelsByResourceTypesAsync(GetLogLevelsByResourceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogLevelsByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogLevelsByResourceTypesResponseUnmarshaller.Instance;

            return InvokeAsync<GetLogLevelsByResourceTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMulticastGroup

        internal virtual GetMulticastGroupResponse GetMulticastGroup(GetMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<GetMulticastGroupResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetMulticastGroupResponse> GetMulticastGroupAsync(GetMulticastGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMulticastGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetMulticastGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMulticastGroupSession

        internal virtual GetMulticastGroupSessionResponse GetMulticastGroupSession(GetMulticastGroupSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMulticastGroupSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMulticastGroupSessionResponseUnmarshaller.Instance;

            return Invoke<GetMulticastGroupSessionResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMulticastGroupSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetMulticastGroupSessionResponse> GetMulticastGroupSessionAsync(GetMulticastGroupSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMulticastGroupSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMulticastGroupSessionResponseUnmarshaller.Instance;

            return InvokeAsync<GetMulticastGroupSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNetworkAnalyzerConfiguration

        internal virtual GetNetworkAnalyzerConfigurationResponse GetNetworkAnalyzerConfiguration(GetNetworkAnalyzerConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetNetworkAnalyzerConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Get network analyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkAnalyzerConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetNetworkAnalyzerConfigurationResponse> GetNetworkAnalyzerConfigurationAsync(GetNetworkAnalyzerConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetNetworkAnalyzerConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPartnerAccount

        internal virtual GetPartnerAccountResponse GetPartnerAccount(GetPartnerAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartnerAccountResponseUnmarshaller.Instance;

            return Invoke<GetPartnerAccountResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a partner account. If <code>PartnerAccountId</code> and <code>PartnerType</code>
        /// are <code>null</code>, returns all partner accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartnerAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetPartnerAccountResponse> GetPartnerAccountAsync(GetPartnerAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartnerAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetPartnerAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPosition

        [Obsolete("This operation is no longer supported.")]
        internal virtual GetPositionResponse GetPosition(GetPositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPositionResponseUnmarshaller.Instance;

            return Invoke<GetPositionResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetPositionResponse> GetPositionAsync(GetPositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPositionResponseUnmarshaller.Instance;

            return InvokeAsync<GetPositionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPositionConfiguration

        [Obsolete("This operation is no longer supported.")]
        internal virtual GetPositionConfigurationResponse GetPositionConfiguration(GetPositionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPositionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPositionConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetPositionConfigurationResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetPositionConfigurationResponse> GetPositionConfigurationAsync(GetPositionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPositionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPositionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetPositionConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPositionEstimate

        internal virtual GetPositionEstimateResponse GetPositionEstimate(GetPositionEstimateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPositionEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPositionEstimateResponseUnmarshaller.Instance;

            return Invoke<GetPositionEstimateResponse>(request, options);
        }



        /// <summary>
        /// Get estimated position information as a payload in GeoJSON format. The payload measurement
        /// data is resolved using solvers that are provided by third-party vendors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPositionEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetPositionEstimateResponse> GetPositionEstimateAsync(GetPositionEstimateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPositionEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPositionEstimateResponseUnmarshaller.Instance;

            return InvokeAsync<GetPositionEstimateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourceEventConfiguration

        internal virtual GetResourceEventConfigurationResponse GetResourceEventConfiguration(GetResourceEventConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceEventConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetResourceEventConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Get the event configuration for a particular resource identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceEventConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetResourceEventConfigurationResponse> GetResourceEventConfigurationAsync(GetResourceEventConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceEventConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceEventConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourceLogLevel

        internal virtual GetResourceLogLevelResponse GetResourceLogLevel(GetResourceLogLevelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceLogLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceLogLevelResponseUnmarshaller.Instance;

            return Invoke<GetResourceLogLevelResponse>(request, options);
        }



        /// <summary>
        /// Fetches the log-level override, if any, for a given resource-ID and resource-type.
        /// It can be used for a wireless device or a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceLogLevel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetResourceLogLevelResponse> GetResourceLogLevelAsync(GetResourceLogLevelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceLogLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceLogLevelResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceLogLevelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourcePosition

        internal virtual GetResourcePositionResponse GetResourcePosition(GetResourcePositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePositionResponseUnmarshaller.Instance;

            return Invoke<GetResourcePositionResponse>(request, options);
        }



        /// <summary>
        /// Get the position information for a given wireless device or a wireless gateway resource.
        /// The postion information uses the <a href="https://gisgeography.com/wgs84-world-geodetic-system/">
        /// World Geodetic System (WGS84)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePosition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetResourcePositionResponse> GetResourcePositionAsync(GetResourcePositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePositionResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePositionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceEndpoint

        internal virtual GetServiceEndpointResponse GetServiceEndpoint(GetServiceEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceEndpointResponseUnmarshaller.Instance;

            return Invoke<GetServiceEndpointResponse>(request, options);
        }



        /// <summary>
        /// Gets the account-specific endpoint for Configuration and Update Server (CUPS) protocol
        /// or LoRaWAN Network Server (LNS) connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetServiceEndpointResponse> GetServiceEndpointAsync(GetServiceEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceProfile

        internal virtual GetServiceProfileResponse GetServiceProfile(GetServiceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceProfileResponseUnmarshaller.Instance;

            return Invoke<GetServiceProfileResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetServiceProfileResponse> GetServiceProfileAsync(GetServiceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWirelessDevice

        internal virtual GetWirelessDeviceResponse GetWirelessDevice(GetWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<GetWirelessDeviceResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetWirelessDeviceResponse> GetWirelessDeviceAsync(GetWirelessDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<GetWirelessDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWirelessDeviceStatistics

        internal virtual GetWirelessDeviceStatisticsResponse GetWirelessDeviceStatistics(GetWirelessDeviceStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessDeviceStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessDeviceStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetWirelessDeviceStatisticsResponse>(request, options);
        }



        /// <summary>
        /// Gets operating information about a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDeviceStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetWirelessDeviceStatisticsResponse> GetWirelessDeviceStatisticsAsync(GetWirelessDeviceStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessDeviceStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessDeviceStatisticsResponseUnmarshaller.Instance;

            return InvokeAsync<GetWirelessDeviceStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWirelessGateway

        internal virtual GetWirelessGatewayResponse GetWirelessGateway(GetWirelessGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetWirelessGatewayResponse> GetWirelessGatewayAsync(GetWirelessGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<GetWirelessGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWirelessGatewayCertificate

        internal virtual GetWirelessGatewayCertificateResponse GetWirelessGatewayCertificate(GetWirelessGatewayCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayCertificateResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayCertificateResponse>(request, options);
        }



        /// <summary>
        /// Gets the ID of the certificate that is currently associated with a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetWirelessGatewayCertificateResponse> GetWirelessGatewayCertificateAsync(GetWirelessGatewayCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GetWirelessGatewayCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWirelessGatewayFirmwareInformation

        internal virtual GetWirelessGatewayFirmwareInformationResponse GetWirelessGatewayFirmwareInformation(GetWirelessGatewayFirmwareInformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayFirmwareInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayFirmwareInformationResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayFirmwareInformationResponse>(request, options);
        }



        /// <summary>
        /// Gets the firmware version and other information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayFirmwareInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetWirelessGatewayFirmwareInformationResponse> GetWirelessGatewayFirmwareInformationAsync(GetWirelessGatewayFirmwareInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayFirmwareInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayFirmwareInformationResponseUnmarshaller.Instance;

            return InvokeAsync<GetWirelessGatewayFirmwareInformationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWirelessGatewayStatistics

        internal virtual GetWirelessGatewayStatisticsResponse GetWirelessGatewayStatistics(GetWirelessGatewayStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayStatisticsResponse>(request, options);
        }



        /// <summary>
        /// Gets operating information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetWirelessGatewayStatisticsResponse> GetWirelessGatewayStatisticsAsync(GetWirelessGatewayStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayStatisticsResponseUnmarshaller.Instance;

            return InvokeAsync<GetWirelessGatewayStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWirelessGatewayTask

        internal virtual GetWirelessGatewayTaskResponse GetWirelessGatewayTask(GetWirelessGatewayTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayTaskResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayTaskResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a wireless gateway task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetWirelessGatewayTaskResponse> GetWirelessGatewayTaskAsync(GetWirelessGatewayTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetWirelessGatewayTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWirelessGatewayTaskDefinition

        internal virtual GetWirelessGatewayTaskDefinitionResponse GetWirelessGatewayTaskDefinition(GetWirelessGatewayTaskDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayTaskDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a wireless gateway task definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTaskDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetWirelessGatewayTaskDefinitionResponse> GetWirelessGatewayTaskDefinitionAsync(GetWirelessGatewayTaskDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetWirelessGatewayTaskDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDestinations

        internal virtual ListDestinationsResponse ListDestinations(ListDestinationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDestinationsResponseUnmarshaller.Instance;

            return Invoke<ListDestinationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the destinations registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListDestinationsResponse> ListDestinationsAsync(ListDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDestinationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDestinationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDeviceProfiles

        internal virtual ListDeviceProfilesResponse ListDeviceProfiles(ListDeviceProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeviceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListDeviceProfilesResponse>(request, options);
        }



        /// <summary>
        /// Lists the device profiles registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListDeviceProfilesResponse> ListDeviceProfilesAsync(ListDeviceProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeviceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeviceProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEventConfigurations

        internal virtual ListEventConfigurationsResponse ListEventConfigurations(ListEventConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListEventConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// List event configurations where at least one event topic has been enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListEventConfigurationsResponse> ListEventConfigurationsAsync(ListEventConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFuotaTasks

        internal virtual ListFuotaTasksResponse ListFuotaTasks(ListFuotaTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFuotaTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFuotaTasksResponseUnmarshaller.Instance;

            return Invoke<ListFuotaTasksResponse>(request, options);
        }



        /// <summary>
        /// Lists the FUOTA tasks registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFuotaTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListFuotaTasksResponse> ListFuotaTasksAsync(ListFuotaTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFuotaTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFuotaTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListFuotaTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMulticastGroups

        internal virtual ListMulticastGroupsResponse ListMulticastGroups(ListMulticastGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMulticastGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMulticastGroupsResponseUnmarshaller.Instance;

            return Invoke<ListMulticastGroupsResponse>(request, options);
        }



        /// <summary>
        /// Lists the multicast groups registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMulticastGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListMulticastGroupsResponse> ListMulticastGroupsAsync(ListMulticastGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMulticastGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMulticastGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMulticastGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMulticastGroupsByFuotaTask

        internal virtual ListMulticastGroupsByFuotaTaskResponse ListMulticastGroupsByFuotaTask(ListMulticastGroupsByFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMulticastGroupsByFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMulticastGroupsByFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<ListMulticastGroupsByFuotaTaskResponse>(request, options);
        }



        /// <summary>
        /// List all multicast groups associated with a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMulticastGroupsByFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListMulticastGroupsByFuotaTaskResponse> ListMulticastGroupsByFuotaTaskAsync(ListMulticastGroupsByFuotaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMulticastGroupsByFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMulticastGroupsByFuotaTaskResponseUnmarshaller.Instance;

            return InvokeAsync<ListMulticastGroupsByFuotaTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNetworkAnalyzerConfigurations

        internal virtual ListNetworkAnalyzerConfigurationsResponse ListNetworkAnalyzerConfigurations(ListNetworkAnalyzerConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworkAnalyzerConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkAnalyzerConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListNetworkAnalyzerConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the network analyzer configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkAnalyzerConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListNetworkAnalyzerConfigurationsResponse> ListNetworkAnalyzerConfigurationsAsync(ListNetworkAnalyzerConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworkAnalyzerConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkAnalyzerConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListNetworkAnalyzerConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPartnerAccounts

        internal virtual ListPartnerAccountsResponse ListPartnerAccounts(ListPartnerAccountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartnerAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnerAccountsResponseUnmarshaller.Instance;

            return Invoke<ListPartnerAccountsResponse>(request, options);
        }



        /// <summary>
        /// Lists the partner accounts associated with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListPartnerAccountsResponse> ListPartnerAccountsAsync(ListPartnerAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartnerAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnerAccountsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPartnerAccountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPositionConfigurations

        [Obsolete("This operation is no longer supported.")]
        internal virtual ListPositionConfigurationsResponse ListPositionConfigurations(ListPositionConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPositionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPositionConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListPositionConfigurationsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListPositionConfigurationsResponse> ListPositionConfigurationsAsync(ListPositionConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPositionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPositionConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPositionConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQueuedMessages

        internal virtual ListQueuedMessagesResponse ListQueuedMessages(ListQueuedMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueuedMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuedMessagesResponseUnmarshaller.Instance;

            return Invoke<ListQueuedMessagesResponse>(request, options);
        }



        /// <summary>
        /// List queued messages in the downlink queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueuedMessages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListQueuedMessagesResponse> ListQueuedMessagesAsync(ListQueuedMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueuedMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuedMessagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListQueuedMessagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceProfiles

        internal virtual ListServiceProfilesResponse ListServiceProfiles(ListServiceProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListServiceProfilesResponse>(request, options);
        }



        /// <summary>
        /// Lists the service profiles registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListServiceProfilesResponse> ListServiceProfilesAsync(ListServiceProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListServiceProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWirelessDevices

        internal virtual ListWirelessDevicesResponse ListWirelessDevices(ListWirelessDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessDevicesResponseUnmarshaller.Instance;

            return Invoke<ListWirelessDevicesResponse>(request, options);
        }



        /// <summary>
        /// Lists the wireless devices registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListWirelessDevicesResponse> ListWirelessDevicesAsync(ListWirelessDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListWirelessDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWirelessGateways

        internal virtual ListWirelessGatewaysResponse ListWirelessGateways(ListWirelessGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListWirelessGatewaysResponse>(request, options);
        }



        /// <summary>
        /// Lists the wireless gateways registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListWirelessGatewaysResponse> ListWirelessGatewaysAsync(ListWirelessGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<ListWirelessGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWirelessGatewayTaskDefinitions

        internal virtual ListWirelessGatewayTaskDefinitionsResponse ListWirelessGatewayTaskDefinitions(ListWirelessGatewayTaskDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessGatewayTaskDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessGatewayTaskDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListWirelessGatewayTaskDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// List the wireless gateway tasks definitions registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGatewayTaskDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListWirelessGatewayTaskDefinitionsResponse> ListWirelessGatewayTaskDefinitionsAsync(ListWirelessGatewayTaskDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessGatewayTaskDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessGatewayTaskDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWirelessGatewayTaskDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutPositionConfiguration

        [Obsolete("This operation is no longer supported.")]
        internal virtual PutPositionConfigurationResponse PutPositionConfiguration(PutPositionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPositionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPositionConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutPositionConfigurationResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<PutPositionConfigurationResponse> PutPositionConfigurationAsync(PutPositionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPositionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPositionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutPositionConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourceLogLevel

        internal virtual PutResourceLogLevelResponse PutResourceLogLevel(PutResourceLogLevelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourceLogLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourceLogLevelResponseUnmarshaller.Instance;

            return Invoke<PutResourceLogLevelResponse>(request, options);
        }



        /// <summary>
        /// Sets the log-level override for a resource-ID and resource-type. This option can be
        /// specified for a wireless gateway or a wireless device. A limit of 200 log level override
        /// can be set per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourceLogLevel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<PutResourceLogLevelResponse> PutResourceLogLevelAsync(PutResourceLogLevelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourceLogLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourceLogLevelResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourceLogLevelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetAllResourceLogLevels

        internal virtual ResetAllResourceLogLevelsResponse ResetAllResourceLogLevels(ResetAllResourceLogLevelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetAllResourceLogLevelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetAllResourceLogLevelsResponseUnmarshaller.Instance;

            return Invoke<ResetAllResourceLogLevelsResponse>(request, options);
        }



        /// <summary>
        /// Removes the log-level overrides for all resources; both wireless devices and wireless
        /// gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetAllResourceLogLevels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ResetAllResourceLogLevelsResponse> ResetAllResourceLogLevelsAsync(ResetAllResourceLogLevelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetAllResourceLogLevelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetAllResourceLogLevelsResponseUnmarshaller.Instance;

            return InvokeAsync<ResetAllResourceLogLevelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetResourceLogLevel

        internal virtual ResetResourceLogLevelResponse ResetResourceLogLevel(ResetResourceLogLevelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetResourceLogLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetResourceLogLevelResponseUnmarshaller.Instance;

            return Invoke<ResetResourceLogLevelResponse>(request, options);
        }



        /// <summary>
        /// Removes the log-level override, if any, for a specific resource-ID and resource-type.
        /// It can be used for a wireless device or a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetResourceLogLevel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ResetResourceLogLevelResponse> ResetResourceLogLevelAsync(ResetResourceLogLevelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetResourceLogLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetResourceLogLevelResponseUnmarshaller.Instance;

            return InvokeAsync<ResetResourceLogLevelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendDataToMulticastGroup

        internal virtual SendDataToMulticastGroupResponse SendDataToMulticastGroup(SendDataToMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendDataToMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataToMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<SendDataToMulticastGroupResponse>(request, options);
        }



        /// <summary>
        /// Sends the specified data to a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataToMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SendDataToMulticastGroupResponse> SendDataToMulticastGroupAsync(SendDataToMulticastGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendDataToMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataToMulticastGroupResponseUnmarshaller.Instance;

            return InvokeAsync<SendDataToMulticastGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendDataToWirelessDevice

        internal virtual SendDataToWirelessDeviceResponse SendDataToWirelessDevice(SendDataToWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendDataToWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataToWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<SendDataToWirelessDeviceResponse>(request, options);
        }



        /// <summary>
        /// Sends a decrypted application data frame to a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataToWirelessDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SendDataToWirelessDeviceResponse> SendDataToWirelessDeviceAsync(SendDataToWirelessDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendDataToWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataToWirelessDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<SendDataToWirelessDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartBulkAssociateWirelessDeviceWithMulticastGroup

        internal virtual StartBulkAssociateWirelessDeviceWithMulticastGroupResponse StartBulkAssociateWirelessDeviceWithMulticastGroup(StartBulkAssociateWirelessDeviceWithMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBulkAssociateWirelessDeviceWithMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBulkAssociateWirelessDeviceWithMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<StartBulkAssociateWirelessDeviceWithMulticastGroupResponse>(request, options);
        }



        /// <summary>
        /// Starts a bulk association of all qualifying wireless devices with a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBulkAssociateWirelessDeviceWithMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartBulkAssociateWirelessDeviceWithMulticastGroupResponse> StartBulkAssociateWirelessDeviceWithMulticastGroupAsync(StartBulkAssociateWirelessDeviceWithMulticastGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBulkAssociateWirelessDeviceWithMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBulkAssociateWirelessDeviceWithMulticastGroupResponseUnmarshaller.Instance;

            return InvokeAsync<StartBulkAssociateWirelessDeviceWithMulticastGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartBulkDisassociateWirelessDeviceFromMulticastGroup

        internal virtual StartBulkDisassociateWirelessDeviceFromMulticastGroupResponse StartBulkDisassociateWirelessDeviceFromMulticastGroup(StartBulkDisassociateWirelessDeviceFromMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBulkDisassociateWirelessDeviceFromMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBulkDisassociateWirelessDeviceFromMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<StartBulkDisassociateWirelessDeviceFromMulticastGroupResponse>(request, options);
        }



        /// <summary>
        /// Starts a bulk disassociatin of all qualifying wireless devices from a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBulkDisassociateWirelessDeviceFromMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartBulkDisassociateWirelessDeviceFromMulticastGroupResponse> StartBulkDisassociateWirelessDeviceFromMulticastGroupAsync(StartBulkDisassociateWirelessDeviceFromMulticastGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBulkDisassociateWirelessDeviceFromMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBulkDisassociateWirelessDeviceFromMulticastGroupResponseUnmarshaller.Instance;

            return InvokeAsync<StartBulkDisassociateWirelessDeviceFromMulticastGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartFuotaTask

        internal virtual StartFuotaTaskResponse StartFuotaTask(StartFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<StartFuotaTaskResponse>(request, options);
        }



        /// <summary>
        /// Starts a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartFuotaTaskResponse> StartFuotaTaskAsync(StartFuotaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFuotaTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartFuotaTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMulticastGroupSession

        internal virtual StartMulticastGroupSessionResponse StartMulticastGroupSession(StartMulticastGroupSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMulticastGroupSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMulticastGroupSessionResponseUnmarshaller.Instance;

            return Invoke<StartMulticastGroupSessionResponse>(request, options);
        }



        /// <summary>
        /// Starts a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMulticastGroupSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartMulticastGroupSessionResponse> StartMulticastGroupSessionAsync(StartMulticastGroupSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMulticastGroupSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMulticastGroupSessionResponseUnmarshaller.Instance;

            return InvokeAsync<StartMulticastGroupSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestWirelessDevice

        internal virtual TestWirelessDeviceResponse TestWirelessDevice(TestWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<TestWirelessDeviceResponse>(request, options);
        }



        /// <summary>
        /// Simulates a provisioned device by sending an uplink data payload of <code>Hello</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestWirelessDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TestWirelessDeviceResponse> TestWirelessDeviceAsync(TestWirelessDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestWirelessDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<TestWirelessDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDestination

        internal virtual UpdateDestinationResponse UpdateDestination(UpdateDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateDestinationResponse>(request, options);
        }



        /// <summary>
        /// Updates properties of a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateDestinationResponse> UpdateDestinationAsync(UpdateDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEventConfigurationByResourceTypes

        internal virtual UpdateEventConfigurationByResourceTypesResponse UpdateEventConfigurationByResourceTypes(UpdateEventConfigurationByResourceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventConfigurationByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventConfigurationByResourceTypesResponseUnmarshaller.Instance;

            return Invoke<UpdateEventConfigurationByResourceTypesResponse>(request, options);
        }



        /// <summary>
        /// Update the event configuration based on resource types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventConfigurationByResourceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateEventConfigurationByResourceTypesResponse> UpdateEventConfigurationByResourceTypesAsync(UpdateEventConfigurationByResourceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventConfigurationByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventConfigurationByResourceTypesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEventConfigurationByResourceTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFuotaTask

        internal virtual UpdateFuotaTaskResponse UpdateFuotaTask(UpdateFuotaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFuotaTaskResponseUnmarshaller.Instance;

            return Invoke<UpdateFuotaTaskResponse>(request, options);
        }



        /// <summary>
        /// Updates properties of a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateFuotaTaskResponse> UpdateFuotaTaskAsync(UpdateFuotaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFuotaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFuotaTaskResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFuotaTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLogLevelsByResourceTypes

        internal virtual UpdateLogLevelsByResourceTypesResponse UpdateLogLevelsByResourceTypes(UpdateLogLevelsByResourceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLogLevelsByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLogLevelsByResourceTypesResponseUnmarshaller.Instance;

            return Invoke<UpdateLogLevelsByResourceTypesResponse>(request, options);
        }



        /// <summary>
        /// Set default log level, or log levels by resource types. This can be for wireless device
        /// log options or wireless gateways log options and is used to control the log messages
        /// that'll be displayed in CloudWatch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogLevelsByResourceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateLogLevelsByResourceTypesResponse> UpdateLogLevelsByResourceTypesAsync(UpdateLogLevelsByResourceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLogLevelsByResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLogLevelsByResourceTypesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLogLevelsByResourceTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMulticastGroup

        internal virtual UpdateMulticastGroupResponse UpdateMulticastGroup(UpdateMulticastGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMulticastGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateMulticastGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates properties of a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateMulticastGroupResponse> UpdateMulticastGroupAsync(UpdateMulticastGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMulticastGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMulticastGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMulticastGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNetworkAnalyzerConfiguration

        internal virtual UpdateNetworkAnalyzerConfigurationResponse UpdateNetworkAnalyzerConfiguration(UpdateNetworkAnalyzerConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkAnalyzerConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Update network analyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkAnalyzerConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateNetworkAnalyzerConfigurationResponse> UpdateNetworkAnalyzerConfigurationAsync(UpdateNetworkAnalyzerConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkAnalyzerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkAnalyzerConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNetworkAnalyzerConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePartnerAccount

        internal virtual UpdatePartnerAccountResponse UpdatePartnerAccount(UpdatePartnerAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartnerAccountResponseUnmarshaller.Instance;

            return Invoke<UpdatePartnerAccountResponse>(request, options);
        }



        /// <summary>
        /// Updates properties of a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnerAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdatePartnerAccountResponse> UpdatePartnerAccountAsync(UpdatePartnerAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartnerAccountResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePartnerAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePosition

        [Obsolete("This operation is no longer supported.")]
        internal virtual UpdatePositionResponse UpdatePosition(UpdatePositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePositionResponseUnmarshaller.Instance;

            return Invoke<UpdatePositionResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdatePositionResponse> UpdatePositionAsync(UpdatePositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePositionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePositionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResourceEventConfiguration

        internal virtual UpdateResourceEventConfigurationResponse UpdateResourceEventConfiguration(UpdateResourceEventConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceEventConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceEventConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Update the event configuration for a particular resource identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceEventConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateResourceEventConfigurationResponse> UpdateResourceEventConfigurationAsync(UpdateResourceEventConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceEventConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourceEventConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResourcePosition

        internal virtual UpdateResourcePositionResponse UpdateResourcePosition(UpdateResourcePositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourcePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourcePositionResponseUnmarshaller.Instance;

            return Invoke<UpdateResourcePositionResponse>(request, options);
        }



        /// <summary>
        /// Update the position information of a given wireless device or a wireless gateway resource.
        /// The postion coordinates are based on the <a href="https://gisgeography.com/wgs84-world-geodetic-system/">
        /// World Geodetic System (WGS84)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourcePosition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateResourcePositionResponse> UpdateResourcePositionAsync(UpdateResourcePositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourcePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourcePositionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourcePositionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWirelessDevice

        internal virtual UpdateWirelessDeviceResponse UpdateWirelessDevice(UpdateWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<UpdateWirelessDeviceResponse>(request, options);
        }



        /// <summary>
        /// Updates properties of a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateWirelessDeviceResponse> UpdateWirelessDeviceAsync(UpdateWirelessDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWirelessDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWirelessDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWirelessGateway

        internal virtual UpdateWirelessGatewayResponse UpdateWirelessGateway(UpdateWirelessGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWirelessGatewayResponseUnmarshaller.Instance;

            return Invoke<UpdateWirelessGatewayResponse>(request, options);
        }



        /// <summary>
        /// Updates properties of a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateWirelessGatewayResponse> UpdateWirelessGatewayAsync(UpdateWirelessGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWirelessGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWirelessGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}