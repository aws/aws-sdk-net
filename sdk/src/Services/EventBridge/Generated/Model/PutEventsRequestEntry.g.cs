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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Represents an event to be submitted.
    /// </summary>
    public partial class PutEventsRequestEntry
    {
        /// <summary>
        /// Gets and sets the property Detail. 
        /// <para>
        /// A valid JSON object. There is no other schema imposed. The JSON object may contain
        /// fields and nested sub-objects.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Detail</c>, <c>DetailType</c>, and <c>Source</c> are required for EventBridge
        /// to successfully send an event to an event bus. If you include event entries in a request
        /// that do not include each of those properties, EventBridge fails that entry. If you
        /// submit a request in which <i>none</i> of the entries have each of these properties,
        /// EventBridge fails the entire request. 
        /// </para>
        ///  </note>
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// Checks to see if the Detail property is set.
        /// </summary>
        internal bool IsSetDetail() => this.Detail != null;

        /// <summary>
        /// Gets and sets the property DetailType. 
        /// <para>
        /// Free-form string, with a maximum of 128 characters, used to decide what fields to
        /// expect in the event detail.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Detail</c>, <c>DetailType</c>, and <c>Source</c> are required for EventBridge
        /// to successfully send an event to an event bus. If you include event entries in a request
        /// that do not include each of those properties, EventBridge fails that entry. If you
        /// submit a request in which <i>none</i> of the entries have each of these properties,
        /// EventBridge fails the entire request. 
        /// </para>
        ///  </note>
        /// </summary>
        public string DetailType { get; set; }

        /// <summary>
        /// Checks to see if the DetailType property is set.
        /// </summary>
        internal bool IsSetDetailType() => this.DetailType != null;

        /// <summary>
        /// Gets and sets the property EventBusName. 
        /// <para>
        /// The name or ARN of the event bus to receive the event. Only the rules that are associated
        /// with this event bus are used to match the event. If you omit this, the default event
        /// bus is used.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're using a global endpoint with a custom bus, you can enter either the name
        /// or Amazon Resource Name (ARN) of the event bus in either the primary or secondary
        /// Region here. EventBridge then determines the corresponding event bus in the other
        /// Region based on the endpoint referenced by the <c>EndpointId</c>. Specifying the event
        /// bus ARN is preferred.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string EventBusName { get; set; }

        /// <summary>
        /// Checks to see if the EventBusName property is set.
        /// </summary>
        internal bool IsSetEventBusName() => this.EventBusName != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// Amazon Web Services resources, identified by Amazon Resource Name (ARN), which the
        /// event primarily concerns. Any number, including zero, may be present.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the event.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Detail</c>, <c>DetailType</c>, and <c>Source</c> are required for EventBridge
        /// to successfully send an event to an event bus. If you include event entries in a request
        /// that do not include each of those properties, EventBridge fails that entry. If you
        /// submit a request in which <i>none</i> of the entries have each of these properties,
        /// EventBridge fails the entire request. 
        /// </para>
        ///  </note>
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The time stamp of the event, per <a href="https://www.rfc-editor.org/rfc/rfc3339.txt">RFC3339</a>.
        /// If no time stamp is provided, the time stamp of the <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_PutEvents.html">PutEvents</a>
        /// call is used.
        /// </para>
        /// </summary>
        public DateTime? Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time.HasValue;

        /// <summary>
        /// Gets and sets the property TraceHeader. 
        /// <para>
        /// An X-Ray trace header, which is an http header (X-Amzn-Trace-Id) that contains the
        /// trace-id associated with the event.
        /// </para>
        ///  
        /// <para>
        /// To learn more about X-Ray trace headers, see <a href="https://docs.aws.amazon.com/xray/latest/devguide/xray-concepts.html#xray-concepts-tracingheader">Tracing
        /// header</a> in the X-Ray Developer Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string TraceHeader { get; set; }

        /// <summary>
        /// Checks to see if the TraceHeader property is set.
        /// </summary>
        internal bool IsSetTraceHeader() => this.TraceHeader != null;
    }
}
