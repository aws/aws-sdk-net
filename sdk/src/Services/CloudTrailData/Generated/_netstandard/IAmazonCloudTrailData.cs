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
 * Do not modify this file. This file is generated from the cloudtrail-data-2021-08-11.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudTrailData.Model;

namespace Amazon.CloudTrailData
{
    /// <summary>
    /// Interface for accessing CloudTrailData
    ///
    /// The CloudTrail Data Service lets you ingest events into CloudTrail from any source
    /// in your hybrid environments, such as in-house or SaaS applications hosted on-premises
    /// or in the cloud, virtual machines, or containers. You can store, access, analyze,
    /// troubleshoot and take action on this data without maintaining multiple log aggregators
    /// and reporting tools. After you run <code>PutAuditEvents</code> to ingest your application
    /// activity into CloudTrail, you can use CloudTrail Lake to search, query, and analyze
    /// the data that is logged from your applications.
    /// </summary>
    public partial interface IAmazonCloudTrailData : IAmazonService, IDisposable
    {
                
        #region  PutAuditEvents



        /// <summary>
        /// Ingests your application events into CloudTrail Lake. A required parameter, <code>auditEvents</code>,
        /// accepts the JSON records (also called <i>payload</i>) of events that you want CloudTrail
        /// to ingest. You can add up to 100 of these events (or up to 1 MB) per <code>PutAuditEvents</code>
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAuditEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAuditEvents service method, as returned by CloudTrailData.</returns>
        /// <exception cref="Amazon.CloudTrailData.Model.ChannelInsufficientPermissionException">
        /// The caller's account ID must be the same as the channel owner's account ID.
        /// </exception>
        /// <exception cref="Amazon.CloudTrailData.Model.ChannelNotFoundException">
        /// The channel could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrailData.Model.ChannelUnsupportedSchemaException">
        /// The schema type of the event is not supported.
        /// </exception>
        /// <exception cref="Amazon.CloudTrailData.Model.DuplicatedAuditEventIdException">
        /// Two or more entries in the request have the same event ID.
        /// </exception>
        /// <exception cref="Amazon.CloudTrailData.Model.InvalidChannelARNException">
        /// The specified channel ARN is not a valid channel ARN.
        /// </exception>
        /// <exception cref="Amazon.CloudTrailData.Model.UnsupportedOperationException">
        /// The operation requested is not supported in this region or account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-data-2021-08-11/PutAuditEvents">REST API Reference for PutAuditEvents Operation</seealso>
        Task<PutAuditEventsResponse> PutAuditEventsAsync(PutAuditEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}