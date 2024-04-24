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
    /// When included in a receipt rule, this action calls an Amazon Web Services Lambda function
    /// and, optionally, publishes a notification to Amazon Simple Notification Service (Amazon
    /// SNS).
    /// 
    ///  
    /// <para>
    /// To enable Amazon SES to call your Amazon Web Services Lambda function or to publish
    /// to an Amazon SNS topic of another account, Amazon SES must have permission to access
    /// those resources. For information about giving permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-permissions.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about using Amazon Web Services Lambda actions in receipt rules, see
    /// the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-action-lambda.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class LambdaAction
    {
        private string _functionArn;
        private InvocationType _invocationType;
        private string _topicArn;

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Lambda function. An example
        /// of an Amazon Web Services Lambda function ARN is <c>arn:aws:lambda:us-west-2:account-id:function:MyFunction</c>.
        /// For more information about Amazon Web Services Lambda, see the <a href="https://docs.aws.amazon.com/lambda/latest/dg/welcome.html">Amazon
        /// Web Services Lambda Developer Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FunctionArn
        {
            get { return this._functionArn; }
            set { this._functionArn = value; }
        }

        // Check to see if FunctionArn property is set
        internal bool IsSetFunctionArn()
        {
            return this._functionArn != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationType. 
        /// <para>
        /// The invocation type of the Amazon Web Services Lambda function. An invocation type
        /// of <c>RequestResponse</c> means that the execution of the function immediately results
        /// in a response, and a value of <c>Event</c> means that the function is invoked asynchronously.
        /// The default value is <c>Event</c>. For information about Amazon Web Services Lambda
        /// invocation types, see the <a href="https://docs.aws.amazon.com/lambda/latest/dg/API_Invoke.html">Amazon
        /// Web Services Lambda Developer Guide</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// There is a 30-second timeout on <c>RequestResponse</c> invocations. You should use
        /// <c>Event</c> invocation in most cases. Use <c>RequestResponse</c> only to make a mail
        /// flow decision, such as whether to stop the receipt rule or the receipt rule set.
        /// </para>
        ///  </important>
        /// </summary>
        public InvocationType InvocationType
        {
            get { return this._invocationType; }
            set { this._invocationType = value; }
        }

        // Check to see if InvocationType property is set
        internal bool IsSetInvocationType()
        {
            return this._invocationType != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify when the Lambda action
        /// is executed. You can find the ARN of a topic by using the <a href="https://docs.aws.amazon.com/sns/latest/api/API_ListTopics.html">ListTopics</a>
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