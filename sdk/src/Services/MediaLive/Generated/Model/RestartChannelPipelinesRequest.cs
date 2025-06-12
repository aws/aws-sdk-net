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
    /// Container for the parameters to the RestartChannelPipelines operation.
    /// Restart pipelines in one channel that is currently running.
    /// </summary>
    public partial class RestartChannelPipelinesRequest : AmazonMediaLiveRequest
    {
        private string _channelId;
        private List<string> _pipelineIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ChannelId. ID of channel
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PipelineIds. An array of pipelines to restart in this channel.
        /// Format PIPELINE_0 or PIPELINE_1.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PipelineIds
        {
            get { return this._pipelineIds; }
            set { this._pipelineIds = value; }
        }

        // Check to see if PipelineIds property is set
        internal bool IsSetPipelineIds()
        {
            return this._pipelineIds != null && (this._pipelineIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}