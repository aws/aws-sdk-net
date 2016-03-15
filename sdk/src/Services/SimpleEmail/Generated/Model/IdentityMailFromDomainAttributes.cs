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
    /// Represents the custom MAIL FROM domain attributes of a verified identity (email address
    /// or domain).
    /// </summary>
    public partial class IdentityMailFromDomainAttributes
    {
        private BehaviorOnMXFailure _behaviorOnMXFailure;
        private string _mailFromDomain;
        private CustomMailFromStatus _mailFromDomainStatus;

        /// <summary>
        /// Gets and sets the property BehaviorOnMXFailure. 
        /// <para>
        /// The action that Amazon SES takes if it cannot successfully read the required MX record
        /// when you send an email. A value of <code>UseDefaultValue</code> indicates that if
        /// Amazon SES cannot read the required MX record, it uses amazonses.com (or a subdomain
        /// of that) as the MAIL FROM domain. A value of <code>RejectMessage</code> indicates
        /// that if Amazon SES cannot read the required MX record, Amazon SES returns a <code>MailFromDomainNotVerified</code>
        /// error and does not send the email.
        /// </para>
        ///  
        /// <para>
        /// The custom MAIL FROM setup states that result in this behavior are <code>Pending</code>,
        /// <code>Failed</code>, and <code>TemporaryFailure</code>.
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
        /// Gets and sets the property MailFromDomain. 
        /// <para>
        /// The custom MAIL FROM domain that the identity is configured to use.
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

        /// <summary>
        /// Gets and sets the property MailFromDomainStatus. 
        /// <para>
        /// The state that indicates whether Amazon SES has successfully read the MX record required
        /// for custom MAIL FROM domain setup. If the state is <code>Success</code>, Amazon SES
        /// uses the specified custom MAIL FROM domain when the verified identity sends an email.
        /// All other states indicate that Amazon SES takes the action described by <code>BehaviorOnMXFailure</code>.
        /// </para>
        /// </summary>
        public CustomMailFromStatus MailFromDomainStatus
        {
            get { return this._mailFromDomainStatus; }
            set { this._mailFromDomainStatus = value; }
        }

        // Check to see if MailFromDomainStatus property is set
        internal bool IsSetMailFromDomainStatus()
        {
            return this._mailFromDomainStatus != null;
        }

    }
}