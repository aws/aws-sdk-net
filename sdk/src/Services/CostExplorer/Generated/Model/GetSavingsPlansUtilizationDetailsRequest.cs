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
    /// Container for the parameters to the GetSavingsPlansUtilizationDetails operation.
    /// Retrieves attribute data along with aggregate utilization and savings data for a given
    /// time period. This doesn't support granular or grouped data (daily/monthly) in response.
    /// You can't retrieve data by dates in a single response similar to <c>GetSavingsPlanUtilization</c>,
    /// but you have the option to make multiple calls to <c>GetSavingsPlanUtilizationDetails</c>
    /// by providing individual dates. You can use <c>GetDimensionValues</c> in <c>SAVINGS_PLANS</c>
    /// to determine the possible dimension values.
    /// 
    ///  <note> 
    /// <para>
    ///  <c>GetSavingsPlanUtilizationDetails</c> internally groups data by <c>SavingsPlansArn</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetSavingsPlansUtilizationDetailsRequest : AmazonCostExplorerRequest
    {
        private List<string> _dataType = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Expression _filter;
        private int? _maxResults;
        private string _nextToken;
        private SortDefinition _sortBy;
        private DateInterval _timePeriod;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null && (this._dataType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filters Savings Plans utilization coverage data for active Savings Plans dimensions.
        /// You can filter data with the following dimensions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LINKED_ACCOUNT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SAVINGS_PLAN_ARN</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PAYMENT_OPTION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSTANCE_TYPE_FAMILY</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>GetSavingsPlansUtilizationDetails</c> uses the same <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>
        /// object as the other operations, but only <c>AND</c> is supported among each dimension.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of items to be returned in a response. The default is <c>20</c>, with a
        /// minimum value of <c>1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The value that you want to sort the data by.
        /// </para>
        ///  
        /// <para>
        /// The following values are supported for <c>Key</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>UtilizationPercentage</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TotalCommitment</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UsedCommitment</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UnusedCommitment</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NetSavings</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AmortizedRecurringCommitment</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AmortizedUpfrontCommitment</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The supported values for <c>SortOrder</c> are <c>ASCENDING</c> and <c>DESCENDING</c>.
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
        /// The time period that you want the usage and costs for. The <c>Start</c> date must
        /// be within 13 months. The <c>End</c> date must be after the <c>Start</c> date, and
        /// before the current date. Future dates can't be used as an <c>End</c> date.
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