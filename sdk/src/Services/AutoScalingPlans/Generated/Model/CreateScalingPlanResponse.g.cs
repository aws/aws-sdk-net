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
    /// This is the response object from the CreateScalingPlan operation.
    /// </summary>
    public partial class CreateScalingPlanResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ScalingPlanVersion. 
        /// <para>
        /// The version number of the scaling plan. This value is always <c>1</c>. Currently,
        /// you cannot have multiple scaling plan versions.
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
