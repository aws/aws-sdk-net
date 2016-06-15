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
    /// Container for the parameters to the RequestCertificate operation.
    /// Requests an ACM Certificate for use with other AWS services. To request an ACM Certificate,
    /// you must specify the fully qualified domain name (FQDN) for your site. You can also
    /// specify additional FQDNs if users can reach your site by using other names. For each
    /// domain name you specify, email is sent to the domain owner to request approval to
    /// issue the certificate. After receiving approval from the domain owner, the ACM Certificate
    /// is issued. For more information, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/overview.html">AWS
    /// Certificate Manager User Guide </a>.
    /// </summary>
    public partial class RequestCertificateRequest : AmazonCertificateManagerRequest
    {
        private string _domainName;
        private List<DomainValidationOption> _domainValidationOptions = new List<DomainValidationOption>();
        private string _idempotencyToken;
        private List<string> _subjectAlternativeNames = new List<string>();

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Fully qualified domain name (FQDN), such as www.example.com, of the site you want
        /// to secure with an ACM Certificate. Use an asterisk (*) to create a wildcard certificate
        /// that protects several sites in the same domain. For example, *.example.com protects
        /// www.example.com, site.example.com, and images.example.com.
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
        /// Gets and sets the property DomainValidationOptions. 
        /// <para>
        /// The base validation domain that will act as the suffix of the email addresses that
        /// are used to send the emails. This must be the same as the <code>Domain</code> value
        /// or a superdomain of the <code>Domain</code> value. For example, if you requested a
        /// certificate for <code>test.example.com</code> and specify <b>DomainValidationOptions</b>
        /// of <code>example.com</code>, ACM sends email to the domain registrant, technical contact,
        /// and administrative contact in WHOIS and the following five addresses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// admin@example.com
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// administrator@example.com
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// hostmaster@example.com
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// postmaster@example.com
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// webmaster@example.com
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<DomainValidationOption> DomainValidationOptions
        {
            get { return this._domainValidationOptions; }
            set { this._domainValidationOptions = value; }
        }

        // Check to see if DomainValidationOptions property is set
        internal bool IsSetDomainValidationOptions()
        {
            return this._domainValidationOptions != null && this._domainValidationOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// Customer chosen string that can be used to distinguish between calls to <code>RequestCertificate</code>.
        /// Idempotency tokens time out after one hour. Therefore, if you call <code>RequestCertificate</code>
        /// multiple times with the same idempotency token within one hour, ACM recognizes that
        /// you are requesting only one certificate and will issue only one. If you change the
        /// idempotency token for each call, ACM recognizes that you are requesting multiple certificates.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectAlternativeNames. 
        /// <para>
        /// Additional FQDNs to be included in the Subject Alternative Name extension of the ACM
        /// Certificate. For example, add the name www.example.net to a certificate for which
        /// the <code>DomainName</code> field is www.example.com if users can reach your site
        /// by using either name.
        /// </para>
        /// </summary>
        public List<string> SubjectAlternativeNames
        {
            get { return this._subjectAlternativeNames; }
            set { this._subjectAlternativeNames = value; }
        }

        // Check to see if SubjectAlternativeNames property is set
        internal bool IsSetSubjectAlternativeNames()
        {
            return this._subjectAlternativeNames != null && this._subjectAlternativeNames.Count > 0; 
        }

    }
}