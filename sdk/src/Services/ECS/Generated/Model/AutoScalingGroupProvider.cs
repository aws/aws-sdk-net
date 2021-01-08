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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The details of the Auto Scaling group for the capacity provider.
    /// </summary>
    public partial class AutoScalingGroupProvider
    {
        private string _autoScalingGroupArn;
        private ManagedScaling _managedScaling;
        private ManagedTerminationProtection _managedTerminationProtection;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AutoScalingGroupArn
        {
            get { return this._autoScalingGroupArn; }
            set { this._autoScalingGroupArn = value; }
        }

        // Check to see if AutoScalingGroupArn property is set
        internal bool IsSetAutoScalingGroupArn()
        {
            return this._autoScalingGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedScaling. 
        /// <para>
        /// The managed scaling settings for the Auto Scaling group capacity provider.
        /// </para>
        /// </summary>
        public ManagedScaling ManagedScaling
        {
            get { return this._managedScaling; }
            set { this._managedScaling = value; }
        }

        // Check to see if ManagedScaling property is set
        internal bool IsSetManagedScaling()
        {
            return this._managedScaling != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedTerminationProtection. 
        /// <para>
        /// The managed termination protection setting to use for the Auto Scaling group capacity
        /// provider. This determines whether the Auto Scaling group has managed termination protection.
        /// </para>
        ///  <important> 
        /// <para>
        /// When using managed termination protection, managed scaling must also be used otherwise
        /// managed termination protection will not work.
        /// </para>
        ///  </important> 
        /// <para>
        /// When managed termination protection is enabled, Amazon ECS prevents the Amazon EC2
        /// instances in an Auto Scaling group that contain tasks from being terminated during
        /// a scale-in action. The Auto Scaling group and each instance in the Auto Scaling group
        /// must have instance protection from scale-in actions enabled as well. For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html#instance-protection">Instance
        /// Protection</a> in the <i>AWS Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When managed termination protection is disabled, your Amazon EC2 instances are not
        /// protected from termination when the Auto Scaling group scales in.
        /// </para>
        /// </summary>
        public ManagedTerminationProtection ManagedTerminationProtection
        {
            get { return this._managedTerminationProtection; }
            set { this._managedTerminationProtection = value; }
        }

        // Check to see if ManagedTerminationProtection property is set
        internal bool IsSetManagedTerminationProtection()
        {
            return this._managedTerminationProtection != null;
        }

    }
}