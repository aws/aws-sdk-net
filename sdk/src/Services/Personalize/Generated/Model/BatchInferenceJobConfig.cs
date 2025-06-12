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

        /// <summary>
        /// Gets and sets the property ItemExplorationConfig. 
        /// <para>
        /// A string to string map specifying the exploration configuration hyperparameters, including
        /// <c>explorationWeight</c> and <c>explorationItemAgeCutOff</c>, you want to use to configure
        /// the amount of item exploration Amazon Personalize uses when recommending items. See
        /// <a href="https://docs.aws.amazon.com/personalize/latest/dg/native-recipe-new-item-USER_PERSONALIZATION.html">User-Personalization</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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

    }
}