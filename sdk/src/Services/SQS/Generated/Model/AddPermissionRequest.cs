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
    /// Container for the parameters to the AddPermission operation.
    /// Adds a permission to a queue for a specific <a href="https://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principal</a>.
    /// This allows sharing access to the queue.
    /// 
    ///  
    /// <para>
    /// When you create a queue, you have full control access rights for the queue. Only you,
    /// the owner of the queue, can grant or deny permissions to the queue. For more information
    /// about these permissions, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-writing-an-sqs-policy.html#write-messages-to-shared-queue">Allow
    /// Developers to Write Messages to a Shared Queue</a> in the <i>Amazon SQS Developer
    /// Guide</i>.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    ///  <c>AddPermission</c> generates a policy for you. You can use <c> <a>SetQueueAttributes</a>
    /// </c> to upload your policy. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-creating-custom-policies.html">Using
    /// Custom Policies with the Amazon SQS Access Policy Language</a> in the <i>Amazon SQS
    /// Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An Amazon SQS policy can have a maximum of seven actions per statement.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To remove the ability to change queue permissions, you must deny permission to the
    /// <c>AddPermission</c>, <c>RemovePermission</c>, and <c>SetQueueAttributes</c> actions
    /// in your IAM policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon SQS <c>AddPermission</c> does not support adding a non-account principal.
    /// </para>
    ///  </li> </ul> </note> <note> 
    /// <para>
    /// Cross-account permissions don't apply to this action. For more information, see <a
    /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
    /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
    /// Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AddPermissionRequest : AmazonSQSRequest
    {
        private List<string> _actions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _awsAccountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _label;
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AddPermissionRequest() { }

        /// <summary>
        /// Instantiates AddPermissionRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to which permissions are added. Queue URLs and names are case-sensitive.</param>
        /// <param name="label">The unique identification of the permission you're setting (for example, <c>AliceSendMessage</c>). Maximum 80 characters. Allowed characters include alphanumeric characters, hyphens (<c>-</c>), and underscores (<c>_</c>).</param>
        /// <param name="awsAccountIds">The Amazon Web Services account numbers of the <a href="https://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principals</a> who are to receive permission. For information about locating the Amazon Web Services account identification, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-making-api-requests.html#sqs-api-request-authentication">Your Amazon Web Services Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.</param>
        /// <param name="actions">The action the client wants to allow for the specified principal. Valid values: the name of any action or <c>*</c>. For more information about these actions, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-overview-of-managing-access.html">Overview of Managing Access Permissions to Your Amazon Simple Queue Service Resource</a> in the <i>Amazon SQS Developer Guide</i>. Specifying <c>SendMessage</c>, <c>DeleteMessage</c>, or <c>ChangeMessageVisibility</c> for <c>ActionName.n</c> also grants permissions for the corresponding batch versions of those actions: <c>SendMessageBatch</c>, <c>DeleteMessageBatch</c>, and <c>ChangeMessageVisibilityBatch</c>.</param>
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
        /// The action the client wants to allow for the specified principal. Valid values: the
        /// name of any action or <c>*</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about these actions, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-overview-of-managing-access.html">Overview
        /// of Managing Access Permissions to Your Amazon Simple Queue Service Resource</a> in
        /// the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Specifying <c>SendMessage</c>, <c>DeleteMessage</c>, or <c>ChangeMessageVisibility</c>
        /// for <c>ActionName.n</c> also grants permissions for the corresponding batch versions
        /// of those actions: <c>SendMessageBatch</c>, <c>DeleteMessageBatch</c>, and <c>ChangeMessageVisibilityBatch</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AWSAccountIds. 
        /// <para>
        /// The Amazon Web Services account numbers of the <a href="https://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principals</a>
        /// who are to receive permission. For information about locating the Amazon Web Services
        /// account identification, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-making-api-requests.html#sqs-api-request-authentication">Your
        /// Amazon Web Services Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AWSAccountIds
        {
            get { return this._awsAccountIds; }
            set { this._awsAccountIds = value; }
        }

        // Check to see if AWSAccountIds property is set
        internal bool IsSetAWSAccountIds()
        {
            return this._awsAccountIds != null && (this._awsAccountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The unique identification of the permission you're setting (for example, <c>AliceSendMessage</c>).
        /// Maximum 80 characters. Allowed characters include alphanumeric characters, hyphens
        /// (<c>-</c>), and underscores (<c>_</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The URL of the Amazon SQS queue to which permissions are added.
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