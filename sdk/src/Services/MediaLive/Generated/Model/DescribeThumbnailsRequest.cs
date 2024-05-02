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
    /// Container for the parameters to the DescribeThumbnails operation.
    /// Describe the latest thumbnails data.
    /// </summary>
    public partial class DescribeThumbnailsRequest : AmazonMediaLiveRequest
    {
        private string _channelId;
        private string _pipelineId;
        private string _thumbnailType;

        /// <summary>
        /// Gets and sets the property ChannelId. Unique ID of the channel
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
        /// Gets and sets the property PipelineId. Pipeline ID ("0" or "1")
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property ThumbnailType. thumbnail type
        /// </summary>
        [AWSProperty(Required=true)]
        public string ThumbnailType
        {
            get { return this._thumbnailType; }
            set { this._thumbnailType = value; }
        }

        // Check to see if ThumbnailType property is set
        internal bool IsSetThumbnailType()
        {
            return this._thumbnailType != null;
        }

    }
}