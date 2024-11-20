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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Billing.Model;

#pragma warning disable CS1570
namespace Amazon.Billing
{
    /// <summary>
    /// <para>Interface for accessing Billing</para>
    ///
    /// You can use the Billing API to programatically list the billing views available to
    /// you for a given time period. A billing view represents a set of billing data. 
    /// 
    ///  
    /// <para>
    /// The Billing API provides the following endpoint:
    /// </para>
    ///  
    /// <para>
    ///  <c>https://billing.us-east-1.api.aws</c> 
    /// </para>
    /// </summary>
    public partial interface IAmazonBilling : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBillingPaginatorFactory Paginators { get; }

        
        #region  ListBillingViews


        /// <summary>
        /// Lists the billing views available for a given time period. 
        /// 
        ///  
        /// <para>
        /// Every Amazon Web Services account has a unique <c>PRIMARY</c> billing view that represents
        /// the billing data available by default. Accounts that use Billing Conductor also have
        /// <c>BILLING_GROUP</c> billing views representing pro forma costs associated with each
        /// created billing group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillingViews service method.</param>
        /// 
        /// <returns>The response from the ListBillingViews service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListBillingViews">REST API Reference for ListBillingViews Operation</seealso>
        ListBillingViewsResponse ListBillingViews(ListBillingViewsRequest request);



        /// <summary>
        /// Lists the billing views available for a given time period. 
        /// 
        ///  
        /// <para>
        /// Every Amazon Web Services account has a unique <c>PRIMARY</c> billing view that represents
        /// the billing data available by default. Accounts that use Billing Conductor also have
        /// <c>BILLING_GROUP</c> billing views representing pro forma costs associated with each
        /// created billing group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillingViews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBillingViews service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListBillingViews">REST API Reference for ListBillingViews Operation</seealso>
        Task<ListBillingViewsResponse> ListBillingViewsAsync(ListBillingViewsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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