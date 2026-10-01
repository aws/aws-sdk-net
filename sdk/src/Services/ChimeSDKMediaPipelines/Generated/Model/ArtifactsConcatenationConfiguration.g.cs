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

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// The configuration for the artifacts concatenation.
    /// </summary>
    public partial class ArtifactsConcatenationConfiguration
    {
        /// <summary>
        /// Gets and sets the property Audio. 
        /// <para>
        /// The configuration for the audio artifacts concatenation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AudioConcatenationConfiguration Audio { get; set; }

        /// <summary>
        /// Checks to see if the Audio property is set.
        /// </summary>
        internal bool IsSetAudio() => this.Audio != null;

        /// <summary>
        /// Gets and sets the property CompositedVideo. 
        /// <para>
        /// The configuration for the composited video artifacts concatenation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CompositedVideoConcatenationConfiguration CompositedVideo { get; set; }

        /// <summary>
        /// Checks to see if the CompositedVideo property is set.
        /// </summary>
        internal bool IsSetCompositedVideo() => this.CompositedVideo != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The configuration for the content artifacts concatenation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContentConcatenationConfiguration Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property DataChannel. 
        /// <para>
        /// The configuration for the data channel artifacts concatenation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataChannelConcatenationConfiguration DataChannel { get; set; }

        /// <summary>
        /// Checks to see if the DataChannel property is set.
        /// </summary>
        internal bool IsSetDataChannel() => this.DataChannel != null;

        /// <summary>
        /// Gets and sets the property MeetingEvents. 
        /// <para>
        /// The configuration for the meeting events artifacts concatenation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MeetingEventsConcatenationConfiguration MeetingEvents { get; set; }

        /// <summary>
        /// Checks to see if the MeetingEvents property is set.
        /// </summary>
        internal bool IsSetMeetingEvents() => this.MeetingEvents != null;

        /// <summary>
        /// Gets and sets the property TranscriptionMessages. 
        /// <para>
        /// The configuration for the transcription messages artifacts concatenation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TranscriptionMessagesConcatenationConfiguration TranscriptionMessages { get; set; }

        /// <summary>
        /// Checks to see if the TranscriptionMessages property is set.
        /// </summary>
        internal bool IsSetTranscriptionMessages() => this.TranscriptionMessages != null;

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// The configuration for the video artifacts concatenation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VideoConcatenationConfiguration Video { get; set; }

        /// <summary>
        /// Checks to see if the Video property is set.
        /// </summary>
        internal bool IsSetVideo() => this.Video != null;
    }
}
