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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains information about the domain controllers for a specified directory.
    /// </summary>
    public partial class DomainController
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where the domain controller is located.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// Identifier of the directory where the domain controller resides.
        /// </para>
        /// </summary>
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property DnsIpAddr. 
        /// <para>
        /// The IP address of the domain controller.
        /// </para>
        /// </summary>
        public string DnsIpAddr { get; set; }

        /// <summary>
        /// Checks to see if the DnsIpAddr property is set.
        /// </summary>
        internal bool IsSetDnsIpAddr() => this.DnsIpAddr != null;

        /// <summary>
        /// Gets and sets the property DnsIpv6Addr. 
        /// <para>
        /// The IPv6 address of the domain controller.
        /// </para>
        /// </summary>
        public string DnsIpv6Addr { get; set; }

        /// <summary>
        /// Checks to see if the DnsIpv6Addr property is set.
        /// </summary>
        internal bool IsSetDnsIpv6Addr() => this.DnsIpv6Addr != null;

        /// <summary>
        /// Gets and sets the property DomainControllerId. 
        /// <para>
        /// Identifies a specific domain controller in the directory.
        /// </para>
        /// </summary>
        public string DomainControllerId { get; set; }

        /// <summary>
        /// Checks to see if the DomainControllerId property is set.
        /// </summary>
        internal bool IsSetDomainControllerId() => this.DomainControllerId != null;

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// Specifies when the domain controller was created.
        /// </para>
        /// </summary>
        public DateTime? LaunchTime { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTime property is set.
        /// </summary>
        internal bool IsSetLaunchTime() => this.LaunchTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the domain controller.
        /// </para>
        /// </summary>
        public DomainControllerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusLastUpdatedDateTime. 
        /// <para>
        /// The date and time that the status was last updated.
        /// </para>
        /// </summary>
        public DateTime? StatusLastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StatusLastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetStatusLastUpdatedDateTime() => this.StatusLastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A description of the domain controller state.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// Identifier of the subnet in the VPC that contains the domain controller.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC that contains the domain controller.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
