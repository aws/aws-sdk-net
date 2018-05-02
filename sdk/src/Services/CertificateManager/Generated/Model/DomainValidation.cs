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
    /// Contains information about the validation of each domain name in the certificate.
    /// </summary>
    public partial class DomainValidation
    {
        private string _domainName;
        private ResourceRecord _resourceRecord;
        private string _validationDomain;
        private List<string> _validationEmails = new List<string>();
        private ValidationMethod _validationMethod;
        private DomainStatus _validationStatus;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// A fully qualified domain name (FQDN) in the certificate. For example, <code>www.example.com</code>
        /// or <code>example.com</code>. 
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
        /// Gets and sets the property ResourceRecord. 
        /// <para>
        /// Contains the CNAME record that you add to your DNS database for domain validation.
        /// For more information, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">Use
        /// DNS to Validate Domain Ownership</a>.
        /// </para>
        /// </summary>
        public ResourceRecord ResourceRecord
        {
            get { return this._resourceRecord; }
            set { this._resourceRecord = value; }
        }

        // Check to see if ResourceRecord property is set
        internal bool IsSetResourceRecord()
        {
            return this._resourceRecord != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationDomain. 
        /// <para>
        /// The domain name that ACM used to send domain validation emails.
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
        /// A list of email addresses that ACM used to send domain validation emails.
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

        /// <summary>
        /// Gets and sets the property ValidationMethod. 
        /// <para>
        /// Specifies the domain validation method.
        /// </para>
        /// </summary>
        public ValidationMethod ValidationMethod
        {
            get { return this._validationMethod; }
            set { this._validationMethod = value; }
        }

        // Check to see if ValidationMethod property is set
        internal bool IsSetValidationMethod()
        {
            return this._validationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// The validation status of the domain name. This can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PENDING_VALIDATION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code/>SUCCESS
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code/>FAILED
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DomainStatus ValidationStatus
        {
            get { return this._validationStatus; }
            set { this._validationStatus = value; }
        }

        // Check to see if ValidationStatus property is set
        internal bool IsSetValidationStatus()
        {
            return this._validationStatus != null;
        }

    }
}