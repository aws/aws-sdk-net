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
    /// A partner's branding, read from their AWS Partner Central profile. 
    /// &lt;para&gt;
    /// The profile is the only source: a campaign carries no branding of its own, so every
    /// campaign of a partner shows the same identity, vetted by Partner Central. Edit it
    /// in Partner Central.
    /// </summary>
    public partial class PartnerProfileBranding
    {
        /// <summary>
        /// Gets and sets the property DisplayName. The profile's display name.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property LogoUrl. The profile's logo URL, as AWS Partner Central
        /// serves it — the image every asset of the campaign shows. Absent when the profile names
        /// none. 
        /// &lt;para&gt;
        /// Partner Central Marketing keeps no copy: the same URL is written into a published
        /// landing page and email, and fetched when a document is composed, so what a client
        /// renders from it is what is sent. Only a document fetches the image: one it cannot
        /// fetch and draw fails that asset with `INTERNAL_ERROR`, which a retry can clear. A
        /// landing page or email links the URL as given, so a logo that does not load shows as
        /// a broken image.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Checks to see if the LogoUrl property is set.
        /// </summary>
        internal bool IsSetLogoUrl() => this.LogoUrl != null;

        /// <summary>
        /// Gets and sets the property RefreshedAt. When this branding was last read from Partner
        /// Central. Earlier than the request when Partner Central could not be reached and Partner
        /// Central Marketing answered from its last copy.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? RefreshedAt { get; set; }

        /// <summary>
        /// Checks to see if the RefreshedAt property is set.
        /// </summary>
        internal bool IsSetRefreshedAt() => this.RefreshedAt.HasValue;

        /// <summary>
        /// Gets and sets the property WebsiteUrl. The profile's website.
        /// </summary>
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// Checks to see if the WebsiteUrl property is set.
        /// </summary>
        internal bool IsSetWebsiteUrl() => this.WebsiteUrl != null;
    }
}
