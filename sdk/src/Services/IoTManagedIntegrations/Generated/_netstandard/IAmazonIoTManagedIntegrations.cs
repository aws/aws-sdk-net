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
using System.Threading;
using System.Threading.Tasks;
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
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTManagedIntegrationsPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateCredentialLocker



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
        Task<CreateCredentialLockerResponse> CreateCredentialLockerAsync(CreateCredentialLockerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDestination



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
        Task<CreateDestinationResponse> CreateDestinationAsync(CreateDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEventLogConfiguration



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
        Task<CreateEventLogConfigurationResponse> CreateEventLogConfigurationAsync(CreateEventLogConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateManagedThing



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
        Task<CreateManagedThingResponse> CreateManagedThingAsync(CreateManagedThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNotificationConfiguration



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
        Task<CreateNotificationConfigurationResponse> CreateNotificationConfigurationAsync(CreateNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateOtaTask



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
        Task<CreateOtaTaskResponse> CreateOtaTaskAsync(CreateOtaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateOtaTaskConfiguration



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
        Task<CreateOtaTaskConfigurationResponse> CreateOtaTaskConfigurationAsync(CreateOtaTaskConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProvisioningProfile



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
        Task<CreateProvisioningProfileResponse> CreateProvisioningProfileAsync(CreateProvisioningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DeleteCredentialLockerResponse> DeleteCredentialLockerAsync(DeleteCredentialLockerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDestination



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
        Task<DeleteDestinationResponse> DeleteDestinationAsync(DeleteDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEventLogConfiguration



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
        Task<DeleteEventLogConfigurationResponse> DeleteEventLogConfigurationAsync(DeleteEventLogConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteManagedThing



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
        Task<DeleteManagedThingResponse> DeleteManagedThingAsync(DeleteManagedThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNotificationConfiguration



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
        Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteOtaTask



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
        Task<DeleteOtaTaskResponse> DeleteOtaTaskAsync(DeleteOtaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteOtaTaskConfiguration



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
        Task<DeleteOtaTaskConfigurationResponse> DeleteOtaTaskConfigurationAsync(DeleteOtaTaskConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProvisioningProfile



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
        Task<DeleteProvisioningProfileResponse> DeleteProvisioningProfileAsync(DeleteProvisioningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCredentialLocker



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
        Task<GetCredentialLockerResponse> GetCredentialLockerAsync(GetCredentialLockerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCustomEndpoint



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
        Task<GetCustomEndpointResponse> GetCustomEndpointAsync(GetCustomEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDefaultEncryptionConfiguration



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
        Task<GetDefaultEncryptionConfigurationResponse> GetDefaultEncryptionConfigurationAsync(GetDefaultEncryptionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDestination



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
        Task<GetDestinationResponse> GetDestinationAsync(GetDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDeviceDiscovery



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
        Task<GetDeviceDiscoveryResponse> GetDeviceDiscoveryAsync(GetDeviceDiscoveryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEventLogConfiguration



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
        Task<GetEventLogConfigurationResponse> GetEventLogConfigurationAsync(GetEventLogConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHubConfiguration



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
        Task<GetHubConfigurationResponse> GetHubConfigurationAsync(GetHubConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetManagedThing



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
        Task<GetManagedThingResponse> GetManagedThingAsync(GetManagedThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetManagedThingCapabilities



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
        Task<GetManagedThingCapabilitiesResponse> GetManagedThingCapabilitiesAsync(GetManagedThingCapabilitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetManagedThingConnectivityData



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
        Task<GetManagedThingConnectivityDataResponse> GetManagedThingConnectivityDataAsync(GetManagedThingConnectivityDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetManagedThingMetaData



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
        Task<GetManagedThingMetaDataResponse> GetManagedThingMetaDataAsync(GetManagedThingMetaDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetManagedThingState



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
        Task<GetManagedThingStateResponse> GetManagedThingStateAsync(GetManagedThingStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetNotificationConfiguration



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
        Task<GetNotificationConfigurationResponse> GetNotificationConfigurationAsync(GetNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetOtaTask



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
        Task<GetOtaTaskResponse> GetOtaTaskAsync(GetOtaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetOtaTaskConfiguration



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
        Task<GetOtaTaskConfigurationResponse> GetOtaTaskConfigurationAsync(GetOtaTaskConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProvisioningProfile



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
        Task<GetProvisioningProfileResponse> GetProvisioningProfileAsync(GetProvisioningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRuntimeLogConfiguration



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
        Task<GetRuntimeLogConfigurationResponse> GetRuntimeLogConfigurationAsync(GetRuntimeLogConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSchemaVersion



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
        Task<GetSchemaVersionResponse> GetSchemaVersionAsync(GetSchemaVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCredentialLockers



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
        Task<ListCredentialLockersResponse> ListCredentialLockersAsync(ListCredentialLockersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDestinations



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
        Task<ListDestinationsResponse> ListDestinationsAsync(ListDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEventLogConfigurations



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
        Task<ListEventLogConfigurationsResponse> ListEventLogConfigurationsAsync(ListEventLogConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListManagedThings



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
        Task<ListManagedThingsResponse> ListManagedThingsAsync(ListManagedThingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListManagedThingSchemas



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
        Task<ListManagedThingSchemasResponse> ListManagedThingSchemasAsync(ListManagedThingSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotificationConfigurations



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
        Task<ListNotificationConfigurationsResponse> ListNotificationConfigurationsAsync(ListNotificationConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListOtaTaskConfigurations



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
        Task<ListOtaTaskConfigurationsResponse> ListOtaTaskConfigurationsAsync(ListOtaTaskConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListOtaTaskExecutions



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
        Task<ListOtaTaskExecutionsResponse> ListOtaTaskExecutionsAsync(ListOtaTaskExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListOtaTasks



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
        Task<ListOtaTasksResponse> ListOtaTasksAsync(ListOtaTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProvisioningProfiles



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
        Task<ListProvisioningProfilesResponse> ListProvisioningProfilesAsync(ListProvisioningProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSchemaVersions



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
        Task<ListSchemaVersionsResponse> ListSchemaVersionsAsync(ListSchemaVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutDefaultEncryptionConfiguration



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
        Task<PutDefaultEncryptionConfigurationResponse> PutDefaultEncryptionConfigurationAsync(PutDefaultEncryptionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutHubConfiguration



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
        Task<PutHubConfigurationResponse> PutHubConfigurationAsync(PutHubConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutRuntimeLogConfiguration



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
        Task<PutRuntimeLogConfigurationResponse> PutRuntimeLogConfigurationAsync(PutRuntimeLogConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterCustomEndpoint



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
        Task<RegisterCustomEndpointResponse> RegisterCustomEndpointAsync(RegisterCustomEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetRuntimeLogConfiguration



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
        Task<ResetRuntimeLogConfigurationResponse> ResetRuntimeLogConfigurationAsync(ResetRuntimeLogConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendManagedThingCommand



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
        Task<SendManagedThingCommandResponse> SendManagedThingCommandAsync(SendManagedThingCommandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDeviceDiscovery



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
        Task<StartDeviceDiscoveryResponse> StartDeviceDiscoveryAsync(StartDeviceDiscoveryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDestination



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
        Task<UpdateDestinationResponse> UpdateDestinationAsync(UpdateDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEventLogConfiguration



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
        Task<UpdateEventLogConfigurationResponse> UpdateEventLogConfigurationAsync(UpdateEventLogConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateManagedThing



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
        Task<UpdateManagedThingResponse> UpdateManagedThingAsync(UpdateManagedThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateNotificationConfiguration



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
        Task<UpdateNotificationConfigurationResponse> UpdateNotificationConfigurationAsync(UpdateNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateOtaTask



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
        Task<UpdateOtaTaskResponse> UpdateOtaTaskAsync(UpdateOtaTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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