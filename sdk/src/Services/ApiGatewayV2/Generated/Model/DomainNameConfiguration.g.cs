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
    /// The domain name configuration.
    /// </summary>
    public partial class DomainNameConfiguration
    {
        /// <summary>
        /// Gets and sets the property ApiGatewayDomainName. 
        /// <para>
        /// A domain name for the API.
        /// </para>
        /// </summary>
        public string ApiGatewayDomainName { get; set; }

        /// <summary>
        /// Checks to see if the ApiGatewayDomainName property is set.
        /// </summary>
        internal bool IsSetApiGatewayDomainName() => this.ApiGatewayDomainName != null;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// An AWS-managed certificate that will be used by the edge-optimized endpoint for this
        /// domain name. AWS Certificate Manager is the only supported source.
        /// </para>
        /// </summary>
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The user-friendly name of the certificate that will be used by the edge-optimized
        /// endpoint for this domain name.
        /// </para>
        /// </summary>
        public string CertificateName { get; set; }

        /// <summary>
        /// Checks to see if the CertificateName property is set.
        /// </summary>
        internal bool IsSetCertificateName() => this.CertificateName != null;

        /// <summary>
        /// Gets and sets the property CertificateUploadDate. 
        /// <para>
        /// The timestamp when the certificate that was used by edge-optimized endpoint for this
        /// domain name was uploaded.
        /// </para>
        /// </summary>
        public DateTime? CertificateUploadDate { get; set; }

        /// <summary>
        /// Checks to see if the CertificateUploadDate property is set.
        /// </summary>
        internal bool IsSetCertificateUploadDate() => this.CertificateUploadDate.HasValue;

        /// <summary>
        /// Gets and sets the property DomainNameStatus. 
        /// <para>
        /// The status of the domain name migration. The valid values are AVAILABLE, UPDATING,
        /// PENDING_CERTIFICATE_REIMPORT, and PENDING_OWNERSHIP_VERIFICATION. If the status is
        /// UPDATING, the domain cannot be modified further until the existing operation is complete.
        /// If it is AVAILABLE, the domain can be updated.
        /// </para>
        /// </summary>
        public DomainNameStatus DomainNameStatus { get; set; }

        /// <summary>
        /// Checks to see if the DomainNameStatus property is set.
        /// </summary>
        internal bool IsSetDomainNameStatus() => this.DomainNameStatus != null;

        /// <summary>
        /// Gets and sets the property DomainNameStatusMessage. 
        /// <para>
        /// An optional text message containing detailed information about status of the domain
        /// name migration.
        /// </para>
        /// </summary>
        public string DomainNameStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the DomainNameStatusMessage property is set.
        /// </summary>
        internal bool IsSetDomainNameStatusMessage() => this.DomainNameStatusMessage != null;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The endpoint type.
        /// </para>
        /// </summary>
        public EndpointType EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The Amazon Route 53 Hosted Zone ID of the endpoint.
        /// </para>
        /// </summary>
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address types that can invoke the domain name. Use ipv4 to allow only IPv4
        /// addresses to invoke your domain name, or use dualstack to allow both IPv4 and IPv6
        /// addresses to invoke your domain name.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property OwnershipVerificationCertificateArn. 
        /// <para>
        /// The ARN of the public certificate issued by ACM to validate ownership of your custom
        /// domain. Only required when configuring mutual TLS and using an ACM imported or private
        /// CA certificate ARN as the regionalCertificateArn
        /// </para>
        /// </summary>
        public string OwnershipVerificationCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the OwnershipVerificationCertificateArn property is set.
        /// </summary>
        internal bool IsSetOwnershipVerificationCertificateArn() => this.OwnershipVerificationCertificateArn != null;

        /// <summary>
        /// Gets and sets the property SecurityPolicy. 
        /// <para>
        /// The Transport Layer Security (TLS) version of the security policy for this domain
        /// name. The valid values are TLS_1_0 and TLS_1_2.
        /// </para>
        /// </summary>
        public SecurityPolicy SecurityPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SecurityPolicy property is set.
        /// </summary>
        internal bool IsSetSecurityPolicy() => this.SecurityPolicy != null;
    }
}
