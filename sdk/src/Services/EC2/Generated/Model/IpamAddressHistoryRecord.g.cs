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
    /// The historical record of a CIDR within an IPAM scope. For more information, see <a
    /// href="https://docs.aws.amazon.com/vpc/latest/ipam/view-history-cidr-ipam.html">View
    /// the history of IP addresses</a> in the <i>Amazon VPC IPAM User Guide</i>.
    /// </summary>
    public partial class IpamAddressHistoryRecord
    {
        /// <summary>
        /// Gets and sets the property ResourceCidr. 
        /// <para>
        /// The CIDR of the resource.
        /// </para>
        /// </summary>
        public string ResourceCidr { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCidr property is set.
        /// </summary>
        internal bool IsSetResourceCidr() => this.ResourceCidr != null;

        /// <summary>
        /// Gets and sets the property ResourceComplianceStatus. 
        /// <para>
        /// The compliance status of a resource. For more information on compliance statuses,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/monitor-cidr-compliance-ipam.html">Monitor
        /// CIDR usage by resource</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public IpamComplianceStatus ResourceComplianceStatus { get; set; }

        /// <summary>
        /// Checks to see if the ResourceComplianceStatus property is set.
        /// </summary>
        internal bool IsSetResourceComplianceStatus() => this.ResourceComplianceStatus != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource.
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
        /// The name of the resource.
        /// </para>
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property ResourceOverlapStatus. 
        /// <para>
        /// The overlap status of an IPAM resource. The overlap status tells you if the CIDR for
        /// a resource overlaps with another CIDR in the scope. For more information on overlap
        /// statuses, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/monitor-cidr-compliance-ipam.html">Monitor
        /// CIDR usage by resource</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public IpamOverlapStatus ResourceOverlapStatus { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOverlapStatus property is set.
        /// </summary>
        internal bool IsSetResourceOverlapStatus() => this.ResourceOverlapStatus != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerId. 
        /// <para>
        /// The ID of the resource owner.
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
        /// The Amazon Web Services Region of the resource.
        /// </para>
        /// </summary>
        public string ResourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRegion property is set.
        /// </summary>
        internal bool IsSetResourceRegion() => this.ResourceRegion != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource.
        /// </para>
        /// </summary>
        public IpamAddressHistoryResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SampledEndTime. 
        /// <para>
        /// Sampled end time of the resource-to-CIDR association within the IPAM scope. Changes
        /// are picked up in periodic snapshots, so the end time may have occurred before this
        /// specific time.
        /// </para>
        /// </summary>
        public DateTime? SampledEndTime { get; set; }

        /// <summary>
        /// Checks to see if the SampledEndTime property is set.
        /// </summary>
        internal bool IsSetSampledEndTime() => this.SampledEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property SampledStartTime. 
        /// <para>
        /// Sampled start time of the resource-to-CIDR association within the IPAM scope. Changes
        /// are picked up in periodic snapshots, so the start time may have occurred before this
        /// specific time.
        /// </para>
        /// </summary>
        public DateTime? SampledStartTime { get; set; }

        /// <summary>
        /// Checks to see if the SampledStartTime property is set.
        /// </summary>
        internal bool IsSetSampledStartTime() => this.SampledStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID of the resource.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
