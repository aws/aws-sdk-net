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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Describes the weight of a target group.
    /// </summary>
    public partial class WeightedTargetGroup
    {
        /// <summary>
        /// Gets and sets the property TargetGroupIdentifier. 
        /// <para>
        /// The ID or ARN of the target group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 2048)]
        public string TargetGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TargetGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetTargetGroupIdentifier() => this.TargetGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// Only required if you specify multiple target groups for a forward action. The weight
        /// determines how requests are distributed to the target group. For example, if you specify
        /// two target groups, each with a weight of 10, each target group receives half the requests.
        /// If you specify two target groups, one with a weight of 10 and the other with a weight
        /// of 20, the target group with a weight of 20 receives twice as many requests as the
        /// other target group. If there's only one target group specified, then the default value
        /// is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 999)]
        public int? Weight { get; set; }

        /// <summary>
        /// Checks to see if the Weight property is set.
        /// </summary>
        internal bool IsSetWeight() => this.Weight.HasValue;
    }
}
