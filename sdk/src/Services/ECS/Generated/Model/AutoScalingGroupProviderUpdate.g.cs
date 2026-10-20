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
    /// The details of the Auto Scaling group capacity provider to update.
    /// </summary>
    public partial class AutoScalingGroupProviderUpdate
    {
        /// <summary>
        /// Gets and sets the property ManagedDraining. 
        /// <para>
        /// The managed draining option for the Auto Scaling group capacity provider. When you
        /// enable this, Amazon ECS manages and gracefully drains the EC2 container instances
        /// that are in the Auto Scaling group capacity provider.
        /// </para>
        /// </summary>
        public ManagedDraining ManagedDraining { get; set; }

        /// <summary>
        /// Checks to see if the ManagedDraining property is set.
        /// </summary>
        internal bool IsSetManagedDraining() => this.ManagedDraining != null;

        /// <summary>
        /// Gets and sets the property ManagedScaling. 
        /// <para>
        /// The managed scaling settings for the Auto Scaling group capacity provider.
        /// </para>
        /// </summary>
        public ManagedScaling ManagedScaling { get; set; }

        /// <summary>
        /// Checks to see if the ManagedScaling property is set.
        /// </summary>
        internal bool IsSetManagedScaling() => this.ManagedScaling != null;

        /// <summary>
        /// Gets and sets the property ManagedTerminationProtection. 
        /// <para>
        /// The managed termination protection setting to use for the Auto Scaling group capacity
        /// provider. This determines whether the Auto Scaling group has managed termination protection.
        /// </para>
        ///  <important> 
        /// <para>
        /// When using managed termination protection, managed scaling must also be used otherwise
        /// managed termination protection doesn't work.
        /// </para>
        ///  </important> 
        /// <para>
        /// When managed termination protection is on, Amazon ECS prevents the Amazon EC2 instances
        /// in an Auto Scaling group that contain tasks from being terminated during a scale-in
        /// action. The Auto Scaling group and each instance in the Auto Scaling group must have
        /// instance protection from scale-in actions on. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html#instance-protection">Instance
        /// Protection</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When managed termination protection is off, your Amazon EC2 instances aren't protected
        /// from termination when the Auto Scaling group scales in.
        /// </para>
        /// </summary>
        public ManagedTerminationProtection ManagedTerminationProtection { get; set; }

        /// <summary>
        /// Checks to see if the ManagedTerminationProtection property is set.
        /// </summary>
        internal bool IsSetManagedTerminationProtection() => this.ManagedTerminationProtection != null;
    }
}
