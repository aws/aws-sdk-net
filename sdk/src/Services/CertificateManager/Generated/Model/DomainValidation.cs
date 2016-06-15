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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Structure that contains the domain name, the base validation domain to which validation
    /// email is sent, and the email addresses used to validate the domain identity.
    /// </summary>
    public partial class DomainValidation
    {
        private string _domainName;
        private string _validationDomain;
        private List<string> _validationEmails = new List<string>();

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Fully Qualified Domain Name (FQDN) of the form <code>www.example.com or </code> <code>example.com</code>.
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
        /// Gets and sets the property ValidationDomain. 
        /// <para>
        /// The base validation domain that acts as the suffix of the email addresses that are
        /// used to send the emails.
        /// </para>
        /// </summary>
        public string ValidationDomain
        {
            get { return this._validationDomain; }
            set { this._validationDomain = value; }
        }

        // Check to see if ValidationDomain property is set
        internal bool IsSetValidationDomain()
        {
            return this._validationDomain != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationEmails. 
        /// <para>
        /// A list of contact address for the domain registrant.
        /// </para>
        /// </summary>
        public List<string> ValidationEmails
        {
            get { return this._validationEmails; }
            set { this._validationEmails = value; }
        }

        // Check to see if ValidationEmails property is set
        internal bool IsSetValidationEmails()
        {
            return this._validationEmails != null && this._validationEmails.Count > 0; 
        }

    }
}