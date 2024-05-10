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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// When included in a receipt rule, this action publishes a notification to Amazon Simple
    /// Notification Service (Amazon SNS). This action includes a complete copy of the email
    /// content in the Amazon SNS notifications. Amazon SNS notifications for all other actions
    /// simply provide information about the email. They do not include the email content
    /// itself.
    /// 
    ///  
    /// <para>
    /// If you own the Amazon SNS topic, you don't need to do anything to give Amazon SES
    /// permission to publish emails to it. However, if you don't own the Amazon SNS topic,
    /// you need to attach a policy to the topic to give Amazon SES permissions to access
    /// it. For information about giving permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-permissions.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// You can only publish emails that are 150 KB or less (including the header) to Amazon
    /// SNS. Larger emails bounce. If you anticipate emails larger than 150 KB, use the S3
    /// action instead.
    /// </para>
    ///  </important> 
    /// <para>
    /// For information about using a receipt rule to publish an Amazon SNS notification,
    /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-action-sns.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class SNSAction
    {
        private SNSActionEncoding _encoding;
        private string _topicArn;

        /// <summary>
        /// Gets and sets the property Encoding. 
        /// <para>
        /// The encoding to use for the email within the Amazon SNS notification. UTF-8 is easier
        /// to use, but may not preserve all special characters when a message was encoded with
        /// a different encoding format. Base64 preserves all special characters. The default
        /// value is UTF-8.
        /// </para>
        /// </summary>
        public SNSActionEncoding Encoding
        {
            get { return this._encoding; }
            set { this._encoding = value; }
        }

        // Check to see if Encoding property is set
        internal bool IsSetEncoding()
        {
            return this._encoding != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify. You can find the
        /// ARN of a topic by using the <a href="https://docs.aws.amazon.com/sns/latest/api/API_ListTopics.html">ListTopics</a>
        /// operation in Amazon SNS.
        /// </para>
        ///  
        /// <para>
        /// For more information about Amazon SNS topics, see the <a href="https://docs.aws.amazon.com/sns/latest/dg/CreateTopic.html">Amazon
        /// SNS Developer Guide</a>.
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