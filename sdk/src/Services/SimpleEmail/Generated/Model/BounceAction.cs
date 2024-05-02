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
    /// When included in a receipt rule, this action rejects the received email by returning
    /// a bounce response to the sender and, optionally, publishes a notification to Amazon
    /// Simple Notification Service (Amazon SNS).
    /// 
    ///  
    /// <para>
    /// For information about sending a bounce message in response to a received email, see
    /// the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-action-bounce.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class BounceAction
    {
        private string _message;
        private string _sender;
        private string _smtpReplyCode;
        private string _statusCode;
        private string _topicArn;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Human-readable text to include in the bounce message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Sender. 
        /// <para>
        /// The email address of the sender of the bounced email. This is the address from which
        /// the bounce message is sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Sender
        {
            get { return this._sender; }
            set { this._sender = value; }
        }

        // Check to see if Sender property is set
        internal bool IsSetSender()
        {
            return this._sender != null;
        }

        /// <summary>
        /// Gets and sets the property SmtpReplyCode. 
        /// <para>
        /// The SMTP reply code, as defined by <a href="https://tools.ietf.org/html/rfc5321">RFC
        /// 5321</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SmtpReplyCode
        {
            get { return this._smtpReplyCode; }
            set { this._smtpReplyCode = value; }
        }

        // Check to see if SmtpReplyCode property is set
        internal bool IsSetSmtpReplyCode()
        {
            return this._smtpReplyCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The SMTP enhanced status code, as defined by <a href="https://tools.ietf.org/html/rfc3463">RFC
        /// 3463</a>.
        /// </para>
        /// </summary>
        public string StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify when the bounce action
        /// is taken. You can find the ARN of a topic by using the <a href="https://docs.aws.amazon.com/sns/latest/api/API_ListTopics.html">ListTopics</a>
        /// operation in Amazon SNS.
        /// </para>
        ///  
        /// <para>
        /// For more information about Amazon SNS topics, see the <a href="https://docs.aws.amazon.com/sns/latest/dg/CreateTopic.html">Amazon
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