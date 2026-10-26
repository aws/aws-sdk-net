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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDomainName operation. Creates a new domain
    /// name.
    /// </summary>
    public partial class CreateDomainNameRequest : AmazonAPIGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The reference to an Amazon Web Services-managed certificate that will be used by edge-optimized
        /// endpoint or private endpoint for this domain name. Certificate Manager is the only
        /// supported source.
        /// </para>
        /// </summary>
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property CertificateBody. 
        /// <para>
        /// [Deprecated] The body of the server certificate that will be used by edge-optimized
        /// endpoint or private endpoint for this domain name provided by your certificate authority.
        /// </para>
        /// </summary>
        public string CertificateBody { get; set; }

        /// <summary>
        /// Checks to see if the CertificateBody property is set.
        /// </summary>
        internal bool IsSetCertificateBody() => this.CertificateBody != null;

        /// <summary>
        /// Gets and sets the property CertificateChain. 
        /// <para>
        /// [Deprecated] The intermediate certificates and optionally the root certificate, one
        /// after the other without any blank lines, used by an edge-optimized endpoint for this
        /// domain name. If you include the root certificate, your certificate chain must start
        /// with intermediate certificates and end with the root certificate. Use the intermediate
        /// certificates that were provided by your certificate authority. Do not include any
        /// intermediaries that are not in the chain of trust path.
        /// </para>
        /// </summary>
        public string CertificateChain { get; set; }

        /// <summary>
        /// Checks to see if the CertificateChain property is set.
        /// </summary>
        internal bool IsSetCertificateChain() => this.CertificateChain != null;

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The user-friendly name of the certificate that will be used by edge-optimized endpoint
        /// or private endpoint for this domain name.
        /// </para>
        /// </summary>
        public string CertificateName { get; set; }

        /// <summary>
        /// Checks to see if the CertificateName property is set.
        /// </summary>
        internal bool IsSetCertificateName() => this.CertificateName != null;

        /// <summary>
        /// Gets and sets the property CertificatePrivateKey. 
        /// <para>
        /// [Deprecated] Your edge-optimized endpoint's domain name certificate's private key.
        /// </para>
        /// </summary>
        public string CertificatePrivateKey { get; set; }

        /// <summary>
        /// Checks to see if the CertificatePrivateKey property is set.
        /// </summary>
        internal bool IsSetCertificatePrivateKey() => this.CertificatePrivateKey != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the DomainName resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property EndpointAccessMode. 
        /// <para>
        ///  The endpoint access mode of the DomainName. Only available for DomainNames that use
        /// security policies that start with <c>SecurityPolicy_</c>. 
        /// </para>
        /// </summary>
        public EndpointAccessMode EndpointAccessMode { get; set; }

        /// <summary>
        /// Checks to see if the EndpointAccessMode property is set.
        /// </summary>
        internal bool IsSetEndpointAccessMode() => this.EndpointAccessMode != null;

        /// <summary>
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// The endpoint configuration of this DomainName showing the endpoint types and IP address
        /// types of the domain name. 
        /// </para>
        /// </summary>
        public EndpointConfiguration EndpointConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EndpointConfiguration property is set.
        /// </summary>
        internal bool IsSetEndpointConfiguration() => this.EndpointConfiguration != null;

        /// <summary>
        /// Gets and sets the property MutualTlsAuthentication.
        /// </summary>
        public MutualTlsAuthenticationInput MutualTlsAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the MutualTlsAuthentication property is set.
        /// </summary>
        internal bool IsSetMutualTlsAuthentication() => this.MutualTlsAuthentication != null;

        /// <summary>
        /// Gets and sets the property OwnershipVerificationCertificateArn. 
        /// <para>
        /// The ARN of the public certificate issued by ACM to validate ownership of your custom
        /// domain. Only required when configuring mutual TLS and using an ACM imported or private
        /// CA certificate ARN as the regionalCertificateArn.
        /// </para>
        /// </summary>
        public string OwnershipVerificationCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the OwnershipVerificationCertificateArn property is set.
        /// </summary>
        internal bool IsSetOwnershipVerificationCertificateArn() => this.OwnershipVerificationCertificateArn != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// A stringified JSON policy document that applies to the <c>execute-api</c> service
        /// for this DomainName regardless of the caller and Method configuration. Supported only
        /// for private custom domain names.
        /// </para>
        /// </summary>
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property RegionalCertificateArn. 
        /// <para>
        /// The reference to an Amazon Web Services-managed certificate that will be used by regional
        /// endpoint for this domain name. Certificate Manager is the only supported source.
        /// </para>
        /// </summary>
        public string RegionalCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the RegionalCertificateArn property is set.
        /// </summary>
        internal bool IsSetRegionalCertificateArn() => this.RegionalCertificateArn != null;

        /// <summary>
        /// Gets and sets the property RegionalCertificateName. 
        /// <para>
        /// The user-friendly name of the certificate that will be used by regional endpoint for
        /// this domain name.
        /// </para>
        /// </summary>
        public string RegionalCertificateName { get; set; }

        /// <summary>
        /// Checks to see if the RegionalCertificateName property is set.
        /// </summary>
        internal bool IsSetRegionalCertificateName() => this.RegionalCertificateName != null;

        /// <summary>
        /// Gets and sets the property RoutingMode. 
        /// <para>
        ///  The routing mode for this domain name. The routing mode determines how API Gateway
        /// sends traffic from your custom domain name to your private APIs. 
        /// </para>
        /// </summary>
        public RoutingMode RoutingMode { get; set; }

        /// <summary>
        /// Checks to see if the RoutingMode property is set.
        /// </summary>
        internal bool IsSetRoutingMode() => this.RoutingMode != null;

        /// <summary>
        /// Gets and sets the property SecurityPolicy. 
        /// <para>
        /// The Transport Layer Security (TLS) version + cipher suite for this DomainName.
        /// </para>
        /// </summary>
        public SecurityPolicy SecurityPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SecurityPolicy property is set.
        /// </summary>
        internal bool IsSetSecurityPolicy() => this.SecurityPolicy != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value map of strings. The valid character set is [a-zA-Z+-=._:/]. The tag
        /// key can be up to 128 characters and must not start with <c>aws:</c>. The tag value
        /// can be up to 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
