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
    /// Provides details of a shard in a snapshot
    /// </summary>
    public partial class ShardDetail
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration details of the shard
        /// </para>
        /// </summary>
        public ShardConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

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
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the shard's snapshot
        /// </para>
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size != null;

        /// <summary>
        /// Gets and sets the property SnapshotCreationTime. 
        /// <para>
        /// The date and time that the shard's snapshot was created
        /// </para>
        /// </summary>
        public DateTime? SnapshotCreationTime { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCreationTime property is set.
        /// </summary>
        internal bool IsSetSnapshotCreationTime() => this.SnapshotCreationTime.HasValue;
    }
}
