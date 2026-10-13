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
    /// Container for the parameters to the GetSavingsPlansCoverage operation. Retrieves the
    /// Savings Plans covered for your account. This enables you to see how much of your cost
    /// is covered by a Savings Plan. An organization’s management account can see the coverage
    /// of the associated member accounts. This supports dimensions, cost categories, and
    /// nested expressions. For any time period, you can filter data for Savings Plans usage
    /// with the following dimensions: <ul> <li> <para> <c>LINKED_ACCOUNT</c> </para> </li>
    /// <li> <para> <c>REGION</c> </para> </li> <li> <para> <c>SERVICE</c> </para> </li> <li>
    /// <para> <c>INSTANCE_FAMILY</c> </para> </li> </ul> <para> To determine valid values
    /// for a dimension, use the <c>GetDimensionValues</c> operation. </para>
    /// </summary>
    public partial class GetSavingsPlansCoverageRequest : AmazonCostExplorerRequest
    {
        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filters Savings Plans coverage data by dimensions. You can filter data for Savings
        /// Plans usage with the following dimensions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LINKED_ACCOUNT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SERVICE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSTANCE_FAMILY</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>GetSavingsPlansCoverage</c> uses the same <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>
        /// object as the other operations, but only <c>AND</c> is supported among each dimension.
        /// If there are multiple values for a dimension, they are OR'd together.
        /// </para>
        ///  
        /// <para>
        /// Cost category is also supported.
        /// </para>
        /// </summary>
        public Expression Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// The granularity of the Amazon Web Services cost data for your Savings Plans. <c>Granularity</c>
        /// can't be set if <c>GroupBy</c> is set.
        /// </para>
        ///  
        /// <para>
        /// The <c>GetSavingsPlansCoverage</c> operation supports only <c>DAILY</c> and <c>MONTHLY</c>
        /// granularities.
        /// </para>
        /// </summary>
        public Granularity Granularity { get; set; }

        /// <summary>
        /// Checks to see if the Granularity property is set.
        /// </summary>
        internal bool IsSetGranularity() => this.Granularity != null;

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// You can group the data using the attributes <c>INSTANCE_FAMILY</c>, <c>REGION</c>,
        /// or <c>SERVICE</c>.
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
        /// The number of items to be returned in a response. The default is <c>20</c>, with a
        /// minimum value of <c>1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The measurement that you want your Savings Plans coverage reported in. The only valid
        /// value is <c>SpendCoveredBySavingsPlans</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value that you want to sort the data by.
        /// </para>
        ///  
        /// <para>
        /// The following values are supported for <c>Key</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SpendCoveredBySavingsPlan</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OnDemandCost</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CoveragePercentage</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TotalCost</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InstanceFamily</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Region</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Service</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The supported values for <c>SortOrder</c> are <c>ASCENDING</c> and <c>DESCENDING</c>.
        /// </para>
        /// </summary>
        public SortDefinition SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The time period that you want the usage and costs for. The <c>Start</c> date must
        /// be within 13 months. The <c>End</c> date must be after the <c>Start</c> date, and
        /// before the current date. Future dates can't be used as an <c>End</c> date.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateInterval TimePeriod { get; set; }

        /// <summary>
        /// Checks to see if the TimePeriod property is set.
        /// </summary>
        internal bool IsSetTimePeriod() => this.TimePeriod != null;
    }
}
