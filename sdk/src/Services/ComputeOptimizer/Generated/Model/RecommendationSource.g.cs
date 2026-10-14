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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the source of a recommendation, such as an Amazon EC2 instance or Auto Scaling
    /// group.
    /// </summary>
    public partial class RecommendationSource
    {
        /// <summary>
        /// Gets and sets the property RecommendationSourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommendation source.
        /// </para>
        /// </summary>
        public string RecommendationSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationSourceArn property is set.
        /// </summary>
        internal bool IsSetRecommendationSourceArn() => this.RecommendationSourceArn != null;

        /// <summary>
        /// Gets and sets the property RecommendationSourceType. 
        /// <para>
        /// The resource type of the recommendation source.
        /// </para>
        /// </summary>
        public RecommendationSourceType RecommendationSourceType { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationSourceType property is set.
        /// </summary>
        internal bool IsSetRecommendationSourceType() => this.RecommendationSourceType != null;
    }
}
