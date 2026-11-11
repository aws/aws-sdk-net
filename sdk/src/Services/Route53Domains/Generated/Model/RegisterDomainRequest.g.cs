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
    /// Container for the parameters to the RegisterDomain operation. This operation registers
    /// a domain. For some top-level domains (TLDs), this operation requires extra parameters.
    /// <para> When you register a domain, Amazon Route 53 does the following: </para> <ul>
    /// <li> <para> Creates a Route 53 hosted zone that has the same name as the domain. Route
    /// 53 assigns four name servers to your hosted zone and automatically updates your domain
    /// registration with the names of these name servers. </para> </li> <li> <para> Enables
    /// auto renew, so your domain registration will renew automatically each year. We'll
    /// notify you in advance of the renewal date so you can choose whether to renew the registration.
    /// </para> </li> <li> <para> Optionally enables privacy protection, so WHOIS queries
    /// return contact for the registrar or the phrase "REDACTED FOR PRIVACY", or "On behalf
    /// of &lt;domain name&gt; owner." If you don't enable privacy protection, WHOIS queries
    /// return the information that you entered for the administrative, registrant, and technical
    /// contacts. </para> <note> <para> While some domains may allow different privacy settings
    /// per contact, we recommend specifying the same privacy setting for all contacts. </para>
    /// </note> </li> <li> <para> If registration is successful, returns an operation ID that
    /// you can use to track the progress and completion of the action. If the request is
    /// not completed successfully, the domain registrant is notified by email. </para> </li>
    /// <li> <para> Charges your Amazon Web Services account an amount based on the top-level
    /// domain. For more information, see <a href="http://aws.amazon.com/route53/pricing/">Amazon
    /// Route 53 Pricing</a>. </para> </li> </ul>
    /// </summary>
    public partial class RegisterDomainRequest : AmazonRoute53DomainsRequest
    {
        /// <summary>
        /// Gets and sets the property AdminContact. 
        /// <para>
        /// Provides detailed contact information. For information about the values that you specify
        /// for each element, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ContactDetail.html">ContactDetail</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public ContactDetail AdminContact { get; set; }

        /// <summary>
        /// Checks to see if the AdminContact property is set.
        /// </summary>
        internal bool IsSetAdminContact() => this.AdminContact != null;

        /// <summary>
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// Indicates whether the domain will be automatically renewed (<c>true</c>) or not (<c>false</c>).
        /// Auto renewal only takes effect after the account is charged.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>true</c> 
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
        /// Provides detailed contact information. For information about the values that you specify
        /// for each element, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ContactDetail.html">ContactDetail</a>.
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
        /// Specifies the maximum price that you agree to pay to register the domain name. This
        /// element is required if the domain has registry premium pricing, and optional if the
        /// domain is priced at the standard rate for its TLD. If you include it and the registration
        /// price is more than <c>MaxPrice</c>, the request fails.
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
        /// Period (.) to separate the labels in the name, such as the <c>.</c> in <c>example.com</c>.
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
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 10)]
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
        /// Gets and sets the property PrivacyProtectAdminContact. 
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
        /// Whether you want to conceal contact information from WHOIS queries. If you specify
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
        /// queries return the information that you entered for the registrant contact (the domain
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
        /// Provides detailed contact information. For information about the values that you specify
        /// for each element, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ContactDetail.html">ContactDetail</a>.
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
        /// Provides detailed contact information. For information about the values that you specify
        /// for each element, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ContactDetail.html">ContactDetail</a>.
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
