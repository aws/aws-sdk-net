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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIpamPrefixListResolver operation. Creates
    /// an IPAM prefix list resolver. <para> An IPAM prefix list resolver is a component that
    /// manages the synchronization between IPAM's CIDR selection rules and customer-managed
    /// prefix lists. It automates connectivity configurations by selecting CIDRs from IPAM's
    /// database based on your business logic and synchronizing them with prefix lists used
    /// in resources such as VPC route tables and security groups. </para> <para> For more
    /// information about IPAM prefix list resolver, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/automate-prefix-list-updates.html">Automate
    /// prefix list updates with IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>. </para>
    /// </summary>
    public partial class CreateIpamPrefixListResolverRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The address family for the IPAM prefix list resolver. Valid values are <c>ipv4</c>
        /// and <c>ipv6</c>. You must create separate resolvers for IPv4 and IPv6 CIDRs as they
        /// cannot be mixed in the same resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AddressFamily AddressFamily { get; set; }

        /// <summary>
        /// Checks to see if the AddressFamily property is set.
        /// </summary>
        internal bool IsSetAddressFamily() => this.AddressFamily != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the IPAM prefix list resolver to help you identify its purpose and
        /// configuration.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The ID of the IPAM that will serve as the source of the IP address database for CIDR
        /// selection. The IPAM must be in the Advanced tier to use this feature.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamId { get; set; }

        /// <summary>
        /// Checks to see if the IpamId property is set.
        /// </summary>
        internal bool IsSetIpamId() => this.IpamId != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The CIDR selection rules for the resolver.
        /// </para>
        ///  
        /// <para>
        /// CIDR selection rules define the business logic for selecting CIDRs from IPAM. If a
        /// CIDR matches any of the rules, it will be included. If a rule has multiple conditions,
        /// the CIDR has to match every condition of that rule. You can create a prefix list resolver
        /// without any CIDR selection rules, but it will generate empty versions (containing
        /// no CIDRs) until you add rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpamPrefixListResolverRuleRequest> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<IpamPrefixListResolverRuleRequest>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the IPAM prefix list resolver during creation. Tags help you
        /// organize and manage your Amazon Web Services resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
