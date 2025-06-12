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
    /// Container for the parameters to the DeleteMessageBatch operation.
    /// Deletes up to ten messages from the specified queue. This is a batch version of <c>
    /// <a>DeleteMessage</a>.</c> The result of the action on each message is reported individually
    /// in the response.
    /// 
    ///  <important> 
    /// <para>
    /// Because the batch request can result in a combination of successful and unsuccessful
    /// actions, you should check for batch errors even when the call returns an HTTP status
    /// code of <c>200</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteMessageBatchRequest : AmazonSQSRequest
    {
        private List<DeleteMessageBatchRequestEntry> _entries = AWSConfigs.InitializeCollections ? new List<DeleteMessageBatchRequestEntry>() : null;
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteMessageBatchRequest() { }

        /// <summary>
        /// Instantiates DeleteMessageBatchRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue from which messages are deleted. Queue URLs and names are case-sensitive.</param>
        /// <param name="entries">Lists the receipt handles for the messages to be deleted.</param>
        public DeleteMessageBatchRequest(string queueUrl, List<DeleteMessageBatchRequestEntry> entries)
        {
            _queueUrl = queueUrl;
            _entries = entries;
        }

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// Lists the receipt handles for the messages to be deleted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DeleteMessageBatchRequestEntry> Entries
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
        /// The URL of the Amazon SQS queue from which messages are deleted.
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