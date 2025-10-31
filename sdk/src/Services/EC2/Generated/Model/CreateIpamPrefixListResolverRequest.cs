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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the CreateIpamPrefixListResolver operation.
    /// Creates an IPAM prefix list resolver.
    /// 
    ///  
    /// <para>
    /// An IPAM prefix list resolver is a component that manages the synchronization between
    /// IPAM's CIDR selection rules and customer-managed prefix lists. It automates connectivity
    /// configurations by selecting CIDRs from IPAM's database based on your business logic
    /// and synchronizing them with prefix lists used in resources such as VPC route tables
    /// and security groups.
    /// </para>
    ///  
    /// <para>
    /// For more information about IPAM prefix list resolver, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/automate-prefix-list-updates.html">Automate
    /// prefix list updates with IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateIpamPrefixListResolverRequest : AmazonEC2Request
    {
        private AddressFamily _addressFamily;
        private string _clientToken;
        private string _description;
        private string _ipamId;
        private List<IpamPrefixListResolverRuleRequest> _rules = AWSConfigs.InitializeCollections ? new List<IpamPrefixListResolverRuleRequest>() : null;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The address family for the IPAM prefix list resolver. Valid values are <c>ipv4</c>
        /// and <c>ipv6</c>. You must create separate resolvers for IPv4 and IPv6 CIDRs as they
        /// cannot be mixed in the same resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AddressFamily AddressFamily
        {
            get { return this._addressFamily; }
            set { this._addressFamily = value; }
        }

        // Check to see if AddressFamily property is set
        internal bool IsSetAddressFamily()
        {
            return this._addressFamily != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the IPAM prefix list resolver to help you identify its purpose and
        /// configuration.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The ID of the IPAM that will serve as the source of the IP address database for CIDR
        /// selection. The IPAM must be in the Advanced tier to use this feature.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamId
        {
            get { return this._ipamId; }
            set { this._ipamId = value; }
        }

        // Check to see if IpamId property is set
        internal bool IsSetIpamId()
        {
            return this._ipamId != null;
        }

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
        /// </summary>
        public List<IpamPrefixListResolverRuleRequest> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the IPAM prefix list resolver during creation. Tags help you
        /// organize and manage your Amazon Web Services resources.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}