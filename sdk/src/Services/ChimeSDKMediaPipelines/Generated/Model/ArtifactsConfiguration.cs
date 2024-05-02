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
    /// The configuration for the artifacts.
    /// </summary>
    public partial class ArtifactsConfiguration
    {
        private AudioArtifactsConfiguration _audio;
        private CompositedVideoArtifactsConfiguration _compositedVideo;
        private ContentArtifactsConfiguration _content;
        private VideoArtifactsConfiguration _video;

        /// <summary>
        /// Gets and sets the property Audio. 
        /// <para>
        /// The configuration for the audio artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AudioArtifactsConfiguration Audio
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
        /// Enables video compositing.
        /// </para>
        /// </summary>
        public CompositedVideoArtifactsConfiguration CompositedVideo
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
        /// The configuration for the content artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContentArtifactsConfiguration Content
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
        /// Gets and sets the property Video. 
        /// <para>
        /// The configuration for the video artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VideoArtifactsConfiguration Video
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