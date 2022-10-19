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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WorkSpacesWeb.Model;

namespace Amazon.WorkSpacesWeb
{
    /// <summary>
    /// Interface for accessing WorkSpacesWeb
    ///
    /// WorkSpaces Web is a low cost, fully managed WorkSpace built specifically to facilitate
    /// secure, web-based workloads. WorkSpaces Web makes it easy for customers to safely
    /// provide their employees with access to internal websites and SaaS web applications
    /// without the administrative burden of appliances or specialized client software. WorkSpaces
    /// Web provides simple policy tools tailored for user interactions, while offloading
    /// common tasks like capacity management, scaling, and maintaining browser images.
    /// </summary>
    public partial interface IAmazonWorkSpacesWeb : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IWorkSpacesWebPaginatorFactory Paginators { get; }

        
        #region  AssociateBrowserSettings


        /// <summary>
        /// Associates a browser settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateBrowserSettings">REST API Reference for AssociateBrowserSettings Operation</seealso>
        AssociateBrowserSettingsResponse AssociateBrowserSettings(AssociateBrowserSettingsRequest request);



        /// <summary>
        /// Associates a browser settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBrowserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateBrowserSettings">REST API Reference for AssociateBrowserSettings Operation</seealso>
        Task<AssociateBrowserSettingsResponse> AssociateBrowserSettingsAsync(AssociateBrowserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateNetworkSettings


        /// <summary>
        /// Associates a network settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateNetworkSettings">REST API Reference for AssociateNetworkSettings Operation</seealso>
        AssociateNetworkSettingsResponse AssociateNetworkSettings(AssociateNetworkSettingsRequest request);



        /// <summary>
        /// Associates a network settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateNetworkSettings">REST API Reference for AssociateNetworkSettings Operation</seealso>
        Task<AssociateNetworkSettingsResponse> AssociateNetworkSettingsAsync(AssociateNetworkSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateTrustStore


        /// <summary>
        /// Associates a trust store with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrustStore service method.</param>
        /// 
        /// <returns>The response from the AssociateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateTrustStore">REST API Reference for AssociateTrustStore Operation</seealso>
        AssociateTrustStoreResponse AssociateTrustStore(AssociateTrustStoreRequest request);



        /// <summary>
        /// Associates a trust store with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrustStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateTrustStore">REST API Reference for AssociateTrustStore Operation</seealso>
        Task<AssociateTrustStoreResponse> AssociateTrustStoreAsync(AssociateTrustStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateUserAccessLoggingSettings


        /// <summary>
        /// Associates a user access logging settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserAccessLoggingSettings">REST API Reference for AssociateUserAccessLoggingSettings Operation</seealso>
        AssociateUserAccessLoggingSettingsResponse AssociateUserAccessLoggingSettings(AssociateUserAccessLoggingSettingsRequest request);



        /// <summary>
        /// Associates a user access logging settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateUserAccessLoggingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserAccessLoggingSettings">REST API Reference for AssociateUserAccessLoggingSettings Operation</seealso>
        Task<AssociateUserAccessLoggingSettingsResponse> AssociateUserAccessLoggingSettingsAsync(AssociateUserAccessLoggingSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateUserSettings


        /// <summary>
        /// Associates a user settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateUserSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserSettings">REST API Reference for AssociateUserSettings Operation</seealso>
        AssociateUserSettingsResponse AssociateUserSettings(AssociateUserSettingsRequest request);



        /// <summary>
        /// Associates a user settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserSettings">REST API Reference for AssociateUserSettings Operation</seealso>
        Task<AssociateUserSettingsResponse> AssociateUserSettingsAsync(AssociateUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBrowserSettings


        /// <summary>
        /// Creates a browser settings resource that can be associated with a web portal. Once
        /// associated with a web portal, browser settings control how the browser will behave
        /// once a user starts a streaming session for the web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the CreateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateBrowserSettings">REST API Reference for CreateBrowserSettings Operation</seealso>
        CreateBrowserSettingsResponse CreateBrowserSettings(CreateBrowserSettingsRequest request);



        /// <summary>
        /// Creates a browser settings resource that can be associated with a web portal. Once
        /// associated with a web portal, browser settings control how the browser will behave
        /// once a user starts a streaming session for the web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrowserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateBrowserSettings">REST API Reference for CreateBrowserSettings Operation</seealso>
        Task<CreateBrowserSettingsResponse> CreateBrowserSettingsAsync(CreateBrowserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateIdentityProvider


        /// <summary>
        /// Creates an identity provider resource that is then associated with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the CreateIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        CreateIdentityProviderResponse CreateIdentityProvider(CreateIdentityProviderRequest request);



        /// <summary>
        /// Creates an identity provider resource that is then associated with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        Task<CreateIdentityProviderResponse> CreateIdentityProviderAsync(CreateIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateNetworkSettings


        /// <summary>
        /// Creates a network settings resource that can be associated with a web portal. Once
        /// associated with a web portal, network settings define how streaming instances will
        /// connect with your specified VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateNetworkSettings">REST API Reference for CreateNetworkSettings Operation</seealso>
        CreateNetworkSettingsResponse CreateNetworkSettings(CreateNetworkSettingsRequest request);



        /// <summary>
        /// Creates a network settings resource that can be associated with a web portal. Once
        /// associated with a web portal, network settings define how streaming instances will
        /// connect with your specified VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateNetworkSettings">REST API Reference for CreateNetworkSettings Operation</seealso>
        Task<CreateNetworkSettingsResponse> CreateNetworkSettingsAsync(CreateNetworkSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePortal


        /// <summary>
        /// Creates a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// 
        /// <returns>The response from the CreatePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        CreatePortalResponse CreatePortal(CreatePortalRequest request);



        /// <summary>
        /// Creates a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        Task<CreatePortalResponse> CreatePortalAsync(CreatePortalRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTrustStore


        /// <summary>
        /// Creates a trust store that can be associated with a web portal. A trust store contains
        /// certificate authority (CA) certificates. Once associated with a web portal, the browser
        /// in a streaming session will recognize certificates that have been issued using any
        /// of the CAs in the trust store. If your organization has internal websites that use
        /// certificates issued by private CAs, you should add the private CA certificate to the
        /// trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustStore service method.</param>
        /// 
        /// <returns>The response from the CreateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        CreateTrustStoreResponse CreateTrustStore(CreateTrustStoreRequest request);



        /// <summary>
        /// Creates a trust store that can be associated with a web portal. A trust store contains
        /// certificate authority (CA) certificates. Once associated with a web portal, the browser
        /// in a streaming session will recognize certificates that have been issued using any
        /// of the CAs in the trust store. If your organization has internal websites that use
        /// certificates issued by private CAs, you should add the private CA certificate to the
        /// trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        Task<CreateTrustStoreResponse> CreateTrustStoreAsync(CreateTrustStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUserAccessLoggingSettings


        /// <summary>
        /// Creates a user access logging settings resource that can be associated with a web
        /// portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the CreateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserAccessLoggingSettings">REST API Reference for CreateUserAccessLoggingSettings Operation</seealso>
        CreateUserAccessLoggingSettingsResponse CreateUserAccessLoggingSettings(CreateUserAccessLoggingSettingsRequest request);



        /// <summary>
        /// Creates a user access logging settings resource that can be associated with a web
        /// portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserAccessLoggingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserAccessLoggingSettings">REST API Reference for CreateUserAccessLoggingSettings Operation</seealso>
        Task<CreateUserAccessLoggingSettingsResponse> CreateUserAccessLoggingSettingsAsync(CreateUserAccessLoggingSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUserSettings


        /// <summary>
        /// Creates a user settings resource that can be associated with a web portal. Once associated
        /// with a web portal, user settings control how users can transfer data between a streaming
        /// session and the their local devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserSettings service method.</param>
        /// 
        /// <returns>The response from the CreateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserSettings">REST API Reference for CreateUserSettings Operation</seealso>
        CreateUserSettingsResponse CreateUserSettings(CreateUserSettingsRequest request);



        /// <summary>
        /// Creates a user settings resource that can be associated with a web portal. Once associated
        /// with a web portal, user settings control how users can transfer data between a streaming
        /// session and the their local devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserSettings">REST API Reference for CreateUserSettings Operation</seealso>
        Task<CreateUserSettingsResponse> CreateUserSettingsAsync(CreateUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBrowserSettings


        /// <summary>
        /// Deletes browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteBrowserSettings">REST API Reference for DeleteBrowserSettings Operation</seealso>
        DeleteBrowserSettingsResponse DeleteBrowserSettings(DeleteBrowserSettingsRequest request);



        /// <summary>
        /// Deletes browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrowserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteBrowserSettings">REST API Reference for DeleteBrowserSettings Operation</seealso>
        Task<DeleteBrowserSettingsResponse> DeleteBrowserSettingsAsync(DeleteBrowserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIdentityProvider


        /// <summary>
        /// Deletes the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        DeleteIdentityProviderResponse DeleteIdentityProvider(DeleteIdentityProviderRequest request);



        /// <summary>
        /// Deletes the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        Task<DeleteIdentityProviderResponse> DeleteIdentityProviderAsync(DeleteIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteNetworkSettings


        /// <summary>
        /// Deletes network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteNetworkSettings">REST API Reference for DeleteNetworkSettings Operation</seealso>
        DeleteNetworkSettingsResponse DeleteNetworkSettings(DeleteNetworkSettingsRequest request);



        /// <summary>
        /// Deletes network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteNetworkSettings">REST API Reference for DeleteNetworkSettings Operation</seealso>
        Task<DeleteNetworkSettingsResponse> DeleteNetworkSettingsAsync(DeleteNetworkSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePortal


        /// <summary>
        /// Deletes a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// 
        /// <returns>The response from the DeletePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        DeletePortalResponse DeletePortal(DeletePortalRequest request);



        /// <summary>
        /// Deletes a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        Task<DeletePortalResponse> DeletePortalAsync(DeletePortalRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTrustStore


        /// <summary>
        /// Deletes the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustStore service method.</param>
        /// 
        /// <returns>The response from the DeleteTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        DeleteTrustStoreResponse DeleteTrustStore(DeleteTrustStoreRequest request);



        /// <summary>
        /// Deletes the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        Task<DeleteTrustStoreResponse> DeleteTrustStoreAsync(DeleteTrustStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserAccessLoggingSettings


        /// <summary>
        /// Deletes user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserAccessLoggingSettings">REST API Reference for DeleteUserAccessLoggingSettings Operation</seealso>
        DeleteUserAccessLoggingSettingsResponse DeleteUserAccessLoggingSettings(DeleteUserAccessLoggingSettingsRequest request);



        /// <summary>
        /// Deletes user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAccessLoggingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserAccessLoggingSettings">REST API Reference for DeleteUserAccessLoggingSettings Operation</seealso>
        Task<DeleteUserAccessLoggingSettingsResponse> DeleteUserAccessLoggingSettingsAsync(DeleteUserAccessLoggingSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserSettings


        /// <summary>
        /// Deletes user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserSettings">REST API Reference for DeleteUserSettings Operation</seealso>
        DeleteUserSettingsResponse DeleteUserSettings(DeleteUserSettingsRequest request);



        /// <summary>
        /// Deletes user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserSettings">REST API Reference for DeleteUserSettings Operation</seealso>
        Task<DeleteUserSettingsResponse> DeleteUserSettingsAsync(DeleteUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateBrowserSettings


        /// <summary>
        /// Disassociates browser settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateBrowserSettings">REST API Reference for DisassociateBrowserSettings Operation</seealso>
        DisassociateBrowserSettingsResponse DisassociateBrowserSettings(DisassociateBrowserSettingsRequest request);



        /// <summary>
        /// Disassociates browser settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBrowserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateBrowserSettings">REST API Reference for DisassociateBrowserSettings Operation</seealso>
        Task<DisassociateBrowserSettingsResponse> DisassociateBrowserSettingsAsync(DisassociateBrowserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateNetworkSettings


        /// <summary>
        /// Disassociates network settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateNetworkSettings">REST API Reference for DisassociateNetworkSettings Operation</seealso>
        DisassociateNetworkSettingsResponse DisassociateNetworkSettings(DisassociateNetworkSettingsRequest request);



        /// <summary>
        /// Disassociates network settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateNetworkSettings">REST API Reference for DisassociateNetworkSettings Operation</seealso>
        Task<DisassociateNetworkSettingsResponse> DisassociateNetworkSettingsAsync(DisassociateNetworkSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateTrustStore


        /// <summary>
        /// Disassociates a trust store from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrustStore service method.</param>
        /// 
        /// <returns>The response from the DisassociateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateTrustStore">REST API Reference for DisassociateTrustStore Operation</seealso>
        DisassociateTrustStoreResponse DisassociateTrustStore(DisassociateTrustStoreRequest request);



        /// <summary>
        /// Disassociates a trust store from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrustStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateTrustStore">REST API Reference for DisassociateTrustStore Operation</seealso>
        Task<DisassociateTrustStoreResponse> DisassociateTrustStoreAsync(DisassociateTrustStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateUserAccessLoggingSettings


        /// <summary>
        /// Disassociates user access logging settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserAccessLoggingSettings">REST API Reference for DisassociateUserAccessLoggingSettings Operation</seealso>
        DisassociateUserAccessLoggingSettingsResponse DisassociateUserAccessLoggingSettings(DisassociateUserAccessLoggingSettingsRequest request);



        /// <summary>
        /// Disassociates user access logging settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUserAccessLoggingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserAccessLoggingSettings">REST API Reference for DisassociateUserAccessLoggingSettings Operation</seealso>
        Task<DisassociateUserAccessLoggingSettingsResponse> DisassociateUserAccessLoggingSettingsAsync(DisassociateUserAccessLoggingSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateUserSettings


        /// <summary>
        /// Disassociates user settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUserSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserSettings">REST API Reference for DisassociateUserSettings Operation</seealso>
        DisassociateUserSettingsResponse DisassociateUserSettings(DisassociateUserSettingsRequest request);



        /// <summary>
        /// Disassociates user settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserSettings">REST API Reference for DisassociateUserSettings Operation</seealso>
        Task<DisassociateUserSettingsResponse> DisassociateUserSettingsAsync(DisassociateUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBrowserSettings


        /// <summary>
        /// Gets browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the GetBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetBrowserSettings">REST API Reference for GetBrowserSettings Operation</seealso>
        GetBrowserSettingsResponse GetBrowserSettings(GetBrowserSettingsRequest request);



        /// <summary>
        /// Gets browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrowserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetBrowserSettings">REST API Reference for GetBrowserSettings Operation</seealso>
        Task<GetBrowserSettingsResponse> GetBrowserSettingsAsync(GetBrowserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIdentityProvider


        /// <summary>
        /// Gets the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the GetIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIdentityProvider">REST API Reference for GetIdentityProvider Operation</seealso>
        GetIdentityProviderResponse GetIdentityProvider(GetIdentityProviderRequest request);



        /// <summary>
        /// Gets the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIdentityProvider">REST API Reference for GetIdentityProvider Operation</seealso>
        Task<GetIdentityProviderResponse> GetIdentityProviderAsync(GetIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetNetworkSettings


        /// <summary>
        /// Gets the network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the GetNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetNetworkSettings">REST API Reference for GetNetworkSettings Operation</seealso>
        GetNetworkSettingsResponse GetNetworkSettings(GetNetworkSettingsRequest request);



        /// <summary>
        /// Gets the network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetNetworkSettings">REST API Reference for GetNetworkSettings Operation</seealso>
        Task<GetNetworkSettingsResponse> GetNetworkSettingsAsync(GetNetworkSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPortal


        /// <summary>
        /// Gets the web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortal service method.</param>
        /// 
        /// <returns>The response from the GetPortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortal">REST API Reference for GetPortal Operation</seealso>
        GetPortalResponse GetPortal(GetPortalRequest request);



        /// <summary>
        /// Gets the web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortal">REST API Reference for GetPortal Operation</seealso>
        Task<GetPortalResponse> GetPortalAsync(GetPortalRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPortalServiceProviderMetadata


        /// <summary>
        /// Gets the service provider metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortalServiceProviderMetadata service method.</param>
        /// 
        /// <returns>The response from the GetPortalServiceProviderMetadata service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortalServiceProviderMetadata">REST API Reference for GetPortalServiceProviderMetadata Operation</seealso>
        GetPortalServiceProviderMetadataResponse GetPortalServiceProviderMetadata(GetPortalServiceProviderMetadataRequest request);



        /// <summary>
        /// Gets the service provider metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortalServiceProviderMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPortalServiceProviderMetadata service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortalServiceProviderMetadata">REST API Reference for GetPortalServiceProviderMetadata Operation</seealso>
        Task<GetPortalServiceProviderMetadataResponse> GetPortalServiceProviderMetadataAsync(GetPortalServiceProviderMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTrustStore


        /// <summary>
        /// Gets the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStore service method.</param>
        /// 
        /// <returns>The response from the GetTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStore">REST API Reference for GetTrustStore Operation</seealso>
        GetTrustStoreResponse GetTrustStore(GetTrustStoreRequest request);



        /// <summary>
        /// Gets the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStore">REST API Reference for GetTrustStore Operation</seealso>
        Task<GetTrustStoreResponse> GetTrustStoreAsync(GetTrustStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTrustStoreCertificate


        /// <summary>
        /// Gets the trust store certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStoreCertificate service method.</param>
        /// 
        /// <returns>The response from the GetTrustStoreCertificate service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStoreCertificate">REST API Reference for GetTrustStoreCertificate Operation</seealso>
        GetTrustStoreCertificateResponse GetTrustStoreCertificate(GetTrustStoreCertificateRequest request);



        /// <summary>
        /// Gets the trust store certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStoreCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrustStoreCertificate service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStoreCertificate">REST API Reference for GetTrustStoreCertificate Operation</seealso>
        Task<GetTrustStoreCertificateResponse> GetTrustStoreCertificateAsync(GetTrustStoreCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUserAccessLoggingSettings


        /// <summary>
        /// Gets user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the GetUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserAccessLoggingSettings">REST API Reference for GetUserAccessLoggingSettings Operation</seealso>
        GetUserAccessLoggingSettingsResponse GetUserAccessLoggingSettings(GetUserAccessLoggingSettingsRequest request);



        /// <summary>
        /// Gets user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserAccessLoggingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserAccessLoggingSettings">REST API Reference for GetUserAccessLoggingSettings Operation</seealso>
        Task<GetUserAccessLoggingSettingsResponse> GetUserAccessLoggingSettingsAsync(GetUserAccessLoggingSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUserSettings


        /// <summary>
        /// Gets user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserSettings service method.</param>
        /// 
        /// <returns>The response from the GetUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        GetUserSettingsResponse GetUserSettings(GetUserSettingsRequest request);



        /// <summary>
        /// Gets user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        Task<GetUserSettingsResponse> GetUserSettingsAsync(GetUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBrowserSettings


        /// <summary>
        /// Retrieves a list of browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the ListBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListBrowserSettings">REST API Reference for ListBrowserSettings Operation</seealso>
        ListBrowserSettingsResponse ListBrowserSettings(ListBrowserSettingsRequest request);



        /// <summary>
        /// Retrieves a list of browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrowserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListBrowserSettings">REST API Reference for ListBrowserSettings Operation</seealso>
        Task<ListBrowserSettingsResponse> ListBrowserSettingsAsync(ListBrowserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIdentityProviders


        /// <summary>
        /// Retrieves a list of identity providers for a specific web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders service method.</param>
        /// 
        /// <returns>The response from the ListIdentityProviders service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request);



        /// <summary>
        /// Retrieves a list of identity providers for a specific web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentityProviders service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        Task<ListIdentityProvidersResponse> ListIdentityProvidersAsync(ListIdentityProvidersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListNetworkSettings


        /// <summary>
        /// Retrieves a list of network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the ListNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListNetworkSettings">REST API Reference for ListNetworkSettings Operation</seealso>
        ListNetworkSettingsResponse ListNetworkSettings(ListNetworkSettingsRequest request);



        /// <summary>
        /// Retrieves a list of network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListNetworkSettings">REST API Reference for ListNetworkSettings Operation</seealso>
        Task<ListNetworkSettingsResponse> ListNetworkSettingsAsync(ListNetworkSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPortals


        /// <summary>
        /// Retrieves a list or web portals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// 
        /// <returns>The response from the ListPortals service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListPortals">REST API Reference for ListPortals Operation</seealso>
        ListPortalsResponse ListPortals(ListPortalsRequest request);



        /// <summary>
        /// Retrieves a list or web portals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPortals service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListPortals">REST API Reference for ListPortals Operation</seealso>
        Task<ListPortalsResponse> ListPortalsAsync(ListPortalsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Retrieves a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTrustStoreCertificates


        /// <summary>
        /// Retrieves a list of trust store certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStoreCertificates service method.</param>
        /// 
        /// <returns>The response from the ListTrustStoreCertificates service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStoreCertificates">REST API Reference for ListTrustStoreCertificates Operation</seealso>
        ListTrustStoreCertificatesResponse ListTrustStoreCertificates(ListTrustStoreCertificatesRequest request);



        /// <summary>
        /// Retrieves a list of trust store certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStoreCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrustStoreCertificates service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStoreCertificates">REST API Reference for ListTrustStoreCertificates Operation</seealso>
        Task<ListTrustStoreCertificatesResponse> ListTrustStoreCertificatesAsync(ListTrustStoreCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTrustStores


        /// <summary>
        /// Retrieves a list of trust stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStores service method.</param>
        /// 
        /// <returns>The response from the ListTrustStores service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStores">REST API Reference for ListTrustStores Operation</seealso>
        ListTrustStoresResponse ListTrustStores(ListTrustStoresRequest request);



        /// <summary>
        /// Retrieves a list of trust stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrustStores service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStores">REST API Reference for ListTrustStores Operation</seealso>
        Task<ListTrustStoresResponse> ListTrustStoresAsync(ListTrustStoresRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUserAccessLoggingSettings


        /// <summary>
        /// Retrieves a list of user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the ListUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserAccessLoggingSettings">REST API Reference for ListUserAccessLoggingSettings Operation</seealso>
        ListUserAccessLoggingSettingsResponse ListUserAccessLoggingSettings(ListUserAccessLoggingSettingsRequest request);



        /// <summary>
        /// Retrieves a list of user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserAccessLoggingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserAccessLoggingSettings">REST API Reference for ListUserAccessLoggingSettings Operation</seealso>
        Task<ListUserAccessLoggingSettingsResponse> ListUserAccessLoggingSettingsAsync(ListUserAccessLoggingSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUserSettings


        /// <summary>
        /// Retrieves a list of user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserSettings service method.</param>
        /// 
        /// <returns>The response from the ListUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserSettings">REST API Reference for ListUserSettings Operation</seealso>
        ListUserSettingsResponse ListUserSettings(ListUserSettingsRequest request);



        /// <summary>
        /// Retrieves a list of user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserSettings">REST API Reference for ListUserSettings Operation</seealso>
        Task<ListUserSettingsResponse> ListUserSettingsAsync(ListUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or overwrites one or more tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.TooManyTagsException">
        /// There are too many tags.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds or overwrites one or more tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.TooManyTagsException">
        /// There are too many tags.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBrowserSettings


        /// <summary>
        /// Updates browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateBrowserSettings">REST API Reference for UpdateBrowserSettings Operation</seealso>
        UpdateBrowserSettingsResponse UpdateBrowserSettings(UpdateBrowserSettingsRequest request);



        /// <summary>
        /// Updates browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrowserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateBrowserSettings">REST API Reference for UpdateBrowserSettings Operation</seealso>
        Task<UpdateBrowserSettingsResponse> UpdateBrowserSettingsAsync(UpdateBrowserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateIdentityProvider


        /// <summary>
        /// Updates the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        UpdateIdentityProviderResponse UpdateIdentityProvider(UpdateIdentityProviderRequest request);



        /// <summary>
        /// Updates the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        Task<UpdateIdentityProviderResponse> UpdateIdentityProviderAsync(UpdateIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateNetworkSettings


        /// <summary>
        /// Updates network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateNetworkSettings">REST API Reference for UpdateNetworkSettings Operation</seealso>
        UpdateNetworkSettingsResponse UpdateNetworkSettings(UpdateNetworkSettingsRequest request);



        /// <summary>
        /// Updates network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateNetworkSettings">REST API Reference for UpdateNetworkSettings Operation</seealso>
        Task<UpdateNetworkSettingsResponse> UpdateNetworkSettingsAsync(UpdateNetworkSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePortal


        /// <summary>
        /// Updates a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// 
        /// <returns>The response from the UpdatePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        UpdatePortalResponse UpdatePortal(UpdatePortalRequest request);



        /// <summary>
        /// Updates a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        Task<UpdatePortalResponse> UpdatePortalAsync(UpdatePortalRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTrustStore


        /// <summary>
        /// Updates the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustStore service method.</param>
        /// 
        /// <returns>The response from the UpdateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateTrustStore">REST API Reference for UpdateTrustStore Operation</seealso>
        UpdateTrustStoreResponse UpdateTrustStore(UpdateTrustStoreRequest request);



        /// <summary>
        /// Updates the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateTrustStore">REST API Reference for UpdateTrustStore Operation</seealso>
        Task<UpdateTrustStoreResponse> UpdateTrustStoreAsync(UpdateTrustStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserAccessLoggingSettings


        /// <summary>
        /// Updates the user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserAccessLoggingSettings">REST API Reference for UpdateUserAccessLoggingSettings Operation</seealso>
        UpdateUserAccessLoggingSettingsResponse UpdateUserAccessLoggingSettings(UpdateUserAccessLoggingSettingsRequest request);



        /// <summary>
        /// Updates the user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAccessLoggingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserAccessLoggingSettings">REST API Reference for UpdateUserAccessLoggingSettings Operation</seealso>
        Task<UpdateUserAccessLoggingSettingsResponse> UpdateUserAccessLoggingSettingsAsync(UpdateUserAccessLoggingSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserSettings


        /// <summary>
        /// Updates the user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        UpdateUserSettingsResponse UpdateUserSettings(UpdateUserSettingsRequest request);



        /// <summary>
        /// Updates the user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        Task<UpdateUserSettingsResponse> UpdateUserSettingsAsync(UpdateUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}