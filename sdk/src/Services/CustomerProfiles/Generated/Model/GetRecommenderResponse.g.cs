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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the GetRecommender operation.
    /// </summary>
    public partial class GetRecommenderResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActiveRecommenderVersionName. 
        /// <para>
        /// The name of the recommender version currently serving recommendations. Omitted when
        /// no active recommender version is set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ActiveRecommenderVersionName { get; set; }

        /// <summary>
        /// Checks to see if the ActiveRecommenderVersionName property is set.
        /// </summary>
        internal bool IsSetActiveRecommenderVersionName() => this.ActiveRecommenderVersionName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the recommender was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A detailed description of the recommender providing information about its purpose
        /// and functionality.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the recommender fails, provides the reason for the failure.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp of when the recommender was edited.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LatestRecommenderUpdate. 
        /// <para>
        /// Information about the most recent update performed on the recommender, including status
        /// and timestamp.
        /// </para>
        /// </summary>
        public RecommenderUpdate LatestRecommenderUpdate { get; set; }

        /// <summary>
        /// Checks to see if the LatestRecommenderUpdate property is set.
        /// </summary>
        internal bool IsSetLatestRecommenderUpdate() => this.LatestRecommenderUpdate != null;

        /// <summary>
        /// Gets and sets the property RecommenderConfig. 
        /// <para>
        /// The configuration settings for the recommender, including parameters and settings
        /// that define its behavior.
        /// </para>
        /// </summary>
        public RecommenderConfig RecommenderConfig { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderConfig property is set.
        /// </summary>
        internal bool IsSetRecommenderConfig() => this.RecommenderConfig != null;

        /// <summary>
        /// Gets and sets the property RecommenderName. 
        /// <para>
        /// The name of the recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string RecommenderName { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderName property is set.
        /// </summary>
        internal bool IsSetRecommenderName() => this.RecommenderName != null;

        /// <summary>
        /// Gets and sets the property RecommenderRecipeName. 
        /// <para>
        /// The name of the recipe used by the recommender to generate recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommenderRecipeName RecommenderRecipeName { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderRecipeName property is set.
        /// </summary>
        internal bool IsSetRecommenderRecipeName() => this.RecommenderRecipeName != null;

        /// <summary>
        /// Gets and sets the property RecommenderSchemaName. 
        /// <para>
        /// The name of the recommender schema associated with this recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string RecommenderSchemaName { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderSchemaName property is set.
        /// </summary>
        internal bool IsSetRecommenderSchemaName() => this.RecommenderSchemaName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the recommender, indicating whether it is active, creating,
        /// updating, or in another state.
        /// </para>
        /// </summary>
        public RecommenderStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrainingMetrics. 
        /// <para>
        /// A set of metrics that provide information about the recommender's training performance
        /// and accuracy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TrainingMetrics> TrainingMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<TrainingMetrics>() : null;

        /// <summary>
        /// Checks to see if the TrainingMetrics property is set.
        /// </summary>
        internal bool IsSetTrainingMetrics() => this.TrainingMetrics != null && (this.TrainingMetrics.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
