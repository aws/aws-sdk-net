/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the AddPermission operation.
    /// <para>Adds a permission to a queue for a specific <a href="http://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P" >principal</a> .
    /// This allows for sharing access to the queue.</para> <para>When you create a queue, you have full control access rights for the queue.
    /// Only you (as owner of the queue) can grant or deny permissions to the queue. For more information about these permissions, see <a
    /// href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html" >Shared Queues</a> in the <i>Amazon SQS
    /// Developer Guide</i> .</para> <para><b>NOTE:</b> AddPermission writes an Amazon SQS-generated policy. If you want to write your own policy,
    /// use SetQueueAttributes to upload your policy. For more information about writing your own policy, see Using The Access Policy Language in
    /// the Amazon SQS Developer Guide. </para> <para><b>NOTE:</b>Some API actions take lists of parameters. These lists are specified using the
    /// param.n notation. Values of n are integers starting from 1. For example, a parameter list with two elements looks like this: </para> <para>
    /// <c>&amp;amp;Attribute.1=this</c> </para> <para> <c>&amp;amp;Attribute.2=that</c> </para>
    /// </summary>
    public partial class AddPermissionRequest : AmazonSQSRequest
    {
        private string queueUrl;
        private string label;
        private List<string> aWSAccountIds = new List<string>();
        private List<string> actions = new List<string>();


        /// <summary>
        /// The URL of the Amazon SQS queue to take action on.
        ///  
        /// </summary>
        public string QueueUrl
        {
            get { return this.queueUrl; }
            set { this.queueUrl = value; }
        }

        // Check to see if QueueUrl property is set
        internal bool IsSetQueueUrl()
        {
            return this.queueUrl != null;
        }

        /// <summary>
        /// The unique identification of the permission you're setting (e.g., <c>AliceSendMessage</c>). Constraints: Maximum 80 characters; alphanumeric
        /// characters, hyphens (-), and underscores (_) are allowed.
        ///  
        /// </summary>
        public string Label
        {
            get { return this.label; }
            set { this.label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this.label != null;
        }

        /// <summary>
        /// The AWS account number of the <a href="http://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principal</a> who will be given
        /// permission. The principal must have an AWS account, but does not need to be signed up for Amazon SQS. For information about locating the AWS
        /// account identification, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AWSCredentials.html">Your AWS
        /// Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.
        ///  
        /// </summary>
        public List<string> AWSAccountIds
        {
            get { return this.aWSAccountIds; }
            set { this.aWSAccountIds = value; }
        }

        // Check to see if AWSAccountIds property is set
        internal bool IsSetAWSAccountIds()
        {
            return this.aWSAccountIds.Count > 0;
        }

        /// <summary>
        /// The action the client wants to allow for the specified principal. The following are valid values: <c>* | SendMessage | ReceiveMessage |
        /// DeleteMessage | ChangeMessageVisibility | GetQueueAttributes | GetQueueUrl</c>. For more information about these actions, see <a
        /// href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html#PermissionTypes">Understanding
        /// Permissions</a> in the <i>Amazon SQS Developer Guide</i>. Specifying <c>SendMessage</c>, <c>DeleteMessage</c>, or
        /// <c>ChangeMessageVisibility</c> for the <c>ActionName.n</c> also grants permissions for the corresponding batch versions of those actions:
        /// <c>SendMessageBatch</c>, <c>DeleteMessageBatch</c>, and <c>ChangeMessageVisibilityBatch</c>.
        ///  
        /// </summary>
        public List<string> Actions
        {
            get { return this.actions; }
            set { this.actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this.actions.Count > 0;
        }

    }
}
    
