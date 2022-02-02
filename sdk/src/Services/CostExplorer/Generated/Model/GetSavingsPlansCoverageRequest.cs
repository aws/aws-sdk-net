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
    /// Container for the parameters to the GetSavingsPlansCoverage operation.
    /// Retrieves the Savings Plans covered for your account. This enables you to see how
    /// much of your cost is covered by a Savings Plan. An organization’s management account
    /// can see the coverage of the associated member accounts. This supports dimensions,
    /// Cost Categories, and nested expressions. For any time period, you can filter data
    /// for Savings Plans usage with the following dimensions:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>LINKED_ACCOUNT</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>REGION</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>SERVICE</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>INSTANCE_FAMILY</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To determine valid values for a dimension, use the <code>GetDimensionValues</code>
    /// operation.
    /// </para>
    /// </summary>
    public partial class GetSavingsPlansCoverageRequest : AmazonCostExplorerRequest
    {
        private Expression _filter;
        private Granularity _granularity;
        private List<GroupDefinition> _groupBy = new List<GroupDefinition>();
        private int? _maxResults;
        private List<string> _metrics = new List<string>();
        private string _nextToken;
        private SortDefinition _sortBy;
        private DateInterval _timePeriod;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filters Savings Plans coverage data by dimensions. You can filter data for Savings
        /// Plans usage with the following dimensions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LINKED_ACCOUNT</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REGION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SERVICE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INSTANCE_FAMILY</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>GetSavingsPlansCoverage</code> uses the same <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>
        /// object as the other operations, but only <code>AND</code> is supported among each
        /// dimension. If there are multiple values for a dimension, they are OR'd together.
        /// </para>
        ///  
        /// <para>
        /// Cost category is also supported.
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
        /// The granularity of the Amazon Web Services cost data for your Savings Plans. <code>Granularity</code>
        /// can't be set if <code>GroupBy</code> is set.
        /// </para>
        ///  
        /// <para>
        /// The <code>GetSavingsPlansCoverage</code> operation supports only <code>DAILY</code>
        /// and <code>MONTHLY</code> granularities.
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
        /// You can group the data using the attributes <code>INSTANCE_FAMILY</code>, <code>REGION</code>,
        /// or <code>SERVICE</code>.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of items to be returned in a response. The default is <code>20</code>,
        /// with a minimum value of <code>1</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The measurement that you want your Savings Plans coverage reported in. The only valid
        /// value is <code>SpendCoveredBySavingsPlans</code>.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value by which you want to sort the data.
        /// </para>
        ///  
        /// <para>
        /// The following values are supported for <code>Key</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SpendCoveredBySavingsPlan</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OnDemandCost</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CoveragePercentage</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TotalCost</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InstanceFamily</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Region</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Service</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Supported values for <code>SortOrder</code> are <code>ASCENDING</code> or <code>DESCENDING</code>.
        /// </para>
        /// </summary>
        public SortDefinition SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The time period that you want the usage and costs for. The <code>Start</code> date
        /// must be within 13 months. The <code>End</code> date must be after the <code>Start</code>
        /// date, and before the current date. Future dates can't be used as an <code>End</code>
        /// date.
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