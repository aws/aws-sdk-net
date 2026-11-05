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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Configures Elemental Inference features in a channel.
    /// </summary>
    public partial class DescribeInferenceSettings
    {
        /// <summary>
        /// Gets and sets the property AudioFeedInputs. A list of audio feed inputs that map audio
        /// selectors in the channel to feed inputs on the associated Elemental Inference feed.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AudioFeedInput> AudioFeedInputs { get; set; } = AWSConfigs.InitializeCollections ? new List<AudioFeedInput>() : null;

        /// <summary>
        /// Checks to see if the AudioFeedInputs property is set.
        /// </summary>
        internal bool IsSetAudioFeedInputs() => this.AudioFeedInputs != null && (this.AudioFeedInputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnrichmentMethods. The set of Contextual Metadata Enrichment
        /// methods enabled for this channel. Each method represents a specific way the channel
        /// uses the inference feed to augment its output with contextual metadata.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnrichmentMethods { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnrichmentMethods property is set.
        /// </summary>
        internal bool IsSetEnrichmentMethods() => this.EnrichmentMethods != null && (this.EnrichmentMethods.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FeedArn. The ARN of the feed resource that is associated
        /// with this channel. The feed is a resource in the Elemental Inference service.
        /// </summary>
        public string FeedArn { get; set; }

        /// <summary>
        /// Checks to see if the FeedArn property is set.
        /// </summary>
        internal bool IsSetFeedArn() => this.FeedArn != null;
    }
}
