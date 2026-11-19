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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.AbuseSignal.Model
{
    /// <summary>
    /// Container for the parameters to the ListAbuseReportStatuses operation. Lists abuse
    /// report statuses for the calling account, ordered by submission time, with optional
    /// filtering and pagination. <para> Use the <c>correlationId</c> parameter to filter
    /// results by the reporter-provided correlation ID that was specified during report submission.
    /// </para> <para> Results are paginated. Use <c>nextToken</c> to retrieve additional
    /// results. </para>
    /// </summary>
    public partial class ListAbuseReportStatusesRequest : AmazonAbuseSignalRequest
    {
        /// <summary>
        /// Gets and sets the property CorrelationId. 
        /// <para>
        /// Filters results by the reporter-provided correlation ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Checks to see if the CorrelationId property is set.
        /// </summary>
        internal bool IsSetCorrelationId() => this.CorrelationId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single page. Valid range: 1–50. The default
        /// is 50.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for retrieving the next page of results. Omit this parameter
        /// to return the first page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
