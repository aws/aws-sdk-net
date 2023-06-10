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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// The configuration details of the recommender.
    /// </summary>
    public partial class RecommenderConfig
    {
        private Dictionary<string, string> _itemExplorationConfig = new Dictionary<string, string>();
        private int? _minRecommendationRequestsPerSecond;
        private TrainingDataConfig _trainingDataConfig;

        /// <summary>
        /// Gets and sets the property ItemExplorationConfig. 
        /// <para>
        /// Specifies the exploration configuration hyperparameters, including <code>explorationWeight</code>
        /// and <code>explorationItemAgeCutOff</code>, you want to use to configure the amount
        /// of item exploration Amazon Personalize uses when recommending items. Provide <code>itemExplorationConfig</code>
        /// data only if your recommenders generate personalized recommendations for a user (not
        /// popular items or similar items).
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, string> ItemExplorationConfig
        {
            get { return this._itemExplorationConfig; }
            set { this._itemExplorationConfig = value; }
        }

        // Check to see if ItemExplorationConfig property is set
        internal bool IsSetItemExplorationConfig()
        {
            return this._itemExplorationConfig != null && this._itemExplorationConfig.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MinRecommendationRequestsPerSecond. 
        /// <para>
        /// Specifies the requested minimum provisioned recommendation requests per second that
        /// Amazon Personalize will support. A high <code>minRecommendationRequestsPerSecond</code>
        /// will increase your bill. We recommend starting with 1 for <code>minRecommendationRequestsPerSecond</code>
        /// (the default). Track your usage using Amazon CloudWatch metrics, and increase the
        /// <code>minRecommendationRequestsPerSecond</code> as necessary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MinRecommendationRequestsPerSecond
        {
            get { return this._minRecommendationRequestsPerSecond.GetValueOrDefault(); }
            set { this._minRecommendationRequestsPerSecond = value; }
        }

        // Check to see if MinRecommendationRequestsPerSecond property is set
        internal bool IsSetMinRecommendationRequestsPerSecond()
        {
            return this._minRecommendationRequestsPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingDataConfig. 
        /// <para>
        ///  Specifies the training data configuration to use when creating a domain recommender.
        /// 
        /// </para>
        /// </summary>
        public TrainingDataConfig TrainingDataConfig
        {
            get { return this._trainingDataConfig; }
            set { this._trainingDataConfig = value; }
        }

        // Check to see if TrainingDataConfig property is set
        internal bool IsSetTrainingDataConfig()
        {
            return this._trainingDataConfig != null;
        }

    }
}