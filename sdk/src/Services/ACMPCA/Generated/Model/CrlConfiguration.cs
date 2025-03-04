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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Contains configuration information for a certificate revocation list (CRL). Your private
    /// certificate authority (CA) creates base CRLs. Delta CRLs are not supported. You can
    /// enable CRLs for your new or an existing private CA by setting the <b>Enabled</b> parameter
    /// to <c>true</c>. Your private CA writes CRLs to an S3 bucket that you specify in the
    /// <b>S3BucketName</b> parameter. You can hide the name of your bucket by specifying
    /// a value for the <b>CustomCname</b> parameter. Your private CA by default copies the
    /// CNAME or the S3 bucket name to the <b>CRL Distribution Points</b> extension of each
    /// certificate it issues. If you want to configure this default behavior to be something
    /// different, you can set the <b>CrlDistributionPointExtensionConfiguration</b> parameter.
    /// Your S3 bucket policy must give write permission to Amazon Web Services Private CA.
    /// 
    /// 
    ///  
    /// <para>
    /// Amazon Web Services Private CA assets that are stored in Amazon S3 can be protected
    /// with encryption. For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/crl-planning.html#crl-encryption">Encrypting
    /// Your CRLs</a>.
    /// </para>
    ///  
    /// <para>
    /// Your private CA uses the value in the <b>ExpirationInDays</b> parameter to calculate
    /// the <b>nextUpdate</b> field in the CRL. The CRL is refreshed prior to a certificate's
    /// expiration date or when a certificate is revoked. When a certificate is revoked, it
    /// appears in the CRL until the certificate expires, and then in one additional CRL after
    /// expiration, and it always appears in the audit report.
    /// </para>
    ///  
    /// <para>
    /// A CRL is typically updated approximately 30 minutes after a certificate is revoked.
    /// If for any reason a CRL update fails, Amazon Web Services Private CA makes further
    /// attempts every 15 minutes.
    /// </para>
    ///  
    /// <para>
    /// CRLs contain the following fields:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Version</b>: The current version number defined in RFC 5280 is V2. The integer
    /// value is 0x1. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Signature Algorithm</b>: The name of the algorithm used to sign the CRL.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Issuer</b>: The X.500 distinguished name of your private CA that issued the CRL.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Last Update</b>: The issue date and time of this CRL.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Next Update</b>: The day and time by which the next CRL will be issued.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Revoked Certificates</b>: List of revoked certificates. Each list item contains
    /// the following information.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Serial Number</b>: The serial number, in hexadecimal format, of the revoked certificate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Revocation Date</b>: Date and time the certificate was revoked.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>CRL Entry Extensions</b>: Optional extensions for the CRL entry.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>X509v3 CRL Reason Code</b>: Reason the certificate was revoked.
    /// </para>
    ///  </li> </ul> </li> </ul> </li> <li> 
    /// <para>
    ///  <b>CRL Extensions</b>: Optional extensions for the CRL.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>X509v3 Authority Key Identifier</b>: Identifies the public key associated with
    /// the private key used to sign the certificate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>X509v3 CRL Number:</b>: Decimal sequence number for the CRL.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Signature Algorithm</b>: Algorithm used by your private CA to sign the CRL.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Signature Value</b>: Signature computed over the CRL.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Certificate revocation lists created by Amazon Web Services Private CA are DER-encoded.
    /// You can use the following OpenSSL command to list a CRL.
    /// </para>
    ///  
    /// <para>
    ///  <c>openssl crl -inform DER -text -in <i>crl_path</i> -noout</c> 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/crl-planning.html">Planning
    /// a certificate revocation list (CRL)</a> in the <i>Amazon Web Services Private Certificate
    /// Authority User Guide</i> 
    /// </para>
    /// </summary>
    public partial class CrlConfiguration
    {
        private CrlDistributionPointExtensionConfiguration _crlDistributionPointExtensionConfiguration;
        private CrlType _crlType;
        private string _customCname;
        private string _customPath;
        private bool? _enabled;
        private int? _expirationInDays;
        private string _s3BucketName;
        private S3ObjectAcl _s3ObjectAcl;

        /// <summary>
        /// Gets and sets the property CrlDistributionPointExtensionConfiguration. 
        /// <para>
        /// Configures the behavior of the CRL Distribution Point extension for certificates issued
        /// by your certificate authority. If this field is not provided, then the CRl Distribution
        /// Point Extension will be present and contain the default CRL URL.
        /// </para>
        /// </summary>
        public CrlDistributionPointExtensionConfiguration CrlDistributionPointExtensionConfiguration
        {
            get { return this._crlDistributionPointExtensionConfiguration; }
            set { this._crlDistributionPointExtensionConfiguration = value; }
        }

        // Check to see if CrlDistributionPointExtensionConfiguration property is set
        internal bool IsSetCrlDistributionPointExtensionConfiguration()
        {
            return this._crlDistributionPointExtensionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CrlType. 
        /// <para>
        /// Specifies whether to create a complete or partitioned CRL. This setting determines
        /// the maximum number of certificates that the certificate authority can issue and revoke.
        /// For more information, see <a href="privateca/latest/userguide/pca.html#limits_pca">Amazon
        /// Web Services Private CA quotas</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPLETE</c> - The default setting. Amazon Web Services Private CA maintains a
        /// single CRL ﬁle for all unexpired certiﬁcates issued by a CA that have been revoked
        /// for any reason. Each certiﬁcate that Amazon Web Services Private CA issues is bound
        /// to a speciﬁc CRL through its CRL distribution point (CDP) extension, deﬁned in <a
        /// href="https://datatracker.ietf.org/doc/html/rfc5280#section-4.2.1.9"> RFC 5280</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARTITIONED</c> - Compared to complete CRLs, partitioned CRLs dramatically increase
        /// the number of certiﬁcates your private CA can issue. 
        /// </para>
        ///  <important> 
        /// <para>
        ///  When using partitioned CRLs, you must validate that the CRL's associated issuing
        /// distribution point (IDP) URI matches the certiﬁcate's CDP URI to ensure the right
        /// CRL has been fetched. Amazon Web Services Private CA marks the IDP extension as critical,
        /// which your client must be able to process. 
        /// </para>
        ///  </important> </li> </ul>
        /// </summary>
        public CrlType CrlType
        {
            get { return this._crlType; }
            set { this._crlType = value; }
        }

        // Check to see if CrlType property is set
        internal bool IsSetCrlType()
        {
            return this._crlType != null;
        }

        /// <summary>
        /// Gets and sets the property CustomCname. 
        /// <para>
        /// Name inserted into the certificate <b>CRL Distribution Points</b> extension that enables
        /// the use of an alias for the CRL distribution point. Use this value if you don't want
        /// the name of your S3 bucket to be public.
        /// </para>
        ///  <note> 
        /// <para>
        /// The content of a Canonical Name (CNAME) record must conform to <a href="https://www.ietf.org/rfc/rfc2396.txt">RFC2396</a>
        /// restrictions on the use of special characters in URIs. Additionally, the value of
        /// the CNAME must not include a protocol prefix such as "http://" or "https://".
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=253)]
        public string CustomCname
        {
            get { return this._customCname; }
            set { this._customCname = value; }
        }

        // Check to see if CustomCname property is set
        internal bool IsSetCustomCname()
        {
            return this._customCname != null;
        }

        /// <summary>
        /// Gets and sets the property CustomPath. 
        /// <para>
        /// Designates a custom ﬁle path in S3 for CRL(s). For example, <c>http://&lt;CustomName&gt;/
        /// &lt;CustomPath&gt;/&lt;CrlPartition_GUID&gt;.crl</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=253)]
        public string CustomPath
        {
            get { return this._customPath; }
            set { this._customPath = value; }
        }

        // Check to see if CustomPath property is set
        internal bool IsSetCustomPath()
        {
            return this._customPath != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Boolean value that specifies whether certificate revocation lists (CRLs) are enabled.
        /// You can use this value to enable certificate revocation for a new CA when you call
        /// the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthority.html">CreateCertificateAuthority</a>
        /// action or for an existing CA when you call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_UpdateCertificateAuthority.html">UpdateCertificateAuthority</a>
        /// action. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpirationInDays. 
        /// <para>
        /// Validity period of the CRL in days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public int? ExpirationInDays
        {
            get { return this._expirationInDays; }
            set { this._expirationInDays = value; }
        }

        // Check to see if ExpirationInDays property is set
        internal bool IsSetExpirationInDays()
        {
            return this._expirationInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// Name of the S3 bucket that contains the CRL. If you do not provide a value for the
        /// <b>CustomCname</b> argument, the name of your S3 bucket is placed into the <b>CRL
        /// Distribution Points</b> extension of the issued certificate. You can change the name
        /// of your bucket by calling the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_UpdateCertificateAuthority.html">UpdateCertificateAuthority</a>
        /// operation. You must specify a <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PcaCreateCa.html#s3-policies">bucket
        /// policy</a> that allows Amazon Web Services Private CA to write the CRL to your bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>S3BucketName</c> parameter must conform to the <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucketnamingrules.html">S3
        /// bucket naming rules</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property S3ObjectAcl. 
        /// <para>
        /// Determines whether the CRL will be publicly readable or privately held in the CRL
        /// Amazon S3 bucket. If you choose PUBLIC_READ, the CRL will be accessible over the public
        /// internet. If you choose BUCKET_OWNER_FULL_CONTROL, only the owner of the CRL S3 bucket
        /// can access the CRL, and your PKI clients may need an alternative method of access.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If no value is specified, the default is <c>PUBLIC_READ</c>.
        /// </para>
        ///  
        /// <para>
        ///  <i>Note:</i> This default can cause CA creation to fail in some circumstances. If
        /// you have have enabled the Block Public Access (BPA) feature in your S3 account, then
        /// you must specify the value of this parameter as <c>BUCKET_OWNER_FULL_CONTROL</c>,
        /// and not doing so results in an error. If you have disabled BPA in S3, then you can
        /// specify either <c>BUCKET_OWNER_FULL_CONTROL</c> or <c>PUBLIC_READ</c> as the value.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PcaCreateCa.html#s3-bpa">Blocking
        /// public access to the S3 bucket</a>.
        /// </para>
        /// </summary>
        public S3ObjectAcl S3ObjectAcl
        {
            get { return this._s3ObjectAcl; }
            set { this._s3ObjectAcl = value; }
        }

        // Check to see if S3ObjectAcl property is set
        internal bool IsSetS3ObjectAcl()
        {
            return this._s3ObjectAcl != null;
        }

    }
}