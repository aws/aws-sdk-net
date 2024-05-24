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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The mixed instances policy for the automatic scaling group.
    /// </summary>
    public partial class AwsAutoScalingAutoScalingGroupMixedInstancesPolicyDetails
    {
        private AwsAutoScalingAutoScalingGroupMixedInstancesPolicyInstancesDistributionDetails _instancesDistribution;
        private AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetails _launchTemplate;

        /// <summary>
        /// Gets and sets the property InstancesDistribution. 
        /// <para>
        /// The instances distribution. The instances distribution specifies the distribution
        /// of On-Demand Instances and Spot Instances, the maximum price to pay for Spot Instances,
        /// and how the Auto Scaling group allocates instance types to fulfill On-Demand and Spot
        /// capacity.
        /// </para>
        /// </summary>
        public AwsAutoScalingAutoScalingGroupMixedInstancesPolicyInstancesDistributionDetails InstancesDistribution
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
        /// The launch template to use and the instance types (overrides) to use to provision
        /// EC2 instances to fulfill On-Demand and Spot capacities.
        /// </para>
        /// </summary>
        public AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetails LaunchTemplate
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