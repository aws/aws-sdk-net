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
    /// Audio Codec Settings
    /// </summary>
    public partial class AudioCodecSettings
    {
        /// <summary>
        /// Gets and sets the property AacSettings.
        /// </summary>
        public AacSettings AacSettings { get; set; }

        /// <summary>
        /// Checks to see if the AacSettings property is set.
        /// </summary>
        internal bool IsSetAacSettings() => this.AacSettings != null;

        /// <summary>
        /// Gets and sets the property Ac3Settings.
        /// </summary>
        public Ac3Settings Ac3Settings { get; set; }

        /// <summary>
        /// Checks to see if the Ac3Settings property is set.
        /// </summary>
        internal bool IsSetAc3Settings() => this.Ac3Settings != null;

        /// <summary>
        /// Gets and sets the property Eac3AtmosSettings.
        /// </summary>
        public Eac3AtmosSettings Eac3AtmosSettings { get; set; }

        /// <summary>
        /// Checks to see if the Eac3AtmosSettings property is set.
        /// </summary>
        internal bool IsSetEac3AtmosSettings() => this.Eac3AtmosSettings != null;

        /// <summary>
        /// Gets and sets the property Eac3Settings.
        /// </summary>
        public Eac3Settings Eac3Settings { get; set; }

        /// <summary>
        /// Checks to see if the Eac3Settings property is set.
        /// </summary>
        internal bool IsSetEac3Settings() => this.Eac3Settings != null;

        /// <summary>
        /// Gets and sets the property Mp2Settings.
        /// </summary>
        public Mp2Settings Mp2Settings { get; set; }

        /// <summary>
        /// Checks to see if the Mp2Settings property is set.
        /// </summary>
        internal bool IsSetMp2Settings() => this.Mp2Settings != null;

        /// <summary>
        /// Gets and sets the property PassThroughSettings.
        /// </summary>
        public PassThroughSettings PassThroughSettings { get; set; }

        /// <summary>
        /// Checks to see if the PassThroughSettings property is set.
        /// </summary>
        internal bool IsSetPassThroughSettings() => this.PassThroughSettings != null;

        /// <summary>
        /// Gets and sets the property WavSettings.
        /// </summary>
        public WavSettings WavSettings { get; set; }

        /// <summary>
        /// Checks to see if the WavSettings property is set.
        /// </summary>
        internal bool IsSetWavSettings() => this.WavSettings != null;
    }
}
