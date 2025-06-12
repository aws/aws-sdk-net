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
    /// Container for the parameters to the TagQueue operation.
    /// Add cost allocation tags to the specified Amazon SQS queue. For an overview, see <a
    /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-tags.html">Tagging
    /// Your Amazon SQS Queues</a> in the <i>Amazon SQS Developer Guide</i>.
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
    ///  </li> </ul> 
    /// <para>
    /// For a full list of tag restrictions, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-limits.html#limits-queues">Quotas
    /// related to queues</a> in the <i>Amazon SQS Developer Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Cross-account permissions don't apply to this action. For more information, see <a
    /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
    /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
    /// Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class TagQueueRequest : AmazonSQSRequest
    {
        private string _queueUrl;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the queue.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags to be added to the specified queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}