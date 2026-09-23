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
    /// A pipeline consisting of a media capture, media concatenation, or live-streaming pipeline.
    /// </summary>
    public partial class MediaPipeline
    {
        /// <summary>
        /// Gets and sets the property MediaCapturePipeline. 
        /// <para>
        /// A pipeline that enables users to capture audio and video.
        /// </para>
        /// </summary>
        public MediaCapturePipeline MediaCapturePipeline { get; set; }

        /// <summary>
        /// Checks to see if the MediaCapturePipeline property is set.
        /// </summary>
        internal bool IsSetMediaCapturePipeline() => this.MediaCapturePipeline != null;

        /// <summary>
        /// Gets and sets the property MediaConcatenationPipeline. 
        /// <para>
        /// The media concatenation pipeline in a media pipeline.
        /// </para>
        /// </summary>
        public MediaConcatenationPipeline MediaConcatenationPipeline { get; set; }

        /// <summary>
        /// Checks to see if the MediaConcatenationPipeline property is set.
        /// </summary>
        internal bool IsSetMediaConcatenationPipeline() => this.MediaConcatenationPipeline != null;

        /// <summary>
        /// Gets and sets the property MediaInsightsPipeline. 
        /// <para>
        /// The media insights pipeline of a media pipeline.
        /// </para>
        /// </summary>
        public MediaInsightsPipeline MediaInsightsPipeline { get; set; }

        /// <summary>
        /// Checks to see if the MediaInsightsPipeline property is set.
        /// </summary>
        internal bool IsSetMediaInsightsPipeline() => this.MediaInsightsPipeline != null;

        /// <summary>
        /// Gets and sets the property MediaLiveConnectorPipeline. 
        /// <para>
        /// The connector pipeline of the media pipeline.
        /// </para>
        /// </summary>
        public MediaLiveConnectorPipeline MediaLiveConnectorPipeline { get; set; }

        /// <summary>
        /// Checks to see if the MediaLiveConnectorPipeline property is set.
        /// </summary>
        internal bool IsSetMediaLiveConnectorPipeline() => this.MediaLiveConnectorPipeline != null;

        /// <summary>
        /// Gets and sets the property MediaStreamPipeline. 
        /// <para>
        /// Designates a media pipeline as a media stream pipeline.
        /// </para>
        /// </summary>
        public MediaStreamPipeline MediaStreamPipeline { get; set; }

        /// <summary>
        /// Checks to see if the MediaStreamPipeline property is set.
        /// </summary>
        internal bool IsSetMediaStreamPipeline() => this.MediaStreamPipeline != null;
    }
}
