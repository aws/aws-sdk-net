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
    /// Container for the parameters to the AcknowledgeQueueRecords operation. Acknowledges
    /// up to 10 records from the specified queue. After a record is acknowledged, the queue
    /// does not deliver it again. The result for each entry is reported individually in the
    /// response. <para> Acknowledging a record does not affect the record in the data stream.
    /// That record remains available to stream consumers and to other queues on the same
    /// stream for the rest of its retention period. </para> <para> Because the request can
    /// result in a combination of successful and unsuccessful entries, check the <c>Failed</c>
    /// list even when the call returns an HTTP status code of <c>200</c>. </para> <para>
    /// On rare occasions, you can receive a record again after you acknowledge it. Design
    /// your queue consumer to be idempotent, so that processing the same record more than
    /// once is safe. </para>
    /// </summary>
    public partial class AcknowledgeQueueRecordsRequest : AmazonKinesisRequest
    {
        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The records to acknowledge, identified by their receipt handles.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<AcknowledgeQueueRecordsRequestEntry> Entries { get; set; } = AWSConfigs.InitializeCollections ? new List<AcknowledgeQueueRecordsRequestEntry>() : null;

        /// <summary>
        /// Checks to see if the Entries property is set.
        /// </summary>
        internal bool IsSetEntries() => this.Entries != null && (this.Entries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueueARN. 
        /// <para>
        /// The ARN of the queue the records were received from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string QueueARN { get; set; }

        /// <summary>
        /// Checks to see if the QueueARN property is set.
        /// </summary>
        internal bool IsSetQueueARN() => this.QueueARN != null;
    }
}
