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
    /// The CIDR for an IPAM resource.
    /// </summary>
    public partial class IpamResourceCidr
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// The compliance status of the IPAM resource. For more information on compliance statuses,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/monitor-cidr-compliance-ipam.html">Monitor
        /// CIDR usage by resource</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public IpamComplianceStatus ComplianceStatus { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceStatus property is set.
        /// </summary>
        internal bool IsSetComplianceStatus() => this.ComplianceStatus != null;

        /// <summary>
        /// Gets and sets the property IpUsage. 
        /// <para>
        /// The percentage of IP address space in use. To convert the decimal to a percentage,
        /// multiply the decimal by 100. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For resources that are VPCs, this is the percentage of IP address space in the VPC
        /// that's taken up by subnet CIDRs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For resources that are subnets, if the subnet has an IPv4 CIDR provisioned to it,
        /// this is the percentage of IPv4 address space in the subnet that's in use. If the subnet
        /// has an IPv6 CIDR provisioned to it, the percentage of IPv6 address space in use is
        /// not represented. The percentage of IPv6 address space in use cannot currently be calculated.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For resources that are public IPv4 pools, this is the percentage of IP address space
        /// in the pool that's been allocated to Elastic IP addresses (EIPs). 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public double? IpUsage { get; set; }

        /// <summary>
        /// Checks to see if the IpUsage property is set.
        /// </summary>
        internal bool IsSetIpUsage() => this.IpUsage.HasValue;

        /// <summary>
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The IPAM ID for an IPAM resource.
        /// </para>
        /// </summary>
        public string IpamId { get; set; }

        /// <summary>
        /// Checks to see if the IpamId property is set.
        /// </summary>
        internal bool IsSetIpamId() => this.IpamId != null;

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The pool ID for an IPAM resource.
        /// </para>
        /// </summary>
        public string IpamPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPoolId property is set.
        /// </summary>
        internal bool IsSetIpamPoolId() => this.IpamPoolId != null;

        /// <summary>
        /// Gets and sets the property IpamScopeId. 
        /// <para>
        /// The scope ID for an IPAM resource.
        /// </para>
        /// </summary>
        public string IpamScopeId { get; set; }

        /// <summary>
        /// Checks to see if the IpamScopeId property is set.
        /// </summary>
        internal bool IsSetIpamScopeId() => this.IpamScopeId != null;

        /// <summary>
        /// Gets and sets the property ManagementState. 
        /// <para>
        /// The management state of the resource. For more information about management states,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/monitor-cidr-compliance-ipam.html">Monitor
        /// CIDR usage by resource</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public IpamManagementState ManagementState { get; set; }

        /// <summary>
        /// Checks to see if the ManagementState property is set.
        /// </summary>
        internal bool IsSetManagementState() => this.ManagementState != null;

        /// <summary>
        /// Gets and sets the property OverlapStatus. 
        /// <para>
        /// The overlap status of an IPAM resource. The overlap status tells you if the CIDR for
        /// a resource overlaps with another CIDR in the scope. For more information on overlap
        /// statuses, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/monitor-cidr-compliance-ipam.html">Monitor
        /// CIDR usage by resource</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public IpamOverlapStatus OverlapStatus { get; set; }

        /// <summary>
        /// Checks to see if the OverlapStatus property is set.
        /// </summary>
        internal bool IsSetOverlapStatus() => this.OverlapStatus != null;

        /// <summary>
        /// Gets and sets the property ResourceCidr. 
        /// <para>
        /// The CIDR for an IPAM resource.
        /// </para>
        /// </summary>
        public string ResourceCidr { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCidr property is set.
        /// </summary>
        internal bool IsSetResourceCidr() => this.ResourceCidr != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of an IPAM resource.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of an IPAM resource.
        /// </para>
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerId. 
        /// <para>
        /// The Amazon Web Services account number of the owner of an IPAM resource.
        /// </para>
        /// </summary>
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerId() => this.ResourceOwnerId != null;

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The Amazon Web Services Region for an IPAM resource.
        /// </para>
        /// </summary>
        public string ResourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRegion property is set.
        /// </summary>
        internal bool IsSetResourceRegion() => this.ResourceRegion != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The tags for an IPAM resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpamResourceTag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<IpamResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of IPAM resource.
        /// </para>
        /// </summary>
        public IpamResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of a VPC.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
