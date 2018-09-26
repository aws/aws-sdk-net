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
    /// Container for the parameters to the UntagQueue operation.
    /// Remove cost allocation tags from the specified Amazon SQS queue. For an overview,
    /// see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-tags.html">Tagging
    /// Your Amazon SQS Queues</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// When you use queue tags, keep the following guidelines in mind:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Adding more than 50 tags to a queue isn't recommended.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Tags don't have any semantic meaning. Amazon SQS interprets tags as character strings.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Tags are case-sensitive.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A new tag with a key identical to that of an existing tag overwrites the existing
    /// tag.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Tagging actions are limited to 5 TPS per AWS account. If your application requires
    /// a higher throughput, file a <a href="https://console.aws.amazon.com/support/home#/case/create?issueType=technical">technical
    /// support request</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For a full list of tag restrictions, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-limits.html#limits-queues">Limits
    /// Related to Queues</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Cross-account permissions don't apply to this action. For more information, see see
    /// <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
    /// Cross-Account Permissions to a Role and a User Name</a> in the <i>Amazon Simple Queue
    /// Service Developer Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UntagQueueRequest : AmazonSQSRequest
    {
        private string _queueUrl;
        private List<string> _tagKeys = new List<string>();

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the queue.
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

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// The list of tags to be removed from the specified queue.
        /// </para>
        /// </summary>
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && this._tagKeys.Count > 0; 
        }

    }
}