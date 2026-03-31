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
    /// The action to send a bounce response for the email. When executed, this action generates
    /// a non-delivery report (bounce) back to the sender.
    /// </summary>
    public partial class BounceAction
    {
        private ActionFailurePolicy _actionFailurePolicy;
        private string _diagnosticMessage;
        private string _message;
        private string _roleArn;
        private string _sender;
        private string _smtpReplyCode;
        private string _statusCode;

        /// <summary>
        /// Gets and sets the property ActionFailurePolicy. 
        /// <para>
        /// A policy that states what to do in the case of failure. The action will fail if there
        /// are configuration errors. For example, the caller does not have the permissions to
        /// call the SendBounce API.
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
        /// Gets and sets the property DiagnosticMessage. 
        /// <para>
        /// The diagnostic message included in the Diagnostic-Code header of the bounce.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
        public string DiagnosticMessage
        {
            get { return this._diagnosticMessage; }
            set { this._diagnosticMessage = value; }
        }

        // Check to see if DiagnosticMessage property is set
        internal bool IsSetDiagnosticMessage()
        {
            return this._diagnosticMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The human-readable text to include in the bounce message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=500)]
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to use to send the bounce message.
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

        /// <summary>
        /// Gets and sets the property Sender. 
        /// <para>
        /// The sender email address of the bounce message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=254)]
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
        /// The SMTP reply code for the bounce, as defined by RFC 5321.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=3)]
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
        /// The enhanced status code for the bounce, in the format of x.y.z (e.g. 5.1.1).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=9)]
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

    }
}