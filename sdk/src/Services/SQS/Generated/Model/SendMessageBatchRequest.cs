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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
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
namespace Amazon.SQS.Model
{
    /// <summary>
    /// Container for the parameters to the SendMessageBatch operation.
    /// You can use <c>SendMessageBatch</c> to send up to 10 messages to the specified queue
    /// by assigning either identical or different values to each message (or by not assigning
    /// values at all). This is a batch version of <c> <a>SendMessage</a>.</c> For a FIFO
    /// queue, multiple messages within a single batch are enqueued in the order they are
    /// sent.
    /// 
    ///  
    /// <para>
    /// The result of sending each message is reported individually in the response. Because
    /// the batch request can result in a combination of successful and unsuccessful actions,
    /// you should check for batch errors even when the call returns an HTTP status code of
    /// <c>200</c>.
    /// </para>
    ///  
    /// <para>
    /// The maximum allowed individual message size and the maximum total payload size (the
    /// sum of the individual lengths of all of the batched messages) are both 1 MiB 1,048,576
    /// bytes.
    /// </para>
    ///  <important> 
    /// <para>
    /// A message can include only XML, JSON, and unformatted text. The following Unicode
    /// characters are allowed. For more information, see the <a href="http://www.w3.org/TR/REC-xml/#charsets">W3C
    /// specification for characters</a>.
    /// </para>
    ///  
    /// <para>
    ///  <c>#x9</c> | <c>#xA</c> | <c>#xD</c> | <c>#x20</c> to <c>#xD7FF</c> | <c>#xE000</c>
    /// to <c>#xFFFD</c> | <c>#x10000</c> to <c>#x10FFFF</c> 
    /// </para>
    ///  
    /// <para>
    /// If a message contains characters outside the allowed set, Amazon SQS rejects the message
    /// and returns an InvalidMessageContents error. Ensure that your message body includes
    /// only valid characters to avoid this exception.
    /// </para>
    ///  </important> 
    /// <para>
    /// If you don't specify the <c>DelaySeconds</c> parameter for an entry, Amazon SQS uses
    /// the default value for the queue.
    /// </para>
    /// </summary>
    public partial class SendMessageBatchRequest : AmazonSQSRequest
    {
        private List<SendMessageBatchRequestEntry> _entries = AWSConfigs.InitializeCollections ? new List<SendMessageBatchRequestEntry>() : null;
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SendMessageBatchRequest() { }

        /// <summary>
        /// Instantiates SendMessageBatchRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to which batched messages are sent. Queue URLs and names are case-sensitive.</param>
        /// <param name="entries">A list of <c> <a>SendMessageBatchRequestEntry</a> </c> items.</param>
        public SendMessageBatchRequest(string queueUrl, List<SendMessageBatchRequestEntry> entries)
        {
            _queueUrl = queueUrl;
            _entries = entries;
        }

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// A list of <c> <a>SendMessageBatchRequestEntry</a> </c> items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SendMessageBatchRequestEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && (this._entries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the Amazon SQS queue to which batched messages are sent.
        /// </para>
        ///  
        /// <para>
        /// Queue URLs and names are case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueUrl
        {
            get { return this._queueUrl; }
            set { this._queueUrl = value; }
        }

        // Check to see if QueueUrl property is set
        internal bool IsSetQueueUrl()
        {
            return this._queueUrl != null;
        }

    }
}