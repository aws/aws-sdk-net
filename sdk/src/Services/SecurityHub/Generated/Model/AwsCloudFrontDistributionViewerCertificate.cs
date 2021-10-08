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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about the TLS/SSL configuration that the distribution uses to
    /// communicate with viewers.
    /// </summary>
    public partial class AwsCloudFrontDistributionViewerCertificate
    {
        private string _acmCertificateArn;
        private string _certificate;
        private string _certificateSource;
        private bool? _cloudFrontDefaultCertificate;
        private string _iamCertificateId;
        private string _minimumProtocolVersion;
        private string _sslSupportMethod;

        /// <summary>
        /// Gets and sets the property AcmCertificateArn. 
        /// <para>
        /// The ARN of the ACM certificate. Used if the certificate is stored in ACM. If you provide
        /// an ACM certificate ARN, you must also provide <code>MinimumCertificateVersion</code>
        /// and <code>SslSupportMethod</code>.
        /// </para>
        /// </summary>
        public string AcmCertificateArn
        {
            get { return this._acmCertificateArn; }
            set { this._acmCertificateArn = value; }
        }

        // Check to see if AcmCertificateArn property is set
        internal bool IsSetAcmCertificateArn()
        {
            return this._acmCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The identifier of the certificate. Note that in CloudFront, this attribute is deprecated.
        /// </para>
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
        /// The source of the certificate identified by <code>Certificate</code>. Note that in
        /// CloudFront, this attribute is deprecated.
        /// </para>
        /// </summary>
        public string CertificateSource
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
        /// Whether the distribution uses the CloudFront domain name. If set to <code>false</code>,
        /// then you provide either <code>AcmCertificateArn</code> or <code>IamCertificateId</code>.
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
        /// Gets and sets the property IamCertificateId. 
        /// <para>
        /// The identifier of the IAM certificate. Used if the certificate is stored in IAM. If
        /// you provide <code>IamCertificateId</code>, then you also must provide <code>MinimumProtocolVersion</code>
        /// and <code>SslSupportMethod</code>.
        /// </para>
        /// </summary>
        public string IamCertificateId
        {
            get { return this._iamCertificateId; }
            set { this._iamCertificateId = value; }
        }

        // Check to see if IamCertificateId property is set
        internal bool IsSetIamCertificateId()
        {
            return this._iamCertificateId != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumProtocolVersion. 
        /// <para>
        /// The security policy that CloudFront uses for HTTPS connections with viewers. If <code>SslSupportMethod</code>
        /// is <code>sni-only</code>, then <code>MinimumProtocolVersion</code> must be <code>TLSv1</code>
        /// or higher.
        /// </para>
        /// </summary>
        public string MinimumProtocolVersion
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
        /// Gets and sets the property SslSupportMethod. 
        /// <para>
        /// The viewers that the distribution accepts HTTPS connections from.
        /// </para>
        /// </summary>
        public string SslSupportMethod
        {
            get { return this._sslSupportMethod; }
            set { this._sslSupportMethod = value; }
        }

        // Check to see if SslSupportMethod property is set
        internal bool IsSetSslSupportMethod()
        {
            return this._sslSupportMethod != null;
        }

    }
}