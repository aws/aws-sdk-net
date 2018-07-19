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
    /// The start and end of the time stamp range for the requested media.
    /// 
    ///  
    /// <para>
    /// This value should not be present if <code>PlaybackType</code> is <code>LIVE</code>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The values in the <code>HLSTimestampRange</code> are inclusive. Fragments that begin
    /// before the start time but continue past it, or fragments that begin before the end
    /// time but continue past it, are included in the session.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class HLSTimestampRange
    {
        private DateTime? _endTimestamp;
        private DateTime? _startTimestamp;

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The end of the time stamp range for the requested media. This value must be within
        /// 3 hours of the specified <code>StartTimestamp</code>, and it must be later than the
        /// <code>StartTimestamp</code> value.
        /// </para>
        ///  
        /// <para>
        /// If <code>FragmentSelectorType</code> for the request is <code>SERVER_TIMESTAMP</code>,
        /// this value must be in the past.
        /// </para>
        ///  
        /// <para>
        /// If the <code>HLSTimestampRange</code> value is specified, the <code>EndTimestamp</code>
        /// value is required.
        /// </para>
        ///  <note> 
        /// <para>
        /// This value is inclusive. The <code>EndTimestamp</code> is compared to the (starting)
        /// time stamp of the fragment. Fragments that start before the <code>EndTimestamp</code>
        /// value and continue past it are included in the session.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime EndTimestamp
        {
            get { return this._endTimestamp.GetValueOrDefault(); }
            set { this._endTimestamp = value; }
        }

        // Check to see if EndTimestamp property is set
        internal bool IsSetEndTimestamp()
        {
            return this._endTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The start of the time stamp range for the requested media.
        /// </para>
        ///  
        /// <para>
        /// If the <code>HLSTimestampRange</code> value is specified, the <code>StartTimestamp</code>
        /// value is required.
        /// </para>
        ///  <note> 
        /// <para>
        /// This value is inclusive. Fragments that start before the <code>StartTimestamp</code>
        /// and continue past it are included in the session. If <code>FragmentSelectorType</code>
        /// is <code>SERVER_TIMESTAMP</code>, the <code>StartTimestamp</code> must be later than
        /// the stream head.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime StartTimestamp
        {
            get { return this._startTimestamp.GetValueOrDefault(); }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

    }
}