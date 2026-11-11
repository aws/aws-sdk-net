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
    /// This is the response object from the DescribeAccountLimits operation.
    /// </summary>
    public partial class DescribeAccountLimitsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property MaxNumberOfAutoScalingGroups. 
        /// <para>
        /// The maximum number of groups allowed for your account. The default is 200 groups per
        /// Region.
        /// </para>
        /// </summary>
        public int? MaxNumberOfAutoScalingGroups { get; set; }

        /// <summary>
        /// Checks to see if the MaxNumberOfAutoScalingGroups property is set.
        /// </summary>
        internal bool IsSetMaxNumberOfAutoScalingGroups() => this.MaxNumberOfAutoScalingGroups.HasValue;

        /// <summary>
        /// Gets and sets the property MaxNumberOfLaunchConfigurations. 
        /// <para>
        /// The maximum number of launch configurations allowed for your account. The default
        /// is 200 launch configurations per Region.
        /// </para>
        /// </summary>
        public int? MaxNumberOfLaunchConfigurations { get; set; }

        /// <summary>
        /// Checks to see if the MaxNumberOfLaunchConfigurations property is set.
        /// </summary>
        internal bool IsSetMaxNumberOfLaunchConfigurations() => this.MaxNumberOfLaunchConfigurations.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfAutoScalingGroups. 
        /// <para>
        /// The current number of groups for your account.
        /// </para>
        /// </summary>
        public int? NumberOfAutoScalingGroups { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfAutoScalingGroups property is set.
        /// </summary>
        internal bool IsSetNumberOfAutoScalingGroups() => this.NumberOfAutoScalingGroups.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfLaunchConfigurations. 
        /// <para>
        /// The current number of launch configurations for your account.
        /// </para>
        /// </summary>
        public int? NumberOfLaunchConfigurations { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfLaunchConfigurations property is set.
        /// </summary>
        internal bool IsSetNumberOfLaunchConfigurations() => this.NumberOfLaunchConfigurations.HasValue;
    }
}
