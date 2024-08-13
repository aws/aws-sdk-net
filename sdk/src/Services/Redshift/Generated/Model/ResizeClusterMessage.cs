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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
        private bool? _classic;
        private string _clusterIdentifier;
        private string _clusterType;
        private string _nodeType;
        private int? _numberOfNodes;
        private string _reservedNodeId;
        private string _targetReservedNodeOfferingId;

        /// <summary>
        /// Gets and sets the property Classic. 
        /// <para>
        /// A boolean value indicating whether the resize operation is using the classic resize
        /// process. If you don't provide this parameter or set the value to <c>false</c>, the
        /// resize type is elastic. 
        /// </para>
        /// </summary>
        public bool? Classic
        {
            get { return this._classic; }
            set { this._classic = value; }
        }

        // Check to see if Classic property is set
        internal bool IsSetClassic()
        {
            return this._classic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier for the cluster to resize.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterType. 
        /// <para>
        /// The new cluster type for the specified cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterType
        {
            get { return this._clusterType; }
            set { this._clusterType = value; }
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this._clusterType != null;
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The new node type for the nodes you are adding. If not specified, the cluster's current
        /// node type is used.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        /// The new number of nodes for the cluster. If not specified, the cluster's current number
        /// of nodes is used.
        /// </para>
        /// </summary>
        public int? NumberOfNodes
        {
            get { return this._numberOfNodes; }
            set { this._numberOfNodes = value; }
        }

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this._numberOfNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservedNodeId. 
        /// <para>
        /// The identifier of the reserved node.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ReservedNodeId
        {
            get { return this._reservedNodeId; }
            set { this._reservedNodeId = value; }
        }

        // Check to see if ReservedNodeId property is set
        internal bool IsSetReservedNodeId()
        {
            return this._reservedNodeId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetReservedNodeOfferingId. 
        /// <para>
        /// The identifier of the target reserved node offering.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string TargetReservedNodeOfferingId
        {
            get { return this._targetReservedNodeOfferingId; }
            set { this._targetReservedNodeOfferingId = value; }
        }

        // Check to see if TargetReservedNodeOfferingId property is set
        internal bool IsSetTargetReservedNodeOfferingId()
        {
            return this._targetReservedNodeOfferingId != null;
        }

    }
}