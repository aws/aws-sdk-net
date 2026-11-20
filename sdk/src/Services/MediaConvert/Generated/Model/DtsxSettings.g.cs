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
    /// Required when you set Codec to the value DTSX.
    /// </summary>
    public partial class DtsxSettings
    {
        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate for the DTS:X Profile
        /// 2 stream, in bits per second. Valid values depend on the coding mode: 160000, 192000,
        /// 224000, 256000, 288000 and 320000 for CODING_MODE_5_1, and 288000, 384000 and 448000
        /// for CODING_MODE_5_1_4.
        /// </summary>
        [AWSProperty(Min = 160000, Max = 448000)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property CodingMode. DTS:X coding mode. Determines the number of
        /// input channels and the channel layout that the encoder emits. - CODING_MODE_5_1: 5.1
        /// surround - CODING_MODE_5_1_4: 5.1.4 immersive
        /// </summary>
        public DtsxCodingMode CodingMode { get; set; }

        /// <summary>
        /// Checks to see if the CodingMode property is set.
        /// </summary>
        internal bool IsSetCodingMode() => this.CodingMode != null;

        /// <summary>
        /// Gets and sets the property SampleRate. This value must be 48000. It represents the
        /// sample rate in Hz.
        /// </summary>
        [AWSProperty(Min = 48000, Max = 48000)]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Checks to see if the SampleRate property is set.
        /// </summary>
        internal bool IsSetSampleRate() => this.SampleRate.HasValue;
    }
}
