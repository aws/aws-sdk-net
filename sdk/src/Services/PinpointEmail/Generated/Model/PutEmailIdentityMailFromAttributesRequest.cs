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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the PutEmailIdentityMailFromAttributes operation.
    /// Used to enable or disable the custom Mail-From domain configuration for an email identity.
    /// </summary>
    public partial class PutEmailIdentityMailFromAttributesRequest : AmazonPinpointEmailRequest
    {
        private BehaviorOnMxFailure _behaviorOnMxFailure;
        private string _emailIdentity;
        private string _mailFromDomain;

        /// <summary>
        /// Gets and sets the property BehaviorOnMxFailure. 
        /// <para>
        /// The action that you want Amazon Pinpoint to take if it can't read the required MX
        /// record when you send an email. When you set this value to <code>UseDefaultValue</code>,
        /// Amazon Pinpoint uses <i>amazonses.com</i> as the MAIL FROM domain. When you set this
        /// value to <code>RejectMessage</code>, Amazon Pinpoint returns a <code>MailFromDomainNotVerified</code>
        /// error, and doesn't attempt to deliver the email.
        /// </para>
        ///  
        /// <para>
        /// These behaviors are taken when the custom MAIL FROM domain configuration is in the
        /// <code>Pending</code>, <code>Failed</code>, and <code>TemporaryFailure</code> states.
        /// </para>
        /// </summary>
        public BehaviorOnMxFailure BehaviorOnMxFailure
        {
            get { return this._behaviorOnMxFailure; }
            set { this._behaviorOnMxFailure = value; }
        }

        // Check to see if BehaviorOnMxFailure property is set
        internal bool IsSetBehaviorOnMxFailure()
        {
            return this._behaviorOnMxFailure != null;
        }

        /// <summary>
        /// Gets and sets the property EmailIdentity. 
        /// <para>
        /// The verified email identity that you want to set up the custom MAIL FROM domain for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EmailIdentity
        {
            get { return this._emailIdentity; }
            set { this._emailIdentity = value; }
        }

        // Check to see if EmailIdentity property is set
        internal bool IsSetEmailIdentity()
        {
            return this._emailIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property MailFromDomain. 
        /// <para>
        ///  The custom MAIL FROM domain that you want the verified identity to use. The MAIL
        /// FROM domain must meet the following criteria:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It has to be a subdomain of the verified identity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It can't be used to receive email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It can't be used in a "From" address if the MAIL FROM domain is a destination for
        /// feedback forwarding emails.
        /// </para>
        ///  </li> </ul>
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