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
    /// Container for the parameters to the GetQueueUrl operation.
    /// The <c>GetQueueUrl</c> API returns the URL of an existing Amazon SQS queue. This is
    /// useful when you know the queue's name but need to retrieve its URL for further operations.
    /// 
    ///  
    /// <para>
    /// To access a queue owned by another Amazon Web Services account, use the <c>QueueOwnerAWSAccountId</c>
    /// parameter to specify the account ID of the queue's owner. Note that the queue owner
    /// must grant you the necessary permissions to access the queue. For more information
    /// about accessing shared queues, see the <c> <a>AddPermission</a> </c> API or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-writing-an-sqs-policy.html#write-messages-to-shared-queue">Allow
    /// developers to write messages to a shared queue</a> in the <i>Amazon SQS Developer
    /// Guide</i>. 
    /// </para>
    /// </summary>
    public partial class GetQueueUrlRequest : AmazonSQSRequest
    {
        private string _queueName;
        private string _queueOwnerAWSAccountId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetQueueUrlRequest() { }

        /// <summary>
        /// Instantiates GetQueueUrlRequest with the parameterized properties
        /// </summary>
        /// <param name="queueName">(Required) The name of the queue for which you want to fetch the URL. The name can be up to 80 characters long and can include alphanumeric characters, hyphens (-), and underscores (_). Queue URLs and names are case-sensitive.</param>
        public GetQueueUrlRequest(string queueName)
        {
            _queueName = queueName;
        }

        /// <summary>
        /// Gets and sets the property QueueName. 
        /// <para>
        /// (Required) The name of the queue for which you want to fetch the URL. The name can
        /// be up to 80 characters long and can include alphanumeric characters, hyphens (-),
        /// and underscores (_). Queue URLs and names are case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueName
        {
            get { return this._queueName; }
            set { this._queueName = value; }
        }

        // Check to see if QueueName property is set
        internal bool IsSetQueueName()
        {
            return this._queueName != null;
        }

        /// <summary>
        /// Gets and sets the property QueueOwnerAWSAccountId. 
        /// <para>
        /// (Optional) The Amazon Web Services account ID of the account that created the queue.
        /// This is only required when you are attempting to access a queue owned by another Amazon
        /// Web Services account.
        /// </para>
        /// </summary>
        public string QueueOwnerAWSAccountId
        {
            get { return this._queueOwnerAWSAccountId; }
            set { this._queueOwnerAWSAccountId = value; }
        }

        // Check to see if QueueOwnerAWSAccountId property is set
        internal bool IsSetQueueOwnerAWSAccountId()
        {
            return this._queueOwnerAWSAccountId != null;
        }

    }
}