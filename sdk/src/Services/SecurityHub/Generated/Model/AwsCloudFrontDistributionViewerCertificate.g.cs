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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about the TLS/SSL configuration that the CloudFront distribution
    /// uses to communicate with viewers.
    /// </summary>
    public partial class AwsCloudFrontDistributionViewerCertificate
    {
        /// <summary>
        /// Gets and sets the property AcmCertificateArn. 
        /// <para>
        /// The ARN of the ACM certificate. Used if the certificate is stored in ACM. If you provide
        /// an ACM certificate ARN, you must also provide <c>MinimumCertificateVersion</c> and
        /// <c>SslSupportMethod</c>.
        /// </para>
        /// </summary>
        public string AcmCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the AcmCertificateArn property is set.
        /// </summary>
        internal bool IsSetAcmCertificateArn() => this.AcmCertificateArn != null;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The identifier of the certificate. Note that in CloudFront, this attribute is deprecated.
        /// </para>
        /// </summary>
        public string Certificate { get; set; }

        /// <summary>
        /// Checks to see if the Certificate property is set.
        /// </summary>
        internal bool IsSetCertificate() => this.Certificate != null;

        /// <summary>
        /// Gets and sets the property CertificateSource. 
        /// <para>
        /// The source of the certificate identified by <c>Certificate</c>. Note that in CloudFront,
        /// this attribute is deprecated.
        /// </para>
        /// </summary>
        public string CertificateSource { get; set; }

        /// <summary>
        /// Checks to see if the CertificateSource property is set.
        /// </summary>
        internal bool IsSetCertificateSource() => this.CertificateSource != null;

        /// <summary>
        /// Gets and sets the property CloudFrontDefaultCertificate. 
        /// <para>
        /// Whether the distribution uses the CloudFront domain name. If set to <c>false</c>,
        /// then you provide either <c>AcmCertificateArn</c> or <c>IamCertificateId</c>.
        /// </para>
        /// </summary>
        public bool? CloudFrontDefaultCertificate { get; set; }

        /// <summary>
        /// Checks to see if the CloudFrontDefaultCertificate property is set.
        /// </summary>
        internal bool IsSetCloudFrontDefaultCertificate() => this.CloudFrontDefaultCertificate.HasValue;

        /// <summary>
        /// Gets and sets the property IamCertificateId. 
        /// <para>
        /// The identifier of the IAM certificate. Used if the certificate is stored in IAM. If
        /// you provide <c>IamCertificateId</c>, then you also must provide <c>MinimumProtocolVersion</c>
        /// and <c>SslSupportMethod</c>.
        /// </para>
        /// </summary>
        public string IamCertificateId { get; set; }

        /// <summary>
        /// Checks to see if the IamCertificateId property is set.
        /// </summary>
        internal bool IsSetIamCertificateId() => this.IamCertificateId != null;

        /// <summary>
        /// Gets and sets the property MinimumProtocolVersion. 
        /// <para>
        /// The security policy that CloudFront uses for HTTPS connections with viewers. If <c>SslSupportMethod</c>
        /// is <c>sni-only</c>, then <c>MinimumProtocolVersion</c> must be <c>TLSv1</c> or higher.
        /// </para>
        /// </summary>
        public string MinimumProtocolVersion { get; set; }

        /// <summary>
        /// Checks to see if the MinimumProtocolVersion property is set.
        /// </summary>
        internal bool IsSetMinimumProtocolVersion() => this.MinimumProtocolVersion != null;

        /// <summary>
        /// Gets and sets the property SslSupportMethod. 
        /// <para>
        /// The viewers that the distribution accepts HTTPS connections from.
        /// </para>
        /// </summary>
        public string SslSupportMethod { get; set; }

        /// <summary>
        /// Checks to see if the SslSupportMethod property is set.
        /// </summary>
        internal bool IsSetSslSupportMethod() => this.SslSupportMethod != null;
    }
}
