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
 * Do not modify this file. This file is generated from the marketplace-reporting-2018-05-10.normal.json service model.
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
namespace Amazon.MarketplaceReporting.Model
{
    /// <summary>
    /// Container for the parameters to the GetBuyerDashboard operation.
    /// Generates an embedding URL for an Amazon QuickSight dashboard for an anonymous user.
    /// 
    ///  <note> 
    /// <para>
    /// This API is available only to Amazon Web Services Organization management accounts
    /// or delegated administrators registered for the procurement insights (<c>procurement-insights.marketplace.amazonaws.com</c>)
    /// feature.
    /// </para>
    ///  </note> 
    /// <para>
    /// The following rules apply to a generated URL:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// It contains a temporary bearer token, valid for 5 minutes after it is generated. Once
    /// redeemed within that period, it cannot be re-used again.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// It has a session lifetime of one hour. The 5-minute validity period runs separately
    /// from the session lifetime.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetBuyerDashboardRequest : AmazonMarketplaceReportingRequest
    {
        private string _dashboardIdentifier;
        private List<string> _embeddingDomains = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DashboardIdentifier. 
        /// <para>
        /// The ARN of the requested dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1023)]
        public string DashboardIdentifier
        {
            get { return this._dashboardIdentifier; }
            set { this._dashboardIdentifier = value; }
        }

        // Check to see if DashboardIdentifier property is set
        internal bool IsSetDashboardIdentifier()
        {
            return this._dashboardIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EmbeddingDomains. 
        /// <para>
        /// Fully qualified domains that you add to the allow list for access to the generated
        /// URL that is then embedded. You can list up to two domains or subdomains in each API
        /// call. To include all subdomains under a specific domain, use <c>*</c>. For example,
        /// <c>https://*.amazon.com</c> includes all subdomains under <c>https://aws.amazon.com</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<string> EmbeddingDomains
        {
            get { return this._embeddingDomains; }
            set { this._embeddingDomains = value; }
        }

        // Check to see if EmbeddingDomains property is set
        internal bool IsSetEmbeddingDomains()
        {
            return this._embeddingDomains != null && (this._embeddingDomains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}