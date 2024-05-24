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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// Contains the range of timestamps for the requested media, and the source of the timestamps.
    /// </summary>
    public partial class DASHFragmentSelector
    {
        private DASHFragmentSelectorType _fragmentSelectorType;
        private DASHTimestampRange _timestampRange;

        /// <summary>
        /// Gets and sets the property FragmentSelectorType. 
        /// <para>
        /// The source of the timestamps for the requested media.
        /// </para>
        ///  
        /// <para>
        /// When <c>FragmentSelectorType</c> is set to <c>PRODUCER_TIMESTAMP</c> and <a>GetDASHStreamingSessionURLInput$PlaybackMode</a>
        /// is <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>, the first fragment ingested with a producer
        /// timestamp within the specified <a>FragmentSelector$TimestampRange</a> is included
        /// in the media playlist. In addition, the fragments with producer timestamps within
        /// the <c>TimestampRange</c> ingested immediately following the first fragment (up to
        /// the <a>GetDASHStreamingSessionURLInput$MaxManifestFragmentResults</a> value) are included.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Fragments that have duplicate producer timestamps are deduplicated. This means that
        /// if producers are producing a stream of fragments with producer timestamps that are
        /// approximately equal to the true clock time, the MPEG-DASH manifest will contain all
        /// of the fragments within the requested timestamp range. If some fragments are ingested
        /// within the same time range and very different points in time, only the oldest ingested
        /// collection of fragments are returned.
        /// </para>
        ///  
        /// <para>
        /// When <c>FragmentSelectorType</c> is set to <c>PRODUCER_TIMESTAMP</c> and <a>GetDASHStreamingSessionURLInput$PlaybackMode</a>
        /// is <c>LIVE</c>, the producer timestamps are used in the MP4 fragments and for deduplication.
        /// But the most recently ingested fragments based on server timestamps are included in
        /// the MPEG-DASH manifest. This means that even if fragments ingested in the past have
        /// producer timestamps with values now, they are not included in the HLS media playlist.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>SERVER_TIMESTAMP</c>.
        /// </para>
        /// </summary>
        public DASHFragmentSelectorType FragmentSelectorType
        {
            get { return this._fragmentSelectorType; }
            set { this._fragmentSelectorType = value; }
        }

        // Check to see if FragmentSelectorType property is set
        internal bool IsSetFragmentSelectorType()
        {
            return this._fragmentSelectorType != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampRange. 
        /// <para>
        /// The start and end of the timestamp range for the requested media.
        /// </para>
        ///  
        /// <para>
        /// This value should not be present if <c>PlaybackType</c> is <c>LIVE</c>.
        /// </para>
        /// </summary>
        public DASHTimestampRange TimestampRange
        {
            get { return this._timestampRange; }
            set { this._timestampRange = value; }
        }

        // Check to see if TimestampRange property is set
        internal bool IsSetTimestampRange()
        {
            return this._timestampRange != null;
        }

    }
}