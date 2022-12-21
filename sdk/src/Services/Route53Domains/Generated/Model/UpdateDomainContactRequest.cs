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
    /// Container for the parameters to the UpdateDomainContact operation.
    /// This operation updates the contact information for a particular domain. You must specify
    /// information for at least one contact: registrant, administrator, or technical.
    /// 
    ///  
    /// <para>
    /// If the update is successful, this method returns an operation ID that you can use
    /// to track the progress and completion of the operation. If the request is not completed
    /// successfully, the domain registrant will be notified by email.
    /// </para>
    /// </summary>
    public partial class UpdateDomainContactRequest : AmazonRoute53DomainsRequest
    {
        private ContactDetail _adminContact;
        private Consent _consent;
        private string _domainName;
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
        /// Gets and sets the property Consent. 
        /// <para>
        ///  Customer's consent for the owner change request. 
        /// </para>
        /// </summary>
        public Consent Consent
        {
            get { return this._consent; }
            set { this._consent = value; }
        }

        // Check to see if Consent property is set
        internal bool IsSetConsent()
        {
            return this._consent != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that you want to update contact information for.
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