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

/*
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Container for the parameters to the SendMessageBatch operation.
    /// Delivers up to ten messages to the specified queue. This is a batch version of <code>
    /// <a>SendMessage</a>.</code> For a FIFO queue, multiple messages within a single batch
    /// are enqueued in the order they are sent.
    /// 
    ///  
    /// <para>
    /// The result of sending each message is reported individually in the response. Because
    /// the batch request can result in a combination of successful and unsuccessful actions,
    /// you should check for batch errors even when the call returns an HTTP status code of
    /// <code>200</code>.
    /// </para>
    ///  
    /// <para>
    /// The maximum allowed individual message size and the maximum total payload size (the
    /// sum of the individual lengths of all of the batched messages) are both 256 KB (262,144
    /// bytes).
    /// </para>
    ///  <important> 
    /// <para>
    /// A message can include only XML, JSON, and unformatted text. The following Unicode
    /// characters are allowed:
    /// </para>
    ///  
    /// <para>
    ///  <code>#x9</code> | <code>#xA</code> | <code>#xD</code> | <code>#x20</code> to <code>#xD7FF</code>
    /// | <code>#xE000</code> to <code>#xFFFD</code> | <code>#x10000</code> to <code>#x10FFFF</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// Any characters not included in this list will be rejected. For more information, see
    /// the <a href="http://www.w3.org/TR/REC-xml/#charsets">W3C specification for characters</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// If you don't specify the <code>DelaySeconds</code> parameter for an entry, Amazon
    /// SQS uses the default value for the queue.
    /// </para>
    ///  
    /// <para>
    /// Some actions take lists of parameters. These lists are specified using the <code>param.n</code>
    /// notation. Values of <code>n</code> are integers starting from 1. For example, a parameter
    /// list with two elements looks like this:
    /// </para>
    ///  
    /// <para>
    ///  <code>&amp;Attribute.1=first</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>&amp;Attribute.2=second</code> 
    /// </para>
    /// </summary>
    public partial class SendMessageBatchRequest : AmazonSQSRequest
    {
        private List<SendMessageBatchRequestEntry> _entries = new List<SendMessageBatchRequestEntry>();
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SendMessageBatchRequest() { }

        /// <summary>
        /// Instantiates SendMessageBatchRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to which batched messages are sent. Queue URLs and names are case-sensitive.</param>
        /// <param name="entries">A list of <code> <a>SendMessageBatchRequestEntry</a> </code> items.</param>
        public SendMessageBatchRequest(string queueUrl, List<SendMessageBatchRequestEntry> entries)
        {
            _queueUrl = queueUrl;
            _entries = entries;
        }

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// A list of <code> <a>SendMessageBatchRequestEntry</a> </code> items.
        /// </para>
        /// </summary>
        public List<SendMessageBatchRequestEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && this._entries.Count > 0; 
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