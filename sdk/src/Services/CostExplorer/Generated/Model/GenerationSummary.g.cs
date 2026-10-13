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
    /// The summary of the Savings Plans recommendation generation.
    /// </summary>
    public partial class GenerationSummary
    {
        /// <summary>
        /// Gets and sets the property EstimatedCompletionTime. 
        /// <para>
        /// Indicates the estimated time for when the recommendation generation will complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string EstimatedCompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedCompletionTime property is set.
        /// </summary>
        internal bool IsSetEstimatedCompletionTime() => this.EstimatedCompletionTime != null;

        /// <summary>
        /// Gets and sets the property GenerationCompletionTime. 
        /// <para>
        /// Indicates the completion time of the recommendation generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string GenerationCompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the GenerationCompletionTime property is set.
        /// </summary>
        internal bool IsSetGenerationCompletionTime() => this.GenerationCompletionTime != null;

        /// <summary>
        /// Gets and sets the property GenerationStartedTime. 
        /// <para>
        /// Indicates the start time of the recommendation generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string GenerationStartedTime { get; set; }

        /// <summary>
        /// Checks to see if the GenerationStartedTime property is set.
        /// </summary>
        internal bool IsSetGenerationStartedTime() => this.GenerationStartedTime != null;

        /// <summary>
        /// Gets and sets the property GenerationStatus. 
        /// <para>
        /// Indicates whether the recommendation generation succeeded, is processing, or failed.
        /// </para>
        /// </summary>
        public GenerationStatus GenerationStatus { get; set; }

        /// <summary>
        /// Checks to see if the GenerationStatus property is set.
        /// </summary>
        internal bool IsSetGenerationStatus() => this.GenerationStatus != null;

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// Indicates the ID for this specific recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string RecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationId property is set.
        /// </summary>
        internal bool IsSetRecommendationId() => this.RecommendationId != null;
    }
}
