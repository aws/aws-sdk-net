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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// This is the response object from the GetDomainDetail operation.
    /// </summary>
    public partial class GetDomainDetailResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AbuseContactEmail. 
        /// <para>
        /// Email address to contact to report incorrect contact information for a domain, to
        /// report that the domain is being used to send spam, to report that someone is cybersquatting
        /// on a domain name, or report some other type of abuse.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 254)]
        public string AbuseContactEmail { get; set; }

        /// <summary>
        /// Checks to see if the AbuseContactEmail property is set.
        /// </summary>
        internal bool IsSetAbuseContactEmail() => this.AbuseContactEmail != null;

        /// <summary>
        /// Gets and sets the property AbuseContactPhone. 
        /// <para>
        /// Phone number for reporting abuse.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 30)]
        public string AbuseContactPhone { get; set; }

        /// <summary>
        /// Checks to see if the AbuseContactPhone property is set.
        /// </summary>
        internal bool IsSetAbuseContactPhone() => this.AbuseContactPhone != null;

        /// <summary>
        /// Gets and sets the property AdminContact. 
        /// <para>
        /// Provides details about the domain administrative contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ContactDetail AdminContact { get; set; }

        /// <summary>
        /// Checks to see if the AdminContact property is set.
        /// </summary>
        internal bool IsSetAdminContact() => this.AdminContact != null;

        /// <summary>
        /// Gets and sets the property AdminPrivacy. 
        /// <para>
        /// Specifies whether contact information is concealed from WHOIS queries. If the value
        /// is <c>true</c>, WHOIS ("who is") queries return contact information either for Amazon
        /// Registrar or for our registrar associate, Gandi. If the value is <c>false</c>, WHOIS
        /// queries return the information that you entered for the admin contact.
        /// </para>
        /// </summary>
        public bool? AdminPrivacy { get; set; }

        /// <summary>
        /// Checks to see if the AdminPrivacy property is set.
        /// </summary>
        internal bool IsSetAdminPrivacy() => this.AdminPrivacy.HasValue;

        /// <summary>
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// Specifies whether the domain registration is set to renew automatically.
        /// </para>
        /// </summary>
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// Checks to see if the AutoRenew property is set.
        /// </summary>
        internal bool IsSetAutoRenew() => this.AutoRenew.HasValue;

        /// <summary>
        /// Gets and sets the property BillingContact. 
        /// <para>
        /// Provides details about the domain billing contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ContactDetail BillingContact { get; set; }

        /// <summary>
        /// Checks to see if the BillingContact property is set.
        /// </summary>
        internal bool IsSetBillingContact() => this.BillingContact != null;

        /// <summary>
        /// Gets and sets the property BillingPrivacy. 
        /// <para>
        /// Specifies whether contact information is concealed from WHOIS queries. If the value
        /// is <c>true</c>, WHOIS ("who is") queries return contact information either for Amazon
        /// Registrar or for our registrar associate, Gandi. If the value is <c>false</c>, WHOIS
        /// queries return the information that you entered for the billing contact.
        /// </para>
        /// </summary>
        public bool? BillingPrivacy { get; set; }

        /// <summary>
        /// Checks to see if the BillingPrivacy property is set.
        /// </summary>
        internal bool IsSetBillingPrivacy() => this.BillingPrivacy.HasValue;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date when the domain was created as found in the response to a WHOIS query. The
        /// date and time is in Unix time format and Coordinated Universal time (UTC).
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property DnsSec. 
        /// <para>
        /// Deprecated.
        /// </para>
        /// </summary>
        public string DnsSec { get; set; }

        /// <summary>
        /// Checks to see if the DnsSec property is set.
        /// </summary>
        internal bool IsSetDnsSec() => this.DnsSec != null;

        /// <summary>
        /// Gets and sets the property DnssecKeys. 
        /// <para>
        /// A complex type that contains information about the DNSSEC configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DnssecKey> DnssecKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<DnssecKey>() : null;

        /// <summary>
        /// Checks to see if the DnssecKeys property is set.
        /// </summary>
        internal bool IsSetDnssecKeys() => this.DnssecKeys != null && (this.DnssecKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of a domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date when the registration for the domain is set to expire. The date and time
        /// is in Unix time format and Coordinated Universal time (UTC).
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Nameservers. 
        /// <para>
        /// The name servers of the domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Nameserver> Nameservers { get; set; } = AWSConfigs.InitializeCollections ? new List<Nameserver>() : null;

        /// <summary>
        /// Checks to see if the Nameservers property is set.
        /// </summary>
        internal bool IsSetNameservers() => this.Nameservers != null && (this.Nameservers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegistrantContact. 
        /// <para>
        /// Provides details about the domain registrant.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ContactDetail RegistrantContact { get; set; }

        /// <summary>
        /// Checks to see if the RegistrantContact property is set.
        /// </summary>
        internal bool IsSetRegistrantContact() => this.RegistrantContact != null;

        /// <summary>
        /// Gets and sets the property RegistrantPrivacy. 
        /// <para>
        /// Specifies whether contact information is concealed from WHOIS queries. If the value
        /// is <c>true</c>, WHOIS ("who is") queries return contact information either for Amazon
        /// Registrar or for our registrar associate, Gandi. If the value is <c>false</c>, WHOIS
        /// queries return the information that you entered for the registrant contact (domain
        /// owner).
        /// </para>
        /// </summary>
        public bool? RegistrantPrivacy { get; set; }

        /// <summary>
        /// Checks to see if the RegistrantPrivacy property is set.
        /// </summary>
        internal bool IsSetRegistrantPrivacy() => this.RegistrantPrivacy.HasValue;

        /// <summary>
        /// Gets and sets the property RegistrarName. 
        /// <para>
        /// Name of the registrar of the domain as identified in the registry. 
        /// </para>
        /// </summary>
        public string RegistrarName { get; set; }

        /// <summary>
        /// Checks to see if the RegistrarName property is set.
        /// </summary>
        internal bool IsSetRegistrarName() => this.RegistrarName != null;

        /// <summary>
        /// Gets and sets the property RegistrarUrl. 
        /// <para>
        /// Web address of the registrar.
        /// </para>
        /// </summary>
        public string RegistrarUrl { get; set; }

        /// <summary>
        /// Checks to see if the RegistrarUrl property is set.
        /// </summary>
        internal bool IsSetRegistrarUrl() => this.RegistrarUrl != null;

        /// <summary>
        /// Gets and sets the property RegistryDomainId. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string RegistryDomainId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryDomainId property is set.
        /// </summary>
        internal bool IsSetRegistryDomainId() => this.RegistryDomainId != null;

        /// <summary>
        /// Gets and sets the property Reseller. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string Reseller { get; set; }

        /// <summary>
        /// Checks to see if the Reseller property is set.
        /// </summary>
        internal bool IsSetReseller() => this.Reseller != null;

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
        /// <c>epp status codes</c>. (Search on the ICANN website; web searches sometimes return
        /// an old version of the document.)
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StatusList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatusList property is set.
        /// </summary>
        internal bool IsSetStatusList() => this.StatusList != null && (this.StatusList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TechContact. 
        /// <para>
        /// Provides details about the domain technical contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ContactDetail TechContact { get; set; }

        /// <summary>
        /// Checks to see if the TechContact property is set.
        /// </summary>
        internal bool IsSetTechContact() => this.TechContact != null;

        /// <summary>
        /// Gets and sets the property TechPrivacy. 
        /// <para>
        /// Specifies whether contact information is concealed from WHOIS queries. If the value
        /// is <c>true</c>, WHOIS ("who is") queries return contact information either for Amazon
        /// Registrar or for our registrar associate, Gandi. If the value is <c>false</c>, WHOIS
        /// queries return the information that you entered for the technical contact.
        /// </para>
        /// </summary>
        public bool? TechPrivacy { get; set; }

        /// <summary>
        /// Checks to see if the TechPrivacy property is set.
        /// </summary>
        internal bool IsSetTechPrivacy() => this.TechPrivacy.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedDate. 
        /// <para>
        /// The last updated date of the domain as found in the response to a WHOIS query. The
        /// date and time is in Unix time format and Coordinated Universal time (UTC).
        /// </para>
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedDate property is set.
        /// </summary>
        internal bool IsSetUpdatedDate() => this.UpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property WhoIsServer. 
        /// <para>
        /// The fully qualified name of the WHOIS server that can answer the WHOIS query for the
        /// domain.
        /// </para>
        /// </summary>
        public string WhoIsServer { get; set; }

        /// <summary>
        /// Checks to see if the WhoIsServer property is set.
        /// </summary>
        internal bool IsSetWhoIsServer() => this.WhoIsServer != null;
    }
}
