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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The instance launch configuration for an Amazon ECS Managed Instances capacity provider.
    /// Specifies the instance profile, networking, instance selection constraints, capacity
    /// pricing model, storage, and monitoring settings.
    /// </summary>
    public partial class InstanceLaunchTemplate
    {
        /// <summary>
        /// Gets and sets the property CapacityOptionType. 
        /// <para>
        /// The capacity pricing model for the managed instances. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ON_DEMAND</c> (default) — On-Demand pricing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SPOT</c> — Spot Instances, which can provide significant cost savings for fault-tolerant
        /// workloads.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string CapacityOptionType { get; set; }

        /// <summary>
        /// Checks to see if the CapacityOptionType property is set.
        /// </summary>
        internal bool IsSetCapacityOptionType() => this.CapacityOptionType != null;

        /// <summary>
        /// Gets and sets the property CapacityReservations. 
        /// <para>
        /// The capacity reservation configuration for the managed instances. Use this to target
        /// On-Demand Capacity Reservations or Reserved Instances for predictable capacity and
        /// cost optimization.
        /// </para>
        /// </summary>
        public CapacityReservationRequest CapacityReservations { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservations property is set.
        /// </summary>
        internal bool IsSetCapacityReservations() => this.CapacityReservations != null;

        /// <summary>
        /// Gets and sets the property Ec2InstanceProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon EC2 instance profile for the managed
        /// instances. The instance profile must use the <c>AmazonECSInstanceRolePolicyForManagedInstances</c>
        /// managed policy with a trust policy for <c>ec2.amazonaws.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Ec2InstanceProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceProfileArn property is set.
        /// </summary>
        internal bool IsSetEc2InstanceProfileArn() => this.Ec2InstanceProfileArn != null;

        /// <summary>
        /// Gets and sets the property FipsEnabled. 
        /// <para>
        /// Specifies whether FIPS 140-2 validated cryptographic modules are enabled on the managed
        /// instances. Not available in all Regions.
        /// </para>
        /// </summary>
        public bool? FipsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the FipsEnabled property is set.
        /// </summary>
        internal bool IsSetFipsEnabled() => this.FipsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceMetadataTagsPropagation. 
        /// <para>
        /// Specifies whether instance tags are accessible from the instance metadata service
        /// (IMDS). If not specified, instance tags are not accessible from IMDS.
        /// </para>
        /// </summary>
        public bool? InstanceMetadataTagsPropagation { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMetadataTagsPropagation property is set.
        /// </summary>
        internal bool IsSetInstanceMetadataTagsPropagation() => this.InstanceMetadataTagsPropagation.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The instance type requirements for the capacity provider. Use this to constrain which
        /// Amazon EC2 instance types Amazon ECS can launch. If not specified, all available instance
        /// types are eligible.
        /// </para>
        /// </summary>
        public InstanceRequirementsRequest InstanceRequirements { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRequirements property is set.
        /// </summary>
        internal bool IsSetInstanceRequirements() => this.InstanceRequirements != null;

        /// <summary>
        /// Gets and sets the property LocalStorageConfiguration. 
        /// <para>
        /// The local storage configuration for the managed instances. If not specified, instance
        /// store volumes are not available to containers.
        /// </para>
        /// </summary>
        public ManagedInstancesLocalStorageConfiguration LocalStorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LocalStorageConfiguration property is set.
        /// </summary>
        internal bool IsSetLocalStorageConfiguration() => this.LocalStorageConfiguration != null;

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// The level of CloudWatch monitoring for the managed instances. Valid values are <c>BASIC</c>
        /// and <c>DETAILED</c>.
        /// </para>
        /// </summary>
        public string Monitoring { get; set; }

        /// <summary>
        /// Checks to see if the Monitoring property is set.
        /// </summary>
        internal bool IsSetMonitoring() => this.Monitoring != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the managed instances. Specifies the VPC subnets and
        /// security groups where instances are launched.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ManagedInstancesNetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// The storage configuration for the managed instances. Configures the root EBS volume
        /// size. If not specified, the service uses the default EBS volume size for the instance
        /// type.
        /// </para>
        /// </summary>
        public ManagedInstancesStorageConfiguration StorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StorageConfiguration property is set.
        /// </summary>
        internal bool IsSetStorageConfiguration() => this.StorageConfiguration != null;
    }
}
