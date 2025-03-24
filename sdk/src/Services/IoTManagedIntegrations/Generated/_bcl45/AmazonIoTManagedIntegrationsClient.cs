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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTManagedIntegrations.Model;
using Amazon.IoTManagedIntegrations.Model.Internal.MarshallTransformations;
using Amazon.IoTManagedIntegrations.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.IoTManagedIntegrations
{
    /// <summary>
    /// <para>Implementation for accessing IoTManagedIntegrations</para>
    ///
    /// Managed integrations is a feature of AWS IoT Device Management that enables developers
    /// to quickly build innovative IoT solutions. Customers can use managed integrations
    /// to automate device setup workflows and support interoperability across many devices,
    /// regardless of device vendor or connectivity protocol. This allows developers to use
    /// a single user-interface to control, manage, and operate a range of devices.
    /// </summary>
    public partial class AmazonIoTManagedIntegrationsClient : AmazonServiceClient, IAmazonIoTManagedIntegrations
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTManagedIntegrationsMetadata();
        private IIoTManagedIntegrationsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIoTManagedIntegrationsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IoTManagedIntegrationsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTManagedIntegrationsClient with the credentials loaded from the application's
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
        public AmazonIoTManagedIntegrationsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTManagedIntegrationsConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTManagedIntegrationsClient with the credentials loaded from the application's
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
        public AmazonIoTManagedIntegrationsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTManagedIntegrationsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTManagedIntegrationsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTManagedIntegrationsClient Configuration Object</param>
        public AmazonIoTManagedIntegrationsClient(AmazonIoTManagedIntegrationsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

        /// <summary>
        /// Constructs AmazonIoTManagedIntegrationsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTManagedIntegrationsClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTManagedIntegrationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTManagedIntegrationsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTManagedIntegrationsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTManagedIntegrationsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTManagedIntegrationsClient with AWS Credentials and an
        /// AmazonIoTManagedIntegrationsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTManagedIntegrationsClient Configuration Object</param>
        public AmazonIoTManagedIntegrationsClient(AWSCredentials credentials, AmazonIoTManagedIntegrationsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTManagedIntegrationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTManagedIntegrationsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTManagedIntegrationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTManagedIntegrationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTManagedIntegrationsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTManagedIntegrationsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTManagedIntegrationsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTManagedIntegrationsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTManagedIntegrationsClient Configuration Object</param>
        public AmazonIoTManagedIntegrationsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTManagedIntegrationsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTManagedIntegrationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTManagedIntegrationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTManagedIntegrationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTManagedIntegrationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTManagedIntegrationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTManagedIntegrationsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTManagedIntegrationsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTManagedIntegrationsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTManagedIntegrationsClient Configuration Object</param>
        public AmazonIoTManagedIntegrationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTManagedIntegrationsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTManagedIntegrationsEndpointResolver());
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


        #region  CreateCredentialLocker


        /// <summary>
        /// Create a product credential locker. This operation will trigger the creation of all
        /// the manufacturing resources including the Wi-Fi setup key pair and device certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCredentialLocker service method.</param>
        /// 
        /// <returns>The response from the CreateCredentialLocker service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded for this request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateCredentialLocker">REST API Reference for CreateCredentialLocker Operation</seealso>
        public virtual CreateCredentialLockerResponse CreateCredentialLocker(CreateCredentialLockerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCredentialLockerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCredentialLockerResponseUnmarshaller.Instance;

            return Invoke<CreateCredentialLockerResponse>(request, options);
        }


        /// <summary>
        /// Create a product credential locker. This operation will trigger the creation of all
        /// the manufacturing resources including the Wi-Fi setup key pair and device certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCredentialLocker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCredentialLocker service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded for this request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateCredentialLocker">REST API Reference for CreateCredentialLocker Operation</seealso>
        public virtual Task<CreateCredentialLockerResponse> CreateCredentialLockerAsync(CreateCredentialLockerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCredentialLockerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCredentialLockerResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCredentialLockerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDestination


        /// <summary>
        /// Create a destination. IoT managed integrations uses the destination to determine
        /// where to deliver notifications for a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination service method.</param>
        /// 
        /// <returns>The response from the CreateDestination service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        public virtual CreateDestinationResponse CreateDestination(CreateDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateDestinationResponse>(request, options);
        }


        /// <summary>
        /// Create a destination. IoT managed integrations uses the destination to determine
        /// where to deliver notifications for a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDestination service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        public virtual Task<CreateDestinationResponse> CreateDestinationAsync(CreateDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEventLogConfiguration


        /// <summary>
        /// Set the event log configuration for the account, resource type, or specific resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventLogConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateEventLogConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded for this request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateEventLogConfiguration">REST API Reference for CreateEventLogConfiguration Operation</seealso>
        public virtual CreateEventLogConfigurationResponse CreateEventLogConfiguration(CreateEventLogConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventLogConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateEventLogConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Set the event log configuration for the account, resource type, or specific resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventLogConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventLogConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded for this request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateEventLogConfiguration">REST API Reference for CreateEventLogConfiguration Operation</seealso>
        public virtual Task<CreateEventLogConfigurationResponse> CreateEventLogConfigurationAsync(CreateEventLogConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventLogConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEventLogConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateManagedThing


        /// <summary>
        /// Creates a managed thing. A managed thing contains the device identifier, protocol
        /// supported, and capabilities of the device in a protocol-specific format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateManagedThing service method.</param>
        /// 
        /// <returns>The response from the CreateManagedThing service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateManagedThing">REST API Reference for CreateManagedThing Operation</seealso>
        public virtual CreateManagedThingResponse CreateManagedThing(CreateManagedThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateManagedThingResponseUnmarshaller.Instance;

            return Invoke<CreateManagedThingResponse>(request, options);
        }


        /// <summary>
        /// Creates a managed thing. A managed thing contains the device identifier, protocol
        /// supported, and capabilities of the device in a protocol-specific format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateManagedThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateManagedThing service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateManagedThing">REST API Reference for CreateManagedThing Operation</seealso>
        public virtual Task<CreateManagedThingResponse> CreateManagedThingAsync(CreateManagedThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateManagedThingResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateManagedThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNotificationConfiguration


        /// <summary>
        /// Creates a notification configuration. A configuration is a connection between an event
        /// type and a destination that you have already created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateNotificationConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateNotificationConfiguration">REST API Reference for CreateNotificationConfiguration Operation</seealso>
        public virtual CreateNotificationConfigurationResponse CreateNotificationConfiguration(CreateNotificationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates a notification configuration. A configuration is a connection between an event
        /// type and a destination that you have already created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNotificationConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateNotificationConfiguration">REST API Reference for CreateNotificationConfiguration Operation</seealso>
        public virtual Task<CreateNotificationConfigurationResponse> CreateNotificationConfigurationAsync(CreateNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOtaTask


        /// <summary>
        /// Create an over-the-air (OTA) task to update a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOtaTask service method.</param>
        /// 
        /// <returns>The response from the CreateOtaTask service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateOtaTask">REST API Reference for CreateOtaTask Operation</seealso>
        public virtual CreateOtaTaskResponse CreateOtaTask(CreateOtaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOtaTaskResponseUnmarshaller.Instance;

            return Invoke<CreateOtaTaskResponse>(request, options);
        }


        /// <summary>
        /// Create an over-the-air (OTA) task to update a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOtaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOtaTask service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateOtaTask">REST API Reference for CreateOtaTask Operation</seealso>
        public virtual Task<CreateOtaTaskResponse> CreateOtaTaskAsync(CreateOtaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOtaTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateOtaTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOtaTaskConfiguration


        /// <summary>
        /// Create a configuraiton for the over-the-air (OTA) task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOtaTaskConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateOtaTaskConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateOtaTaskConfiguration">REST API Reference for CreateOtaTaskConfiguration Operation</seealso>
        public virtual CreateOtaTaskConfigurationResponse CreateOtaTaskConfiguration(CreateOtaTaskConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOtaTaskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOtaTaskConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateOtaTaskConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Create a configuraiton for the over-the-air (OTA) task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOtaTaskConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOtaTaskConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateOtaTaskConfiguration">REST API Reference for CreateOtaTaskConfiguration Operation</seealso>
        public virtual Task<CreateOtaTaskConfigurationResponse> CreateOtaTaskConfigurationAsync(CreateOtaTaskConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOtaTaskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOtaTaskConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateOtaTaskConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProvisioningProfile


        /// <summary>
        /// Create a provisioning profile for a device to execute the provisioning flows using
        /// a provisioning template. The provisioning template is a document that defines the
        /// set of resources and policies applied to a device during the provisioning process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningProfile service method.</param>
        /// 
        /// <returns>The response from the CreateProvisioningProfile service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateProvisioningProfile">REST API Reference for CreateProvisioningProfile Operation</seealso>
        public virtual CreateProvisioningProfileResponse CreateProvisioningProfile(CreateProvisioningProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisioningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningProfileResponseUnmarshaller.Instance;

            return Invoke<CreateProvisioningProfileResponse>(request, options);
        }


        /// <summary>
        /// Create a provisioning profile for a device to execute the provisioning flows using
        /// a provisioning template. The provisioning template is a document that defines the
        /// set of resources and policies applied to a device during the provisioning process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProvisioningProfile service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateProvisioningProfile">REST API Reference for CreateProvisioningProfile Operation</seealso>
        public virtual Task<CreateProvisioningProfileResponse> CreateProvisioningProfileAsync(CreateProvisioningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisioningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProvisioningProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCredentialLocker


        /// <summary>
        /// Delete a credential locker. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation can't be undone and any existing device won't be able to use IoT managed
        /// integrations.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCredentialLocker service method.</param>
        /// 
        /// <returns>The response from the DeleteCredentialLocker service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteCredentialLocker">REST API Reference for DeleteCredentialLocker Operation</seealso>
        public virtual DeleteCredentialLockerResponse DeleteCredentialLocker(DeleteCredentialLockerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCredentialLockerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCredentialLockerResponseUnmarshaller.Instance;

            return Invoke<DeleteCredentialLockerResponse>(request, options);
        }


        /// <summary>
        /// Delete a credential locker. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation can't be undone and any existing device won't be able to use IoT managed
        /// integrations.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCredentialLocker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCredentialLocker service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteCredentialLocker">REST API Reference for DeleteCredentialLocker Operation</seealso>
        public virtual Task<DeleteCredentialLockerResponse> DeleteCredentialLockerAsync(DeleteCredentialLockerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCredentialLockerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCredentialLockerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCredentialLockerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDestination


        /// <summary>
        /// Deletes a customer-managed destination specified by id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteDestination service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteDestinationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a customer-managed destination specified by id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDestination service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual Task<DeleteDestinationResponse> DeleteDestinationAsync(DeleteDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventLogConfiguration


        /// <summary>
        /// Delete an event log configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventLogConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteEventLogConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteEventLogConfiguration">REST API Reference for DeleteEventLogConfiguration Operation</seealso>
        public virtual DeleteEventLogConfigurationResponse DeleteEventLogConfiguration(DeleteEventLogConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventLogConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteEventLogConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Delete an event log configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventLogConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventLogConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteEventLogConfiguration">REST API Reference for DeleteEventLogConfiguration Operation</seealso>
        public virtual Task<DeleteEventLogConfigurationResponse> DeleteEventLogConfigurationAsync(DeleteEventLogConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventLogConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEventLogConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteManagedThing


        /// <summary>
        /// Delete a managed thing. If a controller is deleted, all of the devices connected to
        /// it will have their status changed to <c>PENDING</c>. It is not possible to remove
        /// a cloud device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteManagedThing service method.</param>
        /// 
        /// <returns>The response from the DeleteManagedThing service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteManagedThing">REST API Reference for DeleteManagedThing Operation</seealso>
        public virtual DeleteManagedThingResponse DeleteManagedThing(DeleteManagedThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteManagedThingResponseUnmarshaller.Instance;

            return Invoke<DeleteManagedThingResponse>(request, options);
        }


        /// <summary>
        /// Delete a managed thing. If a controller is deleted, all of the devices connected to
        /// it will have their status changed to <c>PENDING</c>. It is not possible to remove
        /// a cloud device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteManagedThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteManagedThing service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteManagedThing">REST API Reference for DeleteManagedThing Operation</seealso>
        public virtual Task<DeleteManagedThingResponse> DeleteManagedThingAsync(DeleteManagedThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteManagedThingResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteManagedThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotificationConfiguration


        /// <summary>
        /// Deletes a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteNotificationConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        public virtual DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotificationConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        public virtual Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOtaTask


        /// <summary>
        /// Delete the over-the-air (OTA) task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOtaTask service method.</param>
        /// 
        /// <returns>The response from the DeleteOtaTask service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteOtaTask">REST API Reference for DeleteOtaTask Operation</seealso>
        public virtual DeleteOtaTaskResponse DeleteOtaTask(DeleteOtaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOtaTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteOtaTaskResponse>(request, options);
        }


        /// <summary>
        /// Delete the over-the-air (OTA) task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOtaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOtaTask service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteOtaTask">REST API Reference for DeleteOtaTask Operation</seealso>
        public virtual Task<DeleteOtaTaskResponse> DeleteOtaTaskAsync(DeleteOtaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOtaTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteOtaTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOtaTaskConfiguration


        /// <summary>
        /// Delete the over-the-air (OTA) task configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOtaTaskConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteOtaTaskConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteOtaTaskConfiguration">REST API Reference for DeleteOtaTaskConfiguration Operation</seealso>
        public virtual DeleteOtaTaskConfigurationResponse DeleteOtaTaskConfiguration(DeleteOtaTaskConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOtaTaskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOtaTaskConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteOtaTaskConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Delete the over-the-air (OTA) task configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOtaTaskConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOtaTaskConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteOtaTaskConfiguration">REST API Reference for DeleteOtaTaskConfiguration Operation</seealso>
        public virtual Task<DeleteOtaTaskConfigurationResponse> DeleteOtaTaskConfigurationAsync(DeleteOtaTaskConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOtaTaskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOtaTaskConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteOtaTaskConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProvisioningProfile


        /// <summary>
        /// Delete a provisioning profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisioningProfile service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteProvisioningProfile">REST API Reference for DeleteProvisioningProfile Operation</seealso>
        public virtual DeleteProvisioningProfileResponse DeleteProvisioningProfile(DeleteProvisioningProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisioningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisioningProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisioningProfileResponse>(request, options);
        }


        /// <summary>
        /// Delete a provisioning profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProvisioningProfile service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteProvisioningProfile">REST API Reference for DeleteProvisioningProfile Operation</seealso>
        public virtual Task<DeleteProvisioningProfileResponse> DeleteProvisioningProfileAsync(DeleteProvisioningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisioningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisioningProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProvisioningProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCredentialLocker


        /// <summary>
        /// Get information on an existing credential locker
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialLocker service method.</param>
        /// 
        /// <returns>The response from the GetCredentialLocker service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetCredentialLocker">REST API Reference for GetCredentialLocker Operation</seealso>
        public virtual GetCredentialLockerResponse GetCredentialLocker(GetCredentialLockerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCredentialLockerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialLockerResponseUnmarshaller.Instance;

            return Invoke<GetCredentialLockerResponse>(request, options);
        }


        /// <summary>
        /// Get information on an existing credential locker
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialLocker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCredentialLocker service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetCredentialLocker">REST API Reference for GetCredentialLocker Operation</seealso>
        public virtual Task<GetCredentialLockerResponse> GetCredentialLockerAsync(GetCredentialLockerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCredentialLockerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialLockerResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCredentialLockerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCustomEndpoint


        /// <summary>
        /// Returns the IoT managed integrations custom endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetCustomEndpoint service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetCustomEndpoint">REST API Reference for GetCustomEndpoint Operation</seealso>
        public virtual GetCustomEndpointResponse GetCustomEndpoint(GetCustomEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomEndpointResponseUnmarshaller.Instance;

            return Invoke<GetCustomEndpointResponse>(request, options);
        }


        /// <summary>
        /// Returns the IoT managed integrations custom endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCustomEndpoint service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetCustomEndpoint">REST API Reference for GetCustomEndpoint Operation</seealso>
        public virtual Task<GetCustomEndpointResponse> GetCustomEndpointAsync(GetCustomEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCustomEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDefaultEncryptionConfiguration


        /// <summary>
        /// Retrieves information about the default encryption configuration for the Amazon Web
        /// Services account in the default or specified region. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/key-management.html">Key
        /// management</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultEncryptionConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetDefaultEncryptionConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDefaultEncryptionConfiguration">REST API Reference for GetDefaultEncryptionConfiguration Operation</seealso>
        public virtual GetDefaultEncryptionConfigurationResponse GetDefaultEncryptionConfiguration(GetDefaultEncryptionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDefaultEncryptionConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetDefaultEncryptionConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the default encryption configuration for the Amazon Web
        /// Services account in the default or specified region. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/key-management.html">Key
        /// management</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultEncryptionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDefaultEncryptionConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDefaultEncryptionConfiguration">REST API Reference for GetDefaultEncryptionConfiguration Operation</seealso>
        public virtual Task<GetDefaultEncryptionConfigurationResponse> GetDefaultEncryptionConfigurationAsync(GetDefaultEncryptionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDefaultEncryptionConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDefaultEncryptionConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDestination


        /// <summary>
        /// Gets a destination by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDestination service method.</param>
        /// 
        /// <returns>The response from the GetDestination service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDestination">REST API Reference for GetDestination Operation</seealso>
        public virtual GetDestinationResponse GetDestination(GetDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDestinationResponseUnmarshaller.Instance;

            return Invoke<GetDestinationResponse>(request, options);
        }


        /// <summary>
        /// Gets a destination by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDestination service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDestination">REST API Reference for GetDestination Operation</seealso>
        public virtual Task<GetDestinationResponse> GetDestinationAsync(GetDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeviceDiscovery


        /// <summary>
        /// Get the current state of a device discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDiscovery service method.</param>
        /// 
        /// <returns>The response from the GetDeviceDiscovery service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDeviceDiscovery">REST API Reference for GetDeviceDiscovery Operation</seealso>
        public virtual GetDeviceDiscoveryResponse GetDeviceDiscovery(GetDeviceDiscoveryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceDiscoveryResponseUnmarshaller.Instance;

            return Invoke<GetDeviceDiscoveryResponse>(request, options);
        }


        /// <summary>
        /// Get the current state of a device discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDiscovery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeviceDiscovery service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDeviceDiscovery">REST API Reference for GetDeviceDiscovery Operation</seealso>
        public virtual Task<GetDeviceDiscoveryResponse> GetDeviceDiscoveryAsync(GetDeviceDiscoveryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceDiscoveryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDeviceDiscoveryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEventLogConfiguration


        /// <summary>
        /// Get an event log configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventLogConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetEventLogConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetEventLogConfiguration">REST API Reference for GetEventLogConfiguration Operation</seealso>
        public virtual GetEventLogConfigurationResponse GetEventLogConfiguration(GetEventLogConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventLogConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetEventLogConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Get an event log configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventLogConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventLogConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetEventLogConfiguration">REST API Reference for GetEventLogConfiguration Operation</seealso>
        public virtual Task<GetEventLogConfigurationResponse> GetEventLogConfigurationAsync(GetEventLogConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventLogConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEventLogConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHubConfiguration


        /// <summary>
        /// Get a hub configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHubConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetHubConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetHubConfiguration">REST API Reference for GetHubConfiguration Operation</seealso>
        public virtual GetHubConfigurationResponse GetHubConfiguration(GetHubConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHubConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHubConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetHubConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Get a hub configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHubConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHubConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetHubConfiguration">REST API Reference for GetHubConfiguration Operation</seealso>
        public virtual Task<GetHubConfigurationResponse> GetHubConfigurationAsync(GetHubConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHubConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHubConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetHubConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetManagedThing


        /// <summary>
        /// Get the attributes and capabilities associated with a managed thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThing service method.</param>
        /// 
        /// <returns>The response from the GetManagedThing service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThing">REST API Reference for GetManagedThing Operation</seealso>
        public virtual GetManagedThingResponse GetManagedThing(GetManagedThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingResponseUnmarshaller.Instance;

            return Invoke<GetManagedThingResponse>(request, options);
        }


        /// <summary>
        /// Get the attributes and capabilities associated with a managed thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedThing service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThing">REST API Reference for GetManagedThing Operation</seealso>
        public virtual Task<GetManagedThingResponse> GetManagedThingAsync(GetManagedThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetManagedThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetManagedThingCapabilities


        /// <summary>
        /// Get the capabilities for a managed thing using the device ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThingCapabilities service method.</param>
        /// 
        /// <returns>The response from the GetManagedThingCapabilities service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingCapabilities">REST API Reference for GetManagedThingCapabilities Operation</seealso>
        public virtual GetManagedThingCapabilitiesResponse GetManagedThingCapabilities(GetManagedThingCapabilitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedThingCapabilitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingCapabilitiesResponseUnmarshaller.Instance;

            return Invoke<GetManagedThingCapabilitiesResponse>(request, options);
        }


        /// <summary>
        /// Get the capabilities for a managed thing using the device ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThingCapabilities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedThingCapabilities service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingCapabilities">REST API Reference for GetManagedThingCapabilities Operation</seealso>
        public virtual Task<GetManagedThingCapabilitiesResponse> GetManagedThingCapabilitiesAsync(GetManagedThingCapabilitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedThingCapabilitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingCapabilitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetManagedThingCapabilitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetManagedThingConnectivityData


        /// <summary>
        /// Get the connectivity status of a managed thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThingConnectivityData service method.</param>
        /// 
        /// <returns>The response from the GetManagedThingConnectivityData service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingConnectivityData">REST API Reference for GetManagedThingConnectivityData Operation</seealso>
        public virtual GetManagedThingConnectivityDataResponse GetManagedThingConnectivityData(GetManagedThingConnectivityDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedThingConnectivityDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingConnectivityDataResponseUnmarshaller.Instance;

            return Invoke<GetManagedThingConnectivityDataResponse>(request, options);
        }


        /// <summary>
        /// Get the connectivity status of a managed thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThingConnectivityData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedThingConnectivityData service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingConnectivityData">REST API Reference for GetManagedThingConnectivityData Operation</seealso>
        public virtual Task<GetManagedThingConnectivityDataResponse> GetManagedThingConnectivityDataAsync(GetManagedThingConnectivityDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedThingConnectivityDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingConnectivityDataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetManagedThingConnectivityDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetManagedThingMetaData


        /// <summary>
        /// Get the metadata information for a managed thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThingMetaData service method.</param>
        /// 
        /// <returns>The response from the GetManagedThingMetaData service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingMetaData">REST API Reference for GetManagedThingMetaData Operation</seealso>
        public virtual GetManagedThingMetaDataResponse GetManagedThingMetaData(GetManagedThingMetaDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedThingMetaDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingMetaDataResponseUnmarshaller.Instance;

            return Invoke<GetManagedThingMetaDataResponse>(request, options);
        }


        /// <summary>
        /// Get the metadata information for a managed thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThingMetaData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedThingMetaData service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingMetaData">REST API Reference for GetManagedThingMetaData Operation</seealso>
        public virtual Task<GetManagedThingMetaDataResponse> GetManagedThingMetaDataAsync(GetManagedThingMetaDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedThingMetaDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingMetaDataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetManagedThingMetaDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetManagedThingState


        /// <summary>
        /// Returns the managed thing state for the given device Id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThingState service method.</param>
        /// 
        /// <returns>The response from the GetManagedThingState service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingState">REST API Reference for GetManagedThingState Operation</seealso>
        public virtual GetManagedThingStateResponse GetManagedThingState(GetManagedThingStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedThingStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingStateResponseUnmarshaller.Instance;

            return Invoke<GetManagedThingStateResponse>(request, options);
        }


        /// <summary>
        /// Returns the managed thing state for the given device Id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThingState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedThingState service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingState">REST API Reference for GetManagedThingState Operation</seealso>
        public virtual Task<GetManagedThingStateResponse> GetManagedThingStateAsync(GetManagedThingStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedThingStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingStateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetManagedThingStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNotificationConfiguration


        /// <summary>
        /// Get a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetNotificationConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        public virtual GetNotificationConfigurationResponse GetNotificationConfiguration(GetNotificationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Get a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNotificationConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        public virtual Task<GetNotificationConfigurationResponse> GetNotificationConfigurationAsync(GetNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOtaTask


        /// <summary>
        /// Get the over-the-air (OTA) task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOtaTask service method.</param>
        /// 
        /// <returns>The response from the GetOtaTask service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetOtaTask">REST API Reference for GetOtaTask Operation</seealso>
        public virtual GetOtaTaskResponse GetOtaTask(GetOtaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOtaTaskResponseUnmarshaller.Instance;

            return Invoke<GetOtaTaskResponse>(request, options);
        }


        /// <summary>
        /// Get the over-the-air (OTA) task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOtaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOtaTask service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetOtaTask">REST API Reference for GetOtaTask Operation</seealso>
        public virtual Task<GetOtaTaskResponse> GetOtaTaskAsync(GetOtaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOtaTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOtaTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOtaTaskConfiguration


        /// <summary>
        /// Get a configuraiton for the over-the-air (OTA) task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOtaTaskConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetOtaTaskConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetOtaTaskConfiguration">REST API Reference for GetOtaTaskConfiguration Operation</seealso>
        public virtual GetOtaTaskConfigurationResponse GetOtaTaskConfiguration(GetOtaTaskConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOtaTaskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOtaTaskConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetOtaTaskConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Get a configuraiton for the over-the-air (OTA) task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOtaTaskConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOtaTaskConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetOtaTaskConfiguration">REST API Reference for GetOtaTaskConfiguration Operation</seealso>
        public virtual Task<GetOtaTaskConfigurationResponse> GetOtaTaskConfigurationAsync(GetOtaTaskConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOtaTaskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOtaTaskConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOtaTaskConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetProvisioningProfile


        /// <summary>
        /// Get a provisioning profile by template name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProvisioningProfile service method.</param>
        /// 
        /// <returns>The response from the GetProvisioningProfile service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetProvisioningProfile">REST API Reference for GetProvisioningProfile Operation</seealso>
        public virtual GetProvisioningProfileResponse GetProvisioningProfile(GetProvisioningProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProvisioningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProvisioningProfileResponseUnmarshaller.Instance;

            return Invoke<GetProvisioningProfileResponse>(request, options);
        }


        /// <summary>
        /// Get a provisioning profile by template name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProvisioningProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProvisioningProfile service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetProvisioningProfile">REST API Reference for GetProvisioningProfile Operation</seealso>
        public virtual Task<GetProvisioningProfileResponse> GetProvisioningProfileAsync(GetProvisioningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProvisioningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProvisioningProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetProvisioningProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRuntimeLogConfiguration


        /// <summary>
        /// Get the runtime log configuration for a specific managed thing or for all managed
        /// things as a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuntimeLogConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetRuntimeLogConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetRuntimeLogConfiguration">REST API Reference for GetRuntimeLogConfiguration Operation</seealso>
        public virtual GetRuntimeLogConfigurationResponse GetRuntimeLogConfiguration(GetRuntimeLogConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRuntimeLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuntimeLogConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetRuntimeLogConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Get the runtime log configuration for a specific managed thing or for all managed
        /// things as a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuntimeLogConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRuntimeLogConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetRuntimeLogConfiguration">REST API Reference for GetRuntimeLogConfiguration Operation</seealso>
        public virtual Task<GetRuntimeLogConfigurationResponse> GetRuntimeLogConfigurationAsync(GetRuntimeLogConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRuntimeLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuntimeLogConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRuntimeLogConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSchemaVersion


        /// <summary>
        /// Gets a schema version with the provided information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaVersion service method.</param>
        /// 
        /// <returns>The response from the GetSchemaVersion service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetSchemaVersion">REST API Reference for GetSchemaVersion Operation</seealso>
        public virtual GetSchemaVersionResponse GetSchemaVersion(GetSchemaVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaVersionResponseUnmarshaller.Instance;

            return Invoke<GetSchemaVersionResponse>(request, options);
        }


        /// <summary>
        /// Gets a schema version with the provided information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchemaVersion service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetSchemaVersion">REST API Reference for GetSchemaVersion Operation</seealso>
        public virtual Task<GetSchemaVersionResponse> GetSchemaVersionAsync(GetSchemaVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSchemaVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCredentialLockers


        /// <summary>
        /// List information on an existing credential locker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCredentialLockers service method.</param>
        /// 
        /// <returns>The response from the ListCredentialLockers service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListCredentialLockers">REST API Reference for ListCredentialLockers Operation</seealso>
        public virtual ListCredentialLockersResponse ListCredentialLockers(ListCredentialLockersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCredentialLockersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCredentialLockersResponseUnmarshaller.Instance;

            return Invoke<ListCredentialLockersResponse>(request, options);
        }


        /// <summary>
        /// List information on an existing credential locker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCredentialLockers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCredentialLockers service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListCredentialLockers">REST API Reference for ListCredentialLockers Operation</seealso>
        public virtual Task<ListCredentialLockersResponse> ListCredentialLockersAsync(ListCredentialLockersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCredentialLockersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCredentialLockersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCredentialLockersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDestinations


        /// <summary>
        /// List all destination names under one Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations service method.</param>
        /// 
        /// <returns>The response from the ListDestinations service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        public virtual ListDestinationsResponse ListDestinations(ListDestinationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDestinationsResponseUnmarshaller.Instance;

            return Invoke<ListDestinationsResponse>(request, options);
        }


        /// <summary>
        /// List all destination names under one Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDestinations service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        public virtual Task<ListDestinationsResponse> ListDestinationsAsync(ListDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDestinationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDestinationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEventLogConfigurations


        /// <summary>
        /// List all event log configurations for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventLogConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListEventLogConfigurations service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListEventLogConfigurations">REST API Reference for ListEventLogConfigurations Operation</seealso>
        public virtual ListEventLogConfigurationsResponse ListEventLogConfigurations(ListEventLogConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventLogConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventLogConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListEventLogConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// List all event log configurations for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventLogConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventLogConfigurations service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListEventLogConfigurations">REST API Reference for ListEventLogConfigurations Operation</seealso>
        public virtual Task<ListEventLogConfigurationsResponse> ListEventLogConfigurationsAsync(ListEventLogConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventLogConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventLogConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEventLogConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListManagedThings


        /// <summary>
        /// List all of the associations and statuses for a managed thing by its owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedThings service method.</param>
        /// 
        /// <returns>The response from the ListManagedThings service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListManagedThings">REST API Reference for ListManagedThings Operation</seealso>
        public virtual ListManagedThingsResponse ListManagedThings(ListManagedThingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedThingsResponseUnmarshaller.Instance;

            return Invoke<ListManagedThingsResponse>(request, options);
        }


        /// <summary>
        /// List all of the associations and statuses for a managed thing by its owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedThings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedThings service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListManagedThings">REST API Reference for ListManagedThings Operation</seealso>
        public virtual Task<ListManagedThingsResponse> ListManagedThingsAsync(ListManagedThingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedThingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListManagedThingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListManagedThingSchemas


        /// <summary>
        /// List schemas associated with a managed thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedThingSchemas service method.</param>
        /// 
        /// <returns>The response from the ListManagedThingSchemas service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListManagedThingSchemas">REST API Reference for ListManagedThingSchemas Operation</seealso>
        public virtual ListManagedThingSchemasResponse ListManagedThingSchemas(ListManagedThingSchemasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedThingSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedThingSchemasResponseUnmarshaller.Instance;

            return Invoke<ListManagedThingSchemasResponse>(request, options);
        }


        /// <summary>
        /// List schemas associated with a managed thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedThingSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedThingSchemas service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListManagedThingSchemas">REST API Reference for ListManagedThingSchemas Operation</seealso>
        public virtual Task<ListManagedThingSchemasResponse> ListManagedThingSchemasAsync(ListManagedThingSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedThingSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedThingSchemasResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListManagedThingSchemasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNotificationConfigurations


        /// <summary>
        /// List all notification configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListNotificationConfigurations service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListNotificationConfigurations">REST API Reference for ListNotificationConfigurations Operation</seealso>
        public virtual ListNotificationConfigurationsResponse ListNotificationConfigurations(ListNotificationConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// List all notification configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotificationConfigurations service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListNotificationConfigurations">REST API Reference for ListNotificationConfigurations Operation</seealso>
        public virtual Task<ListNotificationConfigurationsResponse> ListNotificationConfigurationsAsync(ListNotificationConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNotificationConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOtaTaskConfigurations


        /// <summary>
        /// List all of the over-the-air (OTA) task configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOtaTaskConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListOtaTaskConfigurations service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTaskConfigurations">REST API Reference for ListOtaTaskConfigurations Operation</seealso>
        public virtual ListOtaTaskConfigurationsResponse ListOtaTaskConfigurations(ListOtaTaskConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOtaTaskConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOtaTaskConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListOtaTaskConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// List all of the over-the-air (OTA) task configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOtaTaskConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOtaTaskConfigurations service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTaskConfigurations">REST API Reference for ListOtaTaskConfigurations Operation</seealso>
        public virtual Task<ListOtaTaskConfigurationsResponse> ListOtaTaskConfigurationsAsync(ListOtaTaskConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOtaTaskConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOtaTaskConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOtaTaskConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOtaTaskExecutions


        /// <summary>
        /// List all of the over-the-air (OTA) task executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOtaTaskExecutions service method.</param>
        /// 
        /// <returns>The response from the ListOtaTaskExecutions service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTaskExecutions">REST API Reference for ListOtaTaskExecutions Operation</seealso>
        public virtual ListOtaTaskExecutionsResponse ListOtaTaskExecutions(ListOtaTaskExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOtaTaskExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOtaTaskExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListOtaTaskExecutionsResponse>(request, options);
        }


        /// <summary>
        /// List all of the over-the-air (OTA) task executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOtaTaskExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOtaTaskExecutions service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTaskExecutions">REST API Reference for ListOtaTaskExecutions Operation</seealso>
        public virtual Task<ListOtaTaskExecutionsResponse> ListOtaTaskExecutionsAsync(ListOtaTaskExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOtaTaskExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOtaTaskExecutionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOtaTaskExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOtaTasks


        /// <summary>
        /// List all of the over-the-air (OTA) tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOtaTasks service method.</param>
        /// 
        /// <returns>The response from the ListOtaTasks service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTasks">REST API Reference for ListOtaTasks Operation</seealso>
        public virtual ListOtaTasksResponse ListOtaTasks(ListOtaTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOtaTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOtaTasksResponseUnmarshaller.Instance;

            return Invoke<ListOtaTasksResponse>(request, options);
        }


        /// <summary>
        /// List all of the over-the-air (OTA) tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOtaTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOtaTasks service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTasks">REST API Reference for ListOtaTasks Operation</seealso>
        public virtual Task<ListOtaTasksResponse> ListOtaTasksAsync(ListOtaTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOtaTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOtaTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOtaTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisioningProfiles


        /// <summary>
        /// List the provisioning profiles within the Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningProfiles service method.</param>
        /// 
        /// <returns>The response from the ListProvisioningProfiles service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListProvisioningProfiles">REST API Reference for ListProvisioningProfiles Operation</seealso>
        public virtual ListProvisioningProfilesResponse ListProvisioningProfiles(ListProvisioningProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningProfilesResponseUnmarshaller.Instance;

            return Invoke<ListProvisioningProfilesResponse>(request, options);
        }


        /// <summary>
        /// List the provisioning profiles within the Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProvisioningProfiles service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListProvisioningProfiles">REST API Reference for ListProvisioningProfiles Operation</seealso>
        public virtual Task<ListProvisioningProfilesResponse> ListProvisioningProfilesAsync(ListProvisioningProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningProfilesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProvisioningProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSchemaVersions


        /// <summary>
        /// Lists schema versions with the provided information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaVersions service method.</param>
        /// 
        /// <returns>The response from the ListSchemaVersions service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        public virtual ListSchemaVersionsResponse ListSchemaVersions(ListSchemaVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaVersionsResponseUnmarshaller.Instance;

            return Invoke<ListSchemaVersionsResponse>(request, options);
        }


        /// <summary>
        /// Lists schema versions with the provided information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemaVersions service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        public virtual Task<ListSchemaVersionsResponse> ListSchemaVersionsAsync(ListSchemaVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSchemaVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDefaultEncryptionConfiguration


        /// <summary>
        /// Sets the default encryption configuration for the Amazon Web Services account. For
        /// more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/key-management.html">Key
        /// management</a> in the AWS IoT SiteWise User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDefaultEncryptionConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutDefaultEncryptionConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutDefaultEncryptionConfiguration">REST API Reference for PutDefaultEncryptionConfiguration Operation</seealso>
        public virtual PutDefaultEncryptionConfigurationResponse PutDefaultEncryptionConfiguration(PutDefaultEncryptionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDefaultEncryptionConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutDefaultEncryptionConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Sets the default encryption configuration for the Amazon Web Services account. For
        /// more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/key-management.html">Key
        /// management</a> in the AWS IoT SiteWise User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDefaultEncryptionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDefaultEncryptionConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutDefaultEncryptionConfiguration">REST API Reference for PutDefaultEncryptionConfiguration Operation</seealso>
        public virtual Task<PutDefaultEncryptionConfigurationResponse> PutDefaultEncryptionConfigurationAsync(PutDefaultEncryptionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDefaultEncryptionConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutDefaultEncryptionConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutHubConfiguration


        /// <summary>
        /// Update a hub configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutHubConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutHubConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutHubConfiguration">REST API Reference for PutHubConfiguration Operation</seealso>
        public virtual PutHubConfigurationResponse PutHubConfiguration(PutHubConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutHubConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutHubConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutHubConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Update a hub configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutHubConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutHubConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutHubConfiguration">REST API Reference for PutHubConfiguration Operation</seealso>
        public virtual Task<PutHubConfigurationResponse> PutHubConfigurationAsync(PutHubConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutHubConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutHubConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutHubConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRuntimeLogConfiguration


        /// <summary>
        /// Set the runtime log configuration for a specific managed thing or for all managed
        /// things as a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRuntimeLogConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutRuntimeLogConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutRuntimeLogConfiguration">REST API Reference for PutRuntimeLogConfiguration Operation</seealso>
        public virtual PutRuntimeLogConfigurationResponse PutRuntimeLogConfiguration(PutRuntimeLogConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRuntimeLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRuntimeLogConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutRuntimeLogConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Set the runtime log configuration for a specific managed thing or for all managed
        /// things as a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRuntimeLogConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRuntimeLogConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutRuntimeLogConfiguration">REST API Reference for PutRuntimeLogConfiguration Operation</seealso>
        public virtual Task<PutRuntimeLogConfigurationResponse> PutRuntimeLogConfigurationAsync(PutRuntimeLogConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRuntimeLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRuntimeLogConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutRuntimeLogConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterCustomEndpoint


        /// <summary>
        /// Customers can request IoT managed integrations to manage the server trust for them
        /// or bring their own external server trusts for the custom domain. Returns an IoT managed
        /// integrations endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCustomEndpoint service method.</param>
        /// 
        /// <returns>The response from the RegisterCustomEndpoint service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/RegisterCustomEndpoint">REST API Reference for RegisterCustomEndpoint Operation</seealso>
        public virtual RegisterCustomEndpointResponse RegisterCustomEndpoint(RegisterCustomEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCustomEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCustomEndpointResponseUnmarshaller.Instance;

            return Invoke<RegisterCustomEndpointResponse>(request, options);
        }


        /// <summary>
        /// Customers can request IoT managed integrations to manage the server trust for them
        /// or bring their own external server trusts for the custom domain. Returns an IoT managed
        /// integrations endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCustomEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterCustomEndpoint service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/RegisterCustomEndpoint">REST API Reference for RegisterCustomEndpoint Operation</seealso>
        public virtual Task<RegisterCustomEndpointResponse> RegisterCustomEndpointAsync(RegisterCustomEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCustomEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCustomEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterCustomEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetRuntimeLogConfiguration


        /// <summary>
        /// Reset a runtime log configuration for a specific managed thing or for all managed
        /// things as a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetRuntimeLogConfiguration service method.</param>
        /// 
        /// <returns>The response from the ResetRuntimeLogConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ResetRuntimeLogConfiguration">REST API Reference for ResetRuntimeLogConfiguration Operation</seealso>
        public virtual ResetRuntimeLogConfigurationResponse ResetRuntimeLogConfiguration(ResetRuntimeLogConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetRuntimeLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetRuntimeLogConfigurationResponseUnmarshaller.Instance;

            return Invoke<ResetRuntimeLogConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Reset a runtime log configuration for a specific managed thing or for all managed
        /// things as a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetRuntimeLogConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetRuntimeLogConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ResetRuntimeLogConfiguration">REST API Reference for ResetRuntimeLogConfiguration Operation</seealso>
        public virtual Task<ResetRuntimeLogConfigurationResponse> ResetRuntimeLogConfigurationAsync(ResetRuntimeLogConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetRuntimeLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetRuntimeLogConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResetRuntimeLogConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendManagedThingCommand


        /// <summary>
        /// Send the command to the device represented by the managed thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendManagedThingCommand service method.</param>
        /// 
        /// <returns>The response from the SendManagedThingCommand service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/SendManagedThingCommand">REST API Reference for SendManagedThingCommand Operation</seealso>
        public virtual SendManagedThingCommandResponse SendManagedThingCommand(SendManagedThingCommandRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendManagedThingCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendManagedThingCommandResponseUnmarshaller.Instance;

            return Invoke<SendManagedThingCommandResponse>(request, options);
        }


        /// <summary>
        /// Send the command to the device represented by the managed thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendManagedThingCommand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendManagedThingCommand service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/SendManagedThingCommand">REST API Reference for SendManagedThingCommand Operation</seealso>
        public virtual Task<SendManagedThingCommandResponse> SendManagedThingCommandAsync(SendManagedThingCommandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendManagedThingCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendManagedThingCommandResponseUnmarshaller.Instance;
            
            return InvokeAsync<SendManagedThingCommandResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDeviceDiscovery


        /// <summary>
        /// During user-guided setup, this is used to start device discovery. The authentication
        /// material (install code) is passed as a message to the controller telling it to start
        /// the discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeviceDiscovery service method.</param>
        /// 
        /// <returns>The response from the StartDeviceDiscovery service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/StartDeviceDiscovery">REST API Reference for StartDeviceDiscovery Operation</seealso>
        public virtual StartDeviceDiscoveryResponse StartDeviceDiscovery(StartDeviceDiscoveryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDeviceDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeviceDiscoveryResponseUnmarshaller.Instance;

            return Invoke<StartDeviceDiscoveryResponse>(request, options);
        }


        /// <summary>
        /// During user-guided setup, this is used to start device discovery. The authentication
        /// material (install code) is passed as a message to the controller telling it to start
        /// the discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeviceDiscovery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDeviceDiscovery service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/StartDeviceDiscovery">REST API Reference for StartDeviceDiscovery Operation</seealso>
        public virtual Task<StartDeviceDiscoveryResponse> StartDeviceDiscoveryAsync(StartDeviceDiscoveryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDeviceDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeviceDiscoveryResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartDeviceDiscoveryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDestination


        /// <summary>
        /// Update a destination specified by id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateDestination service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual UpdateDestinationResponse UpdateDestination(UpdateDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateDestinationResponse>(request, options);
        }


        /// <summary>
        /// Update a destination specified by id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDestination service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual Task<UpdateDestinationResponse> UpdateDestinationAsync(UpdateDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEventLogConfiguration


        /// <summary>
        /// Update an event log configuration by log configuration ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventLogConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateEventLogConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateEventLogConfiguration">REST API Reference for UpdateEventLogConfiguration Operation</seealso>
        public virtual UpdateEventLogConfigurationResponse UpdateEventLogConfiguration(UpdateEventLogConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventLogConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateEventLogConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Update an event log configuration by log configuration ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventLogConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventLogConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateEventLogConfiguration">REST API Reference for UpdateEventLogConfiguration Operation</seealso>
        public virtual Task<UpdateEventLogConfigurationResponse> UpdateEventLogConfigurationAsync(UpdateEventLogConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventLogConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEventLogConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateManagedThing


        /// <summary>
        /// Update the attributes and capabilities associated with a managed thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedThing service method.</param>
        /// 
        /// <returns>The response from the UpdateManagedThing service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateManagedThing">REST API Reference for UpdateManagedThing Operation</seealso>
        public virtual UpdateManagedThingResponse UpdateManagedThing(UpdateManagedThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateManagedThingResponseUnmarshaller.Instance;

            return Invoke<UpdateManagedThingResponse>(request, options);
        }


        /// <summary>
        /// Update the attributes and capabilities associated with a managed thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateManagedThing service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateManagedThing">REST API Reference for UpdateManagedThing Operation</seealso>
        public virtual Task<UpdateManagedThingResponse> UpdateManagedThingAsync(UpdateManagedThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateManagedThingResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateManagedThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNotificationConfiguration


        /// <summary>
        /// Update a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateNotificationConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        public virtual UpdateNotificationConfigurationResponse UpdateNotificationConfiguration(UpdateNotificationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Update a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotificationConfiguration service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        public virtual Task<UpdateNotificationConfigurationResponse> UpdateNotificationConfigurationAsync(UpdateNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOtaTask


        /// <summary>
        /// Update an over-the-air (OTA) task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOtaTask service method.</param>
        /// 
        /// <returns>The response from the UpdateOtaTask service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateOtaTask">REST API Reference for UpdateOtaTask Operation</seealso>
        public virtual UpdateOtaTaskResponse UpdateOtaTask(UpdateOtaTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOtaTaskResponseUnmarshaller.Instance;

            return Invoke<UpdateOtaTaskResponse>(request, options);
        }


        /// <summary>
        /// Update an over-the-air (OTA) task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOtaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOtaTask service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.AccessDeniedException">
        /// User is not authorized.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateOtaTask">REST API Reference for UpdateOtaTask Operation</seealso>
        public virtual Task<UpdateOtaTaskResponse> UpdateOtaTaskAsync(UpdateOtaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOtaTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateOtaTaskResponse>(request, options, cancellationToken);
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
            var resolver = new AmazonIoTManagedIntegrationsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}