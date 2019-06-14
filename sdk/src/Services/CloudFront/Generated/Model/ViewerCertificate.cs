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
 * Do not modify this file. This file is generated from the cloudfront-2019-03-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that specifies the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Whether you want viewers to use HTTP or HTTPS to request your objects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you want viewers to use HTTPS, whether you're using an alternate domain name such
    /// as <code>example.com</code> or the CloudFront domain name for your distribution, such
    /// as <code>d111111abcdef8.cloudfront.net</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you're using an alternate domain name, whether AWS Certificate Manager (ACM) provided
    /// the certificate, or you purchased a certificate from a third-party certificate authority
    /// and imported it into ACM or uploaded it to the IAM certificate store.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Specify only one of the following values: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ViewerCertificate.html#cloudfront-Type-ViewerCertificate-ACMCertificateArn">ACMCertificateArn</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ViewerCertificate.html#cloudfront-Type-ViewerCertificate-IAMCertificateId">IAMCertificateId</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ViewerCertificate.html#cloudfront-Type-ViewerCertificate-CloudFrontDefaultCertificate">CloudFrontDefaultCertificate</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/SecureConnections.html#CNAMEsAndHTTPS">
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
        /// If you want viewers to use HTTPS to request your objects and you're using an alternate
        /// domain name, you must choose the type of certificate that you want to use. Specify
        /// the following value if ACM provided your certificate:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>&lt;ACMCertificateArn&gt;<i>ARN for ACM SSL/TLS certificate</i>&lt;ACMCertificateArn&gt;</code>
        /// where <code> <i>ARN for ACM SSL/TLS certificate</i> </code> is the ARN for the ACM
        /// SSL/TLS certificate that you want to use for this distribution.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify <code>ACMCertificateArn</code>, you must also specify a value for <code>SSLSupportMethod</code>.
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
        /// This field is no longer used. Use one of the following fields instead:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ViewerCertificate.html#cloudfront-Type-ViewerCertificate-ACMCertificateArn">ACMCertificateArn</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ViewerCertificate.html#cloudfront-Type-ViewerCertificate-IAMCertificateId">IAMCertificateId</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ViewerCertificate.html#cloudfront-Type-ViewerCertificate-CloudFrontDefaultCertificate">CloudFrontDefaultCertificate</a>
        /// 
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
        /// This field is no longer used. Use one of the following fields instead:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ViewerCertificate.html#cloudfront-Type-ViewerCertificate-ACMCertificateArn">ACMCertificateArn</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ViewerCertificate.html#cloudfront-Type-ViewerCertificate-IAMCertificateId">IAMCertificateId</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ViewerCertificate.html#cloudfront-Type-ViewerCertificate-CloudFrontDefaultCertificate">CloudFrontDefaultCertificate</a>
        /// 
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
        /// If you're using the CloudFront domain name for your distribution, such as <code>d111111abcdef8.cloudfront.net</code>,
        /// specify the following value:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>&lt;CloudFrontDefaultCertificate&gt;true&lt;CloudFrontDefaultCertificate&gt;
        /// </code> 
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
        /// If you want viewers to use HTTPS to request your objects and you're using an alternate
        /// domain name, you must choose the type of certificate that you want to use. Specify
        /// the following value if you purchased your certificate from a third-party certificate
        /// authority:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>&lt;IAMCertificateId&gt;<i>IAM certificate ID</i>&lt;IAMCertificateId&gt;</code>
        /// where <code> <i>IAM certificate ID</i> </code> is the ID that IAM returned when you
        /// added the certificate to the IAM certificate store.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify <code>IAMCertificateId</code>, you must also specify a value for <code>SSLSupportMethod</code>.
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
        /// Specify the security policy that you want CloudFront to use for HTTPS connections.
        /// A security policy determines two settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The minimum SSL/TLS protocol that CloudFront uses to communicate with viewers
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cipher that CloudFront uses to encrypt the content that it returns to viewers
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// On the CloudFront console, this setting is called <b>Security policy</b>.
        /// </para>
        ///  </note> 
        /// <para>
        /// We recommend that you specify <code>TLSv1.1_2016</code> unless your users are using
        /// browsers or devices that do not support TLSv1.1 or later.
        /// </para>
        ///  
        /// <para>
        /// When both of the following are true, you must specify <code>TLSv1</code> or later
        /// for the security policy: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You're using a custom certificate: you specified a value for <code>ACMCertificateArn</code>
        /// or for <code>IAMCertificateId</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You're using SNI: you specified <code>sni-only</code> for <code>SSLSupportMethod</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify <code>true</code> for <code>CloudFrontDefaultCertificate</code>, CloudFront
        /// automatically sets the security policy to <code>TLSv1</code> regardless of the value
        /// that you specify for <code>MinimumProtocolVersion</code>.
        /// </para>
        ///  
        /// <para>
        /// For information about the relationship between the security policy that you choose
        /// and the protocols and ciphers that CloudFront uses to communicate with viewers, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/secure-connections-supported-viewer-protocols-ciphers.html#secure-connections-supported-ciphers">
        /// Supported SSL/TLS Protocols and Ciphers for Communication Between Viewers and CloudFront</a>
        /// in the <i>Amazon CloudFront Developer Guide</i>.
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
        /// If you specify a value for <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ViewerCertificate.html#cloudfront-Type-ViewerCertificate-ACMCertificateArn">ACMCertificateArn</a>
        /// or for <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ViewerCertificate.html#cloudfront-Type-ViewerCertificate-IAMCertificateId">IAMCertificateId</a>,
        /// you must also specify how you want CloudFront to serve HTTPS requests: using a method
        /// that works for browsers and clients released after 2010 or one that works for all
        /// clients.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>sni-only</code>: CloudFront can respond to HTTPS requests from viewers that
        /// support Server Name Indication (SNI). All modern browsers support SNI, but there are
        /// a few that don't. For a current list of the browsers that support SNI, see the <a
        /// href="http://en.wikipedia.org/wiki/Server_Name_Indication">Wikipedia entry Server
        /// Name Indication</a>. To learn about options to explore if you have users with browsers
        /// that don't include SNI support, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cnames-https-dedicated-ip-or-sni.html">Choosing
        /// How CloudFront Serves HTTPS Requests</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vip</code>: CloudFront uses dedicated IP addresses for your content and can
        /// respond to HTTPS requests from any viewer. However, there are additional monthly charges.
        /// For details, including specific pricing information, see <a href="http://aws.amazon.com/cloudfront/custom-ssl-domains/">Custom
        /// SSL options for Amazon CloudFront</a> on the AWS marketing site.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Don't specify a value for <code>SSLSupportMethod</code> if you specified <code>&lt;CloudFrontDefaultCertificate&gt;true&lt;CloudFrontDefaultCertificate&gt;</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cnames-https-dedicated-ip-or-sni.html">Choosing
        /// How CloudFront Serves HTTPS Requests</a> in the <i>Amazon CloudFront Developer Guide</i>.
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