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
    /// Container for the parameters to the TransferDomain operation. Transfers a domain from
    /// another registrar to Amazon Route 53. <para> For more information about transferring
    /// domains, see the following topics: </para> <ul> <li> <para> For transfer requirements,
    /// a detailed procedure, and information about viewing the status of a domain that you're
    /// transferring to Route 53, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-to-route-53.html">Transferring
    /// Registration for a Domain to Amazon Route 53</a> in the <i>Amazon Route 53 Developer
    /// Guide</i>. </para> </li> <li> <para> For information about how to transfer a domain
    /// from one Amazon Web Services account to another, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
    /// </para> </li> <li> <para> For information about how to transfer a domain to another
    /// domain registrar, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-from-route-53.html">Transferring
    /// a Domain from Amazon Route 53 to Another Registrar</a> in the <i>Amazon Route 53 Developer
    /// Guide</i>. </para> </li> </ul> <important> <para> During the transfer of any country
    /// code top-level domains (ccTLDs) to Route 53, except for .cc and .tv, updates to the
    /// owner contact are ignored and the owner contact data from the registry is used. You
    /// can update the owner contact after the transfer is complete. For more information,
    /// see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_UpdateDomainContact.html">UpdateDomainContact</a>.
    /// </para> </important> <para> If the registrar for your domain is also the DNS service
    /// provider for the domain, we highly recommend that you transfer your DNS service to
    /// Route 53 or to another DNS service provider before you transfer your registration.
    /// Some registrars provide free DNS service when you purchase a domain registration.
    /// When you transfer the registration, the previous registrar will not renew your domain
    /// registration and could end your DNS service at any time. </para> <important> <para>
    /// If the registrar for your domain is also the DNS service provider for the domain and
    /// you don't transfer DNS service to another provider, your website, email, and the web
    /// applications associated with the domain might become unavailable. </para> </important>
    /// <para> If the transfer is successful, this method returns an operation ID that you
    /// can use to track the progress and completion of the action. If the transfer doesn't
    /// complete successfully, the domain registrant will be notified by email. </para>
    /// </summary>
    public partial class TransferDomainRequest : AmazonRoute53DomainsRequest
    {
        /// <summary>
        /// Gets and sets the property AdminContact. 
        /// <para>
        /// Provides detailed contact information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public ContactDetail AdminContact { get; set; }

        /// <summary>
        /// Checks to see if the AdminContact property is set.
        /// </summary>
        internal bool IsSetAdminContact() => this.AdminContact != null;

        /// <summary>
        /// Gets and sets the property AuthCode. 
        /// <para>
        /// The authorization code for the domain. You get this value from the current registrar.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string AuthCode { get; set; }

        /// <summary>
        /// Checks to see if the AuthCode property is set.
        /// </summary>
        internal bool IsSetAuthCode() => this.AuthCode != null;

        /// <summary>
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// Indicates whether the domain will be automatically renewed (true) or not (false).
        /// Auto renewal only takes effect after the account is charged.
        /// </para>
        ///  
        /// <para>
        /// Default: true
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
        /// Provides detailed contact information.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ContactDetail BillingContact { get; set; }

        /// <summary>
        /// Checks to see if the BillingContact property is set.
        /// </summary>
        internal bool IsSetBillingContact() => this.BillingContact != null;

        /// <summary>
        /// Gets and sets the property Consent. 
        /// <para>
        /// Specifies the maximum price that you agree to pay to transfer the domain name to Route
        /// 53. This element is required if the domain has registry premium pricing, and optional
        /// if the domain is priced at the standard rate for its TLD. If you include it and the
        /// transfer price is more than <c>MaxPrice</c>, the request fails.
        /// </para>
        /// </summary>
        public Consent Consent { get; set; }

        /// <summary>
        /// Checks to see if the Consent property is set.
        /// </summary>
        internal bool IsSetConsent() => this.Consent != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that you want to transfer to Route 53. The top-level domain
        /// (TLD), such as .com, must be a TLD that Route 53 supports. For a list of supported
        /// TLDs, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/registrar-tld-list.html">Domains
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
        /// Period (.) to separate the labels in the name, such as the <c>.</c> in <c>example.com</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DurationInYears. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        ///  
        /// <para>
        /// Currently, the effect of a domain transfer on the registration period varies by TLD.
        /// For information about how transferring a domain affects the expiration date, see the
        /// Transfer Term column in the pricing information at <a href="http://aws.amazon.com/route53/pricing/">Amazon
        /// Route 53 Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? DurationInYears { get; set; }

        /// <summary>
        /// Checks to see if the DurationInYears property is set.
        /// </summary>
        internal bool IsSetDurationInYears() => this.DurationInYears.HasValue;

        /// <summary>
        /// Gets and sets the property IdnLangCode. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string IdnLangCode { get; set; }

        /// <summary>
        /// Checks to see if the IdnLangCode property is set.
        /// </summary>
        internal bool IsSetIdnLangCode() => this.IdnLangCode != null;

        /// <summary>
        /// Gets and sets the property Nameservers. 
        /// <para>
        /// Contains details for the host and glue IP addresses.
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
        /// Gets and sets the property PrivacyProtectAdminContact. 
        /// <para>
        /// Whether you want to conceal contact information from WHOIS queries. If you specify
        /// <c>true</c>, WHOIS ("who is") queries return contact information for the registrar,
        /// the phrase "REDACTED FOR PRIVACY", or "On behalf of &lt;domain name&gt; owner.".
        /// </para>
        ///  <note> 
        /// <para>
        /// While some domains may allow different privacy settings per contact, we recommend
        /// specifying the same privacy setting for all contacts.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <c>true</c> 
        /// </para>
        /// </summary>
        public bool? PrivacyProtectAdminContact { get; set; }

        /// <summary>
        /// Checks to see if the PrivacyProtectAdminContact property is set.
        /// </summary>
        internal bool IsSetPrivacyProtectAdminContact() => this.PrivacyProtectAdminContact.HasValue;

        /// <summary>
        /// Gets and sets the property PrivacyProtectBillingContact. 
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
        public bool? PrivacyProtectBillingContact { get; set; }

        /// <summary>
        /// Checks to see if the PrivacyProtectBillingContact property is set.
        /// </summary>
        internal bool IsSetPrivacyProtectBillingContact() => this.PrivacyProtectBillingContact.HasValue;

        /// <summary>
        /// Gets and sets the property PrivacyProtectRegistrantContact. 
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
        /// <para>
        /// Default: <c>true</c> 
        /// </para>
        /// </summary>
        public bool? PrivacyProtectRegistrantContact { get; set; }

        /// <summary>
        /// Checks to see if the PrivacyProtectRegistrantContact property is set.
        /// </summary>
        internal bool IsSetPrivacyProtectRegistrantContact() => this.PrivacyProtectRegistrantContact.HasValue;

        /// <summary>
        /// Gets and sets the property PrivacyProtectTechContact. 
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
        /// <para>
        /// Default: <c>true</c> 
        /// </para>
        /// </summary>
        public bool? PrivacyProtectTechContact { get; set; }

        /// <summary>
        /// Checks to see if the PrivacyProtectTechContact property is set.
        /// </summary>
        internal bool IsSetPrivacyProtectTechContact() => this.PrivacyProtectTechContact.HasValue;

        /// <summary>
        /// Gets and sets the property RegistrantContact. 
        /// <para>
        /// Provides detailed contact information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public ContactDetail RegistrantContact { get; set; }

        /// <summary>
        /// Checks to see if the RegistrantContact property is set.
        /// </summary>
        internal bool IsSetRegistrantContact() => this.RegistrantContact != null;

        /// <summary>
        /// Gets and sets the property TechContact. 
        /// <para>
        /// Provides detailed contact information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public ContactDetail TechContact { get; set; }

        /// <summary>
        /// Checks to see if the TechContact property is set.
        /// </summary>
        internal bool IsSetTechContact() => this.TechContact != null;
    }
}
