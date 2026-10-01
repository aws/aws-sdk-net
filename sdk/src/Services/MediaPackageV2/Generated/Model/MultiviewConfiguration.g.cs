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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// The multiview configuration for a channel. A multiview channel composites video from
    /// several source channels into a single tiled output stream. Players receive one standard
    /// HLS or DASH stream instead of several separate streams. This setting is required when
    /// <c>InputType</c> is <c>MULTIVIEW</c>, and can't be set for any other input type.
    /// </summary>
    public partial class MultiviewConfiguration
    {
        /// <summary>
        /// Gets and sets the property AvailableLayouts. 
        /// <para>
        /// The tile layouts that players can request from this multiview channel's origin endpoints.
        /// Only the layouts that you list here are available. Each layout must appear at most
        /// once.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 6)]
        public List<string> AvailableLayouts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailableLayouts property is set.
        /// </summary>
        internal bool IsSetAvailableLayouts() => this.AvailableLayouts != null && (this.AvailableLayouts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailableSources. 
        /// <para>
        /// The channels that players can use as tiles in this multiview channel's output. Each
        /// source channel must be in the same channel group as the multiview channel, and must
        /// have an <c>InputType</c> of <c>CMAF</c>. Only the channels that you list here are
        /// available as tiles.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> AvailableSources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailableSources property is set.
        /// </summary>
        internal bool IsSetAvailableSources() => this.AvailableSources != null && (this.AvailableSources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
