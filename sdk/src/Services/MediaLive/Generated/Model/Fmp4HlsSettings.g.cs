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
    /// Fmp4 Hls Settings
    /// </summary>
    public partial class Fmp4HlsSettings
    {
        /// <summary>
        /// Gets and sets the property AudioRenditionSets. List all the audio groups that are
        /// used with the video output stream. Input all the audio GROUP-IDs that are associated
        /// to the video, separate by ','.
        /// </summary>
        public string AudioRenditionSets { get; set; }

        /// <summary>
        /// Checks to see if the AudioRenditionSets property is set.
        /// </summary>
        internal bool IsSetAudioRenditionSets() => this.AudioRenditionSets != null;

        /// <summary>
        /// Gets and sets the property NielsenId3Behavior. If set to passthrough, Nielsen inaudible
        /// tones for media tracking will be detected in the input audio and an equivalent ID3
        /// tag will be inserted in the output.
        /// </summary>
        public Fmp4NielsenId3Behavior NielsenId3Behavior { get; set; }

        /// <summary>
        /// Checks to see if the NielsenId3Behavior property is set.
        /// </summary>
        internal bool IsSetNielsenId3Behavior() => this.NielsenId3Behavior != null;

        /// <summary>
        /// Gets and sets the property TimedMetadataBehavior. Set to PASSTHROUGH to enable ID3
        /// metadata insertion. To include metadata, you configure other parameters in the output
        /// group or individual outputs, or you add an ID3 action to the channel schedule.
        /// </summary>
        public Fmp4TimedMetadataBehavior TimedMetadataBehavior { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataBehavior property is set.
        /// </summary>
        internal bool IsSetTimedMetadataBehavior() => this.TimedMetadataBehavior != null;
    }
}
