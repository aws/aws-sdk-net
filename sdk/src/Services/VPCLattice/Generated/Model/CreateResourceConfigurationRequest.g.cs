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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResourceConfiguration operation. Creates
    /// a resource configuration. A resource configuration defines a specific resource. You
    /// can associate a resource configuration with a service network or a VPC endpoint.
    /// </summary>
    public partial class CreateResourceConfigurationRequest : AmazonVPCLatticeRequest
    {
        /// <summary>
        /// Gets and sets the property AllowAssociationToShareableServiceNetwork. 
        /// <para>
        /// (SINGLE, GROUP, ARN) Specifies whether the resource configuration can be associated
        /// with a sharable service network. The default is false.
        /// </para>
        /// </summary>
        public bool? AllowAssociationToShareableServiceNetwork { get; set; }

        /// <summary>
        /// Checks to see if the AllowAssociationToShareableServiceNetwork property is set.
        /// </summary>
        internal bool IsSetAllowAssociationToShareableServiceNetwork() => this.AllowAssociationToShareableServiceNetwork.HasValue;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you retry a request that completed successfully using the same client
        /// token and parameters, the retry succeeds without performing any actions. If the parameters
        /// aren't identical, the retry fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        ///  A custom domain name for your resource configuration. Additionally, provide a DomainVerificationID
        /// to prove your ownership of a domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string CustomDomainName { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainName property is set.
        /// </summary>
        internal bool IsSetCustomDomainName() => this.CustomDomainName != null;

        /// <summary>
        /// Gets and sets the property DomainVerificationIdentifier. 
        /// <para>
        ///  The domain verification ID of your verified custom domain name. If you don't provide
        /// an ID, you must configure the DNS settings yourself. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DomainVerificationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainVerificationIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainVerificationIdentifier() => this.DomainVerificationIdentifier != null;

        /// <summary>
        /// Gets and sets the property GroupDomain. 
        /// <para>
        ///  (GROUP) The group domain for a group resource configuration. Any domains that you
        /// create for the child resource are subdomains of the group domain. Child resources
        /// inherit the verification status of the domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string GroupDomain { get; set; }

        /// <summary>
        /// Checks to see if the GroupDomain property is set.
        /// </summary>
        internal bool IsSetGroupDomain() => this.GroupDomain != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource configuration. The name must be unique within the account.
        /// The valid characters are a-z, 0-9, and hyphens (-). You can't use a hyphen as the
        /// first or last character, or immediately after another hyphen.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 40)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PortRanges. 
        /// <para>
        /// (SINGLE, GROUP, CHILD, CIDR) The port ranges that a consumer can use to access a resource
        /// configuration (for example: 1-65535). You can separate port ranges using commas (for
        /// example: 1,2,22-30). To resolve DNS through a CIDR resource configuration, include
        /// port 53 in the port ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PortRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PortRanges property is set.
        /// </summary>
        internal bool IsSetPortRanges() => this.PortRanges != null && (this.PortRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// (SINGLE, GROUP, CIDR) The protocol accepted by the resource configuration. The default
        /// is <c>TCP</c>. <c>TCP_UDP</c> is supported only for CIDR resource configurations;
        /// specify it for a CIDR resource configuration to allow DNS resolution, which uses UDP.
        /// </para>
        /// </summary>
        public ProtocolType Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationDefinition. 
        /// <para>
        /// Identifies the resource configuration in one of the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Amazon Resource Name (ARN)</b> - Supported resource-types that are provisioned
        /// by Amazon Web Services services, such as RDS databases, can be identified by their
        /// ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Domain name</b> - Any domain name that is publicly resolvable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IP address</b> - For IPv4 and IPv6, only IP addresses in the VPC are supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CIDR range</b> - For a resource configuration of type CIDR, specify a <c>cidrResource</c>
        /// with one or more <c>cidrRanges</c> (for example, <c>10.0.0.0/16</c>) that cover the
        /// IP addresses of the resources you want to make accessible. You can specify up to 10
        /// ranges, using IPv4, IPv6, or both, and each range must include a prefix length. To
        /// represent your entire network, specify <c>0.0.0.0/0</c> (IPv4) or <c>::/0</c> (IPv6)
        /// as the only range. You can't use reserved ranges such as <c>169.254.0.0/16</c>, <c>100.64.0.0/10</c>,
        /// <c>224.0.0.0/4</c>, <c>fe80::/10</c>, or <c>ff00::/8</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceConfigurationDefinition ResourceConfigurationDefinition { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationDefinition property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationDefinition() => this.ResourceConfigurationDefinition != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationGroupIdentifier. 
        /// <para>
        /// (CHILD) The ID or ARN of the parent resource configuration of type <c>GROUP</c>. This
        /// is used to associate a child resource configuration with a group resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceConfigurationGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationGroupIdentifier() => this.ResourceConfigurationGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceGatewayIdentifier. 
        /// <para>
        /// (SINGLE, GROUP, ARN, CIDR) The ID or ARN of the resource gateway used to connect to
        /// the resource configuration. For a child resource configuration, this value is inherited
        /// from the parent resource configuration. For a CIDR resource configuration, the associated
        /// resource gateway must have its DNS resolution set to <c>IN_VPC</c> so that DNS queries
        /// resolve in the context of your VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 17, Max = 2048)]
        public string ResourceGatewayIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGatewayIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceGatewayIdentifier() => this.ResourceGatewayIdentifier != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the resource configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of resource configuration. A resource configuration can be one of the following
        /// types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>SINGLE</b> - A single resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GROUP</b> - A group of resources. You must create a group resource configuration
        /// before you create a child resource configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CHILD</b> - A single resource that is part of a group resource configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ARN</b> - An Amazon Web Services resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CIDR</b> - A network segment, expressed as a range of IP addresses (a CIDR block).
        /// Use this type to share a portion of your network rather than an individual resource.
        /// A consumer accesses the resources within the CIDR range through a <c>Tunnel</c> VPC
        /// endpoint. You can't add a CIDR resource configuration to a service network. A CIDR
        /// resource configuration must be associated with a resource gateway whose DNS resolution
        /// is set to <c>IN_VPC</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceConfigurationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
