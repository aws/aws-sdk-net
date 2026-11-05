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
    /// Used in ListClustersResult.
    /// </summary>
    public partial class DescribeClusterSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. The ARN of this Cluster. It is automatically assigned
        /// when the Cluster is created.
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ChannelIds. An array of the IDs of the Channels that are
        /// associated with this Cluster. One Channel is associated with the Cluster as follows:
        /// A Channel belongs to a ChannelPlacementGroup. A ChannelPlacementGroup is attached
        /// to a Node. A Node belongs to a Cluster.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ChannelIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ChannelIds property is set.
        /// </summary>
        internal bool IsSetChannelIds() => this.ChannelIds != null && (this.ChannelIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterType. The hardware type for the Cluster.
        /// </summary>
        public ClusterType ClusterType { get; set; }

        /// <summary>
        /// Checks to see if the ClusterType property is set.
        /// </summary>
        internal bool IsSetClusterType() => this.ClusterType != null;

        /// <summary>
        /// Gets and sets the property Id. The ID of the Cluster. Unique in the AWS account. The
        /// ID is the resource-id portion of the ARN.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InstanceRoleArn. The ARN of the IAM role for the Node in
        /// this Cluster. Any Nodes that are associated with this Cluster assume this role. The
        /// role gives permissions to the operations that you expect these Node to perform.
        /// </summary>
        public string InstanceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRoleArn property is set.
        /// </summary>
        internal bool IsSetInstanceRoleArn() => this.InstanceRoleArn != null;

        /// <summary>
        /// Gets and sets the property Name. The name that you specified for the Cluster.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkSettings. Network settings that connect the Nodes
        /// in the Cluster to one or more of the Networks that the Cluster is associated with.
        /// </summary>
        public ClusterNetworkSettings NetworkSettings { get; set; }

        /// <summary>
        /// Checks to see if the NetworkSettings property is set.
        /// </summary>
        internal bool IsSetNetworkSettings() => this.NetworkSettings != null;

        /// <summary>
        /// Gets and sets the property State. The current state of the Cluster.
        /// </summary>
        public ClusterState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
