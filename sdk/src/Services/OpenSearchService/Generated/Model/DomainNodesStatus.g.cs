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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for information about nodes on the domain.
    /// </summary>
    public partial class DomainNodesStatus
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type information of the node.
        /// </para>
        /// </summary>
        public OpenSearchPartitionInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        /// The ID of the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 40)]
        public string NodeId { get; set; }

        /// <summary>
        /// Checks to see if the NodeId property is set.
        /// </summary>
        internal bool IsSetNodeId() => this.NodeId != null;

        /// <summary>
        /// Gets and sets the property NodeStatus. 
        /// <para>
        /// Indicates if the node is active or in standby.
        /// </para>
        /// </summary>
        public NodeStatus NodeStatus { get; set; }

        /// <summary>
        /// Checks to see if the NodeStatus property is set.
        /// </summary>
        internal bool IsSetNodeStatus() => this.NodeStatus != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// Indicates whether the nodes is a data, master, or UltraWarm node.
        /// </para>
        /// </summary>
        public NodeType NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property StorageSize. 
        /// <para>
        /// The storage size of the node, in GiB.
        /// </para>
        /// </summary>
        public string StorageSize { get; set; }

        /// <summary>
        /// Checks to see if the StorageSize property is set.
        /// </summary>
        internal bool IsSetStorageSize() => this.StorageSize != null;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Indicates if the node has EBS or instance storage. 
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property StorageVolumeType. 
        /// <para>
        /// If the nodes has EBS storage, indicates if the volume type is gp2 or gp3. Only applicable
        /// for data nodes. 
        /// </para>
        /// </summary>
        public VolumeType StorageVolumeType { get; set; }

        /// <summary>
        /// Checks to see if the StorageVolumeType property is set.
        /// </summary>
        internal bool IsSetStorageVolumeType() => this.StorageVolumeType != null;
    }
}
