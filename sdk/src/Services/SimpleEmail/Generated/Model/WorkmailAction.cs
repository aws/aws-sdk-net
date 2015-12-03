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
    /// When included in a receipt rule, this action calls Amazon WorkMail and, optionally,
    /// publishes a notification to Amazon Simple Notification Service (Amazon SNS). You will
    /// typically not use this action directly because Amazon WorkMail adds the rule automatically
    /// during its setup procedure.
    /// 
    ///  
    /// <para>
    /// For information using a receipt rule to call Amazon WorkMail, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-action-workmail.html">Amazon
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
        /// The ARN of the Amazon WorkMail organization. An example of an Amazon WorkMail organization
        /// ARN is <code>arn:aws:workmail:us-west-2:123456789012:organization/m-68755160c4cb4e29a2b2f8fb58f359d7</code>.
        /// For information about Amazon WorkMail organizations, see the <a href="http://docs.aws.amazon.com/workmail/latest/adminguide/organizations_overview.html">Amazon
        /// WorkMail Administrator Guide</a>.
        /// </para>
        /// </summary>
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
        /// action is called. An example of an Amazon SNS topic ARN is <code>arn:aws:sns:us-west-2:123456789012:MyTopic</code>.
        /// For more information about Amazon SNS topics, see the <a href="http://docs.aws.amazon.com/sns/latest/dg/CreateTopic.html">Amazon
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