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
    /// Container for the parameters to the GetCostAndUsage operation.
    /// Retrieves cost and usage metrics for your account. You can specify which cost and
    /// usage-related metric that you want the request to return. For example, you can specify
    /// <c>BlendedCosts</c> or <c>UsageQuantity</c>. You can also filter and group your data
    /// by various dimensions, such as <c>SERVICE</c> or <c>AZ</c>, in a specific time range.
    /// For a complete list of valid dimensions, see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_GetDimensionValues.html">GetDimensionValues</a>
    /// operation. Management account in an organization in Organizations have access to all
    /// member accounts.
    /// 
    ///  
    /// <para>
    /// For information about filter limitations, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/billing-limits.html">Quotas
    /// and restrictions</a> in the <i>Billing and Cost Management User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetCostAndUsageRequest : AmazonCostExplorerRequest
    {
        private Expression _filter;
        private Granularity _granularity;
        private List<GroupDefinition> _groupBy = AWSConfigs.InitializeCollections ? new List<GroupDefinition>() : null;
        private List<string> _metrics = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _nextPageToken;
        private DateInterval _timePeriod;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filters Amazon Web Services costs by different dimensions. For example, you can specify
        /// <c>SERVICE</c> and <c>LINKED_ACCOUNT</c> and get the costs that are associated with
        /// that account's usage of that service. You can nest <c>Expression</c> objects to define
        /// any combination of dimension filters. For more information, see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <c>MatchOptions</c> for <c>Dimensions</c> are <c>EQUALS</c> and <c>CASE_SENSITIVE</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values for <c>MatchOptions</c> for <c>CostCategories</c> and <c>Tags</c> are
        /// <c>EQUALS</c>, <c>ABSENT</c>, and <c>CASE_SENSITIVE</c>. Default values are <c>EQUALS</c>
        /// and <c>CASE_SENSITIVE</c>.
        /// </para>
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
        /// Gets and sets the property Granularity. 
        /// <para>
        /// Sets the Amazon Web Services cost granularity to <c>MONTHLY</c> or <c>DAILY</c>, or
        /// <c>HOURLY</c>. If <c>Granularity</c> isn't set, the response object doesn't include
        /// the <c>Granularity</c>, either <c>MONTHLY</c> or <c>DAILY</c>, or <c>HOURLY</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Granularity Granularity
        {
            get { return this._granularity; }
            set { this._granularity = value; }
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this._granularity != null;
        }

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// You can group Amazon Web Services costs using up to two different groups, either dimensions,
        /// tag keys, cost categories, or any two group by types.
        /// </para>
        ///  
        /// <para>
        /// Valid values for the <c>DIMENSION</c> type are <c>AZ</c>, <c>INSTANCE_TYPE</c>, <c>LEGAL_ENTITY_NAME</c>,
        /// <c>INVOICING_ENTITY</c>, <c>LINKED_ACCOUNT</c>, <c>OPERATION</c>, <c>PLATFORM</c>,
        /// <c>PURCHASE_TYPE</c>, <c>SERVICE</c>, <c>TENANCY</c>, <c>RECORD_TYPE</c>, and <c>USAGE_TYPE</c>.
        /// </para>
        ///  
        /// <para>
        /// When you group by the <c>TAG</c> type and include a valid tag key, you get all tag
        /// values, including empty strings.
        /// </para>
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
        /// Gets and sets the property Metrics. 
        /// <para>
        /// Which metrics are returned in the query. For more information about blended and unblended
        /// rates, see <a href="http://aws.amazon.com/premiumsupport/knowledge-center/blended-rates-intro/">Why
        /// does the "blended" annotation appear on some line items in my bill?</a>. 
        /// </para>
        ///  
        /// <para>
        /// Valid values are <c>AmortizedCost</c>, <c>BlendedCost</c>, <c>NetAmortizedCost</c>,
        /// <c>NetUnblendedCost</c>, <c>NormalizedUsageAmount</c>, <c>UnblendedCost</c>, and <c>UsageQuantity</c>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you return the <c>UsageQuantity</c> metric, the service aggregates all usage numbers
        /// without taking into account the units. For example, if you aggregate <c>usageQuantity</c>
        /// across all of Amazon EC2, the results aren't meaningful because Amazon EC2 compute
        /// hours and data transfer are measured in different units (for example, hours and GB).
        /// To get more meaningful <c>UsageQuantity</c> metrics, filter by <c>UsageType</c> or
        /// <c>UsageTypeGroups</c>. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  <c>Metrics</c> is required for <c>GetCostAndUsage</c> requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
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

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// Sets the start date and end date for retrieving Amazon Web Services costs. The start
        /// date is inclusive, but the end date is exclusive. For example, if <c>start</c> is
        /// <c>2017-01-01</c> and <c>end</c> is <c>2017-05-01</c>, then the cost and usage data
        /// is retrieved from <c>2017-01-01</c> up to and including <c>2017-04-30</c> but not
        /// including <c>2017-05-01</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateInterval TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

    }
}