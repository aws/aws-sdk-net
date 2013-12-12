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
    /// <para>The unit of data of the Amazon Kinesis stream, which is composed of a sequence number, a partition key, and a data blob.</para>
    /// </summary>
    public class Record
    {
        
        private string sequenceNumber;
        private MemoryStream data;
        private string partitionKey;


        /// <summary>
        /// The unique identifier for the record in the Amazon Kinesis stream.
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

        // Check to see if SequenceNumber property is set
        internal bool IsSetSequenceNumber()
        {
            return this.sequenceNumber != null;
        }

        /// <summary>
        /// The data blob. The data in the blob is both opaque and immutable to the Amazon Kinesis service, which does not inspect, interpret, or change
        /// the data in the blob in any way. The maximum size of the data blob is 50 kilobytes (KB).
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
        /// Identifies which shard in the stream the data record is assigned to.
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
    }
}
