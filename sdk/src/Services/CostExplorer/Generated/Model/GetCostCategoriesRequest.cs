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
    /// Container for the parameters to the GetCostCategories operation.
    /// Retrieves an array of Cost Category names and values incurred cost.
    /// 
    ///  <note> 
    /// <para>
    /// If some Cost Category names and values are not associated with any cost, they will
    /// not be returned by this API.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetCostCategoriesRequest : AmazonCostExplorerRequest
    {
        private string _billingViewArn;
        private string _costCategoryName;
        private Expression _filter;
        private int? _maxResults;
        private string _nextPageToken;
        private string _searchString;
        private List<SortDefinition> _sortBy = AWSConfigs.InitializeCollections ? new List<SortDefinition>() : null;
        private DateInterval _timePeriod;

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
        /// Gets and sets the property CostCategoryName.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string CostCategoryName
        {
            get { return this._costCategoryName; }
            set { this._costCategoryName = value; }
        }

        // Check to see if CostCategoryName property is set
        internal bool IsSetCostCategoryName()
        {
            return this._costCategoryName != null;
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// This field is only used when the <c>SortBy</c> value is provided in the request.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of objects that are returned for this request. If <c>MaxResults</c>
        /// isn't specified with the <c>SortBy</c> value, the request returns 1000 results as
        /// the default value for this parameter.
        /// </para>
        ///  
        /// <para>
        /// For <c>GetCostCategories</c>, MaxResults has an upper quota of 1000.
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
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// If the number of objects that are still available for retrieval exceeds the quota,
        /// Amazon Web Services returns a NextPageToken value in the response. To retrieve the
        /// next batch of objects, provide the NextPageToken from the previous call in your next
        /// request.
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
        /// Gets and sets the property SearchString. 
        /// <para>
        /// The value that you want to search the filter values for.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a <c>CostCategoryName</c>, <c>SearchString</c> is used to filter
        /// Cost Category names that match the <c>SearchString</c> pattern. If you specify a <c>CostCategoryName</c>,
        /// <c>SearchString</c> is used to filter Cost Category values that match the <c>SearchString</c>
        /// pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SearchString
        {
            get { return this._searchString; }
            set { this._searchString = value; }
        }

        // Check to see if SearchString property is set
        internal bool IsSetSearchString()
        {
            return this._searchString != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value that you sort the data by.
        /// </para>
        ///  
        /// <para>
        /// The key represents the cost and usage metrics. The following values are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BlendedCost</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UnblendedCost</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AmortizedCost</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NetAmortizedCost</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NetUnblendedCost</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UsageQuantity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NormalizedUsageAmount</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The supported key values for the <c>SortOrder</c> value are <c>ASCENDING</c> and <c>DESCENDING</c>.
        /// </para>
        ///  
        /// <para>
        /// When you use the <c>SortBy</c> value, the <c>NextPageToken</c> and <c>SearchString</c>
        /// key values aren't supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SortDefinition> SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null && (this._sortBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimePeriod.
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