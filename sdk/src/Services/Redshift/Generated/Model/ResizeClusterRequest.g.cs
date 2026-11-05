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
    /// Container for the parameters to the ResizeCluster operation. Changes the size of the
    /// cluster. You can change the cluster's type, or change the number or type of nodes.
    /// The default behavior is to use the elastic resize method. With an elastic resize,
    /// your cluster is available for read and write operations more quickly than with the
    /// classic resize method. <para> Elastic resize operations have the following restrictions:
    /// </para> <ul> <li> <para> You can only resize clusters of the following types: </para>
    /// <ul> <li> <para> dc2.large </para> </li> <li> <para> dc2.8xlarge </para> </li> <li>
    /// <para> rg.large </para> </li> <li> <para> rg.xlarge </para> </li> <li> <para> rg.4xlarge
    /// </para> </li> <li> <para> rg.12xlarge </para> </li> <li> <para> ra3.large </para>
    /// </li> <li> <para> ra3.xlplus </para> </li> <li> <para> ra3.4xlarge </para> </li> <li>
    /// <para> ra3.16xlarge </para> </li> </ul> </li> <li> <para> The type of nodes that you
    /// add must match the node type for the cluster. </para> </li> </ul>
    /// </summary>
    public partial class ResizeClusterRequest : AmazonRedshiftRequest
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
