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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
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
    /// You must specify only one of the following values: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ViewerCertificate$ACMCertificateArn</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ViewerCertificate$IAMCertificateId</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ViewerCertificate$CloudFrontDefaultCertificate</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Don't specify <code>false</code> for <code>CloudFrontDefaultCertificate</code>.
    /// </para>
    ///  
    /// <para>
    ///  <b>If you want viewers to use HTTP instead of HTTPS to request your objects</b>:
    /// Specify the following value:
    /// </para>
    ///  
    /// <para>
    ///  <code>&lt;CloudFrontDefaultCertificate&gt;true&lt;CloudFrontDefaultCertificate&gt;</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// In addition, specify <code>allow-all</code> for <code>ViewerProtocolPolicy</code>
    /// for all of your cache behaviors.
    /// </para>
    ///  
    /// <para>
    ///  <b>If you want viewers to use HTTPS to request your objects</b>: Choose the type
    /// of certificate that you want to use based on whether you're using an alternate domain
    /// name for your objects or the CloudFront domain name:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>If you're using an alternate domain name, such as example.com</b>: Specify one
    /// of the following values, depending on whether ACM provided your certificate or you
    /// purchased your certificate from third-party certificate authority:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>&lt;ACMCertificateArn&gt;<i>ARN for ACM SSL/TLS certificate</i>&lt;ACMCertificateArn&gt;</code>
    /// where <code> <i>ARN for ACM SSL/TLS certificate</i> </code> is the ARN for the ACM
    /// SSL/TLS certificate that you want to use for this distribution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>&lt;IAMCertificateId&gt;<i>IAM certificate ID</i>&lt;IAMCertificateId&gt;</code>
    /// where <code> <i>IAM certificate ID</i> </code> is the ID that IAM returned when you
    /// added the certificate to the IAM certificate store.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you specify <code>ACMCertificateArn</code> or <code>IAMCertificateId</code>, you
    /// must also specify a value for <code>SSLSupportMethod</code>.
    /// </para>
    ///  
    /// <para>
    /// If you choose to use an ACM certificate or a certificate in the IAM certificate store,
    /// we recommend that you use only an alternate domain name in your object URLs (<code>https://example.com/logo.jpg</code>).
    /// If you use the domain name that is associated with your CloudFront distribution (such
    /// as <code>https://d111111abcdef8.cloudfront.net/logo.jpg</code>) and the viewer supports
    /// <code>SNI</code>, then CloudFront behaves normally. However, if the browser does not
    /// support SNI, the user's experience depends on the value that you choose for <code>SSLSupportMethod</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>vip</code>: The viewer displays a warning because there is a mismatch between
    /// the CloudFront domain name and the domain name in your SSL/TLS certificate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>sni-only</code>: CloudFront drops the connection with the browser without returning
    /// the object.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>If you're using the CloudFront domain name for your distribution, such as <code>d111111abcdef8.cloudfront.net</code>
    /// </b>: Specify the following value:
    /// </para>
    ///  
    /// <para>
    ///  <code>&lt;CloudFrontDefaultCertificate&gt;true&lt;CloudFrontDefaultCertificate&gt;
    /// </code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you want viewers to use HTTPS, you must also specify one of the following values
    /// in your cache behaviors:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code> &lt;ViewerProtocolPolicy&gt;https-only&lt;ViewerProtocolPolicy&gt;</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>&lt;ViewerProtocolPolicy&gt;redirect-to-https&lt;ViewerProtocolPolicy&gt;</code>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can also optionally require that CloudFront use HTTPS to communicate with your
    /// origin by specifying one of the following values for the applicable origins:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>&lt;OriginProtocolPolicy&gt;https-only&lt;OriginProtocolPolicy&gt; </code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>&lt;OriginProtocolPolicy&gt;match-viewer&lt;OriginProtocolPolicy&gt; </code>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/SecureConnections.html#CNAMEsAndHTTPS">Using
    /// Alternate Domain Names and HTTPS</a> in the <i>Amazon CloudFront Developer Guide</i>.
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
        /// For information about how and when to use <code>ACMCertificateArn</code>, see <a>ViewerCertificate</a>.
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
        /// This field has been deprecated. Use one of the following fields instead:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ViewerCertificate$ACMCertificateArn</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ViewerCertificate$IAMCertificateId</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ViewerCertificate$CloudFrontDefaultCertificate</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// This field has been deprecated. Use one of the following fields instead:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ViewerCertificate$ACMCertificateArn</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ViewerCertificate$IAMCertificateId</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ViewerCertificate$CloudFrontDefaultCertificate</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// For information about how and when to use <code>CloudFrontDefaultCertificate</code>,
        /// see <a>ViewerCertificate</a>.
        /// </para>
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
        /// For information about how and when to use <code>IAMCertificateId</code>, see <a>ViewerCertificate</a>.
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
        /// <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/secure-connections-supported-viewer-protocols-ciphers.html#secure-connections-supported-ciphers">
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
        /// If you specify a value for <a>ViewerCertificate$ACMCertificateArn</a> or for <a>ViewerCertificate$IAMCertificateId</a>,
        /// you must also specify how you want CloudFront to serve HTTPS requests: using a method
        /// that works for all clients or one that works for most clients:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>vip</code>: CloudFront uses dedicated IP addresses for your content and can
        /// respond to HTTPS requests from any viewer. However, you will incur additional monthly
        /// charges.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sni-only</code>: CloudFront can respond to HTTPS requests from viewers that
        /// support Server Name Indication (SNI). All modern browsers support SNI, but some browsers
        /// still in use don't support SNI. If some of your users' browsers don't support SNI,
        /// we recommend that you do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <code>vip</code> option (dedicated IP addresses) instead of <code>sni-only</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the CloudFront SSL/TLS certificate instead of a custom certificate. This requires
        /// that you use the CloudFront domain name of your distribution in the URLs for your
        /// objects, for example, <code>https://d111111abcdef8.cloudfront.net/logo.png</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you can control which browser your users use, upgrade the browser to one that supports
        /// SNI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use HTTP instead of HTTPS.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// Don't specify a value for <code>SSLSupportMethod</code> if you specified <code>&lt;CloudFrontDefaultCertificate&gt;true&lt;CloudFrontDefaultCertificate&gt;</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/SecureConnections.html#CNAMEsAndHTTPS.html">Using
        /// Alternate Domain Names and HTTPS</a> in the <i>Amazon CloudFront Developer Guide</i>.
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