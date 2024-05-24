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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.TrustedAdvisor.Model;

#pragma warning disable CS1570
namespace Amazon.TrustedAdvisor
{
    /// <summary>
    /// <para>Interface for accessing TrustedAdvisor</para>
    ///
    /// TrustedAdvisor Public API
    /// </summary>
    public partial interface IAmazonTrustedAdvisor : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITrustedAdvisorPaginatorFactory Paginators { get; }

        
        #region  BatchUpdateRecommendationResourceExclusion


        /// <summary>
        /// Update one or more exclusion status for a list of recommendation resources
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateRecommendationResourceExclusion service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateRecommendationResourceExclusion service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/BatchUpdateRecommendationResourceExclusion">REST API Reference for BatchUpdateRecommendationResourceExclusion Operation</seealso>
        BatchUpdateRecommendationResourceExclusionResponse BatchUpdateRecommendationResourceExclusion(BatchUpdateRecommendationResourceExclusionRequest request);



        /// <summary>
        /// Update one or more exclusion status for a list of recommendation resources
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateRecommendationResourceExclusion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateRecommendationResourceExclusion service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/BatchUpdateRecommendationResourceExclusion">REST API Reference for BatchUpdateRecommendationResourceExclusion Operation</seealso>
        Task<BatchUpdateRecommendationResourceExclusionResponse> BatchUpdateRecommendationResourceExclusionAsync(BatchUpdateRecommendationResourceExclusionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOrganizationRecommendation


        /// <summary>
        /// Get a specific recommendation within an AWS Organizations organization. This API supports
        /// only prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationRecommendation service method.</param>
        /// 
        /// <returns>The response from the GetOrganizationRecommendation service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetOrganizationRecommendation">REST API Reference for GetOrganizationRecommendation Operation</seealso>
        GetOrganizationRecommendationResponse GetOrganizationRecommendation(GetOrganizationRecommendationRequest request);



        /// <summary>
        /// Get a specific recommendation within an AWS Organizations organization. This API supports
        /// only prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOrganizationRecommendation service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetOrganizationRecommendation">REST API Reference for GetOrganizationRecommendation Operation</seealso>
        Task<GetOrganizationRecommendationResponse> GetOrganizationRecommendationAsync(GetOrganizationRecommendationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRecommendation


        /// <summary>
        /// Get a specific Recommendation
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendation service method.</param>
        /// 
        /// <returns>The response from the GetRecommendation service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        GetRecommendationResponse GetRecommendation(GetRecommendationRequest request);



        /// <summary>
        /// Get a specific Recommendation
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecommendation service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        Task<GetRecommendationResponse> GetRecommendationAsync(GetRecommendationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListChecks


        /// <summary>
        /// List a filterable set of Checks
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChecks service method.</param>
        /// 
        /// <returns>The response from the ListChecks service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListChecks">REST API Reference for ListChecks Operation</seealso>
        ListChecksResponse ListChecks(ListChecksRequest request);



        /// <summary>
        /// List a filterable set of Checks
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChecks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChecks service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListChecks">REST API Reference for ListChecks Operation</seealso>
        Task<ListChecksResponse> ListChecksAsync(ListChecksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOrganizationRecommendationAccounts


        /// <summary>
        /// Lists the accounts that own the resources for an organization aggregate recommendation.
        /// This API only supports prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendationAccounts service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendationAccounts service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationAccounts">REST API Reference for ListOrganizationRecommendationAccounts Operation</seealso>
        ListOrganizationRecommendationAccountsResponse ListOrganizationRecommendationAccounts(ListOrganizationRecommendationAccountsRequest request);



        /// <summary>
        /// Lists the accounts that own the resources for an organization aggregate recommendation.
        /// This API only supports prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendationAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendationAccounts service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationAccounts">REST API Reference for ListOrganizationRecommendationAccounts Operation</seealso>
        Task<ListOrganizationRecommendationAccountsResponse> ListOrganizationRecommendationAccountsAsync(ListOrganizationRecommendationAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOrganizationRecommendationResources


        /// <summary>
        /// List Resources of a Recommendation within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendationResources service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendationResources service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationResources">REST API Reference for ListOrganizationRecommendationResources Operation</seealso>
        ListOrganizationRecommendationResourcesResponse ListOrganizationRecommendationResources(ListOrganizationRecommendationResourcesRequest request);



        /// <summary>
        /// List Resources of a Recommendation within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendationResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendationResources service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationResources">REST API Reference for ListOrganizationRecommendationResources Operation</seealso>
        Task<ListOrganizationRecommendationResourcesResponse> ListOrganizationRecommendationResourcesAsync(ListOrganizationRecommendationResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOrganizationRecommendations


        /// <summary>
        /// List a filterable set of Recommendations within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendations service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendations">REST API Reference for ListOrganizationRecommendations Operation</seealso>
        ListOrganizationRecommendationsResponse ListOrganizationRecommendations(ListOrganizationRecommendationsRequest request);



        /// <summary>
        /// List a filterable set of Recommendations within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendations service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendations">REST API Reference for ListOrganizationRecommendations Operation</seealso>
        Task<ListOrganizationRecommendationsResponse> ListOrganizationRecommendationsAsync(ListOrganizationRecommendationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRecommendationResources


        /// <summary>
        /// List Resources of a Recommendation
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationResources service method.</param>
        /// 
        /// <returns>The response from the ListRecommendationResources service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendationResources">REST API Reference for ListRecommendationResources Operation</seealso>
        ListRecommendationResourcesResponse ListRecommendationResources(ListRecommendationResourcesRequest request);



        /// <summary>
        /// List Resources of a Recommendation
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendationResources service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendationResources">REST API Reference for ListRecommendationResources Operation</seealso>
        Task<ListRecommendationResourcesResponse> ListRecommendationResourcesAsync(ListRecommendationResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRecommendations


        /// <summary>
        /// List a filterable set of Recommendations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request);



        /// <summary>
        /// List a filterable set of Recommendations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        Task<ListRecommendationsResponse> ListRecommendationsAsync(ListRecommendationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateOrganizationRecommendationLifecycle


        /// <summary>
        /// Update the lifecycle of a Recommendation within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationRecommendationLifecycle service method.</param>
        /// 
        /// <returns>The response from the UpdateOrganizationRecommendationLifecycle service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateOrganizationRecommendationLifecycle">REST API Reference for UpdateOrganizationRecommendationLifecycle Operation</seealso>
        UpdateOrganizationRecommendationLifecycleResponse UpdateOrganizationRecommendationLifecycle(UpdateOrganizationRecommendationLifecycleRequest request);



        /// <summary>
        /// Update the lifecycle of a Recommendation within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationRecommendationLifecycle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOrganizationRecommendationLifecycle service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateOrganizationRecommendationLifecycle">REST API Reference for UpdateOrganizationRecommendationLifecycle Operation</seealso>
        Task<UpdateOrganizationRecommendationLifecycleResponse> UpdateOrganizationRecommendationLifecycleAsync(UpdateOrganizationRecommendationLifecycleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRecommendationLifecycle


        /// <summary>
        /// Update the lifecyle of a Recommendation. This API only supports prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommendationLifecycle service method.</param>
        /// 
        /// <returns>The response from the UpdateRecommendationLifecycle service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateRecommendationLifecycle">REST API Reference for UpdateRecommendationLifecycle Operation</seealso>
        UpdateRecommendationLifecycleResponse UpdateRecommendationLifecycle(UpdateRecommendationLifecycleRequest request);



        /// <summary>
        /// Update the lifecyle of a Recommendation. This API only supports prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommendationLifecycle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRecommendationLifecycle service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateRecommendationLifecycle">REST API Reference for UpdateRecommendationLifecycle Operation</seealso>
        Task<UpdateRecommendationLifecycleResponse> UpdateRecommendationLifecycleAsync(UpdateRecommendationLifecycleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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