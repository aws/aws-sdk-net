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
    /// A span represents a unit of work during AI agent execution, capturing timing, status,
    /// and contextual attributes.
    /// </summary>
    public partial class Span
    {
        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// UUID of the Connect AI Assistant resource
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssistantId { get; set; }

        /// <summary>
        /// Checks to see if the AssistantId property is set.
        /// </summary>
        internal bool IsSetAssistantId() => this.AssistantId != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Span-specific contextual attributes
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SpanAttributes Attributes { get; set; }

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null;

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// Operation end time in milliseconds since epoch
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EndTimestamp property is set.
        /// </summary>
        internal bool IsSetEndTimestamp() => this.EndTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property OriginRequestId. 
        /// <para>
        /// The origin request identifier for end-to-end tracing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OriginRequestId { get; set; }

        /// <summary>
        /// Checks to see if the OriginRequestId property is set.
        /// </summary>
        internal bool IsSetOriginRequestId() => this.OriginRequestId != null;

        /// <summary>
        /// Gets and sets the property ParentSpanId. 
        /// <para>
        /// Parent span identifier for hierarchy. Null for root spans.
        /// </para>
        /// </summary>
        public string ParentSpanId { get; set; }

        /// <summary>
        /// Checks to see if the ParentSpanId property is set.
        /// </summary>
        internal bool IsSetParentSpanId() => this.ParentSpanId != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The service request ID that initiated the operation
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// UUID of the Connect AI Session resource
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SpanId. 
        /// <para>
        /// Unique span identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SpanId { get; set; }

        /// <summary>
        /// Checks to see if the SpanId property is set.
        /// </summary>
        internal bool IsSetSpanId() => this.SpanId != null;

        /// <summary>
        /// Gets and sets the property SpanName. 
        /// <para>
        /// Service-defined operation name
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string SpanName { get; set; }

        /// <summary>
        /// Checks to see if the SpanName property is set.
        /// </summary>
        internal bool IsSetSpanName() => this.SpanName != null;

        /// <summary>
        /// Gets and sets the property SpanType. 
        /// <para>
        /// Operation relationship type
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SpanType SpanType { get; set; }

        /// <summary>
        /// Checks to see if the SpanType property is set.
        /// </summary>
        internal bool IsSetSpanType() => this.SpanType != null;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// Operation start time in milliseconds since epoch
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Span completion status
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SpanStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDescription. 
        /// <para>
        /// Human-readable error description when status is ERROR or TIMEOUT
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Checks to see if the StatusDescription property is set.
        /// </summary>
        internal bool IsSetStatusDescription() => this.StatusDescription != null;
    }
}
