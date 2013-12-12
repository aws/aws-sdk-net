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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the PutRecord operation.
    /// <para>This operation puts a data record into an Amazon Kinesis stream from a producer. This operation must be called to send data from the
    /// producer into the Amazon Kinesis stream for real-time ingestion and subsequent processing. The <c>PutRecord</c> operation requires the name
    /// of the stream that captures, stores, and transports the data; a partition key; and the data blob itself. The data blob could be a segment
    /// from a log file, geographic/location data, website clickstream data, or any other data type.</para> <para>The partition key is used to
    /// distribute data across shards. Amazon Kinesis segregates the data records that belong to a data stream into multiple shards, using the
    /// partition key associated with each data record to determine which shard a given data record belongs to. </para> <para>Partition keys are
    /// Unicode strings, with a maximum length limit of 256 bytes. An MD5 hash function is used to map partition keys to 128-bit integer values and
    /// to map associated data records to shards using the hash key ranges of the shards. You can override hashing the partition key to determine
    /// the shard by explicitly specifying a hash value using the <c>ExplicitHashKey</c> parameter. For more information, see the <a
    /// href="http://docs.aws.amazon.com/kinesis/latest/dev/" >Amazon Kinesis Developer Guide</a> .</para> <para> <c>PutRecord</c> returns the shard
    /// ID of where the data record was placed and the sequence number that was assigned to the data record.</para> <para>The
    /// <c>SequenceNumberForOrdering</c> sets the initial sequence number for the partition key. Later <c>PutRecord</c> requests to the same
    /// partition key (from the same client) will automatically increase from <c>SequenceNumberForOrdering</c> , ensuring strict sequential
    /// ordering.</para> <para>If a <c>PutRecord</c> request cannot be processed because of insufficient provisioned throughput on the shard
    /// involved in the request, <c>PutRecord</c> throws <c>ProvisionedThroughputExceededException</c> . </para> <para>Data records are accessible
    /// for only 24 hours from the time that they are added to an Amazon Kinesis stream.</para>
    /// </summary>
    public partial class PutRecordRequest : AmazonKinesisRequest
    {
        private string streamName;
        private MemoryStream data;
        private string partitionKey;
        private string explicitHashKey;
        private string sequenceNumberForOrdering;


        /// <summary>
        /// The name of the stream to put the data record into.
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
        public string StreamName
        {
            get { return this.streamName; }
            set { this.streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this.streamName != null;
        }

        /// <summary>
        /// The data blob to put into the record, which must be Base64 encoded. The maximum size of the data blob is 50 kilobytes (KB).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 51200</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public MemoryStream Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this.data != null;
        }

        /// <summary>
        /// Determines which shard in the stream the data record is assigned to. Partition keys are Unicode strings with a maximum length limit of 256
        /// bytes. Amazon Kinesis uses the partition key as input to a hash function that maps the partition key and associated data to a specific
        /// shard. Specifically, an MD5 hash function is used to map partition keys to 128-bit integer values and to map associated data records to
        /// shards. As a result of this hashing mechanism, all data records with the same partition key will map to the same shard within the stream.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PartitionKey
        {
            get { return this.partitionKey; }
            set { this.partitionKey = value; }
        }

        // Check to see if PartitionKey property is set
        internal bool IsSetPartitionKey()
        {
            return this.partitionKey != null;
        }

        /// <summary>
        /// The hash value used to explicitly determine the shard the data record is assigned to by overriding the partition key hash.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>0|([1-9]\d{0,38})</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ExplicitHashKey
        {
            get { return this.explicitHashKey; }
            set { this.explicitHashKey = value; }
        }

        // Check to see if ExplicitHashKey property is set
        internal bool IsSetExplicitHashKey()
        {
            return this.explicitHashKey != null;
        }

        /// <summary>
        /// The sequence number to use as the initial number for the partition key. Subsequent calls to <c>PutRecord</c> from the same client and for
        /// the same partition key will increase from the <c>SequenceNumberForOrdering</c> value.
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
        public string SequenceNumberForOrdering
        {
            get { return this.sequenceNumberForOrdering; }
            set { this.sequenceNumberForOrdering = value; }
        }

        // Check to see if SequenceNumberForOrdering property is set
        internal bool IsSetSequenceNumberForOrdering()
        {
            return this.sequenceNumberForOrdering != null;
        }

    }
}
    
