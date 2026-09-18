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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutEmailIdentityMailFromAttributes operation.
    /// Used to enable or disable the custom Mail-From domain configuration for an email identity.
    /// </summary>
    public partial class PutEmailIdentityMailFromAttributesRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property BehaviorOnMxFailure. 
        /// <para>
        /// The action to take if the required MX record isn't found when you send an email. When
        /// you set this value to <c>UseDefaultValue</c>, the mail is sent using <i>amazonses.com</i>
        /// as the MAIL FROM domain. When you set this value to <c>RejectMessage</c>, the Amazon
        /// SES API v2 returns a <c>MailFromDomainNotVerified</c> error, and doesn't attempt to
        /// deliver the email.
        /// </para>
        ///  
        /// <para>
        /// These behaviors are taken when the custom MAIL FROM domain configuration is in the
        /// <c>Pending</c>, <c>Failed</c>, and <c>TemporaryFailure</c> states.
        /// </para>
        /// </summary>
        public BehaviorOnMxFailure BehaviorOnMxFailure { get; set; }

        /// <summary>
        /// Checks to see if the BehaviorOnMxFailure property is set.
        /// </summary>
        internal bool IsSetBehaviorOnMxFailure() => this.BehaviorOnMxFailure != null;

        /// <summary>
        /// Gets and sets the property EmailIdentity. 
        /// <para>
        /// The verified email identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string EmailIdentity { get; set; }

        /// <summary>
        /// Checks to see if the EmailIdentity property is set.
        /// </summary>
        internal bool IsSetEmailIdentity() => this.EmailIdentity != null;

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
        public string MailFromDomain { get; set; }

        /// <summary>
        /// Checks to see if the MailFromDomain property is set.
        /// </summary>
        internal bool IsSetMailFromDomain() => this.MailFromDomain != null;
    }
}
