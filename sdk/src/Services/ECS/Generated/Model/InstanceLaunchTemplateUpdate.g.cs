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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The updated launch template configuration for Amazon ECS Managed Instances. You can
    /// modify the instance profile, network configuration, storage settings, and instance
    /// requirements. Changes apply to new instances launched after the update.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">Store
    /// instance launch parameters in Amazon EC2 launch templates</a> in the <i>Amazon EC2
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class InstanceLaunchTemplateUpdate
    {
        /// <summary>
        /// Gets and sets the property CapacityReservations. 
        /// <para>
        /// The updated capacity reservations specifications for Amazon ECS Managed Instances.
        /// Changes to capacity reservations settings apply to new instances launched after the
        /// update.
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
        /// The updated Amazon Resource Name (ARN) of the instance profile. The new instance profile
        /// must have the necessary permissions for your tasks.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/managed-instances-instance-profile.html">Amazon
        /// ECS instance profile for Managed Instances</a> in the <i>Amazon ECS Developer Guide</i>.
        /// 
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
        /// Determines whether tags are propagated to the instance metadata service (IMDS) for
        /// Amazon EC2 instances launched by the Managed Instances capacity provider. When enabled,
        /// all tags associated with the instance are available through the instance metadata
        /// service. When disabled, tags are not propagated to IMDS.
        /// </para>
        ///  
        /// <para>
        /// Disable this setting if your tags contain characters that are not compatible with
        /// IMDS, such as <c>/</c>. IMDS requires tag keys to match the pattern <c>[0-9a-zA-Z\-_+=,.@:]{1,255}</c>.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html#work-with-tags-in-IMDS">Work
        /// with instance tags in instance metadata</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// The updated instance requirements for attribute-based instance type selection. Changes
        /// to instance requirements affect which instance types Amazon ECS selects for new instances.
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
        /// The updated local storage configuration for Amazon ECS Managed Instances. Changes
        /// to local storage settings apply to new instances launched after the update.
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
        /// CloudWatch provides two categories of monitoring: basic monitoring and detailed monitoring.
        /// By default, your managed instance is configured for basic monitoring. You can optionally
        /// enable detailed monitoring to help you more quickly identify and act on operational
        /// issues. You can enable or turn off detailed monitoring at launch or when the managed
        /// instance is running or stopped. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/detailed-monitoring-managed-instances.html">Detailed
        /// monitoring for Amazon ECS Managed Instances</a> in the Amazon ECS Developer Guide.
        /// </para>
        /// </summary>
        public ManagedInstancesMonitoringOptions Monitoring { get; set; }

        /// <summary>
        /// Checks to see if the Monitoring property is set.
        /// </summary>
        internal bool IsSetMonitoring() => this.Monitoring != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The updated network configuration for Amazon ECS Managed Instances. Changes to subnets
        /// and security groups affect new instances launched after the update.
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
        /// The updated storage configuration for Amazon ECS Managed Instances. Changes to storage
        /// settings apply to new instances launched after the update.
        /// </para>
        /// </summary>
        public ManagedInstancesStorageConfiguration StorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StorageConfiguration property is set.
        /// </summary>
        internal bool IsSetStorageConfiguration() => this.StorageConfiguration != null;
    }
}
