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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
    /// For forensic video watermarking, MediaConvert supports Nagra NexGuard File Marker
    /// watermarking. MediaConvert supports both PreRelease Content (NGPR/G2) and OTT Streaming
    /// workflows.
    /// </summary>
    public partial class NexGuardFileMarkerSettings
    {
        private string _license;
        private int? _payload;
        private string _preset;
        private WatermarkingStrength _strength;

        /// <summary>
        /// Gets and sets the property License. Use the base64 license string that Nagra provides
        /// you. Enter it directly in your JSON job specification or in the console. Required
        /// when you include Nagra NexGuard File Marker watermarking in your job.
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public string License
        {
            get { return this._license; }
            set { this._license = value; }
        }

        // Check to see if License property is set
        internal bool IsSetLicense()
        {
            return this._license != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. Specify the payload ID that you want associated
        /// with this output. Valid values vary depending on your Nagra NexGuard forensic watermarking
        /// workflow. Required when you include Nagra NexGuard File Marker watermarking in your
        /// job. For PreRelease Content (NGPR/G2), specify an integer from 1 through 4,194,303.
        /// You must generate a unique ID for each asset you watermark, and keep a record of which
        /// ID you have assigned to each asset. Neither Nagra nor MediaConvert keep track of the
        /// relationship between output files and your IDs. For OTT Streaming, create two adaptive
        /// bitrate (ABR) stacks for each asset. Do this by setting up two output groups. For
        /// one output group, set the value of Payload ID to 0 in every output. For the other
        /// output group, set Payload ID to 1 in every output.
        /// </summary>
        [AWSProperty(Min=0, Max=4194303)]
        public int? Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Preset. Enter one of the watermarking preset strings that
        /// Nagra provides you. Required when you include Nagra NexGuard File Marker watermarking
        /// in your job.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Preset
        {
            get { return this._preset; }
            set { this._preset = value; }
        }

        // Check to see if Preset property is set
        internal bool IsSetPreset()
        {
            return this._preset != null;
        }

        /// <summary>
        /// Gets and sets the property Strength. Optional. Ignore this setting unless Nagra support
        /// directs you to specify a value. When you don't specify a value here, the Nagra NexGuard
        /// library uses its default value.
        /// </summary>
        public WatermarkingStrength Strength
        {
            get { return this._strength; }
            set { this._strength = value; }
        }

        // Check to see if Strength property is set
        internal bool IsSetStrength()
        {
            return this._strength != null;
        }

    }
}