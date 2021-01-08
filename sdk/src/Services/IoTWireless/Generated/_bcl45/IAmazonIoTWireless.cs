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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTWireless.Model;

namespace Amazon.IoTWireless
{
    /// <summary>
    /// Interface for accessing IoTWireless
    ///
    /// AWS IoT Wireless API documentation
    /// </summary>
    public partial interface IAmazonIoTWireless : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTWirelessPaginatorFactory Paginators { get; }

        
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
        AssociateAwsAccountWithPartnerAccountResponse AssociateAwsAccountWithPartnerAccount(AssociateAwsAccountWithPartnerAccountRequest request);



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
        Task<AssociateAwsAccountWithPartnerAccountResponse> AssociateAwsAccountWithPartnerAccountAsync(AssociateAwsAccountWithPartnerAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        AssociateWirelessDeviceWithThingResponse AssociateWirelessDeviceWithThing(AssociateWirelessDeviceWithThingRequest request);



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
        Task<AssociateWirelessDeviceWithThingResponse> AssociateWirelessDeviceWithThingAsync(AssociateWirelessDeviceWithThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        AssociateWirelessGatewayWithCertificateResponse AssociateWirelessGatewayWithCertificate(AssociateWirelessGatewayWithCertificateRequest request);



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
        Task<AssociateWirelessGatewayWithCertificateResponse> AssociateWirelessGatewayWithCertificateAsync(AssociateWirelessGatewayWithCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        AssociateWirelessGatewayWithThingResponse AssociateWirelessGatewayWithThing(AssociateWirelessGatewayWithThingRequest request);



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
        Task<AssociateWirelessGatewayWithThingResponse> AssociateWirelessGatewayWithThingAsync(AssociateWirelessGatewayWithThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateDestinationResponse CreateDestination(CreateDestinationRequest request);



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
        Task<CreateDestinationResponse> CreateDestinationAsync(CreateDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateDeviceProfileResponse CreateDeviceProfile(CreateDeviceProfileRequest request);



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
        Task<CreateDeviceProfileResponse> CreateDeviceProfileAsync(CreateDeviceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateServiceProfileResponse CreateServiceProfile(CreateServiceProfileRequest request);



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
        Task<CreateServiceProfileResponse> CreateServiceProfileAsync(CreateServiceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateWirelessDeviceResponse CreateWirelessDevice(CreateWirelessDeviceRequest request);



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
        Task<CreateWirelessDeviceResponse> CreateWirelessDeviceAsync(CreateWirelessDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateWirelessGatewayResponse CreateWirelessGateway(CreateWirelessGatewayRequest request);



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
        Task<CreateWirelessGatewayResponse> CreateWirelessGatewayAsync(CreateWirelessGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateWirelessGatewayTaskResponse CreateWirelessGatewayTask(CreateWirelessGatewayTaskRequest request);



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
        Task<CreateWirelessGatewayTaskResponse> CreateWirelessGatewayTaskAsync(CreateWirelessGatewayTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateWirelessGatewayTaskDefinitionResponse CreateWirelessGatewayTaskDefinition(CreateWirelessGatewayTaskDefinitionRequest request);



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
        Task<CreateWirelessGatewayTaskDefinitionResponse> CreateWirelessGatewayTaskDefinitionAsync(CreateWirelessGatewayTaskDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request);



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
        Task<DeleteDestinationResponse> DeleteDestinationAsync(DeleteDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteDeviceProfileResponse DeleteDeviceProfile(DeleteDeviceProfileRequest request);



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
        Task<DeleteDeviceProfileResponse> DeleteDeviceProfileAsync(DeleteDeviceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteServiceProfileResponse DeleteServiceProfile(DeleteServiceProfileRequest request);



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
        Task<DeleteServiceProfileResponse> DeleteServiceProfileAsync(DeleteServiceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteWirelessDeviceResponse DeleteWirelessDevice(DeleteWirelessDeviceRequest request);



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
        Task<DeleteWirelessDeviceResponse> DeleteWirelessDeviceAsync(DeleteWirelessDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteWirelessGatewayResponse DeleteWirelessGateway(DeleteWirelessGatewayRequest request);



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
        Task<DeleteWirelessGatewayResponse> DeleteWirelessGatewayAsync(DeleteWirelessGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteWirelessGatewayTaskResponse DeleteWirelessGatewayTask(DeleteWirelessGatewayTaskRequest request);



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
        Task<DeleteWirelessGatewayTaskResponse> DeleteWirelessGatewayTaskAsync(DeleteWirelessGatewayTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteWirelessGatewayTaskDefinitionResponse DeleteWirelessGatewayTaskDefinition(DeleteWirelessGatewayTaskDefinitionRequest request);



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
        Task<DeleteWirelessGatewayTaskDefinitionResponse> DeleteWirelessGatewayTaskDefinitionAsync(DeleteWirelessGatewayTaskDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DisassociateAwsAccountFromPartnerAccountResponse DisassociateAwsAccountFromPartnerAccount(DisassociateAwsAccountFromPartnerAccountRequest request);



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
        Task<DisassociateAwsAccountFromPartnerAccountResponse> DisassociateAwsAccountFromPartnerAccountAsync(DisassociateAwsAccountFromPartnerAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DisassociateWirelessDeviceFromThingResponse DisassociateWirelessDeviceFromThing(DisassociateWirelessDeviceFromThingRequest request);



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
        Task<DisassociateWirelessDeviceFromThingResponse> DisassociateWirelessDeviceFromThingAsync(DisassociateWirelessDeviceFromThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DisassociateWirelessGatewayFromCertificateResponse DisassociateWirelessGatewayFromCertificate(DisassociateWirelessGatewayFromCertificateRequest request);



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
        Task<DisassociateWirelessGatewayFromCertificateResponse> DisassociateWirelessGatewayFromCertificateAsync(DisassociateWirelessGatewayFromCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DisassociateWirelessGatewayFromThingResponse DisassociateWirelessGatewayFromThing(DisassociateWirelessGatewayFromThingRequest request);



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
        Task<DisassociateWirelessGatewayFromThingResponse> DisassociateWirelessGatewayFromThingAsync(DisassociateWirelessGatewayFromThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetDestinationResponse GetDestination(GetDestinationRequest request);



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
        Task<GetDestinationResponse> GetDestinationAsync(GetDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetDeviceProfileResponse GetDeviceProfile(GetDeviceProfileRequest request);



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
        Task<GetDeviceProfileResponse> GetDeviceProfileAsync(GetDeviceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetPartnerAccountResponse GetPartnerAccount(GetPartnerAccountRequest request);



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
        Task<GetPartnerAccountResponse> GetPartnerAccountAsync(GetPartnerAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetServiceEndpointResponse GetServiceEndpoint(GetServiceEndpointRequest request);



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
        Task<GetServiceEndpointResponse> GetServiceEndpointAsync(GetServiceEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetServiceProfileResponse GetServiceProfile(GetServiceProfileRequest request);



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
        Task<GetServiceProfileResponse> GetServiceProfileAsync(GetServiceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetWirelessDeviceResponse GetWirelessDevice(GetWirelessDeviceRequest request);



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
        Task<GetWirelessDeviceResponse> GetWirelessDeviceAsync(GetWirelessDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetWirelessDeviceStatisticsResponse GetWirelessDeviceStatistics(GetWirelessDeviceStatisticsRequest request);



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
        Task<GetWirelessDeviceStatisticsResponse> GetWirelessDeviceStatisticsAsync(GetWirelessDeviceStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetWirelessGatewayResponse GetWirelessGateway(GetWirelessGatewayRequest request);



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
        Task<GetWirelessGatewayResponse> GetWirelessGatewayAsync(GetWirelessGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetWirelessGatewayCertificateResponse GetWirelessGatewayCertificate(GetWirelessGatewayCertificateRequest request);



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
        Task<GetWirelessGatewayCertificateResponse> GetWirelessGatewayCertificateAsync(GetWirelessGatewayCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetWirelessGatewayFirmwareInformationResponse GetWirelessGatewayFirmwareInformation(GetWirelessGatewayFirmwareInformationRequest request);



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
        Task<GetWirelessGatewayFirmwareInformationResponse> GetWirelessGatewayFirmwareInformationAsync(GetWirelessGatewayFirmwareInformationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetWirelessGatewayStatisticsResponse GetWirelessGatewayStatistics(GetWirelessGatewayStatisticsRequest request);



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
        Task<GetWirelessGatewayStatisticsResponse> GetWirelessGatewayStatisticsAsync(GetWirelessGatewayStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetWirelessGatewayTaskResponse GetWirelessGatewayTask(GetWirelessGatewayTaskRequest request);



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
        Task<GetWirelessGatewayTaskResponse> GetWirelessGatewayTaskAsync(GetWirelessGatewayTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetWirelessGatewayTaskDefinitionResponse GetWirelessGatewayTaskDefinition(GetWirelessGatewayTaskDefinitionRequest request);



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
        Task<GetWirelessGatewayTaskDefinitionResponse> GetWirelessGatewayTaskDefinitionAsync(GetWirelessGatewayTaskDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListDestinationsResponse ListDestinations(ListDestinationsRequest request);



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
        Task<ListDestinationsResponse> ListDestinationsAsync(ListDestinationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListDeviceProfilesResponse ListDeviceProfiles(ListDeviceProfilesRequest request);



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
        Task<ListDeviceProfilesResponse> ListDeviceProfilesAsync(ListDeviceProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListPartnerAccountsResponse ListPartnerAccounts(ListPartnerAccountsRequest request);



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
        Task<ListPartnerAccountsResponse> ListPartnerAccountsAsync(ListPartnerAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListServiceProfilesResponse ListServiceProfiles(ListServiceProfilesRequest request);



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
        Task<ListServiceProfilesResponse> ListServiceProfilesAsync(ListServiceProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListWirelessDevicesResponse ListWirelessDevices(ListWirelessDevicesRequest request);



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
        Task<ListWirelessDevicesResponse> ListWirelessDevicesAsync(ListWirelessDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListWirelessGatewaysResponse ListWirelessGateways(ListWirelessGatewaysRequest request);



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
        Task<ListWirelessGatewaysResponse> ListWirelessGatewaysAsync(ListWirelessGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListWirelessGatewayTaskDefinitionsResponse ListWirelessGatewayTaskDefinitions(ListWirelessGatewayTaskDefinitionsRequest request);



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
        Task<ListWirelessGatewayTaskDefinitionsResponse> ListWirelessGatewayTaskDefinitionsAsync(ListWirelessGatewayTaskDefinitionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        SendDataToWirelessDeviceResponse SendDataToWirelessDevice(SendDataToWirelessDeviceRequest request);



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
        Task<SendDataToWirelessDeviceResponse> SendDataToWirelessDeviceAsync(SendDataToWirelessDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        TagResourceResponse TagResource(TagResourceRequest request);



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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        TestWirelessDeviceResponse TestWirelessDevice(TestWirelessDeviceRequest request);



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
        Task<TestWirelessDeviceResponse> TestWirelessDeviceAsync(TestWirelessDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UntagResourceResponse UntagResource(UntagResourceRequest request);



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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateDestinationResponse UpdateDestination(UpdateDestinationRequest request);



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
        Task<UpdateDestinationResponse> UpdateDestinationAsync(UpdateDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdatePartnerAccountResponse UpdatePartnerAccount(UpdatePartnerAccountRequest request);



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
        Task<UpdatePartnerAccountResponse> UpdatePartnerAccountAsync(UpdatePartnerAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateWirelessDeviceResponse UpdateWirelessDevice(UpdateWirelessDeviceRequest request);



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
        Task<UpdateWirelessDeviceResponse> UpdateWirelessDeviceAsync(UpdateWirelessDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateWirelessGatewayResponse UpdateWirelessGateway(UpdateWirelessGatewayRequest request);



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
        Task<UpdateWirelessGatewayResponse> UpdateWirelessGatewayAsync(UpdateWirelessGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}