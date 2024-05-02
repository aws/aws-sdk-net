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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
    /// A list of attributes that are associated with a MAIL FROM domain.
    /// </summary>
    public partial class MailFromAttributes
    {
        private BehaviorOnMxFailure _behaviorOnMxFailure;
        private string _mailFromDomain;
        private MailFromDomainStatus _mailFromDomainStatus;

        /// <summary>
        /// Gets and sets the property BehaviorOnMxFailure. 
        /// <para>
        /// The action to take if the required MX record can't be found when you send an email.
        /// When you set this value to <c>USE_DEFAULT_VALUE</c>, the mail is sent using <i>amazonses.com</i>
        /// as the MAIL FROM domain. When you set this value to <c>REJECT_MESSAGE</c>, the Amazon
        /// SES API v2 returns a <c>MailFromDomainNotVerified</c> error, and doesn't attempt to
        /// deliver the email.
        /// </para>
        ///  
        /// <para>
        /// These behaviors are taken when the custom MAIL FROM domain configuration is in the
        /// <c>Pending</c>, <c>Failed</c>, and <c>TemporaryFailure</c> states.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MailFromDomain. 
        /// <para>
        /// The name of a domain that an email identity uses as a custom MAIL FROM domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The status of the MAIL FROM domain. This status can have the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> – Amazon SES hasn't started searching for the MX record yet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> – Amazon SES detected the required MX record for the MAIL FROM domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – Amazon SES can't find the required MX record, or the record no longer
        /// exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TEMPORARY_FAILURE</c> – A temporary issue occurred, which prevented Amazon SES
        /// from determining the status of the MAIL FROM domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public MailFromDomainStatus MailFromDomainStatus
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