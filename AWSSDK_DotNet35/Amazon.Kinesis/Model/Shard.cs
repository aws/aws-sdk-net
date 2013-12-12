/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// <para>A uniquely identified group of data records in an Amazon Kinesis stream.</para>
    /// </summary>
    public class Shard
    {
        
        private string shardId;
        private string parentShardId;
        private string adjacentParentShardId;
        private HashKeyRange hashKeyRange;
        private SequenceNumberRange sequenceNumberRange;


        /// <summary>
        /// The unique identifier of the shard within the Amazon Kinesis stream.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ShardId
        {
            get { return this.shardId; }
            set { this.shardId = value; }
        }

        // Check to see if ShardId property is set
        internal bool IsSetShardId()
        {
            return this.shardId != null;
        }

        /// <summary>
        /// The shard Id of the shard's parent.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ParentShardId
        {
            get { return this.parentShardId; }
            set { this.parentShardId = value; }
        }

        // Check to see if ParentShardId property is set
        internal bool IsSetParentShardId()
        {
            return this.parentShardId != null;
        }

        /// <summary>
        /// The shard Id of the shard adjacent to the shard's parent.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AdjacentParentShardId
        {
            get { return this.adjacentParentShardId; }
            set { this.adjacentParentShardId = value; }
        }

        // Check to see if AdjacentParentShardId property is set
        internal bool IsSetAdjacentParentShardId()
        {
            return this.adjacentParentShardId != null;
        }

        /// <summary>
        /// The range of possible hash key values for the shard, which is a set of ordered contiguous positive integers.
        ///  
        /// </summary>
        public HashKeyRange HashKeyRange
        {
            get { return this.hashKeyRange; }
            set { this.hashKeyRange = value; }
        }

        // Check to see if HashKeyRange property is set
        internal bool IsSetHashKeyRange()
        {
            return this.hashKeyRange != null;
        }

        /// <summary>
        /// The range of possible sequence numbers for the shard.
        ///  
        /// </summary>
        public SequenceNumberRange SequenceNumberRange
        {
            get { return this.sequenceNumberRange; }
            set { this.sequenceNumberRange = value; }
        }

        // Check to see if SequenceNumberRange property is set
        internal bool IsSetSequenceNumberRange()
        {
            return this.sequenceNumberRange != null;
        }
    }
}
