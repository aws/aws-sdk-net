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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Information about an entry in an event log of Amazon CodeCatalyst activity.
    /// </summary>
    public partial class EventLogEntry
    {
        private string _errorCode;
        private string _eventCategory;
        private string _eventName;
        private string _eventSource;
        private DateTime? _eventTime;
        private string _eventType;
        private string _id;
        private OperationType _operationType;
        private ProjectInformation _projectInformation;
        private string _requestId;
        private EventPayload _requestPayload;
        private EventPayload _responsePayload;
        private string _sourceIpAddress;
        private string _userAgent;
        private UserIdentity _userIdentity;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The code of the error, if any.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property EventCategory. 
        /// <para>
        /// The category for the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventCategory
        {
            get { return this._eventCategory; }
            set { this._eventCategory = value; }
        }

        // Check to see if EventCategory property is set
        internal bool IsSetEventCategory()
        {
            return this._eventCategory != null;
        }

        /// <summary>
        /// Gets and sets the property EventName. 
        /// <para>
        /// The name of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventName
        {
            get { return this._eventName; }
            set { this._eventName = value; }
        }

        // Check to see if EventName property is set
        internal bool IsSetEventName()
        {
            return this._eventName != null;
        }

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        /// The source of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventSource
        {
            get { return this._eventSource; }
            set { this._eventSource = value; }
        }

        // Check to see if EventSource property is set
        internal bool IsSetEventSource()
        {
            return this._eventSource != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// The time the event took place, in coordinated universal time (UTC) timestamp format
        /// as specified in <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC 3339</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EventTime
        {
            get { return this._eventTime.GetValueOrDefault(); }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The system-generated unique ID of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The type of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OperationType OperationType
        {
            get { return this._operationType; }
            set { this._operationType = value; }
        }

        // Check to see if OperationType property is set
        internal bool IsSetOperationType()
        {
            return this._operationType != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectInformation. 
        /// <para>
        /// Information about the project where the event occurred.
        /// </para>
        /// </summary>
        public ProjectInformation ProjectInformation
        {
            get { return this._projectInformation; }
            set { this._projectInformation = value; }
        }

        // Check to see if ProjectInformation property is set
        internal bool IsSetProjectInformation()
        {
            return this._projectInformation != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The system-generated unique ID of the request.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestPayload. 
        /// <para>
        /// Information about the payload of the request.
        /// </para>
        /// </summary>
        public EventPayload RequestPayload
        {
            get { return this._requestPayload; }
            set { this._requestPayload = value; }
        }

        // Check to see if RequestPayload property is set
        internal bool IsSetRequestPayload()
        {
            return this._requestPayload != null;
        }

        /// <summary>
        /// Gets and sets the property ResponsePayload. 
        /// <para>
        /// Information about the payload of the response, if any.
        /// </para>
        /// </summary>
        public EventPayload ResponsePayload
        {
            get { return this._responsePayload; }
            set { this._responsePayload = value; }
        }

        // Check to see if ResponsePayload property is set
        internal bool IsSetResponsePayload()
        {
            return this._responsePayload != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIpAddress. 
        /// <para>
        /// The IP address of the user whose actions are recorded in the event.
        /// </para>
        /// </summary>
        public string SourceIpAddress
        {
            get { return this._sourceIpAddress; }
            set { this._sourceIpAddress = value; }
        }

        // Check to see if SourceIpAddress property is set
        internal bool IsSetSourceIpAddress()
        {
            return this._sourceIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property UserAgent.
        /// </summary>
        public string UserAgent
        {
            get { return this._userAgent; }
            set { this._userAgent = value; }
        }

        // Check to see if UserAgent property is set
        internal bool IsSetUserAgent()
        {
            return this._userAgent != null;
        }

        /// <summary>
        /// Gets and sets the property UserIdentity. 
        /// <para>
        /// The system-generated unique ID of the user whose actions are recorded in the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserIdentity UserIdentity
        {
            get { return this._userIdentity; }
            set { this._userIdentity = value; }
        }

        // Check to see if UserIdentity property is set
        internal bool IsSetUserIdentity()
        {
            return this._userIdentity != null;
        }

    }
}