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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// The configuration for the artifacts concatenation.
    /// </summary>
    public partial class ArtifactsConcatenationConfiguration
    {
        private AudioConcatenationConfiguration _audio;
        private CompositedVideoConcatenationConfiguration _compositedVideo;
        private ContentConcatenationConfiguration _content;
        private DataChannelConcatenationConfiguration _dataChannel;
        private MeetingEventsConcatenationConfiguration _meetingEvents;
        private TranscriptionMessagesConcatenationConfiguration _transcriptionMessages;
        private VideoConcatenationConfiguration _video;

        /// <summary>
        /// Gets and sets the property Audio. 
        /// <para>
        /// The configuration for the audio artifacts concatenation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AudioConcatenationConfiguration Audio
        {
            get { return this._audio; }
            set { this._audio = value; }
        }

        // Check to see if Audio property is set
        internal bool IsSetAudio()
        {
            return this._audio != null;
        }

        /// <summary>
        /// Gets and sets the property CompositedVideo. 
        /// <para>
        /// The configuration for the composited video artifacts concatenation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CompositedVideoConcatenationConfiguration CompositedVideo
        {
            get { return this._compositedVideo; }
            set { this._compositedVideo = value; }
        }

        // Check to see if CompositedVideo property is set
        internal bool IsSetCompositedVideo()
        {
            return this._compositedVideo != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The configuration for the content artifacts concatenation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContentConcatenationConfiguration Content
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
        /// Gets and sets the property DataChannel. 
        /// <para>
        /// The configuration for the data channel artifacts concatenation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataChannelConcatenationConfiguration DataChannel
        {
            get { return this._dataChannel; }
            set { this._dataChannel = value; }
        }

        // Check to see if DataChannel property is set
        internal bool IsSetDataChannel()
        {
            return this._dataChannel != null;
        }

        /// <summary>
        /// Gets and sets the property MeetingEvents. 
        /// <para>
        /// The configuration for the meeting events artifacts concatenation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MeetingEventsConcatenationConfiguration MeetingEvents
        {
            get { return this._meetingEvents; }
            set { this._meetingEvents = value; }
        }

        // Check to see if MeetingEvents property is set
        internal bool IsSetMeetingEvents()
        {
            return this._meetingEvents != null;
        }

        /// <summary>
        /// Gets and sets the property TranscriptionMessages. 
        /// <para>
        /// The configuration for the transcription messages artifacts concatenation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TranscriptionMessagesConcatenationConfiguration TranscriptionMessages
        {
            get { return this._transcriptionMessages; }
            set { this._transcriptionMessages = value; }
        }

        // Check to see if TranscriptionMessages property is set
        internal bool IsSetTranscriptionMessages()
        {
            return this._transcriptionMessages != null;
        }

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// The configuration for the video artifacts concatenation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VideoConcatenationConfiguration Video
        {
            get { return this._video; }
            set { this._video = value; }
        }

        // Check to see if Video property is set
        internal bool IsSetVideo()
        {
            return this._video != null;
        }

    }
}