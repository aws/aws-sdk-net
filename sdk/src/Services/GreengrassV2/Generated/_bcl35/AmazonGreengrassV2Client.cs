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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.GreengrassV2.Model;
using Amazon.GreengrassV2.Model.Internal.MarshallTransformations;
using Amazon.GreengrassV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.GreengrassV2
{
    /// <summary>
    /// <para>Implementation for accessing GreengrassV2</para>
    ///
    /// IoT Greengrass brings local compute, messaging, data management, sync, and ML inference
    /// capabilities to edge devices. This enables devices to collect and analyze data closer
    /// to the source of information, react autonomously to local events, and communicate
    /// securely with each other on local networks. Local devices can also communicate securely
    /// with Amazon Web Services IoT Core and export IoT data to the Amazon Web Services Cloud.
    /// IoT Greengrass developers can use Lambda functions and components to create and deploy
    /// applications to fleets of edge devices for local operation.
    /// 
    ///  
    /// <para>
    /// IoT Greengrass Version 2 provides a new major version of the IoT Greengrass Core software,
    /// new APIs, and a new console. Use this API reference to learn how to use the IoT Greengrass
    /// V2 API operations to manage components, manage deployments, and core devices.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/what-is-iot-greengrass.html">What
    /// is IoT Greengrass?</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonGreengrassV2Client : AmazonServiceClient, IAmazonGreengrassV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonGreengrassV2Metadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IGreengrassV2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IGreengrassV2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new GreengrassV2PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with the credentials loaded from the application's
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
        public AmazonGreengrassV2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGreengrassV2Config()) { }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with the credentials loaded from the application's
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
        public AmazonGreengrassV2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGreengrassV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGreengrassV2Client Configuration Object</param>
        public AmazonGreengrassV2Client(AmazonGreengrassV2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGreengrassV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonGreengrassV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGreengrassV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGreengrassV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Credentials and an
        /// AmazonGreengrassV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGreengrassV2Client Configuration Object</param>
        public AmazonGreengrassV2Client(AWSCredentials credentials, AmazonGreengrassV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGreengrassV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGreengrassV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGreengrassV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGreengrassV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGreengrassV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGreengrassV2Client Configuration Object</param>
        public AmazonGreengrassV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonGreengrassV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGreengrassV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGreengrassV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGreengrassV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGreengrassV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGreengrassV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGreengrassV2Client Configuration Object</param>
        public AmazonGreengrassV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGreengrassV2Config clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGreengrassV2EndpointResolver());
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


        #region  AssociateServiceRoleToAccount

        /// <summary>
        /// Associates a Greengrass service role with IoT Greengrass for your Amazon Web Services
        /// account in this Amazon Web Services Region. IoT Greengrass uses this role to verify
        /// the identity of client devices and manage core device connectivity information. The
        /// role must include the <a href="https://console.aws.amazon.com/iam/home#/policies/arn:awsiam::aws:policy/service-role/AWSGreengrassResourceAccessRolePolicy">AWSGreengrassResourceAccessRolePolicy</a>
        /// managed policy or a custom policy that defines equivalent permissions for the IoT
        /// Greengrass features that you use. For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-service-role.html">Greengrass
        /// service role</a> in the <i>IoT Greengrass Version 2 Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceRoleToAccount service method.</param>
        /// 
        /// <returns>The response from the AssociateServiceRoleToAccount service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/AssociateServiceRoleToAccount">REST API Reference for AssociateServiceRoleToAccount Operation</seealso>
        public virtual AssociateServiceRoleToAccountResponse AssociateServiceRoleToAccount(AssociateServiceRoleToAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateServiceRoleToAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceRoleToAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateServiceRoleToAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateServiceRoleToAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceRoleToAccount operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateServiceRoleToAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/AssociateServiceRoleToAccount">REST API Reference for AssociateServiceRoleToAccount Operation</seealso>
        public virtual IAsyncResult BeginAssociateServiceRoleToAccount(AssociateServiceRoleToAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateServiceRoleToAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceRoleToAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateServiceRoleToAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateServiceRoleToAccount.</param>
        /// 
        /// <returns>Returns a  AssociateServiceRoleToAccountResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/AssociateServiceRoleToAccount">REST API Reference for AssociateServiceRoleToAccount Operation</seealso>
        public virtual AssociateServiceRoleToAccountResponse EndAssociateServiceRoleToAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateServiceRoleToAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchAssociateClientDeviceWithCoreDevice

        /// <summary>
        /// Associates a list of client devices with a core device. Use this API operation to
        /// specify which client devices can discover a core device through cloud discovery. With
        /// cloud discovery, client devices connect to IoT Greengrass to retrieve associated core
        /// devices' connectivity information and certificates. For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/configure-cloud-discovery.html">Configure
        /// cloud discovery</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// Client devices are local IoT devices that connect to and communicate with an IoT Greengrass
        /// core device over MQTT. You can connect client devices to a core device to sync MQTT
        /// messages and data to Amazon Web Services IoT Core and interact with client devices
        /// in Greengrass components. For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/interact-with-local-iot-devices.html">Interact
        /// with local IoT devices</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateClientDeviceWithCoreDevice service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateClientDeviceWithCoreDevice service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/BatchAssociateClientDeviceWithCoreDevice">REST API Reference for BatchAssociateClientDeviceWithCoreDevice Operation</seealso>
        public virtual BatchAssociateClientDeviceWithCoreDeviceResponse BatchAssociateClientDeviceWithCoreDevice(BatchAssociateClientDeviceWithCoreDeviceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateClientDeviceWithCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateClientDeviceWithCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateClientDeviceWithCoreDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateClientDeviceWithCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateClientDeviceWithCoreDevice operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAssociateClientDeviceWithCoreDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/BatchAssociateClientDeviceWithCoreDevice">REST API Reference for BatchAssociateClientDeviceWithCoreDevice Operation</seealso>
        public virtual IAsyncResult BeginBatchAssociateClientDeviceWithCoreDevice(BatchAssociateClientDeviceWithCoreDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateClientDeviceWithCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateClientDeviceWithCoreDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateClientDeviceWithCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateClientDeviceWithCoreDevice.</param>
        /// 
        /// <returns>Returns a  BatchAssociateClientDeviceWithCoreDeviceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/BatchAssociateClientDeviceWithCoreDevice">REST API Reference for BatchAssociateClientDeviceWithCoreDevice Operation</seealso>
        public virtual BatchAssociateClientDeviceWithCoreDeviceResponse EndBatchAssociateClientDeviceWithCoreDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchAssociateClientDeviceWithCoreDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDisassociateClientDeviceFromCoreDevice

        /// <summary>
        /// Disassociates a list of client devices from a core device. After you disassociate
        /// a client device from a core device, the client device won't be able to use cloud discovery
        /// to retrieve the core device's connectivity information and certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateClientDeviceFromCoreDevice service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateClientDeviceFromCoreDevice service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/BatchDisassociateClientDeviceFromCoreDevice">REST API Reference for BatchDisassociateClientDeviceFromCoreDevice Operation</seealso>
        public virtual BatchDisassociateClientDeviceFromCoreDeviceResponse BatchDisassociateClientDeviceFromCoreDevice(BatchDisassociateClientDeviceFromCoreDeviceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateClientDeviceFromCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateClientDeviceFromCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateClientDeviceFromCoreDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateClientDeviceFromCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateClientDeviceFromCoreDevice operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisassociateClientDeviceFromCoreDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/BatchDisassociateClientDeviceFromCoreDevice">REST API Reference for BatchDisassociateClientDeviceFromCoreDevice Operation</seealso>
        public virtual IAsyncResult BeginBatchDisassociateClientDeviceFromCoreDevice(BatchDisassociateClientDeviceFromCoreDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateClientDeviceFromCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateClientDeviceFromCoreDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateClientDeviceFromCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateClientDeviceFromCoreDevice.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateClientDeviceFromCoreDeviceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/BatchDisassociateClientDeviceFromCoreDevice">REST API Reference for BatchDisassociateClientDeviceFromCoreDevice Operation</seealso>
        public virtual BatchDisassociateClientDeviceFromCoreDeviceResponse EndBatchDisassociateClientDeviceFromCoreDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDisassociateClientDeviceFromCoreDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelDeployment

        /// <summary>
        /// Cancels a deployment. This operation cancels the deployment for devices that haven't
        /// yet received it. If a device already received the deployment, this operation doesn't
        /// change anything for that device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDeployment service method.</param>
        /// 
        /// <returns>The response from the CancelDeployment service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CancelDeployment">REST API Reference for CancelDeployment Operation</seealso>
        public virtual CancelDeploymentResponse CancelDeployment(CancelDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDeploymentResponseUnmarshaller.Instance;

            return Invoke<CancelDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelDeployment operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CancelDeployment">REST API Reference for CancelDeployment Operation</seealso>
        public virtual IAsyncResult BeginCancelDeployment(CancelDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelDeployment.</param>
        /// 
        /// <returns>Returns a  CancelDeploymentResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CancelDeployment">REST API Reference for CancelDeployment Operation</seealso>
        public virtual CancelDeploymentResponse EndCancelDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateComponentVersion

        /// <summary>
        /// Creates a component. Components are software that run on Greengrass core devices.
        /// After you develop and test a component on your core device, you can use this operation
        /// to upload your component to IoT Greengrass. Then, you can deploy the component to
        /// other core devices.
        /// 
        ///  
        /// <para>
        /// You can use this operation to do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Create components from recipes</b> 
        /// </para>
        ///  
        /// <para>
        /// Create a component from a recipe, which is a file that defines the component's metadata,
        /// parameters, dependencies, lifecycle, artifacts, and platform capability. For more
        /// information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/component-recipe-reference.html">IoT
        /// Greengrass component recipe reference</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To create a component from a recipe, specify <c>inlineRecipe</c> when you call this
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Create components from Lambda functions</b> 
        /// </para>
        ///  
        /// <para>
        /// Create a component from an Lambda function that runs on IoT Greengrass. This creates
        /// a recipe and artifacts from the Lambda function's deployment package. You can use
        /// this operation to migrate Lambda functions from IoT Greengrass V1 to IoT Greengrass
        /// V2.
        /// </para>
        ///  
        /// <para>
        /// This function accepts Lambda functions in all supported versions of Python, Node.js,
        /// and Java runtimes. IoT Greengrass doesn't apply any additional restrictions on deprecated
        /// Lambda runtime versions.
        /// </para>
        ///  
        /// <para>
        /// To create a component from a Lambda function, specify <c>lambdaFunction</c> when you
        /// call this operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// IoT Greengrass currently supports Lambda functions on only Linux core devices.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponentVersion service method.</param>
        /// 
        /// <returns>The response from the CreateComponentVersion service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.RequestAlreadyInProgressException">
        /// The request is already in progress. This exception occurs when you use a client token
        /// for multiple requests while IoT Greengrass is still processing an earlier request
        /// that uses the same client token.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota. For example, you might have the maximum number
        /// of components that you can create.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CreateComponentVersion">REST API Reference for CreateComponentVersion Operation</seealso>
        public virtual CreateComponentVersionResponse CreateComponentVersion(CreateComponentVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComponentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentVersionResponseUnmarshaller.Instance;

            return Invoke<CreateComponentVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComponentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComponentVersion operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComponentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CreateComponentVersion">REST API Reference for CreateComponentVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateComponentVersion(CreateComponentVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComponentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateComponentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateComponentVersion.</param>
        /// 
        /// <returns>Returns a  CreateComponentVersionResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CreateComponentVersion">REST API Reference for CreateComponentVersion Operation</seealso>
        public virtual CreateComponentVersionResponse EndCreateComponentVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateComponentVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDeployment

        /// <summary>
        /// Creates a continuous deployment for a target, which is a Greengrass core device or
        /// group of core devices. When you add a new core device to a group of core devices that
        /// has a deployment, IoT Greengrass deploys that group's deployment to the new device.
        /// 
        ///  
        /// <para>
        /// You can define one deployment for each target. When you create a new deployment for
        /// a target that has an existing deployment, you replace the previous deployment. IoT
        /// Greengrass applies the new deployment to the target devices.
        /// </para>
        ///  
        /// <para>
        /// Every deployment has a revision number that indicates how many deployment revisions
        /// you define for a target. Use this operation to create a new revision of an existing
        /// deployment.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/create-deployments.html">Create
        /// deployments</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.RequestAlreadyInProgressException">
        /// The request is already in progress. This exception occurs when you use a client token
        /// for multiple requests while IoT Greengrass is still processing an earlier request
        /// that uses the same client token.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteComponent

        /// <summary>
        /// Deletes a version of a component from IoT Greengrass.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the component's recipe and artifacts. As a result, deployments
        /// that refer to this component version will fail. If you have deployments that use this
        /// component version, you can remove the component from the deployment or update the
        /// deployment to use a valid version.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent service method.</param>
        /// 
        /// <returns>The response from the DeleteComponent service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual DeleteComponentResponse DeleteComponent(DeleteComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual IAsyncResult BeginDeleteComponent(DeleteComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteComponent.</param>
        /// 
        /// <returns>Returns a  DeleteComponentResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual DeleteComponentResponse EndDeleteComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCoreDevice

        /// <summary>
        /// Deletes a Greengrass core device, which is an IoT thing. This operation removes the
        /// core device from the list of core devices. This operation doesn't delete the IoT thing.
        /// For more information about how to delete the IoT thing, see <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_DeleteThing.html">DeleteThing</a>
        /// in the <i>IoT API Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreDevice service method.</param>
        /// 
        /// <returns>The response from the DeleteCoreDevice service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteCoreDevice">REST API Reference for DeleteCoreDevice Operation</seealso>
        public virtual DeleteCoreDeviceResponse DeleteCoreDevice(DeleteCoreDeviceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteCoreDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreDevice operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCoreDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteCoreDevice">REST API Reference for DeleteCoreDevice Operation</seealso>
        public virtual IAsyncResult BeginDeleteCoreDevice(DeleteCoreDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCoreDevice.</param>
        /// 
        /// <returns>Returns a  DeleteCoreDeviceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteCoreDevice">REST API Reference for DeleteCoreDevice Operation</seealso>
        public virtual DeleteCoreDeviceResponse EndDeleteCoreDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCoreDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDeployment

        /// <summary>
        /// Deletes a deployment. To delete an active deployment, you must first cancel it. For
        /// more information, see <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_CancelDeployment.html">CancelDeployment</a>.
        /// 
        ///  
        /// <para>
        /// Deleting a deployment doesn't affect core devices that run that deployment, because
        /// core devices store the deployment's configuration on the device. Additionally, core
        /// devices can roll back to a previous deployment that has been deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        public virtual DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        public virtual IAsyncResult BeginDeleteDeployment(DeleteDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeployment.</param>
        /// 
        /// <returns>Returns a  DeleteDeploymentResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        public virtual DeleteDeploymentResponse EndDeleteDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComponent

        /// <summary>
        /// Retrieves metadata for a version of a component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponent service method.</param>
        /// 
        /// <returns>The response from the DescribeComponent service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        public virtual DescribeComponentResponse DescribeComponent(DescribeComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentResponseUnmarshaller.Instance;

            return Invoke<DescribeComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponent operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        public virtual IAsyncResult BeginDescribeComponent(DescribeComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComponent.</param>
        /// 
        /// <returns>Returns a  DescribeComponentResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        public virtual DescribeComponentResponse EndDescribeComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateServiceRoleFromAccount

        /// <summary>
        /// Disassociates the Greengrass service role from IoT Greengrass for your Amazon Web
        /// Services account in this Amazon Web Services Region. Without a service role, IoT Greengrass
        /// can't verify the identity of client devices or manage core device connectivity information.
        /// For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-service-role.html">Greengrass
        /// service role</a> in the <i>IoT Greengrass Version 2 Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceRoleFromAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateServiceRoleFromAccount service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DisassociateServiceRoleFromAccount">REST API Reference for DisassociateServiceRoleFromAccount Operation</seealso>
        public virtual DisassociateServiceRoleFromAccountResponse DisassociateServiceRoleFromAccount(DisassociateServiceRoleFromAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateServiceRoleFromAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceRoleFromAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateServiceRoleFromAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateServiceRoleFromAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceRoleFromAccount operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateServiceRoleFromAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DisassociateServiceRoleFromAccount">REST API Reference for DisassociateServiceRoleFromAccount Operation</seealso>
        public virtual IAsyncResult BeginDisassociateServiceRoleFromAccount(DisassociateServiceRoleFromAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateServiceRoleFromAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceRoleFromAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateServiceRoleFromAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateServiceRoleFromAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateServiceRoleFromAccountResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DisassociateServiceRoleFromAccount">REST API Reference for DisassociateServiceRoleFromAccount Operation</seealso>
        public virtual DisassociateServiceRoleFromAccountResponse EndDisassociateServiceRoleFromAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateServiceRoleFromAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComponent

        /// <summary>
        /// Gets the recipe for a version of a component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
        /// 
        /// <returns>The response from the GetComponent service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual GetComponentResponse GetComponent(GetComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return Invoke<GetComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComponent operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual IAsyncResult BeginGetComponent(GetComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComponent.</param>
        /// 
        /// <returns>Returns a  GetComponentResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual GetComponentResponse EndGetComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComponentVersionArtifact

        /// <summary>
        /// Gets the pre-signed URL to download a public or a Lambda component artifact. Core
        /// devices call this operation to identify the URL that they can use to download an artifact
        /// to install.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponentVersionArtifact service method.</param>
        /// 
        /// <returns>The response from the GetComponentVersionArtifact service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetComponentVersionArtifact">REST API Reference for GetComponentVersionArtifact Operation</seealso>
        public virtual GetComponentVersionArtifactResponse GetComponentVersionArtifact(GetComponentVersionArtifactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComponentVersionArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentVersionArtifactResponseUnmarshaller.Instance;

            return Invoke<GetComponentVersionArtifactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComponentVersionArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComponentVersionArtifact operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComponentVersionArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetComponentVersionArtifact">REST API Reference for GetComponentVersionArtifact Operation</seealso>
        public virtual IAsyncResult BeginGetComponentVersionArtifact(GetComponentVersionArtifactRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComponentVersionArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentVersionArtifactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComponentVersionArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComponentVersionArtifact.</param>
        /// 
        /// <returns>Returns a  GetComponentVersionArtifactResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetComponentVersionArtifact">REST API Reference for GetComponentVersionArtifact Operation</seealso>
        public virtual GetComponentVersionArtifactResponse EndGetComponentVersionArtifact(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComponentVersionArtifactResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnectivityInfo

        /// <summary>
        /// Retrieves connectivity information for a Greengrass core device.
        /// 
        ///  
        /// <para>
        /// Connectivity information includes endpoints and ports where client devices can connect
        /// to an MQTT broker on the core device. When a client device calls the <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-discover-api.html">IoT
        /// Greengrass discovery API</a>, IoT Greengrass returns connectivity information for
        /// all of the core devices where the client device can connect. For more information,
        /// see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/connect-client-devices.html">Connect
        /// client devices to core devices</a> in the <i>IoT Greengrass Version 2 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectivityInfo service method.</param>
        /// 
        /// <returns>The response from the GetConnectivityInfo service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetConnectivityInfo">REST API Reference for GetConnectivityInfo Operation</seealso>
        public virtual GetConnectivityInfoResponse GetConnectivityInfo(GetConnectivityInfoRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectivityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectivityInfoResponseUnmarshaller.Instance;

            return Invoke<GetConnectivityInfoResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectivityInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectivityInfo operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectivityInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetConnectivityInfo">REST API Reference for GetConnectivityInfo Operation</seealso>
        public virtual IAsyncResult BeginGetConnectivityInfo(GetConnectivityInfoRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectivityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectivityInfoResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectivityInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectivityInfo.</param>
        /// 
        /// <returns>Returns a  GetConnectivityInfoResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetConnectivityInfo">REST API Reference for GetConnectivityInfo Operation</seealso>
        public virtual GetConnectivityInfoResponse EndGetConnectivityInfo(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectivityInfoResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCoreDevice

        /// <summary>
        /// Retrieves metadata for a Greengrass core device.
        /// 
        ///  <note> 
        /// <para>
        /// IoT Greengrass relies on individual devices to send status updates to the Amazon Web
        /// Services Cloud. If the IoT Greengrass Core software isn't running on the device, or
        /// if device isn't connected to the Amazon Web Services Cloud, then the reported status
        /// of that device might not reflect its current status. The status timestamp indicates
        /// when the device status was last updated.
        /// </para>
        ///  
        /// <para>
        /// Core devices send status updates at the following times:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When the IoT Greengrass Core software starts
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the core device receives a deployment from the Amazon Web Services Cloud
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the status of any component on the core device becomes <c>BROKEN</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// At a <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-nucleus-component.html#greengrass-nucleus-component-configuration-fss">regular
        /// interval that you can configure</a>, which defaults to 24 hours
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For IoT Greengrass Core v2.7.0, the core device sends status updates upon local deployment
        /// and cloud deployment
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDevice service method.</param>
        /// 
        /// <returns>The response from the GetCoreDevice service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetCoreDevice">REST API Reference for GetCoreDevice Operation</seealso>
        public virtual GetCoreDeviceResponse GetCoreDevice(GetCoreDeviceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<GetCoreDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDevice operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoreDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetCoreDevice">REST API Reference for GetCoreDevice Operation</seealso>
        public virtual IAsyncResult BeginGetCoreDevice(GetCoreDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoreDevice.</param>
        /// 
        /// <returns>Returns a  GetCoreDeviceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetCoreDevice">REST API Reference for GetCoreDevice Operation</seealso>
        public virtual GetCoreDeviceResponse EndGetCoreDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCoreDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeployment

        /// <summary>
        /// Gets a deployment. Deployments define the components that run on Greengrass core devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual IAsyncResult BeginGetDeployment(GetDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployment.</param>
        /// 
        /// <returns>Returns a  GetDeploymentResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual GetDeploymentResponse EndGetDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServiceRoleForAccount

        /// <summary>
        /// Gets the service role associated with IoT Greengrass for your Amazon Web Services
        /// account in this Amazon Web Services Region. IoT Greengrass uses this role to verify
        /// the identity of client devices and manage core device connectivity information. For
        /// more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-service-role.html">Greengrass
        /// service role</a> in the <i>IoT Greengrass Version 2 Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceRoleForAccount service method.</param>
        /// 
        /// <returns>The response from the GetServiceRoleForAccount service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetServiceRoleForAccount">REST API Reference for GetServiceRoleForAccount Operation</seealso>
        public virtual GetServiceRoleForAccountResponse GetServiceRoleForAccount(GetServiceRoleForAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceRoleForAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceRoleForAccountResponseUnmarshaller.Instance;

            return Invoke<GetServiceRoleForAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceRoleForAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceRoleForAccount operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceRoleForAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetServiceRoleForAccount">REST API Reference for GetServiceRoleForAccount Operation</seealso>
        public virtual IAsyncResult BeginGetServiceRoleForAccount(GetServiceRoleForAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceRoleForAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceRoleForAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceRoleForAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceRoleForAccount.</param>
        /// 
        /// <returns>Returns a  GetServiceRoleForAccountResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetServiceRoleForAccount">REST API Reference for GetServiceRoleForAccount Operation</seealso>
        public virtual GetServiceRoleForAccountResponse EndGetServiceRoleForAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceRoleForAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  ListClientDevicesAssociatedWithCoreDevice

        /// <summary>
        /// Retrieves a paginated list of client devices that are associated with a core device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClientDevicesAssociatedWithCoreDevice service method.</param>
        /// 
        /// <returns>The response from the ListClientDevicesAssociatedWithCoreDevice service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListClientDevicesAssociatedWithCoreDevice">REST API Reference for ListClientDevicesAssociatedWithCoreDevice Operation</seealso>
        public virtual ListClientDevicesAssociatedWithCoreDeviceResponse ListClientDevicesAssociatedWithCoreDevice(ListClientDevicesAssociatedWithCoreDeviceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClientDevicesAssociatedWithCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClientDevicesAssociatedWithCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<ListClientDevicesAssociatedWithCoreDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClientDevicesAssociatedWithCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClientDevicesAssociatedWithCoreDevice operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClientDevicesAssociatedWithCoreDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListClientDevicesAssociatedWithCoreDevice">REST API Reference for ListClientDevicesAssociatedWithCoreDevice Operation</seealso>
        public virtual IAsyncResult BeginListClientDevicesAssociatedWithCoreDevice(ListClientDevicesAssociatedWithCoreDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClientDevicesAssociatedWithCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClientDevicesAssociatedWithCoreDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClientDevicesAssociatedWithCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClientDevicesAssociatedWithCoreDevice.</param>
        /// 
        /// <returns>Returns a  ListClientDevicesAssociatedWithCoreDeviceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListClientDevicesAssociatedWithCoreDevice">REST API Reference for ListClientDevicesAssociatedWithCoreDevice Operation</seealso>
        public virtual ListClientDevicesAssociatedWithCoreDeviceResponse EndListClientDevicesAssociatedWithCoreDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClientDevicesAssociatedWithCoreDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComponents

        /// <summary>
        /// Retrieves a paginated list of component summaries. This list includes components that
        /// you have permission to view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return Invoke<ListComponentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponents operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual IAsyncResult BeginListComponents(ListComponentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponents.</param>
        /// 
        /// <returns>Returns a  ListComponentsResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse EndListComponents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComponentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComponentVersions

        /// <summary>
        /// Retrieves a paginated list of all versions for a component. Greater versions are listed
        /// first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponentVersions service method.</param>
        /// 
        /// <returns>The response from the ListComponentVersions service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListComponentVersions">REST API Reference for ListComponentVersions Operation</seealso>
        public virtual ListComponentVersionsResponse ListComponentVersions(ListComponentVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentVersionsResponseUnmarshaller.Instance;

            return Invoke<ListComponentVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponentVersions operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponentVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListComponentVersions">REST API Reference for ListComponentVersions Operation</seealso>
        public virtual IAsyncResult BeginListComponentVersions(ListComponentVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponentVersions.</param>
        /// 
        /// <returns>Returns a  ListComponentVersionsResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListComponentVersions">REST API Reference for ListComponentVersions Operation</seealso>
        public virtual ListComponentVersionsResponse EndListComponentVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComponentVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCoreDevices

        /// <summary>
        /// Retrieves a paginated list of Greengrass core devices.
        /// 
        ///  <note> 
        /// <para>
        /// IoT Greengrass relies on individual devices to send status updates to the Amazon Web
        /// Services Cloud. If the IoT Greengrass Core software isn't running on the device, or
        /// if device isn't connected to the Amazon Web Services Cloud, then the reported status
        /// of that device might not reflect its current status. The status timestamp indicates
        /// when the device status was last updated.
        /// </para>
        ///  
        /// <para>
        /// Core devices send status updates at the following times:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When the IoT Greengrass Core software starts
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the core device receives a deployment from the Amazon Web Services Cloud
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Greengrass nucleus 2.12.2 and earlier, the core device sends status updates when
        /// the status of any component on the core device becomes <c>ERRORED</c> or <c>BROKEN</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Greengrass nucleus 2.12.3 and later, the core device sends status updates when
        /// the status of any component on the core device becomes <c>ERRORED</c>, <c>BROKEN</c>,
        /// <c>RUNNING</c>, or <c>FINISHED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// At a <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-nucleus-component.html#greengrass-nucleus-component-configuration-fss">regular
        /// interval that you can configure</a>, which defaults to 24 hours
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For IoT Greengrass Core v2.7.0, the core device sends status updates upon local deployment
        /// and cloud deployment
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDevices service method.</param>
        /// 
        /// <returns>The response from the ListCoreDevices service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListCoreDevices">REST API Reference for ListCoreDevices Operation</seealso>
        public virtual ListCoreDevicesResponse ListCoreDevices(ListCoreDevicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCoreDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreDevicesResponseUnmarshaller.Instance;

            return Invoke<ListCoreDevicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCoreDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDevices operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCoreDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListCoreDevices">REST API Reference for ListCoreDevices Operation</seealso>
        public virtual IAsyncResult BeginListCoreDevices(ListCoreDevicesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCoreDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreDevicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCoreDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCoreDevices.</param>
        /// 
        /// <returns>Returns a  ListCoreDevicesResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListCoreDevices">REST API Reference for ListCoreDevices Operation</seealso>
        public virtual ListCoreDevicesResponse EndListCoreDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCoreDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDeployments

        /// <summary>
        /// Retrieves a paginated list of deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual IAsyncResult BeginListDeployments(ListDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeployments.</param>
        /// 
        /// <returns>Returns a  ListDeploymentsResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual ListDeploymentsResponse EndListDeployments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeploymentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEffectiveDeployments

        /// <summary>
        /// Retrieves a paginated list of deployment jobs that IoT Greengrass sends to Greengrass
        /// core devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEffectiveDeployments service method.</param>
        /// 
        /// <returns>The response from the ListEffectiveDeployments service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListEffectiveDeployments">REST API Reference for ListEffectiveDeployments Operation</seealso>
        public virtual ListEffectiveDeploymentsResponse ListEffectiveDeployments(ListEffectiveDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEffectiveDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEffectiveDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListEffectiveDeploymentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEffectiveDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEffectiveDeployments operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEffectiveDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListEffectiveDeployments">REST API Reference for ListEffectiveDeployments Operation</seealso>
        public virtual IAsyncResult BeginListEffectiveDeployments(ListEffectiveDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEffectiveDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEffectiveDeploymentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEffectiveDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEffectiveDeployments.</param>
        /// 
        /// <returns>Returns a  ListEffectiveDeploymentsResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListEffectiveDeployments">REST API Reference for ListEffectiveDeployments Operation</seealso>
        public virtual ListEffectiveDeploymentsResponse EndListEffectiveDeployments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEffectiveDeploymentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstalledComponents

        /// <summary>
        /// Retrieves a paginated list of the components that a Greengrass core device runs. By
        /// default, this list doesn't include components that are deployed as dependencies of
        /// other components. To include dependencies in the response, set the <c>topologyFilter</c>
        /// parameter to <c>ALL</c>.
        /// 
        ///  <note> 
        /// <para>
        /// IoT Greengrass relies on individual devices to send status updates to the Amazon Web
        /// Services Cloud. If the IoT Greengrass Core software isn't running on the device, or
        /// if device isn't connected to the Amazon Web Services Cloud, then the reported status
        /// of that device might not reflect its current status. The status timestamp indicates
        /// when the device status was last updated.
        /// </para>
        ///  
        /// <para>
        /// Core devices send status updates at the following times:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When the IoT Greengrass Core software starts
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the core device receives a deployment from the Amazon Web Services Cloud
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the status of any component on the core device becomes <c>BROKEN</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// At a <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-nucleus-component.html#greengrass-nucleus-component-configuration-fss">regular
        /// interval that you can configure</a>, which defaults to 24 hours
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For IoT Greengrass Core v2.7.0, the core device sends status updates upon local deployment
        /// and cloud deployment
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstalledComponents service method.</param>
        /// 
        /// <returns>The response from the ListInstalledComponents service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListInstalledComponents">REST API Reference for ListInstalledComponents Operation</seealso>
        public virtual ListInstalledComponentsResponse ListInstalledComponents(ListInstalledComponentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstalledComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstalledComponentsResponseUnmarshaller.Instance;

            return Invoke<ListInstalledComponentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstalledComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstalledComponents operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstalledComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListInstalledComponents">REST API Reference for ListInstalledComponents Operation</seealso>
        public virtual IAsyncResult BeginListInstalledComponents(ListInstalledComponentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstalledComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstalledComponentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstalledComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstalledComponents.</param>
        /// 
        /// <returns>Returns a  ListInstalledComponentsResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListInstalledComponents">REST API Reference for ListInstalledComponents Operation</seealso>
        public virtual ListInstalledComponentsResponse EndListInstalledComponents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstalledComponentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves the list of tags for an IoT Greengrass resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ResolveComponentCandidates

        /// <summary>
        /// Retrieves a list of components that meet the component, version, and platform requirements
        /// of a deployment. Greengrass core devices call this operation when they receive a deployment
        /// to identify the components to install.
        /// 
        ///  
        /// <para>
        /// This operation identifies components that meet all dependency requirements for a deployment.
        /// If the requirements conflict, then this operation returns an error and the deployment
        /// fails. For example, this occurs if component <c>A</c> requires version <c>&gt;2.0.0</c>
        /// and component <c>B</c> requires version <c>&lt;2.0.0</c> of a component dependency.
        /// </para>
        ///  
        /// <para>
        /// When you specify the component candidates to resolve, IoT Greengrass compares each
        /// component's digest from the core device with the component's digest in the Amazon
        /// Web Services Cloud. If the digests don't match, then IoT Greengrass specifies to use
        /// the version from the Amazon Web Services Cloud.
        /// </para>
        ///  <important> 
        /// <para>
        /// To use this operation, you must use the data plane API endpoint and authenticate with
        /// an IoT device certificate. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/greengrass.html">IoT
        /// Greengrass endpoints and quotas</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveComponentCandidates service method.</param>
        /// 
        /// <returns>The response from the ResolveComponentCandidates service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ResolveComponentCandidates">REST API Reference for ResolveComponentCandidates Operation</seealso>
        public virtual ResolveComponentCandidatesResponse ResolveComponentCandidates(ResolveComponentCandidatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResolveComponentCandidatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveComponentCandidatesResponseUnmarshaller.Instance;

            return Invoke<ResolveComponentCandidatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResolveComponentCandidates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveComponentCandidates operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResolveComponentCandidates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ResolveComponentCandidates">REST API Reference for ResolveComponentCandidates Operation</seealso>
        public virtual IAsyncResult BeginResolveComponentCandidates(ResolveComponentCandidatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResolveComponentCandidatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveComponentCandidatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResolveComponentCandidates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResolveComponentCandidates.</param>
        /// 
        /// <returns>Returns a  ResolveComponentCandidatesResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ResolveComponentCandidates">REST API Reference for ResolveComponentCandidates Operation</seealso>
        public virtual ResolveComponentCandidatesResponse EndResolveComponentCandidates(IAsyncResult asyncResult)
        {
            return EndInvoke<ResolveComponentCandidatesResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds tags to an IoT Greengrass resource. If a tag already exists for the resource,
        /// this operation updates the tag's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from an IoT Greengrass resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConnectivityInfo

        /// <summary>
        /// Updates connectivity information for a Greengrass core device.
        /// 
        ///  
        /// <para>
        /// Connectivity information includes endpoints and ports where client devices can connect
        /// to an MQTT broker on the core device. When a client device calls the <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-discover-api.html">IoT
        /// Greengrass discovery API</a>, IoT Greengrass returns connectivity information for
        /// all of the core devices where the client device can connect. For more information,
        /// see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/connect-client-devices.html">Connect
        /// client devices to core devices</a> in the <i>IoT Greengrass Version 2 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectivityInfo service method.</param>
        /// 
        /// <returns>The response from the UpdateConnectivityInfo service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/UpdateConnectivityInfo">REST API Reference for UpdateConnectivityInfo Operation</seealso>
        public virtual UpdateConnectivityInfoResponse UpdateConnectivityInfo(UpdateConnectivityInfoRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectivityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectivityInfoResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectivityInfoResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnectivityInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectivityInfo operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnectivityInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/UpdateConnectivityInfo">REST API Reference for UpdateConnectivityInfo Operation</seealso>
        public virtual IAsyncResult BeginUpdateConnectivityInfo(UpdateConnectivityInfoRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectivityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectivityInfoResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectivityInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectivityInfo.</param>
        /// 
        /// <returns>Returns a  UpdateConnectivityInfoResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/UpdateConnectivityInfo">REST API Reference for UpdateConnectivityInfo Operation</seealso>
        public virtual UpdateConnectivityInfoResponse EndUpdateConnectivityInfo(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConnectivityInfoResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonGreengrassV2EndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}