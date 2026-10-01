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
    /// This is the response object from the UpdateEventTrigger operation.
    /// </summary>
    public partial class UpdateEventTriggerResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the event trigger was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the event trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventTriggerConditions. 
        /// <para>
        /// A list of conditions that determine when an event should trigger the destination.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 5)]
        public List<EventTriggerCondition> EventTriggerConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<EventTriggerCondition>() : null;

        /// <summary>
        /// Checks to see if the EventTriggerConditions property is set.
        /// </summary>
        internal bool IsSetEventTriggerConditions() => this.EventTriggerConditions != null && (this.EventTriggerConditions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventTriggerLimits. 
        /// <para>
        /// Defines limits controlling whether an event triggers the destination, based on ingestion
        /// latency and the number of invocations per profile over specific time periods.
        /// </para>
        /// </summary>
        public EventTriggerLimits EventTriggerLimits { get; set; }

        /// <summary>
        /// Checks to see if the EventTriggerLimits property is set.
        /// </summary>
        internal bool IsSetEventTriggerLimits() => this.EventTriggerLimits != null;

        /// <summary>
        /// Gets and sets the property EventTriggerName. 
        /// <para>
        /// The unique name of the event trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EventTriggerName { get; set; }

        /// <summary>
        /// Checks to see if the EventTriggerName property is set.
        /// </summary>
        internal bool IsSetEventTriggerName() => this.EventTriggerName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp of when the event trigger was most recently updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectTypeName. 
        /// <para>
        /// The unique name of the object type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ObjectTypeName { get; set; }

        /// <summary>
        /// Checks to see if the ObjectTypeName property is set.
        /// </summary>
        internal bool IsSetObjectTypeName() => this.ObjectTypeName != null;

        /// <summary>
        /// Gets and sets the property SegmentFilter. 
        /// <para>
        /// The destination is triggered only for profiles that meet the criteria of a segment
        /// definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SegmentFilter { get; set; }

        /// <summary>
        /// Checks to see if the SegmentFilter property is set.
        /// </summary>
        internal bool IsSetSegmentFilter() => this.SegmentFilter != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs to apply to this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
