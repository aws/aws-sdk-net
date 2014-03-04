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
    /// <para>Represents the output of a <c>PutRecord</c> operation.</para>
    /// </summary>
    public partial class PutRecordResult
    {
        
        private string shardId;
        private string sequenceNumber;

        /// <summary>
        /// The shard ID of the shard where the data record was placed.
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
        public PutRecordResult WithShardId(string shardId)
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
        /// The sequence number identifier that was assigned to the put data record. The sequence number for the record is unique across all records in
        /// the stream. A sequence number is the identifier associated with every record put into the stream.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>0|([1-9]\d{0,128})</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SequenceNumber
        {
            get { return this.sequenceNumber; }
            set { this.sequenceNumber = value; }
        }

        /// <summary>
        /// Sets the SequenceNumber property
        /// </summary>
        /// <param name="sequenceNumber">The value to set for the SequenceNumber property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutRecordResult WithSequenceNumber(string sequenceNumber)
        {
            this.sequenceNumber = sequenceNumber;
            return this;
        }
            

        // Check to see if SequenceNumber property is set
        internal bool IsSetSequenceNumber()
        {
            return this.sequenceNumber != null;
        }
    }
}
