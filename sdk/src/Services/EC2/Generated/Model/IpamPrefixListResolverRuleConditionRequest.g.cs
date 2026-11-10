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
    /// Describes a condition used when creating or modifying resolver rules.
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
    /// There are three rule types. Only 2 of the 3 rule types support conditions - <b>IPAM
    /// pool CIDR</b> and <b>Scope resource CIDR</b>. <b>Static CIDR</b> rules cannot have
    /// conditions.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Static CIDR</b>: A fixed list of CIDRs that do not change (like a manual list
    /// replicated across Regions)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>IPAM pool CIDR</b>: CIDRs from specific IPAM pools (like all CIDRs from your IPAM
    /// production pool)
    /// </para>
    ///  
    /// <para>
    /// If you choose this option, choose the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>IPAM scope</b>: Select the IPAM scope to search for resources
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Conditions:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Property</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>IPAM pool ID</b>: Select an IPAM pool that contains the resources
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>CIDR</b> (like 10.24.34.0/23)
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Operation</b>: Equals/Not equals
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Value</b>: The value on which to match the condition
    /// </para>
    ///  </li> </ul> </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Scope resource CIDR</b>: CIDRs from Amazon Web Services resources like VPCs, subnets,
    /// EIPs within an IPAM scope
    /// </para>
    ///  
    /// <para>
    /// If you choose this option, choose the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>IPAM scope</b>: Select the IPAM scope to search for resources
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Resource type</b>: Select a resource, like a VPC or subnet.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Conditions</b>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Property</b>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Resource ID: The unique ID of a resource (like vpc-1234567890abcdef0)
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
    ///  <b>Operation</b>: Equals/Not equals
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Value</b>: The value on which to match the condition
    /// </para>
    ///  </li> </ul> </li> </ul> </li> </ul>
    /// </summary>
    public partial class IpamPrefixListResolverRuleConditionRequest
    {
        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// A CIDR block to match against. This condition selects CIDRs that fall within or match
        /// the specified CIDR range.
        /// </para>
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool to match against. This condition selects CIDRs that belong
        /// to the specified IPAM pool.
        /// </para>
        /// </summary>
        public string IpamPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPoolId property is set.
        /// </summary>
        internal bool IsSetIpamPoolId() => this.IpamPoolId != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The operation to perform when evaluating this condition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IpamPrefixListResolverRuleConditionOperation Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the Amazon Web Services resource to match against. This condition selects
        /// CIDRs associated with the specified resource.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        /// The Amazon Web Services account ID that owns the resources to match against. This
        /// condition selects CIDRs from resources owned by the specified account.
        /// </para>
        /// </summary>
        public string ResourceOwner { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwner property is set.
        /// </summary>
        internal bool IsSetResourceOwner() => this.ResourceOwner != null;

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The Amazon Web Services Region where the resources are located. This condition selects
        /// CIDRs from resources in the specified Region.
        /// </para>
        /// </summary>
        public string ResourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRegion property is set.
        /// </summary>
        internal bool IsSetResourceRegion() => this.ResourceRegion != null;

        /// <summary>
        /// Gets and sets the property ResourceTag. 
        /// <para>
        /// A tag key-value pair to match against. This condition selects CIDRs from resources
        /// that have the specified tag.
        /// </para>
        /// </summary>
        public RequestIpamResourceTag ResourceTag { get; set; }

        /// <summary>
        /// Checks to see if the ResourceTag property is set.
        /// </summary>
        internal bool IsSetResourceTag() => this.ResourceTag != null;
    }
}
