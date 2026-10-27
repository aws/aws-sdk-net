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

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteScalingPlan operation. Deletes the specified
    /// scaling plan. <para> Deleting a scaling plan deletes the underlying <a>ScalingInstruction</a>
    /// for all of the scalable resources that are covered by the plan. </para> <para> If
    /// the plan has launched resources or has scaling activities in progress, you must delete
    /// those resources separately. </para>
    /// </summary>
    public partial class DeleteScalingPlanRequest : AmazonAutoScalingPlansRequest
    {
        /// <summary>
        /// Gets and sets the property ScalingPlanName. 
        /// <para>
        /// The name of the scaling plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ScalingPlanName { get; set; }

        /// <summary>
        /// Checks to see if the ScalingPlanName property is set.
        /// </summary>
        internal bool IsSetScalingPlanName() => this.ScalingPlanName != null;

        /// <summary>
        /// Gets and sets the property ScalingPlanVersion. 
        /// <para>
        /// The version number of the scaling plan. Currently, the only valid value is <c>1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ScalingPlanVersion { get; set; }

        /// <summary>
        /// Checks to see if the ScalingPlanVersion property is set.
        /// </summary>
        internal bool IsSetScalingPlanVersion() => this.ScalingPlanVersion.HasValue;
    }
}
