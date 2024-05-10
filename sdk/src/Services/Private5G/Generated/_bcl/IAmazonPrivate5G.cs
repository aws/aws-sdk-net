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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Private5G.Model;

#pragma warning disable CS1570
namespace Amazon.Private5G
{
    /// <summary>
    /// <para>Interface for accessing Private5G</para>
    ///
    /// Amazon Web Services Private 5G is a managed service that makes it easy to deploy,
    /// operate, and scale your own private mobile network at your on-premises location. Private
    /// 5G provides the pre-configured hardware and software for mobile networks, helps automate
    /// setup, and scales capacity on demand to support additional devices as needed.
    /// </summary>
    public partial interface IAmazonPrivate5G : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPrivate5GPaginatorFactory Paginators { get; }

        
        #region  AcknowledgeOrderReceipt


        /// <summary>
        /// Acknowledges that the specified network order was received.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeOrderReceipt service method.</param>
        /// 
        /// <returns>The response from the AcknowledgeOrderReceipt service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/AcknowledgeOrderReceipt">REST API Reference for AcknowledgeOrderReceipt Operation</seealso>
        AcknowledgeOrderReceiptResponse AcknowledgeOrderReceipt(AcknowledgeOrderReceiptRequest request);



        /// <summary>
        /// Acknowledges that the specified network order was received.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeOrderReceipt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcknowledgeOrderReceipt service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/AcknowledgeOrderReceipt">REST API Reference for AcknowledgeOrderReceipt Operation</seealso>
        Task<AcknowledgeOrderReceiptResponse> AcknowledgeOrderReceiptAsync(AcknowledgeOrderReceiptRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ActivateDeviceIdentifier


        /// <summary>
        /// Activates the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateDeviceIdentifier service method.</param>
        /// 
        /// <returns>The response from the ActivateDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ActivateDeviceIdentifier">REST API Reference for ActivateDeviceIdentifier Operation</seealso>
        ActivateDeviceIdentifierResponse ActivateDeviceIdentifier(ActivateDeviceIdentifierRequest request);



        /// <summary>
        /// Activates the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateDeviceIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ActivateDeviceIdentifier">REST API Reference for ActivateDeviceIdentifier Operation</seealso>
        Task<ActivateDeviceIdentifierResponse> ActivateDeviceIdentifierAsync(ActivateDeviceIdentifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ActivateNetworkSite


        /// <summary>
        /// Activates the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateNetworkSite service method.</param>
        /// 
        /// <returns>The response from the ActivateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ActivateNetworkSite">REST API Reference for ActivateNetworkSite Operation</seealso>
        ActivateNetworkSiteResponse ActivateNetworkSite(ActivateNetworkSiteRequest request);



        /// <summary>
        /// Activates the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateNetworkSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ActivateNetworkSite">REST API Reference for ActivateNetworkSite Operation</seealso>
        Task<ActivateNetworkSiteResponse> ActivateNetworkSiteAsync(ActivateNetworkSiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ConfigureAccessPoint


        /// <summary>
        /// Configures the specified network resource. 
        /// 
        ///  
        /// <para>
        ///  Use this action to specify the geographic position of the hardware. You must provide
        /// Certified Professional Installer (CPI) credentials in the request so that we can obtain
        /// spectrum grants. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/radio-units.html">Radio
        /// units</a> in the <i>Amazon Web Services Private 5G User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureAccessPoint service method.</param>
        /// 
        /// <returns>The response from the ConfigureAccessPoint service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ConfigureAccessPoint">REST API Reference for ConfigureAccessPoint Operation</seealso>
        ConfigureAccessPointResponse ConfigureAccessPoint(ConfigureAccessPointRequest request);



        /// <summary>
        /// Configures the specified network resource. 
        /// 
        ///  
        /// <para>
        ///  Use this action to specify the geographic position of the hardware. You must provide
        /// Certified Professional Installer (CPI) credentials in the request so that we can obtain
        /// spectrum grants. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/radio-units.html">Radio
        /// units</a> in the <i>Amazon Web Services Private 5G User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfigureAccessPoint service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ConfigureAccessPoint">REST API Reference for ConfigureAccessPoint Operation</seealso>
        Task<ConfigureAccessPointResponse> ConfigureAccessPointAsync(ConfigureAccessPointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateNetwork


        /// <summary>
        /// Creates a network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork service method.</param>
        /// 
        /// <returns>The response from the CreateNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.LimitExceededException">
        /// The limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        CreateNetworkResponse CreateNetwork(CreateNetworkRequest request);



        /// <summary>
        /// Creates a network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.LimitExceededException">
        /// The limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        Task<CreateNetworkResponse> CreateNetworkAsync(CreateNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateNetworkSite


        /// <summary>
        /// Creates a network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkSite service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/CreateNetworkSite">REST API Reference for CreateNetworkSite Operation</seealso>
        CreateNetworkSiteResponse CreateNetworkSite(CreateNetworkSiteRequest request);



        /// <summary>
        /// Creates a network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/CreateNetworkSite">REST API Reference for CreateNetworkSite Operation</seealso>
        Task<CreateNetworkSiteResponse> CreateNetworkSiteAsync(CreateNetworkSiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeactivateDeviceIdentifier


        /// <summary>
        /// Deactivates the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateDeviceIdentifier service method.</param>
        /// 
        /// <returns>The response from the DeactivateDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeactivateDeviceIdentifier">REST API Reference for DeactivateDeviceIdentifier Operation</seealso>
        DeactivateDeviceIdentifierResponse DeactivateDeviceIdentifier(DeactivateDeviceIdentifierRequest request);



        /// <summary>
        /// Deactivates the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateDeviceIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeactivateDeviceIdentifier">REST API Reference for DeactivateDeviceIdentifier Operation</seealso>
        Task<DeactivateDeviceIdentifierResponse> DeactivateDeviceIdentifierAsync(DeactivateDeviceIdentifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteNetwork


        /// <summary>
        /// Deletes the specified network. You must delete network sites before you delete the
        /// network. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/APIReference/API_DeleteNetworkSite.html">DeleteNetworkSite</a>
        /// in the <i>API Reference for Amazon Web Services Private 5G</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetwork service method.</param>
        /// 
        /// <returns>The response from the DeleteNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        DeleteNetworkResponse DeleteNetwork(DeleteNetworkRequest request);



        /// <summary>
        /// Deletes the specified network. You must delete network sites before you delete the
        /// network. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/APIReference/API_DeleteNetworkSite.html">DeleteNetworkSite</a>
        /// in the <i>API Reference for Amazon Web Services Private 5G</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        Task<DeleteNetworkResponse> DeleteNetworkAsync(DeleteNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteNetworkSite


        /// <summary>
        /// Deletes the specified network site. Return the hardware after you delete the network
        /// site. You are responsible for minimum charges. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/hardware-maintenance.html">Hardware
        /// returns</a> in the <i>Amazon Web Services Private 5G User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkSite service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeleteNetworkSite">REST API Reference for DeleteNetworkSite Operation</seealso>
        DeleteNetworkSiteResponse DeleteNetworkSite(DeleteNetworkSiteRequest request);



        /// <summary>
        /// Deletes the specified network site. Return the hardware after you delete the network
        /// site. You are responsible for minimum charges. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/hardware-maintenance.html">Hardware
        /// returns</a> in the <i>Amazon Web Services Private 5G User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeleteNetworkSite">REST API Reference for DeleteNetworkSite Operation</seealso>
        Task<DeleteNetworkSiteResponse> DeleteNetworkSiteAsync(DeleteNetworkSiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDeviceIdentifier


        /// <summary>
        /// Gets the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceIdentifier service method.</param>
        /// 
        /// <returns>The response from the GetDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetDeviceIdentifier">REST API Reference for GetDeviceIdentifier Operation</seealso>
        GetDeviceIdentifierResponse GetDeviceIdentifier(GetDeviceIdentifierRequest request);



        /// <summary>
        /// Gets the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetDeviceIdentifier">REST API Reference for GetDeviceIdentifier Operation</seealso>
        Task<GetDeviceIdentifierResponse> GetDeviceIdentifierAsync(GetDeviceIdentifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetNetwork


        /// <summary>
        /// Gets the specified network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork service method.</param>
        /// 
        /// <returns>The response from the GetNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        GetNetworkResponse GetNetwork(GetNetworkRequest request);



        /// <summary>
        /// Gets the specified network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        Task<GetNetworkResponse> GetNetworkAsync(GetNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetNetworkResource


        /// <summary>
        /// Gets the specified network resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResource service method.</param>
        /// 
        /// <returns>The response from the GetNetworkResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetworkResource">REST API Reference for GetNetworkResource Operation</seealso>
        GetNetworkResourceResponse GetNetworkResource(GetNetworkResourceRequest request);



        /// <summary>
        /// Gets the specified network resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetworkResource">REST API Reference for GetNetworkResource Operation</seealso>
        Task<GetNetworkResourceResponse> GetNetworkResourceAsync(GetNetworkResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetNetworkSite


        /// <summary>
        /// Gets the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSite service method.</param>
        /// 
        /// <returns>The response from the GetNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetworkSite">REST API Reference for GetNetworkSite Operation</seealso>
        GetNetworkSiteResponse GetNetworkSite(GetNetworkSiteRequest request);



        /// <summary>
        /// Gets the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetworkSite">REST API Reference for GetNetworkSite Operation</seealso>
        Task<GetNetworkSiteResponse> GetNetworkSiteAsync(GetNetworkSiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOrder


        /// <summary>
        /// Gets the specified order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrder service method.</param>
        /// 
        /// <returns>The response from the GetOrder service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetOrder">REST API Reference for GetOrder Operation</seealso>
        GetOrderResponse GetOrder(GetOrderRequest request);



        /// <summary>
        /// Gets the specified order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOrder service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetOrder">REST API Reference for GetOrder Operation</seealso>
        Task<GetOrderResponse> GetOrderAsync(GetOrderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDeviceIdentifiers


        /// <summary>
        /// Lists device identifiers. Add filters to your request to return a more specific list
        /// of results. Use filters to match the Amazon Resource Name (ARN) of an order, the status
        /// of device identifiers, or the ARN of the traffic group.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceIdentifiers service method.</param>
        /// 
        /// <returns>The response from the ListDeviceIdentifiers service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListDeviceIdentifiers">REST API Reference for ListDeviceIdentifiers Operation</seealso>
        ListDeviceIdentifiersResponse ListDeviceIdentifiers(ListDeviceIdentifiersRequest request);



        /// <summary>
        /// Lists device identifiers. Add filters to your request to return a more specific list
        /// of results. Use filters to match the Amazon Resource Name (ARN) of an order, the status
        /// of device identifiers, or the ARN of the traffic group.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceIdentifiers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeviceIdentifiers service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListDeviceIdentifiers">REST API Reference for ListDeviceIdentifiers Operation</seealso>
        Task<ListDeviceIdentifiersResponse> ListDeviceIdentifiersAsync(ListDeviceIdentifiersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListNetworkResources


        /// <summary>
        /// Lists network resources. Add filters to your request to return a more specific list
        /// of results. Use filters to match the Amazon Resource Name (ARN) of an order or the
        /// status of network resources.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkResources service method.</param>
        /// 
        /// <returns>The response from the ListNetworkResources service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworkResources">REST API Reference for ListNetworkResources Operation</seealso>
        ListNetworkResourcesResponse ListNetworkResources(ListNetworkResourcesRequest request);



        /// <summary>
        /// Lists network resources. Add filters to your request to return a more specific list
        /// of results. Use filters to match the Amazon Resource Name (ARN) of an order or the
        /// status of network resources.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNetworkResources service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworkResources">REST API Reference for ListNetworkResources Operation</seealso>
        Task<ListNetworkResourcesResponse> ListNetworkResourcesAsync(ListNetworkResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListNetworks


        /// <summary>
        /// Lists networks. Add filters to your request to return a more specific list of results.
        /// Use filters to match the status of the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks service method.</param>
        /// 
        /// <returns>The response from the ListNetworks service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        ListNetworksResponse ListNetworks(ListNetworksRequest request);



        /// <summary>
        /// Lists networks. Add filters to your request to return a more specific list of results.
        /// Use filters to match the status of the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNetworks service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        Task<ListNetworksResponse> ListNetworksAsync(ListNetworksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListNetworkSites


        /// <summary>
        /// Lists network sites. Add filters to your request to return a more specific list of
        /// results. Use filters to match the status of the network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkSites service method.</param>
        /// 
        /// <returns>The response from the ListNetworkSites service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworkSites">REST API Reference for ListNetworkSites Operation</seealso>
        ListNetworkSitesResponse ListNetworkSites(ListNetworkSitesRequest request);



        /// <summary>
        /// Lists network sites. Add filters to your request to return a more specific list of
        /// results. Use filters to match the status of the network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkSites service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNetworkSites service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworkSites">REST API Reference for ListNetworkSites Operation</seealso>
        Task<ListNetworkSitesResponse> ListNetworkSitesAsync(ListNetworkSitesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOrders


        /// <summary>
        /// Lists orders. Add filters to your request to return a more specific list of results.
        /// Use filters to match the Amazon Resource Name (ARN) of the network site or the status
        /// of the order.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrders service method.</param>
        /// 
        /// <returns>The response from the ListOrders service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListOrders">REST API Reference for ListOrders Operation</seealso>
        ListOrdersResponse ListOrders(ListOrdersRequest request);



        /// <summary>
        /// Lists orders. Add filters to your request to return a more specific list of results.
        /// Use filters to match the Amazon Resource Name (ARN) of the network site or the status
        /// of the order.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrders service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListOrders">REST API Reference for ListOrders Operation</seealso>
        Task<ListOrdersResponse> ListOrdersAsync(ListOrdersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Ping


        /// <summary>
        /// Checks the health of the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Ping service method.</param>
        /// 
        /// <returns>The response from the Ping service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/Ping">REST API Reference for Ping Operation</seealso>
        PingResponse Ping(PingRequest request);



        /// <summary>
        /// Checks the health of the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Ping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Ping service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/Ping">REST API Reference for Ping Operation</seealso>
        Task<PingResponse> PingAsync(PingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartNetworkResourceUpdate


        /// <summary>
        /// Use this action to do the following tasks:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Update the duration and renewal status of the commitment period for a radio unit.
        /// The update goes into effect immediately.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Request a replacement for a network resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Request that you return a network resource.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After you submit a request to replace or return a network resource, the status of
        /// the network resource changes to <c>CREATING_SHIPPING_LABEL</c>. The shipping label
        /// is available when the status of the network resource is <c>PENDING_RETURN</c>. After
        /// the network resource is successfully returned, its status changes to <c>DELETED</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/radio-units.html#return-radio-unit">Return
        /// a radio unit</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkResourceUpdate service method.</param>
        /// 
        /// <returns>The response from the StartNetworkResourceUpdate service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/StartNetworkResourceUpdate">REST API Reference for StartNetworkResourceUpdate Operation</seealso>
        StartNetworkResourceUpdateResponse StartNetworkResourceUpdate(StartNetworkResourceUpdateRequest request);



        /// <summary>
        /// Use this action to do the following tasks:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Update the duration and renewal status of the commitment period for a radio unit.
        /// The update goes into effect immediately.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Request a replacement for a network resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Request that you return a network resource.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After you submit a request to replace or return a network resource, the status of
        /// the network resource changes to <c>CREATING_SHIPPING_LABEL</c>. The shipping label
        /// is available when the status of the network resource is <c>PENDING_RETURN</c>. After
        /// the network resource is successfully returned, its status changes to <c>DELETED</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/radio-units.html#return-radio-unit">Return
        /// a radio unit</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkResourceUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartNetworkResourceUpdate service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/StartNetworkResourceUpdate">REST API Reference for StartNetworkResourceUpdate Operation</seealso>
        Task<StartNetworkResourceUpdateResponse> StartNetworkResourceUpdateAsync(StartNetworkResourceUpdateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateNetworkSite


        /// <summary>
        /// Updates the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSite service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UpdateNetworkSite">REST API Reference for UpdateNetworkSite Operation</seealso>
        UpdateNetworkSiteResponse UpdateNetworkSite(UpdateNetworkSiteRequest request);



        /// <summary>
        /// Updates the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UpdateNetworkSite">REST API Reference for UpdateNetworkSite Operation</seealso>
        Task<UpdateNetworkSiteResponse> UpdateNetworkSiteAsync(UpdateNetworkSiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateNetworkSitePlan


        /// <summary>
        /// Updates the specified network site plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSitePlan service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkSitePlan service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UpdateNetworkSitePlan">REST API Reference for UpdateNetworkSitePlan Operation</seealso>
        UpdateNetworkSitePlanResponse UpdateNetworkSitePlan(UpdateNetworkSitePlanRequest request);



        /// <summary>
        /// Updates the specified network site plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSitePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNetworkSitePlan service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UpdateNetworkSitePlan">REST API Reference for UpdateNetworkSitePlan Operation</seealso>
        Task<UpdateNetworkSitePlanResponse> UpdateNetworkSitePlanAsync(UpdateNetworkSitePlanRequest request, CancellationToken cancellationToken = default(CancellationToken));

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