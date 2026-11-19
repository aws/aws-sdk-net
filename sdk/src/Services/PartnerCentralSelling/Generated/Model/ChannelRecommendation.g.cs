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
    /// Aggregated outreach guidance for leads that share the same country, geography, region,
    /// and company segment. It names the outreach channel most commonly recommended for that
    /// group and, optionally, the days and times that channel is best used. This is group-level
    /// guidance. It doesn't describe an individual lead's contact history or rank recommendations
    /// for a specific lead.
    /// </summary>
    public partial class ChannelRecommendation
    {
        /// <summary>
        /// Gets and sets the property BestOutreachWindows. 
        /// <para>
        /// The recommended day-specific outreach windows for the recommended channel, expressed
        /// in Coordinated Universal Time (UTC). Each window applies to one day, and more than
        /// one window can fall on the same day. This field is optional and appears only when
        /// window guidance is available.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public List<BestOutreachWindow> BestOutreachWindows { get; set; } = AWSConfigs.InitializeCollections ? new List<BestOutreachWindow>() : null;

        /// <summary>
        /// Checks to see if the BestOutreachWindows property is set.
        /// </summary>
        internal bool IsSetBestOutreachWindows() => this.BestOutreachWindows != null && (this.BestOutreachWindows.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecommendedChannel. 
        /// <para>
        /// The recommended outreach channel for the group of similar leads. Valid values are
        /// <c>EMAIL</c> and <c>CALL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RecommendedChannel { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedChannel property is set.
        /// </summary>
        internal bool IsSetRecommendedChannel() => this.RecommendedChannel != null;
    }
}
