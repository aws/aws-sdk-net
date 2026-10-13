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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// The configuration details of the recommender.
    /// </summary>
    public partial class RecommenderConfig
    {
        /// <summary>
        /// Gets and sets the property EnableMetadataWithRecommendations. 
        /// <para>
        /// Whether metadata with recommendations is enabled for the recommender. If enabled,
        /// you can specify the columns from your Items dataset in your request for recommendations.
        /// Amazon Personalize returns this data for each item in the recommendation response.
        /// For information about enabling metadata for a recommender, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/creating-recommenders.html#create-recommender-return-metadata">Enabling
        /// metadata in recommendations for a recommender</a>.
        /// </para>
        ///  
        /// <para>
        ///  If you enable metadata in recommendations, you will incur additional costs. For more
        /// information, see <a href="https://aws.amazon.com/personalize/pricing/">Amazon Personalize
        /// pricing</a>. 
        /// </para>
        /// </summary>
        public bool? EnableMetadataWithRecommendations { get; set; }

        /// <summary>
        /// Checks to see if the EnableMetadataWithRecommendations property is set.
        /// </summary>
        internal bool IsSetEnableMetadataWithRecommendations() => this.EnableMetadataWithRecommendations.HasValue;

        /// <summary>
        /// Gets and sets the property ItemExplorationConfig. 
        /// <para>
        /// Specifies the exploration configuration hyperparameters, including <c>explorationWeight</c>
        /// and <c>explorationItemAgeCutOff</c>, you want to use to configure the amount of item
        /// exploration Amazon Personalize uses when recommending items. Provide <c>itemExplorationConfig</c>
        /// data only if your recommenders generate personalized recommendations for a user (not
        /// popular items or similar items).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> ItemExplorationConfig { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ItemExplorationConfig property is set.
        /// </summary>
        internal bool IsSetItemExplorationConfig() => this.ItemExplorationConfig != null && (this.ItemExplorationConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MinRecommendationRequestsPerSecond. 
        /// <para>
        /// Specifies the requested minimum provisioned recommendation requests per second that
        /// Amazon Personalize will support. A high <c>minRecommendationRequestsPerSecond</c>
        /// will increase your bill. We recommend starting with 1 for <c>minRecommendationRequestsPerSecond</c>
        /// (the default). Track your usage using Amazon CloudWatch metrics, and increase the
        /// <c>minRecommendationRequestsPerSecond</c> as necessary.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MinRecommendationRequestsPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the MinRecommendationRequestsPerSecond property is set.
        /// </summary>
        internal bool IsSetMinRecommendationRequestsPerSecond() => this.MinRecommendationRequestsPerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingDataConfig. 
        /// <para>
        ///  Specifies the training data configuration to use when creating a domain recommender.
        /// 
        /// </para>
        /// </summary>
        public TrainingDataConfig TrainingDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDataConfig property is set.
        /// </summary>
        internal bool IsSetTrainingDataConfig() => this.TrainingDataConfig != null;
    }
}
