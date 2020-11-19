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
    /// Describes a mixed instances policy for an Auto Scaling group. With mixed instances,
    /// your Auto Scaling group can provision a combination of On-Demand Instances and Spot
    /// Instances across multiple instance types. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-purchase-options.html">Auto
    /// Scaling groups with multiple instance types and purchase options</a> in the <i>Amazon
    /// EC2 Auto Scaling User Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can create a mixed instances policy for a new Auto Scaling group, or you can create
    /// it for an existing group by updating the group to specify <code>MixedInstancesPolicy</code>
    /// as the top-level parameter instead of a launch configuration or launch template.
    /// </para>
    /// </summary>
    public partial class MixedInstancesPolicy
    {
        private InstancesDistribution _instancesDistribution;
        private LaunchTemplate _launchTemplate;

        /// <summary>
        /// Gets and sets the property InstancesDistribution. 
        /// <para>
        /// Specifies the instances distribution. If not provided, the value for each parameter
        /// in <code>InstancesDistribution</code> uses a default value.
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
        /// Specifies the launch template to use and optionally the instance types (overrides)
        /// that are used to provision EC2 instances to fulfill On-Demand and Spot capacities.
        /// Required when creating a mixed instances policy.
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