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
    /// Describes a mixed instances policy for an Auto Scaling group. With mixed instances,
    /// your Auto Scaling group can provision a combination of On-Demand Instances and Spot
    /// Instances across multiple instance types. For more information, see <a href="http://docs.aws.amazon.com/autoscaling/ec2/userguide/AutoScalingGroup.html#asg-purchase-options">Using
    /// Multiple Instance Types and Purchase Options</a> in the <i>Amazon EC2 Auto Scaling
    /// User Guide</i>.
    /// 
    ///  
    /// <para>
    /// When you create your Auto Scaling group, you can specify a launch configuration or
    /// template as a parameter for the top-level object, or you can specify a mixed instances
    /// policy, but not both at the same time.
    /// </para>
    /// </summary>
    public partial class MixedInstancesPolicy
    {
        private InstancesDistribution _instancesDistribution;
        private LaunchTemplate _launchTemplate;

        /// <summary>
        /// Gets and sets the property InstancesDistribution. 
        /// <para>
        /// The instances distribution to use. 
        /// </para>
        ///  
        /// <para>
        /// If you leave this parameter unspecified when creating the group, the default values
        /// are used.
        /// </para>
        /// </summary>
        public InstancesDistribution InstancesDistribution
        {
            get { return this._instancesDistribution; }
            set { this._instancesDistribution = value; }
        }

        // Check to see if InstancesDistribution property is set
        internal bool IsSetInstancesDistribution()
        {
            return this._instancesDistribution != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The launch template and overrides.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required when creating an Auto Scaling group with a mixed instances
        /// policy, but is not required when updating the group.
        /// </para>
        /// </summary>
        public LaunchTemplate LaunchTemplate
        {
            get { return this._launchTemplate; }
            set { this._launchTemplate = value; }
        }

        // Check to see if LaunchTemplate property is set
        internal bool IsSetLaunchTemplate()
        {
            return this._launchTemplate != null;
        }

    }
}