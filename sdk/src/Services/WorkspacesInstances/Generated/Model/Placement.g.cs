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

namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Defines instance placement configuration for WorkSpace Instance.
    /// </summary>
    public partial class Placement
    {
        /// <summary>
        /// Gets and sets the property Affinity. 
        /// <para>
        /// Specifies host affinity for dedicated instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Affinity { get; set; }

        /// <summary>
        /// Checks to see if the Affinity property is set.
        /// </summary>
        internal bool IsSetAffinity() => this.Affinity != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// Identifies the specific AWS availability zone.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// Unique identifier for placement group.
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
        /// Name of the placement group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property HostId. 
        /// <para>
        /// Identifies the specific dedicated host.
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
        /// ARN of the host resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string HostResourceGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the HostResourceGroupArn property is set.
        /// </summary>
        internal bool IsSetHostResourceGroupArn() => this.HostResourceGroupArn != null;

        /// <summary>
        /// Gets and sets the property PartitionNumber. 
        /// <para>
        /// Specifies partition number for partition placement groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PartitionNumber { get; set; }

        /// <summary>
        /// Checks to see if the PartitionNumber property is set.
        /// </summary>
        internal bool IsSetPartitionNumber() => this.PartitionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Defines instance tenancy configuration.
        /// </para>
        /// </summary>
        public TenancyEnum Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;
    }
}
