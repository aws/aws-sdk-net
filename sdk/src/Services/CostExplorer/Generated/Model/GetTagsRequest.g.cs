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
    /// Container for the parameters to the GetTags operation. Queries for available tag keys
    /// and tag values for a specified period. You can search the tag values for an arbitrary
    /// string.
    /// </summary>
    public partial class GetTagsRequest : AmazonCostExplorerRequest
    {
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
        /// Gets and sets the property Filter.
        /// </summary>
        public Expression Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// This field is only used when SortBy is provided in the request. The maximum number
        /// of objects that are returned for this request. If MaxResults isn't specified with
        /// SortBy, the request returns 1000 results as the default value for this parameter.
        /// </para>
        ///  
        /// <para>
        /// For <c>GetTags</c>, MaxResults has an upper quota of 1000.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Checks to see if the NextPageToken property is set.
        /// </summary>
        internal bool IsSetNextPageToken() => this.NextPageToken != null;

        /// <summary>
        /// Gets and sets the property SearchString. 
        /// <para>
        /// The value that you want to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SearchString { get; set; }

        /// <summary>
        /// Checks to see if the SearchString property is set.
        /// </summary>
        internal bool IsSetSearchString() => this.SearchString != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value that you want to sort the data by.
        /// </para>
        ///  
        /// <para>
        /// The key represents cost and usage metrics. The following values are supported:
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
        /// The supported values for <c>SortOrder</c> are <c>ASCENDING</c> and <c>DESCENDING</c>.
        /// </para>
        ///  
        /// <para>
        /// When you use <c>SortBy</c>, <c>NextPageToken</c> and <c>SearchString</c> aren't supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SortDefinition> SortBy { get; set; } = AWSConfigs.InitializeCollections ? new List<SortDefinition>() : null;

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null && (this.SortBy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The key of the tag that you want to return values for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TagKey { get; set; }

        /// <summary>
        /// Checks to see if the TagKey property is set.
        /// </summary>
        internal bool IsSetTagKey() => this.TagKey != null;

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The start and end dates for retrieving the dimension values. The start date is inclusive,
        /// but the end date is exclusive. For example, if <c>start</c> is <c>2017-01-01</c> and
        /// <c>end</c> is <c>2017-05-01</c>, then the cost and usage data is retrieved from <c>2017-01-01</c>
        /// up to and including <c>2017-04-30</c> but not including <c>2017-05-01</c>.
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
