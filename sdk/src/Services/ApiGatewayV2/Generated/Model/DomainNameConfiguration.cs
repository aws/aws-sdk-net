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
    /// The domain name configuration.
    /// </summary>
    public partial class DomainNameConfiguration
    {
        private string _apiGatewayDomainName;
        private string _certificateArn;
        private string _certificateName;
        private DateTime? _certificateUploadDate;
        private DomainNameStatus _domainNameStatus;
        private string _domainNameStatusMessage;
        private EndpointType _endpointType;
        private string _hostedZoneId;
        private IpAddressType _ipAddressType;
        private string _ownershipVerificationCertificateArn;
        private SecurityPolicy _securityPolicy;

        /// <summary>
        /// Gets and sets the property ApiGatewayDomainName. 
        /// <para>
        /// A domain name for the API.
        /// </para>
        /// </summary>
        public string ApiGatewayDomainName
        {
            get { return this._apiGatewayDomainName; }
            set { this._apiGatewayDomainName = value; }
        }

        // Check to see if ApiGatewayDomainName property is set
        internal bool IsSetApiGatewayDomainName()
        {
            return this._apiGatewayDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// An AWS-managed certificate that will be used by the edge-optimized endpoint for this
        /// domain name. AWS Certificate Manager is the only supported source.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The user-friendly name of the certificate that will be used by the edge-optimized
        /// endpoint for this domain name.
        /// </para>
        /// </summary>
        public string CertificateName
        {
            get { return this._certificateName; }
            set { this._certificateName = value; }
        }

        // Check to see if CertificateName property is set
        internal bool IsSetCertificateName()
        {
            return this._certificateName != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateUploadDate. 
        /// <para>
        /// The timestamp when the certificate that was used by edge-optimized endpoint for this
        /// domain name was uploaded.
        /// </para>
        /// </summary>
        public DateTime? CertificateUploadDate
        {
            get { return this._certificateUploadDate; }
            set { this._certificateUploadDate = value; }
        }

        // Check to see if CertificateUploadDate property is set
        internal bool IsSetCertificateUploadDate()
        {
            return this._certificateUploadDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainNameStatus. 
        /// <para>
        /// The status of the domain name migration. The valid values are AVAILABLE, UPDATING,
        /// PENDING_CERTIFICATE_REIMPORT, and PENDING_OWNERSHIP_VERIFICATION. If the status is
        /// UPDATING, the domain cannot be modified further until the existing operation is complete.
        /// If it is AVAILABLE, the domain can be updated.
        /// </para>
        /// </summary>
        public DomainNameStatus DomainNameStatus
        {
            get { return this._domainNameStatus; }
            set { this._domainNameStatus = value; }
        }

        // Check to see if DomainNameStatus property is set
        internal bool IsSetDomainNameStatus()
        {
            return this._domainNameStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DomainNameStatusMessage. 
        /// <para>
        /// An optional text message containing detailed information about status of the domain
        /// name migration.
        /// </para>
        /// </summary>
        public string DomainNameStatusMessage
        {
            get { return this._domainNameStatusMessage; }
            set { this._domainNameStatusMessage = value; }
        }

        // Check to see if DomainNameStatusMessage property is set
        internal bool IsSetDomainNameStatusMessage()
        {
            return this._domainNameStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The endpoint type.
        /// </para>
        /// </summary>
        public EndpointType EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The Amazon Route 53 Hosted Zone ID of the endpoint.
        /// </para>
        /// </summary>
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address types that can invoke the domain name. Use ipv4 to allow only IPv4
        /// addresses to invoke your domain name, or use dualstack to allow both IPv4 and IPv6
        /// addresses to invoke your domain name.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property OwnershipVerificationCertificateArn. 
        /// <para>
        /// The ARN of the public certificate issued by ACM to validate ownership of your custom
        /// domain. Only required when configuring mutual TLS and using an ACM imported or private
        /// CA certificate ARN as the regionalCertificateArn
        /// </para>
        /// </summary>
        public string OwnershipVerificationCertificateArn
        {
            get { return this._ownershipVerificationCertificateArn; }
            set { this._ownershipVerificationCertificateArn = value; }
        }

        // Check to see if OwnershipVerificationCertificateArn property is set
        internal bool IsSetOwnershipVerificationCertificateArn()
        {
            return this._ownershipVerificationCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityPolicy. 
        /// <para>
        /// The Transport Layer Security (TLS) version of the security policy for this domain
        /// name. The valid values are TLS_1_0 and TLS_1_2.
        /// </para>
        /// </summary>
        public SecurityPolicy SecurityPolicy
        {
            get { return this._securityPolicy; }
            set { this._securityPolicy = value; }
        }

        // Check to see if SecurityPolicy property is set
        internal bool IsSetSecurityPolicy()
        {
            return this._securityPolicy != null;
        }

    }
}