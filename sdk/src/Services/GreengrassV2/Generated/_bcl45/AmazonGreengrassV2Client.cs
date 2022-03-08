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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.GreengrassV2.Model;
using Amazon.GreengrassV2.Model.Internal.MarshallTransformations;
using Amazon.GreengrassV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.GreengrassV2
{
    /// <summary>
    /// Implementation for accessing GreengrassV2
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateServiceRoleToAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceRoleToAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateServiceRoleToAccountResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateServiceRoleToAccountResponse> AssociateServiceRoleToAccountAsync(AssociateServiceRoleToAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateServiceRoleToAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceRoleToAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateServiceRoleToAccountResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateClientDeviceWithCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateClientDeviceWithCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateClientDeviceWithCoreDeviceResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchAssociateClientDeviceWithCoreDeviceResponse> BatchAssociateClientDeviceWithCoreDeviceAsync(BatchAssociateClientDeviceWithCoreDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateClientDeviceWithCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateClientDeviceWithCoreDeviceResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchAssociateClientDeviceWithCoreDeviceResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateClientDeviceFromCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateClientDeviceFromCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateClientDeviceFromCoreDeviceResponse>(request, options);
        }


        /// <summary>
        /// Disassociates a list of client devices from a core device. After you disassociate
        /// a client device from a core device, the client device won't be able to use cloud discovery
        /// to retrieve the core device's connectivity information and certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateClientDeviceFromCoreDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchDisassociateClientDeviceFromCoreDeviceResponse> BatchDisassociateClientDeviceFromCoreDeviceAsync(BatchDisassociateClientDeviceFromCoreDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateClientDeviceFromCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateClientDeviceFromCoreDeviceResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDisassociateClientDeviceFromCoreDeviceResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDeploymentResponseUnmarshaller.Instance;

            return Invoke<CancelDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Cancels a deployment. This operation cancels the deployment for devices that haven't
        /// yet received it. If a device already received the deployment, this operation doesn't
        /// change anything for that device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelDeploymentResponse> CancelDeploymentAsync(CancelDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelDeploymentResponse>(request, options, cancellationToken);
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
        /// To create a component from a recipe, specify <code>inlineRecipe</code> when you call
        /// this operation.
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
        /// This function only accepts Lambda functions that use the following runtimes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Python 2.7 – <code>python2.7</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Python 3.7 – <code>python3.7</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Python 3.8 – <code>python3.8</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Java 8 – <code>java8</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Node.js 10 – <code>nodejs10.x</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Node.js 12 – <code>nodejs12.x</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create a component from a Lambda function, specify <code>lambdaFunction</code>
        /// when you call this operation.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentVersionResponseUnmarshaller.Instance;

            return Invoke<CreateComponentVersionResponse>(request, options);
        }


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
        /// To create a component from a recipe, specify <code>inlineRecipe</code> when you call
        /// this operation.
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
        /// This function only accepts Lambda functions that use the following runtimes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Python 2.7 – <code>python2.7</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Python 3.7 – <code>python3.7</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Python 3.8 – <code>python3.8</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Java 8 – <code>java8</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Node.js 10 – <code>nodejs10.x</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Node.js 12 – <code>nodejs12.x</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create a component from a Lambda function, specify <code>lambdaFunction</code>
        /// when you call this operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// IoT Greengrass currently supports Lambda functions on only Linux core devices.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponentVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateComponentVersionResponse> CreateComponentVersionAsync(CreateComponentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateComponentVersionResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
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
        public virtual Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDeploymentResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteComponentResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteComponentResponse> DeleteComponentAsync(DeleteComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteComponentResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteCoreDeviceResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Greengrass core device, which is an IoT thing. This operation removes the
        /// core device from the list of core devices. This operation doesn't delete the IoT thing.
        /// For more information about how to delete the IoT thing, see <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_DeleteThing.html">DeleteThing</a>
        /// in the <i>IoT API Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteCoreDeviceResponse> DeleteCoreDeviceAsync(DeleteCoreDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreDeviceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCoreDeviceResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentResponseUnmarshaller.Instance;

            return Invoke<DescribeComponentResponse>(request, options);
        }


        /// <summary>
        /// Retrieves metadata for a version of a component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeComponentResponse> DescribeComponentAsync(DescribeComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeComponentResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateServiceRoleFromAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceRoleFromAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateServiceRoleFromAccountResponse>(request, options);
        }


        /// <summary>
        /// Disassociates the Greengrass service role from IoT Greengrass for your Amazon Web
        /// Services account in this Amazon Web Services Region. Without a service role, IoT Greengrass
        /// can't verify the identity of client devices or manage core device connectivity information.
        /// For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-service-role.html">Greengrass
        /// service role</a> in the <i>IoT Greengrass Version 2 Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceRoleFromAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateServiceRoleFromAccount service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DisassociateServiceRoleFromAccount">REST API Reference for DisassociateServiceRoleFromAccount Operation</seealso>
        public virtual Task<DisassociateServiceRoleFromAccountResponse> DisassociateServiceRoleFromAccountAsync(DisassociateServiceRoleFromAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateServiceRoleFromAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceRoleFromAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateServiceRoleFromAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComponent


        /// <summary>
        /// Gets the recipe for a version of a component. Core devices can call this operation
        /// to identify the artifacts and requirements to install a component.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return Invoke<GetComponentResponse>(request, options);
        }


        /// <summary>
        /// Gets the recipe for a version of a component. Core devices can call this operation
        /// to identify the artifacts and requirements to install a component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetComponentResponse> GetComponentAsync(GetComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComponentVersionArtifact


        /// <summary>
        /// Gets the pre-signed URL to download a public component artifact. Core devices call
        /// this operation to identify the URL that they can use to download an artifact to install.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentVersionArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentVersionArtifactResponseUnmarshaller.Instance;

            return Invoke<GetComponentVersionArtifactResponse>(request, options);
        }


        /// <summary>
        /// Gets the pre-signed URL to download a public component artifact. Core devices call
        /// this operation to identify the URL that they can use to download an artifact to install.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponentVersionArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetComponentVersionArtifactResponse> GetComponentVersionArtifactAsync(GetComponentVersionArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentVersionArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentVersionArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetComponentVersionArtifactResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectivityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectivityInfoResponseUnmarshaller.Instance;

            return Invoke<GetConnectivityInfoResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetConnectivityInfoResponse> GetConnectivityInfoAsync(GetConnectivityInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectivityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectivityInfoResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetConnectivityInfoResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCoreDevice


        /// <summary>
        /// Retrieves metadata for a Greengrass core device.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<GetCoreDeviceResponse>(request, options);
        }


        /// <summary>
        /// Retrieves metadata for a Greengrass core device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetCoreDeviceResponse> GetCoreDeviceAsync(GetCoreDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreDeviceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCoreDeviceResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Gets a deployment. Deployments define the components that run on Greengrass core devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDeploymentResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceRoleForAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceRoleForAccountResponseUnmarshaller.Instance;

            return Invoke<GetServiceRoleForAccountResponse>(request, options);
        }


        /// <summary>
        /// Gets the service role associated with IoT Greengrass for your Amazon Web Services
        /// account in this Amazon Web Services Region. IoT Greengrass uses this role to verify
        /// the identity of client devices and manage core device connectivity information. For
        /// more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-service-role.html">Greengrass
        /// service role</a> in the <i>IoT Greengrass Version 2 Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceRoleForAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceRoleForAccount service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetServiceRoleForAccount">REST API Reference for GetServiceRoleForAccount Operation</seealso>
        public virtual Task<GetServiceRoleForAccountResponse> GetServiceRoleForAccountAsync(GetServiceRoleForAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceRoleForAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceRoleForAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetServiceRoleForAccountResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClientDevicesAssociatedWithCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClientDevicesAssociatedWithCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<ListClientDevicesAssociatedWithCoreDeviceResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a paginated list of client devices that are associated with a core device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClientDevicesAssociatedWithCoreDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListClientDevicesAssociatedWithCoreDeviceResponse> ListClientDevicesAssociatedWithCoreDeviceAsync(ListClientDevicesAssociatedWithCoreDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClientDevicesAssociatedWithCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClientDevicesAssociatedWithCoreDeviceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListClientDevicesAssociatedWithCoreDeviceResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return Invoke<ListComponentsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a paginated list of component summaries. This list includes components that
        /// you have permission to view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by GreengrassV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual Task<ListComponentsResponse> ListComponentsAsync(ListComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListComponentsResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentVersionsResponseUnmarshaller.Instance;

            return Invoke<ListComponentVersionsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a paginated list of all versions for a component. Greater versions are listed
        /// first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponentVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListComponentVersionsResponse> ListComponentVersionsAsync(ListComponentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListComponentVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCoreDevices


        /// <summary>
        /// Retrieves a paginated list of Greengrass core devices.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCoreDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreDevicesResponseUnmarshaller.Instance;

            return Invoke<ListCoreDevicesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a paginated list of Greengrass core devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListCoreDevicesResponse> ListCoreDevicesAsync(ListCoreDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCoreDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreDevicesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCoreDevicesResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a paginated list of deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDeploymentsResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEffectiveDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEffectiveDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListEffectiveDeploymentsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a paginated list of deployment jobs that IoT Greengrass sends to Greengrass
        /// core devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEffectiveDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListEffectiveDeploymentsResponse> ListEffectiveDeploymentsAsync(ListEffectiveDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEffectiveDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEffectiveDeploymentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEffectiveDeploymentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInstalledComponents


        /// <summary>
        /// Retrieves a paginated list of the components that a Greengrass core device runs.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstalledComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstalledComponentsResponseUnmarshaller.Instance;

            return Invoke<ListInstalledComponentsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a paginated list of the components that a Greengrass core device runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstalledComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListInstalledComponentsResponse> ListInstalledComponentsAsync(ListInstalledComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstalledComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstalledComponentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListInstalledComponentsResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the list of tags for an IoT Greengrass resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// fails. For example, this occurs if component <code>A</code> requires version <code>&gt;2.0.0</code>
        /// and component <code>B</code> requires version <code>&lt;2.0.0</code> of a component
        /// dependency.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveComponentCandidatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveComponentCandidatesResponseUnmarshaller.Instance;

            return Invoke<ResolveComponentCandidatesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of components that meet the component, version, and platform requirements
        /// of a deployment. Greengrass core devices call this operation when they receive a deployment
        /// to identify the components to install.
        /// 
        ///  
        /// <para>
        /// This operation identifies components that meet all dependency requirements for a deployment.
        /// If the requirements conflict, then this operation returns an error and the deployment
        /// fails. For example, this occurs if component <code>A</code> requires version <code>&gt;2.0.0</code>
        /// and component <code>B</code> requires version <code>&lt;2.0.0</code> of a component
        /// dependency.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ResolveComponentCandidatesResponse> ResolveComponentCandidatesAsync(ResolveComponentCandidatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveComponentCandidatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveComponentCandidatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResolveComponentCandidatesResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds tags to an IoT Greengrass resource. If a tag already exists for the resource,
        /// this operation updates the tag's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes a tag from an IoT Greengrass resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectivityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectivityInfoResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectivityInfoResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateConnectivityInfoResponse> UpdateConnectivityInfoAsync(UpdateConnectivityInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectivityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectivityInfoResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateConnectivityInfoResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}