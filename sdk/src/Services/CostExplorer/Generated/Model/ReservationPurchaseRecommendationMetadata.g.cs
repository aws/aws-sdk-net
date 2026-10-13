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
    /// Information about a recommendation, such as the timestamp for when Amazon Web Services
    /// made a specific recommendation.
    /// </summary>
    public partial class ReservationPurchaseRecommendationMetadata
    {
        /// <summary>
        /// Gets and sets the property AdditionalMetadata. 
        /// <para>
        /// Additional metadata that might be applicable to the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AdditionalMetadata { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalMetadata property is set.
        /// </summary>
        internal bool IsSetAdditionalMetadata() => this.AdditionalMetadata != null;

        /// <summary>
        /// Gets and sets the property GenerationTimestamp. 
        /// <para>
        /// The timestamp for when Amazon Web Services made the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string GenerationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the GenerationTimestamp property is set.
        /// </summary>
        internal bool IsSetGenerationTimestamp() => this.GenerationTimestamp != null;

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The ID for the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string RecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationId property is set.
        /// </summary>
        internal bool IsSetRecommendationId() => this.RecommendationId != null;
    }
}
