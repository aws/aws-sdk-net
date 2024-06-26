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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// This action to delivers an email to a mailbox.
    /// </summary>
    public partial class DeliverToMailboxAction
    {
        private ActionFailurePolicy _actionFailurePolicy;
        private string _mailboxArn;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ActionFailurePolicy. 
        /// <para>
        /// A policy that states what to do in the case of failure. The action will fail if there
        /// are configuration errors. For example, the mailbox ARN is no longer valid.
        /// </para>
        /// </summary>
        public ActionFailurePolicy ActionFailurePolicy
        {
            get { return this._actionFailurePolicy; }
            set { this._actionFailurePolicy = value; }
        }

        // Check to see if ActionFailurePolicy property is set
        internal bool IsSetActionFailurePolicy()
        {
            return this._actionFailurePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property MailboxArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a WorkMail organization to deliver the email to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string MailboxArn
        {
            get { return this._mailboxArn; }
            set { this._mailboxArn = value; }
        }

        // Check to see if MailboxArn property is set
        internal bool IsSetMailboxArn()
        {
            return this._mailboxArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role to use to execute this action. The role
        /// must have access to the workmail:DeliverToMailbox API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}