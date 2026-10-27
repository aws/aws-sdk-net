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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Represents a collection of nodes in a cluster. One node in the node group is the read/write
    /// primary node. All the other nodes are read-only Replica nodes.
    /// </summary>
    public partial class Shard
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the shard
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Nodes. 
        /// <para>
        /// A list containing information about individual nodes within the shard
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Node> Nodes { get; set; } = AWSConfigs.InitializeCollections ? new List<Node>() : null;

        /// <summary>
        /// Checks to see if the Nodes property is set.
        /// </summary>
        internal bool IsSetNodes() => this.Nodes != null && (this.Nodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        /// The number of nodes in the shard
        /// </para>
        /// </summary>
        public int? NumberOfNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfNodes property is set.
        /// </summary>
        internal bool IsSetNumberOfNodes() => this.NumberOfNodes.HasValue;

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// The keyspace for this shard.
        /// </para>
        /// </summary>
        public string Slots { get; set; }

        /// <summary>
        /// Checks to see if the Slots property is set.
        /// </summary>
        internal bool IsSetSlots() => this.Slots != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of this replication group - creating, available, modifying, deleting.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
