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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Capacity details for an OpenSearch Serverless collection group, including the current
    /// capacity and autoscaling status.
    /// </summary>
    public partial class CapacityDetails
    {
        /// <summary>
        /// Gets and sets the property AutoscalingStatus. 
        /// <para>
        /// The current autoscaling status for the collection group.
        /// </para>
        /// </summary>
        public AutoscalingStatus AutoscalingStatus { get; set; }

        /// <summary>
        /// Checks to see if the AutoscalingStatus property is set.
        /// </summary>
        internal bool IsSetAutoscalingStatus() => this.AutoscalingStatus != null;

        /// <summary>
        /// Gets and sets the property CapacityInOcu. 
        /// <para>
        /// The current capacity in OpenSearch Compute Units (OCUs).
        /// </para>
        /// </summary>
        public float? CapacityInOcu { get; set; }

        /// <summary>
        /// Checks to see if the CapacityInOcu property is set.
        /// </summary>
        internal bool IsSetCapacityInOcu() => this.CapacityInOcu.HasValue;
    }
}
