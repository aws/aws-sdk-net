/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    public partial class Shard
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

        /// <summary>
        /// Sets the ShardId property
        /// </summary>
        /// <param name="shardId">The value to set for the ShardId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Shard WithShardId(string shardId)
        {
            this.shardId = shardId;
            return this;
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

        /// <summary>
        /// Sets the ParentShardId property
        /// </summary>
        /// <param name="parentShardId">The value to set for the ParentShardId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Shard WithParentShardId(string parentShardId)
        {
            this.parentShardId = parentShardId;
            return this;
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

        /// <summary>
        /// Sets the AdjacentParentShardId property
        /// </summary>
        /// <param name="adjacentParentShardId">The value to set for the AdjacentParentShardId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Shard WithAdjacentParentShardId(string adjacentParentShardId)
        {
            this.adjacentParentShardId = adjacentParentShardId;
            return this;
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

        /// <summary>
        /// Sets the HashKeyRange property
        /// </summary>
        /// <param name="hashKeyRange">The value to set for the HashKeyRange property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Shard WithHashKeyRange(HashKeyRange hashKeyRange)
        {
            this.hashKeyRange = hashKeyRange;
            return this;
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

        /// <summary>
        /// Sets the SequenceNumberRange property
        /// </summary>
        /// <param name="sequenceNumberRange">The value to set for the SequenceNumberRange property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Shard WithSequenceNumberRange(SequenceNumberRange sequenceNumberRange)
        {
            this.sequenceNumberRange = sequenceNumberRange;
            return this;
        }
            

        // Check to see if SequenceNumberRange property is set
        internal bool IsSetSequenceNumberRange()
        {
            return this.sequenceNumberRange != null;
        }
    }
}
