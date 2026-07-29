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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// Container for the parameters to the GetBillingPreferences operation.
    /// Retrieves billing preferences for the specified feature. Each feature controls a distinct
    /// billing capability: which accounts can share Reserved Instances or credits, whether
    /// billing alerts are enabled, the historical record of sharing changes, and per-credit
    /// options.
    /// </summary>
    public partial class GetBillingPreferencesRequest : AmazonBillingRequest
    {
        private List<string> _features = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<BillingFeatureFilter> _filters = AWSConfigs.InitializeCollections ? new List<BillingFeatureFilter>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// The feature to retrieve. Specify exactly one value. Valid values: <c>BILLING_ALERTS</c>,
        /// <c>RI_SHARING</c>, <c>RI_SHARING_HISTORY</c>, <c>CREDIT_SHARING</c>, <c>CREDIT_SHARING_HISTORY</c>,
        /// <c>CREDIT_LEVEL_SHARING</c>, <c>CREDIT_PREFERENCE_OPTIONS</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null && (this._features.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters to narrow results. Specify exactly one filter when supplied. The supported
        /// filter name is <c>PREFERENCE_KEY</c>, which accepts 1 to 10 values to match preference
        /// keys.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<BillingFeatureFilter> Filters
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
        /// The maximum number of records to return per page. Range: 1 to 50. Default: 50.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Pagination token from a previous response. Pass the value returned in <c>nextToken</c>
        /// to retrieve the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4095)]
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