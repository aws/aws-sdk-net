/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private string _launchConfigurationName;
        private LaunchTemplateSpecification _launchTemplate;
        private string _lifecycleState;
        private bool? _protectedFromScaleIn;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group for the instance.
        /// </para>
        /// </summary>
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
        /// The last reported health status of this instance. "Healthy" means that the instance
        /// is healthy and should remain in service. "Unhealthy" means that the instance is unhealthy
        /// and Amazon EC2 Auto Scaling should terminate and replace it.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The launch configuration used to launch the instance. This value is not available
        /// if you attached the instance to the Auto Scaling group.
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
        /// The lifecycle state for the instance. For more information, see <a href="http://docs.aws.amazon.com/autoscaling/ec2/userguide/AutoScalingGroupLifecycle.html">Auto
        /// Scaling Lifecycle</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
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
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html#instance-protection">Instance
        /// Protection</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public bool ProtectedFromScaleIn
        {
            get { return this._protectedFromScaleIn.GetValueOrDefault(); }
            set { this._protectedFromScaleIn = value; }
        }

        // Check to see if ProtectedFromScaleIn property is set
        internal bool IsSetProtectedFromScaleIn()
        {
            return this._protectedFromScaleIn.HasValue; 
        }

    }
}