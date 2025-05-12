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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
        private string _availabilityZone;
        private OpenSearchPartitionInstanceType _instanceType;
        private string _nodeId;
        private NodeStatus _nodeStatus;
        private NodeType _nodeType;
        private string _storageSize;
        private string _storageType;
        private VolumeType _storageVolumeType;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type information of the node.
        /// </para>
        /// </summary>
        public OpenSearchPartitionInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        /// The ID of the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=40)]
        public string NodeId
        {
            get { return this._nodeId; }
            set { this._nodeId = value; }
        }

        // Check to see if NodeId property is set
        internal bool IsSetNodeId()
        {
            return this._nodeId != null;
        }

        /// <summary>
        /// Gets and sets the property NodeStatus. 
        /// <para>
        /// Indicates if the node is active or in standby.
        /// </para>
        /// </summary>
        public NodeStatus NodeStatus
        {
            get { return this._nodeStatus; }
            set { this._nodeStatus = value; }
        }

        // Check to see if NodeStatus property is set
        internal bool IsSetNodeStatus()
        {
            return this._nodeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// Indicates whether the nodes is a data, master, or UltraWarm node.
        /// </para>
        /// </summary>
        public NodeType NodeType
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
        /// Gets and sets the property StorageSize. 
        /// <para>
        /// The storage size of the node, in GiB.
        /// </para>
        /// </summary>
        public string StorageSize
        {
            get { return this._storageSize; }
            set { this._storageSize = value; }
        }

        // Check to see if StorageSize property is set
        internal bool IsSetStorageSize()
        {
            return this._storageSize != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Indicates if the node has EBS or instance storage. 
        /// </para>
        /// </summary>
        public string StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

        /// <summary>
        /// Gets and sets the property StorageVolumeType. 
        /// <para>
        /// If the nodes has EBS storage, indicates if the volume type is gp2 or gp3. Only applicable
        /// for data nodes. 
        /// </para>
        /// </summary>
        public VolumeType StorageVolumeType
        {
            get { return this._storageVolumeType; }
            set { this._storageVolumeType = value; }
        }

        // Check to see if StorageVolumeType property is set
        internal bool IsSetStorageVolumeType()
        {
            return this._storageVolumeType != null;
        }

    }
}