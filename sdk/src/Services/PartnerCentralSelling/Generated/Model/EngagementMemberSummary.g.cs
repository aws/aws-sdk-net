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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// The EngagementMemberSummary provides a snapshot of essential information about participants
    /// in an AWS Partner Central Engagement. This compact data structure encapsulates key
    /// details of each member, facilitating efficient collaboration and management within
    /// the Engagement.
    /// </summary>
    public partial class EngagementMemberSummary
    {
        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// The official name of the member's company or organization.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Checks to see if the CompanyName property is set.
        /// </summary>
        internal bool IsSetCompanyName() => this.CompanyName != null;

        /// <summary>
        /// Gets and sets the property WebsiteUrl. 
        /// <para>
        /// The URL of the member company's website. This offers a way to find more information
        /// about the member organization and serves as an additional identifier. 
        /// </para>
        /// </summary>
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// Checks to see if the WebsiteUrl property is set.
        /// </summary>
        internal bool IsSetWebsiteUrl() => this.WebsiteUrl != null;
    }
}
