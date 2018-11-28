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
    ///  <b>Submitting Metering Records</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>MeterUsage</i>- Submits the metering record for a Marketplace product. MeterUsage
    /// is called from an EC2 instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>BatchMeterUsage</i>- Submits the metering record for a set of customers. BatchMeterUsage
    /// is called from a software-as-a-service (SaaS) application.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Accepting New Customers</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>ResolveCustomer</i>- Called by a SaaS application during the registration process.
    /// When a buyer visits your website during the registration process, the buyer submits
    /// a Registration Token through the browser. The Registration Token is resolved through
    /// this API to obtain a CustomerIdentifier and Product Code.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Entitlement and Metering for Paid Container Products</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  Paid container software products sold through AWS Marketplace must integrate with
    /// the AWS Marketplace Metering Service and call the RegisterUsage operation for software
    /// entitlement and metering. Calling RegisterUsage from containers running outside of
    /// Amazon Elastic Container Service (Amazon ECR) isn't supported. Free and BYOL products
    /// for ECS aren't required to call RegisterUsage, but you can do so if you want to receive
    /// usage data in your seller reports. For more information on using the RegisterUsage
    /// operation, see <a href="https://docs.aws.amazon.com/latest/userguide/entitlement-and-metering-for-paid-products.html">Container-Based
    /// Products</a>. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// BatchMeterUsage API calls are captured by AWS CloudTrail. You can use Cloudtrail to
    /// verify that the SaaS metering records that you sent are accurate by searching for
    /// records with the eventName of BatchMeterUsage. You can also use CloudTrail to audit
    /// records over time. For more information, see the <i> <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html">AWS
    /// CloudTrail User Guide</a> </i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonAWSMarketplaceMetering : IAmazonService, IDisposable
    {
                
        #region  BatchMeterUsage


        /// <summary>
        /// Initiates the asynchronous execution of the BatchMeterUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchMeterUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/BatchMeterUsage">REST API Reference for BatchMeterUsage Operation</seealso>
        Task<BatchMeterUsageResponse> BatchMeterUsageAsync(BatchMeterUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  MeterUsage


        /// <summary>
        /// Initiates the asynchronous execution of the MeterUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MeterUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/MeterUsage">REST API Reference for MeterUsage Operation</seealso>
        Task<MeterUsageResponse> MeterUsageAsync(MeterUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterUsage


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/RegisterUsage">REST API Reference for RegisterUsage Operation</seealso>
        Task<RegisterUsageResponse> RegisterUsageAsync(RegisterUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResolveCustomer


        /// <summary>
        /// Initiates the asynchronous execution of the ResolveCustomer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveCustomer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/ResolveCustomer">REST API Reference for ResolveCustomer Operation</seealso>
        Task<ResolveCustomerResponse> ResolveCustomerAsync(ResolveCustomerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}