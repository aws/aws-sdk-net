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
 * Do not modify this file. This file is generated from the cloudfront-2016-09-29.normal.json service model.
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
    /// Which SSL/TLS certificate to use when viewers request objects using HTTPS
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Whether you want CloudFront to use dedicated IP addresses or SNI when you're using
    /// alternate domain names in your object names
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The minimum protocol version that you want CloudFront to use when communicating with
    /// viewers
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/SecureConnections.html">Using
    /// an HTTPS Connection to Access Your Objects</a> in the <i>Amazon Amazon CloudFront
    /// Developer Guide</i>.
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
        /// domain name in your object URLs (for example, <code>https://example.com/logo.jpg)</code>,
        /// specify the ACM certificate ARN of the custom viewer certificate for this distribution.
        /// Specify either this value, <code>IAMCertificateId</code>, or <code>CloudFrontDefaultCertificate</code>.
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
        /// Include one of these values to specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether you want viewers to use HTTP or HTTPS to request your objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you want viewers to use HTTPS, whether you're using an alternate domain name such
        /// as example.com or the CloudFront domain name for your distribution, such as <code>d111111abcdef8.cloudfront.net</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you're using an alternate domain name, whether AWS Certificate Manager (ACM) provided
        /// the certificate, or you purchased a certificate from a third-party certificate authority
        /// and imported it into ACM or uploaded it to the IAM certificate store.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must specify one (and only one) of the three values. Do not specify <code>false</code>
        /// for <code>CloudFrontDefaultCertificate</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>If you want viewers to use HTTP to request your objects</b>: Specify the following
        /// value:
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
        ///  <code>&lt;ACMCertificateArn&gt;ARN for ACM SSL/TLS certificate&lt;ACMCertificateArn&gt;</code>
        /// where ARN for ACM SSL/TLS certificate is the ARN for the ACM SSL/TLS certificate that
        /// you want to use for this distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>&lt;IAMCertificateId&gt;IAM certificate ID&lt;IAMCertificateId&gt;</code> where
        /// IAM certificate ID is the ID that IAM returned when you added the certificate to the
        /// IAM certificate store.
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
        /// If you use the domain name that is associated with your CloudFront distribution (<code>https://d111111abcdef8.cloudfront.net/logo.jpg</code>)
        /// and the viewer supports <code>SNI</code>, then CloudFront behaves normally. However,
        /// if the browser does not support SNI, the user's experience depends on the value that
        /// you choose for <code>SSLSupportMethod</code>:
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
        ///  <code> &lt;CloudFrontDefaultCertificate&gt;true&lt;CloudFrontDefaultCertificate&gt;
        /// </code> 
        /// </para>
        ///  
        /// <para>
        /// If you want viewers to use HTTPS, you must also specify one of the following values
        /// in your cache behaviors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code> &lt;ViewerProtocolPolicy&gt;https-only&lt;ViewerProtocolPolicy&gt; </code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code> &lt;ViewerProtocolPolicy&gt;redirect-to-https&lt;ViewerProtocolPolicy&gt;
        /// </code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also optionally require that CloudFront use HTTPS to communicate with your
        /// origin by specifying one of the following values for the applicable origins:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code> &lt;OriginProtocolPolicy&gt;https-only&lt;OriginProtocolPolicy&gt; </code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code> &lt;OriginProtocolPolicy&gt;match-viewer&lt;OriginProtocolPolicy&gt; </code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/SecureConnections.html#CNAMEsAndHTTPS">Using
        /// Alternate Domain Names and HTTPS</a> in the <i>Amazon CloudFront Developer Guide</i>.
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
        /// Gets and sets the property CertificateSource. <note> 
        /// <para>
        /// This field is deprecated. You can use one of the following: <code>[ACMCertificateArn</code>,
        /// <code>IAMCertificateId</code>, or <code>CloudFrontDefaultCertificate]</code>.
        /// </para>
        ///  </note>
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
        /// If you want viewers to use HTTPS to request your objects and you're using the CloudFront
        /// domain name of your distribution in your object URLs (for example, <code>https://d111111abcdef8.cloudfront.net/logo.jpg</code>),
        /// set to <code>true</code>. Omit this value if you are setting an <code>ACMCertificateArn</code>
        /// or <code>IAMCertificateId</code>.
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
        /// If you want viewers to use HTTPS to request your objects and you're using an alternate
        /// domain name in your object URLs (for example, <code>https://example.com/logo.jpg)</code>,
        /// specify the IAM certificate identifier of the custom viewer certificate for this distribution.
        /// Specify either this value, <code>ACMCertificateArn</code>, or <code>CloudFrontDefaultCertificate</code>.
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
        /// Specify the minimum version of the SSL/TLS protocol that you want CloudFront to use
        /// for HTTPS connections between viewers and CloudFront: <code>SSLv3</code> or <code>TLSv1</code>.
        /// CloudFront serves your objects only to viewers that support SSL/TLS version that you
        /// specify and later versions. The <code>TLSv1</code> protocol is more secure, so we
        /// recommend that you specify <code>SSLv3</code> only if your users are using browsers
        /// or devices that don't support <code>TLSv1</code>. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify &lt;CloudFrontDefaultCertificate&gt;true&lt;CloudFrontDefaultCertificate&gt;,
        /// the minimum SSL protocol version is <code>TLSv1</code> and can't be changed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you're using a custom certificate (if you specify a value for <code>ACMCertificateArn</code>
        /// or for <code>IAMCertificateId</code>) and if you're using SNI (if you specify <code>sni-only</code>
        /// for <code>SSLSupportMethod</code>), you must specify <code>TLSv1</code> for <code>MinimumProtocolVersion</code>.
        /// </para>
        ///  </li> </ul>
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
        /// If you specify a value for <code>ACMCertificateArn</code> or for <code>IAMCertificateId</code>,
        /// you must also specify how you want CloudFront to serve HTTPS requests: using a method
        /// that works for all clients or one that works for most clients:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>vip</code>: CloudFront uses dedicated IP addresses for your content and can
        /// respond to HTTPS requests from any viewer. However, you must request permission to
        /// use this feature, and you incur additional monthly charges.
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
        /// Do not specify a value for <code>SSLSupportMethod</code> if you specified <code>&lt;CloudFrontDefaultCertificate&gt;true&lt;CloudFrontDefaultCertificate&gt;</code>.
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