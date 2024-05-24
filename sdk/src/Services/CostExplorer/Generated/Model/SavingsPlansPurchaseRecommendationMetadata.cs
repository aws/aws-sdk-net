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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Metadata about your Savings Plans Purchase Recommendations.
    /// </summary>
    public partial class SavingsPlansPurchaseRecommendationMetadata
    {
        private string _additionalMetadata;
        private string _generationTimestamp;
        private string _recommendationId;

        /// <summary>
        /// Gets and sets the property AdditionalMetadata. 
        /// <para>
        /// Additional metadata that might be applicable to the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AdditionalMetadata
        {
            get { return this._additionalMetadata; }
            set { this._additionalMetadata = value; }
        }

        // Check to see if AdditionalMetadata property is set
        internal bool IsSetAdditionalMetadata()
        {
            return this._additionalMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property GenerationTimestamp. 
        /// <para>
        /// The timestamp that shows when the recommendations were generated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string GenerationTimestamp
        {
            get { return this._generationTimestamp; }
            set { this._generationTimestamp = value; }
        }

        // Check to see if GenerationTimestamp property is set
        internal bool IsSetGenerationTimestamp()
        {
            return this._generationTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The unique identifier for the recommendation set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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