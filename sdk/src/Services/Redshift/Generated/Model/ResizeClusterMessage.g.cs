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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a resize cluster operation. For example, a scheduled action to run the <c>ResizeCluster</c>
    /// API operation.
    /// </summary>
    public partial class ResizeClusterMessage
    {
        /// <summary>
        /// Gets and sets the property Classic. 
        /// <para>
        /// A boolean value indicating whether the resize operation is using the classic resize
        /// process. If you don't provide this parameter or set the value to <c>false</c>, the
        /// resize type is elastic. 
        /// </para>
        /// </summary>
        public bool? Classic { get; set; }

        /// <summary>
        /// Checks to see if the Classic property is set.
        /// </summary>
        internal bool IsSetClassic() => this.Classic.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier for the cluster to resize.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property ClusterType. 
        /// <para>
        /// The new cluster type for the specified cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterType { get; set; }

        /// <summary>
        /// Checks to see if the ClusterType property is set.
        /// </summary>
        internal bool IsSetClusterType() => this.ClusterType != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The new node type for the nodes you are adding. If not specified, the cluster's current
        /// node type is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        /// The new number of nodes for the cluster. If not specified, the cluster's current number
        /// of nodes is used.
        /// </para>
        /// </summary>
        public int? NumberOfNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfNodes property is set.
        /// </summary>
        internal bool IsSetNumberOfNodes() => this.NumberOfNodes.HasValue;

        /// <summary>
        /// Gets and sets the property ReservedNodeId. 
        /// <para>
        /// The identifier of the reserved node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ReservedNodeId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedNodeId property is set.
        /// </summary>
        internal bool IsSetReservedNodeId() => this.ReservedNodeId != null;

        /// <summary>
        /// Gets and sets the property TargetReservedNodeOfferingId. 
        /// <para>
        /// The identifier of the target reserved node offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string TargetReservedNodeOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the TargetReservedNodeOfferingId property is set.
        /// </summary>
        internal bool IsSetTargetReservedNodeOfferingId() => this.TargetReservedNodeOfferingId != null;
    }
}
