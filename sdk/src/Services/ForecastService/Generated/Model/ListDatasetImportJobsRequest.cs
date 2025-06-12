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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the ListDatasetImportJobs operation.
    /// Returns a list of dataset import jobs created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>
    /// operation. For each import job, this operation returns a summary of its properties,
    /// including its Amazon Resource Name (ARN). You can retrieve the complete set of properties
    /// by using the ARN with the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetImportJob.html">DescribeDatasetImportJob</a>
    /// operation. You can filter the list by providing an array of <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_Filter.html">Filter</a>
    /// objects.
    /// </summary>
    public partial class ListDatasetImportJobsRequest : AmazonForecastServiceRequest
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of filters. For each filter, you provide a condition and a match statement.
        /// The condition is either <c>IS</c> or <c>IS_NOT</c>, which specifies whether to include
        /// or exclude the datasets that match the statement from the list, respectively. The
        /// match statement consists of a key and a value.
        /// </para>
        ///  
        /// <para>
        ///  <b>Filter properties</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Condition</c> - The condition to apply. Valid values are <c>IS</c> and <c>IS_NOT</c>.
        /// To include the datasets that match the statement, specify <c>IS</c>. To exclude matching
        /// datasets, specify <c>IS_NOT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key</c> - The name of the parameter to filter on. Valid values are <c>DatasetArn</c>
        /// and <c>Status</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Value</c> - The value to match.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, to list all dataset import jobs whose status is ACTIVE, you specify the
        /// following filter:
        /// </para>
        ///  
        /// <para>
        ///  <c>"Filters": [ { "Condition": "IS", "Key": "Status", "Value": "ACTIVE" } ]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of items to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// If the result of the previous request was truncated, the response includes a <c>NextToken</c>.
        /// To retrieve the next set of results, use the token in the next request. Tokens expire
        /// after 24 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
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

    }
}