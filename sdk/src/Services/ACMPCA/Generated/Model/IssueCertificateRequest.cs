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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Container for the parameters to the IssueCertificate operation.
    /// Uses your private certificate authority (CA), or one that has been shared with you,
    /// to issue a client certificate. This action returns the Amazon Resource Name (ARN)
    /// of the certificate. You can retrieve the certificate by calling the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_GetCertificate.html">GetCertificate</a>
    /// action and specifying the ARN. 
    /// 
    ///  <note> 
    /// <para>
    /// You cannot use the ACM <b>ListCertificateAuthorities</b> action to retrieve the ARNs
    /// of the certificates that you issue by using Amazon Web Services Private CA.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class IssueCertificateRequest : AmazonACMPCARequest
    {
        private ApiPassthrough _apiPassthrough;
        private string _certificateAuthorityArn;
        private MemoryStream _csr;
        private string _idempotencyToken;
        private SigningAlgorithm _signingAlgorithm;
        private string _templateArn;
        private Validity _validity;
        private Validity _validityNotBefore;

        /// <summary>
        /// Gets and sets the property ApiPassthrough. 
        /// <para>
        /// Specifies X.509 certificate information to be included in the issued certificate.
        /// An <code>APIPassthrough</code> or <code>APICSRPassthrough</code> template variant
        /// must be selected, or else this parameter is ignored. For more information about using
        /// these templates, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/UsingTemplates.html">Understanding
        /// Certificate Templates</a>.
        /// </para>
        ///  
        /// <para>
        /// If conflicting or duplicate certificate information is supplied during certificate
        /// issuance, Amazon Web Services Private CA applies <a href="https://docs.aws.amazon.com/privateca/latest/userguide/UsingTemplates.html#template-order-of-operations">order
        /// of operation rules</a> to determine what information is used.
        /// </para>
        /// </summary>
        public ApiPassthrough ApiPassthrough
        {
            get { return this._apiPassthrough; }
            set { this._apiPassthrough = value; }
        }

        // Check to see if ApiPassthrough property is set
        internal bool IsSetApiPassthrough()
        {
            return this._apiPassthrough != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that was returned when you called <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthority.html">CreateCertificateAuthority</a>.
        /// This must be of the form:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm-pca:<i>region</i>:<i>account</i>:certificate-authority/<i>12345678-1234-1234-1234-123456789012</i>
        /// </code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=200)]
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
        /// Gets and sets the property Csr. 
        /// <para>
        /// The certificate signing request (CSR) for the certificate you want to issue. As an
        /// example, you can use the following OpenSSL command to create the CSR and a 2048 bit
        /// RSA private key. 
        /// </para>
        ///  
        /// <para>
        ///  <code>openssl req -new -newkey rsa:2048 -days 365 -keyout private/test_cert_priv_key.pem
        /// -out csr/test_cert_.csr</code> 
        /// </para>
        ///  
        /// <para>
        /// If you have a configuration file, you can then use the following OpenSSL command.
        /// The <code>usr_cert</code> block in the configuration file contains your X509 version
        /// 3 extensions. 
        /// </para>
        ///  
        /// <para>
        ///  <code>openssl req -new -config openssl_rsa.cnf -extensions usr_cert -newkey rsa:2048
        /// -days 365 -keyout private/test_cert_priv_key.pem -out csr/test_cert_.csr</code> 
        /// </para>
        ///  
        /// <para>
        /// Note: A CSR must provide either a <i>subject name</i> or a <i>subject alternative
        /// name</i> or the request will be rejected. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32768)]
        public MemoryStream Csr
        {
            get { return this._csr; }
            set { this._csr = value; }
        }

        // Check to see if Csr property is set
        internal bool IsSetCsr()
        {
            return this._csr != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// Alphanumeric string that can be used to distinguish between calls to the <b>IssueCertificate</b>
        /// action. Idempotency tokens for <b>IssueCertificate</b> time out after one minute.
        /// Therefore, if you call <b>IssueCertificate</b> multiple times with the same idempotency
        /// token within one minute, Amazon Web Services Private CA recognizes that you are requesting
        /// only one certificate and will issue only one. If you change the idempotency token
        /// for each call, Amazon Web Services Private CA recognizes that you are requesting multiple
        /// certificates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
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
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// The name of the algorithm that will be used to sign the certificate to be issued.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This parameter should not be confused with the <code>SigningAlgorithm</code> parameter
        /// used to sign a CSR in the <code>CreateCertificateAuthority</code> action.
        /// </para>
        ///  <note> 
        /// <para>
        /// The specified signing algorithm family (RSA or ECDSA) much match the algorithm family
        /// of the CA's secret key.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public SigningAlgorithm SigningAlgorithm
        {
            get { return this._signingAlgorithm; }
            set { this._signingAlgorithm = value; }
        }

        // Check to see if SigningAlgorithm property is set
        internal bool IsSetSigningAlgorithm()
        {
            return this._signingAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// Specifies a custom configuration template to use when issuing a certificate. If this
        /// parameter is not provided, Amazon Web Services Private CA defaults to the <code>EndEntityCertificate/V1</code>
        /// template. For CA certificates, you should choose the shortest path length that meets
        /// your needs. The path length is indicated by the PathLen<i>N</i> portion of the ARN,
        /// where <i>N</i> is the <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PcaTerms.html#terms-cadepth">CA
        /// depth</a>.
        /// </para>
        ///  
        /// <para>
        /// Note: The CA depth configured on a subordinate CA certificate must not exceed the
        /// limit set by its parents in the CA hierarchy.
        /// </para>
        ///  
        /// <para>
        /// For a list of <code>TemplateArn</code> values supported by Amazon Web Services Private
        /// CA, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/UsingTemplates.html">Understanding
        /// Certificate Templates</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=200)]
        public string TemplateArn
        {
            get { return this._templateArn; }
            set { this._templateArn = value; }
        }

        // Check to see if TemplateArn property is set
        internal bool IsSetTemplateArn()
        {
            return this._templateArn != null;
        }

        /// <summary>
        /// Gets and sets the property Validity. 
        /// <para>
        /// Information describing the end of the validity period of the certificate. This parameter
        /// sets the “Not After” date for the certificate.
        /// </para>
        ///  
        /// <para>
        /// Certificate validity is the period of time during which a certificate is valid. Validity
        /// can be expressed as an explicit date and time when the certificate expires, or as
        /// a span of time after issuance, stated in days, months, or years. For more information,
        /// see <a href="https://datatracker.ietf.org/doc/html/rfc5280#section-4.1.2.5">Validity</a>
        /// in RFC 5280. 
        /// </para>
        ///  
        /// <para>
        /// This value is unaffected when <code>ValidityNotBefore</code> is also specified. For
        /// example, if <code>Validity</code> is set to 20 days in the future, the certificate
        /// will expire 20 days from issuance time regardless of the <code>ValidityNotBefore</code>
        /// value.
        /// </para>
        ///  
        /// <para>
        /// The end of the validity period configured on a certificate must not exceed the limit
        /// set on its parents in the CA hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Validity Validity
        {
            get { return this._validity; }
            set { this._validity = value; }
        }

        // Check to see if Validity property is set
        internal bool IsSetValidity()
        {
            return this._validity != null;
        }

        /// <summary>
        /// Gets and sets the property ValidityNotBefore. 
        /// <para>
        /// Information describing the start of the validity period of the certificate. This parameter
        /// sets the “Not Before" date for the certificate.
        /// </para>
        ///  
        /// <para>
        /// By default, when issuing a certificate, Amazon Web Services Private CA sets the "Not
        /// Before" date to the issuance time minus 60 minutes. This compensates for clock inconsistencies
        /// across computer systems. The <code>ValidityNotBefore</code> parameter can be used
        /// to customize the “Not Before” value. 
        /// </para>
        ///  
        /// <para>
        /// Unlike the <code>Validity</code> parameter, the <code>ValidityNotBefore</code> parameter
        /// is optional.
        /// </para>
        ///  
        /// <para>
        /// The <code>ValidityNotBefore</code> value is expressed as an explicit date and time,
        /// using the <code>Validity</code> type value <code>ABSOLUTE</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/acm-pca/latest/APIReference/API_Validity.html">Validity</a>
        /// in this API reference and <a href="https://datatracker.ietf.org/doc/html/rfc5280#section-4.1.2.5">Validity</a>
        /// in RFC 5280.
        /// </para>
        /// </summary>
        public Validity ValidityNotBefore
        {
            get { return this._validityNotBefore; }
            set { this._validityNotBefore = value; }
        }

        // Check to see if ValidityNotBefore property is set
        internal bool IsSetValidityNotBefore()
        {
            return this._validityNotBefore != null;
        }

    }
}