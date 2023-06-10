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
    /// The GetDomainDetail response includes the following elements.
    /// </summary>
    public partial class GetDomainDetailResponse : AmazonWebServiceResponse
    {
        private string _abuseContactEmail;
        private string _abuseContactPhone;
        private ContactDetail _adminContact;
        private bool? _adminPrivacy;
        private bool? _autoRenew;
        private DateTime? _creationDate;
        private string _dnsSec;
        private List<DnssecKey> _dnssecKeys = new List<DnssecKey>();
        private string _domainName;
        private DateTime? _expirationDate;
        private List<Nameserver> _nameservers = new List<Nameserver>();
        private ContactDetail _registrantContact;
        private bool? _registrantPrivacy;
        private string _registrarName;
        private string _registrarUrl;
        private string _registryDomainId;
        private string _reseller;
        private List<string> _statusList = new List<string>();
        private ContactDetail _techContact;
        private bool? _techPrivacy;
        private DateTime? _updatedDate;
        private string _whoIsServer;

        /// <summary>
        /// Gets and sets the property AbuseContactEmail. 
        /// <para>
        /// Email address to contact to report incorrect contact information for a domain, to
        /// report that the domain is being used to send spam, to report that someone is cybersquatting
        /// on a domain name, or report some other type of abuse.
        /// </para>
        /// </summary>
        [AWSProperty(Max=254)]
        public string AbuseContactEmail
        {
            get { return this._abuseContactEmail; }
            set { this._abuseContactEmail = value; }
        }

        // Check to see if AbuseContactEmail property is set
        internal bool IsSetAbuseContactEmail()
        {
            return this._abuseContactEmail != null;
        }

        /// <summary>
        /// Gets and sets the property AbuseContactPhone. 
        /// <para>
        /// Phone number for reporting abuse.
        /// </para>
        /// </summary>
        [AWSProperty(Max=30)]
        public string AbuseContactPhone
        {
            get { return this._abuseContactPhone; }
            set { this._abuseContactPhone = value; }
        }

        // Check to see if AbuseContactPhone property is set
        internal bool IsSetAbuseContactPhone()
        {
            return this._abuseContactPhone != null;
        }

        /// <summary>
        /// Gets and sets the property AdminContact. 
        /// <para>
        /// Provides details about the domain administrative contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property AdminPrivacy. 
        /// <para>
        /// Specifies whether contact information is concealed from WHOIS queries. If the value
        /// is <code>true</code>, WHOIS ("who is") queries return contact information either for
        /// Amazon Registrar (for .com, .net, and .org domains) or for our registrar associate,
        /// Gandi (for all other TLDs). If the value is <code>false</code>, WHOIS queries return
        /// the information that you entered for the admin contact.
        /// </para>
        /// </summary>
        public bool AdminPrivacy
        {
            get { return this._adminPrivacy.GetValueOrDefault(); }
            set { this._adminPrivacy = value; }
        }

        // Check to see if AdminPrivacy property is set
        internal bool IsSetAdminPrivacy()
        {
            return this._adminPrivacy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// Specifies whether the domain registration is set to renew automatically.
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date when the domain was created as found in the response to a WHOIS query. The
        /// date and time is in Unix time format and Coordinated Universal time (UTC).
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DnsSec. 
        /// <para>
        /// Deprecated.
        /// </para>
        /// </summary>
        public string DnsSec
        {
            get { return this._dnsSec; }
            set { this._dnsSec = value; }
        }

        // Check to see if DnsSec property is set
        internal bool IsSetDnsSec()
        {
            return this._dnsSec != null;
        }

        /// <summary>
        /// Gets and sets the property DnssecKeys. 
        /// <para>
        /// A complex type that contains information about the DNSSEC configuration.
        /// </para>
        /// </summary>
        public List<DnssecKey> DnssecKeys
        {
            get { return this._dnssecKeys; }
            set { this._dnssecKeys = value; }
        }

        // Check to see if DnssecKeys property is set
        internal bool IsSetDnssecKeys()
        {
            return this._dnssecKeys != null && this._dnssecKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of a domain.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date when the registration for the domain is set to expire. The date and time
        /// is in Unix time format and Coordinated Universal time (UTC).
        /// </para>
        /// </summary>
        public DateTime ExpirationDate
        {
            get { return this._expirationDate.GetValueOrDefault(); }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Nameservers. 
        /// <para>
        /// The name servers of the domain.
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
        /// Gets and sets the property RegistrantContact. 
        /// <para>
        /// Provides details about the domain registrant.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property RegistrantPrivacy. 
        /// <para>
        /// Specifies whether contact information is concealed from WHOIS queries. If the value
        /// is <code>true</code>, WHOIS ("who is") queries return contact information either for
        /// Amazon Registrar (for .com, .net, and .org domains) or for our registrar associate,
        /// Gandi (for all other TLDs). If the value is <code>false</code>, WHOIS queries return
        /// the information that you entered for the registrant contact (domain owner).
        /// </para>
        /// </summary>
        public bool RegistrantPrivacy
        {
            get { return this._registrantPrivacy.GetValueOrDefault(); }
            set { this._registrantPrivacy = value; }
        }

        // Check to see if RegistrantPrivacy property is set
        internal bool IsSetRegistrantPrivacy()
        {
            return this._registrantPrivacy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistrarName. 
        /// <para>
        /// Name of the registrar of the domain as identified in the registry. Domains with a
        /// .com, .net, or .org TLD are registered by Amazon Registrar. All other domains are
        /// registered by our registrar associate, Gandi. The value for domains that are registered
        /// by Gandi is <code>"GANDI SAS"</code>. 
        /// </para>
        /// </summary>
        public string RegistrarName
        {
            get { return this._registrarName; }
            set { this._registrarName = value; }
        }

        // Check to see if RegistrarName property is set
        internal bool IsSetRegistrarName()
        {
            return this._registrarName != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrarUrl. 
        /// <para>
        /// Web address of the registrar.
        /// </para>
        /// </summary>
        public string RegistrarUrl
        {
            get { return this._registrarUrl; }
            set { this._registrarUrl = value; }
        }

        // Check to see if RegistrarUrl property is set
        internal bool IsSetRegistrarUrl()
        {
            return this._registrarUrl != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryDomainId. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string RegistryDomainId
        {
            get { return this._registryDomainId; }
            set { this._registryDomainId = value; }
        }

        // Check to see if RegistryDomainId property is set
        internal bool IsSetRegistryDomainId()
        {
            return this._registryDomainId != null;
        }

        /// <summary>
        /// Gets and sets the property Reseller. 
        /// <para>
        /// Reseller of the domain. Domains registered or transferred using Route 53 domains will
        /// have <code>"Amazon"</code> as the reseller. 
        /// </para>
        /// </summary>
        public string Reseller
        {
            get { return this._reseller; }
            set { this._reseller = value; }
        }

        // Check to see if Reseller property is set
        internal bool IsSetReseller()
        {
            return this._reseller != null;
        }

        /// <summary>
        /// Gets and sets the property StatusList. 
        /// <para>
        /// An array of domain name status codes, also known as Extensible Provisioning Protocol
        /// (EPP) status codes.
        /// </para>
        ///  
        /// <para>
        /// ICANN, the organization that maintains a central database of domain names, has developed
        /// a set of domain name status codes that tell you the status of a variety of operations
        /// on a domain name, for example, registering a domain name, transferring a domain name
        /// to another registrar, renewing the registration for a domain name, and so on. All
        /// registrars use this same set of status codes.
        /// </para>
        ///  
        /// <para>
        /// For a current list of domain name status codes and an explanation of what each code
        /// means, go to the <a href="https://www.icann.org/">ICANN website</a> and search for
        /// <code>epp status codes</code>. (Search on the ICANN website; web searches sometimes
        /// return an old version of the document.)
        /// </para>
        /// </summary>
        public List<string> StatusList
        {
            get { return this._statusList; }
            set { this._statusList = value; }
        }

        // Check to see if StatusList property is set
        internal bool IsSetStatusList()
        {
            return this._statusList != null && this._statusList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TechContact. 
        /// <para>
        /// Provides details about the domain technical contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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

        /// <summary>
        /// Gets and sets the property TechPrivacy. 
        /// <para>
        /// Specifies whether contact information is concealed from WHOIS queries. If the value
        /// is <code>true</code>, WHOIS ("who is") queries return contact information either for
        /// Amazon Registrar (for .com, .net, and .org domains) or for our registrar associate,
        /// Gandi (for all other TLDs). If the value is <code>false</code>, WHOIS queries return
        /// the information that you entered for the technical contact.
        /// </para>
        /// </summary>
        public bool TechPrivacy
        {
            get { return this._techPrivacy.GetValueOrDefault(); }
            set { this._techPrivacy = value; }
        }

        // Check to see if TechPrivacy property is set
        internal bool IsSetTechPrivacy()
        {
            return this._techPrivacy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedDate. 
        /// <para>
        /// The last updated date of the domain as found in the response to a WHOIS query. The
        /// date and time is in Unix time format and Coordinated Universal time (UTC).
        /// </para>
        /// </summary>
        public DateTime UpdatedDate
        {
            get { return this._updatedDate.GetValueOrDefault(); }
            set { this._updatedDate = value; }
        }

        // Check to see if UpdatedDate property is set
        internal bool IsSetUpdatedDate()
        {
            return this._updatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WhoIsServer. 
        /// <para>
        /// The fully qualified name of the WHOIS server that can answer the WHOIS query for the
        /// domain.
        /// </para>
        /// </summary>
        public string WhoIsServer
        {
            get { return this._whoIsServer; }
            set { this._whoIsServer = value; }
        }

        // Check to see if WhoIsServer property is set
        internal bool IsSetWhoIsServer()
        {
            return this._whoIsServer != null;
        }

    }
}