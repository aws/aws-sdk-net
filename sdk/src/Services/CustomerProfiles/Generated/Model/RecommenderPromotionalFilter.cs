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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
    /// Contains information on a promotion. A promotion defines additional business rules
    /// that apply to a configurable subset of recommended items.
    /// </summary>
    public partial class RecommenderPromotionalFilter
    {
        private string _name;
        private int? _percentPromotedItems;
        private string _promotionName;
        private Dictionary<string, string> _values = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the recommender filter to use for the promotion.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PercentPromotedItems. 
        /// <para>
        /// The percentage of recommended items to apply the promotion to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int PercentPromotedItems
        {
            get { return this._percentPromotedItems.GetValueOrDefault(); }
            set { this._percentPromotedItems = value; }
        }

        // Check to see if PercentPromotedItems property is set
        internal bool IsSetPercentPromotedItems()
        {
            return this._percentPromotedItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PromotionName. 
        /// <para>
        /// The name of the promotion.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Values. 
        /// <para>
        /// The values to use when promoting items. For each placeholder parameter in your promotion's
        /// filter expression, provide the parameter name (in matching case) as a key and the
        /// filter value(s) as the corresponding value. Separate multiple values for one parameter
        /// with a comma.
        /// </para>
        /// </summary>
        [AWSProperty(Max=25)]
        public Dictionary<string, string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}