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
    /// When included in a receipt rule, this action calls Amazon WorkMail and, optionally,
    /// publishes a notification to Amazon Simple Notification Service (Amazon SNS). It usually
    /// isn't necessary to set this up manually, because Amazon WorkMail adds the rule automatically
    /// during its setup procedure.
    /// 
    ///  
    /// <para>
    /// For information using a receipt rule to call Amazon WorkMail, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-action-workmail.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class WorkmailAction
    {
        private string _organizationArn;
        private string _topicArn;

        /// <summary>
        /// Gets and sets the property OrganizationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon WorkMail organization. Amazon WorkMail
        /// ARNs use the following format:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:workmail:&lt;region&gt;:&lt;awsAccountId&gt;:organization/&lt;workmailOrganizationId&gt;</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can find the ID of your organization by using the <a href="https://docs.aws.amazon.com/workmail/latest/APIReference/API_ListOrganizations.html">ListOrganizations</a>
        /// operation in Amazon WorkMail. Amazon WorkMail organization IDs begin with "<c>m-</c>",
        /// followed by a string of alphanumeric characters.
        /// </para>
        ///  
        /// <para>
        /// For information about Amazon WorkMail organizations, see the <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/organizations_overview.html">Amazon
        /// WorkMail Administrator Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OrganizationArn
        {
            get { return this._organizationArn; }
            set { this._organizationArn = value; }
        }

        // Check to see if OrganizationArn property is set
        internal bool IsSetOrganizationArn()
        {
            return this._organizationArn != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify when the WorkMail
        /// action is called. You can find the ARN of a topic by using the <a href="https://docs.aws.amazon.com/sns/latest/api/API_ListTopics.html">ListTopics</a>
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