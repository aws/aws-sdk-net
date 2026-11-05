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
    /// Standard Hls Settings
    /// </summary>
    public partial class StandardHlsSettings
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
        /// Gets and sets the property M3u8Settings.
        /// </summary>
        [AWSProperty(Required = true)]
        public M3u8Settings M3u8Settings { get; set; }

        /// <summary>
        /// Checks to see if the M3u8Settings property is set.
        /// </summary>
        internal bool IsSetM3u8Settings() => this.M3u8Settings != null;
    }
}
