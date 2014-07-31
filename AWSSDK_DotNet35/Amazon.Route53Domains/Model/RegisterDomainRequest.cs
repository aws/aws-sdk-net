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
    /// Container for the parameters to the RegisterDomain operation.
    /// This operation registers a domain. Domains are registered by the AWS registrar partner,
    /// Gandi. For some top-level domains (TLDs), this operation requires extra parameters.
    /// 
    ///  
    /// <para>
    /// When you register a domain, Amazon Route 53 does the following:
    /// </para>
    ///  <ul> <li>Creates a Amazon Route 53 hosted zone that has the same name as the domain.
    /// Amazon Route 53 assigns four name servers to your hosted zone and automatically updates
    /// your domain registration with the names of these name servers.</li> <li>Enables autorenew,
    /// so your domain registration will renew automatically each year. We'll notify you in
    /// advance of the renewal date so you can choose whether to renew the registration.</li>
    /// <li>Optionally enables privacy protection, so WHOIS queries return contact information
    /// for our registrar partner, Gandi, instead of the information you entered for registrant,
    /// admin, and tech contacts.</li> <li>If registration is successful, returns an operation
    /// ID that you can use to track the progress and completion of the action. If the request
    /// is not completed successfully, the domain registrant is notified by email.</li> <li>Charges
    /// your AWS account an amount based on the top-level domain. For more information, see
    /// <a href="http://aws.amazon.com/route53/pricing/">Amazon Route 53 Pricing</a>.</li>
    /// </ul>
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
        /// Provides detailed contact information.
        /// </para>
        ///  
        /// <para>
        /// Type: Complex
        /// </para>
        ///  
        /// <para>
        /// Children: <code>FirstName</code>, <code>MiddleName</code>, <code>LastName</code>,
        /// <code>ContactType</code>, <code>OrganizationName</code>, <code>AddressLine1</code>,
        /// <code>AddressLine2</code>, <code>City</code>, <code>State</code>, <code>CountryCode</code>,
        /// <code>ZipCode</code>, <code>PhoneNumber</code>, <code>Email</code>, <code>Fax</code>,
        /// <code>ExtraParams</code>
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
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
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// Indicates whether the domain will be automatically renewed (<code>true</code>) or
        /// not (<code>false</code>). Autorenewal only takes effect after the account is charged.
        /// </para>
        ///  
        /// <para>
        /// Type: Boolean
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>true</code> | <code>false</code>
        /// </para>
        ///  
        /// <para>
        /// Default: <code>true</code>
        /// </para>
        ///  
        /// <para>
        /// Required: No
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
        /// The name of a domain.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Default: None
        /// </para>
        ///  
        /// <para>
        /// Constraints: The domain name can contain only the letters a through z, the numbers
        /// 0 through 9, and hyphen (-). Internationalized Domain Names are not supported.
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
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
        /// The number of years the domain will be registered. Domains are registered for a minimum
        /// of one year. The maximum period depends on the top-level domain.
        /// </para>
        ///  
        /// <para>
        /// Type: Integer
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        ///  
        /// <para>
        /// Valid values: Integer from 1 to 10
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
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
        /// Gets and sets the property PrivacyProtectAdminContact. 
        /// <para>
        /// Whether you want to conceal contact information from WHOIS queries. If you specify
        /// true, WHOIS ("who is") queries will return contact information for our registrar partner,
        /// Gandi, instead of the contact information that you enter.
        /// </para>
        ///  
        /// <para>
        /// Type: Boolean
        /// </para>
        ///  
        /// <para>
        /// Default: <code>true</code>
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>true</code> | <code>false</code>
        /// </para>
        ///  
        /// <para>
        /// Required: No
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
        /// true, WHOIS ("who is") queries will return contact information for our registrar partner,
        /// Gandi, instead of the contact information that you enter.
        /// </para>
        ///  
        /// <para>
        /// Type: Boolean
        /// </para>
        ///  
        /// <para>
        /// Default: <code>true</code>
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>true</code> | <code>false</code>
        /// </para>
        ///  
        /// <para>
        /// Required: No
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
        /// true, WHOIS ("who is") queries will return contact information for our registrar partner,
        /// Gandi, instead of the contact information that you enter.
        /// </para>
        ///  
        /// <para>
        /// Type: Boolean
        /// </para>
        ///  
        /// <para>
        /// Default: <code>true</code>
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>true</code> | <code>false</code>
        /// </para>
        ///  
        /// <para>
        /// Required: No
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
        ///  
        /// <para>
        /// Type: Complex
        /// </para>
        ///  
        /// <para>
        /// Children: <code>FirstName</code>, <code>MiddleName</code>, <code>LastName</code>,
        /// <code>ContactType</code>, <code>OrganizationName</code>, <code>AddressLine1</code>,
        /// <code>AddressLine2</code>, <code>City</code>, <code>State</code>, <code>CountryCode</code>,
        /// <code>ZipCode</code>, <code>PhoneNumber</code>, <code>Email</code>, <code>Fax</code>,
        /// <code>ExtraParams</code>
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
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
        ///  
        /// <para>
        /// Type: Complex
        /// </para>
        ///  
        /// <para>
        /// Children: <code>FirstName</code>, <code>MiddleName</code>, <code>LastName</code>,
        /// <code>ContactType</code>, <code>OrganizationName</code>, <code>AddressLine1</code>,
        /// <code>AddressLine2</code>, <code>City</code>, <code>State</code>, <code>CountryCode</code>,
        /// <code>ZipCode</code>, <code>PhoneNumber</code>, <code>Email</code>, <code>Fax</code>,
        /// <code>ExtraParams</code>
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
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