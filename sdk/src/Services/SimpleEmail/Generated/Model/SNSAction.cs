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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
    /// it. For information about giving permissions, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  <important>You can only publish emails that are 150 KB or less (including the header)
    /// to Amazon SNS. Larger emails will bounce. If you anticipate emails larger than 150
    /// KB, use the S3 action instead.</important> 
    /// <para>
    /// For information about using a receipt rule to publish an Amazon SNS notification,
    /// see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-action-sns.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class SNSAction
    {
        private string _topicArn;

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify. An example of an
        /// Amazon SNS topic ARN is <code>arn:aws:sns:us-west-2:123456789012:MyTopic</code>. For
        /// more information about Amazon SNS topics, see the <a href="http://docs.aws.amazon.com/sns/latest/dg/CreateTopic.html">Amazon
        /// SNS Developer Guide</a>.
        /// </para>
        /// </summary>
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