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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Required when you set Codec, under AudioDescriptions>CodecSettings, to the value FLAC.
    /// </summary>
    public partial class FlacSettings
    {
        /// <summary>
        /// Gets and sets the property BitDepth. Specify Bit depth (BitDepth), in bits per sample,
        /// to choose the encoding quality for this audio track.
        /// </summary>
        [AWSProperty(Min = 16, Max = 24)]
        public int? BitDepth { get; set; }

        /// <summary>
        /// Checks to see if the BitDepth property is set.
        /// </summary>
        internal bool IsSetBitDepth() => this.BitDepth.HasValue;

        /// <summary>
        /// Gets and sets the property Channels. Specify the number of channels in this output
        /// audio track. Valid values are 0, 1, and even numbers up to 8. Choose 0 to follow the
        /// number of channels from your input audio. Otherwise, manually choose from 1, 2, 4,
        /// 6, and 8.
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public int? Channels { get; set; }

        /// <summary>
        /// Checks to see if the Channels property is set.
        /// </summary>
        internal bool IsSetChannels() => this.Channels.HasValue;

        /// <summary>
        /// Gets and sets the property SampleRate. Sample rate in Hz.
        /// </summary>
        [AWSProperty(Min = 22050, Max = 192000)]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Checks to see if the SampleRate property is set.
        /// </summary>
        internal bool IsSetSampleRate() => this.SampleRate.HasValue;
    }
}
