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
    /// Use this structure to launch multiple instance types and On-Demand Instances and Spot
    /// Instances within a single Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// A mixed instances policy contains information that Amazon EC2 Auto Scaling can use
    /// to launch instances and help optimize your costs. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-mixed-instances-groups.html">Auto
    /// Scaling groups with multiple instance types and purchase options</a> in the <i>Amazon
    /// EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class MixedInstancesPolicy
    {
        private InstancesDistribution _instancesDistribution;
        private LaunchTemplate _launchTemplate;

        /// <summary>
        /// Gets and sets the property InstancesDistribution. 
        /// <para>
        /// The instances distribution.
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
        /// One or more launch templates and the instance types (overrides) that are used to launch
        /// EC2 instances to fulfill On-Demand and Spot capacities.
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