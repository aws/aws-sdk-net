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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the TransferDomain operation.
    /// This operation transfers a domain from another registrar to Amazon Route 53. When
    /// the transfer is complete, the domain is registered either with Amazon Registrar (for
    /// .com, .net, and .org domains) or with our registrar associate, Gandi (for all other
    /// TLDs).
    /// 
    ///  
    /// <para>
    /// For transfer requirements, a detailed procedure, and information about viewing the
    /// status of a domain transfer, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-to-route-53.html">Transferring
    /// Registration for a Domain to Amazon Route 53</a> in the <i>Amazon Route 53 Developer
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If the registrar for your domain is also the DNS service provider for the domain,
    /// we highly recommend that you consider transferring your DNS service to Amazon Route
    /// 53 or to another DNS service provider before you transfer your registration. Some
    /// registrars provide free DNS service when you purchase a domain registration. When
    /// you transfer the registration, the previous registrar will not renew your domain registration
    /// and could end your DNS service at any time.
    /// </para>
    ///  <important> 
    /// <para>
    /// If the registrar for your domain is also the DNS service provider for the domain and
    /// you don't transfer DNS service to another provider, your website, email, and the web
    /// applications associated with the domain might become unavailable.
    /// </para>
    ///  </important> 
    /// <para>
    /// If the transfer is successful, this method returns an operation ID that you can use
    /// to track the progress and completion of the action. If the transfer doesn't complete
    /// successfully, the domain registrant will be notified by email.
    /// </para>
    /// </summary>
    public partial class TransferDomainRequest : AmazonRoute53DomainsRequest
    {
        private ContactDetail _adminContact;
        private string _authCode;
        private bool? _autoRenew;
        private string _domainName;
        private int? _durationInYears;
        private string _idnLangCode;
        private List<Nameserver> _nameservers = new List<Nameserver>();
        private bool? _privacyProtectAdminContact;
        private bool? _privacyProtectRegistrantContact;
        private bool? _privacyProtectTechContact;
        private ContactDetail _registrantContact;
        private ContactDetail _techContact;

        /// <summary>
        /// Gets and sets the property AdminContact. 
        /// <para>
        /// Provides detailed contact information.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property AuthCode. 
        /// <para>
        /// The authorization code for the domain. You get this value from the current registrar.
        /// </para>
        /// </summary>
        public string AuthCode
        {
            get { return this._authCode; }
            set { this._authCode = value; }
        }

        // Check to see if AuthCode property is set
        internal bool IsSetAuthCode()
        {
            return this._authCode != null;
        }

        /// <summary>
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// Indicates whether the domain will be automatically renewed (true) or not (false).
        /// Autorenewal only takes effect after the account is charged.
        /// </para>
        ///  
        /// <para>
        /// Default: true
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
        /// The name of the domain that you want to transfer to Amazon Route 53.
        /// </para>
        ///  
        /// <para>
        /// Constraints: The domain name can contain only the letters a through z, the numbers
        /// 0 through 9, and hyphen (-). Internationalized Domain Names are not supported.
        /// </para>
        /// </summary>
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
        /// for a minimum of one year. The maximum period depends on the top-level domain.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Nameservers. 
        /// <para>
        /// Contains details for the host and glue IP addresses.
        /// </para>
        /// </summary>
        public List<Nameserver> Nameservers
        {
            get { return this._nameservers; }
            set { this._nameservers = value; }
        }

        // Check to see if Nameservers property is set
        internal bool IsSetNameservers()
        {
            return this._nameservers != null && this._nameservers.Count > 0; 
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
        ///  
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
        /// the information that you entered for the registrant contact (domain owner).
        /// </para>
        ///  
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
        ///  
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
        /// Provides detailed contact information.
        /// </para>
        /// </summary>
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
        /// Provides detailed contact information.
        /// </para>
        /// </summary>
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