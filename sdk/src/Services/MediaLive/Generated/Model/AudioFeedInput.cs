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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private string _audioSelectorName;
        private string _feedInput;

        /// <summary>
        /// Gets and sets the property AudioSelectorName. The name of the audio selector in the
        /// channel that will be sent to the Elemental Inference feed input.
        /// </summary>
        public string AudioSelectorName
        {
            get { return this._audioSelectorName; }
            set { this._audioSelectorName = value; }
        }

        // Check to see if AudioSelectorName property is set
        internal bool IsSetAudioSelectorName()
        {
            return this._audioSelectorName != null;
        }

        /// <summary>
        /// Gets and sets the property FeedInput. The name of the feed input on the Elemental
        /// Inference feed that will receive the audio from the specified audio selector.
        /// </summary>
        public string FeedInput
        {
            get { return this._feedInput; }
            set { this._feedInput = value; }
        }

        // Check to see if FeedInput property is set
        internal bool IsSetFeedInput()
        {
            return this._feedInput != null;
        }

    }
}