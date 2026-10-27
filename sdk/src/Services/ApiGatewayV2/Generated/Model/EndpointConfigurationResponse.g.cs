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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Represents an endpoint configuration.
    /// </summary>
    public partial class EndpointConfigurationResponse
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The ARN of the ACM certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 2048)]
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 256)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property PortalDefaultDomainName. 
        /// <para>
        /// The portal default domain name. This domain name is generated and managed by API Gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 256)]
        public string PortalDefaultDomainName { get; set; }

        /// <summary>
        /// Checks to see if the PortalDefaultDomainName property is set.
        /// </summary>
        internal bool IsSetPortalDefaultDomainName() => this.PortalDefaultDomainName != null;

        /// <summary>
        /// Gets and sets the property PortalDomainHostedZoneId. 
        /// <para>
        /// The portal domain hosted zone identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PortalDomainHostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the PortalDomainHostedZoneId property is set.
        /// </summary>
        internal bool IsSetPortalDomainHostedZoneId() => this.PortalDomainHostedZoneId != null;
    }
}
