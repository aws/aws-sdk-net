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
    /// Maps an audio selector in the channel to a feed input on the associated Elemental
    /// Inference feed.
    /// </summary>
    public partial class AudioFeedInput
    {
        /// <summary>
        /// Gets and sets the property AudioSelectorName. The name of the audio selector in the
        /// channel that will be sent to the Elemental Inference feed input.
        /// </summary>
        public string AudioSelectorName { get; set; }

        /// <summary>
        /// Checks to see if the AudioSelectorName property is set.
        /// </summary>
        internal bool IsSetAudioSelectorName() => this.AudioSelectorName != null;

        /// <summary>
        /// Gets and sets the property FeedInput. The name of the feed input on the Elemental
        /// Inference feed that will receive the audio from the specified audio selector.
        /// </summary>
        public string FeedInput { get; set; }

        /// <summary>
        /// Checks to see if the FeedInput property is set.
        /// </summary>
        internal bool IsSetFeedInput() => this.FeedInput != null;
    }
}
