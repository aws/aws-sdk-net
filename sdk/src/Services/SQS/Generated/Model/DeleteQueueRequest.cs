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
    /// Container for the parameters to the DeleteQueue operation.
    /// Deletes the queue specified by the <c>QueueUrl</c>, regardless of the queue's contents.
    /// 
    ///  <important> 
    /// <para>
    /// Be careful with the <c>DeleteQueue</c> action: When you delete a queue, any messages
    /// in the queue are no longer available. 
    /// </para>
    ///  </important> 
    /// <para>
    /// When you delete a queue, the deletion process takes up to 60 seconds. Requests you
    /// send involving that queue during the 60 seconds might succeed. For example, a <c>
    /// <a>SendMessage</a> </c> request might succeed, but after 60 seconds the queue and
    /// the message you sent no longer exist.
    /// </para>
    ///  
    /// <para>
    /// When you delete a queue, you must wait at least 60 seconds before creating a queue
    /// with the same name.
    /// </para>
    ///  <note> 
    /// <para>
    /// Cross-account permissions don't apply to this action. For more information, see <a
    /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
    /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The delete operation uses the HTTP <c>GET</c> verb.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteQueueRequest : AmazonSQSRequest
    {
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteQueueRequest() { }

        /// <summary>
        /// Instantiates DeleteQueueRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to delete. Queue URLs and names are case-sensitive.</param>
        public DeleteQueueRequest(string queueUrl)
        {
            _queueUrl = queueUrl;
        }

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the Amazon SQS queue to delete.
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