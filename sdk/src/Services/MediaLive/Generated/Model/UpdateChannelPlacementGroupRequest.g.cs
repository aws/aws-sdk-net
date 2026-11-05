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
    /// Container for the parameters to the UpdateChannelPlacementGroup operation. Change
    /// the settings for a ChannelPlacementGroup.
    /// </summary>
    public partial class UpdateChannelPlacementGroupRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelPlacementGroupId. The ID of the channel placement
        /// group.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelPlacementGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelPlacementGroupId property is set.
        /// </summary>
        internal bool IsSetChannelPlacementGroupId() => this.ChannelPlacementGroupId != null;

        /// <summary>
        /// Gets and sets the property ClusterId. The ID of the cluster.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property Name. Include this parameter only if you want to change
        /// the current name of the ChannelPlacementGroup. Specify a name that is unique in the
        /// Cluster. You can't change the name. Names are case-sensitive.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Nodes. Include this parameter only if you want to change
        /// the list of Nodes that are associated with the ChannelPlacementGroup.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Nodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Nodes property is set.
        /// </summary>
        internal bool IsSetNodes() => this.Nodes != null && (this.Nodes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
