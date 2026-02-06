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

using Amazon.Runtime;
using Amazon.IoTManagedIntegrations.Model;

#pragma warning disable CS1570
namespace Amazon.IoTManagedIntegrations
{
    /// <summary>
    /// <para>Interface for accessing IoTManagedIntegrations</para>
    ///
    /// Managed integrations is a feature of AWS IoT Device Management that enables developers
    /// to quickly build innovative IoT solutions. Customers can use managed integrations
    /// to automate device setup workflows and support interoperability across many devices,
    /// regardless of device vendor or connectivity protocol. This allows developers to use
    /// a single user-interface to control, manage, and operate a range of devices.
    /// </summary>
    public partial interface IAmazonIoTManagedIntegrations : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTManagedIntegrationsPaginatorFactory Paginators { get; }
#endif


        
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
        CreateAccountAssociationResponse CreateAccountAssociation(CreateAccountAssociationRequest request);

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
        IAsyncResult BeginCreateAccountAssociation(CreateAccountAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountAssociation.</param>
        /// 
        /// <returns>Returns a  CreateAccountAssociationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateAccountAssociation">REST API Reference for CreateAccountAssociation Operation</seealso>
        CreateAccountAssociationResponse EndCreateAccountAssociation(IAsyncResult asyncResult);

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
        CreateCloudConnectorResponse CreateCloudConnector(CreateCloudConnectorRequest request);

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
        IAsyncResult BeginCreateCloudConnector(CreateCloudConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudConnector.</param>
        /// 
        /// <returns>Returns a  CreateCloudConnectorResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateCloudConnector">REST API Reference for CreateCloudConnector Operation</seealso>
        CreateCloudConnectorResponse EndCreateCloudConnector(IAsyncResult asyncResult);

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
        CreateConnectorDestinationResponse CreateConnectorDestination(CreateConnectorDestinationRequest request);

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
        IAsyncResult BeginCreateConnectorDestination(CreateConnectorDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnectorDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnectorDestination.</param>
        /// 
        /// <returns>Returns a  CreateConnectorDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateConnectorDestination">REST API Reference for CreateConnectorDestination Operation</seealso>
        CreateConnectorDestinationResponse EndCreateConnectorDestination(IAsyncResult asyncResult);

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
        CreateCredentialLockerResponse CreateCredentialLocker(CreateCredentialLockerRequest request);

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
        IAsyncResult BeginCreateCredentialLocker(CreateCredentialLockerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCredentialLocker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCredentialLocker.</param>
        /// 
        /// <returns>Returns a  CreateCredentialLockerResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateCredentialLocker">REST API Reference for CreateCredentialLocker Operation</seealso>
        CreateCredentialLockerResponse EndCreateCredentialLocker(IAsyncResult asyncResult);

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
        CreateDestinationResponse CreateDestination(CreateDestinationRequest request);

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
        IAsyncResult BeginCreateDestination(CreateDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDestination.</param>
        /// 
        /// <returns>Returns a  CreateDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        CreateDestinationResponse EndCreateDestination(IAsyncResult asyncResult);

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
        CreateEventLogConfigurationResponse CreateEventLogConfiguration(CreateEventLogConfigurationRequest request);

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
        IAsyncResult BeginCreateEventLogConfiguration(CreateEventLogConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventLogConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateEventLogConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateEventLogConfiguration">REST API Reference for CreateEventLogConfiguration Operation</seealso>
        CreateEventLogConfigurationResponse EndCreateEventLogConfiguration(IAsyncResult asyncResult);

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
        CreateManagedThingResponse CreateManagedThing(CreateManagedThingRequest request);

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
        IAsyncResult BeginCreateManagedThing(CreateManagedThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateManagedThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateManagedThing.</param>
        /// 
        /// <returns>Returns a  CreateManagedThingResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateManagedThing">REST API Reference for CreateManagedThing Operation</seealso>
        CreateManagedThingResponse EndCreateManagedThing(IAsyncResult asyncResult);

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
        CreateNotificationConfigurationResponse CreateNotificationConfiguration(CreateNotificationConfigurationRequest request);

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
        IAsyncResult BeginCreateNotificationConfiguration(CreateNotificationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateNotificationConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateNotificationConfiguration">REST API Reference for CreateNotificationConfiguration Operation</seealso>
        CreateNotificationConfigurationResponse EndCreateNotificationConfiguration(IAsyncResult asyncResult);

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
        CreateOtaTaskResponse CreateOtaTask(CreateOtaTaskRequest request);

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
        IAsyncResult BeginCreateOtaTask(CreateOtaTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOtaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOtaTask.</param>
        /// 
        /// <returns>Returns a  CreateOtaTaskResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateOtaTask">REST API Reference for CreateOtaTask Operation</seealso>
        CreateOtaTaskResponse EndCreateOtaTask(IAsyncResult asyncResult);

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
        CreateOtaTaskConfigurationResponse CreateOtaTaskConfiguration(CreateOtaTaskConfigurationRequest request);

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
        IAsyncResult BeginCreateOtaTaskConfiguration(CreateOtaTaskConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOtaTaskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOtaTaskConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateOtaTaskConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateOtaTaskConfiguration">REST API Reference for CreateOtaTaskConfiguration Operation</seealso>
        CreateOtaTaskConfigurationResponse EndCreateOtaTaskConfiguration(IAsyncResult asyncResult);

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
        CreateProvisioningProfileResponse CreateProvisioningProfile(CreateProvisioningProfileRequest request);

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
        IAsyncResult BeginCreateProvisioningProfile(CreateProvisioningProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProvisioningProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProvisioningProfile.</param>
        /// 
        /// <returns>Returns a  CreateProvisioningProfileResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/CreateProvisioningProfile">REST API Reference for CreateProvisioningProfile Operation</seealso>
        CreateProvisioningProfileResponse EndCreateProvisioningProfile(IAsyncResult asyncResult);

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
        DeleteAccountAssociationResponse DeleteAccountAssociation(DeleteAccountAssociationRequest request);

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
        IAsyncResult BeginDeleteAccountAssociation(DeleteAccountAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteAccountAssociationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteAccountAssociation">REST API Reference for DeleteAccountAssociation Operation</seealso>
        DeleteAccountAssociationResponse EndDeleteAccountAssociation(IAsyncResult asyncResult);

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
        DeleteCloudConnectorResponse DeleteCloudConnector(DeleteCloudConnectorRequest request);

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
        IAsyncResult BeginDeleteCloudConnector(DeleteCloudConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCloudConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudConnector.</param>
        /// 
        /// <returns>Returns a  DeleteCloudConnectorResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteCloudConnector">REST API Reference for DeleteCloudConnector Operation</seealso>
        DeleteCloudConnectorResponse EndDeleteCloudConnector(IAsyncResult asyncResult);

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
        DeleteConnectorDestinationResponse DeleteConnectorDestination(DeleteConnectorDestinationRequest request);

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
        IAsyncResult BeginDeleteConnectorDestination(DeleteConnectorDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectorDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectorDestination.</param>
        /// 
        /// <returns>Returns a  DeleteConnectorDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteConnectorDestination">REST API Reference for DeleteConnectorDestination Operation</seealso>
        DeleteConnectorDestinationResponse EndDeleteConnectorDestination(IAsyncResult asyncResult);

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
        DeleteCredentialLockerResponse DeleteCredentialLocker(DeleteCredentialLockerRequest request);

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
        IAsyncResult BeginDeleteCredentialLocker(DeleteCredentialLockerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCredentialLocker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCredentialLocker.</param>
        /// 
        /// <returns>Returns a  DeleteCredentialLockerResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteCredentialLocker">REST API Reference for DeleteCredentialLocker Operation</seealso>
        DeleteCredentialLockerResponse EndDeleteCredentialLocker(IAsyncResult asyncResult);

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
        DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request);

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
        IAsyncResult BeginDeleteDestination(DeleteDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDestination.</param>
        /// 
        /// <returns>Returns a  DeleteDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        DeleteDestinationResponse EndDeleteDestination(IAsyncResult asyncResult);

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
        DeleteEventLogConfigurationResponse DeleteEventLogConfiguration(DeleteEventLogConfigurationRequest request);

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
        IAsyncResult BeginDeleteEventLogConfiguration(DeleteEventLogConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventLogConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteEventLogConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteEventLogConfiguration">REST API Reference for DeleteEventLogConfiguration Operation</seealso>
        DeleteEventLogConfigurationResponse EndDeleteEventLogConfiguration(IAsyncResult asyncResult);

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
        DeleteManagedThingResponse DeleteManagedThing(DeleteManagedThingRequest request);

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
        IAsyncResult BeginDeleteManagedThing(DeleteManagedThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteManagedThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteManagedThing.</param>
        /// 
        /// <returns>Returns a  DeleteManagedThingResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteManagedThing">REST API Reference for DeleteManagedThing Operation</seealso>
        DeleteManagedThingResponse EndDeleteManagedThing(IAsyncResult asyncResult);

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
        DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request);

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
        IAsyncResult BeginDeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        DeleteNotificationConfigurationResponse EndDeleteNotificationConfiguration(IAsyncResult asyncResult);

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
        DeleteOtaTaskResponse DeleteOtaTask(DeleteOtaTaskRequest request);

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
        IAsyncResult BeginDeleteOtaTask(DeleteOtaTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOtaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOtaTask.</param>
        /// 
        /// <returns>Returns a  DeleteOtaTaskResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteOtaTask">REST API Reference for DeleteOtaTask Operation</seealso>
        DeleteOtaTaskResponse EndDeleteOtaTask(IAsyncResult asyncResult);

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
        DeleteOtaTaskConfigurationResponse DeleteOtaTaskConfiguration(DeleteOtaTaskConfigurationRequest request);

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
        IAsyncResult BeginDeleteOtaTaskConfiguration(DeleteOtaTaskConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOtaTaskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOtaTaskConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteOtaTaskConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteOtaTaskConfiguration">REST API Reference for DeleteOtaTaskConfiguration Operation</seealso>
        DeleteOtaTaskConfigurationResponse EndDeleteOtaTaskConfiguration(IAsyncResult asyncResult);

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
        DeleteProvisioningProfileResponse DeleteProvisioningProfile(DeleteProvisioningProfileRequest request);

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
        IAsyncResult BeginDeleteProvisioningProfile(DeleteProvisioningProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProvisioningProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProvisioningProfile.</param>
        /// 
        /// <returns>Returns a  DeleteProvisioningProfileResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeleteProvisioningProfile">REST API Reference for DeleteProvisioningProfile Operation</seealso>
        DeleteProvisioningProfileResponse EndDeleteProvisioningProfile(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeregisterAccountAssociation">REST API Reference for DeregisterAccountAssociation Operation</seealso>
        DeregisterAccountAssociationResponse DeregisterAccountAssociation(DeregisterAccountAssociationRequest request);

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
        IAsyncResult BeginDeregisterAccountAssociation(DeregisterAccountAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterAccountAssociation.</param>
        /// 
        /// <returns>Returns a  DeregisterAccountAssociationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/DeregisterAccountAssociation">REST API Reference for DeregisterAccountAssociation Operation</seealso>
        DeregisterAccountAssociationResponse EndDeregisterAccountAssociation(IAsyncResult asyncResult);

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
        GetAccountAssociationResponse GetAccountAssociation(GetAccountAssociationRequest request);

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
        IAsyncResult BeginGetAccountAssociation(GetAccountAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountAssociation.</param>
        /// 
        /// <returns>Returns a  GetAccountAssociationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetAccountAssociation">REST API Reference for GetAccountAssociation Operation</seealso>
        GetAccountAssociationResponse EndGetAccountAssociation(IAsyncResult asyncResult);

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
        GetCloudConnectorResponse GetCloudConnector(GetCloudConnectorRequest request);

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
        IAsyncResult BeginGetCloudConnector(GetCloudConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudConnector.</param>
        /// 
        /// <returns>Returns a  GetCloudConnectorResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetCloudConnector">REST API Reference for GetCloudConnector Operation</seealso>
        GetCloudConnectorResponse EndGetCloudConnector(IAsyncResult asyncResult);

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
        GetConnectorDestinationResponse GetConnectorDestination(GetConnectorDestinationRequest request);

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
        IAsyncResult BeginGetConnectorDestination(GetConnectorDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectorDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectorDestination.</param>
        /// 
        /// <returns>Returns a  GetConnectorDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetConnectorDestination">REST API Reference for GetConnectorDestination Operation</seealso>
        GetConnectorDestinationResponse EndGetConnectorDestination(IAsyncResult asyncResult);

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
        GetCredentialLockerResponse GetCredentialLocker(GetCredentialLockerRequest request);

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
        IAsyncResult BeginGetCredentialLocker(GetCredentialLockerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCredentialLocker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCredentialLocker.</param>
        /// 
        /// <returns>Returns a  GetCredentialLockerResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetCredentialLocker">REST API Reference for GetCredentialLocker Operation</seealso>
        GetCredentialLockerResponse EndGetCredentialLocker(IAsyncResult asyncResult);

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
        GetCustomEndpointResponse GetCustomEndpoint(GetCustomEndpointRequest request);

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
        IAsyncResult BeginGetCustomEndpoint(GetCustomEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCustomEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCustomEndpoint.</param>
        /// 
        /// <returns>Returns a  GetCustomEndpointResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetCustomEndpoint">REST API Reference for GetCustomEndpoint Operation</seealso>
        GetCustomEndpointResponse EndGetCustomEndpoint(IAsyncResult asyncResult);

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
        GetDefaultEncryptionConfigurationResponse GetDefaultEncryptionConfiguration(GetDefaultEncryptionConfigurationRequest request);

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
        IAsyncResult BeginGetDefaultEncryptionConfiguration(GetDefaultEncryptionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDefaultEncryptionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDefaultEncryptionConfiguration.</param>
        /// 
        /// <returns>Returns a  GetDefaultEncryptionConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDefaultEncryptionConfiguration">REST API Reference for GetDefaultEncryptionConfiguration Operation</seealso>
        GetDefaultEncryptionConfigurationResponse EndGetDefaultEncryptionConfiguration(IAsyncResult asyncResult);

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
        GetDestinationResponse GetDestination(GetDestinationRequest request);

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
        IAsyncResult BeginGetDestination(GetDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDestination.</param>
        /// 
        /// <returns>Returns a  GetDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDestination">REST API Reference for GetDestination Operation</seealso>
        GetDestinationResponse EndGetDestination(IAsyncResult asyncResult);

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
        GetDeviceDiscoveryResponse GetDeviceDiscovery(GetDeviceDiscoveryRequest request);

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
        IAsyncResult BeginGetDeviceDiscovery(GetDeviceDiscoveryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeviceDiscovery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeviceDiscovery.</param>
        /// 
        /// <returns>Returns a  GetDeviceDiscoveryResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetDeviceDiscovery">REST API Reference for GetDeviceDiscovery Operation</seealso>
        GetDeviceDiscoveryResponse EndGetDeviceDiscovery(IAsyncResult asyncResult);

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
        GetEventLogConfigurationResponse GetEventLogConfiguration(GetEventLogConfigurationRequest request);

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
        IAsyncResult BeginGetEventLogConfiguration(GetEventLogConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventLogConfiguration.</param>
        /// 
        /// <returns>Returns a  GetEventLogConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetEventLogConfiguration">REST API Reference for GetEventLogConfiguration Operation</seealso>
        GetEventLogConfigurationResponse EndGetEventLogConfiguration(IAsyncResult asyncResult);

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
        GetHubConfigurationResponse GetHubConfiguration(GetHubConfigurationRequest request);

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
        IAsyncResult BeginGetHubConfiguration(GetHubConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHubConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHubConfiguration.</param>
        /// 
        /// <returns>Returns a  GetHubConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetHubConfiguration">REST API Reference for GetHubConfiguration Operation</seealso>
        GetHubConfigurationResponse EndGetHubConfiguration(IAsyncResult asyncResult);

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
        GetManagedThingResponse GetManagedThing(GetManagedThingRequest request);

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
        IAsyncResult BeginGetManagedThing(GetManagedThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedThing.</param>
        /// 
        /// <returns>Returns a  GetManagedThingResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThing">REST API Reference for GetManagedThing Operation</seealso>
        GetManagedThingResponse EndGetManagedThing(IAsyncResult asyncResult);

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
        GetManagedThingCapabilitiesResponse GetManagedThingCapabilities(GetManagedThingCapabilitiesRequest request);

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
        IAsyncResult BeginGetManagedThingCapabilities(GetManagedThingCapabilitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedThingCapabilities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedThingCapabilities.</param>
        /// 
        /// <returns>Returns a  GetManagedThingCapabilitiesResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingCapabilities">REST API Reference for GetManagedThingCapabilities Operation</seealso>
        GetManagedThingCapabilitiesResponse EndGetManagedThingCapabilities(IAsyncResult asyncResult);

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
        GetManagedThingCertificateResponse GetManagedThingCertificate(GetManagedThingCertificateRequest request);

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
        IAsyncResult BeginGetManagedThingCertificate(GetManagedThingCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedThingCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedThingCertificate.</param>
        /// 
        /// <returns>Returns a  GetManagedThingCertificateResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingCertificate">REST API Reference for GetManagedThingCertificate Operation</seealso>
        GetManagedThingCertificateResponse EndGetManagedThingCertificate(IAsyncResult asyncResult);

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
        GetManagedThingConnectivityDataResponse GetManagedThingConnectivityData(GetManagedThingConnectivityDataRequest request);

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
        IAsyncResult BeginGetManagedThingConnectivityData(GetManagedThingConnectivityDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedThingConnectivityData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedThingConnectivityData.</param>
        /// 
        /// <returns>Returns a  GetManagedThingConnectivityDataResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingConnectivityData">REST API Reference for GetManagedThingConnectivityData Operation</seealso>
        GetManagedThingConnectivityDataResponse EndGetManagedThingConnectivityData(IAsyncResult asyncResult);

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
        GetManagedThingMetaDataResponse GetManagedThingMetaData(GetManagedThingMetaDataRequest request);

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
        IAsyncResult BeginGetManagedThingMetaData(GetManagedThingMetaDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedThingMetaData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedThingMetaData.</param>
        /// 
        /// <returns>Returns a  GetManagedThingMetaDataResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingMetaData">REST API Reference for GetManagedThingMetaData Operation</seealso>
        GetManagedThingMetaDataResponse EndGetManagedThingMetaData(IAsyncResult asyncResult);

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
        GetManagedThingStateResponse GetManagedThingState(GetManagedThingStateRequest request);

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
        IAsyncResult BeginGetManagedThingState(GetManagedThingStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedThingState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedThingState.</param>
        /// 
        /// <returns>Returns a  GetManagedThingStateResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetManagedThingState">REST API Reference for GetManagedThingState Operation</seealso>
        GetManagedThingStateResponse EndGetManagedThingState(IAsyncResult asyncResult);

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
        GetNotificationConfigurationResponse GetNotificationConfiguration(GetNotificationConfigurationRequest request);

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
        IAsyncResult BeginGetNotificationConfiguration(GetNotificationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  GetNotificationConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        GetNotificationConfigurationResponse EndGetNotificationConfiguration(IAsyncResult asyncResult);

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
        GetOtaTaskResponse GetOtaTask(GetOtaTaskRequest request);

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
        IAsyncResult BeginGetOtaTask(GetOtaTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOtaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOtaTask.</param>
        /// 
        /// <returns>Returns a  GetOtaTaskResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetOtaTask">REST API Reference for GetOtaTask Operation</seealso>
        GetOtaTaskResponse EndGetOtaTask(IAsyncResult asyncResult);

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
        GetOtaTaskConfigurationResponse GetOtaTaskConfiguration(GetOtaTaskConfigurationRequest request);

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
        IAsyncResult BeginGetOtaTaskConfiguration(GetOtaTaskConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOtaTaskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOtaTaskConfiguration.</param>
        /// 
        /// <returns>Returns a  GetOtaTaskConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetOtaTaskConfiguration">REST API Reference for GetOtaTaskConfiguration Operation</seealso>
        GetOtaTaskConfigurationResponse EndGetOtaTaskConfiguration(IAsyncResult asyncResult);

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
        GetProvisioningProfileResponse GetProvisioningProfile(GetProvisioningProfileRequest request);

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
        IAsyncResult BeginGetProvisioningProfile(GetProvisioningProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProvisioningProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProvisioningProfile.</param>
        /// 
        /// <returns>Returns a  GetProvisioningProfileResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetProvisioningProfile">REST API Reference for GetProvisioningProfile Operation</seealso>
        GetProvisioningProfileResponse EndGetProvisioningProfile(IAsyncResult asyncResult);

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
        GetRuntimeLogConfigurationResponse GetRuntimeLogConfiguration(GetRuntimeLogConfigurationRequest request);

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
        IAsyncResult BeginGetRuntimeLogConfiguration(GetRuntimeLogConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRuntimeLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRuntimeLogConfiguration.</param>
        /// 
        /// <returns>Returns a  GetRuntimeLogConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetRuntimeLogConfiguration">REST API Reference for GetRuntimeLogConfiguration Operation</seealso>
        GetRuntimeLogConfigurationResponse EndGetRuntimeLogConfiguration(IAsyncResult asyncResult);

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
        GetSchemaVersionResponse GetSchemaVersion(GetSchemaVersionRequest request);

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
        IAsyncResult BeginGetSchemaVersion(GetSchemaVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchemaVersion.</param>
        /// 
        /// <returns>Returns a  GetSchemaVersionResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/GetSchemaVersion">REST API Reference for GetSchemaVersion Operation</seealso>
        GetSchemaVersionResponse EndGetSchemaVersion(IAsyncResult asyncResult);

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
        ListAccountAssociationsResponse ListAccountAssociations(ListAccountAssociationsRequest request);

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
        IAsyncResult BeginListAccountAssociations(ListAccountAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAssociations.</param>
        /// 
        /// <returns>Returns a  ListAccountAssociationsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListAccountAssociations">REST API Reference for ListAccountAssociations Operation</seealso>
        ListAccountAssociationsResponse EndListAccountAssociations(IAsyncResult asyncResult);

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
        ListCloudConnectorsResponse ListCloudConnectors(ListCloudConnectorsRequest request);

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
        IAsyncResult BeginListCloudConnectors(ListCloudConnectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCloudConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudConnectors.</param>
        /// 
        /// <returns>Returns a  ListCloudConnectorsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListCloudConnectors">REST API Reference for ListCloudConnectors Operation</seealso>
        ListCloudConnectorsResponse EndListCloudConnectors(IAsyncResult asyncResult);

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
        ListConnectorDestinationsResponse ListConnectorDestinations(ListConnectorDestinationsRequest request);

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
        IAsyncResult BeginListConnectorDestinations(ListConnectorDestinationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectorDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectorDestinations.</param>
        /// 
        /// <returns>Returns a  ListConnectorDestinationsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListConnectorDestinations">REST API Reference for ListConnectorDestinations Operation</seealso>
        ListConnectorDestinationsResponse EndListConnectorDestinations(IAsyncResult asyncResult);

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
        ListCredentialLockersResponse ListCredentialLockers(ListCredentialLockersRequest request);

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
        IAsyncResult BeginListCredentialLockers(ListCredentialLockersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCredentialLockers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCredentialLockers.</param>
        /// 
        /// <returns>Returns a  ListCredentialLockersResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListCredentialLockers">REST API Reference for ListCredentialLockers Operation</seealso>
        ListCredentialLockersResponse EndListCredentialLockers(IAsyncResult asyncResult);

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
        ListDestinationsResponse ListDestinations(ListDestinationsRequest request);

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
        IAsyncResult BeginListDestinations(ListDestinationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDestinations.</param>
        /// 
        /// <returns>Returns a  ListDestinationsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        ListDestinationsResponse EndListDestinations(IAsyncResult asyncResult);

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
        ListDeviceDiscoveriesResponse ListDeviceDiscoveries(ListDeviceDiscoveriesRequest request);

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
        IAsyncResult BeginListDeviceDiscoveries(ListDeviceDiscoveriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeviceDiscoveries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeviceDiscoveries.</param>
        /// 
        /// <returns>Returns a  ListDeviceDiscoveriesResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListDeviceDiscoveries">REST API Reference for ListDeviceDiscoveries Operation</seealso>
        ListDeviceDiscoveriesResponse EndListDeviceDiscoveries(IAsyncResult asyncResult);

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
        ListDiscoveredDevicesResponse ListDiscoveredDevices(ListDiscoveredDevicesRequest request);

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
        IAsyncResult BeginListDiscoveredDevices(ListDiscoveredDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDiscoveredDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDiscoveredDevices.</param>
        /// 
        /// <returns>Returns a  ListDiscoveredDevicesResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListDiscoveredDevices">REST API Reference for ListDiscoveredDevices Operation</seealso>
        ListDiscoveredDevicesResponse EndListDiscoveredDevices(IAsyncResult asyncResult);

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
        ListEventLogConfigurationsResponse ListEventLogConfigurations(ListEventLogConfigurationsRequest request);

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
        IAsyncResult BeginListEventLogConfigurations(ListEventLogConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventLogConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventLogConfigurations.</param>
        /// 
        /// <returns>Returns a  ListEventLogConfigurationsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListEventLogConfigurations">REST API Reference for ListEventLogConfigurations Operation</seealso>
        ListEventLogConfigurationsResponse EndListEventLogConfigurations(IAsyncResult asyncResult);

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
        ListManagedThingAccountAssociationsResponse ListManagedThingAccountAssociations(ListManagedThingAccountAssociationsRequest request);

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
        IAsyncResult BeginListManagedThingAccountAssociations(ListManagedThingAccountAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedThingAccountAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedThingAccountAssociations.</param>
        /// 
        /// <returns>Returns a  ListManagedThingAccountAssociationsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListManagedThingAccountAssociations">REST API Reference for ListManagedThingAccountAssociations Operation</seealso>
        ListManagedThingAccountAssociationsResponse EndListManagedThingAccountAssociations(IAsyncResult asyncResult);

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
        ListManagedThingsResponse ListManagedThings(ListManagedThingsRequest request);

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
        IAsyncResult BeginListManagedThings(ListManagedThingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedThings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedThings.</param>
        /// 
        /// <returns>Returns a  ListManagedThingsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListManagedThings">REST API Reference for ListManagedThings Operation</seealso>
        ListManagedThingsResponse EndListManagedThings(IAsyncResult asyncResult);

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
        ListManagedThingSchemasResponse ListManagedThingSchemas(ListManagedThingSchemasRequest request);

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
        IAsyncResult BeginListManagedThingSchemas(ListManagedThingSchemasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedThingSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedThingSchemas.</param>
        /// 
        /// <returns>Returns a  ListManagedThingSchemasResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListManagedThingSchemas">REST API Reference for ListManagedThingSchemas Operation</seealso>
        ListManagedThingSchemasResponse EndListManagedThingSchemas(IAsyncResult asyncResult);

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
        ListNotificationConfigurationsResponse ListNotificationConfigurations(ListNotificationConfigurationsRequest request);

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
        IAsyncResult BeginListNotificationConfigurations(ListNotificationConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotificationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotificationConfigurations.</param>
        /// 
        /// <returns>Returns a  ListNotificationConfigurationsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListNotificationConfigurations">REST API Reference for ListNotificationConfigurations Operation</seealso>
        ListNotificationConfigurationsResponse EndListNotificationConfigurations(IAsyncResult asyncResult);

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
        ListOtaTaskConfigurationsResponse ListOtaTaskConfigurations(ListOtaTaskConfigurationsRequest request);

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
        IAsyncResult BeginListOtaTaskConfigurations(ListOtaTaskConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOtaTaskConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOtaTaskConfigurations.</param>
        /// 
        /// <returns>Returns a  ListOtaTaskConfigurationsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTaskConfigurations">REST API Reference for ListOtaTaskConfigurations Operation</seealso>
        ListOtaTaskConfigurationsResponse EndListOtaTaskConfigurations(IAsyncResult asyncResult);

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
        ListOtaTaskExecutionsResponse ListOtaTaskExecutions(ListOtaTaskExecutionsRequest request);

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
        IAsyncResult BeginListOtaTaskExecutions(ListOtaTaskExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOtaTaskExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOtaTaskExecutions.</param>
        /// 
        /// <returns>Returns a  ListOtaTaskExecutionsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTaskExecutions">REST API Reference for ListOtaTaskExecutions Operation</seealso>
        ListOtaTaskExecutionsResponse EndListOtaTaskExecutions(IAsyncResult asyncResult);

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
        ListOtaTasksResponse ListOtaTasks(ListOtaTasksRequest request);

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
        IAsyncResult BeginListOtaTasks(ListOtaTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOtaTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOtaTasks.</param>
        /// 
        /// <returns>Returns a  ListOtaTasksResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListOtaTasks">REST API Reference for ListOtaTasks Operation</seealso>
        ListOtaTasksResponse EndListOtaTasks(IAsyncResult asyncResult);

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
        ListProvisioningProfilesResponse ListProvisioningProfiles(ListProvisioningProfilesRequest request);

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
        IAsyncResult BeginListProvisioningProfiles(ListProvisioningProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProvisioningProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProvisioningProfiles.</param>
        /// 
        /// <returns>Returns a  ListProvisioningProfilesResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListProvisioningProfiles">REST API Reference for ListProvisioningProfiles Operation</seealso>
        ListProvisioningProfilesResponse EndListProvisioningProfiles(IAsyncResult asyncResult);

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
        ListSchemaVersionsResponse ListSchemaVersions(ListSchemaVersionsRequest request);

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
        IAsyncResult BeginListSchemaVersions(ListSchemaVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemaVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemaVersions.</param>
        /// 
        /// <returns>Returns a  ListSchemaVersionsResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        ListSchemaVersionsResponse EndListSchemaVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for a specified resource.
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

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
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        PutDefaultEncryptionConfigurationResponse PutDefaultEncryptionConfiguration(PutDefaultEncryptionConfigurationRequest request);

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
        IAsyncResult BeginPutDefaultEncryptionConfiguration(PutDefaultEncryptionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutDefaultEncryptionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDefaultEncryptionConfiguration.</param>
        /// 
        /// <returns>Returns a  PutDefaultEncryptionConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutDefaultEncryptionConfiguration">REST API Reference for PutDefaultEncryptionConfiguration Operation</seealso>
        PutDefaultEncryptionConfigurationResponse EndPutDefaultEncryptionConfiguration(IAsyncResult asyncResult);

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
        PutHubConfigurationResponse PutHubConfiguration(PutHubConfigurationRequest request);

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
        IAsyncResult BeginPutHubConfiguration(PutHubConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutHubConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutHubConfiguration.</param>
        /// 
        /// <returns>Returns a  PutHubConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutHubConfiguration">REST API Reference for PutHubConfiguration Operation</seealso>
        PutHubConfigurationResponse EndPutHubConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRuntimeLogConfiguration


        /// <summary>
        /// Set the runtime log configuration for a specific managed thing.
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
        PutRuntimeLogConfigurationResponse PutRuntimeLogConfiguration(PutRuntimeLogConfigurationRequest request);

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
        IAsyncResult BeginPutRuntimeLogConfiguration(PutRuntimeLogConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRuntimeLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRuntimeLogConfiguration.</param>
        /// 
        /// <returns>Returns a  PutRuntimeLogConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/PutRuntimeLogConfiguration">REST API Reference for PutRuntimeLogConfiguration Operation</seealso>
        PutRuntimeLogConfigurationResponse EndPutRuntimeLogConfiguration(IAsyncResult asyncResult);

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
        RegisterAccountAssociationResponse RegisterAccountAssociation(RegisterAccountAssociationRequest request);

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
        IAsyncResult BeginRegisterAccountAssociation(RegisterAccountAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterAccountAssociation.</param>
        /// 
        /// <returns>Returns a  RegisterAccountAssociationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/RegisterAccountAssociation">REST API Reference for RegisterAccountAssociation Operation</seealso>
        RegisterAccountAssociationResponse EndRegisterAccountAssociation(IAsyncResult asyncResult);

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
        RegisterCustomEndpointResponse RegisterCustomEndpoint(RegisterCustomEndpointRequest request);

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
        IAsyncResult BeginRegisterCustomEndpoint(RegisterCustomEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterCustomEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterCustomEndpoint.</param>
        /// 
        /// <returns>Returns a  RegisterCustomEndpointResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/RegisterCustomEndpoint">REST API Reference for RegisterCustomEndpoint Operation</seealso>
        RegisterCustomEndpointResponse EndRegisterCustomEndpoint(IAsyncResult asyncResult);

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
        ResetRuntimeLogConfigurationResponse ResetRuntimeLogConfiguration(ResetRuntimeLogConfigurationRequest request);

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
        IAsyncResult BeginResetRuntimeLogConfiguration(ResetRuntimeLogConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetRuntimeLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetRuntimeLogConfiguration.</param>
        /// 
        /// <returns>Returns a  ResetRuntimeLogConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/ResetRuntimeLogConfiguration">REST API Reference for ResetRuntimeLogConfiguration Operation</seealso>
        ResetRuntimeLogConfigurationResponse EndResetRuntimeLogConfiguration(IAsyncResult asyncResult);

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
        SendConnectorEventResponse SendConnectorEvent(SendConnectorEventRequest request);

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
        IAsyncResult BeginSendConnectorEvent(SendConnectorEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendConnectorEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendConnectorEvent.</param>
        /// 
        /// <returns>Returns a  SendConnectorEventResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/SendConnectorEvent">REST API Reference for SendConnectorEvent Operation</seealso>
        SendConnectorEventResponse EndSendConnectorEvent(IAsyncResult asyncResult);

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
        SendManagedThingCommandResponse SendManagedThingCommand(SendManagedThingCommandRequest request);

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
        IAsyncResult BeginSendManagedThingCommand(SendManagedThingCommandRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendManagedThingCommand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendManagedThingCommand.</param>
        /// 
        /// <returns>Returns a  SendManagedThingCommandResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/SendManagedThingCommand">REST API Reference for SendManagedThingCommand Operation</seealso>
        SendManagedThingCommandResponse EndSendManagedThingCommand(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/StartAccountAssociationRefresh">REST API Reference for StartAccountAssociationRefresh Operation</seealso>
        StartAccountAssociationRefreshResponse StartAccountAssociationRefresh(StartAccountAssociationRefreshRequest request);

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
        IAsyncResult BeginStartAccountAssociationRefresh(StartAccountAssociationRefreshRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartAccountAssociationRefresh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAccountAssociationRefresh.</param>
        /// 
        /// <returns>Returns a  StartAccountAssociationRefreshResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/StartAccountAssociationRefresh">REST API Reference for StartAccountAssociationRefresh Operation</seealso>
        StartAccountAssociationRefreshResponse EndStartAccountAssociationRefresh(IAsyncResult asyncResult);

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
        StartDeviceDiscoveryResponse StartDeviceDiscovery(StartDeviceDiscoveryRequest request);

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
        IAsyncResult BeginStartDeviceDiscovery(StartDeviceDiscoveryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDeviceDiscovery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDeviceDiscovery.</param>
        /// 
        /// <returns>Returns a  StartDeviceDiscoveryResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/StartDeviceDiscovery">REST API Reference for StartDeviceDiscovery Operation</seealso>
        StartDeviceDiscoveryResponse EndStartDeviceDiscovery(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a specified resource.
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
        TagResourceResponse TagResource(TagResourceRequest request);

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
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a specified resource.
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

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
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        UpdateAccountAssociationResponse UpdateAccountAssociation(UpdateAccountAssociationRequest request);

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
        IAsyncResult BeginUpdateAccountAssociation(UpdateAccountAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateAccountAssociationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateAccountAssociation">REST API Reference for UpdateAccountAssociation Operation</seealso>
        UpdateAccountAssociationResponse EndUpdateAccountAssociation(IAsyncResult asyncResult);

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
        UpdateCloudConnectorResponse UpdateCloudConnector(UpdateCloudConnectorRequest request);

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
        IAsyncResult BeginUpdateCloudConnector(UpdateCloudConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCloudConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCloudConnector.</param>
        /// 
        /// <returns>Returns a  UpdateCloudConnectorResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateCloudConnector">REST API Reference for UpdateCloudConnector Operation</seealso>
        UpdateCloudConnectorResponse EndUpdateCloudConnector(IAsyncResult asyncResult);

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
        UpdateConnectorDestinationResponse UpdateConnectorDestination(UpdateConnectorDestinationRequest request);

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
        IAsyncResult BeginUpdateConnectorDestination(UpdateConnectorDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectorDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectorDestination.</param>
        /// 
        /// <returns>Returns a  UpdateConnectorDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateConnectorDestination">REST API Reference for UpdateConnectorDestination Operation</seealso>
        UpdateConnectorDestinationResponse EndUpdateConnectorDestination(IAsyncResult asyncResult);

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
        UpdateDestinationResponse UpdateDestination(UpdateDestinationRequest request);

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
        IAsyncResult BeginUpdateDestination(UpdateDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDestination.</param>
        /// 
        /// <returns>Returns a  UpdateDestinationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        UpdateDestinationResponse EndUpdateDestination(IAsyncResult asyncResult);

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
        UpdateEventLogConfigurationResponse UpdateEventLogConfiguration(UpdateEventLogConfigurationRequest request);

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
        IAsyncResult BeginUpdateEventLogConfiguration(UpdateEventLogConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventLogConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventLogConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateEventLogConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateEventLogConfiguration">REST API Reference for UpdateEventLogConfiguration Operation</seealso>
        UpdateEventLogConfigurationResponse EndUpdateEventLogConfiguration(IAsyncResult asyncResult);

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
        UpdateManagedThingResponse UpdateManagedThing(UpdateManagedThingRequest request);

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
        IAsyncResult BeginUpdateManagedThing(UpdateManagedThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateManagedThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateManagedThing.</param>
        /// 
        /// <returns>Returns a  UpdateManagedThingResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateManagedThing">REST API Reference for UpdateManagedThing Operation</seealso>
        UpdateManagedThingResponse EndUpdateManagedThing(IAsyncResult asyncResult);

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
        UpdateNotificationConfigurationResponse UpdateNotificationConfiguration(UpdateNotificationConfigurationRequest request);

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
        IAsyncResult BeginUpdateNotificationConfiguration(UpdateNotificationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateNotificationConfigurationResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        UpdateNotificationConfigurationResponse EndUpdateNotificationConfiguration(IAsyncResult asyncResult);

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
        UpdateOtaTaskResponse UpdateOtaTask(UpdateOtaTaskRequest request);

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
        IAsyncResult BeginUpdateOtaTask(UpdateOtaTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOtaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOtaTask.</param>
        /// 
        /// <returns>Returns a  UpdateOtaTaskResult from IoTManagedIntegrations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-managed-integrations-2025-03-03/UpdateOtaTask">REST API Reference for UpdateOtaTask Operation</seealso>
        UpdateOtaTaskResponse EndUpdateOtaTask(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}