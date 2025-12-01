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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// The configuration details of a batch inference job.
    /// </summary>
    public partial class BatchInferenceJobConfig
    {
        private Dictionary<string, string> _itemExplorationConfig = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, double> _rankingInfluence = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;

        /// <summary>
        /// Gets and sets the property ItemExplorationConfig. 
        /// <para>
        /// A string to string map specifying the exploration configuration hyperparameters, including
        /// <c>explorationWeight</c> and <c>explorationItemAgeCutOff</c>, you want to use to configure
        /// the amount of item exploration Amazon Personalize uses when recommending items. See
        /// <a href="https://docs.aws.amazon.com/personalize/latest/dg/native-recipe-new-item-USER_PERSONALIZATION.html">User-Personalization</a>.
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
            return this._itemExplorationConfig != null && (this._itemExplorationConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RankingInfluence. 
        /// <para>
        /// A map of ranking influence values for POPULARITY and FRESHNESS. For each key, specify
        /// a numerical value between 0.0 and 1.0 that determines how much influence that ranking
        /// factor has on the final recommendations. A value closer to 1.0 gives more weight to
        /// the factor, while a value closer to 0.0 reduces its influence.
        /// </para>
        /// </summary>
        public Dictionary<string, double> RankingInfluence
        {
            get { return this._rankingInfluence; }
            set { this._rankingInfluence = value; }
        }

        // Check to see if RankingInfluence property is set
        internal bool IsSetRankingInfluence()
        {
            return this._rankingInfluence != null && (this._rankingInfluence.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}