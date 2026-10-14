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

namespace Amazon.KeyspacesStreams.Model
{
    /// <summary>
    /// Represents a uniquely identified group of change records within a change data capture
    /// stream for Amazon Keyspaces.
    /// </summary>
    public partial class Shard
    {
        /// <summary>
        /// Gets and sets the property ParentShardIds. 
        /// <para>
        /// The identifiers of parent shards that this shard evolved from, if this shard was created
        /// through resharding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ParentShardIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ParentShardIds property is set.
        /// </summary>
        internal bool IsSetParentShardIds() => this.ParentShardIds != null && (this.ParentShardIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SequenceNumberRange. 
        /// <para>
        /// The range of sequence numbers contained within this shard.
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
        /// A unique identifier for this shard within the stream.
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
