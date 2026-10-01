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

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Information about an entry in an event log of Amazon CodeCatalyst activity.
    /// </summary>
    public partial class EventLogEntry
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The code of the error, if any.
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property EventCategory. 
        /// <para>
        /// The category for the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EventCategory { get; set; }

        /// <summary>
        /// Checks to see if the EventCategory property is set.
        /// </summary>
        internal bool IsSetEventCategory() => this.EventCategory != null;

        /// <summary>
        /// Gets and sets the property EventName. 
        /// <para>
        /// The name of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EventName { get; set; }

        /// <summary>
        /// Checks to see if the EventName property is set.
        /// </summary>
        internal bool IsSetEventName() => this.EventName != null;

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        /// The source of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EventSource { get; set; }

        /// <summary>
        /// Checks to see if the EventSource property is set.
        /// </summary>
        internal bool IsSetEventSource() => this.EventSource != null;

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// The time the event took place, in coordinated universal time (UTC) timestamp format
        /// as specified in <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC 3339</a>.
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
        /// The type of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The system-generated unique ID of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The type of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OperationType OperationType { get; set; }

        /// <summary>
        /// Checks to see if the OperationType property is set.
        /// </summary>
        internal bool IsSetOperationType() => this.OperationType != null;

        /// <summary>
        /// Gets and sets the property ProjectInformation. 
        /// <para>
        /// Information about the project where the event occurred.
        /// </para>
        /// </summary>
        public ProjectInformation ProjectInformation { get; set; }

        /// <summary>
        /// Checks to see if the ProjectInformation property is set.
        /// </summary>
        internal bool IsSetProjectInformation() => this.ProjectInformation != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The system-generated unique ID of the request.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property RequestPayload. 
        /// <para>
        /// Information about the payload of the request.
        /// </para>
        /// </summary>
        public EventPayload RequestPayload { get; set; }

        /// <summary>
        /// Checks to see if the RequestPayload property is set.
        /// </summary>
        internal bool IsSetRequestPayload() => this.RequestPayload != null;

        /// <summary>
        /// Gets and sets the property ResponsePayload. 
        /// <para>
        /// Information about the payload of the response, if any.
        /// </para>
        /// </summary>
        public EventPayload ResponsePayload { get; set; }

        /// <summary>
        /// Checks to see if the ResponsePayload property is set.
        /// </summary>
        internal bool IsSetResponsePayload() => this.ResponsePayload != null;

        /// <summary>
        /// Gets and sets the property SourceIpAddress. 
        /// <para>
        /// The IP address of the user whose actions are recorded in the event.
        /// </para>
        /// </summary>
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the SourceIpAddress property is set.
        /// </summary>
        internal bool IsSetSourceIpAddress() => this.SourceIpAddress != null;

        /// <summary>
        /// Gets and sets the property UserAgent. 
        /// <para>
        /// The user agent whose actions are recorded in the event.
        /// </para>
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Checks to see if the UserAgent property is set.
        /// </summary>
        internal bool IsSetUserAgent() => this.UserAgent != null;

        /// <summary>
        /// Gets and sets the property UserIdentity. 
        /// <para>
        /// The system-generated unique ID of the user whose actions are recorded in the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UserIdentity UserIdentity { get; set; }

        /// <summary>
        /// Checks to see if the UserIdentity property is set.
        /// </summary>
        internal bool IsSetUserIdentity() => this.UserIdentity != null;
    }
}
