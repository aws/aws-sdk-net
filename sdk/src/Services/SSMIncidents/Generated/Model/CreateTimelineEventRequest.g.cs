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
    /// Container for the parameters to the CreateTimelineEvent operation. Creates a custom
    /// timeline event on the incident details page of an incident record. Incident Manager
    /// automatically creates timeline events that mark key moments during an incident. You
    /// can create custom timeline events to mark important events that Incident Manager can
    /// detect automatically.
    /// </summary>
    public partial class CreateTimelineEventRequest : AmazonSSMIncidentsRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures that a client calls the action only once with the specified details.
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
        [AWSProperty(Required = true, Max = 12000)]
        public string EventData { get; set; }

        /// <summary>
        /// Checks to see if the EventData property is set.
        /// </summary>
        internal bool IsSetEventData() => this.EventData != null;

        /// <summary>
        /// Gets and sets the property EventReferences. 
        /// <para>
        /// Adds one or more references to the <c>TimelineEvent</c>. A reference is an Amazon
        /// Web Services resource involved or associated with the incident. To specify a reference,
        /// enter its Amazon Resource Name (ARN). You can also specify a related item associated
        /// with a resource. For example, to specify an Amazon DynamoDB (DynamoDB) table as a
        /// resource, use the table's ARN. You can also specify an Amazon CloudWatch metric associated
        /// with the DynamoDB table as a related item.
        /// </para>
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
        [AWSProperty(Required = true)]
        public DateTime? EventTime { get; set; }

        /// <summary>
        /// Checks to see if the EventTime property is set.
        /// </summary>
        internal bool IsSetEventTime() => this.EventTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event. You can create timeline events of type <c>Custom Event</c> and
        /// <c>Note</c>.
        /// </para>
        ///  
        /// <para>
        /// To make a Note-type event appear on the <i>Incident notes</i> panel in the console,
        /// specify <c>eventType</c> as <c>Note</c>and enter the Amazon Resource Name (ARN) of
        /// the incident as the value for <c>eventReference</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property IncidentRecordArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident record that the action adds the incident
        /// to.
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
