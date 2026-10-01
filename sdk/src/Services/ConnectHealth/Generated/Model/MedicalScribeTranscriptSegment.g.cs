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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// A segment of transcript text with timing and channel information
    /// </summary>
    public partial class MedicalScribeTranscriptSegment
    {
        /// <summary>
        /// Gets and sets the property AudioBeginOffset. 
        /// <para>
        /// The offset from audio start when the audio for this segment begins
        /// </para>
        /// </summary>
        public double? AudioBeginOffset { get; set; }

        /// <summary>
        /// Checks to see if the AudioBeginOffset property is set.
        /// </summary>
        internal bool IsSetAudioBeginOffset() => this.AudioBeginOffset.HasValue;

        /// <summary>
        /// Gets and sets the property AudioEndOffset. 
        /// <para>
        /// The offset from audio start when the audio for this segment ends
        /// </para>
        /// </summary>
        public double? AudioEndOffset { get; set; }

        /// <summary>
        /// Checks to see if the AudioEndOffset property is set.
        /// </summary>
        internal bool IsSetAudioEndOffset() => this.AudioEndOffset.HasValue;

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// The channel identifier for this segment
        /// </para>
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelId property is set.
        /// </summary>
        internal bool IsSetChannelId() => this.ChannelId != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The transcript text content
        /// </para>
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property IsPartial. 
        /// <para>
        /// Indicates whether this is a partial or final transcript
        /// </para>
        /// </summary>
        public bool? IsPartial { get; set; }

        /// <summary>
        /// Checks to see if the IsPartial property is set.
        /// </summary>
        internal bool IsSetIsPartial() => this.IsPartial.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentId. 
        /// <para>
        /// The unique identifier for this segment
        /// </para>
        /// </summary>
        public string SegmentId { get; set; }

        /// <summary>
        /// Checks to see if the SegmentId property is set.
        /// </summary>
        internal bool IsSetSegmentId() => this.SegmentId != null;
    }
}
