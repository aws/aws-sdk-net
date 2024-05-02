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
    /// Hls Input Settings
    /// </summary>
    public partial class HlsInputSettings
    {
        private int? _bandwidth;
        private int? _bufferSegments;
        private int? _retries;
        private int? _retryInterval;
        private HlsScte35SourceType _scte35Source;

        /// <summary>
        /// Gets and sets the property Bandwidth. When specified the HLS stream with the m3u8
        /// BANDWIDTH that most closely matches this value will be chosen, otherwise the highest
        /// bandwidth stream in the m3u8 will be chosen.  The bitrate is specified in bits per
        /// second, as in an HLS manifest.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Bandwidth
        {
            get { return this._bandwidth; }
            set { this._bandwidth = value; }
        }

        // Check to see if Bandwidth property is set
        internal bool IsSetBandwidth()
        {
            return this._bandwidth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BufferSegments. When specified, reading of the HLS input
        /// will begin this many buffer segments from the end (most recently written segment).
        ///  When not specified, the HLS input will begin with the first segment specified in
        /// the m3u8.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? BufferSegments
        {
            get { return this._bufferSegments; }
            set { this._bufferSegments = value; }
        }

        // Check to see if BufferSegments property is set
        internal bool IsSetBufferSegments()
        {
            return this._bufferSegments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Retries. The number of consecutive times that attempts
        /// to read a manifest or segment must fail before the input is considered unavailable.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Retries
        {
            get { return this._retries; }
            set { this._retries = value; }
        }

        // Check to see if Retries property is set
        internal bool IsSetRetries()
        {
            return this._retries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetryInterval. The number of seconds between retries when
        /// an attempt to read a manifest or segment fails.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? RetryInterval
        {
            get { return this._retryInterval; }
            set { this._retryInterval = value; }
        }

        // Check to see if RetryInterval property is set
        internal bool IsSetRetryInterval()
        {
            return this._retryInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Scte35Source. Identifies the source for the SCTE-35 messages
        /// that MediaLive will ingest. Messages can be ingested from the content segments (in
        /// the stream) or from tags in the playlist (the HLS manifest). MediaLive ignores SCTE-35
        /// information in the source that is not selected.
        /// </summary>
        public HlsScte35SourceType Scte35Source
        {
            get { return this._scte35Source; }
            set { this._scte35Source = value; }
        }

        // Check to see if Scte35Source property is set
        internal bool IsSetScte35Source()
        {
            return this._scte35Source != null;
        }

    }
}