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
 * Do not modify this file. This file is generated from the entitlement.marketplace-2017-01-11.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MarketplaceEntitlementService.Model;

namespace Amazon.MarketplaceEntitlementService
{
    /// <summary>
    /// Interface for accessing MarketplaceEntitlementService
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
                
        #region  GetEntitlements


        /// <summary>
        /// Initiates the asynchronous execution of the GetEntitlements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEntitlements operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entitlement.marketplace-2017-01-11/GetEntitlements">REST API Reference for GetEntitlements Operation</seealso>
        Task<GetEntitlementsResponse> GetEntitlementsAsync(GetEntitlementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}