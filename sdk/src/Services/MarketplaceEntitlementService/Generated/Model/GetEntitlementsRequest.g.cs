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

namespace Amazon.MarketplaceEntitlementService.Model
{
    /// <summary>
    /// Container for the parameters to the GetEntitlements operation. GetEntitlements retrieves
    /// entitlement values for a given product. The results can be filtered based on customer
    /// identifier, AWS account ID, license ARN, or product dimensions.
    /// </summary>
    public partial class GetEntitlementsRequest : AmazonMarketplaceEntitlementServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filter is used to return entitlements for a specific customer or for a specific dimension.
        /// Filters are described as keys mapped to a lists of values. Filtered requests are <i>unioned</i>
        /// for each value in the value list, and then <i>intersected</i> for each filter key.
        /// </para>
        ///  
        /// <para>
        ///  <c>CustomerIdentifier</c> and <c>CustomerAWSAccountId</c> are mutually exclusive
        /// parameters. You must use one or the other, but not both in the same request. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're migrating an existing integration, use <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/data-feed-account.html">Account
        /// Feeds</a> to map <c>CustomerIdentifier</c> to <c>CustomerAWSAccountId</c>, and <a
        /// href="https://docs.aws.amazon.com/marketplace/latest/userguide/data-feed-agreements.html">Agreements
        /// Feeds</a> to map <c>CustomerAWSAccountId</c> and <c>LicenseArn</c>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Filter { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null && (this.Filter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to retrieve from the GetEntitlements operation. For pagination,
        /// use the NextToken field in subsequent calls to GetEntitlements.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// For paginated calls to GetEntitlements, pass the NextToken from the previous GetEntitlementsResult.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// Product code is used to uniquely identify a product in AWS Marketplace. The product
        /// code will be provided by AWS Marketplace when the product listing is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Checks to see if the ProductCode property is set.
        /// </summary>
        internal bool IsSetProductCode() => this.ProductCode != null;
    }
}
