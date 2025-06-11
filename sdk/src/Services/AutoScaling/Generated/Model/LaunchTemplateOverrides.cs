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
    /// Use this structure to let Amazon EC2 Auto Scaling do the following when the Auto Scaling
    /// group has a mixed instances policy:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Override the instance type that is specified in the launch template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use multiple instance types.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Specify the instance types that you want, or define your instance requirements instead
    /// and let Amazon EC2 Auto Scaling provision the available instance types that meet your
    /// requirements. This can provide Amazon EC2 Auto Scaling with a larger selection of
    /// instance types to choose from when fulfilling Spot and On-Demand capacities. You can
    /// view which instance types are matched before you apply the instance requirements to
    /// your Auto Scaling group.
    /// </para>
    ///  
    /// <para>
    /// After you define your instance requirements, you don't have to keep updating these
    /// settings to get new EC2 instance types automatically. Amazon EC2 Auto Scaling uses
    /// the instance requirements of the Auto Scaling group to determine whether a new EC2
    /// instance type can be used.
    /// </para>
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
        /// The instance requirements. Amazon EC2 Auto Scaling uses your specified requirements
        /// to identify instance types. Then, it uses your On-Demand and Spot allocation strategies
        /// to launch instances from these instance types.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to four separate sets of instance requirements per Auto Scaling
        /// group. This is useful for provisioning instances from different Amazon Machine Images
        /// (AMIs) in the same Auto Scaling group. To do this, create the AMIs and create a new
        /// launch template for each AMI. Then, create a compatible set of instance requirements
        /// for each launch template. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>InstanceRequirements</c>, you can't specify <c>InstanceType</c>.
        /// </para>
        ///  </note>
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
        /// The instance type, such as <c>m3.xlarge</c>. You must specify an instance type that
        /// is supported in your requested Region and Availability Zones. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// types</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 40 instance types per Auto Scaling group.
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
        /// Provides a launch template for the specified instance type or set of instance requirements.
        /// For example, some instance types might require a launch template with a different
        /// AMI. If not provided, Amazon EC2 Auto Scaling uses the launch template that's specified
        /// in the <c>LaunchTemplate</c> definition. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-mixed-instances-groups-launch-template-overrides.html">Specifying
        /// a different launch template for an instance type</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 20 launch templates per Auto Scaling group. The launch templates
        /// specified in the overrides and in the <c>LaunchTemplate</c> definition count towards
        /// this limit.
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
        /// If you provide a list of instance types to use, you can specify the number of capacity
        /// units provided by each instance type in terms of virtual CPUs, memory, storage, throughput,
        /// or other relative performance characteristic. When a Spot or On-Demand Instance is
        /// launched, the capacity units count toward the desired capacity. Amazon EC2 Auto Scaling
        /// launches instances until the desired capacity is totally fulfilled, even if this results
        /// in an overage. For example, if there are two units remaining to fulfill capacity,
        /// and Amazon EC2 Auto Scaling can only launch an instance with a <c>WeightedCapacity</c>
        /// of five units, the instance is launched, and the desired capacity is exceeded by three
        /// units. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-mixed-instances-groups-instance-weighting.html">Configure
        /// an Auto Scaling group to use instance weights</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>. Value must be in the range of 1–999.
        /// </para>
        ///  
        /// <para>
        /// If you specify a value for <c>WeightedCapacity</c> for one instance type, you must
        /// specify a value for <c>WeightedCapacity</c> for all of them.
        /// </para>
        ///  <important> 
        /// <para>
        /// Every Auto Scaling group has three size parameters (<c>DesiredCapacity</c>, <c>MaxSize</c>,
        /// and <c>MinSize</c>). Usually, you set these sizes based on a specific number of instances.
        /// However, if you configure a mixed instances policy that defines weights for the instance
        /// types, you must specify these sizes with the same units that you use for weighting
        /// instances. 
        /// </para>
        ///  </important>
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