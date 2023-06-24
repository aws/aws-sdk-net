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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that determines the distribution's SSL/TLS configuration for communicating
    /// with viewers.
    /// 
    ///  
    /// <para>
    /// If the distribution doesn't use <code>Aliases</code> (also known as alternate domain
    /// names or CNAMEs)—that is, if the distribution uses the CloudFront domain name such
    /// as <code>d111111abcdef8.cloudfront.net</code>—set <code>CloudFrontDefaultCertificate</code>
    /// to <code>true</code> and leave all other fields empty.
    /// </para>
    ///  
    /// <para>
    /// If the distribution uses <code>Aliases</code> (alternate domain names or CNAMEs),
    /// use the fields in this type to specify the following settings:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Which viewers the distribution accepts HTTPS connections from: only viewers that support
    /// <a href="https://en.wikipedia.org/wiki/Server_Name_Indication">server name indication
    /// (SNI)</a> (recommended), or all viewers including those that don't support SNI.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To accept HTTPS connections from only viewers that support SNI, set <code>SSLSupportMethod</code>
    /// to <code>sni-only</code>. This is recommended. Most browsers and clients support SNI.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To accept HTTPS connections from all viewers, including those that don't support SNI,
    /// set <code>SSLSupportMethod</code> to <code>vip</code>. This is not recommended, and
    /// results in additional monthly charges from CloudFront.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// The minimum SSL/TLS protocol version that the distribution can use to communicate
    /// with viewers. To specify a minimum version, choose a value for <code>MinimumProtocolVersion</code>.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValues-security-policy">Security
    /// Policy</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The location of the SSL/TLS certificate, <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-overview.html">Certificate
    /// Manager (ACM)</a> (recommended) or <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Identity
    /// and Access Management (IAM)</a>. You specify the location by setting a value in one
    /// of the following fields (not both):
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>ACMCertificateArn</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>IAMCertificateId</code> 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// All distributions support HTTPS connections from viewers. To require viewers to use
    /// HTTPS only, or to redirect them from HTTP to HTTPS, use <code>ViewerProtocolPolicy</code>
    /// in the <code>CacheBehavior</code> or <code>DefaultCacheBehavior</code>. To specify
    /// how CloudFront should use SSL/TLS to communicate with your custom origin, use <code>CustomOriginConfig</code>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/using-https.html">Using
    /// HTTPS with CloudFront</a> and <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/using-https-alternate-domain-names.html">
    /// Using Alternate Domain Names and HTTPS</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ViewerCertificate
    {
        private string _acmCertificateArn;
        private string _certificate;
        private CertificateSource _certificateSource;
        private bool? _cloudFrontDefaultCertificate;
        private string _iamCertificateId;
        private MinimumProtocolVersion _minimumProtocolVersion;
        private SSLSupportMethod _sslSupportMethod;

        /// <summary>
        /// Gets and sets the property ACMCertificateArn. 
        /// <para>
        /// If the distribution uses <code>Aliases</code> (alternate domain names or CNAMEs) and
        /// the SSL/TLS certificate is stored in <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-overview.html">Certificate
        /// Manager (ACM)</a>, provide the Amazon Resource Name (ARN) of the ACM certificate.
        /// CloudFront only supports ACM certificates in the US East (N. Virginia) Region (<code>us-east-1</code>).
        /// </para>
        ///  
        /// <para>
        /// If you specify an ACM certificate ARN, you must also specify values for <code>MinimumProtocolVersion</code>
        /// and <code>SSLSupportMethod</code>.
        /// </para>
        /// </summary>
        public string ACMCertificateArn
        {
            get { return this._acmCertificateArn; }
            set { this._acmCertificateArn = value; }
        }

        // Check to see if ACMCertificateArn property is set
        internal bool IsSetACMCertificateArn()
        {
            return this._acmCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// This field is deprecated. Use one of the following fields instead:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACMCertificateArn</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IAMCertificateId</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CloudFrontDefaultCertificate</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [Obsolete("This field has been deprecated. Use one of the following fields instead: ACMCertificateArn, IAMCertificateId or CloudFrontDefaultCertificate.")]
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateSource. 
        /// <para>
        /// This field is deprecated. Use one of the following fields instead:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACMCertificateArn</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IAMCertificateId</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CloudFrontDefaultCertificate</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [Obsolete("This field has been deprecated. Use one of the following fields instead: ACMCertificateArn, IAMCertificateId or CloudFrontDefaultCertificate.")]
        public CertificateSource CertificateSource
        {
            get { return this._certificateSource; }
            set { this._certificateSource = value; }
        }

        // Check to see if CertificateSource property is set
        internal bool IsSetCertificateSource()
        {
            return this._certificateSource != null;
        }

        /// <summary>
        /// Gets and sets the property CloudFrontDefaultCertificate. 
        /// <para>
        /// If the distribution uses the CloudFront domain name such as <code>d111111abcdef8.cloudfront.net</code>,
        /// set this field to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// If the distribution uses <code>Aliases</code> (alternate domain names or CNAMEs),
        /// set this field to <code>false</code> and specify values for the following fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACMCertificateArn</code> or <code>IAMCertificateId</code> (specify a value
        /// for one, not both)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MinimumProtocolVersion</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SSLSupportMethod</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool CloudFrontDefaultCertificate
        {
            get { return this._cloudFrontDefaultCertificate.GetValueOrDefault(); }
            set { this._cloudFrontDefaultCertificate = value; }
        }

        // Check to see if CloudFrontDefaultCertificate property is set
        internal bool IsSetCloudFrontDefaultCertificate()
        {
            return this._cloudFrontDefaultCertificate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IAMCertificateId. 
        /// <para>
        /// If the distribution uses <code>Aliases</code> (alternate domain names or CNAMEs) and
        /// the SSL/TLS certificate is stored in <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Identity
        /// and Access Management (IAM)</a>, provide the ID of the IAM certificate.
        /// </para>
        ///  
        /// <para>
        /// If you specify an IAM certificate ID, you must also specify values for <code>MinimumProtocolVersion</code>
        /// and <code>SSLSupportMethod</code>. 
        /// </para>
        /// </summary>
        public string IAMCertificateId
        {
            get { return this._iamCertificateId; }
            set { this._iamCertificateId = value; }
        }

        // Check to see if IAMCertificateId property is set
        internal bool IsSetIAMCertificateId()
        {
            return this._iamCertificateId != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumProtocolVersion. 
        /// <para>
        /// If the distribution uses <code>Aliases</code> (alternate domain names or CNAMEs),
        /// specify the security policy that you want CloudFront to use for HTTPS connections
        /// with viewers. The security policy determines two settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The minimum SSL/TLS protocol that CloudFront can use to communicate with viewers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ciphers that CloudFront can use to encrypt the content that it returns to viewers.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValues-security-policy">Security
        /// Policy</a> and <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/secure-connections-supported-viewer-protocols-ciphers.html#secure-connections-supported-ciphers">Supported
        /// Protocols and Ciphers Between Viewers and CloudFront</a> in the <i>Amazon CloudFront
        /// Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// On the CloudFront console, this setting is called <b>Security Policy</b>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you're using SNI only (you set <code>SSLSupportMethod</code> to <code>sni-only</code>),
        /// you must specify <code>TLSv1</code> or higher.
        /// </para>
        ///  
        /// <para>
        /// If the distribution uses the CloudFront domain name such as <code>d111111abcdef8.cloudfront.net</code>
        /// (you set <code>CloudFrontDefaultCertificate</code> to <code>true</code>), CloudFront
        /// automatically sets the security policy to <code>TLSv1</code> regardless of the value
        /// that you set here.
        /// </para>
        /// </summary>
        public MinimumProtocolVersion MinimumProtocolVersion
        {
            get { return this._minimumProtocolVersion; }
            set { this._minimumProtocolVersion = value; }
        }

        // Check to see if MinimumProtocolVersion property is set
        internal bool IsSetMinimumProtocolVersion()
        {
            return this._minimumProtocolVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SSLSupportMethod. 
        /// <para>
        /// If the distribution uses <code>Aliases</code> (alternate domain names or CNAMEs),
        /// specify which viewers the distribution accepts HTTPS connections from.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>sni-only</code> – The distribution accepts HTTPS connections from only viewers
        /// that support <a href="https://en.wikipedia.org/wiki/Server_Name_Indication">server
        /// name indication (SNI)</a>. This is recommended. Most browsers and clients support
        /// SNI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vip</code> – The distribution accepts HTTPS connections from all viewers including
        /// those that don't support SNI. This is not recommended, and results in additional monthly
        /// charges from CloudFront.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>static-ip</code> - Do not specify this value unless your distribution has been
        /// enabled for this feature by the CloudFront team. If you have a use case that requires
        /// static IP addresses for a distribution, contact CloudFront through the <a href="https://console.aws.amazon.com/support/home">Amazon
        /// Web Services Support Center</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the distribution uses the CloudFront domain name such as <code>d111111abcdef8.cloudfront.net</code>,
        /// don't set a value for this field.
        /// </para>
        /// </summary>
        public SSLSupportMethod SSLSupportMethod
        {
            get { return this._sslSupportMethod; }
            set { this._sslSupportMethod = value; }
        }

        // Check to see if SSLSupportMethod property is set
        internal bool IsSetSSLSupportMethod()
        {
            return this._sslSupportMethod != null;
        }

    }
}