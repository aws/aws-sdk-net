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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
    /// A span represents a unit of work during AI agent execution, capturing timing, status,
    /// and contextual attributes.
    /// </summary>
    public partial class Span
    {
        private string _assistantId;
        private SpanAttributes _attributes;
        private DateTime? _endTimestamp;
        private string _parentSpanId;
        private string _requestId;
        private string _sessionId;
        private string _spanId;
        private string _spanName;
        private SpanType _spanType;
        private DateTime? _startTimestamp;
        private SpanStatus _status;

        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// UUID of the Connect AI Assistant resource
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssistantId
        {
            get { return this._assistantId; }
            set { this._assistantId = value; }
        }

        // Check to see if AssistantId property is set
        internal bool IsSetAssistantId()
        {
            return this._assistantId != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Span-specific contextual attributes
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SpanAttributes Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// Operation end time in milliseconds since epoch
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTimestamp
        {
            get { return this._endTimestamp; }
            set { this._endTimestamp = value; }
        }

        // Check to see if EndTimestamp property is set
        internal bool IsSetEndTimestamp()
        {
            return this._endTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParentSpanId. 
        /// <para>
        /// Parent span identifier for hierarchy. Null for root spans.
        /// </para>
        /// </summary>
        public string ParentSpanId
        {
            get { return this._parentSpanId; }
            set { this._parentSpanId = value; }
        }

        // Check to see if ParentSpanId property is set
        internal bool IsSetParentSpanId()
        {
            return this._parentSpanId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The service request ID that initiated the operation
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SessionId. 
        /// <para>
        /// UUID of the Connect AI Session resource
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property SpanId. 
        /// <para>
        /// Unique span identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SpanId
        {
            get { return this._spanId; }
            set { this._spanId = value; }
        }

        // Check to see if SpanId property is set
        internal bool IsSetSpanId()
        {
            return this._spanId != null;
        }

        /// <summary>
        /// Gets and sets the property SpanName. 
        /// <para>
        /// Service-defined operation name
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string SpanName
        {
            get { return this._spanName; }
            set { this._spanName = value; }
        }

        // Check to see if SpanName property is set
        internal bool IsSetSpanName()
        {
            return this._spanName != null;
        }

        /// <summary>
        /// Gets and sets the property SpanType. 
        /// <para>
        /// Operation relationship type
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SpanType SpanType
        {
            get { return this._spanType; }
            set { this._spanType = value; }
        }

        // Check to see if SpanType property is set
        internal bool IsSetSpanType()
        {
            return this._spanType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// Operation start time in milliseconds since epoch
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTimestamp
        {
            get { return this._startTimestamp; }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Span completion status
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SpanStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}