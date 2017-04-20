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
    /// This operation updates the specified domain contact's privacy setting. When the privacy
    /// option is enabled, personal information such as postal or email address is hidden
    /// from the results of a public WHOIS query. The privacy services are provided by the
    /// AWS registrar, Gandi. For more information, see the <a href="http://www.gandi.net/domain/whois/?currency=USD&amp;amp;lang=en">Gandi
    /// privacy features</a>.
    /// 
    ///  
    /// <para>
    /// This operation only affects the privacy of the specified contact type (registrant,
    /// administrator, or tech). Successful acceptance returns an operation ID that you can
    /// use with <a>GetOperationDetail</a> to track the progress and completion of the action.
    /// If the request is not completed successfully, the domain registrant will be notified
    /// by email.
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
        /// <code>true</code>, WHOIS ("who is") queries will return contact information for our
        /// registrar partner, Gandi, instead of the contact information that you enter.
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
        /// <code>true</code>, WHOIS ("who is") queries will return contact information for our
        /// registrar partner, Gandi, instead of the contact information that you enter.
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
        /// <code>true</code>, WHOIS ("who is") queries will return contact information for our
        /// registrar partner, Gandi, instead of the contact information that you enter.
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