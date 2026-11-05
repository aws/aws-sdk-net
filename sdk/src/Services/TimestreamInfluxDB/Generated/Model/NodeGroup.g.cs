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

namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// A group of one or more nodes in a Timestream for InfluxDB cluster that share the same
    /// instance modes and instance type. A cluster's compute topology is defined as a list
    /// of node groups.
    /// </summary>
    public partial class NodeGroup
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of nodes in this group. Valid values are 1 to 13.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 13)]
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceModes. 
        /// <para>
        /// The functions that the nodes in this group perform. Provide from 1 to 4 unique modes.
        /// Valid modes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// INGEST – Nodes in this mode ingest data. Across all node groups, INGEST nodes must
        /// total between 1 and 4.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// QUERY – Nodes in this mode query data. Across all node groups, QUERY nodes must total
        /// between 0 and 14.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// COMPACT – Nodes in this mode compact data. Exactly one node across all node groups
        /// must have this mode. If the cluster has more than three non-compaction nodes, place
        /// the COMPACT node in its own dedicated node group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PROCESS – Nodes in this mode process data with the processing engine.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4)]
        public List<string> InstanceModes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceModes property is set.
        /// </summary>
        internal bool IsSetInstanceModes() => this.InstanceModes != null && (this.InstanceModes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Timestream for InfluxDB DB instance type to run InfluxDB on for the nodes in this
        /// group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DbInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;
    }
}
