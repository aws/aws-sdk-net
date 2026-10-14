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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetCostComparisonDrivers operation. Retrieves
    /// key factors driving cost changes between two time periods within the last 13 months,
    /// such as usage changes, discount changes, and commitment-based savings. If you have
    /// enabled multi-year data at monthly granularity, you can go back up to 38 months.
    /// </summary>
    public partial class GetCostComparisonDriversRequest : AmazonCostExplorerRequest
    {
        /// <summary>
        /// Gets and sets the property BaselineTimePeriod. 
        /// <para>
        /// The reference time period for comparison. This time period serves as the baseline
        /// against which other cost and usage data will be compared. The interval must start
        /// and end on the first day of a month, with a duration of exactly one month.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateInterval BaselineTimePeriod { get; set; }

        /// <summary>
        /// Checks to see if the BaselineTimePeriod property is set.
        /// </summary>
        internal bool IsSetBaselineTimePeriod() => this.BaselineTimePeriod != null;

        /// <summary>
        /// Gets and sets the property BillingViewArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies a specific billing view. The
        /// ARN is used to specify which particular billing view you want to interact with or
        /// retrieve information from when making API calls related to Amazon Web Services Billing
        /// and Cost Management features. The BillingViewArn can be retrieved by calling the ListBillingViews
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string BillingViewArn { get; set; }

        /// <summary>
        /// Checks to see if the BillingViewArn property is set.
        /// </summary>
        internal bool IsSetBillingViewArn() => this.BillingViewArn != null;

        /// <summary>
        /// Gets and sets the property ComparisonTimePeriod. 
        /// <para>
        /// The comparison time period for analysis. This time period's cost and usage data will
        /// be compared against the baseline time period. The interval must start and end on the
        /// first day of a month, with a duration of exactly one month.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateInterval ComparisonTimePeriod { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonTimePeriod property is set.
        /// </summary>
        internal bool IsSetComparisonTimePeriod() => this.ComparisonTimePeriod != null;

        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public Expression Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// You can group results using the attributes <c>DIMENSION</c>, <c>TAG</c>, and <c>COST_CATEGORY</c>.
        /// Note that <c>SERVICE</c> and <c>USAGE_TYPE</c> dimensions are automatically included
        /// in the cost comparison drivers analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupDefinition> GroupBy { get; set; } = AWSConfigs.InitializeCollections ? new List<GroupDefinition>() : null;

        /// <summary>
        /// Checks to see if the GroupBy property is set.
        /// </summary>
        internal bool IsSetGroupBy() => this.GroupBy != null && (this.GroupBy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that are returned for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MetricForComparison. 
        /// <para>
        /// The cost and usage metric to compare. Valid values are <c>AmortizedCost</c>, <c>BlendedCost</c>,
        /// <c>NetAmortizedCost</c>, <c>NetUnblendedCost</c>, <c>NormalizedUsageAmount</c>, <c>UnblendedCost</c>,
        /// and <c>UsageQuantity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string MetricForComparison { get; set; }

        /// <summary>
        /// Checks to see if the MetricForComparison property is set.
        /// </summary>
        internal bool IsSetMetricForComparison() => this.MetricForComparison != null;

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Checks to see if the NextPageToken property is set.
        /// </summary>
        internal bool IsSetNextPageToken() => this.NextPageToken != null;
    }
}
