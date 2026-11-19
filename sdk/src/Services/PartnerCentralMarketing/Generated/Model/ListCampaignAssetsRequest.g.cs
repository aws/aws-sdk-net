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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// Container for the parameters to the ListCampaignAssets operation. Lists assets for
    /// a campaign with pagination.
    /// </summary>
    public partial class ListCampaignAssetsRequest : AmazonPartnerCentralMarketingRequest
    {
        /// <summary>
        /// Gets and sets the property CampaignIdentifier. The campaign identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 200)]
        public string CampaignIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CampaignIdentifier property is set.
        /// </summary>
        internal bool IsSetCampaignIdentifier() => this.CampaignIdentifier != null;

        /// <summary>
        /// Gets and sets the property Catalog. The catalog (AWS or Sandbox).
        /// </summary>
        [AWSProperty(Required = true)]
        public Catalog Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property MaxResults. Maximum results per page.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. Pagination token.
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
