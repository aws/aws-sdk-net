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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetCostAndUsageWithResources operation.
    /// Retrieves cost and usage metrics with resources for your account. You can specify
    /// which cost and usage-related metric, such as <code>BlendedCosts</code> or <code>UsageQuantity</code>,
    /// that you want the request to return. You can also filter and group your data by various
    /// dimensions, such as <code>SERVICE</code> or <code>AZ</code>, in a specific time range.
    /// For a complete list of valid dimensions, see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_GetDimensionValues.html">GetDimensionValues</a>
    /// operation. Management account in an organization in AWS Organizations have access
    /// to all member accounts. This API is currently available for the Amazon Elastic Compute
    /// Cloud – Compute service only.
    /// 
    ///  <note> 
    /// <para>
    /// This is an opt-in only feature. You can enable this feature from the Cost Explorer
    /// Settings page. For information on how to access the Settings page, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/ce-access.html">Controlling
    /// Access for Cost Explorer</a> in the <i>AWS Billing and Cost Management User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetCostAndUsageWithResourcesRequest : AmazonCostExplorerRequest
    {
        private Expression _filter;
        private Granularity _granularity;
        private List<GroupDefinition> _groupBy = new List<GroupDefinition>();
        private List<string> _metrics = new List<string>();
        private string _nextPageToken;
        private DateInterval _timePeriod;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filters Amazon Web Services costs by different dimensions. For example, you can specify
        /// <code>SERVICE</code> and <code>LINKED_ACCOUNT</code> and get the costs that are associated
        /// with that account's usage of that service. You can nest <code>Expression</code> objects
        /// to define any combination of dimension filters. For more information, see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The <code>GetCostAndUsageWithResources</code> operation requires that you either group
        /// by or filter by a <code>ResourceId</code>. It requires the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>
        /// <code>"SERVICE = Amazon Elastic Compute Cloud - Compute"</code> in the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Sets the AWS cost granularity to <code>MONTHLY</code>, <code>DAILY</code>, or <code>HOURLY</code>.
        /// If <code>Granularity</code> isn't set, the response object doesn't include the <code>Granularity</code>,
        /// <code>MONTHLY</code>, <code>DAILY</code>, or <code>HOURLY</code>. 
        /// </para>
        /// </summary>
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
        /// You can group Amazon Web Services costs using up to two different groups: <code>DIMENSION</code>,
        /// <code>TAG</code>, <code>COST_CATEGORY</code>.
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
            return this._groupBy != null && this._groupBy.Count > 0; 
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
        /// Valid values are <code>AmortizedCost</code>, <code>BlendedCost</code>, <code>NetAmortizedCost</code>,
        /// <code>NetUnblendedCost</code>, <code>NormalizedUsageAmount</code>, <code>UnblendedCost</code>,
        /// and <code>UsageQuantity</code>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you return the <code>UsageQuantity</code> metric, the service aggregates all usage
        /// numbers without taking the units into account. For example, if you aggregate <code>usageQuantity</code>
        /// across all of Amazon EC2, the results aren't meaningful because Amazon EC2 compute
        /// hours and data transfer are measured in different units (for example, hours vs. GB).
        /// To get more meaningful <code>UsageQuantity</code> metrics, filter by <code>UsageType</code>
        /// or <code>UsageTypeGroups</code>. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  <code>Metrics</code> is required for <code>GetCostAndUsageWithResources</code> requests.
        /// </para>
        /// </summary>
        public List<string> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results. AWS provides the token when the response
        /// from a previous call has more results than the maximum page size.
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
        /// Sets the start and end dates for retrieving Amazon Web Services costs. The range must
        /// be within the last 14 days (the start date cannot be earlier than 14 days ago). The
        /// start date is inclusive, but the end date is exclusive. For example, if <code>start</code>
        /// is <code>2017-01-01</code> and <code>end</code> is <code>2017-05-01</code>, then the
        /// cost and usage data is retrieved from <code>2017-01-01</code> up to and including
        /// <code>2017-04-30</code> but not including <code>2017-05-01</code>.
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