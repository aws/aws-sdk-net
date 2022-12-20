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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Audio Track Selection
    /// </summary>
    public partial class AudioTrackSelection
    {
        private AudioDolbyEDecode _dolbyEDecode;
        private List<AudioTrack> _tracks = new List<AudioTrack>();

        /// <summary>
        /// Gets and sets the property DolbyEDecode. Configure decoding options for Dolby E streams
        /// - these should be Dolby E frames carried in PCM streams tagged with SMPTE-337
        /// </summary>
        public AudioDolbyEDecode DolbyEDecode
        {
            get { return this._dolbyEDecode; }
            set { this._dolbyEDecode = value; }
        }

        // Check to see if DolbyEDecode property is set
        internal bool IsSetDolbyEDecode()
        {
            return this._dolbyEDecode != null;
        }

        /// <summary>
        /// Gets and sets the property Tracks. Selects one or more unique audio tracks from within
        /// a source.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AudioTrack> Tracks
        {
            get { return this._tracks; }
            set { this._tracks = value; }
        }

        // Check to see if Tracks property is set
        internal bool IsSetTracks()
        {
            return this._tracks != null && this._tracks.Count > 0; 
        }

    }
}