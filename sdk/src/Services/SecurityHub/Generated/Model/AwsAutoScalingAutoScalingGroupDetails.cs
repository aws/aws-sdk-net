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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private List<AwsAutoScalingAutoScalingGroupAvailabilityZonesListDetails> _availabilityZones = AWSConfigs.InitializeCollections ? new List<AwsAutoScalingAutoScalingGroupAvailabilityZonesListDetails>() : null;
        private bool? _capacityRebalance;
        private string _createdTime;
        private int? _healthCheckGracePeriod;
        private string _healthCheckType;
        private string _launchConfigurationName;
        private AwsAutoScalingAutoScalingGroupLaunchTemplateLaunchTemplateSpecification _launchTemplate;
        private List<string> _loadBalancerNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AwsAutoScalingAutoScalingGroupMixedInstancesPolicyDetails _mixedInstancesPolicy;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The list of Availability Zones for the automatic scaling group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsAutoScalingAutoScalingGroupAvailabilityZonesListDetails> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapacityRebalance. 
        /// <para>
        /// Indicates whether capacity rebalancing is enabled. 
        /// </para>
        /// </summary>
        public bool? CapacityRebalance
        {
            get { return this._capacityRebalance; }
            set { this._capacityRebalance = value; }
        }

        // Check to see if CapacityRebalance property is set
        internal bool IsSetCapacityRebalance()
        {
            return this._capacityRebalance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// Indicates when the auto scaling group was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckGracePeriod. 
        /// <para>
        /// The amount of time, in seconds, that Amazon EC2 Auto Scaling waits before it checks
        /// the health status of an EC2 instance that has come into service.
        /// </para>
        /// </summary>
        public int? HealthCheckGracePeriod
        {
            get { return this._healthCheckGracePeriod; }
            set { this._healthCheckGracePeriod = value; }
        }

        // Check to see if HealthCheckGracePeriod property is set
        internal bool IsSetHealthCheckGracePeriod()
        {
            return this._healthCheckGracePeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckType. 
        /// <para>
        /// The service to use for the health checks. Valid values are <c>EC2</c> or <c>ELB</c>.
        /// </para>
        /// </summary>
        public string HealthCheckType
        {
            get { return this._healthCheckType; }
            set { this._healthCheckType = value; }
        }

        // Check to see if HealthCheckType property is set
        internal bool IsSetHealthCheckType()
        {
            return this._healthCheckType != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The name of the launch configuration.
        /// </para>
        /// </summary>
        public string LaunchConfigurationName
        {
            get { return this._launchConfigurationName; }
            set { this._launchConfigurationName = value; }
        }

        // Check to see if LaunchConfigurationName property is set
        internal bool IsSetLaunchConfigurationName()
        {
            return this._launchConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The launch template to use.
        /// </para>
        /// </summary>
        public AwsAutoScalingAutoScalingGroupLaunchTemplateLaunchTemplateSpecification LaunchTemplate
        {
            get { return this._launchTemplate; }
            set { this._launchTemplate = value; }
        }

        // Check to see if LaunchTemplate property is set
        internal bool IsSetLaunchTemplate()
        {
            return this._launchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerNames. 
        /// <para>
        /// The list of load balancers associated with the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LoadBalancerNames
        {
            get { return this._loadBalancerNames; }
            set { this._loadBalancerNames = value; }
        }

        // Check to see if LoadBalancerNames property is set
        internal bool IsSetLoadBalancerNames()
        {
            return this._loadBalancerNames != null && (this._loadBalancerNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MixedInstancesPolicy. 
        /// <para>
        /// The mixed instances policy for the automatic scaling group.
        /// </para>
        /// </summary>
        public AwsAutoScalingAutoScalingGroupMixedInstancesPolicyDetails MixedInstancesPolicy
        {
            get { return this._mixedInstancesPolicy; }
            set { this._mixedInstancesPolicy = value; }
        }

        // Check to see if MixedInstancesPolicy property is set
        internal bool IsSetMixedInstancesPolicy()
        {
            return this._mixedInstancesPolicy != null;
        }

    }
}