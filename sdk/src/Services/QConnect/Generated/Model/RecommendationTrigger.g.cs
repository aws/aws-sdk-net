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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// A recommendation trigger provides context on the event that produced the referenced
    /// recommendations. Recommendations are only referenced in <c>recommendationIds</c> by
    /// a single RecommendationTrigger.
    /// </summary>
    public partial class RecommendationTrigger
    {
        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// A union type containing information related to the trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationTriggerData Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the recommendation trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property RecommendationIds. 
        /// <para>
        /// The identifiers of the recommendations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 25)]
        public List<string> RecommendationIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RecommendationIds property is set.
        /// </summary>
        internal bool IsSetRecommendationIds() => this.RecommendationIds != null && (this.RecommendationIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the recommendation trigger.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ISSUE_DETECTION: The corresponding recommendations were triggered by a Contact Lens
        /// issue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RULE_EVALUATION: The corresponding recommendations were triggered by a Contact Lens
        /// rule.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationSourceType Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of recommendation trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationTriggerType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
