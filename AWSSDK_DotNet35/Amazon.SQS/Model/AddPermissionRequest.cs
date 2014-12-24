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
    /// Container for the parameters to the AddPermission operation.
    /// Adds a permission to a queue for a specific <a href="http://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principal</a>.
    /// This allows for sharing access to the queue.
    /// 
    ///  
    /// <para>
    /// When you create a queue, you have full control access rights for the queue. Only you
    /// (as owner of the queue) can grant or deny permissions to the queue. For more information
    /// about these permissions, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html">Shared
    /// Queues</a> in the <i>Amazon SQS Developer Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// <code>AddPermission</code> writes an Amazon SQS-generated policy. If you want to write
    /// your own policy, use <a>SetQueueAttributes</a> to upload your policy. For more information
    /// about writing your own policy, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AccessPolicyLanguage.html">Using
    /// The Access Policy Language</a> in the <i>Amazon SQS Developer Guide</i>.
    /// </para>
    ///  </note> <note>Some API actions take lists of parameters. These lists are specified
    /// using the <code>param.n</code> notation. Values of <code>n</code> are integers starting
    /// from 1. For example, a parameter list with two elements looks like this: </note> 
    /// <para>
    /// <code>&amp;Attribute.1=this</code>
    /// </para>
    ///  
    /// <para>
    /// <code>&amp;Attribute.2=that</code>
    /// </para>
    /// </summary>
    public partial class AddPermissionRequest : AmazonSQSRequest
    {
        private List<string> _actions = new List<string>();
        private List<string> _awsAccountIds = new List<string>();
        private string _label;
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AddPermissionRequest() { }

        /// <summary>
        /// Instantiates AddPermissionRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="label">The unique identification of the permission you're setting (e.g., <code>AliceSendMessage</code>). Constraints: Maximum 80 characters; alphanumeric characters, hyphens (-), and underscores (_) are allowed.</param>
        /// <param name="awsAccountIds">The AWS account number of the <a href="http://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principal</a> who will be given permission. The principal must have an AWS account, but does not need to be signed up for Amazon SQS. For information about locating the AWS account identification, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AWSCredentials.html">Your AWS Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.</param>
        /// <param name="actions">The action the client wants to allow for the specified principal. The following are valid values: <code>* | SendMessage | ReceiveMessage | DeleteMessage | ChangeMessageVisibility | GetQueueAttributes | GetQueueUrl</code>. For more information about these actions, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html#PermissionTypes">Understanding Permissions</a> in the <i>Amazon SQS Developer Guide</i>. Specifying <code>SendMessage</code>, <code>DeleteMessage</code>, or <code>ChangeMessageVisibility</code> for the <code>ActionName.n</code> also grants permissions for the corresponding batch versions of those actions: <code>SendMessageBatch</code>, <code>DeleteMessageBatch</code>, and <code>ChangeMessageVisibilityBatch</code>.</param>
        public AddPermissionRequest(string queueUrl, string label, List<string> awsAccountIds, List<string> actions)
        {
            _queueUrl = queueUrl;
            _label = label;
            _awsAccountIds = awsAccountIds;
            _actions = actions;
        }

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The action the client wants to allow for the specified principal. The following are
        /// valid values: <code>* | SendMessage | ReceiveMessage | DeleteMessage | ChangeMessageVisibility
        /// | GetQueueAttributes | GetQueueUrl</code>. For more information about these actions,
        /// see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html#PermissionTypes">Understanding
        /// Permissions</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Specifying <code>SendMessage</code>, <code>DeleteMessage</code>, or <code>ChangeMessageVisibility</code>
        /// for the <code>ActionName.n</code> also grants permissions for the corresponding batch
        /// versions of those actions: <code>SendMessageBatch</code>, <code>DeleteMessageBatch</code>,
        /// and <code>ChangeMessageVisibilityBatch</code>.
        /// </para>
        /// </summary>
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AWSAccountIds. 
        /// <para>
        /// The AWS account number of the <a href="http://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principal</a>
        /// who will be given permission. The principal must have an AWS account, but does not
        /// need to be signed up for Amazon SQS. For information about locating the AWS account
        /// identification, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AWSCredentials.html">Your
        /// AWS Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<string> AWSAccountIds
        {
            get { return this._awsAccountIds; }
            set { this._awsAccountIds = value; }
        }

        // Check to see if AWSAccountIds property is set
        internal bool IsSetAWSAccountIds()
        {
            return this._awsAccountIds != null && this._awsAccountIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The unique identification of the permission you're setting (e.g., <code>AliceSendMessage</code>).
        /// Constraints: Maximum 80 characters; alphanumeric characters, hyphens (-), and underscores
        /// (_) are allowed.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
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