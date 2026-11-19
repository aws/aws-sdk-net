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
    /// Describes the placement of an instance.
    /// </summary>
    public partial class LaunchTemplatePlacementRequest
    {
        /// <summary>
        /// Gets and sets the property Affinity. 
        /// <para>
        /// The affinity setting for an instance on a Dedicated Host.
        /// </para>
        /// </summary>
        public string Affinity { get; set; }

        /// <summary>
        /// Checks to see if the Affinity property is set.
        /// </summary>
        internal bool IsSetAffinity() => this.Affinity != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the instance.
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> can be specified, but
        /// not both
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone for the instance.
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> can be specified, but
        /// not both
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The Group Id of a placement group. You must specify the Placement Group <b>Group Id</b>
        /// to launch an instance in a shared placement group.
        /// </para>
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the placement group for the instance.
        /// </para>
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property HostId. 
        /// <para>
        /// The ID of the Dedicated Host for the instance.
        /// </para>
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// Checks to see if the HostId property is set.
        /// </summary>
        internal bool IsSetHostId() => this.HostId != null;

        /// <summary>
        /// Gets and sets the property HostResourceGroupArn. 
        /// <para>
        /// The ARN of the host resource group in which to launch the instances. If you specify
        /// a host resource group ARN, omit the <b>Tenancy</b> parameter or set it to <c>host</c>.
        /// </para>
        /// </summary>
        public string HostResourceGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the HostResourceGroupArn property is set.
        /// </summary>
        internal bool IsSetHostResourceGroupArn() => this.HostResourceGroupArn != null;

        /// <summary>
        /// Gets and sets the property PartitionNumber. 
        /// <para>
        /// The number of the partition the instance should launch in. Valid only if the placement
        /// group strategy is set to <c>partition</c>.
        /// </para>
        /// </summary>
        public int? PartitionNumber { get; set; }

        /// <summary>
        /// Checks to see if the PartitionNumber property is set.
        /// </summary>
        internal bool IsSetPartitionNumber() => this.PartitionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property SpreadDomain. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string SpreadDomain { get; set; }

        /// <summary>
        /// Checks to see if the SpreadDomain property is set.
        /// </summary>
        internal bool IsSetSpreadDomain() => this.SpreadDomain != null;

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// The tenancy of the instance. An instance with a tenancy of dedicated runs on single-tenant
        /// hardware.
        /// </para>
        /// </summary>
        public Tenancy Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;
    }
}
