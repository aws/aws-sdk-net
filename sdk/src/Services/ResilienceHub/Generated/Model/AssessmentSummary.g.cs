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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Indicates the AI-generated summary for the Resilience Hub assessment, providing a
    /// concise overview that highlights the top risks and recommendations.
    /// 
    ///  <note> 
    /// <para>
    /// This property is available only in the US East (N. Virginia) Region.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AssessmentSummary
    {
        /// <summary>
        /// Gets and sets the property RiskRecommendations. 
        /// <para>
        /// Indicates the top risks and recommendations identified by the Resilience Hub assessment,
        /// each representing a specific risk and the corresponding recommendation to address
        /// it.
        /// </para>
        ///  <note> 
        /// <para>
        /// This property is available only in the US East (N. Virginia) Region.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssessmentRiskRecommendation> RiskRecommendations { get; set; } = AWSConfigs.InitializeCollections ? new List<AssessmentRiskRecommendation>() : null;

        /// <summary>
        /// Checks to see if the RiskRecommendations property is set.
        /// </summary>
        internal bool IsSetRiskRecommendations() => this.RiskRecommendations != null && (this.RiskRecommendations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// Indicates a concise summary that provides an overview of the Resilience Hub assessment.
        /// </para>
        ///  <note> 
        /// <para>
        /// This property is available only in the US East (N. Virginia) Region.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;
    }
}
