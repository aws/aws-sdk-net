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
 * Do not modify this file. This file is generated from the bcm-recommended-actions-2024-11-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BCMRecommendedActions.Model;

#pragma warning disable CS1570
namespace Amazon.BCMRecommendedActions
{
    /// <summary>
    /// <para>Interface for accessing BCMRecommendedActions</para>
    ///
    /// You can use the Billing and Cost Management Recommended Actions API to programmatically
    /// query your best practices and recommendations to optimize your costs.
    /// 
    ///  
    /// <para>
    /// The Billing and Cost Management Recommended Actions API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  https://bcm-recommended-actions.us-east-1.api.aws
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonBCMRecommendedActions : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBCMRecommendedActionsPaginatorFactory Paginators { get; }

        
        #region  ListRecommendedActions


        /// <summary>
        /// Returns a list of recommended actions that match the filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedActions service method.</param>
        /// 
        /// <returns>The response from the ListRecommendedActions service method, as returned by BCMRecommendedActions.</returns>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-recommended-actions-2024-11-14/ListRecommendedActions">REST API Reference for ListRecommendedActions Operation</seealso>
        ListRecommendedActionsResponse ListRecommendedActions(ListRecommendedActionsRequest request);



        /// <summary>
        /// Returns a list of recommended actions that match the filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendedActions service method, as returned by BCMRecommendedActions.</returns>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-recommended-actions-2024-11-14/ListRecommendedActions">REST API Reference for ListRecommendedActions Operation</seealso>
        Task<ListRecommendedActionsResponse> ListRecommendedActionsAsync(ListRecommendedActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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