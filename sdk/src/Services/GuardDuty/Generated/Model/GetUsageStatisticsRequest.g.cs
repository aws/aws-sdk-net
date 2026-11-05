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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the GetUsageStatistics operation. Lists Amazon GuardDuty
    /// usage statistics over the last 30 days for the specified detector ID. For newly enabled
    /// detectors or data sources, the cost returned will include only the usage so far under
    /// 30 days. This may differ from the cost metrics in the console, which project usage
    /// over 30 days to provide a monthly cost estimate. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/monitoring_costs.html#usage-calculations">Understanding
    /// How Usage Costs are Calculated</a>.
    /// </summary>
    public partial class GetUsageStatisticsRequest : AmazonGuardDutyRequest
    {
        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The ID of the detector that specifies the GuardDuty service whose usage statistics
        /// you want to retrieve.
        /// </para>
        ///  
        /// <para>
        /// To find the <c>detectorId</c> in the current Region, see the Settings page in the
        /// GuardDuty console, or run the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_ListDetectors.html">ListDetectors</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string DetectorId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorId property is set.
        /// </summary>
        internal bool IsSetDetectorId() => this.DetectorId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response.
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
        /// A token to use for paginating results that are returned in the response. Set the value
        /// of this parameter to null for the first request to a list action. For subsequent calls,
        /// use the NextToken value returned from the previous request to continue listing results
        /// after the first page.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The currency unit you would like to view your usage statistics in. Current valid values
        /// are USD.
        /// </para>
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property UsageCriteria. 
        /// <para>
        /// Represents the criteria used for querying usage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UsageCriteria UsageCriteria { get; set; }

        /// <summary>
        /// Checks to see if the UsageCriteria property is set.
        /// </summary>
        internal bool IsSetUsageCriteria() => this.UsageCriteria != null;

        /// <summary>
        /// Gets and sets the property UsageStatisticType. 
        /// <para>
        /// The type of usage statistics to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UsageStatisticType UsageStatisticType { get; set; }

        /// <summary>
        /// Checks to see if the UsageStatisticType property is set.
        /// </summary>
        internal bool IsSetUsageStatisticType() => this.UsageStatisticType != null;
    }
}
