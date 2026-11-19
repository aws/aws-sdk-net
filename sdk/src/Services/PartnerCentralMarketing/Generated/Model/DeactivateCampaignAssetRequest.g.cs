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
    /// Container for the parameters to the DeactivateCampaignAsset operation. Stops a live
    /// campaign asset: an email's scheduled send is withdrawn, a social post is removed before
    /// it publishes. On a completed campaign, it also removes a published document, banner
    /// or landing page. Synchronous, and safe to repeat. Does not delete the asset record,
    /// so a stopped email or social post can be started again. Not every asset can be stopped,
    /// and the reasons differ in kind. An email that has begun sending **cannot** be recalled:
    /// the send is gone. A document, a banner or a landing page is **refused** with `ASSET_NOT_DEACTIVATABLE`
    /// until the campaign has completed (the UTC date is after its `EndOn`). Until then the
    /// partner fixes one in place by updating it and activating it again, which keeps its
    /// URL, so every email that already linked to it keeps working. Once the campaign has
    /// completed, the removal is permanent, because a completed campaign can't activate anything
    /// again: - A document's published PDF is deleted. Its URL stops serving within about
    /// a minute (the CDN revalidates), and `PublicUrl` is no longer returned. Anything that
    /// linked to it, such as a landing page's download button or a sent email, reaches an
    /// error page. The export still contains the document. - A banner's or landing page's
    /// published object is taken down at the delivery platform, and the images the partner
    /// put on it are deleted. A landing page stops capturing leads, and its `PublicUrl` is
    /// no longer returned. A partner site that embedded a banner shows nothing there. The
    /// platform's own CDN can keep serving a copy a visitor already cached, which collects
    /// nothing. A landing page and a document it links to can be removed in either order.
    /// </summary>
    public partial class DeactivateCampaignAssetRequest : AmazonPartnerCentralMarketingRequest
    {
        /// <summary>
        /// Gets and sets the property CampaignAssetIdentifier. The asset identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 17)]
        public string CampaignAssetIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CampaignAssetIdentifier property is set.
        /// </summary>
        internal bool IsSetCampaignAssetIdentifier() => this.CampaignAssetIdentifier != null;

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
    }
}
