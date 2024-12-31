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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private string _activeInputAttachmentName;
        private string _activeInputSwitchActionName;
        private string _activeMotionGraphicsActionName;
        private string _activeMotionGraphicsUri;
        private ChannelEngineVersionResponse _channelEngineVersion;
        private string _pipelineId;

        /// <summary>
        /// Gets and sets the property ActiveInputAttachmentName. The name of the active input
        /// attachment currently being ingested by this pipeline.
        /// </summary>
        public string ActiveInputAttachmentName
        {
            get { return this._activeInputAttachmentName; }
            set { this._activeInputAttachmentName = value; }
        }

        // Check to see if ActiveInputAttachmentName property is set
        internal bool IsSetActiveInputAttachmentName()
        {
            return this._activeInputAttachmentName != null;
        }

        /// <summary>
        /// Gets and sets the property ActiveInputSwitchActionName. The name of the input switch
        /// schedule action that occurred most recently and that resulted in the switch to the
        /// current input attachment for this pipeline.
        /// </summary>
        public string ActiveInputSwitchActionName
        {
            get { return this._activeInputSwitchActionName; }
            set { this._activeInputSwitchActionName = value; }
        }

        // Check to see if ActiveInputSwitchActionName property is set
        internal bool IsSetActiveInputSwitchActionName()
        {
            return this._activeInputSwitchActionName != null;
        }

        /// <summary>
        /// Gets and sets the property ActiveMotionGraphicsActionName. The name of the motion
        /// graphics activate action that occurred most recently and that resulted in the current
        /// graphics URI for this pipeline.
        /// </summary>
        public string ActiveMotionGraphicsActionName
        {
            get { return this._activeMotionGraphicsActionName; }
            set { this._activeMotionGraphicsActionName = value; }
        }

        // Check to see if ActiveMotionGraphicsActionName property is set
        internal bool IsSetActiveMotionGraphicsActionName()
        {
            return this._activeMotionGraphicsActionName != null;
        }

        /// <summary>
        /// Gets and sets the property ActiveMotionGraphicsUri. The current URI being used for
        /// HTML5 motion graphics for this pipeline.
        /// </summary>
        public string ActiveMotionGraphicsUri
        {
            get { return this._activeMotionGraphicsUri; }
            set { this._activeMotionGraphicsUri = value; }
        }

        // Check to see if ActiveMotionGraphicsUri property is set
        internal bool IsSetActiveMotionGraphicsUri()
        {
            return this._activeMotionGraphicsUri != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelEngineVersion. Current engine version of the encoder
        /// for this pipeline.
        /// </summary>
        public ChannelEngineVersionResponse ChannelEngineVersion
        {
            get { return this._channelEngineVersion; }
            set { this._channelEngineVersion = value; }
        }

        // Check to see if ChannelEngineVersion property is set
        internal bool IsSetChannelEngineVersion()
        {
            return this._channelEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineId. Pipeline ID
        /// </summary>
        public string PipelineId
        {
            get { return this._pipelineId; }
            set { this._pipelineId = value; }
        }

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this._pipelineId != null;
        }

    }
}