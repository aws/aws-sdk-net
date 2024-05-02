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
    /// Settings for one failover condition.
    /// </summary>
    public partial class FailoverConditionSettings
    {
        private AudioSilenceFailoverSettings _audioSilenceSettings;
        private InputLossFailoverSettings _inputLossSettings;
        private VideoBlackFailoverSettings _videoBlackSettings;

        /// <summary>
        /// Gets and sets the property AudioSilenceSettings. MediaLive will perform a failover
        /// if the specified audio selector is silent for the specified period.
        /// </summary>
        public AudioSilenceFailoverSettings AudioSilenceSettings
        {
            get { return this._audioSilenceSettings; }
            set { this._audioSilenceSettings = value; }
        }

        // Check to see if AudioSilenceSettings property is set
        internal bool IsSetAudioSilenceSettings()
        {
            return this._audioSilenceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property InputLossSettings. MediaLive will perform a failover if
        /// content is not detected in this input for the specified period.
        /// </summary>
        public InputLossFailoverSettings InputLossSettings
        {
            get { return this._inputLossSettings; }
            set { this._inputLossSettings = value; }
        }

        // Check to see if InputLossSettings property is set
        internal bool IsSetInputLossSettings()
        {
            return this._inputLossSettings != null;
        }

        /// <summary>
        /// Gets and sets the property VideoBlackSettings. MediaLive will perform a failover if
        /// content is considered black for the specified period.
        /// </summary>
        public VideoBlackFailoverSettings VideoBlackSettings
        {
            get { return this._videoBlackSettings; }
            set { this._videoBlackSettings = value; }
        }

        // Check to see if VideoBlackSettings property is set
        internal bool IsSetVideoBlackSettings()
        {
            return this._videoBlackSettings != null;
        }

    }
}