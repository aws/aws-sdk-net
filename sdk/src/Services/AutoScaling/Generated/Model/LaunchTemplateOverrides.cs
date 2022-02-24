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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes an override for a launch template. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-configuring-overrides.html">Configuring
    /// overrides</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </summary>
    public partial class LaunchTemplateOverrides
    {
        private InstanceRequirements _instanceRequirements;
        private string _instanceType;
        private LaunchTemplateSpecification _launchTemplateSpecification;
        private string _weightedCapacity;

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The instance requirements. When you specify instance requirements, Amazon EC2 Auto
        /// Scaling finds instance types that satisfy your requirements, and then uses your On-Demand
        /// and Spot allocation strategies to launch instances from these instance types, in the
        /// same way as when you specify a list of specific instance types. 
        /// </para>
        /// </summary>
        public InstanceRequirements InstanceRequirements
        {
            get { return this._instanceRequirements; }
            set { this._instanceRequirements = value; }
        }

        // Check to see if InstanceRequirements property is set
        internal bool IsSetInstanceRequirements()
        {
            return this._instanceRequirements != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type, such as <code>m3.xlarge</code>. You must use an instance type that
        /// is supported in your requested Region and Availability Zones. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        /// Gets and sets the property LaunchTemplateSpecification. 
        /// <para>
        /// Provides a launch template for the specified instance type or instance requirements.
        /// For example, some instance types might require a launch template with a different
        /// AMI. If not provided, Amazon EC2 Auto Scaling uses the launch template that's defined
        /// for your mixed instances policy. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-mixed-instances-groups-launch-template-overrides.html">Specifying
        /// a different launch template for an instance type</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>. 
        /// </para>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplateSpecification
        {
            get { return this._launchTemplateSpecification; }
            set { this._launchTemplateSpecification = value; }
        }

        // Check to see if LaunchTemplateSpecification property is set
        internal bool IsSetLaunchTemplateSpecification()
        {
            return this._launchTemplateSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property WeightedCapacity. 
        /// <para>
        /// The number of capacity units provided by the instance type specified in <code>InstanceType</code>
        /// in terms of virtual CPUs, memory, storage, throughput, or other relative performance
        /// characteristic. When a Spot or On-Demand Instance is launched, the capacity units
        /// count toward the desired capacity. Amazon EC2 Auto Scaling launches instances until
        /// the desired capacity is totally fulfilled, even if this results in an overage. For
        /// example, if there are two units remaining to fulfill capacity, and Amazon EC2 Auto
        /// Scaling can only launch an instance with a <code>WeightedCapacity</code> of five units,
        /// the instance is launched, and the desired capacity is exceeded by three units. For
        /// more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-mixed-instances-groups-instance-weighting.html">Configuring
        /// instance weighting for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>. Value must be in the range of 1–999.
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