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
    /// Contains information on a promotion. A promotion defines additional business rules
    /// that apply to a configurable subset of recommended items.
    /// </summary>
    public partial class RecommenderPromotionalFilter
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the recommender filter to use for the promotion.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PercentPromotedItems. 
        /// <para>
        /// The percentage of recommended items to apply the promotion to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? PercentPromotedItems { get; set; }

        /// <summary>
        /// Checks to see if the PercentPromotedItems property is set.
        /// </summary>
        internal bool IsSetPercentPromotedItems() => this.PercentPromotedItems.HasValue;

        /// <summary>
        /// Gets and sets the property PromotionName. 
        /// <para>
        /// The name of the promotion.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string PromotionName { get; set; }

        /// <summary>
        /// Checks to see if the PromotionName property is set.
        /// </summary>
        internal bool IsSetPromotionName() => this.PromotionName != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values to use when promoting items. For each placeholder parameter in your promotion's
        /// filter expression, provide the parameter name (in matching case) as a key and the
        /// filter value(s) as the corresponding value. Separate multiple values for one parameter
        /// with a comma.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public Dictionary<string, string> Values { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
