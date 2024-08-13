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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
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
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDomainContactPrivacy operation.
    /// This operation updates the specified domain contact's privacy setting. When privacy
    /// protection is enabled, your contact information is replaced with contact information
    /// for the registrar or with the phrase "REDACTED FOR PRIVACY", or "On behalf of &lt;domain
    /// name&gt; owner."
    /// 
    ///  <note> 
    /// <para>
    /// While some domains may allow different privacy settings per contact, we recommend
    /// specifying the same privacy setting for all contacts.
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation affects only the contact information for the specified contact type
    /// (administrative, registrant, or technical). If the request succeeds, Amazon Route
    /// 53 returns an operation ID that you can use with <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
    /// to track the progress and completion of the action. If the request doesn't complete
    /// successfully, the domain registrant will be notified by email.
    /// </para>
    ///  <important> 
    /// <para>
    /// By disabling the privacy service via API, you consent to the publication of the contact
    /// information provided for this domain via the public WHOIS database. You certify that
    /// you are the registrant of this domain name and have the authority to make this decision.
    /// You may withdraw your consent at any time by enabling privacy protection using either
    /// <c>UpdateDomainContactPrivacy</c> or the Route 53 console. Enabling privacy protection
    /// removes the contact information provided for this domain from the WHOIS database.
    /// For more information on our privacy practices, see <a href="https://aws.amazon.com/privacy/">https://aws.amazon.com/privacy/</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateDomainContactPrivacyRequest : AmazonRoute53DomainsRequest
    {
        private bool? _adminPrivacy;
        private bool? _billingPrivacy;
        private string _domainName;
        private bool? _registrantPrivacy;
        private bool? _techPrivacy;

        /// <summary>
        /// Gets and sets the property AdminPrivacy. 
        /// <para>
        /// Whether you want to conceal contact information from WHOIS queries. If you specify
        /// <c>true</c>, WHOIS ("who is") queries return contact information either for Amazon
        /// Registrar or for our registrar associate, Gandi. If you specify <c>false</c>, WHOIS
        /// queries return the information that you entered for the admin contact.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, billing, registrant,
        /// and technical contacts.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? AdminPrivacy
        {
            get { return this._adminPrivacy; }
            set { this._adminPrivacy = value; }
        }

        // Check to see if AdminPrivacy property is set
        internal bool IsSetAdminPrivacy()
        {
            return this._adminPrivacy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BillingPrivacy. 
        /// <para>
        ///  Whether you want to conceal contact information from WHOIS queries. If you specify
        /// <c>true</c>, WHOIS ("who is") queries return contact information either for Amazon
        /// Registrar or for our registrar associate, Gandi. If you specify <c>false</c>, WHOIS
        /// queries return the information that you entered for the billing contact. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, billing, registrant,
        /// and technical contacts.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? BillingPrivacy
        {
            get { return this._billingPrivacy; }
            set { this._billingPrivacy = value; }
        }

        // Check to see if BillingPrivacy property is set
        internal bool IsSetBillingPrivacy()
        {
            return this._billingPrivacy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that you want to update the privacy setting for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrantPrivacy. 
        /// <para>
        /// Whether you want to conceal contact information from WHOIS queries. If you specify
        /// <c>true</c>, WHOIS ("who is") queries return contact information either for Amazon
        /// Registrar or for our registrar associate, Gandi. If you specify <c>false</c>, WHOIS
        /// queries return the information that you entered for the registrant contact (domain
        /// owner).
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, billing, registrant,
        /// and technical contacts.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? RegistrantPrivacy
        {
            get { return this._registrantPrivacy; }
            set { this._registrantPrivacy = value; }
        }

        // Check to see if RegistrantPrivacy property is set
        internal bool IsSetRegistrantPrivacy()
        {
            return this._registrantPrivacy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TechPrivacy. 
        /// <para>
        /// Whether you want to conceal contact information from WHOIS queries. If you specify
        /// <c>true</c>, WHOIS ("who is") queries return contact information either for Amazon
        /// Registrar or for our registrar associate, Gandi. If you specify <c>false</c>, WHOIS
        /// queries return the information that you entered for the technical contact.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, billing, registrant,
        /// and technical contacts.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? TechPrivacy
        {
            get { return this._techPrivacy; }
            set { this._techPrivacy = value; }
        }

        // Check to see if TechPrivacy property is set
        internal bool IsSetTechPrivacy()
        {
            return this._techPrivacy.HasValue; 
        }

    }
}