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
    /// Container for the parameters to the UpdateCustomVerificationEmailTemplate operation.
    /// Updates an existing custom verification email template.
    /// 
    ///  
    /// <para>
    /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
    /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class UpdateCustomVerificationEmailTemplateRequest : AmazonSimpleEmailServiceRequest
    {
        private string _failureRedirectionURL;
        private string _fromEmailAddress;
        private string _successRedirectionURL;
        private string _templateContent;
        private string _templateName;
        private string _templateSubject;

        /// <summary>
        /// Gets and sets the property FailureRedirectionURL. 
        /// <para>
        /// The URL that the recipient of the verification email is sent to if his or her address
        /// is not successfully verified.
        /// </para>
        /// </summary>
        public string FailureRedirectionURL
        {
            get { return this._failureRedirectionURL; }
            set { this._failureRedirectionURL = value; }
        }

        // Check to see if FailureRedirectionURL property is set
        internal bool IsSetFailureRedirectionURL()
        {
            return this._failureRedirectionURL != null;
        }

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The email address that the custom verification email is sent from.
        /// </para>
        /// </summary>
        public string FromEmailAddress
        {
            get { return this._fromEmailAddress; }
            set { this._fromEmailAddress = value; }
        }

        // Check to see if FromEmailAddress property is set
        internal bool IsSetFromEmailAddress()
        {
            return this._fromEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessRedirectionURL. 
        /// <para>
        /// The URL that the recipient of the verification email is sent to if his or her address
        /// is successfully verified.
        /// </para>
        /// </summary>
        public string SuccessRedirectionURL
        {
            get { return this._successRedirectionURL; }
            set { this._successRedirectionURL = value; }
        }

        // Check to see if SuccessRedirectionURL property is set
        internal bool IsSetSuccessRedirectionURL()
        {
            return this._successRedirectionURL != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateContent. 
        /// <para>
        /// The content of the custom verification email. The total size of the email must be
        /// less than 10 MB. The message body may contain HTML, with some limitations. For more
        /// information, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Custom
        /// Verification Email Frequently Asked Questions</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        /// </summary>
        public string TemplateContent
        {
            get { return this._templateContent; }
            set { this._templateContent = value; }
        }

        // Check to see if TemplateContent property is set
        internal bool IsSetTemplateContent()
        {
            return this._templateContent != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the custom verification email template to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateSubject. 
        /// <para>
        /// The subject line of the custom verification email.
        /// </para>
        /// </summary>
        public string TemplateSubject
        {
            get { return this._templateSubject; }
            set { this._templateSubject = value; }
        }

        // Check to see if TemplateSubject property is set
        internal bool IsSetTemplateSubject()
        {
            return this._templateSubject != null;
        }

    }
}