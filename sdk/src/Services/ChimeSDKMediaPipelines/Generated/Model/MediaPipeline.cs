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
    /// A pipeline consisting of a media capture, media concatenation, or live-streaming pipeline.
    /// </summary>
    public partial class MediaPipeline
    {
        private MediaCapturePipeline _mediaCapturePipeline;
        private MediaConcatenationPipeline _mediaConcatenationPipeline;
        private MediaInsightsPipeline _mediaInsightsPipeline;
        private MediaLiveConnectorPipeline _mediaLiveConnectorPipeline;

        /// <summary>
        /// Gets and sets the property MediaCapturePipeline. 
        /// <para>
        /// A pipeline that enables users to capture audio and video.
        /// </para>
        /// </summary>
        public MediaCapturePipeline MediaCapturePipeline
        {
            get { return this._mediaCapturePipeline; }
            set { this._mediaCapturePipeline = value; }
        }

        // Check to see if MediaCapturePipeline property is set
        internal bool IsSetMediaCapturePipeline()
        {
            return this._mediaCapturePipeline != null;
        }

        /// <summary>
        /// Gets and sets the property MediaConcatenationPipeline. 
        /// <para>
        /// The media concatenation pipeline in a media pipeline.
        /// </para>
        /// </summary>
        public MediaConcatenationPipeline MediaConcatenationPipeline
        {
            get { return this._mediaConcatenationPipeline; }
            set { this._mediaConcatenationPipeline = value; }
        }

        // Check to see if MediaConcatenationPipeline property is set
        internal bool IsSetMediaConcatenationPipeline()
        {
            return this._mediaConcatenationPipeline != null;
        }

        /// <summary>
        /// Gets and sets the property MediaInsightsPipeline. 
        /// <para>
        /// The media insights pipeline of a media pipeline.
        /// </para>
        /// </summary>
        public MediaInsightsPipeline MediaInsightsPipeline
        {
            get { return this._mediaInsightsPipeline; }
            set { this._mediaInsightsPipeline = value; }
        }

        // Check to see if MediaInsightsPipeline property is set
        internal bool IsSetMediaInsightsPipeline()
        {
            return this._mediaInsightsPipeline != null;
        }

        /// <summary>
        /// Gets and sets the property MediaLiveConnectorPipeline. 
        /// <para>
        /// The connector pipeline of the media pipeline.
        /// </para>
        /// </summary>
        public MediaLiveConnectorPipeline MediaLiveConnectorPipeline
        {
            get { return this._mediaLiveConnectorPipeline; }
            set { this._mediaLiveConnectorPipeline = value; }
        }

        // Check to see if MediaLiveConnectorPipeline property is set
        internal bool IsSetMediaLiveConnectorPipeline()
        {
            return this._mediaLiveConnectorPipeline != null;
        }

    }
}