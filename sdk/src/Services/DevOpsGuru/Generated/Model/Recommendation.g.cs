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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Recommendation information to help you remediate detected anomalous behavior that
    /// generated an insight.
    /// </summary>
    public partial class Recommendation
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category type of the recommendation.
        /// </para>
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the problem. 
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Link. 
        /// <para>
        ///  A hyperlink to information to help you address the problem. 
        /// </para>
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Checks to see if the Link property is set.
        /// </summary>
        internal bool IsSetLink() => this.Link != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the recommendation. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        ///  The reason DevOps Guru flagged the anomalous behavior as a problem. 
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property RelatedAnomalies. 
        /// <para>
        ///  Anomalies that are related to the problem. Use these Anomalies to learn more about
        /// what's happening and to help address the issue. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendationRelatedAnomaly> RelatedAnomalies { get; set; } = AWSConfigs.InitializeCollections ? new List<RecommendationRelatedAnomaly>() : null;

        /// <summary>
        /// Checks to see if the RelatedAnomalies property is set.
        /// </summary>
        internal bool IsSetRelatedAnomalies() => this.RelatedAnomalies != null && (this.RelatedAnomalies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RelatedEvents. 
        /// <para>
        ///  Events that are related to the problem. Use these events to learn more about what's
        /// happening and to help address the issue. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendationRelatedEvent> RelatedEvents { get; set; } = AWSConfigs.InitializeCollections ? new List<RecommendationRelatedEvent>() : null;

        /// <summary>
        /// Checks to see if the RelatedEvents property is set.
        /// </summary>
        internal bool IsSetRelatedEvents() => this.RelatedEvents != null && (this.RelatedEvents.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
