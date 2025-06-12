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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.Kinesis.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// After you call <a>SubscribeToShard</a>, Kinesis Data Streams sends events of this
    /// type over an HTTP/2 connection to your consumer.
    /// </summary>
    public partial class SubscribeToShardEvent
        : IEventStreamEvent
    {
        private List<ChildShard> _childShards = AWSConfigs.InitializeCollections ? new List<ChildShard>() : null;
        private string _continuationSequenceNumber;
        private long? _millisBehindLatest;
        private List<Record> _records = AWSConfigs.InitializeCollections ? new List<Record>() : null;

        /// <summary>
        /// Gets and sets the property ChildShards. 
        /// <para>
        /// The list of the child shards of the current shard, returned only at the end of the
        /// current shard.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChildShard> ChildShards
        {
            get { return this._childShards; }
            set { this._childShards = value; }
        }

        // Check to see if ChildShards property is set
        internal bool IsSetChildShards()
        {
            return this._childShards != null && (this._childShards.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContinuationSequenceNumber. 
        /// <para>
        /// Use this as <c>SequenceNumber</c> in the next call to <a>SubscribeToShard</a>, with
        /// <c>StartingPosition</c> set to <c>AT_SEQUENCE_NUMBER</c> or <c>AFTER_SEQUENCE_NUMBER</c>.
        /// Use <c>ContinuationSequenceNumber</c> for checkpointing because it captures your shard
        /// progress even when no data is written to the shard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContinuationSequenceNumber
        {
            get { return this._continuationSequenceNumber; }
            set { this._continuationSequenceNumber = value; }
        }

        // Check to see if ContinuationSequenceNumber property is set
        internal bool IsSetContinuationSequenceNumber()
        {
            return this._continuationSequenceNumber != null;
        }

        /// <summary>
        /// Gets and sets the property MillisBehindLatest. 
        /// <para>
        /// The number of milliseconds the read records are from the tip of the stream, indicating
        /// how far behind current time the consumer is. A value of zero indicates that record
        /// processing is caught up, and there are no new records to process at this moment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? MillisBehindLatest
        {
            get { return this._millisBehindLatest; }
            set { this._millisBehindLatest = value; }
        }

        // Check to see if MillisBehindLatest property is set
        internal bool IsSetMillisBehindLatest()
        {
            return this._millisBehindLatest.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Records.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Record> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && (this._records.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}