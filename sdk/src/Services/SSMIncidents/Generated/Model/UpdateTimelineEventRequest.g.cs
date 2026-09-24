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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTimelineEvent operation. Updates a timeline
    /// event. You can update events of type <c>Custom Event</c>.
    /// </summary>
    public partial class UpdateTimelineEventRequest : AmazonSSMIncidentsRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures that a client calls the operation only once with the specified
        /// details.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EventData. 
        /// <para>
        /// A short description of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 12000)]
        public string EventData { get; set; }

        /// <summary>
        /// Checks to see if the EventData property is set.
        /// </summary>
        internal bool IsSetEventData() => this.EventData != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The ID of the event to update. You can use <c>ListTimelineEvents</c> to find an event's
        /// ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 50)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventReferences. 
        /// <para>
        /// Updates all existing references in a <c>TimelineEvent</c>. A reference is an Amazon
        /// Web Services resource involved or associated with the incident. To specify a reference,
        /// enter its Amazon Resource Name (ARN). You can also specify a related item associated
        /// with that resource. For example, to specify an Amazon DynamoDB (DynamoDB) table as
        /// a resource, use its ARN. You can also specify an Amazon CloudWatch metric associated
        /// with the DynamoDB table as a related item.
        /// </para>
        ///  <important> 
        /// <para>
        /// This update action overrides all existing references. If you want to keep existing
        /// references, you must specify them in the call. If you don't, this action removes any
        /// existing references and enters only new references.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<EventReference> EventReferences { get; set; } = AWSConfigs.InitializeCollections ? new List<EventReference>() : null;

        /// <summary>
        /// Checks to see if the EventReferences property is set.
        /// </summary>
        internal bool IsSetEventReferences() => this.EventReferences != null && (this.EventReferences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// The timestamp for when the event occurred.
        /// </para>
        /// </summary>
        public DateTime? EventTime { get; set; }

        /// <summary>
        /// Checks to see if the EventTime property is set.
        /// </summary>
        internal bool IsSetEventTime() => this.EventTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event. You can update events of type <c>Custom Event</c> and <c>Note</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public string EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property IncidentRecordArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident that includes the timeline event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string IncidentRecordArn { get; set; }

        /// <summary>
        /// Checks to see if the IncidentRecordArn property is set.
        /// </summary>
        internal bool IsSetIncidentRecordArn() => this.IncidentRecordArn != null;
    }
}
