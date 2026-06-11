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
    /// Represents a single PID value for audio selection with optional pre-mixer settings
    /// </summary>
    public partial class AudioPid
    {
        private AudioDolbyEDecode _dolbyEDecode;
        private int? _pid;
        private AudioPreMixerSettings _premixSettings;

        /// <summary>
        /// Gets and sets the property DolbyEDecode. Configure decoding options for Dolby E streams
        /// - these should be Dolby E frames carried in PCM streams tagged with SMPTE-337.When
        /// using the 'pids' array, if this field is not specified and Dolby E content is present,the
        /// decoder will extract the specified program. To maintain legacy behavior (allPrograms),explicitly
        /// set programSelection to "allChannels".
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
        /// Gets and sets the property Pid. PID value from within a source.
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Pid
        {
            get { return this._pid; }
            set { this._pid = value; }
        }

        // Check to see if Pid property is set
        internal bool IsSetPid()
        {
            return this._pid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PremixSettings. Optional audio pre-mixer settings for this
        /// PID.When specified, allows per-PID audio processing including channel remixing,gain
        /// adjustment, and loudness normalization before interleaving.
        /// </summary>
        public AudioPreMixerSettings PremixSettings
        {
            get { return this._premixSettings; }
            set { this._premixSettings = value; }
        }

        // Check to see if PremixSettings property is set
        internal bool IsSetPremixSettings()
        {
            return this._premixSettings != null;
        }

    }
}