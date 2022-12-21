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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterDomain operation.
    /// This operation registers a domain. Domains are registered either by Amazon Registrar
    /// (for .com, .net, and .org domains) or by our registrar associate, Gandi (for all other
    /// domains). For some top-level domains (TLDs), this operation requires extra parameters.
    /// 
    ///  
    /// <para>
    /// When you register a domain, Amazon Route 53 does the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Creates a Route 53 hosted zone that has the same name as the domain. Route 53 assigns
    /// four name servers to your hosted zone and automatically updates your domain registration
    /// with the names of these name servers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Enables auto renew, so your domain registration will renew automatically each year.
    /// We'll notify you in advance of the renewal date so you can choose whether to renew
    /// the registration.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Optionally enables privacy protection, so WHOIS queries return contact information
    /// either for Amazon Registrar (for .com, .net, and .org domains) or for our registrar
    /// associate, Gandi (for all other TLDs). If you don't enable privacy protection, WHOIS
    /// queries return the information that you entered for the administrative, registrant,
    /// and technical contacts.
    /// </para>
    ///  <note> 
    /// <para>
    /// You must specify the same privacy setting for the administrative, registrant, and
    /// technical contacts.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// If registration is successful, returns an operation ID that you can use to track the
    /// progress and completion of the action. If the request is not completed successfully,
    /// the domain registrant is notified by email.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Charges your Amazon Web Services account an amount based on the top-level domain.
    /// For more information, see <a href="http://aws.amazon.com/route53/pricing/">Amazon
    /// Route 53 Pricing</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RegisterDomainRequest : AmazonRoute53DomainsRequest
    {
        private ContactDetail _adminContact;
        private bool? _autoRenew;
        private string _domainName;
        private int? _durationInYears;
        private string _idnLangCode;
        private bool? _privacyProtectAdminContact;
        private bool? _privacyProtectRegistrantContact;
        private bool? _privacyProtectTechContact;
        private ContactDetail _registrantContact;
        private ContactDetail _techContact;

        /// <summary>
        /// Gets and sets the property AdminContact. 
        /// <para>
        /// Provides detailed contact information. For information about the values that you specify
        /// for each element, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ContactDetail.html">ContactDetail</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContactDetail AdminContact
        {
            get { return this._adminContact; }
            set { this._adminContact = value; }
        }

        // Check to see if AdminContact property is set
        internal bool IsSetAdminContact()
        {
            return this._adminContact != null;
        }

        /// <summary>
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// Indicates whether the domain will be automatically renewed (<code>true</code>) or
        /// not (<code>false</code>). Auto renewal only takes effect after the account is charged.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>true</code> 
        /// </para>
        /// </summary>
        public bool AutoRenew
        {
            get { return this._autoRenew.GetValueOrDefault(); }
            set { this._autoRenew = value; }
        }

        // Check to see if AutoRenew property is set
        internal bool IsSetAutoRenew()
        {
            return this._autoRenew.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name that you want to register. The top-level domain (TLD), such as .com,
        /// must be a TLD that Route 53 supports. For a list of supported TLDs, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/registrar-tld-list.html">Domains
        /// that You Can Register with Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The domain name can contain only the following characters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Letters a through z. Domain names are not case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Numbers 0 through 9.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Hyphen (-). You can't specify a hyphen at the beginning or end of a label. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Period (.) to separate the labels in the name, such as the <code>.</code> in <code>example.com</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Internationalized domain names are not supported for some top-level domains. To determine
        /// whether the TLD that you want to use supports internationalized domain names, see
        /// <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/registrar-tld-list.html">Domains
        /// that You Can Register with Amazon Route 53</a>. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DomainNameFormat.html#domain-name-format-idns">Formatting
        /// Internationalized Domain Names</a>. 
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
        /// Gets and sets the property DurationInYears. 
        /// <para>
        /// The number of years that you want to register the domain for. Domains are registered
        /// for a minimum of one year. The maximum period depends on the top-level domain. For
        /// the range of valid values for your domain, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/registrar-tld-list.html">Domains
        /// that You Can Register with Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public int DurationInYears
        {
            get { return this._durationInYears.GetValueOrDefault(); }
            set { this._durationInYears = value; }
        }

        // Check to see if DurationInYears property is set
        internal bool IsSetDurationInYears()
        {
            return this._durationInYears.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdnLangCode. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        [AWSProperty(Max=3)]
        public string IdnLangCode
        {
            get { return this._idnLangCode; }
            set { this._idnLangCode = value; }
        }

        // Check to see if IdnLangCode property is set
        internal bool IsSetIdnLangCode()
        {
            return this._idnLangCode != null;
        }

        /// <summary>
        /// Gets and sets the property PrivacyProtectAdminContact. 
        /// <para>
        /// Whether you want to conceal contact information from WHOIS queries. If you specify
        /// <code>true</code>, WHOIS ("who is") queries return contact information either for
        /// Amazon Registrar (for .com, .net, and .org domains) or for our registrar associate,
        /// Gandi (for all other TLDs). If you specify <code>false</code>, WHOIS queries return
        /// the information that you entered for the admin contact.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, registrant, and
        /// technical contacts.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <code>true</code> 
        /// </para>
        /// </summary>
        public bool PrivacyProtectAdminContact
        {
            get { return this._privacyProtectAdminContact.GetValueOrDefault(); }
            set { this._privacyProtectAdminContact = value; }
        }

        // Check to see if PrivacyProtectAdminContact property is set
        internal bool IsSetPrivacyProtectAdminContact()
        {
            return this._privacyProtectAdminContact.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivacyProtectRegistrantContact. 
        /// <para>
        /// Whether you want to conceal contact information from WHOIS queries. If you specify
        /// <code>true</code>, WHOIS ("who is") queries return contact information either for
        /// Amazon Registrar (for .com, .net, and .org domains) or for our registrar associate,
        /// Gandi (for all other TLDs). If you specify <code>false</code>, WHOIS queries return
        /// the information that you entered for the registrant contact (the domain owner).
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, registrant, and
        /// technical contacts.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <code>true</code> 
        /// </para>
        /// </summary>
        public bool PrivacyProtectRegistrantContact
        {
            get { return this._privacyProtectRegistrantContact.GetValueOrDefault(); }
            set { this._privacyProtectRegistrantContact = value; }
        }

        // Check to see if PrivacyProtectRegistrantContact property is set
        internal bool IsSetPrivacyProtectRegistrantContact()
        {
            return this._privacyProtectRegistrantContact.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivacyProtectTechContact. 
        /// <para>
        /// Whether you want to conceal contact information from WHOIS queries. If you specify
        /// <code>true</code>, WHOIS ("who is") queries return contact information either for
        /// Amazon Registrar (for .com, .net, and .org domains) or for our registrar associate,
        /// Gandi (for all other TLDs). If you specify <code>false</code>, WHOIS queries return
        /// the information that you entered for the technical contact.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, registrant, and
        /// technical contacts.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <code>true</code> 
        /// </para>
        /// </summary>
        public bool PrivacyProtectTechContact
        {
            get { return this._privacyProtectTechContact.GetValueOrDefault(); }
            set { this._privacyProtectTechContact = value; }
        }

        // Check to see if PrivacyProtectTechContact property is set
        internal bool IsSetPrivacyProtectTechContact()
        {
            return this._privacyProtectTechContact.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistrantContact. 
        /// <para>
        /// Provides detailed contact information. For information about the values that you specify
        /// for each element, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ContactDetail.html">ContactDetail</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContactDetail RegistrantContact
        {
            get { return this._registrantContact; }
            set { this._registrantContact = value; }
        }

        // Check to see if RegistrantContact property is set
        internal bool IsSetRegistrantContact()
        {
            return this._registrantContact != null;
        }

        /// <summary>
        /// Gets and sets the property TechContact. 
        /// <para>
        /// Provides detailed contact information. For information about the values that you specify
        /// for each element, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ContactDetail.html">ContactDetail</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContactDetail TechContact
        {
            get { return this._techContact; }
            set { this._techContact = value; }
        }

        // Check to see if TechContact property is set
        internal bool IsSetTechContact()
        {
            return this._techContact != null;
        }

    }
}