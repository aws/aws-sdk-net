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
 * Do not modify this file. This file is generated from the entitlement.marketplace-2017-01-11.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MarketplaceEntitlementService.Model;

#pragma warning disable CS1570
namespace Amazon.MarketplaceEntitlementService
{
    /// <summary>
    /// <para>Interface for accessing MarketplaceEntitlementService</para>
    ///
    /// AWS Marketplace Entitlement Service 
    /// <para>
    /// This reference provides descriptions of the AWS Marketplace Entitlement Service API.
    /// </para>
    ///  
    /// <para>
    /// AWS Marketplace Entitlement Service is used to determine the entitlement of a customer
    /// to a given product. An entitlement represents capacity in a product owned by the customer.
    /// For example, a customer might own some number of users or seats in an SaaS application
    /// or some amount of data capacity in a multi-tenant database.
    /// </para>
    ///  
    /// <para>
    ///  <b>Getting Entitlement Records</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>GetEntitlements</i>- Gets the entitlements for a Marketplace product.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonMarketplaceEntitlementService : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMarketplaceEntitlementServicePaginatorFactory Paginators { get; }

        
        #region  GetEntitlements


        /// <summary>
        /// GetEntitlements retrieves entitlement values for a given product. The results can
        /// be filtered based on customer identifier, AWS account ID, or product dimensions.
        /// 
        ///  <important> 
        /// <para>
        ///  The <c>CustomerIdentifier</c> parameter is on path for deprecation. Use <c>CustomerAWSAccountID</c>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// These parameters are mutually exclusive. You can't specify both <c>CustomerIdentifier</c>
        /// and <c>CustomerAWSAccountID</c> in the same request. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntitlements service method.</param>
        /// 
        /// <returns>The response from the GetEntitlements service method, as returned by MarketplaceEntitlementService.</returns>
        /// <exception cref="Amazon.MarketplaceEntitlementService.Model.InternalServiceErrorException">
        /// An internal error has occurred. Retry your request. If the problem persists, post
        /// a message with details on the AWS forums.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceEntitlementService.Model.InvalidParameterException">
        /// One or more parameters in your request was invalid.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceEntitlementService.Model.ThrottlingException">
        /// The calls to the GetEntitlements API are throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entitlement.marketplace-2017-01-11/GetEntitlements">REST API Reference for GetEntitlements Operation</seealso>
        GetEntitlementsResponse GetEntitlements(GetEntitlementsRequest request);



        /// <summary>
        /// GetEntitlements retrieves entitlement values for a given product. The results can
        /// be filtered based on customer identifier, AWS account ID, or product dimensions.
        /// 
        ///  <important> 
        /// <para>
        ///  The <c>CustomerIdentifier</c> parameter is on path for deprecation. Use <c>CustomerAWSAccountID</c>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// These parameters are mutually exclusive. You can't specify both <c>CustomerIdentifier</c>
        /// and <c>CustomerAWSAccountID</c> in the same request. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntitlements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEntitlements service method, as returned by MarketplaceEntitlementService.</returns>
        /// <exception cref="Amazon.MarketplaceEntitlementService.Model.InternalServiceErrorException">
        /// An internal error has occurred. Retry your request. If the problem persists, post
        /// a message with details on the AWS forums.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceEntitlementService.Model.InvalidParameterException">
        /// One or more parameters in your request was invalid.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceEntitlementService.Model.ThrottlingException">
        /// The calls to the GetEntitlements API are throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entitlement.marketplace-2017-01-11/GetEntitlements">REST API Reference for GetEntitlements Operation</seealso>
        Task<GetEntitlementsResponse> GetEntitlementsAsync(GetEntitlementsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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