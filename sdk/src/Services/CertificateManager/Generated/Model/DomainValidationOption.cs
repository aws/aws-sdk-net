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
    /// This structure is used in the request object of the <a>RequestCertificate</a> action.
    /// </summary>
    public partial class DomainValidationOption
    {
        private string _domainName;
        private string _validationDomain;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  Fully Qualified Domain Name (FQDN) of the certificate being requested. 
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
        ///  The domain to which validation email is sent. This is the base validation domain
        /// that will act as the suffix of the email addresses. This must be the same as the <code>DomainName</code>
        /// value or a superdomain of the <code>DomainName</code> value. For example, if you requested
        /// a certificate for <code>site.subdomain.example.com</code> and specify a <b>ValidationDomain</b>
        /// of <code>subdomain.example.com</code>, ACM sends email to the domain registrant, technical
        /// contact, and administrative contact in WHOIS for the base domain and the following
        /// five addresses: <ul> <li>
        /// <para>
        /// admin@subdomain.example.com
        /// </para>
        /// </li> <li>
        /// <para>
        /// administrator@subdomain.example.com
        /// </para>
        /// </li> <li>
        /// <para>
        /// hostmaster@subdomain.example.com
        /// </para>
        /// </li> <li>
        /// <para>
        /// postmaster@subdomain.example.com
        /// </para>
        /// </li> <li>
        /// <para>
        /// webmaster@subdomain.example.com
        /// </para>
        /// </li> </ul> 
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

    }
}