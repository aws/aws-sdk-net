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
    /// Container for the parameters to the ModifyIpamPolicyAllocationRules operation.
    /// Modifies the allocation rules in an IPAM policy.
    /// 
    ///  
    /// <para>
    /// An IPAM policy is a set of rules that define how public IPv4 addresses from IPAM pools
    /// are allocated to Amazon Web Services resources. Each rule maps an Amazon Web Services
    /// service to IPAM pools that the service will use to get IP addresses. A single policy
    /// can have multiple rules and be applied to multiple Amazon Web Services Regions. If
    /// the IPAM pool run out of addresses then the services fallback to Amazon-provided IP
    /// addresses. A policy can be applied to an individual Amazon Web Services account or
    /// an entity within Amazon Web Services Organizations.
    /// </para>
    ///  
    /// <para>
    /// Allocation rules are optional configurations within an IPAM policy that map Amazon
    /// Web Services resource types to specific IPAM pools. If no rules are defined, the resource
    /// types default to using Amazon-provided IP addresses.
    /// </para>
    /// </summary>
    public partial class ModifyIpamPolicyAllocationRulesRequest : AmazonEC2Request
    {
        private List<IpamPolicyAllocationRuleRequest> _allocationRules = AWSConfigs.InitializeCollections ? new List<IpamPolicyAllocationRuleRequest>() : null;
        private string _ipamPolicyId;
        private string _locale;
        private IpamPolicyResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property AllocationRules. 
        /// <para>
        /// The new allocation rules to apply to the IPAM policy.
        /// </para>
        ///  
        /// <para>
        /// Allocation rules are optional configurations within an IPAM policy that map Amazon
        /// Web Services resource types to specific IPAM pools. If no rules are defined, the resource
        /// types default to using Amazon-provided IP addresses.
        /// </para>
        /// </summary>
        public List<IpamPolicyAllocationRuleRequest> AllocationRules
        {
            get { return this._allocationRules; }
            set { this._allocationRules = value; }
        }

        // Check to see if AllocationRules property is set
        internal bool IsSetAllocationRules()
        {
            return this._allocationRules != null && (this._allocationRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpamPolicyId. 
        /// <para>
        /// The ID of the IPAM policy whose allocation rules you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamPolicyId
        {
            get { return this._ipamPolicyId; }
            set { this._ipamPolicyId = value; }
        }

        // Check to see if IpamPolicyId property is set
        internal bool IsSetIpamPolicyId()
        {
            return this._ipamPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale for which to modify the allocation rules.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type for which to modify the allocation rules.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services service or resource type that can use IP addresses through
        /// IPAM policies. Supported services and resource types include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Elastic IP addresses
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public IpamPolicyResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}