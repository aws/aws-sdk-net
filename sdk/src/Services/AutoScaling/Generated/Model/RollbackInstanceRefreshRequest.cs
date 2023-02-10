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
    /// Container for the parameters to the RollbackInstanceRefresh operation.
    /// Cancels an instance refresh that is in progress and rolls back any changes that it
    /// made. Amazon EC2 Auto Scaling replaces any instances that were replaced during the
    /// instance refresh. This restores your Auto Scaling group to the configuration that
    /// it was using before the start of the instance refresh. 
    /// 
    ///  
    /// <para>
    /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
    /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
    /// your Auto Scaling group after you make configuration changes.
    /// </para>
    ///  
    /// <para>
    /// A rollback is not supported in the following situations: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// There is no desired configuration specified for the instance refresh.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Auto Scaling group has a launch template that uses an Amazon Web Services Systems
    /// Manager parameter instead of an AMI ID for the <code>ImageId</code> property.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Auto Scaling group uses the launch template's <code>$Latest</code> or <code>$Default</code>
    /// version.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When you receive a successful response from this operation, Amazon EC2 Auto Scaling
    /// immediately begins replacing instances. You can check the status of this operation
    /// through the <a>DescribeInstanceRefreshes</a> API operation. 
    /// </para>
    /// </summary>
    public partial class RollbackInstanceRefreshRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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

    }
}