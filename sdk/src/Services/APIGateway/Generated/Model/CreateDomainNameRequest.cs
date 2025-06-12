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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
    /// Container for the parameters to the CreateDomainName operation.
    /// Creates a new domain name.
    /// </summary>
    public partial class CreateDomainNameRequest : AmazonAPIGatewayRequest
    {
        private string _certificateArn;
        private string _certificateBody;
        private string _certificateChain;
        private string _certificateName;
        private string _certificatePrivateKey;
        private string _domainName;
        private EndpointConfiguration _endpointConfiguration;
        private MutualTlsAuthenticationInput _mutualTlsAuthentication;
        private string _ownershipVerificationCertificateArn;
        private string _policy;
        private string _regionalCertificateArn;
        private string _regionalCertificateName;
        private RoutingMode _routingMode;
        private SecurityPolicy _securityPolicy;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The reference to an Amazon Web Services-managed certificate that will be used by edge-optimized
        /// endpoint or private endpoint for this domain name. Certificate Manager is the only
        /// supported source.
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
        /// Gets and sets the property CertificateBody. 
        /// <para>
        /// [Deprecated] The body of the server certificate that will be used by edge-optimized
        /// endpoint or private endpoint for this domain name provided by your certificate authority.
        /// </para>
        /// </summary>
        public string CertificateBody
        {
            get { return this._certificateBody; }
            set { this._certificateBody = value; }
        }

        // Check to see if CertificateBody property is set
        internal bool IsSetCertificateBody()
        {
            return this._certificateBody != null;
        }

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
        public string CertificateChain
        {
            get { return this._certificateChain; }
            set { this._certificateChain = value; }
        }

        // Check to see if CertificateChain property is set
        internal bool IsSetCertificateChain()
        {
            return this._certificateChain != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The user-friendly name of the certificate that will be used by edge-optimized endpoint
        /// or private endpoint for this domain name.
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
        /// Gets and sets the property CertificatePrivateKey. 
        /// <para>
        /// [Deprecated] Your edge-optimized endpoint's domain name certificate's private key.
        /// </para>
        /// </summary>
        public string CertificatePrivateKey
        {
            get { return this._certificatePrivateKey; }
            set { this._certificatePrivateKey = value; }
        }

        // Check to see if CertificatePrivateKey property is set
        internal bool IsSetCertificatePrivateKey()
        {
            return this._certificatePrivateKey != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the DomainName resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// The endpoint configuration of this DomainName showing the endpoint types and IP address
        /// types of the domain name. 
        /// </para>
        /// </summary>
        public EndpointConfiguration EndpointConfiguration
        {
            get { return this._endpointConfiguration; }
            set { this._endpointConfiguration = value; }
        }

        // Check to see if EndpointConfiguration property is set
        internal bool IsSetEndpointConfiguration()
        {
            return this._endpointConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MutualTlsAuthentication.
        /// </summary>
        public MutualTlsAuthenticationInput MutualTlsAuthentication
        {
            get { return this._mutualTlsAuthentication; }
            set { this._mutualTlsAuthentication = value; }
        }

        // Check to see if MutualTlsAuthentication property is set
        internal bool IsSetMutualTlsAuthentication()
        {
            return this._mutualTlsAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property OwnershipVerificationCertificateArn. 
        /// <para>
        /// The ARN of the public certificate issued by ACM to validate ownership of your custom
        /// domain. Only required when configuring mutual TLS and using an ACM imported or private
        /// CA certificate ARN as the regionalCertificateArn.
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
        /// Gets and sets the property Policy. 
        /// <para>
        /// A stringified JSON policy document that applies to the <c>execute-api</c> service
        /// for this DomainName regardless of the caller and Method configuration. Supported only
        /// for private custom domain names.
        /// </para>
        /// </summary>
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property RegionalCertificateArn. 
        /// <para>
        /// The reference to an Amazon Web Services-managed certificate that will be used by regional
        /// endpoint for this domain name. Certificate Manager is the only supported source.
        /// </para>
        /// </summary>
        public string RegionalCertificateArn
        {
            get { return this._regionalCertificateArn; }
            set { this._regionalCertificateArn = value; }
        }

        // Check to see if RegionalCertificateArn property is set
        internal bool IsSetRegionalCertificateArn()
        {
            return this._regionalCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegionalCertificateName. 
        /// <para>
        /// The user-friendly name of the certificate that will be used by regional endpoint for
        /// this domain name.
        /// </para>
        /// </summary>
        public string RegionalCertificateName
        {
            get { return this._regionalCertificateName; }
            set { this._regionalCertificateName = value; }
        }

        // Check to see if RegionalCertificateName property is set
        internal bool IsSetRegionalCertificateName()
        {
            return this._regionalCertificateName != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingMode. 
        /// <para>
        ///  The routing mode for this domain name. The routing mode determines how API Gateway
        /// sends traffic from your custom domain name to your private APIs. 
        /// </para>
        /// </summary>
        public RoutingMode RoutingMode
        {
            get { return this._routingMode; }
            set { this._routingMode = value; }
        }

        // Check to see if RoutingMode property is set
        internal bool IsSetRoutingMode()
        {
            return this._routingMode != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityPolicy. 
        /// <para>
        /// The Transport Layer Security (TLS) version + cipher suite for this DomainName. The
        /// valid values are <c>TLS_1_0</c> and <c>TLS_1_2</c>.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value map of strings. The valid character set is [a-zA-Z+-=._:/]. The tag
        /// key can be up to 128 characters and must not start with <c>aws:</c>. The tag value
        /// can be up to 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}