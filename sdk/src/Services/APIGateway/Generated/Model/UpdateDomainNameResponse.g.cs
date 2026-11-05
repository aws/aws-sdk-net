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
    /// This is the response object from the UpdateDomainName operation.
    /// </summary>
    public partial class UpdateDomainNameResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name of the certificate that will be used by edge-optimized endpoint or private
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
        /// The timestamp when the certificate that was used by edge-optimized endpoint or private
        /// endpoint for this domain name was uploaded.
        /// </para>
        /// </summary>
        public DateTime? CertificateUploadDate { get; set; }

        /// <summary>
        /// Checks to see if the CertificateUploadDate property is set.
        /// </summary>
        internal bool IsSetCertificateUploadDate() => this.CertificateUploadDate.HasValue;

        /// <summary>
        /// Gets and sets the property DistributionDomainName. 
        /// <para>
        /// The domain name of the Amazon CloudFront distribution associated with this custom
        /// domain name for an edge-optimized endpoint. You set up this association when adding
        /// a DNS record pointing the custom domain name to this distribution name. For more information
        /// about CloudFront distributions, see the Amazon CloudFront documentation.
        /// </para>
        /// </summary>
        public string DistributionDomainName { get; set; }

        /// <summary>
        /// Checks to see if the DistributionDomainName property is set.
        /// </summary>
        internal bool IsSetDistributionDomainName() => this.DistributionDomainName != null;

        /// <summary>
        /// Gets and sets the property DistributionHostedZoneId. 
        /// <para>
        /// The region-agnostic Amazon Route 53 Hosted Zone ID of the edge-optimized endpoint.
        /// The valid value is <c>Z2FDTNDATAQYW2</c> for all the regions. For more information,
        /// see Set up a Regional Custom Domain Name and AWS Regions and Endpoints for API Gateway.
        /// 
        /// </para>
        /// </summary>
        public string DistributionHostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the DistributionHostedZoneId property is set.
        /// </summary>
        internal bool IsSetDistributionHostedZoneId() => this.DistributionHostedZoneId != null;

        /// <summary>
        /// Gets and sets the property DomainNameArn. 
        /// <para>
        /// The ARN of the domain name. 
        /// </para>
        /// </summary>
        public string DomainNameArn { get; set; }

        /// <summary>
        /// Checks to see if the DomainNameArn property is set.
        /// </summary>
        internal bool IsSetDomainNameArn() => this.DomainNameArn != null;

        /// <summary>
        /// Gets and sets the property DomainNameId. 
        /// <para>
        /// The identifier for the domain name resource. Supported only for private custom domain
        /// names.
        /// </para>
        /// </summary>
        public string DomainNameId { get; set; }

        /// <summary>
        /// Checks to see if the DomainNameId property is set.
        /// </summary>
        internal bool IsSetDomainNameId() => this.DomainNameId != null;

        /// <summary>
        /// Gets and sets the property DomainNameStatus. 
        /// <para>
        /// The status of the DomainName migration. The valid values are <c>AVAILABLE</c> and
        /// <c>UPDATING</c>. If the status is <c>UPDATING</c>, the domain cannot be modified further
        /// until the existing operation is complete. If it is <c>AVAILABLE</c>, the domain can
        /// be updated.
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
        /// An optional text message containing detailed information about status of the DomainName
        /// migration.
        /// </para>
        /// </summary>
        public string DomainNameStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the DomainNameStatusMessage property is set.
        /// </summary>
        internal bool IsSetDomainNameStatusMessage() => this.DomainNameStatusMessage != null;

        /// <summary>
        /// Gets and sets the property EndpointAccessMode. 
        /// <para>
        ///  The endpoint access mode of the DomainName. 
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
        /// Gets and sets the property ManagementPolicy. 
        /// <para>
        /// A stringified JSON policy document that applies to the API Gateway Management service
        /// for this DomainName. This policy document controls access for access association sources
        /// to create domain name access associations with this DomainName. Supported only for
        /// private custom domain names.
        /// </para>
        /// </summary>
        public string ManagementPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ManagementPolicy property is set.
        /// </summary>
        internal bool IsSetManagementPolicy() => this.ManagementPolicy != null;

        /// <summary>
        /// Gets and sets the property MutualTlsAuthentication. 
        /// <para>
        /// The mutual TLS authentication configuration for a custom domain name. If specified,
        /// API Gateway performs two-way authentication between the client and the server. Clients
        /// must present a trusted certificate to access your API.
        /// </para>
        /// </summary>
        public MutualTlsAuthentication MutualTlsAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the MutualTlsAuthentication property is set.
        /// </summary>
        internal bool IsSetMutualTlsAuthentication() => this.MutualTlsAuthentication != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The custom domain name as an API host name, for example, <c>my-api.example.com</c>.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        /// The reference to an Amazon Web Services-managed certificate that will be used for
        /// validating the regional domain name. Certificate Manager is the only supported source.
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
        /// The name of the certificate that will be used for validating the regional domain name.
        /// </para>
        /// </summary>
        public string RegionalCertificateName { get; set; }

        /// <summary>
        /// Checks to see if the RegionalCertificateName property is set.
        /// </summary>
        internal bool IsSetRegionalCertificateName() => this.RegionalCertificateName != null;

        /// <summary>
        /// Gets and sets the property RegionalDomainName. 
        /// <para>
        /// The domain name associated with the regional endpoint for this custom domain name.
        /// You set up this association by adding a DNS record that points the custom domain name
        /// to this regional domain name. The regional domain name is returned by API Gateway
        /// when you create a regional endpoint.
        /// </para>
        /// </summary>
        public string RegionalDomainName { get; set; }

        /// <summary>
        /// Checks to see if the RegionalDomainName property is set.
        /// </summary>
        internal bool IsSetRegionalDomainName() => this.RegionalDomainName != null;

        /// <summary>
        /// Gets and sets the property RegionalHostedZoneId. 
        /// <para>
        /// The region-specific Amazon Route 53 Hosted Zone ID of the regional endpoint. For more
        /// information, see Set up a Regional Custom Domain Name and AWS Regions and Endpoints
        /// for API Gateway. 
        /// </para>
        /// </summary>
        public string RegionalHostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the RegionalHostedZoneId property is set.
        /// </summary>
        internal bool IsSetRegionalHostedZoneId() => this.RegionalHostedZoneId != null;

        /// <summary>
        /// Gets and sets the property RoutingMode. 
        /// <para>
        /// The routing mode for this domain name. The routing mode determines how API Gateway
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
        /// The collection of tags. Each tag element is associated with a given resource.
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
