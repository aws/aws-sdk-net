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
    /// Container for the parameters to the SetIdentityMailFromDomain operation.
    /// Enables or disables the custom MAIL FROM domain setup for a verified identity (email
    /// address or domain). 
    /// 
    ///  <important>To send emails using the specified MAIL FROM domain, you must add an MX
    /// record to your MAIL FROM domain's DNS settings. If you want your emails to pass Sender
    /// Policy Framework (SPF) checks, you must also add or update an SPF record. For more
    /// information, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from-set.html">Amazon
    /// SES Developer Guide</a>.</important> 
    /// <para>
    /// This action is throttled at one request per second.
    /// </para>
    /// </summary>
    public partial class SetIdentityMailFromDomainRequest : AmazonSimpleEmailServiceRequest
    {
        private BehaviorOnMXFailure _behaviorOnMXFailure;
        private string _identity;
        private string _mailFromDomain;

        /// <summary>
        /// Gets and sets the property BehaviorOnMXFailure. 
        /// <para>
        /// The action that you want Amazon SES to take if it cannot successfully read the required
        /// MX record when you send an email. If you choose <code>UseDefaultValue</code>, Amazon
        /// SES will use amazonses.com (or a subdomain of that) as the MAIL FROM domain. If you
        /// choose <code>RejectMessage</code>, Amazon SES will return a <code>MailFromDomainNotVerified</code>
        /// error and not send the email.
        /// </para>
        ///  
        /// <para>
        /// The action specified in <code>BehaviorOnMXFailure</code> is taken when the custom
        /// MAIL FROM domain setup is in the <code>Pending</code>, <code>Failed</code>, and <code>TemporaryFailure</code>
        /// states.
        /// </para>
        /// </summary>
        public BehaviorOnMXFailure BehaviorOnMXFailure
        {
            get { return this._behaviorOnMXFailure; }
            set { this._behaviorOnMXFailure = value; }
        }

        // Check to see if BehaviorOnMXFailure property is set
        internal bool IsSetBehaviorOnMXFailure()
        {
            return this._behaviorOnMXFailure != null;
        }

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// The verified identity for which you want to enable or disable the specified custom
        /// MAIL FROM domain.
        /// </para>
        /// </summary>
        public string Identity
        {
            get { return this._identity; }
            set { this._identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this._identity != null;
        }

        /// <summary>
        /// Gets and sets the property MailFromDomain. 
        /// <para>
        /// The custom MAIL FROM domain that you want the verified identity to use. The MAIL FROM
        /// domain must 1) be a subdomain of the verified identity, 2) not be used in a "From"
        /// address if the MAIL FROM domain is the destination of email feedback forwarding (for
        /// more information, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from.html">Amazon
        /// SES Developer Guide</a>), and 3) not be used to receive emails. A value of <code>null</code>
        /// disables the custom MAIL FROM setting for the identity.
        /// </para>
        /// </summary>
        public string MailFromDomain
        {
            get { return this._mailFromDomain; }
            set { this._mailFromDomain = value; }
        }

        // Check to see if MailFromDomain property is set
        internal bool IsSetMailFromDomain()
        {
            return this._mailFromDomain != null;
        }

    }
}