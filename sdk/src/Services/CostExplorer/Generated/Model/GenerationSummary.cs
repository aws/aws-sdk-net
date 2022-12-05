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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The summary of the Savings Plans recommendation generation.
    /// </summary>
    public partial class GenerationSummary
    {
        private string _estimatedCompletionTime;
        private string _generationCompletionTime;
        private string _generationStartedTime;
        private GenerationStatus _generationStatus;
        private string _recommendationId;

        /// <summary>
        /// Gets and sets the property EstimatedCompletionTime. 
        /// <para>
        /// Indicates the estimated time for when the recommendation generation will complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string EstimatedCompletionTime
        {
            get { return this._estimatedCompletionTime; }
            set { this._estimatedCompletionTime = value; }
        }

        // Check to see if EstimatedCompletionTime property is set
        internal bool IsSetEstimatedCompletionTime()
        {
            return this._estimatedCompletionTime != null;
        }

        /// <summary>
        /// Gets and sets the property GenerationCompletionTime. 
        /// <para>
        /// Indicates the completion time of the recommendation generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string GenerationCompletionTime
        {
            get { return this._generationCompletionTime; }
            set { this._generationCompletionTime = value; }
        }

        // Check to see if GenerationCompletionTime property is set
        internal bool IsSetGenerationCompletionTime()
        {
            return this._generationCompletionTime != null;
        }

        /// <summary>
        /// Gets and sets the property GenerationStartedTime. 
        /// <para>
        /// Indicates the start time of the recommendation generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string GenerationStartedTime
        {
            get { return this._generationStartedTime; }
            set { this._generationStartedTime = value; }
        }

        // Check to see if GenerationStartedTime property is set
        internal bool IsSetGenerationStartedTime()
        {
            return this._generationStartedTime != null;
        }

        /// <summary>
        /// Gets and sets the property GenerationStatus. 
        /// <para>
        /// Indicates whether the recommendation generation succeeded, is processing, or failed.
        /// </para>
        /// </summary>
        public GenerationStatus GenerationStatus
        {
            get { return this._generationStatus; }
            set { this._generationStatus = value; }
        }

        // Check to see if GenerationStatus property is set
        internal bool IsSetGenerationStatus()
        {
            return this._generationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// Indicates the ID for this specific recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string RecommendationId
        {
            get { return this._recommendationId; }
            set { this._recommendationId = value; }
        }

        // Check to see if RecommendationId property is set
        internal bool IsSetRecommendationId()
        {
            return this._recommendationId != null;
        }

    }
}