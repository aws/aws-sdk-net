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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
    /// Container for the parameters to the GetCostAndUsageComparisons operation.
    /// Retrieves cost and usage comparisons for your account between two periods within the
    /// last 13 months. If you have enabled multi-year data at monthly granularity, you can
    /// go back up to 38 months.
    /// </summary>
    public partial class GetCostAndUsageComparisonsRequest : AmazonCostExplorerRequest
    {
        private DateInterval _baselineTimePeriod;
        private string _billingViewArn;
        private DateInterval _comparisonTimePeriod;
        private Expression _filter;
        private List<GroupDefinition> _groupBy = AWSConfigs.InitializeCollections ? new List<GroupDefinition>() : null;
        private int? _maxResults;
        private string _metricForComparison;
        private string _nextPageToken;

        /// <summary>
        /// Gets and sets the property BaselineTimePeriod. 
        /// <para>
        /// The reference time period for comparison. This time period serves as the baseline
        /// against which other cost and usage data will be compared. The interval must start
        /// and end on the first day of a month, with a duration of exactly one month.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateInterval BaselineTimePeriod
        {
            get { return this._baselineTimePeriod; }
            set { this._baselineTimePeriod = value; }
        }

        // Check to see if BaselineTimePeriod property is set
        internal bool IsSetBaselineTimePeriod()
        {
            return this._baselineTimePeriod != null;
        }

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
        [AWSProperty(Min=20, Max=2048)]
        public string BillingViewArn
        {
            get { return this._billingViewArn; }
            set { this._billingViewArn = value; }
        }

        // Check to see if BillingViewArn property is set
        internal bool IsSetBillingViewArn()
        {
            return this._billingViewArn != null;
        }

        /// <summary>
        /// Gets and sets the property ComparisonTimePeriod. 
        /// <para>
        /// The comparison time period for analysis. This time period's cost and usage data will
        /// be compared against the baseline time period. The interval must start and end on the
        /// first day of a month, with a duration of exactly one month.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateInterval ComparisonTimePeriod
        {
            get { return this._comparisonTimePeriod; }
            set { this._comparisonTimePeriod = value; }
        }

        // Check to see if ComparisonTimePeriod property is set
        internal bool IsSetComparisonTimePeriod()
        {
            return this._comparisonTimePeriod != null;
        }

        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public Expression Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// You can group results using the attributes <c>DIMENSION</c>, <c>TAG</c>, and <c>COST_CATEGORY</c>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupDefinition> GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null && (this._groupBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that are returned for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricForComparison. 
        /// <para>
        /// The cost and usage metric to compare. Valid values are <c>AmortizedCost</c>, <c>BlendedCost</c>,
        /// <c>NetAmortizedCost</c>, <c>NetUnblendedCost</c>, <c>NormalizedUsageAmount</c>, <c>UnblendedCost</c>,
        /// and <c>UsageQuantity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string MetricForComparison
        {
            get { return this._metricForComparison; }
            set { this._metricForComparison = value; }
        }

        // Check to see if MetricForComparison property is set
        internal bool IsSetMetricForComparison()
        {
            return this._metricForComparison != null;
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

    }
}