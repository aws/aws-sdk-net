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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// You can use <c>RightsizingRecommendationConfiguration</c> to customize recommendations
    /// across two attributes. You can choose to view recommendations for instances within
    /// the same instance families or across different instance families. You can also choose
    /// to view your estimated savings that are associated with recommendations with consideration
    /// of existing Savings Plans or Reserved Instance (RI) benefits, or neither.
    /// </summary>
    public partial class RightsizingRecommendationConfiguration
    {
        /// <summary>
        /// Gets and sets the property BenefitsConsidered. 
        /// <para>
        /// The option to consider RI or Savings Plans discount benefits in your savings calculation.
        /// The default value is <c>TRUE</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? BenefitsConsidered { get; set; }

        /// <summary>
        /// Checks to see if the BenefitsConsidered property is set.
        /// </summary>
        internal bool IsSetBenefitsConsidered() => this.BenefitsConsidered.HasValue;

        /// <summary>
        /// Gets and sets the property RecommendationTarget. 
        /// <para>
        /// The option to see recommendations within the same instance family or recommendations
        /// for instances across other families. The default value is <c>SAME_INSTANCE_FAMILY</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationTarget RecommendationTarget { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationTarget property is set.
        /// </summary>
        internal bool IsSetRecommendationTarget() => this.RecommendationTarget != null;
    }
}
