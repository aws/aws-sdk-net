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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The CIDR for an IPAM resource.
    /// </summary>
    public partial class IpamResourceCidr
    {
        private IpamComplianceStatus _complianceStatus;
        private string _ipamId;
        private string _ipamPoolId;
        private string _ipamScopeId;
        private double? _ipUsage;
        private IpamManagementState _managementState;
        private IpamOverlapStatus _overlapStatus;
        private string _resourceCidr;
        private string _resourceId;
        private string _resourceName;
        private string _resourceOwnerId;
        private string _resourceRegion;
        private List<IpamResourceTag> _resourceTags = new List<IpamResourceTag>();
        private IpamResourceType _resourceType;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// The compliance status of the IPAM resource. For more information on compliance statuses,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/monitor-cidr-compliance-ipam.html">Monitor
        /// CIDR usage by resource</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public IpamComplianceStatus ComplianceStatus
        {
            get { return this._complianceStatus; }
            set { this._complianceStatus = value; }
        }

        // Check to see if ComplianceStatus property is set
        internal bool IsSetComplianceStatus()
        {
            return this._complianceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The IPAM ID for an IPAM resource.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The pool ID for an IPAM resource.
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
        /// Gets and sets the property IpamScopeId. 
        /// <para>
        /// The scope ID for an IPAM resource.
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
        public double IpUsage
        {
            get { return this._ipUsage.GetValueOrDefault(); }
            set { this._ipUsage = value; }
        }

        // Check to see if IpUsage property is set
        internal bool IsSetIpUsage()
        {
            return this._ipUsage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagementState. 
        /// <para>
        /// The management state of the resource. For more information about management states,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/monitor-cidr-compliance-ipam.html">Monitor
        /// CIDR usage by resource</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public IpamManagementState ManagementState
        {
            get { return this._managementState; }
            set { this._managementState = value; }
        }

        // Check to see if ManagementState property is set
        internal bool IsSetManagementState()
        {
            return this._managementState != null;
        }

        /// <summary>
        /// Gets and sets the property OverlapStatus. 
        /// <para>
        /// The overlap status of an IPAM resource. The overlap status tells you if the CIDR for
        /// a resource overlaps with another CIDR in the scope. For more information on overlap
        /// statuses, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/monitor-cidr-compliance-ipam.html">Monitor
        /// CIDR usage by resource</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public IpamOverlapStatus OverlapStatus
        {
            get { return this._overlapStatus; }
            set { this._overlapStatus = value; }
        }

        // Check to see if OverlapStatus property is set
        internal bool IsSetOverlapStatus()
        {
            return this._overlapStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCidr. 
        /// <para>
        /// The CIDR for an IPAM resource.
        /// </para>
        /// </summary>
        public string ResourceCidr
        {
            get { return this._resourceCidr; }
            set { this._resourceCidr = value; }
        }

        // Check to see if ResourceCidr property is set
        internal bool IsSetResourceCidr()
        {
            return this._resourceCidr != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of an IPAM resource.
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
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of an IPAM resource.
        /// </para>
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOwnerId. 
        /// <para>
        /// The Amazon Web Services account number of the owner of an IPAM resource.
        /// </para>
        /// </summary>
        public string ResourceOwnerId
        {
            get { return this._resourceOwnerId; }
            set { this._resourceOwnerId = value; }
        }

        // Check to see if ResourceOwnerId property is set
        internal bool IsSetResourceOwnerId()
        {
            return this._resourceOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The Amazon Web Services Region for an IPAM resource.
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
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The tags for an IPAM resource.
        /// </para>
        /// </summary>
        public List<IpamResourceTag> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && this._resourceTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of IPAM resource.
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of a VPC.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}