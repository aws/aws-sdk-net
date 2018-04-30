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
    /// Container for the parameters to the UpdateDomainContactPrivacy operation.
    /// This operation updates the specified domain contact's privacy setting. When privacy
    /// protection is enabled, contact information such as email address is replaced either
    /// with contact information for Amazon Registrar (for .com, .net, and .org domains) or
    /// with contact information for our registrar associate, Gandi.
    /// 
    ///  
    /// <para>
    /// This operation affects only the contact information for the specified contact type
    /// (registrant, administrator, or tech). If the request succeeds, Amazon Route 53 returns
    /// an operation ID that you can use with <a>GetOperationDetail</a> to track the progress
    /// and completion of the action. If the request doesn't complete successfully, the domain
    /// registrant will be notified by email.
    /// </para>
    /// </summary>
    public partial class UpdateDomainContactPrivacyRequest : AmazonRoute53DomainsRequest
    {
        private bool? _adminPrivacy;
        private string _domainName;
        private bool? _registrantPrivacy;
        private bool? _techPrivacy;

        /// <summary>
        /// Gets and sets the property AdminPrivacy. 
        /// <para>
        /// Whether you want to conceal contact information from WHOIS queries. If you specify
        /// <code>true</code>, WHOIS ("who is") queries return contact information either for
        /// Amazon Registrar (for .com, .net, and .org domains) or for our registrar associate,
        /// Gandi (for all other TLDs). If you specify <code>false</code>, WHOIS queries return
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that you want to update the privacy setting for.
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
        /// Gets and sets the property RegistrantPrivacy. 
        /// <para>
        /// Whether you want to conceal contact information from WHOIS queries. If you specify
        /// <code>true</code>, WHOIS ("who is") queries return contact information either for
        /// Amazon Registrar (for .com, .net, and .org domains) or for our registrar associate,
        /// Gandi (for all other TLDs). If you specify <code>false</code>, WHOIS queries return
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
        /// Gets and sets the property TechPrivacy. 
        /// <para>
        /// Whether you want to conceal contact information from WHOIS queries. If you specify
        /// <code>true</code>, WHOIS ("who is") queries return contact information either for
        /// Amazon Registrar (for .com, .net, and .org domains) or for our registrar associate,
        /// Gandi (for all other TLDs). If you specify <code>false</code>, WHOIS queries return
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

    }
}