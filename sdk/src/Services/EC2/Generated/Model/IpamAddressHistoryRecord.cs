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
    /// The historical record of a CIDR within an IPAM scope. For more information, see <a
    /// href="https://docs.aws.amazon.com/vpc/latest/ipam/view-history-cidr-ipam.html">View
    /// the history of IP addresses</a> in the <i>Amazon VPC IPAM User Guide</i>.
    /// </summary>
    public partial class IpamAddressHistoryRecord
    {
        private string _resourceCidr;
        private IpamComplianceStatus _resourceComplianceStatus;
        private string _resourceId;
        private string _resourceName;
        private IpamOverlapStatus _resourceOverlapStatus;
        private string _resourceOwnerId;
        private string _resourceRegion;
        private IpamAddressHistoryResourceType _resourceType;
        private DateTime? _sampledEndTime;
        private DateTime? _sampledStartTime;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property ResourceCidr. 
        /// <para>
        /// The CIDR of the resource.
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
        /// Gets and sets the property ResourceComplianceStatus. 
        /// <para>
        /// The compliance status of a resource. For more information on compliance statuses,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/monitor-cidr-compliance-ipam.html">Monitor
        /// CIDR usage by resource</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public IpamComplianceStatus ResourceComplianceStatus
        {
            get { return this._resourceComplianceStatus; }
            set { this._resourceComplianceStatus = value; }
        }

        // Check to see if ResourceComplianceStatus property is set
        internal bool IsSetResourceComplianceStatus()
        {
            return this._resourceComplianceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource.
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
        /// The name of the resource.
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
        /// Gets and sets the property ResourceOverlapStatus. 
        /// <para>
        /// The overlap status of an IPAM resource. The overlap status tells you if the CIDR for
        /// a resource overlaps with another CIDR in the scope. For more information on overlap
        /// statuses, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/monitor-cidr-compliance-ipam.html">Monitor
        /// CIDR usage by resource</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public IpamOverlapStatus ResourceOverlapStatus
        {
            get { return this._resourceOverlapStatus; }
            set { this._resourceOverlapStatus = value; }
        }

        // Check to see if ResourceOverlapStatus property is set
        internal bool IsSetResourceOverlapStatus()
        {
            return this._resourceOverlapStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOwnerId. 
        /// <para>
        /// The ID of the resource owner.
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
        /// The Amazon Web Services Region of the resource.
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource.
        /// </para>
        /// </summary>
        public IpamAddressHistoryResourceType ResourceType
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
        /// Gets and sets the property SampledEndTime. 
        /// <para>
        /// Sampled end time of the resource-to-CIDR association within the IPAM scope. Changes
        /// are picked up in periodic snapshots, so the end time may have occurred before this
        /// specific time.
        /// </para>
        /// </summary>
        public DateTime? SampledEndTime
        {
            get { return this._sampledEndTime; }
            set { this._sampledEndTime = value; }
        }

        // Check to see if SampledEndTime property is set
        internal bool IsSetSampledEndTime()
        {
            return this._sampledEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampledStartTime. 
        /// <para>
        /// Sampled start time of the resource-to-CIDR association within the IPAM scope. Changes
        /// are picked up in periodic snapshots, so the start time may have occurred before this
        /// specific time.
        /// </para>
        /// </summary>
        public DateTime? SampledStartTime
        {
            get { return this._sampledStartTime; }
            set { this._sampledStartTime = value; }
        }

        // Check to see if SampledStartTime property is set
        internal bool IsSetSampledStartTime()
        {
            return this._sampledStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID of the resource.
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