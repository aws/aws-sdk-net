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
    /// The runtime configuration settings for the Kinesis video stream source.
    /// </summary>
    public partial class KinesisVideoStreamSourceRuntimeConfiguration
    {
        private MediaEncoding _mediaEncoding;
        private int? _mediaSampleRate;
        private List<StreamConfiguration> _streams = new List<StreamConfiguration>();

        /// <summary>
        /// Gets and sets the property MediaEncoding. 
        /// <para>
        /// Specifies the encoding of your input audio. Supported format: PCM (only signed 16-bit
        /// little-endian audio formats, which does not include WAV)
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/how-input.html#how-input-audio">Media
        /// formats</a> in the <i>Amazon Transcribe Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaEncoding MediaEncoding
        {
            get { return this._mediaEncoding; }
            set { this._mediaEncoding = value; }
        }

        // Check to see if MediaEncoding property is set
        internal bool IsSetMediaEncoding()
        {
            return this._mediaEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property MediaSampleRate. 
        /// <para>
        /// The sample rate of the input audio (in hertz). Low-quality audio, such as telephone
        /// audio, is typically around 8,000 Hz. High-quality audio typically ranges from 16,000
        /// Hz to 48,000 Hz. Note that the sample rate you specify must match that of your audio.
        /// </para>
        ///  
        /// <para>
        /// Valid Range: Minimum value of 8000. Maximum value of 48000.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8000, Max=48000)]
        public int MediaSampleRate
        {
            get { return this._mediaSampleRate.GetValueOrDefault(); }
            set { this._mediaSampleRate = value; }
        }

        // Check to see if MediaSampleRate property is set
        internal bool IsSetMediaSampleRate()
        {
            return this._mediaSampleRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Streams. 
        /// <para>
        /// The streams in the source runtime configuration of a Kinesis video stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<StreamConfiguration> Streams
        {
            get { return this._streams; }
            set { this._streams = value; }
        }

        // Check to see if Streams property is set
        internal bool IsSetStreams()
        {
            return this._streams != null && this._streams.Count > 0; 
        }

    }
}