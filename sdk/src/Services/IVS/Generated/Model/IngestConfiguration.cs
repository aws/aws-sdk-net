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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
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
namespace Amazon.IVS.Model
{
    /// <summary>
    /// Object specifying the ingest configuration set up by the broadcaster, usually in an
    /// encoder.
    /// 
    ///  
    /// <para>
    ///  <b>Note:</b> IngestConfiguration is deprecated in favor of <a>IngestConfigurations</a>
    /// but retained to ensure backward compatibility. If multitrack is not enabled, IngestConfiguration
    /// and IngestConfigurations contain the same data, namely information about track0 (the
    /// sole track). If multitrack is enabled, IngestConfiguration contains data for only
    /// the first track (track0) and IngestConfigurations contains data for all tracks.
    /// </para>
    /// </summary>
    public partial class IngestConfiguration
    {
        private AudioConfiguration _audio;
        private VideoConfiguration _video;

        /// <summary>
        /// Gets and sets the property Audio. 
        /// <para>
        /// Encoder settings for audio.
        /// </para>
        /// </summary>
        public AudioConfiguration Audio
        {
            get { return this._audio; }
            set { this._audio = value; }
        }

        // Check to see if Audio property is set
        internal bool IsSetAudio()
        {
            return this._audio != null;
        }

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// Encoder settings for video.
        /// </para>
        /// </summary>
        public VideoConfiguration Video
        {
            get { return this._video; }
            set { this._video = value; }
        }

        // Check to see if Video property is set
        internal bool IsSetVideo()
        {
            return this._video != null;
        }

    }
}