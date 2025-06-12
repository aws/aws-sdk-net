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
    /// Represents a custom domain name as a user-friendly host name of an API (RestApi).
    /// </summary>
    public partial class DomainName
    {
        private string _certificateArn;
        private string _certificateName;
        private DateTime? _certificateUploadDate;
        private string _distributionDomainName;
        private string _distributionHostedZoneId;
        private string _domainNameArn;
        private string _domainNameId;
        private DomainNameStatus _domainNameStatus;
        private string _domainNameStatusMessage;
        private EndpointConfiguration _endpointConfiguration;
        private string _managementPolicy;
        private MutualTlsAuthentication _mutualTlsAuthentication;
        private string _name;
        private string _ownershipVerificationCertificateArn;
        private string _policy;
        private string _regionalCertificateArn;
        private string _regionalCertificateName;
        private string _regionalDomainName;
        private string _regionalHostedZoneId;
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
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name of the certificate that will be used by edge-optimized endpoint or private
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
        /// The timestamp when the certificate that was used by edge-optimized endpoint or private
        /// endpoint for this domain name was uploaded.
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
        /// Gets and sets the property DistributionDomainName. 
        /// <para>
        /// The domain name of the Amazon CloudFront distribution associated with this custom
        /// domain name for an edge-optimized endpoint. You set up this association when adding
        /// a DNS record pointing the custom domain name to this distribution name. For more information
        /// about CloudFront distributions, see the Amazon CloudFront documentation.
        /// </para>
        /// </summary>
        public string DistributionDomainName
        {
            get { return this._distributionDomainName; }
            set { this._distributionDomainName = value; }
        }

        // Check to see if DistributionDomainName property is set
        internal bool IsSetDistributionDomainName()
        {
            return this._distributionDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property DistributionHostedZoneId. 
        /// <para>
        /// The region-agnostic Amazon Route 53 Hosted Zone ID of the edge-optimized endpoint.
        /// The valid value is <c>Z2FDTNDATAQYW2</c> for all the regions. For more information,
        /// see Set up a Regional Custom Domain Name and AWS Regions and Endpoints for API Gateway.
        /// 
        /// </para>
        /// </summary>
        public string DistributionHostedZoneId
        {
            get { return this._distributionHostedZoneId; }
            set { this._distributionHostedZoneId = value; }
        }

        // Check to see if DistributionHostedZoneId property is set
        internal bool IsSetDistributionHostedZoneId()
        {
            return this._distributionHostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property DomainNameArn. 
        /// <para>
        /// The ARN of the domain name. 
        /// </para>
        /// </summary>
        public string DomainNameArn
        {
            get { return this._domainNameArn; }
            set { this._domainNameArn = value; }
        }

        // Check to see if DomainNameArn property is set
        internal bool IsSetDomainNameArn()
        {
            return this._domainNameArn != null;
        }

        /// <summary>
        /// Gets and sets the property DomainNameId. 
        /// <para>
        /// The identifier for the domain name resource. Supported only for private custom domain
        /// names.
        /// </para>
        /// </summary>
        public string DomainNameId
        {
            get { return this._domainNameId; }
            set { this._domainNameId = value; }
        }

        // Check to see if DomainNameId property is set
        internal bool IsSetDomainNameId()
        {
            return this._domainNameId != null;
        }

        /// <summary>
        /// Gets and sets the property DomainNameStatus. 
        /// <para>
        /// The status of the DomainName migration. The valid values are <c>AVAILABLE</c> and
        /// <c>UPDATING</c>. If the status is <c>UPDATING</c>, the domain cannot be modified further
        /// until the existing operation is complete. If it is <c>AVAILABLE</c>, the domain can
        /// be updated.
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
        /// An optional text message containing detailed information about status of the DomainName
        /// migration.
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
        /// Gets and sets the property ManagementPolicy. 
        /// <para>
        /// A stringified JSON policy document that applies to the API Gateway Management service
        /// for this DomainName. This policy document controls access for access association sources
        /// to create domain name access associations with this DomainName. Supported only for
        /// private custom domain names.
        /// </para>
        /// </summary>
        public string ManagementPolicy
        {
            get { return this._managementPolicy; }
            set { this._managementPolicy = value; }
        }

        // Check to see if ManagementPolicy property is set
        internal bool IsSetManagementPolicy()
        {
            return this._managementPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property MutualTlsAuthentication. 
        /// <para>
        /// The mutual TLS authentication configuration for a custom domain name. If specified,
        /// API Gateway performs two-way authentication between the client and the server. Clients
        /// must present a trusted certificate to access your API.
        /// </para>
        /// </summary>
        public MutualTlsAuthentication MutualTlsAuthentication
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The custom domain name as an API host name, for example, <c>my-api.example.com</c>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
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
        /// The reference to an Amazon Web Services-managed certificate that will be used for
        /// validating the regional domain name. Certificate Manager is the only supported source.
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
        /// The name of the certificate that will be used for validating the regional domain name.
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
        /// Gets and sets the property RegionalDomainName. 
        /// <para>
        /// The domain name associated with the regional endpoint for this custom domain name.
        /// You set up this association by adding a DNS record that points the custom domain name
        /// to this regional domain name. The regional domain name is returned by API Gateway
        /// when you create a regional endpoint.
        /// </para>
        /// </summary>
        public string RegionalDomainName
        {
            get { return this._regionalDomainName; }
            set { this._regionalDomainName = value; }
        }

        // Check to see if RegionalDomainName property is set
        internal bool IsSetRegionalDomainName()
        {
            return this._regionalDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property RegionalHostedZoneId. 
        /// <para>
        /// The region-specific Amazon Route 53 Hosted Zone ID of the regional endpoint. For more
        /// information, see Set up a Regional Custom Domain Name and AWS Regions and Endpoints
        /// for API Gateway. 
        /// </para>
        /// </summary>
        public string RegionalHostedZoneId
        {
            get { return this._regionalHostedZoneId; }
            set { this._regionalHostedZoneId = value; }
        }

        // Check to see if RegionalHostedZoneId property is set
        internal bool IsSetRegionalHostedZoneId()
        {
            return this._regionalHostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingMode. 
        /// <para>
        /// The routing mode for this domain name. The routing mode determines how API Gateway
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
        /// The collection of tags. Each tag element is associated with a given resource.
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