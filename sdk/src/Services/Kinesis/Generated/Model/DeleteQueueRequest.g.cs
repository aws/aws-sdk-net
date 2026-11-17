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
    /// Container for the parameters to the DeleteQueue operation. Deletes the specified queue.
    /// Records that are in flight when you delete the queue are not delivered again, and
    /// receipt handles issued by the queue stop being valid. <para> Deleting a queue does
    /// not delete the data stream the queue was created on, and does not delete any records
    /// in that stream. Those records remain available to stream consumers and to other queues
    /// on the same stream for the rest of their retention period. </para> <para> <c>DeleteQueue</c>
    /// is an asynchronous operation. Upon receiving a <c>DeleteQueue</c> request, Amazon
    /// Kinesis Data Streams sets the <c>QueueStatus</c> to <c>DELETING</c>. The queue is
    /// deleted when the operation completes. A queue in the <c>DELETING</c> state does not
    /// deliver records. </para> <para> You must delete every queue on a data stream before
    /// you can delete the stream, or switch it from on-demand to provisioned capacity mode.
    /// </para>
    /// </summary>
    public partial class DeleteQueueRequest : AmazonKinesisRequest
    {
        /// <summary>
        /// Gets and sets the property QueueARN. 
        /// <para>
        /// The ARN of the queue to delete.
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
