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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
        private string _codec;
        private long? _durationMillis;
        private long? _numberOfChannels;
        private long? _sampleRate;

        /// <summary>
        /// Gets and sets the property Codec. 
        /// <para>
        /// The audio codec used to encode or decode the audio stream. 
        /// </para>
        /// </summary>
        public string Codec
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
        /// Gets and sets the property DurationMillis. 
        /// <para>
        /// The duration of the audio stream in milliseconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? DurationMillis
        {
            get { return this._durationMillis; }
            set { this._durationMillis = value; }
        }

        // Check to see if DurationMillis property is set
        internal bool IsSetDurationMillis()
        {
            return this._durationMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfChannels. 
        /// <para>
        /// The number of audio channels in the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? NumberOfChannels
        {
            get { return this._numberOfChannels; }
            set { this._numberOfChannels = value; }
        }

        // Check to see if NumberOfChannels property is set
        internal bool IsSetNumberOfChannels()
        {
            return this._numberOfChannels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampleRate. 
        /// <para>
        /// The sample rate for the audio stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? SampleRate
        {
            get { return this._sampleRate; }
            set { this._sampleRate = value; }
        }

        // Check to see if SampleRate property is set
        internal bool IsSetSampleRate()
        {
            return this._sampleRate.HasValue; 
        }

    }
}