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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudWatchOmni.Model;

#pragma warning disable CS1570
namespace Amazon.CloudWatchOmni
{
    /// <summary>
    /// <para>Interface for accessing CloudWatchOmni</para>
    ///
    /// CloudWatch Omni is a unified observability experience built on Amazon CloudWatch.
    /// You work in a space, an isolated environment that holds your telemetry and controls
    /// who can access it, and your data is stored in the CloudWatch Dataset for correlated
    /// analysis of logs, metrics, and traces.
    /// </summary>
    public partial interface IAmazonCloudWatchOmni : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICloudWatchOmniPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateAccessGrant



        /// <summary>
        /// Creates an AccessGrant that authorizes a principal to perform a set of actions on
        /// resources in a space.
        /// 
        ///  
        /// <para>
        /// Optionally narrow the grant with scoped actions that limit it to specific resources
        /// and fields. Use ListAccessGrants and GetAccessGrant to retrieve grants, and DeleteAccessGrant
        /// to remove them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessGrant service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateAccessGrant">REST API Reference for CreateAccessGrant Operation</seealso>
        Task<CreateAccessGrantResponse> CreateAccessGrantAsync(CreateAccessGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAccessProfile



        /// <summary>
        /// Creates an access profile in a space.
        /// 
        ///  
        /// <para>
        /// Use GetAccessProfile and ListAccessProfiles to retrieve profiles, and UpdateAccessProfile
        /// to modify one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessProfile service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateAccessProfile">REST API Reference for CreateAccessProfile Operation</seealso>
        Task<CreateAccessProfileResponse> CreateAccessProfileAsync(CreateAccessProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAlert



        /// <summary>
        /// Creates a new alert within a space.
        /// 
        ///  
        /// <para>
        /// Use GetAlert and ListAlerts to retrieve alerts, UpdateAlert to modify one, and DeleteAlert
        /// to remove it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlert service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateAlert">REST API Reference for CreateAlert Operation</seealso>
        Task<CreateAlertResponse> CreateAlertAsync(CreateAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDomain



        /// <summary>
        /// Creates a domain with identity provider configuration.
        /// 
        ///  
        /// <para>
        /// Use GetDomain to retrieve the domain, UpdateDomain to change its configuration, and
        /// CreateSpace to add spaces within it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDomainAccessGrantForOrganization



        /// <summary>
        /// Creates an AccessGrant that authorizes a principal to administer an organization domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainAccessGrantForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomainAccessGrantForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateDomainAccessGrantForOrganization">REST API Reference for CreateDomainAccessGrantForOrganization Operation</seealso>
        Task<CreateDomainAccessGrantForOrganizationResponse> CreateDomainAccessGrantForOrganizationAsync(CreateDomainAccessGrantForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDomainForOrganization



        /// <summary>
        /// Creates an organization-scoped domain for the caller's AWS Organization. Only the
        /// organization's management account can call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomainForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateDomainForOrganization">REST API Reference for CreateDomainForOrganization Operation</seealso>
        Task<CreateDomainForOrganizationResponse> CreateDomainForOrganizationAsync(CreateDomainForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIntegration



        /// <summary>
        /// Creates an integration with a third-party provider. Returns the integration identifier
        /// and its initial status; when the provider requires interactive consent, an authorization
        /// URL is returned for the user to complete setup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIntegration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        Task<CreateIntegrationResponse> CreateIntegrationAsync(CreateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateOmniDashboard



        /// <summary>
        /// Creates a new dashboard within a space.
        /// 
        ///  
        /// <para>
        /// Use GetOmniDashboard and ListOmniDashboards to retrieve dashboards, UpdateOmniDashboard
        /// to modify one, and DeleteOmniDashboard to remove it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOmniDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOmniDashboard service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateOmniDashboard">REST API Reference for CreateOmniDashboard Operation</seealso>
        Task<CreateOmniDashboardResponse> CreateOmniDashboardAsync(CreateOmniDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateOneTimeDeepLinkCode



        /// <summary>
        /// Generates a one-time code for deep-link authentication.
        /// 
        ///  
        /// <para>
        /// Direct the user's browser to the returned deepLinkUrl before it expires. The code
        /// is exchanged for an authenticated, domain-scoped session and can be used only once.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOneTimeDeepLinkCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOneTimeDeepLinkCode service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateOneTimeDeepLinkCode">REST API Reference for CreateOneTimeDeepLinkCode Operation</seealso>
        Task<CreateOneTimeDeepLinkCodeResponse> CreateOneTimeDeepLinkCodeAsync(CreateOneTimeDeepLinkCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSpace



        /// <summary>
        /// Creates a space in a domain.
        /// 
        ///  
        /// <para>
        /// Use GetSpace to retrieve the space, ListSpaces to enumerate spaces, UpdateSpace to
        /// modify it, and DeleteSpace to remove it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSpace service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateSpace">REST API Reference for CreateSpace Operation</seealso>
        Task<CreateSpaceResponse> CreateSpaceAsync(CreateSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateView



        /// <summary>
        /// Creates a new SQL view.
        /// 
        ///  
        /// <para>
        /// A view is a named, reusable SQL query that can be referenced from telemetry queries.
        /// View names must be unique within the account and region. Only USER views can be created
        /// — MANAGED views are provisioned by AWS.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateView service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateView">REST API Reference for CreateView Operation</seealso>
        Task<CreateViewResponse> CreateViewAsync(CreateViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccessGrant



        /// <summary>
        /// Removes an existing AccessGrant, revoking the access it granted.
        /// 
        ///  
        /// <para>
        /// A service-managed grant cannot be deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessGrant service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteAccessGrant">REST API Reference for DeleteAccessGrant Operation</seealso>
        Task<DeleteAccessGrantResponse> DeleteAccessGrantAsync(DeleteAccessGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccessProfile



        /// <summary>
        /// Removes an access profile.
        /// 
        ///  
        /// <para>
        /// An access profile cannot be deleted while access grants reference it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessProfile service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteAccessProfile">REST API Reference for DeleteAccessProfile Operation</seealso>
        Task<DeleteAccessProfileResponse> DeleteAccessProfileAsync(DeleteAccessProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAlert



        /// <summary>
        /// Deletes an alert by its identifier.
        /// 
        ///  
        /// <para>
        /// Idempotent: deleting an alert that has already been removed succeeds without error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlert service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteAlert">REST API Reference for DeleteAlert Operation</seealso>
        Task<DeleteAlertResponse> DeleteAlertAsync(DeleteAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDomain



        /// <summary>
        /// Removes a domain and all of its resources. Call this operation in the Region where
        /// the domain was created.
        /// 
        ///  
        /// <para>
        /// A domain cannot be deleted while it contains spaces.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDomainAccessGrantForOrganization



        /// <summary>
        /// Removes an existing organization access grant, revoking the access it granted.
        /// 
        ///  
        /// <para>
        /// A service-managed grant cannot be deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainAccessGrantForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomainAccessGrantForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteDomainAccessGrantForOrganization">REST API Reference for DeleteDomainAccessGrantForOrganization Operation</seealso>
        Task<DeleteDomainAccessGrantForOrganizationResponse> DeleteDomainAccessGrantForOrganizationAsync(DeleteDomainAccessGrantForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDomainForOrganization



        /// <summary>
        /// Removes an organization domain and all of its resources. Call this operation in the
        /// Region where the domain was created.
        /// 
        ///  
        /// <para>
        /// A domain cannot be deleted while it contains spaces.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomainForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteDomainForOrganization">REST API Reference for DeleteDomainForOrganization Operation</seealso>
        Task<DeleteDomainForOrganizationResponse> DeleteDomainForOrganizationAsync(DeleteDomainForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIntegration



        /// <summary>
        /// Deletes an integration. Returns the resulting status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteOmniDashboard



        /// <summary>
        /// Removes a dashboard from a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOmniDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOmniDashboard service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteOmniDashboard">REST API Reference for DeleteOmniDashboard Operation</seealso>
        Task<DeleteOmniDashboardResponse> DeleteOmniDashboardAsync(DeleteOmniDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSpace



        /// <summary>
        /// Removes a space and all of its resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSpace service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        Task<DeleteSpaceResponse> DeleteSpaceAsync(DeleteSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteView



        /// <summary>
        /// Deletes the specified view.
        /// 
        ///  
        /// <para>
        /// Queries that reference the view fail after it is deleted. Managed views cannot be
        /// deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteView service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteView">REST API Reference for DeleteView Operation</seealso>
        Task<DeleteViewResponse> DeleteViewAsync(DeleteViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccessGrant



        /// <summary>
        /// Retrieves the full detail of a single AccessGrant by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessGrant service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetAccessGrant">REST API Reference for GetAccessGrant Operation</seealso>
        Task<GetAccessGrantResponse> GetAccessGrantAsync(GetAccessGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccessProfile



        /// <summary>
        /// Retrieves an access profile by ID.
        /// 
        ///  
        /// <para>
        /// The response indicates whether the calling principal is currently allowed to assume
        /// the profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessProfile service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetAccessProfile">REST API Reference for GetAccessProfile Operation</seealso>
        Task<GetAccessProfileResponse> GetAccessProfileAsync(GetAccessProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAlert



        /// <summary>
        /// Retrieves a single alert by its identifier.
        /// 
        ///  
        /// <para>
        /// Use ListAlerts to enumerate alerts in the space.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAlert service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetAlert">REST API Reference for GetAlert Operation</seealso>
        Task<GetAlertResponse> GetAlertAsync(GetAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetContextGraph



        /// <summary>
        /// Queries the context graph with filtering, traversal, and pagination support.
        /// 
        ///  
        /// <para>
        /// Pagination note: nodes and edges are returned together as a coherent subgraph. Pagination
        /// cursors advance over nodes (the primary collection); each page includes all edges
        /// connecting nodes within that page. Callers should treat nodes as the paginated collection
        /// and edges as supplementary relationship data attached to those nodes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContextGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContextGraph service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetContextGraph">REST API Reference for GetContextGraph Operation</seealso>
        Task<GetContextGraphResponse> GetContextGraphAsync(GetContextGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDomain



        /// <summary>
        /// Retrieves the details of a domain by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetDomain">REST API Reference for GetDomain Operation</seealso>
        Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDomainAccessGrantForOrganization



        /// <summary>
        /// Retrieves the full detail of a single organization access grant by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainAccessGrantForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainAccessGrantForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetDomainAccessGrantForOrganization">REST API Reference for GetDomainAccessGrantForOrganization Operation</seealso>
        Task<GetDomainAccessGrantForOrganizationResponse> GetDomainAccessGrantForOrganizationAsync(GetDomainAccessGrantForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDomainForOrganization



        /// <summary>
        /// Retrieves the details of an organization domain by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetDomainForOrganization">REST API Reference for GetDomainForOrganization Operation</seealso>
        Task<GetDomainForOrganizationResponse> GetDomainForOrganizationAsync(GetDomainForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIntegration



        /// <summary>
        /// Returns the details of a single integration, identified by its identifier, Amazon
        /// Resource Name, or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIntelligenceConfiguration



        /// <summary>
        /// Retrieves the intelligence configuration for the calling account. Account is identified
        /// via FAS (caller identity). Returns the default configuration if none exists yet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntelligenceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntelligenceConfiguration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetIntelligenceConfiguration">REST API Reference for GetIntelligenceConfiguration Operation</seealso>
        Task<GetIntelligenceConfigurationResponse> GetIntelligenceConfigurationAsync(GetIntelligenceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetOmniDashboard



        /// <summary>
        /// Retrieves a dashboard by ID within a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOmniDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOmniDashboard service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetOmniDashboard">REST API Reference for GetOmniDashboard Operation</seealso>
        Task<GetOmniDashboardResponse> GetOmniDashboardAsync(GetOmniDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSpace



        /// <summary>
        /// Retrieves the details of a space by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSpace service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetSpace">REST API Reference for GetSpace Operation</seealso>
        Task<GetSpaceResponse> GetSpaceAsync(GetSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSpaceCredentialsForOrganization



        /// <summary>
        /// Returns temporary credentials for a space in an organization member account. The credentials
        /// are valid for one hour.
        /// 
        ///  
        /// <para>
        /// The caller must be the organization's management account or a delegated administrator
        /// with access to the target space. The target account must be an active member of the
        /// same organization as the domain, and the space must already exist.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpaceCredentialsForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSpaceCredentialsForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetSpaceCredentialsForOrganization">REST API Reference for GetSpaceCredentialsForOrganization Operation</seealso>
        Task<GetSpaceCredentialsForOrganizationResponse> GetSpaceCredentialsForOrganizationAsync(GetSpaceCredentialsForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTelemetryQueryResults



        /// <summary>
        /// Returns the results for the specified query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryQueryResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTelemetryQueryResults service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetTelemetryQueryResults">REST API Reference for GetTelemetryQueryResults Operation</seealso>
        Task<GetTelemetryQueryResultsResponse> GetTelemetryQueryResultsAsync(GetTelemetryQueryResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetView



        /// <summary>
        /// Returns the definition and metadata of the specified view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetView service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetView">REST API Reference for GetView Operation</seealso>
        Task<GetViewResponse> GetViewAsync(GetViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccessGrants



        /// <summary>
        /// Returns AccessGrants, with optional filtering by domain, space, principal, or permission.
        /// A grant is returned only when it matches every filter supplied. With no filters, returns
        /// the grants for the current account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessGrants service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListAccessGrants">REST API Reference for ListAccessGrants Operation</seealso>
        Task<ListAccessGrantsResponse> ListAccessGrantsAsync(ListAccessGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccessProfiles



        /// <summary>
        /// Returns the access profiles in a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessProfiles service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListAccessProfiles">REST API Reference for ListAccessProfiles Operation</seealso>
        Task<ListAccessProfilesResponse> ListAccessProfilesAsync(ListAccessProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAlerts



        /// <summary>
        /// Lists alerts within a space, optionally filtered by exact name(s), a single name prefix,
        /// or exact alertId(s), with pagination.
        /// 
        ///  
        /// <para>
        /// Use GetAlert to retrieve a single alert's full detail.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAlerts service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        Task<ListAlertsResponse> ListAlertsAsync(ListAlertsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDomainAccessGrantsForOrganization



        /// <summary>
        /// Returns organization-level domain access grants, with optional filtering by domain,
        /// principal, or permission. A grant is returned only when it matches every filter supplied.
        /// With no filters, returns the grants for the caller's organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainAccessGrantsForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainAccessGrantsForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListDomainAccessGrantsForOrganization">REST API Reference for ListDomainAccessGrantsForOrganization Operation</seealso>
        Task<ListDomainAccessGrantsForOrganizationResponse> ListDomainAccessGrantsForOrganizationAsync(ListDomainAccessGrantsForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDomains



        /// <summary>
        /// Returns the caller's domains: the account-scoped domain and the organization-scoped
        /// domain, if either exists. At most two domains are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListDomains">REST API Reference for ListDomains Operation</seealso>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIntegrations



        /// <summary>
        /// Lists the integrations in the account, optionally filtered by type, status, or name.
        /// Results are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIntegrations service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        Task<ListIntegrationsResponse> ListIntegrationsAsync(ListIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListOmniDashboards



        /// <summary>
        /// Returns the dashboards in a space, optionally filtered by name prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOmniDashboards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOmniDashboards service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListOmniDashboards">REST API Reference for ListOmniDashboards Operation</seealso>
        Task<ListOmniDashboardsResponse> ListOmniDashboardsAsync(ListOmniDashboardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSpaces



        /// <summary>
        /// Returns the spaces in the account, optionally filtered by domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSpaces service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        Task<ListSpacesResponse> ListSpacesAsync(ListSpacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSpacesForOrganization



        /// <summary>
        /// Returns the spaces across all member accounts in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpacesForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSpacesForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListSpacesForOrganization">REST API Reference for ListSpacesForOrganization Operation</seealso>
        Task<ListSpacesForOrganizationResponse> ListSpacesForOrganizationAsync(ListSpacesForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTelemetryFields



        /// <summary>
        /// Lists fields available for telemetry queries.
        /// 
        ///  
        /// <para>
        /// Returns a list of fields included in the specified dataset, granular to telemetry
        /// type. Returned field names reflect the exact stored casing and are case-sensitive
        /// when referenced in query expressions; the query engine does not normalize identifier
        /// case.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryFields service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTelemetryFields service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListTelemetryFields">REST API Reference for ListTelemetryFields Operation</seealso>
        Task<ListTelemetryFieldsResponse> ListTelemetryFieldsAsync(ListTelemetryFieldsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTelemetryQuerySessions



        /// <summary>
        /// Lists telemetry query sessions.
        /// 
        ///  
        /// <para>
        /// Returns a list of telemetry query sessions owned by the caller.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryQuerySessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTelemetryQuerySessions service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListTelemetryQuerySessions">REST API Reference for ListTelemetryQuerySessions Operation</seealso>
        Task<ListTelemetryQuerySessionsResponse> ListTelemetryQuerySessionsAsync(ListTelemetryQuerySessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListViews



        /// <summary>
        /// Lists the views in the caller's account and region.
        /// 
        ///  
        /// <para>
        /// Returns a summary for each view, optionally filtered by view type. View definitions
        /// are not included — use GetView to retrieve them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListViews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListViews service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListViews">REST API Reference for ListViews Operation</seealso>
        Task<ListViewsResponse> ListViewsAsync(ListViewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutIntelligenceConfiguration



        /// <summary>
        /// Creates or updates the intelligence configuration for the calling account. Account
        /// is identified via FAS (caller identity).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntelligenceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutIntelligenceConfiguration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/PutIntelligenceConfiguration">REST API Reference for PutIntelligenceConfiguration Operation</seealso>
        Task<PutIntelligenceConfigurationResponse> PutIntelligenceConfigurationAsync(PutIntelligenceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchPrincipals



        /// <summary>
        /// Searches Identity Center for users and groups in a domain. The domain must be configured
        /// with Identity Center.
        /// 
        ///  
        /// <para>
        /// To grant access to a result, pass its principalId to CreateAccessGrant with a principalType
        /// of IDC_USER for a user or IDC_GROUP for a group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPrincipals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchPrincipals service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/SearchPrincipals">REST API Reference for SearchPrincipals Operation</seealso>
        Task<SearchPrincipalsResponse> SearchPrincipalsAsync(SearchPrincipalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartTelemetryQuery



        /// <summary>
        /// Starts a telemetry query within a session.
        /// 
        ///  
        /// <para>
        /// Submits the provided query string for execution in the specified session. Use GetTelemetryQueryResults
        /// to poll for results and check query status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTelemetryQuery service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/StartTelemetryQuery">REST API Reference for StartTelemetryQuery Operation</seealso>
        Task<StartTelemetryQueryResponse> StartTelemetryQueryAsync(StartTelemetryQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartTelemetryQuerySession



        /// <summary>
        /// Starts a new telemetry query session.
        /// 
        ///  
        /// <para>
        /// A session provides a logical grouping for one or more telemetry queries. The returned
        /// session ID is required when starting queries via StartTelemetryQuery.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryQuerySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTelemetryQuerySession service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/StartTelemetryQuerySession">REST API Reference for StartTelemetryQuerySession Operation</seealso>
        Task<StartTelemetryQuerySessionResponse> StartTelemetryQuerySessionAsync(StartTelemetryQuerySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopTelemetryQuery



        /// <summary>
        /// Stops a running telemetry query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTelemetryQuery service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/StopTelemetryQuery">REST API Reference for StopTelemetryQuery Operation</seealso>
        Task<StopTelemetryQueryResponse> StopTelemetryQueryAsync(StopTelemetryQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopTelemetryQuerySession



        /// <summary>
        /// Stops a telemetry query session.
        /// 
        ///  
        /// <para>
        /// Terminates the specified session. After a session is stopped it cannot be reused.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryQuerySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTelemetryQuerySession service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/StopTelemetryQuerySession">REST API Reference for StopTelemetryQuerySession Operation</seealso>
        Task<StopTelemetryQuerySessionResponse> StopTelemetryQuerySessionAsync(StopTelemetryQuerySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccessProfile



        /// <summary>
        /// Updates the name or description of an access profile.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccessProfile service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateAccessProfile">REST API Reference for UpdateAccessProfile Operation</seealso>
        Task<UpdateAccessProfileResponse> UpdateAccessProfileAsync(UpdateAccessProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAlert



        /// <summary>
        /// Updates an existing alert.
        /// 
        ///  
        /// <para>
        /// Only non-null fields overwrite existing values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlert service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateAlert">REST API Reference for UpdateAlert Operation</seealso>
        Task<UpdateAlertResponse> UpdateAlertAsync(UpdateAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDomain



        /// <summary>
        /// Updates a domain's name or identity provider configuration.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged. Renaming
        /// a domain also changes the endpoint URLs derived from its name.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDomainForOrganization



        /// <summary>
        /// Updates an organization domain's name or identity provider configuration. Call this
        /// operation in the Region where the domain was created.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged. Renaming
        /// a domain also changes the endpoint URLs derived from its name.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateDomainForOrganization">REST API Reference for UpdateDomainForOrganization Operation</seealso>
        Task<UpdateDomainForOrganizationResponse> UpdateDomainForOrganizationAsync(UpdateDomainForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIntegration



        /// <summary>
        /// Updates an existing integration, identified by its id, ARN, or name. Only the fields
        /// you provide are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIntegration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        Task<UpdateIntegrationResponse> UpdateIntegrationAsync(UpdateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateOmniDashboard



        /// <summary>
        /// Updates an existing dashboard within a space.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOmniDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOmniDashboard service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateOmniDashboard">REST API Reference for UpdateOmniDashboard Operation</seealso>
        Task<UpdateOmniDashboardResponse> UpdateOmniDashboardAsync(UpdateOmniDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSpace



        /// <summary>
        /// Updates a space.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSpace service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        Task<UpdateSpaceResponse> UpdateSpaceAsync(UpdateSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateView



        /// <summary>
        /// Updates an existing view's definition and/or description.
        /// 
        ///  
        /// <para>
        /// Only the fields you provide are changed. Managed views cannot be updated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateView service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateView">REST API Reference for UpdateView Operation</seealso>
        Task<UpdateViewResponse> UpdateViewAsync(UpdateViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonCloudWatchOmniConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonCloudWatchOmniConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonCloudWatchOmniConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonCloudWatchOmniConfig to create AmazonCloudWatchOmniClient");
            }

            return awsCredentials == null ? 
                    new AmazonCloudWatchOmniClient(serviceClientConfig) :
                    new AmazonCloudWatchOmniClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}