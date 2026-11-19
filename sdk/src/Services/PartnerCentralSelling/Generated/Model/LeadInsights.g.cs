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
    /// Contains insights that AI generates for a lead. These insights provide automated analysis
    /// to help partners evaluate the lead quality and prioritize engagement efforts.
    /// </summary>
    public partial class LeadInsights
    {
        /// <summary>
        /// Gets and sets the property ChannelRecommendation. 
        /// <para>
        /// The outreach channel most commonly recommended for leads that share this lead's country,
        /// geography, region, and company segment. It includes the days and the Coordinated Universal
        /// Time (UTC) hours when that channel is best used. This is guidance for the group of
        /// similar leads. It doesn't describe this lead's own contact history. Present only when
        /// a recommendation is available for the lead.
        /// </para>
        /// </summary>
        public ChannelRecommendation ChannelRecommendation { get; set; }

        /// <summary>
        /// Checks to see if the ChannelRecommendation property is set.
        /// </summary>
        internal bool IsSetChannelRecommendation() => this.ChannelRecommendation != null;

        /// <summary>
        /// Gets and sets the property LeadReadinessScore. 
        /// <para>
        /// A score that indicates the lead's readiness for engagement. Valid values are <c>Low</c>,
        /// <c>Medium</c>, and <c>High</c>. Use this score to prioritize leads based on their
        /// likelihood of conversion.
        /// </para>
        /// </summary>
        public string LeadReadinessScore { get; set; }

        /// <summary>
        /// Checks to see if the LeadReadinessScore property is set.
        /// </summary>
        internal bool IsSetLeadReadinessScore() => this.LeadReadinessScore != null;
    }
}
