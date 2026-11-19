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
    /// Describes the instances that were launched by the fleet.
    /// </summary>
    public partial class CreateFleetInstance
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone in which the instance was launched. For example,
        /// <c>us-east-2a</c>.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <c>instant</c>.
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
        /// The ID of the Availability Zone in which the instance was launched. For example, <c>use2-az1</c>.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <c>instant</c>.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The IDs of the instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceIds property is set.
        /// </summary>
        internal bool IsSetInstanceIds() => this.InstanceIds != null && (this.InstanceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LaunchTemplateAndOverrides. 
        /// <para>
        /// The launch templates and overrides that were used for launching the instances. The
        /// values that you specify in the Overrides replace the values in the launch template.
        /// </para>
        /// </summary>
        public LaunchTemplateAndOverridesResponse LaunchTemplateAndOverrides { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplateAndOverrides property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateAndOverrides() => this.LaunchTemplateAndOverrides != null;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// Indicates if the instance that was launched is a Spot, On-Demand, Capacity Block for
        /// ML, or interruptible Capacity Reservation instance.
        /// </para>
        /// </summary>
        public InstanceLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The value is <c>windows</c> for Windows instances in an EC2 Fleet. Otherwise, the
        /// value is blank.
        /// </para>
        /// </summary>
        public PlatformValues Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in which the instance was launched.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <c>instant</c>.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;
    }
}
