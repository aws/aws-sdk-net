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
    /// When included in a receipt rule, this action calls an AWS Lambda function and, optionally,
    /// publishes a notification to Amazon Simple Notification Service (Amazon SNS).
    /// 
    ///  
    /// <para>
    /// To enable Amazon SES to call your AWS Lambda function or to publish to an Amazon SNS
    /// topic of another account, Amazon SES must have permission to access those resources.
    /// For information about giving permissions, see the <i> <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
    /// SES Developer Guide</a>.</i> 
    /// </para>
    ///  
    /// <para>
    /// For information about using AWS Lambda actions in receipt rules, see the <i> <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-action-lambda.html">Amazon
    /// SES Developer Guide</a>.</i> 
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
        /// The Amazon Resource Name (ARN) of the AWS Lambda function. An example of an AWS Lambda
        /// function ARN is <code>arn:aws:lambda:us-west-2:account-id:function:MyFunction</code>.
        /// For more information about AWS Lambda, see the <i> <a href="http://docs.aws.amazon.com/lambda/latest/dg/welcome.html">AWS
        /// Lambda Developer Guide</a>.</i> 
        /// </para>
        /// </summary>
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
        /// The invocation type of the AWS Lambda function. An invocation type of <code>RequestResponse</code>
        /// means that the execution of the function will immediately result in a response, and
        /// a value of <code>Event</code> means that the function will be invoked asynchronously.
        /// The default value is <code>Event</code>. For information about AWS Lambda invocation
        /// types, see the <i> <a href="http://docs.aws.amazon.com/lambda/latest/dg/API_Invoke.html">AWS
        /// Lambda Developer Guide</a>.</i> 
        /// </para>
        ///  <important> 
        /// <para>
        /// There is a 30-second timeout on <code>RequestResponse</code> invocations. You should
        /// use <code>Event</code> invocation in most cases. Use <code>RequestResponse</code>
        /// only when you want to make a mail flow decision, such as whether to stop the receipt
        /// rule or the receipt rule set.
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
        /// is taken. An example of an Amazon SNS topic ARN is <code>arn:aws:sns:us-west-2:123456789012:MyTopic</code>.
        /// For more information about Amazon SNS topics, see the <i> <a href="http://docs.aws.amazon.com/sns/latest/dg/CreateTopic.html">Amazon
        /// SNS Developer Guide</a>.</i> 
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