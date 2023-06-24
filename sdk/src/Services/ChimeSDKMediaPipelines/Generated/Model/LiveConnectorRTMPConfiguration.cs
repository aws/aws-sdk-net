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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// The media pipeline's RTMP configuration object.
    /// </summary>
    public partial class LiveConnectorRTMPConfiguration
    {
        private AudioChannelsOption _audioChannels;
        private string _audioSampleRate;
        private string _url;

        /// <summary>
        /// Gets and sets the property AudioChannels. 
        /// <para>
        /// The audio channels set for the RTMP configuration
        /// </para>
        /// </summary>
        public AudioChannelsOption AudioChannels
        {
            get { return this._audioChannels; }
            set { this._audioChannels = value; }
        }

        // Check to see if AudioChannels property is set
        internal bool IsSetAudioChannels()
        {
            return this._audioChannels != null;
        }

        /// <summary>
        /// Gets and sets the property AudioSampleRate. 
        /// <para>
        /// The audio sample rate set for the RTMP configuration. Default: 48000.
        /// </para>
        /// </summary>
        public string AudioSampleRate
        {
            get { return this._audioSampleRate; }
            set { this._audioSampleRate = value; }
        }

        // Check to see if AudioSampleRate property is set
        internal bool IsSetAudioSampleRate()
        {
            return this._audioSampleRate != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the RTMP configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}