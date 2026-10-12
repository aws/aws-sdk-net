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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The configuration for a custom domain, including the SSL certificate and TLS security
    /// policy.
    /// </summary>
    public partial class CustomDomainConfigType
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Certificate Manager SSL certificate. You use
        /// this certificate for the subdomain of your custom domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property SecurityPolicy. 
        /// <para>
        /// The security policy for the custom domain. Defines the minimum TLS version and cipher
        /// suites that Amazon CloudFront supports when communicating with clients. For specific
        /// guidance, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/secure-connections-supported-viewer-protocols-ciphers.html">Supported
        /// protocols and ciphers between viewers and CloudFront</a>. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TLS_V1_3_2025</c> (strictest): A post-quantum-ready policy requiring TLS 1.3.
        /// It provides the strongest security posture and is ideal for workloads where all clients
        /// and browsers are updated to the latest versions. <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/secure-connections-supported-viewer-protocols-ciphers.html">Supported
        /// protocols and ciphers for TLSv1.3_2025</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TLS_V1_2_2021</c> (recommended): A post-quantum-ready policy which prefers TLS
        /// 1.3 but allows fallback to TLS 1.2 to accommodate older clients. It is the recommended
        /// minimum for typical commercial-grade consumer applications. <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/secure-connections-supported-viewer-protocols-ciphers.html">Supported
        /// protocols and ciphers for TLSv1.2_2021</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TLS_V1</c> (strongly discouraged): Permits fallback to TLS 1.0. It offers the
        /// broadest compatibility, including support for legacy clients that are more than a
        /// decade old. This compatibility comes at the expense of allowing TLS versions and cryptographic
        /// algorithms that are no longer considered safe for commercial use. <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/secure-connections-supported-viewer-protocols-ciphers.html">Supported
        /// protocols and ciphers for TLSv1</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SecurityPolicyType SecurityPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SecurityPolicy property is set.
        /// </summary>
        internal bool IsSetSecurityPolicy() => this.SecurityPolicy != null;
    }
}
