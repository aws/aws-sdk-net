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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Metadata information about an audio stream. An array of <c>AudioMetadata</c> objects
    /// for the audio streams found in a stored video is returned by <a>GetSegmentDetection</a>.
    /// </summary>
    public partial class AudioMetadata
    {
        /// <summary>
        /// Gets and sets the property Codec. 
        /// <para>
        /// The audio codec used to encode or decode the audio stream. 
        /// </para>
        /// </summary>
        public string Codec { get; set; }

        /// <summary>
        /// Checks to see if the Codec property is set.
        /// </summary>
        internal bool IsSetCodec() => this.Codec != null;

        /// <summary>
        /// Gets and sets the property DurationMillis. 
        /// <para>
        /// The duration of the audio stream in milliseconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? DurationMillis { get; set; }

        /// <summary>
        /// Checks to see if the DurationMillis property is set.
        /// </summary>
        internal bool IsSetDurationMillis() => this.DurationMillis.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfChannels. 
        /// <para>
        /// The number of audio channels in the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? NumberOfChannels { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfChannels property is set.
        /// </summary>
        internal bool IsSetNumberOfChannels() => this.NumberOfChannels.HasValue;

        /// <summary>
        /// Gets and sets the property SampleRate. 
        /// <para>
        /// The sample rate for the audio stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? SampleRate { get; set; }

        /// <summary>
        /// Checks to see if the SampleRate property is set.
        /// </summary>
        internal bool IsSetSampleRate() => this.SampleRate.HasValue;
    }
}
