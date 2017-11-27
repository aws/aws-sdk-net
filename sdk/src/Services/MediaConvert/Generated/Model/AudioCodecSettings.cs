/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Audio codec settings (CodecSettings) under (AudioDescriptions) contains the group
    /// of settings related to audio encoding. The settings in this group vary depending on
    /// the value you choose for Audio codec (Codec). For each codec enum you choose, define
    /// the corresponding settings object. The following lists the codec enum, settings object
    /// pairs. * AAC, AacSettings * MP2, Mp2Settings * WAV, WavSettings * AIFF, AiffSettings
    /// * AC3, Ac3Settings * EAC3, Eac3Settings
    /// </summary>
    public partial class AudioCodecSettings
    {
        private AacSettings _aacSettings;
        private Ac3Settings _ac3Settings;
        private AiffSettings _aiffSettings;
        private AudioCodec _codec;
        private Eac3Settings _eac3Settings;
        private Mp2Settings _mp2Settings;
        private WavSettings _wavSettings;

        /// <summary>
        /// Gets and sets the property AacSettings.
        /// </summary>
        public AacSettings AacSettings
        {
            get { return this._aacSettings; }
            set { this._aacSettings = value; }
        }

        // Check to see if AacSettings property is set
        internal bool IsSetAacSettings()
        {
            return this._aacSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Ac3Settings.
        /// </summary>
        public Ac3Settings Ac3Settings
        {
            get { return this._ac3Settings; }
            set { this._ac3Settings = value; }
        }

        // Check to see if Ac3Settings property is set
        internal bool IsSetAc3Settings()
        {
            return this._ac3Settings != null;
        }

        /// <summary>
        /// Gets and sets the property AiffSettings.
        /// </summary>
        public AiffSettings AiffSettings
        {
            get { return this._aiffSettings; }
            set { this._aiffSettings = value; }
        }

        // Check to see if AiffSettings property is set
        internal bool IsSetAiffSettings()
        {
            return this._aiffSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Codec.
        /// </summary>
        public AudioCodec Codec
        {
            get { return this._codec; }
            set { this._codec = value; }
        }

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this._codec != null;
        }

        /// <summary>
        /// Gets and sets the property Eac3Settings.
        /// </summary>
        public Eac3Settings Eac3Settings
        {
            get { return this._eac3Settings; }
            set { this._eac3Settings = value; }
        }

        // Check to see if Eac3Settings property is set
        internal bool IsSetEac3Settings()
        {
            return this._eac3Settings != null;
        }

        /// <summary>
        /// Gets and sets the property Mp2Settings.
        /// </summary>
        public Mp2Settings Mp2Settings
        {
            get { return this._mp2Settings; }
            set { this._mp2Settings = value; }
        }

        // Check to see if Mp2Settings property is set
        internal bool IsSetMp2Settings()
        {
            return this._mp2Settings != null;
        }

        /// <summary>
        /// Gets and sets the property WavSettings.
        /// </summary>
        public WavSettings WavSettings
        {
            get { return this._wavSettings; }
            set { this._wavSettings = value; }
        }

        // Check to see if WavSettings property is set
        internal bool IsSetWavSettings()
        {
            return this._wavSettings != null;
        }

    }
}