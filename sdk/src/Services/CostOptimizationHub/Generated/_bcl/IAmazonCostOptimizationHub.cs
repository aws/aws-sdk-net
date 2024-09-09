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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CostOptimizationHub.Model;

#pragma warning disable CS1570
namespace Amazon.CostOptimizationHub
{
    /// <summary>
    /// <para>Interface for accessing CostOptimizationHub</para>
    ///
    /// You can use the Cost Optimization Hub API to programmatically identify, filter, aggregate,
    /// and quantify savings for your cost optimization recommendations across multiple Amazon
    /// Web Services Regions and Amazon Web Services accounts in your organization.
    /// 
    ///  
    /// <para>
    /// The Cost Optimization Hub API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  https://cost-optimization-hub.us-east-1.amazonaws.com 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonCostOptimizationHub : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICostOptimizationHubPaginatorFactory Paginators { get; }

        
        #region  GetPreferences


        /// <summary>
        /// Returns a set of preferences for an account in order to add account-specific preferences
        /// into the service. These preferences impact how the savings associated with recommendations
        /// are presented—estimated savings after discounts or estimated savings before discounts,
        /// for example.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPreferences service method.</param>
        /// 
        /// <returns>The response from the GetPreferences service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/GetPreferences">REST API Reference for GetPreferences Operation</seealso>
        GetPreferencesResponse GetPreferences(GetPreferencesRequest request);



        /// <summary>
        /// Returns a set of preferences for an account in order to add account-specific preferences
        /// into the service. These preferences impact how the savings associated with recommendations
        /// are presented—estimated savings after discounts or estimated savings before discounts,
        /// for example.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPreferences service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/GetPreferences">REST API Reference for GetPreferences Operation</seealso>
        Task<GetPreferencesResponse> GetPreferencesAsync(GetPreferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRecommendation


        /// <summary>
        /// Returns both the current and recommended resource configuration and the estimated
        /// cost impact for a recommendation.
        /// 
        ///  
        /// <para>
        /// The <c>recommendationId</c> is only valid for up to a maximum of 24 hours as recommendations
        /// are refreshed daily. To retrieve the <c>recommendationId</c>, use the <c>ListRecommendations</c>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendation service method.</param>
        /// 
        /// <returns>The response from the GetRecommendation service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        GetRecommendationResponse GetRecommendation(GetRecommendationRequest request);



        /// <summary>
        /// Returns both the current and recommended resource configuration and the estimated
        /// cost impact for a recommendation.
        /// 
        ///  
        /// <para>
        /// The <c>recommendationId</c> is only valid for up to a maximum of 24 hours as recommendations
        /// are refreshed daily. To retrieve the <c>recommendationId</c>, use the <c>ListRecommendations</c>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecommendation service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        Task<GetRecommendationResponse> GetRecommendationAsync(GetRecommendationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEnrollmentStatuses


        /// <summary>
        /// Retrieves the enrollment status for an account. It can also return the list of accounts
        /// that are enrolled under the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnrollmentStatuses service method.</param>
        /// 
        /// <returns>The response from the ListEnrollmentStatuses service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/ListEnrollmentStatuses">REST API Reference for ListEnrollmentStatuses Operation</seealso>
        ListEnrollmentStatusesResponse ListEnrollmentStatuses(ListEnrollmentStatusesRequest request);



        /// <summary>
        /// Retrieves the enrollment status for an account. It can also return the list of accounts
        /// that are enrolled under the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnrollmentStatuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnrollmentStatuses service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/ListEnrollmentStatuses">REST API Reference for ListEnrollmentStatuses Operation</seealso>
        Task<ListEnrollmentStatusesResponse> ListEnrollmentStatusesAsync(ListEnrollmentStatusesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRecommendations


        /// <summary>
        /// Returns a list of recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request);



        /// <summary>
        /// Returns a list of recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        Task<ListRecommendationsResponse> ListRecommendationsAsync(ListRecommendationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRecommendationSummaries


        /// <summary>
        /// Returns a concise representation of savings estimates for resources. Also returns
        /// de-duped savings across different types of recommendations.
        /// 
        ///  <note> 
        /// <para>
        /// The following filters are not supported for this API: <c>recommendationIds</c>, <c>resourceArns</c>,
        /// and <c>resourceIds</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationSummaries service method.</param>
        /// 
        /// <returns>The response from the ListRecommendationSummaries service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/ListRecommendationSummaries">REST API Reference for ListRecommendationSummaries Operation</seealso>
        ListRecommendationSummariesResponse ListRecommendationSummaries(ListRecommendationSummariesRequest request);



        /// <summary>
        /// Returns a concise representation of savings estimates for resources. Also returns
        /// de-duped savings across different types of recommendations.
        /// 
        ///  <note> 
        /// <para>
        /// The following filters are not supported for this API: <c>recommendationIds</c>, <c>resourceArns</c>,
        /// and <c>resourceIds</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendationSummaries service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/ListRecommendationSummaries">REST API Reference for ListRecommendationSummaries Operation</seealso>
        Task<ListRecommendationSummariesResponse> ListRecommendationSummariesAsync(ListRecommendationSummariesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEnrollmentStatus


        /// <summary>
        /// Updates the enrollment (opt in and opt out) status of an account to the Cost Optimization
        /// Hub service.
        /// 
        ///  
        /// <para>
        /// If the account is a management account or delegated administrator of an organization,
        /// this action can also be used to enroll member accounts of the organization.
        /// </para>
        ///  
        /// <para>
        /// You must have the appropriate permissions to opt in to Cost Optimization Hub and to
        /// view its recommendations. When you opt in, Cost Optimization Hub automatically creates
        /// a service-linked role in your account to access its data.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateEnrollmentStatus service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/UpdateEnrollmentStatus">REST API Reference for UpdateEnrollmentStatus Operation</seealso>
        UpdateEnrollmentStatusResponse UpdateEnrollmentStatus(UpdateEnrollmentStatusRequest request);



        /// <summary>
        /// Updates the enrollment (opt in and opt out) status of an account to the Cost Optimization
        /// Hub service.
        /// 
        ///  
        /// <para>
        /// If the account is a management account or delegated administrator of an organization,
        /// this action can also be used to enroll member accounts of the organization.
        /// </para>
        ///  
        /// <para>
        /// You must have the appropriate permissions to opt in to Cost Optimization Hub and to
        /// view its recommendations. When you opt in, Cost Optimization Hub automatically creates
        /// a service-linked role in your account to access its data.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnrollmentStatus service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/UpdateEnrollmentStatus">REST API Reference for UpdateEnrollmentStatus Operation</seealso>
        Task<UpdateEnrollmentStatusResponse> UpdateEnrollmentStatusAsync(UpdateEnrollmentStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePreferences


        /// <summary>
        /// Updates a set of preferences for an account in order to add account-specific preferences
        /// into the service. These preferences impact how the savings associated with recommendations
        /// are presented.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreferences service method.</param>
        /// 
        /// <returns>The response from the UpdatePreferences service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/UpdatePreferences">REST API Reference for UpdatePreferences Operation</seealso>
        UpdatePreferencesResponse UpdatePreferences(UpdatePreferencesRequest request);



        /// <summary>
        /// Updates a set of preferences for an account in order to add account-specific preferences
        /// into the service. These preferences impact how the savings associated with recommendations
        /// are presented.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePreferences service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/UpdatePreferences">REST API Reference for UpdatePreferences Operation</seealso>
        Task<UpdatePreferencesResponse> UpdatePreferencesAsync(UpdatePreferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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