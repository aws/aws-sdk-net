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
    /// Describes the desired configuration for an instance refresh. 
    /// 
    ///  
    /// <para>
    /// If you specify a desired configuration, you must specify either a <c>LaunchTemplate</c>
    /// or a <c>MixedInstancesPolicy</c>. 
    /// </para>
    /// </summary>
    public partial class DesiredConfiguration
    {
        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// Describes the launch template and the version of the launch template that Amazon EC2
        /// Auto Scaling uses to launch Amazon EC2 instances. For more information about launch
        /// templates, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/launch-templates.html">Launch
        /// templates</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplate property is set.
        /// </summary>
        internal bool IsSetLaunchTemplate() => this.LaunchTemplate != null;

        /// <summary>
        /// Gets and sets the property MixedInstancesPolicy. 
        /// <para>
        /// Use this structure to launch multiple instance types and configure how capacity is
        /// distributed across On-Demand, Spot, and supported Capacity Reservation types within
        /// a single Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// A mixed instances policy contains information that Amazon EC2 Auto Scaling can use
        /// to launch instances, prioritize capacity types, and help optimize your costs. For
        /// more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-mixed-instances-groups.html">Auto
        /// Scaling groups with multiple instance types and purchase options</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public MixedInstancesPolicy MixedInstancesPolicy { get; set; }

        /// <summary>
        /// Checks to see if the MixedInstancesPolicy property is set.
        /// </summary>
        internal bool IsSetMixedInstancesPolicy() => this.MixedInstancesPolicy != null;
    }
}
