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
    /// Describes an instance maintenance policy.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-instance-maintenance-policy.html">Set
    /// instance maintenance policy</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class InstanceMaintenancePolicy
    {
        private int? _maxHealthyPercentage;
        private int? _minHealthyPercentage;

        /// <summary>
        /// Gets and sets the property MaxHealthyPercentage. 
        /// <para>
        /// Specifies the upper threshold as a percentage of the desired capacity of the Auto
        /// Scaling group. It represents the maximum percentage of the group that can be in service
        /// and healthy, or pending, to support your workload when replacing instances. Value
        /// range is 100 to 200. To clear a previously set value, specify a value of <c>-1</c>.
        /// </para>
        ///  
        /// <para>
        /// Both <c>MinHealthyPercentage</c> and <c>MaxHealthyPercentage</c> must be specified,
        /// and the difference between them cannot be greater than 100. A large range increases
        /// the number of instances that can be replaced at the same time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1, Max=200)]
        public int? MaxHealthyPercentage
        {
            get { return this._maxHealthyPercentage; }
            set { this._maxHealthyPercentage = value; }
        }

        // Check to see if MaxHealthyPercentage property is set
        internal bool IsSetMaxHealthyPercentage()
        {
            return this._maxHealthyPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinHealthyPercentage. 
        /// <para>
        /// Specifies the lower threshold as a percentage of the desired capacity of the Auto
        /// Scaling group. It represents the minimum percentage of the group to keep in service,
        /// healthy, and ready to use to support your workload when replacing instances. Value
        /// range is 0 to 100. To clear a previously set value, specify a value of <c>-1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1, Max=100)]
        public int? MinHealthyPercentage
        {
            get { return this._minHealthyPercentage; }
            set { this._minHealthyPercentage = value; }
        }

        // Check to see if MinHealthyPercentage property is set
        internal bool IsSetMinHealthyPercentage()
        {
            return this._minHealthyPercentage.HasValue; 
        }

    }
}