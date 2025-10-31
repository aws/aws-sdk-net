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
    /// Describes a CIDR selection rule to include in a request. This is used when creating
    /// or modifying resolver rules.
    /// 
    ///  
    /// <para>
    /// CIDR selection rules define the business logic for selecting CIDRs from IPAM. If a
    /// CIDR matches any of the rules, it will be included. If a rule has multiple conditions,
    /// the CIDR has to match every condition of that rule. You can create a prefix list resolver
    /// without any CIDR selection rules, but it will generate empty versions (containing
    /// no CIDRs) until you add rules.
    /// </para>
    ///  
    /// <para>
    /// There are three rule types:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Static CIDR</b>: A fixed list of CIDRs that do not change (like a manual list
    /// replicated across Regions).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>IPAM pool CIDR</b>: CIDRs from specific IPAM pools (like all CIDRs from your IPAM
    /// production pool).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Scope resource CIDR</b>: CIDRs for Amazon Web Services resources like VPCs, subnets,
    /// and EIPs within a specific IPAM scope.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Condition availability by resource type:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Only 2 of the 3 rule types support conditions - <b>IPAM pool CIDR</b> and <b>Scope
    /// resource CIDR</b>. <b>Static CIDR</b> rules cannot have conditions.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Condition available for the <b>IPAM pool CIDR</b> resource type:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Property:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// IPAM Pool ID
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CIDR (like 10.24.34.0/23)
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Operation: Equals/Not equals
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Value: The value on which to match the condition
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Conditions for the <b>Scope resource CIDR</b> resource type:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Property:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Resource ID: The unique ID of a resource (like vpc-1234567890abcdef0)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Resource type (like VPC or Subnet)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Resource owner (like 111122223333)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Resource region (like us-east-1)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Resource tag (like key: name, value: dev-vpc-1)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CIDR (like 10.24.34.0/23)
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Operation: Equals/Not equals
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Value: The value on which to match the condition
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// When setting conditions for a rule, one or more conditions is required.
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class IpamPrefixListResolverRuleRequest
    {
        private List<IpamPrefixListResolverRuleConditionRequest> _conditions = AWSConfigs.InitializeCollections ? new List<IpamPrefixListResolverRuleConditionRequest>() : null;
        private string _ipamScopeId;
        private IpamResourceType _resourceType;
        private IpamPrefixListResolverRuleType _ruleType;
        private string _staticCidr;

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// The conditions that determine which CIDRs are selected by this rule. Conditions specify
        /// criteria such as resource type, tags, account IDs, and Regions.
        /// </para>
        /// </summary>
        public List<IpamPrefixListResolverRuleConditionRequest> Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }

        // Check to see if Conditions property is set
        internal bool IsSetConditions()
        {
            return this._conditions != null && (this._conditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpamScopeId. 
        /// <para>
        /// The ID of the IPAM scope from which to select CIDRs. This determines whether to select
        /// from public or private IP address space.
        /// </para>
        /// </summary>
        public string IpamScopeId
        {
            get { return this._ipamScopeId; }
            set { this._ipamScopeId = value; }
        }

        // Check to see if IpamScopeId property is set
        internal bool IsSetIpamScopeId()
        {
            return this._ipamScopeId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// For rules of type <c>ipam-resource-cidr</c>, this is the resource type.
        /// </para>
        /// </summary>
        public IpamResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        /// The type of CIDR selection rule. Valid values include <c>include</c> for selecting
        /// CIDRs that match the conditions, and <c>exclude</c> for excluding CIDRs that match
        /// the conditions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IpamPrefixListResolverRuleType RuleType
        {
            get { return this._ruleType; }
            set { this._ruleType = value; }
        }

        // Check to see if RuleType property is set
        internal bool IsSetRuleType()
        {
            return this._ruleType != null;
        }

        /// <summary>
        /// Gets and sets the property StaticCidr. 
        /// <para>
        /// A fixed list of CIDRs that do not change (like a manual list replicated across Regions).
        /// </para>
        /// </summary>
        public string StaticCidr
        {
            get { return this._staticCidr; }
            set { this._staticCidr = value; }
        }

        // Check to see if StaticCidr property is set
        internal bool IsSetStaticCidr()
        {
            return this._staticCidr != null;
        }

    }
}