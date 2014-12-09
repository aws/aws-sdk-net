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
    /// Container for the parameters to the ChangeMessageVisibilityBatch operation.
    /// Changes the visibility timeout of multiple messages. This is a batch version of <a>ChangeMessageVisibility</a>.
    /// The result of the action on each message is reported individually in the response.
    /// You can send up to 10 <a>ChangeMessageVisibility</a> requests with each <code>ChangeMessageVisibilityBatch</code>
    /// action.
    /// 
    ///  <important>Because the batch request can result in a combination of successful and
    /// unsuccessful actions, you should check for batch errors even when the call returns
    /// an HTTP status code of 200.</important> <note>Some API actions take lists of parameters.
    /// These lists are specified using the <code>param.n</code> notation. Values of <code>n</code>
    /// are integers starting from 1. For example, a parameter list with two elements looks
    /// like this: </note> 
    /// <para>
    /// <code>&amp;Attribute.1=this</code>
    /// </para>
    ///  
    /// <para>
    /// <code>&amp;Attribute.2=that</code>
    /// </para>
    /// </summary>
    public partial class ChangeMessageVisibilityBatchRequest : AmazonSQSRequest
    {
        private List<ChangeMessageVisibilityBatchRequestEntry> _entries = new List<ChangeMessageVisibilityBatchRequestEntry>();
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ChangeMessageVisibilityBatchRequest() { }

        /// <summary>
        /// Instantiates ChangeMessageVisibilityBatchRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="entries">A list of receipt handles of the messages for which the visibility timeout must be changed.</param>
        public ChangeMessageVisibilityBatchRequest(string queueUrl, List<ChangeMessageVisibilityBatchRequestEntry> entries)
        {
            _queueUrl = queueUrl;
            _entries = entries;
        }

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// A list of receipt handles of the messages for which the visibility timeout must be
        /// changed.
        /// </para>
        /// </summary>
        public List<ChangeMessageVisibilityBatchRequestEntry> Entries
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