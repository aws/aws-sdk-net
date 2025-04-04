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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// The starting position in the data stream from which to start streaming.
    /// </summary>
    public partial class StartingPosition
    {
        private string _sequenceNumber;
        private DateTime? _timestamp;
        private ShardIteratorType _type;

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// The sequence number of the data record in the shard from which to start streaming.
        /// To specify a sequence number, set <c>StartingPosition</c> to <c>AT_SEQUENCE_NUMBER</c>
        /// or <c>AFTER_SEQUENCE_NUMBER</c>.
        /// </para>
        /// </summary>
        public string SequenceNumber
        {
            get { return this._sequenceNumber; }
            set { this._sequenceNumber = value; }
        }

        // Check to see if SequenceNumber property is set
        internal bool IsSetSequenceNumber()
        {
            return this._sequenceNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time stamp of the data record from which to start reading. To specify a time stamp,
        /// set <c>StartingPosition</c> to <c>Type AT_TIMESTAMP</c>. A time stamp is the Unix
        /// epoch date with precision in milliseconds. For example, <c>2016-04-04T19:58:46.480-00:00</c>
        /// or <c>1459799926.480</c>. If a record with this exact time stamp does not exist, records
        /// will be streamed from the next (later) record. If the time stamp is older than the
        /// current trim horizon, records will be streamed from the oldest untrimmed data record
        /// (<c>TRIM_HORIZON</c>).
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// You can set the starting position to one of the following values:
        /// </para>
        ///  
        /// <para>
        ///  <c>AT_SEQUENCE_NUMBER</c>: Start streaming from the position denoted by the sequence
        /// number specified in the <c>SequenceNumber</c> field.
        /// </para>
        ///  
        /// <para>
        ///  <c>AFTER_SEQUENCE_NUMBER</c>: Start streaming right after the position denoted by
        /// the sequence number specified in the <c>SequenceNumber</c> field.
        /// </para>
        ///  
        /// <para>
        ///  <c>AT_TIMESTAMP</c>: Start streaming from the position denoted by the time stamp
        /// specified in the <c>Timestamp</c> field.
        /// </para>
        ///  
        /// <para>
        ///  <c>TRIM_HORIZON</c>: Start streaming at the last untrimmed record in the shard, which
        /// is the oldest data record in the shard.
        /// </para>
        ///  
        /// <para>
        ///  <c>LATEST</c>: Start streaming just after the most recent record in the shard, so
        /// that you always read the most recent data in the shard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ShardIteratorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}