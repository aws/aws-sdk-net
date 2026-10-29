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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// This is the response object from the GetRecords operation.
    /// </summary>
    public partial class GetRecordsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChildShards. 
        /// <para>
        /// The list of the current shard's child shards, returned in the <c>GetRecords</c> API's
        /// response only when the end of the current shard is reached.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChildShard> ChildShards { get; set; } = AWSConfigs.InitializeCollections ? new List<ChildShard>() : null;

        /// <summary>
        /// Checks to see if the ChildShards property is set.
        /// </summary>
        internal bool IsSetChildShards() => this.ChildShards != null && (this.ChildShards.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MillisBehindLatest. 
        /// <para>
        /// The number of milliseconds the <a>GetRecords</a> response is from the tip of the stream,
        /// indicating how far behind current time the consumer is. A value of zero indicates
        /// that record processing is caught up, and there are no new records to process at this
        /// moment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? MillisBehindLatest { get; set; }

        /// <summary>
        /// Checks to see if the MillisBehindLatest property is set.
        /// </summary>
        internal bool IsSetMillisBehindLatest() => this.MillisBehindLatest.HasValue;

        /// <summary>
        /// Gets and sets the property NextShardIterator. 
        /// <para>
        /// The next position in the shard from which to start sequentially reading data records.
        /// If set to <c>null</c>, the shard has been closed and the requested iterator does not
        /// return any more data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string NextShardIterator { get; set; }

        /// <summary>
        /// Checks to see if the NextShardIterator property is set.
        /// </summary>
        internal bool IsSetNextShardIterator() => this.NextShardIterator != null;

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// The data records retrieved from the shard.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Record> Records { get; set; } = AWSConfigs.InitializeCollections ? new List<Record>() : null;

        /// <summary>
        /// Checks to see if the Records property is set.
        /// </summary>
        internal bool IsSetRecords() => this.Records != null && (this.Records.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
