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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Configuration for transcript related features
    /// </summary>
    public partial class TranscriptConfiguration
    {
        private ChannelLabelingConfiguration _channelLabeling;
        private SpeakerLabelingConfiguration _speakerLabeling;

        /// <summary>
        /// Gets and sets the property ChannelLabeling.
        /// </summary>
        public ChannelLabelingConfiguration ChannelLabeling
        {
            get { return this._channelLabeling; }
            set { this._channelLabeling = value; }
        }

        // Check to see if ChannelLabeling property is set
        internal bool IsSetChannelLabeling()
        {
            return this._channelLabeling != null;
        }

        /// <summary>
        /// Gets and sets the property SpeakerLabeling.
        /// </summary>
        public SpeakerLabelingConfiguration SpeakerLabeling
        {
            get { return this._speakerLabeling; }
            set { this._speakerLabeling = value; }
        }

        // Check to see if SpeakerLabeling property is set
        internal bool IsSetSpeakerLabeling()
        {
            return this._speakerLabeling != null;
        }

    }
}