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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes an EC2 instance associated with an Auto Scaling group.
    /// </summary>
    public partial class AutoScalingInstanceDetails
    {
        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group for the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AutoScalingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingGroupName property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroupName() => this.AutoScalingGroupName != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        ///  The Availability Zone ID where the instance is located. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The last reported health status of this instance. <c>Healthy</c> means that the instance
        /// is healthy and should remain in service. <c>Unhealthy</c> means that the instance
        /// is unhealthy and Amazon EC2 Auto Scaling should terminate and replace it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        ///  The ID of the Amazon Machine Image (AMI) associated with the instance. This field
        /// shows the current AMI ID of the instance's root volume. It may differ from the original
        /// AMI used when the instance was first launched. 
        /// </para>
        ///  
        /// <para>
        ///  This field appears for: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Instances with root volume replacements through Instance Refresh
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instances launched with AMI overrides 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This field won't appear for:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Existing instances launched from Launch Templates without overrides
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Existing instances that didn’t have their root volume replaced through Instance Refresh
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 19)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The launch configuration used to launch the instance. This value is not available
        /// if you attached the instance to the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LaunchConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the LaunchConfigurationName property is set.
        /// </summary>
        internal bool IsSetLaunchConfigurationName() => this.LaunchConfigurationName != null;

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The launch template for the instance.
        /// </para>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplate property is set.
        /// </summary>
        internal bool IsSetLaunchTemplate() => this.LaunchTemplate != null;

        /// <summary>
        /// Gets and sets the property LifecycleState. 
        /// <para>
        /// The lifecycle state for the instance. The <c>Quarantined</c> state is not used. For
        /// more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-lifecycle.html">Amazon
        /// EC2 Auto Scaling instance lifecycle</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>Pending</c> | <c>Pending:Wait</c> | <c>Pending:Proceed</c> | <c>Quarantined</c>
        /// | <c>InService</c> | <c>Terminating</c> | <c>Terminating:Wait</c> | <c>Terminating:Proceed</c>
        /// | <c>Terminating:Retained</c> | <c>Terminated</c> | <c>Detaching</c> | <c>Detached</c>
        /// | <c>EnteringStandby</c> | <c>Standby</c> | <c>ReplacingRootVolume</c> | <c>ReplacingRootVolume:Wait</c>
        /// | <c>ReplacingRootVolume:Proceed</c> | <c>RootVolumeReplaced</c> | <c>Warmed:Pending</c>
        /// | <c>Warmed:Pending:Wait</c> | <c>Warmed:Pending:Proceed</c> | <c>Warmed:Pending:Retained</c>
        /// | <c>Warmed:Terminating</c> | <c>Warmed:Terminating:Wait</c> | <c>Warmed:Terminating:Proceed</c>
        /// | <c>Warmed:Terminating:Retained</c> | <c>Warmed:Terminated</c> | <c>Warmed:Stopped</c>
        /// | <c>Warmed:Running</c> | <c>Warmed:Hibernated</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string LifecycleState { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleState property is set.
        /// </summary>
        internal bool IsSetLifecycleState() => this.LifecycleState != null;

        /// <summary>
        /// Gets and sets the property ProtectedFromScaleIn. 
        /// <para>
        /// Indicates whether the instance is protected from termination by Amazon EC2 Auto Scaling
        /// when scaling in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? ProtectedFromScaleIn { get; set; }

        /// <summary>
        /// Checks to see if the ProtectedFromScaleIn property is set.
        /// </summary>
        internal bool IsSetProtectedFromScaleIn() => this.ProtectedFromScaleIn.HasValue;

        /// <summary>
        /// Gets and sets the property WeightedCapacity. 
        /// <para>
        /// The number of capacity units contributed by the instance based on its instance type.
        /// </para>
        ///  
        /// <para>
        /// Valid Range: Minimum value of 1. Maximum value of 999.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string WeightedCapacity { get; set; }

        /// <summary>
        /// Checks to see if the WeightedCapacity property is set.
        /// </summary>
        internal bool IsSetWeightedCapacity() => this.WeightedCapacity != null;
    }
}
