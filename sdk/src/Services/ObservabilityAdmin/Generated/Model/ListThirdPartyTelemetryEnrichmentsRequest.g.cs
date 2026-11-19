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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the ListThirdPartyTelemetryEnrichments operation.
    /// Returns a summary of each third-party telemetry enrichment in your account and Region.
    /// To get the full configuration of an enrichment, use <c>GetThirdPartyTelemetryEnrichment</c>.
    /// The results are paginated. To get the next page of results, use <c>NextToken</c>.
    /// </summary>
    public partial class ListThirdPartyTelemetryEnrichmentsRequest : AmazonObservabilityAdminRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. If you omit this parameter,
        /// the operation returns up to 100 results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. A previous call generates this token. If you
        /// omit this parameter, the operation returns the first page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Returns only the enrichments that have this status. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Initializing</c> - CloudWatch is setting up the enrichment. Some telemetry can
        /// be enriched before setup completes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Running</c> - The enrichment is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stopped</c> - The enrichment is stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Impaired</c> - The enrichment has a problem. <c>StatusReason</c> describes the
        /// problem.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ThirdPartyTelemetryEnrichmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TelemetrySource. 
        /// <para>
        /// Returns only the enrichments for this third-party telemetry source.
        /// </para>
        /// </summary>
        public ThirdPartyTelemetrySource TelemetrySource { get; set; }

        /// <summary>
        /// Checks to see if the TelemetrySource property is set.
        /// </summary>
        internal bool IsSetTelemetrySource() => this.TelemetrySource != null;
    }
}
