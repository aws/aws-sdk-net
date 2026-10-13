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
    /// Describes a recommendation generator for a Domain dataset group. You create a recommender
    /// in a Domain dataset group for a specific domain use case (domain recipe), and specify
    /// the recommender in a <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
    /// request.
    /// </summary>
    public partial class Recommender
    {
        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time (in Unix format) that the recommender was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Domain dataset group that contains the recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DatasetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetGroupArn property is set.
        /// </summary>
        internal bool IsSetDatasetGroupArn() => this.DatasetGroupArn != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If a recommender fails, the reason behind the failure.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time (in Unix format) that the recommender was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestRecommenderUpdate. 
        /// <para>
        /// Provides a summary of the latest updates to the recommender. 
        /// </para>
        /// </summary>
        public RecommenderUpdateSummary LatestRecommenderUpdate { get; set; }

        /// <summary>
        /// Checks to see if the LatestRecommenderUpdate property is set.
        /// </summary>
        internal bool IsSetLatestRecommenderUpdate() => this.LatestRecommenderUpdate != null;

        /// <summary>
        /// Gets and sets the property ModelMetrics. 
        /// <para>
        /// Provides evaluation metrics that help you determine the performance of a recommender.
        /// For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/evaluating-recommenders.html">
        /// Evaluating a recommender</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, double> ModelMetrics { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;

        /// <summary>
        /// Checks to see if the ModelMetrics property is set.
        /// </summary>
        internal bool IsSetModelMetrics() => this.ModelMetrics != null && (this.ModelMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recipe (Domain dataset group use case) that
        /// the recommender was created for. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string RecipeArn { get; set; }

        /// <summary>
        /// Checks to see if the RecipeArn property is set.
        /// </summary>
        internal bool IsSetRecipeArn() => this.RecipeArn != null;

        /// <summary>
        /// Gets and sets the property RecommenderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string RecommenderArn { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderArn property is set.
        /// </summary>
        internal bool IsSetRecommenderArn() => this.RecommenderArn != null;

        /// <summary>
        /// Gets and sets the property RecommenderConfig. 
        /// <para>
        /// The configuration details of the recommender.
        /// </para>
        /// </summary>
        public RecommenderConfig RecommenderConfig { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderConfig property is set.
        /// </summary>
        internal bool IsSetRecommenderConfig() => this.RecommenderConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the recommender.
        /// </para>
        ///  
        /// <para>
        /// A recommender can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING > CREATE IN_PROGRESS > ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOP PENDING > STOP IN_PROGRESS > INACTIVE > START PENDING > START IN_PROGRESS > ACTIVE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE PENDING > DELETE IN_PROGRESS
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
