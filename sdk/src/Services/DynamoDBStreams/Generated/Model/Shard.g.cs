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

namespace Amazon.DynamoDBStreams.Model
{
    /// <summary>
    /// A uniquely identified group of stream records within a stream.
    /// </summary>
    public partial class Shard
    {
        /// <summary>
        /// Gets and sets the property ParentShardId. 
        /// <para>
        /// The shard ID of the current shard's parent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 28, Max = 65)]
        public string ParentShardId { get; set; }

        /// <summary>
        /// Checks to see if the ParentShardId property is set.
        /// </summary>
        internal bool IsSetParentShardId() => this.ParentShardId != null;

        /// <summary>
        /// Gets and sets the property SequenceNumberRange. 
        /// <para>
        /// The range of possible sequence numbers for the shard.
        /// </para>
        /// </summary>
        public SequenceNumberRange SequenceNumberRange { get; set; }

        /// <summary>
        /// Checks to see if the SequenceNumberRange property is set.
        /// </summary>
        internal bool IsSetSequenceNumberRange() => this.SequenceNumberRange != null;

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        /// The system-generated identifier for this shard.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 28, Max = 65)]
        public string ShardId { get; set; }

        /// <summary>
        /// Checks to see if the ShardId property is set.
        /// </summary>
        internal bool IsSetShardId() => this.ShardId != null;
    }
}
