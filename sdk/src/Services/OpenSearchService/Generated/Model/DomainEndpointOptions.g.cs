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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Options to configure a custom endpoint for an OpenSearch Service domain.
    /// </summary>
    public partial class DomainEndpointOptions
    {
        /// <summary>
        /// Gets and sets the property CustomEndpoint. 
        /// <para>
        /// The fully qualified URL for the custom endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CustomEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the CustomEndpoint property is set.
        /// </summary>
        internal bool IsSetCustomEndpoint() => this.CustomEndpoint != null;

        /// <summary>
        /// Gets and sets the property CustomEndpointCertificateArn. 
        /// <para>
        /// The ARN for your security certificate, managed in Amazon Web Services Certificate
        /// Manager (ACM).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CustomEndpointCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomEndpointCertificateArn property is set.
        /// </summary>
        internal bool IsSetCustomEndpointCertificateArn() => this.CustomEndpointCertificateArn != null;

        /// <summary>
        /// Gets and sets the property CustomEndpointEnabled. 
        /// <para>
        /// Whether to enable a custom endpoint for the domain.
        /// </para>
        /// </summary>
        public bool? CustomEndpointEnabled { get; set; }

        /// <summary>
        /// Checks to see if the CustomEndpointEnabled property is set.
        /// </summary>
        internal bool IsSetCustomEndpointEnabled() => this.CustomEndpointEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property EnforceHTTPS. 
        /// <para>
        /// True to require that all traffic to the domain arrive over HTTPS.
        /// </para>
        /// </summary>
        public bool? EnforceHTTPS { get; set; }

        /// <summary>
        /// Checks to see if the EnforceHTTPS property is set.
        /// </summary>
        internal bool IsSetEnforceHTTPS() => this.EnforceHTTPS.HasValue;

        /// <summary>
        /// Gets and sets the property TLSSecurityPolicy. 
        /// <para>
        /// Specify the TLS security policy to apply to the HTTPS endpoint of the domain. The
        /// policy can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Policy-Min-TLS-1-0-2019-07:</b> TLS security policy that supports TLS version
        /// 1.0 to TLS version 1.2
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Policy-Min-TLS-1-2-2019-07:</b> TLS security policy that supports only TLS version
        /// 1.2
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Policy-Min-TLS-1-2-PFS-2023-10:</b> TLS security policy that supports TLS version
        /// 1.2 to TLS version 1.3 with perfect forward secrecy cipher suites
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Policy-Min-TLS-1-2-RFC9151-FIPS-2024-08:</b> TLS security policy that supports
        /// TLS version 1.3 with FIPS
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TLSSecurityPolicy TLSSecurityPolicy { get; set; }

        /// <summary>
        /// Checks to see if the TLSSecurityPolicy property is set.
        /// </summary>
        internal bool IsSetTLSSecurityPolicy() => this.TLSSecurityPolicy != null;
    }
}
