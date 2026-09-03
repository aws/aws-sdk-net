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
    /// The instance launch configuration for updating an Amazon ECS Managed Instances capacity
    /// provider. You cannot change <c>capacityOptionType</c> or <c>fipsEnabled</c> after
    /// the compute environment is created.
    /// </summary>
    public partial class InstanceLaunchTemplateUpdate
    {
        /// <summary>
        /// Gets and sets the property CapacityReservations. 
        /// <para>
        /// The updated capacity reservation configuration.
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
        /// The updated Amazon Resource Name (ARN) of the Amazon EC2 instance profile for the
        /// managed instances.
        /// </para>
        /// </summary>
        public string Ec2InstanceProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceProfileArn property is set.
        /// </summary>
        internal bool IsSetEc2InstanceProfileArn() => this.Ec2InstanceProfileArn != null;

        /// <summary>
        /// Gets and sets the property InstanceMetadataTagsPropagation. 
        /// <para>
        /// Specifies whether instance tags are accessible from the instance metadata service
        /// (IMDS).
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
        /// The updated instance type requirements for the capacity provider.
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
        /// The updated local storage configuration.
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
        /// The updated monitoring level. Valid values are <c>BASIC</c> and <c>DETAILED</c>.
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
        /// The updated network configuration for the managed instances.
        /// </para>
        /// </summary>
        public ManagedInstancesNetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// The updated storage configuration for the managed instances.
        /// </para>
        /// </summary>
        public ManagedInstancesStorageConfiguration StorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StorageConfiguration property is set.
        /// </summary>
        internal bool IsSetStorageConfiguration() => this.StorageConfiguration != null;
    }
}
