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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The API security details of an event.
    /// </summary>
    public partial class ApiSecurityEventDetail
    {
        /// <summary>
        /// Gets and sets the property ApiPatterns. 
        /// <para>
        /// The API patterns that the event involves. The list contains up to 20 API patterns.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<ApiPattern> ApiPatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<ApiPattern>() : null;

        /// <summary>
        /// Checks to see if the ApiPatterns property is set.
        /// </summary>
        internal bool IsSetApiPatterns() => this.ApiPatterns != null && (this.ApiPatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The API security threat category of the event. For example, <c>API2:2023</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence level of the event detection: <c>LOW</c>, <c>MEDIUM</c>, or <c>HIGH</c>.
        /// </para>
        /// </summary>
        public Confidence Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence != null;

        /// <summary>
        /// Gets and sets the property EventActors. 
        /// <para>
        /// The event actors that are associated with the event. The list contains up to 20 event
        /// actors. To retrieve the details of an event actor, provide its <c>EventActorId</c>
        /// to <a>GetEventActor</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<EventActorReference> EventActors { get; set; } = AWSConfigs.InitializeCollections ? new List<EventActorReference>() : null;

        /// <summary>
        /// Checks to see if the EventActors property is set.
        /// </summary>
        internal bool IsSetEventActors() => this.EventActors != null && (this.EventActors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The fully qualified name of the label that WAF assigned to the event. For example,
        /// <c>awswaf:managed:aws:api-security:credential-stuffing-high</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property Timeline. 
        /// <para>
        /// The changes to the event's label, confidence, and API patterns over time, ordered
        /// from oldest to newest. The list contains up to 32 entries.
        /// </para>
        ///  
        /// <para>
        /// For <a>ListEvents</a> and <a>ListEventsByWebACL</a>, this is returned only if you
        /// specify <c>TIMELINE</c> in the request <c>Include</c> setting.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public List<EventTimelineEntry> Timeline { get; set; } = AWSConfigs.InitializeCollections ? new List<EventTimelineEntry>() : null;

        /// <summary>
        /// Checks to see if the Timeline property is set.
        /// </summary>
        internal bool IsSetTimeline() => this.Timeline != null && (this.Timeline.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
