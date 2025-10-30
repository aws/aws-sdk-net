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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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


        #region  CreateAccountAssociation

        /// <summary>
        /// Creates a new account association via the destination id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateAccountAssociation service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateAccountAssociation">REST API Reference for CreateAccountAssociation Operation</seealso>
        public virtual CreateAccountAssociationResponse CreateAccountAssociation(CreateAccountAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccountAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateAccountAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAssociation operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccountAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateAccountAssociation">REST API Reference for CreateAccountAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateAccountAssociation(CreateAccountAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccountAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountAssociation.</param>
        /// 
        /// <returns>Returns a  CreateAccountAssociationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateAccountAssociation">REST API Reference for CreateAccountAssociation Operation</seealso>
        public virtual CreateAccountAssociationResponse EndCreateAccountAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccountAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCloudConnector

        /// <summary>
        /// Creates a C2C (cloud-to-cloud) connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudConnector service method.</param>
        /// 
        /// <returns>The response from the CreateCloudConnector service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateCloudConnector">REST API Reference for CreateCloudConnector Operation</seealso>
        public virtual CreateCloudConnectorResponse CreateCloudConnector(CreateCloudConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudConnectorResponseUnmarshaller.Instance;

            return Invoke<CreateCloudConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudConnector operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateCloudConnector">REST API Reference for CreateCloudConnector Operation</seealso>
        public virtual IAsyncResult BeginCreateCloudConnector(CreateCloudConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudConnector.</param>
        /// 
        /// <returns>Returns a  CreateCloudConnectorResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateCloudConnector">REST API Reference for CreateCloudConnector Operation</seealso>
        public virtual CreateCloudConnectorResponse EndCreateCloudConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCloudConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConnectorDestination

        /// <summary>
        /// Create a connector destination for connecting a cloud-to-cloud (C2C) connector to
        /// the customer's Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectorDestination service method.</param>
        /// 
        /// <returns>The response from the CreateConnectorDestination service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateConnectorDestination">REST API Reference for CreateConnectorDestination Operation</seealso>
        public virtual CreateConnectorDestinationResponse CreateConnectorDestination(CreateConnectorDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateConnectorDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnectorDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectorDestination operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnectorDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateConnectorDestination">REST API Reference for CreateConnectorDestination Operation</seealso>
        public virtual IAsyncResult BeginCreateConnectorDestination(CreateConnectorDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnectorDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnectorDestination.</param>
        /// 
        /// <returns>Returns a  CreateConnectorDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateConnectorDestination">REST API Reference for CreateConnectorDestination Operation</seealso>
        public virtual CreateConnectorDestinationResponse EndCreateConnectorDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConnectorDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCredentialLocker

        /// <summary>
        /// Create a credential locker.
        /// 
        ///  <note> 
        /// <para>
        /// This operation will not trigger the creation of all the manufacturing resources.
        /// </para>
        ///  </note>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCredentialLockerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCredentialLockerResponseUnmarshaller.Instance;

            return Invoke<CreateCredentialLockerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCredentialLocker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCredentialLocker operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCredentialLocker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateCredentialLocker">REST API Reference for CreateCredentialLocker Operation</seealso>
        public virtual IAsyncResult BeginCreateCredentialLocker(CreateCredentialLockerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCredentialLockerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCredentialLockerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCredentialLocker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCredentialLocker.</param>
        /// 
        /// <returns>Returns a  CreateCredentialLockerResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateCredentialLocker">REST API Reference for CreateCredentialLocker Operation</seealso>
        public virtual CreateCredentialLockerResponse EndCreateCredentialLocker(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCredentialLockerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDestination

        /// <summary>
        /// Create a notification destination such as Kinesis Data Streams that receive events
        /// and notifications from Managed integrations. Managed integrations uses the destination
        /// to determine where to deliver notifications.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        public virtual IAsyncResult BeginCreateDestination(CreateDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  CreateDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        public virtual CreateDestinationResponse EndCreateDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDestinationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventLogConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateEventLogConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventLogConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventLogConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateEventLogConfiguration">REST API Reference for CreateEventLogConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateEventLogConfiguration(CreateEventLogConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventLogConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventLogConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateEventLogConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateEventLogConfiguration">REST API Reference for CreateEventLogConfiguration Operation</seealso>
        public virtual CreateEventLogConfigurationResponse EndCreateEventLogConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventLogConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateManagedThing

        /// <summary>
        /// Creates a managed thing. A managed thing contains the device identifier, protocol
        /// supported, and capabilities of the device in a data model format defined by Managed
        /// integrations.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateManagedThingResponseUnmarshaller.Instance;

            return Invoke<CreateManagedThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateManagedThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateManagedThing operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateManagedThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateManagedThing">REST API Reference for CreateManagedThing Operation</seealso>
        public virtual IAsyncResult BeginCreateManagedThing(CreateManagedThingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateManagedThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateManagedThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateManagedThing.</param>
        /// 
        /// <returns>Returns a  CreateManagedThingResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateManagedThing">REST API Reference for CreateManagedThing Operation</seealso>
        public virtual CreateManagedThingResponse EndCreateManagedThing(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateManagedThingResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateNotificationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateNotificationConfiguration">REST API Reference for CreateNotificationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateNotificationConfiguration(CreateNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateNotificationConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateNotificationConfiguration">REST API Reference for CreateNotificationConfiguration Operation</seealso>
        public virtual CreateNotificationConfigurationResponse EndCreateNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNotificationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateOtaTask

        /// <summary>
        /// Create an over-the-air (OTA) task to target a device.
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
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateOtaTask">REST API Reference for CreateOtaTask Operation</seealso>
        public virtual CreateOtaTaskResponse CreateOtaTask(CreateOtaTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOtaTaskResponseUnmarshaller.Instance;

            return Invoke<CreateOtaTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOtaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOtaTask operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOtaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateOtaTask">REST API Reference for CreateOtaTask Operation</seealso>
        public virtual IAsyncResult BeginCreateOtaTask(CreateOtaTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOtaTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOtaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOtaTask.</param>
        /// 
        /// <returns>Returns a  CreateOtaTaskResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateOtaTask">REST API Reference for CreateOtaTask Operation</seealso>
        public virtual CreateOtaTaskResponse EndCreateOtaTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOtaTaskResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOtaTaskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOtaTaskConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateOtaTaskConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOtaTaskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOtaTaskConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOtaTaskConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateOtaTaskConfiguration">REST API Reference for CreateOtaTaskConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateOtaTaskConfiguration(CreateOtaTaskConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOtaTaskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOtaTaskConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOtaTaskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOtaTaskConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateOtaTaskConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateOtaTaskConfiguration">REST API Reference for CreateOtaTaskConfiguration Operation</seealso>
        public virtual CreateOtaTaskConfigurationResponse EndCreateOtaTaskConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOtaTaskConfigurationResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateProvisioningProfile">REST API Reference for CreateProvisioningProfile Operation</seealso>
        public virtual CreateProvisioningProfileResponse CreateProvisioningProfile(CreateProvisioningProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProvisioningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningProfileResponseUnmarshaller.Instance;

            return Invoke<CreateProvisioningProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProvisioningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningProfile operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProvisioningProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateProvisioningProfile">REST API Reference for CreateProvisioningProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateProvisioningProfile(CreateProvisioningProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProvisioningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProvisioningProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProvisioningProfile.</param>
        /// 
        /// <returns>Returns a  CreateProvisioningProfileResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateProvisioningProfile">REST API Reference for CreateProvisioningProfile Operation</seealso>
        public virtual CreateProvisioningProfileResponse EndCreateProvisioningProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProvisioningProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccountAssociation

        /// <summary>
        /// Remove a third-party account association for an end user.
        /// 
        ///  <note> 
        /// <para>
        /// You must first call the <c>DeregisterAccountAssociation</c> to remove the connection
        /// between the managed thing and the third-party account before calling the <c>DeleteAccountAssociation</c>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountAssociation service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteAccountAssociation">REST API Reference for DeleteAccountAssociation Operation</seealso>
        public virtual DeleteAccountAssociationResponse DeleteAccountAssociation(DeleteAccountAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccountAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAssociation operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccountAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteAccountAssociation">REST API Reference for DeleteAccountAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccountAssociation(DeleteAccountAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccountAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteAccountAssociationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteAccountAssociation">REST API Reference for DeleteAccountAssociation Operation</seealso>
        public virtual DeleteAccountAssociationResponse EndDeleteAccountAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccountAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCloudConnector

        /// <summary>
        /// Delete a cloud connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteCloudConnector service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteCloudConnector">REST API Reference for DeleteCloudConnector Operation</seealso>
        public virtual DeleteCloudConnectorResponse DeleteCloudConnector(DeleteCloudConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudConnectorResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudConnector operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCloudConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteCloudConnector">REST API Reference for DeleteCloudConnector Operation</seealso>
        public virtual IAsyncResult BeginDeleteCloudConnector(DeleteCloudConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCloudConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudConnector.</param>
        /// 
        /// <returns>Returns a  DeleteCloudConnectorResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteCloudConnector">REST API Reference for DeleteCloudConnector Operation</seealso>
        public virtual DeleteCloudConnectorResponse EndDeleteCloudConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCloudConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConnectorDestination

        /// <summary>
        /// Delete a connector destination linked to a cloud-to-cloud (C2C) connector.
        /// 
        ///  <note> 
        /// <para>
        /// Deletion can't be done if the account association has used this connector destination.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectorDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteConnectorDestination service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteConnectorDestination">REST API Reference for DeleteConnectorDestination Operation</seealso>
        public virtual DeleteConnectorDestinationResponse DeleteConnectorDestination(DeleteConnectorDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectorDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectorDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnectorDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectorDestination operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnectorDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteConnectorDestination">REST API Reference for DeleteConnectorDestination Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnectorDestination(DeleteConnectorDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectorDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectorDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectorDestination.</param>
        /// 
        /// <returns>Returns a  DeleteConnectorDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteConnectorDestination">REST API Reference for DeleteConnectorDestination Operation</seealso>
        public virtual DeleteConnectorDestinationResponse EndDeleteConnectorDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectorDestinationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCredentialLockerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCredentialLockerResponseUnmarshaller.Instance;

            return Invoke<DeleteCredentialLockerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCredentialLocker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCredentialLocker operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCredentialLocker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteCredentialLocker">REST API Reference for DeleteCredentialLocker Operation</seealso>
        public virtual IAsyncResult BeginDeleteCredentialLocker(DeleteCredentialLockerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCredentialLockerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCredentialLockerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCredentialLocker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCredentialLocker.</param>
        /// 
        /// <returns>Returns a  DeleteCredentialLockerResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteCredentialLocker">REST API Reference for DeleteCredentialLocker Operation</seealso>
        public virtual DeleteCredentialLockerResponse EndDeleteCredentialLocker(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCredentialLockerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDestination

        /// <summary>
        /// Deletes a notification destination specified by name.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual IAsyncResult BeginDeleteDestination(DeleteDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  DeleteDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual DeleteDestinationResponse EndDeleteDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDestinationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventLogConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteEventLogConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventLogConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventLogConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteEventLogConfiguration">REST API Reference for DeleteEventLogConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventLogConfiguration(DeleteEventLogConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventLogConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventLogConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteEventLogConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteEventLogConfiguration">REST API Reference for DeleteEventLogConfiguration Operation</seealso>
        public virtual DeleteEventLogConfigurationResponse EndDeleteEventLogConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventLogConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteManagedThing

        /// <summary>
        /// Delete a managed thing. For direct-connected and hub-connected devices connecting
        /// with Managed integrations via a controller, all of the devices connected to it will
        /// have their status changed to <c>PENDING</c>. It is not possible to remove a cloud-to-cloud
        /// device.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteManagedThingResponseUnmarshaller.Instance;

            return Invoke<DeleteManagedThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteManagedThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteManagedThing operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteManagedThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteManagedThing">REST API Reference for DeleteManagedThing Operation</seealso>
        public virtual IAsyncResult BeginDeleteManagedThing(DeleteManagedThingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteManagedThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteManagedThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteManagedThing.</param>
        /// 
        /// <returns>Returns a  DeleteManagedThingResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteManagedThing">REST API Reference for DeleteManagedThing Operation</seealso>
        public virtual DeleteManagedThingResponse EndDeleteManagedThing(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteManagedThingResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        public virtual DeleteNotificationConfigurationResponse EndDeleteNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNotificationConfigurationResponse>(asyncResult);
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
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.LimitExceededException">
        /// The request exceeds a service limit or quota. Adjust your request parameters and try
        /// again.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOtaTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteOtaTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOtaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOtaTask operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOtaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteOtaTask">REST API Reference for DeleteOtaTask Operation</seealso>
        public virtual IAsyncResult BeginDeleteOtaTask(DeleteOtaTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOtaTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOtaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOtaTask.</param>
        /// 
        /// <returns>Returns a  DeleteOtaTaskResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteOtaTask">REST API Reference for DeleteOtaTask Operation</seealso>
        public virtual DeleteOtaTaskResponse EndDeleteOtaTask(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOtaTaskResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOtaTaskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOtaTaskConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteOtaTaskConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOtaTaskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOtaTaskConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOtaTaskConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteOtaTaskConfiguration">REST API Reference for DeleteOtaTaskConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteOtaTaskConfiguration(DeleteOtaTaskConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOtaTaskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOtaTaskConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOtaTaskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOtaTaskConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteOtaTaskConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteOtaTaskConfiguration">REST API Reference for DeleteOtaTaskConfiguration Operation</seealso>
        public virtual DeleteOtaTaskConfigurationResponse EndDeleteOtaTaskConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOtaTaskConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProvisioningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisioningProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisioningProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProvisioningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningProfile operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProvisioningProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteProvisioningProfile">REST API Reference for DeleteProvisioningProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteProvisioningProfile(DeleteProvisioningProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProvisioningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisioningProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProvisioningProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProvisioningProfile.</param>
        /// 
        /// <returns>Returns a  DeleteProvisioningProfileResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteProvisioningProfile">REST API Reference for DeleteProvisioningProfile Operation</seealso>
        public virtual DeleteProvisioningProfileResponse EndDeleteProvisioningProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProvisioningProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterAccountAssociation

        /// <summary>
        /// Deregister an account association from a managed thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAccountAssociation service method.</param>
        /// 
        /// <returns>The response from the DeregisterAccountAssociation service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeregisterAccountAssociation">REST API Reference for DeregisterAccountAssociation Operation</seealso>
        public virtual DeregisterAccountAssociationResponse DeregisterAccountAssociation(DeregisterAccountAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterAccountAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterAccountAssociationResponseUnmarshaller.Instance;

            return Invoke<DeregisterAccountAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAccountAssociation operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterAccountAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeregisterAccountAssociation">REST API Reference for DeregisterAccountAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeregisterAccountAssociation(DeregisterAccountAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterAccountAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterAccountAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterAccountAssociation.</param>
        /// 
        /// <returns>Returns a  DeregisterAccountAssociationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeregisterAccountAssociation">REST API Reference for DeregisterAccountAssociation Operation</seealso>
        public virtual DeregisterAccountAssociationResponse EndDeregisterAccountAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterAccountAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccountAssociation

        /// <summary>
        /// Get an account association for an Amazon Web Services account linked to a customer-managed
        /// destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountAssociation service method.</param>
        /// 
        /// <returns>The response from the GetAccountAssociation service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetAccountAssociation">REST API Reference for GetAccountAssociation Operation</seealso>
        public virtual GetAccountAssociationResponse GetAccountAssociation(GetAccountAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountAssociationResponseUnmarshaller.Instance;

            return Invoke<GetAccountAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountAssociation operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetAccountAssociation">REST API Reference for GetAccountAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetAccountAssociation(GetAccountAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountAssociation.</param>
        /// 
        /// <returns>Returns a  GetAccountAssociationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetAccountAssociation">REST API Reference for GetAccountAssociation Operation</seealso>
        public virtual GetAccountAssociationResponse EndGetAccountAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCloudConnector

        /// <summary>
        /// Get configuration details for a cloud connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudConnector service method.</param>
        /// 
        /// <returns>The response from the GetCloudConnector service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetCloudConnector">REST API Reference for GetCloudConnector Operation</seealso>
        public virtual GetCloudConnectorResponse GetCloudConnector(GetCloudConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudConnectorResponseUnmarshaller.Instance;

            return Invoke<GetCloudConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudConnector operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetCloudConnector">REST API Reference for GetCloudConnector Operation</seealso>
        public virtual IAsyncResult BeginGetCloudConnector(GetCloudConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudConnector.</param>
        /// 
        /// <returns>Returns a  GetCloudConnectorResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetCloudConnector">REST API Reference for GetCloudConnector Operation</seealso>
        public virtual GetCloudConnectorResponse EndGetCloudConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCloudConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnectorDestination

        /// <summary>
        /// Get connector destination details linked to a cloud-to-cloud (C2C) connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectorDestination service method.</param>
        /// 
        /// <returns>The response from the GetConnectorDestination service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetConnectorDestination">REST API Reference for GetConnectorDestination Operation</seealso>
        public virtual GetConnectorDestinationResponse GetConnectorDestination(GetConnectorDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectorDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorDestinationResponseUnmarshaller.Instance;

            return Invoke<GetConnectorDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectorDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectorDestination operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectorDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetConnectorDestination">REST API Reference for GetConnectorDestination Operation</seealso>
        public virtual IAsyncResult BeginGetConnectorDestination(GetConnectorDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectorDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectorDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectorDestination.</param>
        /// 
        /// <returns>Returns a  GetConnectorDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetConnectorDestination">REST API Reference for GetConnectorDestination Operation</seealso>
        public virtual GetConnectorDestinationResponse EndGetConnectorDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectorDestinationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCredentialLockerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialLockerResponseUnmarshaller.Instance;

            return Invoke<GetCredentialLockerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCredentialLocker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialLocker operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCredentialLocker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetCredentialLocker">REST API Reference for GetCredentialLocker Operation</seealso>
        public virtual IAsyncResult BeginGetCredentialLocker(GetCredentialLockerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCredentialLockerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialLockerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCredentialLocker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCredentialLocker.</param>
        /// 
        /// <returns>Returns a  GetCredentialLockerResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetCredentialLocker">REST API Reference for GetCredentialLocker Operation</seealso>
        public virtual GetCredentialLockerResponse EndGetCredentialLocker(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCredentialLockerResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCustomEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomEndpointResponseUnmarshaller.Instance;

            return Invoke<GetCustomEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCustomEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCustomEndpoint operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCustomEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetCustomEndpoint">REST API Reference for GetCustomEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetCustomEndpoint(GetCustomEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCustomEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCustomEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCustomEndpoint.</param>
        /// 
        /// <returns>Returns a  GetCustomEndpointResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetCustomEndpoint">REST API Reference for GetCustomEndpoint Operation</seealso>
        public virtual GetCustomEndpointResponse EndGetCustomEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCustomEndpointResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDefaultEncryptionConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetDefaultEncryptionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDefaultEncryptionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultEncryptionConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDefaultEncryptionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDefaultEncryptionConfiguration">REST API Reference for GetDefaultEncryptionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetDefaultEncryptionConfiguration(GetDefaultEncryptionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDefaultEncryptionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDefaultEncryptionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDefaultEncryptionConfiguration.</param>
        /// 
        /// <returns>Returns a  GetDefaultEncryptionConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDefaultEncryptionConfiguration">REST API Reference for GetDefaultEncryptionConfiguration Operation</seealso>
        public virtual GetDefaultEncryptionConfigurationResponse EndGetDefaultEncryptionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDefaultEncryptionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDestination

        /// <summary>
        /// Gets a destination by name.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDestinationResponseUnmarshaller.Instance;

            return Invoke<GetDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDestination operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDestination">REST API Reference for GetDestination Operation</seealso>
        public virtual IAsyncResult BeginGetDestination(GetDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  GetDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDestination">REST API Reference for GetDestination Operation</seealso>
        public virtual GetDestinationResponse EndGetDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDestinationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeviceDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceDiscoveryResponseUnmarshaller.Instance;

            return Invoke<GetDeviceDiscoveryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceDiscovery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDiscovery operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeviceDiscovery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDeviceDiscovery">REST API Reference for GetDeviceDiscovery Operation</seealso>
        public virtual IAsyncResult BeginGetDeviceDiscovery(GetDeviceDiscoveryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeviceDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceDiscoveryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeviceDiscovery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeviceDiscovery.</param>
        /// 
        /// <returns>Returns a  GetDeviceDiscoveryResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDeviceDiscovery">REST API Reference for GetDeviceDiscovery Operation</seealso>
        public virtual GetDeviceDiscoveryResponse EndGetDeviceDiscovery(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeviceDiscoveryResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventLogConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetEventLogConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventLogConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventLogConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetEventLogConfiguration">REST API Reference for GetEventLogConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetEventLogConfiguration(GetEventLogConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventLogConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventLogConfiguration.</param>
        /// 
        /// <returns>Returns a  GetEventLogConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetEventLogConfiguration">REST API Reference for GetEventLogConfiguration Operation</seealso>
        public virtual GetEventLogConfigurationResponse EndGetEventLogConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventLogConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHubConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHubConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetHubConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHubConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHubConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHubConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetHubConfiguration">REST API Reference for GetHubConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetHubConfiguration(GetHubConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHubConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHubConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetHubConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHubConfiguration.</param>
        /// 
        /// <returns>Returns a  GetHubConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetHubConfiguration">REST API Reference for GetHubConfiguration Operation</seealso>
        public virtual GetHubConfigurationResponse EndGetHubConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetHubConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetManagedThing

        /// <summary>
        /// Get details of a managed thing including its attributes and capabilities.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingResponseUnmarshaller.Instance;

            return Invoke<GetManagedThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThing operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThing">REST API Reference for GetManagedThing Operation</seealso>
        public virtual IAsyncResult BeginGetManagedThing(GetManagedThingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedThing.</param>
        /// 
        /// <returns>Returns a  GetManagedThingResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThing">REST API Reference for GetManagedThing Operation</seealso>
        public virtual GetManagedThingResponse EndGetManagedThing(IAsyncResult asyncResult)
        {
            return EndInvoke<GetManagedThingResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedThingCapabilitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingCapabilitiesResponseUnmarshaller.Instance;

            return Invoke<GetManagedThingCapabilitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedThingCapabilities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThingCapabilities operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedThingCapabilities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingCapabilities">REST API Reference for GetManagedThingCapabilities Operation</seealso>
        public virtual IAsyncResult BeginGetManagedThingCapabilities(GetManagedThingCapabilitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedThingCapabilitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingCapabilitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedThingCapabilities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedThingCapabilities.</param>
        /// 
        /// <returns>Returns a  GetManagedThingCapabilitiesResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingCapabilities">REST API Reference for GetManagedThingCapabilities Operation</seealso>
        public virtual GetManagedThingCapabilitiesResponse EndGetManagedThingCapabilities(IAsyncResult asyncResult)
        {
            return EndInvoke<GetManagedThingCapabilitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetManagedThingCertificate

        /// <summary>
        /// Retrieves the certificate PEM for a managed IoT thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThingCertificate service method.</param>
        /// 
        /// <returns>The response from the GetManagedThingCertificate service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingCertificate">REST API Reference for GetManagedThingCertificate Operation</seealso>
        public virtual GetManagedThingCertificateResponse GetManagedThingCertificate(GetManagedThingCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedThingCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingCertificateResponseUnmarshaller.Instance;

            return Invoke<GetManagedThingCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedThingCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThingCertificate operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedThingCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingCertificate">REST API Reference for GetManagedThingCertificate Operation</seealso>
        public virtual IAsyncResult BeginGetManagedThingCertificate(GetManagedThingCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedThingCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedThingCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedThingCertificate.</param>
        /// 
        /// <returns>Returns a  GetManagedThingCertificateResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingCertificate">REST API Reference for GetManagedThingCertificate Operation</seealso>
        public virtual GetManagedThingCertificateResponse EndGetManagedThingCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetManagedThingCertificateResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedThingConnectivityDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingConnectivityDataResponseUnmarshaller.Instance;

            return Invoke<GetManagedThingConnectivityDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedThingConnectivityData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThingConnectivityData operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedThingConnectivityData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingConnectivityData">REST API Reference for GetManagedThingConnectivityData Operation</seealso>
        public virtual IAsyncResult BeginGetManagedThingConnectivityData(GetManagedThingConnectivityDataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedThingConnectivityDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingConnectivityDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedThingConnectivityData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedThingConnectivityData.</param>
        /// 
        /// <returns>Returns a  GetManagedThingConnectivityDataResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingConnectivityData">REST API Reference for GetManagedThingConnectivityData Operation</seealso>
        public virtual GetManagedThingConnectivityDataResponse EndGetManagedThingConnectivityData(IAsyncResult asyncResult)
        {
            return EndInvoke<GetManagedThingConnectivityDataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetManagedThingMetaData

        /// <summary>
        /// Get the metadata information for a managed thing.
        /// 
        ///  <note> 
        /// <para>
        /// The <c>managedThing</c> <c>metadata</c> parameter is used for associating attributes
        /// with a <c>managedThing</c> that can be used for grouping over-the-air (OTA) tasks.
        /// Name value pairs in <c>metadata</c> can be used in the <c>OtaTargetQueryString</c>
        /// parameter for the <c>CreateOtaTask</c> API operation.
        /// </para>
        ///  </note>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedThingMetaDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingMetaDataResponseUnmarshaller.Instance;

            return Invoke<GetManagedThingMetaDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedThingMetaData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThingMetaData operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedThingMetaData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingMetaData">REST API Reference for GetManagedThingMetaData Operation</seealso>
        public virtual IAsyncResult BeginGetManagedThingMetaData(GetManagedThingMetaDataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedThingMetaDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingMetaDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedThingMetaData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedThingMetaData.</param>
        /// 
        /// <returns>Returns a  GetManagedThingMetaDataResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingMetaData">REST API Reference for GetManagedThingMetaData Operation</seealso>
        public virtual GetManagedThingMetaDataResponse EndGetManagedThingMetaData(IAsyncResult asyncResult)
        {
            return EndInvoke<GetManagedThingMetaDataResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedThingStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingStateResponseUnmarshaller.Instance;

            return Invoke<GetManagedThingStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedThingState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedThingState operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedThingState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingState">REST API Reference for GetManagedThingState Operation</seealso>
        public virtual IAsyncResult BeginGetManagedThingState(GetManagedThingStateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedThingStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedThingStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedThingState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedThingState.</param>
        /// 
        /// <returns>Returns a  GetManagedThingStateResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingState">REST API Reference for GetManagedThingState Operation</seealso>
        public virtual GetManagedThingStateResponse EndGetManagedThingState(IAsyncResult asyncResult)
        {
            return EndInvoke<GetManagedThingStateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNotificationConfiguration

        /// <summary>
        /// Get a notification configuration for a specified event type.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetNotificationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetNotificationConfiguration(GetNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  GetNotificationConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        public virtual GetNotificationConfigurationResponse EndGetNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNotificationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOtaTask

        /// <summary>
        /// Get details of the over-the-air (OTA) task by its task id.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOtaTaskResponseUnmarshaller.Instance;

            return Invoke<GetOtaTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOtaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOtaTask operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOtaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetOtaTask">REST API Reference for GetOtaTask Operation</seealso>
        public virtual IAsyncResult BeginGetOtaTask(GetOtaTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOtaTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOtaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOtaTask.</param>
        /// 
        /// <returns>Returns a  GetOtaTaskResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetOtaTask">REST API Reference for GetOtaTask Operation</seealso>
        public virtual GetOtaTaskResponse EndGetOtaTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOtaTaskResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOtaTaskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOtaTaskConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetOtaTaskConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOtaTaskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOtaTaskConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOtaTaskConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetOtaTaskConfiguration">REST API Reference for GetOtaTaskConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetOtaTaskConfiguration(GetOtaTaskConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOtaTaskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOtaTaskConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOtaTaskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOtaTaskConfiguration.</param>
        /// 
        /// <returns>Returns a  GetOtaTaskConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetOtaTaskConfiguration">REST API Reference for GetOtaTaskConfiguration Operation</seealso>
        public virtual GetOtaTaskConfigurationResponse EndGetOtaTaskConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOtaTaskConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProvisioningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProvisioningProfileResponseUnmarshaller.Instance;

            return Invoke<GetProvisioningProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProvisioningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProvisioningProfile operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProvisioningProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetProvisioningProfile">REST API Reference for GetProvisioningProfile Operation</seealso>
        public virtual IAsyncResult BeginGetProvisioningProfile(GetProvisioningProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProvisioningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProvisioningProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProvisioningProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProvisioningProfile.</param>
        /// 
        /// <returns>Returns a  GetProvisioningProfileResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetProvisioningProfile">REST API Reference for GetProvisioningProfile Operation</seealso>
        public virtual GetProvisioningProfileResponse EndGetProvisioningProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProvisioningProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRuntimeLogConfiguration

        /// <summary>
        /// Get the runtime log configuration for a specific managed thing.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuntimeLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuntimeLogConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetRuntimeLogConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRuntimeLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRuntimeLogConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRuntimeLogConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetRuntimeLogConfiguration">REST API Reference for GetRuntimeLogConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetRuntimeLogConfiguration(GetRuntimeLogConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuntimeLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuntimeLogConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRuntimeLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRuntimeLogConfiguration.</param>
        /// 
        /// <returns>Returns a  GetRuntimeLogConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetRuntimeLogConfiguration">REST API Reference for GetRuntimeLogConfiguration Operation</seealso>
        public virtual GetRuntimeLogConfigurationResponse EndGetRuntimeLogConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRuntimeLogConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaVersionResponseUnmarshaller.Instance;

            return Invoke<GetSchemaVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaVersion operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchemaVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetSchemaVersion">REST API Reference for GetSchemaVersion Operation</seealso>
        public virtual IAsyncResult BeginGetSchemaVersion(GetSchemaVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchemaVersion.</param>
        /// 
        /// <returns>Returns a  GetSchemaVersionResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetSchemaVersion">REST API Reference for GetSchemaVersion Operation</seealso>
        public virtual GetSchemaVersionResponse EndGetSchemaVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSchemaVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccountAssociations

        /// <summary>
        /// Lists all account associations, with optional filtering by connector destination ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssociations service method.</param>
        /// 
        /// <returns>The response from the ListAccountAssociations service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListAccountAssociations">REST API Reference for ListAccountAssociations Operation</seealso>
        public virtual ListAccountAssociationsResponse ListAccountAssociations(ListAccountAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListAccountAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssociations operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListAccountAssociations">REST API Reference for ListAccountAssociations Operation</seealso>
        public virtual IAsyncResult BeginListAccountAssociations(ListAccountAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAssociations.</param>
        /// 
        /// <returns>Returns a  ListAccountAssociationsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListAccountAssociations">REST API Reference for ListAccountAssociations Operation</seealso>
        public virtual ListAccountAssociationsResponse EndListAccountAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccountAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCloudConnectors

        /// <summary>
        /// Returns a list of connectors filtered by its Lambda Amazon Resource Name (ARN) and
        /// <c>type</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudConnectors service method.</param>
        /// 
        /// <returns>The response from the ListCloudConnectors service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListCloudConnectors">REST API Reference for ListCloudConnectors Operation</seealso>
        public virtual ListCloudConnectorsResponse ListCloudConnectors(ListCloudConnectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudConnectorsResponseUnmarshaller.Instance;

            return Invoke<ListCloudConnectorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudConnectors operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCloudConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListCloudConnectors">REST API Reference for ListCloudConnectors Operation</seealso>
        public virtual IAsyncResult BeginListCloudConnectors(ListCloudConnectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudConnectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCloudConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudConnectors.</param>
        /// 
        /// <returns>Returns a  ListCloudConnectorsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListCloudConnectors">REST API Reference for ListCloudConnectors Operation</seealso>
        public virtual ListCloudConnectorsResponse EndListCloudConnectors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCloudConnectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConnectorDestinations

        /// <summary>
        /// Lists all connector destinations, with optional filtering by cloud connector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectorDestinations service method.</param>
        /// 
        /// <returns>The response from the ListConnectorDestinations service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListConnectorDestinations">REST API Reference for ListConnectorDestinations Operation</seealso>
        public virtual ListConnectorDestinationsResponse ListConnectorDestinations(ListConnectorDestinationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorDestinationsResponseUnmarshaller.Instance;

            return Invoke<ListConnectorDestinationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnectorDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnectorDestinations operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectorDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListConnectorDestinations">REST API Reference for ListConnectorDestinations Operation</seealso>
        public virtual IAsyncResult BeginListConnectorDestinations(ListConnectorDestinationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorDestinationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectorDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectorDestinations.</param>
        /// 
        /// <returns>Returns a  ListConnectorDestinationsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListConnectorDestinations">REST API Reference for ListConnectorDestinations Operation</seealso>
        public virtual ListConnectorDestinationsResponse EndListConnectorDestinations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConnectorDestinationsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCredentialLockersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCredentialLockersResponseUnmarshaller.Instance;

            return Invoke<ListCredentialLockersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCredentialLockers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCredentialLockers operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCredentialLockers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListCredentialLockers">REST API Reference for ListCredentialLockers Operation</seealso>
        public virtual IAsyncResult BeginListCredentialLockers(ListCredentialLockersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCredentialLockersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCredentialLockersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCredentialLockers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCredentialLockers.</param>
        /// 
        /// <returns>Returns a  ListCredentialLockersResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListCredentialLockers">REST API Reference for ListCredentialLockers Operation</seealso>
        public virtual ListCredentialLockersResponse EndListCredentialLockers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCredentialLockersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDestinations

        /// <summary>
        /// List all notification destinations.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDestinationsResponseUnmarshaller.Instance;

            return Invoke<ListDestinationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        public virtual IAsyncResult BeginListDestinations(ListDestinationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListDestinationsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        public virtual ListDestinationsResponse EndListDestinations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDestinationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDeviceDiscoveries

        /// <summary>
        /// Lists all device discovery tasks, with optional filtering by type and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceDiscoveries service method.</param>
        /// 
        /// <returns>The response from the ListDeviceDiscoveries service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListDeviceDiscoveries">REST API Reference for ListDeviceDiscoveries Operation</seealso>
        public virtual ListDeviceDiscoveriesResponse ListDeviceDiscoveries(ListDeviceDiscoveriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeviceDiscoveriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceDiscoveriesResponseUnmarshaller.Instance;

            return Invoke<ListDeviceDiscoveriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceDiscoveries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceDiscoveries operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeviceDiscoveries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListDeviceDiscoveries">REST API Reference for ListDeviceDiscoveries Operation</seealso>
        public virtual IAsyncResult BeginListDeviceDiscoveries(ListDeviceDiscoveriesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeviceDiscoveriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceDiscoveriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeviceDiscoveries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeviceDiscoveries.</param>
        /// 
        /// <returns>Returns a  ListDeviceDiscoveriesResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListDeviceDiscoveries">REST API Reference for ListDeviceDiscoveries Operation</seealso>
        public virtual ListDeviceDiscoveriesResponse EndListDeviceDiscoveries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeviceDiscoveriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDiscoveredDevices

        /// <summary>
        /// Lists all devices discovered during a specific device discovery task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredDevices service method.</param>
        /// 
        /// <returns>The response from the ListDiscoveredDevices service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListDiscoveredDevices">REST API Reference for ListDiscoveredDevices Operation</seealso>
        public virtual ListDiscoveredDevicesResponse ListDiscoveredDevices(ListDiscoveredDevicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoveredDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveredDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDiscoveredDevicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDiscoveredDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredDevices operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDiscoveredDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListDiscoveredDevices">REST API Reference for ListDiscoveredDevices Operation</seealso>
        public virtual IAsyncResult BeginListDiscoveredDevices(ListDiscoveredDevicesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoveredDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveredDevicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDiscoveredDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDiscoveredDevices.</param>
        /// 
        /// <returns>Returns a  ListDiscoveredDevicesResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListDiscoveredDevices">REST API Reference for ListDiscoveredDevices Operation</seealso>
        public virtual ListDiscoveredDevicesResponse EndListDiscoveredDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDiscoveredDevicesResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventLogConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventLogConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListEventLogConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventLogConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventLogConfigurations operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventLogConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListEventLogConfigurations">REST API Reference for ListEventLogConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListEventLogConfigurations(ListEventLogConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventLogConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventLogConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventLogConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventLogConfigurations.</param>
        /// 
        /// <returns>Returns a  ListEventLogConfigurationsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListEventLogConfigurations">REST API Reference for ListEventLogConfigurations Operation</seealso>
        public virtual ListEventLogConfigurationsResponse EndListEventLogConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventLogConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListManagedThingAccountAssociations

        /// <summary>
        /// Lists all account associations for a specific managed thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedThingAccountAssociations service method.</param>
        /// 
        /// <returns>The response from the ListManagedThingAccountAssociations service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListManagedThingAccountAssociations">REST API Reference for ListManagedThingAccountAssociations Operation</seealso>
        public virtual ListManagedThingAccountAssociationsResponse ListManagedThingAccountAssociations(ListManagedThingAccountAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedThingAccountAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedThingAccountAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListManagedThingAccountAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedThingAccountAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedThingAccountAssociations operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedThingAccountAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListManagedThingAccountAssociations">REST API Reference for ListManagedThingAccountAssociations Operation</seealso>
        public virtual IAsyncResult BeginListManagedThingAccountAssociations(ListManagedThingAccountAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedThingAccountAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedThingAccountAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedThingAccountAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedThingAccountAssociations.</param>
        /// 
        /// <returns>Returns a  ListManagedThingAccountAssociationsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListManagedThingAccountAssociations">REST API Reference for ListManagedThingAccountAssociations Operation</seealso>
        public virtual ListManagedThingAccountAssociationsResponse EndListManagedThingAccountAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListManagedThingAccountAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListManagedThings

        /// <summary>
        /// Listing all managed things with provision for filters.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedThingsResponseUnmarshaller.Instance;

            return Invoke<ListManagedThingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedThings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedThings operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedThings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListManagedThings">REST API Reference for ListManagedThings Operation</seealso>
        public virtual IAsyncResult BeginListManagedThings(ListManagedThingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedThingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedThings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedThings.</param>
        /// 
        /// <returns>Returns a  ListManagedThingsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListManagedThings">REST API Reference for ListManagedThings Operation</seealso>
        public virtual ListManagedThingsResponse EndListManagedThings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListManagedThingsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedThingSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedThingSchemasResponseUnmarshaller.Instance;

            return Invoke<ListManagedThingSchemasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedThingSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedThingSchemas operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedThingSchemas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListManagedThingSchemas">REST API Reference for ListManagedThingSchemas Operation</seealso>
        public virtual IAsyncResult BeginListManagedThingSchemas(ListManagedThingSchemasRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedThingSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedThingSchemasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedThingSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedThingSchemas.</param>
        /// 
        /// <returns>Returns a  ListManagedThingSchemasResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListManagedThingSchemas">REST API Reference for ListManagedThingSchemas Operation</seealso>
        public virtual ListManagedThingSchemasResponse EndListManagedThingSchemas(IAsyncResult asyncResult)
        {
            return EndInvoke<ListManagedThingSchemasResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotificationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationConfigurations operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotificationConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListNotificationConfigurations">REST API Reference for ListNotificationConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListNotificationConfigurations(ListNotificationConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotificationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotificationConfigurations.</param>
        /// 
        /// <returns>Returns a  ListNotificationConfigurationsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListNotificationConfigurations">REST API Reference for ListNotificationConfigurations Operation</seealso>
        public virtual ListNotificationConfigurationsResponse EndListNotificationConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNotificationConfigurationsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOtaTaskConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOtaTaskConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListOtaTaskConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOtaTaskConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOtaTaskConfigurations operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOtaTaskConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTaskConfigurations">REST API Reference for ListOtaTaskConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListOtaTaskConfigurations(ListOtaTaskConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOtaTaskConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOtaTaskConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOtaTaskConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOtaTaskConfigurations.</param>
        /// 
        /// <returns>Returns a  ListOtaTaskConfigurationsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTaskConfigurations">REST API Reference for ListOtaTaskConfigurations Operation</seealso>
        public virtual ListOtaTaskConfigurationsResponse EndListOtaTaskConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOtaTaskConfigurationsResponse>(asyncResult);
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
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOtaTaskExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOtaTaskExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListOtaTaskExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOtaTaskExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOtaTaskExecutions operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOtaTaskExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTaskExecutions">REST API Reference for ListOtaTaskExecutions Operation</seealso>
        public virtual IAsyncResult BeginListOtaTaskExecutions(ListOtaTaskExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOtaTaskExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOtaTaskExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOtaTaskExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOtaTaskExecutions.</param>
        /// 
        /// <returns>Returns a  ListOtaTaskExecutionsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTaskExecutions">REST API Reference for ListOtaTaskExecutions Operation</seealso>
        public virtual ListOtaTaskExecutionsResponse EndListOtaTaskExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOtaTaskExecutionsResponse>(asyncResult);
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
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOtaTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOtaTasksResponseUnmarshaller.Instance;

            return Invoke<ListOtaTasksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOtaTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOtaTasks operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOtaTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTasks">REST API Reference for ListOtaTasks Operation</seealso>
        public virtual IAsyncResult BeginListOtaTasks(ListOtaTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOtaTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOtaTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOtaTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOtaTasks.</param>
        /// 
        /// <returns>Returns a  ListOtaTasksResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTasks">REST API Reference for ListOtaTasks Operation</seealso>
        public virtual ListOtaTasksResponse EndListOtaTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOtaTasksResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProvisioningProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningProfilesResponseUnmarshaller.Instance;

            return Invoke<ListProvisioningProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisioningProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningProfiles operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProvisioningProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListProvisioningProfiles">REST API Reference for ListProvisioningProfiles Operation</seealso>
        public virtual IAsyncResult BeginListProvisioningProfiles(ListProvisioningProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProvisioningProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProvisioningProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProvisioningProfiles.</param>
        /// 
        /// <returns>Returns a  ListProvisioningProfilesResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListProvisioningProfiles">REST API Reference for ListProvisioningProfiles Operation</seealso>
        public virtual ListProvisioningProfilesResponse EndListProvisioningProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProvisioningProfilesResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaVersionsResponseUnmarshaller.Instance;

            return Invoke<ListSchemaVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemaVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaVersions operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemaVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        public virtual IAsyncResult BeginListSchemaVersions(ListSchemaVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemaVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemaVersions.</param>
        /// 
        /// <returns>Returns a  ListSchemaVersionsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        public virtual ListSchemaVersionsResponse EndListSchemaVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSchemaVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDefaultEncryptionConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutDefaultEncryptionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDefaultEncryptionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDefaultEncryptionConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDefaultEncryptionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutDefaultEncryptionConfiguration">REST API Reference for PutDefaultEncryptionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutDefaultEncryptionConfiguration(PutDefaultEncryptionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDefaultEncryptionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDefaultEncryptionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDefaultEncryptionConfiguration.</param>
        /// 
        /// <returns>Returns a  PutDefaultEncryptionConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutDefaultEncryptionConfiguration">REST API Reference for PutDefaultEncryptionConfiguration Operation</seealso>
        public virtual PutDefaultEncryptionConfigurationResponse EndPutDefaultEncryptionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDefaultEncryptionConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutHubConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutHubConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutHubConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutHubConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutHubConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutHubConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutHubConfiguration">REST API Reference for PutHubConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutHubConfiguration(PutHubConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutHubConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutHubConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutHubConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutHubConfiguration.</param>
        /// 
        /// <returns>Returns a  PutHubConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutHubConfiguration">REST API Reference for PutHubConfiguration Operation</seealso>
        public virtual PutHubConfigurationResponse EndPutHubConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutHubConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRuntimeLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRuntimeLogConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutRuntimeLogConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRuntimeLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRuntimeLogConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRuntimeLogConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutRuntimeLogConfiguration">REST API Reference for PutRuntimeLogConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutRuntimeLogConfiguration(PutRuntimeLogConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRuntimeLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRuntimeLogConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRuntimeLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRuntimeLogConfiguration.</param>
        /// 
        /// <returns>Returns a  PutRuntimeLogConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutRuntimeLogConfiguration">REST API Reference for PutRuntimeLogConfiguration Operation</seealso>
        public virtual PutRuntimeLogConfigurationResponse EndPutRuntimeLogConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRuntimeLogConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterAccountAssociation

        /// <summary>
        /// Registers an account association with a managed thing, establishing a connection between
        /// a device and a third-party account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccountAssociation service method.</param>
        /// 
        /// <returns>The response from the RegisterAccountAssociation service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/RegisterAccountAssociation">REST API Reference for RegisterAccountAssociation Operation</seealso>
        public virtual RegisterAccountAssociationResponse RegisterAccountAssociation(RegisterAccountAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterAccountAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAccountAssociationResponseUnmarshaller.Instance;

            return Invoke<RegisterAccountAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccountAssociation operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterAccountAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/RegisterAccountAssociation">REST API Reference for RegisterAccountAssociation Operation</seealso>
        public virtual IAsyncResult BeginRegisterAccountAssociation(RegisterAccountAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterAccountAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAccountAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterAccountAssociation.</param>
        /// 
        /// <returns>Returns a  RegisterAccountAssociationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/RegisterAccountAssociation">REST API Reference for RegisterAccountAssociation Operation</seealso>
        public virtual RegisterAccountAssociationResponse EndRegisterAccountAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterAccountAssociationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterCustomEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCustomEndpointResponseUnmarshaller.Instance;

            return Invoke<RegisterCustomEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterCustomEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterCustomEndpoint operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterCustomEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/RegisterCustomEndpoint">REST API Reference for RegisterCustomEndpoint Operation</seealso>
        public virtual IAsyncResult BeginRegisterCustomEndpoint(RegisterCustomEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterCustomEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCustomEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterCustomEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterCustomEndpoint.</param>
        /// 
        /// <returns>Returns a  RegisterCustomEndpointResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/RegisterCustomEndpoint">REST API Reference for RegisterCustomEndpoint Operation</seealso>
        public virtual RegisterCustomEndpointResponse EndRegisterCustomEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterCustomEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetRuntimeLogConfiguration

        /// <summary>
        /// Reset a runtime log configuration for a specific managed thing.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetRuntimeLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetRuntimeLogConfigurationResponseUnmarshaller.Instance;

            return Invoke<ResetRuntimeLogConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetRuntimeLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetRuntimeLogConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetRuntimeLogConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ResetRuntimeLogConfiguration">REST API Reference for ResetRuntimeLogConfiguration Operation</seealso>
        public virtual IAsyncResult BeginResetRuntimeLogConfiguration(ResetRuntimeLogConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetRuntimeLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetRuntimeLogConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetRuntimeLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetRuntimeLogConfiguration.</param>
        /// 
        /// <returns>Returns a  ResetRuntimeLogConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ResetRuntimeLogConfiguration">REST API Reference for ResetRuntimeLogConfiguration Operation</seealso>
        public virtual ResetRuntimeLogConfigurationResponse EndResetRuntimeLogConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetRuntimeLogConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  SendConnectorEvent

        /// <summary>
        /// Relays third-party device events for a connector such as a new device or a device
        /// state change event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendConnectorEvent service method.</param>
        /// 
        /// <returns>The response from the SendConnectorEvent service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/SendConnectorEvent">REST API Reference for SendConnectorEvent Operation</seealso>
        public virtual SendConnectorEventResponse SendConnectorEvent(SendConnectorEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendConnectorEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendConnectorEventResponseUnmarshaller.Instance;

            return Invoke<SendConnectorEventResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendConnectorEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendConnectorEvent operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendConnectorEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/SendConnectorEvent">REST API Reference for SendConnectorEvent Operation</seealso>
        public virtual IAsyncResult BeginSendConnectorEvent(SendConnectorEventRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendConnectorEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendConnectorEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendConnectorEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendConnectorEvent.</param>
        /// 
        /// <returns>Returns a  SendConnectorEventResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/SendConnectorEvent">REST API Reference for SendConnectorEvent Operation</seealso>
        public virtual SendConnectorEventResponse EndSendConnectorEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<SendConnectorEventResponse>(asyncResult);
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
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/SendManagedThingCommand">REST API Reference for SendManagedThingCommand Operation</seealso>
        public virtual SendManagedThingCommandResponse SendManagedThingCommand(SendManagedThingCommandRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendManagedThingCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendManagedThingCommandResponseUnmarshaller.Instance;

            return Invoke<SendManagedThingCommandResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendManagedThingCommand operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendManagedThingCommand operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendManagedThingCommand
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/SendManagedThingCommand">REST API Reference for SendManagedThingCommand Operation</seealso>
        public virtual IAsyncResult BeginSendManagedThingCommand(SendManagedThingCommandRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendManagedThingCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendManagedThingCommandResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendManagedThingCommand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendManagedThingCommand.</param>
        /// 
        /// <returns>Returns a  SendManagedThingCommandResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/SendManagedThingCommand">REST API Reference for SendManagedThingCommand Operation</seealso>
        public virtual SendManagedThingCommandResponse EndSendManagedThingCommand(IAsyncResult asyncResult)
        {
            return EndInvoke<SendManagedThingCommandResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAccountAssociationRefresh

        /// <summary>
        /// Initiates a refresh of an existing account association to update its authorization
        /// and connection status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAccountAssociationRefresh service method.</param>
        /// 
        /// <returns>The response from the StartAccountAssociationRefresh service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/StartAccountAssociationRefresh">REST API Reference for StartAccountAssociationRefresh Operation</seealso>
        public virtual StartAccountAssociationRefreshResponse StartAccountAssociationRefresh(StartAccountAssociationRefreshRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAccountAssociationRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAccountAssociationRefreshResponseUnmarshaller.Instance;

            return Invoke<StartAccountAssociationRefreshResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAccountAssociationRefresh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAccountAssociationRefresh operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAccountAssociationRefresh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/StartAccountAssociationRefresh">REST API Reference for StartAccountAssociationRefresh Operation</seealso>
        public virtual IAsyncResult BeginStartAccountAssociationRefresh(StartAccountAssociationRefreshRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAccountAssociationRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAccountAssociationRefreshResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAccountAssociationRefresh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAccountAssociationRefresh.</param>
        /// 
        /// <returns>Returns a  StartAccountAssociationRefreshResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/StartAccountAssociationRefresh">REST API Reference for StartAccountAssociationRefresh Operation</seealso>
        public virtual StartAccountAssociationRefreshResponse EndStartAccountAssociationRefresh(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAccountAssociationRefreshResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDeviceDiscovery

        /// <summary>
        /// This API is used to start device discovery for hub-connected and third-party-connected
        /// devices. The authentication material (install code) is delivered as a message to the
        /// controller instructing it to start the discovery.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDeviceDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeviceDiscoveryResponseUnmarshaller.Instance;

            return Invoke<StartDeviceDiscoveryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDeviceDiscovery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDeviceDiscovery operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDeviceDiscovery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/StartDeviceDiscovery">REST API Reference for StartDeviceDiscovery Operation</seealso>
        public virtual IAsyncResult BeginStartDeviceDiscovery(StartDeviceDiscoveryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDeviceDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeviceDiscoveryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDeviceDiscovery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDeviceDiscovery.</param>
        /// 
        /// <returns>Returns a  StartDeviceDiscoveryResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/StartDeviceDiscovery">REST API Reference for StartDeviceDiscovery Operation</seealso>
        public virtual StartDeviceDiscoveryResponse EndStartDeviceDiscovery(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDeviceDiscoveryResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Add tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Remove tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTManagedIntegrations.</returns>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ConflictException">
        /// There is a conflict with the request.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccountAssociation

        /// <summary>
        /// Updates the properties of an existing account association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountAssociation service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateAccountAssociation">REST API Reference for UpdateAccountAssociation Operation</seealso>
        public virtual UpdateAccountAssociationResponse UpdateAccountAssociation(UpdateAccountAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccountAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountAssociation operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateAccountAssociation">REST API Reference for UpdateAccountAssociation Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccountAssociation(UpdateAccountAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccountAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateAccountAssociationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateAccountAssociation">REST API Reference for UpdateAccountAssociation Operation</seealso>
        public virtual UpdateAccountAssociationResponse EndUpdateAccountAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccountAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCloudConnector

        /// <summary>
        /// Update an existing cloud connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudConnector service method.</param>
        /// 
        /// <returns>The response from the UpdateCloudConnector service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoTManagedIntegrations.Model.ValidationException">
        /// A validation error occurred when performing the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateCloudConnector">REST API Reference for UpdateCloudConnector Operation</seealso>
        public virtual UpdateCloudConnectorResponse UpdateCloudConnector(UpdateCloudConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCloudConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCloudConnectorResponseUnmarshaller.Instance;

            return Invoke<UpdateCloudConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCloudConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudConnector operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCloudConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateCloudConnector">REST API Reference for UpdateCloudConnector Operation</seealso>
        public virtual IAsyncResult BeginUpdateCloudConnector(UpdateCloudConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCloudConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCloudConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCloudConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCloudConnector.</param>
        /// 
        /// <returns>Returns a  UpdateCloudConnectorResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateCloudConnector">REST API Reference for UpdateCloudConnector Operation</seealso>
        public virtual UpdateCloudConnectorResponse EndUpdateCloudConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCloudConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConnectorDestination

        /// <summary>
        /// Updates the properties of an existing connector destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectorDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateConnectorDestination service method, as returned by IoTManagedIntegrations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateConnectorDestination">REST API Reference for UpdateConnectorDestination Operation</seealso>
        public virtual UpdateConnectorDestinationResponse UpdateConnectorDestination(UpdateConnectorDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectorDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectorDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnectorDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectorDestination operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnectorDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateConnectorDestination">REST API Reference for UpdateConnectorDestination Operation</seealso>
        public virtual IAsyncResult BeginUpdateConnectorDestination(UpdateConnectorDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectorDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectorDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectorDestination.</param>
        /// 
        /// <returns>Returns a  UpdateConnectorDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateConnectorDestination">REST API Reference for UpdateConnectorDestination Operation</seealso>
        public virtual UpdateConnectorDestinationResponse EndUpdateConnectorDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConnectorDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDestination

        /// <summary>
        /// Update a destination specified by name.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual IAsyncResult BeginUpdateDestination(UpdateDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UpdateDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual UpdateDestinationResponse EndUpdateDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDestinationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventLogConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateEventLogConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventLogConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventLogConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateEventLogConfiguration">REST API Reference for UpdateEventLogConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateEventLogConfiguration(UpdateEventLogConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventLogConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventLogConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventLogConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateEventLogConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateEventLogConfiguration">REST API Reference for UpdateEventLogConfiguration Operation</seealso>
        public virtual UpdateEventLogConfigurationResponse EndUpdateEventLogConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEventLogConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateManagedThingResponseUnmarshaller.Instance;

            return Invoke<UpdateManagedThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateManagedThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedThing operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateManagedThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateManagedThing">REST API Reference for UpdateManagedThing Operation</seealso>
        public virtual IAsyncResult BeginUpdateManagedThing(UpdateManagedThingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateManagedThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateManagedThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateManagedThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateManagedThing.</param>
        /// 
        /// <returns>Returns a  UpdateManagedThingResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateManagedThing">REST API Reference for UpdateManagedThing Operation</seealso>
        public virtual UpdateManagedThingResponse EndUpdateManagedThing(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateManagedThingResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateNotificationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationConfiguration operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateNotificationConfiguration(UpdateNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateNotificationConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        public virtual UpdateNotificationConfigurationResponse EndUpdateNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNotificationConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOtaTaskResponseUnmarshaller.Instance;

            return Invoke<UpdateOtaTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOtaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOtaTask operation on AmazonIoTManagedIntegrationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOtaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateOtaTask">REST API Reference for UpdateOtaTask Operation</seealso>
        public virtual IAsyncResult BeginUpdateOtaTask(UpdateOtaTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOtaTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOtaTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOtaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOtaTask.</param>
        /// 
        /// <returns>Returns a  UpdateOtaTaskResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateOtaTask">REST API Reference for UpdateOtaTask Operation</seealso>
        public virtual UpdateOtaTaskResponse EndUpdateOtaTask(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateOtaTaskResponse>(asyncResult);
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