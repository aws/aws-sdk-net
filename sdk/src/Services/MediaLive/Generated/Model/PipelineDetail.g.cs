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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Runtime details of a pipeline when a channel is running.
    /// </summary>
    public partial class PipelineDetail
    {
        /// <summary>
        /// Gets and sets the property ActiveInputAttachmentName. The name of the active input
        /// attachment currently being ingested by this pipeline.
        /// </summary>
        public string ActiveInputAttachmentName { get; set; }

        /// <summary>
        /// Checks to see if the ActiveInputAttachmentName property is set.
        /// </summary>
        internal bool IsSetActiveInputAttachmentName() => this.ActiveInputAttachmentName != null;

        /// <summary>
        /// Gets and sets the property ActiveInputSwitchActionName. The name of the input switch
        /// schedule action that occurred most recently and that resulted in the switch to the
        /// current input attachment for this pipeline.
        /// </summary>
        public string ActiveInputSwitchActionName { get; set; }

        /// <summary>
        /// Checks to see if the ActiveInputSwitchActionName property is set.
        /// </summary>
        internal bool IsSetActiveInputSwitchActionName() => this.ActiveInputSwitchActionName != null;

        /// <summary>
        /// Gets and sets the property ActiveMotionGraphicsActionName. The name of the motion
        /// graphics activate action that occurred most recently and that resulted in the current
        /// graphics URI for this pipeline.
        /// </summary>
        public string ActiveMotionGraphicsActionName { get; set; }

        /// <summary>
        /// Checks to see if the ActiveMotionGraphicsActionName property is set.
        /// </summary>
        internal bool IsSetActiveMotionGraphicsActionName() => this.ActiveMotionGraphicsActionName != null;

        /// <summary>
        /// Gets and sets the property ActiveMotionGraphicsUri. The current URI being used for
        /// HTML5 motion graphics for this pipeline.
        /// </summary>
        public string ActiveMotionGraphicsUri { get; set; }

        /// <summary>
        /// Checks to see if the ActiveMotionGraphicsUri property is set.
        /// </summary>
        internal bool IsSetActiveMotionGraphicsUri() => this.ActiveMotionGraphicsUri != null;

        /// <summary>
        /// Gets and sets the property ChannelEngineVersion. Current engine version of the encoder
        /// for this pipeline.
        /// </summary>
        public ChannelEngineVersionResponse ChannelEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the ChannelEngineVersion property is set.
        /// </summary>
        internal bool IsSetChannelEngineVersion() => this.ChannelEngineVersion != null;

        /// <summary>
        /// Gets and sets the property MediaConnectRouterOutputConnectionMap. A map of output
        /// names to the MediaConnect Router connection for this pipeline. Only present for channels
        /// with MediaConnect Router outputs.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MediaConnectRouterOutputConnection> MediaConnectRouterOutputConnectionMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, MediaConnectRouterOutputConnection>() : null;

        /// <summary>
        /// Checks to see if the MediaConnectRouterOutputConnectionMap property is set.
        /// </summary>
        internal bool IsSetMediaConnectRouterOutputConnectionMap() => this.MediaConnectRouterOutputConnectionMap != null && (this.MediaConnectRouterOutputConnectionMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PipelineId. Pipeline ID
        /// </summary>
        public string PipelineId { get; set; }

        /// <summary>
        /// Checks to see if the PipelineId property is set.
        /// </summary>
        internal bool IsSetPipelineId() => this.PipelineId != null;
    }
}
