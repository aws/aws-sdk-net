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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
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
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the PublishBatch operation.
    /// Publishes up to 10 messages to the specified topic in a single batch. This is a batch
    /// version of the <c>Publish</c> API. If you try to send more than 10 messages in a single
    /// batch request, you will receive a <c>TooManyEntriesInBatchRequest</c> exception.
    /// 
    ///  
    /// <para>
    /// For FIFO topics, multiple messages within a single batch are published in the order
    /// they are sent, and messages are deduplicated within the batch and across batches for
    /// five minutes.
    /// </para>
    ///  
    /// <para>
    /// The result of publishing each message is reported individually in the response. Because
    /// the batch request can result in a combination of successful and unsuccessful actions,
    /// you should check for batch errors even when the call returns an HTTP status code of
    /// 200.
    /// </para>
    ///  
    /// <para>
    /// The maximum allowed individual message size and the maximum total payload size (the
    /// sum of the individual lengths of all of the batched messages) are both 256 KB (262,144
    /// bytes).
    /// </para>
    ///  <important> 
    /// <para>
    /// The <c>PublishBatch</c> API can send up to 10 messages at a time. If you attempt to
    /// send more than 10 messages in one request, you will encounter a <c>TooManyEntriesInBatchRequest</c>
    /// exception. In such cases, split your messages into multiple requests, each containing
    /// no more than 10 messages.
    /// </para>
    ///  </important> 
    /// <para>
    /// Some actions take lists of parameters. These lists are specified using the <c>param.n</c>
    /// notation. Values of <c>n</c> are integers starting from <b>1</b>. For example, a parameter
    /// list with two elements looks like this:
    /// </para>
    ///  
    /// <para>
    ///  <c>&amp;AttributeName.1=first</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>&amp;AttributeName.2=second</c> 
    /// </para>
    ///  
    /// <para>
    /// If you send a batch message to a topic, Amazon SNS publishes the batch message to
    /// each endpoint that is subscribed to the topic. The format of the batch message depends
    /// on the notification protocol for each subscribed endpoint.
    /// </para>
    ///  
    /// <para>
    /// When a <c>messageId</c> is returned, the batch message is saved, and Amazon SNS immediately
    /// delivers the message to subscribers.
    /// </para>
    /// </summary>
    public partial class PublishBatchRequest : AmazonSimpleNotificationServiceRequest
    {
        private List<PublishBatchRequestEntry> _publishBatchRequestEntries = AWSConfigs.InitializeCollections ? new List<PublishBatchRequestEntry>() : null;
        private string _topicArn;

        /// <summary>
        /// Gets and sets the property PublishBatchRequestEntries. 
        /// <para>
        /// A list of <c>PublishBatch</c> request entries to be sent to the SNS topic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PublishBatchRequestEntry> PublishBatchRequestEntries
        {
            get { return this._publishBatchRequestEntries; }
            set { this._publishBatchRequestEntries = value; }
        }

        // Check to see if PublishBatchRequestEntries property is set
        internal bool IsSetPublishBatchRequestEntries()
        {
            return this._publishBatchRequestEntries != null && (this._publishBatchRequestEntries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the topic you want to batch publish to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

    }
}