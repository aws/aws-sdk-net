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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
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
namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// A segment of transcript text with timing and channel information
    /// </summary>
    public partial class MedicalScribeTranscriptSegment
    {
        private double? _audioBeginOffset;
        private double? _audioEndOffset;
        private string _channelId;
        private string _content;
        private bool? _isPartial;
        private string _segmentId;

        /// <summary>
        /// Gets and sets the property AudioBeginOffset. 
        /// <para>
        /// The offset from audio start when the audio for this segment begins
        /// </para>
        /// </summary>
        public double? AudioBeginOffset
        {
            get { return this._audioBeginOffset; }
            set { this._audioBeginOffset = value; }
        }

        // Check to see if AudioBeginOffset property is set
        internal bool IsSetAudioBeginOffset()
        {
            return this._audioBeginOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AudioEndOffset. 
        /// <para>
        /// The offset from audio start when the audio for this segment ends
        /// </para>
        /// </summary>
        public double? AudioEndOffset
        {
            get { return this._audioEndOffset; }
            set { this._audioEndOffset = value; }
        }

        // Check to see if AudioEndOffset property is set
        internal bool IsSetAudioEndOffset()
        {
            return this._audioEndOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// The channel identifier for this segment
        /// </para>
        /// </summary>
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The transcript text content
        /// </para>
        /// </summary>
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property IsPartial. 
        /// <para>
        /// Indicates whether this is a partial or final transcript
        /// </para>
        /// </summary>
        public bool? IsPartial
        {
            get { return this._isPartial; }
            set { this._isPartial = value; }
        }

        // Check to see if IsPartial property is set
        internal bool IsSetIsPartial()
        {
            return this._isPartial.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentId. 
        /// <para>
        /// The unique identifier for this segment
        /// </para>
        /// </summary>
        public string SegmentId
        {
            get { return this._segmentId; }
            set { this._segmentId = value; }
        }

        // Check to see if SegmentId property is set
        internal bool IsSetSegmentId()
        {
            return this._segmentId != null;
        }

    }
}