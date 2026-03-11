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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
        private string _certificateArn;
        private string _domainName;
        private string _portalDefaultDomainName;
        private string _portalDomainHostedZoneId;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The ARN of the ACM certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=2048)]
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=256)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property PortalDefaultDomainName. 
        /// <para>
        /// The portal default domain name. This domain name is generated and managed by API Gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=256)]
        public string PortalDefaultDomainName
        {
            get { return this._portalDefaultDomainName; }
            set { this._portalDefaultDomainName = value; }
        }

        // Check to see if PortalDefaultDomainName property is set
        internal bool IsSetPortalDefaultDomainName()
        {
            return this._portalDefaultDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property PortalDomainHostedZoneId. 
        /// <para>
        /// The portal domain hosted zone identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string PortalDomainHostedZoneId
        {
            get { return this._portalDomainHostedZoneId; }
            set { this._portalDomainHostedZoneId = value; }
        }

        // Check to see if PortalDomainHostedZoneId property is set
        internal bool IsSetPortalDomainHostedZoneId()
        {
            return this._portalDomainHostedZoneId != null;
        }

    }
}