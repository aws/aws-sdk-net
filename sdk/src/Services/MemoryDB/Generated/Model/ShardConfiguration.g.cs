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
    /// Shard configuration options. Each shard configuration has the following: Slots and
    /// ReplicaCount.
    /// </summary>
    public partial class ShardConfiguration
    {
        /// <summary>
        /// Gets and sets the property ReplicaCount. 
        /// <para>
        /// The number of read replica nodes in this shard.
        /// </para>
        /// </summary>
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaCount property is set.
        /// </summary>
        internal bool IsSetReplicaCount() => this.ReplicaCount.HasValue;

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// A string that specifies the keyspace for a particular node group. Keyspaces range
        /// from 0 to 16,383. The string is in the format startkey-endkey.
        /// </para>
        /// </summary>
        public string Slots { get; set; }

        /// <summary>
        /// Checks to see if the Slots property is set.
        /// </summary>
        internal bool IsSetSlots() => this.Slots != null;
    }
}
