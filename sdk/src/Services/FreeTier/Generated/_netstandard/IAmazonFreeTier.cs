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
 * Do not modify this file. This file is generated from the freetier-2023-09-07.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.FreeTier.Model;

#pragma warning disable CS1570
namespace Amazon.FreeTier
{
    /// <summary>
    /// <para>Interface for accessing FreeTier</para>
    ///
    /// You can use the Amazon Web Services Free Tier API to query programmatically your Free
    /// Tier usage data.
    /// 
    ///  
    /// <para>
    /// Free Tier tracks your monthly usage data for all free tier offers that are associated
    /// with your Amazon Web Services account. You can use the Free Tier API to filter and
    /// show only the data that you want.
    /// </para>
    ///  
    /// <para>
    /// Service endpoint
    /// </para>
    ///  
    /// <para>
    /// The Free Tier API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// https://freetier.us-east-1.api.aws
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/billing-free-tier.html">Using
    /// the Amazon Web Services Free Tier</a> in the <i>Billing User Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonFreeTier : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IFreeTierPaginatorFactory Paginators { get; }
#endif
                
        #region  GetFreeTierUsage



        /// <summary>
        /// Returns a list of all Free Tier usage objects that match your filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFreeTierUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFreeTierUsage service method, as returned by FreeTier.</returns>
        /// <exception cref="Amazon.FreeTier.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.FreeTier.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FreeTier.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/freetier-2023-09-07/GetFreeTierUsage">REST API Reference for GetFreeTierUsage Operation</seealso>
        Task<GetFreeTierUsageResponse> GetFreeTierUsageAsync(GetFreeTierUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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