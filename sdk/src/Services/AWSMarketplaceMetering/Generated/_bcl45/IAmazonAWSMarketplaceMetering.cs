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
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AWSMarketplaceMetering.Model;

namespace Amazon.AWSMarketplaceMetering
{
    /// <summary>
    /// Interface for accessing AWSMarketplaceMetering
    ///
    /// AWS Marketplace Metering Service 
    /// <para>
    /// This reference provides descriptions of the low-level AWS Marketplace Metering Service
    /// API. 
    /// </para>
    ///  
    /// <para>
    /// AWS Marketplace sellers can use this API to submit usage data for custom usage dimensions.
    /// </para>
    ///  
    /// <para>
    /// <b>Submitting Metering Records</b>
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// <i>MeterUsage</i>- Submits the metering record for a Marketplace product.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonAWSMarketplaceMetering : IAmazonService, IDisposable
    {

        
        #region  MeterUsage


        /// <summary>
        /// API to emit metering records. For identical requests, the API is idempotent. It simply
        /// returns the metering record ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MeterUsage service method.</param>
        /// 
        /// <returns>The response from the MeterUsage service method, as returned by AWSMarketplaceMetering.</returns>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.DuplicateRequestException">
        /// A metering record has already been emitted by the same EC2 instance for the given
        /// {usageDimension, timestamp} with a different usageQuantity.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InternalServiceErrorException">
        /// An internal error has occurred. Retry your request. If the problem persists, post
        /// a message with details on the AWS forums.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidEndpointRegionException">
        /// The endpoint being called is in a region different from your EC2 instance. The region
        /// of the Metering service endpoint and the region of the EC2 instance must match.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidProductCodeException">
        /// The product code passed does not match the product code used for publishing the product.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidUsageDimensionException">
        /// The usage dimension does not match one of the UsageDimensions associated with products.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the MeterUsage API are throttled.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.TimestampOutOfBoundsException">
        /// The timestamp value passed in the meterUsage() is out of allowed range.
        /// </exception>
        MeterUsageResponse MeterUsage(MeterUsageRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the MeterUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MeterUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<MeterUsageResponse> MeterUsageAsync(MeterUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}