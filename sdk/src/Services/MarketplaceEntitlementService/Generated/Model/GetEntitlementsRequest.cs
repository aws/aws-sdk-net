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
 * Do not modify this file. This file is generated from the entitlement.marketplace-2017-01-11.normal.json service model.
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
namespace Amazon.MarketplaceEntitlementService.Model
{
    /// <summary>
    /// Container for the parameters to the GetEntitlements operation.
    /// GetEntitlements retrieves entitlement values for a given product. The results can
    /// be filtered based on customer identifier, AWS account ID, or product dimensions.
    /// 
    ///  <important> 
    /// <para>
    ///  The <c>CustomerIdentifier</c> parameter is on path for deprecation. Use <c>CustomerAWSAccountID</c>
    /// instead.
    /// </para>
    ///  
    /// <para>
    /// These parameters are mutually exclusive. You can't specify both <c>CustomerIdentifier</c>
    /// and <c>CustomerAWSAccountID</c> in the same request. 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class GetEntitlementsRequest : AmazonMarketplaceEntitlementServiceRequest
    {
        private Dictionary<string, List<string>> _filter = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
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
        ///  
        /// <para>
        ///  <c>CustomerIdentifier</c> and <c>CustomerAWSAccountID</c> are mutually exclusive.
        /// You can't specify both in the same request. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null && (this._filter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to retrieve from the GetEntitlements operation. For pagination,
        /// use the NextToken field in subsequent calls to GetEntitlements.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
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
        [AWSProperty(Required=true, Min=1, Max=255)]
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