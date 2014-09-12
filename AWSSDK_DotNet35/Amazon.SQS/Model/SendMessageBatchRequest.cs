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
    /// Delivers up to ten messages to the specified queue.      This is a batch version of
    /// <a>SendMessage</a>.      The result of the send action on each message is reported
    /// individually in the response.      The maximum allowed individual message size is
    /// 256 KB (262,144 bytes).
    /// 
    ///     
    /// <para>
    /// The maximum total payload size (i.e., the sum of all a batch's individual message
    /// lengths)      is also 256 KB (262,144 bytes).
    /// </para>
    ///     
    /// <para>
    /// If the <code>DelaySeconds</code> parameter is not specified for an entry,     the
    /// default for the queue is used.
    /// </para>
    ///     <important>The following list shows the characters (in Unicode) that are allowed
    /// in your message, according      to the W3C XML specification. For more information,
    /// go to <a href="http://www.faqs.org/rfcs/rfc1321.html">http://www.faqs.org/rfcs/rfc1321.html</a>.
    ///       If you send any characters that are not included in the list, your request will
    /// be rejected.      
    /// <para>
    /// #x9 | #xA | #xD | [#x20 to #xD7FF] | [#xE000 to #xFFFD] | [#x10000 to #x10FFFF]
    /// </para>
    ///     </important>    <important>      Because the batch request can result in a combination
    /// of successful and unsuccessful actions,       you should check for batch errors even
    /// when the call returns an HTTP status code of 200.     </important>    <note>Some API
    /// actions take lists of parameters. These lists are specified using the <code>param.n</code>
    /// notation. Values      of <code>n</code> are integers starting from 1. For example,
    /// a parameter list with two elements looks like this:     </note>    
    /// <para>
    /// <code>&amp;Attribute.1=this</code>
    /// </para>
    ///     
    /// <para>
    /// <code>&amp;Attribute.2=that</code>
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
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="entries">A list of <a>SendMessageBatchRequestEntry</a> items.</param>
        public SendMessageBatchRequest(string queueUrl, List<SendMessageBatchRequestEntry> entries)
        {
            _queueUrl = queueUrl;
            _entries = entries;
        }

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// A list of <a>SendMessageBatchRequestEntry</a> items.
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
        /// The URL of the Amazon SQS queue to take action on.
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