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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about the placement of an Amazon EC2 instance.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataPlacementDetails
    {
        /// <summary>
        /// Gets and sets the property Affinity. 
        /// <para>
        ///  The affinity setting for an instance on an EC2 Dedicated Host. 
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
        ///  The Availability Zone for the instance. 
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        ///  The name of the placement group for the instance. 
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
        ///  The ID of the Dedicated Host for the instance. 
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
        ///  The Amazon Resource Name (ARN) of the host resource group in which to launch the
        /// instances. 
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
        ///  The number of the partition the instance should launch in. 
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
        ///  Reserved for future use. 
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
        ///  The tenancy of the instance (if the instance is running in a VPC). An instance with
        /// a tenancy of dedicated runs on single-tenant hardware. 
        /// </para>
        /// </summary>
        public string Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;
    }
}
