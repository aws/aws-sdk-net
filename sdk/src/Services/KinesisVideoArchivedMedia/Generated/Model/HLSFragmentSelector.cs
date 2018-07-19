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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// Contains the range of time stamps for the requested media, and the source of the time
    /// stamps.
    /// </summary>
    public partial class HLSFragmentSelector
    {
        private HLSFragmentSelectorType _fragmentSelectorType;
        private HLSTimestampRange _timestampRange;

        /// <summary>
        /// Gets and sets the property FragmentSelectorType. 
        /// <para>
        /// The source of the time stamps for the requested media.
        /// </para>
        ///  
        /// <para>
        /// When <code>FragmentSelectorType</code> is set to <code>PRODUCER_TIMESTAMP</code> and
        /// <a>GetHLSStreamingSessionURLInput$PlaybackMode</a> is <code>ON_DEMAND</code>, the
        /// first fragment ingested with a producer time stamp within the specified <a>FragmentSelector$TimestampRange</a>
        /// is included in the media playlist. In addition, the fragments with producer time stamps
        /// within the <code>TimestampRange</code> ingested immediately following the first fragment
        /// (up to the <a>GetHLSStreamingSessionURLInput$MaxMediaPlaylistFragmentResults</a> value)
        /// are included. 
        /// </para>
        ///  
        /// <para>
        /// Fragments that have duplicate producer time stamps are deduplicated. This means that
        /// if producers are producing a stream of fragments with producer time stamps that are
        /// approximately equal to the true clock time, the HLS media playlists will contain all
        /// of the fragments within the requested time stamp range. If some fragments are ingested
        /// within the same time range and very different points in time, only the oldest ingested
        /// collection of fragments are returned.
        /// </para>
        ///  
        /// <para>
        /// When <code>FragmentSelectorType</code> is set to <code>PRODUCER_TIMESTAMP</code> and
        /// <a>GetHLSStreamingSessionURLInput$PlaybackMode</a> is <code>LIVE</code>, the producer
        /// time stamps are used in the MP4 fragments and for deduplication. But the most recently
        /// ingested fragments based on server time stamps are included in the HLS media playlist.
        /// This means that even if fragments ingested in the past have producer time stamps with
        /// values now, they are not included in the HLS media playlist.
        /// </para>
        ///  
        /// <para>
        /// The default is <code>SERVER_TIMESTAMP</code>.
        /// </para>
        /// </summary>
        public HLSFragmentSelectorType FragmentSelectorType
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
        /// The start and end of the time stamp range for the requested media.
        /// </para>
        ///  
        /// <para>
        /// This value should not be present if <code>PlaybackType</code> is <code>LIVE</code>.
        /// </para>
        /// </summary>
        public HLSTimestampRange TimestampRange
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