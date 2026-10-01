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
    /// Information about additional options for the domain endpoint.
    /// </summary>
    public partial class AwsOpenSearchServiceDomainDomainEndpointOptionsDetails
    {
        /// <summary>
        /// Gets and sets the property CustomEndpoint. 
        /// <para>
        /// The fully qualified URL for the custom endpoint.
        /// </para>
        /// </summary>
        public string CustomEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the CustomEndpoint property is set.
        /// </summary>
        internal bool IsSetCustomEndpoint() => this.CustomEndpoint != null;

        /// <summary>
        /// Gets and sets the property CustomEndpointCertificateArn. 
        /// <para>
        /// The ARN for the security certificate. The certificate is managed in ACM.
        /// </para>
        /// </summary>
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
        /// Whether to require that all traffic to the domain arrive over HTTPS.
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
        /// The TLS security policy to apply to the HTTPS endpoint of the OpenSearch domain.
        /// </para>
        /// </summary>
        public string TLSSecurityPolicy { get; set; }

        /// <summary>
        /// Checks to see if the TLSSecurityPolicy property is set.
        /// </summary>
        internal bool IsSetTLSSecurityPolicy() => this.TLSSecurityPolicy != null;
    }
}
