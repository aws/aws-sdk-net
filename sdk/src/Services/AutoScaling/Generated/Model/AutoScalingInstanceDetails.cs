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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
        private string _autoScalingGroupName;
        private string _availabilityZone;
        private string _healthStatus;
        private string _instanceId;
        private string _instanceType;
        private string _launchConfigurationName;
        private LaunchTemplateSpecification _launchTemplate;
        private string _lifecycleState;
        private bool? _protectedFromScaleIn;
        private string _weightedCapacity;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group for the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The last reported health status of this instance. <c>Healthy</c> means that the instance
        /// is healthy and should remain in service. <c>Unhealthy</c> means that the instance
        /// is unhealthy and Amazon EC2 Auto Scaling should terminate and replace it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=19)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The launch configuration used to launch the instance. This value is not available
        /// if you attached the instance to the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The launch template for the instance.
        /// </para>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate
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
        /// | <c>Terminated</c> | <c>Detaching</c> | <c>Detached</c> | <c>EnteringStandby</c>
        /// | <c>Standby</c> | <c>Warmed:Pending</c> | <c>Warmed:Pending:Wait</c> | <c>Warmed:Pending:Proceed</c>
        /// | <c>Warmed:Terminating</c> | <c>Warmed:Terminating:Wait</c> | <c>Warmed:Terminating:Proceed</c>
        /// | <c>Warmed:Terminated</c> | <c>Warmed:Stopped</c> | <c>Warmed:Running</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string LifecycleState
        {
            get { return this._lifecycleState; }
            set { this._lifecycleState = value; }
        }

        // Check to see if LifecycleState property is set
        internal bool IsSetLifecycleState()
        {
            return this._lifecycleState != null;
        }

        /// <summary>
        /// Gets and sets the property ProtectedFromScaleIn. 
        /// <para>
        /// Indicates whether the instance is protected from termination by Amazon EC2 Auto Scaling
        /// when scaling in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ProtectedFromScaleIn
        {
            get { return this._protectedFromScaleIn; }
            set { this._protectedFromScaleIn = value; }
        }

        // Check to see if ProtectedFromScaleIn property is set
        internal bool IsSetProtectedFromScaleIn()
        {
            return this._protectedFromScaleIn.HasValue; 
        }

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
        [AWSProperty(Min=1, Max=32)]
        public string WeightedCapacity
        {
            get { return this._weightedCapacity; }
            set { this._weightedCapacity = value; }
        }

        // Check to see if WeightedCapacity property is set
        internal bool IsSetWeightedCapacity()
        {
            return this._weightedCapacity != null;
        }

    }
}