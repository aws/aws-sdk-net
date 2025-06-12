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
 * Do not modify this file. This file is generated from the personalize-runtime-2018-05-22.normal.json service model.
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
namespace Amazon.PersonalizeRuntime.Model
{
    /// <summary>
    /// An object that identifies an item.
    /// 
    ///  
    /// <para>
    /// The and APIs return a list of <c>PredictedItem</c>s.
    /// </para>
    /// </summary>
    public partial class PredictedItem
    {
        private string _itemId;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _promotionName;
        private List<string> _reason = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private double? _score;

        /// <summary>
        /// Gets and sets the property ItemId. 
        /// <para>
        /// The recommended item ID.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ItemId
        {
            get { return this._itemId; }
            set { this._itemId = value; }
        }

        // Check to see if ItemId property is set
        internal bool IsSetItemId()
        {
            return this._itemId != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata about the item from your Items dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PromotionName. 
        /// <para>
        /// The name of the promotion that included the predicted item.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string PromotionName
        {
            get { return this._promotionName; }
            set { this._promotionName = value; }
        }

        // Check to see if PromotionName property is set
        internal bool IsSetPromotionName()
        {
            return this._promotionName != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// If you use User-Personalization-v2, a list of reasons for why the item was included
        /// in recommendations. Possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Promoted item - Indicates the item was included as part of a promotion that you applied
        /// in your recommendation request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Exploration - Indicates the item was included with exploration. With exploration,
        /// recommendations include items with less interactions data or relevance for the user.
        /// For more information about exploration, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/use-case-recipe-features.html#about-exploration">Exploration</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Popular item - Indicates the item was included as a placeholder popular item. If
        /// you use a filter, depending on how many recommendations the filter removes, Amazon
        /// Personalize might add placeholder items to meet the <c>numResults</c> for your recommendation
        /// request. These items are popular items, based on interactions data, that satisfy your
        /// filter criteria. They don't have a relevance score for the user. 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null && (this._reason.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// A numeric representation of the model's certainty that the item will be the next user
        /// selection. For more information on scoring logic, see <a>how-scores-work</a>.
        /// </para>
        /// </summary>
        public double? Score
        {
            get { return this._score; }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

    }
}