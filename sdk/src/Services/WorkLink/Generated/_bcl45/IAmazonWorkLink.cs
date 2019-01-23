/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WorkLink.Model;

namespace Amazon.WorkLink
{
    /// <summary>
    /// Interface for accessing WorkLink
    ///
    /// Amazon WorkLink is a cloud-based service that provides secure access to internal websites
    /// and web apps from iOS phones. In a single step, your users, such as employees, can
    /// access internal websites as efficiently as they access any other public website. They
    /// enter a URL in their web browser, or choose a link to an internal website in an email.
    /// Amazon WorkLink authenticates the user's access and securely renders authorized internal
    /// web content in a secure rendering service in the AWS cloud. Amazon WorkLink doesn't
    /// download or store any internal web content on mobile devices.
    /// </summary>
    public partial interface IAmazonWorkLink : IAmazonService, IDisposable
    {

        
        #region  AssociateWebsiteCertificateAuthority


        /// <summary>
        /// Imports the root certificate of a certificate authority (CA) used to obtain TLS certificates
        /// used by associated websites within the company network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebsiteCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the AssociateWebsiteCertificateAuthority service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateWebsiteCertificateAuthority">REST API Reference for AssociateWebsiteCertificateAuthority Operation</seealso>
        AssociateWebsiteCertificateAuthorityResponse AssociateWebsiteCertificateAuthority(AssociateWebsiteCertificateAuthorityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebsiteCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateWebsiteCertificateAuthority">REST API Reference for AssociateWebsiteCertificateAuthority Operation</seealso>
        Task<AssociateWebsiteCertificateAuthorityResponse> AssociateWebsiteCertificateAuthorityAsync(AssociateWebsiteCertificateAuthorityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFleet


        /// <summary>
        /// Creates a fleet. A fleet consists of resources and the configuration that delivers
        /// associated websites to authorized users who download and set up the Amazon WorkLink
        /// app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        CreateFleetResponse CreateFleet(CreateFleetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFleet


        /// <summary>
        /// Deletes a fleet. Prevents users from accessing previously associated websites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        DeleteFleetResponse DeleteFleet(DeleteFleetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAuditStreamConfiguration


        /// <summary>
        /// Describes the configuration for delivering audit streams to the customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditStreamConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeAuditStreamConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeAuditStreamConfiguration">REST API Reference for DescribeAuditStreamConfiguration Operation</seealso>
        DescribeAuditStreamConfigurationResponse DescribeAuditStreamConfiguration(DescribeAuditStreamConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAuditStreamConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditStreamConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeAuditStreamConfiguration">REST API Reference for DescribeAuditStreamConfiguration Operation</seealso>
        Task<DescribeAuditStreamConfigurationResponse> DescribeAuditStreamConfigurationAsync(DescribeAuditStreamConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCompanyNetworkConfiguration


        /// <summary>
        /// Describes the networking configuration to access the internal websites associated
        /// with the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompanyNetworkConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeCompanyNetworkConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeCompanyNetworkConfiguration">REST API Reference for DescribeCompanyNetworkConfiguration Operation</seealso>
        DescribeCompanyNetworkConfigurationResponse DescribeCompanyNetworkConfiguration(DescribeCompanyNetworkConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCompanyNetworkConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompanyNetworkConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeCompanyNetworkConfiguration">REST API Reference for DescribeCompanyNetworkConfiguration Operation</seealso>
        Task<DescribeCompanyNetworkConfigurationResponse> DescribeCompanyNetworkConfigurationAsync(DescribeCompanyNetworkConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDevice


        /// <summary>
        /// Provides information about a user's device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice service method.</param>
        /// 
        /// <returns>The response from the DescribeDevice service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        Task<DescribeDeviceResponse> DescribeDeviceAsync(DescribeDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDevicePolicyConfiguration


        /// <summary>
        /// Describes the device policy configuration for the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevicePolicyConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeDevicePolicyConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevicePolicyConfiguration">REST API Reference for DescribeDevicePolicyConfiguration Operation</seealso>
        DescribeDevicePolicyConfigurationResponse DescribeDevicePolicyConfiguration(DescribeDevicePolicyConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDevicePolicyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevicePolicyConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevicePolicyConfiguration">REST API Reference for DescribeDevicePolicyConfiguration Operation</seealso>
        Task<DescribeDevicePolicyConfigurationResponse> DescribeDevicePolicyConfigurationAsync(DescribeDevicePolicyConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetMetadata


        /// <summary>
        /// Provides basic information for the specified fleet, excluding identity provider, networking,
        /// and device configuration details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetMetadata service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetMetadata service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeFleetMetadata">REST API Reference for DescribeFleetMetadata Operation</seealso>
        DescribeFleetMetadataResponse DescribeFleetMetadata(DescribeFleetMetadataRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeFleetMetadata">REST API Reference for DescribeFleetMetadata Operation</seealso>
        Task<DescribeFleetMetadataResponse> DescribeFleetMetadataAsync(DescribeFleetMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeIdentityProviderConfiguration


        /// <summary>
        /// Describes the identity provider configuration of the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProviderConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityProviderConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeIdentityProviderConfiguration">REST API Reference for DescribeIdentityProviderConfiguration Operation</seealso>
        DescribeIdentityProviderConfigurationResponse DescribeIdentityProviderConfiguration(DescribeIdentityProviderConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProviderConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeIdentityProviderConfiguration">REST API Reference for DescribeIdentityProviderConfiguration Operation</seealso>
        Task<DescribeIdentityProviderConfigurationResponse> DescribeIdentityProviderConfigurationAsync(DescribeIdentityProviderConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeWebsiteCertificateAuthority


        /// <summary>
        /// Provides information about the certificate authority.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWebsiteCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the DescribeWebsiteCertificateAuthority service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeWebsiteCertificateAuthority">REST API Reference for DescribeWebsiteCertificateAuthority Operation</seealso>
        DescribeWebsiteCertificateAuthorityResponse DescribeWebsiteCertificateAuthority(DescribeWebsiteCertificateAuthorityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWebsiteCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeWebsiteCertificateAuthority">REST API Reference for DescribeWebsiteCertificateAuthority Operation</seealso>
        Task<DescribeWebsiteCertificateAuthorityResponse> DescribeWebsiteCertificateAuthorityAsync(DescribeWebsiteCertificateAuthorityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateWebsiteCertificateAuthority


        /// <summary>
        /// Removes a certificate authority (CA).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebsiteCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the DisassociateWebsiteCertificateAuthority service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateWebsiteCertificateAuthority">REST API Reference for DisassociateWebsiteCertificateAuthority Operation</seealso>
        DisassociateWebsiteCertificateAuthorityResponse DisassociateWebsiteCertificateAuthority(DisassociateWebsiteCertificateAuthorityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebsiteCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateWebsiteCertificateAuthority">REST API Reference for DisassociateWebsiteCertificateAuthority Operation</seealso>
        Task<DisassociateWebsiteCertificateAuthorityResponse> DisassociateWebsiteCertificateAuthorityAsync(DisassociateWebsiteCertificateAuthorityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDevices


        /// <summary>
        /// Retrieves a list of devices registered with the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListDevices">REST API Reference for ListDevices Operation</seealso>
        ListDevicesResponse ListDevices(ListDevicesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListDevices">REST API Reference for ListDevices Operation</seealso>
        Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFleets


        /// <summary>
        /// Retrieves a list of fleets for the current account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListFleets">REST API Reference for ListFleets Operation</seealso>
        ListFleetsResponse ListFleets(ListFleetsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListFleets">REST API Reference for ListFleets Operation</seealso>
        Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWebsiteCertificateAuthorities


        /// <summary>
        /// Retrieves a list of certificate authorities added for the current account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebsiteCertificateAuthorities service method.</param>
        /// 
        /// <returns>The response from the ListWebsiteCertificateAuthorities service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListWebsiteCertificateAuthorities">REST API Reference for ListWebsiteCertificateAuthorities Operation</seealso>
        ListWebsiteCertificateAuthoritiesResponse ListWebsiteCertificateAuthorities(ListWebsiteCertificateAuthoritiesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListWebsiteCertificateAuthorities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWebsiteCertificateAuthorities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListWebsiteCertificateAuthorities">REST API Reference for ListWebsiteCertificateAuthorities Operation</seealso>
        Task<ListWebsiteCertificateAuthoritiesResponse> ListWebsiteCertificateAuthoritiesAsync(ListWebsiteCertificateAuthoritiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SignOutUser


        /// <summary>
        /// Signs the user out from all of their devices. The user can sign in again if they have
        /// valid credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignOutUser service method.</param>
        /// 
        /// <returns>The response from the SignOutUser service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/SignOutUser">REST API Reference for SignOutUser Operation</seealso>
        SignOutUserResponse SignOutUser(SignOutUserRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SignOutUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignOutUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/SignOutUser">REST API Reference for SignOutUser Operation</seealso>
        Task<SignOutUserResponse> SignOutUserAsync(SignOutUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAuditStreamConfiguration


        /// <summary>
        /// Updates the audit stream configuration for the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuditStreamConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateAuditStreamConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateAuditStreamConfiguration">REST API Reference for UpdateAuditStreamConfiguration Operation</seealso>
        UpdateAuditStreamConfigurationResponse UpdateAuditStreamConfiguration(UpdateAuditStreamConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuditStreamConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuditStreamConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateAuditStreamConfiguration">REST API Reference for UpdateAuditStreamConfiguration Operation</seealso>
        Task<UpdateAuditStreamConfigurationResponse> UpdateAuditStreamConfigurationAsync(UpdateAuditStreamConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCompanyNetworkConfiguration


        /// <summary>
        /// Updates the company network configuration for the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCompanyNetworkConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateCompanyNetworkConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateCompanyNetworkConfiguration">REST API Reference for UpdateCompanyNetworkConfiguration Operation</seealso>
        UpdateCompanyNetworkConfigurationResponse UpdateCompanyNetworkConfiguration(UpdateCompanyNetworkConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCompanyNetworkConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCompanyNetworkConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateCompanyNetworkConfiguration">REST API Reference for UpdateCompanyNetworkConfiguration Operation</seealso>
        Task<UpdateCompanyNetworkConfigurationResponse> UpdateCompanyNetworkConfigurationAsync(UpdateCompanyNetworkConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDevicePolicyConfiguration


        /// <summary>
        /// Updates the device policy configuration for the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevicePolicyConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateDevicePolicyConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateDevicePolicyConfiguration">REST API Reference for UpdateDevicePolicyConfiguration Operation</seealso>
        UpdateDevicePolicyConfigurationResponse UpdateDevicePolicyConfiguration(UpdateDevicePolicyConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevicePolicyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevicePolicyConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateDevicePolicyConfiguration">REST API Reference for UpdateDevicePolicyConfiguration Operation</seealso>
        Task<UpdateDevicePolicyConfigurationResponse> UpdateDevicePolicyConfigurationAsync(UpdateDevicePolicyConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFleetMetadata


        /// <summary>
        /// Updates fleet metadata, such as DisplayName.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetMetadata service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateFleetMetadata">REST API Reference for UpdateFleetMetadata Operation</seealso>
        UpdateFleetMetadataResponse UpdateFleetMetadata(UpdateFleetMetadataRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateFleetMetadata">REST API Reference for UpdateFleetMetadata Operation</seealso>
        Task<UpdateFleetMetadataResponse> UpdateFleetMetadataAsync(UpdateFleetMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateIdentityProviderConfiguration


        /// <summary>
        /// Updates the identity provider configuration for the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProviderConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateIdentityProviderConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateIdentityProviderConfiguration">REST API Reference for UpdateIdentityProviderConfiguration Operation</seealso>
        UpdateIdentityProviderConfigurationResponse UpdateIdentityProviderConfiguration(UpdateIdentityProviderConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProviderConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateIdentityProviderConfiguration">REST API Reference for UpdateIdentityProviderConfiguration Operation</seealso>
        Task<UpdateIdentityProviderConfigurationResponse> UpdateIdentityProviderConfigurationAsync(UpdateIdentityProviderConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}