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
    /// Describes a condition within a CIDR selection rule. Conditions define the criteria
    /// for selecting CIDRs from IPAM's database based on resource attributes.
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
    public partial class IpamPrefixListResolverRuleCondition
    {
        private string _cidr;
        private string _ipamPoolId;
        private IpamPrefixListResolverRuleConditionOperation _operation;
        private string _resourceId;
        private string _resourceOwner;
        private string _resourceRegion;
        private IpamResourceTag _resourceTag;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// A CIDR block to match against. This condition selects CIDRs that fall within or match
        /// the specified CIDR range.
        /// </para>
        /// </summary>
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool to match against. This condition selects CIDRs that belong
        /// to the specified IPAM pool.
        /// </para>
        /// </summary>
        public string IpamPoolId
        {
            get { return this._ipamPoolId; }
            set { this._ipamPoolId = value; }
        }

        // Check to see if IpamPoolId property is set
        internal bool IsSetIpamPoolId()
        {
            return this._ipamPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The operation to perform when evaluating this condition. Valid values include <c>equals</c>,
        /// <c>not-equals</c>, <c>contains</c>, and <c>not-contains</c>.
        /// </para>
        /// </summary>
        public IpamPrefixListResolverRuleConditionOperation Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the Amazon Web Services resource to match against. This condition selects
        /// CIDRs associated with the specified resource.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        /// The Amazon Web Services account ID that owns the resources to match against. This
        /// condition selects CIDRs from resources owned by the specified account.
        /// </para>
        /// </summary>
        public string ResourceOwner
        {
            get { return this._resourceOwner; }
            set { this._resourceOwner = value; }
        }

        // Check to see if ResourceOwner property is set
        internal bool IsSetResourceOwner()
        {
            return this._resourceOwner != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The Amazon Web Services Region where the resources are located. This condition selects
        /// CIDRs from resources in the specified Region.
        /// </para>
        /// </summary>
        public string ResourceRegion
        {
            get { return this._resourceRegion; }
            set { this._resourceRegion = value; }
        }

        // Check to see if ResourceRegion property is set
        internal bool IsSetResourceRegion()
        {
            return this._resourceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTag. 
        /// <para>
        /// A tag key-value pair to match against. This condition selects CIDRs from resources
        /// that have the specified tag.
        /// </para>
        /// </summary>
        public IpamResourceTag ResourceTag
        {
            get { return this._resourceTag; }
            set { this._resourceTag = value; }
        }

        // Check to see if ResourceTag property is set
        internal bool IsSetResourceTag()
        {
            return this._resourceTag != null;
        }

    }
}