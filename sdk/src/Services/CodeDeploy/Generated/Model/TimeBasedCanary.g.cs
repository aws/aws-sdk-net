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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// A configuration that shifts traffic from one version of a Lambda function or Amazon
    /// ECS task set to another in two increments. The original and target Lambda function
    /// versions or ECS task sets are specified in the deployment's AppSpec file.
    /// </summary>
    public partial class TimeBasedCanary
    {
        /// <summary>
        /// Gets and sets the property CanaryInterval. 
        /// <para>
        /// The number of minutes between the first and second traffic shifts of a <c>TimeBasedCanary</c>
        /// deployment.
        /// </para>
        /// </summary>
        public int? CanaryInterval { get; set; }

        /// <summary>
        /// Checks to see if the CanaryInterval property is set.
        /// </summary>
        internal bool IsSetCanaryInterval() => this.CanaryInterval.HasValue;

        /// <summary>
        /// Gets and sets the property CanaryPercentage. 
        /// <para>
        /// The percentage of traffic to shift in the first increment of a <c>TimeBasedCanary</c>
        /// deployment.
        /// </para>
        /// </summary>
        public int? CanaryPercentage { get; set; }

        /// <summary>
        /// Checks to see if the CanaryPercentage property is set.
        /// </summary>
        internal bool IsSetCanaryPercentage() => this.CanaryPercentage.HasValue;
    }
}
