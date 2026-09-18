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
    /// Provides details about an auto scaling group.
    /// </summary>
    public partial class AwsAutoScalingAutoScalingGroupDetails
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The list of Availability Zones for the automatic scaling group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsAutoScalingAutoScalingGroupAvailabilityZonesListDetails> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsAutoScalingAutoScalingGroupAvailabilityZonesListDetails>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapacityRebalance. 
        /// <para>
        /// Indicates whether capacity rebalancing is enabled. 
        /// </para>
        /// </summary>
        public bool? CapacityRebalance { get; set; }

        /// <summary>
        /// Checks to see if the CapacityRebalance property is set.
        /// </summary>
        internal bool IsSetCapacityRebalance() => this.CapacityRebalance.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// Indicates when the auto scaling group was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime != null;

        /// <summary>
        /// Gets and sets the property HealthCheckGracePeriod. 
        /// <para>
        /// The amount of time, in seconds, that Amazon EC2 Auto Scaling waits before it checks
        /// the health status of an EC2 instance that has come into service.
        /// </para>
        /// </summary>
        public int? HealthCheckGracePeriod { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckGracePeriod property is set.
        /// </summary>
        internal bool IsSetHealthCheckGracePeriod() => this.HealthCheckGracePeriod.HasValue;

        /// <summary>
        /// Gets and sets the property HealthCheckType. 
        /// <para>
        /// The service to use for the health checks. Valid values are <c>EC2</c> or <c>ELB</c>.
        /// </para>
        /// </summary>
        public string HealthCheckType { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckType property is set.
        /// </summary>
        internal bool IsSetHealthCheckType() => this.HealthCheckType != null;

        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The name of the launch configuration.
        /// </para>
        /// </summary>
        public string LaunchConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the LaunchConfigurationName property is set.
        /// </summary>
        internal bool IsSetLaunchConfigurationName() => this.LaunchConfigurationName != null;

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The launch template to use.
        /// </para>
        /// </summary>
        public AwsAutoScalingAutoScalingGroupLaunchTemplateLaunchTemplateSpecification LaunchTemplate { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplate property is set.
        /// </summary>
        internal bool IsSetLaunchTemplate() => this.LaunchTemplate != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerNames. 
        /// <para>
        /// The list of load balancers associated with the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LoadBalancerNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LoadBalancerNames property is set.
        /// </summary>
        internal bool IsSetLoadBalancerNames() => this.LoadBalancerNames != null && (this.LoadBalancerNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MixedInstancesPolicy. 
        /// <para>
        /// The mixed instances policy for the automatic scaling group.
        /// </para>
        /// </summary>
        public AwsAutoScalingAutoScalingGroupMixedInstancesPolicyDetails MixedInstancesPolicy { get; set; }

        /// <summary>
        /// Checks to see if the MixedInstancesPolicy property is set.
        /// </summary>
        internal bool IsSetMixedInstancesPolicy() => this.MixedInstancesPolicy != null;
    }
}
