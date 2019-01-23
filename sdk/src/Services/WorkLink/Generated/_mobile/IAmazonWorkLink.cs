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
        /// Initiates the asynchronous execution of the AssociateWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebsiteCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateWebsiteCertificateAuthority">REST API Reference for AssociateWebsiteCertificateAuthority Operation</seealso>
        Task<AssociateWebsiteCertificateAuthorityResponse> AssociateWebsiteCertificateAuthorityAsync(AssociateWebsiteCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFleet


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
        Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFleet


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
        Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAuditStreamConfiguration


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
        Task<DescribeAuditStreamConfigurationResponse> DescribeAuditStreamConfigurationAsync(DescribeAuditStreamConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCompanyNetworkConfiguration


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
        Task<DescribeCompanyNetworkConfigurationResponse> DescribeCompanyNetworkConfigurationAsync(DescribeCompanyNetworkConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDevice


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
        Task<DescribeDeviceResponse> DescribeDeviceAsync(DescribeDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDevicePolicyConfiguration


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
        Task<DescribeDevicePolicyConfigurationResponse> DescribeDevicePolicyConfigurationAsync(DescribeDevicePolicyConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFleetMetadata


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
        Task<DescribeFleetMetadataResponse> DescribeFleetMetadataAsync(DescribeFleetMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIdentityProviderConfiguration


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
        Task<DescribeIdentityProviderConfigurationResponse> DescribeIdentityProviderConfigurationAsync(DescribeIdentityProviderConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWebsiteCertificateAuthority


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
        Task<DescribeWebsiteCertificateAuthorityResponse> DescribeWebsiteCertificateAuthorityAsync(DescribeWebsiteCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateWebsiteCertificateAuthority


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
        Task<DisassociateWebsiteCertificateAuthorityResponse> DisassociateWebsiteCertificateAuthorityAsync(DisassociateWebsiteCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDevices


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
        Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFleets


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
        Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWebsiteCertificateAuthorities


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
        Task<ListWebsiteCertificateAuthoritiesResponse> ListWebsiteCertificateAuthoritiesAsync(ListWebsiteCertificateAuthoritiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SignOutUser


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
        Task<SignOutUserResponse> SignOutUserAsync(SignOutUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAuditStreamConfiguration


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
        Task<UpdateAuditStreamConfigurationResponse> UpdateAuditStreamConfigurationAsync(UpdateAuditStreamConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCompanyNetworkConfiguration


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
        Task<UpdateCompanyNetworkConfigurationResponse> UpdateCompanyNetworkConfigurationAsync(UpdateCompanyNetworkConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDevicePolicyConfiguration


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
        Task<UpdateDevicePolicyConfigurationResponse> UpdateDevicePolicyConfigurationAsync(UpdateDevicePolicyConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFleetMetadata


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
        Task<UpdateFleetMetadataResponse> UpdateFleetMetadataAsync(UpdateFleetMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIdentityProviderConfiguration


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
        Task<UpdateIdentityProviderConfigurationResponse> UpdateIdentityProviderConfigurationAsync(UpdateIdentityProviderConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}