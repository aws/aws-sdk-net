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
 * Do not modify this file. This file is generated from the mobileanalytics-2014-06-05.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MobileAnalytics.Model;

#pragma warning disable CS1570
namespace Amazon.MobileAnalytics
{
    /// <summary>
    /// <para>Interface for accessing MobileAnalytics</para>
    ///
    /// Amazon Mobile Analytics is a service for collecting, visualizing, and understanding
    /// app usage data at scale.
    /// </summary>
    public partial interface IAmazonMobileAnalytics : IAmazonService, IDisposable
    {


        
        #region  PutEvents


        /// <summary>
        /// The PutEvents operation records one or more events. You can have up to 1,500 unique
        /// custom events per app, any combination of up to 40 attributes and metrics per custom
        /// event, and any number of attribute or metric values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by MobileAnalytics.</returns>
        /// <exception cref="Amazon.MobileAnalytics.Model.BadRequestException">
        /// An exception object returned when a request fails.
        /// </exception>
        PutEventsResponse PutEvents(PutEventsRequest request);



        /// <summary>
        /// The PutEvents operation records one or more events. You can have up to 1,500 unique
        /// custom events per app, any combination of up to 40 attributes and metrics per custom
        /// event, and any number of attribute or metric values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by MobileAnalytics.</returns>
        /// <exception cref="Amazon.MobileAnalytics.Model.BadRequestException">
        /// An exception object returned when a request fails.
        /// </exception>
        Task<PutEventsResponse> PutEventsAsync(PutEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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