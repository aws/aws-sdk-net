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
    /// Container for the parameters to the DeleteChannelPlacementGroup operation.
    /// Delete the specified ChannelPlacementGroup that exists in the specified Cluster.
    /// </summary>
    public partial class DeleteChannelPlacementGroupRequest : AmazonMediaLiveRequest
    {
        private string _channelPlacementGroupId;
        private string _clusterId;

        /// <summary>
        /// Gets and sets the property ChannelPlacementGroupId. The ID of the channel placement
        /// group.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ChannelPlacementGroupId
        {
            get { return this._channelPlacementGroupId; }
            set { this._channelPlacementGroupId = value; }
        }

        // Check to see if ChannelPlacementGroupId property is set
        internal bool IsSetChannelPlacementGroupId()
        {
            return this._channelPlacementGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterId. The ID of the cluster.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

    }
}