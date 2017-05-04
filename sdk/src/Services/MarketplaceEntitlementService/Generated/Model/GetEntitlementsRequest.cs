/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the entitlement.marketplace-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MarketplaceEntitlementService.Model
{
    /// <summary>
    /// Container for the parameters to the GetEntitlements operation.
    /// GetEntitlements retrieves entitlement values for a given product. The results can
    /// be filtered based on customer identifier or product dimensions.
    /// </summary>
    public partial class GetEntitlementsRequest : AmazonMarketplaceEntitlementServiceRequest
    {
        private Dictionary<string, List<string>> _filter = new Dictionary<string, List<string>>();
        private int? _maxResults;
        private string _nextToken;
        private string _productCode;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filter is used to return entitlements for a specific customer or for a specific dimension.
        /// Filters are described as keys mapped to a lists of values. Filtered requests are <i>unioned</i>
        /// for each value in the value list, and then <i>intersected</i> for each filter key.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null && this._filter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to retrieve from the GetEntitlements operation. For pagination,
        /// use the NextToken field in subsequent calls to GetEntitlements.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// For paginated calls to GetEntitlements, pass the NextToken from the previous GetEntitlementsResult.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// Product code is used to uniquely identify a product in AWS Marketplace. The product
        /// code will be provided by AWS Marketplace when the product listing is created.
        /// </para>
        /// </summary>
        public string ProductCode
        {
            get { return this._productCode; }
            set { this._productCode = value; }
        }

        // Check to see if ProductCode property is set
        internal bool IsSetProductCode()
        {
            return this._productCode != null;
        }

    }
}