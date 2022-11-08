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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Container for the parameters to the RequestCertificate operation.
    /// Requests an ACM certificate for use with other Amazon Web Services services. To request
    /// an ACM certificate, you must specify a fully qualified domain name (FQDN) in the <code>DomainName</code>
    /// parameter. You can also specify additional FQDNs in the <code>SubjectAlternativeNames</code>
    /// parameter. 
    /// 
    ///  
    /// <para>
    /// If you are requesting a private certificate, domain validation is not required. If
    /// you are requesting a public certificate, each domain name that you specify must be
    /// validated to verify that you own or control the domain. You can use <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">DNS
    /// validation</a> or <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-email.html">email
    /// validation</a>. We recommend that you use DNS validation. ACM issues public certificates
    /// after receiving approval from the domain owner. 
    /// </para>
    ///  <note> 
    /// <para>
    /// ACM behavior differs from the <a href="https://datatracker.ietf.org/doc/html/rfc6125#appendix-B.2">RFC
    /// 6125</a> specification of the certificate validation process. ACM first checks for
    /// a Subject Alternative Name, and, if it finds one, ignores the common name (CN).
    /// </para>
    ///  </note> 
    /// <para>
    /// After successful completion of the <code>RequestCertificate</code> action, there is
    /// a delay of several seconds before you can retrieve information about the new certificate.
    /// </para>
    /// </summary>
    public partial class RequestCertificateRequest : AmazonCertificateManagerRequest
    {
        private string _certificateAuthorityArn;
        private string _domainName;
        private List<DomainValidationOption> _domainValidationOptions = new List<DomainValidationOption>();
        private string _idempotencyToken;
        private KeyAlgorithm _keyAlgorithm;
        private CertificateOptions _options;
        private List<string> _subjectAlternativeNames = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private ValidationMethod _validationMethod;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the private certificate authority (CA) that will
        /// be used to issue the certificate. If you do not provide an ARN and you are trying
        /// to request a private certificate, ACM will attempt to issue a public certificate.
        /// For more information about private CAs, see the <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PcaWelcome.html">Amazon
        /// Web Services Private Certificate Authority</a> user guide. The ARN must have the following
        /// form: 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm-pca:region:account:certificate-authority/12345678-1234-1234-1234-123456789012</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CertificateAuthorityArn
        {
            get { return this._certificateAuthorityArn; }
            set { this._certificateAuthorityArn = value; }
        }

        // Check to see if CertificateAuthorityArn property is set
        internal bool IsSetCertificateAuthorityArn()
        {
            return this._certificateAuthorityArn != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Fully qualified domain name (FQDN), such as www.example.com, that you want to secure
        /// with an ACM certificate. Use an asterisk (*) to create a wildcard certificate that
        /// protects several sites in the same domain. For example, *.example.com protects www.example.com,
        /// site.example.com, and images.example.com. 
        /// </para>
        ///  
        /// <para>
        /// In compliance with <a href="https://datatracker.ietf.org/doc/html/rfc5280">RFC 5280</a>,
        /// the length of the domain name (technically, the Common Name) that you provide cannot
        /// exceed 64 octets (characters), including periods. To add a longer domain name, specify
        /// it in the Subject Alternative Name field, which supports names up to 253 octets in
        /// length. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=253)]
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
        /// The domain name that you want ACM to use to send you emails so that you can validate
        /// domain ownership.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        [AWSProperty(Min=1, Max=32)]
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
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// Specifies the algorithm of the public and private key pair that your certificate uses
        /// to encrypt data. RSA is the default key algorithm for ACM certificates. Elliptic Curve
        /// Digital Signature Algorithm (ECDSA) keys are smaller, offering security comparable
        /// to RSA keys but with greater computing efficiency. However, ECDSA is not supported
        /// by all network clients. Some AWS services may require RSA keys, or only support ECDSA
        /// keys of a particular size, while others allow the use of either RSA and ECDSA keys
        /// to ensure that compatibility is not broken. Check the requirements for the AWS service
        /// where you plan to deploy your certificate.
        /// </para>
        ///  
        /// <para>
        /// Default: RSA_2048
        /// </para>
        /// </summary>
        public KeyAlgorithm KeyAlgorithm
        {
            get { return this._keyAlgorithm; }
            set { this._keyAlgorithm = value; }
        }

        // Check to see if KeyAlgorithm property is set
        internal bool IsSetKeyAlgorithm()
        {
            return this._keyAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Currently, you can use this parameter to specify whether to add the certificate to
        /// a certificate transparency log. Certificate transparency makes it possible to detect
        /// SSL/TLS certificates that have been mistakenly or maliciously issued. Certificates
        /// that have not been logged typically produce an error message in a browser. For more
        /// information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-bestpractices.html#best-practices-transparency">Opting
        /// Out of Certificate Transparency Logging</a>.
        /// </para>
        /// </summary>
        public CertificateOptions Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectAlternativeNames. 
        /// <para>
        /// Additional FQDNs to be included in the Subject Alternative Name extension of the ACM
        /// certificate. For example, add the name www.example.net to a certificate for which
        /// the <code>DomainName</code> field is www.example.com if users can reach your site
        /// by using either name. The maximum number of domain names that you can add to an ACM
        /// certificate is 100. However, the initial quota is 10 domain names. If you need more
        /// than 10 names, you must request a quota increase. For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-limits.html">Quotas</a>.
        /// </para>
        ///  
        /// <para>
        ///  The maximum length of a SAN DNS name is 253 octets. The name is made up of multiple
        /// labels separated by periods. No label can be longer than 63 octets. Consider the following
        /// examples: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>(63 octets).(63 octets).(63 octets).(61 octets)</code> is legal because the
        /// total length is 253 octets (63+1+63+1+63+1+61) and no label exceeds 63 octets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>(64 octets).(63 octets).(63 octets).(61 octets)</code> is not legal because
        /// the total length exceeds 253 octets (64+1+63+1+63+1+61) and the first label exceeds
        /// 63 octets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>(63 octets).(63 octets).(63 octets).(62 octets)</code> is not legal because
        /// the total length of the DNS name (63+1+63+1+63+1+62) exceeds 253 octets.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more resource tags to associate with the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ValidationMethod. 
        /// <para>
        /// The method you want to use if you are requesting a public certificate to validate
        /// that you own or control domain. You can <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">validate
        /// with DNS</a> or <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-email.html">validate
        /// with email</a>. We recommend that you use DNS validation. 
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

    }
}