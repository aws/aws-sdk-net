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
    /// <para>Represents the output of a <c>GetShardIterator</c> operation.</para>
    /// </summary>
    public partial class GetShardIteratorResult
    {
        
        private string shardIterator;

        /// <summary>
        /// The position in the shard from which to start reading data records sequentially. A shard iterator specifies this position using the sequence
        /// number of a data record in a shard.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 512</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ShardIterator
        {
            get { return this.shardIterator; }
            set { this.shardIterator = value; }
        }

        /// <summary>
        /// Sets the ShardIterator property
        /// </summary>
        /// <param name="shardIterator">The value to set for the ShardIterator property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetShardIteratorResult WithShardIterator(string shardIterator)
        {
            this.shardIterator = shardIterator;
            return this;
        }
            

        // Check to see if ShardIterator property is set
        internal bool IsSetShardIterator()
        {
            return this.shardIterator != null;
        }
    }
}
