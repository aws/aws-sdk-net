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
    /// Container for the parameters to the SendCustomVerificationEmail operation.
    /// Adds an email address to the list of identities for your Amazon SES account in the
    /// current AWS Region and attempts to verify it. As a result of executing this operation,
    /// a customized verification email is sent to the specified address.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must first create a custom verification email template.
    /// For more information about creating and using custom verification email templates,
    /// see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/custom-verification-emails.html">Using
    /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class SendCustomVerificationEmailRequest : AmazonSimpleEmailServiceRequest
    {
        private string _configurationSetName;
        private string _emailAddress;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// Name of a configuration set to use when sending the verification email.
        /// </para>
        /// </summary>
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address to verify.
        /// </para>
        /// </summary>
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the custom verification email template to use when sending the verification
        /// email.
        /// </para>
        /// </summary>
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

    }
}